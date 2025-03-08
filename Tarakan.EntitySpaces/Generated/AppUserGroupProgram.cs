
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 3/8/2025 7:55:10 AM
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
    /// Encapsulates the 'AppUserGroupProgram' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(AppUserGroupProgram))]
    [XmlType("AppUserGroupProgram")]
    public partial class AppUserGroupProgram : esAppUserGroupProgram
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new AppUserGroupProgram();
        }

        #region Static Quick Access Methods
        static public void Delete(string programID, string userGroupID)
        {
            var obj = new AppUserGroupProgram();
            obj.ProgramID = programID;
            obj.UserGroupID = userGroupID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string programID, string userGroupID, esSqlAccessType sqlAccessType)
        {
            var obj = new AppUserGroupProgram();
            obj.ProgramID = programID;
            obj.UserGroupID = userGroupID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("AppUserGroupProgramCollection")]
    public partial class AppUserGroupProgramCollection : esAppUserGroupProgramCollection, IEnumerable<AppUserGroupProgram>
    {
        public AppUserGroupProgram FindByPrimaryKey(string programID, string userGroupID)
        {
            return this.SingleOrDefault(e => e.ProgramID == programID && e.UserGroupID == userGroupID);
        }



    }



    [Serializable]
    public partial class AppUserGroupProgramQuery : esAppUserGroupProgramQuery
    {
        public AppUserGroupProgramQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public AppUserGroupProgramQuery(string joinAlias, out AppUserGroupProgramQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "AppUserGroupProgramQuery";
        }



        #region Explicit Casts

        public static explicit operator string(AppUserGroupProgramQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator AppUserGroupProgramQuery(string query)
        {
            return (AppUserGroupProgramQuery)SerializeHelper.FromXml(query, typeof(AppUserGroupProgramQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esAppUserGroupProgram : esEntity
    {
        public esAppUserGroupProgram()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string programID, string userGroupID)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(programID, userGroupID);
            else
                return LoadByPrimaryKeyStoredProcedure(programID, userGroupID);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string programID, string userGroupID)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(programID, userGroupID);
            else
                return LoadByPrimaryKeyStoredProcedure(programID, userGroupID);
        }

        private bool LoadByPrimaryKeyDynamic(string programID, string userGroupID)
        {
            AppUserGroupProgramQuery query = new AppUserGroupProgramQuery("augpQ");
            query.Where(query.ProgramID == programID, query.UserGroupID == userGroupID);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string programID, string userGroupID)
        {
            esParameters parms = new esParameters();
            parms.Add("ProgramID", programID); parms.Add("UserGroupID", userGroupID);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to AppUserGroupProgram.UserGroupID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string UserGroupID
        {
            get
            {
                return GetSystemString(AppUserGroupProgramMetadata.ColumnNames.UserGroupID);
            }

            set
            {
                if (SetSystemString(AppUserGroupProgramMetadata.ColumnNames.UserGroupID, value))
                {
                    OnPropertyChanged(AppUserGroupProgramMetadata.PropertyNames.UserGroupID);
                }
            }
        }

        /// <summary>
        /// Maps to AppUserGroupProgram.ProgramID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ProgramID
        {
            get
            {
                return GetSystemString(AppUserGroupProgramMetadata.ColumnNames.ProgramID);
            }

            set
            {
                if (SetSystemString(AppUserGroupProgramMetadata.ColumnNames.ProgramID, value))
                {
                    OnPropertyChanged(AppUserGroupProgramMetadata.PropertyNames.ProgramID);
                }
            }
        }

        /// <summary>
        /// Maps to AppUserGroupProgram.IsUserGroupAddAble
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsUserGroupAddAble
        {
            get
            {
                return GetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupAddAble);
            }

            set
            {
                if (SetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupAddAble, value))
                {
                    OnPropertyChanged(AppUserGroupProgramMetadata.PropertyNames.IsUserGroupAddAble);
                }
            }
        }

        /// <summary>
        /// Maps to AppUserGroupProgram.IsUserGroupEditAble
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsUserGroupEditAble
        {
            get
            {
                return GetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupEditAble);
            }

            set
            {
                if (SetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupEditAble, value))
                {
                    OnPropertyChanged(AppUserGroupProgramMetadata.PropertyNames.IsUserGroupEditAble);
                }
            }
        }

        /// <summary>
        /// Maps to AppUserGroupProgram.IsUserGroupDeleteAble
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsUserGroupDeleteAble
        {
            get
            {
                return GetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupDeleteAble);
            }

            set
            {
                if (SetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupDeleteAble, value))
                {
                    OnPropertyChanged(AppUserGroupProgramMetadata.PropertyNames.IsUserGroupDeleteAble);
                }
            }
        }

        /// <summary>
        /// Maps to AppUserGroupProgram.IsUserGroupApprovalAble
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsUserGroupApprovalAble
        {
            get
            {
                return GetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupApprovalAble);
            }

            set
            {
                if (SetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupApprovalAble, value))
                {
                    OnPropertyChanged(AppUserGroupProgramMetadata.PropertyNames.IsUserGroupApprovalAble);
                }
            }
        }

        /// <summary>
        /// Maps to AppUserGroupProgram.IsUserGroupUnApprovalAble
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsUserGroupUnApprovalAble
        {
            get
            {
                return GetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupUnApprovalAble);
            }

            set
            {
                if (SetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupUnApprovalAble, value))
                {
                    OnPropertyChanged(AppUserGroupProgramMetadata.PropertyNames.IsUserGroupUnApprovalAble);
                }
            }
        }

        /// <summary>
        /// Maps to AppUserGroupProgram.IsUserGroupVoidAble
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsUserGroupVoidAble
        {
            get
            {
                return GetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupVoidAble);
            }

            set
            {
                if (SetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupVoidAble, value))
                {
                    OnPropertyChanged(AppUserGroupProgramMetadata.PropertyNames.IsUserGroupVoidAble);
                }
            }
        }

        /// <summary>
        /// Maps to AppUserGroupProgram.IsUserGroupUnVoidAble
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsUserGroupUnVoidAble
        {
            get
            {
                return GetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupUnVoidAble);
            }

            set
            {
                if (SetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupUnVoidAble, value))
                {
                    OnPropertyChanged(AppUserGroupProgramMetadata.PropertyNames.IsUserGroupUnVoidAble);
                }
            }
        }

        /// <summary>
        /// Maps to AppUserGroupProgram.IsUserGroupExportAble
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsUserGroupExportAble
        {
            get
            {
                return GetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupExportAble);
            }

            set
            {
                if (SetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupExportAble, value))
                {
                    OnPropertyChanged(AppUserGroupProgramMetadata.PropertyNames.IsUserGroupExportAble);
                }
            }
        }

        /// <summary>
        /// Maps to AppUserGroupProgram.IsUserGroupCrossUnitAble
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsUserGroupCrossUnitAble
        {
            get
            {
                return GetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupCrossUnitAble);
            }

            set
            {
                if (SetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupCrossUnitAble, value))
                {
                    OnPropertyChanged(AppUserGroupProgramMetadata.PropertyNames.IsUserGroupCrossUnitAble);
                }
            }
        }

        /// <summary>
        /// Maps to AppUserGroupProgram.IsUserGroupPowerUserAble
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsUserGroupPowerUserAble
        {
            get
            {
                return GetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupPowerUserAble);
            }

            set
            {
                if (SetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupPowerUserAble, value))
                {
                    OnPropertyChanged(AppUserGroupProgramMetadata.PropertyNames.IsUserGroupPowerUserAble);
                }
            }
        }

        /// <summary>
        /// Maps to AppUserGroupProgram.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(AppUserGroupProgramMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(AppUserGroupProgramMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(AppUserGroupProgramMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to AppUserGroupProgram.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(AppUserGroupProgramMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(AppUserGroupProgramMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(AppUserGroupProgramMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return AppUserGroupProgramMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public AppUserGroupProgramQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new AppUserGroupProgramQuery("augpQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(AppUserGroupProgramQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(AppUserGroupProgramQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((AppUserGroupProgramQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private AppUserGroupProgramQuery query;
    }



    [Serializable]
    abstract public partial class esAppUserGroupProgramCollection : esEntityCollection<AppUserGroupProgram>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return AppUserGroupProgramMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "AppUserGroupProgramCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public AppUserGroupProgramQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new AppUserGroupProgramQuery("augpQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(AppUserGroupProgramQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new AppUserGroupProgramQuery("augpQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(AppUserGroupProgramQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((AppUserGroupProgramQuery)query);
        }

        #endregion

        private AppUserGroupProgramQuery query;
    }



    [Serializable]
    abstract public partial class esAppUserGroupProgramQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return AppUserGroupProgramMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "UserGroupID": return UserGroupID;
                case "ProgramID": return ProgramID;
                case "IsUserGroupAddAble": return IsUserGroupAddAble;
                case "IsUserGroupEditAble": return IsUserGroupEditAble;
                case "IsUserGroupDeleteAble": return IsUserGroupDeleteAble;
                case "IsUserGroupApprovalAble": return IsUserGroupApprovalAble;
                case "IsUserGroupUnApprovalAble": return IsUserGroupUnApprovalAble;
                case "IsUserGroupVoidAble": return IsUserGroupVoidAble;
                case "IsUserGroupUnVoidAble": return IsUserGroupUnVoidAble;
                case "IsUserGroupExportAble": return IsUserGroupExportAble;
                case "IsUserGroupCrossUnitAble": return IsUserGroupCrossUnitAble;
                case "IsUserGroupPowerUserAble": return IsUserGroupPowerUserAble;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem UserGroupID
        {
            get { return new esQueryItem(this, AppUserGroupProgramMetadata.ColumnNames.UserGroupID, esSystemType.String); }
        }

        public esQueryItem ProgramID
        {
            get { return new esQueryItem(this, AppUserGroupProgramMetadata.ColumnNames.ProgramID, esSystemType.String); }
        }

        public esQueryItem IsUserGroupAddAble
        {
            get { return new esQueryItem(this, AppUserGroupProgramMetadata.ColumnNames.IsUserGroupAddAble, esSystemType.Boolean); }
        }

        public esQueryItem IsUserGroupEditAble
        {
            get { return new esQueryItem(this, AppUserGroupProgramMetadata.ColumnNames.IsUserGroupEditAble, esSystemType.Boolean); }
        }

        public esQueryItem IsUserGroupDeleteAble
        {
            get { return new esQueryItem(this, AppUserGroupProgramMetadata.ColumnNames.IsUserGroupDeleteAble, esSystemType.Boolean); }
        }

        public esQueryItem IsUserGroupApprovalAble
        {
            get { return new esQueryItem(this, AppUserGroupProgramMetadata.ColumnNames.IsUserGroupApprovalAble, esSystemType.Boolean); }
        }

        public esQueryItem IsUserGroupUnApprovalAble
        {
            get { return new esQueryItem(this, AppUserGroupProgramMetadata.ColumnNames.IsUserGroupUnApprovalAble, esSystemType.Boolean); }
        }

        public esQueryItem IsUserGroupVoidAble
        {
            get { return new esQueryItem(this, AppUserGroupProgramMetadata.ColumnNames.IsUserGroupVoidAble, esSystemType.Boolean); }
        }

        public esQueryItem IsUserGroupUnVoidAble
        {
            get { return new esQueryItem(this, AppUserGroupProgramMetadata.ColumnNames.IsUserGroupUnVoidAble, esSystemType.Boolean); }
        }

        public esQueryItem IsUserGroupExportAble
        {
            get { return new esQueryItem(this, AppUserGroupProgramMetadata.ColumnNames.IsUserGroupExportAble, esSystemType.Boolean); }
        }

        public esQueryItem IsUserGroupCrossUnitAble
        {
            get { return new esQueryItem(this, AppUserGroupProgramMetadata.ColumnNames.IsUserGroupCrossUnitAble, esSystemType.Boolean); }
        }

        public esQueryItem IsUserGroupPowerUserAble
        {
            get { return new esQueryItem(this, AppUserGroupProgramMetadata.ColumnNames.IsUserGroupPowerUserAble, esSystemType.Boolean); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, AppUserGroupProgramMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, AppUserGroupProgramMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        #endregion

    }



    [Serializable]
    public partial class AppUserGroupProgramMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected AppUserGroupProgramMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.UserGroupID, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.UserGroupID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 10;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ProgramID, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ProgramID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 30;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsUserGroupAddAble, 2, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsUserGroupAddAble;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsUserGroupEditAble, 3, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsUserGroupEditAble;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsUserGroupDeleteAble, 4, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsUserGroupDeleteAble;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsUserGroupApprovalAble, 5, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsUserGroupApprovalAble;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsUserGroupUnApprovalAble, 6, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsUserGroupUnApprovalAble;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsUserGroupVoidAble, 7, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsUserGroupVoidAble;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsUserGroupUnVoidAble, 8, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsUserGroupUnVoidAble;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsUserGroupExportAble, 9, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsUserGroupExportAble;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsUserGroupCrossUnitAble, 10, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsUserGroupCrossUnitAble;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsUserGroupPowerUserAble, 11, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsUserGroupPowerUserAble;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 12, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 13, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 40;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public AppUserGroupProgramMetadata Meta()
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
            public const string UserGroupID = "UserGroupID";
            public const string ProgramID = "ProgramID";
            public const string IsUserGroupAddAble = "IsUserGroupAddAble";
            public const string IsUserGroupEditAble = "IsUserGroupEditAble";
            public const string IsUserGroupDeleteAble = "IsUserGroupDeleteAble";
            public const string IsUserGroupApprovalAble = "IsUserGroupApprovalAble";
            public const string IsUserGroupUnApprovalAble = "IsUserGroupUnApprovalAble";
            public const string IsUserGroupVoidAble = "IsUserGroupVoidAble";
            public const string IsUserGroupUnVoidAble = "IsUserGroupUnVoidAble";
            public const string IsUserGroupExportAble = "IsUserGroupExportAble";
            public const string IsUserGroupCrossUnitAble = "IsUserGroupCrossUnitAble";
            public const string IsUserGroupPowerUserAble = "IsUserGroupPowerUserAble";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string UserGroupID = "UserGroupID";
            public const string ProgramID = "ProgramID";
            public const string IsUserGroupAddAble = "IsUserGroupAddAble";
            public const string IsUserGroupEditAble = "IsUserGroupEditAble";
            public const string IsUserGroupDeleteAble = "IsUserGroupDeleteAble";
            public const string IsUserGroupApprovalAble = "IsUserGroupApprovalAble";
            public const string IsUserGroupUnApprovalAble = "IsUserGroupUnApprovalAble";
            public const string IsUserGroupVoidAble = "IsUserGroupVoidAble";
            public const string IsUserGroupUnVoidAble = "IsUserGroupUnVoidAble";
            public const string IsUserGroupExportAble = "IsUserGroupExportAble";
            public const string IsUserGroupCrossUnitAble = "IsUserGroupCrossUnitAble";
            public const string IsUserGroupPowerUserAble = "IsUserGroupPowerUserAble";
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
            lock (typeof(AppUserGroupProgramMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new AppUserGroupProgramMetadata();
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


                meta.AddTypeMap("UserGroupID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ProgramID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsUserGroupAddAble", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsUserGroupEditAble", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsUserGroupDeleteAble", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsUserGroupApprovalAble", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsUserGroupUnApprovalAble", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsUserGroupVoidAble", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsUserGroupUnVoidAble", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsUserGroupExportAble", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsUserGroupCrossUnitAble", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsUserGroupPowerUserAble", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));



                meta.Source = "AppUserGroupProgram";
                meta.Destination = "AppUserGroupProgram";

                meta.spInsert = "proc_AppUserGroupProgramInsert";
                meta.spUpdate = "proc_AppUserGroupProgramUpdate";
                meta.spDelete = "proc_AppUserGroupProgramDelete";
                meta.spLoadAll = "proc_AppUserGroupProgramLoadAll";
                meta.spLoadByPrimaryKey = "proc_AppUserGroupProgramLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private AppUserGroupProgramMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
