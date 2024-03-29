﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace TrackerModel
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class trackDBEntities2 : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new trackDBEntities2 object using the connection string found in the 'trackDBEntities2' section of the application configuration file.
        /// </summary>
        public trackDBEntities2() : base("name=trackDBEntities2", "trackDBEntities2")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new trackDBEntities2 object.
        /// </summary>
        public trackDBEntities2(string connectionString) : base(connectionString, "trackDBEntities2")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new trackDBEntities2 object.
        /// </summary>
        public trackDBEntities2(EntityConnection connection) : base(connection, "trackDBEntities2")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<LogFiles> LogFiles
        {
            get
            {
                if ((_LogFiles == null))
                {
                    _LogFiles = base.CreateObjectSet<LogFiles>("LogFiles");
                }
                return _LogFiles;
            }
        }
        private ObjectSet<LogFiles> _LogFiles;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<LogImport> LogImport
        {
            get
            {
                if ((_LogImport == null))
                {
                    _LogImport = base.CreateObjectSet<LogImport>("LogImport");
                }
                return _LogImport;
            }
        }
        private ObjectSet<LogImport> _LogImport;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<MyCards> MyCards
        {
            get
            {
                if ((_MyCards == null))
                {
                    _MyCards = base.CreateObjectSet<MyCards>("MyCards");
                }
                return _MyCards;
            }
        }
        private ObjectSet<MyCards> _MyCards;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Hands> Hands
        {
            get
            {
                if ((_Hands == null))
                {
                    _Hands = base.CreateObjectSet<Hands>("Hands");
                }
                return _Hands;
            }
        }
        private ObjectSet<Hands> _Hands;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the LogFiles EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToLogFiles(LogFiles logFiles)
        {
            base.AddObject("LogFiles", logFiles);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the LogImport EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToLogImport(LogImport logImport)
        {
            base.AddObject("LogImport", logImport);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the MyCards EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToMyCards(MyCards myCards)
        {
            base.AddObject("MyCards", myCards);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Hands EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToHands(Hands hands)
        {
            base.AddObject("Hands", hands);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="trackDBModel", Name="Hands")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Hands : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Hands object.
        /// </summary>
        /// <param name="position">Initial value of the Position property.</param>
        /// <param name="pk">Initial value of the pk property.</param>
        /// <param name="positionButton">Initial value of the PositionButton property.</param>
        public static Hands CreateHands(global::System.Int32 position, global::System.Int32 pk, global::System.Int32 positionButton)
        {
            Hands hands = new Hands();
            hands.Position = position;
            hands.pk = pk;
            hands.PositionButton = positionButton;
            return hands;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Id
        {
            get
            {
                return _Id;
            }
            set
            {
                OnIdChanging(value);
                ReportPropertyChanging("Id");
                _Id = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Id");
                OnIdChanged();
            }
        }
        private global::System.String _Id;
        partial void OnIdChanging(global::System.String value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String User
        {
            get
            {
                return _User;
            }
            set
            {
                OnUserChanging(value);
                ReportPropertyChanging("User");
                _User = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("User");
                OnUserChanged();
            }
        }
        private global::System.String _User;
        partial void OnUserChanging(global::System.String value);
        partial void OnUserChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> Net
        {
            get
            {
                return _Net;
            }
            set
            {
                OnNetChanging(value);
                ReportPropertyChanging("Net");
                _Net = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Net");
                OnNetChanged();
            }
        }
        private Nullable<global::System.Decimal> _Net;
        partial void OnNetChanging(Nullable<global::System.Decimal> value);
        partial void OnNetChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> Time
        {
            get
            {
                return _Time;
            }
            set
            {
                OnTimeChanging(value);
                ReportPropertyChanging("Time");
                _Time = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Time");
                OnTimeChanged();
            }
        }
        private Nullable<global::System.DateTime> _Time;
        partial void OnTimeChanging(Nullable<global::System.DateTime> value);
        partial void OnTimeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ActionPreflop
        {
            get
            {
                return _ActionPreflop;
            }
            set
            {
                OnActionPreflopChanging(value);
                ReportPropertyChanging("ActionPreflop");
                _ActionPreflop = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ActionPreflop");
                OnActionPreflopChanged();
            }
        }
        private global::System.String _ActionPreflop;
        partial void OnActionPreflopChanging(global::System.String value);
        partial void OnActionPreflopChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ActionFlop
        {
            get
            {
                return _ActionFlop;
            }
            set
            {
                OnActionFlopChanging(value);
                ReportPropertyChanging("ActionFlop");
                _ActionFlop = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ActionFlop");
                OnActionFlopChanged();
            }
        }
        private global::System.String _ActionFlop;
        partial void OnActionFlopChanging(global::System.String value);
        partial void OnActionFlopChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ActionTurn
        {
            get
            {
                return _ActionTurn;
            }
            set
            {
                OnActionTurnChanging(value);
                ReportPropertyChanging("ActionTurn");
                _ActionTurn = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ActionTurn");
                OnActionTurnChanged();
            }
        }
        private global::System.String _ActionTurn;
        partial void OnActionTurnChanging(global::System.String value);
        partial void OnActionTurnChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ActionRiver
        {
            get
            {
                return _ActionRiver;
            }
            set
            {
                OnActionRiverChanging(value);
                ReportPropertyChanging("ActionRiver");
                _ActionRiver = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ActionRiver");
                OnActionRiverChanged();
            }
        }
        private global::System.String _ActionRiver;
        partial void OnActionRiverChanging(global::System.String value);
        partial void OnActionRiverChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Card1
        {
            get
            {
                return _Card1;
            }
            set
            {
                OnCard1Changing(value);
                ReportPropertyChanging("Card1");
                _Card1 = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Card1");
                OnCard1Changed();
            }
        }
        private global::System.String _Card1;
        partial void OnCard1Changing(global::System.String value);
        partial void OnCard1Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Card2
        {
            get
            {
                return _Card2;
            }
            set
            {
                OnCard2Changing(value);
                ReportPropertyChanging("Card2");
                _Card2 = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Card2");
                OnCard2Changed();
            }
        }
        private global::System.String _Card2;
        partial void OnCard2Changing(global::System.String value);
        partial void OnCard2Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> BB
        {
            get
            {
                return _BB;
            }
            set
            {
                OnBBChanging(value);
                ReportPropertyChanging("BB");
                _BB = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("BB");
                OnBBChanged();
            }
        }
        private Nullable<global::System.Decimal> _BB;
        partial void OnBBChanging(Nullable<global::System.Decimal> value);
        partial void OnBBChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Position
        {
            get
            {
                return _Position;
            }
            set
            {
                OnPositionChanging(value);
                ReportPropertyChanging("Position");
                _Position = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Position");
                OnPositionChanged();
            }
        }
        private global::System.Int32 _Position;
        partial void OnPositionChanging(global::System.Int32 value);
        partial void OnPositionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 pk
        {
            get
            {
                return _pk;
            }
            set
            {
                if (_pk != value)
                {
                    OnpkChanging(value);
                    ReportPropertyChanging("pk");
                    _pk = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("pk");
                    OnpkChanged();
                }
            }
        }
        private global::System.Int32 _pk;
        partial void OnpkChanging(global::System.Int32 value);
        partial void OnpkChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 PositionButton
        {
            get
            {
                return _PositionButton;
            }
            set
            {
                OnPositionButtonChanging(value);
                ReportPropertyChanging("PositionButton");
                _PositionButton = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("PositionButton");
                OnPositionButtonChanged();
            }
        }
        private global::System.Int32 _PositionButton;
        partial void OnPositionButtonChanging(global::System.Int32 value);
        partial void OnPositionButtonChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> Stack
        {
            get
            {
                return _Stack;
            }
            set
            {
                OnStackChanging(value);
                ReportPropertyChanging("Stack");
                _Stack = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Stack");
                OnStackChanged();
            }
        }
        private Nullable<global::System.Decimal> _Stack;
        partial void OnStackChanging(Nullable<global::System.Decimal> value);
        partial void OnStackChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ActionBlind
        {
            get
            {
                return _ActionBlind;
            }
            set
            {
                OnActionBlindChanging(value);
                ReportPropertyChanging("ActionBlind");
                _ActionBlind = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ActionBlind");
                OnActionBlindChanged();
            }
        }
        private global::System.String _ActionBlind;
        partial void OnActionBlindChanging(global::System.String value);
        partial void OnActionBlindChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String TableName
        {
            get
            {
                return _TableName;
            }
            set
            {
                OnTableNameChanging(value);
                ReportPropertyChanging("TableName");
                _TableName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("TableName");
                OnTableNameChanged();
            }
        }
        private global::System.String _TableName;
        partial void OnTableNameChanging(global::System.String value);
        partial void OnTableNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String GameType
        {
            get
            {
                return _GameType;
            }
            set
            {
                OnGameTypeChanging(value);
                ReportPropertyChanging("GameType");
                _GameType = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("GameType");
                OnGameTypeChanged();
            }
        }
        private global::System.String _GameType;
        partial void OnGameTypeChanging(global::System.String value);
        partial void OnGameTypeChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="trackDBModel", Name="LogFiles")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class LogFiles : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new LogFiles object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        public static LogFiles CreateLogFiles(global::System.Int32 id)
        {
            LogFiles logFiles = new LogFiles();
            logFiles.Id = id;
            return logFiles;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String FileName
        {
            get
            {
                return _FileName;
            }
            set
            {
                OnFileNameChanging(value);
                ReportPropertyChanging("FileName");
                _FileName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("FileName");
                OnFileNameChanged();
            }
        }
        private global::System.String _FileName;
        partial void OnFileNameChanging(global::System.String value);
        partial void OnFileNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> StartDate
        {
            get
            {
                return _StartDate;
            }
            set
            {
                OnStartDateChanging(value);
                ReportPropertyChanging("StartDate");
                _StartDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("StartDate");
                OnStartDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _StartDate;
        partial void OnStartDateChanging(Nullable<global::System.DateTime> value);
        partial void OnStartDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> EndDate
        {
            get
            {
                return _EndDate;
            }
            set
            {
                OnEndDateChanging(value);
                ReportPropertyChanging("EndDate");
                _EndDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("EndDate");
                OnEndDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _EndDate;
        partial void OnEndDateChanging(Nullable<global::System.DateTime> value);
        partial void OnEndDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Status
        {
            get
            {
                return _Status;
            }
            set
            {
                OnStatusChanging(value);
                ReportPropertyChanging("Status");
                _Status = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Status");
                OnStatusChanged();
            }
        }
        private global::System.String _Status;
        partial void OnStatusChanging(global::System.String value);
        partial void OnStatusChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String LastHandId
        {
            get
            {
                return _LastHandId;
            }
            set
            {
                OnLastHandIdChanging(value);
                ReportPropertyChanging("LastHandId");
                _LastHandId = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("LastHandId");
                OnLastHandIdChanged();
            }
        }
        private global::System.String _LastHandId;
        partial void OnLastHandIdChanging(global::System.String value);
        partial void OnLastHandIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> LastHandDate
        {
            get
            {
                return _LastHandDate;
            }
            set
            {
                OnLastHandDateChanging(value);
                ReportPropertyChanging("LastHandDate");
                _LastHandDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("LastHandDate");
                OnLastHandDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _LastHandDate;
        partial void OnLastHandDateChanging(Nullable<global::System.DateTime> value);
        partial void OnLastHandDateChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="trackDBModel", Name="LogImport")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class LogImport : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new LogImport object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        public static LogImport CreateLogImport(global::System.Int32 id)
        {
            LogImport logImport = new LogImport();
            logImport.Id = id;
            return logImport;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> BeginDate
        {
            get
            {
                return _BeginDate;
            }
            set
            {
                OnBeginDateChanging(value);
                ReportPropertyChanging("BeginDate");
                _BeginDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("BeginDate");
                OnBeginDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _BeginDate;
        partial void OnBeginDateChanging(Nullable<global::System.DateTime> value);
        partial void OnBeginDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> EndDate
        {
            get
            {
                return _EndDate;
            }
            set
            {
                OnEndDateChanging(value);
                ReportPropertyChanging("EndDate");
                _EndDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("EndDate");
                OnEndDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _EndDate;
        partial void OnEndDateChanging(Nullable<global::System.DateTime> value);
        partial void OnEndDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Status
        {
            get
            {
                return _Status;
            }
            set
            {
                OnStatusChanging(value);
                ReportPropertyChanging("Status");
                _Status = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Status");
                OnStatusChanged();
            }
        }
        private global::System.String _Status;
        partial void OnStatusChanging(global::System.String value);
        partial void OnStatusChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Directory
        {
            get
            {
                return _Directory;
            }
            set
            {
                OnDirectoryChanging(value);
                ReportPropertyChanging("Directory");
                _Directory = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Directory");
                OnDirectoryChanged();
            }
        }
        private global::System.String _Directory;
        partial void OnDirectoryChanging(global::System.String value);
        partial void OnDirectoryChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="trackDBModel", Name="MyCards")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class MyCards : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new MyCards object.
        /// </summary>
        /// <param name="handId">Initial value of the HandId property.</param>
        /// <param name="card1">Initial value of the Card1 property.</param>
        /// <param name="card2">Initial value of the Card2 property.</param>
        public static MyCards CreateMyCards(global::System.Int32 handId, global::System.String card1, global::System.String card2)
        {
            MyCards myCards = new MyCards();
            myCards.HandId = handId;
            myCards.Card1 = card1;
            myCards.Card2 = card2;
            return myCards;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 HandId
        {
            get
            {
                return _HandId;
            }
            set
            {
                if (_HandId != value)
                {
                    OnHandIdChanging(value);
                    ReportPropertyChanging("HandId");
                    _HandId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("HandId");
                    OnHandIdChanged();
                }
            }
        }
        private global::System.Int32 _HandId;
        partial void OnHandIdChanging(global::System.Int32 value);
        partial void OnHandIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Card1
        {
            get
            {
                return _Card1;
            }
            set
            {
                OnCard1Changing(value);
                ReportPropertyChanging("Card1");
                _Card1 = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Card1");
                OnCard1Changed();
            }
        }
        private global::System.String _Card1;
        partial void OnCard1Changing(global::System.String value);
        partial void OnCard1Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Card2
        {
            get
            {
                return _Card2;
            }
            set
            {
                OnCard2Changing(value);
                ReportPropertyChanging("Card2");
                _Card2 = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Card2");
                OnCard2Changed();
            }
        }
        private global::System.String _Card2;
        partial void OnCard2Changing(global::System.String value);
        partial void OnCard2Changed();

        #endregion
    
    }

    #endregion
    
}
