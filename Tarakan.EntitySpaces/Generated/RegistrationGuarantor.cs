
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 2/17/2025 9:17:01 AM
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
    /// Encapsulates the 'RegistrationGuarantor' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(RegistrationGuarantor))]
    [XmlType("RegistrationGuarantor")]
    public partial class RegistrationGuarantor : esRegistrationGuarantor
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new RegistrationGuarantor();
        }

        #region Static Quick Access Methods
        static public void Delete(string registrationNo, string guarantorID)
        {
            var obj = new RegistrationGuarantor();
            obj.RegistrationNo = registrationNo;
            obj.GuarantorID = guarantorID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string registrationNo, string guarantorID, esSqlAccessType sqlAccessType)
        {
            var obj = new RegistrationGuarantor();
            obj.RegistrationNo = registrationNo;
            obj.GuarantorID = guarantorID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("RegistrationGuarantorCollection")]
    public partial class RegistrationGuarantorCollection : esRegistrationGuarantorCollection, IEnumerable<RegistrationGuarantor>
    {
        public RegistrationGuarantor FindByPrimaryKey(string registrationNo, string guarantorID)
        {
            return this.SingleOrDefault(e => e.RegistrationNo == registrationNo && e.GuarantorID == guarantorID);
        }



    }



    [Serializable]
    public partial class RegistrationGuarantorQuery : esRegistrationGuarantorQuery
    {
        public RegistrationGuarantorQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public RegistrationGuarantorQuery(string joinAlias, out RegistrationGuarantorQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "RegistrationGuarantorQuery";
        }



        #region Explicit Casts

        public static explicit operator string(RegistrationGuarantorQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator RegistrationGuarantorQuery(string query)
        {
            return (RegistrationGuarantorQuery)SerializeHelper.FromXml(query, typeof(RegistrationGuarantorQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esRegistrationGuarantor : esEntity
    {
        public esRegistrationGuarantor()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string registrationNo, string guarantorID)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(registrationNo, guarantorID);
            else
                return LoadByPrimaryKeyStoredProcedure(registrationNo, guarantorID);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string registrationNo, string guarantorID)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(registrationNo, guarantorID);
            else
                return LoadByPrimaryKeyStoredProcedure(registrationNo, guarantorID);
        }

        private bool LoadByPrimaryKeyDynamic(string registrationNo, string guarantorID)
        {
            RegistrationGuarantorQuery query = new RegistrationGuarantorQuery("rgQ");
            query.Where(query.RegistrationNo == registrationNo, query.GuarantorID == guarantorID);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string registrationNo, string guarantorID)
        {
            esParameters parms = new esParameters();
            parms.Add("RegistrationNo", registrationNo); parms.Add("GuarantorID", guarantorID);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to RegistrationGuarantor.RegistrationNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RegistrationNo
        {
            get
            {
                return GetSystemString(RegistrationGuarantorMetadata.ColumnNames.RegistrationNo);
            }

            set
            {
                if (SetSystemString(RegistrationGuarantorMetadata.ColumnNames.RegistrationNo, value))
                {
                    OnPropertyChanged(RegistrationGuarantorMetadata.PropertyNames.RegistrationNo);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationGuarantor.GuarantorID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string GuarantorID
        {
            get
            {
                return GetSystemString(RegistrationGuarantorMetadata.ColumnNames.GuarantorID);
            }

            set
            {
                if (SetSystemString(RegistrationGuarantorMetadata.ColumnNames.GuarantorID, value))
                {
                    OnPropertyChanged(RegistrationGuarantorMetadata.PropertyNames.GuarantorID);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationGuarantor.PlafondAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? PlafondAmount
        {
            get
            {
                return GetSystemDecimal(RegistrationGuarantorMetadata.ColumnNames.PlafondAmount);
            }

            set
            {
                if (SetSystemDecimal(RegistrationGuarantorMetadata.ColumnNames.PlafondAmount, value))
                {
                    OnPropertyChanged(RegistrationGuarantorMetadata.PropertyNames.PlafondAmount);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationGuarantor.Notes
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Notes
        {
            get
            {
                return GetSystemString(RegistrationGuarantorMetadata.ColumnNames.Notes);
            }

            set
            {
                if (SetSystemString(RegistrationGuarantorMetadata.ColumnNames.Notes, value))
                {
                    OnPropertyChanged(RegistrationGuarantorMetadata.PropertyNames.Notes);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationGuarantor.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(RegistrationGuarantorMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(RegistrationGuarantorMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(RegistrationGuarantorMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationGuarantor.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(RegistrationGuarantorMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(RegistrationGuarantorMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(RegistrationGuarantorMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return RegistrationGuarantorMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public RegistrationGuarantorQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new RegistrationGuarantorQuery("rgQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(RegistrationGuarantorQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(RegistrationGuarantorQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((RegistrationGuarantorQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private RegistrationGuarantorQuery query;
    }



    [Serializable]
    abstract public partial class esRegistrationGuarantorCollection : esEntityCollection<RegistrationGuarantor>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return RegistrationGuarantorMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "RegistrationGuarantorCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public RegistrationGuarantorQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new RegistrationGuarantorQuery("rgQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(RegistrationGuarantorQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new RegistrationGuarantorQuery("rgQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(RegistrationGuarantorQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((RegistrationGuarantorQuery)query);
        }

        #endregion

        private RegistrationGuarantorQuery query;
    }



    [Serializable]
    abstract public partial class esRegistrationGuarantorQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return RegistrationGuarantorMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "RegistrationNo": return RegistrationNo;
                case "GuarantorID": return GuarantorID;
                case "PlafondAmount": return PlafondAmount;
                case "Notes": return Notes;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem RegistrationNo
        {
            get { return new esQueryItem(this, RegistrationGuarantorMetadata.ColumnNames.RegistrationNo, esSystemType.String); }
        }

        public esQueryItem GuarantorID
        {
            get { return new esQueryItem(this, RegistrationGuarantorMetadata.ColumnNames.GuarantorID, esSystemType.String); }
        }

        public esQueryItem PlafondAmount
        {
            get { return new esQueryItem(this, RegistrationGuarantorMetadata.ColumnNames.PlafondAmount, esSystemType.Decimal); }
        }

        public esQueryItem Notes
        {
            get { return new esQueryItem(this, RegistrationGuarantorMetadata.ColumnNames.Notes, esSystemType.String); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, RegistrationGuarantorMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, RegistrationGuarantorMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        #endregion

    }



    [Serializable]
    public partial class RegistrationGuarantorMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected RegistrationGuarantorMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.RegistrationNo, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RegistrationNo;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 20;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.GuarantorID, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.GuarantorID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 10;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PlafondAmount, 2, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.PlafondAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Notes, 3, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Notes;
            c.CharacterMaxLength = 500;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 4, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 5, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public RegistrationGuarantorMetadata Meta()
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
            public const string GuarantorID = "GuarantorID";
            public const string PlafondAmount = "PlafondAmount";
            public const string Notes = "Notes";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string RegistrationNo = "RegistrationNo";
            public const string GuarantorID = "GuarantorID";
            public const string PlafondAmount = "PlafondAmount";
            public const string Notes = "Notes";
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
            lock (typeof(RegistrationGuarantorMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new RegistrationGuarantorMetadata();
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
                meta.AddTypeMap("GuarantorID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PlafondAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("Notes", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));



                meta.Source = "RegistrationGuarantor";
                meta.Destination = "RegistrationGuarantor";

                meta.spInsert = "proc_RegistrationGuarantorInsert";
                meta.spUpdate = "proc_RegistrationGuarantorUpdate";
                meta.spDelete = "proc_RegistrationGuarantorDelete";
                meta.spLoadAll = "proc_RegistrationGuarantorLoadAll";
                meta.spLoadByPrimaryKey = "proc_RegistrationGuarantorLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private RegistrationGuarantorMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
