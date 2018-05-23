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
	/// 实体类Order_BatchProduct 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("Order_BatchProduct")]
	[Serializable]
	public partial class Order_BatchProduct : Entity 
	{
		#region Model
		private int _Id;
		private int? _ContractId;
		private int? _BatchId;
		private string _Name;
		private decimal? _UnitValue;
		private int? _Quantity;
		private decimal? _TotalCost;
		private DateTime? _AddTime;
		private int? _AdminId;
		private string _Unit;
		private decimal? _UnitPerCost;
		private decimal? _Cost;
		/// <summary>
		/// 
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
		/// 
		/// </summary>
		public int? ContractId
		{
			get{ return _ContractId; }
			set
			{
				this.OnPropertyValueChange(_.ContractId,_ContractId,value);
				this._ContractId=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? BatchId
		{
			get{ return _BatchId; }
			set
			{
				this.OnPropertyValueChange(_.BatchId,_BatchId,value);
				this._BatchId=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			get{ return _Name; }
			set
			{
				this.OnPropertyValueChange(_.Name,_Name,value);
				this._Name=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? UnitValue
		{
			get{ return _UnitValue; }
			set
			{
				this.OnPropertyValueChange(_.UnitValue,_UnitValue,value);
				this._UnitValue=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Quantity
		{
			get{ return _Quantity; }
			set
			{
				this.OnPropertyValueChange(_.Quantity,_Quantity,value);
				this._Quantity=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TotalCost
		{
			get{ return _TotalCost; }
			set
			{
				this.OnPropertyValueChange(_.TotalCost,_TotalCost,value);
				this._TotalCost=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? AddTime
		{
			get{ return _AddTime; }
			set
			{
				this.OnPropertyValueChange(_.AddTime,_AddTime,value);
				this._AddTime=value;
			}
		}
		/// <summary>
		/// 
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
		/// 
		/// </summary>
		public string Unit
		{
			get{ return _Unit; }
			set
			{
				this.OnPropertyValueChange(_.Unit,_Unit,value);
				this._Unit=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? UnitPerCost
		{
			get{ return _UnitPerCost; }
			set
			{
				this.OnPropertyValueChange(_.UnitPerCost,_UnitPerCost,value);
				this._UnitPerCost=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Cost
		{
			get{ return _Cost; }
			set
			{
				this.OnPropertyValueChange(_.Cost,_Cost,value);
				this._Cost=value;
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
				_.ContractId,
				_.BatchId,
				_.Name,
				_.UnitValue,
				_.Quantity,
				_.TotalCost,
				_.AddTime,
				_.AdminId,
				_.Unit,
				_.UnitPerCost,
				_.Cost};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Id,
				this._ContractId,
				this._BatchId,
				this._Name,
				this._UnitValue,
				this._Quantity,
				this._TotalCost,
				this._AddTime,
				this._AdminId,
				this._Unit,
				this._UnitPerCost,
				this._Cost};
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
			public readonly static Field All = new Field("*","Order_BatchProduct");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("Id","Order_BatchProduct","Id");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ContractId = new Field("ContractId","Order_BatchProduct","ContractId");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BatchId = new Field("BatchId","Order_BatchProduct","BatchId");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Name = new Field("Name","Order_BatchProduct","Name");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UnitValue = new Field("UnitValue","Order_BatchProduct","UnitValue");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Quantity = new Field("Quantity","Order_BatchProduct","Quantity");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TotalCost = new Field("TotalCost","Order_BatchProduct","TotalCost");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AddTime = new Field("AddTime","Order_BatchProduct","AddTime");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AdminId = new Field("AdminId","Order_BatchProduct","AdminId");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Unit = new Field("Unit","Order_BatchProduct","Unit");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UnitPerCost = new Field("UnitPerCost","Order_BatchProduct","UnitPerCost");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Cost = new Field("Cost","Order_BatchProduct","Cost");
		}
		#endregion


	}
}

