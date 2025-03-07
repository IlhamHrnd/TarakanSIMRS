
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 2/12/2025 3:49:48 PM
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
    /// Encapsulates the 'ServiceUnitParamedic' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(ServiceUnitParamedic))]
    [XmlType("ServiceUnitParamedic")]
    public partial class ServiceUnitParamedic : esServiceUnitParamedic
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new ServiceUnitParamedic();
        }

        #region Static Quick Access Methods
        static public void Delete(string paramedicID, string serviceUnitID)
        {
            var obj = new ServiceUnitParamedic();
            obj.ParamedicID = paramedicID;
            obj.ServiceUnitID = serviceUnitID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string paramedicID, string serviceUnitID, esSqlAccessType sqlAccessType)
        {
            var obj = new ServiceUnitParamedic();
            obj.ParamedicID = paramedicID;
            obj.ServiceUnitID = serviceUnitID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("ServiceUnitParamedicCollection")]
    public partial class ServiceUnitParamedicCollection : esServiceUnitParamedicCollection, IEnumerable<ServiceUnitParamedic>
    {
        public ServiceUnitParamedic FindByPrimaryKey(string paramedicID, string serviceUnitID)
        {
            return this.SingleOrDefault(e => e.ParamedicID == paramedicID && e.ServiceUnitID == serviceUnitID);
        }



    }



    [Serializable]
    public partial class ServiceUnitParamedicQuery : esServiceUnitParamedicQuery
    {
        public ServiceUnitParamedicQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public ServiceUnitParamedicQuery(string joinAlias, out ServiceUnitParamedicQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "ServiceUnitParamedicQuery";
        }



        #region Explicit Casts

        public static explicit operator string(ServiceUnitParamedicQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator ServiceUnitParamedicQuery(string query)
        {
            return (ServiceUnitParamedicQuery)SerializeHelper.FromXml(query, typeof(ServiceUnitParamedicQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esServiceUnitParamedic : esEntity
    {
        public esServiceUnitParamedic()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string paramedicID, string serviceUnitID)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(paramedicID, serviceUnitID);
            else
                return LoadByPrimaryKeyStoredProcedure(paramedicID, serviceUnitID);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string paramedicID, string serviceUnitID)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(paramedicID, serviceUnitID);
            else
                return LoadByPrimaryKeyStoredProcedure(paramedicID, serviceUnitID);
        }

        private bool LoadByPrimaryKeyDynamic(string paramedicID, string serviceUnitID)
        {
            ServiceUnitParamedicQuery query = new ServiceUnitParamedicQuery("supQ");
            query.Where(query.ParamedicID == paramedicID, query.ServiceUnitID == serviceUnitID);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string paramedicID, string serviceUnitID)
        {
            esParameters parms = new esParameters();
            parms.Add("ParamedicID", paramedicID); parms.Add("ServiceUnitID", serviceUnitID);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to ServiceUnitParamedic.ServiceUnitID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ServiceUnitID
        {
            get
            {
                return GetSystemString(ServiceUnitParamedicMetadata.ColumnNames.ServiceUnitID);
            }

            set
            {
                if (SetSystemString(ServiceUnitParamedicMetadata.ColumnNames.ServiceUnitID, value))
                {
                    OnPropertyChanged(ServiceUnitParamedicMetadata.PropertyNames.ServiceUnitID);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitParamedic.ParamedicID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParamedicID
        {
            get
            {
                return GetSystemString(ServiceUnitParamedicMetadata.ColumnNames.ParamedicID);
            }

            set
            {
                if (SetSystemString(ServiceUnitParamedicMetadata.ColumnNames.ParamedicID, value))
                {
                    OnPropertyChanged(ServiceUnitParamedicMetadata.PropertyNames.ParamedicID);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitParamedic.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(ServiceUnitParamedicMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(ServiceUnitParamedicMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(ServiceUnitParamedicMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitParamedic.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(ServiceUnitParamedicMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(ServiceUnitParamedicMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(ServiceUnitParamedicMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitParamedic.DefaultRoomID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DefaultRoomID
        {
            get
            {
                return GetSystemString(ServiceUnitParamedicMetadata.ColumnNames.DefaultRoomID);
            }

            set
            {
                if (SetSystemString(ServiceUnitParamedicMetadata.ColumnNames.DefaultRoomID, value))
                {
                    OnPropertyChanged(ServiceUnitParamedicMetadata.PropertyNames.DefaultRoomID);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitParamedic.IsUsingQue
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsUsingQue
        {
            get
            {
                return GetSystemBoolean(ServiceUnitParamedicMetadata.ColumnNames.IsUsingQue);
            }

            set
            {
                if (SetSystemBoolean(ServiceUnitParamedicMetadata.ColumnNames.IsUsingQue, value))
                {
                    OnPropertyChanged(ServiceUnitParamedicMetadata.PropertyNames.IsUsingQue);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitParamedic.IsAcceptBPJS
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsAcceptBPJS
        {
            get
            {
                return GetSystemBoolean(ServiceUnitParamedicMetadata.ColumnNames.IsAcceptBPJS);
            }

            set
            {
                if (SetSystemBoolean(ServiceUnitParamedicMetadata.ColumnNames.IsAcceptBPJS, value))
                {
                    OnPropertyChanged(ServiceUnitParamedicMetadata.PropertyNames.IsAcceptBPJS);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitParamedic.IsActive
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsActive
        {
            get
            {
                return GetSystemBoolean(ServiceUnitParamedicMetadata.ColumnNames.IsActive);
            }

            set
            {
                if (SetSystemBoolean(ServiceUnitParamedicMetadata.ColumnNames.IsActive, value))
                {
                    OnPropertyChanged(ServiceUnitParamedicMetadata.PropertyNames.IsActive);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return ServiceUnitParamedicMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public ServiceUnitParamedicQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new ServiceUnitParamedicQuery("supQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(ServiceUnitParamedicQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(ServiceUnitParamedicQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((ServiceUnitParamedicQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private ServiceUnitParamedicQuery query;
    }



    [Serializable]
    abstract public partial class esServiceUnitParamedicCollection : esEntityCollection<ServiceUnitParamedic>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return ServiceUnitParamedicMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "ServiceUnitParamedicCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public ServiceUnitParamedicQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new ServiceUnitParamedicQuery("supQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(ServiceUnitParamedicQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new ServiceUnitParamedicQuery("supQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(ServiceUnitParamedicQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((ServiceUnitParamedicQuery)query);
        }

        #endregion

        private ServiceUnitParamedicQuery query;
    }



    [Serializable]
    abstract public partial class esServiceUnitParamedicQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return ServiceUnitParamedicMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "ServiceUnitID": return ServiceUnitID;
                case "ParamedicID": return ParamedicID;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "DefaultRoomID": return DefaultRoomID;
                case "IsUsingQue": return IsUsingQue;
                case "IsAcceptBPJS": return IsAcceptBPJS;
                case "IsActive": return IsActive;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem ServiceUnitID
        {
            get { return new esQueryItem(this, ServiceUnitParamedicMetadata.ColumnNames.ServiceUnitID, esSystemType.String); }
        }

        public esQueryItem ParamedicID
        {
            get { return new esQueryItem(this, ServiceUnitParamedicMetadata.ColumnNames.ParamedicID, esSystemType.String); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, ServiceUnitParamedicMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, ServiceUnitParamedicMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem DefaultRoomID
        {
            get { return new esQueryItem(this, ServiceUnitParamedicMetadata.ColumnNames.DefaultRoomID, esSystemType.String); }
        }

        public esQueryItem IsUsingQue
        {
            get { return new esQueryItem(this, ServiceUnitParamedicMetadata.ColumnNames.IsUsingQue, esSystemType.Boolean); }
        }

        public esQueryItem IsAcceptBPJS
        {
            get { return new esQueryItem(this, ServiceUnitParamedicMetadata.ColumnNames.IsAcceptBPJS, esSystemType.Boolean); }
        }

        public esQueryItem IsActive
        {
            get { return new esQueryItem(this, ServiceUnitParamedicMetadata.ColumnNames.IsActive, esSystemType.Boolean); }
        }

        #endregion

    }



    [Serializable]
    public partial class ServiceUnitParamedicMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected ServiceUnitParamedicMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.ServiceUnitID, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ServiceUnitID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParamedicID, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParamedicID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
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

            c = new esColumnMetadata(ColumnNames.DefaultRoomID, 4, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DefaultRoomID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsUsingQue, 5, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsUsingQue;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsAcceptBPJS, 6, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsAcceptBPJS;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsActive, 7, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsActive;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public ServiceUnitParamedicMetadata Meta()
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
            public const string ServiceUnitID = "ServiceUnitID";
            public const string ParamedicID = "ParamedicID";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string DefaultRoomID = "DefaultRoomID";
            public const string IsUsingQue = "IsUsingQue";
            public const string IsAcceptBPJS = "IsAcceptBPJS";
            public const string IsActive = "IsActive";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string ServiceUnitID = "ServiceUnitID";
            public const string ParamedicID = "ParamedicID";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string DefaultRoomID = "DefaultRoomID";
            public const string IsUsingQue = "IsUsingQue";
            public const string IsAcceptBPJS = "IsAcceptBPJS";
            public const string IsActive = "IsActive";
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
            lock (typeof(ServiceUnitParamedicMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new ServiceUnitParamedicMetadata();
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


                meta.AddTypeMap("ServiceUnitID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ParamedicID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("DefaultRoomID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsUsingQue", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsAcceptBPJS", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsActive", new esTypeMap("bit", "System.Boolean"));



                meta.Source = "ServiceUnitParamedic";
                meta.Destination = "ServiceUnitParamedic";

                meta.spInsert = "proc_ServiceUnitParamedicInsert";
                meta.spUpdate = "proc_ServiceUnitParamedicUpdate";
                meta.spDelete = "proc_ServiceUnitParamedicDelete";
                meta.spLoadAll = "proc_ServiceUnitParamedicLoadAll";
                meta.spLoadByPrimaryKey = "proc_ServiceUnitParamedicLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private ServiceUnitParamedicMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
