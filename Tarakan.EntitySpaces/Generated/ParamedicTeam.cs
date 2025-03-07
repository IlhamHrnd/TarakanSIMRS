
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 2/11/2025 4:58:16 PM
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
    /// Encapsulates the 'ParamedicTeam' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(ParamedicTeam))]
    [XmlType("ParamedicTeam")]
    public partial class ParamedicTeam : esParamedicTeam
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new ParamedicTeam();
        }

        #region Static Quick Access Methods
        static public void Delete(string paramedicID, string registrationNo, DateTime startDate)
        {
            var obj = new ParamedicTeam();
            obj.ParamedicID = paramedicID;
            obj.RegistrationNo = registrationNo;
            obj.StartDate = startDate;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string paramedicID, string registrationNo, DateTime startDate, esSqlAccessType sqlAccessType)
        {
            var obj = new ParamedicTeam();
            obj.ParamedicID = paramedicID;
            obj.RegistrationNo = registrationNo;
            obj.StartDate = startDate;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("ParamedicTeamCollection")]
    public partial class ParamedicTeamCollection : esParamedicTeamCollection, IEnumerable<ParamedicTeam>
    {
        public ParamedicTeam FindByPrimaryKey(string paramedicID, string registrationNo, DateTime startDate)
        {
            return this.SingleOrDefault(e => e.ParamedicID == paramedicID && e.RegistrationNo == registrationNo && e.StartDate == startDate);
        }



    }



    [Serializable]
    public partial class ParamedicTeamQuery : esParamedicTeamQuery
    {
        public ParamedicTeamQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public ParamedicTeamQuery(string joinAlias, out ParamedicTeamQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "ParamedicTeamQuery";
        }



        #region Explicit Casts

        public static explicit operator string(ParamedicTeamQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator ParamedicTeamQuery(string query)
        {
            return (ParamedicTeamQuery)SerializeHelper.FromXml(query, typeof(ParamedicTeamQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esParamedicTeam : esEntity
    {
        public esParamedicTeam()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string paramedicID, string registrationNo, DateTime startDate)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(paramedicID, registrationNo, startDate);
            else
                return LoadByPrimaryKeyStoredProcedure(paramedicID, registrationNo, startDate);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string paramedicID, string registrationNo, DateTime startDate)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(paramedicID, registrationNo, startDate);
            else
                return LoadByPrimaryKeyStoredProcedure(paramedicID, registrationNo, startDate);
        }

        private bool LoadByPrimaryKeyDynamic(string paramedicID, string registrationNo, DateTime startDate)
        {
            ParamedicTeamQuery query = new ParamedicTeamQuery("ptQ");
            query.Where(query.ParamedicID == paramedicID, query.RegistrationNo == registrationNo, query.StartDate == startDate);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string paramedicID, string registrationNo, DateTime startDate)
        {
            esParameters parms = new esParameters();
            parms.Add("ParamedicID", paramedicID); parms.Add("RegistrationNo", registrationNo); parms.Add("StartDate", startDate);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to ParamedicTeam.RegistrationNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RegistrationNo
        {
            get
            {
                return GetSystemString(ParamedicTeamMetadata.ColumnNames.RegistrationNo);
            }

            set
            {
                if (SetSystemString(ParamedicTeamMetadata.ColumnNames.RegistrationNo, value))
                {
                    OnPropertyChanged(ParamedicTeamMetadata.PropertyNames.RegistrationNo);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicTeam.ParamedicID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParamedicID
        {
            get
            {
                return GetSystemString(ParamedicTeamMetadata.ColumnNames.ParamedicID);
            }

            set
            {
                if (SetSystemString(ParamedicTeamMetadata.ColumnNames.ParamedicID, value))
                {
                    OnPropertyChanged(ParamedicTeamMetadata.PropertyNames.ParamedicID);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicTeam.StartDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? StartDate
        {
            get
            {
                return GetSystemDateTime(ParamedicTeamMetadata.ColumnNames.StartDate);
            }

            set
            {
                if (SetSystemDateTime(ParamedicTeamMetadata.ColumnNames.StartDate, value))
                {
                    OnPropertyChanged(ParamedicTeamMetadata.PropertyNames.StartDate);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicTeam.SRParamedicTeamStatus
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRParamedicTeamStatus
        {
            get
            {
                return GetSystemString(ParamedicTeamMetadata.ColumnNames.SRParamedicTeamStatus);
            }

            set
            {
                if (SetSystemString(ParamedicTeamMetadata.ColumnNames.SRParamedicTeamStatus, value))
                {
                    OnPropertyChanged(ParamedicTeamMetadata.PropertyNames.SRParamedicTeamStatus);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicTeam.EndDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? EndDate
        {
            get
            {
                return GetSystemDateTime(ParamedicTeamMetadata.ColumnNames.EndDate);
            }

            set
            {
                if (SetSystemDateTime(ParamedicTeamMetadata.ColumnNames.EndDate, value))
                {
                    OnPropertyChanged(ParamedicTeamMetadata.PropertyNames.EndDate);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicTeam.Notes
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Notes
        {
            get
            {
                return GetSystemString(ParamedicTeamMetadata.ColumnNames.Notes);
            }

            set
            {
                if (SetSystemString(ParamedicTeamMetadata.ColumnNames.Notes, value))
                {
                    OnPropertyChanged(ParamedicTeamMetadata.PropertyNames.Notes);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicTeam.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(ParamedicTeamMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(ParamedicTeamMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(ParamedicTeamMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicTeam.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(ParamedicTeamMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(ParamedicTeamMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(ParamedicTeamMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicTeam.SourceType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public char? SourceType
        {
            get
            {
                return GetSystemChar(ParamedicTeamMetadata.ColumnNames.SourceType);
            }

            set
            {
                if (SetSystemChar(ParamedicTeamMetadata.ColumnNames.SourceType, value))
                {
                    OnPropertyChanged(ParamedicTeamMetadata.PropertyNames.SourceType);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return ParamedicTeamMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public ParamedicTeamQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new ParamedicTeamQuery("ptQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(ParamedicTeamQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(ParamedicTeamQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((ParamedicTeamQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private ParamedicTeamQuery query;
    }



    [Serializable]
    abstract public partial class esParamedicTeamCollection : esEntityCollection<ParamedicTeam>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return ParamedicTeamMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "ParamedicTeamCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public ParamedicTeamQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new ParamedicTeamQuery("ptQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(ParamedicTeamQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new ParamedicTeamQuery("ptQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(ParamedicTeamQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((ParamedicTeamQuery)query);
        }

        #endregion

        private ParamedicTeamQuery query;
    }



    [Serializable]
    abstract public partial class esParamedicTeamQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return ParamedicTeamMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "RegistrationNo": return RegistrationNo;
                case "ParamedicID": return ParamedicID;
                case "StartDate": return StartDate;
                case "SRParamedicTeamStatus": return SRParamedicTeamStatus;
                case "EndDate": return EndDate;
                case "Notes": return Notes;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "SourceType": return SourceType;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem RegistrationNo
        {
            get { return new esQueryItem(this, ParamedicTeamMetadata.ColumnNames.RegistrationNo, esSystemType.String); }
        }

        public esQueryItem ParamedicID
        {
            get { return new esQueryItem(this, ParamedicTeamMetadata.ColumnNames.ParamedicID, esSystemType.String); }
        }

        public esQueryItem StartDate
        {
            get { return new esQueryItem(this, ParamedicTeamMetadata.ColumnNames.StartDate, esSystemType.DateTime); }
        }

        public esQueryItem SRParamedicTeamStatus
        {
            get { return new esQueryItem(this, ParamedicTeamMetadata.ColumnNames.SRParamedicTeamStatus, esSystemType.String); }
        }

        public esQueryItem EndDate
        {
            get { return new esQueryItem(this, ParamedicTeamMetadata.ColumnNames.EndDate, esSystemType.DateTime); }
        }

        public esQueryItem Notes
        {
            get { return new esQueryItem(this, ParamedicTeamMetadata.ColumnNames.Notes, esSystemType.String); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, ParamedicTeamMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, ParamedicTeamMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem SourceType
        {
            get { return new esQueryItem(this, ParamedicTeamMetadata.ColumnNames.SourceType, esSystemType.Char); }
        }

        #endregion

    }



    [Serializable]
    public partial class ParamedicTeamMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected ParamedicTeamMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.RegistrationNo, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RegistrationNo;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 20;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParamedicID, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParamedicID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 10;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.StartDate, 2, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.StartDate;
            c.IsInPrimaryKey = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRParamedicTeamStatus, 3, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRParamedicTeamStatus;
            c.CharacterMaxLength = 20;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.EndDate, 4, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.EndDate;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Notes, 5, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Notes;
            c.CharacterMaxLength = 500;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 6, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 7, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SourceType, 8, typeof(char), esSystemType.Char);
            c.PropertyName = PropertyNames.SourceType;
            c.CharacterMaxLength = 1;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public ParamedicTeamMetadata Meta()
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
            public const string ParamedicID = "ParamedicID";
            public const string StartDate = "StartDate";
            public const string SRParamedicTeamStatus = "SRParamedicTeamStatus";
            public const string EndDate = "EndDate";
            public const string Notes = "Notes";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string SourceType = "SourceType";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string RegistrationNo = "RegistrationNo";
            public const string ParamedicID = "ParamedicID";
            public const string StartDate = "StartDate";
            public const string SRParamedicTeamStatus = "SRParamedicTeamStatus";
            public const string EndDate = "EndDate";
            public const string Notes = "Notes";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string SourceType = "SourceType";
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
            lock (typeof(ParamedicTeamMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new ParamedicTeamMetadata();
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
                meta.AddTypeMap("ParamedicID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("StartDate", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("SRParamedicTeamStatus", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("EndDate", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("Notes", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SourceType", new esTypeMap("char", "System.Char"));



                meta.Source = "ParamedicTeam";
                meta.Destination = "ParamedicTeam";

                meta.spInsert = "proc_ParamedicTeamInsert";
                meta.spUpdate = "proc_ParamedicTeamUpdate";
                meta.spDelete = "proc_ParamedicTeamDelete";
                meta.spLoadAll = "proc_ParamedicTeamLoadAll";
                meta.spLoadByPrimaryKey = "proc_ParamedicTeamLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private ParamedicTeamMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
