
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 3/14/2025 9:21:24 AM
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
    /// Encapsulates the 'NursingDiagnosaTemplateDetail' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(NursingDiagnosaTemplateDetail))]
    [XmlType("NursingDiagnosaTemplateDetail")]
    public partial class NursingDiagnosaTemplateDetail : esNursingDiagnosaTemplateDetail
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new NursingDiagnosaTemplateDetail();
        }

        #region Static Quick Access Methods
        static public void Delete(string questionID, int templateID)
        {
            var obj = new NursingDiagnosaTemplateDetail();
            obj.QuestionID = questionID;
            obj.TemplateID = templateID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string questionID, int templateID, esSqlAccessType sqlAccessType)
        {
            var obj = new NursingDiagnosaTemplateDetail();
            obj.QuestionID = questionID;
            obj.TemplateID = templateID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("NursingDiagnosaTemplateDetailCollection")]
    public partial class NursingDiagnosaTemplateDetailCollection : esNursingDiagnosaTemplateDetailCollection, IEnumerable<NursingDiagnosaTemplateDetail>
    {
        public NursingDiagnosaTemplateDetail FindByPrimaryKey(string questionID, int templateID)
        {
            return this.SingleOrDefault(e => e.QuestionID == questionID && e.TemplateID == templateID);
        }



    }



    [Serializable]
    public partial class NursingDiagnosaTemplateDetailQuery : esNursingDiagnosaTemplateDetailQuery
    {
        public NursingDiagnosaTemplateDetailQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public NursingDiagnosaTemplateDetailQuery(string joinAlias, out NursingDiagnosaTemplateDetailQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "NursingDiagnosaTemplateDetailQuery";
        }



        #region Explicit Casts

        public static explicit operator string(NursingDiagnosaTemplateDetailQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator NursingDiagnosaTemplateDetailQuery(string query)
        {
            return (NursingDiagnosaTemplateDetailQuery)SerializeHelper.FromXml(query, typeof(NursingDiagnosaTemplateDetailQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esNursingDiagnosaTemplateDetail : esEntity
    {
        public esNursingDiagnosaTemplateDetail()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string questionID, int templateID)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(questionID, templateID);
            else
                return LoadByPrimaryKeyStoredProcedure(questionID, templateID);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string questionID, int templateID)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(questionID, templateID);
            else
                return LoadByPrimaryKeyStoredProcedure(questionID, templateID);
        }

        private bool LoadByPrimaryKeyDynamic(string questionID, int templateID)
        {
            NursingDiagnosaTemplateDetailQuery query = new NursingDiagnosaTemplateDetailQuery("ndtdQ");
            query.Where(query.QuestionID == questionID, query.TemplateID == templateID);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string questionID, int templateID)
        {
            esParameters parms = new esParameters();
            parms.Add("QuestionID", questionID); parms.Add("TemplateID", templateID);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to NursingDiagnosaTemplateDetail.TemplateID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? TemplateID
        {
            get
            {
                return GetSystemInt32(NursingDiagnosaTemplateDetailMetadata.ColumnNames.TemplateID);
            }

            set
            {
                if (SetSystemInt32(NursingDiagnosaTemplateDetailMetadata.ColumnNames.TemplateID, value))
                {
                    OnPropertyChanged(NursingDiagnosaTemplateDetailMetadata.PropertyNames.TemplateID);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTemplateDetail.QuestionID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string QuestionID
        {
            get
            {
                return GetSystemString(NursingDiagnosaTemplateDetailMetadata.ColumnNames.QuestionID);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaTemplateDetailMetadata.ColumnNames.QuestionID, value))
                {
                    OnPropertyChanged(NursingDiagnosaTemplateDetailMetadata.PropertyNames.QuestionID);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTemplateDetail.CreateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string CreateByUserID
        {
            get
            {
                return GetSystemString(NursingDiagnosaTemplateDetailMetadata.ColumnNames.CreateByUserID);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaTemplateDetailMetadata.ColumnNames.CreateByUserID, value))
                {
                    OnPropertyChanged(NursingDiagnosaTemplateDetailMetadata.PropertyNames.CreateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTemplateDetail.CreateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? CreateDateTime
        {
            get
            {
                return GetSystemDateTime(NursingDiagnosaTemplateDetailMetadata.ColumnNames.CreateDateTime);
            }

            set
            {
                if (SetSystemDateTime(NursingDiagnosaTemplateDetailMetadata.ColumnNames.CreateDateTime, value))
                {
                    OnPropertyChanged(NursingDiagnosaTemplateDetailMetadata.PropertyNames.CreateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTemplateDetail.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(NursingDiagnosaTemplateDetailMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaTemplateDetailMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(NursingDiagnosaTemplateDetailMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTemplateDetail.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(NursingDiagnosaTemplateDetailMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(NursingDiagnosaTemplateDetailMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(NursingDiagnosaTemplateDetailMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTemplateDetail.RowIndex
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? RowIndex
        {
            get
            {
                return GetSystemInt32(NursingDiagnosaTemplateDetailMetadata.ColumnNames.RowIndex);
            }

            set
            {
                if (SetSystemInt32(NursingDiagnosaTemplateDetailMetadata.ColumnNames.RowIndex, value))
                {
                    OnPropertyChanged(NursingDiagnosaTemplateDetailMetadata.PropertyNames.RowIndex);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return NursingDiagnosaTemplateDetailMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public NursingDiagnosaTemplateDetailQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new NursingDiagnosaTemplateDetailQuery("ndtdQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(NursingDiagnosaTemplateDetailQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(NursingDiagnosaTemplateDetailQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((NursingDiagnosaTemplateDetailQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private NursingDiagnosaTemplateDetailQuery query;
    }



    [Serializable]
    abstract public partial class esNursingDiagnosaTemplateDetailCollection : esEntityCollection<NursingDiagnosaTemplateDetail>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return NursingDiagnosaTemplateDetailMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "NursingDiagnosaTemplateDetailCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public NursingDiagnosaTemplateDetailQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new NursingDiagnosaTemplateDetailQuery("ndtdQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(NursingDiagnosaTemplateDetailQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new NursingDiagnosaTemplateDetailQuery("ndtdQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(NursingDiagnosaTemplateDetailQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((NursingDiagnosaTemplateDetailQuery)query);
        }

        #endregion

        private NursingDiagnosaTemplateDetailQuery query;
    }



    [Serializable]
    abstract public partial class esNursingDiagnosaTemplateDetailQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return NursingDiagnosaTemplateDetailMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "TemplateID": return TemplateID;
                case "QuestionID": return QuestionID;
                case "CreateByUserID": return CreateByUserID;
                case "CreateDateTime": return CreateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "RowIndex": return RowIndex;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem TemplateID
        {
            get { return new esQueryItem(this, NursingDiagnosaTemplateDetailMetadata.ColumnNames.TemplateID, esSystemType.Int32); }
        }

        public esQueryItem QuestionID
        {
            get { return new esQueryItem(this, NursingDiagnosaTemplateDetailMetadata.ColumnNames.QuestionID, esSystemType.String); }
        }

        public esQueryItem CreateByUserID
        {
            get { return new esQueryItem(this, NursingDiagnosaTemplateDetailMetadata.ColumnNames.CreateByUserID, esSystemType.String); }
        }

        public esQueryItem CreateDateTime
        {
            get { return new esQueryItem(this, NursingDiagnosaTemplateDetailMetadata.ColumnNames.CreateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, NursingDiagnosaTemplateDetailMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, NursingDiagnosaTemplateDetailMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem RowIndex
        {
            get { return new esQueryItem(this, NursingDiagnosaTemplateDetailMetadata.ColumnNames.RowIndex, esSystemType.Int32); }
        }

        #endregion

    }



    [Serializable]
    public partial class NursingDiagnosaTemplateDetailMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected NursingDiagnosaTemplateDetailMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.TemplateID, 0, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.TemplateID;
            c.IsInPrimaryKey = true;
            c.NumericPrecision = 10;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.QuestionID, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.QuestionID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 10;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreateByUserID, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.CreateByUserID;
            c.CharacterMaxLength = 15;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreateDateTime, 3, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.CreateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 4, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 15;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 5, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RowIndex, 6, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.RowIndex;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public NursingDiagnosaTemplateDetailMetadata Meta()
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
            public const string TemplateID = "TemplateID";
            public const string QuestionID = "QuestionID";
            public const string CreateByUserID = "CreateByUserID";
            public const string CreateDateTime = "CreateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string RowIndex = "RowIndex";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string TemplateID = "TemplateID";
            public const string QuestionID = "QuestionID";
            public const string CreateByUserID = "CreateByUserID";
            public const string CreateDateTime = "CreateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string RowIndex = "RowIndex";
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
            lock (typeof(NursingDiagnosaTemplateDetailMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new NursingDiagnosaTemplateDetailMetadata();
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


                meta.AddTypeMap("TemplateID", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("QuestionID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CreateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CreateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("RowIndex", new esTypeMap("int", "System.Int32"));



                meta.Source = "NursingDiagnosaTemplateDetail";
                meta.Destination = "NursingDiagnosaTemplateDetail";

                meta.spInsert = "proc_NursingDiagnosaTemplateDetailInsert";
                meta.spUpdate = "proc_NursingDiagnosaTemplateDetailUpdate";
                meta.spDelete = "proc_NursingDiagnosaTemplateDetailDelete";
                meta.spLoadAll = "proc_NursingDiagnosaTemplateDetailLoadAll";
                meta.spLoadByPrimaryKey = "proc_NursingDiagnosaTemplateDetailLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private NursingDiagnosaTemplateDetailMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
