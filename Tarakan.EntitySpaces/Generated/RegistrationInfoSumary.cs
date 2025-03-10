
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 3/10/2025 7:57:41 AM
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
    /// Encapsulates the 'RegistrationInfoSumary' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(RegistrationInfoSumary))]
    [XmlType("RegistrationInfoSumary")]
    public partial class RegistrationInfoSumary : esRegistrationInfoSumary
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new RegistrationInfoSumary();
        }

        #region Static Quick Access Methods
        static public void Delete(string registrationNo)
        {
            var obj = new RegistrationInfoSumary();
            obj.RegistrationNo = registrationNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string registrationNo, esSqlAccessType sqlAccessType)
        {
            var obj = new RegistrationInfoSumary();
            obj.RegistrationNo = registrationNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("RegistrationInfoSumaryCollection")]
    public partial class RegistrationInfoSumaryCollection : esRegistrationInfoSumaryCollection, IEnumerable<RegistrationInfoSumary>
    {
        public RegistrationInfoSumary FindByPrimaryKey(string registrationNo)
        {
            return this.SingleOrDefault(e => e.RegistrationNo == registrationNo);
        }



    }



    [Serializable]
    public partial class RegistrationInfoSumaryQuery : esRegistrationInfoSumaryQuery
    {
        public RegistrationInfoSumaryQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public RegistrationInfoSumaryQuery(string joinAlias, out RegistrationInfoSumaryQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "RegistrationInfoSumaryQuery";
        }



        #region Explicit Casts

        public static explicit operator string(RegistrationInfoSumaryQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator RegistrationInfoSumaryQuery(string query)
        {
            return (RegistrationInfoSumaryQuery)SerializeHelper.FromXml(query, typeof(RegistrationInfoSumaryQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esRegistrationInfoSumary : esEntity
    {
        public esRegistrationInfoSumary()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string registrationNo)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(registrationNo);
            else
                return LoadByPrimaryKeyStoredProcedure(registrationNo);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string registrationNo)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(registrationNo);
            else
                return LoadByPrimaryKeyStoredProcedure(registrationNo);
        }

        private bool LoadByPrimaryKeyDynamic(string registrationNo)
        {
            RegistrationInfoSumaryQuery query = new RegistrationInfoSumaryQuery("risQ");
            query.Where(query.RegistrationNo == registrationNo);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string registrationNo)
        {
            esParameters parms = new esParameters();
            parms.Add("RegistrationNo", registrationNo);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to RegistrationInfoSumary.RegistrationNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RegistrationNo
        {
            get
            {
                return GetSystemString(RegistrationInfoSumaryMetadata.ColumnNames.RegistrationNo);
            }

            set
            {
                if (SetSystemString(RegistrationInfoSumaryMetadata.ColumnNames.RegistrationNo, value))
                {
                    OnPropertyChanged(RegistrationInfoSumaryMetadata.PropertyNames.RegistrationNo);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoSumary.NoteCount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? NoteCount
        {
            get
            {
                return GetSystemInt32(RegistrationInfoSumaryMetadata.ColumnNames.NoteCount);
            }

            set
            {
                if (SetSystemInt32(RegistrationInfoSumaryMetadata.ColumnNames.NoteCount, value))
                {
                    OnPropertyChanged(RegistrationInfoSumaryMetadata.PropertyNames.NoteCount);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoSumary.CreatedByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string CreatedByUserID
        {
            get
            {
                return GetSystemString(RegistrationInfoSumaryMetadata.ColumnNames.CreatedByUserID);
            }

            set
            {
                if (SetSystemString(RegistrationInfoSumaryMetadata.ColumnNames.CreatedByUserID, value))
                {
                    OnPropertyChanged(RegistrationInfoSumaryMetadata.PropertyNames.CreatedByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoSumary.CreatedDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? CreatedDateTime
        {
            get
            {
                return GetSystemDateTime(RegistrationInfoSumaryMetadata.ColumnNames.CreatedDateTime);
            }

            set
            {
                if (SetSystemDateTime(RegistrationInfoSumaryMetadata.ColumnNames.CreatedDateTime, value))
                {
                    OnPropertyChanged(RegistrationInfoSumaryMetadata.PropertyNames.CreatedDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoSumary.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(RegistrationInfoSumaryMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(RegistrationInfoSumaryMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(RegistrationInfoSumaryMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoSumary.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(RegistrationInfoSumaryMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(RegistrationInfoSumaryMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(RegistrationInfoSumaryMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoSumary.NoteMedicalCount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? NoteMedicalCount
        {
            get
            {
                return GetSystemInt32(RegistrationInfoSumaryMetadata.ColumnNames.NoteMedicalCount);
            }

            set
            {
                if (SetSystemInt32(RegistrationInfoSumaryMetadata.ColumnNames.NoteMedicalCount, value))
                {
                    OnPropertyChanged(RegistrationInfoSumaryMetadata.PropertyNames.NoteMedicalCount);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoSumary.DocumentCheckListCount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? DocumentCheckListCount
        {
            get
            {
                return GetSystemInt32(RegistrationInfoSumaryMetadata.ColumnNames.DocumentCheckListCount);
            }

            set
            {
                if (SetSystemInt32(RegistrationInfoSumaryMetadata.ColumnNames.DocumentCheckListCount, value))
                {
                    OnPropertyChanged(RegistrationInfoSumaryMetadata.PropertyNames.DocumentCheckListCount);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return RegistrationInfoSumaryMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public RegistrationInfoSumaryQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new RegistrationInfoSumaryQuery("risQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(RegistrationInfoSumaryQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(RegistrationInfoSumaryQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((RegistrationInfoSumaryQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private RegistrationInfoSumaryQuery query;
    }



    [Serializable]
    abstract public partial class esRegistrationInfoSumaryCollection : esEntityCollection<RegistrationInfoSumary>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return RegistrationInfoSumaryMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "RegistrationInfoSumaryCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public RegistrationInfoSumaryQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new RegistrationInfoSumaryQuery("risQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(RegistrationInfoSumaryQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new RegistrationInfoSumaryQuery("risQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(RegistrationInfoSumaryQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((RegistrationInfoSumaryQuery)query);
        }

        #endregion

        private RegistrationInfoSumaryQuery query;
    }



    [Serializable]
    abstract public partial class esRegistrationInfoSumaryQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return RegistrationInfoSumaryMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "RegistrationNo": return RegistrationNo;
                case "NoteCount": return NoteCount;
                case "CreatedByUserID": return CreatedByUserID;
                case "CreatedDateTime": return CreatedDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "NoteMedicalCount": return NoteMedicalCount;
                case "DocumentCheckListCount": return DocumentCheckListCount;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem RegistrationNo
        {
            get { return new esQueryItem(this, RegistrationInfoSumaryMetadata.ColumnNames.RegistrationNo, esSystemType.String); }
        }

        public esQueryItem NoteCount
        {
            get { return new esQueryItem(this, RegistrationInfoSumaryMetadata.ColumnNames.NoteCount, esSystemType.Int32); }
        }

        public esQueryItem CreatedByUserID
        {
            get { return new esQueryItem(this, RegistrationInfoSumaryMetadata.ColumnNames.CreatedByUserID, esSystemType.String); }
        }

        public esQueryItem CreatedDateTime
        {
            get { return new esQueryItem(this, RegistrationInfoSumaryMetadata.ColumnNames.CreatedDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, RegistrationInfoSumaryMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, RegistrationInfoSumaryMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem NoteMedicalCount
        {
            get { return new esQueryItem(this, RegistrationInfoSumaryMetadata.ColumnNames.NoteMedicalCount, esSystemType.Int32); }
        }

        public esQueryItem DocumentCheckListCount
        {
            get { return new esQueryItem(this, RegistrationInfoSumaryMetadata.ColumnNames.DocumentCheckListCount, esSystemType.Int32); }
        }

        #endregion

    }



    [Serializable]
    public partial class RegistrationInfoSumaryMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected RegistrationInfoSumaryMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.RegistrationNo, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RegistrationNo;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 50;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.NoteCount, 1, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.NoteCount;
            c.NumericPrecision = 10;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreatedByUserID, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.CreatedByUserID;
            c.CharacterMaxLength = 15;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreatedDateTime, 3, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.CreatedDateTime;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 4, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 15;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 5, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.NoteMedicalCount, 6, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.NoteMedicalCount;
            c.NumericPrecision = 10;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DocumentCheckListCount, 7, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.DocumentCheckListCount;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public RegistrationInfoSumaryMetadata Meta()
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
            public const string RegistrationNo = "RegistrationNo";
            public const string NoteCount = "NoteCount";
            public const string CreatedByUserID = "CreatedByUserID";
            public const string CreatedDateTime = "CreatedDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string NoteMedicalCount = "NoteMedicalCount";
            public const string DocumentCheckListCount = "DocumentCheckListCount";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string RegistrationNo = "RegistrationNo";
            public const string NoteCount = "NoteCount";
            public const string CreatedByUserID = "CreatedByUserID";
            public const string CreatedDateTime = "CreatedDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string NoteMedicalCount = "NoteMedicalCount";
            public const string DocumentCheckListCount = "DocumentCheckListCount";
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
            lock (typeof(RegistrationInfoSumaryMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new RegistrationInfoSumaryMetadata();
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


                meta.AddTypeMap("RegistrationNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("NoteCount", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("CreatedByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CreatedDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("NoteMedicalCount", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("DocumentCheckListCount", new esTypeMap("int", "System.Int32"));



                meta.Source = "RegistrationInfoSumary";
                meta.Destination = "RegistrationInfoSumary";

                meta.spInsert = "proc_RegistrationInfoSumaryInsert";
                meta.spUpdate = "proc_RegistrationInfoSumaryUpdate";
                meta.spDelete = "proc_RegistrationInfoSumaryDelete";
                meta.spLoadAll = "proc_RegistrationInfoSumaryLoadAll";
                meta.spLoadByPrimaryKey = "proc_RegistrationInfoSumaryLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private RegistrationInfoSumaryMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
