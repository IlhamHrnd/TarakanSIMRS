
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 3/17/2025 1:56:59 PM
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
    /// Encapsulates the 'Embalace' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(Embalace))]
    [XmlType("Embalace")]
    public partial class Embalace : esEmbalace
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new Embalace();
        }

        #region Static Quick Access Methods
        static public void Delete(string embalaceID)
        {
            var obj = new Embalace();
            obj.EmbalaceID = embalaceID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string embalaceID, esSqlAccessType sqlAccessType)
        {
            var obj = new Embalace();
            obj.EmbalaceID = embalaceID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("EmbalaceCollection")]
    public partial class EmbalaceCollection : esEmbalaceCollection, IEnumerable<Embalace>
    {
        public Embalace FindByPrimaryKey(string embalaceID)
        {
            return this.SingleOrDefault(e => e.EmbalaceID == embalaceID);
        }



    }



    [Serializable]
    public partial class EmbalaceQuery : esEmbalaceQuery
    {
        public EmbalaceQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public EmbalaceQuery(string joinAlias, out EmbalaceQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "EmbalaceQuery";
        }



        #region Explicit Casts

        public static explicit operator string(EmbalaceQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator EmbalaceQuery(string query)
        {
            return (EmbalaceQuery)SerializeHelper.FromXml(query, typeof(EmbalaceQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esEmbalace : esEntity
    {
        public esEmbalace()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string embalaceID)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(embalaceID);
            else
                return LoadByPrimaryKeyStoredProcedure(embalaceID);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string embalaceID)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(embalaceID);
            else
                return LoadByPrimaryKeyStoredProcedure(embalaceID);
        }

        private bool LoadByPrimaryKeyDynamic(string embalaceID)
        {
            EmbalaceQuery query = new EmbalaceQuery("eQ");
            query.Where(query.EmbalaceID == embalaceID);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string embalaceID)
        {
            esParameters parms = new esParameters();
            parms.Add("EmbalaceID", embalaceID);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to Embalace.EmbalaceID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string EmbalaceID
        {
            get
            {
                return GetSystemString(EmbalaceMetadata.ColumnNames.EmbalaceID);
            }

            set
            {
                if (SetSystemString(EmbalaceMetadata.ColumnNames.EmbalaceID, value))
                {
                    OnPropertyChanged(EmbalaceMetadata.PropertyNames.EmbalaceID);
                }
            }
        }

        /// <summary>
        /// Maps to Embalace.EmbalaceName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string EmbalaceName
        {
            get
            {
                return GetSystemString(EmbalaceMetadata.ColumnNames.EmbalaceName);
            }

            set
            {
                if (SetSystemString(EmbalaceMetadata.ColumnNames.EmbalaceName, value))
                {
                    OnPropertyChanged(EmbalaceMetadata.PropertyNames.EmbalaceName);
                }
            }
        }

        /// <summary>
        /// Maps to Embalace.EmbalaceLabel
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string EmbalaceLabel
        {
            get
            {
                return GetSystemString(EmbalaceMetadata.ColumnNames.EmbalaceLabel);
            }

            set
            {
                if (SetSystemString(EmbalaceMetadata.ColumnNames.EmbalaceLabel, value))
                {
                    OnPropertyChanged(EmbalaceMetadata.PropertyNames.EmbalaceLabel);
                }
            }
        }

        /// <summary>
        /// Maps to Embalace.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(EmbalaceMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(EmbalaceMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(EmbalaceMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to Embalace.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(EmbalaceMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(EmbalaceMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(EmbalaceMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to Embalace.EmbalaceFeeAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? EmbalaceFeeAmount
        {
            get
            {
                return GetSystemDecimal(EmbalaceMetadata.ColumnNames.EmbalaceFeeAmount);
            }

            set
            {
                if (SetSystemDecimal(EmbalaceMetadata.ColumnNames.EmbalaceFeeAmount, value))
                {
                    OnPropertyChanged(EmbalaceMetadata.PropertyNames.EmbalaceFeeAmount);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return EmbalaceMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public EmbalaceQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new EmbalaceQuery("eQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(EmbalaceQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(EmbalaceQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((EmbalaceQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private EmbalaceQuery query;
    }



    [Serializable]
    abstract public partial class esEmbalaceCollection : esEntityCollection<Embalace>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return EmbalaceMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "EmbalaceCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public EmbalaceQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new EmbalaceQuery("eQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(EmbalaceQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new EmbalaceQuery("eQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(EmbalaceQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((EmbalaceQuery)query);
        }

        #endregion

        private EmbalaceQuery query;
    }



    [Serializable]
    abstract public partial class esEmbalaceQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return EmbalaceMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "EmbalaceID": return EmbalaceID;
                case "EmbalaceName": return EmbalaceName;
                case "EmbalaceLabel": return EmbalaceLabel;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "EmbalaceFeeAmount": return EmbalaceFeeAmount;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem EmbalaceID
        {
            get { return new esQueryItem(this, EmbalaceMetadata.ColumnNames.EmbalaceID, esSystemType.String); }
        }

        public esQueryItem EmbalaceName
        {
            get { return new esQueryItem(this, EmbalaceMetadata.ColumnNames.EmbalaceName, esSystemType.String); }
        }

        public esQueryItem EmbalaceLabel
        {
            get { return new esQueryItem(this, EmbalaceMetadata.ColumnNames.EmbalaceLabel, esSystemType.String); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, EmbalaceMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, EmbalaceMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem EmbalaceFeeAmount
        {
            get { return new esQueryItem(this, EmbalaceMetadata.ColumnNames.EmbalaceFeeAmount, esSystemType.Decimal); }
        }

        #endregion

    }



    [Serializable]
    public partial class EmbalaceMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected EmbalaceMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.EmbalaceID, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.EmbalaceID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.EmbalaceName, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.EmbalaceName;
            c.CharacterMaxLength = 50;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.EmbalaceLabel, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.EmbalaceLabel;
            c.CharacterMaxLength = 50;
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

            c = new esColumnMetadata(ColumnNames.EmbalaceFeeAmount, 5, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.EmbalaceFeeAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public EmbalaceMetadata Meta()
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
            public const string EmbalaceID = "EmbalaceID";
            public const string EmbalaceName = "EmbalaceName";
            public const string EmbalaceLabel = "EmbalaceLabel";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string EmbalaceFeeAmount = "EmbalaceFeeAmount";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string EmbalaceID = "EmbalaceID";
            public const string EmbalaceName = "EmbalaceName";
            public const string EmbalaceLabel = "EmbalaceLabel";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string EmbalaceFeeAmount = "EmbalaceFeeAmount";
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
            lock (typeof(EmbalaceMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new EmbalaceMetadata();
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


                meta.AddTypeMap("EmbalaceID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("EmbalaceName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("EmbalaceLabel", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("EmbalaceFeeAmount", new esTypeMap("numeric", "System.Decimal"));



                meta.Source = "Embalace";
                meta.Destination = "Embalace";

                meta.spInsert = "proc_EmbalaceInsert";
                meta.spUpdate = "proc_EmbalaceUpdate";
                meta.spDelete = "proc_EmbalaceDelete";
                meta.spLoadAll = "proc_EmbalaceLoadAll";
                meta.spLoadByPrimaryKey = "proc_EmbalaceLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private EmbalaceMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
