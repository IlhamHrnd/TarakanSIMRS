
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 2/24/2025 10:51:01 AM
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
    /// Encapsulates the 'RegistrationPathway' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(RegistrationPathway))]
    [XmlType("RegistrationPathway")]
    public partial class RegistrationPathway : esRegistrationPathway
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new RegistrationPathway();
        }

        #region Static Quick Access Methods
        static public void Delete(string pathwayID, string registrationNo)
        {
            var obj = new RegistrationPathway();
            obj.PathwayID = pathwayID;
            obj.RegistrationNo = registrationNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string pathwayID, string registrationNo, esSqlAccessType sqlAccessType)
        {
            var obj = new RegistrationPathway();
            obj.PathwayID = pathwayID;
            obj.RegistrationNo = registrationNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("RegistrationPathwayCollection")]
    public partial class RegistrationPathwayCollection : esRegistrationPathwayCollection, IEnumerable<RegistrationPathway>
    {
        public RegistrationPathway FindByPrimaryKey(string pathwayID, string registrationNo)
        {
            return this.SingleOrDefault(e => e.PathwayID == pathwayID && e.RegistrationNo == registrationNo);
        }



    }



    [Serializable]
    public partial class RegistrationPathwayQuery : esRegistrationPathwayQuery
    {
        public RegistrationPathwayQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public RegistrationPathwayQuery(string joinAlias, out RegistrationPathwayQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "RegistrationPathwayQuery";
        }



        #region Explicit Casts

        public static explicit operator string(RegistrationPathwayQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator RegistrationPathwayQuery(string query)
        {
            return (RegistrationPathwayQuery)SerializeHelper.FromXml(query, typeof(RegistrationPathwayQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esRegistrationPathway : esEntity
    {
        public esRegistrationPathway()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string pathwayID, string registrationNo)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(pathwayID, registrationNo);
            else
                return LoadByPrimaryKeyStoredProcedure(pathwayID, registrationNo);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string pathwayID, string registrationNo)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(pathwayID, registrationNo);
            else
                return LoadByPrimaryKeyStoredProcedure(pathwayID, registrationNo);
        }

        private bool LoadByPrimaryKeyDynamic(string pathwayID, string registrationNo)
        {
            RegistrationPathwayQuery query = new RegistrationPathwayQuery("rpQ");
            query.Where(query.PathwayID == pathwayID, query.RegistrationNo == registrationNo);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string pathwayID, string registrationNo)
        {
            esParameters parms = new esParameters();
            parms.Add("PathwayID", pathwayID); parms.Add("RegistrationNo", registrationNo);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to RegistrationPathway.RegistrationNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RegistrationNo
        {
            get
            {
                return GetSystemString(RegistrationPathwayMetadata.ColumnNames.RegistrationNo);
            }

            set
            {
                if (SetSystemString(RegistrationPathwayMetadata.ColumnNames.RegistrationNo, value))
                {
                    OnPropertyChanged(RegistrationPathwayMetadata.PropertyNames.RegistrationNo);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationPathway.PathwayID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PathwayID
        {
            get
            {
                return GetSystemString(RegistrationPathwayMetadata.ColumnNames.PathwayID);
            }

            set
            {
                if (SetSystemString(RegistrationPathwayMetadata.ColumnNames.PathwayID, value))
                {
                    OnPropertyChanged(RegistrationPathwayMetadata.PropertyNames.PathwayID);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationPathway.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(RegistrationPathwayMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(RegistrationPathwayMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(RegistrationPathwayMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationPathway.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(RegistrationPathwayMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(RegistrationPathwayMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(RegistrationPathwayMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationPathway.PathwayStatus
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public char? PathwayStatus
        {
            get
            {
                return GetSystemChar(RegistrationPathwayMetadata.ColumnNames.PathwayStatus);
            }

            set
            {
                if (SetSystemChar(RegistrationPathwayMetadata.ColumnNames.PathwayStatus, value))
                {
                    OnPropertyChanged(RegistrationPathwayMetadata.PropertyNames.PathwayStatus);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationPathway.Notes
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Notes
        {
            get
            {
                return GetSystemString(RegistrationPathwayMetadata.ColumnNames.Notes);
            }

            set
            {
                if (SetSystemString(RegistrationPathwayMetadata.ColumnNames.Notes, value))
                {
                    OnPropertyChanged(RegistrationPathwayMetadata.PropertyNames.Notes);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return RegistrationPathwayMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public RegistrationPathwayQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new RegistrationPathwayQuery("rpQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(RegistrationPathwayQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(RegistrationPathwayQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((RegistrationPathwayQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private RegistrationPathwayQuery query;
    }



    [Serializable]
    abstract public partial class esRegistrationPathwayCollection : esEntityCollection<RegistrationPathway>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return RegistrationPathwayMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "RegistrationPathwayCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public RegistrationPathwayQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new RegistrationPathwayQuery("rpQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(RegistrationPathwayQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new RegistrationPathwayQuery("rpQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(RegistrationPathwayQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((RegistrationPathwayQuery)query);
        }

        #endregion

        private RegistrationPathwayQuery query;
    }



    [Serializable]
    abstract public partial class esRegistrationPathwayQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return RegistrationPathwayMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "RegistrationNo": return RegistrationNo;
                case "PathwayID": return PathwayID;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "PathwayStatus": return PathwayStatus;
                case "Notes": return Notes;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem RegistrationNo
        {
            get { return new esQueryItem(this, RegistrationPathwayMetadata.ColumnNames.RegistrationNo, esSystemType.String); }
        }

        public esQueryItem PathwayID
        {
            get { return new esQueryItem(this, RegistrationPathwayMetadata.ColumnNames.PathwayID, esSystemType.String); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, RegistrationPathwayMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, RegistrationPathwayMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem PathwayStatus
        {
            get { return new esQueryItem(this, RegistrationPathwayMetadata.ColumnNames.PathwayStatus, esSystemType.Char); }
        }

        public esQueryItem Notes
        {
            get { return new esQueryItem(this, RegistrationPathwayMetadata.ColumnNames.Notes, esSystemType.String); }
        }

        #endregion

    }



    [Serializable]
    public partial class RegistrationPathwayMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected RegistrationPathwayMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.RegistrationNo, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RegistrationNo;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 20;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PathwayID, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PathwayID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 50;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 2, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 3, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PathwayStatus, 4, typeof(char), esSystemType.Char);
            c.PropertyName = PropertyNames.PathwayStatus;
            c.CharacterMaxLength = 1;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Notes, 5, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Notes;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public RegistrationPathwayMetadata Meta()
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
            public const string PathwayID = "PathwayID";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string PathwayStatus = "PathwayStatus";
            public const string Notes = "Notes";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string RegistrationNo = "RegistrationNo";
            public const string PathwayID = "PathwayID";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string PathwayStatus = "PathwayStatus";
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
            lock (typeof(RegistrationPathwayMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new RegistrationPathwayMetadata();
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
                meta.AddTypeMap("PathwayID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PathwayStatus", new esTypeMap("varchar", "System.Char"));
                meta.AddTypeMap("Notes", new esTypeMap("varchar", "System.String"));



                meta.Source = "RegistrationPathway";
                meta.Destination = "RegistrationPathway";

                meta.spInsert = "proc_RegistrationPathwayInsert";
                meta.spUpdate = "proc_RegistrationPathwayUpdate";
                meta.spDelete = "proc_RegistrationPathwayDelete";
                meta.spLoadAll = "proc_RegistrationPathwayLoadAll";
                meta.spLoadByPrimaryKey = "proc_RegistrationPathwayLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private RegistrationPathwayMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
