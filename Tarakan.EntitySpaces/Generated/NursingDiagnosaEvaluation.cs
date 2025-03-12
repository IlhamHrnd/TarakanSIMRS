
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 3/12/2025 11:22:11 AM
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
    /// Encapsulates the 'NursingDiagnosaEvaluation' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(NursingDiagnosaEvaluation))]
    [XmlType("NursingDiagnosaEvaluation")]
    public partial class NursingDiagnosaEvaluation : esNursingDiagnosaEvaluation
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new NursingDiagnosaEvaluation();
        }

        #region Static Quick Access Methods
        static public void Delete(long id)
        {
            var obj = new NursingDiagnosaEvaluation();
            obj.Id = id;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(long id, esSqlAccessType sqlAccessType)
        {
            var obj = new NursingDiagnosaEvaluation();
            obj.Id = id;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("NursingDiagnosaEvaluationCollection")]
    public partial class NursingDiagnosaEvaluationCollection : esNursingDiagnosaEvaluationCollection, IEnumerable<NursingDiagnosaEvaluation>
    {
        public NursingDiagnosaEvaluation FindByPrimaryKey(long id)
        {
            return this.SingleOrDefault(e => e.Id == id);
        }



    }



    [Serializable]
    public partial class NursingDiagnosaEvaluationQuery : esNursingDiagnosaEvaluationQuery
    {
        public NursingDiagnosaEvaluationQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public NursingDiagnosaEvaluationQuery(string joinAlias, out NursingDiagnosaEvaluationQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "NursingDiagnosaEvaluationQuery";
        }



        #region Explicit Casts

        public static explicit operator string(NursingDiagnosaEvaluationQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator NursingDiagnosaEvaluationQuery(string query)
        {
            return (NursingDiagnosaEvaluationQuery)SerializeHelper.FromXml(query, typeof(NursingDiagnosaEvaluationQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esNursingDiagnosaEvaluation : esEntity
    {
        public esNursingDiagnosaEvaluation()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(long id)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(id);
            else
                return LoadByPrimaryKeyStoredProcedure(id);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, long id)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(id);
            else
                return LoadByPrimaryKeyStoredProcedure(id);
        }

        private bool LoadByPrimaryKeyDynamic(long id)
        {
            NursingDiagnosaEvaluationQuery query = new NursingDiagnosaEvaluationQuery("ndeQ");
            query.Where(query.Id == id);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(long id)
        {
            esParameters parms = new esParameters();
            parms.Add("Id", id);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to NursingDiagnosaEvaluation.ID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public long? Id
        {
            get
            {
                return GetSystemInt64(NursingDiagnosaEvaluationMetadata.ColumnNames.Id);
            }

            set
            {
                if (SetSystemInt64(NursingDiagnosaEvaluationMetadata.ColumnNames.Id, value))
                {
                    OnPropertyChanged(NursingDiagnosaEvaluationMetadata.PropertyNames.Id);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaEvaluation.EvaluationID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public long? EvaluationID
        {
            get
            {
                return GetSystemInt64(NursingDiagnosaEvaluationMetadata.ColumnNames.EvaluationID);
            }

            set
            {
                if (SetSystemInt64(NursingDiagnosaEvaluationMetadata.ColumnNames.EvaluationID, value))
                {
                    OnPropertyChanged(NursingDiagnosaEvaluationMetadata.PropertyNames.EvaluationID);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaEvaluation.InterventionID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public long? InterventionID
        {
            get
            {
                return GetSystemInt64(NursingDiagnosaEvaluationMetadata.ColumnNames.InterventionID);
            }

            set
            {
                if (SetSystemInt64(NursingDiagnosaEvaluationMetadata.ColumnNames.InterventionID, value))
                {
                    OnPropertyChanged(NursingDiagnosaEvaluationMetadata.PropertyNames.InterventionID);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaEvaluation.NursingInterventionID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string NursingInterventionID
        {
            get
            {
                return GetSystemString(NursingDiagnosaEvaluationMetadata.ColumnNames.NursingInterventionID);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaEvaluationMetadata.ColumnNames.NursingInterventionID, value))
                {
                    OnPropertyChanged(NursingDiagnosaEvaluationMetadata.PropertyNames.NursingInterventionID);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaEvaluation.SRNursingCarePlanning
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRNursingCarePlanning
        {
            get
            {
                return GetSystemString(NursingDiagnosaEvaluationMetadata.ColumnNames.SRNursingCarePlanning);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaEvaluationMetadata.ColumnNames.SRNursingCarePlanning, value))
                {
                    OnPropertyChanged(NursingDiagnosaEvaluationMetadata.PropertyNames.SRNursingCarePlanning);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaEvaluation.CreateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string CreateByUserID
        {
            get
            {
                return GetSystemString(NursingDiagnosaEvaluationMetadata.ColumnNames.CreateByUserID);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaEvaluationMetadata.ColumnNames.CreateByUserID, value))
                {
                    OnPropertyChanged(NursingDiagnosaEvaluationMetadata.PropertyNames.CreateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaEvaluation.CreateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? CreateDateTime
        {
            get
            {
                return GetSystemDateTime(NursingDiagnosaEvaluationMetadata.ColumnNames.CreateDateTime);
            }

            set
            {
                if (SetSystemDateTime(NursingDiagnosaEvaluationMetadata.ColumnNames.CreateDateTime, value))
                {
                    OnPropertyChanged(NursingDiagnosaEvaluationMetadata.PropertyNames.CreateDateTime);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return NursingDiagnosaEvaluationMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public NursingDiagnosaEvaluationQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new NursingDiagnosaEvaluationQuery("ndeQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(NursingDiagnosaEvaluationQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(NursingDiagnosaEvaluationQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((NursingDiagnosaEvaluationQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private NursingDiagnosaEvaluationQuery query;
    }



    [Serializable]
    abstract public partial class esNursingDiagnosaEvaluationCollection : esEntityCollection<NursingDiagnosaEvaluation>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return NursingDiagnosaEvaluationMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "NursingDiagnosaEvaluationCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public NursingDiagnosaEvaluationQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new NursingDiagnosaEvaluationQuery("ndeQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(NursingDiagnosaEvaluationQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new NursingDiagnosaEvaluationQuery("ndeQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(NursingDiagnosaEvaluationQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((NursingDiagnosaEvaluationQuery)query);
        }

        #endregion

        private NursingDiagnosaEvaluationQuery query;
    }



    [Serializable]
    abstract public partial class esNursingDiagnosaEvaluationQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return NursingDiagnosaEvaluationMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "Id": return Id;
                case "EvaluationID": return EvaluationID;
                case "InterventionID": return InterventionID;
                case "NursingInterventionID": return NursingInterventionID;
                case "SRNursingCarePlanning": return SRNursingCarePlanning;
                case "CreateByUserID": return CreateByUserID;
                case "CreateDateTime": return CreateDateTime;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem Id
        {
            get { return new esQueryItem(this, NursingDiagnosaEvaluationMetadata.ColumnNames.Id, esSystemType.Int64); }
        }

        public esQueryItem EvaluationID
        {
            get { return new esQueryItem(this, NursingDiagnosaEvaluationMetadata.ColumnNames.EvaluationID, esSystemType.Int64); }
        }

        public esQueryItem InterventionID
        {
            get { return new esQueryItem(this, NursingDiagnosaEvaluationMetadata.ColumnNames.InterventionID, esSystemType.Int64); }
        }

        public esQueryItem NursingInterventionID
        {
            get { return new esQueryItem(this, NursingDiagnosaEvaluationMetadata.ColumnNames.NursingInterventionID, esSystemType.String); }
        }

        public esQueryItem SRNursingCarePlanning
        {
            get { return new esQueryItem(this, NursingDiagnosaEvaluationMetadata.ColumnNames.SRNursingCarePlanning, esSystemType.String); }
        }

        public esQueryItem CreateByUserID
        {
            get { return new esQueryItem(this, NursingDiagnosaEvaluationMetadata.ColumnNames.CreateByUserID, esSystemType.String); }
        }

        public esQueryItem CreateDateTime
        {
            get { return new esQueryItem(this, NursingDiagnosaEvaluationMetadata.ColumnNames.CreateDateTime, esSystemType.DateTime); }
        }

        #endregion

    }



    [Serializable]
    public partial class NursingDiagnosaEvaluationMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected NursingDiagnosaEvaluationMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.Id, 0, typeof(long), esSystemType.Int64);
            c.PropertyName = PropertyNames.Id;
            c.IsInPrimaryKey = true;
            c.IsAutoIncrement = true;
            c.NumericPrecision = 19;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.EvaluationID, 1, typeof(long), esSystemType.Int64);
            c.PropertyName = PropertyNames.EvaluationID;
            c.NumericPrecision = 19;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.InterventionID, 2, typeof(long), esSystemType.Int64);
            c.PropertyName = PropertyNames.InterventionID;
            c.NumericPrecision = 19;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.NursingInterventionID, 3, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.NursingInterventionID;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRNursingCarePlanning, 4, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRNursingCarePlanning;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreateByUserID, 5, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.CreateByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreateDateTime, 6, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.CreateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public NursingDiagnosaEvaluationMetadata Meta()
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
            public const string Id = "ID";
            public const string EvaluationID = "EvaluationID";
            public const string InterventionID = "InterventionID";
            public const string NursingInterventionID = "NursingInterventionID";
            public const string SRNursingCarePlanning = "SRNursingCarePlanning";
            public const string CreateByUserID = "CreateByUserID";
            public const string CreateDateTime = "CreateDateTime";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string Id = "Id";
            public const string EvaluationID = "EvaluationID";
            public const string InterventionID = "InterventionID";
            public const string NursingInterventionID = "NursingInterventionID";
            public const string SRNursingCarePlanning = "SRNursingCarePlanning";
            public const string CreateByUserID = "CreateByUserID";
            public const string CreateDateTime = "CreateDateTime";
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
            lock (typeof(NursingDiagnosaEvaluationMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new NursingDiagnosaEvaluationMetadata();
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


                meta.AddTypeMap("Id", new esTypeMap("bigint", "System.Int64"));
                meta.AddTypeMap("EvaluationID", new esTypeMap("bigint", "System.Int64"));
                meta.AddTypeMap("InterventionID", new esTypeMap("bigint", "System.Int64"));
                meta.AddTypeMap("NursingInterventionID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRNursingCarePlanning", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CreateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CreateDateTime", new esTypeMap("datetime", "System.DateTime"));



                meta.Source = "NursingDiagnosaEvaluation";
                meta.Destination = "NursingDiagnosaEvaluation";

                meta.spInsert = "proc_NursingDiagnosaEvaluationInsert";
                meta.spUpdate = "proc_NursingDiagnosaEvaluationUpdate";
                meta.spDelete = "proc_NursingDiagnosaEvaluationDelete";
                meta.spLoadAll = "proc_NursingDiagnosaEvaluationLoadAll";
                meta.spLoadByPrimaryKey = "proc_NursingDiagnosaEvaluationLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private NursingDiagnosaEvaluationMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
