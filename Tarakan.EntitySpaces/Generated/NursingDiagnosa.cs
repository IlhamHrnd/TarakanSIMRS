
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 3/12/2025 11:22:11 AM
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
    /// Encapsulates the 'NursingDiagnosa' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(NursingDiagnosa))]
    [XmlType("NursingDiagnosa")]
    public partial class NursingDiagnosa : esNursingDiagnosa
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new NursingDiagnosa();
        }

        #region Static Quick Access Methods
        static public void Delete(string nursingDiagnosaID)
        {
            var obj = new NursingDiagnosa();
            obj.NursingDiagnosaID = nursingDiagnosaID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string nursingDiagnosaID, esSqlAccessType sqlAccessType)
        {
            var obj = new NursingDiagnosa();
            obj.NursingDiagnosaID = nursingDiagnosaID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("NursingDiagnosaCollection")]
    public partial class NursingDiagnosaCollection : esNursingDiagnosaCollection, IEnumerable<NursingDiagnosa>
    {
        public NursingDiagnosa FindByPrimaryKey(string nursingDiagnosaID)
        {
            return this.SingleOrDefault(e => e.NursingDiagnosaID == nursingDiagnosaID);
        }



    }



    [Serializable]
    public partial class NursingDiagnosaQuery : esNursingDiagnosaQuery
    {
        public NursingDiagnosaQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public NursingDiagnosaQuery(string joinAlias, out NursingDiagnosaQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "NursingDiagnosaQuery";
        }



        #region Explicit Casts

        public static explicit operator string(NursingDiagnosaQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator NursingDiagnosaQuery(string query)
        {
            return (NursingDiagnosaQuery)SerializeHelper.FromXml(query, typeof(NursingDiagnosaQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esNursingDiagnosa : esEntity
    {
        public esNursingDiagnosa()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string nursingDiagnosaID)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(nursingDiagnosaID);
            else
                return LoadByPrimaryKeyStoredProcedure(nursingDiagnosaID);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string nursingDiagnosaID)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(nursingDiagnosaID);
            else
                return LoadByPrimaryKeyStoredProcedure(nursingDiagnosaID);
        }

        private bool LoadByPrimaryKeyDynamic(string nursingDiagnosaID)
        {
            NursingDiagnosaQuery query = new NursingDiagnosaQuery("ndQ");
            query.Where(query.NursingDiagnosaID == nursingDiagnosaID);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string nursingDiagnosaID)
        {
            esParameters parms = new esParameters();
            parms.Add("NursingDiagnosaID", nursingDiagnosaID);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to NursingDiagnosa.NursingDiagnosaID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string NursingDiagnosaID
        {
            get
            {
                return GetSystemString(NursingDiagnosaMetadata.ColumnNames.NursingDiagnosaID);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaMetadata.ColumnNames.NursingDiagnosaID, value))
                {
                    OnPropertyChanged(NursingDiagnosaMetadata.PropertyNames.NursingDiagnosaID);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosa.NursingDiagnosaName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string NursingDiagnosaName
        {
            get
            {
                return GetSystemString(NursingDiagnosaMetadata.ColumnNames.NursingDiagnosaName);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaMetadata.ColumnNames.NursingDiagnosaName, value))
                {
                    OnPropertyChanged(NursingDiagnosaMetadata.PropertyNames.NursingDiagnosaName);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosa.SRNursingDiagnosaLevel
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRNursingDiagnosaLevel
        {
            get
            {
                return GetSystemString(NursingDiagnosaMetadata.ColumnNames.SRNursingDiagnosaLevel);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaMetadata.ColumnNames.SRNursingDiagnosaLevel, value))
                {
                    OnPropertyChanged(NursingDiagnosaMetadata.PropertyNames.SRNursingDiagnosaLevel);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosa.SequenceNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SequenceNo
        {
            get
            {
                return GetSystemString(NursingDiagnosaMetadata.ColumnNames.SequenceNo);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaMetadata.ColumnNames.SequenceNo, value))
                {
                    OnPropertyChanged(NursingDiagnosaMetadata.PropertyNames.SequenceNo);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosa.IsActive
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsActive
        {
            get
            {
                return GetSystemBoolean(NursingDiagnosaMetadata.ColumnNames.IsActive);
            }

            set
            {
                if (SetSystemBoolean(NursingDiagnosaMetadata.ColumnNames.IsActive, value))
                {
                    OnPropertyChanged(NursingDiagnosaMetadata.PropertyNames.IsActive);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosa.NursingDiagnosaParentID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string NursingDiagnosaParentID
        {
            get
            {
                return GetSystemString(NursingDiagnosaMetadata.ColumnNames.NursingDiagnosaParentID);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaMetadata.ColumnNames.NursingDiagnosaParentID, value))
                {
                    OnPropertyChanged(NursingDiagnosaMetadata.PropertyNames.NursingDiagnosaParentID);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosa.SRNursingNicType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRNursingNicType
        {
            get
            {
                return GetSystemString(NursingDiagnosaMetadata.ColumnNames.SRNursingNicType);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaMetadata.ColumnNames.SRNursingNicType, value))
                {
                    OnPropertyChanged(NursingDiagnosaMetadata.PropertyNames.SRNursingNicType);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosa.CreateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string CreateByUserID
        {
            get
            {
                return GetSystemString(NursingDiagnosaMetadata.ColumnNames.CreateByUserID);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaMetadata.ColumnNames.CreateByUserID, value))
                {
                    OnPropertyChanged(NursingDiagnosaMetadata.PropertyNames.CreateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosa.CreateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? CreateDateTime
        {
            get
            {
                return GetSystemDateTime(NursingDiagnosaMetadata.ColumnNames.CreateDateTime);
            }

            set
            {
                if (SetSystemDateTime(NursingDiagnosaMetadata.ColumnNames.CreateDateTime, value))
                {
                    OnPropertyChanged(NursingDiagnosaMetadata.PropertyNames.CreateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosa.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(NursingDiagnosaMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(NursingDiagnosaMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosa.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(NursingDiagnosaMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(NursingDiagnosaMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(NursingDiagnosaMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosa.RespondTemplate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RespondTemplate
        {
            get
            {
                return GetSystemString(NursingDiagnosaMetadata.ColumnNames.RespondTemplate);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaMetadata.ColumnNames.RespondTemplate, value))
                {
                    OnPropertyChanged(NursingDiagnosaMetadata.PropertyNames.RespondTemplate);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosa.TemplateID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? TemplateID
        {
            get
            {
                return GetSystemInt32(NursingDiagnosaMetadata.ColumnNames.TemplateID);
            }

            set
            {
                if (SetSystemInt32(NursingDiagnosaMetadata.ColumnNames.TemplateID, value))
                {
                    OnPropertyChanged(NursingDiagnosaMetadata.PropertyNames.TemplateID);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosa.SRNsDiagnosaType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRNsDiagnosaType
        {
            get
            {
                return GetSystemString(NursingDiagnosaMetadata.ColumnNames.SRNsDiagnosaType);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaMetadata.ColumnNames.SRNsDiagnosaType, value))
                {
                    OnPropertyChanged(NursingDiagnosaMetadata.PropertyNames.SRNsDiagnosaType);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosa.SRNsEtiologyType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRNsEtiologyType
        {
            get
            {
                return GetSystemString(NursingDiagnosaMetadata.ColumnNames.SRNsEtiologyType);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaMetadata.ColumnNames.SRNsEtiologyType, value))
                {
                    OnPropertyChanged(NursingDiagnosaMetadata.PropertyNames.SRNsEtiologyType);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosa.Prefix
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Prefix
        {
            get
            {
                return GetSystemString(NursingDiagnosaMetadata.ColumnNames.Prefix);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaMetadata.ColumnNames.Prefix, value))
                {
                    OnPropertyChanged(NursingDiagnosaMetadata.PropertyNames.Prefix);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosa.Suffix
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Suffix
        {
            get
            {
                return GetSystemString(NursingDiagnosaMetadata.ColumnNames.Suffix);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaMetadata.ColumnNames.Suffix, value))
                {
                    OnPropertyChanged(NursingDiagnosaMetadata.PropertyNames.Suffix);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosa.NursingDiagnosaCode
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string NursingDiagnosaCode
        {
            get
            {
                return GetSystemString(NursingDiagnosaMetadata.ColumnNames.NursingDiagnosaCode);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaMetadata.ColumnNames.NursingDiagnosaCode, value))
                {
                    OnPropertyChanged(NursingDiagnosaMetadata.PropertyNames.NursingDiagnosaCode);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosa.F1
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string F1
        {
            get
            {
                return GetSystemString(NursingDiagnosaMetadata.ColumnNames.F1);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaMetadata.ColumnNames.F1, value))
                {
                    OnPropertyChanged(NursingDiagnosaMetadata.PropertyNames.F1);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosa.F2
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string F2
        {
            get
            {
                return GetSystemString(NursingDiagnosaMetadata.ColumnNames.F2);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaMetadata.ColumnNames.F2, value))
                {
                    OnPropertyChanged(NursingDiagnosaMetadata.PropertyNames.F2);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosa.SRNursingNocType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRNursingNocType
        {
            get
            {
                return GetSystemString(NursingDiagnosaMetadata.ColumnNames.SRNursingNocType);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaMetadata.ColumnNames.SRNursingNocType, value))
                {
                    OnPropertyChanged(NursingDiagnosaMetadata.PropertyNames.SRNursingNocType);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return NursingDiagnosaMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public NursingDiagnosaQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new NursingDiagnosaQuery("ndQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(NursingDiagnosaQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(NursingDiagnosaQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((NursingDiagnosaQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private NursingDiagnosaQuery query;
    }



    [Serializable]
    abstract public partial class esNursingDiagnosaCollection : esEntityCollection<NursingDiagnosa>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return NursingDiagnosaMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "NursingDiagnosaCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public NursingDiagnosaQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new NursingDiagnosaQuery("ndQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(NursingDiagnosaQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new NursingDiagnosaQuery("ndQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(NursingDiagnosaQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((NursingDiagnosaQuery)query);
        }

        #endregion

        private NursingDiagnosaQuery query;
    }



    [Serializable]
    abstract public partial class esNursingDiagnosaQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return NursingDiagnosaMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "NursingDiagnosaID": return NursingDiagnosaID;
                case "NursingDiagnosaName": return NursingDiagnosaName;
                case "SRNursingDiagnosaLevel": return SRNursingDiagnosaLevel;
                case "SequenceNo": return SequenceNo;
                case "IsActive": return IsActive;
                case "NursingDiagnosaParentID": return NursingDiagnosaParentID;
                case "SRNursingNicType": return SRNursingNicType;
                case "CreateByUserID": return CreateByUserID;
                case "CreateDateTime": return CreateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "RespondTemplate": return RespondTemplate;
                case "TemplateID": return TemplateID;
                case "SRNsDiagnosaType": return SRNsDiagnosaType;
                case "SRNsEtiologyType": return SRNsEtiologyType;
                case "Prefix": return Prefix;
                case "Suffix": return Suffix;
                case "NursingDiagnosaCode": return NursingDiagnosaCode;
                case "F1": return F1;
                case "F2": return F2;
                case "SRNursingNocType": return SRNursingNocType;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem NursingDiagnosaID
        {
            get { return new esQueryItem(this, NursingDiagnosaMetadata.ColumnNames.NursingDiagnosaID, esSystemType.String); }
        }

        public esQueryItem NursingDiagnosaName
        {
            get { return new esQueryItem(this, NursingDiagnosaMetadata.ColumnNames.NursingDiagnosaName, esSystemType.String); }
        }

        public esQueryItem SRNursingDiagnosaLevel
        {
            get { return new esQueryItem(this, NursingDiagnosaMetadata.ColumnNames.SRNursingDiagnosaLevel, esSystemType.String); }
        }

        public esQueryItem SequenceNo
        {
            get { return new esQueryItem(this, NursingDiagnosaMetadata.ColumnNames.SequenceNo, esSystemType.String); }
        }

        public esQueryItem IsActive
        {
            get { return new esQueryItem(this, NursingDiagnosaMetadata.ColumnNames.IsActive, esSystemType.Boolean); }
        }

        public esQueryItem NursingDiagnosaParentID
        {
            get { return new esQueryItem(this, NursingDiagnosaMetadata.ColumnNames.NursingDiagnosaParentID, esSystemType.String); }
        }

        public esQueryItem SRNursingNicType
        {
            get { return new esQueryItem(this, NursingDiagnosaMetadata.ColumnNames.SRNursingNicType, esSystemType.String); }
        }

        public esQueryItem CreateByUserID
        {
            get { return new esQueryItem(this, NursingDiagnosaMetadata.ColumnNames.CreateByUserID, esSystemType.String); }
        }

        public esQueryItem CreateDateTime
        {
            get { return new esQueryItem(this, NursingDiagnosaMetadata.ColumnNames.CreateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, NursingDiagnosaMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, NursingDiagnosaMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem RespondTemplate
        {
            get { return new esQueryItem(this, NursingDiagnosaMetadata.ColumnNames.RespondTemplate, esSystemType.String); }
        }

        public esQueryItem TemplateID
        {
            get { return new esQueryItem(this, NursingDiagnosaMetadata.ColumnNames.TemplateID, esSystemType.Int32); }
        }

        public esQueryItem SRNsDiagnosaType
        {
            get { return new esQueryItem(this, NursingDiagnosaMetadata.ColumnNames.SRNsDiagnosaType, esSystemType.String); }
        }

        public esQueryItem SRNsEtiologyType
        {
            get { return new esQueryItem(this, NursingDiagnosaMetadata.ColumnNames.SRNsEtiologyType, esSystemType.String); }
        }

        public esQueryItem Prefix
        {
            get { return new esQueryItem(this, NursingDiagnosaMetadata.ColumnNames.Prefix, esSystemType.String); }
        }

        public esQueryItem Suffix
        {
            get { return new esQueryItem(this, NursingDiagnosaMetadata.ColumnNames.Suffix, esSystemType.String); }
        }

        public esQueryItem NursingDiagnosaCode
        {
            get { return new esQueryItem(this, NursingDiagnosaMetadata.ColumnNames.NursingDiagnosaCode, esSystemType.String); }
        }

        public esQueryItem F1
        {
            get { return new esQueryItem(this, NursingDiagnosaMetadata.ColumnNames.F1, esSystemType.String); }
        }

        public esQueryItem F2
        {
            get { return new esQueryItem(this, NursingDiagnosaMetadata.ColumnNames.F2, esSystemType.String); }
        }

        public esQueryItem SRNursingNocType
        {
            get { return new esQueryItem(this, NursingDiagnosaMetadata.ColumnNames.SRNursingNocType, esSystemType.String); }
        }

        #endregion

    }



    [Serializable]
    public partial class NursingDiagnosaMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected NursingDiagnosaMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.NursingDiagnosaID, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.NursingDiagnosaID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 20;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.NursingDiagnosaName, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.NursingDiagnosaName;
            c.CharacterMaxLength = 450;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRNursingDiagnosaLevel, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRNursingDiagnosaLevel;
            c.CharacterMaxLength = 20;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SequenceNo, 3, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SequenceNo;
            c.CharacterMaxLength = 5;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsActive, 4, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsActive;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.NursingDiagnosaParentID, 5, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.NursingDiagnosaParentID;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRNursingNicType, 6, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRNursingNicType;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreateByUserID, 7, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.CreateByUserID;
            c.CharacterMaxLength = 15;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreateDateTime, 8, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.CreateDateTime;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 9, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 15;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 10, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RespondTemplate, 11, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RespondTemplate;
            c.CharacterMaxLength = 255;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TemplateID, 12, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.TemplateID;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRNsDiagnosaType, 13, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRNsDiagnosaType;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRNsEtiologyType, 14, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRNsEtiologyType;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Prefix, 15, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Prefix;
            c.CharacterMaxLength = 450;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Suffix, 16, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Suffix;
            c.CharacterMaxLength = 450;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.NursingDiagnosaCode, 17, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.NursingDiagnosaCode;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.F1, 18, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.F1;
            c.CharacterMaxLength = 500;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.F2, 19, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.F2;
            c.CharacterMaxLength = 500;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRNursingNocType, 20, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRNursingNocType;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public NursingDiagnosaMetadata Meta()
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
            public const string NursingDiagnosaID = "NursingDiagnosaID";
            public const string NursingDiagnosaName = "NursingDiagnosaName";
            public const string SRNursingDiagnosaLevel = "SRNursingDiagnosaLevel";
            public const string SequenceNo = "SequenceNo";
            public const string IsActive = "IsActive";
            public const string NursingDiagnosaParentID = "NursingDiagnosaParentID";
            public const string SRNursingNicType = "SRNursingNicType";
            public const string CreateByUserID = "CreateByUserID";
            public const string CreateDateTime = "CreateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string RespondTemplate = "RespondTemplate";
            public const string TemplateID = "TemplateID";
            public const string SRNsDiagnosaType = "SRNsDiagnosaType";
            public const string SRNsEtiologyType = "SRNsEtiologyType";
            public const string Prefix = "Prefix";
            public const string Suffix = "Suffix";
            public const string NursingDiagnosaCode = "NursingDiagnosaCode";
            public const string F1 = "F1";
            public const string F2 = "F2";
            public const string SRNursingNocType = "SRNursingNocType";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string NursingDiagnosaID = "NursingDiagnosaID";
            public const string NursingDiagnosaName = "NursingDiagnosaName";
            public const string SRNursingDiagnosaLevel = "SRNursingDiagnosaLevel";
            public const string SequenceNo = "SequenceNo";
            public const string IsActive = "IsActive";
            public const string NursingDiagnosaParentID = "NursingDiagnosaParentID";
            public const string SRNursingNicType = "SRNursingNicType";
            public const string CreateByUserID = "CreateByUserID";
            public const string CreateDateTime = "CreateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string RespondTemplate = "RespondTemplate";
            public const string TemplateID = "TemplateID";
            public const string SRNsDiagnosaType = "SRNsDiagnosaType";
            public const string SRNsEtiologyType = "SRNsEtiologyType";
            public const string Prefix = "Prefix";
            public const string Suffix = "Suffix";
            public const string NursingDiagnosaCode = "NursingDiagnosaCode";
            public const string F1 = "F1";
            public const string F2 = "F2";
            public const string SRNursingNocType = "SRNursingNocType";
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
            lock (typeof(NursingDiagnosaMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new NursingDiagnosaMetadata();
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


                meta.AddTypeMap("NursingDiagnosaID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("NursingDiagnosaName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRNursingDiagnosaLevel", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SequenceNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsActive", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("NursingDiagnosaParentID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRNursingNicType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CreateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CreateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("RespondTemplate", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TemplateID", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("SRNsDiagnosaType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRNsEtiologyType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Prefix", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Suffix", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("NursingDiagnosaCode", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("F1", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("F2", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRNursingNocType", new esTypeMap("varchar", "System.String"));



                meta.Source = "NursingDiagnosa";
                meta.Destination = "NursingDiagnosa";

                meta.spInsert = "proc_NursingDiagnosaInsert";
                meta.spUpdate = "proc_NursingDiagnosaUpdate";
                meta.spDelete = "proc_NursingDiagnosaDelete";
                meta.spLoadAll = "proc_NursingDiagnosaLoadAll";
                meta.spLoadByPrimaryKey = "proc_NursingDiagnosaLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private NursingDiagnosaMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
