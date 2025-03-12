
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 3/12/2025 9:53:14 AM
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
    /// Encapsulates the 'NursingTransHD' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(NursingTransHD))]
    [XmlType("NursingTransHD")]
    public partial class NursingTransHD : esNursingTransHD
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new NursingTransHD();
        }

        #region Static Quick Access Methods
        static public void Delete(string transactionNo)
        {
            var obj = new NursingTransHD();
            obj.TransactionNo = transactionNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string transactionNo, esSqlAccessType sqlAccessType)
        {
            var obj = new NursingTransHD();
            obj.TransactionNo = transactionNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("NursingTransHDCollection")]
    public partial class NursingTransHDCollection : esNursingTransHDCollection, IEnumerable<NursingTransHD>
    {
        public NursingTransHD FindByPrimaryKey(string transactionNo)
        {
            return this.SingleOrDefault(e => e.TransactionNo == transactionNo);
        }



    }



    [Serializable]
    public partial class NursingTransHDQuery : esNursingTransHDQuery
    {
        public NursingTransHDQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public NursingTransHDQuery(string joinAlias, out NursingTransHDQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "NursingTransHDQuery";
        }



        #region Explicit Casts

        public static explicit operator string(NursingTransHDQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator NursingTransHDQuery(string query)
        {
            return (NursingTransHDQuery)SerializeHelper.FromXml(query, typeof(NursingTransHDQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esNursingTransHD : esEntity
    {
        public esNursingTransHD()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string transactionNo)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(transactionNo);
            else
                return LoadByPrimaryKeyStoredProcedure(transactionNo);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string transactionNo)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(transactionNo);
            else
                return LoadByPrimaryKeyStoredProcedure(transactionNo);
        }

        private bool LoadByPrimaryKeyDynamic(string transactionNo)
        {
            NursingTransHDQuery query = new NursingTransHDQuery("ntQ");
            query.Where(query.TransactionNo == transactionNo);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string transactionNo)
        {
            esParameters parms = new esParameters();
            parms.Add("TransactionNo", transactionNo);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to NursingTransHD.TransactionNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TransactionNo
        {
            get
            {
                return GetSystemString(NursingTransHDMetadata.ColumnNames.TransactionNo);
            }

            set
            {
                if (SetSystemString(NursingTransHDMetadata.ColumnNames.TransactionNo, value))
                {
                    OnPropertyChanged(NursingTransHDMetadata.PropertyNames.TransactionNo);
                }
            }
        }

        /// <summary>
        /// Maps to NursingTransHD.NursingTransDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? NursingTransDateTime
        {
            get
            {
                return GetSystemDateTime(NursingTransHDMetadata.ColumnNames.NursingTransDateTime);
            }

            set
            {
                if (SetSystemDateTime(NursingTransHDMetadata.ColumnNames.NursingTransDateTime, value))
                {
                    OnPropertyChanged(NursingTransHDMetadata.PropertyNames.NursingTransDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to NursingTransHD.RegistrationNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RegistrationNo
        {
            get
            {
                return GetSystemString(NursingTransHDMetadata.ColumnNames.RegistrationNo);
            }

            set
            {
                if (SetSystemString(NursingTransHDMetadata.ColumnNames.RegistrationNo, value))
                {
                    OnPropertyChanged(NursingTransHDMetadata.PropertyNames.RegistrationNo);
                }
            }
        }

        /// <summary>
        /// Maps to NursingTransHD.CreateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string CreateByUserID
        {
            get
            {
                return GetSystemString(NursingTransHDMetadata.ColumnNames.CreateByUserID);
            }

            set
            {
                if (SetSystemString(NursingTransHDMetadata.ColumnNames.CreateByUserID, value))
                {
                    OnPropertyChanged(NursingTransHDMetadata.PropertyNames.CreateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to NursingTransHD.CreateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? CreateDateTime
        {
            get
            {
                return GetSystemDateTime(NursingTransHDMetadata.ColumnNames.CreateDateTime);
            }

            set
            {
                if (SetSystemDateTime(NursingTransHDMetadata.ColumnNames.CreateDateTime, value))
                {
                    OnPropertyChanged(NursingTransHDMetadata.PropertyNames.CreateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to NursingTransHD.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(NursingTransHDMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(NursingTransHDMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(NursingTransHDMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to NursingTransHD.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(NursingTransHDMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(NursingTransHDMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(NursingTransHDMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return NursingTransHDMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public NursingTransHDQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new NursingTransHDQuery("ntQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(NursingTransHDQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(NursingTransHDQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((NursingTransHDQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private NursingTransHDQuery query;
    }



    [Serializable]
    abstract public partial class esNursingTransHDCollection : esEntityCollection<NursingTransHD>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return NursingTransHDMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "NursingTransHDCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public NursingTransHDQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new NursingTransHDQuery("ntQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(NursingTransHDQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new NursingTransHDQuery("ntQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(NursingTransHDQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((NursingTransHDQuery)query);
        }

        #endregion

        private NursingTransHDQuery query;
    }



    [Serializable]
    abstract public partial class esNursingTransHDQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return NursingTransHDMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "TransactionNo": return TransactionNo;
                case "NursingTransDateTime": return NursingTransDateTime;
                case "RegistrationNo": return RegistrationNo;
                case "CreateByUserID": return CreateByUserID;
                case "CreateDateTime": return CreateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "LastUpdateDateTime": return LastUpdateDateTime;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem TransactionNo
        {
            get { return new esQueryItem(this, NursingTransHDMetadata.ColumnNames.TransactionNo, esSystemType.String); }
        }

        public esQueryItem NursingTransDateTime
        {
            get { return new esQueryItem(this, NursingTransHDMetadata.ColumnNames.NursingTransDateTime, esSystemType.DateTime); }
        }

        public esQueryItem RegistrationNo
        {
            get { return new esQueryItem(this, NursingTransHDMetadata.ColumnNames.RegistrationNo, esSystemType.String); }
        }

        public esQueryItem CreateByUserID
        {
            get { return new esQueryItem(this, NursingTransHDMetadata.ColumnNames.CreateByUserID, esSystemType.String); }
        }

        public esQueryItem CreateDateTime
        {
            get { return new esQueryItem(this, NursingTransHDMetadata.ColumnNames.CreateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, NursingTransHDMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, NursingTransHDMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        #endregion

    }



    [Serializable]
    public partial class NursingTransHDMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected NursingTransHDMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.TransactionNo, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TransactionNo;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 20;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.NursingTransDateTime, 1, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.NursingTransDateTime;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RegistrationNo, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RegistrationNo;
            c.CharacterMaxLength = 20;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreateByUserID, 3, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.CreateByUserID;
            c.CharacterMaxLength = 15;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreateDateTime, 4, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.CreateDateTime;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 5, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 15;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 6, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            m_columns.Add(c);

        }
        #endregion

        static public NursingTransHDMetadata Meta()
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
            public const string TransactionNo = "TransactionNo";
            public const string NursingTransDateTime = "NursingTransDateTime";
            public const string RegistrationNo = "RegistrationNo";
            public const string CreateByUserID = "CreateByUserID";
            public const string CreateDateTime = "CreateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string TransactionNo = "TransactionNo";
            public const string NursingTransDateTime = "NursingTransDateTime";
            public const string RegistrationNo = "RegistrationNo";
            public const string CreateByUserID = "CreateByUserID";
            public const string CreateDateTime = "CreateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
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
            lock (typeof(NursingTransHDMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new NursingTransHDMetadata();
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


                meta.AddTypeMap("TransactionNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("NursingTransDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("RegistrationNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CreateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CreateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));



                meta.Source = "NursingTransHD";
                meta.Destination = "NursingTransHD";

                meta.spInsert = "proc_NursingTransHDInsert";
                meta.spUpdate = "proc_NursingTransHDUpdate";
                meta.spDelete = "proc_NursingTransHDDelete";
                meta.spLoadAll = "proc_NursingTransHDLoadAll";
                meta.spLoadByPrimaryKey = "proc_NursingTransHDLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private NursingTransHDMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
