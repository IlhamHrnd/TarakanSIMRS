
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 3/8/2025 7:54:51 AM
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
    /// Encapsulates the 'AppUserUserGroup' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(AppUserUserGroup))]
    [XmlType("AppUserUserGroup")]
    public partial class AppUserUserGroup : esAppUserUserGroup
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new AppUserUserGroup();
        }

        #region Static Quick Access Methods
        static public void Delete(string userGroupID, string userID)
        {
            var obj = new AppUserUserGroup();
            obj.UserGroupID = userGroupID;
            obj.UserID = userID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string userGroupID, string userID, esSqlAccessType sqlAccessType)
        {
            var obj = new AppUserUserGroup();
            obj.UserGroupID = userGroupID;
            obj.UserID = userID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("AppUserUserGroupCollection")]
    public partial class AppUserUserGroupCollection : esAppUserUserGroupCollection, IEnumerable<AppUserUserGroup>
    {
        public AppUserUserGroup FindByPrimaryKey(string userGroupID, string userID)
        {
            return this.SingleOrDefault(e => e.UserGroupID == userGroupID && e.UserID == userID);
        }



    }



    [Serializable]
    public partial class AppUserUserGroupQuery : esAppUserUserGroupQuery
    {
        public AppUserUserGroupQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public AppUserUserGroupQuery(string joinAlias, out AppUserUserGroupQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "AppUserUserGroupQuery";
        }



        #region Explicit Casts

        public static explicit operator string(AppUserUserGroupQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator AppUserUserGroupQuery(string query)
        {
            return (AppUserUserGroupQuery)SerializeHelper.FromXml(query, typeof(AppUserUserGroupQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esAppUserUserGroup : esEntity
    {
        public esAppUserUserGroup()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string userGroupID, string userID)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(userGroupID, userID);
            else
                return LoadByPrimaryKeyStoredProcedure(userGroupID, userID);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string userGroupID, string userID)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(userGroupID, userID);
            else
                return LoadByPrimaryKeyStoredProcedure(userGroupID, userID);
        }

        private bool LoadByPrimaryKeyDynamic(string userGroupID, string userID)
        {
            AppUserUserGroupQuery query = new AppUserUserGroupQuery("auugQ");
            query.Where(query.UserGroupID == userGroupID, query.UserID == userID);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string userGroupID, string userID)
        {
            esParameters parms = new esParameters();
            parms.Add("UserGroupID", userGroupID); parms.Add("UserID", userID);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to AppUserUserGroup.UserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string UserID
        {
            get
            {
                return GetSystemString(AppUserUserGroupMetadata.ColumnNames.UserID);
            }

            set
            {
                if (SetSystemString(AppUserUserGroupMetadata.ColumnNames.UserID, value))
                {
                    OnPropertyChanged(AppUserUserGroupMetadata.PropertyNames.UserID);
                }
            }
        }

        /// <summary>
        /// Maps to AppUserUserGroup.UserGroupID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string UserGroupID
        {
            get
            {
                return GetSystemString(AppUserUserGroupMetadata.ColumnNames.UserGroupID);
            }

            set
            {
                if (SetSystemString(AppUserUserGroupMetadata.ColumnNames.UserGroupID, value))
                {
                    OnPropertyChanged(AppUserUserGroupMetadata.PropertyNames.UserGroupID);
                }
            }
        }

        /// <summary>
        /// Maps to AppUserUserGroup.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(AppUserUserGroupMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(AppUserUserGroupMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(AppUserUserGroupMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to AppUserUserGroup.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(AppUserUserGroupMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(AppUserUserGroupMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(AppUserUserGroupMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return AppUserUserGroupMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public AppUserUserGroupQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new AppUserUserGroupQuery("auugQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(AppUserUserGroupQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(AppUserUserGroupQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((AppUserUserGroupQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private AppUserUserGroupQuery query;
    }



    [Serializable]
    abstract public partial class esAppUserUserGroupCollection : esEntityCollection<AppUserUserGroup>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return AppUserUserGroupMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "AppUserUserGroupCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public AppUserUserGroupQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new AppUserUserGroupQuery("auugQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(AppUserUserGroupQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new AppUserUserGroupQuery("auugQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(AppUserUserGroupQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((AppUserUserGroupQuery)query);
        }

        #endregion

        private AppUserUserGroupQuery query;
    }



    [Serializable]
    abstract public partial class esAppUserUserGroupQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return AppUserUserGroupMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "UserID": return UserID;
                case "UserGroupID": return UserGroupID;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem UserID
        {
            get { return new esQueryItem(this, AppUserUserGroupMetadata.ColumnNames.UserID, esSystemType.String); }
        }

        public esQueryItem UserGroupID
        {
            get { return new esQueryItem(this, AppUserUserGroupMetadata.ColumnNames.UserGroupID, esSystemType.String); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, AppUserUserGroupMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, AppUserUserGroupMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        #endregion

    }



    [Serializable]
    public partial class AppUserUserGroupMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected AppUserUserGroupMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.UserID, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.UserID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 15;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.UserGroupID, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.UserGroupID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 2, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 3, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 40;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public AppUserUserGroupMetadata Meta()
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
            public const string UserID = "UserID";
            public const string UserGroupID = "UserGroupID";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string UserID = "UserID";
            public const string UserGroupID = "UserGroupID";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
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
            lock (typeof(AppUserUserGroupMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new AppUserUserGroupMetadata();
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


                meta.AddTypeMap("UserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("UserGroupID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));



                meta.Source = "AppUserUserGroup";
                meta.Destination = "AppUserUserGroup";

                meta.spInsert = "proc_AppUserUserGroupInsert";
                meta.spUpdate = "proc_AppUserUserGroupUpdate";
                meta.spDelete = "proc_AppUserUserGroupDelete";
                meta.spLoadAll = "proc_AppUserUserGroupLoadAll";
                meta.spLoadByPrimaryKey = "proc_AppUserUserGroupLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private AppUserUserGroupMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
