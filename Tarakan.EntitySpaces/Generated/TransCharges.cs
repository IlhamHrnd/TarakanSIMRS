
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 2/12/2025 11:48:56 AM
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
    /// Encapsulates the 'TransCharges' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(TransCharges))]
    [XmlType("TransCharges")]
    public partial class TransCharges : esTransCharges
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new TransCharges();
        }

        #region Static Quick Access Methods
        static public void Delete(string transactionNo)
        {
            var obj = new TransCharges();
            obj.TransactionNo = transactionNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string transactionNo, esSqlAccessType sqlAccessType)
        {
            var obj = new TransCharges();
            obj.TransactionNo = transactionNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("TransChargesCollection")]
    public partial class TransChargesCollection : esTransChargesCollection, IEnumerable<TransCharges>
    {
        public TransCharges FindByPrimaryKey(string transactionNo)
        {
            return this.SingleOrDefault(e => e.TransactionNo == transactionNo);
        }



    }



    [Serializable]
    public partial class TransChargesQuery : esTransChargesQuery
    {
        public TransChargesQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public TransChargesQuery(string joinAlias, out TransChargesQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "TransChargesQuery";
        }



        #region Explicit Casts

        public static explicit operator string(TransChargesQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator TransChargesQuery(string query)
        {
            return (TransChargesQuery)SerializeHelper.FromXml(query, typeof(TransChargesQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esTransCharges : esEntity
    {
        public esTransCharges()
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
            TransChargesQuery query = new TransChargesQuery("tcQ");
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
        /// Maps to TransCharges.TransactionNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TransactionNo
        {
            get
            {
                return GetSystemString(TransChargesMetadata.ColumnNames.TransactionNo);
            }

            set
            {
                if (SetSystemString(TransChargesMetadata.ColumnNames.TransactionNo, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.TransactionNo);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.RegistrationNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RegistrationNo
        {
            get
            {
                return GetSystemString(TransChargesMetadata.ColumnNames.RegistrationNo);
            }

            set
            {
                if (SetSystemString(TransChargesMetadata.ColumnNames.RegistrationNo, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.RegistrationNo);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.TransactionDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? TransactionDate
        {
            get
            {
                return GetSystemDateTime(TransChargesMetadata.ColumnNames.TransactionDate);
            }

            set
            {
                if (SetSystemDateTime(TransChargesMetadata.ColumnNames.TransactionDate, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.TransactionDate);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.ExecutionDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? ExecutionDate
        {
            get
            {
                return GetSystemDateTime(TransChargesMetadata.ColumnNames.ExecutionDate);
            }

            set
            {
                if (SetSystemDateTime(TransChargesMetadata.ColumnNames.ExecutionDate, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.ExecutionDate);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.ReferenceNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ReferenceNo
        {
            get
            {
                return GetSystemString(TransChargesMetadata.ColumnNames.ReferenceNo);
            }

            set
            {
                if (SetSystemString(TransChargesMetadata.ColumnNames.ReferenceNo, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.ReferenceNo);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.FromServiceUnitID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string FromServiceUnitID
        {
            get
            {
                return GetSystemString(TransChargesMetadata.ColumnNames.FromServiceUnitID);
            }

            set
            {
                if (SetSystemString(TransChargesMetadata.ColumnNames.FromServiceUnitID, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.FromServiceUnitID);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.ToServiceUnitID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ToServiceUnitID
        {
            get
            {
                return GetSystemString(TransChargesMetadata.ColumnNames.ToServiceUnitID);
            }

            set
            {
                if (SetSystemString(TransChargesMetadata.ColumnNames.ToServiceUnitID, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.ToServiceUnitID);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.ClassID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ClassID
        {
            get
            {
                return GetSystemString(TransChargesMetadata.ColumnNames.ClassID);
            }

            set
            {
                if (SetSystemString(TransChargesMetadata.ColumnNames.ClassID, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.ClassID);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.RoomID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RoomID
        {
            get
            {
                return GetSystemString(TransChargesMetadata.ColumnNames.RoomID);
            }

            set
            {
                if (SetSystemString(TransChargesMetadata.ColumnNames.RoomID, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.RoomID);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.BedID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string BedID
        {
            get
            {
                return GetSystemString(TransChargesMetadata.ColumnNames.BedID);
            }

            set
            {
                if (SetSystemString(TransChargesMetadata.ColumnNames.BedID, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.BedID);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.DueDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? DueDate
        {
            get
            {
                return GetSystemDateTime(TransChargesMetadata.ColumnNames.DueDate);
            }

            set
            {
                if (SetSystemDateTime(TransChargesMetadata.ColumnNames.DueDate, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.DueDate);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.SRShift
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRShift
        {
            get
            {
                return GetSystemString(TransChargesMetadata.ColumnNames.SRShift);
            }

            set
            {
                if (SetSystemString(TransChargesMetadata.ColumnNames.SRShift, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.SRShift);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.SRItemType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRItemType
        {
            get
            {
                return GetSystemString(TransChargesMetadata.ColumnNames.SRItemType);
            }

            set
            {
                if (SetSystemString(TransChargesMetadata.ColumnNames.SRItemType, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.SRItemType);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.IsProceed
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsProceed
        {
            get
            {
                return GetSystemBoolean(TransChargesMetadata.ColumnNames.IsProceed);
            }

            set
            {
                if (SetSystemBoolean(TransChargesMetadata.ColumnNames.IsProceed, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.IsProceed);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.IsApproved
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsApproved
        {
            get
            {
                return GetSystemBoolean(TransChargesMetadata.ColumnNames.IsApproved);
            }

            set
            {
                if (SetSystemBoolean(TransChargesMetadata.ColumnNames.IsApproved, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.IsApproved);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.IsVoid
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsVoid
        {
            get
            {
                return GetSystemBoolean(TransChargesMetadata.ColumnNames.IsVoid);
            }

            set
            {
                if (SetSystemBoolean(TransChargesMetadata.ColumnNames.IsVoid, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.IsVoid);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.IsOrder
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsOrder
        {
            get
            {
                return GetSystemBoolean(TransChargesMetadata.ColumnNames.IsOrder);
            }

            set
            {
                if (SetSystemBoolean(TransChargesMetadata.ColumnNames.IsOrder, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.IsOrder);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.IsCorrection
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsCorrection
        {
            get
            {
                return GetSystemBoolean(TransChargesMetadata.ColumnNames.IsCorrection);
            }

            set
            {
                if (SetSystemBoolean(TransChargesMetadata.ColumnNames.IsCorrection, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.IsCorrection);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.IsClusterAssign
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsClusterAssign
        {
            get
            {
                return GetSystemBoolean(TransChargesMetadata.ColumnNames.IsClusterAssign);
            }

            set
            {
                if (SetSystemBoolean(TransChargesMetadata.ColumnNames.IsClusterAssign, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.IsClusterAssign);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.IsAutoBillTransaction
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsAutoBillTransaction
        {
            get
            {
                return GetSystemBoolean(TransChargesMetadata.ColumnNames.IsAutoBillTransaction);
            }

            set
            {
                if (SetSystemBoolean(TransChargesMetadata.ColumnNames.IsAutoBillTransaction, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.IsAutoBillTransaction);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.IsBillProceed
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsBillProceed
        {
            get
            {
                return GetSystemBoolean(TransChargesMetadata.ColumnNames.IsBillProceed);
            }

            set
            {
                if (SetSystemBoolean(TransChargesMetadata.ColumnNames.IsBillProceed, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.IsBillProceed);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.Notes
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Notes
        {
            get
            {
                return GetSystemString(TransChargesMetadata.ColumnNames.Notes);
            }

            set
            {
                if (SetSystemString(TransChargesMetadata.ColumnNames.Notes, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.Notes);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(TransChargesMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(TransChargesMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(TransChargesMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(TransChargesMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.SRTypeResult
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRTypeResult
        {
            get
            {
                return GetSystemString(TransChargesMetadata.ColumnNames.SRTypeResult);
            }

            set
            {
                if (SetSystemString(TransChargesMetadata.ColumnNames.SRTypeResult, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.SRTypeResult);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.ResponUnitID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ResponUnitID
        {
            get
            {
                return GetSystemString(TransChargesMetadata.ColumnNames.ResponUnitID);
            }

            set
            {
                if (SetSystemString(TransChargesMetadata.ColumnNames.ResponUnitID, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.ResponUnitID);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.SurgicalPackageID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SurgicalPackageID
        {
            get
            {
                return GetSystemString(TransChargesMetadata.ColumnNames.SurgicalPackageID);
            }

            set
            {
                if (SetSystemString(TransChargesMetadata.ColumnNames.SurgicalPackageID, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.SurgicalPackageID);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.IsPackage
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsPackage
        {
            get
            {
                return GetSystemBoolean(TransChargesMetadata.ColumnNames.IsPackage);
            }

            set
            {
                if (SetSystemBoolean(TransChargesMetadata.ColumnNames.IsPackage, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.IsPackage);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.PackageReferenceNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PackageReferenceNo
        {
            get
            {
                return GetSystemString(TransChargesMetadata.ColumnNames.PackageReferenceNo);
            }

            set
            {
                if (SetSystemString(TransChargesMetadata.ColumnNames.PackageReferenceNo, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.PackageReferenceNo);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.IsRoomIn
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsRoomIn
        {
            get
            {
                return GetSystemBoolean(TransChargesMetadata.ColumnNames.IsRoomIn);
            }

            set
            {
                if (SetSystemBoolean(TransChargesMetadata.ColumnNames.IsRoomIn, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.IsRoomIn);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.TariffDiscountForRoomIn
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? TariffDiscountForRoomIn
        {
            get
            {
                return GetSystemDecimal(TransChargesMetadata.ColumnNames.TariffDiscountForRoomIn);
            }

            set
            {
                if (SetSystemDecimal(TransChargesMetadata.ColumnNames.TariffDiscountForRoomIn, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.TariffDiscountForRoomIn);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.IsNonPatient
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsNonPatient
        {
            get
            {
                return GetSystemBoolean(TransChargesMetadata.ColumnNames.IsNonPatient);
            }

            set
            {
                if (SetSystemBoolean(TransChargesMetadata.ColumnNames.IsNonPatient, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.IsNonPatient);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.ServiceUnitBookingNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ServiceUnitBookingNo
        {
            get
            {
                return GetSystemString(TransChargesMetadata.ColumnNames.ServiceUnitBookingNo);
            }

            set
            {
                if (SetSystemString(TransChargesMetadata.ColumnNames.ServiceUnitBookingNo, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.ServiceUnitBookingNo);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.CreatedDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? CreatedDateTime
        {
            get
            {
                return GetSystemDateTime(TransChargesMetadata.ColumnNames.CreatedDateTime);
            }

            set
            {
                if (SetSystemDateTime(TransChargesMetadata.ColumnNames.CreatedDateTime, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.CreatedDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.CreatedByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string CreatedByUserID
        {
            get
            {
                return GetSystemString(TransChargesMetadata.ColumnNames.CreatedByUserID);
            }

            set
            {
                if (SetSystemString(TransChargesMetadata.ColumnNames.CreatedByUserID, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.CreatedByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.PhysicianSenders
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PhysicianSenders
        {
            get
            {
                return GetSystemString(TransChargesMetadata.ColumnNames.PhysicianSenders);
            }

            set
            {
                if (SetSystemString(TransChargesMetadata.ColumnNames.PhysicianSenders, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.PhysicianSenders);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.IsValidated
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsValidated
        {
            get
            {
                return GetSystemBoolean(TransChargesMetadata.ColumnNames.IsValidated);
            }

            set
            {
                if (SetSystemBoolean(TransChargesMetadata.ColumnNames.IsValidated, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.IsValidated);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.ValidatedDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? ValidatedDateTime
        {
            get
            {
                return GetSystemDateTime(TransChargesMetadata.ColumnNames.ValidatedDateTime);
            }

            set
            {
                if (SetSystemDateTime(TransChargesMetadata.ColumnNames.ValidatedDateTime, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.ValidatedDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.ValidatedByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ValidatedByUserID
        {
            get
            {
                return GetSystemString(TransChargesMetadata.ColumnNames.ValidatedByUserID);
            }

            set
            {
                if (SetSystemString(TransChargesMetadata.ColumnNames.ValidatedByUserID, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.ValidatedByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.LocationID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LocationID
        {
            get
            {
                return GetSystemString(TransChargesMetadata.ColumnNames.LocationID);
            }

            set
            {
                if (SetSystemString(TransChargesMetadata.ColumnNames.LocationID, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.LocationID);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.SRProdiaContractID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRProdiaContractID
        {
            get
            {
                return GetSystemString(TransChargesMetadata.ColumnNames.SRProdiaContractID);
            }

            set
            {
                if (SetSystemString(TransChargesMetadata.ColumnNames.SRProdiaContractID, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.SRProdiaContractID);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.LaboratoryParamedicID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LaboratoryParamedicID
        {
            get
            {
                return GetSystemString(TransChargesMetadata.ColumnNames.LaboratoryParamedicID);
            }

            set
            {
                if (SetSystemString(TransChargesMetadata.ColumnNames.LaboratoryParamedicID, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.LaboratoryParamedicID);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.SRBloodSampleTakenBy
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRBloodSampleTakenBy
        {
            get
            {
                return GetSystemString(TransChargesMetadata.ColumnNames.SRBloodSampleTakenBy);
            }

            set
            {
                if (SetSystemString(TransChargesMetadata.ColumnNames.SRBloodSampleTakenBy, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.SRBloodSampleTakenBy);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.ApprovedDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? ApprovedDateTime
        {
            get
            {
                return GetSystemDateTime(TransChargesMetadata.ColumnNames.ApprovedDateTime);
            }

            set
            {
                if (SetSystemDateTime(TransChargesMetadata.ColumnNames.ApprovedDateTime, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.ApprovedDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.ApprovedByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ApprovedByUserID
        {
            get
            {
                return GetSystemString(TransChargesMetadata.ColumnNames.ApprovedByUserID);
            }

            set
            {
                if (SetSystemString(TransChargesMetadata.ColumnNames.ApprovedByUserID, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.ApprovedByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.AnalystID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string AnalystID
        {
            get
            {
                return GetSystemString(TransChargesMetadata.ColumnNames.AnalystID);
            }

            set
            {
                if (SetSystemString(TransChargesMetadata.ColumnNames.AnalystID, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.AnalystID);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.VoidDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? VoidDateTime
        {
            get
            {
                return GetSystemDateTime(TransChargesMetadata.ColumnNames.VoidDateTime);
            }

            set
            {
                if (SetSystemDateTime(TransChargesMetadata.ColumnNames.VoidDateTime, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.VoidDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.VoidByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string VoidByUserID
        {
            get
            {
                return GetSystemString(TransChargesMetadata.ColumnNames.VoidByUserID);
            }

            set
            {
                if (SetSystemString(TransChargesMetadata.ColumnNames.VoidByUserID, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.VoidByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.SROrderStatus
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SROrderStatus
        {
            get
            {
                return GetSystemString(TransChargesMetadata.ColumnNames.SROrderStatus);
            }

            set
            {
                if (SetSystemString(TransChargesMetadata.ColumnNames.SROrderStatus, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.SROrderStatus);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.ResultReadByPhysicianID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ResultReadByPhysicianID
        {
            get
            {
                return GetSystemString(TransChargesMetadata.ColumnNames.ResultReadByPhysicianID);
            }

            set
            {
                if (SetSystemString(TransChargesMetadata.ColumnNames.ResultReadByPhysicianID, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.ResultReadByPhysicianID);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.ResultReadByPhysicianDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? ResultReadByPhysicianDateTime
        {
            get
            {
                return GetSystemDateTime(TransChargesMetadata.ColumnNames.ResultReadByPhysicianDateTime);
            }

            set
            {
                if (SetSystemDateTime(TransChargesMetadata.ColumnNames.ResultReadByPhysicianDateTime, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.ResultReadByPhysicianDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to TransCharges.ClinicalDiagnosis
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ClinicalDiagnosis
        {
            get
            {
                return GetSystemString(TransChargesMetadata.ColumnNames.ClinicalDiagnosis);
            }

            set
            {
                if (SetSystemString(TransChargesMetadata.ColumnNames.ClinicalDiagnosis, value))
                {
                    OnPropertyChanged(TransChargesMetadata.PropertyNames.ClinicalDiagnosis);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return TransChargesMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public TransChargesQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new TransChargesQuery("tcQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(TransChargesQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(TransChargesQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((TransChargesQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private TransChargesQuery query;
    }



    [Serializable]
    abstract public partial class esTransChargesCollection : esEntityCollection<TransCharges>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return TransChargesMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "TransChargesCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public TransChargesQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new TransChargesQuery("tcQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(TransChargesQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new TransChargesQuery("tcQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(TransChargesQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((TransChargesQuery)query);
        }

        #endregion

        private TransChargesQuery query;
    }



    [Serializable]
    abstract public partial class esTransChargesQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return TransChargesMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "TransactionNo": return TransactionNo;
                case "RegistrationNo": return RegistrationNo;
                case "TransactionDate": return TransactionDate;
                case "ExecutionDate": return ExecutionDate;
                case "ReferenceNo": return ReferenceNo;
                case "FromServiceUnitID": return FromServiceUnitID;
                case "ToServiceUnitID": return ToServiceUnitID;
                case "ClassID": return ClassID;
                case "RoomID": return RoomID;
                case "BedID": return BedID;
                case "DueDate": return DueDate;
                case "SRShift": return SRShift;
                case "SRItemType": return SRItemType;
                case "IsProceed": return IsProceed;
                case "IsApproved": return IsApproved;
                case "IsVoid": return IsVoid;
                case "IsOrder": return IsOrder;
                case "IsCorrection": return IsCorrection;
                case "IsClusterAssign": return IsClusterAssign;
                case "IsAutoBillTransaction": return IsAutoBillTransaction;
                case "IsBillProceed": return IsBillProceed;
                case "Notes": return Notes;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "SRTypeResult": return SRTypeResult;
                case "ResponUnitID": return ResponUnitID;
                case "SurgicalPackageID": return SurgicalPackageID;
                case "IsPackage": return IsPackage;
                case "PackageReferenceNo": return PackageReferenceNo;
                case "IsRoomIn": return IsRoomIn;
                case "TariffDiscountForRoomIn": return TariffDiscountForRoomIn;
                case "IsNonPatient": return IsNonPatient;
                case "ServiceUnitBookingNo": return ServiceUnitBookingNo;
                case "CreatedDateTime": return CreatedDateTime;
                case "CreatedByUserID": return CreatedByUserID;
                case "PhysicianSenders": return PhysicianSenders;
                case "IsValidated": return IsValidated;
                case "ValidatedDateTime": return ValidatedDateTime;
                case "ValidatedByUserID": return ValidatedByUserID;
                case "LocationID": return LocationID;
                case "SRProdiaContractID": return SRProdiaContractID;
                case "LaboratoryParamedicID": return LaboratoryParamedicID;
                case "SRBloodSampleTakenBy": return SRBloodSampleTakenBy;
                case "ApprovedDateTime": return ApprovedDateTime;
                case "ApprovedByUserID": return ApprovedByUserID;
                case "AnalystID": return AnalystID;
                case "VoidDateTime": return VoidDateTime;
                case "VoidByUserID": return VoidByUserID;
                case "SROrderStatus": return SROrderStatus;
                case "ResultReadByPhysicianID": return ResultReadByPhysicianID;
                case "ResultReadByPhysicianDateTime": return ResultReadByPhysicianDateTime;
                case "ClinicalDiagnosis": return ClinicalDiagnosis;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem TransactionNo
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.TransactionNo, esSystemType.String); }
        }

        public esQueryItem RegistrationNo
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.RegistrationNo, esSystemType.String); }
        }

        public esQueryItem TransactionDate
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.TransactionDate, esSystemType.DateTime); }
        }

        public esQueryItem ExecutionDate
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.ExecutionDate, esSystemType.DateTime); }
        }

        public esQueryItem ReferenceNo
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.ReferenceNo, esSystemType.String); }
        }

        public esQueryItem FromServiceUnitID
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.FromServiceUnitID, esSystemType.String); }
        }

        public esQueryItem ToServiceUnitID
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.ToServiceUnitID, esSystemType.String); }
        }

        public esQueryItem ClassID
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.ClassID, esSystemType.String); }
        }

        public esQueryItem RoomID
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.RoomID, esSystemType.String); }
        }

        public esQueryItem BedID
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.BedID, esSystemType.String); }
        }

        public esQueryItem DueDate
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.DueDate, esSystemType.DateTime); }
        }

        public esQueryItem SRShift
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.SRShift, esSystemType.String); }
        }

        public esQueryItem SRItemType
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.SRItemType, esSystemType.String); }
        }

        public esQueryItem IsProceed
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.IsProceed, esSystemType.Boolean); }
        }

        public esQueryItem IsApproved
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.IsApproved, esSystemType.Boolean); }
        }

        public esQueryItem IsVoid
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.IsVoid, esSystemType.Boolean); }
        }

        public esQueryItem IsOrder
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.IsOrder, esSystemType.Boolean); }
        }

        public esQueryItem IsCorrection
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.IsCorrection, esSystemType.Boolean); }
        }

        public esQueryItem IsClusterAssign
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.IsClusterAssign, esSystemType.Boolean); }
        }

        public esQueryItem IsAutoBillTransaction
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.IsAutoBillTransaction, esSystemType.Boolean); }
        }

        public esQueryItem IsBillProceed
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.IsBillProceed, esSystemType.Boolean); }
        }

        public esQueryItem Notes
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.Notes, esSystemType.String); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem SRTypeResult
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.SRTypeResult, esSystemType.String); }
        }

        public esQueryItem ResponUnitID
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.ResponUnitID, esSystemType.String); }
        }

        public esQueryItem SurgicalPackageID
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.SurgicalPackageID, esSystemType.String); }
        }

        public esQueryItem IsPackage
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.IsPackage, esSystemType.Boolean); }
        }

        public esQueryItem PackageReferenceNo
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.PackageReferenceNo, esSystemType.String); }
        }

        public esQueryItem IsRoomIn
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.IsRoomIn, esSystemType.Boolean); }
        }

        public esQueryItem TariffDiscountForRoomIn
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.TariffDiscountForRoomIn, esSystemType.Decimal); }
        }

        public esQueryItem IsNonPatient
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.IsNonPatient, esSystemType.Boolean); }
        }

        public esQueryItem ServiceUnitBookingNo
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.ServiceUnitBookingNo, esSystemType.String); }
        }

        public esQueryItem CreatedDateTime
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.CreatedDateTime, esSystemType.DateTime); }
        }

        public esQueryItem CreatedByUserID
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.CreatedByUserID, esSystemType.String); }
        }

        public esQueryItem PhysicianSenders
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.PhysicianSenders, esSystemType.String); }
        }

        public esQueryItem IsValidated
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.IsValidated, esSystemType.Boolean); }
        }

        public esQueryItem ValidatedDateTime
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.ValidatedDateTime, esSystemType.DateTime); }
        }

        public esQueryItem ValidatedByUserID
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.ValidatedByUserID, esSystemType.String); }
        }

        public esQueryItem LocationID
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.LocationID, esSystemType.String); }
        }

        public esQueryItem SRProdiaContractID
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.SRProdiaContractID, esSystemType.String); }
        }

        public esQueryItem LaboratoryParamedicID
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.LaboratoryParamedicID, esSystemType.String); }
        }

        public esQueryItem SRBloodSampleTakenBy
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.SRBloodSampleTakenBy, esSystemType.String); }
        }

        public esQueryItem ApprovedDateTime
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.ApprovedDateTime, esSystemType.DateTime); }
        }

        public esQueryItem ApprovedByUserID
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.ApprovedByUserID, esSystemType.String); }
        }

        public esQueryItem AnalystID
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.AnalystID, esSystemType.String); }
        }

        public esQueryItem VoidDateTime
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.VoidDateTime, esSystemType.DateTime); }
        }

        public esQueryItem VoidByUserID
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.VoidByUserID, esSystemType.String); }
        }

        public esQueryItem SROrderStatus
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.SROrderStatus, esSystemType.String); }
        }

        public esQueryItem ResultReadByPhysicianID
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.ResultReadByPhysicianID, esSystemType.String); }
        }

        public esQueryItem ResultReadByPhysicianDateTime
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.ResultReadByPhysicianDateTime, esSystemType.DateTime); }
        }

        public esQueryItem ClinicalDiagnosis
        {
            get { return new esQueryItem(this, TransChargesMetadata.ColumnNames.ClinicalDiagnosis, esSystemType.String); }
        }

        #endregion

    }



    [Serializable]
    public partial class TransChargesMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected TransChargesMetadata()
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

            c = new esColumnMetadata(ColumnNames.RegistrationNo, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RegistrationNo;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TransactionDate, 2, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.TransactionDate;
            c.HasDefault = true;
            c.Default = @"(getdate())";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ExecutionDate, 3, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.ExecutionDate;
            c.HasDefault = true;
            c.Default = @"(getdate())";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ReferenceNo, 4, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ReferenceNo;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FromServiceUnitID, 5, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.FromServiceUnitID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ToServiceUnitID, 6, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ToServiceUnitID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ClassID, 7, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ClassID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RoomID, 8, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RoomID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.BedID, 9, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.BedID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DueDate, 10, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.DueDate;
            c.HasDefault = true;
            c.Default = @"(getdate())";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRShift, 11, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRShift;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRItemType, 12, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRItemType;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsProceed, 13, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsProceed;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsApproved, 14, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsApproved;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsVoid, 15, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsVoid;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsOrder, 16, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsOrder;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsCorrection, 17, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsCorrection;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsClusterAssign, 18, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsClusterAssign;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsAutoBillTransaction, 19, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsAutoBillTransaction;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsBillProceed, 20, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsBillProceed;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Notes, 21, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Notes;
            c.CharacterMaxLength = 4000;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 22, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 23, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 40;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRTypeResult, 24, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRTypeResult;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ResponUnitID, 25, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ResponUnitID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SurgicalPackageID, 26, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SurgicalPackageID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsPackage, 27, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsPackage;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PackageReferenceNo, 28, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PackageReferenceNo;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsRoomIn, 29, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsRoomIn;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TariffDiscountForRoomIn, 30, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.TariffDiscountForRoomIn;
            c.NumericPrecision = 10;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsNonPatient, 31, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsNonPatient;
            c.HasDefault = true;
            c.Default = @"(CONVERT([bit],(0),0))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ServiceUnitBookingNo, 32, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ServiceUnitBookingNo;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreatedDateTime, 33, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.CreatedDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreatedByUserID, 34, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.CreatedByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PhysicianSenders, 35, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PhysicianSenders;
            c.CharacterMaxLength = 255;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsValidated, 36, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsValidated;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ValidatedDateTime, 37, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.ValidatedDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ValidatedByUserID, 38, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ValidatedByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LocationID, 39, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LocationID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRProdiaContractID, 40, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRProdiaContractID;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LaboratoryParamedicID, 41, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LaboratoryParamedicID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRBloodSampleTakenBy, 42, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRBloodSampleTakenBy;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ApprovedDateTime, 43, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.ApprovedDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ApprovedByUserID, 44, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ApprovedByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AnalystID, 45, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.AnalystID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.VoidDateTime, 46, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.VoidDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.VoidByUserID, 47, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.VoidByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SROrderStatus, 48, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SROrderStatus;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ResultReadByPhysicianID, 49, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ResultReadByPhysicianID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ResultReadByPhysicianDateTime, 50, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.ResultReadByPhysicianDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ClinicalDiagnosis, 51, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ClinicalDiagnosis;
            c.CharacterMaxLength = 500;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public TransChargesMetadata Meta()
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
            public const string TransactionDate = "TransactionDate";
            public const string ExecutionDate = "ExecutionDate";
            public const string ReferenceNo = "ReferenceNo";
            public const string FromServiceUnitID = "FromServiceUnitID";
            public const string ToServiceUnitID = "ToServiceUnitID";
            public const string ClassID = "ClassID";
            public const string RoomID = "RoomID";
            public const string BedID = "BedID";
            public const string DueDate = "DueDate";
            public const string SRShift = "SRShift";
            public const string SRItemType = "SRItemType";
            public const string IsProceed = "IsProceed";
            public const string IsApproved = "IsApproved";
            public const string IsVoid = "IsVoid";
            public const string IsOrder = "IsOrder";
            public const string IsCorrection = "IsCorrection";
            public const string IsClusterAssign = "IsClusterAssign";
            public const string IsAutoBillTransaction = "IsAutoBillTransaction";
            public const string IsBillProceed = "IsBillProceed";
            public const string Notes = "Notes";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string SRTypeResult = "SRTypeResult";
            public const string ResponUnitID = "ResponUnitID";
            public const string SurgicalPackageID = "SurgicalPackageID";
            public const string IsPackage = "IsPackage";
            public const string PackageReferenceNo = "PackageReferenceNo";
            public const string IsRoomIn = "IsRoomIn";
            public const string TariffDiscountForRoomIn = "TariffDiscountForRoomIn";
            public const string IsNonPatient = "IsNonPatient";
            public const string ServiceUnitBookingNo = "ServiceUnitBookingNo";
            public const string CreatedDateTime = "CreatedDateTime";
            public const string CreatedByUserID = "CreatedByUserID";
            public const string PhysicianSenders = "PhysicianSenders";
            public const string IsValidated = "IsValidated";
            public const string ValidatedDateTime = "ValidatedDateTime";
            public const string ValidatedByUserID = "ValidatedByUserID";
            public const string LocationID = "LocationID";
            public const string SRProdiaContractID = "SRProdiaContractID";
            public const string LaboratoryParamedicID = "LaboratoryParamedicID";
            public const string SRBloodSampleTakenBy = "SRBloodSampleTakenBy";
            public const string ApprovedDateTime = "ApprovedDateTime";
            public const string ApprovedByUserID = "ApprovedByUserID";
            public const string AnalystID = "AnalystID";
            public const string VoidDateTime = "VoidDateTime";
            public const string VoidByUserID = "VoidByUserID";
            public const string SROrderStatus = "SROrderStatus";
            public const string ResultReadByPhysicianID = "ResultReadByPhysicianID";
            public const string ResultReadByPhysicianDateTime = "ResultReadByPhysicianDateTime";
            public const string ClinicalDiagnosis = "ClinicalDiagnosis";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string TransactionNo = "TransactionNo";
            public const string RegistrationNo = "RegistrationNo";
            public const string TransactionDate = "TransactionDate";
            public const string ExecutionDate = "ExecutionDate";
            public const string ReferenceNo = "ReferenceNo";
            public const string FromServiceUnitID = "FromServiceUnitID";
            public const string ToServiceUnitID = "ToServiceUnitID";
            public const string ClassID = "ClassID";
            public const string RoomID = "RoomID";
            public const string BedID = "BedID";
            public const string DueDate = "DueDate";
            public const string SRShift = "SRShift";
            public const string SRItemType = "SRItemType";
            public const string IsProceed = "IsProceed";
            public const string IsApproved = "IsApproved";
            public const string IsVoid = "IsVoid";
            public const string IsOrder = "IsOrder";
            public const string IsCorrection = "IsCorrection";
            public const string IsClusterAssign = "IsClusterAssign";
            public const string IsAutoBillTransaction = "IsAutoBillTransaction";
            public const string IsBillProceed = "IsBillProceed";
            public const string Notes = "Notes";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string SRTypeResult = "SRTypeResult";
            public const string ResponUnitID = "ResponUnitID";
            public const string SurgicalPackageID = "SurgicalPackageID";
            public const string IsPackage = "IsPackage";
            public const string PackageReferenceNo = "PackageReferenceNo";
            public const string IsRoomIn = "IsRoomIn";
            public const string TariffDiscountForRoomIn = "TariffDiscountForRoomIn";
            public const string IsNonPatient = "IsNonPatient";
            public const string ServiceUnitBookingNo = "ServiceUnitBookingNo";
            public const string CreatedDateTime = "CreatedDateTime";
            public const string CreatedByUserID = "CreatedByUserID";
            public const string PhysicianSenders = "PhysicianSenders";
            public const string IsValidated = "IsValidated";
            public const string ValidatedDateTime = "ValidatedDateTime";
            public const string ValidatedByUserID = "ValidatedByUserID";
            public const string LocationID = "LocationID";
            public const string SRProdiaContractID = "SRProdiaContractID";
            public const string LaboratoryParamedicID = "LaboratoryParamedicID";
            public const string SRBloodSampleTakenBy = "SRBloodSampleTakenBy";
            public const string ApprovedDateTime = "ApprovedDateTime";
            public const string ApprovedByUserID = "ApprovedByUserID";
            public const string AnalystID = "AnalystID";
            public const string VoidDateTime = "VoidDateTime";
            public const string VoidByUserID = "VoidByUserID";
            public const string SROrderStatus = "SROrderStatus";
            public const string ResultReadByPhysicianID = "ResultReadByPhysicianID";
            public const string ResultReadByPhysicianDateTime = "ResultReadByPhysicianDateTime";
            public const string ClinicalDiagnosis = "ClinicalDiagnosis";
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
            lock (typeof(TransChargesMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new TransChargesMetadata();
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
                meta.AddTypeMap("TransactionDate", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("ExecutionDate", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("ReferenceNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("FromServiceUnitID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ToServiceUnitID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ClassID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("RoomID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("BedID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("DueDate", new esTypeMap("smalldatetime", "System.DateTime"));
                meta.AddTypeMap("SRShift", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRItemType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsProceed", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsApproved", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsVoid", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsOrder", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsCorrection", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsClusterAssign", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsAutoBillTransaction", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsBillProceed", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("Notes", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRTypeResult", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ResponUnitID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SurgicalPackageID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsPackage", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("PackageReferenceNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsRoomIn", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("TariffDiscountForRoomIn", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("IsNonPatient", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ServiceUnitBookingNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CreatedDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("CreatedByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PhysicianSenders", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsValidated", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ValidatedDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("ValidatedByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LocationID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRProdiaContractID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LaboratoryParamedicID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRBloodSampleTakenBy", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ApprovedDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("ApprovedByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("AnalystID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("VoidDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("VoidByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SROrderStatus", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ResultReadByPhysicianID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ResultReadByPhysicianDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("ClinicalDiagnosis", new esTypeMap("varchar", "System.String"));



                meta.Source = "TransCharges";
                meta.Destination = "TransCharges";

                meta.spInsert = "proc_TransChargesInsert";
                meta.spUpdate = "proc_TransChargesUpdate";
                meta.spDelete = "proc_TransChargesDelete";
                meta.spLoadAll = "proc_TransChargesLoadAll";
                meta.spLoadByPrimaryKey = "proc_TransChargesLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private TransChargesMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
