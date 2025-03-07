
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 2/17/2025 9:53:28 AM
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
    /// Encapsulates the 'Department' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(Department))]
    [XmlType("Department")]
    public partial class Department : esDepartment
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new Department();
        }

        #region Static Quick Access Methods
        static public void Delete(string departmentID)
        {
            var obj = new Department();
            obj.DepartmentID = departmentID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string departmentID, esSqlAccessType sqlAccessType)
        {
            var obj = new Department();
            obj.DepartmentID = departmentID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("DepartmentCollection")]
    public partial class DepartmentCollection : esDepartmentCollection, IEnumerable<Department>
    {
        public Department FindByPrimaryKey(string departmentID)
        {
            return this.SingleOrDefault(e => e.DepartmentID == departmentID);
        }



    }



    [Serializable]
    public partial class DepartmentQuery : esDepartmentQuery
    {
        public DepartmentQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public DepartmentQuery(string joinAlias, out DepartmentQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "DepartmentQuery";
        }



        #region Explicit Casts

        public static explicit operator string(DepartmentQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator DepartmentQuery(string query)
        {
            return (DepartmentQuery)SerializeHelper.FromXml(query, typeof(DepartmentQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esDepartment : esEntity
    {
        public esDepartment()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string departmentID)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(departmentID);
            else
                return LoadByPrimaryKeyStoredProcedure(departmentID);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string departmentID)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(departmentID);
            else
                return LoadByPrimaryKeyStoredProcedure(departmentID);
        }

        private bool LoadByPrimaryKeyDynamic(string departmentID)
        {
            DepartmentQuery query = new DepartmentQuery("dQ");
            query.Where(query.DepartmentID == departmentID);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string departmentID)
        {
            esParameters parms = new esParameters();
            parms.Add("DepartmentID", departmentID);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to Department.DepartmentID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DepartmentID
        {
            get
            {
                return GetSystemString(DepartmentMetadata.ColumnNames.DepartmentID);
            }

            set
            {
                if (SetSystemString(DepartmentMetadata.ColumnNames.DepartmentID, value))
                {
                    OnPropertyChanged(DepartmentMetadata.PropertyNames.DepartmentID);
                }
            }
        }

        /// <summary>
        /// Maps to Department.DepartmentName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DepartmentName
        {
            get
            {
                return GetSystemString(DepartmentMetadata.ColumnNames.DepartmentName);
            }

            set
            {
                if (SetSystemString(DepartmentMetadata.ColumnNames.DepartmentName, value))
                {
                    OnPropertyChanged(DepartmentMetadata.PropertyNames.DepartmentName);
                }
            }
        }

        /// <summary>
        /// Maps to Department.ShortName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ShortName
        {
            get
            {
                return GetSystemString(DepartmentMetadata.ColumnNames.ShortName);
            }

            set
            {
                if (SetSystemString(DepartmentMetadata.ColumnNames.ShortName, value))
                {
                    OnPropertyChanged(DepartmentMetadata.PropertyNames.ShortName);
                }
            }
        }

        /// <summary>
        /// Maps to Department.Initial
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Initial
        {
            get
            {
                return GetSystemString(DepartmentMetadata.ColumnNames.Initial);
            }

            set
            {
                if (SetSystemString(DepartmentMetadata.ColumnNames.Initial, value))
                {
                    OnPropertyChanged(DepartmentMetadata.PropertyNames.Initial);
                }
            }
        }

        /// <summary>
        /// Maps to Department.DepartmentManager
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DepartmentManager
        {
            get
            {
                return GetSystemString(DepartmentMetadata.ColumnNames.DepartmentManager);
            }

            set
            {
                if (SetSystemString(DepartmentMetadata.ColumnNames.DepartmentManager, value))
                {
                    OnPropertyChanged(DepartmentMetadata.PropertyNames.DepartmentManager);
                }
            }
        }

        /// <summary>
        /// Maps to Department.IsHasRegistration
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsHasRegistration
        {
            get
            {
                return GetSystemBoolean(DepartmentMetadata.ColumnNames.IsHasRegistration);
            }

            set
            {
                if (SetSystemBoolean(DepartmentMetadata.ColumnNames.IsHasRegistration, value))
                {
                    OnPropertyChanged(DepartmentMetadata.PropertyNames.IsHasRegistration);
                }
            }
        }

        /// <summary>
        /// Maps to Department.IsAllowBackDateRegistration
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsAllowBackDateRegistration
        {
            get
            {
                return GetSystemBoolean(DepartmentMetadata.ColumnNames.IsAllowBackDateRegistration);
            }

            set
            {
                if (SetSystemBoolean(DepartmentMetadata.ColumnNames.IsAllowBackDateRegistration, value))
                {
                    OnPropertyChanged(DepartmentMetadata.PropertyNames.IsAllowBackDateRegistration);
                }
            }
        }

        /// <summary>
        /// Maps to Department.IsActive
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsActive
        {
            get
            {
                return GetSystemBoolean(DepartmentMetadata.ColumnNames.IsActive);
            }

            set
            {
                if (SetSystemBoolean(DepartmentMetadata.ColumnNames.IsActive, value))
                {
                    OnPropertyChanged(DepartmentMetadata.PropertyNames.IsActive);
                }
            }
        }

        /// <summary>
        /// Maps to Department.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(DepartmentMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(DepartmentMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(DepartmentMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to Department.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(DepartmentMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(DepartmentMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(DepartmentMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return DepartmentMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public DepartmentQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new DepartmentQuery("dQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(DepartmentQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(DepartmentQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((DepartmentQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private DepartmentQuery query;
    }



    [Serializable]
    abstract public partial class esDepartmentCollection : esEntityCollection<Department>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return DepartmentMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "DepartmentCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public DepartmentQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new DepartmentQuery("dQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(DepartmentQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new DepartmentQuery("dQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(DepartmentQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((DepartmentQuery)query);
        }

        #endregion

        private DepartmentQuery query;
    }



    [Serializable]
    abstract public partial class esDepartmentQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return DepartmentMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "DepartmentID": return DepartmentID;
                case "DepartmentName": return DepartmentName;
                case "ShortName": return ShortName;
                case "Initial": return Initial;
                case "DepartmentManager": return DepartmentManager;
                case "IsHasRegistration": return IsHasRegistration;
                case "IsAllowBackDateRegistration": return IsAllowBackDateRegistration;
                case "IsActive": return IsActive;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem DepartmentID
        {
            get { return new esQueryItem(this, DepartmentMetadata.ColumnNames.DepartmentID, esSystemType.String); }
        }

        public esQueryItem DepartmentName
        {
            get { return new esQueryItem(this, DepartmentMetadata.ColumnNames.DepartmentName, esSystemType.String); }
        }

        public esQueryItem ShortName
        {
            get { return new esQueryItem(this, DepartmentMetadata.ColumnNames.ShortName, esSystemType.String); }
        }

        public esQueryItem Initial
        {
            get { return new esQueryItem(this, DepartmentMetadata.ColumnNames.Initial, esSystemType.String); }
        }

        public esQueryItem DepartmentManager
        {
            get { return new esQueryItem(this, DepartmentMetadata.ColumnNames.DepartmentManager, esSystemType.String); }
        }

        public esQueryItem IsHasRegistration
        {
            get { return new esQueryItem(this, DepartmentMetadata.ColumnNames.IsHasRegistration, esSystemType.Boolean); }
        }

        public esQueryItem IsAllowBackDateRegistration
        {
            get { return new esQueryItem(this, DepartmentMetadata.ColumnNames.IsAllowBackDateRegistration, esSystemType.Boolean); }
        }

        public esQueryItem IsActive
        {
            get { return new esQueryItem(this, DepartmentMetadata.ColumnNames.IsActive, esSystemType.Boolean); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, DepartmentMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, DepartmentMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        #endregion

    }



    [Serializable]
    public partial class DepartmentMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected DepartmentMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.DepartmentID, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DepartmentID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DepartmentName, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DepartmentName;
            c.CharacterMaxLength = 100;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ShortName, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ShortName;
            c.CharacterMaxLength = 35;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Initial, 3, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Initial;
            c.CharacterMaxLength = 3;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DepartmentManager, 4, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DepartmentManager;
            c.CharacterMaxLength = 100;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsHasRegistration, 5, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsHasRegistration;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsAllowBackDateRegistration, 6, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsAllowBackDateRegistration;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsActive, 7, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsActive;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 8, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 9, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 40;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public DepartmentMetadata Meta()
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
            public const string DepartmentID = "DepartmentID";
            public const string DepartmentName = "DepartmentName";
            public const string ShortName = "ShortName";
            public const string Initial = "Initial";
            public const string DepartmentManager = "DepartmentManager";
            public const string IsHasRegistration = "IsHasRegistration";
            public const string IsAllowBackDateRegistration = "IsAllowBackDateRegistration";
            public const string IsActive = "IsActive";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string DepartmentID = "DepartmentID";
            public const string DepartmentName = "DepartmentName";
            public const string ShortName = "ShortName";
            public const string Initial = "Initial";
            public const string DepartmentManager = "DepartmentManager";
            public const string IsHasRegistration = "IsHasRegistration";
            public const string IsAllowBackDateRegistration = "IsAllowBackDateRegistration";
            public const string IsActive = "IsActive";
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
            lock (typeof(DepartmentMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new DepartmentMetadata();
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


                meta.AddTypeMap("DepartmentID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("DepartmentName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ShortName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Initial", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("DepartmentManager", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsHasRegistration", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsAllowBackDateRegistration", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsActive", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));



                meta.Source = "Department";
                meta.Destination = "Department";

                meta.spInsert = "proc_DepartmentInsert";
                meta.spUpdate = "proc_DepartmentUpdate";
                meta.spDelete = "proc_DepartmentDelete";
                meta.spLoadAll = "proc_DepartmentLoadAll";
                meta.spLoadByPrimaryKey = "proc_DepartmentLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private DepartmentMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
