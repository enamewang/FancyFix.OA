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
	/// 实体类Kpi_Process 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("Kpi_Process")]
	[Serializable]
	public partial class Kpi_Process : Entity 
	{
		#region Model
		private int _Id;
		private int? _UserId;
		private decimal? _Score;
		private int? _Year;
		private int? _Month;
		private bool? _IsApprove;
		private string _Remark;
		private bool? _IsCreated;
		private decimal? _SelfScore;
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
		public int? UserId
		{
			get{ return _UserId; }
			set
			{
				this.OnPropertyValueChange(_.UserId,_UserId,value);
				this._UserId=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Score
		{
			get{ return _Score; }
			set
			{
				this.OnPropertyValueChange(_.Score,_Score,value);
				this._Score=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Year
		{
			get{ return _Year; }
			set
			{
				this.OnPropertyValueChange(_.Year,_Year,value);
				this._Year=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Month
		{
			get{ return _Month; }
			set
			{
				this.OnPropertyValueChange(_.Month,_Month,value);
				this._Month=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool? IsApprove
		{
			get{ return _IsApprove; }
			set
			{
				this.OnPropertyValueChange(_.IsApprove,_IsApprove,value);
				this._IsApprove=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			get{ return _Remark; }
			set
			{
				this.OnPropertyValueChange(_.Remark,_Remark,value);
				this._Remark=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool? IsCreated
		{
			get{ return _IsCreated; }
			set
			{
				this.OnPropertyValueChange(_.IsCreated,_IsCreated,value);
				this._IsCreated=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SelfScore
		{
			get{ return _SelfScore; }
			set
			{
				this.OnPropertyValueChange(_.SelfScore,_SelfScore,value);
				this._SelfScore=value;
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
				_.UserId,
				_.Score,
				_.Year,
				_.Month,
				_.IsApprove,
				_.Remark,
				_.IsCreated,
				_.SelfScore};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Id,
				this._UserId,
				this._Score,
				this._Year,
				this._Month,
				this._IsApprove,
				this._Remark,
				this._IsCreated,
				this._SelfScore};
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
			public readonly static Field All = new Field("*","Kpi_Process");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("Id","Kpi_Process","Id");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UserId = new Field("UserId","Kpi_Process","UserId");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Score = new Field("Score","Kpi_Process","Score");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Year = new Field("Year","Kpi_Process","Year");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Month = new Field("Month","Kpi_Process","Month");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IsApprove = new Field("IsApprove","Kpi_Process","IsApprove");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Remark = new Field("Remark","Kpi_Process","Remark");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IsCreated = new Field("IsCreated","Kpi_Process","IsCreated");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SelfScore = new Field("SelfScore","Kpi_Process","SelfScore");
		}
		#endregion


	}
}

