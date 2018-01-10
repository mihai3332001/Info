﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InfoOras.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
 using System.ComponentModel.DataAnnotations;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="City")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertJudet(Judet instance);
    partial void UpdateJudet(Judet instance);
    partial void DeleteJudet(Judet instance);
    partial void InsertOra(Ora instance);
    partial void UpdateOra(Ora instance);
    partial void DeleteOra(Ora instance);
    partial void InsertBilet(Bilet instance);
    partial void UpdateBilet(Bilet instance);
    partial void DeleteBilet(Bilet instance);
    partial void InsertTransport(Transport instance);
    partial void UpdateTransport(Transport instance);
    partial void DeleteTransport(Transport instance);
    partial void InsertGM(GM instance);
    partial void UpdateGM(GM instance);
    partial void DeleteGM(GM instance);
    partial void InsertLocatie(Locatie instance);
    partial void UpdateLocatie(Locatie instance);
    partial void DeleteLocatie(Locatie instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["CityConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Judet> Judets
		{
			get
			{
				return this.GetTable<Judet>();
			}
		}
		
		public System.Data.Linq.Table<Ora> Oras
		{
			get
			{
				return this.GetTable<Ora>();
			}
		}
		
		public System.Data.Linq.Table<Bilet> Bilets
		{
			get
			{
				return this.GetTable<Bilet>();
			}
		}
		
		public System.Data.Linq.Table<Transport> Transports
		{
			get
			{
				return this.GetTable<Transport>();
			}
		}
		
		public System.Data.Linq.Table<GM> GMs
		{
			get
			{
				return this.GetTable<GM>();
			}
		}
		
		public System.Data.Linq.Table<Locatie> Locaties
		{
			get
			{
				return this.GetTable<Locatie>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Judet")]
	public partial class Judet : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Judet1;
		
		private EntitySet<Ora> _Oras;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnJudet1Changing(string value);
    partial void OnJudet1Changed();
    #endregion
		
		public Judet()
		{
			this._Oras = new EntitySet<Ora>(new Action<Ora>(this.attach_Oras), new Action<Ora>(this.detach_Oras));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Judet", Storage="_Judet1", DbType="NVarChar(32) NOT NULL", CanBeNull=false)]
		public string Judet1
		{
			get
			{
				return this._Judet1;
			}
			set
			{
				if ((this._Judet1 != value))
				{
					this.OnJudet1Changing(value);
					this.SendPropertyChanging();
					this._Judet1 = value;
					this.SendPropertyChanged("Judet1");
					this.OnJudet1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Judet_Ora", Storage="_Oras", ThisKey="ID", OtherKey="JudetID")]
		public EntitySet<Ora> Oras
		{
			get
			{
				return this._Oras;
			}
			set
			{
				this._Oras.Assign(value);
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
		
		private void attach_Oras(Ora entity)
		{
			this.SendPropertyChanging();
			entity.Judet = this;
		}
		
		private void detach_Oras(Ora entity)
		{
			this.SendPropertyChanging();
			entity.Judet = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Oras")]
	public partial class Ora : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _JudetID;
		
		private string _Oras;
		
		private System.Nullable<decimal> _Lat;
		
		private System.Nullable<decimal> _Long;
		
		private EntitySet<Transport> _Transports;
		
		private EntitySet<GM> _GMs;
		
		private EntitySet<Locatie> _Locaties;
		
		private EntityRef<Judet> _Judet;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnJudetIDChanging(int value);
    partial void OnJudetIDChanged();
    partial void OnOrasChanging(string value);
    partial void OnOrasChanged();
    partial void OnLatChanging(System.Nullable<decimal> value);
    partial void OnLatChanged();
    partial void OnLongChanging(System.Nullable<decimal> value);
    partial void OnLongChanged();
    #endregion
		
		public Ora()
		{
			this._Transports = new EntitySet<Transport>(new Action<Transport>(this.attach_Transports), new Action<Transport>(this.detach_Transports));
			this._GMs = new EntitySet<GM>(new Action<GM>(this.attach_GMs), new Action<GM>(this.detach_GMs));
			this._Locaties = new EntitySet<Locatie>(new Action<Locatie>(this.attach_Locaties), new Action<Locatie>(this.detach_Locaties));
			this._Judet = default(EntityRef<Judet>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JudetID", DbType="Int NOT NULL")]
		public int JudetID
		{
			get
			{
				return this._JudetID;
			}
			set
			{
				if ((this._JudetID != value))
				{
					if (this._Judet.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnJudetIDChanging(value);
					this.SendPropertyChanging();
					this._JudetID = value;
					this.SendPropertyChanged("JudetID");
					this.OnJudetIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Oras", DbType="NVarChar(128) NOT NULL", CanBeNull=false)]
  [Required]
  [MaxLength(50, ErrorMessage ="Prea multe caractere")]
		public string Oras
		{
			get
			{
				return this._Oras;
			}
			set
			{
				if ((this._Oras != value))
				{
					this.OnOrasChanging(value);
					this.SendPropertyChanging();
					this._Oras = value;
					this.SendPropertyChanged("Oras");
					this.OnOrasChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Lat", DbType="Decimal(12,9)")]
		public System.Nullable<decimal> Lat
		{
			get
			{
				return this._Lat;
			}
			set
			{
				if ((this._Lat != value))
				{
					this.OnLatChanging(value);
					this.SendPropertyChanging();
					this._Lat = value;
					this.SendPropertyChanged("Lat");
					this.OnLatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Long", DbType="Decimal(12,9)")]
		public System.Nullable<decimal> Long
		{
			get
			{
				return this._Long;
			}
			set
			{
				if ((this._Long != value))
				{
					this.OnLongChanging(value);
					this.SendPropertyChanging();
					this._Long = value;
					this.SendPropertyChanged("Long");
					this.OnLongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Ora_Transport", Storage="_Transports", ThisKey="ID", OtherKey="OrasID")]
		public EntitySet<Transport> Transports
		{
			get
			{
				return this._Transports;
			}
			set
			{
				this._Transports.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Ora_GM", Storage="_GMs", ThisKey="ID", OtherKey="OrasID")]
		public EntitySet<GM> GMs
		{
			get
			{
				return this._GMs;
			}
			set
			{
				this._GMs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Ora_Locatie", Storage="_Locaties", ThisKey="ID", OtherKey="OrasID")]
		public EntitySet<Locatie> Locaties
		{
			get
			{
				return this._Locaties;
			}
			set
			{
				this._Locaties.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Judet_Ora", Storage="_Judet", ThisKey="JudetID", OtherKey="ID", IsForeignKey=true)]
		public Judet Judet
		{
			get
			{
				return this._Judet.Entity;
			}
			set
			{
				Judet previousValue = this._Judet.Entity;
				if (((previousValue != value) 
							|| (this._Judet.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Judet.Entity = null;
						previousValue.Oras.Remove(this);
					}
					this._Judet.Entity = value;
					if ((value != null))
					{
						value.Oras.Add(this);
						this._JudetID = value.ID;
					}
					else
					{
						this._JudetID = default(int);
					}
					this.SendPropertyChanged("Judet");
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
		
		private void attach_Transports(Transport entity)
		{
			this.SendPropertyChanging();
			entity.Ora = this;
		}
		
		private void detach_Transports(Transport entity)
		{
			this.SendPropertyChanging();
			entity.Ora = null;
		}
		
		private void attach_GMs(GM entity)
		{
			this.SendPropertyChanging();
			entity.Ora = this;
		}
		
		private void detach_GMs(GM entity)
		{
			this.SendPropertyChanging();
			entity.Ora = null;
		}
		
		private void attach_Locaties(Locatie entity)
		{
			this.SendPropertyChanging();
			entity.Ora = this;
		}
		
		private void detach_Locaties(Locatie entity)
		{
			this.SendPropertyChanging();
			entity.Ora = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Bilet")]
	public partial class Bilet : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private System.Nullable<int> _GMSID;
		
		private int _TransportID;
		
		private decimal _Pret;
		
		private string _Timp;
		
		private EntityRef<Transport> _Transport;
		
		private EntityRef<GM> _GM;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnGMSIDChanging(System.Nullable<int> value);
    partial void OnGMSIDChanged();
    partial void OnTransportIDChanging(int value);
    partial void OnTransportIDChanged();
    partial void OnPretChanging(decimal value);
    partial void OnPretChanged();
    partial void OnTimpChanging(string value);
    partial void OnTimpChanged();
    #endregion
		
		public Bilet()
		{
			this._Transport = default(EntityRef<Transport>);
			this._GM = default(EntityRef<GM>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GMSID", DbType="Int")]
		public System.Nullable<int> GMSID
		{
			get
			{
				return this._GMSID;
			}
			set
			{
				if ((this._GMSID != value))
				{
					if (this._GM.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnGMSIDChanging(value);
					this.SendPropertyChanging();
					this._GMSID = value;
					this.SendPropertyChanged("GMSID");
					this.OnGMSIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TransportID", DbType="Int NOT NULL")]
		public int TransportID
		{
			get
			{
				return this._TransportID;
			}
			set
			{
				if ((this._TransportID != value))
				{
					if (this._Transport.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTransportIDChanging(value);
					this.SendPropertyChanging();
					this._TransportID = value;
					this.SendPropertyChanged("TransportID");
					this.OnTransportIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pret", DbType="Decimal(5,2) NOT NULL")]
		public decimal Pret
		{
			get
			{
				return this._Pret;
			}
			set
			{
				if ((this._Pret != value))
				{
					this.OnPretChanging(value);
					this.SendPropertyChanging();
					this._Pret = value;
					this.SendPropertyChanged("Pret");
					this.OnPretChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Timp", DbType="NVarChar(128)")]
		public string Timp
		{
			get
			{
				return this._Timp;
			}
			set
			{
				if ((this._Timp != value))
				{
					this.OnTimpChanging(value);
					this.SendPropertyChanging();
					this._Timp = value;
					this.SendPropertyChanged("Timp");
					this.OnTimpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Transport_Bilet", Storage="_Transport", ThisKey="TransportID", OtherKey="ID", IsForeignKey=true)]
		public Transport Transport
		{
			get
			{
				return this._Transport.Entity;
			}
			set
			{
				Transport previousValue = this._Transport.Entity;
				if (((previousValue != value) 
							|| (this._Transport.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Transport.Entity = null;
						previousValue.Bilets.Remove(this);
					}
					this._Transport.Entity = value;
					if ((value != null))
					{
						value.Bilets.Add(this);
						this._TransportID = value.ID;
					}
					else
					{
						this._TransportID = default(int);
					}
					this.SendPropertyChanged("Transport");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="GM_Bilet", Storage="_GM", ThisKey="GMSID", OtherKey="ID", IsForeignKey=true)]
		public GM GM
		{
			get
			{
				return this._GM.Entity;
			}
			set
			{
				GM previousValue = this._GM.Entity;
				if (((previousValue != value) 
							|| (this._GM.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._GM.Entity = null;
						previousValue.Bilets.Remove(this);
					}
					this._GM.Entity = value;
					if ((value != null))
					{
						value.Bilets.Add(this);
						this._GMSID = value.ID;
					}
					else
					{
						this._GMSID = default(Nullable<int>);
					}
					this.SendPropertyChanged("GM");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Transport")]
	public partial class Transport : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _OrasID;
		
		private string _Name;
		
		private EntitySet<Bilet> _Bilets;
		
		private EntityRef<Ora> _Ora;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnOrasIDChanging(int value);
    partial void OnOrasIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Transport()
		{
			this._Bilets = new EntitySet<Bilet>(new Action<Bilet>(this.attach_Bilets), new Action<Bilet>(this.detach_Bilets));
			this._Ora = default(EntityRef<Ora>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrasID", DbType="Int NOT NULL")]
		public int OrasID
		{
			get
			{
				return this._OrasID;
			}
			set
			{
				if ((this._OrasID != value))
				{
					if (this._Ora.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnOrasIDChanging(value);
					this.SendPropertyChanging();
					this._OrasID = value;
					this.SendPropertyChanged("OrasID");
					this.OnOrasIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(8) NOT NULL", CanBeNull=false)]
  [Required]
  [MaxLength(10, ErrorMessage = "Maxim 3 cifre")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Transport_Bilet", Storage="_Bilets", ThisKey="ID", OtherKey="TransportID")]
		public EntitySet<Bilet> Bilets
		{
			get
			{
				return this._Bilets;
			}
			set
			{
				this._Bilets.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Ora_Transport", Storage="_Ora", ThisKey="OrasID", OtherKey="ID", IsForeignKey=true)]
		public Ora Ora
		{
			get
			{
				return this._Ora.Entity;
			}
			set
			{
				Ora previousValue = this._Ora.Entity;
				if (((previousValue != value) 
							|| (this._Ora.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Ora.Entity = null;
						previousValue.Transports.Remove(this);
					}
					this._Ora.Entity = value;
					if ((value != null))
					{
						value.Transports.Add(this);
						this._OrasID = value.ID;
					}
					else
					{
						this._OrasID = default(int);
					}
					this.SendPropertyChanged("Ora");
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
		
		private void attach_Bilets(Bilet entity)
		{
			this.SendPropertyChanging();
			entity.Transport = this;
		}
		
		private void detach_Bilets(Bilet entity)
		{
			this.SendPropertyChanging();
			entity.Transport = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.GMS")]
	public partial class GM : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _OrasID;
		
		private short _GMS;
		
		private EntitySet<Bilet> _Bilets;
		
		private EntityRef<Ora> _Ora;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnOrasIDChanging(int value);
    partial void OnOrasIDChanged();
    partial void OnGMSChanging(short value);
    partial void OnGMSChanged();
    #endregion
		
		public GM()
		{
			this._Bilets = new EntitySet<Bilet>(new Action<Bilet>(this.attach_Bilets), new Action<Bilet>(this.detach_Bilets));
			this._Ora = default(EntityRef<Ora>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrasID", DbType="Int NOT NULL")]
		public int OrasID
		{
			get
			{
				return this._OrasID;
			}
			set
			{
				if ((this._OrasID != value))
				{
					if (this._Ora.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnOrasIDChanging(value);
					this.SendPropertyChanging();
					this._OrasID = value;
					this.SendPropertyChanged("OrasID");
					this.OnOrasIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GMS", DbType="SmallInt NOT NULL")]
  [MaxLength(3, ErrorMessage ="Maxim 3 cifre")]
		public short GMS
		{
			get
			{
				return this._GMS;
			}
			set
			{
				if ((this._GMS != value))
				{
					this.OnGMSChanging(value);
					this.SendPropertyChanging();
					this._GMS = value;
					this.SendPropertyChanged("GMS");
					this.OnGMSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="GM_Bilet", Storage="_Bilets", ThisKey="ID", OtherKey="GMSID")]
		public EntitySet<Bilet> Bilets
		{
			get
			{
				return this._Bilets;
			}
			set
			{
				this._Bilets.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Ora_GM", Storage="_Ora", ThisKey="OrasID", OtherKey="ID", IsForeignKey=true)]
		public Ora Ora
		{
			get
			{
				return this._Ora.Entity;
			}
			set
			{
				Ora previousValue = this._Ora.Entity;
				if (((previousValue != value) 
							|| (this._Ora.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Ora.Entity = null;
						previousValue.GMs.Remove(this);
					}
					this._Ora.Entity = value;
					if ((value != null))
					{
						value.GMs.Add(this);
						this._OrasID = value.ID;
					}
					else
					{
						this._OrasID = default(int);
					}
					this.SendPropertyChanged("Ora");
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
		
		private void attach_Bilets(Bilet entity)
		{
			this.SendPropertyChanging();
			entity.GM = this;
		}
		
		private void detach_Bilets(Bilet entity)
		{
			this.SendPropertyChanging();
			entity.GM = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Locatie")]
	public partial class Locatie : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _OrasID;
		
		private string _Name;
		
		private EntityRef<Ora> _Ora;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnOrasIDChanging(int value);
    partial void OnOrasIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Locatie()
		{
			this._Ora = default(EntityRef<Ora>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrasID", DbType="Int NOT NULL")]
		public int OrasID
		{
			get
			{
				return this._OrasID;
			}
			set
			{
				if ((this._OrasID != value))
				{
					if (this._Ora.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnOrasIDChanging(value);
					this.SendPropertyChanging();
					this._OrasID = value;
					this.SendPropertyChanged("OrasID");
					this.OnOrasIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(256) NOT NULL", CanBeNull=false)]
  [Required]
  [MaxLength(100, ErrorMessage = "Maxim 3 cifre")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Ora_Locatie", Storage="_Ora", ThisKey="OrasID", OtherKey="ID", IsForeignKey=true)]
		public Ora Ora
		{
			get
			{
				return this._Ora.Entity;
			}
			set
			{
				Ora previousValue = this._Ora.Entity;
				if (((previousValue != value) 
							|| (this._Ora.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Ora.Entity = null;
						previousValue.Locaties.Remove(this);
					}
					this._Ora.Entity = value;
					if ((value != null))
					{
						value.Locaties.Add(this);
						this._OrasID = value.ID;
					}
					else
					{
						this._OrasID = default(int);
					}
					this.SendPropertyChanged("Ora");
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
}
#pragma warning restore 1591
