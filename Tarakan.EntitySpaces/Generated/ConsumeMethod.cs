
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 3/17/2025 1:56:57 PM
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
    /// Encapsulates the 'ConsumeMethod' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(ConsumeMethod))]
    [XmlType("ConsumeMethod")]
    public partial class ConsumeMethod : esConsumeMethod
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new ConsumeMethod();
        }

        #region Static Quick Access Methods
        static public void Delete(string sRConsumeMethod)
        {
            var obj = new ConsumeMethod();
            obj.SRConsumeMethod = sRConsumeMethod;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string sRConsumeMethod, esSqlAccessType sqlAccessType)
        {
            var obj = new ConsumeMethod();
            obj.SRConsumeMethod = sRConsumeMethod;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("ConsumeMethodCollection")]
    public partial class ConsumeMethodCollection : esConsumeMethodCollection, IEnumerable<ConsumeMethod>
    {
        public ConsumeMethod FindByPrimaryKey(string sRConsumeMethod)
        {
            return this.SingleOrDefault(e => e.SRConsumeMethod == sRConsumeMethod);
        }



    }



    [Serializable]
    public partial class ConsumeMethodQuery : esConsumeMethodQuery
    {
        public ConsumeMethodQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public ConsumeMethodQuery(string joinAlias, out ConsumeMethodQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "ConsumeMethodQuery";
        }



        #region Explicit Casts

        public static explicit operator string(ConsumeMethodQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator ConsumeMethodQuery(string query)
        {
            return (ConsumeMethodQuery)SerializeHelper.FromXml(query, typeof(ConsumeMethodQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esConsumeMethod : esEntity
    {
        public esConsumeMethod()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string sRConsumeMethod)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(sRConsumeMethod);
            else
                return LoadByPrimaryKeyStoredProcedure(sRConsumeMethod);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string sRConsumeMethod)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(sRConsumeMethod);
            else
                return LoadByPrimaryKeyStoredProcedure(sRConsumeMethod);
        }

        private bool LoadByPrimaryKeyDynamic(string sRConsumeMethod)
        {
            ConsumeMethodQuery query = new ConsumeMethodQuery("cmQ");
            query.Where(query.SRConsumeMethod == sRConsumeMethod);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string sRConsumeMethod)
        {
            esParameters parms = new esParameters();
            parms.Add("SRConsumeMethod", sRConsumeMethod);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to ConsumeMethod.SRConsumeMethod
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRConsumeMethod
        {
            get
            {
                return GetSystemString(ConsumeMethodMetadata.ColumnNames.SRConsumeMethod);
            }

            set
            {
                if (SetSystemString(ConsumeMethodMetadata.ColumnNames.SRConsumeMethod, value))
                {
                    OnPropertyChanged(ConsumeMethodMetadata.PropertyNames.SRConsumeMethod);
                }
            }
        }

        /// <summary>
        /// Maps to ConsumeMethod.SRConsumeMethodName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRConsumeMethodName
        {
            get
            {
                return GetSystemString(ConsumeMethodMetadata.ColumnNames.SRConsumeMethodName);
            }

            set
            {
                if (SetSystemString(ConsumeMethodMetadata.ColumnNames.SRConsumeMethodName, value))
                {
                    OnPropertyChanged(ConsumeMethodMetadata.PropertyNames.SRConsumeMethodName);
                }
            }
        }

        /// <summary>
        /// Maps to ConsumeMethod.TimeSequence
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TimeSequence
        {
            get
            {
                return GetSystemString(ConsumeMethodMetadata.ColumnNames.TimeSequence);
            }

            set
            {
                if (SetSystemString(ConsumeMethodMetadata.ColumnNames.TimeSequence, value))
                {
                    OnPropertyChanged(ConsumeMethodMetadata.PropertyNames.TimeSequence);
                }
            }
        }

        /// <summary>
        /// Maps to ConsumeMethod.LastCreateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastCreateDateTime
        {
            get
            {
                return GetSystemDateTime(ConsumeMethodMetadata.ColumnNames.LastCreateDateTime);
            }

            set
            {
                if (SetSystemDateTime(ConsumeMethodMetadata.ColumnNames.LastCreateDateTime, value))
                {
                    OnPropertyChanged(ConsumeMethodMetadata.PropertyNames.LastCreateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to ConsumeMethod.LastCreateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastCreateByUserID
        {
            get
            {
                return GetSystemString(ConsumeMethodMetadata.ColumnNames.LastCreateByUserID);
            }

            set
            {
                if (SetSystemString(ConsumeMethodMetadata.ColumnNames.LastCreateByUserID, value))
                {
                    OnPropertyChanged(ConsumeMethodMetadata.PropertyNames.LastCreateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to ConsumeMethod.SygnaText
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SygnaText
        {
            get
            {
                return GetSystemString(ConsumeMethodMetadata.ColumnNames.SygnaText);
            }

            set
            {
                if (SetSystemString(ConsumeMethodMetadata.ColumnNames.SygnaText, value))
                {
                    OnPropertyChanged(ConsumeMethodMetadata.PropertyNames.SygnaText);
                }
            }
        }

        /// <summary>
        /// Maps to ConsumeMethod.IterationQty
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? IterationQty
        {
            get
            {
                return GetSystemInt32(ConsumeMethodMetadata.ColumnNames.IterationQty);
            }

            set
            {
                if (SetSystemInt32(ConsumeMethodMetadata.ColumnNames.IterationQty, value))
                {
                    OnPropertyChanged(ConsumeMethodMetadata.PropertyNames.IterationQty);
                }
            }
        }

        /// <summary>
        /// Maps to ConsumeMethod.IterationInInterval
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string IterationInInterval
        {
            get
            {
                return GetSystemString(ConsumeMethodMetadata.ColumnNames.IterationInInterval);
            }

            set
            {
                if (SetSystemString(ConsumeMethodMetadata.ColumnNames.IterationInInterval, value))
                {
                    OnPropertyChanged(ConsumeMethodMetadata.PropertyNames.IterationInInterval);
                }
            }
        }

        /// <summary>
        /// Maps to ConsumeMethod.Time01
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Time01
        {
            get
            {
                return GetSystemString(ConsumeMethodMetadata.ColumnNames.Time01);
            }

            set
            {
                if (SetSystemString(ConsumeMethodMetadata.ColumnNames.Time01, value))
                {
                    OnPropertyChanged(ConsumeMethodMetadata.PropertyNames.Time01);
                }
            }
        }

        /// <summary>
        /// Maps to ConsumeMethod.Time02
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Time02
        {
            get
            {
                return GetSystemString(ConsumeMethodMetadata.ColumnNames.Time02);
            }

            set
            {
                if (SetSystemString(ConsumeMethodMetadata.ColumnNames.Time02, value))
                {
                    OnPropertyChanged(ConsumeMethodMetadata.PropertyNames.Time02);
                }
            }
        }

        /// <summary>
        /// Maps to ConsumeMethod.Time03
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Time03
        {
            get
            {
                return GetSystemString(ConsumeMethodMetadata.ColumnNames.Time03);
            }

            set
            {
                if (SetSystemString(ConsumeMethodMetadata.ColumnNames.Time03, value))
                {
                    OnPropertyChanged(ConsumeMethodMetadata.PropertyNames.Time03);
                }
            }
        }

        /// <summary>
        /// Maps to ConsumeMethod.Time04
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Time04
        {
            get
            {
                return GetSystemString(ConsumeMethodMetadata.ColumnNames.Time04);
            }

            set
            {
                if (SetSystemString(ConsumeMethodMetadata.ColumnNames.Time04, value))
                {
                    OnPropertyChanged(ConsumeMethodMetadata.PropertyNames.Time04);
                }
            }
        }

        /// <summary>
        /// Maps to ConsumeMethod.Time05
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Time05
        {
            get
            {
                return GetSystemString(ConsumeMethodMetadata.ColumnNames.Time05);
            }

            set
            {
                if (SetSystemString(ConsumeMethodMetadata.ColumnNames.Time05, value))
                {
                    OnPropertyChanged(ConsumeMethodMetadata.PropertyNames.Time05);
                }
            }
        }

        /// <summary>
        /// Maps to ConsumeMethod.Time06
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Time06
        {
            get
            {
                return GetSystemString(ConsumeMethodMetadata.ColumnNames.Time06);
            }

            set
            {
                if (SetSystemString(ConsumeMethodMetadata.ColumnNames.Time06, value))
                {
                    OnPropertyChanged(ConsumeMethodMetadata.PropertyNames.Time06);
                }
            }
        }

        /// <summary>
        /// Maps to ConsumeMethod.Time07
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Time07
        {
            get
            {
                return GetSystemString(ConsumeMethodMetadata.ColumnNames.Time07);
            }

            set
            {
                if (SetSystemString(ConsumeMethodMetadata.ColumnNames.Time07, value))
                {
                    OnPropertyChanged(ConsumeMethodMetadata.PropertyNames.Time07);
                }
            }
        }

        /// <summary>
        /// Maps to ConsumeMethod.Time08
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Time08
        {
            get
            {
                return GetSystemString(ConsumeMethodMetadata.ColumnNames.Time08);
            }

            set
            {
                if (SetSystemString(ConsumeMethodMetadata.ColumnNames.Time08, value))
                {
                    OnPropertyChanged(ConsumeMethodMetadata.PropertyNames.Time08);
                }
            }
        }

        /// <summary>
        /// Maps to ConsumeMethod.Time09
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Time09
        {
            get
            {
                return GetSystemString(ConsumeMethodMetadata.ColumnNames.Time09);
            }

            set
            {
                if (SetSystemString(ConsumeMethodMetadata.ColumnNames.Time09, value))
                {
                    OnPropertyChanged(ConsumeMethodMetadata.PropertyNames.Time09);
                }
            }
        }

        /// <summary>
        /// Maps to ConsumeMethod.Time10
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Time10
        {
            get
            {
                return GetSystemString(ConsumeMethodMetadata.ColumnNames.Time10);
            }

            set
            {
                if (SetSystemString(ConsumeMethodMetadata.ColumnNames.Time10, value))
                {
                    OnPropertyChanged(ConsumeMethodMetadata.PropertyNames.Time10);
                }
            }
        }

        /// <summary>
        /// Maps to ConsumeMethod.IsActive
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsActive
        {
            get
            {
                return GetSystemBoolean(ConsumeMethodMetadata.ColumnNames.IsActive);
            }

            set
            {
                if (SetSystemBoolean(ConsumeMethodMetadata.ColumnNames.IsActive, value))
                {
                    OnPropertyChanged(ConsumeMethodMetadata.PropertyNames.IsActive);
                }
            }
        }

        /// <summary>
        /// Maps to ConsumeMethod.LineNumber
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? LineNumber
        {
            get
            {
                return GetSystemInt32(ConsumeMethodMetadata.ColumnNames.LineNumber);
            }

            set
            {
                if (SetSystemInt32(ConsumeMethodMetadata.ColumnNames.LineNumber, value))
                {
                    OnPropertyChanged(ConsumeMethodMetadata.PropertyNames.LineNumber);
                }
            }
        }

        /// <summary>
        /// Maps to ConsumeMethod.frequency_satset
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? FrequencySatset
        {
            get
            {
                return GetSystemInt32(ConsumeMethodMetadata.ColumnNames.FrequencySatset);
            }

            set
            {
                if (SetSystemInt32(ConsumeMethodMetadata.ColumnNames.FrequencySatset, value))
                {
                    OnPropertyChanged(ConsumeMethodMetadata.PropertyNames.FrequencySatset);
                }
            }
        }

        /// <summary>
        /// Maps to ConsumeMethod.periodUnit
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PeriodUnit
        {
            get
            {
                return GetSystemString(ConsumeMethodMetadata.ColumnNames.PeriodUnit);
            }

            set
            {
                if (SetSystemString(ConsumeMethodMetadata.ColumnNames.PeriodUnit, value))
                {
                    OnPropertyChanged(ConsumeMethodMetadata.PropertyNames.PeriodUnit);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return ConsumeMethodMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public ConsumeMethodQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new ConsumeMethodQuery("cmQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(ConsumeMethodQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(ConsumeMethodQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((ConsumeMethodQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private ConsumeMethodQuery query;
    }



    [Serializable]
    abstract public partial class esConsumeMethodCollection : esEntityCollection<ConsumeMethod>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return ConsumeMethodMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "ConsumeMethodCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public ConsumeMethodQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new ConsumeMethodQuery("cmQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(ConsumeMethodQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new ConsumeMethodQuery("cmQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(ConsumeMethodQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((ConsumeMethodQuery)query);
        }

        #endregion

        private ConsumeMethodQuery query;
    }



    [Serializable]
    abstract public partial class esConsumeMethodQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return ConsumeMethodMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "SRConsumeMethod": return SRConsumeMethod;
                case "SRConsumeMethodName": return SRConsumeMethodName;
                case "TimeSequence": return TimeSequence;
                case "LastCreateDateTime": return LastCreateDateTime;
                case "LastCreateByUserID": return LastCreateByUserID;
                case "SygnaText": return SygnaText;
                case "IterationQty": return IterationQty;
                case "IterationInInterval": return IterationInInterval;
                case "Time01": return Time01;
                case "Time02": return Time02;
                case "Time03": return Time03;
                case "Time04": return Time04;
                case "Time05": return Time05;
                case "Time06": return Time06;
                case "Time07": return Time07;
                case "Time08": return Time08;
                case "Time09": return Time09;
                case "Time10": return Time10;
                case "IsActive": return IsActive;
                case "LineNumber": return LineNumber;
                case "FrequencySatset": return FrequencySatset;
                case "PeriodUnit": return PeriodUnit;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem SRConsumeMethod
        {
            get { return new esQueryItem(this, ConsumeMethodMetadata.ColumnNames.SRConsumeMethod, esSystemType.String); }
        }

        public esQueryItem SRConsumeMethodName
        {
            get { return new esQueryItem(this, ConsumeMethodMetadata.ColumnNames.SRConsumeMethodName, esSystemType.String); }
        }

        public esQueryItem TimeSequence
        {
            get { return new esQueryItem(this, ConsumeMethodMetadata.ColumnNames.TimeSequence, esSystemType.String); }
        }

        public esQueryItem LastCreateDateTime
        {
            get { return new esQueryItem(this, ConsumeMethodMetadata.ColumnNames.LastCreateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastCreateByUserID
        {
            get { return new esQueryItem(this, ConsumeMethodMetadata.ColumnNames.LastCreateByUserID, esSystemType.String); }
        }

        public esQueryItem SygnaText
        {
            get { return new esQueryItem(this, ConsumeMethodMetadata.ColumnNames.SygnaText, esSystemType.String); }
        }

        public esQueryItem IterationQty
        {
            get { return new esQueryItem(this, ConsumeMethodMetadata.ColumnNames.IterationQty, esSystemType.Int32); }
        }

        public esQueryItem IterationInInterval
        {
            get { return new esQueryItem(this, ConsumeMethodMetadata.ColumnNames.IterationInInterval, esSystemType.String); }
        }

        public esQueryItem Time01
        {
            get { return new esQueryItem(this, ConsumeMethodMetadata.ColumnNames.Time01, esSystemType.String); }
        }

        public esQueryItem Time02
        {
            get { return new esQueryItem(this, ConsumeMethodMetadata.ColumnNames.Time02, esSystemType.String); }
        }

        public esQueryItem Time03
        {
            get { return new esQueryItem(this, ConsumeMethodMetadata.ColumnNames.Time03, esSystemType.String); }
        }

        public esQueryItem Time04
        {
            get { return new esQueryItem(this, ConsumeMethodMetadata.ColumnNames.Time04, esSystemType.String); }
        }

        public esQueryItem Time05
        {
            get { return new esQueryItem(this, ConsumeMethodMetadata.ColumnNames.Time05, esSystemType.String); }
        }

        public esQueryItem Time06
        {
            get { return new esQueryItem(this, ConsumeMethodMetadata.ColumnNames.Time06, esSystemType.String); }
        }

        public esQueryItem Time07
        {
            get { return new esQueryItem(this, ConsumeMethodMetadata.ColumnNames.Time07, esSystemType.String); }
        }

        public esQueryItem Time08
        {
            get { return new esQueryItem(this, ConsumeMethodMetadata.ColumnNames.Time08, esSystemType.String); }
        }

        public esQueryItem Time09
        {
            get { return new esQueryItem(this, ConsumeMethodMetadata.ColumnNames.Time09, esSystemType.String); }
        }

        public esQueryItem Time10
        {
            get { return new esQueryItem(this, ConsumeMethodMetadata.ColumnNames.Time10, esSystemType.String); }
        }

        public esQueryItem IsActive
        {
            get { return new esQueryItem(this, ConsumeMethodMetadata.ColumnNames.IsActive, esSystemType.Boolean); }
        }

        public esQueryItem LineNumber
        {
            get { return new esQueryItem(this, ConsumeMethodMetadata.ColumnNames.LineNumber, esSystemType.Int32); }
        }

        public esQueryItem FrequencySatset
        {
            get { return new esQueryItem(this, ConsumeMethodMetadata.ColumnNames.FrequencySatset, esSystemType.Int32); }
        }

        public esQueryItem PeriodUnit
        {
            get { return new esQueryItem(this, ConsumeMethodMetadata.ColumnNames.PeriodUnit, esSystemType.String); }
        }

        #endregion

    }



    [Serializable]
    public partial class ConsumeMethodMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected ConsumeMethodMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.SRConsumeMethod, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRConsumeMethod;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 10;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRConsumeMethodName, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRConsumeMethodName;
            c.CharacterMaxLength = 255;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TimeSequence, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TimeSequence;
            c.CharacterMaxLength = 50;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastCreateDateTime, 3, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastCreateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastCreateByUserID, 4, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastCreateByUserID;
            c.CharacterMaxLength = 40;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SygnaText, 5, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SygnaText;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IterationQty, 6, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.IterationQty;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IterationInInterval, 7, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.IterationInInterval;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Time01, 8, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Time01;
            c.CharacterMaxLength = 5;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Time02, 9, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Time02;
            c.CharacterMaxLength = 5;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Time03, 10, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Time03;
            c.CharacterMaxLength = 5;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Time04, 11, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Time04;
            c.CharacterMaxLength = 5;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Time05, 12, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Time05;
            c.CharacterMaxLength = 5;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Time06, 13, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Time06;
            c.CharacterMaxLength = 5;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Time07, 14, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Time07;
            c.CharacterMaxLength = 5;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Time08, 15, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Time08;
            c.CharacterMaxLength = 5;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Time09, 16, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Time09;
            c.CharacterMaxLength = 5;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Time10, 17, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Time10;
            c.CharacterMaxLength = 5;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsActive, 18, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsActive;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LineNumber, 19, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.LineNumber;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FrequencySatset, 20, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.FrequencySatset;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PeriodUnit, 21, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PeriodUnit;
            c.CharacterMaxLength = 5;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public ConsumeMethodMetadata Meta()
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
            public const string SRConsumeMethod = "SRConsumeMethod";
            public const string SRConsumeMethodName = "SRConsumeMethodName";
            public const string TimeSequence = "TimeSequence";
            public const string LastCreateDateTime = "LastCreateDateTime";
            public const string LastCreateByUserID = "LastCreateByUserID";
            public const string SygnaText = "SygnaText";
            public const string IterationQty = "IterationQty";
            public const string IterationInInterval = "IterationInInterval";
            public const string Time01 = "Time01";
            public const string Time02 = "Time02";
            public const string Time03 = "Time03";
            public const string Time04 = "Time04";
            public const string Time05 = "Time05";
            public const string Time06 = "Time06";
            public const string Time07 = "Time07";
            public const string Time08 = "Time08";
            public const string Time09 = "Time09";
            public const string Time10 = "Time10";
            public const string IsActive = "IsActive";
            public const string LineNumber = "LineNumber";
            public const string FrequencySatset = "frequency_satset";
            public const string PeriodUnit = "periodUnit";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string SRConsumeMethod = "SRConsumeMethod";
            public const string SRConsumeMethodName = "SRConsumeMethodName";
            public const string TimeSequence = "TimeSequence";
            public const string LastCreateDateTime = "LastCreateDateTime";
            public const string LastCreateByUserID = "LastCreateByUserID";
            public const string SygnaText = "SygnaText";
            public const string IterationQty = "IterationQty";
            public const string IterationInInterval = "IterationInInterval";
            public const string Time01 = "Time01";
            public const string Time02 = "Time02";
            public const string Time03 = "Time03";
            public const string Time04 = "Time04";
            public const string Time05 = "Time05";
            public const string Time06 = "Time06";
            public const string Time07 = "Time07";
            public const string Time08 = "Time08";
            public const string Time09 = "Time09";
            public const string Time10 = "Time10";
            public const string IsActive = "IsActive";
            public const string LineNumber = "LineNumber";
            public const string FrequencySatset = "FrequencySatset";
            public const string PeriodUnit = "PeriodUnit";
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
            lock (typeof(ConsumeMethodMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new ConsumeMethodMetadata();
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


                meta.AddTypeMap("SRConsumeMethod", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRConsumeMethodName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TimeSequence", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastCreateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastCreateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SygnaText", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IterationQty", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("IterationInInterval", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Time01", new esTypeMap("char", "System.String"));
                meta.AddTypeMap("Time02", new esTypeMap("char", "System.String"));
                meta.AddTypeMap("Time03", new esTypeMap("char", "System.String"));
                meta.AddTypeMap("Time04", new esTypeMap("char", "System.String"));
                meta.AddTypeMap("Time05", new esTypeMap("char", "System.String"));
                meta.AddTypeMap("Time06", new esTypeMap("char", "System.String"));
                meta.AddTypeMap("Time07", new esTypeMap("char", "System.String"));
                meta.AddTypeMap("Time08", new esTypeMap("char", "System.String"));
                meta.AddTypeMap("Time09", new esTypeMap("char", "System.String"));
                meta.AddTypeMap("Time10", new esTypeMap("char", "System.String"));
                meta.AddTypeMap("IsActive", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("LineNumber", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("FrequencySatset", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("PeriodUnit", new esTypeMap("char", "System.String"));



                meta.Source = "ConsumeMethod";
                meta.Destination = "ConsumeMethod";

                meta.spInsert = "proc_ConsumeMethodInsert";
                meta.spUpdate = "proc_ConsumeMethodUpdate";
                meta.spDelete = "proc_ConsumeMethodDelete";
                meta.spLoadAll = "proc_ConsumeMethodLoadAll";
                meta.spLoadByPrimaryKey = "proc_ConsumeMethodLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private ConsumeMethodMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
