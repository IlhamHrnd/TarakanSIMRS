
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 3/12/2025 9:29:03 AM
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
    /// Encapsulates the 'PatientRelated' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(PatientRelated))]
    [XmlType("PatientRelated")]
    public partial class PatientRelated : esPatientRelated
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new PatientRelated();
        }

        #region Static Quick Access Methods
        static public void Delete(string patientID, string relatedPatientID)
        {
            var obj = new PatientRelated();
            obj.PatientID = patientID;
            obj.RelatedPatientID = relatedPatientID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string patientID, string relatedPatientID, esSqlAccessType sqlAccessType)
        {
            var obj = new PatientRelated();
            obj.PatientID = patientID;
            obj.RelatedPatientID = relatedPatientID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("PatientRelatedCollection")]
    public partial class PatientRelatedCollection : esPatientRelatedCollection, IEnumerable<PatientRelated>
    {
        public PatientRelated FindByPrimaryKey(string patientID, string relatedPatientID)
        {
            return this.SingleOrDefault(e => e.PatientID == patientID && e.RelatedPatientID == relatedPatientID);
        }



    }



    [Serializable]
    public partial class PatientRelatedQuery : esPatientRelatedQuery
    {
        public PatientRelatedQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public PatientRelatedQuery(string joinAlias, out PatientRelatedQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "PatientRelatedQuery";
        }



        #region Explicit Casts

        public static explicit operator string(PatientRelatedQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator PatientRelatedQuery(string query)
        {
            return (PatientRelatedQuery)SerializeHelper.FromXml(query, typeof(PatientRelatedQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esPatientRelated : esEntity
    {
        public esPatientRelated()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string patientID, string relatedPatientID)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(patientID, relatedPatientID);
            else
                return LoadByPrimaryKeyStoredProcedure(patientID, relatedPatientID);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string patientID, string relatedPatientID)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(patientID, relatedPatientID);
            else
                return LoadByPrimaryKeyStoredProcedure(patientID, relatedPatientID);
        }

        private bool LoadByPrimaryKeyDynamic(string patientID, string relatedPatientID)
        {
            PatientRelatedQuery query = new PatientRelatedQuery("prQ");
            query.Where(query.PatientID == patientID, query.RelatedPatientID == relatedPatientID);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string patientID, string relatedPatientID)
        {
            esParameters parms = new esParameters();
            parms.Add("PatientID", patientID); parms.Add("RelatedPatientID", relatedPatientID);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to PatientRelated.PatientID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PatientID
        {
            get
            {
                return GetSystemString(PatientRelatedMetadata.ColumnNames.PatientID);
            }

            set
            {
                if (SetSystemString(PatientRelatedMetadata.ColumnNames.PatientID, value))
                {
                    OnPropertyChanged(PatientRelatedMetadata.PropertyNames.PatientID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientRelated.RelatedPatientID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RelatedPatientID
        {
            get
            {
                return GetSystemString(PatientRelatedMetadata.ColumnNames.RelatedPatientID);
            }

            set
            {
                if (SetSystemString(PatientRelatedMetadata.ColumnNames.RelatedPatientID, value))
                {
                    OnPropertyChanged(PatientRelatedMetadata.PropertyNames.RelatedPatientID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientRelated.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(PatientRelatedMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(PatientRelatedMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(PatientRelatedMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to PatientRelated.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(PatientRelatedMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(PatientRelatedMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(PatientRelatedMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return PatientRelatedMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public PatientRelatedQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new PatientRelatedQuery("prQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(PatientRelatedQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(PatientRelatedQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((PatientRelatedQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private PatientRelatedQuery query;
    }



    [Serializable]
    abstract public partial class esPatientRelatedCollection : esEntityCollection<PatientRelated>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return PatientRelatedMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "PatientRelatedCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public PatientRelatedQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new PatientRelatedQuery("prQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(PatientRelatedQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new PatientRelatedQuery("prQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(PatientRelatedQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((PatientRelatedQuery)query);
        }

        #endregion

        private PatientRelatedQuery query;
    }



    [Serializable]
    abstract public partial class esPatientRelatedQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return PatientRelatedMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "PatientID": return PatientID;
                case "RelatedPatientID": return RelatedPatientID;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem PatientID
        {
            get { return new esQueryItem(this, PatientRelatedMetadata.ColumnNames.PatientID, esSystemType.String); }
        }

        public esQueryItem RelatedPatientID
        {
            get { return new esQueryItem(this, PatientRelatedMetadata.ColumnNames.RelatedPatientID, esSystemType.String); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, PatientRelatedMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, PatientRelatedMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        #endregion

    }



    [Serializable]
    public partial class PatientRelatedMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected PatientRelatedMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.PatientID, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PatientID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 15;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RelatedPatientID, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RelatedPatientID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 15;
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

        static public PatientRelatedMetadata Meta()
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
            public const string PatientID = "PatientID";
            public const string RelatedPatientID = "RelatedPatientID";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string PatientID = "PatientID";
            public const string RelatedPatientID = "RelatedPatientID";
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
            lock (typeof(PatientRelatedMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new PatientRelatedMetadata();
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


                meta.AddTypeMap("PatientID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("RelatedPatientID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));



                meta.Source = "PatientRelated";
                meta.Destination = "PatientRelated";

                meta.spInsert = "proc_PatientRelatedInsert";
                meta.spUpdate = "proc_PatientRelatedUpdate";
                meta.spDelete = "proc_PatientRelatedDelete";
                meta.spLoadAll = "proc_PatientRelatedLoadAll";
                meta.spLoadByPrimaryKey = "proc_PatientRelatedLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private PatientRelatedMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
