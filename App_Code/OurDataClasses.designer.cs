﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SjukAnmala")]
public partial class DataClassesDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertRoles(Roles instance);
  partial void UpdateRoles(Roles instance);
  partial void DeleteRoles(Roles instance);
  partial void InsertUsers(Users instance);
  partial void UpdateUsers(Users instance);
  partial void DeleteUsers(Users instance);
  partial void InsertIllness(Illness instance);
  partial void UpdateIllness(Illness instance);
  partial void DeleteIllness(Illness instance);
  #endregion
	
	public DataClassesDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SjukAnmalaConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<Roles> Roles
	{
		get
		{
			return this.GetTable<Roles>();
		}
	}
	
	public System.Data.Linq.Table<Users> Users
	{
		get
		{
			return this.GetTable<Users>();
		}
	}
	
	public System.Data.Linq.Table<Illness> Illnesses
	{
		get
		{
			return this.GetTable<Illness>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Roles")]
public partial class Roles : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private string _RoleName;
	
	private EntitySet<Users> _Users;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnRoleNameChanging(string value);
    partial void OnRoleNameChanged();
    #endregion
	
	public Roles()
	{
		this._Users = new EntitySet<Users>(new Action<Users>(this.attach_Users), new Action<Users>(this.detach_Users));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleName", DbType="NChar(25) NOT NULL", CanBeNull=false)]
	public string RoleName
	{
		get
		{
			return this._RoleName;
		}
		set
		{
			if ((this._RoleName != value))
			{
				this.OnRoleNameChanging(value);
				this.SendPropertyChanging();
				this._RoleName = value;
				this.SendPropertyChanged("RoleName");
				this.OnRoleNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Roles_Users", Storage="_Users", ThisKey="Id", OtherKey="Role")]
	public EntitySet<Users> Users
	{
		get
		{
			return this._Users;
		}
		set
		{
			this._Users.Assign(value);
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_Users(Users entity)
	{
		this.SendPropertyChanging();
		entity.Roles = this;
	}
	
	private void detach_Users(Users entity)
	{
		this.SendPropertyChanging();
		entity.Roles = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
public partial class Users : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private string _Name;
	
	private string _Password;
	
	private int _Role;
	
	private EntitySet<Illness> _Illnesses;
	
	private EntityRef<Roles> _Roles;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnRoleChanging(int value);
    partial void OnRoleChanged();
    #endregion
	
	public Users()
	{
		this._Illnesses = new EntitySet<Illness>(new Action<Illness>(this.attach_Illnesses), new Action<Illness>(this.detach_Illnesses));
		this._Roles = default(EntityRef<Roles>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NChar(50) NOT NULL", CanBeNull=false)]
	public string Name
	{
		get
		{
			return this._Name;
		}
		set
		{
			if ((this._Name != value))
			{
				this.OnNameChanging(value);
				this.SendPropertyChanging();
				this._Name = value;
				this.SendPropertyChanged("Name");
				this.OnNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NChar(1000) NOT NULL", CanBeNull=false)]
	public string Password
	{
		get
		{
			return this._Password;
		}
		set
		{
			if ((this._Password != value))
			{
				this.OnPasswordChanging(value);
				this.SendPropertyChanging();
				this._Password = value;
				this.SendPropertyChanged("Password");
				this.OnPasswordChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Role", DbType="Int NOT NULL")]
	public int Role
	{
		get
		{
			return this._Role;
		}
		set
		{
			if ((this._Role != value))
			{
				if (this._Roles.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnRoleChanging(value);
				this.SendPropertyChanging();
				this._Role = value;
				this.SendPropertyChanged("Role");
				this.OnRoleChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Users_Illness", Storage="_Illnesses", ThisKey="Id", OtherKey="AnstalldId")]
	public EntitySet<Illness> Illnesses
	{
		get
		{
			return this._Illnesses;
		}
		set
		{
			this._Illnesses.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Roles_Users", Storage="_Roles", ThisKey="Role", OtherKey="Id", IsForeignKey=true)]
	public Roles Roles
	{
		get
		{
			return this._Roles.Entity;
		}
		set
		{
			Roles previousValue = this._Roles.Entity;
			if (((previousValue != value) 
						|| (this._Roles.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Roles.Entity = null;
					previousValue.Users.Remove(this);
				}
				this._Roles.Entity = value;
				if ((value != null))
				{
					value.Users.Add(this);
					this._Role = value.Id;
				}
				else
				{
					this._Role = default(int);
				}
				this.SendPropertyChanged("Roles");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_Illnesses(Illness entity)
	{
		this.SendPropertyChanging();
		entity.Users = this;
	}
	
	private void detach_Illnesses(Illness entity)
	{
		this.SendPropertyChanging();
		entity.Users = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Illness")]
public partial class Illness : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private System.DateTime _Start;
	
	private System.DateTime _Expires;
	
	private bool _MedicalCertificate;
	
	private System.Nullable<int> _AnstalldId;
	
	private bool _ChildIllness;
	
	private string _SocialSecurity;
	
	private EntityRef<Users> _Users;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnStartChanging(System.DateTime value);
    partial void OnStartChanged();
    partial void OnExpiresChanging(System.DateTime value);
    partial void OnExpiresChanged();
    partial void OnMedicalCertificateChanging(bool value);
    partial void OnMedicalCertificateChanged();
    partial void OnAnstalldIdChanging(System.Nullable<int> value);
    partial void OnAnstalldIdChanged();
    partial void OnChildIllnessChanging(bool value);
    partial void OnChildIllnessChanged();
    partial void OnSocialSecurityChanging(string value);
    partial void OnSocialSecurityChanged();
    #endregion
	
	public Illness()
	{
		this._Users = default(EntityRef<Users>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Start", DbType="DateTime NOT NULL")]
	public System.DateTime Start
	{
		get
		{
			return this._Start;
		}
		set
		{
			if ((this._Start != value))
			{
				this.OnStartChanging(value);
				this.SendPropertyChanging();
				this._Start = value;
				this.SendPropertyChanged("Start");
				this.OnStartChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Expires", DbType="DateTime NOT NULL")]
	public System.DateTime Expires
	{
		get
		{
			return this._Expires;
		}
		set
		{
			if ((this._Expires != value))
			{
				this.OnExpiresChanging(value);
				this.SendPropertyChanging();
				this._Expires = value;
				this.SendPropertyChanged("Expires");
				this.OnExpiresChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MedicalCertificate", DbType="Bit NOT NULL")]
	public bool MedicalCertificate
	{
		get
		{
			return this._MedicalCertificate;
		}
		set
		{
			if ((this._MedicalCertificate != value))
			{
				this.OnMedicalCertificateChanging(value);
				this.SendPropertyChanging();
				this._MedicalCertificate = value;
				this.SendPropertyChanged("MedicalCertificate");
				this.OnMedicalCertificateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnstalldId", DbType="Int")]
	public System.Nullable<int> AnstalldId
	{
		get
		{
			return this._AnstalldId;
		}
		set
		{
			if ((this._AnstalldId != value))
			{
				if (this._Users.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnAnstalldIdChanging(value);
				this.SendPropertyChanging();
				this._AnstalldId = value;
				this.SendPropertyChanged("AnstalldId");
				this.OnAnstalldIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChildIllness", DbType="Bit NOT NULL")]
	public bool ChildIllness
	{
		get
		{
			return this._ChildIllness;
		}
		set
		{
			if ((this._ChildIllness != value))
			{
				this.OnChildIllnessChanging(value);
				this.SendPropertyChanging();
				this._ChildIllness = value;
				this.SendPropertyChanged("ChildIllness");
				this.OnChildIllnessChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SocialSecurity", DbType="NVarChar(50)")]
	public string SocialSecurity
	{
		get
		{
			return this._SocialSecurity;
		}
		set
		{
			if ((this._SocialSecurity != value))
			{
				this.OnSocialSecurityChanging(value);
				this.SendPropertyChanging();
				this._SocialSecurity = value;
				this.SendPropertyChanged("SocialSecurity");
				this.OnSocialSecurityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Users_Illness", Storage="_Users", ThisKey="AnstalldId", OtherKey="Id", IsForeignKey=true)]
	public Users Users
	{
		get
		{
			return this._Users.Entity;
		}
		set
		{
			Users previousValue = this._Users.Entity;
			if (((previousValue != value) 
						|| (this._Users.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Users.Entity = null;
					previousValue.Illnesses.Remove(this);
				}
				this._Users.Entity = value;
				if ((value != null))
				{
					value.Illnesses.Add(this);
					this._AnstalldId = value.Id;
				}
				else
				{
					this._AnstalldId = default(Nullable<int>);
				}
				this.SendPropertyChanged("Users");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
#pragma warning restore 1591
