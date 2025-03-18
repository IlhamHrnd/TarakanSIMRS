
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 3/17/2025 1:57:00 PM
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
    /// Encapsulates the 'TransPrescriptionItem' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(TransPrescriptionItem))]
    [XmlType("TransPrescriptionItem")]
    public partial class TransPrescriptionItem : esTransPrescriptionItem
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new TransPrescriptionItem();
        }

        #region Static Quick Access Methods
        static public void Delete(string prescriptionNo, string sequenceNo)
        {
            var obj = new TransPrescriptionItem();
            obj.PrescriptionNo = prescriptionNo;
            obj.SequenceNo = sequenceNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string prescriptionNo, string sequenceNo, esSqlAccessType sqlAccessType)
        {
            var obj = new TransPrescriptionItem();
            obj.PrescriptionNo = prescriptionNo;
            obj.SequenceNo = sequenceNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("TransPrescriptionItemCollection")]
    public partial class TransPrescriptionItemCollection : esTransPrescriptionItemCollection, IEnumerable<TransPrescriptionItem>
    {
        public TransPrescriptionItem FindByPrimaryKey(string prescriptionNo, string sequenceNo)
        {
            return this.SingleOrDefault(e => e.PrescriptionNo == prescriptionNo && e.SequenceNo == sequenceNo);
        }



    }



    [Serializable]
    public partial class TransPrescriptionItemQuery : esTransPrescriptionItemQuery
    {
        public TransPrescriptionItemQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public TransPrescriptionItemQuery(string joinAlias, out TransPrescriptionItemQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "TransPrescriptionItemQuery";
        }



        #region Explicit Casts

        public static explicit operator string(TransPrescriptionItemQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator TransPrescriptionItemQuery(string query)
        {
            return (TransPrescriptionItemQuery)SerializeHelper.FromXml(query, typeof(TransPrescriptionItemQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esTransPrescriptionItem : esEntity
    {
        public esTransPrescriptionItem()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string prescriptionNo, string sequenceNo)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(prescriptionNo, sequenceNo);
            else
                return LoadByPrimaryKeyStoredProcedure(prescriptionNo, sequenceNo);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string prescriptionNo, string sequenceNo)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(prescriptionNo, sequenceNo);
            else
                return LoadByPrimaryKeyStoredProcedure(prescriptionNo, sequenceNo);
        }

        private bool LoadByPrimaryKeyDynamic(string prescriptionNo, string sequenceNo)
        {
            TransPrescriptionItemQuery query = new TransPrescriptionItemQuery("tpiQ");
            query.Where(query.PrescriptionNo == prescriptionNo, query.SequenceNo == sequenceNo);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string prescriptionNo, string sequenceNo)
        {
            esParameters parms = new esParameters();
            parms.Add("PrescriptionNo", prescriptionNo); parms.Add("SequenceNo", sequenceNo);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to TransPrescriptionItem.PrescriptionNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PrescriptionNo
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.PrescriptionNo);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.PrescriptionNo, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.PrescriptionNo);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.SequenceNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SequenceNo
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.SequenceNo);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.SequenceNo, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.SequenceNo);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.ParentNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParentNo
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.ParentNo);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.ParentNo, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.ParentNo);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.IsRFlag
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsRFlag
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionItemMetadata.ColumnNames.IsRFlag);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionItemMetadata.ColumnNames.IsRFlag, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.IsRFlag);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.IsCompound
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsCompound
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionItemMetadata.ColumnNames.IsCompound);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionItemMetadata.ColumnNames.IsCompound, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.IsCompound);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.ItemID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ItemID
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.ItemID);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.ItemID, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.ItemID);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.ItemInterventionID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ItemInterventionID
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.ItemInterventionID);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.ItemInterventionID, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.ItemInterventionID);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.SRItemUnit
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRItemUnit
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.SRItemUnit);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.SRItemUnit, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.SRItemUnit);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.ItemQtyInString
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ItemQtyInString
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.ItemQtyInString);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.ItemQtyInString, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.ItemQtyInString);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.IsUsingDosageUnit
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsUsingDosageUnit
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionItemMetadata.ColumnNames.IsUsingDosageUnit);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionItemMetadata.ColumnNames.IsUsingDosageUnit, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.IsUsingDosageUnit);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.SRDosageUnit
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRDosageUnit
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.SRDosageUnit);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.SRDosageUnit, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.SRDosageUnit);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.FrequencyOfDosing
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public byte? FrequencyOfDosing
        {
            get
            {
                return GetSystemByte(TransPrescriptionItemMetadata.ColumnNames.FrequencyOfDosing);
            }

            set
            {
                if (SetSystemByte(TransPrescriptionItemMetadata.ColumnNames.FrequencyOfDosing, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.FrequencyOfDosing);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.DosingPeriod
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DosingPeriod
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.DosingPeriod);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.DosingPeriod, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.DosingPeriod);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.NumberOfDosage
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? NumberOfDosage
        {
            get
            {
                return GetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.NumberOfDosage);
            }

            set
            {
                if (SetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.NumberOfDosage, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.NumberOfDosage);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.DurationOfDosing
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public byte? DurationOfDosing
        {
            get
            {
                return GetSystemByte(TransPrescriptionItemMetadata.ColumnNames.DurationOfDosing);
            }

            set
            {
                if (SetSystemByte(TransPrescriptionItemMetadata.ColumnNames.DurationOfDosing, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.DurationOfDosing);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.ACPCDC
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Acpcdc
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.Acpcdc);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.Acpcdc, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.Acpcdc);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.SRMedicationRoute
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRMedicationRoute
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.SRMedicationRoute);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.SRMedicationRoute, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.SRMedicationRoute);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.ConsumeMethod
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ConsumeMethod
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.ConsumeMethod);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.ConsumeMethod, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.ConsumeMethod);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.PrescriptionQty
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? PrescriptionQty
        {
            get
            {
                return GetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.PrescriptionQty);
            }

            set
            {
                if (SetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.PrescriptionQty, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.PrescriptionQty);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.TakenQty
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? TakenQty
        {
            get
            {
                return GetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.TakenQty);
            }

            set
            {
                if (SetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.TakenQty, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.TakenQty);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.ResultQty
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? ResultQty
        {
            get
            {
                return GetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.ResultQty);
            }

            set
            {
                if (SetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.ResultQty, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.ResultQty);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.CostPrice
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? CostPrice
        {
            get
            {
                return GetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.CostPrice);
            }

            set
            {
                if (SetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.CostPrice, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.CostPrice);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.InitialPrice
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? InitialPrice
        {
            get
            {
                return GetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.InitialPrice);
            }

            set
            {
                if (SetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.InitialPrice, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.InitialPrice);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.Price
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? Price
        {
            get
            {
                return GetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.Price);
            }

            set
            {
                if (SetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.Price, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.Price);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.DiscountAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? DiscountAmount
        {
            get
            {
                return GetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.DiscountAmount);
            }

            set
            {
                if (SetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.DiscountAmount, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.DiscountAmount);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.EmbalaceID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string EmbalaceID
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.EmbalaceID);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.EmbalaceID, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.EmbalaceID);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.EmbalaceAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? EmbalaceAmount
        {
            get
            {
                return GetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.EmbalaceAmount);
            }

            set
            {
                if (SetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.EmbalaceAmount, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.EmbalaceAmount);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.IsUseSweetener
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsUseSweetener
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionItemMetadata.ColumnNames.IsUseSweetener);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionItemMetadata.ColumnNames.IsUseSweetener, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.IsUseSweetener);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.SweetenerAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? SweetenerAmount
        {
            get
            {
                return GetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.SweetenerAmount);
            }

            set
            {
                if (SetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.SweetenerAmount, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.SweetenerAmount);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.LineAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? LineAmount
        {
            get
            {
                return GetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.LineAmount);
            }

            set
            {
                if (SetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.LineAmount, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.LineAmount);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.Notes
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Notes
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.Notes);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.Notes, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.Notes);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(TransPrescriptionItemMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(TransPrescriptionItemMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.SRDiscountReason
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRDiscountReason
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.SRDiscountReason);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.SRDiscountReason, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.SRDiscountReason);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.IsApprove
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsApprove
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionItemMetadata.ColumnNames.IsApprove);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionItemMetadata.ColumnNames.IsApprove, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.IsApprove);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.IsVoid
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsVoid
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionItemMetadata.ColumnNames.IsVoid);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionItemMetadata.ColumnNames.IsVoid, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.IsVoid);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.IsBillProceed
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsBillProceed
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionItemMetadata.ColumnNames.IsBillProceed);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionItemMetadata.ColumnNames.IsBillProceed, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.IsBillProceed);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.DurationRelease
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? DurationRelease
        {
            get
            {
                return GetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.DurationRelease);
            }

            set
            {
                if (SetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.DurationRelease, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.DurationRelease);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.RecipeAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? RecipeAmount
        {
            get
            {
                return GetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.RecipeAmount);
            }

            set
            {
                if (SetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.RecipeAmount, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.RecipeAmount);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.IsCalcPercentage
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsCalcPercentage
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionItemMetadata.ColumnNames.IsCalcPercentage);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionItemMetadata.ColumnNames.IsCalcPercentage, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.IsCalcPercentage);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.AutoProcessCalculation
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? AutoProcessCalculation
        {
            get
            {
                return GetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.AutoProcessCalculation);
            }

            set
            {
                if (SetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.AutoProcessCalculation, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.AutoProcessCalculation);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.IsUsingAdminReturn
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsUsingAdminReturn
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionItemMetadata.ColumnNames.IsUsingAdminReturn);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionItemMetadata.ColumnNames.IsUsingAdminReturn, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.IsUsingAdminReturn);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.VerifiedByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string VerifiedByUserID
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.VerifiedByUserID);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.VerifiedByUserID, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.VerifiedByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.VerifiedDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? VerifiedDateTime
        {
            get
            {
                return GetSystemDateTime(TransPrescriptionItemMetadata.ColumnNames.VerifiedDateTime);
            }

            set
            {
                if (SetSystemDateTime(TransPrescriptionItemMetadata.ColumnNames.VerifiedDateTime, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.VerifiedDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.LastUpdateByUserHostName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserHostName
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.LastUpdateByUserHostName);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.LastUpdateByUserHostName, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.LastUpdateByUserHostName);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.VerifiedByUserHostName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string VerifiedByUserHostName
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.VerifiedByUserHostName);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.VerifiedByUserHostName, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.VerifiedByUserHostName);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.SRConsumeMethod
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRConsumeMethod
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.SRConsumeMethod);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.SRConsumeMethod, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.SRConsumeMethod);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.DosageQty
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DosageQty
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.DosageQty);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.DosageQty, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.DosageQty);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.EmbalaceQty
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string EmbalaceQty
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.EmbalaceQty);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.EmbalaceQty, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.EmbalaceQty);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.IterText
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string IterText
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.IterText);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.IterText, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.IterText);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.OrderText
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string OrderText
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.OrderText);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.OrderText, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.OrderText);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.ConsumeQty
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ConsumeQty
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.ConsumeQty);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.ConsumeQty, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.ConsumeQty);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.SRConsumeUnit
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRConsumeUnit
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.SRConsumeUnit);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.SRConsumeUnit, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.SRConsumeUnit);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.ReferenceNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ReferenceNo
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.ReferenceNo);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.ReferenceNo, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.ReferenceNo);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.ReferenceSequenceNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ReferenceSequenceNo
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.ReferenceSequenceNo);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.ReferenceSequenceNo, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.ReferenceSequenceNo);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.CreatedDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? CreatedDateTime
        {
            get
            {
                return GetSystemDateTime(TransPrescriptionItemMetadata.ColumnNames.CreatedDateTime);
            }

            set
            {
                if (SetSystemDateTime(TransPrescriptionItemMetadata.ColumnNames.CreatedDateTime, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.CreatedDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.CreatedByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string CreatedByUserID
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.CreatedByUserID);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.CreatedByUserID, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.CreatedByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.OriPrescriptionQty
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? OriPrescriptionQty
        {
            get
            {
                return GetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.OriPrescriptionQty);
            }

            set
            {
                if (SetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.OriPrescriptionQty, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.OriPrescriptionQty);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.OriConsumeQty
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string OriConsumeQty
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.OriConsumeQty);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.OriConsumeQty, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.OriConsumeQty);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.OriSRConsumeUnit
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string OriSRConsumeUnit
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.OriSRConsumeUnit);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.OriSRConsumeUnit, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.OriSRConsumeUnit);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.OriResultQty
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? OriResultQty
        {
            get
            {
                return GetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.OriResultQty);
            }

            set
            {
                if (SetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.OriResultQty, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.OriResultQty);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.OriItemQtyInString
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string OriItemQtyInString
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.OriItemQtyInString);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.OriItemQtyInString, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.OriItemQtyInString);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.OriSRItemUnit
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string OriSRItemUnit
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.OriSRItemUnit);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.OriSRItemUnit, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.OriSRItemUnit);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.OriDosageQty
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string OriDosageQty
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.OriDosageQty);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.OriDosageQty, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.OriDosageQty);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.OriSRDosageUnit
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string OriSRDosageUnit
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.OriSRDosageUnit);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.OriSRDosageUnit, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.OriSRDosageUnit);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.OriSRConsumeMethod
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string OriSRConsumeMethod
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.OriSRConsumeMethod);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.OriSRConsumeMethod, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.OriSRConsumeMethod);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.IsReturned
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsReturned
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionItemMetadata.ColumnNames.IsReturned);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionItemMetadata.ColumnNames.IsReturned, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.IsReturned);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.IsPendingDelivery
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsPendingDelivery
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionItemMetadata.ColumnNames.IsPendingDelivery);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionItemMetadata.ColumnNames.IsPendingDelivery, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.IsPendingDelivery);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.DeliveryQty
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? DeliveryQty
        {
            get
            {
                return GetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.DeliveryQty);
            }

            set
            {
                if (SetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.DeliveryQty, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.DeliveryQty);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.DaysOfUsage
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? DaysOfUsage
        {
            get
            {
                return GetSystemInt32(TransPrescriptionItemMetadata.ColumnNames.DaysOfUsage);
            }

            set
            {
                if (SetSystemInt32(TransPrescriptionItemMetadata.ColumnNames.DaysOfUsage, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.DaysOfUsage);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.IsCasemixApproved
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsCasemixApproved
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionItemMetadata.ColumnNames.IsCasemixApproved);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionItemMetadata.ColumnNames.IsCasemixApproved, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.IsCasemixApproved);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.CasemixApprovedDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? CasemixApprovedDateTime
        {
            get
            {
                return GetSystemDateTime(TransPrescriptionItemMetadata.ColumnNames.CasemixApprovedDateTime);
            }

            set
            {
                if (SetSystemDateTime(TransPrescriptionItemMetadata.ColumnNames.CasemixApprovedDateTime, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.CasemixApprovedDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.CasemixApprovedByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string CasemixApprovedByUserID
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.CasemixApprovedByUserID);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.CasemixApprovedByUserID, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.CasemixApprovedByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.StartDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? StartDateTime
        {
            get
            {
                return GetSystemDateTime(TransPrescriptionItemMetadata.ColumnNames.StartDateTime);
            }

            set
            {
                if (SetSystemDateTime(TransPrescriptionItemMetadata.ColumnNames.StartDateTime, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.StartDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.SRInterventionReason
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRInterventionReason
        {
            get
            {
                return GetSystemString(TransPrescriptionItemMetadata.ColumnNames.SRInterventionReason);
            }

            set
            {
                if (SetSystemString(TransPrescriptionItemMetadata.ColumnNames.SRInterventionReason, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.SRInterventionReason);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.Qty23Days
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? Qty23Days
        {
            get
            {
                return GetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.Qty23Days);
            }

            set
            {
                if (SetSystemDecimal(TransPrescriptionItemMetadata.ColumnNames.Qty23Days, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.Qty23Days);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.IsConsTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsConsTime
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionItemMetadata.ColumnNames.IsConsTime);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionItemMetadata.ColumnNames.IsConsTime, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.IsConsTime);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.IsPagi
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsPagi
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionItemMetadata.ColumnNames.IsPagi);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionItemMetadata.ColumnNames.IsPagi, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.IsPagi);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.IsSiang
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsSiang
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionItemMetadata.ColumnNames.IsSiang);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionItemMetadata.ColumnNames.IsSiang, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.IsSiang);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.IsSore
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsSore
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionItemMetadata.ColumnNames.IsSore);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionItemMetadata.ColumnNames.IsSore, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.IsSore);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescriptionItem.IsMalam
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsMalam
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionItemMetadata.ColumnNames.IsMalam);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionItemMetadata.ColumnNames.IsMalam, value))
                {
                    OnPropertyChanged(TransPrescriptionItemMetadata.PropertyNames.IsMalam);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return TransPrescriptionItemMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public TransPrescriptionItemQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new TransPrescriptionItemQuery("tpiQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(TransPrescriptionItemQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(TransPrescriptionItemQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((TransPrescriptionItemQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private TransPrescriptionItemQuery query;
    }



    [Serializable]
    abstract public partial class esTransPrescriptionItemCollection : esEntityCollection<TransPrescriptionItem>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return TransPrescriptionItemMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "TransPrescriptionItemCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public TransPrescriptionItemQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new TransPrescriptionItemQuery("tpiQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(TransPrescriptionItemQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new TransPrescriptionItemQuery("tpiQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(TransPrescriptionItemQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((TransPrescriptionItemQuery)query);
        }

        #endregion

        private TransPrescriptionItemQuery query;
    }



    [Serializable]
    abstract public partial class esTransPrescriptionItemQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return TransPrescriptionItemMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "PrescriptionNo": return PrescriptionNo;
                case "SequenceNo": return SequenceNo;
                case "ParentNo": return ParentNo;
                case "IsRFlag": return IsRFlag;
                case "IsCompound": return IsCompound;
                case "ItemID": return ItemID;
                case "ItemInterventionID": return ItemInterventionID;
                case "SRItemUnit": return SRItemUnit;
                case "ItemQtyInString": return ItemQtyInString;
                case "IsUsingDosageUnit": return IsUsingDosageUnit;
                case "SRDosageUnit": return SRDosageUnit;
                case "FrequencyOfDosing": return FrequencyOfDosing;
                case "DosingPeriod": return DosingPeriod;
                case "NumberOfDosage": return NumberOfDosage;
                case "DurationOfDosing": return DurationOfDosing;
                case "Acpcdc": return Acpcdc;
                case "SRMedicationRoute": return SRMedicationRoute;
                case "ConsumeMethod": return ConsumeMethod;
                case "PrescriptionQty": return PrescriptionQty;
                case "TakenQty": return TakenQty;
                case "ResultQty": return ResultQty;
                case "CostPrice": return CostPrice;
                case "InitialPrice": return InitialPrice;
                case "Price": return Price;
                case "DiscountAmount": return DiscountAmount;
                case "EmbalaceID": return EmbalaceID;
                case "EmbalaceAmount": return EmbalaceAmount;
                case "IsUseSweetener": return IsUseSweetener;
                case "SweetenerAmount": return SweetenerAmount;
                case "LineAmount": return LineAmount;
                case "Notes": return Notes;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "SRDiscountReason": return SRDiscountReason;
                case "IsApprove": return IsApprove;
                case "IsVoid": return IsVoid;
                case "IsBillProceed": return IsBillProceed;
                case "DurationRelease": return DurationRelease;
                case "RecipeAmount": return RecipeAmount;
                case "IsCalcPercentage": return IsCalcPercentage;
                case "AutoProcessCalculation": return AutoProcessCalculation;
                case "IsUsingAdminReturn": return IsUsingAdminReturn;
                case "VerifiedByUserID": return VerifiedByUserID;
                case "VerifiedDateTime": return VerifiedDateTime;
                case "LastUpdateByUserHostName": return LastUpdateByUserHostName;
                case "VerifiedByUserHostName": return VerifiedByUserHostName;
                case "SRConsumeMethod": return SRConsumeMethod;
                case "DosageQty": return DosageQty;
                case "EmbalaceQty": return EmbalaceQty;
                case "IterText": return IterText;
                case "OrderText": return OrderText;
                case "ConsumeQty": return ConsumeQty;
                case "SRConsumeUnit": return SRConsumeUnit;
                case "ReferenceNo": return ReferenceNo;
                case "ReferenceSequenceNo": return ReferenceSequenceNo;
                case "CreatedDateTime": return CreatedDateTime;
                case "CreatedByUserID": return CreatedByUserID;
                case "OriPrescriptionQty": return OriPrescriptionQty;
                case "OriConsumeQty": return OriConsumeQty;
                case "OriSRConsumeUnit": return OriSRConsumeUnit;
                case "OriResultQty": return OriResultQty;
                case "OriItemQtyInString": return OriItemQtyInString;
                case "OriSRItemUnit": return OriSRItemUnit;
                case "OriDosageQty": return OriDosageQty;
                case "OriSRDosageUnit": return OriSRDosageUnit;
                case "OriSRConsumeMethod": return OriSRConsumeMethod;
                case "IsReturned": return IsReturned;
                case "IsPendingDelivery": return IsPendingDelivery;
                case "DeliveryQty": return DeliveryQty;
                case "DaysOfUsage": return DaysOfUsage;
                case "IsCasemixApproved": return IsCasemixApproved;
                case "CasemixApprovedDateTime": return CasemixApprovedDateTime;
                case "CasemixApprovedByUserID": return CasemixApprovedByUserID;
                case "StartDateTime": return StartDateTime;
                case "SRInterventionReason": return SRInterventionReason;
                case "Qty23Days": return Qty23Days;
                case "IsConsTime": return IsConsTime;
                case "IsPagi": return IsPagi;
                case "IsSiang": return IsSiang;
                case "IsSore": return IsSore;
                case "IsMalam": return IsMalam;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem PrescriptionNo
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.PrescriptionNo, esSystemType.String); }
        }

        public esQueryItem SequenceNo
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.SequenceNo, esSystemType.String); }
        }

        public esQueryItem ParentNo
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.ParentNo, esSystemType.String); }
        }

        public esQueryItem IsRFlag
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.IsRFlag, esSystemType.Boolean); }
        }

        public esQueryItem IsCompound
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.IsCompound, esSystemType.Boolean); }
        }

        public esQueryItem ItemID
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.ItemID, esSystemType.String); }
        }

        public esQueryItem ItemInterventionID
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.ItemInterventionID, esSystemType.String); }
        }

        public esQueryItem SRItemUnit
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.SRItemUnit, esSystemType.String); }
        }

        public esQueryItem ItemQtyInString
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.ItemQtyInString, esSystemType.String); }
        }

        public esQueryItem IsUsingDosageUnit
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.IsUsingDosageUnit, esSystemType.Boolean); }
        }

        public esQueryItem SRDosageUnit
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.SRDosageUnit, esSystemType.String); }
        }

        public esQueryItem FrequencyOfDosing
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.FrequencyOfDosing, esSystemType.Byte); }
        }

        public esQueryItem DosingPeriod
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.DosingPeriod, esSystemType.String); }
        }

        public esQueryItem NumberOfDosage
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.NumberOfDosage, esSystemType.Decimal); }
        }

        public esQueryItem DurationOfDosing
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.DurationOfDosing, esSystemType.Byte); }
        }

        public esQueryItem Acpcdc
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.Acpcdc, esSystemType.String); }
        }

        public esQueryItem SRMedicationRoute
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.SRMedicationRoute, esSystemType.String); }
        }

        public esQueryItem ConsumeMethod
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.ConsumeMethod, esSystemType.String); }
        }

        public esQueryItem PrescriptionQty
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.PrescriptionQty, esSystemType.Decimal); }
        }

        public esQueryItem TakenQty
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.TakenQty, esSystemType.Decimal); }
        }

        public esQueryItem ResultQty
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.ResultQty, esSystemType.Decimal); }
        }

        public esQueryItem CostPrice
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.CostPrice, esSystemType.Decimal); }
        }

        public esQueryItem InitialPrice
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.InitialPrice, esSystemType.Decimal); }
        }

        public esQueryItem Price
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.Price, esSystemType.Decimal); }
        }

        public esQueryItem DiscountAmount
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.DiscountAmount, esSystemType.Decimal); }
        }

        public esQueryItem EmbalaceID
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.EmbalaceID, esSystemType.String); }
        }

        public esQueryItem EmbalaceAmount
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.EmbalaceAmount, esSystemType.Decimal); }
        }

        public esQueryItem IsUseSweetener
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.IsUseSweetener, esSystemType.Boolean); }
        }

        public esQueryItem SweetenerAmount
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.SweetenerAmount, esSystemType.Decimal); }
        }

        public esQueryItem LineAmount
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.LineAmount, esSystemType.Decimal); }
        }

        public esQueryItem Notes
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.Notes, esSystemType.String); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem SRDiscountReason
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.SRDiscountReason, esSystemType.String); }
        }

        public esQueryItem IsApprove
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.IsApprove, esSystemType.Boolean); }
        }

        public esQueryItem IsVoid
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.IsVoid, esSystemType.Boolean); }
        }

        public esQueryItem IsBillProceed
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.IsBillProceed, esSystemType.Boolean); }
        }

        public esQueryItem DurationRelease
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.DurationRelease, esSystemType.Decimal); }
        }

        public esQueryItem RecipeAmount
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.RecipeAmount, esSystemType.Decimal); }
        }

        public esQueryItem IsCalcPercentage
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.IsCalcPercentage, esSystemType.Boolean); }
        }

        public esQueryItem AutoProcessCalculation
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.AutoProcessCalculation, esSystemType.Decimal); }
        }

        public esQueryItem IsUsingAdminReturn
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.IsUsingAdminReturn, esSystemType.Boolean); }
        }

        public esQueryItem VerifiedByUserID
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.VerifiedByUserID, esSystemType.String); }
        }

        public esQueryItem VerifiedDateTime
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.VerifiedDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserHostName
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.LastUpdateByUserHostName, esSystemType.String); }
        }

        public esQueryItem VerifiedByUserHostName
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.VerifiedByUserHostName, esSystemType.String); }
        }

        public esQueryItem SRConsumeMethod
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.SRConsumeMethod, esSystemType.String); }
        }

        public esQueryItem DosageQty
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.DosageQty, esSystemType.String); }
        }

        public esQueryItem EmbalaceQty
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.EmbalaceQty, esSystemType.String); }
        }

        public esQueryItem IterText
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.IterText, esSystemType.String); }
        }

        public esQueryItem OrderText
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.OrderText, esSystemType.String); }
        }

        public esQueryItem ConsumeQty
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.ConsumeQty, esSystemType.String); }
        }

        public esQueryItem SRConsumeUnit
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.SRConsumeUnit, esSystemType.String); }
        }

        public esQueryItem ReferenceNo
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.ReferenceNo, esSystemType.String); }
        }

        public esQueryItem ReferenceSequenceNo
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.ReferenceSequenceNo, esSystemType.String); }
        }

        public esQueryItem CreatedDateTime
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.CreatedDateTime, esSystemType.DateTime); }
        }

        public esQueryItem CreatedByUserID
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.CreatedByUserID, esSystemType.String); }
        }

        public esQueryItem OriPrescriptionQty
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.OriPrescriptionQty, esSystemType.Decimal); }
        }

        public esQueryItem OriConsumeQty
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.OriConsumeQty, esSystemType.String); }
        }

        public esQueryItem OriSRConsumeUnit
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.OriSRConsumeUnit, esSystemType.String); }
        }

        public esQueryItem OriResultQty
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.OriResultQty, esSystemType.Decimal); }
        }

        public esQueryItem OriItemQtyInString
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.OriItemQtyInString, esSystemType.String); }
        }

        public esQueryItem OriSRItemUnit
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.OriSRItemUnit, esSystemType.String); }
        }

        public esQueryItem OriDosageQty
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.OriDosageQty, esSystemType.String); }
        }

        public esQueryItem OriSRDosageUnit
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.OriSRDosageUnit, esSystemType.String); }
        }

        public esQueryItem OriSRConsumeMethod
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.OriSRConsumeMethod, esSystemType.String); }
        }

        public esQueryItem IsReturned
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.IsReturned, esSystemType.Boolean); }
        }

        public esQueryItem IsPendingDelivery
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.IsPendingDelivery, esSystemType.Boolean); }
        }

        public esQueryItem DeliveryQty
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.DeliveryQty, esSystemType.Decimal); }
        }

        public esQueryItem DaysOfUsage
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.DaysOfUsage, esSystemType.Int32); }
        }

        public esQueryItem IsCasemixApproved
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.IsCasemixApproved, esSystemType.Boolean); }
        }

        public esQueryItem CasemixApprovedDateTime
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.CasemixApprovedDateTime, esSystemType.DateTime); }
        }

        public esQueryItem CasemixApprovedByUserID
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.CasemixApprovedByUserID, esSystemType.String); }
        }

        public esQueryItem StartDateTime
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.StartDateTime, esSystemType.DateTime); }
        }

        public esQueryItem SRInterventionReason
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.SRInterventionReason, esSystemType.String); }
        }

        public esQueryItem Qty23Days
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.Qty23Days, esSystemType.Decimal); }
        }

        public esQueryItem IsConsTime
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.IsConsTime, esSystemType.Boolean); }
        }

        public esQueryItem IsPagi
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.IsPagi, esSystemType.Boolean); }
        }

        public esQueryItem IsSiang
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.IsSiang, esSystemType.Boolean); }
        }

        public esQueryItem IsSore
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.IsSore, esSystemType.Boolean); }
        }

        public esQueryItem IsMalam
        {
            get { return new esQueryItem(this, TransPrescriptionItemMetadata.ColumnNames.IsMalam, esSystemType.Boolean); }
        }

        #endregion

    }



    [Serializable]
    public partial class TransPrescriptionItemMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected TransPrescriptionItemMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.PrescriptionNo, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PrescriptionNo;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 20;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SequenceNo, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SequenceNo;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 3;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParentNo, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParentNo;
            c.CharacterMaxLength = 3;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsRFlag, 3, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsRFlag;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsCompound, 4, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsCompound;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ItemID, 5, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ItemID;
            c.CharacterMaxLength = 10;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ItemInterventionID, 6, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ItemInterventionID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRItemUnit, 7, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRItemUnit;
            c.CharacterMaxLength = 30;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ItemQtyInString, 8, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ItemQtyInString;
            c.CharacterMaxLength = 30;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsUsingDosageUnit, 9, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsUsingDosageUnit;
            c.HasDefault = true;
            c.Default = @"((0))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRDosageUnit, 10, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRDosageUnit;
            c.CharacterMaxLength = 30;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FrequencyOfDosing, 11, typeof(byte), esSystemType.Byte);
            c.PropertyName = PropertyNames.FrequencyOfDosing;
            c.NumericPrecision = 3;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DosingPeriod, 12, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DosingPeriod;
            c.CharacterMaxLength = 30;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.NumberOfDosage, 13, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.NumberOfDosage;
            c.NumericPrecision = 10;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DurationOfDosing, 14, typeof(byte), esSystemType.Byte);
            c.PropertyName = PropertyNames.DurationOfDosing;
            c.NumericPrecision = 3;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Acpcdc, 15, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Acpcdc;
            c.CharacterMaxLength = 30;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRMedicationRoute, 16, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRMedicationRoute;
            c.CharacterMaxLength = 30;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ConsumeMethod, 17, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ConsumeMethod;
            c.CharacterMaxLength = 100;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PrescriptionQty, 18, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.PrescriptionQty;
            c.NumericPrecision = 10;
            c.NumericScale = 2;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TakenQty, 19, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.TakenQty;
            c.NumericPrecision = 10;
            c.NumericScale = 2;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ResultQty, 20, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.ResultQty;
            c.NumericPrecision = 10;
            c.NumericScale = 2;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CostPrice, 21, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.CostPrice;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.InitialPrice, 22, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.InitialPrice;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Price, 23, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.Price;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DiscountAmount, 24, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.DiscountAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.EmbalaceID, 25, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.EmbalaceID;
            c.CharacterMaxLength = 10;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.EmbalaceAmount, 26, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.EmbalaceAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsUseSweetener, 27, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsUseSweetener;
            c.HasDefault = true;
            c.Default = @"((0))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SweetenerAmount, 28, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.SweetenerAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LineAmount, 29, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.LineAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Notes, 30, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Notes;
            c.CharacterMaxLength = 500;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 31, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 32, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 40;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRDiscountReason, 33, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRDiscountReason;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsApprove, 34, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsApprove;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsVoid, 35, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsVoid;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsBillProceed, 36, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsBillProceed;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DurationRelease, 37, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.DurationRelease;
            c.NumericPrecision = 10;
            c.NumericScale = 2;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RecipeAmount, 38, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.RecipeAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsCalcPercentage, 39, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsCalcPercentage;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AutoProcessCalculation, 40, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.AutoProcessCalculation;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsUsingAdminReturn, 41, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsUsingAdminReturn;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.VerifiedByUserID, 42, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.VerifiedByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.VerifiedDateTime, 43, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.VerifiedDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserHostName, 44, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserHostName;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.VerifiedByUserHostName, 45, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.VerifiedByUserHostName;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRConsumeMethod, 46, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRConsumeMethod;
            c.CharacterMaxLength = 30;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DosageQty, 47, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DosageQty;
            c.CharacterMaxLength = 30;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.EmbalaceQty, 48, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.EmbalaceQty;
            c.CharacterMaxLength = 30;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IterText, 49, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.IterText;
            c.CharacterMaxLength = 500;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.OrderText, 50, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.OrderText;
            c.CharacterMaxLength = 500;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ConsumeQty, 51, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ConsumeQty;
            c.CharacterMaxLength = 30;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRConsumeUnit, 52, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRConsumeUnit;
            c.CharacterMaxLength = 30;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ReferenceNo, 53, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ReferenceNo;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ReferenceSequenceNo, 54, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ReferenceSequenceNo;
            c.CharacterMaxLength = 3;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreatedDateTime, 55, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.CreatedDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreatedByUserID, 56, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.CreatedByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.OriPrescriptionQty, 57, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.OriPrescriptionQty;
            c.NumericPrecision = 10;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.OriConsumeQty, 58, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.OriConsumeQty;
            c.CharacterMaxLength = 30;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.OriSRConsumeUnit, 59, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.OriSRConsumeUnit;
            c.CharacterMaxLength = 30;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.OriResultQty, 60, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.OriResultQty;
            c.NumericPrecision = 10;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.OriItemQtyInString, 61, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.OriItemQtyInString;
            c.CharacterMaxLength = 30;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.OriSRItemUnit, 62, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.OriSRItemUnit;
            c.CharacterMaxLength = 30;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.OriDosageQty, 63, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.OriDosageQty;
            c.CharacterMaxLength = 30;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.OriSRDosageUnit, 64, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.OriSRDosageUnit;
            c.CharacterMaxLength = 30;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.OriSRConsumeMethod, 65, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.OriSRConsumeMethod;
            c.CharacterMaxLength = 30;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsReturned, 66, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsReturned;
            c.HasDefault = true;
            c.Default = @"((0))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsPendingDelivery, 67, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsPendingDelivery;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DeliveryQty, 68, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.DeliveryQty;
            c.NumericPrecision = 10;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DaysOfUsage, 69, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.DaysOfUsage;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsCasemixApproved, 70, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsCasemixApproved;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CasemixApprovedDateTime, 71, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.CasemixApprovedDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CasemixApprovedByUserID, 72, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.CasemixApprovedByUserID;
            c.CharacterMaxLength = 40;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.StartDateTime, 73, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.StartDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRInterventionReason, 74, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRInterventionReason;
            c.CharacterMaxLength = 30;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Qty23Days, 75, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.Qty23Days;
            c.NumericPrecision = 10;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsConsTime, 76, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsConsTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsPagi, 77, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsPagi;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsSiang, 78, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsSiang;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsSore, 79, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsSore;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsMalam, 80, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsMalam;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public TransPrescriptionItemMetadata Meta()
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
            public const string PrescriptionNo = "PrescriptionNo";
            public const string SequenceNo = "SequenceNo";
            public const string ParentNo = "ParentNo";
            public const string IsRFlag = "IsRFlag";
            public const string IsCompound = "IsCompound";
            public const string ItemID = "ItemID";
            public const string ItemInterventionID = "ItemInterventionID";
            public const string SRItemUnit = "SRItemUnit";
            public const string ItemQtyInString = "ItemQtyInString";
            public const string IsUsingDosageUnit = "IsUsingDosageUnit";
            public const string SRDosageUnit = "SRDosageUnit";
            public const string FrequencyOfDosing = "FrequencyOfDosing";
            public const string DosingPeriod = "DosingPeriod";
            public const string NumberOfDosage = "NumberOfDosage";
            public const string DurationOfDosing = "DurationOfDosing";
            public const string Acpcdc = "ACPCDC";
            public const string SRMedicationRoute = "SRMedicationRoute";
            public const string ConsumeMethod = "ConsumeMethod";
            public const string PrescriptionQty = "PrescriptionQty";
            public const string TakenQty = "TakenQty";
            public const string ResultQty = "ResultQty";
            public const string CostPrice = "CostPrice";
            public const string InitialPrice = "InitialPrice";
            public const string Price = "Price";
            public const string DiscountAmount = "DiscountAmount";
            public const string EmbalaceID = "EmbalaceID";
            public const string EmbalaceAmount = "EmbalaceAmount";
            public const string IsUseSweetener = "IsUseSweetener";
            public const string SweetenerAmount = "SweetenerAmount";
            public const string LineAmount = "LineAmount";
            public const string Notes = "Notes";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string SRDiscountReason = "SRDiscountReason";
            public const string IsApprove = "IsApprove";
            public const string IsVoid = "IsVoid";
            public const string IsBillProceed = "IsBillProceed";
            public const string DurationRelease = "DurationRelease";
            public const string RecipeAmount = "RecipeAmount";
            public const string IsCalcPercentage = "IsCalcPercentage";
            public const string AutoProcessCalculation = "AutoProcessCalculation";
            public const string IsUsingAdminReturn = "IsUsingAdminReturn";
            public const string VerifiedByUserID = "VerifiedByUserID";
            public const string VerifiedDateTime = "VerifiedDateTime";
            public const string LastUpdateByUserHostName = "LastUpdateByUserHostName";
            public const string VerifiedByUserHostName = "VerifiedByUserHostName";
            public const string SRConsumeMethod = "SRConsumeMethod";
            public const string DosageQty = "DosageQty";
            public const string EmbalaceQty = "EmbalaceQty";
            public const string IterText = "IterText";
            public const string OrderText = "OrderText";
            public const string ConsumeQty = "ConsumeQty";
            public const string SRConsumeUnit = "SRConsumeUnit";
            public const string ReferenceNo = "ReferenceNo";
            public const string ReferenceSequenceNo = "ReferenceSequenceNo";
            public const string CreatedDateTime = "CreatedDateTime";
            public const string CreatedByUserID = "CreatedByUserID";
            public const string OriPrescriptionQty = "OriPrescriptionQty";
            public const string OriConsumeQty = "OriConsumeQty";
            public const string OriSRConsumeUnit = "OriSRConsumeUnit";
            public const string OriResultQty = "OriResultQty";
            public const string OriItemQtyInString = "OriItemQtyInString";
            public const string OriSRItemUnit = "OriSRItemUnit";
            public const string OriDosageQty = "OriDosageQty";
            public const string OriSRDosageUnit = "OriSRDosageUnit";
            public const string OriSRConsumeMethod = "OriSRConsumeMethod";
            public const string IsReturned = "IsReturned";
            public const string IsPendingDelivery = "IsPendingDelivery";
            public const string DeliveryQty = "DeliveryQty";
            public const string DaysOfUsage = "DaysOfUsage";
            public const string IsCasemixApproved = "IsCasemixApproved";
            public const string CasemixApprovedDateTime = "CasemixApprovedDateTime";
            public const string CasemixApprovedByUserID = "CasemixApprovedByUserID";
            public const string StartDateTime = "StartDateTime";
            public const string SRInterventionReason = "SRInterventionReason";
            public const string Qty23Days = "Qty23Days";
            public const string IsConsTime = "IsConsTime";
            public const string IsPagi = "IsPagi";
            public const string IsSiang = "IsSiang";
            public const string IsSore = "IsSore";
            public const string IsMalam = "IsMalam";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string PrescriptionNo = "PrescriptionNo";
            public const string SequenceNo = "SequenceNo";
            public const string ParentNo = "ParentNo";
            public const string IsRFlag = "IsRFlag";
            public const string IsCompound = "IsCompound";
            public const string ItemID = "ItemID";
            public const string ItemInterventionID = "ItemInterventionID";
            public const string SRItemUnit = "SRItemUnit";
            public const string ItemQtyInString = "ItemQtyInString";
            public const string IsUsingDosageUnit = "IsUsingDosageUnit";
            public const string SRDosageUnit = "SRDosageUnit";
            public const string FrequencyOfDosing = "FrequencyOfDosing";
            public const string DosingPeriod = "DosingPeriod";
            public const string NumberOfDosage = "NumberOfDosage";
            public const string DurationOfDosing = "DurationOfDosing";
            public const string Acpcdc = "Acpcdc";
            public const string SRMedicationRoute = "SRMedicationRoute";
            public const string ConsumeMethod = "ConsumeMethod";
            public const string PrescriptionQty = "PrescriptionQty";
            public const string TakenQty = "TakenQty";
            public const string ResultQty = "ResultQty";
            public const string CostPrice = "CostPrice";
            public const string InitialPrice = "InitialPrice";
            public const string Price = "Price";
            public const string DiscountAmount = "DiscountAmount";
            public const string EmbalaceID = "EmbalaceID";
            public const string EmbalaceAmount = "EmbalaceAmount";
            public const string IsUseSweetener = "IsUseSweetener";
            public const string SweetenerAmount = "SweetenerAmount";
            public const string LineAmount = "LineAmount";
            public const string Notes = "Notes";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string SRDiscountReason = "SRDiscountReason";
            public const string IsApprove = "IsApprove";
            public const string IsVoid = "IsVoid";
            public const string IsBillProceed = "IsBillProceed";
            public const string DurationRelease = "DurationRelease";
            public const string RecipeAmount = "RecipeAmount";
            public const string IsCalcPercentage = "IsCalcPercentage";
            public const string AutoProcessCalculation = "AutoProcessCalculation";
            public const string IsUsingAdminReturn = "IsUsingAdminReturn";
            public const string VerifiedByUserID = "VerifiedByUserID";
            public const string VerifiedDateTime = "VerifiedDateTime";
            public const string LastUpdateByUserHostName = "LastUpdateByUserHostName";
            public const string VerifiedByUserHostName = "VerifiedByUserHostName";
            public const string SRConsumeMethod = "SRConsumeMethod";
            public const string DosageQty = "DosageQty";
            public const string EmbalaceQty = "EmbalaceQty";
            public const string IterText = "IterText";
            public const string OrderText = "OrderText";
            public const string ConsumeQty = "ConsumeQty";
            public const string SRConsumeUnit = "SRConsumeUnit";
            public const string ReferenceNo = "ReferenceNo";
            public const string ReferenceSequenceNo = "ReferenceSequenceNo";
            public const string CreatedDateTime = "CreatedDateTime";
            public const string CreatedByUserID = "CreatedByUserID";
            public const string OriPrescriptionQty = "OriPrescriptionQty";
            public const string OriConsumeQty = "OriConsumeQty";
            public const string OriSRConsumeUnit = "OriSRConsumeUnit";
            public const string OriResultQty = "OriResultQty";
            public const string OriItemQtyInString = "OriItemQtyInString";
            public const string OriSRItemUnit = "OriSRItemUnit";
            public const string OriDosageQty = "OriDosageQty";
            public const string OriSRDosageUnit = "OriSRDosageUnit";
            public const string OriSRConsumeMethod = "OriSRConsumeMethod";
            public const string IsReturned = "IsReturned";
            public const string IsPendingDelivery = "IsPendingDelivery";
            public const string DeliveryQty = "DeliveryQty";
            public const string DaysOfUsage = "DaysOfUsage";
            public const string IsCasemixApproved = "IsCasemixApproved";
            public const string CasemixApprovedDateTime = "CasemixApprovedDateTime";
            public const string CasemixApprovedByUserID = "CasemixApprovedByUserID";
            public const string StartDateTime = "StartDateTime";
            public const string SRInterventionReason = "SRInterventionReason";
            public const string Qty23Days = "Qty23Days";
            public const string IsConsTime = "IsConsTime";
            public const string IsPagi = "IsPagi";
            public const string IsSiang = "IsSiang";
            public const string IsSore = "IsSore";
            public const string IsMalam = "IsMalam";
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
            lock (typeof(TransPrescriptionItemMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new TransPrescriptionItemMetadata();
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


                meta.AddTypeMap("PrescriptionNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SequenceNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ParentNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsRFlag", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsCompound", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ItemID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ItemInterventionID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRItemUnit", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ItemQtyInString", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsUsingDosageUnit", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("SRDosageUnit", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("FrequencyOfDosing", new esTypeMap("tinyint", "System.Byte"));
                meta.AddTypeMap("DosingPeriod", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("NumberOfDosage", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("DurationOfDosing", new esTypeMap("tinyint", "System.Byte"));
                meta.AddTypeMap("Acpcdc", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRMedicationRoute", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ConsumeMethod", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PrescriptionQty", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("TakenQty", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("ResultQty", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("CostPrice", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("InitialPrice", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("Price", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("DiscountAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("EmbalaceID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("EmbalaceAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("IsUseSweetener", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("SweetenerAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("LineAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("Notes", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRDiscountReason", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsApprove", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsVoid", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsBillProceed", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("DurationRelease", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("RecipeAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("IsCalcPercentage", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("AutoProcessCalculation", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("IsUsingAdminReturn", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("VerifiedByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("VerifiedDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserHostName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("VerifiedByUserHostName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRConsumeMethod", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("DosageQty", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("EmbalaceQty", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IterText", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("OrderText", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ConsumeQty", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRConsumeUnit", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ReferenceNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ReferenceSequenceNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CreatedDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("CreatedByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("OriPrescriptionQty", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("OriConsumeQty", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("OriSRConsumeUnit", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("OriResultQty", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("OriItemQtyInString", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("OriSRItemUnit", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("OriDosageQty", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("OriSRDosageUnit", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("OriSRConsumeMethod", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsReturned", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsPendingDelivery", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("DeliveryQty", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("DaysOfUsage", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("IsCasemixApproved", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("CasemixApprovedDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("CasemixApprovedByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("StartDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("SRInterventionReason", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Qty23Days", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("IsConsTime", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsPagi", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsSiang", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsSore", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsMalam", new esTypeMap("bit", "System.Boolean"));



                meta.Source = "TransPrescriptionItem";
                meta.Destination = "TransPrescriptionItem";

                meta.spInsert = "proc_TransPrescriptionItemInsert";
                meta.spUpdate = "proc_TransPrescriptionItemUpdate";
                meta.spDelete = "proc_TransPrescriptionItemDelete";
                meta.spLoadAll = "proc_TransPrescriptionItemLoadAll";
                meta.spLoadByPrimaryKey = "proc_TransPrescriptionItemLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private TransPrescriptionItemMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
