
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 2/20/2025 2:21:19 PM
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
    /// Encapsulates the 'Dtd' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(Dtd))]
    [XmlType("Dtd")]
    public partial class Dtd : esDtd
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new Dtd();
        }

        #region Static Quick Access Methods
        static public void Delete(string dtdNo)
        {
            var obj = new Dtd();
            obj.DtdNo = dtdNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string dtdNo, esSqlAccessType sqlAccessType)
        {
            var obj = new Dtd();
            obj.DtdNo = dtdNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("DtdCollection")]
    public partial class DtdCollection : esDtdCollection, IEnumerable<Dtd>
    {
        public Dtd FindByPrimaryKey(string dtdNo)
        {
            return this.SingleOrDefault(e => e.DtdNo == dtdNo);
        }



    }



    [Serializable]
    public partial class DtdQuery : esDtdQuery
    {
        public DtdQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public DtdQuery(string joinAlias, out DtdQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "DtdQuery";
        }



        #region Explicit Casts

        public static explicit operator string(DtdQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator DtdQuery(string query)
        {
            return (DtdQuery)SerializeHelper.FromXml(query, typeof(DtdQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esDtd : esEntity
    {
        public esDtd()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string dtdNo)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(dtdNo);
            else
                return LoadByPrimaryKeyStoredProcedure(dtdNo);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string dtdNo)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(dtdNo);
            else
                return LoadByPrimaryKeyStoredProcedure(dtdNo);
        }

        private bool LoadByPrimaryKeyDynamic(string dtdNo)
        {
            DtdQuery query = new DtdQuery("dQ");
            query.Where(query.DtdNo == dtdNo);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string dtdNo)
        {
            esParameters parms = new esParameters();
            parms.Add("DtdNo", dtdNo);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to Dtd.DtdNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DtdNo
        {
            get
            {
                return GetSystemString(DtdMetadata.ColumnNames.DtdNo);
            }

            set
            {
                if (SetSystemString(DtdMetadata.ColumnNames.DtdNo, value))
                {
                    OnPropertyChanged(DtdMetadata.PropertyNames.DtdNo);
                }
            }
        }

        /// <summary>
        /// Maps to Dtd.DtdName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DtdName
        {
            get
            {
                return GetSystemString(DtdMetadata.ColumnNames.DtdName);
            }

            set
            {
                if (SetSystemString(DtdMetadata.ColumnNames.DtdName, value))
                {
                    OnPropertyChanged(DtdMetadata.PropertyNames.DtdName);
                }
            }
        }

        /// <summary>
        /// Maps to Dtd.DtdLabel
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DtdLabel
        {
            get
            {
                return GetSystemString(DtdMetadata.ColumnNames.DtdLabel);
            }

            set
            {
                if (SetSystemString(DtdMetadata.ColumnNames.DtdLabel, value))
                {
                    OnPropertyChanged(DtdMetadata.PropertyNames.DtdLabel);
                }
            }
        }

        /// <summary>
        /// Maps to Dtd.IsActive
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsActive
        {
            get
            {
                return GetSystemBoolean(DtdMetadata.ColumnNames.IsActive);
            }

            set
            {
                if (SetSystemBoolean(DtdMetadata.ColumnNames.IsActive, value))
                {
                    OnPropertyChanged(DtdMetadata.PropertyNames.IsActive);
                }
            }
        }

        /// <summary>
        /// Maps to Dtd.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(DtdMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(DtdMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(DtdMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to Dtd.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(DtdMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(DtdMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(DtdMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to Dtd.SRChronicDisease
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRChronicDisease
        {
            get
            {
                return GetSystemString(DtdMetadata.ColumnNames.SRChronicDisease);
            }

            set
            {
                if (SetSystemString(DtdMetadata.ColumnNames.SRChronicDisease, value))
                {
                    OnPropertyChanged(DtdMetadata.PropertyNames.SRChronicDisease);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return DtdMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public DtdQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new DtdQuery("dQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(DtdQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(DtdQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((DtdQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private DtdQuery query;
    }



    [Serializable]
    abstract public partial class esDtdCollection : esEntityCollection<Dtd>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return DtdMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "DtdCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public DtdQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new DtdQuery("dQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(DtdQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new DtdQuery("dQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(DtdQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((DtdQuery)query);
        }

        #endregion

        private DtdQuery query;
    }



    [Serializable]
    abstract public partial class esDtdQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return DtdMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "DtdNo": return DtdNo;
                case "DtdName": return DtdName;
                case "DtdLabel": return DtdLabel;
                case "IsActive": return IsActive;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "SRChronicDisease": return SRChronicDisease;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem DtdNo
        {
            get { return new esQueryItem(this, DtdMetadata.ColumnNames.DtdNo, esSystemType.String); }
        }

        public esQueryItem DtdName
        {
            get { return new esQueryItem(this, DtdMetadata.ColumnNames.DtdName, esSystemType.String); }
        }

        public esQueryItem DtdLabel
        {
            get { return new esQueryItem(this, DtdMetadata.ColumnNames.DtdLabel, esSystemType.String); }
        }

        public esQueryItem IsActive
        {
            get { return new esQueryItem(this, DtdMetadata.ColumnNames.IsActive, esSystemType.Boolean); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, DtdMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, DtdMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem SRChronicDisease
        {
            get { return new esQueryItem(this, DtdMetadata.ColumnNames.SRChronicDisease, esSystemType.String); }
        }

        #endregion

    }



    [Serializable]
    public partial class DtdMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected DtdMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.DtdNo, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DtdNo;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DtdName, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DtdName;
            c.CharacterMaxLength = 500;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DtdLabel, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DtdLabel;
            c.CharacterMaxLength = 500;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsActive, 3, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsActive;
            c.HasDefault = true;
            c.Default = @"((1))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 4, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 5, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 40;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRChronicDisease, 6, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRChronicDisease;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public DtdMetadata Meta()
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
            public const string DtdNo = "DtdNo";
            public const string DtdName = "DtdName";
            public const string DtdLabel = "DtdLabel";
            public const string IsActive = "IsActive";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string SRChronicDisease = "SRChronicDisease";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string DtdNo = "DtdNo";
            public const string DtdName = "DtdName";
            public const string DtdLabel = "DtdLabel";
            public const string IsActive = "IsActive";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string SRChronicDisease = "SRChronicDisease";
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
            lock (typeof(DtdMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new DtdMetadata();
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


                meta.AddTypeMap("DtdNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("DtdName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("DtdLabel", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsActive", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRChronicDisease", new esTypeMap("varchar", "System.String"));



                meta.Source = "Dtd";
                meta.Destination = "Dtd";

                meta.spInsert = "proc_DtdInsert";
                meta.spUpdate = "proc_DtdUpdate";
                meta.spDelete = "proc_DtdDelete";
                meta.spLoadAll = "proc_DtdLoadAll";
                meta.spLoadByPrimaryKey = "proc_DtdLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private DtdMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
