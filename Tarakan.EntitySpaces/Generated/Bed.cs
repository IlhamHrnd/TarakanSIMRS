
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 9/19/2024 3:12:05 PM
===============================================================================
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Linq;
using System.Data;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

using EntitySpaces.Core;
using EntitySpaces.Interfaces;
using EntitySpaces.DynamicQuery;



namespace Tarakan.EntitySpaces.Generated
{
    /// <summary>
    /// Encapsulates the 'Bed' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(Bed))]
    [XmlType("Bed")]
    public partial class Bed : esBed
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new Bed();
        }

        #region Static Quick Access Methods
        static public void Delete(string bedID)
        {
            var obj = new Bed();
            obj.BedID = bedID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string bedID, esSqlAccessType sqlAccessType)
        {
            var obj = new Bed();
            obj.BedID = bedID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("BedCollection")]
    public partial class BedCollection : esBedCollection, IEnumerable<Bed>
    {
        public Bed FindByPrimaryKey(string bedID)
        {
            return this.SingleOrDefault(e => e.BedID == bedID);
        }



    }



    [Serializable]
    public partial class BedQuery : esBedQuery
    {
        public BedQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public BedQuery(string joinAlias, out BedQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "BedQuery";
        }



        #region Explicit Casts

        public static explicit operator string(BedQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator BedQuery(string query)
        {
            return (BedQuery)SerializeHelper.FromXml(query, typeof(BedQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esBed : esEntity
    {
        public esBed()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string bedID)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(bedID);
            else
                return LoadByPrimaryKeyStoredProcedure(bedID);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string bedID)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(bedID);
            else
                return LoadByPrimaryKeyStoredProcedure(bedID);
        }

        private bool LoadByPrimaryKeyDynamic(string bedID)
        {
            BedQuery query = new BedQuery("bQ");
            query.Where(query.BedID == bedID);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string bedID)
        {
            esParameters parms = new esParameters();
            parms.Add("BedID", bedID);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to Bed.BedID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string BedID
        {
            get
            {
                return GetSystemString(BedMetadata.ColumnNames.BedID);
            }

            set
            {
                if (SetSystemString(BedMetadata.ColumnNames.BedID, value))
                {
                    OnPropertyChanged(BedMetadata.PropertyNames.BedID);
                }
            }
        }

        /// <summary>
        /// Maps to Bed.RoomID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RoomID
        {
            get
            {
                return GetSystemString(BedMetadata.ColumnNames.RoomID);
            }

            set
            {
                if (SetSystemString(BedMetadata.ColumnNames.RoomID, value))
                {
                    OnPropertyChanged(BedMetadata.PropertyNames.RoomID);
                }
            }
        }

        /// <summary>
        /// Maps to Bed.RegistrationNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RegistrationNo
        {
            get
            {
                return GetSystemString(BedMetadata.ColumnNames.RegistrationNo);
            }

            set
            {
                if (SetSystemString(BedMetadata.ColumnNames.RegistrationNo, value))
                {
                    OnPropertyChanged(BedMetadata.PropertyNames.RegistrationNo);
                }
            }
        }

        /// <summary>
        /// Maps to Bed.ClassID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ClassID
        {
            get
            {
                return GetSystemString(BedMetadata.ColumnNames.ClassID);
            }

            set
            {
                if (SetSystemString(BedMetadata.ColumnNames.ClassID, value))
                {
                    OnPropertyChanged(BedMetadata.PropertyNames.ClassID);
                }
            }
        }

        /// <summary>
        /// Maps to Bed.SRBedStatus
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRBedStatus
        {
            get
            {
                return GetSystemString(BedMetadata.ColumnNames.SRBedStatus);
            }

            set
            {
                if (SetSystemString(BedMetadata.ColumnNames.SRBedStatus, value))
                {
                    OnPropertyChanged(BedMetadata.PropertyNames.SRBedStatus);
                }
            }
        }

        /// <summary>
        /// Maps to Bed.BedStatusUpdatedBy
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string BedStatusUpdatedBy
        {
            get
            {
                return GetSystemString(BedMetadata.ColumnNames.BedStatusUpdatedBy);
            }

            set
            {
                if (SetSystemString(BedMetadata.ColumnNames.BedStatusUpdatedBy, value))
                {
                    OnPropertyChanged(BedMetadata.PropertyNames.BedStatusUpdatedBy);
                }
            }
        }

        /// <summary>
        /// Maps to Bed.IsTemporary
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsTemporary
        {
            get
            {
                return GetSystemBoolean(BedMetadata.ColumnNames.IsTemporary);
            }

            set
            {
                if (SetSystemBoolean(BedMetadata.ColumnNames.IsTemporary, value))
                {
                    OnPropertyChanged(BedMetadata.PropertyNames.IsTemporary);
                }
            }
        }

        /// <summary>
        /// Maps to Bed.IsActive
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsActive
        {
            get
            {
                return GetSystemBoolean(BedMetadata.ColumnNames.IsActive);
            }

            set
            {
                if (SetSystemBoolean(BedMetadata.ColumnNames.IsActive, value))
                {
                    OnPropertyChanged(BedMetadata.PropertyNames.IsActive);
                }
            }
        }

        /// <summary>
        /// Maps to Bed.IsNeedConfirmation
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsNeedConfirmation
        {
            get
            {
                return GetSystemBoolean(BedMetadata.ColumnNames.IsNeedConfirmation);
            }

            set
            {
                if (SetSystemBoolean(BedMetadata.ColumnNames.IsNeedConfirmation, value))
                {
                    OnPropertyChanged(BedMetadata.PropertyNames.IsNeedConfirmation);
                }
            }
        }

        /// <summary>
        /// Maps to Bed.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(BedMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(BedMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(BedMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to Bed.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(BedMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(BedMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(BedMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to Bed.IsRoomIn
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsRoomIn
        {
            get
            {
                return GetSystemBoolean(BedMetadata.ColumnNames.IsRoomIn);
            }

            set
            {
                if (SetSystemBoolean(BedMetadata.ColumnNames.IsRoomIn, value))
                {
                    OnPropertyChanged(BedMetadata.PropertyNames.IsRoomIn);
                }
            }
        }

        /// <summary>
        /// Maps to Bed.BookingDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? BookingDateTime
        {
            get
            {
                return GetSystemDateTime(BedMetadata.ColumnNames.BookingDateTime);
            }

            set
            {
                if (SetSystemDateTime(BedMetadata.ColumnNames.BookingDateTime, value))
                {
                    OnPropertyChanged(BedMetadata.PropertyNames.BookingDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to Bed.IsVisibleTo3rdParty
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsVisibleTo3rdParty
        {
            get
            {
                return GetSystemBoolean(BedMetadata.ColumnNames.IsVisibleTo3rdParty);
            }

            set
            {
                if (SetSystemBoolean(BedMetadata.ColumnNames.IsVisibleTo3rdParty, value))
                {
                    OnPropertyChanged(BedMetadata.PropertyNames.IsVisibleTo3rdParty);
                }
            }
        }

        /// <summary>
        /// Maps to Bed.OldBedID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string OldBedID
        {
            get
            {
                return GetSystemString(BedMetadata.ColumnNames.OldBedID);
            }

            set
            {
                if (SetSystemString(BedMetadata.ColumnNames.OldBedID, value))
                {
                    OnPropertyChanged(BedMetadata.PropertyNames.OldBedID);
                }
            }
        }

        /// <summary>
        /// Maps to Bed.DefaultChargeClassID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DefaultChargeClassID
        {
            get
            {
                return GetSystemString(BedMetadata.ColumnNames.DefaultChargeClassID);
            }

            set
            {
                if (SetSystemString(BedMetadata.ColumnNames.DefaultChargeClassID, value))
                {
                    OnPropertyChanged(BedMetadata.PropertyNames.DefaultChargeClassID);
                }
            }
        }

        /// <summary>
        /// Maps to Bed.Notes
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Notes
        {
            get
            {
                return GetSystemString(BedMetadata.ColumnNames.Notes);
            }

            set
            {
                if (SetSystemString(BedMetadata.ColumnNames.Notes, value))
                {
                    OnPropertyChanged(BedMetadata.PropertyNames.Notes);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return BedMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public BedQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new BedQuery("bQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(BedQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(BedQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((BedQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private BedQuery query;
    }



    [Serializable]
    abstract public partial class esBedCollection : esEntityCollection<Bed>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return BedMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "BedCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public BedQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new BedQuery("bQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(BedQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new BedQuery("bQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(BedQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((BedQuery)query);
        }

        #endregion

        private BedQuery query;
    }



    [Serializable]
    abstract public partial class esBedQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return BedMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "BedID": return BedID;
                case "RoomID": return RoomID;
                case "RegistrationNo": return RegistrationNo;
                case "ClassID": return ClassID;
                case "SRBedStatus": return SRBedStatus;
                case "BedStatusUpdatedBy": return BedStatusUpdatedBy;
                case "IsTemporary": return IsTemporary;
                case "IsActive": return IsActive;
                case "IsNeedConfirmation": return IsNeedConfirmation;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "IsRoomIn": return IsRoomIn;
                case "BookingDateTime": return BookingDateTime;
                case "IsVisibleTo3rdParty": return IsVisibleTo3rdParty;
                case "OldBedID": return OldBedID;
                case "DefaultChargeClassID": return DefaultChargeClassID;
                case "Notes": return Notes;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem BedID
        {
            get { return new esQueryItem(this, BedMetadata.ColumnNames.BedID, esSystemType.String); }
        }

        public esQueryItem RoomID
        {
            get { return new esQueryItem(this, BedMetadata.ColumnNames.RoomID, esSystemType.String); }
        }

        public esQueryItem RegistrationNo
        {
            get { return new esQueryItem(this, BedMetadata.ColumnNames.RegistrationNo, esSystemType.String); }
        }

        public esQueryItem ClassID
        {
            get { return new esQueryItem(this, BedMetadata.ColumnNames.ClassID, esSystemType.String); }
        }

        public esQueryItem SRBedStatus
        {
            get { return new esQueryItem(this, BedMetadata.ColumnNames.SRBedStatus, esSystemType.String); }
        }

        public esQueryItem BedStatusUpdatedBy
        {
            get { return new esQueryItem(this, BedMetadata.ColumnNames.BedStatusUpdatedBy, esSystemType.String); }
        }

        public esQueryItem IsTemporary
        {
            get { return new esQueryItem(this, BedMetadata.ColumnNames.IsTemporary, esSystemType.Boolean); }
        }

        public esQueryItem IsActive
        {
            get { return new esQueryItem(this, BedMetadata.ColumnNames.IsActive, esSystemType.Boolean); }
        }

        public esQueryItem IsNeedConfirmation
        {
            get { return new esQueryItem(this, BedMetadata.ColumnNames.IsNeedConfirmation, esSystemType.Boolean); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, BedMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, BedMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem IsRoomIn
        {
            get { return new esQueryItem(this, BedMetadata.ColumnNames.IsRoomIn, esSystemType.Boolean); }
        }

        public esQueryItem BookingDateTime
        {
            get { return new esQueryItem(this, BedMetadata.ColumnNames.BookingDateTime, esSystemType.DateTime); }
        }

        public esQueryItem IsVisibleTo3rdParty
        {
            get { return new esQueryItem(this, BedMetadata.ColumnNames.IsVisibleTo3rdParty, esSystemType.Boolean); }
        }

        public esQueryItem OldBedID
        {
            get { return new esQueryItem(this, BedMetadata.ColumnNames.OldBedID, esSystemType.String); }
        }

        public esQueryItem DefaultChargeClassID
        {
            get { return new esQueryItem(this, BedMetadata.ColumnNames.DefaultChargeClassID, esSystemType.String); }
        }

        public esQueryItem Notes
        {
            get { return new esQueryItem(this, BedMetadata.ColumnNames.Notes, esSystemType.String); }
        }

        #endregion

    }



    [Serializable]
    public partial class BedMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected BedMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.BedID, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.BedID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RoomID, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RoomID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RegistrationNo, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RegistrationNo;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ClassID, 3, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ClassID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRBedStatus, 4, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRBedStatus;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.BedStatusUpdatedBy, 5, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.BedStatusUpdatedBy;
            c.CharacterMaxLength = 40;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsTemporary, 6, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsTemporary;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsActive, 7, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsActive;
            c.HasDefault = true;
            c.Default = @"((1))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsNeedConfirmation, 8, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsNeedConfirmation;
            c.HasDefault = true;
            c.Default = @"((0))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 9, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 10, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 40;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsRoomIn, 11, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsRoomIn;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.BookingDateTime, 12, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.BookingDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsVisibleTo3rdParty, 13, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsVisibleTo3rdParty;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.OldBedID, 14, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.OldBedID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DefaultChargeClassID, 15, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DefaultChargeClassID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Notes, 16, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Notes;
            c.CharacterMaxLength = 500;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public BedMetadata Meta()
        {
            return meta;
        }

        public Guid DataID
        {
            get { return m_dataID; }
        }

        public bool MultiProviderMode
        {
            get { return false; }
        }

        public esColumnMetadataCollection Columns
        {
            get { return m_columns; }
        }

        #region ColumnNames
        public class ColumnNames
        {
            public const string BedID = "BedID";
            public const string RoomID = "RoomID";
            public const string RegistrationNo = "RegistrationNo";
            public const string ClassID = "ClassID";
            public const string SRBedStatus = "SRBedStatus";
            public const string BedStatusUpdatedBy = "BedStatusUpdatedBy";
            public const string IsTemporary = "IsTemporary";
            public const string IsActive = "IsActive";
            public const string IsNeedConfirmation = "IsNeedConfirmation";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string IsRoomIn = "IsRoomIn";
            public const string BookingDateTime = "BookingDateTime";
            public const string IsVisibleTo3rdParty = "IsVisibleTo3rdParty";
            public const string OldBedID = "OldBedID";
            public const string DefaultChargeClassID = "DefaultChargeClassID";
            public const string Notes = "Notes";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string BedID = "BedID";
            public const string RoomID = "RoomID";
            public const string RegistrationNo = "RegistrationNo";
            public const string ClassID = "ClassID";
            public const string SRBedStatus = "SRBedStatus";
            public const string BedStatusUpdatedBy = "BedStatusUpdatedBy";
            public const string IsTemporary = "IsTemporary";
            public const string IsActive = "IsActive";
            public const string IsNeedConfirmation = "IsNeedConfirmation";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string IsRoomIn = "IsRoomIn";
            public const string BookingDateTime = "BookingDateTime";
            public const string IsVisibleTo3rdParty = "IsVisibleTo3rdParty";
            public const string OldBedID = "OldBedID";
            public const string DefaultChargeClassID = "DefaultChargeClassID";
            public const string Notes = "Notes";
        }
        #endregion

        public esProviderSpecificMetadata GetProviderMetadata(string mapName)
        {
            MapToMeta mapMethod = mapDelegates[mapName];

            if (mapMethod != null)
                return mapMethod(mapName);
            else
                return null;
        }

        #region MAP esDefault

        static private int RegisterDelegateesDefault()
        {
            // This is only executed once per the life of the application
            lock (typeof(BedMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new BedMetadata();
                }

                MapToMeta mapMethod = new MapToMeta(meta.esDefault);
                mapDelegates.Add("esDefault", mapMethod);
                mapMethod("esDefault");
            }
            return 0;
        }

        private esProviderSpecificMetadata esDefault(string mapName)
        {
            if (!m_providerMetadataMaps.ContainsKey(mapName))
            {
                esProviderSpecificMetadata meta = new esProviderSpecificMetadata();


                meta.AddTypeMap("BedID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("RoomID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("RegistrationNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ClassID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRBedStatus", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("BedStatusUpdatedBy", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsTemporary", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsActive", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsNeedConfirmation", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsRoomIn", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("BookingDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("IsVisibleTo3rdParty", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("OldBedID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("DefaultChargeClassID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Notes", new esTypeMap("varchar", "System.String"));



                meta.Source = "Bed";
                meta.Destination = "Bed";

                meta.spInsert = "proc_BedInsert";
                meta.spUpdate = "proc_BedUpdate";
                meta.spDelete = "proc_BedDelete";
                meta.spLoadAll = "proc_BedLoadAll";
                meta.spLoadByPrimaryKey = "proc_BedLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private BedMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
