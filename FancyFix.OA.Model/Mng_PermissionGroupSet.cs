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
	/// 实体类Mng_PermissionGroupSet 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("Mng_PermissionGroupSet")]
	[Serializable]
	public partial class Mng_PermissionGroupSet : Entity 
	{
		#region Model
		private int _Id;
		private int? _GroupId;
		private int? _PermissionId;
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
		public int? GroupId
		{
			get{ return _GroupId; }
			set
			{
				this.OnPropertyValueChange(_.GroupId,_GroupId,value);
				this._GroupId=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PermissionId
		{
			get{ return _PermissionId; }
			set
			{
				this.OnPropertyValueChange(_.PermissionId,_PermissionId,value);
				this._PermissionId=value;
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
				_.GroupId,
				_.PermissionId};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Id,
				this._GroupId,
				this._PermissionId};
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
			public readonly static Field All = new Field("*","Mng_PermissionGroupSet");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("Id","Mng_PermissionGroupSet","Id");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GroupId = new Field("GroupId","Mng_PermissionGroupSet","GroupId");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PermissionId = new Field("PermissionId","Mng_PermissionGroupSet","PermissionId");
		}
		#endregion


	}
}

