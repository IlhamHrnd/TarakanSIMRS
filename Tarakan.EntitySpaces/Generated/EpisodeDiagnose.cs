
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 2/20/2025 2:20:09 PM
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
    /// Encapsulates the 'EpisodeDiagnose' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(EpisodeDiagnose))]
    [XmlType("EpisodeDiagnose")]
    public partial class EpisodeDiagnose : esEpisodeDiagnose
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new EpisodeDiagnose();
        }

        #region Static Quick Access Methods
        static public void Delete(string registrationNo, string sequenceNo)
        {
            var obj = new EpisodeDiagnose();
            obj.RegistrationNo = registrationNo;
            obj.SequenceNo = sequenceNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string registrationNo, string sequenceNo, esSqlAccessType sqlAccessType)
        {
            var obj = new EpisodeDiagnose();
            obj.RegistrationNo = registrationNo;
            obj.SequenceNo = sequenceNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("EpisodeDiagnoseCollection")]
    public partial class EpisodeDiagnoseCollection : esEpisodeDiagnoseCollection, IEnumerable<EpisodeDiagnose>
    {
        public EpisodeDiagnose FindByPrimaryKey(string registrationNo, string sequenceNo)
        {
            return this.SingleOrDefault(e => e.RegistrationNo == registrationNo && e.SequenceNo == sequenceNo);
        }



    }



    [Serializable]
    public partial class EpisodeDiagnoseQuery : esEpisodeDiagnoseQuery
    {
        public EpisodeDiagnoseQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public EpisodeDiagnoseQuery(string joinAlias, out EpisodeDiagnoseQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "EpisodeDiagnoseQuery";
        }



        #region Explicit Casts

        public static explicit operator string(EpisodeDiagnoseQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator EpisodeDiagnoseQuery(string query)
        {
            return (EpisodeDiagnoseQuery)SerializeHelper.FromXml(query, typeof(EpisodeDiagnoseQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esEpisodeDiagnose : esEntity
    {
        public esEpisodeDiagnose()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string registrationNo, string sequenceNo)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(registrationNo, sequenceNo);
            else
                return LoadByPrimaryKeyStoredProcedure(registrationNo, sequenceNo);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string registrationNo, string sequenceNo)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(registrationNo, sequenceNo);
            else
                return LoadByPrimaryKeyStoredProcedure(registrationNo, sequenceNo);
        }

        private bool LoadByPrimaryKeyDynamic(string registrationNo, string sequenceNo)
        {
            EpisodeDiagnoseQuery query = new EpisodeDiagnoseQuery("edQ");
            query.Where(query.RegistrationNo == registrationNo, query.SequenceNo == sequenceNo);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string registrationNo, string sequenceNo)
        {
            esParameters parms = new esParameters();
            parms.Add("RegistrationNo", registrationNo); parms.Add("SequenceNo", sequenceNo);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to EpisodeDiagnose.RegistrationNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RegistrationNo
        {
            get
            {
                return GetSystemString(EpisodeDiagnoseMetadata.ColumnNames.RegistrationNo);
            }

            set
            {
                if (SetSystemString(EpisodeDiagnoseMetadata.ColumnNames.RegistrationNo, value))
                {
                    OnPropertyChanged(EpisodeDiagnoseMetadata.PropertyNames.RegistrationNo);
                }
            }
        }

        /// <summary>
        /// Maps to EpisodeDiagnose.SequenceNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SequenceNo
        {
            get
            {
                return GetSystemString(EpisodeDiagnoseMetadata.ColumnNames.SequenceNo);
            }

            set
            {
                if (SetSystemString(EpisodeDiagnoseMetadata.ColumnNames.SequenceNo, value))
                {
                    OnPropertyChanged(EpisodeDiagnoseMetadata.PropertyNames.SequenceNo);
                }
            }
        }

        /// <summary>
        /// Maps to EpisodeDiagnose.DiagnoseID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DiagnoseID
        {
            get
            {
                return GetSystemString(EpisodeDiagnoseMetadata.ColumnNames.DiagnoseID);
            }

            set
            {
                if (SetSystemString(EpisodeDiagnoseMetadata.ColumnNames.DiagnoseID, value))
                {
                    OnPropertyChanged(EpisodeDiagnoseMetadata.PropertyNames.DiagnoseID);
                }
            }
        }

        /// <summary>
        /// Maps to EpisodeDiagnose.SRDiagnoseType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRDiagnoseType
        {
            get
            {
                return GetSystemString(EpisodeDiagnoseMetadata.ColumnNames.SRDiagnoseType);
            }

            set
            {
                if (SetSystemString(EpisodeDiagnoseMetadata.ColumnNames.SRDiagnoseType, value))
                {
                    OnPropertyChanged(EpisodeDiagnoseMetadata.PropertyNames.SRDiagnoseType);
                }
            }
        }

        /// <summary>
        /// Maps to EpisodeDiagnose.DiagnosisText
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DiagnosisText
        {
            get
            {
                return GetSystemString(EpisodeDiagnoseMetadata.ColumnNames.DiagnosisText);
            }

            set
            {
                if (SetSystemString(EpisodeDiagnoseMetadata.ColumnNames.DiagnosisText, value))
                {
                    OnPropertyChanged(EpisodeDiagnoseMetadata.PropertyNames.DiagnosisText);
                }
            }
        }

        /// <summary>
        /// Maps to EpisodeDiagnose.MorphologyID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string MorphologyID
        {
            get
            {
                return GetSystemString(EpisodeDiagnoseMetadata.ColumnNames.MorphologyID);
            }

            set
            {
                if (SetSystemString(EpisodeDiagnoseMetadata.ColumnNames.MorphologyID, value))
                {
                    OnPropertyChanged(EpisodeDiagnoseMetadata.PropertyNames.MorphologyID);
                }
            }
        }

        /// <summary>
        /// Maps to EpisodeDiagnose.ParamedicID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParamedicID
        {
            get
            {
                return GetSystemString(EpisodeDiagnoseMetadata.ColumnNames.ParamedicID);
            }

            set
            {
                if (SetSystemString(EpisodeDiagnoseMetadata.ColumnNames.ParamedicID, value))
                {
                    OnPropertyChanged(EpisodeDiagnoseMetadata.PropertyNames.ParamedicID);
                }
            }
        }

        /// <summary>
        /// Maps to EpisodeDiagnose.IsAcuteDisease
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsAcuteDisease
        {
            get
            {
                return GetSystemBoolean(EpisodeDiagnoseMetadata.ColumnNames.IsAcuteDisease);
            }

            set
            {
                if (SetSystemBoolean(EpisodeDiagnoseMetadata.ColumnNames.IsAcuteDisease, value))
                {
                    OnPropertyChanged(EpisodeDiagnoseMetadata.PropertyNames.IsAcuteDisease);
                }
            }
        }

        /// <summary>
        /// Maps to EpisodeDiagnose.IsChronicDisease
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsChronicDisease
        {
            get
            {
                return GetSystemBoolean(EpisodeDiagnoseMetadata.ColumnNames.IsChronicDisease);
            }

            set
            {
                if (SetSystemBoolean(EpisodeDiagnoseMetadata.ColumnNames.IsChronicDisease, value))
                {
                    OnPropertyChanged(EpisodeDiagnoseMetadata.PropertyNames.IsChronicDisease);
                }
            }
        }

        /// <summary>
        /// Maps to EpisodeDiagnose.IsOldCase
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsOldCase
        {
            get
            {
                return GetSystemBoolean(EpisodeDiagnoseMetadata.ColumnNames.IsOldCase);
            }

            set
            {
                if (SetSystemBoolean(EpisodeDiagnoseMetadata.ColumnNames.IsOldCase, value))
                {
                    OnPropertyChanged(EpisodeDiagnoseMetadata.PropertyNames.IsOldCase);
                }
            }
        }

        /// <summary>
        /// Maps to EpisodeDiagnose.IsConfirmed
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsConfirmed
        {
            get
            {
                return GetSystemBoolean(EpisodeDiagnoseMetadata.ColumnNames.IsConfirmed);
            }

            set
            {
                if (SetSystemBoolean(EpisodeDiagnoseMetadata.ColumnNames.IsConfirmed, value))
                {
                    OnPropertyChanged(EpisodeDiagnoseMetadata.PropertyNames.IsConfirmed);
                }
            }
        }

        /// <summary>
        /// Maps to EpisodeDiagnose.IsVoid
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsVoid
        {
            get
            {
                return GetSystemBoolean(EpisodeDiagnoseMetadata.ColumnNames.IsVoid);
            }

            set
            {
                if (SetSystemBoolean(EpisodeDiagnoseMetadata.ColumnNames.IsVoid, value))
                {
                    OnPropertyChanged(EpisodeDiagnoseMetadata.PropertyNames.IsVoid);
                }
            }
        }

        /// <summary>
        /// Maps to EpisodeDiagnose.Notes
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Notes
        {
            get
            {
                return GetSystemString(EpisodeDiagnoseMetadata.ColumnNames.Notes);
            }

            set
            {
                if (SetSystemString(EpisodeDiagnoseMetadata.ColumnNames.Notes, value))
                {
                    OnPropertyChanged(EpisodeDiagnoseMetadata.PropertyNames.Notes);
                }
            }
        }

        /// <summary>
        /// Maps to EpisodeDiagnose.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(EpisodeDiagnoseMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(EpisodeDiagnoseMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(EpisodeDiagnoseMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to EpisodeDiagnose.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(EpisodeDiagnoseMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(EpisodeDiagnoseMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(EpisodeDiagnoseMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to EpisodeDiagnose.ExternalCauseID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ExternalCauseID
        {
            get
            {
                return GetSystemString(EpisodeDiagnoseMetadata.ColumnNames.ExternalCauseID);
            }

            set
            {
                if (SetSystemString(EpisodeDiagnoseMetadata.ColumnNames.ExternalCauseID, value))
                {
                    OnPropertyChanged(EpisodeDiagnoseMetadata.PropertyNames.ExternalCauseID);
                }
            }
        }

        /// <summary>
        /// Maps to EpisodeDiagnose.CreateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string CreateByUserID
        {
            get
            {
                return GetSystemString(EpisodeDiagnoseMetadata.ColumnNames.CreateByUserID);
            }

            set
            {
                if (SetSystemString(EpisodeDiagnoseMetadata.ColumnNames.CreateByUserID, value))
                {
                    OnPropertyChanged(EpisodeDiagnoseMetadata.PropertyNames.CreateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to EpisodeDiagnose.CreateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? CreateDateTime
        {
            get
            {
                return GetSystemDateTime(EpisodeDiagnoseMetadata.ColumnNames.CreateDateTime);
            }

            set
            {
                if (SetSystemDateTime(EpisodeDiagnoseMetadata.ColumnNames.CreateDateTime, value))
                {
                    OnPropertyChanged(EpisodeDiagnoseMetadata.PropertyNames.CreateDateTime);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return EpisodeDiagnoseMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public EpisodeDiagnoseQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new EpisodeDiagnoseQuery("edQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(EpisodeDiagnoseQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(EpisodeDiagnoseQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((EpisodeDiagnoseQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private EpisodeDiagnoseQuery query;
    }



    [Serializable]
    abstract public partial class esEpisodeDiagnoseCollection : esEntityCollection<EpisodeDiagnose>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return EpisodeDiagnoseMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "EpisodeDiagnoseCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public EpisodeDiagnoseQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new EpisodeDiagnoseQuery("edQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(EpisodeDiagnoseQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new EpisodeDiagnoseQuery("edQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(EpisodeDiagnoseQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((EpisodeDiagnoseQuery)query);
        }

        #endregion

        private EpisodeDiagnoseQuery query;
    }



    [Serializable]
    abstract public partial class esEpisodeDiagnoseQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return EpisodeDiagnoseMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "RegistrationNo": return RegistrationNo;
                case "SequenceNo": return SequenceNo;
                case "DiagnoseID": return DiagnoseID;
                case "SRDiagnoseType": return SRDiagnoseType;
                case "DiagnosisText": return DiagnosisText;
                case "MorphologyID": return MorphologyID;
                case "ParamedicID": return ParamedicID;
                case "IsAcuteDisease": return IsAcuteDisease;
                case "IsChronicDisease": return IsChronicDisease;
                case "IsOldCase": return IsOldCase;
                case "IsConfirmed": return IsConfirmed;
                case "IsVoid": return IsVoid;
                case "Notes": return Notes;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "ExternalCauseID": return ExternalCauseID;
                case "CreateByUserID": return CreateByUserID;
                case "CreateDateTime": return CreateDateTime;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem RegistrationNo
        {
            get { return new esQueryItem(this, EpisodeDiagnoseMetadata.ColumnNames.RegistrationNo, esSystemType.String); }
        }

        public esQueryItem SequenceNo
        {
            get { return new esQueryItem(this, EpisodeDiagnoseMetadata.ColumnNames.SequenceNo, esSystemType.String); }
        }

        public esQueryItem DiagnoseID
        {
            get { return new esQueryItem(this, EpisodeDiagnoseMetadata.ColumnNames.DiagnoseID, esSystemType.String); }
        }

        public esQueryItem SRDiagnoseType
        {
            get { return new esQueryItem(this, EpisodeDiagnoseMetadata.ColumnNames.SRDiagnoseType, esSystemType.String); }
        }

        public esQueryItem DiagnosisText
        {
            get { return new esQueryItem(this, EpisodeDiagnoseMetadata.ColumnNames.DiagnosisText, esSystemType.String); }
        }

        public esQueryItem MorphologyID
        {
            get { return new esQueryItem(this, EpisodeDiagnoseMetadata.ColumnNames.MorphologyID, esSystemType.String); }
        }

        public esQueryItem ParamedicID
        {
            get { return new esQueryItem(this, EpisodeDiagnoseMetadata.ColumnNames.ParamedicID, esSystemType.String); }
        }

        public esQueryItem IsAcuteDisease
        {
            get { return new esQueryItem(this, EpisodeDiagnoseMetadata.ColumnNames.IsAcuteDisease, esSystemType.Boolean); }
        }

        public esQueryItem IsChronicDisease
        {
            get { return new esQueryItem(this, EpisodeDiagnoseMetadata.ColumnNames.IsChronicDisease, esSystemType.Boolean); }
        }

        public esQueryItem IsOldCase
        {
            get { return new esQueryItem(this, EpisodeDiagnoseMetadata.ColumnNames.IsOldCase, esSystemType.Boolean); }
        }

        public esQueryItem IsConfirmed
        {
            get { return new esQueryItem(this, EpisodeDiagnoseMetadata.ColumnNames.IsConfirmed, esSystemType.Boolean); }
        }

        public esQueryItem IsVoid
        {
            get { return new esQueryItem(this, EpisodeDiagnoseMetadata.ColumnNames.IsVoid, esSystemType.Boolean); }
        }

        public esQueryItem Notes
        {
            get { return new esQueryItem(this, EpisodeDiagnoseMetadata.ColumnNames.Notes, esSystemType.String); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, EpisodeDiagnoseMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, EpisodeDiagnoseMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem ExternalCauseID
        {
            get { return new esQueryItem(this, EpisodeDiagnoseMetadata.ColumnNames.ExternalCauseID, esSystemType.String); }
        }

        public esQueryItem CreateByUserID
        {
            get { return new esQueryItem(this, EpisodeDiagnoseMetadata.ColumnNames.CreateByUserID, esSystemType.String); }
        }

        public esQueryItem CreateDateTime
        {
            get { return new esQueryItem(this, EpisodeDiagnoseMetadata.ColumnNames.CreateDateTime, esSystemType.DateTime); }
        }

        #endregion

    }



    [Serializable]
    public partial class EpisodeDiagnoseMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected EpisodeDiagnoseMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.RegistrationNo, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RegistrationNo;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SequenceNo, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SequenceNo;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 3;
            c.HasDefault = true;
            c.Default = @"('000')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DiagnoseID, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DiagnoseID;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRDiagnoseType, 3, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRDiagnoseType;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DiagnosisText, 4, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DiagnosisText;
            c.CharacterMaxLength = 8000;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.MorphologyID, 5, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.MorphologyID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParamedicID, 6, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParamedicID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsAcuteDisease, 7, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsAcuteDisease;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsChronicDisease, 8, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsChronicDisease;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsOldCase, 9, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsOldCase;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsConfirmed, 10, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsConfirmed;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsVoid, 11, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsVoid;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Notes, 12, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Notes;
            c.CharacterMaxLength = 4000;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 13, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 14, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 40;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ExternalCauseID, 15, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ExternalCauseID;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreateByUserID, 16, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.CreateByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreateDateTime, 17, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.CreateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public EpisodeDiagnoseMetadata Meta()
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
            public const string SequenceNo = "SequenceNo";
            public const string DiagnoseID = "DiagnoseID";
            public const string SRDiagnoseType = "SRDiagnoseType";
            public const string DiagnosisText = "DiagnosisText";
            public const string MorphologyID = "MorphologyID";
            public const string ParamedicID = "ParamedicID";
            public const string IsAcuteDisease = "IsAcuteDisease";
            public const string IsChronicDisease = "IsChronicDisease";
            public const string IsOldCase = "IsOldCase";
            public const string IsConfirmed = "IsConfirmed";
            public const string IsVoid = "IsVoid";
            public const string Notes = "Notes";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string ExternalCauseID = "ExternalCauseID";
            public const string CreateByUserID = "CreateByUserID";
            public const string CreateDateTime = "CreateDateTime";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string RegistrationNo = "RegistrationNo";
            public const string SequenceNo = "SequenceNo";
            public const string DiagnoseID = "DiagnoseID";
            public const string SRDiagnoseType = "SRDiagnoseType";
            public const string DiagnosisText = "DiagnosisText";
            public const string MorphologyID = "MorphologyID";
            public const string ParamedicID = "ParamedicID";
            public const string IsAcuteDisease = "IsAcuteDisease";
            public const string IsChronicDisease = "IsChronicDisease";
            public const string IsOldCase = "IsOldCase";
            public const string IsConfirmed = "IsConfirmed";
            public const string IsVoid = "IsVoid";
            public const string Notes = "Notes";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string ExternalCauseID = "ExternalCauseID";
            public const string CreateByUserID = "CreateByUserID";
            public const string CreateDateTime = "CreateDateTime";
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
            lock (typeof(EpisodeDiagnoseMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new EpisodeDiagnoseMetadata();
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
                meta.AddTypeMap("SequenceNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("DiagnoseID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRDiagnoseType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("DiagnosisText", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("MorphologyID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ParamedicID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsAcuteDisease", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsChronicDisease", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsOldCase", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsConfirmed", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsVoid", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("Notes", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ExternalCauseID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CreateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CreateDateTime", new esTypeMap("datetime", "System.DateTime"));



                meta.Source = "EpisodeDiagnose";
                meta.Destination = "EpisodeDiagnose";

                meta.spInsert = "proc_EpisodeDiagnoseInsert";
                meta.spUpdate = "proc_EpisodeDiagnoseUpdate";
                meta.spDelete = "proc_EpisodeDiagnoseDelete";
                meta.spLoadAll = "proc_EpisodeDiagnoseLoadAll";
                meta.spLoadByPrimaryKey = "proc_EpisodeDiagnoseLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private EpisodeDiagnoseMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
