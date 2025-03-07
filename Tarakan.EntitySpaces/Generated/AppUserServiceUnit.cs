
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 2/11/2025 4:50:41 PM
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
    /// Encapsulates the 'AppUserServiceUnit' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(AppUserServiceUnit))]
    [XmlType("AppUserServiceUnit")]
    public partial class AppUserServiceUnit : esAppUserServiceUnit
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new AppUserServiceUnit();
        }

        #region Static Quick Access Methods
        static public void Delete(string serviceUnitID, string userID)
        {
            var obj = new AppUserServiceUnit();
            obj.ServiceUnitID = serviceUnitID;
            obj.UserID = userID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string serviceUnitID, string userID, esSqlAccessType sqlAccessType)
        {
            var obj = new AppUserServiceUnit();
            obj.ServiceUnitID = serviceUnitID;
            obj.UserID = userID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("AppUserServiceUnitCollection")]
    public partial class AppUserServiceUnitCollection : esAppUserServiceUnitCollection, IEnumerable<AppUserServiceUnit>
    {
        public AppUserServiceUnit FindByPrimaryKey(string serviceUnitID, string userID)
        {
            return this.SingleOrDefault(e => e.ServiceUnitID == serviceUnitID && e.UserID == userID);
        }



    }



    [Serializable]
    public partial class AppUserServiceUnitQuery : esAppUserServiceUnitQuery
    {
        public AppUserServiceUnitQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public AppUserServiceUnitQuery(string joinAlias, out AppUserServiceUnitQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "AppUserServiceUnitQuery";
        }



        #region Explicit Casts

        public static explicit operator string(AppUserServiceUnitQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator AppUserServiceUnitQuery(string query)
        {
            return (AppUserServiceUnitQuery)SerializeHelper.FromXml(query, typeof(AppUserServiceUnitQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esAppUserServiceUnit : esEntity
    {
        public esAppUserServiceUnit()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string serviceUnitID, string userID)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(serviceUnitID, userID);
            else
                return LoadByPrimaryKeyStoredProcedure(serviceUnitID, userID);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string serviceUnitID, string userID)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(serviceUnitID, userID);
            else
                return LoadByPrimaryKeyStoredProcedure(serviceUnitID, userID);
        }

        private bool LoadByPrimaryKeyDynamic(string serviceUnitID, string userID)
        {
            AppUserServiceUnitQuery query = new AppUserServiceUnitQuery("ausuQ");
            query.Where(query.ServiceUnitID == serviceUnitID, query.UserID == userID);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string serviceUnitID, string userID)
        {
            esParameters parms = new esParameters();
            parms.Add("ServiceUnitID", serviceUnitID); parms.Add("UserID", userID);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to AppUserServiceUnit.UserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string UserID
        {
            get
            {
                return GetSystemString(AppUserServiceUnitMetadata.ColumnNames.UserID);
            }

            set
            {
                if (SetSystemString(AppUserServiceUnitMetadata.ColumnNames.UserID, value))
                {
                    OnPropertyChanged(AppUserServiceUnitMetadata.PropertyNames.UserID);
                }
            }
        }

        /// <summary>
        /// Maps to AppUserServiceUnit.ServiceUnitID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ServiceUnitID
        {
            get
            {
                return GetSystemString(AppUserServiceUnitMetadata.ColumnNames.ServiceUnitID);
            }

            set
            {
                if (SetSystemString(AppUserServiceUnitMetadata.ColumnNames.ServiceUnitID, value))
                {
                    OnPropertyChanged(AppUserServiceUnitMetadata.PropertyNames.ServiceUnitID);
                }
            }
        }

        /// <summary>
        /// Maps to AppUserServiceUnit.IsDiscontinue
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsDiscontinue
        {
            get
            {
                return GetSystemBoolean(AppUserServiceUnitMetadata.ColumnNames.IsDiscontinue);
            }

            set
            {
                if (SetSystemBoolean(AppUserServiceUnitMetadata.ColumnNames.IsDiscontinue, value))
                {
                    OnPropertyChanged(AppUserServiceUnitMetadata.PropertyNames.IsDiscontinue);
                }
            }
        }

        /// <summary>
        /// Maps to AppUserServiceUnit.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(AppUserServiceUnitMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(AppUserServiceUnitMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(AppUserServiceUnitMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to AppUserServiceUnit.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(AppUserServiceUnitMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(AppUserServiceUnitMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(AppUserServiceUnitMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return AppUserServiceUnitMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public AppUserServiceUnitQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new AppUserServiceUnitQuery("ausuQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(AppUserServiceUnitQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(AppUserServiceUnitQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((AppUserServiceUnitQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private AppUserServiceUnitQuery query;
    }



    [Serializable]
    abstract public partial class esAppUserServiceUnitCollection : esEntityCollection<AppUserServiceUnit>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return AppUserServiceUnitMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "AppUserServiceUnitCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public AppUserServiceUnitQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new AppUserServiceUnitQuery("ausuQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(AppUserServiceUnitQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new AppUserServiceUnitQuery("ausuQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(AppUserServiceUnitQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((AppUserServiceUnitQuery)query);
        }

        #endregion

        private AppUserServiceUnitQuery query;
    }



    [Serializable]
    abstract public partial class esAppUserServiceUnitQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return AppUserServiceUnitMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "UserID": return UserID;
                case "ServiceUnitID": return ServiceUnitID;
                case "IsDiscontinue": return IsDiscontinue;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem UserID
        {
            get { return new esQueryItem(this, AppUserServiceUnitMetadata.ColumnNames.UserID, esSystemType.String); }
        }

        public esQueryItem ServiceUnitID
        {
            get { return new esQueryItem(this, AppUserServiceUnitMetadata.ColumnNames.ServiceUnitID, esSystemType.String); }
        }

        public esQueryItem IsDiscontinue
        {
            get { return new esQueryItem(this, AppUserServiceUnitMetadata.ColumnNames.IsDiscontinue, esSystemType.Boolean); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, AppUserServiceUnitMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, AppUserServiceUnitMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        #endregion

    }



    [Serializable]
    public partial class AppUserServiceUnitMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected AppUserServiceUnitMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.UserID, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.UserID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 15;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ServiceUnitID, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ServiceUnitID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 10;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsDiscontinue, 2, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsDiscontinue;
            c.IsNullable = true;
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

        }
        #endregion

        static public AppUserServiceUnitMetadata Meta()
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
            public const string ServiceUnitID = "ServiceUnitID";
            public const string IsDiscontinue = "IsDiscontinue";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string UserID = "UserID";
            public const string ServiceUnitID = "ServiceUnitID";
            public const string IsDiscontinue = "IsDiscontinue";
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
            lock (typeof(AppUserServiceUnitMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new AppUserServiceUnitMetadata();
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
                meta.AddTypeMap("ServiceUnitID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsDiscontinue", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));



                meta.Source = "AppUserServiceUnit";
                meta.Destination = "AppUserServiceUnit";

                meta.spInsert = "proc_AppUserServiceUnitInsert";
                meta.spUpdate = "proc_AppUserServiceUnitUpdate";
                meta.spDelete = "proc_AppUserServiceUnitDelete";
                meta.spLoadAll = "proc_AppUserServiceUnitLoadAll";
                meta.spLoadByPrimaryKey = "proc_AppUserServiceUnitLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private AppUserServiceUnitMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
