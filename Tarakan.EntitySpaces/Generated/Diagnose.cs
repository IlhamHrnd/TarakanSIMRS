
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 2/20/2025 2:20:58 PM
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
    /// Encapsulates the 'Diagnose' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(Diagnose))]
    [XmlType("Diagnose")]
    public partial class Diagnose : esDiagnose
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new Diagnose();
        }

        #region Static Quick Access Methods
        static public void Delete(string diagnoseID)
        {
            var obj = new Diagnose();
            obj.DiagnoseID = diagnoseID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string diagnoseID, esSqlAccessType sqlAccessType)
        {
            var obj = new Diagnose();
            obj.DiagnoseID = diagnoseID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("DiagnoseCollection")]
    public partial class DiagnoseCollection : esDiagnoseCollection, IEnumerable<Diagnose>
    {
        public Diagnose FindByPrimaryKey(string diagnoseID)
        {
            return this.SingleOrDefault(e => e.DiagnoseID == diagnoseID);
        }



    }



    [Serializable]
    public partial class DiagnoseQuery : esDiagnoseQuery
    {
        public DiagnoseQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public DiagnoseQuery(string joinAlias, out DiagnoseQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "DiagnoseQuery";
        }



        #region Explicit Casts

        public static explicit operator string(DiagnoseQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator DiagnoseQuery(string query)
        {
            return (DiagnoseQuery)SerializeHelper.FromXml(query, typeof(DiagnoseQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esDiagnose : esEntity
    {
        public esDiagnose()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string diagnoseID)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(diagnoseID);
            else
                return LoadByPrimaryKeyStoredProcedure(diagnoseID);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string diagnoseID)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(diagnoseID);
            else
                return LoadByPrimaryKeyStoredProcedure(diagnoseID);
        }

        private bool LoadByPrimaryKeyDynamic(string diagnoseID)
        {
            DiagnoseQuery query = new DiagnoseQuery("dQ");
            query.Where(query.DiagnoseID == diagnoseID);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string diagnoseID)
        {
            esParameters parms = new esParameters();
            parms.Add("DiagnoseID", diagnoseID);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to Diagnose.DiagnoseID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DiagnoseID
        {
            get
            {
                return GetSystemString(DiagnoseMetadata.ColumnNames.DiagnoseID);
            }

            set
            {
                if (SetSystemString(DiagnoseMetadata.ColumnNames.DiagnoseID, value))
                {
                    OnPropertyChanged(DiagnoseMetadata.PropertyNames.DiagnoseID);
                }
            }
        }

        /// <summary>
        /// Maps to Diagnose.DtdNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DtdNo
        {
            get
            {
                return GetSystemString(DiagnoseMetadata.ColumnNames.DtdNo);
            }

            set
            {
                if (SetSystemString(DiagnoseMetadata.ColumnNames.DtdNo, value))
                {
                    OnPropertyChanged(DiagnoseMetadata.PropertyNames.DtdNo);
                }
            }
        }

        /// <summary>
        /// Maps to Diagnose.DiagnoseName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DiagnoseName
        {
            get
            {
                return GetSystemString(DiagnoseMetadata.ColumnNames.DiagnoseName);
            }

            set
            {
                if (SetSystemString(DiagnoseMetadata.ColumnNames.DiagnoseName, value))
                {
                    OnPropertyChanged(DiagnoseMetadata.PropertyNames.DiagnoseName);
                }
            }
        }

        /// <summary>
        /// Maps to Diagnose.IsChronicDisease
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsChronicDisease
        {
            get
            {
                return GetSystemBoolean(DiagnoseMetadata.ColumnNames.IsChronicDisease);
            }

            set
            {
                if (SetSystemBoolean(DiagnoseMetadata.ColumnNames.IsChronicDisease, value))
                {
                    OnPropertyChanged(DiagnoseMetadata.PropertyNames.IsChronicDisease);
                }
            }
        }

        /// <summary>
        /// Maps to Diagnose.IsDisease
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsDisease
        {
            get
            {
                return GetSystemBoolean(DiagnoseMetadata.ColumnNames.IsDisease);
            }

            set
            {
                if (SetSystemBoolean(DiagnoseMetadata.ColumnNames.IsDisease, value))
                {
                    OnPropertyChanged(DiagnoseMetadata.PropertyNames.IsDisease);
                }
            }
        }

        /// <summary>
        /// Maps to Diagnose.IsActive
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsActive
        {
            get
            {
                return GetSystemBoolean(DiagnoseMetadata.ColumnNames.IsActive);
            }

            set
            {
                if (SetSystemBoolean(DiagnoseMetadata.ColumnNames.IsActive, value))
                {
                    OnPropertyChanged(DiagnoseMetadata.PropertyNames.IsActive);
                }
            }
        }

        /// <summary>
        /// Maps to Diagnose.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(DiagnoseMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(DiagnoseMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(DiagnoseMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to Diagnose.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(DiagnoseMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(DiagnoseMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(DiagnoseMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to Diagnose.Synonym
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Synonym
        {
            get
            {
                return GetSystemString(DiagnoseMetadata.ColumnNames.Synonym);
            }

            set
            {
                if (SetSystemString(DiagnoseMetadata.ColumnNames.Synonym, value))
                {
                    OnPropertyChanged(DiagnoseMetadata.PropertyNames.Synonym);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return DiagnoseMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public DiagnoseQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new DiagnoseQuery("dQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(DiagnoseQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(DiagnoseQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((DiagnoseQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private DiagnoseQuery query;
    }



    [Serializable]
    abstract public partial class esDiagnoseCollection : esEntityCollection<Diagnose>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return DiagnoseMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "DiagnoseCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public DiagnoseQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new DiagnoseQuery("dQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(DiagnoseQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new DiagnoseQuery("dQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(DiagnoseQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((DiagnoseQuery)query);
        }

        #endregion

        private DiagnoseQuery query;
    }



    [Serializable]
    abstract public partial class esDiagnoseQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return DiagnoseMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "DiagnoseID": return DiagnoseID;
                case "DtdNo": return DtdNo;
                case "DiagnoseName": return DiagnoseName;
                case "IsChronicDisease": return IsChronicDisease;
                case "IsDisease": return IsDisease;
                case "IsActive": return IsActive;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "Synonym": return Synonym;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem DiagnoseID
        {
            get { return new esQueryItem(this, DiagnoseMetadata.ColumnNames.DiagnoseID, esSystemType.String); }
        }

        public esQueryItem DtdNo
        {
            get { return new esQueryItem(this, DiagnoseMetadata.ColumnNames.DtdNo, esSystemType.String); }
        }

        public esQueryItem DiagnoseName
        {
            get { return new esQueryItem(this, DiagnoseMetadata.ColumnNames.DiagnoseName, esSystemType.String); }
        }

        public esQueryItem IsChronicDisease
        {
            get { return new esQueryItem(this, DiagnoseMetadata.ColumnNames.IsChronicDisease, esSystemType.Boolean); }
        }

        public esQueryItem IsDisease
        {
            get { return new esQueryItem(this, DiagnoseMetadata.ColumnNames.IsDisease, esSystemType.Boolean); }
        }

        public esQueryItem IsActive
        {
            get { return new esQueryItem(this, DiagnoseMetadata.ColumnNames.IsActive, esSystemType.Boolean); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, DiagnoseMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, DiagnoseMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem Synonym
        {
            get { return new esQueryItem(this, DiagnoseMetadata.ColumnNames.Synonym, esSystemType.String); }
        }

        #endregion

    }



    [Serializable]
    public partial class DiagnoseMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected DiagnoseMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.DiagnoseID, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DiagnoseID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DtdNo, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DtdNo;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DiagnoseName, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DiagnoseName;
            c.CharacterMaxLength = 500;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsChronicDisease, 3, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsChronicDisease;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsDisease, 4, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsDisease;
            c.HasDefault = true;
            c.Default = @"((1))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsActive, 5, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsActive;
            c.HasDefault = true;
            c.Default = @"((1))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 6, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 7, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 40;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Synonym, 8, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Synonym;
            c.CharacterMaxLength = 200;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public DiagnoseMetadata Meta()
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
            public const string DiagnoseID = "DiagnoseID";
            public const string DtdNo = "DtdNo";
            public const string DiagnoseName = "DiagnoseName";
            public const string IsChronicDisease = "IsChronicDisease";
            public const string IsDisease = "IsDisease";
            public const string IsActive = "IsActive";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string Synonym = "Synonym";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string DiagnoseID = "DiagnoseID";
            public const string DtdNo = "DtdNo";
            public const string DiagnoseName = "DiagnoseName";
            public const string IsChronicDisease = "IsChronicDisease";
            public const string IsDisease = "IsDisease";
            public const string IsActive = "IsActive";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string Synonym = "Synonym";
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
            lock (typeof(DiagnoseMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new DiagnoseMetadata();
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


                meta.AddTypeMap("DiagnoseID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("DtdNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("DiagnoseName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsChronicDisease", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsDisease", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsActive", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Synonym", new esTypeMap("varchar", "System.String"));



                meta.Source = "Diagnose";
                meta.Destination = "Diagnose";

                meta.spInsert = "proc_DiagnoseInsert";
                meta.spUpdate = "proc_DiagnoseUpdate";
                meta.spDelete = "proc_DiagnoseDelete";
                meta.spLoadAll = "proc_DiagnoseLoadAll";
                meta.spLoadByPrimaryKey = "proc_DiagnoseLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private DiagnoseMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
