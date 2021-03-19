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

namespace JitterTestAnalyser
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="JitterTestData")]
	public partial class DataBaseHelperDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDelay(Delay instance);
    partial void UpdateDelay(Delay instance);
    partial void DeleteDelay(Delay instance);
    partial void InsertTestSystem(TestSystem instance);
    partial void UpdateTestSystem(TestSystem instance);
    partial void DeleteTestSystem(TestSystem instance);
    partial void InsertTestSetup(TestSetup instance);
    partial void UpdateTestSetup(TestSetup instance);
    partial void DeleteTestSetup(TestSetup instance);
    #endregion
		
		public DataBaseHelperDataContext() : 
				base(global::JitterTestAnalyser.Properties.Settings.Default.JitterTestDataConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseHelperDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseHelperDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseHelperDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseHelperDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Delay> Delays
		{
			get
			{
				return this.GetTable<Delay>();
			}
		}
		
		public System.Data.Linq.Table<TestSystem> TestSystems
		{
			get
			{
				return this.GetTable<TestSystem>();
			}
		}
		
		public System.Data.Linq.Table<TestSetup> TestSetups
		{
			get
			{
				return this.GetTable<TestSetup>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AddDelayValues")]
		public int AddDelayValues([global::System.Data.Linq.Mapping.ParameterAttribute(Name="TimeStamp", DbType="DateTime")] System.Nullable<System.DateTime> timeStamp, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Delay", DbType="Int")] System.Nullable<int> delay, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SampleID", DbType="Int")] System.Nullable<int> sampleID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SystemID", DbType="Int")] System.Nullable<int> systemID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SetupID", DbType="Int")] System.Nullable<int> setupID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), timeStamp, delay, sampleID, systemID, setupID);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DeleteTestSetup")]
		public int DeleteTestSetup([global::System.Data.Linq.Mapping.ParameterAttribute(Name="CsvFileName", DbType="NVarChar(MAX)")] string csvFileName)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), csvFileName);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DeleteTestSetupID")]
		public int DeleteTestSetupID([global::System.Data.Linq.Mapping.ParameterAttribute(Name="SetupID", DbType="Int")] System.Nullable<int> setupID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), setupID);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ExcludeTestSetupFromSumary")]
		public int ExcludeTestSetupFromSumary([global::System.Data.Linq.Mapping.ParameterAttribute(Name="SetupID", DbType="Int")] System.Nullable<int> setupID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), setupID);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetTestSystems", IsComposable=true)]
		public IQueryable<GetTestSystemsResult> GetTestSystems()
		{
			return this.CreateMethodCallQuery<GetTestSystemsResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AddNewTestSetup")]
		public int AddNewTestSetup(
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="NovaVersion", DbType="NVarChar(50)")] string novaVersion, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="MantaVersion", DbType="NVarChar(50)")] string mantaVersion, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Product", DbType="NVarChar(50)")] string product, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="ImageLength", DbType="Int")] System.Nullable<int> imageLength, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="RawDataEnabled", DbType="Bit")] System.Nullable<bool> rawDataEnabled, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="FODEnabled", DbType="Bit")] System.Nullable<bool> fODEnabled, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="SurveilanceEnabled", DbType="Bit")] System.Nullable<bool> surveilanceEnabled, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="StatisticsEnabled", DbType="Bit")] System.Nullable<bool> statisticsEnabled, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="MeasureFrom", DbType="NVarChar(50)")] string measureFrom, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="ConvSpeed", DbType="Int")] System.Nullable<int> convSpeed, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="DataBaseSize", DbType="Int")] System.Nullable<int> dataBaseSize, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="CsvFile", DbType="NVarChar(MAX)")] string csvFile, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="SystemID", DbType="Int")] System.Nullable<int> systemID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="OpcClient", DbType="NVarChar(20)")] string opcClient, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="NlcpPoints", DbType="Int")] System.Nullable<int> nlcpPoints, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Comment", DbType="NVarChar(MAX)")] string comment)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), novaVersion, mantaVersion, product, imageLength, rawDataEnabled, fODEnabled, surveilanceEnabled, statisticsEnabled, measureFrom, convSpeed, dataBaseSize, csvFile, systemID, opcClient, nlcpPoints, comment);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Delays")]
	public partial class Delay : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DelayID;
		
		private System.DateTime _TimeStamp;
		
		private int _Delay1;
		
		private int _SampleID;
		
		private int _SystemID;
		
		private int _SetupID;
		
		private EntityRef<TestSystem> _TestSystem;
		
		private EntityRef<TestSetup> _TestSetup;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDelayIDChanging(int value);
    partial void OnDelayIDChanged();
    partial void OnTimeStampChanging(System.DateTime value);
    partial void OnTimeStampChanged();
    partial void OnDelay1Changing(int value);
    partial void OnDelay1Changed();
    partial void OnSampleIDChanging(int value);
    partial void OnSampleIDChanged();
    partial void OnSystemIDChanging(int value);
    partial void OnSystemIDChanged();
    partial void OnSetupIDChanging(int value);
    partial void OnSetupIDChanged();
    #endregion
		
		public Delay()
		{
			this._TestSystem = default(EntityRef<TestSystem>);
			this._TestSetup = default(EntityRef<TestSetup>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DelayID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int DelayID
		{
			get
			{
				return this._DelayID;
			}
			set
			{
				if ((this._DelayID != value))
				{
					this.OnDelayIDChanging(value);
					this.SendPropertyChanging();
					this._DelayID = value;
					this.SendPropertyChanged("DelayID");
					this.OnDelayIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimeStamp", DbType="DateTime NOT NULL")]
		public System.DateTime TimeStamp
		{
			get
			{
				return this._TimeStamp;
			}
			set
			{
				if ((this._TimeStamp != value))
				{
					this.OnTimeStampChanging(value);
					this.SendPropertyChanging();
					this._TimeStamp = value;
					this.SendPropertyChanged("TimeStamp");
					this.OnTimeStampChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Delay", Storage="_Delay1", DbType="Int NOT NULL")]
		public int Delay1
		{
			get
			{
				return this._Delay1;
			}
			set
			{
				if ((this._Delay1 != value))
				{
					this.OnDelay1Changing(value);
					this.SendPropertyChanging();
					this._Delay1 = value;
					this.SendPropertyChanged("Delay1");
					this.OnDelay1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SampleID", DbType="Int NOT NULL")]
		public int SampleID
		{
			get
			{
				return this._SampleID;
			}
			set
			{
				if ((this._SampleID != value))
				{
					this.OnSampleIDChanging(value);
					this.SendPropertyChanging();
					this._SampleID = value;
					this.SendPropertyChanged("SampleID");
					this.OnSampleIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SystemID", DbType="Int NOT NULL")]
		public int SystemID
		{
			get
			{
				return this._SystemID;
			}
			set
			{
				if ((this._SystemID != value))
				{
					if (this._TestSystem.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSystemIDChanging(value);
					this.SendPropertyChanging();
					this._SystemID = value;
					this.SendPropertyChanged("SystemID");
					this.OnSystemIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SetupID", DbType="Int NOT NULL")]
		public int SetupID
		{
			get
			{
				return this._SetupID;
			}
			set
			{
				if ((this._SetupID != value))
				{
					if (this._TestSetup.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSetupIDChanging(value);
					this.SendPropertyChanging();
					this._SetupID = value;
					this.SendPropertyChanged("SetupID");
					this.OnSetupIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TestSystem_Delay", Storage="_TestSystem", ThisKey="SystemID", OtherKey="SystemID", IsForeignKey=true)]
		public TestSystem TestSystem
		{
			get
			{
				return this._TestSystem.Entity;
			}
			set
			{
				TestSystem previousValue = this._TestSystem.Entity;
				if (((previousValue != value) 
							|| (this._TestSystem.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TestSystem.Entity = null;
						previousValue.Delays.Remove(this);
					}
					this._TestSystem.Entity = value;
					if ((value != null))
					{
						value.Delays.Add(this);
						this._SystemID = value.SystemID;
					}
					else
					{
						this._SystemID = default(int);
					}
					this.SendPropertyChanged("TestSystem");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TestSetup_Delay", Storage="_TestSetup", ThisKey="SetupID", OtherKey="SetupID", IsForeignKey=true)]
		public TestSetup TestSetup
		{
			get
			{
				return this._TestSetup.Entity;
			}
			set
			{
				TestSetup previousValue = this._TestSetup.Entity;
				if (((previousValue != value) 
							|| (this._TestSetup.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TestSetup.Entity = null;
						previousValue.Delays.Remove(this);
					}
					this._TestSetup.Entity = value;
					if ((value != null))
					{
						value.Delays.Add(this);
						this._SetupID = value.SetupID;
					}
					else
					{
						this._SetupID = default(int);
					}
					this.SendPropertyChanged("TestSetup");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TestSystem")]
	public partial class TestSystem : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SystemID;
		
		private string _Name;
		
		private string _HardWare;
		
		private int _RamSize;
		
		private System.DateTime _DateForImage;
		
		private EntitySet<Delay> _Delays;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSystemIDChanging(int value);
    partial void OnSystemIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnHardWareChanging(string value);
    partial void OnHardWareChanged();
    partial void OnRamSizeChanging(int value);
    partial void OnRamSizeChanged();
    partial void OnDateForImageChanging(System.DateTime value);
    partial void OnDateForImageChanged();
    #endregion
		
		public TestSystem()
		{
			this._Delays = new EntitySet<Delay>(new Action<Delay>(this.attach_Delays), new Action<Delay>(this.detach_Delays));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SystemID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int SystemID
		{
			get
			{
				return this._SystemID;
			}
			set
			{
				if ((this._SystemID != value))
				{
					this.OnSystemIDChanging(value);
					this.SendPropertyChanging();
					this._SystemID = value;
					this.SendPropertyChanged("SystemID");
					this.OnSystemIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HardWare", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string HardWare
		{
			get
			{
				return this._HardWare;
			}
			set
			{
				if ((this._HardWare != value))
				{
					this.OnHardWareChanging(value);
					this.SendPropertyChanging();
					this._HardWare = value;
					this.SendPropertyChanged("HardWare");
					this.OnHardWareChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RamSize", DbType="Int NOT NULL")]
		public int RamSize
		{
			get
			{
				return this._RamSize;
			}
			set
			{
				if ((this._RamSize != value))
				{
					this.OnRamSizeChanging(value);
					this.SendPropertyChanging();
					this._RamSize = value;
					this.SendPropertyChanged("RamSize");
					this.OnRamSizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateForImage", DbType="DateTime NOT NULL")]
		public System.DateTime DateForImage
		{
			get
			{
				return this._DateForImage;
			}
			set
			{
				if ((this._DateForImage != value))
				{
					this.OnDateForImageChanging(value);
					this.SendPropertyChanging();
					this._DateForImage = value;
					this.SendPropertyChanged("DateForImage");
					this.OnDateForImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TestSystem_Delay", Storage="_Delays", ThisKey="SystemID", OtherKey="SystemID")]
		public EntitySet<Delay> Delays
		{
			get
			{
				return this._Delays;
			}
			set
			{
				this._Delays.Assign(value);
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
		
		private void attach_Delays(Delay entity)
		{
			this.SendPropertyChanging();
			entity.TestSystem = this;
		}
		
		private void detach_Delays(Delay entity)
		{
			this.SendPropertyChanging();
			entity.TestSystem = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TestSetup")]
	public partial class TestSetup : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SetupID;
		
		private int _SystemID;
		
		private string _NovaVersion;
		
		private string _MantaVersion;
		
		private string _Product;
		
		private int _ImageLength;
		
		private bool _RawDataEnabled;
		
		private bool _FODEnabled;
		
		private bool _SurveilanceEnabled;
		
		private bool _StatisticsEnabled;
		
		private string _MeasureFrom;
		
		private int _ConvSpeed;
		
		private int _DataBaseSize;
		
		private string _OpcClient;
		
		private int _NlcpPoints;
		
		private string _CsvFile;
		
		private System.Nullable<bool> _ExcludeFromSumery;
		
		private string _Comment;
		
		private EntitySet<Delay> _Delays;
		
		private EntityRef<TestSetup> _TestSetup2;
		
		private EntityRef<TestSetup> _TestSetup1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSetupIDChanging(int value);
    partial void OnSetupIDChanged();
    partial void OnSystemIDChanging(int value);
    partial void OnSystemIDChanged();
    partial void OnNovaVersionChanging(string value);
    partial void OnNovaVersionChanged();
    partial void OnMantaVersionChanging(string value);
    partial void OnMantaVersionChanged();
    partial void OnProductChanging(string value);
    partial void OnProductChanged();
    partial void OnImageLengthChanging(int value);
    partial void OnImageLengthChanged();
    partial void OnRawDataEnabledChanging(bool value);
    partial void OnRawDataEnabledChanged();
    partial void OnFODEnabledChanging(bool value);
    partial void OnFODEnabledChanged();
    partial void OnSurveilanceEnabledChanging(bool value);
    partial void OnSurveilanceEnabledChanged();
    partial void OnStatisticsEnabledChanging(bool value);
    partial void OnStatisticsEnabledChanged();
    partial void OnMeasureFromChanging(string value);
    partial void OnMeasureFromChanged();
    partial void OnConvSpeedChanging(int value);
    partial void OnConvSpeedChanged();
    partial void OnDataBaseSizeChanging(int value);
    partial void OnDataBaseSizeChanged();
    partial void OnOpcClientChanging(string value);
    partial void OnOpcClientChanged();
    partial void OnNlcpPointsChanging(int value);
    partial void OnNlcpPointsChanged();
    partial void OnCsvFileChanging(string value);
    partial void OnCsvFileChanged();
    partial void OnExcludeFromSumeryChanging(System.Nullable<bool> value);
    partial void OnExcludeFromSumeryChanged();
    partial void OnCommentChanging(string value);
    partial void OnCommentChanged();
    #endregion
		
		public TestSetup()
		{
			this._Delays = new EntitySet<Delay>(new Action<Delay>(this.attach_Delays), new Action<Delay>(this.detach_Delays));
			this._TestSetup2 = default(EntityRef<TestSetup>);
			this._TestSetup1 = default(EntityRef<TestSetup>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SetupID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int SetupID
		{
			get
			{
				return this._SetupID;
			}
			set
			{
				if ((this._SetupID != value))
				{
					if (this._TestSetup1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSetupIDChanging(value);
					this.SendPropertyChanging();
					this._SetupID = value;
					this.SendPropertyChanged("SetupID");
					this.OnSetupIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SystemID", DbType="Int NOT NULL")]
		public int SystemID
		{
			get
			{
				return this._SystemID;
			}
			set
			{
				if ((this._SystemID != value))
				{
					this.OnSystemIDChanging(value);
					this.SendPropertyChanging();
					this._SystemID = value;
					this.SendPropertyChanged("SystemID");
					this.OnSystemIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NovaVersion", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string NovaVersion
		{
			get
			{
				return this._NovaVersion;
			}
			set
			{
				if ((this._NovaVersion != value))
				{
					this.OnNovaVersionChanging(value);
					this.SendPropertyChanging();
					this._NovaVersion = value;
					this.SendPropertyChanged("NovaVersion");
					this.OnNovaVersionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MantaVersion", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string MantaVersion
		{
			get
			{
				return this._MantaVersion;
			}
			set
			{
				if ((this._MantaVersion != value))
				{
					this.OnMantaVersionChanging(value);
					this.SendPropertyChanging();
					this._MantaVersion = value;
					this.SendPropertyChanged("MantaVersion");
					this.OnMantaVersionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Product
		{
			get
			{
				return this._Product;
			}
			set
			{
				if ((this._Product != value))
				{
					this.OnProductChanging(value);
					this.SendPropertyChanging();
					this._Product = value;
					this.SendPropertyChanged("Product");
					this.OnProductChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageLength", DbType="Int NOT NULL")]
		public int ImageLength
		{
			get
			{
				return this._ImageLength;
			}
			set
			{
				if ((this._ImageLength != value))
				{
					this.OnImageLengthChanging(value);
					this.SendPropertyChanging();
					this._ImageLength = value;
					this.SendPropertyChanged("ImageLength");
					this.OnImageLengthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RawDataEnabled", DbType="Bit NOT NULL")]
		public bool RawDataEnabled
		{
			get
			{
				return this._RawDataEnabled;
			}
			set
			{
				if ((this._RawDataEnabled != value))
				{
					this.OnRawDataEnabledChanging(value);
					this.SendPropertyChanging();
					this._RawDataEnabled = value;
					this.SendPropertyChanged("RawDataEnabled");
					this.OnRawDataEnabledChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FODEnabled", DbType="Bit NOT NULL")]
		public bool FODEnabled
		{
			get
			{
				return this._FODEnabled;
			}
			set
			{
				if ((this._FODEnabled != value))
				{
					this.OnFODEnabledChanging(value);
					this.SendPropertyChanging();
					this._FODEnabled = value;
					this.SendPropertyChanged("FODEnabled");
					this.OnFODEnabledChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SurveilanceEnabled", DbType="Bit NOT NULL")]
		public bool SurveilanceEnabled
		{
			get
			{
				return this._SurveilanceEnabled;
			}
			set
			{
				if ((this._SurveilanceEnabled != value))
				{
					this.OnSurveilanceEnabledChanging(value);
					this.SendPropertyChanging();
					this._SurveilanceEnabled = value;
					this.SendPropertyChanged("SurveilanceEnabled");
					this.OnSurveilanceEnabledChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StatisticsEnabled", DbType="Bit NOT NULL")]
		public bool StatisticsEnabled
		{
			get
			{
				return this._StatisticsEnabled;
			}
			set
			{
				if ((this._StatisticsEnabled != value))
				{
					this.OnStatisticsEnabledChanging(value);
					this.SendPropertyChanging();
					this._StatisticsEnabled = value;
					this.SendPropertyChanged("StatisticsEnabled");
					this.OnStatisticsEnabledChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MeasureFrom", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string MeasureFrom
		{
			get
			{
				return this._MeasureFrom;
			}
			set
			{
				if ((this._MeasureFrom != value))
				{
					this.OnMeasureFromChanging(value);
					this.SendPropertyChanging();
					this._MeasureFrom = value;
					this.SendPropertyChanged("MeasureFrom");
					this.OnMeasureFromChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ConvSpeed", DbType="Int NOT NULL")]
		public int ConvSpeed
		{
			get
			{
				return this._ConvSpeed;
			}
			set
			{
				if ((this._ConvSpeed != value))
				{
					this.OnConvSpeedChanging(value);
					this.SendPropertyChanging();
					this._ConvSpeed = value;
					this.SendPropertyChanged("ConvSpeed");
					this.OnConvSpeedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DataBaseSize", DbType="Int NOT NULL")]
		public int DataBaseSize
		{
			get
			{
				return this._DataBaseSize;
			}
			set
			{
				if ((this._DataBaseSize != value))
				{
					this.OnDataBaseSizeChanging(value);
					this.SendPropertyChanging();
					this._DataBaseSize = value;
					this.SendPropertyChanged("DataBaseSize");
					this.OnDataBaseSizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OpcClient", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string OpcClient
		{
			get
			{
				return this._OpcClient;
			}
			set
			{
				if ((this._OpcClient != value))
				{
					this.OnOpcClientChanging(value);
					this.SendPropertyChanging();
					this._OpcClient = value;
					this.SendPropertyChanged("OpcClient");
					this.OnOpcClientChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NlcpPoints", DbType="Int NOT NULL")]
		public int NlcpPoints
		{
			get
			{
				return this._NlcpPoints;
			}
			set
			{
				if ((this._NlcpPoints != value))
				{
					this.OnNlcpPointsChanging(value);
					this.SendPropertyChanging();
					this._NlcpPoints = value;
					this.SendPropertyChanged("NlcpPoints");
					this.OnNlcpPointsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CsvFile", DbType="NVarChar(MAX)")]
		public string CsvFile
		{
			get
			{
				return this._CsvFile;
			}
			set
			{
				if ((this._CsvFile != value))
				{
					this.OnCsvFileChanging(value);
					this.SendPropertyChanging();
					this._CsvFile = value;
					this.SendPropertyChanged("CsvFile");
					this.OnCsvFileChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExcludeFromSumery", DbType="Bit")]
		public System.Nullable<bool> ExcludeFromSumery
		{
			get
			{
				return this._ExcludeFromSumery;
			}
			set
			{
				if ((this._ExcludeFromSumery != value))
				{
					this.OnExcludeFromSumeryChanging(value);
					this.SendPropertyChanging();
					this._ExcludeFromSumery = value;
					this.SendPropertyChanged("ExcludeFromSumery");
					this.OnExcludeFromSumeryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Comment", DbType="NVarChar(MAX)")]
		public string Comment
		{
			get
			{
				return this._Comment;
			}
			set
			{
				if ((this._Comment != value))
				{
					this.OnCommentChanging(value);
					this.SendPropertyChanging();
					this._Comment = value;
					this.SendPropertyChanged("Comment");
					this.OnCommentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TestSetup_Delay", Storage="_Delays", ThisKey="SetupID", OtherKey="SetupID")]
		public EntitySet<Delay> Delays
		{
			get
			{
				return this._Delays;
			}
			set
			{
				this._Delays.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TestSetup_TestSetup", Storage="_TestSetup2", ThisKey="SetupID", OtherKey="SetupID", IsUnique=true, IsForeignKey=false)]
		public TestSetup TestSetup2
		{
			get
			{
				return this._TestSetup2.Entity;
			}
			set
			{
				TestSetup previousValue = this._TestSetup2.Entity;
				if (((previousValue != value) 
							|| (this._TestSetup2.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TestSetup2.Entity = null;
						previousValue.TestSetup1 = null;
					}
					this._TestSetup2.Entity = value;
					if ((value != null))
					{
						value.TestSetup1 = this;
					}
					this.SendPropertyChanged("TestSetup2");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TestSetup_TestSetup", Storage="_TestSetup1", ThisKey="SetupID", OtherKey="SetupID", IsForeignKey=true)]
		public TestSetup TestSetup1
		{
			get
			{
				return this._TestSetup1.Entity;
			}
			set
			{
				TestSetup previousValue = this._TestSetup1.Entity;
				if (((previousValue != value) 
							|| (this._TestSetup1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TestSetup1.Entity = null;
						previousValue.TestSetup2 = null;
					}
					this._TestSetup1.Entity = value;
					if ((value != null))
					{
						value.TestSetup2 = this;
						this._SetupID = value.SetupID;
					}
					else
					{
						this._SetupID = default(int);
					}
					this.SendPropertyChanged("TestSetup1");
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
		
		private void attach_Delays(Delay entity)
		{
			this.SendPropertyChanging();
			entity.TestSetup = this;
		}
		
		private void detach_Delays(Delay entity)
		{
			this.SendPropertyChanging();
			entity.TestSetup = null;
		}
	}
	
	public partial class GetTestSystemsResult
	{
		
		private int _SystemID;
		
		private string _Name;
		
		public GetTestSystemsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SystemID", DbType="Int NOT NULL")]
		public int SystemID
		{
			get
			{
				return this._SystemID;
			}
			set
			{
				if ((this._SystemID != value))
				{
					this._SystemID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(152)")]
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
					this._Name = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
