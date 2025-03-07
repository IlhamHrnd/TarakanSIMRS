
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 2/12/2025 10:16:39 AM
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
    /// Encapsulates the 'MergeBilling' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(MergeBilling))]
    [XmlType("MergeBilling")]
    public partial class MergeBilling : esMergeBilling
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new MergeBilling();
        }

        #region Static Quick Access Methods
        static public void Delete(string registrationNo)
        {
            var obj = new MergeBilling();
            obj.RegistrationNo = registrationNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string registrationNo, esSqlAccessType sqlAccessType)
        {
            var obj = new MergeBilling();
            obj.RegistrationNo = registrationNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("MergeBillingCollection")]
    public partial class MergeBillingCollection : esMergeBillingCollection, IEnumerable<MergeBilling>
    {
        public MergeBilling FindByPrimaryKey(string registrationNo)
        {
            return this.SingleOrDefault(e => e.RegistrationNo == registrationNo);
        }



    }



    [Serializable]
    public partial class MergeBillingQuery : esMergeBillingQuery
    {
        public MergeBillingQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public MergeBillingQuery(string joinAlias, out MergeBillingQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "MergeBillingQuery";
        }



        #region Explicit Casts

        public static explicit operator string(MergeBillingQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator MergeBillingQuery(string query)
        {
            return (MergeBillingQuery)SerializeHelper.FromXml(query, typeof(MergeBillingQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esMergeBilling : esEntity
    {
        public esMergeBilling()
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
            MergeBillingQuery query = new MergeBillingQuery("mbQ");
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
        /// Maps to MergeBilling.RegistrationNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RegistrationNo
        {
            get
            {
                return GetSystemString(MergeBillingMetadata.ColumnNames.RegistrationNo);
            }

            set
            {
                if (SetSystemString(MergeBillingMetadata.ColumnNames.RegistrationNo, value))
                {
                    OnPropertyChanged(MergeBillingMetadata.PropertyNames.RegistrationNo);
                }
            }
        }

        /// <summary>
        /// Maps to MergeBilling.FromRegistrationNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string FromRegistrationNo
        {
            get
            {
                return GetSystemString(MergeBillingMetadata.ColumnNames.FromRegistrationNo);
            }

            set
            {
                if (SetSystemString(MergeBillingMetadata.ColumnNames.FromRegistrationNo, value))
                {
                    OnPropertyChanged(MergeBillingMetadata.PropertyNames.FromRegistrationNo);
                }
            }
        }

        /// <summary>
        /// Maps to MergeBilling.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(MergeBillingMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(MergeBillingMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(MergeBillingMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to MergeBilling.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(MergeBillingMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(MergeBillingMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(MergeBillingMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return MergeBillingMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public MergeBillingQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new MergeBillingQuery("mbQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(MergeBillingQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(MergeBillingQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((MergeBillingQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private MergeBillingQuery query;
    }



    [Serializable]
    abstract public partial class esMergeBillingCollection : esEntityCollection<MergeBilling>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return MergeBillingMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "MergeBillingCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public MergeBillingQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new MergeBillingQuery("mbQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(MergeBillingQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new MergeBillingQuery("mbQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(MergeBillingQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((MergeBillingQuery)query);
        }

        #endregion

        private MergeBillingQuery query;
    }



    [Serializable]
    abstract public partial class esMergeBillingQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return MergeBillingMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "RegistrationNo": return RegistrationNo;
                case "FromRegistrationNo": return FromRegistrationNo;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem RegistrationNo
        {
            get { return new esQueryItem(this, MergeBillingMetadata.ColumnNames.RegistrationNo, esSystemType.String); }
        }

        public esQueryItem FromRegistrationNo
        {
            get { return new esQueryItem(this, MergeBillingMetadata.ColumnNames.FromRegistrationNo, esSystemType.String); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, MergeBillingMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, MergeBillingMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        #endregion

    }



    [Serializable]
    public partial class MergeBillingMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected MergeBillingMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.RegistrationNo, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RegistrationNo;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FromRegistrationNo, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.FromRegistrationNo;
            c.CharacterMaxLength = 20;
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

        }
        #endregion

        static public MergeBillingMetadata Meta()
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
            public const string FromRegistrationNo = "FromRegistrationNo";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string RegistrationNo = "RegistrationNo";
            public const string FromRegistrationNo = "FromRegistrationNo";
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
            lock (typeof(MergeBillingMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new MergeBillingMetadata();
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
                meta.AddTypeMap("FromRegistrationNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));



                meta.Source = "MergeBilling";
                meta.Destination = "MergeBilling";

                meta.spInsert = "proc_MergeBillingInsert";
                meta.spUpdate = "proc_MergeBillingUpdate";
                meta.spDelete = "proc_MergeBillingDelete";
                meta.spLoadAll = "proc_MergeBillingLoadAll";
                meta.spLoadByPrimaryKey = "proc_MergeBillingLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private MergeBillingMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
