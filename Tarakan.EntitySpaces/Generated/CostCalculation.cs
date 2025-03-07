
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 2/17/2025 10:04:26 AM
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
    /// Encapsulates the 'CostCalculation' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(CostCalculation))]
    [XmlType("CostCalculation")]
    public partial class CostCalculation : esCostCalculation
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new CostCalculation();
        }

        #region Static Quick Access Methods
        static public void Delete(string registrationNo, string transactionNo, string sequenceNo)
        {
            var obj = new CostCalculation();
            obj.RegistrationNo = registrationNo;
            obj.TransactionNo = transactionNo;
            obj.SequenceNo = sequenceNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string registrationNo, string transactionNo, string sequenceNo, esSqlAccessType sqlAccessType)
        {
            var obj = new CostCalculation();
            obj.RegistrationNo = registrationNo;
            obj.TransactionNo = transactionNo;
            obj.SequenceNo = sequenceNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("CostCalculationCollection")]
    public partial class CostCalculationCollection : esCostCalculationCollection, IEnumerable<CostCalculation>
    {
        public CostCalculation FindByPrimaryKey(string registrationNo, string transactionNo, string sequenceNo)
        {
            return this.SingleOrDefault(e => e.RegistrationNo == registrationNo && e.TransactionNo == transactionNo && e.SequenceNo == sequenceNo);
        }



    }



    [Serializable]
    public partial class CostCalculationQuery : esCostCalculationQuery
    {
        public CostCalculationQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public CostCalculationQuery(string joinAlias, out CostCalculationQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "CostCalculationQuery";
        }



        #region Explicit Casts

        public static explicit operator string(CostCalculationQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator CostCalculationQuery(string query)
        {
            return (CostCalculationQuery)SerializeHelper.FromXml(query, typeof(CostCalculationQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esCostCalculation : esEntity
    {
        public esCostCalculation()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string registrationNo, string transactionNo, string sequenceNo)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(registrationNo, transactionNo, sequenceNo);
            else
                return LoadByPrimaryKeyStoredProcedure(registrationNo, transactionNo, sequenceNo);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string registrationNo, string transactionNo, string sequenceNo)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(registrationNo, transactionNo, sequenceNo);
            else
                return LoadByPrimaryKeyStoredProcedure(registrationNo, transactionNo, sequenceNo);
        }

        private bool LoadByPrimaryKeyDynamic(string registrationNo, string transactionNo, string sequenceNo)
        {
            CostCalculationQuery query = new CostCalculationQuery("ccQ");
            query.Where(query.RegistrationNo == registrationNo, query.TransactionNo == transactionNo, query.SequenceNo == sequenceNo);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string registrationNo, string transactionNo, string sequenceNo)
        {
            esParameters parms = new esParameters();
            parms.Add("RegistrationNo", registrationNo); parms.Add("TransactionNo", transactionNo); parms.Add("SequenceNo", sequenceNo);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to CostCalculation.RegistrationNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RegistrationNo
        {
            get
            {
                return GetSystemString(CostCalculationMetadata.ColumnNames.RegistrationNo);
            }

            set
            {
                if (SetSystemString(CostCalculationMetadata.ColumnNames.RegistrationNo, value))
                {
                    OnPropertyChanged(CostCalculationMetadata.PropertyNames.RegistrationNo);
                }
            }
        }

        /// <summary>
        /// Maps to CostCalculation.TransactionNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TransactionNo
        {
            get
            {
                return GetSystemString(CostCalculationMetadata.ColumnNames.TransactionNo);
            }

            set
            {
                if (SetSystemString(CostCalculationMetadata.ColumnNames.TransactionNo, value))
                {
                    OnPropertyChanged(CostCalculationMetadata.PropertyNames.TransactionNo);
                }
            }
        }

        /// <summary>
        /// Maps to CostCalculation.SequenceNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SequenceNo
        {
            get
            {
                return GetSystemString(CostCalculationMetadata.ColumnNames.SequenceNo);
            }

            set
            {
                if (SetSystemString(CostCalculationMetadata.ColumnNames.SequenceNo, value))
                {
                    OnPropertyChanged(CostCalculationMetadata.PropertyNames.SequenceNo);
                }
            }
        }

        /// <summary>
        /// Maps to CostCalculation.ItemID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ItemID
        {
            get
            {
                return GetSystemString(CostCalculationMetadata.ColumnNames.ItemID);
            }

            set
            {
                if (SetSystemString(CostCalculationMetadata.ColumnNames.ItemID, value))
                {
                    OnPropertyChanged(CostCalculationMetadata.PropertyNames.ItemID);
                }
            }
        }

        /// <summary>
        /// Maps to CostCalculation.PatientAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? PatientAmount
        {
            get
            {
                return GetSystemDecimal(CostCalculationMetadata.ColumnNames.PatientAmount);
            }

            set
            {
                if (SetSystemDecimal(CostCalculationMetadata.ColumnNames.PatientAmount, value))
                {
                    OnPropertyChanged(CostCalculationMetadata.PropertyNames.PatientAmount);
                }
            }
        }

        /// <summary>
        /// Maps to CostCalculation.GuarantorAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? GuarantorAmount
        {
            get
            {
                return GetSystemDecimal(CostCalculationMetadata.ColumnNames.GuarantorAmount);
            }

            set
            {
                if (SetSystemDecimal(CostCalculationMetadata.ColumnNames.GuarantorAmount, value))
                {
                    OnPropertyChanged(CostCalculationMetadata.PropertyNames.GuarantorAmount);
                }
            }
        }

        /// <summary>
        /// Maps to CostCalculation.DiscountAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? DiscountAmount
        {
            get
            {
                return GetSystemDecimal(CostCalculationMetadata.ColumnNames.DiscountAmount);
            }

            set
            {
                if (SetSystemDecimal(CostCalculationMetadata.ColumnNames.DiscountAmount, value))
                {
                    OnPropertyChanged(CostCalculationMetadata.PropertyNames.DiscountAmount);
                }
            }
        }

        /// <summary>
        /// Maps to CostCalculation.ParamedicAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? ParamedicAmount
        {
            get
            {
                return GetSystemDecimal(CostCalculationMetadata.ColumnNames.ParamedicAmount);
            }

            set
            {
                if (SetSystemDecimal(CostCalculationMetadata.ColumnNames.ParamedicAmount, value))
                {
                    OnPropertyChanged(CostCalculationMetadata.PropertyNames.ParamedicAmount);
                }
            }
        }

        /// <summary>
        /// Maps to CostCalculation.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(CostCalculationMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(CostCalculationMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(CostCalculationMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to CostCalculation.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(CostCalculationMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(CostCalculationMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(CostCalculationMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to CostCalculation.ParamedicFeeAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? ParamedicFeeAmount
        {
            get
            {
                return GetSystemDecimal(CostCalculationMetadata.ColumnNames.ParamedicFeeAmount);
            }

            set
            {
                if (SetSystemDecimal(CostCalculationMetadata.ColumnNames.ParamedicFeeAmount, value))
                {
                    OnPropertyChanged(CostCalculationMetadata.PropertyNames.ParamedicFeeAmount);
                }
            }
        }

        /// <summary>
        /// Maps to CostCalculation.ParamedicFeePaymentNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParamedicFeePaymentNo
        {
            get
            {
                return GetSystemString(CostCalculationMetadata.ColumnNames.ParamedicFeePaymentNo);
            }

            set
            {
                if (SetSystemString(CostCalculationMetadata.ColumnNames.ParamedicFeePaymentNo, value))
                {
                    OnPropertyChanged(CostCalculationMetadata.PropertyNames.ParamedicFeePaymentNo);
                }
            }
        }

        /// <summary>
        /// Maps to CostCalculation.IsPackage
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsPackage
        {
            get
            {
                return GetSystemBoolean(CostCalculationMetadata.ColumnNames.IsPackage);
            }

            set
            {
                if (SetSystemBoolean(CostCalculationMetadata.ColumnNames.IsPackage, value))
                {
                    OnPropertyChanged(CostCalculationMetadata.PropertyNames.IsPackage);
                }
            }
        }

        /// <summary>
        /// Maps to CostCalculation.ParentNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParentNo
        {
            get
            {
                return GetSystemString(CostCalculationMetadata.ColumnNames.ParentNo);
            }

            set
            {
                if (SetSystemString(CostCalculationMetadata.ColumnNames.ParentNo, value))
                {
                    OnPropertyChanged(CostCalculationMetadata.PropertyNames.ParentNo);
                }
            }
        }

        /// <summary>
        /// Maps to CostCalculation.IntermBillNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string IntermBillNo
        {
            get
            {
                return GetSystemString(CostCalculationMetadata.ColumnNames.IntermBillNo);
            }

            set
            {
                if (SetSystemString(CostCalculationMetadata.ColumnNames.IntermBillNo, value))
                {
                    OnPropertyChanged(CostCalculationMetadata.PropertyNames.IntermBillNo);
                }
            }
        }

        /// <summary>
        /// Maps to CostCalculation.IsChecked
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsChecked
        {
            get
            {
                return GetSystemBoolean(CostCalculationMetadata.ColumnNames.IsChecked);
            }

            set
            {
                if (SetSystemBoolean(CostCalculationMetadata.ColumnNames.IsChecked, value))
                {
                    OnPropertyChanged(CostCalculationMetadata.PropertyNames.IsChecked);
                }
            }
        }

        /// <summary>
        /// Maps to CostCalculation.DiscountAmount2
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? DiscountAmount2
        {
            get
            {
                return GetSystemDecimal(CostCalculationMetadata.ColumnNames.DiscountAmount2);
            }

            set
            {
                if (SetSystemDecimal(CostCalculationMetadata.ColumnNames.DiscountAmount2, value))
                {
                    OnPropertyChanged(CostCalculationMetadata.PropertyNames.DiscountAmount2);
                }
            }
        }

        /// <summary>
        /// Maps to CostCalculation.AmountAdjusted
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? AmountAdjusted
        {
            get
            {
                return GetSystemDecimal(CostCalculationMetadata.ColumnNames.AmountAdjusted);
            }

            set
            {
                if (SetSystemDecimal(CostCalculationMetadata.ColumnNames.AmountAdjusted, value))
                {
                    OnPropertyChanged(CostCalculationMetadata.PropertyNames.AmountAdjusted);
                }
            }
        }

        /// <summary>
        /// Maps to CostCalculation.AdjustedDiscAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? AdjustedDiscAmount
        {
            get
            {
                return GetSystemDecimal(CostCalculationMetadata.ColumnNames.AdjustedDiscAmount);
            }

            set
            {
                if (SetSystemDecimal(CostCalculationMetadata.ColumnNames.AdjustedDiscAmount, value))
                {
                    OnPropertyChanged(CostCalculationMetadata.PropertyNames.AdjustedDiscAmount);
                }
            }
        }

        /// <summary>
        /// Maps to CostCalculation.AdjustedDiscSelection
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? AdjustedDiscSelection
        {
            get
            {
                return GetSystemInt32(CostCalculationMetadata.ColumnNames.AdjustedDiscSelection);
            }

            set
            {
                if (SetSystemInt32(CostCalculationMetadata.ColumnNames.AdjustedDiscSelection, value))
                {
                    OnPropertyChanged(CostCalculationMetadata.PropertyNames.AdjustedDiscSelection);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return CostCalculationMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public CostCalculationQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new CostCalculationQuery("ccQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(CostCalculationQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(CostCalculationQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((CostCalculationQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private CostCalculationQuery query;
    }



    [Serializable]
    abstract public partial class esCostCalculationCollection : esEntityCollection<CostCalculation>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return CostCalculationMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "CostCalculationCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public CostCalculationQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new CostCalculationQuery("ccQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(CostCalculationQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new CostCalculationQuery("ccQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(CostCalculationQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((CostCalculationQuery)query);
        }

        #endregion

        private CostCalculationQuery query;
    }



    [Serializable]
    abstract public partial class esCostCalculationQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return CostCalculationMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "RegistrationNo": return RegistrationNo;
                case "TransactionNo": return TransactionNo;
                case "SequenceNo": return SequenceNo;
                case "ItemID": return ItemID;
                case "PatientAmount": return PatientAmount;
                case "GuarantorAmount": return GuarantorAmount;
                case "DiscountAmount": return DiscountAmount;
                case "ParamedicAmount": return ParamedicAmount;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "ParamedicFeeAmount": return ParamedicFeeAmount;
                case "ParamedicFeePaymentNo": return ParamedicFeePaymentNo;
                case "IsPackage": return IsPackage;
                case "ParentNo": return ParentNo;
                case "IntermBillNo": return IntermBillNo;
                case "IsChecked": return IsChecked;
                case "DiscountAmount2": return DiscountAmount2;
                case "AmountAdjusted": return AmountAdjusted;
                case "AdjustedDiscAmount": return AdjustedDiscAmount;
                case "AdjustedDiscSelection": return AdjustedDiscSelection;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem RegistrationNo
        {
            get { return new esQueryItem(this, CostCalculationMetadata.ColumnNames.RegistrationNo, esSystemType.String); }
        }

        public esQueryItem TransactionNo
        {
            get { return new esQueryItem(this, CostCalculationMetadata.ColumnNames.TransactionNo, esSystemType.String); }
        }

        public esQueryItem SequenceNo
        {
            get { return new esQueryItem(this, CostCalculationMetadata.ColumnNames.SequenceNo, esSystemType.String); }
        }

        public esQueryItem ItemID
        {
            get { return new esQueryItem(this, CostCalculationMetadata.ColumnNames.ItemID, esSystemType.String); }
        }

        public esQueryItem PatientAmount
        {
            get { return new esQueryItem(this, CostCalculationMetadata.ColumnNames.PatientAmount, esSystemType.Decimal); }
        }

        public esQueryItem GuarantorAmount
        {
            get { return new esQueryItem(this, CostCalculationMetadata.ColumnNames.GuarantorAmount, esSystemType.Decimal); }
        }

        public esQueryItem DiscountAmount
        {
            get { return new esQueryItem(this, CostCalculationMetadata.ColumnNames.DiscountAmount, esSystemType.Decimal); }
        }

        public esQueryItem ParamedicAmount
        {
            get { return new esQueryItem(this, CostCalculationMetadata.ColumnNames.ParamedicAmount, esSystemType.Decimal); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, CostCalculationMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, CostCalculationMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem ParamedicFeeAmount
        {
            get { return new esQueryItem(this, CostCalculationMetadata.ColumnNames.ParamedicFeeAmount, esSystemType.Decimal); }
        }

        public esQueryItem ParamedicFeePaymentNo
        {
            get { return new esQueryItem(this, CostCalculationMetadata.ColumnNames.ParamedicFeePaymentNo, esSystemType.String); }
        }

        public esQueryItem IsPackage
        {
            get { return new esQueryItem(this, CostCalculationMetadata.ColumnNames.IsPackage, esSystemType.Boolean); }
        }

        public esQueryItem ParentNo
        {
            get { return new esQueryItem(this, CostCalculationMetadata.ColumnNames.ParentNo, esSystemType.String); }
        }

        public esQueryItem IntermBillNo
        {
            get { return new esQueryItem(this, CostCalculationMetadata.ColumnNames.IntermBillNo, esSystemType.String); }
        }

        public esQueryItem IsChecked
        {
            get { return new esQueryItem(this, CostCalculationMetadata.ColumnNames.IsChecked, esSystemType.Boolean); }
        }

        public esQueryItem DiscountAmount2
        {
            get { return new esQueryItem(this, CostCalculationMetadata.ColumnNames.DiscountAmount2, esSystemType.Decimal); }
        }

        public esQueryItem AmountAdjusted
        {
            get { return new esQueryItem(this, CostCalculationMetadata.ColumnNames.AmountAdjusted, esSystemType.Decimal); }
        }

        public esQueryItem AdjustedDiscAmount
        {
            get { return new esQueryItem(this, CostCalculationMetadata.ColumnNames.AdjustedDiscAmount, esSystemType.Decimal); }
        }

        public esQueryItem AdjustedDiscSelection
        {
            get { return new esQueryItem(this, CostCalculationMetadata.ColumnNames.AdjustedDiscSelection, esSystemType.Int32); }
        }

        #endregion

    }



    [Serializable]
    public partial class CostCalculationMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected CostCalculationMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.RegistrationNo, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RegistrationNo;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 20;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TransactionNo, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TransactionNo;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SequenceNo, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SequenceNo;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 12;
            c.HasDefault = true;
            c.Default = @"('000')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ItemID, 3, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ItemID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PatientAmount, 4, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.PatientAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.GuarantorAmount, 5, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.GuarantorAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DiscountAmount, 6, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.DiscountAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParamedicAmount, 7, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.ParamedicAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 8, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 9, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 40;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParamedicFeeAmount, 10, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.ParamedicFeeAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParamedicFeePaymentNo, 11, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParamedicFeePaymentNo;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsPackage, 12, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsPackage;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParentNo, 13, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParentNo;
            c.CharacterMaxLength = 7;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IntermBillNo, 14, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.IntermBillNo;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsChecked, 15, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsChecked;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DiscountAmount2, 16, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.DiscountAmount2;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AmountAdjusted, 17, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.AmountAdjusted;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AdjustedDiscAmount, 18, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.AdjustedDiscAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AdjustedDiscSelection, 19, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.AdjustedDiscSelection;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public CostCalculationMetadata Meta()
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
            public const string TransactionNo = "TransactionNo";
            public const string SequenceNo = "SequenceNo";
            public const string ItemID = "ItemID";
            public const string PatientAmount = "PatientAmount";
            public const string GuarantorAmount = "GuarantorAmount";
            public const string DiscountAmount = "DiscountAmount";
            public const string ParamedicAmount = "ParamedicAmount";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string ParamedicFeeAmount = "ParamedicFeeAmount";
            public const string ParamedicFeePaymentNo = "ParamedicFeePaymentNo";
            public const string IsPackage = "IsPackage";
            public const string ParentNo = "ParentNo";
            public const string IntermBillNo = "IntermBillNo";
            public const string IsChecked = "IsChecked";
            public const string DiscountAmount2 = "DiscountAmount2";
            public const string AmountAdjusted = "AmountAdjusted";
            public const string AdjustedDiscAmount = "AdjustedDiscAmount";
            public const string AdjustedDiscSelection = "AdjustedDiscSelection";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string RegistrationNo = "RegistrationNo";
            public const string TransactionNo = "TransactionNo";
            public const string SequenceNo = "SequenceNo";
            public const string ItemID = "ItemID";
            public const string PatientAmount = "PatientAmount";
            public const string GuarantorAmount = "GuarantorAmount";
            public const string DiscountAmount = "DiscountAmount";
            public const string ParamedicAmount = "ParamedicAmount";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string ParamedicFeeAmount = "ParamedicFeeAmount";
            public const string ParamedicFeePaymentNo = "ParamedicFeePaymentNo";
            public const string IsPackage = "IsPackage";
            public const string ParentNo = "ParentNo";
            public const string IntermBillNo = "IntermBillNo";
            public const string IsChecked = "IsChecked";
            public const string DiscountAmount2 = "DiscountAmount2";
            public const string AmountAdjusted = "AmountAdjusted";
            public const string AdjustedDiscAmount = "AdjustedDiscAmount";
            public const string AdjustedDiscSelection = "AdjustedDiscSelection";
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
            lock (typeof(CostCalculationMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new CostCalculationMetadata();
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
                meta.AddTypeMap("TransactionNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SequenceNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ItemID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PatientAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("GuarantorAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("DiscountAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("ParamedicAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ParamedicFeeAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("ParamedicFeePaymentNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsPackage", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ParentNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IntermBillNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsChecked", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("DiscountAmount2", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("AmountAdjusted", new esTypeMap("decimal", "System.Decimal"));
                meta.AddTypeMap("AdjustedDiscAmount", new esTypeMap("decimal", "System.Decimal"));
                meta.AddTypeMap("AdjustedDiscSelection", new esTypeMap("int", "System.Int32"));



                meta.Source = "CostCalculation";
                meta.Destination = "CostCalculation";

                meta.spInsert = "proc_CostCalculationInsert";
                meta.spUpdate = "proc_CostCalculationUpdate";
                meta.spDelete = "proc_CostCalculationDelete";
                meta.spLoadAll = "proc_CostCalculationLoadAll";
                meta.spLoadByPrimaryKey = "proc_CostCalculationLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private CostCalculationMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
