
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 2/24/2025 10:51:26 AM
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
    /// Encapsulates the 'Pathway' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(Pathway))]
    [XmlType("Pathway")]
    public partial class Pathway : esPathway
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new Pathway();
        }

        #region Static Quick Access Methods
        static public void Delete(string pathwayID)
        {
            var obj = new Pathway();
            obj.PathwayID = pathwayID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string pathwayID, esSqlAccessType sqlAccessType)
        {
            var obj = new Pathway();
            obj.PathwayID = pathwayID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("PathwayCollection")]
    public partial class PathwayCollection : esPathwayCollection, IEnumerable<Pathway>
    {
        public Pathway FindByPrimaryKey(string pathwayID)
        {
            return this.SingleOrDefault(e => e.PathwayID == pathwayID);
        }



    }



    [Serializable]
    public partial class PathwayQuery : esPathwayQuery
    {
        public PathwayQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public PathwayQuery(string joinAlias, out PathwayQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "PathwayQuery";
        }



        #region Explicit Casts

        public static explicit operator string(PathwayQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator PathwayQuery(string query)
        {
            return (PathwayQuery)SerializeHelper.FromXml(query, typeof(PathwayQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esPathway : esEntity
    {
        public esPathway()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string pathwayID)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(pathwayID);
            else
                return LoadByPrimaryKeyStoredProcedure(pathwayID);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string pathwayID)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(pathwayID);
            else
                return LoadByPrimaryKeyStoredProcedure(pathwayID);
        }

        private bool LoadByPrimaryKeyDynamic(string pathwayID)
        {
            PathwayQuery query = new PathwayQuery("pQ");
            query.Where(query.PathwayID == pathwayID);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string pathwayID)
        {
            esParameters parms = new esParameters();
            parms.Add("PathwayID", pathwayID);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to Pathway.PathwayID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PathwayID
        {
            get
            {
                return GetSystemString(PathwayMetadata.ColumnNames.PathwayID);
            }

            set
            {
                if (SetSystemString(PathwayMetadata.ColumnNames.PathwayID, value))
                {
                    OnPropertyChanged(PathwayMetadata.PropertyNames.PathwayID);
                }
            }
        }

        /// <summary>
        /// Maps to Pathway.PathwayName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PathwayName
        {
            get
            {
                return GetSystemString(PathwayMetadata.ColumnNames.PathwayName);
            }

            set
            {
                if (SetSystemString(PathwayMetadata.ColumnNames.PathwayName, value))
                {
                    OnPropertyChanged(PathwayMetadata.PropertyNames.PathwayName);
                }
            }
        }

        /// <summary>
        /// Maps to Pathway.StartingDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? StartingDate
        {
            get
            {
                return GetSystemDateTime(PathwayMetadata.ColumnNames.StartingDate);
            }

            set
            {
                if (SetSystemDateTime(PathwayMetadata.ColumnNames.StartingDate, value))
                {
                    OnPropertyChanged(PathwayMetadata.PropertyNames.StartingDate);
                }
            }
        }

        /// <summary>
        /// Maps to Pathway.CoverageValue1
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? CoverageValue1
        {
            get
            {
                return GetSystemDecimal(PathwayMetadata.ColumnNames.CoverageValue1);
            }

            set
            {
                if (SetSystemDecimal(PathwayMetadata.ColumnNames.CoverageValue1, value))
                {
                    OnPropertyChanged(PathwayMetadata.PropertyNames.CoverageValue1);
                }
            }
        }

        /// <summary>
        /// Maps to Pathway.CoverageValue2
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? CoverageValue2
        {
            get
            {
                return GetSystemDecimal(PathwayMetadata.ColumnNames.CoverageValue2);
            }

            set
            {
                if (SetSystemDecimal(PathwayMetadata.ColumnNames.CoverageValue2, value))
                {
                    OnPropertyChanged(PathwayMetadata.PropertyNames.CoverageValue2);
                }
            }
        }

        /// <summary>
        /// Maps to Pathway.CoverageValue3
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? CoverageValue3
        {
            get
            {
                return GetSystemDecimal(PathwayMetadata.ColumnNames.CoverageValue3);
            }

            set
            {
                if (SetSystemDecimal(PathwayMetadata.ColumnNames.CoverageValue3, value))
                {
                    OnPropertyChanged(PathwayMetadata.PropertyNames.CoverageValue3);
                }
            }
        }

        /// <summary>
        /// Maps to Pathway.ALOS
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? Alos
        {
            get
            {
                return GetSystemInt32(PathwayMetadata.ColumnNames.Alos);
            }

            set
            {
                if (SetSystemInt32(PathwayMetadata.ColumnNames.Alos, value))
                {
                    OnPropertyChanged(PathwayMetadata.PropertyNames.Alos);
                }
            }
        }

        /// <summary>
        /// Maps to Pathway.Notes
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Notes
        {
            get
            {
                return GetSystemString(PathwayMetadata.ColumnNames.Notes);
            }

            set
            {
                if (SetSystemString(PathwayMetadata.ColumnNames.Notes, value))
                {
                    OnPropertyChanged(PathwayMetadata.PropertyNames.Notes);
                }
            }
        }

        /// <summary>
        /// Maps to Pathway.IsActive
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsActive
        {
            get
            {
                return GetSystemBoolean(PathwayMetadata.ColumnNames.IsActive);
            }

            set
            {
                if (SetSystemBoolean(PathwayMetadata.ColumnNames.IsActive, value))
                {
                    OnPropertyChanged(PathwayMetadata.PropertyNames.IsActive);
                }
            }
        }

        /// <summary>
        /// Maps to Pathway.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(PathwayMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(PathwayMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(PathwayMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to Pathway.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(PathwayMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(PathwayMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(PathwayMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return PathwayMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public PathwayQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new PathwayQuery("pQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(PathwayQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(PathwayQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((PathwayQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private PathwayQuery query;
    }



    [Serializable]
    abstract public partial class esPathwayCollection : esEntityCollection<Pathway>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return PathwayMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "PathwayCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public PathwayQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new PathwayQuery("pQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(PathwayQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new PathwayQuery("pQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(PathwayQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((PathwayQuery)query);
        }

        #endregion

        private PathwayQuery query;
    }



    [Serializable]
    abstract public partial class esPathwayQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return PathwayMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "PathwayID": return PathwayID;
                case "PathwayName": return PathwayName;
                case "StartingDate": return StartingDate;
                case "CoverageValue1": return CoverageValue1;
                case "CoverageValue2": return CoverageValue2;
                case "CoverageValue3": return CoverageValue3;
                case "Alos": return Alos;
                case "Notes": return Notes;
                case "IsActive": return IsActive;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem PathwayID
        {
            get { return new esQueryItem(this, PathwayMetadata.ColumnNames.PathwayID, esSystemType.String); }
        }

        public esQueryItem PathwayName
        {
            get { return new esQueryItem(this, PathwayMetadata.ColumnNames.PathwayName, esSystemType.String); }
        }

        public esQueryItem StartingDate
        {
            get { return new esQueryItem(this, PathwayMetadata.ColumnNames.StartingDate, esSystemType.DateTime); }
        }

        public esQueryItem CoverageValue1
        {
            get { return new esQueryItem(this, PathwayMetadata.ColumnNames.CoverageValue1, esSystemType.Decimal); }
        }

        public esQueryItem CoverageValue2
        {
            get { return new esQueryItem(this, PathwayMetadata.ColumnNames.CoverageValue2, esSystemType.Decimal); }
        }

        public esQueryItem CoverageValue3
        {
            get { return new esQueryItem(this, PathwayMetadata.ColumnNames.CoverageValue3, esSystemType.Decimal); }
        }

        public esQueryItem Alos
        {
            get { return new esQueryItem(this, PathwayMetadata.ColumnNames.Alos, esSystemType.Int32); }
        }

        public esQueryItem Notes
        {
            get { return new esQueryItem(this, PathwayMetadata.ColumnNames.Notes, esSystemType.String); }
        }

        public esQueryItem IsActive
        {
            get { return new esQueryItem(this, PathwayMetadata.ColumnNames.IsActive, esSystemType.Boolean); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, PathwayMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, PathwayMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        #endregion

    }



    [Serializable]
    public partial class PathwayMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected PathwayMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.PathwayID, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PathwayID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 50;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PathwayName, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PathwayName;
            c.CharacterMaxLength = 2147483647;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.StartingDate, 2, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.StartingDate;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CoverageValue1, 3, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.CoverageValue1;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CoverageValue2, 4, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.CoverageValue2;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CoverageValue3, 5, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.CoverageValue3;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Alos, 6, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.Alos;
            c.NumericPrecision = 10;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Notes, 7, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Notes;
            c.CharacterMaxLength = 2147483647;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsActive, 8, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsActive;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 9, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 10, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public PathwayMetadata Meta()
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
            public const string PathwayID = "PathwayID";
            public const string PathwayName = "PathwayName";
            public const string StartingDate = "StartingDate";
            public const string CoverageValue1 = "CoverageValue1";
            public const string CoverageValue2 = "CoverageValue2";
            public const string CoverageValue3 = "CoverageValue3";
            public const string Alos = "ALOS";
            public const string Notes = "Notes";
            public const string IsActive = "IsActive";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string PathwayID = "PathwayID";
            public const string PathwayName = "PathwayName";
            public const string StartingDate = "StartingDate";
            public const string CoverageValue1 = "CoverageValue1";
            public const string CoverageValue2 = "CoverageValue2";
            public const string CoverageValue3 = "CoverageValue3";
            public const string Alos = "Alos";
            public const string Notes = "Notes";
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
            lock (typeof(PathwayMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new PathwayMetadata();
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


                meta.AddTypeMap("PathwayID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PathwayName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("StartingDate", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("CoverageValue1", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("CoverageValue2", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("CoverageValue3", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("Alos", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("Notes", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsActive", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));



                meta.Source = "Pathway";
                meta.Destination = "Pathway";

                meta.spInsert = "proc_PathwayInsert";
                meta.spUpdate = "proc_PathwayUpdate";
                meta.spDelete = "proc_PathwayDelete";
                meta.spLoadAll = "proc_PathwayLoadAll";
                meta.spLoadByPrimaryKey = "proc_PathwayLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private PathwayMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
