
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 2/12/2025 10:26:48 AM
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
    /// Encapsulates the 'Question' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(Question))]
    [XmlType("Question")]
    public partial class Question : esQuestion
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new Question();
        }

        #region Static Quick Access Methods
        static public void Delete(string questionID)
        {
            var obj = new Question();
            obj.QuestionID = questionID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string questionID, esSqlAccessType sqlAccessType)
        {
            var obj = new Question();
            obj.QuestionID = questionID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("QuestionCollection")]
    public partial class QuestionCollection : esQuestionCollection, IEnumerable<Question>
    {
        public Question FindByPrimaryKey(string questionID)
        {
            return this.SingleOrDefault(e => e.QuestionID == questionID);
        }



    }



    [Serializable]
    public partial class QuestionQuery : esQuestionQuery
    {
        public QuestionQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public QuestionQuery(string joinAlias, out QuestionQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "QuestionQuery";
        }



        #region Explicit Casts

        public static explicit operator string(QuestionQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator QuestionQuery(string query)
        {
            return (QuestionQuery)SerializeHelper.FromXml(query, typeof(QuestionQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esQuestion : esEntity
    {
        public esQuestion()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string questionID)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(questionID);
            else
                return LoadByPrimaryKeyStoredProcedure(questionID);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string questionID)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(questionID);
            else
                return LoadByPrimaryKeyStoredProcedure(questionID);
        }

        private bool LoadByPrimaryKeyDynamic(string questionID)
        {
            QuestionQuery query = new QuestionQuery("qQ");
            query.Where(query.QuestionID == questionID);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string questionID)
        {
            esParameters parms = new esParameters();
            parms.Add("QuestionID", questionID);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to Question.QuestionID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string QuestionID
        {
            get
            {
                return GetSystemString(QuestionMetadata.ColumnNames.QuestionID);
            }

            set
            {
                if (SetSystemString(QuestionMetadata.ColumnNames.QuestionID, value))
                {
                    OnPropertyChanged(QuestionMetadata.PropertyNames.QuestionID);
                }
            }
        }

        /// <summary>
        /// Maps to Question.ParentQuestionID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParentQuestionID
        {
            get
            {
                return GetSystemString(QuestionMetadata.ColumnNames.ParentQuestionID);
            }

            set
            {
                if (SetSystemString(QuestionMetadata.ColumnNames.ParentQuestionID, value))
                {
                    OnPropertyChanged(QuestionMetadata.PropertyNames.ParentQuestionID);
                }
            }
        }

        /// <summary>
        /// Maps to Question.IndexNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? IndexNo
        {
            get
            {
                return GetSystemInt32(QuestionMetadata.ColumnNames.IndexNo);
            }

            set
            {
                if (SetSystemInt32(QuestionMetadata.ColumnNames.IndexNo, value))
                {
                    OnPropertyChanged(QuestionMetadata.PropertyNames.IndexNo);
                }
            }
        }

        /// <summary>
        /// Maps to Question.QuestionLevel
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? QuestionLevel
        {
            get
            {
                return GetSystemInt32(QuestionMetadata.ColumnNames.QuestionLevel);
            }

            set
            {
                if (SetSystemInt32(QuestionMetadata.ColumnNames.QuestionLevel, value))
                {
                    OnPropertyChanged(QuestionMetadata.PropertyNames.QuestionLevel);
                }
            }
        }

        /// <summary>
        /// Maps to Question.QuestionText
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string QuestionText
        {
            get
            {
                return GetSystemString(QuestionMetadata.ColumnNames.QuestionText);
            }

            set
            {
                if (SetSystemString(QuestionMetadata.ColumnNames.QuestionText, value))
                {
                    OnPropertyChanged(QuestionMetadata.PropertyNames.QuestionText);
                }
            }
        }

        /// <summary>
        /// Maps to Question.QuestionShortText
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string QuestionShortText
        {
            get
            {
                return GetSystemString(QuestionMetadata.ColumnNames.QuestionShortText);
            }

            set
            {
                if (SetSystemString(QuestionMetadata.ColumnNames.QuestionShortText, value))
                {
                    OnPropertyChanged(QuestionMetadata.PropertyNames.QuestionShortText);
                }
            }
        }

        /// <summary>
        /// Maps to Question.SRAnswerType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRAnswerType
        {
            get
            {
                return GetSystemString(QuestionMetadata.ColumnNames.SRAnswerType);
            }

            set
            {
                if (SetSystemString(QuestionMetadata.ColumnNames.SRAnswerType, value))
                {
                    OnPropertyChanged(QuestionMetadata.PropertyNames.SRAnswerType);
                }
            }
        }

        /// <summary>
        /// Maps to Question.AnswerDecimalDigit
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? AnswerDecimalDigit
        {
            get
            {
                return GetSystemInt32(QuestionMetadata.ColumnNames.AnswerDecimalDigit);
            }

            set
            {
                if (SetSystemInt32(QuestionMetadata.ColumnNames.AnswerDecimalDigit, value))
                {
                    OnPropertyChanged(QuestionMetadata.PropertyNames.AnswerDecimalDigit);
                }
            }
        }

        /// <summary>
        /// Maps to Question.AnswerPrefix
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string AnswerPrefix
        {
            get
            {
                return GetSystemString(QuestionMetadata.ColumnNames.AnswerPrefix);
            }

            set
            {
                if (SetSystemString(QuestionMetadata.ColumnNames.AnswerPrefix, value))
                {
                    OnPropertyChanged(QuestionMetadata.PropertyNames.AnswerPrefix);
                }
            }
        }

        /// <summary>
        /// Maps to Question.AnswerSuffix
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string AnswerSuffix
        {
            get
            {
                return GetSystemString(QuestionMetadata.ColumnNames.AnswerSuffix);
            }

            set
            {
                if (SetSystemString(QuestionMetadata.ColumnNames.AnswerSuffix, value))
                {
                    OnPropertyChanged(QuestionMetadata.PropertyNames.AnswerSuffix);
                }
            }
        }

        /// <summary>
        /// Maps to Question.IsActive
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsActive
        {
            get
            {
                return GetSystemBoolean(QuestionMetadata.ColumnNames.IsActive);
            }

            set
            {
                if (SetSystemBoolean(QuestionMetadata.ColumnNames.IsActive, value))
                {
                    OnPropertyChanged(QuestionMetadata.PropertyNames.IsActive);
                }
            }
        }

        /// <summary>
        /// Maps to Question.AnswerWidth
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? AnswerWidth
        {
            get
            {
                return GetSystemInt32(QuestionMetadata.ColumnNames.AnswerWidth);
            }

            set
            {
                if (SetSystemInt32(QuestionMetadata.ColumnNames.AnswerWidth, value))
                {
                    OnPropertyChanged(QuestionMetadata.PropertyNames.AnswerWidth);
                }
            }
        }

        /// <summary>
        /// Maps to Question.AnswerWidth2
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? AnswerWidth2
        {
            get
            {
                return GetSystemInt32(QuestionMetadata.ColumnNames.AnswerWidth2);
            }

            set
            {
                if (SetSystemInt32(QuestionMetadata.ColumnNames.AnswerWidth2, value))
                {
                    OnPropertyChanged(QuestionMetadata.PropertyNames.AnswerWidth2);
                }
            }
        }

        /// <summary>
        /// Maps to Question.QuestionAnswerSelectionID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string QuestionAnswerSelectionID
        {
            get
            {
                return GetSystemString(QuestionMetadata.ColumnNames.QuestionAnswerSelectionID);
            }

            set
            {
                if (SetSystemString(QuestionMetadata.ColumnNames.QuestionAnswerSelectionID, value))
                {
                    OnPropertyChanged(QuestionMetadata.PropertyNames.QuestionAnswerSelectionID);
                }
            }
        }

        /// <summary>
        /// Maps to Question.QuestionAnswerDefaultSelectionID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string QuestionAnswerDefaultSelectionID
        {
            get
            {
                return GetSystemString(QuestionMetadata.ColumnNames.QuestionAnswerDefaultSelectionID);
            }

            set
            {
                if (SetSystemString(QuestionMetadata.ColumnNames.QuestionAnswerDefaultSelectionID, value))
                {
                    OnPropertyChanged(QuestionMetadata.PropertyNames.QuestionAnswerDefaultSelectionID);
                }
            }
        }

        /// <summary>
        /// Maps to Question.QuestionAnswerSelectionID2
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string QuestionAnswerSelectionID2
        {
            get
            {
                return GetSystemString(QuestionMetadata.ColumnNames.QuestionAnswerSelectionID2);
            }

            set
            {
                if (SetSystemString(QuestionMetadata.ColumnNames.QuestionAnswerSelectionID2, value))
                {
                    OnPropertyChanged(QuestionMetadata.PropertyNames.QuestionAnswerSelectionID2);
                }
            }
        }

        /// <summary>
        /// Maps to Question.QuestionAnswerDefaultSelectionID2
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string QuestionAnswerDefaultSelectionID2
        {
            get
            {
                return GetSystemString(QuestionMetadata.ColumnNames.QuestionAnswerDefaultSelectionID2);
            }

            set
            {
                if (SetSystemString(QuestionMetadata.ColumnNames.QuestionAnswerDefaultSelectionID2, value))
                {
                    OnPropertyChanged(QuestionMetadata.PropertyNames.QuestionAnswerDefaultSelectionID2);
                }
            }
        }

        /// <summary>
        /// Maps to Question.Formula
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Formula
        {
            get
            {
                return GetSystemString(QuestionMetadata.ColumnNames.Formula);
            }

            set
            {
                if (SetSystemString(QuestionMetadata.ColumnNames.Formula, value))
                {
                    OnPropertyChanged(QuestionMetadata.PropertyNames.Formula);
                }
            }
        }

        /// <summary>
        /// Maps to Question.IsAlwaysPrint
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsAlwaysPrint
        {
            get
            {
                return GetSystemBoolean(QuestionMetadata.ColumnNames.IsAlwaysPrint);
            }

            set
            {
                if (SetSystemBoolean(QuestionMetadata.ColumnNames.IsAlwaysPrint, value))
                {
                    OnPropertyChanged(QuestionMetadata.PropertyNames.IsAlwaysPrint);
                }
            }
        }

        /// <summary>
        /// Maps to Question.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(QuestionMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(QuestionMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(QuestionMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to Question.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(QuestionMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(QuestionMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(QuestionMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to Question.IsMandatory
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsMandatory
        {
            get
            {
                return GetSystemBoolean(QuestionMetadata.ColumnNames.IsMandatory);
            }

            set
            {
                if (SetSystemBoolean(QuestionMetadata.ColumnNames.IsMandatory, value))
                {
                    OnPropertyChanged(QuestionMetadata.PropertyNames.IsMandatory);
                }
            }
        }

        /// <summary>
        /// Maps to Question.ReferenceQuestionID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ReferenceQuestionID
        {
            get
            {
                return GetSystemString(QuestionMetadata.ColumnNames.ReferenceQuestionID);
            }

            set
            {
                if (SetSystemString(QuestionMetadata.ColumnNames.ReferenceQuestionID, value))
                {
                    OnPropertyChanged(QuestionMetadata.PropertyNames.ReferenceQuestionID);
                }
            }
        }

        /// <summary>
        /// Maps to Question.VitalSignID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string VitalSignID
        {
            get
            {
                return GetSystemString(QuestionMetadata.ColumnNames.VitalSignID);
            }

            set
            {
                if (SetSystemString(QuestionMetadata.ColumnNames.VitalSignID, value))
                {
                    OnPropertyChanged(QuestionMetadata.PropertyNames.VitalSignID);
                }
            }
        }

        /// <summary>
        /// Maps to Question.BodyID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string BodyID
        {
            get
            {
                return GetSystemString(QuestionMetadata.ColumnNames.BodyID);
            }

            set
            {
                if (SetSystemString(QuestionMetadata.ColumnNames.BodyID, value))
                {
                    OnPropertyChanged(QuestionMetadata.PropertyNames.BodyID);
                }
            }
        }

        /// <summary>
        /// Maps to Question.RelatedEntityName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RelatedEntityName
        {
            get
            {
                return GetSystemString(QuestionMetadata.ColumnNames.RelatedEntityName);
            }

            set
            {
                if (SetSystemString(QuestionMetadata.ColumnNames.RelatedEntityName, value))
                {
                    OnPropertyChanged(QuestionMetadata.PropertyNames.RelatedEntityName);
                }
            }
        }

        /// <summary>
        /// Maps to Question.RelatedColumnName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RelatedColumnName
        {
            get
            {
                return GetSystemString(QuestionMetadata.ColumnNames.RelatedColumnName);
            }

            set
            {
                if (SetSystemString(QuestionMetadata.ColumnNames.RelatedColumnName, value))
                {
                    OnPropertyChanged(QuestionMetadata.PropertyNames.RelatedColumnName);
                }
            }
        }

        /// <summary>
        /// Maps to Question.LookUpID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LookUpID
        {
            get
            {
                return GetSystemString(QuestionMetadata.ColumnNames.LookUpID);
            }

            set
            {
                if (SetSystemString(QuestionMetadata.ColumnNames.LookUpID, value))
                {
                    OnPropertyChanged(QuestionMetadata.PropertyNames.LookUpID);
                }
            }
        }

        /// <summary>
        /// Maps to Question.IsUpdateRelatedEntity
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsUpdateRelatedEntity
        {
            get
            {
                return GetSystemBoolean(QuestionMetadata.ColumnNames.IsUpdateRelatedEntity);
            }

            set
            {
                if (SetSystemBoolean(QuestionMetadata.ColumnNames.IsUpdateRelatedEntity, value))
                {
                    OnPropertyChanged(QuestionMetadata.PropertyNames.IsUpdateRelatedEntity);
                }
            }
        }

        /// <summary>
        /// Maps to Question.IsReadOnly
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsReadOnly
        {
            get
            {
                return GetSystemBoolean(QuestionMetadata.ColumnNames.IsReadOnly);
            }

            set
            {
                if (SetSystemBoolean(QuestionMetadata.ColumnNames.IsReadOnly, value))
                {
                    OnPropertyChanged(QuestionMetadata.PropertyNames.IsReadOnly);
                }
            }
        }

        /// <summary>
        /// Maps to Question.NursingDisplayAs
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string NursingDisplayAs
        {
            get
            {
                return GetSystemString(QuestionMetadata.ColumnNames.NursingDisplayAs);
            }

            set
            {
                if (SetSystemString(QuestionMetadata.ColumnNames.NursingDisplayAs, value))
                {
                    OnPropertyChanged(QuestionMetadata.PropertyNames.NursingDisplayAs);
                }
            }
        }

        /// <summary>
        /// Maps to Question.EquivalentQuestionID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string EquivalentQuestionID
        {
            get
            {
                return GetSystemString(QuestionMetadata.ColumnNames.EquivalentQuestionID);
            }

            set
            {
                if (SetSystemString(QuestionMetadata.ColumnNames.EquivalentQuestionID, value))
                {
                    OnPropertyChanged(QuestionMetadata.PropertyNames.EquivalentQuestionID);
                }
            }
        }

        /// <summary>
        /// Maps to Question.IsEmptyDefault
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsEmptyDefault
        {
            get
            {
                return GetSystemBoolean(QuestionMetadata.ColumnNames.IsEmptyDefault);
            }

            set
            {
                if (SetSystemBoolean(QuestionMetadata.ColumnNames.IsEmptyDefault, value))
                {
                    OnPropertyChanged(QuestionMetadata.PropertyNames.IsEmptyDefault);
                }
            }
        }

        /// <summary>
        /// Maps to Question.IsNotOverWriteRelatedEntity
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsNotOverWriteRelatedEntity
        {
            get
            {
                return GetSystemBoolean(QuestionMetadata.ColumnNames.IsNotOverWriteRelatedEntity);
            }

            set
            {
                if (SetSystemBoolean(QuestionMetadata.ColumnNames.IsNotOverWriteRelatedEntity, value))
                {
                    OnPropertyChanged(QuestionMetadata.PropertyNames.IsNotOverWriteRelatedEntity);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return QuestionMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public QuestionQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new QuestionQuery("qQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(QuestionQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(QuestionQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((QuestionQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private QuestionQuery query;
    }



    [Serializable]
    abstract public partial class esQuestionCollection : esEntityCollection<Question>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return QuestionMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "QuestionCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public QuestionQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new QuestionQuery("qQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(QuestionQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new QuestionQuery("qQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(QuestionQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((QuestionQuery)query);
        }

        #endregion

        private QuestionQuery query;
    }



    [Serializable]
    abstract public partial class esQuestionQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return QuestionMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "QuestionID": return QuestionID;
                case "ParentQuestionID": return ParentQuestionID;
                case "IndexNo": return IndexNo;
                case "QuestionLevel": return QuestionLevel;
                case "QuestionText": return QuestionText;
                case "QuestionShortText": return QuestionShortText;
                case "SRAnswerType": return SRAnswerType;
                case "AnswerDecimalDigit": return AnswerDecimalDigit;
                case "AnswerPrefix": return AnswerPrefix;
                case "AnswerSuffix": return AnswerSuffix;
                case "IsActive": return IsActive;
                case "AnswerWidth": return AnswerWidth;
                case "AnswerWidth2": return AnswerWidth2;
                case "QuestionAnswerSelectionID": return QuestionAnswerSelectionID;
                case "QuestionAnswerDefaultSelectionID": return QuestionAnswerDefaultSelectionID;
                case "QuestionAnswerSelectionID2": return QuestionAnswerSelectionID2;
                case "QuestionAnswerDefaultSelectionID2": return QuestionAnswerDefaultSelectionID2;
                case "Formula": return Formula;
                case "IsAlwaysPrint": return IsAlwaysPrint;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "IsMandatory": return IsMandatory;
                case "ReferenceQuestionID": return ReferenceQuestionID;
                case "VitalSignID": return VitalSignID;
                case "BodyID": return BodyID;
                case "RelatedEntityName": return RelatedEntityName;
                case "RelatedColumnName": return RelatedColumnName;
                case "LookUpID": return LookUpID;
                case "IsUpdateRelatedEntity": return IsUpdateRelatedEntity;
                case "IsReadOnly": return IsReadOnly;
                case "NursingDisplayAs": return NursingDisplayAs;
                case "EquivalentQuestionID": return EquivalentQuestionID;
                case "IsEmptyDefault": return IsEmptyDefault;
                case "IsNotOverWriteRelatedEntity": return IsNotOverWriteRelatedEntity;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem QuestionID
        {
            get { return new esQueryItem(this, QuestionMetadata.ColumnNames.QuestionID, esSystemType.String); }
        }

        public esQueryItem ParentQuestionID
        {
            get { return new esQueryItem(this, QuestionMetadata.ColumnNames.ParentQuestionID, esSystemType.String); }
        }

        public esQueryItem IndexNo
        {
            get { return new esQueryItem(this, QuestionMetadata.ColumnNames.IndexNo, esSystemType.Int32); }
        }

        public esQueryItem QuestionLevel
        {
            get { return new esQueryItem(this, QuestionMetadata.ColumnNames.QuestionLevel, esSystemType.Int32); }
        }

        public esQueryItem QuestionText
        {
            get { return new esQueryItem(this, QuestionMetadata.ColumnNames.QuestionText, esSystemType.String); }
        }

        public esQueryItem QuestionShortText
        {
            get { return new esQueryItem(this, QuestionMetadata.ColumnNames.QuestionShortText, esSystemType.String); }
        }

        public esQueryItem SRAnswerType
        {
            get { return new esQueryItem(this, QuestionMetadata.ColumnNames.SRAnswerType, esSystemType.String); }
        }

        public esQueryItem AnswerDecimalDigit
        {
            get { return new esQueryItem(this, QuestionMetadata.ColumnNames.AnswerDecimalDigit, esSystemType.Int32); }
        }

        public esQueryItem AnswerPrefix
        {
            get { return new esQueryItem(this, QuestionMetadata.ColumnNames.AnswerPrefix, esSystemType.String); }
        }

        public esQueryItem AnswerSuffix
        {
            get { return new esQueryItem(this, QuestionMetadata.ColumnNames.AnswerSuffix, esSystemType.String); }
        }

        public esQueryItem IsActive
        {
            get { return new esQueryItem(this, QuestionMetadata.ColumnNames.IsActive, esSystemType.Boolean); }
        }

        public esQueryItem AnswerWidth
        {
            get { return new esQueryItem(this, QuestionMetadata.ColumnNames.AnswerWidth, esSystemType.Int32); }
        }

        public esQueryItem AnswerWidth2
        {
            get { return new esQueryItem(this, QuestionMetadata.ColumnNames.AnswerWidth2, esSystemType.Int32); }
        }

        public esQueryItem QuestionAnswerSelectionID
        {
            get { return new esQueryItem(this, QuestionMetadata.ColumnNames.QuestionAnswerSelectionID, esSystemType.String); }
        }

        public esQueryItem QuestionAnswerDefaultSelectionID
        {
            get { return new esQueryItem(this, QuestionMetadata.ColumnNames.QuestionAnswerDefaultSelectionID, esSystemType.String); }
        }

        public esQueryItem QuestionAnswerSelectionID2
        {
            get { return new esQueryItem(this, QuestionMetadata.ColumnNames.QuestionAnswerSelectionID2, esSystemType.String); }
        }

        public esQueryItem QuestionAnswerDefaultSelectionID2
        {
            get { return new esQueryItem(this, QuestionMetadata.ColumnNames.QuestionAnswerDefaultSelectionID2, esSystemType.String); }
        }

        public esQueryItem Formula
        {
            get { return new esQueryItem(this, QuestionMetadata.ColumnNames.Formula, esSystemType.String); }
        }

        public esQueryItem IsAlwaysPrint
        {
            get { return new esQueryItem(this, QuestionMetadata.ColumnNames.IsAlwaysPrint, esSystemType.Boolean); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, QuestionMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, QuestionMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem IsMandatory
        {
            get { return new esQueryItem(this, QuestionMetadata.ColumnNames.IsMandatory, esSystemType.Boolean); }
        }

        public esQueryItem ReferenceQuestionID
        {
            get { return new esQueryItem(this, QuestionMetadata.ColumnNames.ReferenceQuestionID, esSystemType.String); }
        }

        public esQueryItem VitalSignID
        {
            get { return new esQueryItem(this, QuestionMetadata.ColumnNames.VitalSignID, esSystemType.String); }
        }

        public esQueryItem BodyID
        {
            get { return new esQueryItem(this, QuestionMetadata.ColumnNames.BodyID, esSystemType.String); }
        }

        public esQueryItem RelatedEntityName
        {
            get { return new esQueryItem(this, QuestionMetadata.ColumnNames.RelatedEntityName, esSystemType.String); }
        }

        public esQueryItem RelatedColumnName
        {
            get { return new esQueryItem(this, QuestionMetadata.ColumnNames.RelatedColumnName, esSystemType.String); }
        }

        public esQueryItem LookUpID
        {
            get { return new esQueryItem(this, QuestionMetadata.ColumnNames.LookUpID, esSystemType.String); }
        }

        public esQueryItem IsUpdateRelatedEntity
        {
            get { return new esQueryItem(this, QuestionMetadata.ColumnNames.IsUpdateRelatedEntity, esSystemType.Boolean); }
        }

        public esQueryItem IsReadOnly
        {
            get { return new esQueryItem(this, QuestionMetadata.ColumnNames.IsReadOnly, esSystemType.Boolean); }
        }

        public esQueryItem NursingDisplayAs
        {
            get { return new esQueryItem(this, QuestionMetadata.ColumnNames.NursingDisplayAs, esSystemType.String); }
        }

        public esQueryItem EquivalentQuestionID
        {
            get { return new esQueryItem(this, QuestionMetadata.ColumnNames.EquivalentQuestionID, esSystemType.String); }
        }

        public esQueryItem IsEmptyDefault
        {
            get { return new esQueryItem(this, QuestionMetadata.ColumnNames.IsEmptyDefault, esSystemType.Boolean); }
        }

        public esQueryItem IsNotOverWriteRelatedEntity
        {
            get { return new esQueryItem(this, QuestionMetadata.ColumnNames.IsNotOverWriteRelatedEntity, esSystemType.Boolean); }
        }

        #endregion

    }



    [Serializable]
    public partial class QuestionMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected QuestionMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.QuestionID, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.QuestionID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 10;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParentQuestionID, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParentQuestionID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IndexNo, 2, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.IndexNo;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.QuestionLevel, 3, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.QuestionLevel;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.QuestionText, 4, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.QuestionText;
            c.CharacterMaxLength = 500;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.QuestionShortText, 5, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.QuestionShortText;
            c.CharacterMaxLength = 200;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRAnswerType, 6, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRAnswerType;
            c.CharacterMaxLength = 3;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AnswerDecimalDigit, 7, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.AnswerDecimalDigit;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AnswerPrefix, 8, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.AnswerPrefix;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AnswerSuffix, 9, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.AnswerSuffix;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsActive, 10, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsActive;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AnswerWidth, 11, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.AnswerWidth;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AnswerWidth2, 12, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.AnswerWidth2;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.QuestionAnswerSelectionID, 13, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.QuestionAnswerSelectionID;
            c.CharacterMaxLength = 500;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.QuestionAnswerDefaultSelectionID, 14, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.QuestionAnswerDefaultSelectionID;
            c.CharacterMaxLength = 2000;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.QuestionAnswerSelectionID2, 15, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.QuestionAnswerSelectionID2;
            c.CharacterMaxLength = 225;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.QuestionAnswerDefaultSelectionID2, 16, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.QuestionAnswerDefaultSelectionID2;
            c.CharacterMaxLength = 225;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Formula, 17, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Formula;
            c.CharacterMaxLength = 2000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsAlwaysPrint, 18, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsAlwaysPrint;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 19, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 20, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 40;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsMandatory, 21, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsMandatory;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ReferenceQuestionID, 22, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ReferenceQuestionID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.VitalSignID, 23, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.VitalSignID;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.BodyID, 24, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.BodyID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RelatedEntityName, 25, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RelatedEntityName;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RelatedColumnName, 26, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RelatedColumnName;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LookUpID, 27, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LookUpID;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsUpdateRelatedEntity, 28, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsUpdateRelatedEntity;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsReadOnly, 29, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsReadOnly;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.NursingDisplayAs, 30, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.NursingDisplayAs;
            c.CharacterMaxLength = 500;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.EquivalentQuestionID, 31, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.EquivalentQuestionID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsEmptyDefault, 32, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsEmptyDefault;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsNotOverWriteRelatedEntity, 33, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsNotOverWriteRelatedEntity;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public QuestionMetadata Meta()
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
            public const string QuestionID = "QuestionID";
            public const string ParentQuestionID = "ParentQuestionID";
            public const string IndexNo = "IndexNo";
            public const string QuestionLevel = "QuestionLevel";
            public const string QuestionText = "QuestionText";
            public const string QuestionShortText = "QuestionShortText";
            public const string SRAnswerType = "SRAnswerType";
            public const string AnswerDecimalDigit = "AnswerDecimalDigit";
            public const string AnswerPrefix = "AnswerPrefix";
            public const string AnswerSuffix = "AnswerSuffix";
            public const string IsActive = "IsActive";
            public const string AnswerWidth = "AnswerWidth";
            public const string AnswerWidth2 = "AnswerWidth2";
            public const string QuestionAnswerSelectionID = "QuestionAnswerSelectionID";
            public const string QuestionAnswerDefaultSelectionID = "QuestionAnswerDefaultSelectionID";
            public const string QuestionAnswerSelectionID2 = "QuestionAnswerSelectionID2";
            public const string QuestionAnswerDefaultSelectionID2 = "QuestionAnswerDefaultSelectionID2";
            public const string Formula = "Formula";
            public const string IsAlwaysPrint = "IsAlwaysPrint";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string IsMandatory = "IsMandatory";
            public const string ReferenceQuestionID = "ReferenceQuestionID";
            public const string VitalSignID = "VitalSignID";
            public const string BodyID = "BodyID";
            public const string RelatedEntityName = "RelatedEntityName";
            public const string RelatedColumnName = "RelatedColumnName";
            public const string LookUpID = "LookUpID";
            public const string IsUpdateRelatedEntity = "IsUpdateRelatedEntity";
            public const string IsReadOnly = "IsReadOnly";
            public const string NursingDisplayAs = "NursingDisplayAs";
            public const string EquivalentQuestionID = "EquivalentQuestionID";
            public const string IsEmptyDefault = "IsEmptyDefault";
            public const string IsNotOverWriteRelatedEntity = "IsNotOverWriteRelatedEntity";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string QuestionID = "QuestionID";
            public const string ParentQuestionID = "ParentQuestionID";
            public const string IndexNo = "IndexNo";
            public const string QuestionLevel = "QuestionLevel";
            public const string QuestionText = "QuestionText";
            public const string QuestionShortText = "QuestionShortText";
            public const string SRAnswerType = "SRAnswerType";
            public const string AnswerDecimalDigit = "AnswerDecimalDigit";
            public const string AnswerPrefix = "AnswerPrefix";
            public const string AnswerSuffix = "AnswerSuffix";
            public const string IsActive = "IsActive";
            public const string AnswerWidth = "AnswerWidth";
            public const string AnswerWidth2 = "AnswerWidth2";
            public const string QuestionAnswerSelectionID = "QuestionAnswerSelectionID";
            public const string QuestionAnswerDefaultSelectionID = "QuestionAnswerDefaultSelectionID";
            public const string QuestionAnswerSelectionID2 = "QuestionAnswerSelectionID2";
            public const string QuestionAnswerDefaultSelectionID2 = "QuestionAnswerDefaultSelectionID2";
            public const string Formula = "Formula";
            public const string IsAlwaysPrint = "IsAlwaysPrint";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string IsMandatory = "IsMandatory";
            public const string ReferenceQuestionID = "ReferenceQuestionID";
            public const string VitalSignID = "VitalSignID";
            public const string BodyID = "BodyID";
            public const string RelatedEntityName = "RelatedEntityName";
            public const string RelatedColumnName = "RelatedColumnName";
            public const string LookUpID = "LookUpID";
            public const string IsUpdateRelatedEntity = "IsUpdateRelatedEntity";
            public const string IsReadOnly = "IsReadOnly";
            public const string NursingDisplayAs = "NursingDisplayAs";
            public const string EquivalentQuestionID = "EquivalentQuestionID";
            public const string IsEmptyDefault = "IsEmptyDefault";
            public const string IsNotOverWriteRelatedEntity = "IsNotOverWriteRelatedEntity";
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
            lock (typeof(QuestionMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new QuestionMetadata();
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


                meta.AddTypeMap("QuestionID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ParentQuestionID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IndexNo", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("QuestionLevel", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("QuestionText", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("QuestionShortText", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRAnswerType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("AnswerDecimalDigit", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("AnswerPrefix", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("AnswerSuffix", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsActive", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("AnswerWidth", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("AnswerWidth2", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("QuestionAnswerSelectionID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("QuestionAnswerDefaultSelectionID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("QuestionAnswerSelectionID2", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("QuestionAnswerDefaultSelectionID2", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Formula", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsAlwaysPrint", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsMandatory", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ReferenceQuestionID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("VitalSignID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("BodyID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("RelatedEntityName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("RelatedColumnName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LookUpID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsUpdateRelatedEntity", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsReadOnly", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("NursingDisplayAs", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("EquivalentQuestionID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsEmptyDefault", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsNotOverWriteRelatedEntity", new esTypeMap("bit", "System.Boolean"));



                meta.Source = "Question";
                meta.Destination = "Question";

                meta.spInsert = "proc_QuestionInsert";
                meta.spUpdate = "proc_QuestionUpdate";
                meta.spDelete = "proc_QuestionDelete";
                meta.spLoadAll = "proc_QuestionLoadAll";
                meta.spLoadByPrimaryKey = "proc_QuestionLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private QuestionMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
