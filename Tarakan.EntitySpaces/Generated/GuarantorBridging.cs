
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 2/17/2025 9:03:08 AM
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
    /// Encapsulates the 'GuarantorBridging' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(GuarantorBridging))]
    [XmlType("GuarantorBridging")]
    public partial class GuarantorBridging : esGuarantorBridging
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new GuarantorBridging();
        }

        #region Static Quick Access Methods
        static public void Delete(string guarantorID, string sRBridgingType, string bridgingID)
        {
            var obj = new GuarantorBridging();
            obj.GuarantorID = guarantorID;
            obj.SRBridgingType = sRBridgingType;
            obj.BridgingID = bridgingID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string guarantorID, string sRBridgingType, string bridgingID, esSqlAccessType sqlAccessType)
        {
            var obj = new GuarantorBridging();
            obj.GuarantorID = guarantorID;
            obj.SRBridgingType = sRBridgingType;
            obj.BridgingID = bridgingID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("GuarantorBridgingCollection")]
    public partial class GuarantorBridgingCollection : esGuarantorBridgingCollection, IEnumerable<GuarantorBridging>
    {
        public GuarantorBridging FindByPrimaryKey(string guarantorID, string sRBridgingType, string bridgingID)
        {
            return this.SingleOrDefault(e => e.GuarantorID == guarantorID && e.SRBridgingType == sRBridgingType && e.BridgingID == bridgingID);
        }



    }



    [Serializable]
    public partial class GuarantorBridgingQuery : esGuarantorBridgingQuery
    {
        public GuarantorBridgingQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public GuarantorBridgingQuery(string joinAlias, out GuarantorBridgingQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "GuarantorBridgingQuery";
        }



        #region Explicit Casts

        public static explicit operator string(GuarantorBridgingQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator GuarantorBridgingQuery(string query)
        {
            return (GuarantorBridgingQuery)SerializeHelper.FromXml(query, typeof(GuarantorBridgingQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esGuarantorBridging : esEntity
    {
        public esGuarantorBridging()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string guarantorID, string sRBridgingType, string bridgingID)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(guarantorID, sRBridgingType, bridgingID);
            else
                return LoadByPrimaryKeyStoredProcedure(guarantorID, sRBridgingType, bridgingID);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string guarantorID, string sRBridgingType, string bridgingID)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(guarantorID, sRBridgingType, bridgingID);
            else
                return LoadByPrimaryKeyStoredProcedure(guarantorID, sRBridgingType, bridgingID);
        }

        private bool LoadByPrimaryKeyDynamic(string guarantorID, string sRBridgingType, string bridgingID)
        {
            GuarantorBridgingQuery query = new GuarantorBridgingQuery("gbQ");
            query.Where(query.GuarantorID == guarantorID, query.SRBridgingType == sRBridgingType, query.BridgingID == bridgingID);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string guarantorID, string sRBridgingType, string bridgingID)
        {
            esParameters parms = new esParameters();
            parms.Add("GuarantorID", guarantorID); parms.Add("SRBridgingType", sRBridgingType); parms.Add("BridgingID", bridgingID);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to GuarantorBridging.GuarantorID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string GuarantorID
        {
            get
            {
                return GetSystemString(GuarantorBridgingMetadata.ColumnNames.GuarantorID);
            }

            set
            {
                if (SetSystemString(GuarantorBridgingMetadata.ColumnNames.GuarantorID, value))
                {
                    OnPropertyChanged(GuarantorBridgingMetadata.PropertyNames.GuarantorID);
                }
            }
        }

        /// <summary>
        /// Maps to GuarantorBridging.SRBridgingType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRBridgingType
        {
            get
            {
                return GetSystemString(GuarantorBridgingMetadata.ColumnNames.SRBridgingType);
            }

            set
            {
                if (SetSystemString(GuarantorBridgingMetadata.ColumnNames.SRBridgingType, value))
                {
                    OnPropertyChanged(GuarantorBridgingMetadata.PropertyNames.SRBridgingType);
                }
            }
        }

        /// <summary>
        /// Maps to GuarantorBridging.IsActive
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsActive
        {
            get
            {
                return GetSystemBoolean(GuarantorBridgingMetadata.ColumnNames.IsActive);
            }

            set
            {
                if (SetSystemBoolean(GuarantorBridgingMetadata.ColumnNames.IsActive, value))
                {
                    OnPropertyChanged(GuarantorBridgingMetadata.PropertyNames.IsActive);
                }
            }
        }

        /// <summary>
        /// Maps to GuarantorBridging.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(GuarantorBridgingMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(GuarantorBridgingMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(GuarantorBridgingMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to GuarantorBridging.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(GuarantorBridgingMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(GuarantorBridgingMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(GuarantorBridgingMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to GuarantorBridging.IsPercentageCoverageValue
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsPercentageCoverageValue
        {
            get
            {
                return GetSystemBoolean(GuarantorBridgingMetadata.ColumnNames.IsPercentageCoverageValue);
            }

            set
            {
                if (SetSystemBoolean(GuarantorBridgingMetadata.ColumnNames.IsPercentageCoverageValue, value))
                {
                    OnPropertyChanged(GuarantorBridgingMetadata.PropertyNames.IsPercentageCoverageValue);
                }
            }
        }

        /// <summary>
        /// Maps to GuarantorBridging.CoverageValue
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? CoverageValue
        {
            get
            {
                return GetSystemDecimal(GuarantorBridgingMetadata.ColumnNames.CoverageValue);
            }

            set
            {
                if (SetSystemDecimal(GuarantorBridgingMetadata.ColumnNames.CoverageValue, value))
                {
                    OnPropertyChanged(GuarantorBridgingMetadata.PropertyNames.CoverageValue);
                }
            }
        }

        /// <summary>
        /// Maps to GuarantorBridging.MarginValue
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? MarginValue
        {
            get
            {
                return GetSystemDecimal(GuarantorBridgingMetadata.ColumnNames.MarginValue);
            }

            set
            {
                if (SetSystemDecimal(GuarantorBridgingMetadata.ColumnNames.MarginValue, value))
                {
                    OnPropertyChanged(GuarantorBridgingMetadata.PropertyNames.MarginValue);
                }
            }
        }

        /// <summary>
        /// Maps to GuarantorBridging.BridgingID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string BridgingID
        {
            get
            {
                return GetSystemString(GuarantorBridgingMetadata.ColumnNames.BridgingID);
            }

            set
            {
                if (SetSystemString(GuarantorBridgingMetadata.ColumnNames.BridgingID, value))
                {
                    OnPropertyChanged(GuarantorBridgingMetadata.PropertyNames.BridgingID);
                }
            }
        }

        /// <summary>
        /// Maps to GuarantorBridging.BridgingCode
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string BridgingCode
        {
            get
            {
                return GetSystemString(GuarantorBridgingMetadata.ColumnNames.BridgingCode);
            }

            set
            {
                if (SetSystemString(GuarantorBridgingMetadata.ColumnNames.BridgingCode, value))
                {
                    OnPropertyChanged(GuarantorBridgingMetadata.PropertyNames.BridgingCode);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return GuarantorBridgingMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public GuarantorBridgingQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new GuarantorBridgingQuery("gbQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(GuarantorBridgingQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(GuarantorBridgingQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((GuarantorBridgingQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private GuarantorBridgingQuery query;
    }



    [Serializable]
    abstract public partial class esGuarantorBridgingCollection : esEntityCollection<GuarantorBridging>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return GuarantorBridgingMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "GuarantorBridgingCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public GuarantorBridgingQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new GuarantorBridgingQuery("gbQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(GuarantorBridgingQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new GuarantorBridgingQuery("gbQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(GuarantorBridgingQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((GuarantorBridgingQuery)query);
        }

        #endregion

        private GuarantorBridgingQuery query;
    }



    [Serializable]
    abstract public partial class esGuarantorBridgingQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return GuarantorBridgingMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "GuarantorID": return GuarantorID;
                case "SRBridgingType": return SRBridgingType;
                case "IsActive": return IsActive;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "IsPercentageCoverageValue": return IsPercentageCoverageValue;
                case "CoverageValue": return CoverageValue;
                case "MarginValue": return MarginValue;
                case "BridgingID": return BridgingID;
                case "BridgingCode": return BridgingCode;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem GuarantorID
        {
            get { return new esQueryItem(this, GuarantorBridgingMetadata.ColumnNames.GuarantorID, esSystemType.String); }
        }

        public esQueryItem SRBridgingType
        {
            get { return new esQueryItem(this, GuarantorBridgingMetadata.ColumnNames.SRBridgingType, esSystemType.String); }
        }

        public esQueryItem IsActive
        {
            get { return new esQueryItem(this, GuarantorBridgingMetadata.ColumnNames.IsActive, esSystemType.Boolean); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, GuarantorBridgingMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, GuarantorBridgingMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem IsPercentageCoverageValue
        {
            get { return new esQueryItem(this, GuarantorBridgingMetadata.ColumnNames.IsPercentageCoverageValue, esSystemType.Boolean); }
        }

        public esQueryItem CoverageValue
        {
            get { return new esQueryItem(this, GuarantorBridgingMetadata.ColumnNames.CoverageValue, esSystemType.Decimal); }
        }

        public esQueryItem MarginValue
        {
            get { return new esQueryItem(this, GuarantorBridgingMetadata.ColumnNames.MarginValue, esSystemType.Decimal); }
        }

        public esQueryItem BridgingID
        {
            get { return new esQueryItem(this, GuarantorBridgingMetadata.ColumnNames.BridgingID, esSystemType.String); }
        }

        public esQueryItem BridgingCode
        {
            get { return new esQueryItem(this, GuarantorBridgingMetadata.ColumnNames.BridgingCode, esSystemType.String); }
        }

        #endregion

    }



    [Serializable]
    public partial class GuarantorBridgingMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected GuarantorBridgingMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.GuarantorID, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.GuarantorID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 10;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRBridgingType, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRBridgingType;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 20;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsActive, 2, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsActive;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 3, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 4, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 40;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsPercentageCoverageValue, 5, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsPercentageCoverageValue;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CoverageValue, 6, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.CoverageValue;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.MarginValue, 7, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.MarginValue;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.BridgingID, 8, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.BridgingID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 10;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.BridgingCode, 9, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.BridgingCode;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public GuarantorBridgingMetadata Meta()
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
            public const string GuarantorID = "GuarantorID";
            public const string SRBridgingType = "SRBridgingType";
            public const string IsActive = "IsActive";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string IsPercentageCoverageValue = "IsPercentageCoverageValue";
            public const string CoverageValue = "CoverageValue";
            public const string MarginValue = "MarginValue";
            public const string BridgingID = "BridgingID";
            public const string BridgingCode = "BridgingCode";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string GuarantorID = "GuarantorID";
            public const string SRBridgingType = "SRBridgingType";
            public const string IsActive = "IsActive";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string IsPercentageCoverageValue = "IsPercentageCoverageValue";
            public const string CoverageValue = "CoverageValue";
            public const string MarginValue = "MarginValue";
            public const string BridgingID = "BridgingID";
            public const string BridgingCode = "BridgingCode";
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
            lock (typeof(GuarantorBridgingMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new GuarantorBridgingMetadata();
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


                meta.AddTypeMap("GuarantorID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRBridgingType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsActive", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsPercentageCoverageValue", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("CoverageValue", new esTypeMap("decimal", "System.Decimal"));
                meta.AddTypeMap("MarginValue", new esTypeMap("decimal", "System.Decimal"));
                meta.AddTypeMap("BridgingID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("BridgingCode", new esTypeMap("varchar", "System.String"));



                meta.Source = "GuarantorBridging";
                meta.Destination = "GuarantorBridging";

                meta.spInsert = "proc_GuarantorBridgingInsert";
                meta.spUpdate = "proc_GuarantorBridgingUpdate";
                meta.spDelete = "proc_GuarantorBridgingDelete";
                meta.spLoadAll = "proc_GuarantorBridgingLoadAll";
                meta.spLoadByPrimaryKey = "proc_GuarantorBridgingLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private GuarantorBridgingMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
