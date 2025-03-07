
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 2/12/2025 11:52:22 AM
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
    /// Encapsulates the 'TransChargesItem' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(TransChargesItem))]
    [XmlType("TransChargesItem")]
    public partial class TransChargesItem : esTransChargesItem
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new TransChargesItem();
        }

        #region Static Quick Access Methods
        static public void Delete(string sequenceNo, string transactionNo)
        {
            var obj = new TransChargesItem();
            obj.SequenceNo = sequenceNo;
            obj.TransactionNo = transactionNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string sequenceNo, string transactionNo, esSqlAccessType sqlAccessType)
        {
            var obj = new TransChargesItem();
            obj.SequenceNo = sequenceNo;
            obj.TransactionNo = transactionNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("TransChargesItemCollection")]
    public partial class TransChargesItemCollection : esTransChargesItemCollection, IEnumerable<TransChargesItem>
    {
        public TransChargesItem FindByPrimaryKey(string sequenceNo, string transactionNo)
        {
            return this.SingleOrDefault(e => e.SequenceNo == sequenceNo && e.TransactionNo == transactionNo);
        }



    }



    [Serializable]
    public partial class TransChargesItemQuery : esTransChargesItemQuery
    {
        public TransChargesItemQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public TransChargesItemQuery(string joinAlias, out TransChargesItemQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "TransChargesItemQuery";
        }



        #region Explicit Casts

        public static explicit operator string(TransChargesItemQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator TransChargesItemQuery(string query)
        {
            return (TransChargesItemQuery)SerializeHelper.FromXml(query, typeof(TransChargesItemQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esTransChargesItem : esEntity
    {
        public esTransChargesItem()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string sequenceNo, string transactionNo)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(sequenceNo, transactionNo);
            else
                return LoadByPrimaryKeyStoredProcedure(sequenceNo, transactionNo);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string sequenceNo, string transactionNo)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(sequenceNo, transactionNo);
            else
                return LoadByPrimaryKeyStoredProcedure(sequenceNo, transactionNo);
        }

        private bool LoadByPrimaryKeyDynamic(string sequenceNo, string transactionNo)
        {
            TransChargesItemQuery query = new TransChargesItemQuery("tciQ");
            query.Where(query.SequenceNo == sequenceNo, query.TransactionNo == transactionNo);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string sequenceNo, string transactionNo)
        {
            esParameters parms = new esParameters();
            parms.Add("SequenceNo", sequenceNo); parms.Add("TransactionNo", transactionNo);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to TransChargesItem.TransactionNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TransactionNo
        {
            get
            {
                return GetSystemString(TransChargesItemMetadata.ColumnNames.TransactionNo);
            }

            set
            {
                if (SetSystemString(TransChargesItemMetadata.ColumnNames.TransactionNo, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.TransactionNo);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.SequenceNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SequenceNo
        {
            get
            {
                return GetSystemString(TransChargesItemMetadata.ColumnNames.SequenceNo);
            }

            set
            {
                if (SetSystemString(TransChargesItemMetadata.ColumnNames.SequenceNo, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.SequenceNo);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.ReferenceNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ReferenceNo
        {
            get
            {
                return GetSystemString(TransChargesItemMetadata.ColumnNames.ReferenceNo);
            }

            set
            {
                if (SetSystemString(TransChargesItemMetadata.ColumnNames.ReferenceNo, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.ReferenceNo);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.ReferenceSequenceNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ReferenceSequenceNo
        {
            get
            {
                return GetSystemString(TransChargesItemMetadata.ColumnNames.ReferenceSequenceNo);
            }

            set
            {
                if (SetSystemString(TransChargesItemMetadata.ColumnNames.ReferenceSequenceNo, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.ReferenceSequenceNo);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.ItemID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ItemID
        {
            get
            {
                return GetSystemString(TransChargesItemMetadata.ColumnNames.ItemID);
            }

            set
            {
                if (SetSystemString(TransChargesItemMetadata.ColumnNames.ItemID, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.ItemID);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.ChargeClassID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ChargeClassID
        {
            get
            {
                return GetSystemString(TransChargesItemMetadata.ColumnNames.ChargeClassID);
            }

            set
            {
                if (SetSystemString(TransChargesItemMetadata.ColumnNames.ChargeClassID, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.ChargeClassID);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.ParamedicID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParamedicID
        {
            get
            {
                return GetSystemString(TransChargesItemMetadata.ColumnNames.ParamedicID);
            }

            set
            {
                if (SetSystemString(TransChargesItemMetadata.ColumnNames.ParamedicID, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.ParamedicID);
                }
            }
        }

        /// <summary>
        /// Diisi untuk rawat inap oelh Dokter Pengganti atau dokter anestesi
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SecondParamedicID
        {
            get
            {
                return GetSystemString(TransChargesItemMetadata.ColumnNames.SecondParamedicID);
            }

            set
            {
                if (SetSystemString(TransChargesItemMetadata.ColumnNames.SecondParamedicID, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.SecondParamedicID);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.IsAdminCalculation
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsAdminCalculation
        {
            get
            {
                return GetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsAdminCalculation);
            }

            set
            {
                if (SetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsAdminCalculation, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.IsAdminCalculation);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.IsVariable
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsVariable
        {
            get
            {
                return GetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsVariable);
            }

            set
            {
                if (SetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsVariable, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.IsVariable);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.IsCito
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsCito
        {
            get
            {
                return GetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsCito);
            }

            set
            {
                if (SetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsCito, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.IsCito);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.ChargeQuantity
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? ChargeQuantity
        {
            get
            {
                return GetSystemDecimal(TransChargesItemMetadata.ColumnNames.ChargeQuantity);
            }

            set
            {
                if (SetSystemDecimal(TransChargesItemMetadata.ColumnNames.ChargeQuantity, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.ChargeQuantity);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.StockQuantity
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? StockQuantity
        {
            get
            {
                return GetSystemDecimal(TransChargesItemMetadata.ColumnNames.StockQuantity);
            }

            set
            {
                if (SetSystemDecimal(TransChargesItemMetadata.ColumnNames.StockQuantity, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.StockQuantity);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.SRItemUnit
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRItemUnit
        {
            get
            {
                return GetSystemString(TransChargesItemMetadata.ColumnNames.SRItemUnit);
            }

            set
            {
                if (SetSystemString(TransChargesItemMetadata.ColumnNames.SRItemUnit, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.SRItemUnit);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.CostPrice
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? CostPrice
        {
            get
            {
                return GetSystemDecimal(TransChargesItemMetadata.ColumnNames.CostPrice);
            }

            set
            {
                if (SetSystemDecimal(TransChargesItemMetadata.ColumnNames.CostPrice, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.CostPrice);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.Price
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? Price
        {
            get
            {
                return GetSystemDecimal(TransChargesItemMetadata.ColumnNames.Price);
            }

            set
            {
                if (SetSystemDecimal(TransChargesItemMetadata.ColumnNames.Price, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.Price);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.DiscountAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? DiscountAmount
        {
            get
            {
                return GetSystemDecimal(TransChargesItemMetadata.ColumnNames.DiscountAmount);
            }

            set
            {
                if (SetSystemDecimal(TransChargesItemMetadata.ColumnNames.DiscountAmount, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.DiscountAmount);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.CitoAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? CitoAmount
        {
            get
            {
                return GetSystemDecimal(TransChargesItemMetadata.ColumnNames.CitoAmount);
            }

            set
            {
                if (SetSystemDecimal(TransChargesItemMetadata.ColumnNames.CitoAmount, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.CitoAmount);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.RoundingAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? RoundingAmount
        {
            get
            {
                return GetSystemDecimal(TransChargesItemMetadata.ColumnNames.RoundingAmount);
            }

            set
            {
                if (SetSystemDecimal(TransChargesItemMetadata.ColumnNames.RoundingAmount, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.RoundingAmount);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.SRDiscountReason
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRDiscountReason
        {
            get
            {
                return GetSystemString(TransChargesItemMetadata.ColumnNames.SRDiscountReason);
            }

            set
            {
                if (SetSystemString(TransChargesItemMetadata.ColumnNames.SRDiscountReason, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.SRDiscountReason);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.IsAssetUtilization
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsAssetUtilization
        {
            get
            {
                return GetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsAssetUtilization);
            }

            set
            {
                if (SetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsAssetUtilization, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.IsAssetUtilization);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.AssetID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string AssetID
        {
            get
            {
                return GetSystemString(TransChargesItemMetadata.ColumnNames.AssetID);
            }

            set
            {
                if (SetSystemString(TransChargesItemMetadata.ColumnNames.AssetID, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.AssetID);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.IsBillProceed
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsBillProceed
        {
            get
            {
                return GetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsBillProceed);
            }

            set
            {
                if (SetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsBillProceed, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.IsBillProceed);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.IsOrderRealization
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsOrderRealization
        {
            get
            {
                return GetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsOrderRealization);
            }

            set
            {
                if (SetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsOrderRealization, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.IsOrderRealization);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.IsPackage
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsPackage
        {
            get
            {
                return GetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsPackage);
            }

            set
            {
                if (SetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsPackage, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.IsPackage);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.IsApprove
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsApprove
        {
            get
            {
                return GetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsApprove);
            }

            set
            {
                if (SetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsApprove, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.IsApprove);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.IsVoid
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsVoid
        {
            get
            {
                return GetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsVoid);
            }

            set
            {
                if (SetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsVoid, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.IsVoid);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.Notes
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Notes
        {
            get
            {
                return GetSystemString(TransChargesItemMetadata.ColumnNames.Notes);
            }

            set
            {
                if (SetSystemString(TransChargesItemMetadata.ColumnNames.Notes, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.Notes);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.FilmNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string FilmNo
        {
            get
            {
                return GetSystemString(TransChargesItemMetadata.ColumnNames.FilmNo);
            }

            set
            {
                if (SetSystemString(TransChargesItemMetadata.ColumnNames.FilmNo, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.FilmNo);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(TransChargesItemMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(TransChargesItemMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(TransChargesItemMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(TransChargesItemMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.ParentNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParentNo
        {
            get
            {
                return GetSystemString(TransChargesItemMetadata.ColumnNames.ParentNo);
            }

            set
            {
                if (SetSystemString(TransChargesItemMetadata.ColumnNames.ParentNo, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.ParentNo);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.SRCenterID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRCenterID
        {
            get
            {
                return GetSystemString(TransChargesItemMetadata.ColumnNames.SRCenterID);
            }

            set
            {
                if (SetSystemString(TransChargesItemMetadata.ColumnNames.SRCenterID, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.SRCenterID);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.AutoProcessCalculation
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? AutoProcessCalculation
        {
            get
            {
                return GetSystemDecimal(TransChargesItemMetadata.ColumnNames.AutoProcessCalculation);
            }

            set
            {
                if (SetSystemDecimal(TransChargesItemMetadata.ColumnNames.AutoProcessCalculation, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.AutoProcessCalculation);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.ParamedicCollectionName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParamedicCollectionName
        {
            get
            {
                return GetSystemString(TransChargesItemMetadata.ColumnNames.ParamedicCollectionName);
            }

            set
            {
                if (SetSystemString(TransChargesItemMetadata.ColumnNames.ParamedicCollectionName, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.ParamedicCollectionName);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.ToServiceUnitID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ToServiceUnitID
        {
            get
            {
                return GetSystemString(TransChargesItemMetadata.ColumnNames.ToServiceUnitID);
            }

            set
            {
                if (SetSystemString(TransChargesItemMetadata.ColumnNames.ToServiceUnitID, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.ToServiceUnitID);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.RealizationDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? RealizationDateTime
        {
            get
            {
                return GetSystemDateTime(TransChargesItemMetadata.ColumnNames.RealizationDateTime);
            }

            set
            {
                if (SetSystemDateTime(TransChargesItemMetadata.ColumnNames.RealizationDateTime, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.RealizationDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.RealizationUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RealizationUserID
        {
            get
            {
                return GetSystemString(TransChargesItemMetadata.ColumnNames.RealizationUserID);
            }

            set
            {
                if (SetSystemString(TransChargesItemMetadata.ColumnNames.RealizationUserID, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.RealizationUserID);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.UpdateRealizationDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? UpdateRealizationDateTime
        {
            get
            {
                return GetSystemDateTime(TransChargesItemMetadata.ColumnNames.UpdateRealizationDateTime);
            }

            set
            {
                if (SetSystemDateTime(TransChargesItemMetadata.ColumnNames.UpdateRealizationDateTime, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.UpdateRealizationDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.UpdateRealizationUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string UpdateRealizationUserID
        {
            get
            {
                return GetSystemString(TransChargesItemMetadata.ColumnNames.UpdateRealizationUserID);
            }

            set
            {
                if (SetSystemString(TransChargesItemMetadata.ColumnNames.UpdateRealizationUserID, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.UpdateRealizationUserID);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.IsCitoInPercent
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsCitoInPercent
        {
            get
            {
                return GetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsCitoInPercent);
            }

            set
            {
                if (SetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsCitoInPercent, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.IsCitoInPercent);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.BasicCitoAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? BasicCitoAmount
        {
            get
            {
                return GetSystemDecimal(TransChargesItemMetadata.ColumnNames.BasicCitoAmount);
            }

            set
            {
                if (SetSystemDecimal(TransChargesItemMetadata.ColumnNames.BasicCitoAmount, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.BasicCitoAmount);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.IsItemRoom
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsItemRoom
        {
            get
            {
                return GetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsItemRoom);
            }

            set
            {
                if (SetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsItemRoom, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.IsItemRoom);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.IsExtraItem
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsExtraItem
        {
            get
            {
                return GetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsExtraItem);
            }

            set
            {
                if (SetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsExtraItem, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.IsExtraItem);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.IsSelectedExtraItem
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsSelectedExtraItem
        {
            get
            {
                return GetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsSelectedExtraItem);
            }

            set
            {
                if (SetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsSelectedExtraItem, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.IsSelectedExtraItem);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.IsSendToLIS
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsSendToLIS
        {
            get
            {
                return GetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsSendToLIS);
            }

            set
            {
                if (SetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsSendToLIS, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.IsSendToLIS);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.CreatedDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? CreatedDateTime
        {
            get
            {
                return GetSystemDateTime(TransChargesItemMetadata.ColumnNames.CreatedDateTime);
            }

            set
            {
                if (SetSystemDateTime(TransChargesItemMetadata.ColumnNames.CreatedDateTime, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.CreatedDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.CreatedByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string CreatedByUserID
        {
            get
            {
                return GetSystemString(TransChargesItemMetadata.ColumnNames.CreatedByUserID);
            }

            set
            {
                if (SetSystemString(TransChargesItemMetadata.ColumnNames.CreatedByUserID, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.CreatedByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.IsCorrection
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsCorrection
        {
            get
            {
                return GetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsCorrection);
            }

            set
            {
                if (SetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsCorrection, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.IsCorrection);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.ResultValue
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ResultValue
        {
            get
            {
                return GetSystemString(TransChargesItemMetadata.ColumnNames.ResultValue);
            }

            set
            {
                if (SetSystemString(TransChargesItemMetadata.ColumnNames.ResultValue, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.ResultValue);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.IsDuplo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsDuplo
        {
            get
            {
                return GetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsDuplo);
            }

            set
            {
                if (SetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsDuplo, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.IsDuplo);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.IsPaymentConfirmed
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsPaymentConfirmed
        {
            get
            {
                return GetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsPaymentConfirmed);
            }

            set
            {
                if (SetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsPaymentConfirmed, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.IsPaymentConfirmed);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.PaymentConfirmedDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? PaymentConfirmedDateTime
        {
            get
            {
                return GetSystemDateTime(TransChargesItemMetadata.ColumnNames.PaymentConfirmedDateTime);
            }

            set
            {
                if (SetSystemDateTime(TransChargesItemMetadata.ColumnNames.PaymentConfirmedDateTime, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.PaymentConfirmedDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.PaymentConfirmedBy
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PaymentConfirmedBy
        {
            get
            {
                return GetSystemString(TransChargesItemMetadata.ColumnNames.PaymentConfirmedBy);
            }

            set
            {
                if (SetSystemString(TransChargesItemMetadata.ColumnNames.PaymentConfirmedBy, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.PaymentConfirmedBy);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.LastPaymentConfirmedDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastPaymentConfirmedDateTime
        {
            get
            {
                return GetSystemDateTime(TransChargesItemMetadata.ColumnNames.LastPaymentConfirmedDateTime);
            }

            set
            {
                if (SetSystemDateTime(TransChargesItemMetadata.ColumnNames.LastPaymentConfirmedDateTime, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.LastPaymentConfirmedDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.LastPaymentConfirmedByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastPaymentConfirmedByUserID
        {
            get
            {
                return GetSystemString(TransChargesItemMetadata.ColumnNames.LastPaymentConfirmedByUserID);
            }

            set
            {
                if (SetSystemString(TransChargesItemMetadata.ColumnNames.LastPaymentConfirmedByUserID, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.LastPaymentConfirmedByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.IsDescriptionResult
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsDescriptionResult
        {
            get
            {
                return GetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsDescriptionResult);
            }

            set
            {
                if (SetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsDescriptionResult, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.IsDescriptionResult);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.PriceAdjusted
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? PriceAdjusted
        {
            get
            {
                return GetSystemDecimal(TransChargesItemMetadata.ColumnNames.PriceAdjusted);
            }

            set
            {
                if (SetSystemDecimal(TransChargesItemMetadata.ColumnNames.PriceAdjusted, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.PriceAdjusted);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.SRCitoPercentage
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRCitoPercentage
        {
            get
            {
                return GetSystemString(TransChargesItemMetadata.ColumnNames.SRCitoPercentage);
            }

            set
            {
                if (SetSystemString(TransChargesItemMetadata.ColumnNames.SRCitoPercentage, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.SRCitoPercentage);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.ItemConditionRuleID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ItemConditionRuleID
        {
            get
            {
                return GetSystemString(TransChargesItemMetadata.ColumnNames.ItemConditionRuleID);
            }

            set
            {
                if (SetSystemString(TransChargesItemMetadata.ColumnNames.ItemConditionRuleID, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.ItemConditionRuleID);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.CommunicationID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string CommunicationID
        {
            get
            {
                return GetSystemString(TransChargesItemMetadata.ColumnNames.CommunicationID);
            }

            set
            {
                if (SetSystemString(TransChargesItemMetadata.ColumnNames.CommunicationID, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.CommunicationID);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.IsCasemixApproved
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsCasemixApproved
        {
            get
            {
                return GetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsCasemixApproved);
            }

            set
            {
                if (SetSystemBoolean(TransChargesItemMetadata.ColumnNames.IsCasemixApproved, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.IsCasemixApproved);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.CasemixApprovedDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? CasemixApprovedDateTime
        {
            get
            {
                return GetSystemDateTime(TransChargesItemMetadata.ColumnNames.CasemixApprovedDateTime);
            }

            set
            {
                if (SetSystemDateTime(TransChargesItemMetadata.ColumnNames.CasemixApprovedDateTime, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.CasemixApprovedDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.CasemixApprovedByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string CasemixApprovedByUserID
        {
            get
            {
                return GetSystemString(TransChargesItemMetadata.ColumnNames.CasemixApprovedByUserID);
            }

            set
            {
                if (SetSystemString(TransChargesItemMetadata.ColumnNames.CasemixApprovedByUserID, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.CasemixApprovedByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.TariffDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? TariffDate
        {
            get
            {
                return GetSystemDateTime(TransChargesItemMetadata.ColumnNames.TariffDate);
            }

            set
            {
                if (SetSystemDateTime(TransChargesItemMetadata.ColumnNames.TariffDate, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.TariffDate);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.SpecimenTakenDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? SpecimenTakenDateTime
        {
            get
            {
                return GetSystemDateTime(TransChargesItemMetadata.ColumnNames.SpecimenTakenDateTime);
            }

            set
            {
                if (SetSystemDateTime(TransChargesItemMetadata.ColumnNames.SpecimenTakenDateTime, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.SpecimenTakenDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.SpecimenTakenByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SpecimenTakenByUserID
        {
            get
            {
                return GetSystemString(TransChargesItemMetadata.ColumnNames.SpecimenTakenByUserID);
            }

            set
            {
                if (SetSystemString(TransChargesItemMetadata.ColumnNames.SpecimenTakenByUserID, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.SpecimenTakenByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.SpecimenSubmittedDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? SpecimenSubmittedDateTime
        {
            get
            {
                return GetSystemDateTime(TransChargesItemMetadata.ColumnNames.SpecimenSubmittedDateTime);
            }

            set
            {
                if (SetSystemDateTime(TransChargesItemMetadata.ColumnNames.SpecimenSubmittedDateTime, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.SpecimenSubmittedDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.SpecimenSubmittedByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SpecimenSubmittedByUserID
        {
            get
            {
                return GetSystemString(TransChargesItemMetadata.ColumnNames.SpecimenSubmittedByUserID);
            }

            set
            {
                if (SetSystemString(TransChargesItemMetadata.ColumnNames.SpecimenSubmittedByUserID, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.SpecimenSubmittedByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.SpecimenReceivedDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? SpecimenReceivedDateTime
        {
            get
            {
                return GetSystemDateTime(TransChargesItemMetadata.ColumnNames.SpecimenReceivedDateTime);
            }

            set
            {
                if (SetSystemDateTime(TransChargesItemMetadata.ColumnNames.SpecimenReceivedDateTime, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.SpecimenReceivedDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.SpecimenReceivedByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SpecimenReceivedByUserID
        {
            get
            {
                return GetSystemString(TransChargesItemMetadata.ColumnNames.SpecimenReceivedByUserID);
            }

            set
            {
                if (SetSystemString(TransChargesItemMetadata.ColumnNames.SpecimenReceivedByUserID, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.SpecimenReceivedByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.VoidDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? VoidDateTime
        {
            get
            {
                return GetSystemDateTime(TransChargesItemMetadata.ColumnNames.VoidDateTime);
            }

            set
            {
                if (SetSystemDateTime(TransChargesItemMetadata.ColumnNames.VoidDateTime, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.VoidDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItem.VoidByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string VoidByUserID
        {
            get
            {
                return GetSystemString(TransChargesItemMetadata.ColumnNames.VoidByUserID);
            }

            set
            {
                if (SetSystemString(TransChargesItemMetadata.ColumnNames.VoidByUserID, value))
                {
                    OnPropertyChanged(TransChargesItemMetadata.PropertyNames.VoidByUserID);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return TransChargesItemMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public TransChargesItemQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new TransChargesItemQuery("tciQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(TransChargesItemQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(TransChargesItemQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((TransChargesItemQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private TransChargesItemQuery query;
    }



    [Serializable]
    abstract public partial class esTransChargesItemCollection : esEntityCollection<TransChargesItem>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return TransChargesItemMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "TransChargesItemCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public TransChargesItemQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new TransChargesItemQuery("tciQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(TransChargesItemQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new TransChargesItemQuery("tciQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(TransChargesItemQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((TransChargesItemQuery)query);
        }

        #endregion

        private TransChargesItemQuery query;
    }



    [Serializable]
    abstract public partial class esTransChargesItemQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return TransChargesItemMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "TransactionNo": return TransactionNo;
                case "SequenceNo": return SequenceNo;
                case "ReferenceNo": return ReferenceNo;
                case "ReferenceSequenceNo": return ReferenceSequenceNo;
                case "ItemID": return ItemID;
                case "ChargeClassID": return ChargeClassID;
                case "ParamedicID": return ParamedicID;
                case "SecondParamedicID": return SecondParamedicID;
                case "IsAdminCalculation": return IsAdminCalculation;
                case "IsVariable": return IsVariable;
                case "IsCito": return IsCito;
                case "ChargeQuantity": return ChargeQuantity;
                case "StockQuantity": return StockQuantity;
                case "SRItemUnit": return SRItemUnit;
                case "CostPrice": return CostPrice;
                case "Price": return Price;
                case "DiscountAmount": return DiscountAmount;
                case "CitoAmount": return CitoAmount;
                case "RoundingAmount": return RoundingAmount;
                case "SRDiscountReason": return SRDiscountReason;
                case "IsAssetUtilization": return IsAssetUtilization;
                case "AssetID": return AssetID;
                case "IsBillProceed": return IsBillProceed;
                case "IsOrderRealization": return IsOrderRealization;
                case "IsPackage": return IsPackage;
                case "IsApprove": return IsApprove;
                case "IsVoid": return IsVoid;
                case "Notes": return Notes;
                case "FilmNo": return FilmNo;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "ParentNo": return ParentNo;
                case "SRCenterID": return SRCenterID;
                case "AutoProcessCalculation": return AutoProcessCalculation;
                case "ParamedicCollectionName": return ParamedicCollectionName;
                case "ToServiceUnitID": return ToServiceUnitID;
                case "RealizationDateTime": return RealizationDateTime;
                case "RealizationUserID": return RealizationUserID;
                case "UpdateRealizationDateTime": return UpdateRealizationDateTime;
                case "UpdateRealizationUserID": return UpdateRealizationUserID;
                case "IsCitoInPercent": return IsCitoInPercent;
                case "BasicCitoAmount": return BasicCitoAmount;
                case "IsItemRoom": return IsItemRoom;
                case "IsExtraItem": return IsExtraItem;
                case "IsSelectedExtraItem": return IsSelectedExtraItem;
                case "IsSendToLIS": return IsSendToLIS;
                case "CreatedDateTime": return CreatedDateTime;
                case "CreatedByUserID": return CreatedByUserID;
                case "IsCorrection": return IsCorrection;
                case "ResultValue": return ResultValue;
                case "IsDuplo": return IsDuplo;
                case "IsPaymentConfirmed": return IsPaymentConfirmed;
                case "PaymentConfirmedDateTime": return PaymentConfirmedDateTime;
                case "PaymentConfirmedBy": return PaymentConfirmedBy;
                case "LastPaymentConfirmedDateTime": return LastPaymentConfirmedDateTime;
                case "LastPaymentConfirmedByUserID": return LastPaymentConfirmedByUserID;
                case "IsDescriptionResult": return IsDescriptionResult;
                case "PriceAdjusted": return PriceAdjusted;
                case "SRCitoPercentage": return SRCitoPercentage;
                case "ItemConditionRuleID": return ItemConditionRuleID;
                case "CommunicationID": return CommunicationID;
                case "IsCasemixApproved": return IsCasemixApproved;
                case "CasemixApprovedDateTime": return CasemixApprovedDateTime;
                case "CasemixApprovedByUserID": return CasemixApprovedByUserID;
                case "TariffDate": return TariffDate;
                case "SpecimenTakenDateTime": return SpecimenTakenDateTime;
                case "SpecimenTakenByUserID": return SpecimenTakenByUserID;
                case "SpecimenSubmittedDateTime": return SpecimenSubmittedDateTime;
                case "SpecimenSubmittedByUserID": return SpecimenSubmittedByUserID;
                case "SpecimenReceivedDateTime": return SpecimenReceivedDateTime;
                case "SpecimenReceivedByUserID": return SpecimenReceivedByUserID;
                case "VoidDateTime": return VoidDateTime;
                case "VoidByUserID": return VoidByUserID;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem TransactionNo
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.TransactionNo, esSystemType.String); }
        }

        public esQueryItem SequenceNo
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.SequenceNo, esSystemType.String); }
        }

        public esQueryItem ReferenceNo
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.ReferenceNo, esSystemType.String); }
        }

        public esQueryItem ReferenceSequenceNo
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.ReferenceSequenceNo, esSystemType.String); }
        }

        public esQueryItem ItemID
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.ItemID, esSystemType.String); }
        }

        public esQueryItem ChargeClassID
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.ChargeClassID, esSystemType.String); }
        }

        public esQueryItem ParamedicID
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.ParamedicID, esSystemType.String); }
        }

        public esQueryItem SecondParamedicID
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.SecondParamedicID, esSystemType.String); }
        }

        public esQueryItem IsAdminCalculation
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.IsAdminCalculation, esSystemType.Boolean); }
        }

        public esQueryItem IsVariable
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.IsVariable, esSystemType.Boolean); }
        }

        public esQueryItem IsCito
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.IsCito, esSystemType.Boolean); }
        }

        public esQueryItem ChargeQuantity
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.ChargeQuantity, esSystemType.Decimal); }
        }

        public esQueryItem StockQuantity
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.StockQuantity, esSystemType.Decimal); }
        }

        public esQueryItem SRItemUnit
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.SRItemUnit, esSystemType.String); }
        }

        public esQueryItem CostPrice
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.CostPrice, esSystemType.Decimal); }
        }

        public esQueryItem Price
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.Price, esSystemType.Decimal); }
        }

        public esQueryItem DiscountAmount
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.DiscountAmount, esSystemType.Decimal); }
        }

        public esQueryItem CitoAmount
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.CitoAmount, esSystemType.Decimal); }
        }

        public esQueryItem RoundingAmount
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.RoundingAmount, esSystemType.Decimal); }
        }

        public esQueryItem SRDiscountReason
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.SRDiscountReason, esSystemType.String); }
        }

        public esQueryItem IsAssetUtilization
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.IsAssetUtilization, esSystemType.Boolean); }
        }

        public esQueryItem AssetID
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.AssetID, esSystemType.String); }
        }

        public esQueryItem IsBillProceed
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.IsBillProceed, esSystemType.Boolean); }
        }

        public esQueryItem IsOrderRealization
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.IsOrderRealization, esSystemType.Boolean); }
        }

        public esQueryItem IsPackage
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.IsPackage, esSystemType.Boolean); }
        }

        public esQueryItem IsApprove
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.IsApprove, esSystemType.Boolean); }
        }

        public esQueryItem IsVoid
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.IsVoid, esSystemType.Boolean); }
        }

        public esQueryItem Notes
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.Notes, esSystemType.String); }
        }

        public esQueryItem FilmNo
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.FilmNo, esSystemType.String); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem ParentNo
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.ParentNo, esSystemType.String); }
        }

        public esQueryItem SRCenterID
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.SRCenterID, esSystemType.String); }
        }

        public esQueryItem AutoProcessCalculation
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.AutoProcessCalculation, esSystemType.Decimal); }
        }

        public esQueryItem ParamedicCollectionName
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.ParamedicCollectionName, esSystemType.String); }
        }

        public esQueryItem ToServiceUnitID
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.ToServiceUnitID, esSystemType.String); }
        }

        public esQueryItem RealizationDateTime
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.RealizationDateTime, esSystemType.DateTime); }
        }

        public esQueryItem RealizationUserID
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.RealizationUserID, esSystemType.String); }
        }

        public esQueryItem UpdateRealizationDateTime
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.UpdateRealizationDateTime, esSystemType.DateTime); }
        }

        public esQueryItem UpdateRealizationUserID
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.UpdateRealizationUserID, esSystemType.String); }
        }

        public esQueryItem IsCitoInPercent
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.IsCitoInPercent, esSystemType.Boolean); }
        }

        public esQueryItem BasicCitoAmount
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.BasicCitoAmount, esSystemType.Decimal); }
        }

        public esQueryItem IsItemRoom
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.IsItemRoom, esSystemType.Boolean); }
        }

        public esQueryItem IsExtraItem
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.IsExtraItem, esSystemType.Boolean); }
        }

        public esQueryItem IsSelectedExtraItem
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.IsSelectedExtraItem, esSystemType.Boolean); }
        }

        public esQueryItem IsSendToLIS
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.IsSendToLIS, esSystemType.Boolean); }
        }

        public esQueryItem CreatedDateTime
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.CreatedDateTime, esSystemType.DateTime); }
        }

        public esQueryItem CreatedByUserID
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.CreatedByUserID, esSystemType.String); }
        }

        public esQueryItem IsCorrection
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.IsCorrection, esSystemType.Boolean); }
        }

        public esQueryItem ResultValue
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.ResultValue, esSystemType.String); }
        }

        public esQueryItem IsDuplo
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.IsDuplo, esSystemType.Boolean); }
        }

        public esQueryItem IsPaymentConfirmed
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.IsPaymentConfirmed, esSystemType.Boolean); }
        }

        public esQueryItem PaymentConfirmedDateTime
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.PaymentConfirmedDateTime, esSystemType.DateTime); }
        }

        public esQueryItem PaymentConfirmedBy
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.PaymentConfirmedBy, esSystemType.String); }
        }

        public esQueryItem LastPaymentConfirmedDateTime
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.LastPaymentConfirmedDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastPaymentConfirmedByUserID
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.LastPaymentConfirmedByUserID, esSystemType.String); }
        }

        public esQueryItem IsDescriptionResult
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.IsDescriptionResult, esSystemType.Boolean); }
        }

        public esQueryItem PriceAdjusted
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.PriceAdjusted, esSystemType.Decimal); }
        }

        public esQueryItem SRCitoPercentage
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.SRCitoPercentage, esSystemType.String); }
        }

        public esQueryItem ItemConditionRuleID
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.ItemConditionRuleID, esSystemType.String); }
        }

        public esQueryItem CommunicationID
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.CommunicationID, esSystemType.String); }
        }

        public esQueryItem IsCasemixApproved
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.IsCasemixApproved, esSystemType.Boolean); }
        }

        public esQueryItem CasemixApprovedDateTime
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.CasemixApprovedDateTime, esSystemType.DateTime); }
        }

        public esQueryItem CasemixApprovedByUserID
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.CasemixApprovedByUserID, esSystemType.String); }
        }

        public esQueryItem TariffDate
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.TariffDate, esSystemType.DateTime); }
        }

        public esQueryItem SpecimenTakenDateTime
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.SpecimenTakenDateTime, esSystemType.DateTime); }
        }

        public esQueryItem SpecimenTakenByUserID
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.SpecimenTakenByUserID, esSystemType.String); }
        }

        public esQueryItem SpecimenSubmittedDateTime
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.SpecimenSubmittedDateTime, esSystemType.DateTime); }
        }

        public esQueryItem SpecimenSubmittedByUserID
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.SpecimenSubmittedByUserID, esSystemType.String); }
        }

        public esQueryItem SpecimenReceivedDateTime
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.SpecimenReceivedDateTime, esSystemType.DateTime); }
        }

        public esQueryItem SpecimenReceivedByUserID
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.SpecimenReceivedByUserID, esSystemType.String); }
        }

        public esQueryItem VoidDateTime
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.VoidDateTime, esSystemType.DateTime); }
        }

        public esQueryItem VoidByUserID
        {
            get { return new esQueryItem(this, TransChargesItemMetadata.ColumnNames.VoidByUserID, esSystemType.String); }
        }

        #endregion

    }



    [Serializable]
    public partial class TransChargesItemMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected TransChargesItemMetadata()
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

            c = new esColumnMetadata(ColumnNames.SequenceNo, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SequenceNo;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 12;
            c.HasDefault = true;
            c.Default = @"('000')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ReferenceNo, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ReferenceNo;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ReferenceSequenceNo, 3, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ReferenceSequenceNo;
            c.CharacterMaxLength = 12;
            c.HasDefault = true;
            c.Default = @"('000')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ItemID, 4, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ItemID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ChargeClassID, 5, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ChargeClassID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParamedicID, 6, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParamedicID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SecondParamedicID, 7, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SecondParamedicID;
            c.CharacterMaxLength = 10;
            c.Description = "Diisi untuk rawat inap oelh Dokter Pengganti atau dokter anestesi";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsAdminCalculation, 8, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsAdminCalculation;
            c.HasDefault = true;
            c.Default = @"(CONVERT([bit],(1),0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsVariable, 9, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsVariable;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsCito, 10, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsCito;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ChargeQuantity, 11, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.ChargeQuantity;
            c.NumericPrecision = 10;
            c.NumericScale = 2;
            c.HasDefault = true;
            c.Default = @"((1.0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.StockQuantity, 12, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.StockQuantity;
            c.NumericPrecision = 10;
            c.NumericScale = 2;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRItemUnit, 13, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRItemUnit;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CostPrice, 14, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.CostPrice;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Price, 15, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.Price;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DiscountAmount, 16, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.DiscountAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CitoAmount, 17, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.CitoAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RoundingAmount, 18, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.RoundingAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRDiscountReason, 19, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRDiscountReason;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsAssetUtilization, 20, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsAssetUtilization;
            c.HasDefault = true;
            c.Default = @"(CONVERT([bit],(0),0))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AssetID, 21, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.AssetID;
            c.CharacterMaxLength = 30;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsBillProceed, 22, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsBillProceed;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsOrderRealization, 23, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsOrderRealization;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsPackage, 24, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsPackage;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsApprove, 25, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsApprove;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsVoid, 26, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsVoid;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Notes, 27, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Notes;
            c.CharacterMaxLength = 4000;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FilmNo, 28, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.FilmNo;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 29, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 30, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 40;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParentNo, 31, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParentNo;
            c.CharacterMaxLength = 12;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRCenterID, 32, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRCenterID;
            c.CharacterMaxLength = 30;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AutoProcessCalculation, 33, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.AutoProcessCalculation;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParamedicCollectionName, 34, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParamedicCollectionName;
            c.CharacterMaxLength = 250;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ToServiceUnitID, 35, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ToServiceUnitID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RealizationDateTime, 36, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.RealizationDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RealizationUserID, 37, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RealizationUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.UpdateRealizationDateTime, 38, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.UpdateRealizationDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.UpdateRealizationUserID, 39, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.UpdateRealizationUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsCitoInPercent, 40, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsCitoInPercent;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.BasicCitoAmount, 41, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.BasicCitoAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsItemRoom, 42, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsItemRoom;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsExtraItem, 43, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsExtraItem;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsSelectedExtraItem, 44, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsSelectedExtraItem;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsSendToLIS, 45, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsSendToLIS;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreatedDateTime, 46, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.CreatedDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreatedByUserID, 47, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.CreatedByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsCorrection, 48, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsCorrection;
            c.HasDefault = true;
            c.Default = @"(CONVERT([bit],(0),0))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ResultValue, 49, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ResultValue;
            c.CharacterMaxLength = 1000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsDuplo, 50, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsDuplo;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsPaymentConfirmed, 51, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsPaymentConfirmed;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PaymentConfirmedDateTime, 52, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.PaymentConfirmedDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PaymentConfirmedBy, 53, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PaymentConfirmedBy;
            c.CharacterMaxLength = 150;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastPaymentConfirmedDateTime, 54, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastPaymentConfirmedDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastPaymentConfirmedByUserID, 55, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastPaymentConfirmedByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsDescriptionResult, 56, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsDescriptionResult;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PriceAdjusted, 57, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.PriceAdjusted;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRCitoPercentage, 58, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRCitoPercentage;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ItemConditionRuleID, 59, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ItemConditionRuleID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CommunicationID, 60, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.CommunicationID;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsCasemixApproved, 61, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsCasemixApproved;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CasemixApprovedDateTime, 62, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.CasemixApprovedDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CasemixApprovedByUserID, 63, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.CasemixApprovedByUserID;
            c.CharacterMaxLength = 40;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TariffDate, 64, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.TariffDate;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SpecimenTakenDateTime, 65, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.SpecimenTakenDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SpecimenTakenByUserID, 66, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SpecimenTakenByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SpecimenSubmittedDateTime, 67, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.SpecimenSubmittedDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SpecimenSubmittedByUserID, 68, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SpecimenSubmittedByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SpecimenReceivedDateTime, 69, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.SpecimenReceivedDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SpecimenReceivedByUserID, 70, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SpecimenReceivedByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.VoidDateTime, 71, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.VoidDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.VoidByUserID, 72, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.VoidByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public TransChargesItemMetadata Meta()
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
            public const string SequenceNo = "SequenceNo";
            public const string ReferenceNo = "ReferenceNo";
            public const string ReferenceSequenceNo = "ReferenceSequenceNo";
            public const string ItemID = "ItemID";
            public const string ChargeClassID = "ChargeClassID";
            public const string ParamedicID = "ParamedicID";
            public const string SecondParamedicID = "SecondParamedicID";
            public const string IsAdminCalculation = "IsAdminCalculation";
            public const string IsVariable = "IsVariable";
            public const string IsCito = "IsCito";
            public const string ChargeQuantity = "ChargeQuantity";
            public const string StockQuantity = "StockQuantity";
            public const string SRItemUnit = "SRItemUnit";
            public const string CostPrice = "CostPrice";
            public const string Price = "Price";
            public const string DiscountAmount = "DiscountAmount";
            public const string CitoAmount = "CitoAmount";
            public const string RoundingAmount = "RoundingAmount";
            public const string SRDiscountReason = "SRDiscountReason";
            public const string IsAssetUtilization = "IsAssetUtilization";
            public const string AssetID = "AssetID";
            public const string IsBillProceed = "IsBillProceed";
            public const string IsOrderRealization = "IsOrderRealization";
            public const string IsPackage = "IsPackage";
            public const string IsApprove = "IsApprove";
            public const string IsVoid = "IsVoid";
            public const string Notes = "Notes";
            public const string FilmNo = "FilmNo";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string ParentNo = "ParentNo";
            public const string SRCenterID = "SRCenterID";
            public const string AutoProcessCalculation = "AutoProcessCalculation";
            public const string ParamedicCollectionName = "ParamedicCollectionName";
            public const string ToServiceUnitID = "ToServiceUnitID";
            public const string RealizationDateTime = "RealizationDateTime";
            public const string RealizationUserID = "RealizationUserID";
            public const string UpdateRealizationDateTime = "UpdateRealizationDateTime";
            public const string UpdateRealizationUserID = "UpdateRealizationUserID";
            public const string IsCitoInPercent = "IsCitoInPercent";
            public const string BasicCitoAmount = "BasicCitoAmount";
            public const string IsItemRoom = "IsItemRoom";
            public const string IsExtraItem = "IsExtraItem";
            public const string IsSelectedExtraItem = "IsSelectedExtraItem";
            public const string IsSendToLIS = "IsSendToLIS";
            public const string CreatedDateTime = "CreatedDateTime";
            public const string CreatedByUserID = "CreatedByUserID";
            public const string IsCorrection = "IsCorrection";
            public const string ResultValue = "ResultValue";
            public const string IsDuplo = "IsDuplo";
            public const string IsPaymentConfirmed = "IsPaymentConfirmed";
            public const string PaymentConfirmedDateTime = "PaymentConfirmedDateTime";
            public const string PaymentConfirmedBy = "PaymentConfirmedBy";
            public const string LastPaymentConfirmedDateTime = "LastPaymentConfirmedDateTime";
            public const string LastPaymentConfirmedByUserID = "LastPaymentConfirmedByUserID";
            public const string IsDescriptionResult = "IsDescriptionResult";
            public const string PriceAdjusted = "PriceAdjusted";
            public const string SRCitoPercentage = "SRCitoPercentage";
            public const string ItemConditionRuleID = "ItemConditionRuleID";
            public const string CommunicationID = "CommunicationID";
            public const string IsCasemixApproved = "IsCasemixApproved";
            public const string CasemixApprovedDateTime = "CasemixApprovedDateTime";
            public const string CasemixApprovedByUserID = "CasemixApprovedByUserID";
            public const string TariffDate = "TariffDate";
            public const string SpecimenTakenDateTime = "SpecimenTakenDateTime";
            public const string SpecimenTakenByUserID = "SpecimenTakenByUserID";
            public const string SpecimenSubmittedDateTime = "SpecimenSubmittedDateTime";
            public const string SpecimenSubmittedByUserID = "SpecimenSubmittedByUserID";
            public const string SpecimenReceivedDateTime = "SpecimenReceivedDateTime";
            public const string SpecimenReceivedByUserID = "SpecimenReceivedByUserID";
            public const string VoidDateTime = "VoidDateTime";
            public const string VoidByUserID = "VoidByUserID";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string TransactionNo = "TransactionNo";
            public const string SequenceNo = "SequenceNo";
            public const string ReferenceNo = "ReferenceNo";
            public const string ReferenceSequenceNo = "ReferenceSequenceNo";
            public const string ItemID = "ItemID";
            public const string ChargeClassID = "ChargeClassID";
            public const string ParamedicID = "ParamedicID";
            public const string SecondParamedicID = "SecondParamedicID";
            public const string IsAdminCalculation = "IsAdminCalculation";
            public const string IsVariable = "IsVariable";
            public const string IsCito = "IsCito";
            public const string ChargeQuantity = "ChargeQuantity";
            public const string StockQuantity = "StockQuantity";
            public const string SRItemUnit = "SRItemUnit";
            public const string CostPrice = "CostPrice";
            public const string Price = "Price";
            public const string DiscountAmount = "DiscountAmount";
            public const string CitoAmount = "CitoAmount";
            public const string RoundingAmount = "RoundingAmount";
            public const string SRDiscountReason = "SRDiscountReason";
            public const string IsAssetUtilization = "IsAssetUtilization";
            public const string AssetID = "AssetID";
            public const string IsBillProceed = "IsBillProceed";
            public const string IsOrderRealization = "IsOrderRealization";
            public const string IsPackage = "IsPackage";
            public const string IsApprove = "IsApprove";
            public const string IsVoid = "IsVoid";
            public const string Notes = "Notes";
            public const string FilmNo = "FilmNo";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string ParentNo = "ParentNo";
            public const string SRCenterID = "SRCenterID";
            public const string AutoProcessCalculation = "AutoProcessCalculation";
            public const string ParamedicCollectionName = "ParamedicCollectionName";
            public const string ToServiceUnitID = "ToServiceUnitID";
            public const string RealizationDateTime = "RealizationDateTime";
            public const string RealizationUserID = "RealizationUserID";
            public const string UpdateRealizationDateTime = "UpdateRealizationDateTime";
            public const string UpdateRealizationUserID = "UpdateRealizationUserID";
            public const string IsCitoInPercent = "IsCitoInPercent";
            public const string BasicCitoAmount = "BasicCitoAmount";
            public const string IsItemRoom = "IsItemRoom";
            public const string IsExtraItem = "IsExtraItem";
            public const string IsSelectedExtraItem = "IsSelectedExtraItem";
            public const string IsSendToLIS = "IsSendToLIS";
            public const string CreatedDateTime = "CreatedDateTime";
            public const string CreatedByUserID = "CreatedByUserID";
            public const string IsCorrection = "IsCorrection";
            public const string ResultValue = "ResultValue";
            public const string IsDuplo = "IsDuplo";
            public const string IsPaymentConfirmed = "IsPaymentConfirmed";
            public const string PaymentConfirmedDateTime = "PaymentConfirmedDateTime";
            public const string PaymentConfirmedBy = "PaymentConfirmedBy";
            public const string LastPaymentConfirmedDateTime = "LastPaymentConfirmedDateTime";
            public const string LastPaymentConfirmedByUserID = "LastPaymentConfirmedByUserID";
            public const string IsDescriptionResult = "IsDescriptionResult";
            public const string PriceAdjusted = "PriceAdjusted";
            public const string SRCitoPercentage = "SRCitoPercentage";
            public const string ItemConditionRuleID = "ItemConditionRuleID";
            public const string CommunicationID = "CommunicationID";
            public const string IsCasemixApproved = "IsCasemixApproved";
            public const string CasemixApprovedDateTime = "CasemixApprovedDateTime";
            public const string CasemixApprovedByUserID = "CasemixApprovedByUserID";
            public const string TariffDate = "TariffDate";
            public const string SpecimenTakenDateTime = "SpecimenTakenDateTime";
            public const string SpecimenTakenByUserID = "SpecimenTakenByUserID";
            public const string SpecimenSubmittedDateTime = "SpecimenSubmittedDateTime";
            public const string SpecimenSubmittedByUserID = "SpecimenSubmittedByUserID";
            public const string SpecimenReceivedDateTime = "SpecimenReceivedDateTime";
            public const string SpecimenReceivedByUserID = "SpecimenReceivedByUserID";
            public const string VoidDateTime = "VoidDateTime";
            public const string VoidByUserID = "VoidByUserID";
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
            lock (typeof(TransChargesItemMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new TransChargesItemMetadata();
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
                meta.AddTypeMap("SequenceNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ReferenceNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ReferenceSequenceNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ItemID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ChargeClassID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ParamedicID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SecondParamedicID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsAdminCalculation", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsVariable", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsCito", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ChargeQuantity", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("StockQuantity", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("SRItemUnit", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CostPrice", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("Price", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("DiscountAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("CitoAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("RoundingAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("SRDiscountReason", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsAssetUtilization", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("AssetID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsBillProceed", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsOrderRealization", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsPackage", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsApprove", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsVoid", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("Notes", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("FilmNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ParentNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRCenterID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("AutoProcessCalculation", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("ParamedicCollectionName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ToServiceUnitID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("RealizationDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("RealizationUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("UpdateRealizationDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("UpdateRealizationUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsCitoInPercent", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("BasicCitoAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("IsItemRoom", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsExtraItem", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsSelectedExtraItem", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsSendToLIS", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("CreatedDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("CreatedByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsCorrection", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ResultValue", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsDuplo", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsPaymentConfirmed", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("PaymentConfirmedDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("PaymentConfirmedBy", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastPaymentConfirmedDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastPaymentConfirmedByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsDescriptionResult", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("PriceAdjusted", new esTypeMap("decimal", "System.Decimal"));
                meta.AddTypeMap("SRCitoPercentage", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ItemConditionRuleID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CommunicationID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsCasemixApproved", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("CasemixApprovedDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("CasemixApprovedByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TariffDate", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("SpecimenTakenDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("SpecimenTakenByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SpecimenSubmittedDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("SpecimenSubmittedByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SpecimenReceivedDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("SpecimenReceivedByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("VoidDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("VoidByUserID", new esTypeMap("varchar", "System.String"));



                meta.Source = "TransChargesItem";
                meta.Destination = "TransChargesItem";

                meta.spInsert = "proc_TransChargesItemInsert";
                meta.spUpdate = "proc_TransChargesItemUpdate";
                meta.spDelete = "proc_TransChargesItemDelete";
                meta.spLoadAll = "proc_TransChargesItemLoadAll";
                meta.spLoadByPrimaryKey = "proc_TransChargesItemLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private TransChargesItemMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
