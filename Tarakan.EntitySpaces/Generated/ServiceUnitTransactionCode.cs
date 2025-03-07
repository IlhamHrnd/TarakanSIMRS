
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 2/12/2025 3:38:53 PM
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
    /// Encapsulates the 'ServiceUnitTransactionCode' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(ServiceUnitTransactionCode))]
    [XmlType("ServiceUnitTransactionCode")]
    public partial class ServiceUnitTransactionCode : esServiceUnitTransactionCode
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new ServiceUnitTransactionCode();
        }

        #region Static Quick Access Methods
        static public void Delete(string serviceUnitID, string sRTransactionCode)
        {
            var obj = new ServiceUnitTransactionCode();
            obj.ServiceUnitID = serviceUnitID;
            obj.SRTransactionCode = sRTransactionCode;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string serviceUnitID, string sRTransactionCode, esSqlAccessType sqlAccessType)
        {
            var obj = new ServiceUnitTransactionCode();
            obj.ServiceUnitID = serviceUnitID;
            obj.SRTransactionCode = sRTransactionCode;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("ServiceUnitTransactionCodeCollection")]
    public partial class ServiceUnitTransactionCodeCollection : esServiceUnitTransactionCodeCollection, IEnumerable<ServiceUnitTransactionCode>
    {
        public ServiceUnitTransactionCode FindByPrimaryKey(string serviceUnitID, string sRTransactionCode)
        {
            return this.SingleOrDefault(e => e.ServiceUnitID == serviceUnitID && e.SRTransactionCode == sRTransactionCode);
        }



    }



    [Serializable]
    public partial class ServiceUnitTransactionCodeQuery : esServiceUnitTransactionCodeQuery
    {
        public ServiceUnitTransactionCodeQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public ServiceUnitTransactionCodeQuery(string joinAlias, out ServiceUnitTransactionCodeQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "ServiceUnitTransactionCodeQuery";
        }



        #region Explicit Casts

        public static explicit operator string(ServiceUnitTransactionCodeQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator ServiceUnitTransactionCodeQuery(string query)
        {
            return (ServiceUnitTransactionCodeQuery)SerializeHelper.FromXml(query, typeof(ServiceUnitTransactionCodeQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esServiceUnitTransactionCode : esEntity
    {
        public esServiceUnitTransactionCode()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string serviceUnitID, string sRTransactionCode)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(serviceUnitID, sRTransactionCode);
            else
                return LoadByPrimaryKeyStoredProcedure(serviceUnitID, sRTransactionCode);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string serviceUnitID, string sRTransactionCode)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(serviceUnitID, sRTransactionCode);
            else
                return LoadByPrimaryKeyStoredProcedure(serviceUnitID, sRTransactionCode);
        }

        private bool LoadByPrimaryKeyDynamic(string serviceUnitID, string sRTransactionCode)
        {
            ServiceUnitTransactionCodeQuery query = new ServiceUnitTransactionCodeQuery("sutcQ");
            query.Where(query.ServiceUnitID == serviceUnitID, query.SRTransactionCode == sRTransactionCode);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string serviceUnitID, string sRTransactionCode)
        {
            esParameters parms = new esParameters();
            parms.Add("ServiceUnitID", serviceUnitID); parms.Add("SRTransactionCode", sRTransactionCode);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to ServiceUnitTransactionCode.ServiceUnitID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ServiceUnitID
        {
            get
            {
                return GetSystemString(ServiceUnitTransactionCodeMetadata.ColumnNames.ServiceUnitID);
            }

            set
            {
                if (SetSystemString(ServiceUnitTransactionCodeMetadata.ColumnNames.ServiceUnitID, value))
                {
                    OnPropertyChanged(ServiceUnitTransactionCodeMetadata.PropertyNames.ServiceUnitID);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitTransactionCode.SRTransactionCode
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRTransactionCode
        {
            get
            {
                return GetSystemString(ServiceUnitTransactionCodeMetadata.ColumnNames.SRTransactionCode);
            }

            set
            {
                if (SetSystemString(ServiceUnitTransactionCodeMetadata.ColumnNames.SRTransactionCode, value))
                {
                    OnPropertyChanged(ServiceUnitTransactionCodeMetadata.PropertyNames.SRTransactionCode);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitTransactionCode.IsItemProductMedic
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsItemProductMedic
        {
            get
            {
                return GetSystemBoolean(ServiceUnitTransactionCodeMetadata.ColumnNames.IsItemProductMedic);
            }

            set
            {
                if (SetSystemBoolean(ServiceUnitTransactionCodeMetadata.ColumnNames.IsItemProductMedic, value))
                {
                    OnPropertyChanged(ServiceUnitTransactionCodeMetadata.PropertyNames.IsItemProductMedic);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitTransactionCode.IsItemProductNonMedic
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsItemProductNonMedic
        {
            get
            {
                return GetSystemBoolean(ServiceUnitTransactionCodeMetadata.ColumnNames.IsItemProductNonMedic);
            }

            set
            {
                if (SetSystemBoolean(ServiceUnitTransactionCodeMetadata.ColumnNames.IsItemProductNonMedic, value))
                {
                    OnPropertyChanged(ServiceUnitTransactionCodeMetadata.PropertyNames.IsItemProductNonMedic);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitTransactionCode.IsItemKitchen
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsItemKitchen
        {
            get
            {
                return GetSystemBoolean(ServiceUnitTransactionCodeMetadata.ColumnNames.IsItemKitchen);
            }

            set
            {
                if (SetSystemBoolean(ServiceUnitTransactionCodeMetadata.ColumnNames.IsItemKitchen, value))
                {
                    OnPropertyChanged(ServiceUnitTransactionCodeMetadata.PropertyNames.IsItemKitchen);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitTransactionCode.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(ServiceUnitTransactionCodeMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(ServiceUnitTransactionCodeMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(ServiceUnitTransactionCodeMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitTransactionCode.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(ServiceUnitTransactionCodeMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(ServiceUnitTransactionCodeMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(ServiceUnitTransactionCodeMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return ServiceUnitTransactionCodeMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public ServiceUnitTransactionCodeQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new ServiceUnitTransactionCodeQuery("sutcQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(ServiceUnitTransactionCodeQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(ServiceUnitTransactionCodeQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((ServiceUnitTransactionCodeQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private ServiceUnitTransactionCodeQuery query;
    }



    [Serializable]
    abstract public partial class esServiceUnitTransactionCodeCollection : esEntityCollection<ServiceUnitTransactionCode>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return ServiceUnitTransactionCodeMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "ServiceUnitTransactionCodeCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public ServiceUnitTransactionCodeQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new ServiceUnitTransactionCodeQuery("sutcQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(ServiceUnitTransactionCodeQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new ServiceUnitTransactionCodeQuery("sutcQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(ServiceUnitTransactionCodeQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((ServiceUnitTransactionCodeQuery)query);
        }

        #endregion

        private ServiceUnitTransactionCodeQuery query;
    }



    [Serializable]
    abstract public partial class esServiceUnitTransactionCodeQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return ServiceUnitTransactionCodeMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "ServiceUnitID": return ServiceUnitID;
                case "SRTransactionCode": return SRTransactionCode;
                case "IsItemProductMedic": return IsItemProductMedic;
                case "IsItemProductNonMedic": return IsItemProductNonMedic;
                case "IsItemKitchen": return IsItemKitchen;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem ServiceUnitID
        {
            get { return new esQueryItem(this, ServiceUnitTransactionCodeMetadata.ColumnNames.ServiceUnitID, esSystemType.String); }
        }

        public esQueryItem SRTransactionCode
        {
            get { return new esQueryItem(this, ServiceUnitTransactionCodeMetadata.ColumnNames.SRTransactionCode, esSystemType.String); }
        }

        public esQueryItem IsItemProductMedic
        {
            get { return new esQueryItem(this, ServiceUnitTransactionCodeMetadata.ColumnNames.IsItemProductMedic, esSystemType.Boolean); }
        }

        public esQueryItem IsItemProductNonMedic
        {
            get { return new esQueryItem(this, ServiceUnitTransactionCodeMetadata.ColumnNames.IsItemProductNonMedic, esSystemType.Boolean); }
        }

        public esQueryItem IsItemKitchen
        {
            get { return new esQueryItem(this, ServiceUnitTransactionCodeMetadata.ColumnNames.IsItemKitchen, esSystemType.Boolean); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, ServiceUnitTransactionCodeMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, ServiceUnitTransactionCodeMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        #endregion

    }



    [Serializable]
    public partial class ServiceUnitTransactionCodeMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected ServiceUnitTransactionCodeMetadata()
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

            c = new esColumnMetadata(ColumnNames.SRTransactionCode, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRTransactionCode;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsItemProductMedic, 2, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsItemProductMedic;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsItemProductNonMedic, 3, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsItemProductNonMedic;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsItemKitchen, 4, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsItemKitchen;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 5, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 6, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 40;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public ServiceUnitTransactionCodeMetadata Meta()
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
            public const string SRTransactionCode = "SRTransactionCode";
            public const string IsItemProductMedic = "IsItemProductMedic";
            public const string IsItemProductNonMedic = "IsItemProductNonMedic";
            public const string IsItemKitchen = "IsItemKitchen";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string ServiceUnitID = "ServiceUnitID";
            public const string SRTransactionCode = "SRTransactionCode";
            public const string IsItemProductMedic = "IsItemProductMedic";
            public const string IsItemProductNonMedic = "IsItemProductNonMedic";
            public const string IsItemKitchen = "IsItemKitchen";
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
            lock (typeof(ServiceUnitTransactionCodeMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new ServiceUnitTransactionCodeMetadata();
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
                meta.AddTypeMap("SRTransactionCode", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsItemProductMedic", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsItemProductNonMedic", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsItemKitchen", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));



                meta.Source = "ServiceUnitTransactionCode";
                meta.Destination = "ServiceUnitTransactionCode";

                meta.spInsert = "proc_ServiceUnitTransactionCodeInsert";
                meta.spUpdate = "proc_ServiceUnitTransactionCodeUpdate";
                meta.spDelete = "proc_ServiceUnitTransactionCodeDelete";
                meta.spLoadAll = "proc_ServiceUnitTransactionCodeLoadAll";
                meta.spLoadByPrimaryKey = "proc_ServiceUnitTransactionCodeLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private ServiceUnitTransactionCodeMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
