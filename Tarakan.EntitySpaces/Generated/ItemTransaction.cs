
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 2/17/2025 10:14:04 AM
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
    /// Encapsulates the 'ItemTransaction' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(ItemTransaction))]
    [XmlType("ItemTransaction")]
    public partial class ItemTransaction : esItemTransaction
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new ItemTransaction();
        }

        #region Static Quick Access Methods
        static public void Delete(string transactionNo)
        {
            var obj = new ItemTransaction();
            obj.TransactionNo = transactionNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string transactionNo, esSqlAccessType sqlAccessType)
        {
            var obj = new ItemTransaction();
            obj.TransactionNo = transactionNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("ItemTransactionCollection")]
    public partial class ItemTransactionCollection : esItemTransactionCollection, IEnumerable<ItemTransaction>
    {
        public ItemTransaction FindByPrimaryKey(string transactionNo)
        {
            return this.SingleOrDefault(e => e.TransactionNo == transactionNo);
        }



    }



    [Serializable]
    public partial class ItemTransactionQuery : esItemTransactionQuery
    {
        public ItemTransactionQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public ItemTransactionQuery(string joinAlias, out ItemTransactionQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "ItemTransactionQuery";
        }



        #region Explicit Casts

        public static explicit operator string(ItemTransactionQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator ItemTransactionQuery(string query)
        {
            return (ItemTransactionQuery)SerializeHelper.FromXml(query, typeof(ItemTransactionQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esItemTransaction : esEntity
    {
        public esItemTransaction()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string transactionNo)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(transactionNo);
            else
                return LoadByPrimaryKeyStoredProcedure(transactionNo);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string transactionNo)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(transactionNo);
            else
                return LoadByPrimaryKeyStoredProcedure(transactionNo);
        }

        private bool LoadByPrimaryKeyDynamic(string transactionNo)
        {
            ItemTransactionQuery query = new ItemTransactionQuery("itQ");
            query.Where(query.TransactionNo == transactionNo);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string transactionNo)
        {
            esParameters parms = new esParameters();
            parms.Add("TransactionNo", transactionNo);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to ItemTransaction.TransactionNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TransactionNo
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.TransactionNo);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.TransactionNo, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.TransactionNo);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.TransactionCode
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TransactionCode
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.TransactionCode);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.TransactionCode, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.TransactionCode);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.TransactionDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? TransactionDate
        {
            get
            {
                return GetSystemDateTime(ItemTransactionMetadata.ColumnNames.TransactionDate);
            }

            set
            {
                if (SetSystemDateTime(ItemTransactionMetadata.ColumnNames.TransactionDate, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.TransactionDate);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.BusinessPartnerID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string BusinessPartnerID
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.BusinessPartnerID);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.BusinessPartnerID, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.BusinessPartnerID);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.InvoiceNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string InvoiceNo
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.InvoiceNo);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.InvoiceNo, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.InvoiceNo);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.CurrencyID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string CurrencyID
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.CurrencyID);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.CurrencyID, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.CurrencyID);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.CurrencyRate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? CurrencyRate
        {
            get
            {
                return GetSystemDecimal(ItemTransactionMetadata.ColumnNames.CurrencyRate);
            }

            set
            {
                if (SetSystemDecimal(ItemTransactionMetadata.ColumnNames.CurrencyRate, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.CurrencyRate);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.ReferenceNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ReferenceNo
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.ReferenceNo);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.ReferenceNo, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.ReferenceNo);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.ReferenceDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? ReferenceDate
        {
            get
            {
                return GetSystemDateTime(ItemTransactionMetadata.ColumnNames.ReferenceDate);
            }

            set
            {
                if (SetSystemDateTime(ItemTransactionMetadata.ColumnNames.ReferenceDate, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.ReferenceDate);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.FromServiceUnitID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string FromServiceUnitID
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.FromServiceUnitID);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.FromServiceUnitID, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.FromServiceUnitID);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.FromLocationID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string FromLocationID
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.FromLocationID);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.FromLocationID, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.FromLocationID);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.ToServiceUnitID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ToServiceUnitID
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.ToServiceUnitID);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.ToServiceUnitID, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.ToServiceUnitID);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.ToLocationID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ToLocationID
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.ToLocationID);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.ToLocationID, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.ToLocationID);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.TermID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TermID
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.TermID);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.TermID, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.TermID);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.SRItemType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRItemType
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.SRItemType);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.SRItemType, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.SRItemType);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.DiscountAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? DiscountAmount
        {
            get
            {
                return GetSystemDecimal(ItemTransactionMetadata.ColumnNames.DiscountAmount);
            }

            set
            {
                if (SetSystemDecimal(ItemTransactionMetadata.ColumnNames.DiscountAmount, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.DiscountAmount);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.ChargesAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? ChargesAmount
        {
            get
            {
                return GetSystemDecimal(ItemTransactionMetadata.ColumnNames.ChargesAmount);
            }

            set
            {
                if (SetSystemDecimal(ItemTransactionMetadata.ColumnNames.ChargesAmount, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.ChargesAmount);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.StampAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? StampAmount
        {
            get
            {
                return GetSystemDecimal(ItemTransactionMetadata.ColumnNames.StampAmount);
            }

            set
            {
                if (SetSystemDecimal(ItemTransactionMetadata.ColumnNames.StampAmount, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.StampAmount);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.DownPaymentAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? DownPaymentAmount
        {
            get
            {
                return GetSystemDecimal(ItemTransactionMetadata.ColumnNames.DownPaymentAmount);
            }

            set
            {
                if (SetSystemDecimal(ItemTransactionMetadata.ColumnNames.DownPaymentAmount, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.DownPaymentAmount);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.DownPaymentReferenceNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DownPaymentReferenceNo
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.DownPaymentReferenceNo);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.DownPaymentReferenceNo, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.DownPaymentReferenceNo);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.SRDownPaymentType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRDownPaymentType
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.SRDownPaymentType);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.SRDownPaymentType, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.SRDownPaymentType);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.SRAdjustmentType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRAdjustmentType
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.SRAdjustmentType);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.SRAdjustmentType, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.SRAdjustmentType);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.SRDistributionType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRDistributionType
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.SRDistributionType);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.SRDistributionType, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.SRDistributionType);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.SRPurchaseReturnType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRPurchaseReturnType
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.SRPurchaseReturnType);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.SRPurchaseReturnType, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.SRPurchaseReturnType);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.SRPurchaseOrderType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRPurchaseOrderType
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.SRPurchaseOrderType);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.SRPurchaseOrderType, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.SRPurchaseOrderType);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.TaxPercentage
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? TaxPercentage
        {
            get
            {
                return GetSystemDecimal(ItemTransactionMetadata.ColumnNames.TaxPercentage);
            }

            set
            {
                if (SetSystemDecimal(ItemTransactionMetadata.ColumnNames.TaxPercentage, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.TaxPercentage);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.TaxAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? TaxAmount
        {
            get
            {
                return GetSystemDecimal(ItemTransactionMetadata.ColumnNames.TaxAmount);
            }

            set
            {
                if (SetSystemDecimal(ItemTransactionMetadata.ColumnNames.TaxAmount, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.TaxAmount);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.IsTaxable
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public short? IsTaxable
        {
            get
            {
                return GetSystemInt16(ItemTransactionMetadata.ColumnNames.IsTaxable);
            }

            set
            {
                if (SetSystemInt16(ItemTransactionMetadata.ColumnNames.IsTaxable, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.IsTaxable);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.IsVoid
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsVoid
        {
            get
            {
                return GetSystemBoolean(ItemTransactionMetadata.ColumnNames.IsVoid);
            }

            set
            {
                if (SetSystemBoolean(ItemTransactionMetadata.ColumnNames.IsVoid, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.IsVoid);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.VoidDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? VoidDate
        {
            get
            {
                return GetSystemDateTime(ItemTransactionMetadata.ColumnNames.VoidDate);
            }

            set
            {
                if (SetSystemDateTime(ItemTransactionMetadata.ColumnNames.VoidDate, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.VoidDate);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.VoidByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string VoidByUserID
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.VoidByUserID);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.VoidByUserID, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.VoidByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.IsApproved
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsApproved
        {
            get
            {
                return GetSystemBoolean(ItemTransactionMetadata.ColumnNames.IsApproved);
            }

            set
            {
                if (SetSystemBoolean(ItemTransactionMetadata.ColumnNames.IsApproved, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.IsApproved);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.ApprovedDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? ApprovedDate
        {
            get
            {
                return GetSystemDateTime(ItemTransactionMetadata.ColumnNames.ApprovedDate);
            }

            set
            {
                if (SetSystemDateTime(ItemTransactionMetadata.ColumnNames.ApprovedDate, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.ApprovedDate);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.ApprovedByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ApprovedByUserID
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.ApprovedByUserID);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.ApprovedByUserID, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.ApprovedByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.IsClosed
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsClosed
        {
            get
            {
                return GetSystemBoolean(ItemTransactionMetadata.ColumnNames.IsClosed);
            }

            set
            {
                if (SetSystemBoolean(ItemTransactionMetadata.ColumnNames.IsClosed, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.IsClosed);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.IsBySystem
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsBySystem
        {
            get
            {
                return GetSystemBoolean(ItemTransactionMetadata.ColumnNames.IsBySystem);
            }

            set
            {
                if (SetSystemBoolean(ItemTransactionMetadata.ColumnNames.IsBySystem, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.IsBySystem);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.IsNonMasterOrder
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsNonMasterOrder
        {
            get
            {
                return GetSystemBoolean(ItemTransactionMetadata.ColumnNames.IsNonMasterOrder);
            }

            set
            {
                if (SetSystemBoolean(ItemTransactionMetadata.ColumnNames.IsNonMasterOrder, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.IsNonMasterOrder);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.Notes
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Notes
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.Notes);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.Notes, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.Notes);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(ItemTransactionMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(ItemTransactionMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.ProductAccountID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ProductAccountID
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.ProductAccountID);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.ProductAccountID, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.ProductAccountID);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.LeadTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LeadTime
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.LeadTime);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.LeadTime, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.LeadTime);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.Pph22
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? Pph22
        {
            get
            {
                return GetSystemDecimal(ItemTransactionMetadata.ColumnNames.Pph22);
            }

            set
            {
                if (SetSystemDecimal(ItemTransactionMetadata.ColumnNames.Pph22, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.Pph22);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.Pph23
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? Pph23
        {
            get
            {
                return GetSystemDecimal(ItemTransactionMetadata.ColumnNames.Pph23);
            }

            set
            {
                if (SetSystemDecimal(ItemTransactionMetadata.ColumnNames.Pph23, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.Pph23);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.ContractNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ContractNo
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.ContractNo);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.ContractNo, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.ContractNo);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.PriorChargesAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? PriorChargesAmount
        {
            get
            {
                return GetSystemDecimal(ItemTransactionMetadata.ColumnNames.PriorChargesAmount);
            }

            set
            {
                if (SetSystemDecimal(ItemTransactionMetadata.ColumnNames.PriorChargesAmount, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.PriorChargesAmount);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.PriorTaxAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? PriorTaxAmount
        {
            get
            {
                return GetSystemDecimal(ItemTransactionMetadata.ColumnNames.PriorTaxAmount);
            }

            set
            {
                if (SetSystemDecimal(ItemTransactionMetadata.ColumnNames.PriorTaxAmount, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.PriorTaxAmount);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.CustomerID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string CustomerID
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.CustomerID);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.CustomerID, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.CustomerID);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.TaxInvoiceNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TaxInvoiceNo
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.TaxInvoiceNo);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.TaxInvoiceNo, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.TaxInvoiceNo);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.TaxInvoiceDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? TaxInvoiceDate
        {
            get
            {
                return GetSystemDateTime(ItemTransactionMetadata.ColumnNames.TaxInvoiceDate);
            }

            set
            {
                if (SetSystemDateTime(ItemTransactionMetadata.ColumnNames.TaxInvoiceDate, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.TaxInvoiceDate);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.SRPaymentType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRPaymentType
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.SRPaymentType);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.SRPaymentType, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.SRPaymentType);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.SRPurchaseCategorization
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRPurchaseCategorization
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.SRPurchaseCategorization);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.SRPurchaseCategorization, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.SRPurchaseCategorization);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.IsInventoryItem
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsInventoryItem
        {
            get
            {
                return GetSystemBoolean(ItemTransactionMetadata.ColumnNames.IsInventoryItem);
            }

            set
            {
                if (SetSystemBoolean(ItemTransactionMetadata.ColumnNames.IsInventoryItem, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.IsInventoryItem);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.TermOfPayment
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? TermOfPayment
        {
            get
            {
                return GetSystemDecimal(ItemTransactionMetadata.ColumnNames.TermOfPayment);
            }

            set
            {
                if (SetSystemDecimal(ItemTransactionMetadata.ColumnNames.TermOfPayment, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.TermOfPayment);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.IsAssets
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsAssets
        {
            get
            {
                return GetSystemBoolean(ItemTransactionMetadata.ColumnNames.IsAssets);
            }

            set
            {
                if (SetSystemBoolean(ItemTransactionMetadata.ColumnNames.IsAssets, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.IsAssets);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.BudgetPlanCounter
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? BudgetPlanCounter
        {
            get
            {
                return GetSystemInt32(ItemTransactionMetadata.ColumnNames.BudgetPlanCounter);
            }

            set
            {
                if (SetSystemInt32(ItemTransactionMetadata.ColumnNames.BudgetPlanCounter, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.BudgetPlanCounter);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.ServiceUnitCostID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ServiceUnitCostID
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.ServiceUnitCostID);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.ServiceUnitCostID, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.ServiceUnitCostID);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.IsPph22InPercent
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsPph22InPercent
        {
            get
            {
                return GetSystemBoolean(ItemTransactionMetadata.ColumnNames.IsPph22InPercent);
            }

            set
            {
                if (SetSystemBoolean(ItemTransactionMetadata.ColumnNames.IsPph22InPercent, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.IsPph22InPercent);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.Pph22Percentage
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? Pph22Percentage
        {
            get
            {
                return GetSystemDecimal(ItemTransactionMetadata.ColumnNames.Pph22Percentage);
            }

            set
            {
                if (SetSystemDecimal(ItemTransactionMetadata.ColumnNames.Pph22Percentage, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.Pph22Percentage);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.IsPph23InPercent
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsPph23InPercent
        {
            get
            {
                return GetSystemBoolean(ItemTransactionMetadata.ColumnNames.IsPph23InPercent);
            }

            set
            {
                if (SetSystemBoolean(ItemTransactionMetadata.ColumnNames.IsPph23InPercent, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.IsPph23InPercent);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.Pph23Percentage
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? Pph23Percentage
        {
            get
            {
                return GetSystemDecimal(ItemTransactionMetadata.ColumnNames.Pph23Percentage);
            }

            set
            {
                if (SetSystemDecimal(ItemTransactionMetadata.ColumnNames.Pph23Percentage, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.Pph23Percentage);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.IsConsignment
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsConsignment
        {
            get
            {
                return GetSystemBoolean(ItemTransactionMetadata.ColumnNames.IsConsignment);
            }

            set
            {
                if (SetSystemBoolean(ItemTransactionMetadata.ColumnNames.IsConsignment, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.IsConsignment);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.AmountTaxed
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? AmountTaxed
        {
            get
            {
                return GetSystemDecimal(ItemTransactionMetadata.ColumnNames.AmountTaxed);
            }

            set
            {
                if (SetSystemDecimal(ItemTransactionMetadata.ColumnNames.AmountTaxed, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.AmountTaxed);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.RevisionNumber
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public short? RevisionNumber
        {
            get
            {
                return GetSystemInt16(ItemTransactionMetadata.ColumnNames.RevisionNumber);
            }

            set
            {
                if (SetSystemInt16(ItemTransactionMetadata.ColumnNames.RevisionNumber, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.RevisionNumber);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.PrintNumber
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public short? PrintNumber
        {
            get
            {
                return GetSystemInt16(ItemTransactionMetadata.ColumnNames.PrintNumber);
            }

            set
            {
                if (SetSystemInt16(ItemTransactionMetadata.ColumnNames.PrintNumber, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.PrintNumber);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.LastPrintedDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastPrintedDateTime
        {
            get
            {
                return GetSystemDateTime(ItemTransactionMetadata.ColumnNames.LastPrintedDateTime);
            }

            set
            {
                if (SetSystemDateTime(ItemTransactionMetadata.ColumnNames.LastPrintedDateTime, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.LastPrintedDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.LastPrintedByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastPrintedByUserID
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.LastPrintedByUserID);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.LastPrintedByUserID, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.LastPrintedByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.AdvanceAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? AdvanceAmount
        {
            get
            {
                return GetSystemDecimal(ItemTransactionMetadata.ColumnNames.AdvanceAmount);
            }

            set
            {
                if (SetSystemDecimal(ItemTransactionMetadata.ColumnNames.AdvanceAmount, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.AdvanceAmount);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.DeliveryOrdersNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DeliveryOrdersNo
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.DeliveryOrdersNo);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.DeliveryOrdersNo, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.DeliveryOrdersNo);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.DeliveryOrdersDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? DeliveryOrdersDate
        {
            get
            {
                return GetSystemDateTime(ItemTransactionMetadata.ColumnNames.DeliveryOrdersDate);
            }

            set
            {
                if (SetSystemDateTime(ItemTransactionMetadata.ColumnNames.DeliveryOrdersDate, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.DeliveryOrdersDate);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.PphAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? PphAmount
        {
            get
            {
                return GetSystemDecimal(ItemTransactionMetadata.ColumnNames.PphAmount);
            }

            set
            {
                if (SetSystemDecimal(ItemTransactionMetadata.ColumnNames.PphAmount, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.PphAmount);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.InvoiceSupplierDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? InvoiceSupplierDate
        {
            get
            {
                return GetSystemDateTime(ItemTransactionMetadata.ColumnNames.InvoiceSupplierDate);
            }

            set
            {
                if (SetSystemDateTime(ItemTransactionMetadata.ColumnNames.InvoiceSupplierDate, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.InvoiceSupplierDate);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.CashTransactionReconcileId
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string CashTransactionReconcileId
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.CashTransactionReconcileId);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.CashTransactionReconcileId, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.CashTransactionReconcileId);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.ItemGroupID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ItemGroupID
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.ItemGroupID);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.ItemGroupID, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.ItemGroupID);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.SRPph
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRPph
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.SRPph);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.SRPph, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.SRPph);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.PphPercentage
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? PphPercentage
        {
            get
            {
                return GetSystemDecimal(ItemTransactionMetadata.ColumnNames.PphPercentage);
            }

            set
            {
                if (SetSystemDecimal(ItemTransactionMetadata.ColumnNames.PphPercentage, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.PphPercentage);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.IsConsignmentAlreadyReceived
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsConsignmentAlreadyReceived
        {
            get
            {
                return GetSystemBoolean(ItemTransactionMetadata.ColumnNames.IsConsignmentAlreadyReceived);
            }

            set
            {
                if (SetSystemBoolean(ItemTransactionMetadata.ColumnNames.IsConsignmentAlreadyReceived, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.IsConsignmentAlreadyReceived);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.PlanningDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? PlanningDate
        {
            get
            {
                return GetSystemDateTime(ItemTransactionMetadata.ColumnNames.PlanningDate);
            }

            set
            {
                if (SetSystemDateTime(ItemTransactionMetadata.ColumnNames.PlanningDate, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.PlanningDate);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.IsInstallmentType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsInstallmentType
        {
            get
            {
                return GetSystemBoolean(ItemTransactionMetadata.ColumnNames.IsInstallmentType);
            }

            set
            {
                if (SetSystemBoolean(ItemTransactionMetadata.ColumnNames.IsInstallmentType, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.IsInstallmentType);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.CreateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? CreateDateTime
        {
            get
            {
                return GetSystemDateTime(ItemTransactionMetadata.ColumnNames.CreateDateTime);
            }

            set
            {
                if (SetSystemDateTime(ItemTransactionMetadata.ColumnNames.CreateDateTime, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.CreateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.CreateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string CreateByUserID
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.CreateByUserID);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.CreateByUserID, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.CreateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.SRItemCategory
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRItemCategory
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.SRItemCategory);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.SRItemCategory, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.SRItemCategory);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.SRProcurementType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRProcurementType
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.SRProcurementType);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.SRProcurementType, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.SRProcurementType);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.ContractDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? ContractDate
        {
            get
            {
                return GetSystemDateTime(ItemTransactionMetadata.ColumnNames.ContractDate);
            }

            set
            {
                if (SetSystemDateTime(ItemTransactionMetadata.ColumnNames.ContractDate, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.ContractDate);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.CheckNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string CheckNo
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.CheckNo);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.CheckNo, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.CheckNo);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.CheckDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? CheckDate
        {
            get
            {
                return GetSystemDateTime(ItemTransactionMetadata.ColumnNames.CheckDate);
            }

            set
            {
                if (SetSystemDateTime(ItemTransactionMetadata.ColumnNames.CheckDate, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.CheckDate);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.SalesMarginPercentage
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? SalesMarginPercentage
        {
            get
            {
                return GetSystemDecimal(ItemTransactionMetadata.ColumnNames.SalesMarginPercentage);
            }

            set
            {
                if (SetSystemDecimal(ItemTransactionMetadata.ColumnNames.SalesMarginPercentage, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.SalesMarginPercentage);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.IsCito
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsCito
        {
            get
            {
                return GetSystemBoolean(ItemTransactionMetadata.ColumnNames.IsCito);
            }

            set
            {
                if (SetSystemBoolean(ItemTransactionMetadata.ColumnNames.IsCito, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.IsCito);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.IsVerified
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsVerified
        {
            get
            {
                return GetSystemBoolean(ItemTransactionMetadata.ColumnNames.IsVerified);
            }

            set
            {
                if (SetSystemBoolean(ItemTransactionMetadata.ColumnNames.IsVerified, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.IsVerified);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.VerifiedDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? VerifiedDate
        {
            get
            {
                return GetSystemDateTime(ItemTransactionMetadata.ColumnNames.VerifiedDate);
            }

            set
            {
                if (SetSystemDateTime(ItemTransactionMetadata.ColumnNames.VerifiedDate, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.VerifiedDate);
                }
            }
        }

        /// <summary>
        /// Maps to ItemTransaction.VerifiedByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string VerifiedByUserID
        {
            get
            {
                return GetSystemString(ItemTransactionMetadata.ColumnNames.VerifiedByUserID);
            }

            set
            {
                if (SetSystemString(ItemTransactionMetadata.ColumnNames.VerifiedByUserID, value))
                {
                    OnPropertyChanged(ItemTransactionMetadata.PropertyNames.VerifiedByUserID);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return ItemTransactionMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public ItemTransactionQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new ItemTransactionQuery("itQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(ItemTransactionQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(ItemTransactionQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((ItemTransactionQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private ItemTransactionQuery query;
    }



    [Serializable]
    abstract public partial class esItemTransactionCollection : esEntityCollection<ItemTransaction>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return ItemTransactionMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "ItemTransactionCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public ItemTransactionQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new ItemTransactionQuery("itQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(ItemTransactionQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new ItemTransactionQuery("itQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(ItemTransactionQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((ItemTransactionQuery)query);
        }

        #endregion

        private ItemTransactionQuery query;
    }



    [Serializable]
    abstract public partial class esItemTransactionQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return ItemTransactionMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "TransactionNo": return TransactionNo;
                case "TransactionCode": return TransactionCode;
                case "TransactionDate": return TransactionDate;
                case "BusinessPartnerID": return BusinessPartnerID;
                case "InvoiceNo": return InvoiceNo;
                case "CurrencyID": return CurrencyID;
                case "CurrencyRate": return CurrencyRate;
                case "ReferenceNo": return ReferenceNo;
                case "ReferenceDate": return ReferenceDate;
                case "FromServiceUnitID": return FromServiceUnitID;
                case "FromLocationID": return FromLocationID;
                case "ToServiceUnitID": return ToServiceUnitID;
                case "ToLocationID": return ToLocationID;
                case "TermID": return TermID;
                case "SRItemType": return SRItemType;
                case "DiscountAmount": return DiscountAmount;
                case "ChargesAmount": return ChargesAmount;
                case "StampAmount": return StampAmount;
                case "DownPaymentAmount": return DownPaymentAmount;
                case "DownPaymentReferenceNo": return DownPaymentReferenceNo;
                case "SRDownPaymentType": return SRDownPaymentType;
                case "SRAdjustmentType": return SRAdjustmentType;
                case "SRDistributionType": return SRDistributionType;
                case "SRPurchaseReturnType": return SRPurchaseReturnType;
                case "SRPurchaseOrderType": return SRPurchaseOrderType;
                case "TaxPercentage": return TaxPercentage;
                case "TaxAmount": return TaxAmount;
                case "IsTaxable": return IsTaxable;
                case "IsVoid": return IsVoid;
                case "VoidDate": return VoidDate;
                case "VoidByUserID": return VoidByUserID;
                case "IsApproved": return IsApproved;
                case "ApprovedDate": return ApprovedDate;
                case "ApprovedByUserID": return ApprovedByUserID;
                case "IsClosed": return IsClosed;
                case "IsBySystem": return IsBySystem;
                case "IsNonMasterOrder": return IsNonMasterOrder;
                case "Notes": return Notes;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "ProductAccountID": return ProductAccountID;
                case "LeadTime": return LeadTime;
                case "Pph22": return Pph22;
                case "Pph23": return Pph23;
                case "ContractNo": return ContractNo;
                case "PriorChargesAmount": return PriorChargesAmount;
                case "PriorTaxAmount": return PriorTaxAmount;
                case "CustomerID": return CustomerID;
                case "TaxInvoiceNo": return TaxInvoiceNo;
                case "TaxInvoiceDate": return TaxInvoiceDate;
                case "SRPaymentType": return SRPaymentType;
                case "SRPurchaseCategorization": return SRPurchaseCategorization;
                case "IsInventoryItem": return IsInventoryItem;
                case "TermOfPayment": return TermOfPayment;
                case "IsAssets": return IsAssets;
                case "BudgetPlanCounter": return BudgetPlanCounter;
                case "ServiceUnitCostID": return ServiceUnitCostID;
                case "IsPph22InPercent": return IsPph22InPercent;
                case "Pph22Percentage": return Pph22Percentage;
                case "IsPph23InPercent": return IsPph23InPercent;
                case "Pph23Percentage": return Pph23Percentage;
                case "IsConsignment": return IsConsignment;
                case "AmountTaxed": return AmountTaxed;
                case "RevisionNumber": return RevisionNumber;
                case "PrintNumber": return PrintNumber;
                case "LastPrintedDateTime": return LastPrintedDateTime;
                case "LastPrintedByUserID": return LastPrintedByUserID;
                case "AdvanceAmount": return AdvanceAmount;
                case "DeliveryOrdersNo": return DeliveryOrdersNo;
                case "DeliveryOrdersDate": return DeliveryOrdersDate;
                case "PphAmount": return PphAmount;
                case "InvoiceSupplierDate": return InvoiceSupplierDate;
                case "CashTransactionReconcileId": return CashTransactionReconcileId;
                case "ItemGroupID": return ItemGroupID;
                case "SRPph": return SRPph;
                case "PphPercentage": return PphPercentage;
                case "IsConsignmentAlreadyReceived": return IsConsignmentAlreadyReceived;
                case "PlanningDate": return PlanningDate;
                case "IsInstallmentType": return IsInstallmentType;
                case "CreateDateTime": return CreateDateTime;
                case "CreateByUserID": return CreateByUserID;
                case "SRItemCategory": return SRItemCategory;
                case "SRProcurementType": return SRProcurementType;
                case "ContractDate": return ContractDate;
                case "CheckNo": return CheckNo;
                case "CheckDate": return CheckDate;
                case "SalesMarginPercentage": return SalesMarginPercentage;
                case "IsCito": return IsCito;
                case "IsVerified": return IsVerified;
                case "VerifiedDate": return VerifiedDate;
                case "VerifiedByUserID": return VerifiedByUserID;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem TransactionNo
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.TransactionNo, esSystemType.String); }
        }

        public esQueryItem TransactionCode
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.TransactionCode, esSystemType.String); }
        }

        public esQueryItem TransactionDate
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.TransactionDate, esSystemType.DateTime); }
        }

        public esQueryItem BusinessPartnerID
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.BusinessPartnerID, esSystemType.String); }
        }

        public esQueryItem InvoiceNo
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.InvoiceNo, esSystemType.String); }
        }

        public esQueryItem CurrencyID
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.CurrencyID, esSystemType.String); }
        }

        public esQueryItem CurrencyRate
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.CurrencyRate, esSystemType.Decimal); }
        }

        public esQueryItem ReferenceNo
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.ReferenceNo, esSystemType.String); }
        }

        public esQueryItem ReferenceDate
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.ReferenceDate, esSystemType.DateTime); }
        }

        public esQueryItem FromServiceUnitID
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.FromServiceUnitID, esSystemType.String); }
        }

        public esQueryItem FromLocationID
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.FromLocationID, esSystemType.String); }
        }

        public esQueryItem ToServiceUnitID
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.ToServiceUnitID, esSystemType.String); }
        }

        public esQueryItem ToLocationID
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.ToLocationID, esSystemType.String); }
        }

        public esQueryItem TermID
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.TermID, esSystemType.String); }
        }

        public esQueryItem SRItemType
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.SRItemType, esSystemType.String); }
        }

        public esQueryItem DiscountAmount
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.DiscountAmount, esSystemType.Decimal); }
        }

        public esQueryItem ChargesAmount
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.ChargesAmount, esSystemType.Decimal); }
        }

        public esQueryItem StampAmount
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.StampAmount, esSystemType.Decimal); }
        }

        public esQueryItem DownPaymentAmount
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.DownPaymentAmount, esSystemType.Decimal); }
        }

        public esQueryItem DownPaymentReferenceNo
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.DownPaymentReferenceNo, esSystemType.String); }
        }

        public esQueryItem SRDownPaymentType
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.SRDownPaymentType, esSystemType.String); }
        }

        public esQueryItem SRAdjustmentType
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.SRAdjustmentType, esSystemType.String); }
        }

        public esQueryItem SRDistributionType
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.SRDistributionType, esSystemType.String); }
        }

        public esQueryItem SRPurchaseReturnType
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.SRPurchaseReturnType, esSystemType.String); }
        }

        public esQueryItem SRPurchaseOrderType
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.SRPurchaseOrderType, esSystemType.String); }
        }

        public esQueryItem TaxPercentage
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.TaxPercentage, esSystemType.Decimal); }
        }

        public esQueryItem TaxAmount
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.TaxAmount, esSystemType.Decimal); }
        }

        public esQueryItem IsTaxable
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.IsTaxable, esSystemType.Int16); }
        }

        public esQueryItem IsVoid
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.IsVoid, esSystemType.Boolean); }
        }

        public esQueryItem VoidDate
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.VoidDate, esSystemType.DateTime); }
        }

        public esQueryItem VoidByUserID
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.VoidByUserID, esSystemType.String); }
        }

        public esQueryItem IsApproved
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.IsApproved, esSystemType.Boolean); }
        }

        public esQueryItem ApprovedDate
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.ApprovedDate, esSystemType.DateTime); }
        }

        public esQueryItem ApprovedByUserID
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.ApprovedByUserID, esSystemType.String); }
        }

        public esQueryItem IsClosed
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.IsClosed, esSystemType.Boolean); }
        }

        public esQueryItem IsBySystem
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.IsBySystem, esSystemType.Boolean); }
        }

        public esQueryItem IsNonMasterOrder
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.IsNonMasterOrder, esSystemType.Boolean); }
        }

        public esQueryItem Notes
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.Notes, esSystemType.String); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem ProductAccountID
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.ProductAccountID, esSystemType.String); }
        }

        public esQueryItem LeadTime
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.LeadTime, esSystemType.String); }
        }

        public esQueryItem Pph22
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.Pph22, esSystemType.Decimal); }
        }

        public esQueryItem Pph23
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.Pph23, esSystemType.Decimal); }
        }

        public esQueryItem ContractNo
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.ContractNo, esSystemType.String); }
        }

        public esQueryItem PriorChargesAmount
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.PriorChargesAmount, esSystemType.Decimal); }
        }

        public esQueryItem PriorTaxAmount
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.PriorTaxAmount, esSystemType.Decimal); }
        }

        public esQueryItem CustomerID
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.CustomerID, esSystemType.String); }
        }

        public esQueryItem TaxInvoiceNo
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.TaxInvoiceNo, esSystemType.String); }
        }

        public esQueryItem TaxInvoiceDate
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.TaxInvoiceDate, esSystemType.DateTime); }
        }

        public esQueryItem SRPaymentType
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.SRPaymentType, esSystemType.String); }
        }

        public esQueryItem SRPurchaseCategorization
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.SRPurchaseCategorization, esSystemType.String); }
        }

        public esQueryItem IsInventoryItem
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.IsInventoryItem, esSystemType.Boolean); }
        }

        public esQueryItem TermOfPayment
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.TermOfPayment, esSystemType.Decimal); }
        }

        public esQueryItem IsAssets
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.IsAssets, esSystemType.Boolean); }
        }

        public esQueryItem BudgetPlanCounter
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.BudgetPlanCounter, esSystemType.Int32); }
        }

        public esQueryItem ServiceUnitCostID
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.ServiceUnitCostID, esSystemType.String); }
        }

        public esQueryItem IsPph22InPercent
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.IsPph22InPercent, esSystemType.Boolean); }
        }

        public esQueryItem Pph22Percentage
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.Pph22Percentage, esSystemType.Decimal); }
        }

        public esQueryItem IsPph23InPercent
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.IsPph23InPercent, esSystemType.Boolean); }
        }

        public esQueryItem Pph23Percentage
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.Pph23Percentage, esSystemType.Decimal); }
        }

        public esQueryItem IsConsignment
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.IsConsignment, esSystemType.Boolean); }
        }

        public esQueryItem AmountTaxed
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.AmountTaxed, esSystemType.Decimal); }
        }

        public esQueryItem RevisionNumber
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.RevisionNumber, esSystemType.Int16); }
        }

        public esQueryItem PrintNumber
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.PrintNumber, esSystemType.Int16); }
        }

        public esQueryItem LastPrintedDateTime
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.LastPrintedDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastPrintedByUserID
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.LastPrintedByUserID, esSystemType.String); }
        }

        public esQueryItem AdvanceAmount
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.AdvanceAmount, esSystemType.Decimal); }
        }

        public esQueryItem DeliveryOrdersNo
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.DeliveryOrdersNo, esSystemType.String); }
        }

        public esQueryItem DeliveryOrdersDate
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.DeliveryOrdersDate, esSystemType.DateTime); }
        }

        public esQueryItem PphAmount
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.PphAmount, esSystemType.Decimal); }
        }

        public esQueryItem InvoiceSupplierDate
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.InvoiceSupplierDate, esSystemType.DateTime); }
        }

        public esQueryItem CashTransactionReconcileId
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.CashTransactionReconcileId, esSystemType.String); }
        }

        public esQueryItem ItemGroupID
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.ItemGroupID, esSystemType.String); }
        }

        public esQueryItem SRPph
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.SRPph, esSystemType.String); }
        }

        public esQueryItem PphPercentage
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.PphPercentage, esSystemType.Decimal); }
        }

        public esQueryItem IsConsignmentAlreadyReceived
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.IsConsignmentAlreadyReceived, esSystemType.Boolean); }
        }

        public esQueryItem PlanningDate
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.PlanningDate, esSystemType.DateTime); }
        }

        public esQueryItem IsInstallmentType
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.IsInstallmentType, esSystemType.Boolean); }
        }

        public esQueryItem CreateDateTime
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.CreateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem CreateByUserID
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.CreateByUserID, esSystemType.String); }
        }

        public esQueryItem SRItemCategory
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.SRItemCategory, esSystemType.String); }
        }

        public esQueryItem SRProcurementType
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.SRProcurementType, esSystemType.String); }
        }

        public esQueryItem ContractDate
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.ContractDate, esSystemType.DateTime); }
        }

        public esQueryItem CheckNo
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.CheckNo, esSystemType.String); }
        }

        public esQueryItem CheckDate
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.CheckDate, esSystemType.DateTime); }
        }

        public esQueryItem SalesMarginPercentage
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.SalesMarginPercentage, esSystemType.Decimal); }
        }

        public esQueryItem IsCito
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.IsCito, esSystemType.Boolean); }
        }

        public esQueryItem IsVerified
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.IsVerified, esSystemType.Boolean); }
        }

        public esQueryItem VerifiedDate
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.VerifiedDate, esSystemType.DateTime); }
        }

        public esQueryItem VerifiedByUserID
        {
            get { return new esQueryItem(this, ItemTransactionMetadata.ColumnNames.VerifiedByUserID, esSystemType.String); }
        }

        #endregion

    }



    [Serializable]
    public partial class ItemTransactionMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected ItemTransactionMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.TransactionNo, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TransactionNo;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TransactionCode, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TransactionCode;
            c.CharacterMaxLength = 3;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TransactionDate, 2, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.TransactionDate;
            c.HasDefault = true;
            c.Default = @"(getdate())";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.BusinessPartnerID, 3, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.BusinessPartnerID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.InvoiceNo, 4, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.InvoiceNo;
            c.CharacterMaxLength = 100;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CurrencyID, 5, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.CurrencyID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CurrencyRate, 6, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.CurrencyRate;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ReferenceNo, 7, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ReferenceNo;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ReferenceDate, 8, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.ReferenceDate;
            c.HasDefault = true;
            c.Default = @"(getdate())";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FromServiceUnitID, 9, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.FromServiceUnitID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FromLocationID, 10, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.FromLocationID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ToServiceUnitID, 11, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ToServiceUnitID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ToLocationID, 12, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ToLocationID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TermID, 13, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TermID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRItemType, 14, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRItemType;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DiscountAmount, 15, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.DiscountAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ChargesAmount, 16, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.ChargesAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.StampAmount, 17, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.StampAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DownPaymentAmount, 18, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.DownPaymentAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DownPaymentReferenceNo, 19, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DownPaymentReferenceNo;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRDownPaymentType, 20, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRDownPaymentType;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRAdjustmentType, 21, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRAdjustmentType;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRDistributionType, 22, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRDistributionType;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRPurchaseReturnType, 23, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRPurchaseReturnType;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRPurchaseOrderType, 24, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRPurchaseOrderType;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TaxPercentage, 25, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.TaxPercentage;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TaxAmount, 26, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.TaxAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsTaxable, 27, typeof(short), esSystemType.Int16);
            c.PropertyName = PropertyNames.IsTaxable;
            c.NumericPrecision = 5;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsVoid, 28, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsVoid;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.VoidDate, 29, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.VoidDate;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.VoidByUserID, 30, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.VoidByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsApproved, 31, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsApproved;
            c.HasDefault = true;
            c.Default = @"((0))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ApprovedDate, 32, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.ApprovedDate;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ApprovedByUserID, 33, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ApprovedByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsClosed, 34, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsClosed;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsBySystem, 35, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsBySystem;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsNonMasterOrder, 36, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsNonMasterOrder;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Notes, 37, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Notes;
            c.CharacterMaxLength = 4000;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 38, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 39, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 15;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ProductAccountID, 40, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ProductAccountID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LeadTime, 41, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LeadTime;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Pph22, 42, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.Pph22;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.HasDefault = true;
            c.Default = @"((0))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Pph23, 43, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.Pph23;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.HasDefault = true;
            c.Default = @"((0))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ContractNo, 44, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ContractNo;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PriorChargesAmount, 45, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.PriorChargesAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PriorTaxAmount, 46, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.PriorTaxAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CustomerID, 47, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.CustomerID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TaxInvoiceNo, 48, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TaxInvoiceNo;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TaxInvoiceDate, 49, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.TaxInvoiceDate;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRPaymentType, 50, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRPaymentType;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRPurchaseCategorization, 51, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRPurchaseCategorization;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsInventoryItem, 52, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsInventoryItem;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TermOfPayment, 53, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.TermOfPayment;
            c.NumericPrecision = 5;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsAssets, 54, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsAssets;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.BudgetPlanCounter, 55, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.BudgetPlanCounter;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ServiceUnitCostID, 56, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ServiceUnitCostID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsPph22InPercent, 57, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsPph22InPercent;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Pph22Percentage, 58, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.Pph22Percentage;
            c.NumericPrecision = 6;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsPph23InPercent, 59, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsPph23InPercent;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Pph23Percentage, 60, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.Pph23Percentage;
            c.NumericPrecision = 6;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsConsignment, 61, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsConsignment;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AmountTaxed, 62, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.AmountTaxed;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RevisionNumber, 63, typeof(short), esSystemType.Int16);
            c.PropertyName = PropertyNames.RevisionNumber;
            c.NumericPrecision = 5;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PrintNumber, 64, typeof(short), esSystemType.Int16);
            c.PropertyName = PropertyNames.PrintNumber;
            c.NumericPrecision = 5;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastPrintedDateTime, 65, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastPrintedDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastPrintedByUserID, 66, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastPrintedByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AdvanceAmount, 67, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.AdvanceAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DeliveryOrdersNo, 68, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DeliveryOrdersNo;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DeliveryOrdersDate, 69, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.DeliveryOrdersDate;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PphAmount, 70, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.PphAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.InvoiceSupplierDate, 71, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.InvoiceSupplierDate;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CashTransactionReconcileId, 72, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.CashTransactionReconcileId;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ItemGroupID, 73, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ItemGroupID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRPph, 74, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRPph;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PphPercentage, 75, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.PphPercentage;
            c.NumericPrecision = 6;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsConsignmentAlreadyReceived, 76, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsConsignmentAlreadyReceived;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PlanningDate, 77, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.PlanningDate;
            c.HasDefault = true;
            c.Default = @"(getdate())";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsInstallmentType, 78, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsInstallmentType;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreateDateTime, 79, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.CreateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreateByUserID, 80, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.CreateByUserID;
            c.CharacterMaxLength = 40;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRItemCategory, 81, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRItemCategory;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRProcurementType, 82, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRProcurementType;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ContractDate, 83, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.ContractDate;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CheckNo, 84, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.CheckNo;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CheckDate, 85, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.CheckDate;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SalesMarginPercentage, 86, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.SalesMarginPercentage;
            c.NumericPrecision = 5;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsCito, 87, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsCito;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsVerified, 88, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsVerified;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.VerifiedDate, 89, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.VerifiedDate;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.VerifiedByUserID, 90, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.VerifiedByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public ItemTransactionMetadata Meta()
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
            public const string TransactionCode = "TransactionCode";
            public const string TransactionDate = "TransactionDate";
            public const string BusinessPartnerID = "BusinessPartnerID";
            public const string InvoiceNo = "InvoiceNo";
            public const string CurrencyID = "CurrencyID";
            public const string CurrencyRate = "CurrencyRate";
            public const string ReferenceNo = "ReferenceNo";
            public const string ReferenceDate = "ReferenceDate";
            public const string FromServiceUnitID = "FromServiceUnitID";
            public const string FromLocationID = "FromLocationID";
            public const string ToServiceUnitID = "ToServiceUnitID";
            public const string ToLocationID = "ToLocationID";
            public const string TermID = "TermID";
            public const string SRItemType = "SRItemType";
            public const string DiscountAmount = "DiscountAmount";
            public const string ChargesAmount = "ChargesAmount";
            public const string StampAmount = "StampAmount";
            public const string DownPaymentAmount = "DownPaymentAmount";
            public const string DownPaymentReferenceNo = "DownPaymentReferenceNo";
            public const string SRDownPaymentType = "SRDownPaymentType";
            public const string SRAdjustmentType = "SRAdjustmentType";
            public const string SRDistributionType = "SRDistributionType";
            public const string SRPurchaseReturnType = "SRPurchaseReturnType";
            public const string SRPurchaseOrderType = "SRPurchaseOrderType";
            public const string TaxPercentage = "TaxPercentage";
            public const string TaxAmount = "TaxAmount";
            public const string IsTaxable = "IsTaxable";
            public const string IsVoid = "IsVoid";
            public const string VoidDate = "VoidDate";
            public const string VoidByUserID = "VoidByUserID";
            public const string IsApproved = "IsApproved";
            public const string ApprovedDate = "ApprovedDate";
            public const string ApprovedByUserID = "ApprovedByUserID";
            public const string IsClosed = "IsClosed";
            public const string IsBySystem = "IsBySystem";
            public const string IsNonMasterOrder = "IsNonMasterOrder";
            public const string Notes = "Notes";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string ProductAccountID = "ProductAccountID";
            public const string LeadTime = "LeadTime";
            public const string Pph22 = "Pph22";
            public const string Pph23 = "Pph23";
            public const string ContractNo = "ContractNo";
            public const string PriorChargesAmount = "PriorChargesAmount";
            public const string PriorTaxAmount = "PriorTaxAmount";
            public const string CustomerID = "CustomerID";
            public const string TaxInvoiceNo = "TaxInvoiceNo";
            public const string TaxInvoiceDate = "TaxInvoiceDate";
            public const string SRPaymentType = "SRPaymentType";
            public const string SRPurchaseCategorization = "SRPurchaseCategorization";
            public const string IsInventoryItem = "IsInventoryItem";
            public const string TermOfPayment = "TermOfPayment";
            public const string IsAssets = "IsAssets";
            public const string BudgetPlanCounter = "BudgetPlanCounter";
            public const string ServiceUnitCostID = "ServiceUnitCostID";
            public const string IsPph22InPercent = "IsPph22InPercent";
            public const string Pph22Percentage = "Pph22Percentage";
            public const string IsPph23InPercent = "IsPph23InPercent";
            public const string Pph23Percentage = "Pph23Percentage";
            public const string IsConsignment = "IsConsignment";
            public const string AmountTaxed = "AmountTaxed";
            public const string RevisionNumber = "RevisionNumber";
            public const string PrintNumber = "PrintNumber";
            public const string LastPrintedDateTime = "LastPrintedDateTime";
            public const string LastPrintedByUserID = "LastPrintedByUserID";
            public const string AdvanceAmount = "AdvanceAmount";
            public const string DeliveryOrdersNo = "DeliveryOrdersNo";
            public const string DeliveryOrdersDate = "DeliveryOrdersDate";
            public const string PphAmount = "PphAmount";
            public const string InvoiceSupplierDate = "InvoiceSupplierDate";
            public const string CashTransactionReconcileId = "CashTransactionReconcileId";
            public const string ItemGroupID = "ItemGroupID";
            public const string SRPph = "SRPph";
            public const string PphPercentage = "PphPercentage";
            public const string IsConsignmentAlreadyReceived = "IsConsignmentAlreadyReceived";
            public const string PlanningDate = "PlanningDate";
            public const string IsInstallmentType = "IsInstallmentType";
            public const string CreateDateTime = "CreateDateTime";
            public const string CreateByUserID = "CreateByUserID";
            public const string SRItemCategory = "SRItemCategory";
            public const string SRProcurementType = "SRProcurementType";
            public const string ContractDate = "ContractDate";
            public const string CheckNo = "CheckNo";
            public const string CheckDate = "CheckDate";
            public const string SalesMarginPercentage = "SalesMarginPercentage";
            public const string IsCito = "IsCito";
            public const string IsVerified = "IsVerified";
            public const string VerifiedDate = "VerifiedDate";
            public const string VerifiedByUserID = "VerifiedByUserID";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string TransactionNo = "TransactionNo";
            public const string TransactionCode = "TransactionCode";
            public const string TransactionDate = "TransactionDate";
            public const string BusinessPartnerID = "BusinessPartnerID";
            public const string InvoiceNo = "InvoiceNo";
            public const string CurrencyID = "CurrencyID";
            public const string CurrencyRate = "CurrencyRate";
            public const string ReferenceNo = "ReferenceNo";
            public const string ReferenceDate = "ReferenceDate";
            public const string FromServiceUnitID = "FromServiceUnitID";
            public const string FromLocationID = "FromLocationID";
            public const string ToServiceUnitID = "ToServiceUnitID";
            public const string ToLocationID = "ToLocationID";
            public const string TermID = "TermID";
            public const string SRItemType = "SRItemType";
            public const string DiscountAmount = "DiscountAmount";
            public const string ChargesAmount = "ChargesAmount";
            public const string StampAmount = "StampAmount";
            public const string DownPaymentAmount = "DownPaymentAmount";
            public const string DownPaymentReferenceNo = "DownPaymentReferenceNo";
            public const string SRDownPaymentType = "SRDownPaymentType";
            public const string SRAdjustmentType = "SRAdjustmentType";
            public const string SRDistributionType = "SRDistributionType";
            public const string SRPurchaseReturnType = "SRPurchaseReturnType";
            public const string SRPurchaseOrderType = "SRPurchaseOrderType";
            public const string TaxPercentage = "TaxPercentage";
            public const string TaxAmount = "TaxAmount";
            public const string IsTaxable = "IsTaxable";
            public const string IsVoid = "IsVoid";
            public const string VoidDate = "VoidDate";
            public const string VoidByUserID = "VoidByUserID";
            public const string IsApproved = "IsApproved";
            public const string ApprovedDate = "ApprovedDate";
            public const string ApprovedByUserID = "ApprovedByUserID";
            public const string IsClosed = "IsClosed";
            public const string IsBySystem = "IsBySystem";
            public const string IsNonMasterOrder = "IsNonMasterOrder";
            public const string Notes = "Notes";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string ProductAccountID = "ProductAccountID";
            public const string LeadTime = "LeadTime";
            public const string Pph22 = "Pph22";
            public const string Pph23 = "Pph23";
            public const string ContractNo = "ContractNo";
            public const string PriorChargesAmount = "PriorChargesAmount";
            public const string PriorTaxAmount = "PriorTaxAmount";
            public const string CustomerID = "CustomerID";
            public const string TaxInvoiceNo = "TaxInvoiceNo";
            public const string TaxInvoiceDate = "TaxInvoiceDate";
            public const string SRPaymentType = "SRPaymentType";
            public const string SRPurchaseCategorization = "SRPurchaseCategorization";
            public const string IsInventoryItem = "IsInventoryItem";
            public const string TermOfPayment = "TermOfPayment";
            public const string IsAssets = "IsAssets";
            public const string BudgetPlanCounter = "BudgetPlanCounter";
            public const string ServiceUnitCostID = "ServiceUnitCostID";
            public const string IsPph22InPercent = "IsPph22InPercent";
            public const string Pph22Percentage = "Pph22Percentage";
            public const string IsPph23InPercent = "IsPph23InPercent";
            public const string Pph23Percentage = "Pph23Percentage";
            public const string IsConsignment = "IsConsignment";
            public const string AmountTaxed = "AmountTaxed";
            public const string RevisionNumber = "RevisionNumber";
            public const string PrintNumber = "PrintNumber";
            public const string LastPrintedDateTime = "LastPrintedDateTime";
            public const string LastPrintedByUserID = "LastPrintedByUserID";
            public const string AdvanceAmount = "AdvanceAmount";
            public const string DeliveryOrdersNo = "DeliveryOrdersNo";
            public const string DeliveryOrdersDate = "DeliveryOrdersDate";
            public const string PphAmount = "PphAmount";
            public const string InvoiceSupplierDate = "InvoiceSupplierDate";
            public const string CashTransactionReconcileId = "CashTransactionReconcileId";
            public const string ItemGroupID = "ItemGroupID";
            public const string SRPph = "SRPph";
            public const string PphPercentage = "PphPercentage";
            public const string IsConsignmentAlreadyReceived = "IsConsignmentAlreadyReceived";
            public const string PlanningDate = "PlanningDate";
            public const string IsInstallmentType = "IsInstallmentType";
            public const string CreateDateTime = "CreateDateTime";
            public const string CreateByUserID = "CreateByUserID";
            public const string SRItemCategory = "SRItemCategory";
            public const string SRProcurementType = "SRProcurementType";
            public const string ContractDate = "ContractDate";
            public const string CheckNo = "CheckNo";
            public const string CheckDate = "CheckDate";
            public const string SalesMarginPercentage = "SalesMarginPercentage";
            public const string IsCito = "IsCito";
            public const string IsVerified = "IsVerified";
            public const string VerifiedDate = "VerifiedDate";
            public const string VerifiedByUserID = "VerifiedByUserID";
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
            lock (typeof(ItemTransactionMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new ItemTransactionMetadata();
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
                meta.AddTypeMap("TransactionCode", new esTypeMap("char", "System.String"));
                meta.AddTypeMap("TransactionDate", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("BusinessPartnerID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("InvoiceNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CurrencyID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CurrencyRate", new esTypeMap("decimal", "System.Decimal"));
                meta.AddTypeMap("ReferenceNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ReferenceDate", new esTypeMap("smalldatetime", "System.DateTime"));
                meta.AddTypeMap("FromServiceUnitID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("FromLocationID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ToServiceUnitID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ToLocationID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TermID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRItemType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("DiscountAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("ChargesAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("StampAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("DownPaymentAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("DownPaymentReferenceNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRDownPaymentType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRAdjustmentType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRDistributionType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRPurchaseReturnType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRPurchaseOrderType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TaxPercentage", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("TaxAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("IsTaxable", new esTypeMap("smallint", "System.Int16"));
                meta.AddTypeMap("IsVoid", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("VoidDate", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("VoidByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsApproved", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ApprovedDate", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("ApprovedByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsClosed", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsBySystem", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsNonMasterOrder", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("Notes", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ProductAccountID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LeadTime", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Pph22", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("Pph23", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("ContractNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PriorChargesAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("PriorTaxAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("CustomerID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TaxInvoiceNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TaxInvoiceDate", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("SRPaymentType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRPurchaseCategorization", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsInventoryItem", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("TermOfPayment", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("IsAssets", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("BudgetPlanCounter", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("ServiceUnitCostID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsPph22InPercent", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("Pph22Percentage", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("IsPph23InPercent", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("Pph23Percentage", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("IsConsignment", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("AmountTaxed", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("RevisionNumber", new esTypeMap("smallint", "System.Int16"));
                meta.AddTypeMap("PrintNumber", new esTypeMap("smallint", "System.Int16"));
                meta.AddTypeMap("LastPrintedDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastPrintedByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("AdvanceAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("DeliveryOrdersNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("DeliveryOrdersDate", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("PphAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("InvoiceSupplierDate", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("CashTransactionReconcileId", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ItemGroupID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRPph", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PphPercentage", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("IsConsignmentAlreadyReceived", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("PlanningDate", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("IsInstallmentType", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("CreateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("CreateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRItemCategory", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRProcurementType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ContractDate", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("CheckNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CheckDate", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("SalesMarginPercentage", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("IsCito", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsVerified", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("VerifiedDate", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("VerifiedByUserID", new esTypeMap("varchar", "System.String"));



                meta.Source = "ItemTransaction";
                meta.Destination = "ItemTransaction";

                meta.spInsert = "proc_ItemTransactionInsert";
                meta.spUpdate = "proc_ItemTransactionUpdate";
                meta.spDelete = "proc_ItemTransactionDelete";
                meta.spLoadAll = "proc_ItemTransactionLoadAll";
                meta.spLoadByPrimaryKey = "proc_ItemTransactionLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private ItemTransactionMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
