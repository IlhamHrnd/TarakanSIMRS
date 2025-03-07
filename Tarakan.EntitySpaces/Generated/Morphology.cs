
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 2/24/2025 1:51:13 PM
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
    /// Encapsulates the 'Morphology' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(Morphology))]
    [XmlType("Morphology")]
    public partial class Morphology : esMorphology
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new Morphology();
        }

        #region Static Quick Access Methods
        static public void Delete(string morphologyID)
        {
            var obj = new Morphology();
            obj.MorphologyID = morphologyID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string morphologyID, esSqlAccessType sqlAccessType)
        {
            var obj = new Morphology();
            obj.MorphologyID = morphologyID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("MorphologyCollection")]
    public partial class MorphologyCollection : esMorphologyCollection, IEnumerable<Morphology>
    {
        public Morphology FindByPrimaryKey(string morphologyID)
        {
            return this.SingleOrDefault(e => e.MorphologyID == morphologyID);
        }



    }



    [Serializable]
    public partial class MorphologyQuery : esMorphologyQuery
    {
        public MorphologyQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public MorphologyQuery(string joinAlias, out MorphologyQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "MorphologyQuery";
        }



        #region Explicit Casts

        public static explicit operator string(MorphologyQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator MorphologyQuery(string query)
        {
            return (MorphologyQuery)SerializeHelper.FromXml(query, typeof(MorphologyQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esMorphology : esEntity
    {
        public esMorphology()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string morphologyID)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(morphologyID);
            else
                return LoadByPrimaryKeyStoredProcedure(morphologyID);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string morphologyID)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(morphologyID);
            else
                return LoadByPrimaryKeyStoredProcedure(morphologyID);
        }

        private bool LoadByPrimaryKeyDynamic(string morphologyID)
        {
            MorphologyQuery query = new MorphologyQuery("mQ");
            query.Where(query.MorphologyID == morphologyID);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string morphologyID)
        {
            esParameters parms = new esParameters();
            parms.Add("MorphologyID", morphologyID);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to Morphology.MorphologyID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string MorphologyID
        {
            get
            {
                return GetSystemString(MorphologyMetadata.ColumnNames.MorphologyID);
            }

            set
            {
                if (SetSystemString(MorphologyMetadata.ColumnNames.MorphologyID, value))
                {
                    OnPropertyChanged(MorphologyMetadata.PropertyNames.MorphologyID);
                }
            }
        }

        /// <summary>
        /// Maps to Morphology.DiagnoseID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DiagnoseID
        {
            get
            {
                return GetSystemString(MorphologyMetadata.ColumnNames.DiagnoseID);
            }

            set
            {
                if (SetSystemString(MorphologyMetadata.ColumnNames.DiagnoseID, value))
                {
                    OnPropertyChanged(MorphologyMetadata.PropertyNames.DiagnoseID);
                }
            }
        }

        /// <summary>
        /// Maps to Morphology.MorphologyName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string MorphologyName
        {
            get
            {
                return GetSystemString(MorphologyMetadata.ColumnNames.MorphologyName);
            }

            set
            {
                if (SetSystemString(MorphologyMetadata.ColumnNames.MorphologyName, value))
                {
                    OnPropertyChanged(MorphologyMetadata.PropertyNames.MorphologyName);
                }
            }
        }

        /// <summary>
        /// Maps to Morphology.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(MorphologyMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(MorphologyMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(MorphologyMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to Morphology.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(MorphologyMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(MorphologyMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(MorphologyMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return MorphologyMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public MorphologyQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new MorphologyQuery("mQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(MorphologyQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(MorphologyQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((MorphologyQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private MorphologyQuery query;
    }



    [Serializable]
    abstract public partial class esMorphologyCollection : esEntityCollection<Morphology>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return MorphologyMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "MorphologyCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public MorphologyQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new MorphologyQuery("mQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(MorphologyQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new MorphologyQuery("mQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(MorphologyQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((MorphologyQuery)query);
        }

        #endregion

        private MorphologyQuery query;
    }



    [Serializable]
    abstract public partial class esMorphologyQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return MorphologyMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "MorphologyID": return MorphologyID;
                case "DiagnoseID": return DiagnoseID;
                case "MorphologyName": return MorphologyName;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem MorphologyID
        {
            get { return new esQueryItem(this, MorphologyMetadata.ColumnNames.MorphologyID, esSystemType.String); }
        }

        public esQueryItem DiagnoseID
        {
            get { return new esQueryItem(this, MorphologyMetadata.ColumnNames.DiagnoseID, esSystemType.String); }
        }

        public esQueryItem MorphologyName
        {
            get { return new esQueryItem(this, MorphologyMetadata.ColumnNames.MorphologyName, esSystemType.String); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, MorphologyMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, MorphologyMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        #endregion

    }



    [Serializable]
    public partial class MorphologyMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected MorphologyMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.MorphologyID, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.MorphologyID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DiagnoseID, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DiagnoseID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.MorphologyName, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.MorphologyName;
            c.CharacterMaxLength = 500;
            c.HasDefault = true;
            c.Default = @"('')";
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

        static public MorphologyMetadata Meta()
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
            public const string MorphologyID = "MorphologyID";
            public const string DiagnoseID = "DiagnoseID";
            public const string MorphologyName = "MorphologyName";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string MorphologyID = "MorphologyID";
            public const string DiagnoseID = "DiagnoseID";
            public const string MorphologyName = "MorphologyName";
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
            lock (typeof(MorphologyMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new MorphologyMetadata();
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


                meta.AddTypeMap("MorphologyID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("DiagnoseID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("MorphologyName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));



                meta.Source = "Morphology";
                meta.Destination = "Morphology";

                meta.spInsert = "proc_MorphologyInsert";
                meta.spUpdate = "proc_MorphologyUpdate";
                meta.spDelete = "proc_MorphologyDelete";
                meta.spLoadAll = "proc_MorphologyLoadAll";
                meta.spLoadByPrimaryKey = "proc_MorphologyLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private MorphologyMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
