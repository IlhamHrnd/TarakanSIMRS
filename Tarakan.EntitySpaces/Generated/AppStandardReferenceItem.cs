
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 9/23/2024 2:36:20 PM
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
    /// Encapsulates the 'AppStandardReferenceItem' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(AppStandardReferenceItem))]
    [XmlType("AppStandardReferenceItem")]
    public partial class AppStandardReferenceItem : esAppStandardReferenceItem
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new AppStandardReferenceItem();
        }

        #region Static Quick Access Methods
        static public void Delete(string standardReferenceID, string itemID)
        {
            var obj = new AppStandardReferenceItem();
            obj.StandardReferenceID = standardReferenceID;
            obj.ItemID = itemID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string standardReferenceID, string itemID, esSqlAccessType sqlAccessType)
        {
            var obj = new AppStandardReferenceItem();
            obj.StandardReferenceID = standardReferenceID;
            obj.ItemID = itemID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("AppStandardReferenceItemCollection")]
    public partial class AppStandardReferenceItemCollection : esAppStandardReferenceItemCollection, IEnumerable<AppStandardReferenceItem>
    {
        public AppStandardReferenceItem FindByPrimaryKey(string standardReferenceID, string itemID)
        {
            return this.SingleOrDefault(e => e.StandardReferenceID == standardReferenceID && e.ItemID == itemID);
        }



    }



    [Serializable]
    public partial class AppStandardReferenceItemQuery : esAppStandardReferenceItemQuery
    {
        public AppStandardReferenceItemQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public AppStandardReferenceItemQuery(string joinAlias, out AppStandardReferenceItemQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "AppStandardReferenceItemQuery";
        }



        #region Explicit Casts

        public static explicit operator string(AppStandardReferenceItemQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator AppStandardReferenceItemQuery(string query)
        {
            return (AppStandardReferenceItemQuery)SerializeHelper.FromXml(query, typeof(AppStandardReferenceItemQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esAppStandardReferenceItem : esEntity
    {
        public esAppStandardReferenceItem()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string standardReferenceID, string itemID)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(standardReferenceID, itemID);
            else
                return LoadByPrimaryKeyStoredProcedure(standardReferenceID, itemID);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string standardReferenceID, string itemID)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(standardReferenceID, itemID);
            else
                return LoadByPrimaryKeyStoredProcedure(standardReferenceID, itemID);
        }

        private bool LoadByPrimaryKeyDynamic(string standardReferenceID, string itemID)
        {
            AppStandardReferenceItemQuery query = new AppStandardReferenceItemQuery("asriQ");
            query.Where(query.StandardReferenceID == standardReferenceID, query.ItemID == itemID);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string standardReferenceID, string itemID)
        {
            esParameters parms = new esParameters();
            parms.Add("StandardReferenceID", standardReferenceID); parms.Add("ItemID", itemID);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to AppStandardReferenceItem.StandardReferenceID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string StandardReferenceID
        {
            get
            {
                return GetSystemString(AppStandardReferenceItemMetadata.ColumnNames.StandardReferenceID);
            }

            set
            {
                if (SetSystemString(AppStandardReferenceItemMetadata.ColumnNames.StandardReferenceID, value))
                {
                    OnPropertyChanged(AppStandardReferenceItemMetadata.PropertyNames.StandardReferenceID);
                }
            }
        }

        /// <summary>
        /// Maps to AppStandardReferenceItem.ItemID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ItemID
        {
            get
            {
                return GetSystemString(AppStandardReferenceItemMetadata.ColumnNames.ItemID);
            }

            set
            {
                if (SetSystemString(AppStandardReferenceItemMetadata.ColumnNames.ItemID, value))
                {
                    OnPropertyChanged(AppStandardReferenceItemMetadata.PropertyNames.ItemID);
                }
            }
        }

        /// <summary>
        /// Maps to AppStandardReferenceItem.ItemName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ItemName
        {
            get
            {
                return GetSystemString(AppStandardReferenceItemMetadata.ColumnNames.ItemName);
            }

            set
            {
                if (SetSystemString(AppStandardReferenceItemMetadata.ColumnNames.ItemName, value))
                {
                    OnPropertyChanged(AppStandardReferenceItemMetadata.PropertyNames.ItemName);
                }
            }
        }

        /// <summary>
        /// Maps to AppStandardReferenceItem.Note
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Note
        {
            get
            {
                return GetSystemString(AppStandardReferenceItemMetadata.ColumnNames.Note);
            }

            set
            {
                if (SetSystemString(AppStandardReferenceItemMetadata.ColumnNames.Note, value))
                {
                    OnPropertyChanged(AppStandardReferenceItemMetadata.PropertyNames.Note);
                }
            }
        }

        /// <summary>
        /// Maps to AppStandardReferenceItem.IsUsedBySystem
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsUsedBySystem
        {
            get
            {
                return GetSystemBoolean(AppStandardReferenceItemMetadata.ColumnNames.IsUsedBySystem);
            }

            set
            {
                if (SetSystemBoolean(AppStandardReferenceItemMetadata.ColumnNames.IsUsedBySystem, value))
                {
                    OnPropertyChanged(AppStandardReferenceItemMetadata.PropertyNames.IsUsedBySystem);
                }
            }
        }

        /// <summary>
        /// Maps to AppStandardReferenceItem.IsActive
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsActive
        {
            get
            {
                return GetSystemBoolean(AppStandardReferenceItemMetadata.ColumnNames.IsActive);
            }

            set
            {
                if (SetSystemBoolean(AppStandardReferenceItemMetadata.ColumnNames.IsActive, value))
                {
                    OnPropertyChanged(AppStandardReferenceItemMetadata.PropertyNames.IsActive);
                }
            }
        }

        /// <summary>
        /// Maps to AppStandardReferenceItem.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(AppStandardReferenceItemMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(AppStandardReferenceItemMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(AppStandardReferenceItemMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to AppStandardReferenceItem.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(AppStandardReferenceItemMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(AppStandardReferenceItemMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(AppStandardReferenceItemMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to AppStandardReferenceItem.ReferenceID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ReferenceID
        {
            get
            {
                return GetSystemString(AppStandardReferenceItemMetadata.ColumnNames.ReferenceID);
            }

            set
            {
                if (SetSystemString(AppStandardReferenceItemMetadata.ColumnNames.ReferenceID, value))
                {
                    OnPropertyChanged(AppStandardReferenceItemMetadata.PropertyNames.ReferenceID);
                }
            }
        }

        /// <summary>
        /// Maps to AppStandardReferenceItem.coaID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? CoaID
        {
            get
            {
                return GetSystemInt32(AppStandardReferenceItemMetadata.ColumnNames.CoaID);
            }

            set
            {
                if (SetSystemInt32(AppStandardReferenceItemMetadata.ColumnNames.CoaID, value))
                {
                    OnPropertyChanged(AppStandardReferenceItemMetadata.PropertyNames.CoaID);
                }
            }
        }

        /// <summary>
        /// Maps to AppStandardReferenceItem.subledgerID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? SubledgerID
        {
            get
            {
                return GetSystemInt32(AppStandardReferenceItemMetadata.ColumnNames.SubledgerID);
            }

            set
            {
                if (SetSystemInt32(AppStandardReferenceItemMetadata.ColumnNames.SubledgerID, value))
                {
                    OnPropertyChanged(AppStandardReferenceItemMetadata.PropertyNames.SubledgerID);
                }
            }
        }

        /// <summary>
        /// Maps to AppStandardReferenceItem.CustomField
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string CustomField
        {
            get
            {
                return GetSystemString(AppStandardReferenceItemMetadata.ColumnNames.CustomField);
            }

            set
            {
                if (SetSystemString(AppStandardReferenceItemMetadata.ColumnNames.CustomField, value))
                {
                    OnPropertyChanged(AppStandardReferenceItemMetadata.PropertyNames.CustomField);
                }
            }
        }

        /// <summary>
        /// Maps to AppStandardReferenceItem.LineNumber
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? LineNumber
        {
            get
            {
                return GetSystemInt32(AppStandardReferenceItemMetadata.ColumnNames.LineNumber);
            }

            set
            {
                if (SetSystemInt32(AppStandardReferenceItemMetadata.ColumnNames.LineNumber, value))
                {
                    OnPropertyChanged(AppStandardReferenceItemMetadata.PropertyNames.LineNumber);
                }
            }
        }

        /// <summary>
        /// Maps to AppStandardReferenceItem.NumericValue
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? NumericValue
        {
            get
            {
                return GetSystemDecimal(AppStandardReferenceItemMetadata.ColumnNames.NumericValue);
            }

            set
            {
                if (SetSystemDecimal(AppStandardReferenceItemMetadata.ColumnNames.NumericValue, value))
                {
                    OnPropertyChanged(AppStandardReferenceItemMetadata.PropertyNames.NumericValue);
                }
            }
        }

        /// <summary>
        /// Maps to AppStandardReferenceItem.CustomField2
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string CustomField2
        {
            get
            {
                return GetSystemString(AppStandardReferenceItemMetadata.ColumnNames.CustomField2);
            }

            set
            {
                if (SetSystemString(AppStandardReferenceItemMetadata.ColumnNames.CustomField2, value))
                {
                    OnPropertyChanged(AppStandardReferenceItemMetadata.PropertyNames.CustomField2);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return AppStandardReferenceItemMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public AppStandardReferenceItemQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new AppStandardReferenceItemQuery("asriQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(AppStandardReferenceItemQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(AppStandardReferenceItemQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((AppStandardReferenceItemQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private AppStandardReferenceItemQuery query;
    }



    [Serializable]
    abstract public partial class esAppStandardReferenceItemCollection : esEntityCollection<AppStandardReferenceItem>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return AppStandardReferenceItemMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "AppStandardReferenceItemCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public AppStandardReferenceItemQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new AppStandardReferenceItemQuery("asriQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(AppStandardReferenceItemQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new AppStandardReferenceItemQuery("asriQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(AppStandardReferenceItemQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((AppStandardReferenceItemQuery)query);
        }

        #endregion

        private AppStandardReferenceItemQuery query;
    }



    [Serializable]
    abstract public partial class esAppStandardReferenceItemQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return AppStandardReferenceItemMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "StandardReferenceID": return StandardReferenceID;
                case "ItemID": return ItemID;
                case "ItemName": return ItemName;
                case "Note": return Note;
                case "IsUsedBySystem": return IsUsedBySystem;
                case "IsActive": return IsActive;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "ReferenceID": return ReferenceID;
                case "CoaID": return CoaID;
                case "SubledgerID": return SubledgerID;
                case "CustomField": return CustomField;
                case "LineNumber": return LineNumber;
                case "NumericValue": return NumericValue;
                case "CustomField2": return CustomField2;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem StandardReferenceID
        {
            get { return new esQueryItem(this, AppStandardReferenceItemMetadata.ColumnNames.StandardReferenceID, esSystemType.String); }
        }

        public esQueryItem ItemID
        {
            get { return new esQueryItem(this, AppStandardReferenceItemMetadata.ColumnNames.ItemID, esSystemType.String); }
        }

        public esQueryItem ItemName
        {
            get { return new esQueryItem(this, AppStandardReferenceItemMetadata.ColumnNames.ItemName, esSystemType.String); }
        }

        public esQueryItem Note
        {
            get { return new esQueryItem(this, AppStandardReferenceItemMetadata.ColumnNames.Note, esSystemType.String); }
        }

        public esQueryItem IsUsedBySystem
        {
            get { return new esQueryItem(this, AppStandardReferenceItemMetadata.ColumnNames.IsUsedBySystem, esSystemType.Boolean); }
        }

        public esQueryItem IsActive
        {
            get { return new esQueryItem(this, AppStandardReferenceItemMetadata.ColumnNames.IsActive, esSystemType.Boolean); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, AppStandardReferenceItemMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, AppStandardReferenceItemMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem ReferenceID
        {
            get { return new esQueryItem(this, AppStandardReferenceItemMetadata.ColumnNames.ReferenceID, esSystemType.String); }
        }

        public esQueryItem CoaID
        {
            get { return new esQueryItem(this, AppStandardReferenceItemMetadata.ColumnNames.CoaID, esSystemType.Int32); }
        }

        public esQueryItem SubledgerID
        {
            get { return new esQueryItem(this, AppStandardReferenceItemMetadata.ColumnNames.SubledgerID, esSystemType.Int32); }
        }

        public esQueryItem CustomField
        {
            get { return new esQueryItem(this, AppStandardReferenceItemMetadata.ColumnNames.CustomField, esSystemType.String); }
        }

        public esQueryItem LineNumber
        {
            get { return new esQueryItem(this, AppStandardReferenceItemMetadata.ColumnNames.LineNumber, esSystemType.Int32); }
        }

        public esQueryItem NumericValue
        {
            get { return new esQueryItem(this, AppStandardReferenceItemMetadata.ColumnNames.NumericValue, esSystemType.Decimal); }
        }

        public esQueryItem CustomField2
        {
            get { return new esQueryItem(this, AppStandardReferenceItemMetadata.ColumnNames.CustomField2, esSystemType.String); }
        }

        #endregion

    }



    [Serializable]
    public partial class AppStandardReferenceItemMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected AppStandardReferenceItemMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.StandardReferenceID, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.StandardReferenceID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 30;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ItemID, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ItemID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 50;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ItemName, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ItemName;
            c.CharacterMaxLength = 200;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Note, 3, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Note;
            c.CharacterMaxLength = 2000;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsUsedBySystem, 4, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsUsedBySystem;
            c.HasDefault = true;
            c.Default = @"((1))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsActive, 5, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsActive;
            c.HasDefault = true;
            c.Default = @"((0))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 6, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 7, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 40;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ReferenceID, 8, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ReferenceID;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CoaID, 9, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.CoaID;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SubledgerID, 10, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.SubledgerID;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CustomField, 11, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.CustomField;
            c.CharacterMaxLength = 2000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LineNumber, 12, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.LineNumber;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.NumericValue, 13, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.NumericValue;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CustomField2, 14, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.CustomField2;
            c.CharacterMaxLength = 2000;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public AppStandardReferenceItemMetadata Meta()
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
            public const string StandardReferenceID = "StandardReferenceID";
            public const string ItemID = "ItemID";
            public const string ItemName = "ItemName";
            public const string Note = "Note";
            public const string IsUsedBySystem = "IsUsedBySystem";
            public const string IsActive = "IsActive";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string ReferenceID = "ReferenceID";
            public const string CoaID = "coaID";
            public const string SubledgerID = "subledgerID";
            public const string CustomField = "CustomField";
            public const string LineNumber = "LineNumber";
            public const string NumericValue = "NumericValue";
            public const string CustomField2 = "CustomField2";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string StandardReferenceID = "StandardReferenceID";
            public const string ItemID = "ItemID";
            public const string ItemName = "ItemName";
            public const string Note = "Note";
            public const string IsUsedBySystem = "IsUsedBySystem";
            public const string IsActive = "IsActive";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string ReferenceID = "ReferenceID";
            public const string CoaID = "CoaID";
            public const string SubledgerID = "SubledgerID";
            public const string CustomField = "CustomField";
            public const string LineNumber = "LineNumber";
            public const string NumericValue = "NumericValue";
            public const string CustomField2 = "CustomField2";
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
            lock (typeof(AppStandardReferenceItemMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new AppStandardReferenceItemMetadata();
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


                meta.AddTypeMap("StandardReferenceID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ItemID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ItemName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Note", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsUsedBySystem", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsActive", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ReferenceID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CoaID", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("SubledgerID", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("CustomField", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LineNumber", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("NumericValue", new esTypeMap("decimal", "System.Decimal"));
                meta.AddTypeMap("CustomField2", new esTypeMap("varchar", "System.String"));



                meta.Source = "AppStandardReferenceItem";
                meta.Destination = "AppStandardReferenceItem";

                meta.spInsert = "proc_AppStandardReferenceItemInsert";
                meta.spUpdate = "proc_AppStandardReferenceItemUpdate";
                meta.spDelete = "proc_AppStandardReferenceItemDelete";
                meta.spLoadAll = "proc_AppStandardReferenceItemLoadAll";
                meta.spLoadByPrimaryKey = "proc_AppStandardReferenceItemLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private AppStandardReferenceItemMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
