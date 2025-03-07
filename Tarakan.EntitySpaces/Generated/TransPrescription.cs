
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 2/14/2025 11:51:04 AM
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
    /// Encapsulates the 'TransPrescription' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(TransPrescription))]
    [XmlType("TransPrescription")]
    public partial class TransPrescription : esTransPrescription
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new TransPrescription();
        }

        #region Static Quick Access Methods
        static public void Delete(string prescriptionNo)
        {
            var obj = new TransPrescription();
            obj.PrescriptionNo = prescriptionNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string prescriptionNo, esSqlAccessType sqlAccessType)
        {
            var obj = new TransPrescription();
            obj.PrescriptionNo = prescriptionNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("TransPrescriptionCollection")]
    public partial class TransPrescriptionCollection : esTransPrescriptionCollection, IEnumerable<TransPrescription>
    {
        public TransPrescription FindByPrimaryKey(string prescriptionNo)
        {
            return this.SingleOrDefault(e => e.PrescriptionNo == prescriptionNo);
        }



    }



    [Serializable]
    public partial class TransPrescriptionQuery : esTransPrescriptionQuery
    {
        public TransPrescriptionQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public TransPrescriptionQuery(string joinAlias, out TransPrescriptionQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "TransPrescriptionQuery";
        }



        #region Explicit Casts

        public static explicit operator string(TransPrescriptionQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator TransPrescriptionQuery(string query)
        {
            return (TransPrescriptionQuery)SerializeHelper.FromXml(query, typeof(TransPrescriptionQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esTransPrescription : esEntity
    {
        public esTransPrescription()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string prescriptionNo)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(prescriptionNo);
            else
                return LoadByPrimaryKeyStoredProcedure(prescriptionNo);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string prescriptionNo)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(prescriptionNo);
            else
                return LoadByPrimaryKeyStoredProcedure(prescriptionNo);
        }

        private bool LoadByPrimaryKeyDynamic(string prescriptionNo)
        {
            TransPrescriptionQuery query = new TransPrescriptionQuery("tpQ");
            query.Where(query.PrescriptionNo == prescriptionNo);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string prescriptionNo)
        {
            esParameters parms = new esParameters();
            parms.Add("PrescriptionNo", prescriptionNo);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to TransPrescription.PrescriptionNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PrescriptionNo
        {
            get
            {
                return GetSystemString(TransPrescriptionMetadata.ColumnNames.PrescriptionNo);
            }

            set
            {
                if (SetSystemString(TransPrescriptionMetadata.ColumnNames.PrescriptionNo, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.PrescriptionNo);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.PrescriptionDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? PrescriptionDate
        {
            get
            {
                return GetSystemDateTime(TransPrescriptionMetadata.ColumnNames.PrescriptionDate);
            }

            set
            {
                if (SetSystemDateTime(TransPrescriptionMetadata.ColumnNames.PrescriptionDate, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.PrescriptionDate);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.RegistrationNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RegistrationNo
        {
            get
            {
                return GetSystemString(TransPrescriptionMetadata.ColumnNames.RegistrationNo);
            }

            set
            {
                if (SetSystemString(TransPrescriptionMetadata.ColumnNames.RegistrationNo, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.RegistrationNo);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.ServiceUnitID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ServiceUnitID
        {
            get
            {
                return GetSystemString(TransPrescriptionMetadata.ColumnNames.ServiceUnitID);
            }

            set
            {
                if (SetSystemString(TransPrescriptionMetadata.ColumnNames.ServiceUnitID, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.ServiceUnitID);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.ClassID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ClassID
        {
            get
            {
                return GetSystemString(TransPrescriptionMetadata.ColumnNames.ClassID);
            }

            set
            {
                if (SetSystemString(TransPrescriptionMetadata.ColumnNames.ClassID, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.ClassID);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.ParamedicID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParamedicID
        {
            get
            {
                return GetSystemString(TransPrescriptionMetadata.ColumnNames.ParamedicID);
            }

            set
            {
                if (SetSystemString(TransPrescriptionMetadata.ColumnNames.ParamedicID, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.ParamedicID);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.IsApproval
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsApproval
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsApproval);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsApproval, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.IsApproval);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.IsVoid
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsVoid
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsVoid);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsVoid, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.IsVoid);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.Note
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Note
        {
            get
            {
                return GetSystemString(TransPrescriptionMetadata.ColumnNames.Note);
            }

            set
            {
                if (SetSystemString(TransPrescriptionMetadata.ColumnNames.Note, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.Note);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(TransPrescriptionMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(TransPrescriptionMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(TransPrescriptionMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(TransPrescriptionMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.IsPrescriptionReturn
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsPrescriptionReturn
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsPrescriptionReturn);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsPrescriptionReturn, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.IsPrescriptionReturn);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.ReferenceNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ReferenceNo
        {
            get
            {
                return GetSystemString(TransPrescriptionMetadata.ColumnNames.ReferenceNo);
            }

            set
            {
                if (SetSystemString(TransPrescriptionMetadata.ColumnNames.ReferenceNo, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.ReferenceNo);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.IsFromSOAP
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsFromSOAP
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsFromSOAP);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsFromSOAP, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.IsFromSOAP);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.IsBillProceed
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsBillProceed
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsBillProceed);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsBillProceed, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.IsBillProceed);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.IsUnitDosePrescription
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsUnitDosePrescription
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsUnitDosePrescription);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsUnitDosePrescription, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.IsUnitDosePrescription);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.IsCito
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsCito
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsCito);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsCito, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.IsCito);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.IsClosed
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsClosed
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsClosed);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsClosed, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.IsClosed);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.ApprovalDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? ApprovalDateTime
        {
            get
            {
                return GetSystemDateTime(TransPrescriptionMetadata.ColumnNames.ApprovalDateTime);
            }

            set
            {
                if (SetSystemDateTime(TransPrescriptionMetadata.ColumnNames.ApprovalDateTime, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.ApprovalDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.DeliverDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? DeliverDateTime
        {
            get
            {
                return GetSystemDateTime(TransPrescriptionMetadata.ColumnNames.DeliverDateTime);
            }

            set
            {
                if (SetSystemDateTime(TransPrescriptionMetadata.ColumnNames.DeliverDateTime, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.DeliverDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.TextPrescription
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TextPrescription
        {
            get
            {
                return GetSystemString(TransPrescriptionMetadata.ColumnNames.TextPrescription);
            }

            set
            {
                if (SetSystemString(TransPrescriptionMetadata.ColumnNames.TextPrescription, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.TextPrescription);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.IsDirect
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsDirect
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsDirect);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsDirect, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.IsDirect);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.IsPaid
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsPaid
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsPaid);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsPaid, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.IsPaid);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.OrderNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string OrderNo
        {
            get
            {
                return GetSystemString(TransPrescriptionMetadata.ColumnNames.OrderNo);
            }

            set
            {
                if (SetSystemString(TransPrescriptionMetadata.ColumnNames.OrderNo, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.OrderNo);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.IsProceedByPharmacist
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsProceedByPharmacist
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsProceedByPharmacist);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsProceedByPharmacist, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.IsProceedByPharmacist);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.FullAddress
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string FullAddress
        {
            get
            {
                return GetSystemString(TransPrescriptionMetadata.ColumnNames.FullAddress);
            }

            set
            {
                if (SetSystemString(TransPrescriptionMetadata.ColumnNames.FullAddress, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.FullAddress);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.NoTelp
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string NoTelp
        {
            get
            {
                return GetSystemString(TransPrescriptionMetadata.ColumnNames.NoTelp);
            }

            set
            {
                if (SetSystemString(TransPrescriptionMetadata.ColumnNames.NoTelp, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.NoTelp);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.AdditionalNote
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string AdditionalNote
        {
            get
            {
                return GetSystemString(TransPrescriptionMetadata.ColumnNames.AdditionalNote);
            }

            set
            {
                if (SetSystemString(TransPrescriptionMetadata.ColumnNames.AdditionalNote, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.AdditionalNote);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.SRFloor
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRFloor
        {
            get
            {
                return GetSystemString(TransPrescriptionMetadata.ColumnNames.SRFloor);
            }

            set
            {
                if (SetSystemString(TransPrescriptionMetadata.ColumnNames.SRFloor, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.SRFloor);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.CreatedDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? CreatedDateTime
        {
            get
            {
                return GetSystemDateTime(TransPrescriptionMetadata.ColumnNames.CreatedDateTime);
            }

            set
            {
                if (SetSystemDateTime(TransPrescriptionMetadata.ColumnNames.CreatedDateTime, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.CreatedDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.CreatedByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string CreatedByUserID
        {
            get
            {
                return GetSystemString(TransPrescriptionMetadata.ColumnNames.CreatedByUserID);
            }

            set
            {
                if (SetSystemString(TransPrescriptionMetadata.ColumnNames.CreatedByUserID, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.CreatedByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.QtyR
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public short? QtyR
        {
            get
            {
                return GetSystemInt16(TransPrescriptionMetadata.ColumnNames.QtyR);
            }

            set
            {
                if (SetSystemInt16(TransPrescriptionMetadata.ColumnNames.QtyR, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.QtyR);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.ApprovedByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ApprovedByUserID
        {
            get
            {
                return GetSystemString(TransPrescriptionMetadata.ColumnNames.ApprovedByUserID);
            }

            set
            {
                if (SetSystemString(TransPrescriptionMetadata.ColumnNames.ApprovedByUserID, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.ApprovedByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.IsPrinted
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsPrinted
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsPrinted);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsPrinted, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.IsPrinted);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.FloorSeqNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? FloorSeqNo
        {
            get
            {
                return GetSystemInt32(TransPrescriptionMetadata.ColumnNames.FloorSeqNo);
            }

            set
            {
                if (SetSystemInt32(TransPrescriptionMetadata.ColumnNames.FloorSeqNo, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.FloorSeqNo);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.Rtype
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Rtype
        {
            get
            {
                return GetSystemString(TransPrescriptionMetadata.ColumnNames.Rtype);
            }

            set
            {
                if (SetSystemString(TransPrescriptionMetadata.ColumnNames.Rtype, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.Rtype);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.FromServiceUnitID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string FromServiceUnitID
        {
            get
            {
                return GetSystemString(TransPrescriptionMetadata.ColumnNames.FromServiceUnitID);
            }

            set
            {
                if (SetSystemString(TransPrescriptionMetadata.ColumnNames.FromServiceUnitID, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.FromServiceUnitID);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.FromRoomID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string FromRoomID
        {
            get
            {
                return GetSystemString(TransPrescriptionMetadata.ColumnNames.FromRoomID);
            }

            set
            {
                if (SetSystemString(TransPrescriptionMetadata.ColumnNames.FromRoomID, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.FromRoomID);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.FromBedID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string FromBedID
        {
            get
            {
                return GetSystemString(TransPrescriptionMetadata.ColumnNames.FromBedID);
            }

            set
            {
                if (SetSystemString(TransPrescriptionMetadata.ColumnNames.FromBedID, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.FromBedID);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.LocationID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LocationID
        {
            get
            {
                return GetSystemString(TransPrescriptionMetadata.ColumnNames.LocationID);
            }

            set
            {
                if (SetSystemString(TransPrescriptionMetadata.ColumnNames.LocationID, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.LocationID);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.CompleteDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? CompleteDateTime
        {
            get
            {
                return GetSystemDateTime(TransPrescriptionMetadata.ColumnNames.CompleteDateTime);
            }

            set
            {
                if (SetSystemDateTime(TransPrescriptionMetadata.ColumnNames.CompleteDateTime, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.CompleteDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.VoidReason
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string VoidReason
        {
            get
            {
                return GetSystemString(TransPrescriptionMetadata.ColumnNames.VoidReason);
            }

            set
            {
                if (SetSystemString(TransPrescriptionMetadata.ColumnNames.VoidReason, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.VoidReason);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.ExecutionDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? ExecutionDate
        {
            get
            {
                return GetSystemDateTime(TransPrescriptionMetadata.ColumnNames.ExecutionDate);
            }

            set
            {
                if (SetSystemDateTime(TransPrescriptionMetadata.ColumnNames.ExecutionDate, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.ExecutionDate);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.IsPos
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsPos
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsPos);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsPos, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.IsPos);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.IsForTakeItHome
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsForTakeItHome
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsForTakeItHome);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsForTakeItHome, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.IsForTakeItHome);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.PatientEducationSeqNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? PatientEducationSeqNo
        {
            get
            {
                return GetSystemInt32(TransPrescriptionMetadata.ColumnNames.PatientEducationSeqNo);
            }

            set
            {
                if (SetSystemInt32(TransPrescriptionMetadata.ColumnNames.PatientEducationSeqNo, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.PatientEducationSeqNo);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.ReviewByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ReviewByUserID
        {
            get
            {
                return GetSystemString(TransPrescriptionMetadata.ColumnNames.ReviewByUserID);
            }

            set
            {
                if (SetSystemString(TransPrescriptionMetadata.ColumnNames.ReviewByUserID, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.ReviewByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.IsUnapproved
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsUnapproved
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsUnapproved);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsUnapproved, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.IsUnapproved);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.UnapprovedDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? UnapprovedDateTime
        {
            get
            {
                return GetSystemDateTime(TransPrescriptionMetadata.ColumnNames.UnapprovedDateTime);
            }

            set
            {
                if (SetSystemDateTime(TransPrescriptionMetadata.ColumnNames.UnapprovedDateTime, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.UnapprovedDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.UnapprovedByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string UnapprovedByUserID
        {
            get
            {
                return GetSystemString(TransPrescriptionMetadata.ColumnNames.UnapprovedByUserID);
            }

            set
            {
                if (SetSystemString(TransPrescriptionMetadata.ColumnNames.UnapprovedByUserID, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.UnapprovedByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.SRKioskQueueType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRKioskQueueType
        {
            get
            {
                return GetSystemString(TransPrescriptionMetadata.ColumnNames.SRKioskQueueType);
            }

            set
            {
                if (SetSystemString(TransPrescriptionMetadata.ColumnNames.SRKioskQueueType, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.SRKioskQueueType);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.KioskQueueNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string KioskQueueNo
        {
            get
            {
                return GetSystemString(TransPrescriptionMetadata.ColumnNames.KioskQueueNo);
            }

            set
            {
                if (SetSystemString(TransPrescriptionMetadata.ColumnNames.KioskQueueNo, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.KioskQueueNo);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.IsVerified
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsVerified
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsVerified);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsVerified, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.IsVerified);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.VerifiedByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string VerifiedByUserID
        {
            get
            {
                return GetSystemString(TransPrescriptionMetadata.ColumnNames.VerifiedByUserID);
            }

            set
            {
                if (SetSystemString(TransPrescriptionMetadata.ColumnNames.VerifiedByUserID, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.VerifiedByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.VerifiedDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? VerifiedDateTime
        {
            get
            {
                return GetSystemDateTime(TransPrescriptionMetadata.ColumnNames.VerifiedDateTime);
            }

            set
            {
                if (SetSystemDateTime(TransPrescriptionMetadata.ColumnNames.VerifiedDateTime, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.VerifiedDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.SRPrescriptionCategory
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRPrescriptionCategory
        {
            get
            {
                return GetSystemString(TransPrescriptionMetadata.ColumnNames.SRPrescriptionCategory);
            }

            set
            {
                if (SetSystemString(TransPrescriptionMetadata.ColumnNames.SRPrescriptionCategory, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.SRPrescriptionCategory);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.RasproSeqNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? RasproSeqNo
        {
            get
            {
                return GetSystemInt32(TransPrescriptionMetadata.ColumnNames.RasproSeqNo);
            }

            set
            {
                if (SetSystemInt32(TransPrescriptionMetadata.ColumnNames.RasproSeqNo, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.RasproSeqNo);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.IsReviewed
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsReviewed
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsReviewed);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsReviewed, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.IsReviewed);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.ReviewedByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ReviewedByUserID
        {
            get
            {
                return GetSystemString(TransPrescriptionMetadata.ColumnNames.ReviewedByUserID);
            }

            set
            {
                if (SetSystemString(TransPrescriptionMetadata.ColumnNames.ReviewedByUserID, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.ReviewedByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.ReviewedDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? ReviewedDateTime
        {
            get
            {
                return GetSystemDateTime(TransPrescriptionMetadata.ColumnNames.ReviewedDateTime);
            }

            set
            {
                if (SetSystemDateTime(TransPrescriptionMetadata.ColumnNames.ReviewedDateTime, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.ReviewedDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.Is23Days
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? Is23Days
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionMetadata.ColumnNames.Is23Days);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionMetadata.ColumnNames.Is23Days, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.Is23Days);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.IsSplitBill
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsSplitBill
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsSplitBill);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsSplitBill, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.IsSplitBill);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.IsCash
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsCash
        {
            get
            {
                return GetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsCash);
            }

            set
            {
                if (SetSystemBoolean(TransPrescriptionMetadata.ColumnNames.IsCash, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.IsCash);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.DeliverByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DeliverByUserID
        {
            get
            {
                return GetSystemString(TransPrescriptionMetadata.ColumnNames.DeliverByUserID);
            }

            set
            {
                if (SetSystemString(TransPrescriptionMetadata.ColumnNames.DeliverByUserID, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.DeliverByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.CompleteByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string CompleteByUserID
        {
            get
            {
                return GetSystemString(TransPrescriptionMetadata.ColumnNames.CompleteByUserID);
            }

            set
            {
                if (SetSystemString(TransPrescriptionMetadata.ColumnNames.CompleteByUserID, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.CompleteByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.InProgressByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string InProgressByUserID
        {
            get
            {
                return GetSystemString(TransPrescriptionMetadata.ColumnNames.InProgressByUserID);
            }

            set
            {
                if (SetSystemString(TransPrescriptionMetadata.ColumnNames.InProgressByUserID, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.InProgressByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to TransPrescription.InProgressDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? InProgressDateTime
        {
            get
            {
                return GetSystemDateTime(TransPrescriptionMetadata.ColumnNames.InProgressDateTime);
            }

            set
            {
                if (SetSystemDateTime(TransPrescriptionMetadata.ColumnNames.InProgressDateTime, value))
                {
                    OnPropertyChanged(TransPrescriptionMetadata.PropertyNames.InProgressDateTime);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return TransPrescriptionMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public TransPrescriptionQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new TransPrescriptionQuery("tpQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(TransPrescriptionQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(TransPrescriptionQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((TransPrescriptionQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private TransPrescriptionQuery query;
    }



    [Serializable]
    abstract public partial class esTransPrescriptionCollection : esEntityCollection<TransPrescription>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return TransPrescriptionMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "TransPrescriptionCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public TransPrescriptionQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new TransPrescriptionQuery("tpQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(TransPrescriptionQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new TransPrescriptionQuery("tpQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(TransPrescriptionQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((TransPrescriptionQuery)query);
        }

        #endregion

        private TransPrescriptionQuery query;
    }



    [Serializable]
    abstract public partial class esTransPrescriptionQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return TransPrescriptionMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "PrescriptionNo": return PrescriptionNo;
                case "PrescriptionDate": return PrescriptionDate;
                case "RegistrationNo": return RegistrationNo;
                case "ServiceUnitID": return ServiceUnitID;
                case "ClassID": return ClassID;
                case "ParamedicID": return ParamedicID;
                case "IsApproval": return IsApproval;
                case "IsVoid": return IsVoid;
                case "Note": return Note;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "IsPrescriptionReturn": return IsPrescriptionReturn;
                case "ReferenceNo": return ReferenceNo;
                case "IsFromSOAP": return IsFromSOAP;
                case "IsBillProceed": return IsBillProceed;
                case "IsUnitDosePrescription": return IsUnitDosePrescription;
                case "IsCito": return IsCito;
                case "IsClosed": return IsClosed;
                case "ApprovalDateTime": return ApprovalDateTime;
                case "DeliverDateTime": return DeliverDateTime;
                case "TextPrescription": return TextPrescription;
                case "IsDirect": return IsDirect;
                case "IsPaid": return IsPaid;
                case "OrderNo": return OrderNo;
                case "IsProceedByPharmacist": return IsProceedByPharmacist;
                case "FullAddress": return FullAddress;
                case "NoTelp": return NoTelp;
                case "AdditionalNote": return AdditionalNote;
                case "SRFloor": return SRFloor;
                case "CreatedDateTime": return CreatedDateTime;
                case "CreatedByUserID": return CreatedByUserID;
                case "QtyR": return QtyR;
                case "ApprovedByUserID": return ApprovedByUserID;
                case "IsPrinted": return IsPrinted;
                case "FloorSeqNo": return FloorSeqNo;
                case "Rtype": return Rtype;
                case "FromServiceUnitID": return FromServiceUnitID;
                case "FromRoomID": return FromRoomID;
                case "FromBedID": return FromBedID;
                case "LocationID": return LocationID;
                case "CompleteDateTime": return CompleteDateTime;
                case "VoidReason": return VoidReason;
                case "ExecutionDate": return ExecutionDate;
                case "IsPos": return IsPos;
                case "IsForTakeItHome": return IsForTakeItHome;
                case "PatientEducationSeqNo": return PatientEducationSeqNo;
                case "ReviewByUserID": return ReviewByUserID;
                case "IsUnapproved": return IsUnapproved;
                case "UnapprovedDateTime": return UnapprovedDateTime;
                case "UnapprovedByUserID": return UnapprovedByUserID;
                case "SRKioskQueueType": return SRKioskQueueType;
                case "KioskQueueNo": return KioskQueueNo;
                case "IsVerified": return IsVerified;
                case "VerifiedByUserID": return VerifiedByUserID;
                case "VerifiedDateTime": return VerifiedDateTime;
                case "SRPrescriptionCategory": return SRPrescriptionCategory;
                case "RasproSeqNo": return RasproSeqNo;
                case "IsReviewed": return IsReviewed;
                case "ReviewedByUserID": return ReviewedByUserID;
                case "ReviewedDateTime": return ReviewedDateTime;
                case "Is23Days": return Is23Days;
                case "IsSplitBill": return IsSplitBill;
                case "IsCash": return IsCash;
                case "DeliverByUserID": return DeliverByUserID;
                case "CompleteByUserID": return CompleteByUserID;
                case "InProgressByUserID": return InProgressByUserID;
                case "InProgressDateTime": return InProgressDateTime;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem PrescriptionNo
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.PrescriptionNo, esSystemType.String); }
        }

        public esQueryItem PrescriptionDate
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.PrescriptionDate, esSystemType.DateTime); }
        }

        public esQueryItem RegistrationNo
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.RegistrationNo, esSystemType.String); }
        }

        public esQueryItem ServiceUnitID
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.ServiceUnitID, esSystemType.String); }
        }

        public esQueryItem ClassID
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.ClassID, esSystemType.String); }
        }

        public esQueryItem ParamedicID
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.ParamedicID, esSystemType.String); }
        }

        public esQueryItem IsApproval
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.IsApproval, esSystemType.Boolean); }
        }

        public esQueryItem IsVoid
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.IsVoid, esSystemType.Boolean); }
        }

        public esQueryItem Note
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.Note, esSystemType.String); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem IsPrescriptionReturn
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.IsPrescriptionReturn, esSystemType.Boolean); }
        }

        public esQueryItem ReferenceNo
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.ReferenceNo, esSystemType.String); }
        }

        public esQueryItem IsFromSOAP
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.IsFromSOAP, esSystemType.Boolean); }
        }

        public esQueryItem IsBillProceed
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.IsBillProceed, esSystemType.Boolean); }
        }

        public esQueryItem IsUnitDosePrescription
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.IsUnitDosePrescription, esSystemType.Boolean); }
        }

        public esQueryItem IsCito
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.IsCito, esSystemType.Boolean); }
        }

        public esQueryItem IsClosed
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.IsClosed, esSystemType.Boolean); }
        }

        public esQueryItem ApprovalDateTime
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.ApprovalDateTime, esSystemType.DateTime); }
        }

        public esQueryItem DeliverDateTime
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.DeliverDateTime, esSystemType.DateTime); }
        }

        public esQueryItem TextPrescription
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.TextPrescription, esSystemType.String); }
        }

        public esQueryItem IsDirect
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.IsDirect, esSystemType.Boolean); }
        }

        public esQueryItem IsPaid
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.IsPaid, esSystemType.Boolean); }
        }

        public esQueryItem OrderNo
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.OrderNo, esSystemType.String); }
        }

        public esQueryItem IsProceedByPharmacist
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.IsProceedByPharmacist, esSystemType.Boolean); }
        }

        public esQueryItem FullAddress
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.FullAddress, esSystemType.String); }
        }

        public esQueryItem NoTelp
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.NoTelp, esSystemType.String); }
        }

        public esQueryItem AdditionalNote
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.AdditionalNote, esSystemType.String); }
        }

        public esQueryItem SRFloor
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.SRFloor, esSystemType.String); }
        }

        public esQueryItem CreatedDateTime
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.CreatedDateTime, esSystemType.DateTime); }
        }

        public esQueryItem CreatedByUserID
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.CreatedByUserID, esSystemType.String); }
        }

        public esQueryItem QtyR
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.QtyR, esSystemType.Int16); }
        }

        public esQueryItem ApprovedByUserID
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.ApprovedByUserID, esSystemType.String); }
        }

        public esQueryItem IsPrinted
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.IsPrinted, esSystemType.Boolean); }
        }

        public esQueryItem FloorSeqNo
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.FloorSeqNo, esSystemType.Int32); }
        }

        public esQueryItem Rtype
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.Rtype, esSystemType.String); }
        }

        public esQueryItem FromServiceUnitID
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.FromServiceUnitID, esSystemType.String); }
        }

        public esQueryItem FromRoomID
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.FromRoomID, esSystemType.String); }
        }

        public esQueryItem FromBedID
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.FromBedID, esSystemType.String); }
        }

        public esQueryItem LocationID
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.LocationID, esSystemType.String); }
        }

        public esQueryItem CompleteDateTime
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.CompleteDateTime, esSystemType.DateTime); }
        }

        public esQueryItem VoidReason
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.VoidReason, esSystemType.String); }
        }

        public esQueryItem ExecutionDate
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.ExecutionDate, esSystemType.DateTime); }
        }

        public esQueryItem IsPos
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.IsPos, esSystemType.Boolean); }
        }

        public esQueryItem IsForTakeItHome
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.IsForTakeItHome, esSystemType.Boolean); }
        }

        public esQueryItem PatientEducationSeqNo
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.PatientEducationSeqNo, esSystemType.Int32); }
        }

        public esQueryItem ReviewByUserID
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.ReviewByUserID, esSystemType.String); }
        }

        public esQueryItem IsUnapproved
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.IsUnapproved, esSystemType.Boolean); }
        }

        public esQueryItem UnapprovedDateTime
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.UnapprovedDateTime, esSystemType.DateTime); }
        }

        public esQueryItem UnapprovedByUserID
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.UnapprovedByUserID, esSystemType.String); }
        }

        public esQueryItem SRKioskQueueType
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.SRKioskQueueType, esSystemType.String); }
        }

        public esQueryItem KioskQueueNo
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.KioskQueueNo, esSystemType.String); }
        }

        public esQueryItem IsVerified
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.IsVerified, esSystemType.Boolean); }
        }

        public esQueryItem VerifiedByUserID
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.VerifiedByUserID, esSystemType.String); }
        }

        public esQueryItem VerifiedDateTime
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.VerifiedDateTime, esSystemType.DateTime); }
        }

        public esQueryItem SRPrescriptionCategory
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.SRPrescriptionCategory, esSystemType.String); }
        }

        public esQueryItem RasproSeqNo
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.RasproSeqNo, esSystemType.Int32); }
        }

        public esQueryItem IsReviewed
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.IsReviewed, esSystemType.Boolean); }
        }

        public esQueryItem ReviewedByUserID
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.ReviewedByUserID, esSystemType.String); }
        }

        public esQueryItem ReviewedDateTime
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.ReviewedDateTime, esSystemType.DateTime); }
        }

        public esQueryItem Is23Days
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.Is23Days, esSystemType.Boolean); }
        }

        public esQueryItem IsSplitBill
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.IsSplitBill, esSystemType.Boolean); }
        }

        public esQueryItem IsCash
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.IsCash, esSystemType.Boolean); }
        }

        public esQueryItem DeliverByUserID
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.DeliverByUserID, esSystemType.String); }
        }

        public esQueryItem CompleteByUserID
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.CompleteByUserID, esSystemType.String); }
        }

        public esQueryItem InProgressByUserID
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.InProgressByUserID, esSystemType.String); }
        }

        public esQueryItem InProgressDateTime
        {
            get { return new esQueryItem(this, TransPrescriptionMetadata.ColumnNames.InProgressDateTime, esSystemType.DateTime); }
        }

        #endregion

    }



    [Serializable]
    public partial class TransPrescriptionMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected TransPrescriptionMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.PrescriptionNo, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PrescriptionNo;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 20;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PrescriptionDate, 1, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.PrescriptionDate;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RegistrationNo, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RegistrationNo;
            c.CharacterMaxLength = 20;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ServiceUnitID, 3, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ServiceUnitID;
            c.CharacterMaxLength = 10;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ClassID, 4, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ClassID;
            c.CharacterMaxLength = 10;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParamedicID, 5, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParamedicID;
            c.CharacterMaxLength = 10;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsApproval, 6, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsApproval;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsVoid, 7, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsVoid;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Note, 8, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Note;
            c.CharacterMaxLength = 5000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 9, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 10, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 40;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsPrescriptionReturn, 11, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsPrescriptionReturn;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ReferenceNo, 12, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ReferenceNo;
            c.CharacterMaxLength = 20;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsFromSOAP, 13, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsFromSOAP;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsBillProceed, 14, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsBillProceed;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsUnitDosePrescription, 15, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsUnitDosePrescription;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsCito, 16, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsCito;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsClosed, 17, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsClosed;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ApprovalDateTime, 18, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.ApprovalDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DeliverDateTime, 19, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.DeliverDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TextPrescription, 20, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TextPrescription;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsDirect, 21, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsDirect;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsPaid, 22, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsPaid;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.OrderNo, 23, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.OrderNo;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsProceedByPharmacist, 24, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsProceedByPharmacist;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FullAddress, 25, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.FullAddress;
            c.CharacterMaxLength = 200;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.NoTelp, 26, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.NoTelp;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AdditionalNote, 27, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.AdditionalNote;
            c.CharacterMaxLength = 800;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRFloor, 28, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRFloor;
            c.CharacterMaxLength = 30;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreatedDateTime, 29, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.CreatedDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreatedByUserID, 30, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.CreatedByUserID;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.QtyR, 31, typeof(short), esSystemType.Int16);
            c.PropertyName = PropertyNames.QtyR;
            c.NumericPrecision = 5;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ApprovedByUserID, 32, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ApprovedByUserID;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsPrinted, 33, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsPrinted;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FloorSeqNo, 34, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.FloorSeqNo;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Rtype, 35, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Rtype;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FromServiceUnitID, 36, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.FromServiceUnitID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FromRoomID, 37, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.FromRoomID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FromBedID, 38, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.FromBedID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LocationID, 39, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LocationID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CompleteDateTime, 40, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.CompleteDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.VoidReason, 41, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.VoidReason;
            c.CharacterMaxLength = 500;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ExecutionDate, 42, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.ExecutionDate;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsPos, 43, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsPos;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsForTakeItHome, 44, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsForTakeItHome;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PatientEducationSeqNo, 45, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.PatientEducationSeqNo;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ReviewByUserID, 46, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ReviewByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsUnapproved, 47, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsUnapproved;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.UnapprovedDateTime, 48, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.UnapprovedDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.UnapprovedByUserID, 49, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.UnapprovedByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRKioskQueueType, 50, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRKioskQueueType;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.KioskQueueNo, 51, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.KioskQueueNo;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsVerified, 52, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsVerified;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.VerifiedByUserID, 53, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.VerifiedByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.VerifiedDateTime, 54, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.VerifiedDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRPrescriptionCategory, 55, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRPrescriptionCategory;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RasproSeqNo, 56, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.RasproSeqNo;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsReviewed, 57, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsReviewed;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ReviewedByUserID, 58, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ReviewedByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ReviewedDateTime, 59, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.ReviewedDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Is23Days, 60, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.Is23Days;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsSplitBill, 61, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsSplitBill;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsCash, 62, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsCash;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DeliverByUserID, 63, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DeliverByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CompleteByUserID, 64, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.CompleteByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.InProgressByUserID, 65, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.InProgressByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.InProgressDateTime, 66, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.InProgressDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public TransPrescriptionMetadata Meta()
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
            public const string PrescriptionDate = "PrescriptionDate";
            public const string RegistrationNo = "RegistrationNo";
            public const string ServiceUnitID = "ServiceUnitID";
            public const string ClassID = "ClassID";
            public const string ParamedicID = "ParamedicID";
            public const string IsApproval = "IsApproval";
            public const string IsVoid = "IsVoid";
            public const string Note = "Note";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string IsPrescriptionReturn = "IsPrescriptionReturn";
            public const string ReferenceNo = "ReferenceNo";
            public const string IsFromSOAP = "IsFromSOAP";
            public const string IsBillProceed = "IsBillProceed";
            public const string IsUnitDosePrescription = "IsUnitDosePrescription";
            public const string IsCito = "IsCito";
            public const string IsClosed = "IsClosed";
            public const string ApprovalDateTime = "ApprovalDateTime";
            public const string DeliverDateTime = "DeliverDateTime";
            public const string TextPrescription = "TextPrescription";
            public const string IsDirect = "IsDirect";
            public const string IsPaid = "IsPaid";
            public const string OrderNo = "OrderNo";
            public const string IsProceedByPharmacist = "IsProceedByPharmacist";
            public const string FullAddress = "FullAddress";
            public const string NoTelp = "NoTelp";
            public const string AdditionalNote = "AdditionalNote";
            public const string SRFloor = "SRFloor";
            public const string CreatedDateTime = "CreatedDateTime";
            public const string CreatedByUserID = "CreatedByUserID";
            public const string QtyR = "QtyR";
            public const string ApprovedByUserID = "ApprovedByUserID";
            public const string IsPrinted = "IsPrinted";
            public const string FloorSeqNo = "FloorSeqNo";
            public const string Rtype = "Rtype";
            public const string FromServiceUnitID = "FromServiceUnitID";
            public const string FromRoomID = "FromRoomID";
            public const string FromBedID = "FromBedID";
            public const string LocationID = "LocationID";
            public const string CompleteDateTime = "CompleteDateTime";
            public const string VoidReason = "VoidReason";
            public const string ExecutionDate = "ExecutionDate";
            public const string IsPos = "IsPos";
            public const string IsForTakeItHome = "IsForTakeItHome";
            public const string PatientEducationSeqNo = "PatientEducationSeqNo";
            public const string ReviewByUserID = "ReviewByUserID";
            public const string IsUnapproved = "IsUnapproved";
            public const string UnapprovedDateTime = "UnapprovedDateTime";
            public const string UnapprovedByUserID = "UnapprovedByUserID";
            public const string SRKioskQueueType = "SRKioskQueueType";
            public const string KioskQueueNo = "KioskQueueNo";
            public const string IsVerified = "IsVerified";
            public const string VerifiedByUserID = "VerifiedByUserID";
            public const string VerifiedDateTime = "VerifiedDateTime";
            public const string SRPrescriptionCategory = "SRPrescriptionCategory";
            public const string RasproSeqNo = "RasproSeqNo";
            public const string IsReviewed = "IsReviewed";
            public const string ReviewedByUserID = "ReviewedByUserID";
            public const string ReviewedDateTime = "ReviewedDateTime";
            public const string Is23Days = "Is23Days";
            public const string IsSplitBill = "IsSplitBill";
            public const string IsCash = "IsCash";
            public const string DeliverByUserID = "DeliverByUserID";
            public const string CompleteByUserID = "CompleteByUserID";
            public const string InProgressByUserID = "InProgressByUserID";
            public const string InProgressDateTime = "InProgressDateTime";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string PrescriptionNo = "PrescriptionNo";
            public const string PrescriptionDate = "PrescriptionDate";
            public const string RegistrationNo = "RegistrationNo";
            public const string ServiceUnitID = "ServiceUnitID";
            public const string ClassID = "ClassID";
            public const string ParamedicID = "ParamedicID";
            public const string IsApproval = "IsApproval";
            public const string IsVoid = "IsVoid";
            public const string Note = "Note";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string IsPrescriptionReturn = "IsPrescriptionReturn";
            public const string ReferenceNo = "ReferenceNo";
            public const string IsFromSOAP = "IsFromSOAP";
            public const string IsBillProceed = "IsBillProceed";
            public const string IsUnitDosePrescription = "IsUnitDosePrescription";
            public const string IsCito = "IsCito";
            public const string IsClosed = "IsClosed";
            public const string ApprovalDateTime = "ApprovalDateTime";
            public const string DeliverDateTime = "DeliverDateTime";
            public const string TextPrescription = "TextPrescription";
            public const string IsDirect = "IsDirect";
            public const string IsPaid = "IsPaid";
            public const string OrderNo = "OrderNo";
            public const string IsProceedByPharmacist = "IsProceedByPharmacist";
            public const string FullAddress = "FullAddress";
            public const string NoTelp = "NoTelp";
            public const string AdditionalNote = "AdditionalNote";
            public const string SRFloor = "SRFloor";
            public const string CreatedDateTime = "CreatedDateTime";
            public const string CreatedByUserID = "CreatedByUserID";
            public const string QtyR = "QtyR";
            public const string ApprovedByUserID = "ApprovedByUserID";
            public const string IsPrinted = "IsPrinted";
            public const string FloorSeqNo = "FloorSeqNo";
            public const string Rtype = "Rtype";
            public const string FromServiceUnitID = "FromServiceUnitID";
            public const string FromRoomID = "FromRoomID";
            public const string FromBedID = "FromBedID";
            public const string LocationID = "LocationID";
            public const string CompleteDateTime = "CompleteDateTime";
            public const string VoidReason = "VoidReason";
            public const string ExecutionDate = "ExecutionDate";
            public const string IsPos = "IsPos";
            public const string IsForTakeItHome = "IsForTakeItHome";
            public const string PatientEducationSeqNo = "PatientEducationSeqNo";
            public const string ReviewByUserID = "ReviewByUserID";
            public const string IsUnapproved = "IsUnapproved";
            public const string UnapprovedDateTime = "UnapprovedDateTime";
            public const string UnapprovedByUserID = "UnapprovedByUserID";
            public const string SRKioskQueueType = "SRKioskQueueType";
            public const string KioskQueueNo = "KioskQueueNo";
            public const string IsVerified = "IsVerified";
            public const string VerifiedByUserID = "VerifiedByUserID";
            public const string VerifiedDateTime = "VerifiedDateTime";
            public const string SRPrescriptionCategory = "SRPrescriptionCategory";
            public const string RasproSeqNo = "RasproSeqNo";
            public const string IsReviewed = "IsReviewed";
            public const string ReviewedByUserID = "ReviewedByUserID";
            public const string ReviewedDateTime = "ReviewedDateTime";
            public const string Is23Days = "Is23Days";
            public const string IsSplitBill = "IsSplitBill";
            public const string IsCash = "IsCash";
            public const string DeliverByUserID = "DeliverByUserID";
            public const string CompleteByUserID = "CompleteByUserID";
            public const string InProgressByUserID = "InProgressByUserID";
            public const string InProgressDateTime = "InProgressDateTime";
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
            lock (typeof(TransPrescriptionMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new TransPrescriptionMetadata();
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
                meta.AddTypeMap("PrescriptionDate", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("RegistrationNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ServiceUnitID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ClassID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ParamedicID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsApproval", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsVoid", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("Note", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsPrescriptionReturn", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ReferenceNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsFromSOAP", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsBillProceed", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsUnitDosePrescription", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsCito", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsClosed", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ApprovalDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("DeliverDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("TextPrescription", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsDirect", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsPaid", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("OrderNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsProceedByPharmacist", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("FullAddress", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("NoTelp", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("AdditionalNote", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRFloor", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CreatedDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("CreatedByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("QtyR", new esTypeMap("smallint", "System.Int16"));
                meta.AddTypeMap("ApprovedByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsPrinted", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("FloorSeqNo", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("Rtype", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("FromServiceUnitID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("FromRoomID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("FromBedID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LocationID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CompleteDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("VoidReason", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ExecutionDate", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("IsPos", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsForTakeItHome", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("PatientEducationSeqNo", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("ReviewByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsUnapproved", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("UnapprovedDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("UnapprovedByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRKioskQueueType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("KioskQueueNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsVerified", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("VerifiedByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("VerifiedDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("SRPrescriptionCategory", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("RasproSeqNo", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("IsReviewed", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ReviewedByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ReviewedDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("Is23Days", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsSplitBill", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsCash", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("DeliverByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CompleteByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("InProgressByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("InProgressDateTime", new esTypeMap("datetime", "System.DateTime"));



                meta.Source = "TransPrescription";
                meta.Destination = "TransPrescription";

                meta.spInsert = "proc_TransPrescriptionInsert";
                meta.spUpdate = "proc_TransPrescriptionUpdate";
                meta.spDelete = "proc_TransPrescriptionDelete";
                meta.spLoadAll = "proc_TransPrescriptionLoadAll";
                meta.spLoadByPrimaryKey = "proc_TransPrescriptionLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private TransPrescriptionMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
