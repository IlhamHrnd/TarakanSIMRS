
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 9/23/2024 3:16:57 PM
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
    /// Encapsulates the 'AppParameter' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(AppParameter))]
    [XmlType("AppParameter")]
    public partial class AppParameter : esAppParameter
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new AppParameter();
        }

        #region Static Quick Access Methods
        static public void Delete(string parameterID)
        {
            var obj = new AppParameter();
            obj.ParameterID = parameterID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string parameterID, esSqlAccessType sqlAccessType)
        {
            var obj = new AppParameter();
            obj.ParameterID = parameterID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("AppParameterCollection")]
    public partial class AppParameterCollection : esAppParameterCollection, IEnumerable<AppParameter>
    {
        public AppParameter FindByPrimaryKey(string parameterID)
        {
            return this.SingleOrDefault(e => e.ParameterID == parameterID);
        }



    }



    [Serializable]
    public partial class AppParameterQuery : esAppParameterQuery
    {
        public AppParameterQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public AppParameterQuery(string joinAlias, out AppParameterQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "AppParameterQuery";
        }



        #region Explicit Casts

        public static explicit operator string(AppParameterQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator AppParameterQuery(string query)
        {
            return (AppParameterQuery)SerializeHelper.FromXml(query, typeof(AppParameterQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esAppParameter : esEntity
    {
        public esAppParameter()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string parameterID)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(parameterID);
            else
                return LoadByPrimaryKeyStoredProcedure(parameterID);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string parameterID)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(parameterID);
            else
                return LoadByPrimaryKeyStoredProcedure(parameterID);
        }

        private bool LoadByPrimaryKeyDynamic(string parameterID)
        {
            AppParameterQuery query = new AppParameterQuery("apQ");
            query.Where(query.ParameterID == parameterID);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string parameterID)
        {
            esParameters parms = new esParameters();
            parms.Add("ParameterID", parameterID);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to AppParameter.ParameterID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParameterID
        {
            get
            {
                return GetSystemString(AppParameterMetadata.ColumnNames.ParameterID);
            }

            set
            {
                if (SetSystemString(AppParameterMetadata.ColumnNames.ParameterID, value))
                {
                    OnPropertyChanged(AppParameterMetadata.PropertyNames.ParameterID);
                }
            }
        }

        /// <summary>
        /// Maps to AppParameter.ParameterName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParameterName
        {
            get
            {
                return GetSystemString(AppParameterMetadata.ColumnNames.ParameterName);
            }

            set
            {
                if (SetSystemString(AppParameterMetadata.ColumnNames.ParameterName, value))
                {
                    OnPropertyChanged(AppParameterMetadata.PropertyNames.ParameterName);
                }
            }
        }

        /// <summary>
        /// Maps to AppParameter.ParameterValue
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParameterValue
        {
            get
            {
                return GetSystemString(AppParameterMetadata.ColumnNames.ParameterValue);
            }

            set
            {
                if (SetSystemString(AppParameterMetadata.ColumnNames.ParameterValue, value))
                {
                    OnPropertyChanged(AppParameterMetadata.PropertyNames.ParameterValue);
                }
            }
        }

        /// <summary>
        /// Maps to AppParameter.ParameterType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public char? ParameterType
        {
            get
            {
                return GetSystemChar(AppParameterMetadata.ColumnNames.ParameterType);
            }

            set
            {
                if (SetSystemChar(AppParameterMetadata.ColumnNames.ParameterType, value))
                {
                    OnPropertyChanged(AppParameterMetadata.PropertyNames.ParameterType);
                }
            }
        }

        /// <summary>
        /// Maps to AppParameter.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(AppParameterMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(AppParameterMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(AppParameterMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to AppParameter.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(AppParameterMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(AppParameterMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(AppParameterMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to AppParameter.IsUsedBySystem
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsUsedBySystem
        {
            get
            {
                return GetSystemBoolean(AppParameterMetadata.ColumnNames.IsUsedBySystem);
            }

            set
            {
                if (SetSystemBoolean(AppParameterMetadata.ColumnNames.IsUsedBySystem, value))
                {
                    OnPropertyChanged(AppParameterMetadata.PropertyNames.IsUsedBySystem);
                }
            }
        }

        /// <summary>
        /// Maps to AppParameter.Message
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Message
        {
            get
            {
                return GetSystemString(AppParameterMetadata.ColumnNames.Message);
            }

            set
            {
                if (SetSystemString(AppParameterMetadata.ColumnNames.Message, value))
                {
                    OnPropertyChanged(AppParameterMetadata.PropertyNames.Message);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return AppParameterMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public AppParameterQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new AppParameterQuery("apQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(AppParameterQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(AppParameterQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((AppParameterQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private AppParameterQuery query;
    }



    [Serializable]
    abstract public partial class esAppParameterCollection : esEntityCollection<AppParameter>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return AppParameterMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "AppParameterCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public AppParameterQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new AppParameterQuery("apQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(AppParameterQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new AppParameterQuery("apQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(AppParameterQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((AppParameterQuery)query);
        }

        #endregion

        private AppParameterQuery query;
    }



    [Serializable]
    abstract public partial class esAppParameterQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return AppParameterMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "ParameterID": return ParameterID;
                case "ParameterName": return ParameterName;
                case "ParameterValue": return ParameterValue;
                case "ParameterType": return ParameterType;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "IsUsedBySystem": return IsUsedBySystem;
                case "Message": return Message;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem ParameterID
        {
            get { return new esQueryItem(this, AppParameterMetadata.ColumnNames.ParameterID, esSystemType.String); }
        }

        public esQueryItem ParameterName
        {
            get { return new esQueryItem(this, AppParameterMetadata.ColumnNames.ParameterName, esSystemType.String); }
        }

        public esQueryItem ParameterValue
        {
            get { return new esQueryItem(this, AppParameterMetadata.ColumnNames.ParameterValue, esSystemType.String); }
        }

        public esQueryItem ParameterType
        {
            get { return new esQueryItem(this, AppParameterMetadata.ColumnNames.ParameterType, esSystemType.Char); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, AppParameterMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, AppParameterMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem IsUsedBySystem
        {
            get { return new esQueryItem(this, AppParameterMetadata.ColumnNames.IsUsedBySystem, esSystemType.Boolean); }
        }

        public esQueryItem Message
        {
            get { return new esQueryItem(this, AppParameterMetadata.ColumnNames.Message, esSystemType.String); }
        }

        #endregion

    }



    [Serializable]
    public partial class AppParameterMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected AppParameterMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.ParameterID, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParameterID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 50;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParameterName, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParameterName;
            c.CharacterMaxLength = 200;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParameterValue, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParameterValue;
            c.CharacterMaxLength = 1000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParameterType, 3, typeof(char), esSystemType.Char);
            c.PropertyName = PropertyNames.ParameterType;
            c.CharacterMaxLength = 1;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 4, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 5, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 40;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsUsedBySystem, 6, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsUsedBySystem;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Message, 7, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Message;
            c.CharacterMaxLength = 200;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public AppParameterMetadata Meta()
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
            public const string ParameterID = "ParameterID";
            public const string ParameterName = "ParameterName";
            public const string ParameterValue = "ParameterValue";
            public const string ParameterType = "ParameterType";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string IsUsedBySystem = "IsUsedBySystem";
            public const string Message = "Message";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string ParameterID = "ParameterID";
            public const string ParameterName = "ParameterName";
            public const string ParameterValue = "ParameterValue";
            public const string ParameterType = "ParameterType";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string IsUsedBySystem = "IsUsedBySystem";
            public const string Message = "Message";
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
            lock (typeof(AppParameterMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new AppParameterMetadata();
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


                meta.AddTypeMap("ParameterID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ParameterName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ParameterValue", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ParameterType", new esTypeMap("char", "System.Char"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsUsedBySystem", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("Message", new esTypeMap("varchar", "System.String"));



                meta.Source = "AppParameter";
                meta.Destination = "AppParameter";

                meta.spInsert = "proc_AppParameterInsert";
                meta.spUpdate = "proc_AppParameterUpdate";
                meta.spDelete = "proc_AppParameterDelete";
                meta.spLoadAll = "proc_AppParameterLoadAll";
                meta.spLoadByPrimaryKey = "proc_AppParameterLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private AppParameterMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
