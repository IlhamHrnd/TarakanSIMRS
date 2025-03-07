
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 2/12/2025 10:27:21 AM
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
    /// Encapsulates the 'PatientHealthRecord' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(PatientHealthRecord))]
    [XmlType("PatientHealthRecord")]
    public partial class PatientHealthRecord : esPatientHealthRecord
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new PatientHealthRecord();
        }

        #region Static Quick Access Methods
        static public void Delete(string questionFormID, string registrationNo, string transactionNo)
        {
            var obj = new PatientHealthRecord();
            obj.QuestionFormID = questionFormID;
            obj.RegistrationNo = registrationNo;
            obj.TransactionNo = transactionNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string questionFormID, string registrationNo, string transactionNo, esSqlAccessType sqlAccessType)
        {
            var obj = new PatientHealthRecord();
            obj.QuestionFormID = questionFormID;
            obj.RegistrationNo = registrationNo;
            obj.TransactionNo = transactionNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("PatientHealthRecordCollection")]
    public partial class PatientHealthRecordCollection : esPatientHealthRecordCollection, IEnumerable<PatientHealthRecord>
    {
        public PatientHealthRecord FindByPrimaryKey(string questionFormID, string registrationNo, string transactionNo)
        {
            return this.SingleOrDefault(e => e.QuestionFormID == questionFormID && e.RegistrationNo == registrationNo && e.TransactionNo == transactionNo);
        }



    }



    [Serializable]
    public partial class PatientHealthRecordQuery : esPatientHealthRecordQuery
    {
        public PatientHealthRecordQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public PatientHealthRecordQuery(string joinAlias, out PatientHealthRecordQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "PatientHealthRecordQuery";
        }



        #region Explicit Casts

        public static explicit operator string(PatientHealthRecordQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator PatientHealthRecordQuery(string query)
        {
            return (PatientHealthRecordQuery)SerializeHelper.FromXml(query, typeof(PatientHealthRecordQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esPatientHealthRecord : esEntity
    {
        public esPatientHealthRecord()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string questionFormID, string registrationNo, string transactionNo)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(questionFormID, registrationNo, transactionNo);
            else
                return LoadByPrimaryKeyStoredProcedure(questionFormID, registrationNo, transactionNo);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string questionFormID, string registrationNo, string transactionNo)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(questionFormID, registrationNo, transactionNo);
            else
                return LoadByPrimaryKeyStoredProcedure(questionFormID, registrationNo, transactionNo);
        }

        private bool LoadByPrimaryKeyDynamic(string questionFormID, string registrationNo, string transactionNo)
        {
            PatientHealthRecordQuery query = new PatientHealthRecordQuery("phrQ");
            query.Where(query.QuestionFormID == questionFormID, query.RegistrationNo == registrationNo, query.TransactionNo == transactionNo);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string questionFormID, string registrationNo, string transactionNo)
        {
            esParameters parms = new esParameters();
            parms.Add("QuestionFormID", questionFormID); parms.Add("RegistrationNo", registrationNo); parms.Add("TransactionNo", transactionNo);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to PatientHealthRecord.TransactionNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TransactionNo
        {
            get
            {
                return GetSystemString(PatientHealthRecordMetadata.ColumnNames.TransactionNo);
            }

            set
            {
                if (SetSystemString(PatientHealthRecordMetadata.ColumnNames.TransactionNo, value))
                {
                    OnPropertyChanged(PatientHealthRecordMetadata.PropertyNames.TransactionNo);
                }
            }
        }

        /// <summary>
        /// Maps to PatientHealthRecord.RegistrationNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RegistrationNo
        {
            get
            {
                return GetSystemString(PatientHealthRecordMetadata.ColumnNames.RegistrationNo);
            }

            set
            {
                if (SetSystemString(PatientHealthRecordMetadata.ColumnNames.RegistrationNo, value))
                {
                    OnPropertyChanged(PatientHealthRecordMetadata.PropertyNames.RegistrationNo);
                }
            }
        }

        /// <summary>
        /// Maps to PatientHealthRecord.QuestionFormID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string QuestionFormID
        {
            get
            {
                return GetSystemString(PatientHealthRecordMetadata.ColumnNames.QuestionFormID);
            }

            set
            {
                if (SetSystemString(PatientHealthRecordMetadata.ColumnNames.QuestionFormID, value))
                {
                    OnPropertyChanged(PatientHealthRecordMetadata.PropertyNames.QuestionFormID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientHealthRecord.RecordDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? RecordDate
        {
            get
            {
                return GetSystemDateTime(PatientHealthRecordMetadata.ColumnNames.RecordDate);
            }

            set
            {
                if (SetSystemDateTime(PatientHealthRecordMetadata.ColumnNames.RecordDate, value))
                {
                    OnPropertyChanged(PatientHealthRecordMetadata.PropertyNames.RecordDate);
                }
            }
        }

        /// <summary>
        /// Maps to PatientHealthRecord.RecordTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RecordTime
        {
            get
            {
                return GetSystemString(PatientHealthRecordMetadata.ColumnNames.RecordTime);
            }

            set
            {
                if (SetSystemString(PatientHealthRecordMetadata.ColumnNames.RecordTime, value))
                {
                    OnPropertyChanged(PatientHealthRecordMetadata.PropertyNames.RecordTime);
                }
            }
        }

        /// <summary>
        /// Examiner
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string EmployeeID
        {
            get
            {
                return GetSystemString(PatientHealthRecordMetadata.ColumnNames.EmployeeID);
            }

            set
            {
                if (SetSystemString(PatientHealthRecordMetadata.ColumnNames.EmployeeID, value))
                {
                    OnPropertyChanged(PatientHealthRecordMetadata.PropertyNames.EmployeeID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientHealthRecord.IsComplete
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsComplete
        {
            get
            {
                return GetSystemBoolean(PatientHealthRecordMetadata.ColumnNames.IsComplete);
            }

            set
            {
                if (SetSystemBoolean(PatientHealthRecordMetadata.ColumnNames.IsComplete, value))
                {
                    OnPropertyChanged(PatientHealthRecordMetadata.PropertyNames.IsComplete);
                }
            }
        }

        /// <summary>
        /// Maps to PatientHealthRecord.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(PatientHealthRecordMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(PatientHealthRecordMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(PatientHealthRecordMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to PatientHealthRecord.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(PatientHealthRecordMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(PatientHealthRecordMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(PatientHealthRecordMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientHealthRecord.ExaminerID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ExaminerID
        {
            get
            {
                return GetSystemString(PatientHealthRecordMetadata.ColumnNames.ExaminerID);
            }

            set
            {
                if (SetSystemString(PatientHealthRecordMetadata.ColumnNames.ExaminerID, value))
                {
                    OnPropertyChanged(PatientHealthRecordMetadata.PropertyNames.ExaminerID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientHealthRecord.CreateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string CreateByUserID
        {
            get
            {
                return GetSystemString(PatientHealthRecordMetadata.ColumnNames.CreateByUserID);
            }

            set
            {
                if (SetSystemString(PatientHealthRecordMetadata.ColumnNames.CreateByUserID, value))
                {
                    OnPropertyChanged(PatientHealthRecordMetadata.PropertyNames.CreateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientHealthRecord.CreateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? CreateDateTime
        {
            get
            {
                return GetSystemDateTime(PatientHealthRecordMetadata.ColumnNames.CreateDateTime);
            }

            set
            {
                if (SetSystemDateTime(PatientHealthRecordMetadata.ColumnNames.CreateDateTime, value))
                {
                    OnPropertyChanged(PatientHealthRecordMetadata.PropertyNames.CreateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to PatientHealthRecord.ServiceUnitID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ServiceUnitID
        {
            get
            {
                return GetSystemString(PatientHealthRecordMetadata.ColumnNames.ServiceUnitID);
            }

            set
            {
                if (SetSystemString(PatientHealthRecordMetadata.ColumnNames.ServiceUnitID, value))
                {
                    OnPropertyChanged(PatientHealthRecordMetadata.PropertyNames.ServiceUnitID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientHealthRecord.ReferenceNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ReferenceNo
        {
            get
            {
                return GetSystemString(PatientHealthRecordMetadata.ColumnNames.ReferenceNo);
            }

            set
            {
                if (SetSystemString(PatientHealthRecordMetadata.ColumnNames.ReferenceNo, value))
                {
                    OnPropertyChanged(PatientHealthRecordMetadata.PropertyNames.ReferenceNo);
                }
            }
        }

        /// <summary>
        /// Maps to PatientHealthRecord.IsApproved
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsApproved
        {
            get
            {
                return GetSystemBoolean(PatientHealthRecordMetadata.ColumnNames.IsApproved);
            }

            set
            {
                if (SetSystemBoolean(PatientHealthRecordMetadata.ColumnNames.IsApproved, value))
                {
                    OnPropertyChanged(PatientHealthRecordMetadata.PropertyNames.IsApproved);
                }
            }
        }

        /// <summary>
        /// Maps to PatientHealthRecord.ApprovedDatetime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? ApprovedDatetime
        {
            get
            {
                return GetSystemDateTime(PatientHealthRecordMetadata.ColumnNames.ApprovedDatetime);
            }

            set
            {
                if (SetSystemDateTime(PatientHealthRecordMetadata.ColumnNames.ApprovedDatetime, value))
                {
                    OnPropertyChanged(PatientHealthRecordMetadata.PropertyNames.ApprovedDatetime);
                }
            }
        }

        /// <summary>
        /// Maps to PatientHealthRecord.ApprovedByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ApprovedByUserID
        {
            get
            {
                return GetSystemString(PatientHealthRecordMetadata.ColumnNames.ApprovedByUserID);
            }

            set
            {
                if (SetSystemString(PatientHealthRecordMetadata.ColumnNames.ApprovedByUserID, value))
                {
                    OnPropertyChanged(PatientHealthRecordMetadata.PropertyNames.ApprovedByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientHealthRecord.LetterNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LetterNo
        {
            get
            {
                return GetSystemString(PatientHealthRecordMetadata.ColumnNames.LetterNo);
            }

            set
            {
                if (SetSystemString(PatientHealthRecordMetadata.ColumnNames.LetterNo, value))
                {
                    OnPropertyChanged(PatientHealthRecordMetadata.PropertyNames.LetterNo);
                }
            }
        }

        /// <summary>
        /// Maps to PatientHealthRecord.IsClaimDocument
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsClaimDocument
        {
            get
            {
                return GetSystemBoolean(PatientHealthRecordMetadata.ColumnNames.IsClaimDocument);
            }

            set
            {
                if (SetSystemBoolean(PatientHealthRecordMetadata.ColumnNames.IsClaimDocument, value))
                {
                    OnPropertyChanged(PatientHealthRecordMetadata.PropertyNames.IsClaimDocument);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return PatientHealthRecordMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public PatientHealthRecordQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new PatientHealthRecordQuery("phrQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(PatientHealthRecordQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(PatientHealthRecordQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((PatientHealthRecordQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private PatientHealthRecordQuery query;
    }



    [Serializable]
    abstract public partial class esPatientHealthRecordCollection : esEntityCollection<PatientHealthRecord>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return PatientHealthRecordMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "PatientHealthRecordCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public PatientHealthRecordQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new PatientHealthRecordQuery("phrQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(PatientHealthRecordQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new PatientHealthRecordQuery("phrQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(PatientHealthRecordQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((PatientHealthRecordQuery)query);
        }

        #endregion

        private PatientHealthRecordQuery query;
    }



    [Serializable]
    abstract public partial class esPatientHealthRecordQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return PatientHealthRecordMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "TransactionNo": return TransactionNo;
                case "RegistrationNo": return RegistrationNo;
                case "QuestionFormID": return QuestionFormID;
                case "RecordDate": return RecordDate;
                case "RecordTime": return RecordTime;
                case "EmployeeID": return EmployeeID;
                case "IsComplete": return IsComplete;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "ExaminerID": return ExaminerID;
                case "CreateByUserID": return CreateByUserID;
                case "CreateDateTime": return CreateDateTime;
                case "ServiceUnitID": return ServiceUnitID;
                case "ReferenceNo": return ReferenceNo;
                case "IsApproved": return IsApproved;
                case "ApprovedDatetime": return ApprovedDatetime;
                case "ApprovedByUserID": return ApprovedByUserID;
                case "LetterNo": return LetterNo;
                case "IsClaimDocument": return IsClaimDocument;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem TransactionNo
        {
            get { return new esQueryItem(this, PatientHealthRecordMetadata.ColumnNames.TransactionNo, esSystemType.String); }
        }

        public esQueryItem RegistrationNo
        {
            get { return new esQueryItem(this, PatientHealthRecordMetadata.ColumnNames.RegistrationNo, esSystemType.String); }
        }

        public esQueryItem QuestionFormID
        {
            get { return new esQueryItem(this, PatientHealthRecordMetadata.ColumnNames.QuestionFormID, esSystemType.String); }
        }

        public esQueryItem RecordDate
        {
            get { return new esQueryItem(this, PatientHealthRecordMetadata.ColumnNames.RecordDate, esSystemType.DateTime); }
        }

        public esQueryItem RecordTime
        {
            get { return new esQueryItem(this, PatientHealthRecordMetadata.ColumnNames.RecordTime, esSystemType.String); }
        }

        public esQueryItem EmployeeID
        {
            get { return new esQueryItem(this, PatientHealthRecordMetadata.ColumnNames.EmployeeID, esSystemType.String); }
        }

        public esQueryItem IsComplete
        {
            get { return new esQueryItem(this, PatientHealthRecordMetadata.ColumnNames.IsComplete, esSystemType.Boolean); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, PatientHealthRecordMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, PatientHealthRecordMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem ExaminerID
        {
            get { return new esQueryItem(this, PatientHealthRecordMetadata.ColumnNames.ExaminerID, esSystemType.String); }
        }

        public esQueryItem CreateByUserID
        {
            get { return new esQueryItem(this, PatientHealthRecordMetadata.ColumnNames.CreateByUserID, esSystemType.String); }
        }

        public esQueryItem CreateDateTime
        {
            get { return new esQueryItem(this, PatientHealthRecordMetadata.ColumnNames.CreateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem ServiceUnitID
        {
            get { return new esQueryItem(this, PatientHealthRecordMetadata.ColumnNames.ServiceUnitID, esSystemType.String); }
        }

        public esQueryItem ReferenceNo
        {
            get { return new esQueryItem(this, PatientHealthRecordMetadata.ColumnNames.ReferenceNo, esSystemType.String); }
        }

        public esQueryItem IsApproved
        {
            get { return new esQueryItem(this, PatientHealthRecordMetadata.ColumnNames.IsApproved, esSystemType.Boolean); }
        }

        public esQueryItem ApprovedDatetime
        {
            get { return new esQueryItem(this, PatientHealthRecordMetadata.ColumnNames.ApprovedDatetime, esSystemType.DateTime); }
        }

        public esQueryItem ApprovedByUserID
        {
            get { return new esQueryItem(this, PatientHealthRecordMetadata.ColumnNames.ApprovedByUserID, esSystemType.String); }
        }

        public esQueryItem LetterNo
        {
            get { return new esQueryItem(this, PatientHealthRecordMetadata.ColumnNames.LetterNo, esSystemType.String); }
        }

        public esQueryItem IsClaimDocument
        {
            get { return new esQueryItem(this, PatientHealthRecordMetadata.ColumnNames.IsClaimDocument, esSystemType.Boolean); }
        }

        #endregion

    }



    [Serializable]
    public partial class PatientHealthRecordMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected PatientHealthRecordMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.TransactionNo, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TransactionNo;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 20;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RegistrationNo, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RegistrationNo;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 20;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.QuestionFormID, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.QuestionFormID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('000')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RecordDate, 3, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.RecordDate;
            c.HasDefault = true;
            c.Default = @"(getdate())";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RecordTime, 4, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RecordTime;
            c.CharacterMaxLength = 5;
            c.HasDefault = true;
            c.Default = @"('00:00')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.EmployeeID, 5, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.EmployeeID;
            c.CharacterMaxLength = 15;
            c.Description = "Examiner";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsComplete, 6, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsComplete;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 7, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 8, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 40;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ExaminerID, 9, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ExaminerID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreateByUserID, 10, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.CreateByUserID;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreateDateTime, 11, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.CreateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ServiceUnitID, 12, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ServiceUnitID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ReferenceNo, 13, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ReferenceNo;
            c.CharacterMaxLength = 40;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsApproved, 14, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsApproved;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ApprovedDatetime, 15, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.ApprovedDatetime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ApprovedByUserID, 16, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ApprovedByUserID;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LetterNo, 17, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LetterNo;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsClaimDocument, 18, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsClaimDocument;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public PatientHealthRecordMetadata Meta()
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
            public const string TransactionNo = "TransactionNo";
            public const string RegistrationNo = "RegistrationNo";
            public const string QuestionFormID = "QuestionFormID";
            public const string RecordDate = "RecordDate";
            public const string RecordTime = "RecordTime";
            public const string EmployeeID = "EmployeeID";
            public const string IsComplete = "IsComplete";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string ExaminerID = "ExaminerID";
            public const string CreateByUserID = "CreateByUserID";
            public const string CreateDateTime = "CreateDateTime";
            public const string ServiceUnitID = "ServiceUnitID";
            public const string ReferenceNo = "ReferenceNo";
            public const string IsApproved = "IsApproved";
            public const string ApprovedDatetime = "ApprovedDatetime";
            public const string ApprovedByUserID = "ApprovedByUserID";
            public const string LetterNo = "LetterNo";
            public const string IsClaimDocument = "IsClaimDocument";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string TransactionNo = "TransactionNo";
            public const string RegistrationNo = "RegistrationNo";
            public const string QuestionFormID = "QuestionFormID";
            public const string RecordDate = "RecordDate";
            public const string RecordTime = "RecordTime";
            public const string EmployeeID = "EmployeeID";
            public const string IsComplete = "IsComplete";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string ExaminerID = "ExaminerID";
            public const string CreateByUserID = "CreateByUserID";
            public const string CreateDateTime = "CreateDateTime";
            public const string ServiceUnitID = "ServiceUnitID";
            public const string ReferenceNo = "ReferenceNo";
            public const string IsApproved = "IsApproved";
            public const string ApprovedDatetime = "ApprovedDatetime";
            public const string ApprovedByUserID = "ApprovedByUserID";
            public const string LetterNo = "LetterNo";
            public const string IsClaimDocument = "IsClaimDocument";
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
            lock (typeof(PatientHealthRecordMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new PatientHealthRecordMetadata();
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


                meta.AddTypeMap("TransactionNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("RegistrationNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("QuestionFormID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("RecordDate", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("RecordTime", new esTypeMap("char", "System.String"));
                meta.AddTypeMap("EmployeeID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsComplete", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ExaminerID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CreateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CreateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("ServiceUnitID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ReferenceNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsApproved", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ApprovedDatetime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("ApprovedByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LetterNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsClaimDocument", new esTypeMap("bit", "System.Boolean"));



                meta.Source = "PatientHealthRecord";
                meta.Destination = "PatientHealthRecord";

                meta.spInsert = "proc_PatientHealthRecordInsert";
                meta.spUpdate = "proc_PatientHealthRecordUpdate";
                meta.spDelete = "proc_PatientHealthRecordDelete";
                meta.spLoadAll = "proc_PatientHealthRecordLoadAll";
                meta.spLoadByPrimaryKey = "proc_PatientHealthRecordLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private PatientHealthRecordMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
