
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 2/24/2025 11:23:46 AM
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
    /// Encapsulates the 'PatientAllergy' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(PatientAllergy))]
    [XmlType("PatientAllergy")]
    public partial class PatientAllergy : esPatientAllergy
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new PatientAllergy();
        }

        #region Static Quick Access Methods
        static public void Delete(string allergen, string allergyGroup, string patientID)
        {
            var obj = new PatientAllergy();
            obj.Allergen = allergen;
            obj.AllergyGroup = allergyGroup;
            obj.PatientID = patientID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string allergen, string allergyGroup, string patientID, esSqlAccessType sqlAccessType)
        {
            var obj = new PatientAllergy();
            obj.Allergen = allergen;
            obj.AllergyGroup = allergyGroup;
            obj.PatientID = patientID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("PatientAllergyCollection")]
    public partial class PatientAllergyCollection : esPatientAllergyCollection, IEnumerable<PatientAllergy>
    {
        public PatientAllergy FindByPrimaryKey(string allergen, string allergyGroup, string patientID)
        {
            return this.SingleOrDefault(e => e.Allergen == allergen && e.AllergyGroup == allergyGroup && e.PatientID == patientID);
        }



    }



    [Serializable]
    public partial class PatientAllergyQuery : esPatientAllergyQuery
    {
        public PatientAllergyQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public PatientAllergyQuery(string joinAlias, out PatientAllergyQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "PatientAllergyQuery";
        }



        #region Explicit Casts

        public static explicit operator string(PatientAllergyQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator PatientAllergyQuery(string query)
        {
            return (PatientAllergyQuery)SerializeHelper.FromXml(query, typeof(PatientAllergyQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esPatientAllergy : esEntity
    {
        public esPatientAllergy()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string allergen, string allergyGroup, string patientID)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(allergen, allergyGroup, patientID);
            else
                return LoadByPrimaryKeyStoredProcedure(allergen, allergyGroup, patientID);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string allergen, string allergyGroup, string patientID)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(allergen, allergyGroup, patientID);
            else
                return LoadByPrimaryKeyStoredProcedure(allergen, allergyGroup, patientID);
        }

        private bool LoadByPrimaryKeyDynamic(string allergen, string allergyGroup, string patientID)
        {
            PatientAllergyQuery query = new PatientAllergyQuery("paQ");
            query.Where(query.Allergen == allergen, query.AllergyGroup == allergyGroup, query.PatientID == patientID);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string allergen, string allergyGroup, string patientID)
        {
            esParameters parms = new esParameters();
            parms.Add("Allergen", allergen); parms.Add("AllergyGroup", allergyGroup); parms.Add("PatientID", patientID);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to PatientAllergy.AllergyGroup
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string AllergyGroup
        {
            get
            {
                return GetSystemString(PatientAllergyMetadata.ColumnNames.AllergyGroup);
            }

            set
            {
                if (SetSystemString(PatientAllergyMetadata.ColumnNames.AllergyGroup, value))
                {
                    OnPropertyChanged(PatientAllergyMetadata.PropertyNames.AllergyGroup);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAllergy.Allergen
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Allergen
        {
            get
            {
                return GetSystemString(PatientAllergyMetadata.ColumnNames.Allergen);
            }

            set
            {
                if (SetSystemString(PatientAllergyMetadata.ColumnNames.Allergen, value))
                {
                    OnPropertyChanged(PatientAllergyMetadata.PropertyNames.Allergen);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAllergy.AllergenName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string AllergenName
        {
            get
            {
                return GetSystemString(PatientAllergyMetadata.ColumnNames.AllergenName);
            }

            set
            {
                if (SetSystemString(PatientAllergyMetadata.ColumnNames.AllergenName, value))
                {
                    OnPropertyChanged(PatientAllergyMetadata.PropertyNames.AllergenName);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAllergy.SRAnaphylaxis
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRAnaphylaxis
        {
            get
            {
                return GetSystemString(PatientAllergyMetadata.ColumnNames.SRAnaphylaxis);
            }

            set
            {
                if (SetSystemString(PatientAllergyMetadata.ColumnNames.SRAnaphylaxis, value))
                {
                    OnPropertyChanged(PatientAllergyMetadata.PropertyNames.SRAnaphylaxis);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAllergy.Anaphylaxis
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Anaphylaxis
        {
            get
            {
                return GetSystemString(PatientAllergyMetadata.ColumnNames.Anaphylaxis);
            }

            set
            {
                if (SetSystemString(PatientAllergyMetadata.ColumnNames.Anaphylaxis, value))
                {
                    OnPropertyChanged(PatientAllergyMetadata.PropertyNames.Anaphylaxis);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAllergy.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(PatientAllergyMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(PatientAllergyMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(PatientAllergyMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAllergy.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(PatientAllergyMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(PatientAllergyMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(PatientAllergyMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAllergy.PatientID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PatientID
        {
            get
            {
                return GetSystemString(PatientAllergyMetadata.ColumnNames.PatientID);
            }

            set
            {
                if (SetSystemString(PatientAllergyMetadata.ColumnNames.PatientID, value))
                {
                    OnPropertyChanged(PatientAllergyMetadata.PropertyNames.PatientID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAllergy.DescAndReaction
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DescAndReaction
        {
            get
            {
                return GetSystemString(PatientAllergyMetadata.ColumnNames.DescAndReaction);
            }

            set
            {
                if (SetSystemString(PatientAllergyMetadata.ColumnNames.DescAndReaction, value))
                {
                    OnPropertyChanged(PatientAllergyMetadata.PropertyNames.DescAndReaction);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return PatientAllergyMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public PatientAllergyQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new PatientAllergyQuery("paQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(PatientAllergyQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(PatientAllergyQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((PatientAllergyQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private PatientAllergyQuery query;
    }



    [Serializable]
    abstract public partial class esPatientAllergyCollection : esEntityCollection<PatientAllergy>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return PatientAllergyMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "PatientAllergyCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public PatientAllergyQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new PatientAllergyQuery("paQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(PatientAllergyQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new PatientAllergyQuery("paQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(PatientAllergyQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((PatientAllergyQuery)query);
        }

        #endregion

        private PatientAllergyQuery query;
    }



    [Serializable]
    abstract public partial class esPatientAllergyQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return PatientAllergyMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "AllergyGroup": return AllergyGroup;
                case "Allergen": return Allergen;
                case "AllergenName": return AllergenName;
                case "SRAnaphylaxis": return SRAnaphylaxis;
                case "Anaphylaxis": return Anaphylaxis;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "PatientID": return PatientID;
                case "DescAndReaction": return DescAndReaction;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem AllergyGroup
        {
            get { return new esQueryItem(this, PatientAllergyMetadata.ColumnNames.AllergyGroup, esSystemType.String); }
        }

        public esQueryItem Allergen
        {
            get { return new esQueryItem(this, PatientAllergyMetadata.ColumnNames.Allergen, esSystemType.String); }
        }

        public esQueryItem AllergenName
        {
            get { return new esQueryItem(this, PatientAllergyMetadata.ColumnNames.AllergenName, esSystemType.String); }
        }

        public esQueryItem SRAnaphylaxis
        {
            get { return new esQueryItem(this, PatientAllergyMetadata.ColumnNames.SRAnaphylaxis, esSystemType.String); }
        }

        public esQueryItem Anaphylaxis
        {
            get { return new esQueryItem(this, PatientAllergyMetadata.ColumnNames.Anaphylaxis, esSystemType.String); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, PatientAllergyMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, PatientAllergyMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem PatientID
        {
            get { return new esQueryItem(this, PatientAllergyMetadata.ColumnNames.PatientID, esSystemType.String); }
        }

        public esQueryItem DescAndReaction
        {
            get { return new esQueryItem(this, PatientAllergyMetadata.ColumnNames.DescAndReaction, esSystemType.String); }
        }

        #endregion

    }



    [Serializable]
    public partial class PatientAllergyMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected PatientAllergyMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.AllergyGroup, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.AllergyGroup;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 30;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Allergen, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Allergen;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 20;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AllergenName, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.AllergenName;
            c.CharacterMaxLength = 4000;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRAnaphylaxis, 3, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRAnaphylaxis;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Anaphylaxis, 4, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Anaphylaxis;
            c.CharacterMaxLength = 100;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 5, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 6, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 40;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PatientID, 7, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PatientID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 15;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DescAndReaction, 8, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DescAndReaction;
            c.CharacterMaxLength = 4000;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

        }
        #endregion

        static public PatientAllergyMetadata Meta()
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
            public const string AllergyGroup = "AllergyGroup";
            public const string Allergen = "Allergen";
            public const string AllergenName = "AllergenName";
            public const string SRAnaphylaxis = "SRAnaphylaxis";
            public const string Anaphylaxis = "Anaphylaxis";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string PatientID = "PatientID";
            public const string DescAndReaction = "DescAndReaction";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string AllergyGroup = "AllergyGroup";
            public const string Allergen = "Allergen";
            public const string AllergenName = "AllergenName";
            public const string SRAnaphylaxis = "SRAnaphylaxis";
            public const string Anaphylaxis = "Anaphylaxis";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string PatientID = "PatientID";
            public const string DescAndReaction = "DescAndReaction";
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
            lock (typeof(PatientAllergyMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new PatientAllergyMetadata();
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


                meta.AddTypeMap("AllergyGroup", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Allergen", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("AllergenName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRAnaphylaxis", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Anaphylaxis", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PatientID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("DescAndReaction", new esTypeMap("varchar", "System.String"));



                meta.Source = "PatientAllergy";
                meta.Destination = "PatientAllergy";

                meta.spInsert = "proc_PatientAllergyInsert";
                meta.spUpdate = "proc_PatientAllergyUpdate";
                meta.spDelete = "proc_PatientAllergyDelete";
                meta.spLoadAll = "proc_PatientAllergyLoadAll";
                meta.spLoadByPrimaryKey = "proc_PatientAllergyLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private PatientAllergyMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
