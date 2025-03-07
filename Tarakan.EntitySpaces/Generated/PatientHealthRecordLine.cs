
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 2/12/2025 10:26:30 AM
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
    /// Encapsulates the 'PatientHealthRecordLine' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(PatientHealthRecordLine))]
    [XmlType("PatientHealthRecordLine")]
    public partial class PatientHealthRecordLine : esPatientHealthRecordLine
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new PatientHealthRecordLine();
        }

        #region Static Quick Access Methods
        static public void Delete(string questionFormID, string questionGroupID, string questionID, string registrationNo, string transactionNo)
        {
            var obj = new PatientHealthRecordLine();
            obj.QuestionFormID = questionFormID;
            obj.QuestionGroupID = questionGroupID;
            obj.QuestionID = questionID;
            obj.RegistrationNo = registrationNo;
            obj.TransactionNo = transactionNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string questionFormID, string questionGroupID, string questionID, string registrationNo, string transactionNo, esSqlAccessType sqlAccessType)
        {
            var obj = new PatientHealthRecordLine();
            obj.QuestionFormID = questionFormID;
            obj.QuestionGroupID = questionGroupID;
            obj.QuestionID = questionID;
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
    [XmlType("PatientHealthRecordLineCollection")]
    public partial class PatientHealthRecordLineCollection : esPatientHealthRecordLineCollection, IEnumerable<PatientHealthRecordLine>
    {
        public PatientHealthRecordLine FindByPrimaryKey(string questionFormID, string questionGroupID, string questionID, string registrationNo, string transactionNo)
        {
            return this.SingleOrDefault(e => e.QuestionFormID == questionFormID && e.QuestionGroupID == questionGroupID && e.QuestionID == questionID && e.RegistrationNo == registrationNo && e.TransactionNo == transactionNo);
        }



    }



    [Serializable]
    public partial class PatientHealthRecordLineQuery : esPatientHealthRecordLineQuery
    {
        public PatientHealthRecordLineQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public PatientHealthRecordLineQuery(string joinAlias, out PatientHealthRecordLineQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "PatientHealthRecordLineQuery";
        }



        #region Explicit Casts

        public static explicit operator string(PatientHealthRecordLineQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator PatientHealthRecordLineQuery(string query)
        {
            return (PatientHealthRecordLineQuery)SerializeHelper.FromXml(query, typeof(PatientHealthRecordLineQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esPatientHealthRecordLine : esEntity
    {
        public esPatientHealthRecordLine()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string questionFormID, string questionGroupID, string questionID, string registrationNo, string transactionNo)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(questionFormID, questionGroupID, questionID, registrationNo, transactionNo);
            else
                return LoadByPrimaryKeyStoredProcedure(questionFormID, questionGroupID, questionID, registrationNo, transactionNo);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string questionFormID, string questionGroupID, string questionID, string registrationNo, string transactionNo)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(questionFormID, questionGroupID, questionID, registrationNo, transactionNo);
            else
                return LoadByPrimaryKeyStoredProcedure(questionFormID, questionGroupID, questionID, registrationNo, transactionNo);
        }

        private bool LoadByPrimaryKeyDynamic(string questionFormID, string questionGroupID, string questionID, string registrationNo, string transactionNo)
        {
            PatientHealthRecordLineQuery query = new PatientHealthRecordLineQuery("phrlQ");
            query.Where(query.QuestionFormID == questionFormID, query.QuestionGroupID == questionGroupID, query.QuestionID == questionID, query.RegistrationNo == registrationNo, query.TransactionNo == transactionNo);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string questionFormID, string questionGroupID, string questionID, string registrationNo, string transactionNo)
        {
            esParameters parms = new esParameters();
            parms.Add("QuestionFormID", questionFormID); parms.Add("QuestionGroupID", questionGroupID); parms.Add("QuestionID", questionID); parms.Add("RegistrationNo", registrationNo); parms.Add("TransactionNo", transactionNo);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to PatientHealthRecordLine.TransactionNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TransactionNo
        {
            get
            {
                return GetSystemString(PatientHealthRecordLineMetadata.ColumnNames.TransactionNo);
            }

            set
            {
                if (SetSystemString(PatientHealthRecordLineMetadata.ColumnNames.TransactionNo, value))
                {
                    OnPropertyChanged(PatientHealthRecordLineMetadata.PropertyNames.TransactionNo);
                }
            }
        }

        /// <summary>
        /// Maps to PatientHealthRecordLine.RegistrationNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RegistrationNo
        {
            get
            {
                return GetSystemString(PatientHealthRecordLineMetadata.ColumnNames.RegistrationNo);
            }

            set
            {
                if (SetSystemString(PatientHealthRecordLineMetadata.ColumnNames.RegistrationNo, value))
                {
                    OnPropertyChanged(PatientHealthRecordLineMetadata.PropertyNames.RegistrationNo);
                }
            }
        }

        /// <summary>
        /// Maps to PatientHealthRecordLine.QuestionFormID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string QuestionFormID
        {
            get
            {
                return GetSystemString(PatientHealthRecordLineMetadata.ColumnNames.QuestionFormID);
            }

            set
            {
                if (SetSystemString(PatientHealthRecordLineMetadata.ColumnNames.QuestionFormID, value))
                {
                    OnPropertyChanged(PatientHealthRecordLineMetadata.PropertyNames.QuestionFormID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientHealthRecordLine.QuestionGroupID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string QuestionGroupID
        {
            get
            {
                return GetSystemString(PatientHealthRecordLineMetadata.ColumnNames.QuestionGroupID);
            }

            set
            {
                if (SetSystemString(PatientHealthRecordLineMetadata.ColumnNames.QuestionGroupID, value))
                {
                    OnPropertyChanged(PatientHealthRecordLineMetadata.PropertyNames.QuestionGroupID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientHealthRecordLine.QuestionID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string QuestionID
        {
            get
            {
                return GetSystemString(PatientHealthRecordLineMetadata.ColumnNames.QuestionID);
            }

            set
            {
                if (SetSystemString(PatientHealthRecordLineMetadata.ColumnNames.QuestionID, value))
                {
                    OnPropertyChanged(PatientHealthRecordLineMetadata.PropertyNames.QuestionID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientHealthRecordLine.QuestionAnswerPrefix
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string QuestionAnswerPrefix
        {
            get
            {
                return GetSystemString(PatientHealthRecordLineMetadata.ColumnNames.QuestionAnswerPrefix);
            }

            set
            {
                if (SetSystemString(PatientHealthRecordLineMetadata.ColumnNames.QuestionAnswerPrefix, value))
                {
                    OnPropertyChanged(PatientHealthRecordLineMetadata.PropertyNames.QuestionAnswerPrefix);
                }
            }
        }

        /// <summary>
        /// Maps to PatientHealthRecordLine.QuestionAnswerSuffix
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string QuestionAnswerSuffix
        {
            get
            {
                return GetSystemString(PatientHealthRecordLineMetadata.ColumnNames.QuestionAnswerSuffix);
            }

            set
            {
                if (SetSystemString(PatientHealthRecordLineMetadata.ColumnNames.QuestionAnswerSuffix, value))
                {
                    OnPropertyChanged(PatientHealthRecordLineMetadata.PropertyNames.QuestionAnswerSuffix);
                }
            }
        }

        /// <summary>
        /// Maps to PatientHealthRecordLine.QuestionAnswerSelectionLineID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string QuestionAnswerSelectionLineID
        {
            get
            {
                return GetSystemString(PatientHealthRecordLineMetadata.ColumnNames.QuestionAnswerSelectionLineID);
            }

            set
            {
                if (SetSystemString(PatientHealthRecordLineMetadata.ColumnNames.QuestionAnswerSelectionLineID, value))
                {
                    OnPropertyChanged(PatientHealthRecordLineMetadata.PropertyNames.QuestionAnswerSelectionLineID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientHealthRecordLine.QuestionAnswerText
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string QuestionAnswerText
        {
            get
            {
                return GetSystemString(PatientHealthRecordLineMetadata.ColumnNames.QuestionAnswerText);
            }

            set
            {
                if (SetSystemString(PatientHealthRecordLineMetadata.ColumnNames.QuestionAnswerText, value))
                {
                    OnPropertyChanged(PatientHealthRecordLineMetadata.PropertyNames.QuestionAnswerText);
                }
            }
        }

        /// <summary>
        /// Maps to PatientHealthRecordLine.QuestionAnswerNum
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? QuestionAnswerNum
        {
            get
            {
                return GetSystemDecimal(PatientHealthRecordLineMetadata.ColumnNames.QuestionAnswerNum);
            }

            set
            {
                if (SetSystemDecimal(PatientHealthRecordLineMetadata.ColumnNames.QuestionAnswerNum, value))
                {
                    OnPropertyChanged(PatientHealthRecordLineMetadata.PropertyNames.QuestionAnswerNum);
                }
            }
        }

        /// <summary>
        /// Maps to PatientHealthRecordLine.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(PatientHealthRecordLineMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(PatientHealthRecordLineMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(PatientHealthRecordLineMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to PatientHealthRecordLine.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(PatientHealthRecordLineMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(PatientHealthRecordLineMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(PatientHealthRecordLineMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientHealthRecordLine.QuestionAnswerText2
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string QuestionAnswerText2
        {
            get
            {
                return GetSystemString(PatientHealthRecordLineMetadata.ColumnNames.QuestionAnswerText2);
            }

            set
            {
                if (SetSystemString(PatientHealthRecordLineMetadata.ColumnNames.QuestionAnswerText2, value))
                {
                    OnPropertyChanged(PatientHealthRecordLineMetadata.PropertyNames.QuestionAnswerText2);
                }
            }
        }

        /// <summary>
        /// Maps to PatientHealthRecordLine.BodyImage
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public byte[] BodyImage
        {
            get
            {
                return GetSystemByteArray(PatientHealthRecordLineMetadata.ColumnNames.BodyImage);
            }

            set
            {
                if (SetSystemByteArray(PatientHealthRecordLineMetadata.ColumnNames.BodyImage, value))
                {
                    OnPropertyChanged(PatientHealthRecordLineMetadata.PropertyNames.BodyImage);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return PatientHealthRecordLineMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public PatientHealthRecordLineQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new PatientHealthRecordLineQuery("phrlQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(PatientHealthRecordLineQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(PatientHealthRecordLineQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((PatientHealthRecordLineQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private PatientHealthRecordLineQuery query;
    }



    [Serializable]
    abstract public partial class esPatientHealthRecordLineCollection : esEntityCollection<PatientHealthRecordLine>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return PatientHealthRecordLineMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "PatientHealthRecordLineCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public PatientHealthRecordLineQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new PatientHealthRecordLineQuery("phrlQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(PatientHealthRecordLineQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new PatientHealthRecordLineQuery("phrlQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(PatientHealthRecordLineQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((PatientHealthRecordLineQuery)query);
        }

        #endregion

        private PatientHealthRecordLineQuery query;
    }



    [Serializable]
    abstract public partial class esPatientHealthRecordLineQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return PatientHealthRecordLineMetadata.Meta();
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
                case "QuestionGroupID": return QuestionGroupID;
                case "QuestionID": return QuestionID;
                case "QuestionAnswerPrefix": return QuestionAnswerPrefix;
                case "QuestionAnswerSuffix": return QuestionAnswerSuffix;
                case "QuestionAnswerSelectionLineID": return QuestionAnswerSelectionLineID;
                case "QuestionAnswerText": return QuestionAnswerText;
                case "QuestionAnswerNum": return QuestionAnswerNum;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "QuestionAnswerText2": return QuestionAnswerText2;
                case "BodyImage": return BodyImage;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem TransactionNo
        {
            get { return new esQueryItem(this, PatientHealthRecordLineMetadata.ColumnNames.TransactionNo, esSystemType.String); }
        }

        public esQueryItem RegistrationNo
        {
            get { return new esQueryItem(this, PatientHealthRecordLineMetadata.ColumnNames.RegistrationNo, esSystemType.String); }
        }

        public esQueryItem QuestionFormID
        {
            get { return new esQueryItem(this, PatientHealthRecordLineMetadata.ColumnNames.QuestionFormID, esSystemType.String); }
        }

        public esQueryItem QuestionGroupID
        {
            get { return new esQueryItem(this, PatientHealthRecordLineMetadata.ColumnNames.QuestionGroupID, esSystemType.String); }
        }

        public esQueryItem QuestionID
        {
            get { return new esQueryItem(this, PatientHealthRecordLineMetadata.ColumnNames.QuestionID, esSystemType.String); }
        }

        public esQueryItem QuestionAnswerPrefix
        {
            get { return new esQueryItem(this, PatientHealthRecordLineMetadata.ColumnNames.QuestionAnswerPrefix, esSystemType.String); }
        }

        public esQueryItem QuestionAnswerSuffix
        {
            get { return new esQueryItem(this, PatientHealthRecordLineMetadata.ColumnNames.QuestionAnswerSuffix, esSystemType.String); }
        }

        public esQueryItem QuestionAnswerSelectionLineID
        {
            get { return new esQueryItem(this, PatientHealthRecordLineMetadata.ColumnNames.QuestionAnswerSelectionLineID, esSystemType.String); }
        }

        public esQueryItem QuestionAnswerText
        {
            get { return new esQueryItem(this, PatientHealthRecordLineMetadata.ColumnNames.QuestionAnswerText, esSystemType.String); }
        }

        public esQueryItem QuestionAnswerNum
        {
            get { return new esQueryItem(this, PatientHealthRecordLineMetadata.ColumnNames.QuestionAnswerNum, esSystemType.Decimal); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, PatientHealthRecordLineMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, PatientHealthRecordLineMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem QuestionAnswerText2
        {
            get { return new esQueryItem(this, PatientHealthRecordLineMetadata.ColumnNames.QuestionAnswerText2, esSystemType.String); }
        }

        public esQueryItem BodyImage
        {
            get { return new esQueryItem(this, PatientHealthRecordLineMetadata.ColumnNames.BodyImage, esSystemType.ByteArray); }
        }

        #endregion

    }



    [Serializable]
    public partial class PatientHealthRecordLineMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected PatientHealthRecordLineMetadata()
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
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.QuestionFormID, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.QuestionFormID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('000')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.QuestionGroupID, 3, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.QuestionGroupID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.QuestionID, 4, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.QuestionID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.QuestionAnswerPrefix, 5, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.QuestionAnswerPrefix;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.QuestionAnswerSuffix, 6, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.QuestionAnswerSuffix;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.QuestionAnswerSelectionLineID, 7, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.QuestionAnswerSelectionLineID;
            c.CharacterMaxLength = 100;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.QuestionAnswerText, 8, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.QuestionAnswerText;
            c.CharacterMaxLength = 2147483647;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.QuestionAnswerNum, 9, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.QuestionAnswerNum;
            c.NumericPrecision = 18;
            c.NumericScale = 4;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 10, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 11, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 40;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.QuestionAnswerText2, 12, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.QuestionAnswerText2;
            c.CharacterMaxLength = 2147483647;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.BodyImage, 13, typeof(byte[]), esSystemType.ByteArray);
            c.PropertyName = PropertyNames.BodyImage;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public PatientHealthRecordLineMetadata Meta()
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
            public const string QuestionGroupID = "QuestionGroupID";
            public const string QuestionID = "QuestionID";
            public const string QuestionAnswerPrefix = "QuestionAnswerPrefix";
            public const string QuestionAnswerSuffix = "QuestionAnswerSuffix";
            public const string QuestionAnswerSelectionLineID = "QuestionAnswerSelectionLineID";
            public const string QuestionAnswerText = "QuestionAnswerText";
            public const string QuestionAnswerNum = "QuestionAnswerNum";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string QuestionAnswerText2 = "QuestionAnswerText2";
            public const string BodyImage = "BodyImage";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string TransactionNo = "TransactionNo";
            public const string RegistrationNo = "RegistrationNo";
            public const string QuestionFormID = "QuestionFormID";
            public const string QuestionGroupID = "QuestionGroupID";
            public const string QuestionID = "QuestionID";
            public const string QuestionAnswerPrefix = "QuestionAnswerPrefix";
            public const string QuestionAnswerSuffix = "QuestionAnswerSuffix";
            public const string QuestionAnswerSelectionLineID = "QuestionAnswerSelectionLineID";
            public const string QuestionAnswerText = "QuestionAnswerText";
            public const string QuestionAnswerNum = "QuestionAnswerNum";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string QuestionAnswerText2 = "QuestionAnswerText2";
            public const string BodyImage = "BodyImage";
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
            lock (typeof(PatientHealthRecordLineMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new PatientHealthRecordLineMetadata();
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
                meta.AddTypeMap("QuestionGroupID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("QuestionID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("QuestionAnswerPrefix", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("QuestionAnswerSuffix", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("QuestionAnswerSelectionLineID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("QuestionAnswerText", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("QuestionAnswerNum", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("QuestionAnswerText2", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("BodyImage", new esTypeMap("image", "System.Byte[]"));



                meta.Source = "PatientHealthRecordLine";
                meta.Destination = "PatientHealthRecordLine";

                meta.spInsert = "proc_PatientHealthRecordLineInsert";
                meta.spUpdate = "proc_PatientHealthRecordLineUpdate";
                meta.spDelete = "proc_PatientHealthRecordLineDelete";
                meta.spLoadAll = "proc_PatientHealthRecordLineLoadAll";
                meta.spLoadByPrimaryKey = "proc_PatientHealthRecordLineLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private PatientHealthRecordLineMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
