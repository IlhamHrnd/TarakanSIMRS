
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 2/14/2025 3:18:33 PM
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
    /// Encapsulates the 'TestResult' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(TestResult))]
    [XmlType("TestResult")]
    public partial class TestResult : esTestResult
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new TestResult();
        }

        #region Static Quick Access Methods
        static public void Delete(string itemID, string transactionNo)
        {
            var obj = new TestResult();
            obj.ItemID = itemID;
            obj.TransactionNo = transactionNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string itemID, string transactionNo, esSqlAccessType sqlAccessType)
        {
            var obj = new TestResult();
            obj.ItemID = itemID;
            obj.TransactionNo = transactionNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("TestResultCollection")]
    public partial class TestResultCollection : esTestResultCollection, IEnumerable<TestResult>
    {
        public TestResult FindByPrimaryKey(string itemID, string transactionNo)
        {
            return this.SingleOrDefault(e => e.ItemID == itemID && e.TransactionNo == transactionNo);
        }



    }



    [Serializable]
    public partial class TestResultQuery : esTestResultQuery
    {
        public TestResultQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public TestResultQuery(string joinAlias, out TestResultQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "TestResultQuery";
        }



        #region Explicit Casts

        public static explicit operator string(TestResultQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator TestResultQuery(string query)
        {
            return (TestResultQuery)SerializeHelper.FromXml(query, typeof(TestResultQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esTestResult : esEntity
    {
        public esTestResult()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string itemID, string transactionNo)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(itemID, transactionNo);
            else
                return LoadByPrimaryKeyStoredProcedure(itemID, transactionNo);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string itemID, string transactionNo)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(itemID, transactionNo);
            else
                return LoadByPrimaryKeyStoredProcedure(itemID, transactionNo);
        }

        private bool LoadByPrimaryKeyDynamic(string itemID, string transactionNo)
        {
            TestResultQuery query = new TestResultQuery("trQ");
            query.Where(query.ItemID == itemID, query.TransactionNo == transactionNo);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string itemID, string transactionNo)
        {
            esParameters parms = new esParameters();
            parms.Add("ItemID", itemID); parms.Add("TransactionNo", transactionNo);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to TestResult.TransactionNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TransactionNo
        {
            get
            {
                return GetSystemString(TestResultMetadata.ColumnNames.TransactionNo);
            }

            set
            {
                if (SetSystemString(TestResultMetadata.ColumnNames.TransactionNo, value))
                {
                    OnPropertyChanged(TestResultMetadata.PropertyNames.TransactionNo);
                }
            }
        }

        /// <summary>
        /// Maps to TestResult.ItemID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ItemID
        {
            get
            {
                return GetSystemString(TestResultMetadata.ColumnNames.ItemID);
            }

            set
            {
                if (SetSystemString(TestResultMetadata.ColumnNames.ItemID, value))
                {
                    OnPropertyChanged(TestResultMetadata.PropertyNames.ItemID);
                }
            }
        }

        /// <summary>
        /// Maps to TestResult.ParamedicID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParamedicID
        {
            get
            {
                return GetSystemString(TestResultMetadata.ColumnNames.ParamedicID);
            }

            set
            {
                if (SetSystemString(TestResultMetadata.ColumnNames.ParamedicID, value))
                {
                    OnPropertyChanged(TestResultMetadata.PropertyNames.ParamedicID);
                }
            }
        }

        /// <summary>
        /// Maps to TestResult.TestResultDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? TestResultDateTime
        {
            get
            {
                return GetSystemDateTime(TestResultMetadata.ColumnNames.TestResultDateTime);
            }

            set
            {
                if (SetSystemDateTime(TestResultMetadata.ColumnNames.TestResultDateTime, value))
                {
                    OnPropertyChanged(TestResultMetadata.PropertyNames.TestResultDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to TestResult.TestResult
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TestResult
        {
            get
            {
                return GetSystemString(TestResultMetadata.ColumnNames.TestResult);
            }

            set
            {
                if (SetSystemString(TestResultMetadata.ColumnNames.TestResult, value))
                {
                    OnPropertyChanged(TestResultMetadata.PropertyNames.TestResult);
                }
            }
        }

        /// <summary>
        /// Maps to TestResult.TestSummary
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TestSummary
        {
            get
            {
                return GetSystemString(TestResultMetadata.ColumnNames.TestSummary);
            }

            set
            {
                if (SetSystemString(TestResultMetadata.ColumnNames.TestSummary, value))
                {
                    OnPropertyChanged(TestResultMetadata.PropertyNames.TestSummary);
                }
            }
        }

        /// <summary>
        /// Maps to TestResult.TestSuggest
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TestSuggest
        {
            get
            {
                return GetSystemString(TestResultMetadata.ColumnNames.TestSuggest);
            }

            set
            {
                if (SetSystemString(TestResultMetadata.ColumnNames.TestSuggest, value))
                {
                    OnPropertyChanged(TestResultMetadata.PropertyNames.TestSuggest);
                }
            }
        }

        /// <summary>
        /// Maps to TestResult.TestResultOtherLang
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TestResultOtherLang
        {
            get
            {
                return GetSystemString(TestResultMetadata.ColumnNames.TestResultOtherLang);
            }

            set
            {
                if (SetSystemString(TestResultMetadata.ColumnNames.TestResultOtherLang, value))
                {
                    OnPropertyChanged(TestResultMetadata.PropertyNames.TestResultOtherLang);
                }
            }
        }

        /// <summary>
        /// Maps to TestResult.TestSummaryOtherLang
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TestSummaryOtherLang
        {
            get
            {
                return GetSystemString(TestResultMetadata.ColumnNames.TestSummaryOtherLang);
            }

            set
            {
                if (SetSystemString(TestResultMetadata.ColumnNames.TestSummaryOtherLang, value))
                {
                    OnPropertyChanged(TestResultMetadata.PropertyNames.TestSummaryOtherLang);
                }
            }
        }

        /// <summary>
        /// Maps to TestResult.TestSuggestOtherLang
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TestSuggestOtherLang
        {
            get
            {
                return GetSystemString(TestResultMetadata.ColumnNames.TestSuggestOtherLang);
            }

            set
            {
                if (SetSystemString(TestResultMetadata.ColumnNames.TestSuggestOtherLang, value))
                {
                    OnPropertyChanged(TestResultMetadata.PropertyNames.TestSuggestOtherLang);
                }
            }
        }

        /// <summary>
        /// Maps to TestResult.TestResultHistory
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TestResultHistory
        {
            get
            {
                return GetSystemString(TestResultMetadata.ColumnNames.TestResultHistory);
            }

            set
            {
                if (SetSystemString(TestResultMetadata.ColumnNames.TestResultHistory, value))
                {
                    OnPropertyChanged(TestResultMetadata.PropertyNames.TestResultHistory);
                }
            }
        }

        /// <summary>
        /// Maps to TestResult.TestSummaryHistory
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TestSummaryHistory
        {
            get
            {
                return GetSystemString(TestResultMetadata.ColumnNames.TestSummaryHistory);
            }

            set
            {
                if (SetSystemString(TestResultMetadata.ColumnNames.TestSummaryHistory, value))
                {
                    OnPropertyChanged(TestResultMetadata.PropertyNames.TestSummaryHistory);
                }
            }
        }

        /// <summary>
        /// Maps to TestResult.TestSuggestHistory
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TestSuggestHistory
        {
            get
            {
                return GetSystemString(TestResultMetadata.ColumnNames.TestSuggestHistory);
            }

            set
            {
                if (SetSystemString(TestResultMetadata.ColumnNames.TestSuggestHistory, value))
                {
                    OnPropertyChanged(TestResultMetadata.PropertyNames.TestSuggestHistory);
                }
            }
        }

        /// <summary>
        /// Maps to TestResult.TestResultOtherLangHistory
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TestResultOtherLangHistory
        {
            get
            {
                return GetSystemString(TestResultMetadata.ColumnNames.TestResultOtherLangHistory);
            }

            set
            {
                if (SetSystemString(TestResultMetadata.ColumnNames.TestResultOtherLangHistory, value))
                {
                    OnPropertyChanged(TestResultMetadata.PropertyNames.TestResultOtherLangHistory);
                }
            }
        }

        /// <summary>
        /// Maps to TestResult.TestSummaryOtherLangHistory
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TestSummaryOtherLangHistory
        {
            get
            {
                return GetSystemString(TestResultMetadata.ColumnNames.TestSummaryOtherLangHistory);
            }

            set
            {
                if (SetSystemString(TestResultMetadata.ColumnNames.TestSummaryOtherLangHistory, value))
                {
                    OnPropertyChanged(TestResultMetadata.PropertyNames.TestSummaryOtherLangHistory);
                }
            }
        }

        /// <summary>
        /// Maps to TestResult.TestSuggestOtherLangHistory
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TestSuggestOtherLangHistory
        {
            get
            {
                return GetSystemString(TestResultMetadata.ColumnNames.TestSuggestOtherLangHistory);
            }

            set
            {
                if (SetSystemString(TestResultMetadata.ColumnNames.TestSuggestOtherLangHistory, value))
                {
                    OnPropertyChanged(TestResultMetadata.PropertyNames.TestSuggestOtherLangHistory);
                }
            }
        }

        /// <summary>
        /// Maps to TestResult.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(TestResultMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(TestResultMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(TestResultMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to TestResult.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(TestResultMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(TestResultMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(TestResultMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to TestResult.ClinicalInfo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ClinicalInfo
        {
            get
            {
                return GetSystemString(TestResultMetadata.ColumnNames.ClinicalInfo);
            }

            set
            {
                if (SetSystemString(TestResultMetadata.ColumnNames.ClinicalInfo, value))
                {
                    OnPropertyChanged(TestResultMetadata.PropertyNames.ClinicalInfo);
                }
            }
        }

        /// <summary>
        /// Maps to TestResult.SRRadiologyCriticalResults
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRRadiologyCriticalResults
        {
            get
            {
                return GetSystemString(TestResultMetadata.ColumnNames.SRRadiologyCriticalResults);
            }

            set
            {
                if (SetSystemString(TestResultMetadata.ColumnNames.SRRadiologyCriticalResults, value))
                {
                    OnPropertyChanged(TestResultMetadata.PropertyNames.SRRadiologyCriticalResults);
                }
            }
        }

        /// <summary>
        /// Maps to TestResult.TestResultTemplateID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public long? TestResultTemplateID
        {
            get
            {
                return GetSystemInt64(TestResultMetadata.ColumnNames.TestResultTemplateID);
            }

            set
            {
                if (SetSystemInt64(TestResultMetadata.ColumnNames.TestResultTemplateID, value))
                {
                    OnPropertyChanged(TestResultMetadata.PropertyNames.TestResultTemplateID);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return TestResultMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public TestResultQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new TestResultQuery("trQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(TestResultQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(TestResultQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((TestResultQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private TestResultQuery query;
    }



    [Serializable]
    abstract public partial class esTestResultCollection : esEntityCollection<TestResult>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return TestResultMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "TestResultCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public TestResultQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new TestResultQuery("trQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(TestResultQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new TestResultQuery("trQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(TestResultQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((TestResultQuery)query);
        }

        #endregion

        private TestResultQuery query;
    }



    [Serializable]
    abstract public partial class esTestResultQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return TestResultMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "TransactionNo": return TransactionNo;
                case "ItemID": return ItemID;
                case "ParamedicID": return ParamedicID;
                case "TestResultDateTime": return TestResultDateTime;
                case "TestResult": return TestResult;
                case "TestSummary": return TestSummary;
                case "TestSuggest": return TestSuggest;
                case "TestResultOtherLang": return TestResultOtherLang;
                case "TestSummaryOtherLang": return TestSummaryOtherLang;
                case "TestSuggestOtherLang": return TestSuggestOtherLang;
                case "TestResultHistory": return TestResultHistory;
                case "TestSummaryHistory": return TestSummaryHistory;
                case "TestSuggestHistory": return TestSuggestHistory;
                case "TestResultOtherLangHistory": return TestResultOtherLangHistory;
                case "TestSummaryOtherLangHistory": return TestSummaryOtherLangHistory;
                case "TestSuggestOtherLangHistory": return TestSuggestOtherLangHistory;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "ClinicalInfo": return ClinicalInfo;
                case "SRRadiologyCriticalResults": return SRRadiologyCriticalResults;
                case "TestResultTemplateID": return TestResultTemplateID;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem TransactionNo
        {
            get { return new esQueryItem(this, TestResultMetadata.ColumnNames.TransactionNo, esSystemType.String); }
        }

        public esQueryItem ItemID
        {
            get { return new esQueryItem(this, TestResultMetadata.ColumnNames.ItemID, esSystemType.String); }
        }

        public esQueryItem ParamedicID
        {
            get { return new esQueryItem(this, TestResultMetadata.ColumnNames.ParamedicID, esSystemType.String); }
        }

        public esQueryItem TestResultDateTime
        {
            get { return new esQueryItem(this, TestResultMetadata.ColumnNames.TestResultDateTime, esSystemType.DateTime); }
        }

        public esQueryItem TestResult
        {
            get { return new esQueryItem(this, TestResultMetadata.ColumnNames.TestResult, esSystemType.String); }
        }

        public esQueryItem TestSummary
        {
            get { return new esQueryItem(this, TestResultMetadata.ColumnNames.TestSummary, esSystemType.String); }
        }

        public esQueryItem TestSuggest
        {
            get { return new esQueryItem(this, TestResultMetadata.ColumnNames.TestSuggest, esSystemType.String); }
        }

        public esQueryItem TestResultOtherLang
        {
            get { return new esQueryItem(this, TestResultMetadata.ColumnNames.TestResultOtherLang, esSystemType.String); }
        }

        public esQueryItem TestSummaryOtherLang
        {
            get { return new esQueryItem(this, TestResultMetadata.ColumnNames.TestSummaryOtherLang, esSystemType.String); }
        }

        public esQueryItem TestSuggestOtherLang
        {
            get { return new esQueryItem(this, TestResultMetadata.ColumnNames.TestSuggestOtherLang, esSystemType.String); }
        }

        public esQueryItem TestResultHistory
        {
            get { return new esQueryItem(this, TestResultMetadata.ColumnNames.TestResultHistory, esSystemType.String); }
        }

        public esQueryItem TestSummaryHistory
        {
            get { return new esQueryItem(this, TestResultMetadata.ColumnNames.TestSummaryHistory, esSystemType.String); }
        }

        public esQueryItem TestSuggestHistory
        {
            get { return new esQueryItem(this, TestResultMetadata.ColumnNames.TestSuggestHistory, esSystemType.String); }
        }

        public esQueryItem TestResultOtherLangHistory
        {
            get { return new esQueryItem(this, TestResultMetadata.ColumnNames.TestResultOtherLangHistory, esSystemType.String); }
        }

        public esQueryItem TestSummaryOtherLangHistory
        {
            get { return new esQueryItem(this, TestResultMetadata.ColumnNames.TestSummaryOtherLangHistory, esSystemType.String); }
        }

        public esQueryItem TestSuggestOtherLangHistory
        {
            get { return new esQueryItem(this, TestResultMetadata.ColumnNames.TestSuggestOtherLangHistory, esSystemType.String); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, TestResultMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, TestResultMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem ClinicalInfo
        {
            get { return new esQueryItem(this, TestResultMetadata.ColumnNames.ClinicalInfo, esSystemType.String); }
        }

        public esQueryItem SRRadiologyCriticalResults
        {
            get { return new esQueryItem(this, TestResultMetadata.ColumnNames.SRRadiologyCriticalResults, esSystemType.String); }
        }

        public esQueryItem TestResultTemplateID
        {
            get { return new esQueryItem(this, TestResultMetadata.ColumnNames.TestResultTemplateID, esSystemType.Int64); }
        }

        #endregion

    }



    [Serializable]
    public partial class TestResultMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected TestResultMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.TransactionNo, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TransactionNo;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 20;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ItemID, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ItemID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 10;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParamedicID, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParamedicID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TestResultDateTime, 3, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.TestResultDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TestResult, 4, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TestResult;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TestSummary, 5, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TestSummary;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TestSuggest, 6, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TestSuggest;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TestResultOtherLang, 7, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TestResultOtherLang;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TestSummaryOtherLang, 8, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TestSummaryOtherLang;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TestSuggestOtherLang, 9, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TestSuggestOtherLang;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TestResultHistory, 10, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TestResultHistory;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TestSummaryHistory, 11, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TestSummaryHistory;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TestSuggestHistory, 12, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TestSuggestHistory;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TestResultOtherLangHistory, 13, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TestResultOtherLangHistory;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TestSummaryOtherLangHistory, 14, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TestSummaryOtherLangHistory;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TestSuggestOtherLangHistory, 15, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TestSuggestOtherLangHistory;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 16, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 17, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 40;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ClinicalInfo, 18, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ClinicalInfo;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRRadiologyCriticalResults, 19, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRRadiologyCriticalResults;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TestResultTemplateID, 20, typeof(long), esSystemType.Int64);
            c.PropertyName = PropertyNames.TestResultTemplateID;
            c.NumericPrecision = 19;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public TestResultMetadata Meta()
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
            public const string ItemID = "ItemID";
            public const string ParamedicID = "ParamedicID";
            public const string TestResultDateTime = "TestResultDateTime";
            public const string TestResult = "TestResult";
            public const string TestSummary = "TestSummary";
            public const string TestSuggest = "TestSuggest";
            public const string TestResultOtherLang = "TestResultOtherLang";
            public const string TestSummaryOtherLang = "TestSummaryOtherLang";
            public const string TestSuggestOtherLang = "TestSuggestOtherLang";
            public const string TestResultHistory = "TestResultHistory";
            public const string TestSummaryHistory = "TestSummaryHistory";
            public const string TestSuggestHistory = "TestSuggestHistory";
            public const string TestResultOtherLangHistory = "TestResultOtherLangHistory";
            public const string TestSummaryOtherLangHistory = "TestSummaryOtherLangHistory";
            public const string TestSuggestOtherLangHistory = "TestSuggestOtherLangHistory";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string ClinicalInfo = "ClinicalInfo";
            public const string SRRadiologyCriticalResults = "SRRadiologyCriticalResults";
            public const string TestResultTemplateID = "TestResultTemplateID";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string TransactionNo = "TransactionNo";
            public const string ItemID = "ItemID";
            public const string ParamedicID = "ParamedicID";
            public const string TestResultDateTime = "TestResultDateTime";
            public const string TestResult = "TestResult";
            public const string TestSummary = "TestSummary";
            public const string TestSuggest = "TestSuggest";
            public const string TestResultOtherLang = "TestResultOtherLang";
            public const string TestSummaryOtherLang = "TestSummaryOtherLang";
            public const string TestSuggestOtherLang = "TestSuggestOtherLang";
            public const string TestResultHistory = "TestResultHistory";
            public const string TestSummaryHistory = "TestSummaryHistory";
            public const string TestSuggestHistory = "TestSuggestHistory";
            public const string TestResultOtherLangHistory = "TestResultOtherLangHistory";
            public const string TestSummaryOtherLangHistory = "TestSummaryOtherLangHistory";
            public const string TestSuggestOtherLangHistory = "TestSuggestOtherLangHistory";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string ClinicalInfo = "ClinicalInfo";
            public const string SRRadiologyCriticalResults = "SRRadiologyCriticalResults";
            public const string TestResultTemplateID = "TestResultTemplateID";
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
            lock (typeof(TestResultMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new TestResultMetadata();
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
                meta.AddTypeMap("ItemID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ParamedicID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TestResultDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("TestResult", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TestSummary", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TestSuggest", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TestResultOtherLang", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TestSummaryOtherLang", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TestSuggestOtherLang", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TestResultHistory", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TestSummaryHistory", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TestSuggestHistory", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TestResultOtherLangHistory", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TestSummaryOtherLangHistory", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TestSuggestOtherLangHistory", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ClinicalInfo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRRadiologyCriticalResults", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TestResultTemplateID", new esTypeMap("bigint", "System.Int64"));



                meta.Source = "TestResult";
                meta.Destination = "TestResult";

                meta.spInsert = "proc_TestResultInsert";
                meta.spUpdate = "proc_TestResultUpdate";
                meta.spDelete = "proc_TestResultDelete";
                meta.spLoadAll = "proc_TestResultLoadAll";
                meta.spLoadByPrimaryKey = "proc_TestResultLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private TestResultMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
