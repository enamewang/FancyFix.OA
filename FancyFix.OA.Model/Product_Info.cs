﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//     Website: http://ITdos.com/Dos/ORM/Index.html
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Data;
using System.Data.Common;
using Dos.ORM;
using Dos.ORM.Common;

namespace FancyFix.OA.Model
{

	/// <summary>
	/// 实体类Product_Info 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("Product_Info")]
	[Serializable]
	public partial class Product_Info : Entity 
	{
		#region Model
		private int _Id;
		private int? _ClassId_1;
		private int? _ClassId_2;
		private int _ClassId;
		private string _ClassParPath;
		private string _Title;
		private string _Spu;
		private string _FirstPic;
		private string _Pics;
		private string _Description;
		private string _Content;
		private string _Attribute;
		private string _AttributeCustom;
		private int? _Stock;
		private string _QuantityUnit;
		private int? _Moq;
		private string _MoqUnit;
		private string _Currency;
		private decimal? _Price;
		private decimal? _TaxPrice;
		private string _PriceUnit;
		private bool? _IsShow;
		private string _Url;
		private int? _AdminId;
		private DateTime _CreateDate;
		private DateTime? _UpdateDate;
		private int? _PatternId;
		private string _Pattern;
		private string _Thickness;
		private string _Specification;
		private string _Color;
		private string _Weight;
		private string _Cost;
		private string _Regulation;
		private string _Features;
		private string _HS_Code;
		private int? _SupplierId;
		private string _InvoiceName;
		private string _Attachment;
		private string _Videos;
		private string _SupplierName;
		private string _SupplierProductCode;
		private string _PriceRemark;
		private string _AIFile;
		private string _Title_En;
		private string _Old_Spu;
		/// <summary>
		/// 自增Id
		/// </summary>
		public int Id
		{
			get{ return _Id; }
			set
			{
				this.OnPropertyValueChange(_.Id,_Id,value);
				this._Id=value;
			}
		}
		/// <summary>
		/// 一级分类Id
		/// </summary>
		public int? ClassId_1
		{
			get{ return _ClassId_1; }
			set
			{
				this.OnPropertyValueChange(_.ClassId_1,_ClassId_1,value);
				this._ClassId_1=value;
			}
		}
		/// <summary>
		/// 二级分类Id
		/// </summary>
		public int? ClassId_2
		{
			get{ return _ClassId_2; }
			set
			{
				this.OnPropertyValueChange(_.ClassId_2,_ClassId_2,value);
				this._ClassId_2=value;
			}
		}
		/// <summary>
		/// 分类Id
		/// </summary>
		public int ClassId
		{
			get{ return _ClassId; }
			set
			{
				this.OnPropertyValueChange(_.ClassId,_ClassId,value);
				this._ClassId=value;
			}
		}
		/// <summary>
		/// 分类路径
		/// </summary>
		public string ClassParPath
		{
			get{ return _ClassParPath; }
			set
			{
				this.OnPropertyValueChange(_.ClassParPath,_ClassParPath,value);
				this._ClassParPath=value;
			}
		}
		/// <summary>
		/// 标题
		/// </summary>
		public string Title
		{
			get{ return _Title; }
			set
			{
				this.OnPropertyValueChange(_.Title,_Title,value);
				this._Title=value;
			}
		}
		/// <summary>
		/// SPU编号
		/// </summary>
		public string Spu
		{
			get{ return _Spu; }
			set
			{
				this.OnPropertyValueChange(_.Spu,_Spu,value);
				this._Spu=value;
			}
		}
		/// <summary>
		/// 封面图
		/// </summary>
		public string FirstPic
		{
			get{ return _FirstPic; }
			set
			{
				this.OnPropertyValueChange(_.FirstPic,_FirstPic,value);
				this._FirstPic=value;
			}
		}
		/// <summary>
		/// 图片
		/// </summary>
		public string Pics
		{
			get{ return _Pics; }
			set
			{
				this.OnPropertyValueChange(_.Pics,_Pics,value);
				this._Pics=value;
			}
		}
		/// <summary>
		/// 描述
		/// </summary>
		public string Description
		{
			get{ return _Description; }
			set
			{
				this.OnPropertyValueChange(_.Description,_Description,value);
				this._Description=value;
			}
		}
		/// <summary>
		/// 详细内容
		/// </summary>
		public string Content
		{
			get{ return _Content; }
			set
			{
				this.OnPropertyValueChange(_.Content,_Content,value);
				this._Content=value;
			}
		}
		/// <summary>
		/// 属性JSON
		/// </summary>
		public string Attribute
		{
			get{ return _Attribute; }
			set
			{
				this.OnPropertyValueChange(_.Attribute,_Attribute,value);
				this._Attribute=value;
			}
		}
		/// <summary>
		/// 自定义属性JSON
		/// </summary>
		public string AttributeCustom
		{
			get{ return _AttributeCustom; }
			set
			{
				this.OnPropertyValueChange(_.AttributeCustom,_AttributeCustom,value);
				this._AttributeCustom=value;
			}
		}
		/// <summary>
		/// 库存
		/// </summary>
		public int? Stock
		{
			get{ return _Stock; }
			set
			{
				this.OnPropertyValueChange(_.Stock,_Stock,value);
				this._Stock=value;
			}
		}
		/// <summary>
		/// 产品计量单位
		/// </summary>
		public string QuantityUnit
		{
			get{ return _QuantityUnit; }
			set
			{
				this.OnPropertyValueChange(_.QuantityUnit,_QuantityUnit,value);
				this._QuantityUnit=value;
			}
		}
		/// <summary>
		/// 最小起订量
		/// </summary>
		public int? Moq
		{
			get{ return _Moq; }
			set
			{
				this.OnPropertyValueChange(_.Moq,_Moq,value);
				this._Moq=value;
			}
		}
		/// <summary>
		/// 最小起订量单位
		/// </summary>
		public string MoqUnit
		{
			get{ return _MoqUnit; }
			set
			{
				this.OnPropertyValueChange(_.MoqUnit,_MoqUnit,value);
				this._MoqUnit=value;
			}
		}
		/// <summary>
		/// 货币单位
		/// </summary>
		public string Currency
		{
			get{ return _Currency; }
			set
			{
				this.OnPropertyValueChange(_.Currency,_Currency,value);
				this._Currency=value;
			}
		}
		/// <summary>
		/// 不含税价
		/// </summary>
		public decimal? Price
		{
			get{ return _Price; }
			set
			{
				this.OnPropertyValueChange(_.Price,_Price,value);
				this._Price=value;
			}
		}
		/// <summary>
		/// 含税价
		/// </summary>
		public decimal? TaxPrice
		{
			get{ return _TaxPrice; }
			set
			{
				this.OnPropertyValueChange(_.TaxPrice,_TaxPrice,value);
				this._TaxPrice=value;
			}
		}
		/// <summary>
		/// 价格单位
		/// </summary>
		public string PriceUnit
		{
			get{ return _PriceUnit; }
			set
			{
				this.OnPropertyValueChange(_.PriceUnit,_PriceUnit,value);
				this._PriceUnit=value;
			}
		}
		/// <summary>
		/// 是否上架
		/// </summary>
		public bool? IsShow
		{
			get{ return _IsShow; }
			set
			{
				this.OnPropertyValueChange(_.IsShow,_IsShow,value);
				this._IsShow=value;
			}
		}
		/// <summary>
		/// Url
		/// </summary>
		public string Url
		{
			get{ return _Url; }
			set
			{
				this.OnPropertyValueChange(_.Url,_Url,value);
				this._Url=value;
			}
		}
		/// <summary>
		/// 管理员Id
		/// </summary>
		public int? AdminId
		{
			get{ return _AdminId; }
			set
			{
				this.OnPropertyValueChange(_.AdminId,_AdminId,value);
				this._AdminId=value;
			}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime CreateDate
		{
			get{ return _CreateDate; }
			set
			{
				this.OnPropertyValueChange(_.CreateDate,_CreateDate,value);
				this._CreateDate=value;
			}
		}
		/// <summary>
		/// 更新时间
		/// </summary>
		public DateTime? UpdateDate
		{
			get{ return _UpdateDate; }
			set
			{
				this.OnPropertyValueChange(_.UpdateDate,_UpdateDate,value);
				this._UpdateDate=value;
			}
		}
		/// <summary>
		/// 图案Id
		/// </summary>
		public int? PatternId
		{
			get{ return _PatternId; }
			set
			{
				this.OnPropertyValueChange(_.PatternId,_PatternId,value);
				this._PatternId=value;
			}
		}
		/// <summary>
		/// 图案
		/// </summary>
		public string Pattern
		{
			get{ return _Pattern; }
			set
			{
				this.OnPropertyValueChange(_.Pattern,_Pattern,value);
				this._Pattern=value;
			}
		}
		/// <summary>
		/// 厚度
		/// </summary>
		public string Thickness
		{
			get{ return _Thickness; }
			set
			{
				this.OnPropertyValueChange(_.Thickness,_Thickness,value);
				this._Thickness=value;
			}
		}
		/// <summary>
		/// 规格
		/// </summary>
		public string Specification
		{
			get{ return _Specification; }
			set
			{
				this.OnPropertyValueChange(_.Specification,_Specification,value);
				this._Specification=value;
			}
		}
		/// <summary>
		/// 颜色
		/// </summary>
		public string Color
		{
			get{ return _Color; }
			set
			{
				this.OnPropertyValueChange(_.Color,_Color,value);
				this._Color=value;
			}
		}
		/// <summary>
		/// 重量
		/// </summary>
		public string Weight
		{
			get{ return _Weight; }
			set
			{
				this.OnPropertyValueChange(_.Weight,_Weight,value);
				this._Weight=value;
			}
		}
		/// <summary>
		/// 成本
		/// </summary>
		public string Cost
		{
			get{ return _Cost; }
			set
			{
				this.OnPropertyValueChange(_.Cost,_Cost,value);
				this._Cost=value;
			}
		}
		/// <summary>
		/// 适用法律法规
		/// </summary>
		public string Regulation
		{
			get{ return _Regulation; }
			set
			{
				this.OnPropertyValueChange(_.Regulation,_Regulation,value);
				this._Regulation=value;
			}
		}
		/// <summary>
		/// 产品特性
		/// </summary>
		public string Features
		{
			get{ return _Features; }
			set
			{
				this.OnPropertyValueChange(_.Features,_Features,value);
				this._Features=value;
			}
		}
		/// <summary>
		/// HS编码
		/// </summary>
		public string HS_Code
		{
			get{ return _HS_Code; }
			set
			{
				this.OnPropertyValueChange(_.HS_Code,_HS_Code,value);
				this._HS_Code=value;
			}
		}
		/// <summary>
		/// 供应商Id
		/// </summary>
		public int? SupplierId
		{
			get{ return _SupplierId; }
			set
			{
				this.OnPropertyValueChange(_.SupplierId,_SupplierId,value);
				this._SupplierId=value;
			}
		}
		/// <summary>
		/// 开票品名
		/// </summary>
		public string InvoiceName
		{
			get{ return _InvoiceName; }
			set
			{
				this.OnPropertyValueChange(_.InvoiceName,_InvoiceName,value);
				this._InvoiceName=value;
			}
		}
		/// <summary>
		/// 附件
		/// </summary>
		public string Attachment
		{
			get{ return _Attachment; }
			set
			{
				this.OnPropertyValueChange(_.Attachment,_Attachment,value);
				this._Attachment=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Videos
		{
			get{ return _Videos; }
			set
			{
				this.OnPropertyValueChange(_.Videos,_Videos,value);
				this._Videos=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SupplierName
		{
			get{ return _SupplierName; }
			set
			{
				this.OnPropertyValueChange(_.SupplierName,_SupplierName,value);
				this._SupplierName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SupplierProductCode
		{
			get{ return _SupplierProductCode; }
			set
			{
				this.OnPropertyValueChange(_.SupplierProductCode,_SupplierProductCode,value);
				this._SupplierProductCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PriceRemark
		{
			get{ return _PriceRemark; }
			set
			{
				this.OnPropertyValueChange(_.PriceRemark,_PriceRemark,value);
				this._PriceRemark=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AIFile
		{
			get{ return _AIFile; }
			set
			{
				this.OnPropertyValueChange(_.AIFile,_AIFile,value);
				this._AIFile=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Title_En
		{
			get{ return _Title_En; }
			set
			{
				this.OnPropertyValueChange(_.Title_En,_Title_En,value);
				this._Title_En=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Old_Spu
		{
			get{ return _Old_Spu; }
			set
			{
				this.OnPropertyValueChange(_.Old_Spu,_Old_Spu,value);
				this._Old_Spu=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.Id;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.Id};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.Id,
				_.ClassId_1,
				_.ClassId_2,
				_.ClassId,
				_.ClassParPath,
				_.Title,
				_.Spu,
				_.FirstPic,
				_.Pics,
				_.Description,
				_.Content,
				_.Attribute,
				_.AttributeCustom,
				_.Stock,
				_.QuantityUnit,
				_.Moq,
				_.MoqUnit,
				_.Currency,
				_.Price,
				_.TaxPrice,
				_.PriceUnit,
				_.IsShow,
				_.Url,
				_.AdminId,
				_.CreateDate,
				_.UpdateDate,
				_.PatternId,
				_.Pattern,
				_.Thickness,
				_.Specification,
				_.Color,
				_.Weight,
				_.Cost,
				_.Regulation,
				_.Features,
				_.HS_Code,
				_.SupplierId,
				_.InvoiceName,
				_.Attachment,
				_.Videos,
				_.SupplierName,
				_.SupplierProductCode,
				_.PriceRemark,
				_.AIFile,
				_.Title_En,
				_.Old_Spu};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Id,
				this._ClassId_1,
				this._ClassId_2,
				this._ClassId,
				this._ClassParPath,
				this._Title,
				this._Spu,
				this._FirstPic,
				this._Pics,
				this._Description,
				this._Content,
				this._Attribute,
				this._AttributeCustom,
				this._Stock,
				this._QuantityUnit,
				this._Moq,
				this._MoqUnit,
				this._Currency,
				this._Price,
				this._TaxPrice,
				this._PriceUnit,
				this._IsShow,
				this._Url,
				this._AdminId,
				this._CreateDate,
				this._UpdateDate,
				this._PatternId,
				this._Pattern,
				this._Thickness,
				this._Specification,
				this._Color,
				this._Weight,
				this._Cost,
				this._Regulation,
				this._Features,
				this._HS_Code,
				this._SupplierId,
				this._InvoiceName,
				this._Attachment,
				this._Videos,
				this._SupplierName,
				this._SupplierProductCode,
				this._PriceRemark,
				this._AIFile,
				this._Title_En,
				this._Old_Spu};
		}
		#endregion

		#region _Field
		/// <summary>
		/// 字段信息
		/// </summary>
		public class _
		{
			/// <summary>
			/// * 
			/// </summary>
			public readonly static Field All = new Field("*","Product_Info");
			/// <summary>
			/// 自增Id
			/// </summary>
			public readonly static Field Id = new Field("Id","Product_Info","自增Id");
			/// <summary>
			/// 一级分类Id
			/// </summary>
			public readonly static Field ClassId_1 = new Field("ClassId_1","Product_Info","一级分类Id");
			/// <summary>
			/// 二级分类Id
			/// </summary>
			public readonly static Field ClassId_2 = new Field("ClassId_2","Product_Info","二级分类Id");
			/// <summary>
			/// 分类Id
			/// </summary>
			public readonly static Field ClassId = new Field("ClassId","Product_Info","分类Id");
			/// <summary>
			/// 分类路径
			/// </summary>
			public readonly static Field ClassParPath = new Field("ClassParPath","Product_Info","分类路径");
			/// <summary>
			/// 标题
			/// </summary>
			public readonly static Field Title = new Field("Title","Product_Info","标题");
			/// <summary>
			/// SPU编号
			/// </summary>
			public readonly static Field Spu = new Field("Spu","Product_Info","SPU编号");
			/// <summary>
			/// 封面图
			/// </summary>
			public readonly static Field FirstPic = new Field("FirstPic","Product_Info","封面图");
			/// <summary>
			/// 图片
			/// </summary>
			public readonly static Field Pics = new Field("Pics","Product_Info","图片");
			/// <summary>
			/// 描述
			/// </summary>
			public readonly static Field Description = new Field("Description","Product_Info","描述");
			/// <summary>
			/// 详细内容
			/// </summary>
			public readonly static Field Content = new Field("Content","Product_Info","详细内容");
			/// <summary>
			/// 属性JSON
			/// </summary>
			public readonly static Field Attribute = new Field("Attribute","Product_Info","属性JSON");
			/// <summary>
			/// 自定义属性JSON
			/// </summary>
			public readonly static Field AttributeCustom = new Field("AttributeCustom","Product_Info","自定义属性JSON");
			/// <summary>
			/// 库存
			/// </summary>
			public readonly static Field Stock = new Field("Stock","Product_Info","库存");
			/// <summary>
			/// 产品计量单位
			/// </summary>
			public readonly static Field QuantityUnit = new Field("QuantityUnit","Product_Info","产品计量单位");
			/// <summary>
			/// 最小起订量
			/// </summary>
			public readonly static Field Moq = new Field("Moq","Product_Info","最小起订量");
			/// <summary>
			/// 最小起订量单位
			/// </summary>
			public readonly static Field MoqUnit = new Field("MoqUnit","Product_Info","最小起订量单位");
			/// <summary>
			/// 货币单位
			/// </summary>
			public readonly static Field Currency = new Field("Currency","Product_Info","货币单位");
			/// <summary>
			/// 不含税价
			/// </summary>
			public readonly static Field Price = new Field("Price","Product_Info","不含税价");
			/// <summary>
			/// 含税价
			/// </summary>
			public readonly static Field TaxPrice = new Field("TaxPrice","Product_Info","含税价");
			/// <summary>
			/// 价格单位
			/// </summary>
			public readonly static Field PriceUnit = new Field("PriceUnit","Product_Info","价格单位");
			/// <summary>
			/// 是否上架
			/// </summary>
			public readonly static Field IsShow = new Field("IsShow","Product_Info","是否上架");
			/// <summary>
			/// Url
			/// </summary>
			public readonly static Field Url = new Field("Url","Product_Info","Url");
			/// <summary>
			/// 管理员Id
			/// </summary>
			public readonly static Field AdminId = new Field("AdminId","Product_Info","管理员Id");
			/// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CreateDate = new Field("CreateDate","Product_Info","创建时间");
			/// <summary>
			/// 更新时间
			/// </summary>
			public readonly static Field UpdateDate = new Field("UpdateDate","Product_Info","更新时间");
			/// <summary>
			/// 图案Id
			/// </summary>
			public readonly static Field PatternId = new Field("PatternId","Product_Info","图案Id");
			/// <summary>
			/// 图案
			/// </summary>
			public readonly static Field Pattern = new Field("Pattern","Product_Info","图案");
			/// <summary>
			/// 厚度
			/// </summary>
			public readonly static Field Thickness = new Field("Thickness","Product_Info","厚度");
			/// <summary>
			/// 规格
			/// </summary>
			public readonly static Field Specification = new Field("Specification","Product_Info","规格");
			/// <summary>
			/// 颜色
			/// </summary>
			public readonly static Field Color = new Field("Color","Product_Info","颜色");
			/// <summary>
			/// 重量
			/// </summary>
			public readonly static Field Weight = new Field("Weight","Product_Info","重量");
			/// <summary>
			/// 成本
			/// </summary>
			public readonly static Field Cost = new Field("Cost","Product_Info","成本");
			/// <summary>
			/// 适用法律法规
			/// </summary>
			public readonly static Field Regulation = new Field("Regulation","Product_Info","适用法律法规");
			/// <summary>
			/// 产品特性
			/// </summary>
			public readonly static Field Features = new Field("Features","Product_Info","产品特性");
			/// <summary>
			/// HS编码
			/// </summary>
			public readonly static Field HS_Code = new Field("HS_Code","Product_Info","HS编码");
			/// <summary>
			/// 供应商Id
			/// </summary>
			public readonly static Field SupplierId = new Field("SupplierId","Product_Info","供应商Id");
			/// <summary>
			/// 开票品名
			/// </summary>
			public readonly static Field InvoiceName = new Field("InvoiceName","Product_Info","开票品名");
			/// <summary>
			/// 附件
			/// </summary>
			public readonly static Field Attachment = new Field("Attachment","Product_Info","附件");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Videos = new Field("Videos","Product_Info","Videos");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SupplierName = new Field("SupplierName","Product_Info","SupplierName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SupplierProductCode = new Field("SupplierProductCode","Product_Info","SupplierProductCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PriceRemark = new Field("PriceRemark","Product_Info","PriceRemark");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AIFile = new Field("AIFile","Product_Info","AIFile");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Title_En = new Field("Title_En","Product_Info","Title_En");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Old_Spu = new Field("Old_Spu","Product_Info","Old_Spu");
		}
		#endregion


	}
}

