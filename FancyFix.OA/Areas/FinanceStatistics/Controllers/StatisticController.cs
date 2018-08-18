﻿using FancyFix.OA.Base;
using FancyFix.OA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FancyFix.OA.Areas.FinanceStatistics.Controllers
{
    /// <summary>
    /// 财务统计
    /// </summary>
    /// <returns></returns>
    public class StatisticController : BaseAdminController
    {
        #region 加载数据
        public ActionResult List()
        {
            return View();
        }

        public JsonResult PageList(int page = 0, int pagesize = 0, DateTime? startdate = null, DateTime? enddate = null)
        {
            long records = 0;
            //Sql注入检测
            string files = Tools.Usual.Utils.CheckSqlKeyword(RequestString("files"));
            string key = Tools.Usual.Utils.CheckSqlKeyword(RequestString("key")).Trim();
            var list = Bll.BllFinance_Statistics.PageList(page, pagesize, out records, files, key, startdate,enddate);
            return BspTableJson(list, records);
        }
        #endregion


        #region 编辑
        public ActionResult Save(int id = 0)
        {
            Finance_Statistics model = null;
            if (id > 0)
            {
                model = Bll.BllFinance_Statistics.First(o => o.Id == id && o.Display != 2);
                if (model == null)
                    return LayerAlertSuccessAndRefresh("加载数据失败，未找到该数据");
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult Save(Finance_Statistics statistics)
        {
            //关键字段不能为空
            if (statistics.SaleDate == null ||
                string.IsNullOrWhiteSpace(statistics.DepartmentName))
            {
                return LayerMsgErrorAndReturn("销售日期或部门不能为空！");
            }

            //数据是否重复
            Finance_Statistics model = Bll.BllFinance_Statistics.First(o => o.Id != statistics.Id &&
                                                                                o.SaleDate == statistics.SaleDate &&
                                                                                o.DepartmentName == statistics.DepartmentName &&
                                                                                o.Display != 2);
            if (model != null)
                return LayerMsgErrorAndReturn("添加数据失败，该条数据已存在，请确认后重新提交！");

            if (statistics.Id < 1)
                model = new Finance_Statistics();
            else
                model = Bll.BllFinance_Statistics.First(o => o.Id == statistics.Id && o.Display != 2) ?? new Finance_Statistics();

            model.Year = statistics.SaleDate.GetValueOrDefault().Year;
            model.Month = statistics.SaleDate.GetValueOrDefault().Month;
            model.Day = statistics.SaleDate.GetValueOrDefault().Day;
            model.SaleDate = statistics.SaleDate;
            model.DepartmentName = statistics.DepartmentName;
            model.BusinessIncome = statistics.BusinessIncome;
            model.BudgetaryValue = statistics.BudgetaryValue;
            model.BusinessIncomeRate = GetBusinessRate(model.BusinessIncome, model.BudgetaryValue);
            model.ActualReceipts = statistics.ActualReceipts;
            model.ActualDeliveryOrderNumber = statistics.ActualDeliveryOrderNumber;
            model.PlanDeliveryOrderNumber = statistics.PlanDeliveryOrderNumber;
            model.DeliveryPunctualityRate = GetBusinessRate(model.ActualDeliveryOrderNumber, model.PlanDeliveryOrderNumber);

            model.LastDate = DateTime.Now;
            model.LastUserId = MyInfo.Id;

            bool isok = false;
            //没有ID就新增，反之修改
            if (model.Id < 1)
            {
                model.AddDate = model.LastDate;
                model.AddUserId = model.LastUserId;
                model.Display = 1;

                isok = Bll.BllFinance_Statistics.Insert(model) > 0;
            }
            else
                isok = Bll.BllFinance_Statistics.Update(model) > 0;

            return LayerMsgSuccessAndRefresh("保存" + (isok ? "成功" : "失败"));
        }

        private decimal? GetBusinessRate(decimal? dividend, decimal? divisor)
        {
            if (dividend != null && divisor != null)
                return ((dividend / divisor) * 100).GetValueOrDefault().ToString("f2").ToDecimal();
            else if (divisor == null)
                return null;
            else
                return 0;
        }
        #endregion

        #region 删除
        [HttpPost]
        public JsonResult Delete(int id)
        {
            return Json(new { result = Bll.BllFinance_Statistics.Delete(id, MyInfo.Id) > 0 });
        }

        [HttpPost]
        public JsonResult DeleteBatch(List<Finance_Statistics> list)
        {
            if (list == null || !list.Any()) return Json(new { result = false });
            return Json(new { result = Bll.BllFinance_Statistics.DeleteList(list, MyInfo.Id) > 0 });
        }
        #endregion
    }
}