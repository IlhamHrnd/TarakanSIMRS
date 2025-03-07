
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 9/18/2024 5:28:58 PM
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
    /// Encapsulates the 'Registration' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(Registration))]
    [XmlType("Registration")]
    public partial class Registration : esRegistration
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new Registration();
        }

        #region Static Quick Access Methods
        static public void Delete(string registrationNo)
        {
            var obj = new Registration();
            obj.RegistrationNo = registrationNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string registrationNo, esSqlAccessType sqlAccessType)
        {
            var obj = new Registration();
            obj.RegistrationNo = registrationNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("RegistrationCollection")]
    public partial class RegistrationCollection : esRegistrationCollection, IEnumerable<Registration>
    {
        public Registration FindByPrimaryKey(string registrationNo)
        {
            return this.SingleOrDefault(e => e.RegistrationNo == registrationNo);
        }



    }



    [Serializable]
    public partial class RegistrationQuery : esRegistrationQuery
    {
        public RegistrationQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public RegistrationQuery(string joinAlias, out RegistrationQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "RegistrationQuery";
        }



        #region Explicit Casts

        public static explicit operator string(RegistrationQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator RegistrationQuery(string query)
        {
            return (RegistrationQuery)SerializeHelper.FromXml(query, typeof(RegistrationQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esRegistration : esEntity
    {
        public esRegistration()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string registrationNo)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(registrationNo);
            else
                return LoadByPrimaryKeyStoredProcedure(registrationNo);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string registrationNo)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(registrationNo);
            else
                return LoadByPrimaryKeyStoredProcedure(registrationNo);
        }

        private bool LoadByPrimaryKeyDynamic(string registrationNo)
        {
            RegistrationQuery query = new RegistrationQuery("rQ");
            query.Where(query.RegistrationNo == registrationNo);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string registrationNo)
        {
            esParameters parms = new esParameters();
            parms.Add("RegistrationNo", registrationNo);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to Registration.RegistrationNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RegistrationNo
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.RegistrationNo);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.RegistrationNo, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.RegistrationNo);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.SRRegistrationType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRRegistrationType
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.SRRegistrationType);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.SRRegistrationType, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.SRRegistrationType);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.ParamedicID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParamedicID
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.ParamedicID);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.ParamedicID, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.ParamedicID);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.GuarantorID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string GuarantorID
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.GuarantorID);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.GuarantorID, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.GuarantorID);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.PatientID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PatientID
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.PatientID);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.PatientID, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.PatientID);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.ClassID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ClassID
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.ClassID);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.ClassID, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.ClassID);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.RegistrationDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? RegistrationDate
        {
            get
            {
                return GetSystemDateTime(RegistrationMetadata.ColumnNames.RegistrationDate);
            }

            set
            {
                if (SetSystemDateTime(RegistrationMetadata.ColumnNames.RegistrationDate, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.RegistrationDate);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.RegistrationTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RegistrationTime
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.RegistrationTime);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.RegistrationTime, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.RegistrationTime);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.AppointmentNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string AppointmentNo
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.AppointmentNo);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.AppointmentNo, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.AppointmentNo);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.AgeInYear
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public byte? AgeInYear
        {
            get
            {
                return GetSystemByte(RegistrationMetadata.ColumnNames.AgeInYear);
            }

            set
            {
                if (SetSystemByte(RegistrationMetadata.ColumnNames.AgeInYear, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.AgeInYear);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.AgeInMonth
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public byte? AgeInMonth
        {
            get
            {
                return GetSystemByte(RegistrationMetadata.ColumnNames.AgeInMonth);
            }

            set
            {
                if (SetSystemByte(RegistrationMetadata.ColumnNames.AgeInMonth, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.AgeInMonth);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.AgeInDay
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public byte? AgeInDay
        {
            get
            {
                return GetSystemByte(RegistrationMetadata.ColumnNames.AgeInDay);
            }

            set
            {
                if (SetSystemByte(RegistrationMetadata.ColumnNames.AgeInDay, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.AgeInDay);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.SRShift
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRShift
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.SRShift);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.SRShift, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.SRShift);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.SRPatientInType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRPatientInType
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.SRPatientInType);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.SRPatientInType, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.SRPatientInType);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.InsuranceID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string InsuranceID
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.InsuranceID);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.InsuranceID, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.InsuranceID);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.SRPatientCategory
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRPatientCategory
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.SRPatientCategory);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.SRPatientCategory, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.SRPatientCategory);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.SRERCaseType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRERCaseType
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.SRERCaseType);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.SRERCaseType, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.SRERCaseType);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.SRVisitReason
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRVisitReason
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.SRVisitReason);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.SRVisitReason, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.SRVisitReason);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.SRBussinesMethod
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRBussinesMethod
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.SRBussinesMethod);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.SRBussinesMethod, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.SRBussinesMethod);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.PlavonAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? PlavonAmount
        {
            get
            {
                return GetSystemDecimal(RegistrationMetadata.ColumnNames.PlavonAmount);
            }

            set
            {
                if (SetSystemDecimal(RegistrationMetadata.ColumnNames.PlavonAmount, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.PlavonAmount);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.DepartmentID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DepartmentID
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.DepartmentID);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.DepartmentID, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.DepartmentID);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.ServiceUnitID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ServiceUnitID
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.ServiceUnitID);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.ServiceUnitID, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.ServiceUnitID);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.RoomID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RoomID
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.RoomID);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.RoomID, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.RoomID);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.BedID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string BedID
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.BedID);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.BedID, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.BedID);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.ChargeClassID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ChargeClassID
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.ChargeClassID);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.ChargeClassID, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.ChargeClassID);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.CoverageClassID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string CoverageClassID
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.CoverageClassID);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.CoverageClassID, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.CoverageClassID);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.VisitTypeID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string VisitTypeID
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.VisitTypeID);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.VisitTypeID, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.VisitTypeID);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.ReferralID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ReferralID
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.ReferralID);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.ReferralID, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.ReferralID);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.Anamnesis
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Anamnesis
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.Anamnesis);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.Anamnesis, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.Anamnesis);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.Complaint
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Complaint
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.Complaint);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.Complaint, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.Complaint);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.InitialDiagnose
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string InitialDiagnose
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.InitialDiagnose);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.InitialDiagnose, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.InitialDiagnose);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.MedicationPlanning
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string MedicationPlanning
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.MedicationPlanning);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.MedicationPlanning, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.MedicationPlanning);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.SRTriage
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRTriage
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.SRTriage);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.SRTriage, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.SRTriage);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsPrintingPatientCard
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsPrintingPatientCard
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsPrintingPatientCard);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsPrintingPatientCard, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsPrintingPatientCard);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.DischargeDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? DischargeDate
        {
            get
            {
                return GetSystemDateTime(RegistrationMetadata.ColumnNames.DischargeDate);
            }

            set
            {
                if (SetSystemDateTime(RegistrationMetadata.ColumnNames.DischargeDate, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.DischargeDate);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.DischargeTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DischargeTime
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.DischargeTime);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.DischargeTime, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.DischargeTime);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.DischargeMedicalNotes
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DischargeMedicalNotes
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.DischargeMedicalNotes);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.DischargeMedicalNotes, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.DischargeMedicalNotes);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.DischargeNotes
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DischargeNotes
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.DischargeNotes);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.DischargeNotes, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.DischargeNotes);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.SRDischargeCondition
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRDischargeCondition
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.SRDischargeCondition);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.SRDischargeCondition, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.SRDischargeCondition);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.SRDischargeMethod
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRDischargeMethod
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.SRDischargeMethod);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.SRDischargeMethod, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.SRDischargeMethod);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.LOSInYear
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public byte? LOSInYear
        {
            get
            {
                return GetSystemByte(RegistrationMetadata.ColumnNames.LOSInYear);
            }

            set
            {
                if (SetSystemByte(RegistrationMetadata.ColumnNames.LOSInYear, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.LOSInYear);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.LOSInMonth
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public byte? LOSInMonth
        {
            get
            {
                return GetSystemByte(RegistrationMetadata.ColumnNames.LOSInMonth);
            }

            set
            {
                if (SetSystemByte(RegistrationMetadata.ColumnNames.LOSInMonth, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.LOSInMonth);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.LOSInDay
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public byte? LOSInDay
        {
            get
            {
                return GetSystemByte(RegistrationMetadata.ColumnNames.LOSInDay);
            }

            set
            {
                if (SetSystemByte(RegistrationMetadata.ColumnNames.LOSInDay, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.LOSInDay);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.DischargeOperatorID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DischargeOperatorID
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.DischargeOperatorID);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.DischargeOperatorID, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.DischargeOperatorID);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.AccountNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string AccountNo
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.AccountNo);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.AccountNo, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.AccountNo);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.TransactionAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? TransactionAmount
        {
            get
            {
                return GetSystemDecimal(RegistrationMetadata.ColumnNames.TransactionAmount);
            }

            set
            {
                if (SetSystemDecimal(RegistrationMetadata.ColumnNames.TransactionAmount, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.TransactionAmount);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.AdministrationAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? AdministrationAmount
        {
            get
            {
                return GetSystemDecimal(RegistrationMetadata.ColumnNames.AdministrationAmount);
            }

            set
            {
                if (SetSystemDecimal(RegistrationMetadata.ColumnNames.AdministrationAmount, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.AdministrationAmount);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.RoundingAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? RoundingAmount
        {
            get
            {
                return GetSystemDecimal(RegistrationMetadata.ColumnNames.RoundingAmount);
            }

            set
            {
                if (SetSystemDecimal(RegistrationMetadata.ColumnNames.RoundingAmount, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.RoundingAmount);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.RemainingAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? RemainingAmount
        {
            get
            {
                return GetSystemDecimal(RegistrationMetadata.ColumnNames.RemainingAmount);
            }

            set
            {
                if (SetSystemDecimal(RegistrationMetadata.ColumnNames.RemainingAmount, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.RemainingAmount);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsTransferedToInpatient
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsTransferedToInpatient
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsTransferedToInpatient);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsTransferedToInpatient, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsTransferedToInpatient);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsNewPatient
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsNewPatient
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsNewPatient);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsNewPatient, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsNewPatient);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsNewBornInfant
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsNewBornInfant
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsNewBornInfant);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsNewBornInfant, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsNewBornInfant);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsParturition
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsParturition
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsParturition);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsParturition, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsParturition);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsHoldTransactionEntry
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsHoldTransactionEntry
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsHoldTransactionEntry);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsHoldTransactionEntry, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsHoldTransactionEntry);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsHasCorrection
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsHasCorrection
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsHasCorrection);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsHasCorrection, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsHasCorrection);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsEMRValid
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsEMRValid
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsEMRValid);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsEMRValid, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsEMRValid);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsBackDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsBackDate
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsBackDate);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsBackDate, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsBackDate);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.ActualVisitDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? ActualVisitDate
        {
            get
            {
                return GetSystemDateTime(RegistrationMetadata.ColumnNames.ActualVisitDate);
            }

            set
            {
                if (SetSystemDateTime(RegistrationMetadata.ColumnNames.ActualVisitDate, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.ActualVisitDate);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsVoid
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsVoid
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsVoid);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsVoid, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsVoid);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.SRVoidReason
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRVoidReason
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.SRVoidReason);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.SRVoidReason, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.SRVoidReason);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.VoidNotes
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string VoidNotes
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.VoidNotes);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.VoidNotes, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.VoidNotes);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.VoidDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? VoidDate
        {
            get
            {
                return GetSystemDateTime(RegistrationMetadata.ColumnNames.VoidDate);
            }

            set
            {
                if (SetSystemDateTime(RegistrationMetadata.ColumnNames.VoidDate, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.VoidDate);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.VoidByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string VoidByUserID
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.VoidByUserID);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.VoidByUserID, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.VoidByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsClosed
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsClosed
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsClosed);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsClosed, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsClosed);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsEpisodeComplete
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsEpisodeComplete
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsEpisodeComplete);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsEpisodeComplete, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsEpisodeComplete);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsClusterAssessment
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsClusterAssessment
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsClusterAssessment);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsClusterAssessment, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsClusterAssessment);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsConsul
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsConsul
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsConsul);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsConsul, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsConsul);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsFromDispensary
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsFromDispensary
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsFromDispensary);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsFromDispensary, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsFromDispensary);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsNewVisit
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsNewVisit
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsNewVisit);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsNewVisit, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsNewVisit);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.Notes
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Notes
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.Notes);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.Notes, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.Notes);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.LastCreateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastCreateDateTime
        {
            get
            {
                return GetSystemDateTime(RegistrationMetadata.ColumnNames.LastCreateDateTime);
            }

            set
            {
                if (SetSystemDateTime(RegistrationMetadata.ColumnNames.LastCreateDateTime, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.LastCreateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.LastCreateUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastCreateUserID
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.LastCreateUserID);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.LastCreateUserID, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.LastCreateUserID);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(RegistrationMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(RegistrationMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.isDirectPrescriptionReturn
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsDirectPrescriptionReturn
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsDirectPrescriptionReturn);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsDirectPrescriptionReturn, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsDirectPrescriptionReturn);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.RegistrationQue
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? RegistrationQue
        {
            get
            {
                return GetSystemInt32(RegistrationMetadata.ColumnNames.RegistrationQue);
            }

            set
            {
                if (SetSystemInt32(RegistrationMetadata.ColumnNames.RegistrationQue, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.RegistrationQue);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.VisiteRegistrationNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string VisiteRegistrationNo
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.VisiteRegistrationNo);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.VisiteRegistrationNo, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.VisiteRegistrationNo);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsGenerateHL7
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsGenerateHL7
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsGenerateHL7);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsGenerateHL7, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsGenerateHL7);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.ReferralName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ReferralName
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.ReferralName);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.ReferralName, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.ReferralName);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsObservation
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsObservation
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsObservation);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsObservation, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsObservation);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.CauseOfAccident
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string CauseOfAccident
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.CauseOfAccident);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.CauseOfAccident, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.CauseOfAccident);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.ReferTo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ReferTo
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.ReferTo);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.ReferTo, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.ReferTo);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsOldCase
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsOldCase
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsOldCase);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsOldCase, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsOldCase);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsDHF
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsDHF
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsDHF);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsDHF, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsDHF);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsEKG
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsEKG
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsEKG);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsEKG, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsEKG);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.EmrDiagnoseID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string EmrDiagnoseID
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.EmrDiagnoseID);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.EmrDiagnoseID, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.EmrDiagnoseID);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsGlobalPlafond
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsGlobalPlafond
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsGlobalPlafond);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsGlobalPlafond, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsGlobalPlafond);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.FirstResponDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? FirstResponDate
        {
            get
            {
                return GetSystemDateTime(RegistrationMetadata.ColumnNames.FirstResponDate);
            }

            set
            {
                if (SetSystemDateTime(RegistrationMetadata.ColumnNames.FirstResponDate, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.FirstResponDate);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.FirstResponTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string FirstResponTime
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.FirstResponTime);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.FirstResponTime, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.FirstResponTime);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.PhysicianResponDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? PhysicianResponDate
        {
            get
            {
                return GetSystemDateTime(RegistrationMetadata.ColumnNames.PhysicianResponDate);
            }

            set
            {
                if (SetSystemDateTime(RegistrationMetadata.ColumnNames.PhysicianResponDate, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.PhysicianResponDate);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.PhysicianResponTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PhysicianResponTime
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.PhysicianResponTime);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.PhysicianResponTime, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.PhysicianResponTime);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsRoomIn
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsRoomIn
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsRoomIn);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsRoomIn, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsRoomIn);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsLockVerifiedBilling
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsLockVerifiedBilling
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsLockVerifiedBilling);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsLockVerifiedBilling, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsLockVerifiedBilling);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.LockVerifiedBillingDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LockVerifiedBillingDateTime
        {
            get
            {
                return GetSystemDateTime(RegistrationMetadata.ColumnNames.LockVerifiedBillingDateTime);
            }

            set
            {
                if (SetSystemDateTime(RegistrationMetadata.ColumnNames.LockVerifiedBillingDateTime, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.LockVerifiedBillingDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.LockVerifiedBillingByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LockVerifiedBillingByUserID
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.LockVerifiedBillingByUserID);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.LockVerifiedBillingByUserID, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.LockVerifiedBillingByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.ProcedureChargeClassID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ProcedureChargeClassID
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.ProcedureChargeClassID);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.ProcedureChargeClassID, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.ProcedureChargeClassID);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.PersonID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? PersonID
        {
            get
            {
                return GetSystemInt32(RegistrationMetadata.ColumnNames.PersonID);
            }

            set
            {
                if (SetSystemInt32(RegistrationMetadata.ColumnNames.PersonID, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.PersonID);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.EmployeeNumber
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string EmployeeNumber
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.EmployeeNumber);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.EmployeeNumber, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.EmployeeNumber);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.SREmployeeRelationship
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SREmployeeRelationship
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.SREmployeeRelationship);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.SREmployeeRelationship, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.SREmployeeRelationship);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.GuarantorCardNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string GuarantorCardNo
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.GuarantorCardNo);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.GuarantorCardNo, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.GuarantorCardNo);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.DischargePlanDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? DischargePlanDate
        {
            get
            {
                return GetSystemDateTime(RegistrationMetadata.ColumnNames.DischargePlanDate);
            }

            set
            {
                if (SetSystemDateTime(RegistrationMetadata.ColumnNames.DischargePlanDate, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.DischargePlanDate);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.UsertInsertDischargePlan
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string UsertInsertDischargePlan
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.UsertInsertDischargePlan);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.UsertInsertDischargePlan, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.UsertInsertDischargePlan);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsNonPatient
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsNonPatient
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsNonPatient);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsNonPatient, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsNonPatient);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.ReasonsForTreatmentID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ReasonsForTreatmentID
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.ReasonsForTreatmentID);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.ReasonsForTreatmentID, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.ReasonsForTreatmentID);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.SmfID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SmfID
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.SmfID);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.SmfID, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.SmfID);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.PatientAdm
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? PatientAdm
        {
            get
            {
                return GetSystemDecimal(RegistrationMetadata.ColumnNames.PatientAdm);
            }

            set
            {
                if (SetSystemDecimal(RegistrationMetadata.ColumnNames.PatientAdm, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.PatientAdm);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.GuarantorAdm
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? GuarantorAdm
        {
            get
            {
                return GetSystemDecimal(RegistrationMetadata.ColumnNames.GuarantorAdm);
            }

            set
            {
                if (SetSystemDecimal(RegistrationMetadata.ColumnNames.GuarantorAdm, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.GuarantorAdm);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.ReasonsForTreatmentDescID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ReasonsForTreatmentDescID
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.ReasonsForTreatmentDescID);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.ReasonsForTreatmentDescID, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.ReasonsForTreatmentDescID);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.SRReferralGroup
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRReferralGroup
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.SRReferralGroup);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.SRReferralGroup, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.SRReferralGroup);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.SRDiscountReason
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRDiscountReason
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.SRDiscountReason);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.SRDiscountReason, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.SRDiscountReason);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.PhysicianSenders
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PhysicianSenders
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.PhysicianSenders);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.PhysicianSenders, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.PhysicianSenders);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.DiscAdmPatient
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? DiscAdmPatient
        {
            get
            {
                return GetSystemDecimal(RegistrationMetadata.ColumnNames.DiscAdmPatient);
            }

            set
            {
                if (SetSystemDecimal(RegistrationMetadata.ColumnNames.DiscAdmPatient, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.DiscAdmPatient);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.DiscAdmGuarantor
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? DiscAdmGuarantor
        {
            get
            {
                return GetSystemDecimal(RegistrationMetadata.ColumnNames.DiscAdmGuarantor);
            }

            set
            {
                if (SetSystemDecimal(RegistrationMetadata.ColumnNames.DiscAdmGuarantor, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.DiscAdmGuarantor);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.SRPatientInCondition
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRPatientInCondition
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.SRPatientInCondition);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.SRPatientInCondition, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.SRPatientInCondition);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.SRKiaCaseType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRKiaCaseType
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.SRKiaCaseType);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.SRKiaCaseType, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.SRKiaCaseType);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.SRObstetricType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRObstetricType
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.SRObstetricType);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.SRObstetricType, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.SRObstetricType);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsHoldTransactionEntryByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string IsHoldTransactionEntryByUserID
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.IsHoldTransactionEntryByUserID);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.IsHoldTransactionEntryByUserID, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsHoldTransactionEntryByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.FromRegistrationNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string FromRegistrationNo
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.FromRegistrationNo);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.FromRegistrationNo, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.FromRegistrationNo);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsConfirmedAttendance
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsConfirmedAttendance
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsConfirmedAttendance);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsConfirmedAttendance, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsConfirmedAttendance);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.ConfirmedAttendanceByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ConfirmedAttendanceByUserID
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.ConfirmedAttendanceByUserID);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.ConfirmedAttendanceByUserID, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.ConfirmedAttendanceByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.ConfirmedAttendanceDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? ConfirmedAttendanceDateTime
        {
            get
            {
                return GetSystemDateTime(RegistrationMetadata.ColumnNames.ConfirmedAttendanceDateTime);
            }

            set
            {
                if (SetSystemDateTime(RegistrationMetadata.ColumnNames.ConfirmedAttendanceDateTime, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.ConfirmedAttendanceDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.BpjsSepNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string BpjsSepNo
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.BpjsSepNo);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.BpjsSepNo, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.BpjsSepNo);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.PlavonAmount2
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? PlavonAmount2
        {
            get
            {
                return GetSystemDecimal(RegistrationMetadata.ColumnNames.PlavonAmount2);
            }

            set
            {
                if (SetSystemDecimal(RegistrationMetadata.ColumnNames.PlavonAmount2, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.PlavonAmount2);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.DeathCertificateNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DeathCertificateNo
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.DeathCertificateNo);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.DeathCertificateNo, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.DeathCertificateNo);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.BpjsCoverageFormula
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? BpjsCoverageFormula
        {
            get
            {
                return GetSystemDecimal(RegistrationMetadata.ColumnNames.BpjsCoverageFormula);
            }

            set
            {
                if (SetSystemDecimal(RegistrationMetadata.ColumnNames.BpjsCoverageFormula, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.BpjsCoverageFormula);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.BpjsPackageID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string BpjsPackageID
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.BpjsPackageID);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.BpjsPackageID, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.BpjsPackageID);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.ApproximatePlafondAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? ApproximatePlafondAmount
        {
            get
            {
                return GetSystemDecimal(RegistrationMetadata.ColumnNames.ApproximatePlafondAmount);
            }

            set
            {
                if (SetSystemDecimal(RegistrationMetadata.ColumnNames.ApproximatePlafondAmount, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.ApproximatePlafondAmount);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.SentToBillingDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? SentToBillingDateTime
        {
            get
            {
                return GetSystemDateTime(RegistrationMetadata.ColumnNames.SentToBillingDateTime);
            }

            set
            {
                if (SetSystemDateTime(RegistrationMetadata.ColumnNames.SentToBillingDateTime, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.SentToBillingDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.SentToBillingByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SentToBillingByUserID
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.SentToBillingByUserID);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.SentToBillingByUserID, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.SentToBillingByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsAdjusted
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsAdjusted
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsAdjusted);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsAdjusted, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsAdjusted);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.AdjustLog
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string AdjustLog
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.AdjustLog);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.AdjustLog, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.AdjustLog);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsAllowPatientCheckOut
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsAllowPatientCheckOut
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsAllowPatientCheckOut);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsAllowPatientCheckOut, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsAllowPatientCheckOut);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.AllowPatientCheckOutDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? AllowPatientCheckOutDateTime
        {
            get
            {
                return GetSystemDateTime(RegistrationMetadata.ColumnNames.AllowPatientCheckOutDateTime);
            }

            set
            {
                if (SetSystemDateTime(RegistrationMetadata.ColumnNames.AllowPatientCheckOutDateTime, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.AllowPatientCheckOutDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.AllowPatientCheckOutByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string AllowPatientCheckOutByUserID
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.AllowPatientCheckOutByUserID);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.AllowPatientCheckOutByUserID, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.AllowPatientCheckOutByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.ReferByParamedicID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ReferByParamedicID
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.ReferByParamedicID);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.ReferByParamedicID, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.ReferByParamedicID);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.SRMaritalStatus
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRMaritalStatus
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.SRMaritalStatus);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.SRMaritalStatus, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.SRMaritalStatus);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.SROccupation
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SROccupation
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.SROccupation);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.SROccupation, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.SROccupation);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.SRRelationshipQuality
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRRelationshipQuality
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.SRRelationshipQuality);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.SRRelationshipQuality, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.SRRelationshipQuality);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.SRResidentialHome
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRResidentialHome
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.SRResidentialHome);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.SRResidentialHome, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.SRResidentialHome);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.SRFatherOccupation
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRFatherOccupation
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.SRFatherOccupation);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.SRFatherOccupation, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.SRFatherOccupation);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsPregnant
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsPregnant
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsPregnant);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsPregnant, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsPregnant);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.GestationalAge
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public short? GestationalAge
        {
            get
            {
                return GetSystemInt16(RegistrationMetadata.ColumnNames.GestationalAge);
            }

            set
            {
                if (SetSystemInt16(RegistrationMetadata.ColumnNames.GestationalAge, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.GestationalAge);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsBreastFeeding
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsBreastFeeding
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsBreastFeeding);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsBreastFeeding, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsBreastFeeding);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.AgeOfBabyInYear
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public short? AgeOfBabyInYear
        {
            get
            {
                return GetSystemInt16(RegistrationMetadata.ColumnNames.AgeOfBabyInYear);
            }

            set
            {
                if (SetSystemInt16(RegistrationMetadata.ColumnNames.AgeOfBabyInYear, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.AgeOfBabyInYear);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.AgeOfBabyInMonth
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public short? AgeOfBabyInMonth
        {
            get
            {
                return GetSystemInt16(RegistrationMetadata.ColumnNames.AgeOfBabyInMonth);
            }

            set
            {
                if (SetSystemInt16(RegistrationMetadata.ColumnNames.AgeOfBabyInMonth, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.AgeOfBabyInMonth);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.AgeOfBabyInDay
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public short? AgeOfBabyInDay
        {
            get
            {
                return GetSystemInt16(RegistrationMetadata.ColumnNames.AgeOfBabyInDay);
            }

            set
            {
                if (SetSystemInt16(RegistrationMetadata.ColumnNames.AgeOfBabyInDay, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.AgeOfBabyInDay);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsKidneyFunctionImpaired
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsKidneyFunctionImpaired
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsKidneyFunctionImpaired);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsKidneyFunctionImpaired, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsKidneyFunctionImpaired);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.CreatinineSerumValue
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public short? CreatinineSerumValue
        {
            get
            {
                return GetSystemInt16(RegistrationMetadata.ColumnNames.CreatinineSerumValue);
            }

            set
            {
                if (SetSystemInt16(RegistrationMetadata.ColumnNames.CreatinineSerumValue, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.CreatinineSerumValue);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.Hpi
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Hpi
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.Hpi);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.Hpi, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.Hpi);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.MembershipDetailID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public long? MembershipDetailID
        {
            get
            {
                return GetSystemInt64(RegistrationMetadata.ColumnNames.MembershipDetailID);
            }

            set
            {
                if (SetSystemInt64(RegistrationMetadata.ColumnNames.MembershipDetailID, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.MembershipDetailID);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.ExternalQueNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ExternalQueNo
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.ExternalQueNo);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.ExternalQueNo, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.ExternalQueNo);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.ReferralIdTo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ReferralIdTo
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.ReferralIdTo);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.ReferralIdTo, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.ReferralIdTo);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.ReferralNameTo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ReferralNameTo
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.ReferralNameTo);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.ReferralNameTo, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.ReferralNameTo);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsReconcile
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsReconcile
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsReconcile);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsReconcile, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsReconcile);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsSkipAutoBill
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsSkipAutoBill
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsSkipAutoBill);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsSkipAutoBill, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsSkipAutoBill);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.SRCrashSite
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRCrashSite
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.SRCrashSite);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.SRCrashSite, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.SRCrashSite);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.CrashSiteDetail
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string CrashSiteDetail
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.CrashSiteDetail);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.CrashSiteDetail, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.CrashSiteDetail);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.MembershipNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string MembershipNo
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.MembershipNo);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.MembershipNo, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.MembershipNo);
                }
            }
        }

        /// <summary>
        /// Status bisa entry MR jika registrasi sudah diclose
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsOpenEntryMR
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsOpenEntryMR);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsOpenEntryMR, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsOpenEntryMR);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.SRCovidStatus
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public byte? SRCovidStatus
        {
            get
            {
                return GetSystemByte(RegistrationMetadata.ColumnNames.SRCovidStatus);
            }

            set
            {
                if (SetSystemByte(RegistrationMetadata.ColumnNames.SRCovidStatus, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.SRCovidStatus);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.VoucherNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string VoucherNo
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.VoucherNo);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.VoucherNo, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.VoucherNo);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.SRCovidComorbidStatus
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRCovidComorbidStatus
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.SRCovidComorbidStatus);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.SRCovidComorbidStatus, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.SRCovidComorbidStatus);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsDisability
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsDisability
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsDisability);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsDisability, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsDisability);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsTracer
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsTracer
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsTracer);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsTracer, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsTracer);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.ItemConditionRuleID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ItemConditionRuleID
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.ItemConditionRuleID);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.ItemConditionRuleID, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.ItemConditionRuleID);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.SRPatientRiskStatus
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRPatientRiskStatus
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.SRPatientRiskStatus);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.SRPatientRiskStatus, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.SRPatientRiskStatus);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsFinishedAttendance
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsFinishedAttendance
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsFinishedAttendance);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsFinishedAttendance, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsFinishedAttendance);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.FinishedAttendanceByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string FinishedAttendanceByUserID
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.FinishedAttendanceByUserID);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.FinishedAttendanceByUserID, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.FinishedAttendanceByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.FinishedAttendanceDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? FinishedAttendanceDateTime
        {
            get
            {
                return GetSystemDateTime(RegistrationMetadata.ColumnNames.FinishedAttendanceDateTime);
            }

            set
            {
                if (SetSystemDateTime(RegistrationMetadata.ColumnNames.FinishedAttendanceDateTime, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.FinishedAttendanceDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsQueueCalled
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsQueueCalled
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsQueueCalled);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsQueueCalled, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsQueueCalled);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.IsQueueRecall
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsQueueRecall
        {
            get
            {
                return GetSystemBoolean(RegistrationMetadata.ColumnNames.IsQueueRecall);
            }

            set
            {
                if (SetSystemBoolean(RegistrationMetadata.ColumnNames.IsQueueRecall, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.IsQueueRecall);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.QueueCalledDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? QueueCalledDateTime
        {
            get
            {
                return GetSystemDateTime(RegistrationMetadata.ColumnNames.QueueCalledDateTime);
            }

            set
            {
                if (SetSystemDateTime(RegistrationMetadata.ColumnNames.QueueCalledDateTime, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.QueueCalledDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.SRQueRoom
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRQueRoom
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.SRQueRoom);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.SRQueRoom, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.SRQueRoom);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.SRClassification
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRClassification
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.SRClassification);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.SRClassification, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.SRClassification);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.SRClassificationRoom
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRClassificationRoom
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.SRClassificationRoom);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.SRClassificationRoom, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.SRClassificationRoom);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.QueueQr
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string QueueQr
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.QueueQr);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.QueueQr, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.QueueQr);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.SRPatientRiskColor
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRPatientRiskColor
        {
            get
            {
                return GetSystemString(RegistrationMetadata.ColumnNames.SRPatientRiskColor);
            }

            set
            {
                if (SetSystemString(RegistrationMetadata.ColumnNames.SRPatientRiskColor, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.SRPatientRiskColor);
                }
            }
        }

        /// <summary>
        /// Maps to Registration.PatientSign
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public byte[] PatientSign
        {
            get
            {
                return GetSystemByteArray(RegistrationMetadata.ColumnNames.PatientSign);
            }

            set
            {
                if (SetSystemByteArray(RegistrationMetadata.ColumnNames.PatientSign, value))
                {
                    OnPropertyChanged(RegistrationMetadata.PropertyNames.PatientSign);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return RegistrationMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public RegistrationQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new RegistrationQuery("rQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(RegistrationQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(RegistrationQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((RegistrationQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private RegistrationQuery query;
    }



    [Serializable]
    abstract public partial class esRegistrationCollection : esEntityCollection<Registration>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return RegistrationMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "RegistrationCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public RegistrationQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new RegistrationQuery("rQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(RegistrationQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new RegistrationQuery("rQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(RegistrationQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((RegistrationQuery)query);
        }

        #endregion

        private RegistrationQuery query;
    }



    [Serializable]
    abstract public partial class esRegistrationQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return RegistrationMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "RegistrationNo": return RegistrationNo;
                case "SRRegistrationType": return SRRegistrationType;
                case "ParamedicID": return ParamedicID;
                case "GuarantorID": return GuarantorID;
                case "PatientID": return PatientID;
                case "ClassID": return ClassID;
                case "RegistrationDate": return RegistrationDate;
                case "RegistrationTime": return RegistrationTime;
                case "AppointmentNo": return AppointmentNo;
                case "AgeInYear": return AgeInYear;
                case "AgeInMonth": return AgeInMonth;
                case "AgeInDay": return AgeInDay;
                case "SRShift": return SRShift;
                case "SRPatientInType": return SRPatientInType;
                case "InsuranceID": return InsuranceID;
                case "SRPatientCategory": return SRPatientCategory;
                case "SRERCaseType": return SRERCaseType;
                case "SRVisitReason": return SRVisitReason;
                case "SRBussinesMethod": return SRBussinesMethod;
                case "PlavonAmount": return PlavonAmount;
                case "DepartmentID": return DepartmentID;
                case "ServiceUnitID": return ServiceUnitID;
                case "RoomID": return RoomID;
                case "BedID": return BedID;
                case "ChargeClassID": return ChargeClassID;
                case "CoverageClassID": return CoverageClassID;
                case "VisitTypeID": return VisitTypeID;
                case "ReferralID": return ReferralID;
                case "Anamnesis": return Anamnesis;
                case "Complaint": return Complaint;
                case "InitialDiagnose": return InitialDiagnose;
                case "MedicationPlanning": return MedicationPlanning;
                case "SRTriage": return SRTriage;
                case "IsPrintingPatientCard": return IsPrintingPatientCard;
                case "DischargeDate": return DischargeDate;
                case "DischargeTime": return DischargeTime;
                case "DischargeMedicalNotes": return DischargeMedicalNotes;
                case "DischargeNotes": return DischargeNotes;
                case "SRDischargeCondition": return SRDischargeCondition;
                case "SRDischargeMethod": return SRDischargeMethod;
                case "LOSInYear": return LOSInYear;
                case "LOSInMonth": return LOSInMonth;
                case "LOSInDay": return LOSInDay;
                case "DischargeOperatorID": return DischargeOperatorID;
                case "AccountNo": return AccountNo;
                case "TransactionAmount": return TransactionAmount;
                case "AdministrationAmount": return AdministrationAmount;
                case "RoundingAmount": return RoundingAmount;
                case "RemainingAmount": return RemainingAmount;
                case "IsTransferedToInpatient": return IsTransferedToInpatient;
                case "IsNewPatient": return IsNewPatient;
                case "IsNewBornInfant": return IsNewBornInfant;
                case "IsParturition": return IsParturition;
                case "IsHoldTransactionEntry": return IsHoldTransactionEntry;
                case "IsHasCorrection": return IsHasCorrection;
                case "IsEMRValid": return IsEMRValid;
                case "IsBackDate": return IsBackDate;
                case "ActualVisitDate": return ActualVisitDate;
                case "IsVoid": return IsVoid;
                case "SRVoidReason": return SRVoidReason;
                case "VoidNotes": return VoidNotes;
                case "VoidDate": return VoidDate;
                case "VoidByUserID": return VoidByUserID;
                case "IsClosed": return IsClosed;
                case "IsEpisodeComplete": return IsEpisodeComplete;
                case "IsClusterAssessment": return IsClusterAssessment;
                case "IsConsul": return IsConsul;
                case "IsFromDispensary": return IsFromDispensary;
                case "IsNewVisit": return IsNewVisit;
                case "Notes": return Notes;
                case "LastCreateDateTime": return LastCreateDateTime;
                case "LastCreateUserID": return LastCreateUserID;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "IsDirectPrescriptionReturn": return IsDirectPrescriptionReturn;
                case "RegistrationQue": return RegistrationQue;
                case "VisiteRegistrationNo": return VisiteRegistrationNo;
                case "IsGenerateHL7": return IsGenerateHL7;
                case "ReferralName": return ReferralName;
                case "IsObservation": return IsObservation;
                case "CauseOfAccident": return CauseOfAccident;
                case "ReferTo": return ReferTo;
                case "IsOldCase": return IsOldCase;
                case "IsDHF": return IsDHF;
                case "IsEKG": return IsEKG;
                case "EmrDiagnoseID": return EmrDiagnoseID;
                case "IsGlobalPlafond": return IsGlobalPlafond;
                case "FirstResponDate": return FirstResponDate;
                case "FirstResponTime": return FirstResponTime;
                case "PhysicianResponDate": return PhysicianResponDate;
                case "PhysicianResponTime": return PhysicianResponTime;
                case "IsRoomIn": return IsRoomIn;
                case "IsLockVerifiedBilling": return IsLockVerifiedBilling;
                case "LockVerifiedBillingDateTime": return LockVerifiedBillingDateTime;
                case "LockVerifiedBillingByUserID": return LockVerifiedBillingByUserID;
                case "ProcedureChargeClassID": return ProcedureChargeClassID;
                case "PersonID": return PersonID;
                case "EmployeeNumber": return EmployeeNumber;
                case "SREmployeeRelationship": return SREmployeeRelationship;
                case "GuarantorCardNo": return GuarantorCardNo;
                case "DischargePlanDate": return DischargePlanDate;
                case "UsertInsertDischargePlan": return UsertInsertDischargePlan;
                case "IsNonPatient": return IsNonPatient;
                case "ReasonsForTreatmentID": return ReasonsForTreatmentID;
                case "SmfID": return SmfID;
                case "PatientAdm": return PatientAdm;
                case "GuarantorAdm": return GuarantorAdm;
                case "ReasonsForTreatmentDescID": return ReasonsForTreatmentDescID;
                case "SRReferralGroup": return SRReferralGroup;
                case "SRDiscountReason": return SRDiscountReason;
                case "PhysicianSenders": return PhysicianSenders;
                case "DiscAdmPatient": return DiscAdmPatient;
                case "DiscAdmGuarantor": return DiscAdmGuarantor;
                case "SRPatientInCondition": return SRPatientInCondition;
                case "SRKiaCaseType": return SRKiaCaseType;
                case "SRObstetricType": return SRObstetricType;
                case "IsHoldTransactionEntryByUserID": return IsHoldTransactionEntryByUserID;
                case "FromRegistrationNo": return FromRegistrationNo;
                case "IsConfirmedAttendance": return IsConfirmedAttendance;
                case "ConfirmedAttendanceByUserID": return ConfirmedAttendanceByUserID;
                case "ConfirmedAttendanceDateTime": return ConfirmedAttendanceDateTime;
                case "BpjsSepNo": return BpjsSepNo;
                case "PlavonAmount2": return PlavonAmount2;
                case "DeathCertificateNo": return DeathCertificateNo;
                case "BpjsCoverageFormula": return BpjsCoverageFormula;
                case "BpjsPackageID": return BpjsPackageID;
                case "ApproximatePlafondAmount": return ApproximatePlafondAmount;
                case "SentToBillingDateTime": return SentToBillingDateTime;
                case "SentToBillingByUserID": return SentToBillingByUserID;
                case "IsAdjusted": return IsAdjusted;
                case "AdjustLog": return AdjustLog;
                case "IsAllowPatientCheckOut": return IsAllowPatientCheckOut;
                case "AllowPatientCheckOutDateTime": return AllowPatientCheckOutDateTime;
                case "AllowPatientCheckOutByUserID": return AllowPatientCheckOutByUserID;
                case "ReferByParamedicID": return ReferByParamedicID;
                case "SRMaritalStatus": return SRMaritalStatus;
                case "SROccupation": return SROccupation;
                case "SRRelationshipQuality": return SRRelationshipQuality;
                case "SRResidentialHome": return SRResidentialHome;
                case "SRFatherOccupation": return SRFatherOccupation;
                case "IsPregnant": return IsPregnant;
                case "GestationalAge": return GestationalAge;
                case "IsBreastFeeding": return IsBreastFeeding;
                case "AgeOfBabyInYear": return AgeOfBabyInYear;
                case "AgeOfBabyInMonth": return AgeOfBabyInMonth;
                case "AgeOfBabyInDay": return AgeOfBabyInDay;
                case "IsKidneyFunctionImpaired": return IsKidneyFunctionImpaired;
                case "CreatinineSerumValue": return CreatinineSerumValue;
                case "Hpi": return Hpi;
                case "MembershipDetailID": return MembershipDetailID;
                case "ExternalQueNo": return ExternalQueNo;
                case "ReferralIdTo": return ReferralIdTo;
                case "ReferralNameTo": return ReferralNameTo;
                case "IsReconcile": return IsReconcile;
                case "IsSkipAutoBill": return IsSkipAutoBill;
                case "SRCrashSite": return SRCrashSite;
                case "CrashSiteDetail": return CrashSiteDetail;
                case "MembershipNo": return MembershipNo;
                case "IsOpenEntryMR": return IsOpenEntryMR;
                case "SRCovidStatus": return SRCovidStatus;
                case "VoucherNo": return VoucherNo;
                case "SRCovidComorbidStatus": return SRCovidComorbidStatus;
                case "IsDisability": return IsDisability;
                case "IsTracer": return IsTracer;
                case "ItemConditionRuleID": return ItemConditionRuleID;
                case "SRPatientRiskStatus": return SRPatientRiskStatus;
                case "IsFinishedAttendance": return IsFinishedAttendance;
                case "FinishedAttendanceByUserID": return FinishedAttendanceByUserID;
                case "FinishedAttendanceDateTime": return FinishedAttendanceDateTime;
                case "IsQueueCalled": return IsQueueCalled;
                case "IsQueueRecall": return IsQueueRecall;
                case "QueueCalledDateTime": return QueueCalledDateTime;
                case "SRQueRoom": return SRQueRoom;
                case "SRClassification": return SRClassification;
                case "SRClassificationRoom": return SRClassificationRoom;
                case "QueueQr": return QueueQr;
                case "SRPatientRiskColor": return SRPatientRiskColor;
                case "PatientSign": return PatientSign;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem RegistrationNo
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.RegistrationNo, esSystemType.String); }
        }

        public esQueryItem SRRegistrationType
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.SRRegistrationType, esSystemType.String); }
        }

        public esQueryItem ParamedicID
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.ParamedicID, esSystemType.String); }
        }

        public esQueryItem GuarantorID
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.GuarantorID, esSystemType.String); }
        }

        public esQueryItem PatientID
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.PatientID, esSystemType.String); }
        }

        public esQueryItem ClassID
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.ClassID, esSystemType.String); }
        }

        public esQueryItem RegistrationDate
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.RegistrationDate, esSystemType.DateTime); }
        }

        public esQueryItem RegistrationTime
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.RegistrationTime, esSystemType.String); }
        }

        public esQueryItem AppointmentNo
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.AppointmentNo, esSystemType.String); }
        }

        public esQueryItem AgeInYear
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.AgeInYear, esSystemType.Byte); }
        }

        public esQueryItem AgeInMonth
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.AgeInMonth, esSystemType.Byte); }
        }

        public esQueryItem AgeInDay
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.AgeInDay, esSystemType.Byte); }
        }

        public esQueryItem SRShift
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.SRShift, esSystemType.String); }
        }

        public esQueryItem SRPatientInType
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.SRPatientInType, esSystemType.String); }
        }

        public esQueryItem InsuranceID
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.InsuranceID, esSystemType.String); }
        }

        public esQueryItem SRPatientCategory
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.SRPatientCategory, esSystemType.String); }
        }

        public esQueryItem SRERCaseType
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.SRERCaseType, esSystemType.String); }
        }

        public esQueryItem SRVisitReason
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.SRVisitReason, esSystemType.String); }
        }

        public esQueryItem SRBussinesMethod
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.SRBussinesMethod, esSystemType.String); }
        }

        public esQueryItem PlavonAmount
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.PlavonAmount, esSystemType.Decimal); }
        }

        public esQueryItem DepartmentID
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.DepartmentID, esSystemType.String); }
        }

        public esQueryItem ServiceUnitID
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.ServiceUnitID, esSystemType.String); }
        }

        public esQueryItem RoomID
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.RoomID, esSystemType.String); }
        }

        public esQueryItem BedID
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.BedID, esSystemType.String); }
        }

        public esQueryItem ChargeClassID
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.ChargeClassID, esSystemType.String); }
        }

        public esQueryItem CoverageClassID
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.CoverageClassID, esSystemType.String); }
        }

        public esQueryItem VisitTypeID
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.VisitTypeID, esSystemType.String); }
        }

        public esQueryItem ReferralID
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.ReferralID, esSystemType.String); }
        }

        public esQueryItem Anamnesis
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.Anamnesis, esSystemType.String); }
        }

        public esQueryItem Complaint
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.Complaint, esSystemType.String); }
        }

        public esQueryItem InitialDiagnose
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.InitialDiagnose, esSystemType.String); }
        }

        public esQueryItem MedicationPlanning
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.MedicationPlanning, esSystemType.String); }
        }

        public esQueryItem SRTriage
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.SRTriage, esSystemType.String); }
        }

        public esQueryItem IsPrintingPatientCard
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsPrintingPatientCard, esSystemType.Boolean); }
        }

        public esQueryItem DischargeDate
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.DischargeDate, esSystemType.DateTime); }
        }

        public esQueryItem DischargeTime
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.DischargeTime, esSystemType.String); }
        }

        public esQueryItem DischargeMedicalNotes
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.DischargeMedicalNotes, esSystemType.String); }
        }

        public esQueryItem DischargeNotes
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.DischargeNotes, esSystemType.String); }
        }

        public esQueryItem SRDischargeCondition
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.SRDischargeCondition, esSystemType.String); }
        }

        public esQueryItem SRDischargeMethod
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.SRDischargeMethod, esSystemType.String); }
        }

        public esQueryItem LOSInYear
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.LOSInYear, esSystemType.Byte); }
        }

        public esQueryItem LOSInMonth
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.LOSInMonth, esSystemType.Byte); }
        }

        public esQueryItem LOSInDay
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.LOSInDay, esSystemType.Byte); }
        }

        public esQueryItem DischargeOperatorID
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.DischargeOperatorID, esSystemType.String); }
        }

        public esQueryItem AccountNo
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.AccountNo, esSystemType.String); }
        }

        public esQueryItem TransactionAmount
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.TransactionAmount, esSystemType.Decimal); }
        }

        public esQueryItem AdministrationAmount
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.AdministrationAmount, esSystemType.Decimal); }
        }

        public esQueryItem RoundingAmount
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.RoundingAmount, esSystemType.Decimal); }
        }

        public esQueryItem RemainingAmount
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.RemainingAmount, esSystemType.Decimal); }
        }

        public esQueryItem IsTransferedToInpatient
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsTransferedToInpatient, esSystemType.Boolean); }
        }

        public esQueryItem IsNewPatient
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsNewPatient, esSystemType.Boolean); }
        }

        public esQueryItem IsNewBornInfant
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsNewBornInfant, esSystemType.Boolean); }
        }

        public esQueryItem IsParturition
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsParturition, esSystemType.Boolean); }
        }

        public esQueryItem IsHoldTransactionEntry
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsHoldTransactionEntry, esSystemType.Boolean); }
        }

        public esQueryItem IsHasCorrection
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsHasCorrection, esSystemType.Boolean); }
        }

        public esQueryItem IsEMRValid
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsEMRValid, esSystemType.Boolean); }
        }

        public esQueryItem IsBackDate
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsBackDate, esSystemType.Boolean); }
        }

        public esQueryItem ActualVisitDate
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.ActualVisitDate, esSystemType.DateTime); }
        }

        public esQueryItem IsVoid
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsVoid, esSystemType.Boolean); }
        }

        public esQueryItem SRVoidReason
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.SRVoidReason, esSystemType.String); }
        }

        public esQueryItem VoidNotes
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.VoidNotes, esSystemType.String); }
        }

        public esQueryItem VoidDate
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.VoidDate, esSystemType.DateTime); }
        }

        public esQueryItem VoidByUserID
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.VoidByUserID, esSystemType.String); }
        }

        public esQueryItem IsClosed
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsClosed, esSystemType.Boolean); }
        }

        public esQueryItem IsEpisodeComplete
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsEpisodeComplete, esSystemType.Boolean); }
        }

        public esQueryItem IsClusterAssessment
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsClusterAssessment, esSystemType.Boolean); }
        }

        public esQueryItem IsConsul
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsConsul, esSystemType.Boolean); }
        }

        public esQueryItem IsFromDispensary
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsFromDispensary, esSystemType.Boolean); }
        }

        public esQueryItem IsNewVisit
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsNewVisit, esSystemType.Boolean); }
        }

        public esQueryItem Notes
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.Notes, esSystemType.String); }
        }

        public esQueryItem LastCreateDateTime
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.LastCreateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastCreateUserID
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.LastCreateUserID, esSystemType.String); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem IsDirectPrescriptionReturn
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsDirectPrescriptionReturn, esSystemType.Boolean); }
        }

        public esQueryItem RegistrationQue
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.RegistrationQue, esSystemType.Int32); }
        }

        public esQueryItem VisiteRegistrationNo
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.VisiteRegistrationNo, esSystemType.String); }
        }

        public esQueryItem IsGenerateHL7
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsGenerateHL7, esSystemType.Boolean); }
        }

        public esQueryItem ReferralName
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.ReferralName, esSystemType.String); }
        }

        public esQueryItem IsObservation
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsObservation, esSystemType.Boolean); }
        }

        public esQueryItem CauseOfAccident
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.CauseOfAccident, esSystemType.String); }
        }

        public esQueryItem ReferTo
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.ReferTo, esSystemType.String); }
        }

        public esQueryItem IsOldCase
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsOldCase, esSystemType.Boolean); }
        }

        public esQueryItem IsDHF
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsDHF, esSystemType.Boolean); }
        }

        public esQueryItem IsEKG
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsEKG, esSystemType.Boolean); }
        }

        public esQueryItem EmrDiagnoseID
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.EmrDiagnoseID, esSystemType.String); }
        }

        public esQueryItem IsGlobalPlafond
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsGlobalPlafond, esSystemType.Boolean); }
        }

        public esQueryItem FirstResponDate
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.FirstResponDate, esSystemType.DateTime); }
        }

        public esQueryItem FirstResponTime
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.FirstResponTime, esSystemType.String); }
        }

        public esQueryItem PhysicianResponDate
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.PhysicianResponDate, esSystemType.DateTime); }
        }

        public esQueryItem PhysicianResponTime
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.PhysicianResponTime, esSystemType.String); }
        }

        public esQueryItem IsRoomIn
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsRoomIn, esSystemType.Boolean); }
        }

        public esQueryItem IsLockVerifiedBilling
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsLockVerifiedBilling, esSystemType.Boolean); }
        }

        public esQueryItem LockVerifiedBillingDateTime
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.LockVerifiedBillingDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LockVerifiedBillingByUserID
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.LockVerifiedBillingByUserID, esSystemType.String); }
        }

        public esQueryItem ProcedureChargeClassID
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.ProcedureChargeClassID, esSystemType.String); }
        }

        public esQueryItem PersonID
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.PersonID, esSystemType.Int32); }
        }

        public esQueryItem EmployeeNumber
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.EmployeeNumber, esSystemType.String); }
        }

        public esQueryItem SREmployeeRelationship
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.SREmployeeRelationship, esSystemType.String); }
        }

        public esQueryItem GuarantorCardNo
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.GuarantorCardNo, esSystemType.String); }
        }

        public esQueryItem DischargePlanDate
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.DischargePlanDate, esSystemType.DateTime); }
        }

        public esQueryItem UsertInsertDischargePlan
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.UsertInsertDischargePlan, esSystemType.String); }
        }

        public esQueryItem IsNonPatient
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsNonPatient, esSystemType.Boolean); }
        }

        public esQueryItem ReasonsForTreatmentID
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.ReasonsForTreatmentID, esSystemType.String); }
        }

        public esQueryItem SmfID
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.SmfID, esSystemType.String); }
        }

        public esQueryItem PatientAdm
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.PatientAdm, esSystemType.Decimal); }
        }

        public esQueryItem GuarantorAdm
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.GuarantorAdm, esSystemType.Decimal); }
        }

        public esQueryItem ReasonsForTreatmentDescID
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.ReasonsForTreatmentDescID, esSystemType.String); }
        }

        public esQueryItem SRReferralGroup
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.SRReferralGroup, esSystemType.String); }
        }

        public esQueryItem SRDiscountReason
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.SRDiscountReason, esSystemType.String); }
        }

        public esQueryItem PhysicianSenders
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.PhysicianSenders, esSystemType.String); }
        }

        public esQueryItem DiscAdmPatient
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.DiscAdmPatient, esSystemType.Decimal); }
        }

        public esQueryItem DiscAdmGuarantor
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.DiscAdmGuarantor, esSystemType.Decimal); }
        }

        public esQueryItem SRPatientInCondition
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.SRPatientInCondition, esSystemType.String); }
        }

        public esQueryItem SRKiaCaseType
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.SRKiaCaseType, esSystemType.String); }
        }

        public esQueryItem SRObstetricType
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.SRObstetricType, esSystemType.String); }
        }

        public esQueryItem IsHoldTransactionEntryByUserID
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsHoldTransactionEntryByUserID, esSystemType.String); }
        }

        public esQueryItem FromRegistrationNo
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.FromRegistrationNo, esSystemType.String); }
        }

        public esQueryItem IsConfirmedAttendance
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsConfirmedAttendance, esSystemType.Boolean); }
        }

        public esQueryItem ConfirmedAttendanceByUserID
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.ConfirmedAttendanceByUserID, esSystemType.String); }
        }

        public esQueryItem ConfirmedAttendanceDateTime
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.ConfirmedAttendanceDateTime, esSystemType.DateTime); }
        }

        public esQueryItem BpjsSepNo
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.BpjsSepNo, esSystemType.String); }
        }

        public esQueryItem PlavonAmount2
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.PlavonAmount2, esSystemType.Decimal); }
        }

        public esQueryItem DeathCertificateNo
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.DeathCertificateNo, esSystemType.String); }
        }

        public esQueryItem BpjsCoverageFormula
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.BpjsCoverageFormula, esSystemType.Decimal); }
        }

        public esQueryItem BpjsPackageID
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.BpjsPackageID, esSystemType.String); }
        }

        public esQueryItem ApproximatePlafondAmount
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.ApproximatePlafondAmount, esSystemType.Decimal); }
        }

        public esQueryItem SentToBillingDateTime
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.SentToBillingDateTime, esSystemType.DateTime); }
        }

        public esQueryItem SentToBillingByUserID
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.SentToBillingByUserID, esSystemType.String); }
        }

        public esQueryItem IsAdjusted
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsAdjusted, esSystemType.Boolean); }
        }

        public esQueryItem AdjustLog
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.AdjustLog, esSystemType.String); }
        }

        public esQueryItem IsAllowPatientCheckOut
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsAllowPatientCheckOut, esSystemType.Boolean); }
        }

        public esQueryItem AllowPatientCheckOutDateTime
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.AllowPatientCheckOutDateTime, esSystemType.DateTime); }
        }

        public esQueryItem AllowPatientCheckOutByUserID
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.AllowPatientCheckOutByUserID, esSystemType.String); }
        }

        public esQueryItem ReferByParamedicID
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.ReferByParamedicID, esSystemType.String); }
        }

        public esQueryItem SRMaritalStatus
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.SRMaritalStatus, esSystemType.String); }
        }

        public esQueryItem SROccupation
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.SROccupation, esSystemType.String); }
        }

        public esQueryItem SRRelationshipQuality
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.SRRelationshipQuality, esSystemType.String); }
        }

        public esQueryItem SRResidentialHome
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.SRResidentialHome, esSystemType.String); }
        }

        public esQueryItem SRFatherOccupation
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.SRFatherOccupation, esSystemType.String); }
        }

        public esQueryItem IsPregnant
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsPregnant, esSystemType.Boolean); }
        }

        public esQueryItem GestationalAge
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.GestationalAge, esSystemType.Int16); }
        }

        public esQueryItem IsBreastFeeding
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsBreastFeeding, esSystemType.Boolean); }
        }

        public esQueryItem AgeOfBabyInYear
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.AgeOfBabyInYear, esSystemType.Int16); }
        }

        public esQueryItem AgeOfBabyInMonth
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.AgeOfBabyInMonth, esSystemType.Int16); }
        }

        public esQueryItem AgeOfBabyInDay
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.AgeOfBabyInDay, esSystemType.Int16); }
        }

        public esQueryItem IsKidneyFunctionImpaired
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsKidneyFunctionImpaired, esSystemType.Boolean); }
        }

        public esQueryItem CreatinineSerumValue
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.CreatinineSerumValue, esSystemType.Int16); }
        }

        public esQueryItem Hpi
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.Hpi, esSystemType.String); }
        }

        public esQueryItem MembershipDetailID
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.MembershipDetailID, esSystemType.Int64); }
        }

        public esQueryItem ExternalQueNo
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.ExternalQueNo, esSystemType.String); }
        }

        public esQueryItem ReferralIdTo
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.ReferralIdTo, esSystemType.String); }
        }

        public esQueryItem ReferralNameTo
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.ReferralNameTo, esSystemType.String); }
        }

        public esQueryItem IsReconcile
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsReconcile, esSystemType.Boolean); }
        }

        public esQueryItem IsSkipAutoBill
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsSkipAutoBill, esSystemType.Boolean); }
        }

        public esQueryItem SRCrashSite
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.SRCrashSite, esSystemType.String); }
        }

        public esQueryItem CrashSiteDetail
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.CrashSiteDetail, esSystemType.String); }
        }

        public esQueryItem MembershipNo
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.MembershipNo, esSystemType.String); }
        }

        public esQueryItem IsOpenEntryMR
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsOpenEntryMR, esSystemType.Boolean); }
        }

        public esQueryItem SRCovidStatus
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.SRCovidStatus, esSystemType.Byte); }
        }

        public esQueryItem VoucherNo
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.VoucherNo, esSystemType.String); }
        }

        public esQueryItem SRCovidComorbidStatus
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.SRCovidComorbidStatus, esSystemType.String); }
        }

        public esQueryItem IsDisability
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsDisability, esSystemType.Boolean); }
        }

        public esQueryItem IsTracer
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsTracer, esSystemType.Boolean); }
        }

        public esQueryItem ItemConditionRuleID
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.ItemConditionRuleID, esSystemType.String); }
        }

        public esQueryItem SRPatientRiskStatus
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.SRPatientRiskStatus, esSystemType.String); }
        }

        public esQueryItem IsFinishedAttendance
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsFinishedAttendance, esSystemType.Boolean); }
        }

        public esQueryItem FinishedAttendanceByUserID
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.FinishedAttendanceByUserID, esSystemType.String); }
        }

        public esQueryItem FinishedAttendanceDateTime
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.FinishedAttendanceDateTime, esSystemType.DateTime); }
        }

        public esQueryItem IsQueueCalled
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsQueueCalled, esSystemType.Boolean); }
        }

        public esQueryItem IsQueueRecall
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.IsQueueRecall, esSystemType.Boolean); }
        }

        public esQueryItem QueueCalledDateTime
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.QueueCalledDateTime, esSystemType.DateTime); }
        }

        public esQueryItem SRQueRoom
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.SRQueRoom, esSystemType.String); }
        }

        public esQueryItem SRClassification
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.SRClassification, esSystemType.String); }
        }

        public esQueryItem SRClassificationRoom
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.SRClassificationRoom, esSystemType.String); }
        }

        public esQueryItem QueueQr
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.QueueQr, esSystemType.String); }
        }

        public esQueryItem SRPatientRiskColor
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.SRPatientRiskColor, esSystemType.String); }
        }

        public esQueryItem PatientSign
        {
            get { return new esQueryItem(this, RegistrationMetadata.ColumnNames.PatientSign, esSystemType.ByteArray); }
        }

        #endregion

    }



    [Serializable]
    public partial class RegistrationMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected RegistrationMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.RegistrationNo, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RegistrationNo;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRRegistrationType, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRRegistrationType;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParamedicID, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParamedicID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.GuarantorID, 3, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.GuarantorID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PatientID, 4, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PatientID;
            c.CharacterMaxLength = 15;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ClassID, 5, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ClassID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RegistrationDate, 6, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.RegistrationDate;
            c.HasDefault = true;
            c.Default = @"(getdate())";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RegistrationTime, 7, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RegistrationTime;
            c.CharacterMaxLength = 5;
            c.HasDefault = true;
            c.Default = @"('00:00')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AppointmentNo, 8, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.AppointmentNo;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AgeInYear, 9, typeof(byte), esSystemType.Byte);
            c.PropertyName = PropertyNames.AgeInYear;
            c.NumericPrecision = 3;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AgeInMonth, 10, typeof(byte), esSystemType.Byte);
            c.PropertyName = PropertyNames.AgeInMonth;
            c.NumericPrecision = 3;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AgeInDay, 11, typeof(byte), esSystemType.Byte);
            c.PropertyName = PropertyNames.AgeInDay;
            c.NumericPrecision = 3;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRShift, 12, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRShift;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRPatientInType, 13, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRPatientInType;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.InsuranceID, 14, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.InsuranceID;
            c.CharacterMaxLength = 255;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRPatientCategory, 15, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRPatientCategory;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRERCaseType, 16, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRERCaseType;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRVisitReason, 17, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRVisitReason;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRBussinesMethod, 18, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRBussinesMethod;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PlavonAmount, 19, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.PlavonAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.HasDefault = true;
            c.Default = @"((0))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DepartmentID, 20, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DepartmentID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ServiceUnitID, 21, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ServiceUnitID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RoomID, 22, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RoomID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.BedID, 23, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.BedID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ChargeClassID, 24, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ChargeClassID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CoverageClassID, 25, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.CoverageClassID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.VisitTypeID, 26, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.VisitTypeID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ReferralID, 27, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ReferralID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Anamnesis, 28, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Anamnesis;
            c.CharacterMaxLength = 4000;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Complaint, 29, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Complaint;
            c.CharacterMaxLength = 4000;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.InitialDiagnose, 30, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.InitialDiagnose;
            c.CharacterMaxLength = 2147483647;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.MedicationPlanning, 31, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.MedicationPlanning;
            c.CharacterMaxLength = 2147483647;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRTriage, 32, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRTriage;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsPrintingPatientCard, 33, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsPrintingPatientCard;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DischargeDate, 34, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.DischargeDate;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DischargeTime, 35, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DischargeTime;
            c.CharacterMaxLength = 5;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DischargeMedicalNotes, 36, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DischargeMedicalNotes;
            c.CharacterMaxLength = 4000;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DischargeNotes, 37, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DischargeNotes;
            c.CharacterMaxLength = 4000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRDischargeCondition, 38, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRDischargeCondition;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRDischargeMethod, 39, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRDischargeMethod;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LOSInYear, 40, typeof(byte), esSystemType.Byte);
            c.PropertyName = PropertyNames.LOSInYear;
            c.NumericPrecision = 3;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LOSInMonth, 41, typeof(byte), esSystemType.Byte);
            c.PropertyName = PropertyNames.LOSInMonth;
            c.NumericPrecision = 3;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LOSInDay, 42, typeof(byte), esSystemType.Byte);
            c.PropertyName = PropertyNames.LOSInDay;
            c.NumericPrecision = 3;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DischargeOperatorID, 43, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DischargeOperatorID;
            c.CharacterMaxLength = 15;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AccountNo, 44, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.AccountNo;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TransactionAmount, 45, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.TransactionAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AdministrationAmount, 46, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.AdministrationAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RoundingAmount, 47, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.RoundingAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RemainingAmount, 48, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.RemainingAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsTransferedToInpatient, 49, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsTransferedToInpatient;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsNewPatient, 50, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsNewPatient;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsNewBornInfant, 51, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsNewBornInfant;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsParturition, 52, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsParturition;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsHoldTransactionEntry, 53, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsHoldTransactionEntry;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsHasCorrection, 54, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsHasCorrection;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsEMRValid, 55, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsEMRValid;
            c.HasDefault = true;
            c.Default = @"((0))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsBackDate, 56, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsBackDate;
            c.HasDefault = true;
            c.Default = @"((0))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ActualVisitDate, 57, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.ActualVisitDate;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsVoid, 58, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsVoid;
            c.HasDefault = true;
            c.Default = @"((0))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRVoidReason, 59, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRVoidReason;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.VoidNotes, 60, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.VoidNotes;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.VoidDate, 61, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.VoidDate;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.VoidByUserID, 62, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.VoidByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsClosed, 63, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsClosed;
            c.HasDefault = true;
            c.Default = @"((0))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsEpisodeComplete, 64, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsEpisodeComplete;
            c.HasDefault = true;
            c.Default = @"((0))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsClusterAssessment, 65, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsClusterAssessment;
            c.HasDefault = true;
            c.Default = @"((0))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsConsul, 66, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsConsul;
            c.HasDefault = true;
            c.Default = @"((0))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsFromDispensary, 67, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsFromDispensary;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsNewVisit, 68, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsNewVisit;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Notes, 69, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Notes;
            c.CharacterMaxLength = 2147483647;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastCreateDateTime, 70, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastCreateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastCreateUserID, 71, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastCreateUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 72, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 73, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsDirectPrescriptionReturn, 74, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsDirectPrescriptionReturn;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RegistrationQue, 75, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.RegistrationQue;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.VisiteRegistrationNo, 76, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.VisiteRegistrationNo;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsGenerateHL7, 77, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsGenerateHL7;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ReferralName, 78, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ReferralName;
            c.CharacterMaxLength = 100;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsObservation, 79, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsObservation;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CauseOfAccident, 80, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.CauseOfAccident;
            c.CharacterMaxLength = 250;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ReferTo, 81, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ReferTo;
            c.CharacterMaxLength = 100;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsOldCase, 82, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsOldCase;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsDHF, 83, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsDHF;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsEKG, 84, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsEKG;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.EmrDiagnoseID, 85, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.EmrDiagnoseID;
            c.CharacterMaxLength = 200;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsGlobalPlafond, 86, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsGlobalPlafond;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FirstResponDate, 87, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.FirstResponDate;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FirstResponTime, 88, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.FirstResponTime;
            c.CharacterMaxLength = 5;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PhysicianResponDate, 89, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.PhysicianResponDate;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PhysicianResponTime, 90, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PhysicianResponTime;
            c.CharacterMaxLength = 5;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsRoomIn, 91, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsRoomIn;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsLockVerifiedBilling, 92, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsLockVerifiedBilling;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LockVerifiedBillingDateTime, 93, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LockVerifiedBillingDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LockVerifiedBillingByUserID, 94, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LockVerifiedBillingByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ProcedureChargeClassID, 95, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ProcedureChargeClassID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PersonID, 96, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.PersonID;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.EmployeeNumber, 97, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.EmployeeNumber;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SREmployeeRelationship, 98, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SREmployeeRelationship;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.GuarantorCardNo, 99, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.GuarantorCardNo;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DischargePlanDate, 100, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.DischargePlanDate;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.UsertInsertDischargePlan, 101, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.UsertInsertDischargePlan;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsNonPatient, 102, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsNonPatient;
            c.HasDefault = true;
            c.Default = @"((0))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ReasonsForTreatmentID, 103, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ReasonsForTreatmentID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SmfID, 104, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SmfID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PatientAdm, 105, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.PatientAdm;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.GuarantorAdm, 106, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.GuarantorAdm;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ReasonsForTreatmentDescID, 107, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ReasonsForTreatmentDescID;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRReferralGroup, 108, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRReferralGroup;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRDiscountReason, 109, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRDiscountReason;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PhysicianSenders, 110, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PhysicianSenders;
            c.CharacterMaxLength = 150;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DiscAdmPatient, 111, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.DiscAdmPatient;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DiscAdmGuarantor, 112, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.DiscAdmGuarantor;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRPatientInCondition, 113, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRPatientInCondition;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRKiaCaseType, 114, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRKiaCaseType;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRObstetricType, 115, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRObstetricType;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsHoldTransactionEntryByUserID, 116, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.IsHoldTransactionEntryByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FromRegistrationNo, 117, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.FromRegistrationNo;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsConfirmedAttendance, 118, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsConfirmedAttendance;
            c.HasDefault = true;
            c.Default = @"((0))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ConfirmedAttendanceByUserID, 119, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ConfirmedAttendanceByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ConfirmedAttendanceDateTime, 120, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.ConfirmedAttendanceDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.BpjsSepNo, 121, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.BpjsSepNo;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PlavonAmount2, 122, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.PlavonAmount2;
            c.NumericPrecision = 18;
            c.HasDefault = true;
            c.Default = @"((0))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DeathCertificateNo, 123, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DeathCertificateNo;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.BpjsCoverageFormula, 124, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.BpjsCoverageFormula;
            c.NumericPrecision = 10;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.BpjsPackageID, 125, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.BpjsPackageID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ApproximatePlafondAmount, 126, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.ApproximatePlafondAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SentToBillingDateTime, 127, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.SentToBillingDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SentToBillingByUserID, 128, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SentToBillingByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsAdjusted, 129, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsAdjusted;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AdjustLog, 130, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.AdjustLog;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsAllowPatientCheckOut, 131, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsAllowPatientCheckOut;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AllowPatientCheckOutDateTime, 132, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.AllowPatientCheckOutDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AllowPatientCheckOutByUserID, 133, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.AllowPatientCheckOutByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ReferByParamedicID, 134, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ReferByParamedicID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRMaritalStatus, 135, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRMaritalStatus;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SROccupation, 136, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SROccupation;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRRelationshipQuality, 137, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRRelationshipQuality;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRResidentialHome, 138, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRResidentialHome;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRFatherOccupation, 139, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRFatherOccupation;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsPregnant, 140, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsPregnant;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.GestationalAge, 141, typeof(short), esSystemType.Int16);
            c.PropertyName = PropertyNames.GestationalAge;
            c.NumericPrecision = 5;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsBreastFeeding, 142, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsBreastFeeding;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AgeOfBabyInYear, 143, typeof(short), esSystemType.Int16);
            c.PropertyName = PropertyNames.AgeOfBabyInYear;
            c.NumericPrecision = 5;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AgeOfBabyInMonth, 144, typeof(short), esSystemType.Int16);
            c.PropertyName = PropertyNames.AgeOfBabyInMonth;
            c.NumericPrecision = 5;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AgeOfBabyInDay, 145, typeof(short), esSystemType.Int16);
            c.PropertyName = PropertyNames.AgeOfBabyInDay;
            c.NumericPrecision = 5;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsKidneyFunctionImpaired, 146, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsKidneyFunctionImpaired;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreatinineSerumValue, 147, typeof(short), esSystemType.Int16);
            c.PropertyName = PropertyNames.CreatinineSerumValue;
            c.NumericPrecision = 5;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Hpi, 148, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Hpi;
            c.CharacterMaxLength = 4000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.MembershipDetailID, 149, typeof(long), esSystemType.Int64);
            c.PropertyName = PropertyNames.MembershipDetailID;
            c.NumericPrecision = 19;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ExternalQueNo, 150, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ExternalQueNo;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ReferralIdTo, 151, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ReferralIdTo;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ReferralNameTo, 152, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ReferralNameTo;
            c.CharacterMaxLength = 100;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsReconcile, 153, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsReconcile;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsSkipAutoBill, 154, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsSkipAutoBill;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRCrashSite, 155, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRCrashSite;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CrashSiteDetail, 156, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.CrashSiteDetail;
            c.CharacterMaxLength = 200;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.MembershipNo, 157, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.MembershipNo;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsOpenEntryMR, 158, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsOpenEntryMR;
            c.Description = "Status bisa entry MR jika registrasi sudah diclose";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRCovidStatus, 159, typeof(byte), esSystemType.Byte);
            c.PropertyName = PropertyNames.SRCovidStatus;
            c.NumericPrecision = 3;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.VoucherNo, 160, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.VoucherNo;
            c.CharacterMaxLength = 100;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRCovidComorbidStatus, 161, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRCovidComorbidStatus;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsDisability, 162, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsDisability;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsTracer, 163, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsTracer;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ItemConditionRuleID, 164, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ItemConditionRuleID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRPatientRiskStatus, 165, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRPatientRiskStatus;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsFinishedAttendance, 166, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsFinishedAttendance;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FinishedAttendanceByUserID, 167, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.FinishedAttendanceByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FinishedAttendanceDateTime, 168, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.FinishedAttendanceDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsQueueCalled, 169, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsQueueCalled;
            c.HasDefault = true;
            c.Default = @"((0))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsQueueRecall, 170, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsQueueRecall;
            c.HasDefault = true;
            c.Default = @"((0))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.QueueCalledDateTime, 171, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.QueueCalledDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRQueRoom, 172, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRQueRoom;
            c.CharacterMaxLength = 5;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRClassification, 173, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRClassification;
            c.CharacterMaxLength = 200;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRClassificationRoom, 174, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRClassificationRoom;
            c.CharacterMaxLength = 200;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.QueueQr, 175, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.QueueQr;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRPatientRiskColor, 176, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRPatientRiskColor;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PatientSign, 177, typeof(byte[]), esSystemType.ByteArray);
            c.PropertyName = PropertyNames.PatientSign;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public RegistrationMetadata Meta()
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
            public const string SRRegistrationType = "SRRegistrationType";
            public const string ParamedicID = "ParamedicID";
            public const string GuarantorID = "GuarantorID";
            public const string PatientID = "PatientID";
            public const string ClassID = "ClassID";
            public const string RegistrationDate = "RegistrationDate";
            public const string RegistrationTime = "RegistrationTime";
            public const string AppointmentNo = "AppointmentNo";
            public const string AgeInYear = "AgeInYear";
            public const string AgeInMonth = "AgeInMonth";
            public const string AgeInDay = "AgeInDay";
            public const string SRShift = "SRShift";
            public const string SRPatientInType = "SRPatientInType";
            public const string InsuranceID = "InsuranceID";
            public const string SRPatientCategory = "SRPatientCategory";
            public const string SRERCaseType = "SRERCaseType";
            public const string SRVisitReason = "SRVisitReason";
            public const string SRBussinesMethod = "SRBussinesMethod";
            public const string PlavonAmount = "PlavonAmount";
            public const string DepartmentID = "DepartmentID";
            public const string ServiceUnitID = "ServiceUnitID";
            public const string RoomID = "RoomID";
            public const string BedID = "BedID";
            public const string ChargeClassID = "ChargeClassID";
            public const string CoverageClassID = "CoverageClassID";
            public const string VisitTypeID = "VisitTypeID";
            public const string ReferralID = "ReferralID";
            public const string Anamnesis = "Anamnesis";
            public const string Complaint = "Complaint";
            public const string InitialDiagnose = "InitialDiagnose";
            public const string MedicationPlanning = "MedicationPlanning";
            public const string SRTriage = "SRTriage";
            public const string IsPrintingPatientCard = "IsPrintingPatientCard";
            public const string DischargeDate = "DischargeDate";
            public const string DischargeTime = "DischargeTime";
            public const string DischargeMedicalNotes = "DischargeMedicalNotes";
            public const string DischargeNotes = "DischargeNotes";
            public const string SRDischargeCondition = "SRDischargeCondition";
            public const string SRDischargeMethod = "SRDischargeMethod";
            public const string LOSInYear = "LOSInYear";
            public const string LOSInMonth = "LOSInMonth";
            public const string LOSInDay = "LOSInDay";
            public const string DischargeOperatorID = "DischargeOperatorID";
            public const string AccountNo = "AccountNo";
            public const string TransactionAmount = "TransactionAmount";
            public const string AdministrationAmount = "AdministrationAmount";
            public const string RoundingAmount = "RoundingAmount";
            public const string RemainingAmount = "RemainingAmount";
            public const string IsTransferedToInpatient = "IsTransferedToInpatient";
            public const string IsNewPatient = "IsNewPatient";
            public const string IsNewBornInfant = "IsNewBornInfant";
            public const string IsParturition = "IsParturition";
            public const string IsHoldTransactionEntry = "IsHoldTransactionEntry";
            public const string IsHasCorrection = "IsHasCorrection";
            public const string IsEMRValid = "IsEMRValid";
            public const string IsBackDate = "IsBackDate";
            public const string ActualVisitDate = "ActualVisitDate";
            public const string IsVoid = "IsVoid";
            public const string SRVoidReason = "SRVoidReason";
            public const string VoidNotes = "VoidNotes";
            public const string VoidDate = "VoidDate";
            public const string VoidByUserID = "VoidByUserID";
            public const string IsClosed = "IsClosed";
            public const string IsEpisodeComplete = "IsEpisodeComplete";
            public const string IsClusterAssessment = "IsClusterAssessment";
            public const string IsConsul = "IsConsul";
            public const string IsFromDispensary = "IsFromDispensary";
            public const string IsNewVisit = "IsNewVisit";
            public const string Notes = "Notes";
            public const string LastCreateDateTime = "LastCreateDateTime";
            public const string LastCreateUserID = "LastCreateUserID";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string IsDirectPrescriptionReturn = "isDirectPrescriptionReturn";
            public const string RegistrationQue = "RegistrationQue";
            public const string VisiteRegistrationNo = "VisiteRegistrationNo";
            public const string IsGenerateHL7 = "IsGenerateHL7";
            public const string ReferralName = "ReferralName";
            public const string IsObservation = "IsObservation";
            public const string CauseOfAccident = "CauseOfAccident";
            public const string ReferTo = "ReferTo";
            public const string IsOldCase = "IsOldCase";
            public const string IsDHF = "IsDHF";
            public const string IsEKG = "IsEKG";
            public const string EmrDiagnoseID = "EmrDiagnoseID";
            public const string IsGlobalPlafond = "IsGlobalPlafond";
            public const string FirstResponDate = "FirstResponDate";
            public const string FirstResponTime = "FirstResponTime";
            public const string PhysicianResponDate = "PhysicianResponDate";
            public const string PhysicianResponTime = "PhysicianResponTime";
            public const string IsRoomIn = "IsRoomIn";
            public const string IsLockVerifiedBilling = "IsLockVerifiedBilling";
            public const string LockVerifiedBillingDateTime = "LockVerifiedBillingDateTime";
            public const string LockVerifiedBillingByUserID = "LockVerifiedBillingByUserID";
            public const string ProcedureChargeClassID = "ProcedureChargeClassID";
            public const string PersonID = "PersonID";
            public const string EmployeeNumber = "EmployeeNumber";
            public const string SREmployeeRelationship = "SREmployeeRelationship";
            public const string GuarantorCardNo = "GuarantorCardNo";
            public const string DischargePlanDate = "DischargePlanDate";
            public const string UsertInsertDischargePlan = "UsertInsertDischargePlan";
            public const string IsNonPatient = "IsNonPatient";
            public const string ReasonsForTreatmentID = "ReasonsForTreatmentID";
            public const string SmfID = "SmfID";
            public const string PatientAdm = "PatientAdm";
            public const string GuarantorAdm = "GuarantorAdm";
            public const string ReasonsForTreatmentDescID = "ReasonsForTreatmentDescID";
            public const string SRReferralGroup = "SRReferralGroup";
            public const string SRDiscountReason = "SRDiscountReason";
            public const string PhysicianSenders = "PhysicianSenders";
            public const string DiscAdmPatient = "DiscAdmPatient";
            public const string DiscAdmGuarantor = "DiscAdmGuarantor";
            public const string SRPatientInCondition = "SRPatientInCondition";
            public const string SRKiaCaseType = "SRKiaCaseType";
            public const string SRObstetricType = "SRObstetricType";
            public const string IsHoldTransactionEntryByUserID = "IsHoldTransactionEntryByUserID";
            public const string FromRegistrationNo = "FromRegistrationNo";
            public const string IsConfirmedAttendance = "IsConfirmedAttendance";
            public const string ConfirmedAttendanceByUserID = "ConfirmedAttendanceByUserID";
            public const string ConfirmedAttendanceDateTime = "ConfirmedAttendanceDateTime";
            public const string BpjsSepNo = "BpjsSepNo";
            public const string PlavonAmount2 = "PlavonAmount2";
            public const string DeathCertificateNo = "DeathCertificateNo";
            public const string BpjsCoverageFormula = "BpjsCoverageFormula";
            public const string BpjsPackageID = "BpjsPackageID";
            public const string ApproximatePlafondAmount = "ApproximatePlafondAmount";
            public const string SentToBillingDateTime = "SentToBillingDateTime";
            public const string SentToBillingByUserID = "SentToBillingByUserID";
            public const string IsAdjusted = "IsAdjusted";
            public const string AdjustLog = "AdjustLog";
            public const string IsAllowPatientCheckOut = "IsAllowPatientCheckOut";
            public const string AllowPatientCheckOutDateTime = "AllowPatientCheckOutDateTime";
            public const string AllowPatientCheckOutByUserID = "AllowPatientCheckOutByUserID";
            public const string ReferByParamedicID = "ReferByParamedicID";
            public const string SRMaritalStatus = "SRMaritalStatus";
            public const string SROccupation = "SROccupation";
            public const string SRRelationshipQuality = "SRRelationshipQuality";
            public const string SRResidentialHome = "SRResidentialHome";
            public const string SRFatherOccupation = "SRFatherOccupation";
            public const string IsPregnant = "IsPregnant";
            public const string GestationalAge = "GestationalAge";
            public const string IsBreastFeeding = "IsBreastFeeding";
            public const string AgeOfBabyInYear = "AgeOfBabyInYear";
            public const string AgeOfBabyInMonth = "AgeOfBabyInMonth";
            public const string AgeOfBabyInDay = "AgeOfBabyInDay";
            public const string IsKidneyFunctionImpaired = "IsKidneyFunctionImpaired";
            public const string CreatinineSerumValue = "CreatinineSerumValue";
            public const string Hpi = "Hpi";
            public const string MembershipDetailID = "MembershipDetailID";
            public const string ExternalQueNo = "ExternalQueNo";
            public const string ReferralIdTo = "ReferralIdTo";
            public const string ReferralNameTo = "ReferralNameTo";
            public const string IsReconcile = "IsReconcile";
            public const string IsSkipAutoBill = "IsSkipAutoBill";
            public const string SRCrashSite = "SRCrashSite";
            public const string CrashSiteDetail = "CrashSiteDetail";
            public const string MembershipNo = "MembershipNo";
            public const string IsOpenEntryMR = "IsOpenEntryMR";
            public const string SRCovidStatus = "SRCovidStatus";
            public const string VoucherNo = "VoucherNo";
            public const string SRCovidComorbidStatus = "SRCovidComorbidStatus";
            public const string IsDisability = "IsDisability";
            public const string IsTracer = "IsTracer";
            public const string ItemConditionRuleID = "ItemConditionRuleID";
            public const string SRPatientRiskStatus = "SRPatientRiskStatus";
            public const string IsFinishedAttendance = "IsFinishedAttendance";
            public const string FinishedAttendanceByUserID = "FinishedAttendanceByUserID";
            public const string FinishedAttendanceDateTime = "FinishedAttendanceDateTime";
            public const string IsQueueCalled = "IsQueueCalled";
            public const string IsQueueRecall = "IsQueueRecall";
            public const string QueueCalledDateTime = "QueueCalledDateTime";
            public const string SRQueRoom = "SRQueRoom";
            public const string SRClassification = "SRClassification";
            public const string SRClassificationRoom = "SRClassificationRoom";
            public const string QueueQr = "QueueQr";
            public const string SRPatientRiskColor = "SRPatientRiskColor";
            public const string PatientSign = "PatientSign";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string RegistrationNo = "RegistrationNo";
            public const string SRRegistrationType = "SRRegistrationType";
            public const string ParamedicID = "ParamedicID";
            public const string GuarantorID = "GuarantorID";
            public const string PatientID = "PatientID";
            public const string ClassID = "ClassID";
            public const string RegistrationDate = "RegistrationDate";
            public const string RegistrationTime = "RegistrationTime";
            public const string AppointmentNo = "AppointmentNo";
            public const string AgeInYear = "AgeInYear";
            public const string AgeInMonth = "AgeInMonth";
            public const string AgeInDay = "AgeInDay";
            public const string SRShift = "SRShift";
            public const string SRPatientInType = "SRPatientInType";
            public const string InsuranceID = "InsuranceID";
            public const string SRPatientCategory = "SRPatientCategory";
            public const string SRERCaseType = "SRERCaseType";
            public const string SRVisitReason = "SRVisitReason";
            public const string SRBussinesMethod = "SRBussinesMethod";
            public const string PlavonAmount = "PlavonAmount";
            public const string DepartmentID = "DepartmentID";
            public const string ServiceUnitID = "ServiceUnitID";
            public const string RoomID = "RoomID";
            public const string BedID = "BedID";
            public const string ChargeClassID = "ChargeClassID";
            public const string CoverageClassID = "CoverageClassID";
            public const string VisitTypeID = "VisitTypeID";
            public const string ReferralID = "ReferralID";
            public const string Anamnesis = "Anamnesis";
            public const string Complaint = "Complaint";
            public const string InitialDiagnose = "InitialDiagnose";
            public const string MedicationPlanning = "MedicationPlanning";
            public const string SRTriage = "SRTriage";
            public const string IsPrintingPatientCard = "IsPrintingPatientCard";
            public const string DischargeDate = "DischargeDate";
            public const string DischargeTime = "DischargeTime";
            public const string DischargeMedicalNotes = "DischargeMedicalNotes";
            public const string DischargeNotes = "DischargeNotes";
            public const string SRDischargeCondition = "SRDischargeCondition";
            public const string SRDischargeMethod = "SRDischargeMethod";
            public const string LOSInYear = "LOSInYear";
            public const string LOSInMonth = "LOSInMonth";
            public const string LOSInDay = "LOSInDay";
            public const string DischargeOperatorID = "DischargeOperatorID";
            public const string AccountNo = "AccountNo";
            public const string TransactionAmount = "TransactionAmount";
            public const string AdministrationAmount = "AdministrationAmount";
            public const string RoundingAmount = "RoundingAmount";
            public const string RemainingAmount = "RemainingAmount";
            public const string IsTransferedToInpatient = "IsTransferedToInpatient";
            public const string IsNewPatient = "IsNewPatient";
            public const string IsNewBornInfant = "IsNewBornInfant";
            public const string IsParturition = "IsParturition";
            public const string IsHoldTransactionEntry = "IsHoldTransactionEntry";
            public const string IsHasCorrection = "IsHasCorrection";
            public const string IsEMRValid = "IsEMRValid";
            public const string IsBackDate = "IsBackDate";
            public const string ActualVisitDate = "ActualVisitDate";
            public const string IsVoid = "IsVoid";
            public const string SRVoidReason = "SRVoidReason";
            public const string VoidNotes = "VoidNotes";
            public const string VoidDate = "VoidDate";
            public const string VoidByUserID = "VoidByUserID";
            public const string IsClosed = "IsClosed";
            public const string IsEpisodeComplete = "IsEpisodeComplete";
            public const string IsClusterAssessment = "IsClusterAssessment";
            public const string IsConsul = "IsConsul";
            public const string IsFromDispensary = "IsFromDispensary";
            public const string IsNewVisit = "IsNewVisit";
            public const string Notes = "Notes";
            public const string LastCreateDateTime = "LastCreateDateTime";
            public const string LastCreateUserID = "LastCreateUserID";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string IsDirectPrescriptionReturn = "IsDirectPrescriptionReturn";
            public const string RegistrationQue = "RegistrationQue";
            public const string VisiteRegistrationNo = "VisiteRegistrationNo";
            public const string IsGenerateHL7 = "IsGenerateHL7";
            public const string ReferralName = "ReferralName";
            public const string IsObservation = "IsObservation";
            public const string CauseOfAccident = "CauseOfAccident";
            public const string ReferTo = "ReferTo";
            public const string IsOldCase = "IsOldCase";
            public const string IsDHF = "IsDHF";
            public const string IsEKG = "IsEKG";
            public const string EmrDiagnoseID = "EmrDiagnoseID";
            public const string IsGlobalPlafond = "IsGlobalPlafond";
            public const string FirstResponDate = "FirstResponDate";
            public const string FirstResponTime = "FirstResponTime";
            public const string PhysicianResponDate = "PhysicianResponDate";
            public const string PhysicianResponTime = "PhysicianResponTime";
            public const string IsRoomIn = "IsRoomIn";
            public const string IsLockVerifiedBilling = "IsLockVerifiedBilling";
            public const string LockVerifiedBillingDateTime = "LockVerifiedBillingDateTime";
            public const string LockVerifiedBillingByUserID = "LockVerifiedBillingByUserID";
            public const string ProcedureChargeClassID = "ProcedureChargeClassID";
            public const string PersonID = "PersonID";
            public const string EmployeeNumber = "EmployeeNumber";
            public const string SREmployeeRelationship = "SREmployeeRelationship";
            public const string GuarantorCardNo = "GuarantorCardNo";
            public const string DischargePlanDate = "DischargePlanDate";
            public const string UsertInsertDischargePlan = "UsertInsertDischargePlan";
            public const string IsNonPatient = "IsNonPatient";
            public const string ReasonsForTreatmentID = "ReasonsForTreatmentID";
            public const string SmfID = "SmfID";
            public const string PatientAdm = "PatientAdm";
            public const string GuarantorAdm = "GuarantorAdm";
            public const string ReasonsForTreatmentDescID = "ReasonsForTreatmentDescID";
            public const string SRReferralGroup = "SRReferralGroup";
            public const string SRDiscountReason = "SRDiscountReason";
            public const string PhysicianSenders = "PhysicianSenders";
            public const string DiscAdmPatient = "DiscAdmPatient";
            public const string DiscAdmGuarantor = "DiscAdmGuarantor";
            public const string SRPatientInCondition = "SRPatientInCondition";
            public const string SRKiaCaseType = "SRKiaCaseType";
            public const string SRObstetricType = "SRObstetricType";
            public const string IsHoldTransactionEntryByUserID = "IsHoldTransactionEntryByUserID";
            public const string FromRegistrationNo = "FromRegistrationNo";
            public const string IsConfirmedAttendance = "IsConfirmedAttendance";
            public const string ConfirmedAttendanceByUserID = "ConfirmedAttendanceByUserID";
            public const string ConfirmedAttendanceDateTime = "ConfirmedAttendanceDateTime";
            public const string BpjsSepNo = "BpjsSepNo";
            public const string PlavonAmount2 = "PlavonAmount2";
            public const string DeathCertificateNo = "DeathCertificateNo";
            public const string BpjsCoverageFormula = "BpjsCoverageFormula";
            public const string BpjsPackageID = "BpjsPackageID";
            public const string ApproximatePlafondAmount = "ApproximatePlafondAmount";
            public const string SentToBillingDateTime = "SentToBillingDateTime";
            public const string SentToBillingByUserID = "SentToBillingByUserID";
            public const string IsAdjusted = "IsAdjusted";
            public const string AdjustLog = "AdjustLog";
            public const string IsAllowPatientCheckOut = "IsAllowPatientCheckOut";
            public const string AllowPatientCheckOutDateTime = "AllowPatientCheckOutDateTime";
            public const string AllowPatientCheckOutByUserID = "AllowPatientCheckOutByUserID";
            public const string ReferByParamedicID = "ReferByParamedicID";
            public const string SRMaritalStatus = "SRMaritalStatus";
            public const string SROccupation = "SROccupation";
            public const string SRRelationshipQuality = "SRRelationshipQuality";
            public const string SRResidentialHome = "SRResidentialHome";
            public const string SRFatherOccupation = "SRFatherOccupation";
            public const string IsPregnant = "IsPregnant";
            public const string GestationalAge = "GestationalAge";
            public const string IsBreastFeeding = "IsBreastFeeding";
            public const string AgeOfBabyInYear = "AgeOfBabyInYear";
            public const string AgeOfBabyInMonth = "AgeOfBabyInMonth";
            public const string AgeOfBabyInDay = "AgeOfBabyInDay";
            public const string IsKidneyFunctionImpaired = "IsKidneyFunctionImpaired";
            public const string CreatinineSerumValue = "CreatinineSerumValue";
            public const string Hpi = "Hpi";
            public const string MembershipDetailID = "MembershipDetailID";
            public const string ExternalQueNo = "ExternalQueNo";
            public const string ReferralIdTo = "ReferralIdTo";
            public const string ReferralNameTo = "ReferralNameTo";
            public const string IsReconcile = "IsReconcile";
            public const string IsSkipAutoBill = "IsSkipAutoBill";
            public const string SRCrashSite = "SRCrashSite";
            public const string CrashSiteDetail = "CrashSiteDetail";
            public const string MembershipNo = "MembershipNo";
            public const string IsOpenEntryMR = "IsOpenEntryMR";
            public const string SRCovidStatus = "SRCovidStatus";
            public const string VoucherNo = "VoucherNo";
            public const string SRCovidComorbidStatus = "SRCovidComorbidStatus";
            public const string IsDisability = "IsDisability";
            public const string IsTracer = "IsTracer";
            public const string ItemConditionRuleID = "ItemConditionRuleID";
            public const string SRPatientRiskStatus = "SRPatientRiskStatus";
            public const string IsFinishedAttendance = "IsFinishedAttendance";
            public const string FinishedAttendanceByUserID = "FinishedAttendanceByUserID";
            public const string FinishedAttendanceDateTime = "FinishedAttendanceDateTime";
            public const string IsQueueCalled = "IsQueueCalled";
            public const string IsQueueRecall = "IsQueueRecall";
            public const string QueueCalledDateTime = "QueueCalledDateTime";
            public const string SRQueRoom = "SRQueRoom";
            public const string SRClassification = "SRClassification";
            public const string SRClassificationRoom = "SRClassificationRoom";
            public const string QueueQr = "QueueQr";
            public const string SRPatientRiskColor = "SRPatientRiskColor";
            public const string PatientSign = "PatientSign";
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
            lock (typeof(RegistrationMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new RegistrationMetadata();
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
                meta.AddTypeMap("SRRegistrationType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ParamedicID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("GuarantorID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PatientID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ClassID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("RegistrationDate", new esTypeMap("smalldatetime", "System.DateTime"));
                meta.AddTypeMap("RegistrationTime", new esTypeMap("char", "System.String"));
                meta.AddTypeMap("AppointmentNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("AgeInYear", new esTypeMap("tinyint", "System.Byte"));
                meta.AddTypeMap("AgeInMonth", new esTypeMap("tinyint", "System.Byte"));
                meta.AddTypeMap("AgeInDay", new esTypeMap("tinyint", "System.Byte"));
                meta.AddTypeMap("SRShift", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRPatientInType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("InsuranceID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRPatientCategory", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRERCaseType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRVisitReason", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRBussinesMethod", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PlavonAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("DepartmentID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ServiceUnitID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("RoomID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("BedID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ChargeClassID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CoverageClassID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("VisitTypeID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ReferralID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Anamnesis", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Complaint", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("InitialDiagnose", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("MedicationPlanning", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRTriage", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsPrintingPatientCard", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("DischargeDate", new esTypeMap("smalldatetime", "System.DateTime"));
                meta.AddTypeMap("DischargeTime", new esTypeMap("char", "System.String"));
                meta.AddTypeMap("DischargeMedicalNotes", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("DischargeNotes", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRDischargeCondition", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRDischargeMethod", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LOSInYear", new esTypeMap("tinyint", "System.Byte"));
                meta.AddTypeMap("LOSInMonth", new esTypeMap("tinyint", "System.Byte"));
                meta.AddTypeMap("LOSInDay", new esTypeMap("tinyint", "System.Byte"));
                meta.AddTypeMap("DischargeOperatorID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("AccountNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TransactionAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("AdministrationAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("RoundingAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("RemainingAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("IsTransferedToInpatient", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsNewPatient", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsNewBornInfant", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsParturition", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsHoldTransactionEntry", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsHasCorrection", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsEMRValid", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsBackDate", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ActualVisitDate", new esTypeMap("smalldatetime", "System.DateTime"));
                meta.AddTypeMap("IsVoid", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("SRVoidReason", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("VoidNotes", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("VoidDate", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("VoidByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsClosed", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsEpisodeComplete", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsClusterAssessment", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsConsul", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsFromDispensary", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsNewVisit", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("Notes", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastCreateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastCreateUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsDirectPrescriptionReturn", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("RegistrationQue", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("VisiteRegistrationNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsGenerateHL7", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ReferralName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsObservation", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("CauseOfAccident", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ReferTo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsOldCase", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsDHF", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsEKG", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("EmrDiagnoseID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsGlobalPlafond", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("FirstResponDate", new esTypeMap("smalldatetime", "System.DateTime"));
                meta.AddTypeMap("FirstResponTime", new esTypeMap("char", "System.String"));
                meta.AddTypeMap("PhysicianResponDate", new esTypeMap("smalldatetime", "System.DateTime"));
                meta.AddTypeMap("PhysicianResponTime", new esTypeMap("char", "System.String"));
                meta.AddTypeMap("IsRoomIn", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsLockVerifiedBilling", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("LockVerifiedBillingDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LockVerifiedBillingByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ProcedureChargeClassID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PersonID", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("EmployeeNumber", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SREmployeeRelationship", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("GuarantorCardNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("DischargePlanDate", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("UsertInsertDischargePlan", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsNonPatient", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ReasonsForTreatmentID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SmfID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PatientAdm", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("GuarantorAdm", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("ReasonsForTreatmentDescID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRReferralGroup", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRDiscountReason", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PhysicianSenders", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("DiscAdmPatient", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("DiscAdmGuarantor", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("SRPatientInCondition", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRKiaCaseType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRObstetricType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsHoldTransactionEntryByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("FromRegistrationNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsConfirmedAttendance", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ConfirmedAttendanceByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ConfirmedAttendanceDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("BpjsSepNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PlavonAmount2", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("DeathCertificateNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("BpjsCoverageFormula", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("BpjsPackageID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ApproximatePlafondAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("SentToBillingDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("SentToBillingByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsAdjusted", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("AdjustLog", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsAllowPatientCheckOut", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("AllowPatientCheckOutDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("AllowPatientCheckOutByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ReferByParamedicID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRMaritalStatus", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SROccupation", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRRelationshipQuality", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRResidentialHome", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRFatherOccupation", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsPregnant", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("GestationalAge", new esTypeMap("smallint", "System.Int16"));
                meta.AddTypeMap("IsBreastFeeding", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("AgeOfBabyInYear", new esTypeMap("smallint", "System.Int16"));
                meta.AddTypeMap("AgeOfBabyInMonth", new esTypeMap("smallint", "System.Int16"));
                meta.AddTypeMap("AgeOfBabyInDay", new esTypeMap("smallint", "System.Int16"));
                meta.AddTypeMap("IsKidneyFunctionImpaired", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("CreatinineSerumValue", new esTypeMap("smallint", "System.Int16"));
                meta.AddTypeMap("Hpi", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("MembershipDetailID", new esTypeMap("bigint", "System.Int64"));
                meta.AddTypeMap("ExternalQueNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ReferralIdTo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ReferralNameTo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsReconcile", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsSkipAutoBill", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("SRCrashSite", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CrashSiteDetail", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("MembershipNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsOpenEntryMR", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("SRCovidStatus", new esTypeMap("tinyint", "System.Byte"));
                meta.AddTypeMap("VoucherNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRCovidComorbidStatus", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsDisability", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsTracer", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ItemConditionRuleID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRPatientRiskStatus", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsFinishedAttendance", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("FinishedAttendanceByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("FinishedAttendanceDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("IsQueueCalled", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsQueueRecall", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("QueueCalledDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("SRQueRoom", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRClassification", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRClassificationRoom", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("QueueQr", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRPatientRiskColor", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PatientSign", new esTypeMap("image", "System.Byte[]"));



                meta.Source = "Registration";
                meta.Destination = "Registration";

                meta.spInsert = "proc_RegistrationInsert";
                meta.spUpdate = "proc_RegistrationUpdate";
                meta.spDelete = "proc_RegistrationDelete";
                meta.spLoadAll = "proc_RegistrationLoadAll";
                meta.spLoadByPrimaryKey = "proc_RegistrationLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private RegistrationMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
