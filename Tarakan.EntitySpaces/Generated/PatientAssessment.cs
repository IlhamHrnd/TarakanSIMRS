
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 9/23/2024 2:34:18 PM
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
    /// Encapsulates the 'PatientAssessment' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(PatientAssessment))]
    [XmlType("PatientAssessment")]
    public partial class PatientAssessment : esPatientAssessment
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new PatientAssessment();
        }

        #region Static Quick Access Methods
        static public void Delete(string registrationInfoMedicID)
        {
            var obj = new PatientAssessment();
            obj.RegistrationInfoMedicID = registrationInfoMedicID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string registrationInfoMedicID, esSqlAccessType sqlAccessType)
        {
            var obj = new PatientAssessment();
            obj.RegistrationInfoMedicID = registrationInfoMedicID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("PatientAssessmentCollection")]
    public partial class PatientAssessmentCollection : esPatientAssessmentCollection, IEnumerable<PatientAssessment>
    {
        public PatientAssessment FindByPrimaryKey(string registrationInfoMedicID)
        {
            return this.SingleOrDefault(e => e.RegistrationInfoMedicID == registrationInfoMedicID);
        }



    }



    [Serializable]
    public partial class PatientAssessmentQuery : esPatientAssessmentQuery
    {
        public PatientAssessmentQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public PatientAssessmentQuery(string joinAlias, out PatientAssessmentQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "PatientAssessmentQuery";
        }



        #region Explicit Casts

        public static explicit operator string(PatientAssessmentQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator PatientAssessmentQuery(string query)
        {
            return (PatientAssessmentQuery)SerializeHelper.FromXml(query, typeof(PatientAssessmentQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esPatientAssessment : esEntity
    {
        public esPatientAssessment()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string registrationInfoMedicID)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(registrationInfoMedicID);
            else
                return LoadByPrimaryKeyStoredProcedure(registrationInfoMedicID);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string registrationInfoMedicID)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(registrationInfoMedicID);
            else
                return LoadByPrimaryKeyStoredProcedure(registrationInfoMedicID);
        }

        private bool LoadByPrimaryKeyDynamic(string registrationInfoMedicID)
        {
            PatientAssessmentQuery query = new PatientAssessmentQuery("paQ");
            query.Where(query.RegistrationInfoMedicID == registrationInfoMedicID);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string registrationInfoMedicID)
        {
            esParameters parms = new esParameters();
            parms.Add("RegistrationInfoMedicID", registrationInfoMedicID);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to PatientAssessment.RegistrationInfoMedicID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RegistrationInfoMedicID
        {
            get
            {
                return GetSystemString(PatientAssessmentMetadata.ColumnNames.RegistrationInfoMedicID);
            }

            set
            {
                if (SetSystemString(PatientAssessmentMetadata.ColumnNames.RegistrationInfoMedicID, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.RegistrationInfoMedicID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.PatientID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PatientID
        {
            get
            {
                return GetSystemString(PatientAssessmentMetadata.ColumnNames.PatientID);
            }

            set
            {
                if (SetSystemString(PatientAssessmentMetadata.ColumnNames.PatientID, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.PatientID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.SRAssessmentType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRAssessmentType
        {
            get
            {
                return GetSystemString(PatientAssessmentMetadata.ColumnNames.SRAssessmentType);
            }

            set
            {
                if (SetSystemString(PatientAssessmentMetadata.ColumnNames.SRAssessmentType, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.SRAssessmentType);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.AssessmentDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? AssessmentDateTime
        {
            get
            {
                return GetSystemDateTime(PatientAssessmentMetadata.ColumnNames.AssessmentDateTime);
            }

            set
            {
                if (SetSystemDateTime(PatientAssessmentMetadata.ColumnNames.AssessmentDateTime, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.AssessmentDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.RegistrationNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RegistrationNo
        {
            get
            {
                return GetSystemString(PatientAssessmentMetadata.ColumnNames.RegistrationNo);
            }

            set
            {
                if (SetSystemString(PatientAssessmentMetadata.ColumnNames.RegistrationNo, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.RegistrationNo);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.ServiceUnitID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ServiceUnitID
        {
            get
            {
                return GetSystemString(PatientAssessmentMetadata.ColumnNames.ServiceUnitID);
            }

            set
            {
                if (SetSystemString(PatientAssessmentMetadata.ColumnNames.ServiceUnitID, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.ServiceUnitID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.IsAutoAnamnesis
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsAutoAnamnesis
        {
            get
            {
                return GetSystemBoolean(PatientAssessmentMetadata.ColumnNames.IsAutoAnamnesis);
            }

            set
            {
                if (SetSystemBoolean(PatientAssessmentMetadata.ColumnNames.IsAutoAnamnesis, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.IsAutoAnamnesis);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.AllowAnamnesisSource
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string AllowAnamnesisSource
        {
            get
            {
                return GetSystemString(PatientAssessmentMetadata.ColumnNames.AllowAnamnesisSource);
            }

            set
            {
                if (SetSystemString(PatientAssessmentMetadata.ColumnNames.AllowAnamnesisSource, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.AllowAnamnesisSource);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.Hpi
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Hpi
        {
            get
            {
                return GetSystemString(PatientAssessmentMetadata.ColumnNames.Hpi);
            }

            set
            {
                if (SetSystemString(PatientAssessmentMetadata.ColumnNames.Hpi, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.Hpi);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.Medikamentosa
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Medikamentosa
        {
            get
            {
                return GetSystemString(PatientAssessmentMetadata.ColumnNames.Medikamentosa);
            }

            set
            {
                if (SetSystemString(PatientAssessmentMetadata.ColumnNames.Medikamentosa, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.Medikamentosa);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.ReviewOfSystem
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ReviewOfSystem
        {
            get
            {
                return GetSystemString(PatientAssessmentMetadata.ColumnNames.ReviewOfSystem);
            }

            set
            {
                if (SetSystemString(PatientAssessmentMetadata.ColumnNames.ReviewOfSystem, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.ReviewOfSystem);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.PhysicalExam
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PhysicalExam
        {
            get
            {
                return GetSystemString(PatientAssessmentMetadata.ColumnNames.PhysicalExam);
            }

            set
            {
                if (SetSystemString(PatientAssessmentMetadata.ColumnNames.PhysicalExam, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.PhysicalExam);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.OtherExam
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string OtherExam
        {
            get
            {
                return GetSystemString(PatientAssessmentMetadata.ColumnNames.OtherExam);
            }

            set
            {
                if (SetSystemString(PatientAssessmentMetadata.ColumnNames.OtherExam, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.OtherExam);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.Diagnose
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Diagnose
        {
            get
            {
                return GetSystemString(PatientAssessmentMetadata.ColumnNames.Diagnose);
            }

            set
            {
                if (SetSystemString(PatientAssessmentMetadata.ColumnNames.Diagnose, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.Diagnose);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.Therapy
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Therapy
        {
            get
            {
                return GetSystemString(PatientAssessmentMetadata.ColumnNames.Therapy);
            }

            set
            {
                if (SetSystemString(PatientAssessmentMetadata.ColumnNames.Therapy, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.Therapy);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.Education
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Education
        {
            get
            {
                return GetSystemString(PatientAssessmentMetadata.ColumnNames.Education);
            }

            set
            {
                if (SetSystemString(PatientAssessmentMetadata.ColumnNames.Education, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.Education);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.Genogram
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public byte[] Genogram
        {
            get
            {
                return GetSystemByteArray(PatientAssessmentMetadata.ColumnNames.Genogram);
            }

            set
            {
                if (SetSystemByteArray(PatientAssessmentMetadata.ColumnNames.Genogram, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.Genogram);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.Notes
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Notes
        {
            get
            {
                return GetSystemString(PatientAssessmentMetadata.ColumnNames.Notes);
            }

            set
            {
                if (SetSystemString(PatientAssessmentMetadata.ColumnNames.Notes, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.Notes);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.CreatedByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string CreatedByUserID
        {
            get
            {
                return GetSystemString(PatientAssessmentMetadata.ColumnNames.CreatedByUserID);
            }

            set
            {
                if (SetSystemString(PatientAssessmentMetadata.ColumnNames.CreatedByUserID, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.CreatedByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.CreatedDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? CreatedDateTime
        {
            get
            {
                return GetSystemDateTime(PatientAssessmentMetadata.ColumnNames.CreatedDateTime);
            }

            set
            {
                if (SetSystemDateTime(PatientAssessmentMetadata.ColumnNames.CreatedDateTime, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.CreatedDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(PatientAssessmentMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(PatientAssessmentMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(PatientAssessmentMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(PatientAssessmentMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.AnamnesisNotes
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string AnamnesisNotes
        {
            get
            {
                return GetSystemString(PatientAssessmentMetadata.ColumnNames.AnamnesisNotes);
            }

            set
            {
                if (SetSystemString(PatientAssessmentMetadata.ColumnNames.AnamnesisNotes, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.AnamnesisNotes);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.IsInitialAssessment
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsInitialAssessment
        {
            get
            {
                return GetSystemBoolean(PatientAssessmentMetadata.ColumnNames.IsInitialAssessment);
            }

            set
            {
                if (SetSystemBoolean(PatientAssessmentMetadata.ColumnNames.IsInitialAssessment, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.IsInitialAssessment);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.EstimatedDayInPatient
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? EstimatedDayInPatient
        {
            get
            {
                return GetSystemInt32(PatientAssessmentMetadata.ColumnNames.EstimatedDayInPatient);
            }

            set
            {
                if (SetSystemInt32(PatientAssessmentMetadata.ColumnNames.EstimatedDayInPatient, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.EstimatedDayInPatient);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.Prognosis
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Prognosis
        {
            get
            {
                return GetSystemString(PatientAssessmentMetadata.ColumnNames.Prognosis);
            }

            set
            {
                if (SetSystemString(PatientAssessmentMetadata.ColumnNames.Prognosis, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.Prognosis);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.FollowUpPlanType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string FollowUpPlanType
        {
            get
            {
                return GetSystemString(PatientAssessmentMetadata.ColumnNames.FollowUpPlanType);
            }

            set
            {
                if (SetSystemString(PatientAssessmentMetadata.ColumnNames.FollowUpPlanType, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.FollowUpPlanType);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.ConsulToType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ConsulToType
        {
            get
            {
                return GetSystemString(PatientAssessmentMetadata.ColumnNames.ConsulToType);
            }

            set
            {
                if (SetSystemString(PatientAssessmentMetadata.ColumnNames.ConsulToType, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.ConsulToType);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.ConsulTo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ConsulTo
        {
            get
            {
                return GetSystemString(PatientAssessmentMetadata.ColumnNames.ConsulTo);
            }

            set
            {
                if (SetSystemString(PatientAssessmentMetadata.ColumnNames.ConsulTo, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.ConsulTo);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.InpatientIndication
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string InpatientIndication
        {
            get
            {
                return GetSystemString(PatientAssessmentMetadata.ColumnNames.InpatientIndication);
            }

            set
            {
                if (SetSystemString(PatientAssessmentMetadata.ColumnNames.InpatientIndication, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.InpatientIndication);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.ControlPlan
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ControlPlan
        {
            get
            {
                return GetSystemString(PatientAssessmentMetadata.ColumnNames.ControlPlan);
            }

            set
            {
                if (SetSystemString(PatientAssessmentMetadata.ColumnNames.ControlPlan, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.ControlPlan);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.JobHistNotes
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string JobHistNotes
        {
            get
            {
                return GetSystemString(PatientAssessmentMetadata.ColumnNames.JobHistNotes);
            }

            set
            {
                if (SetSystemString(PatientAssessmentMetadata.ColumnNames.JobHistNotes, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.JobHistNotes);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.HighRiskCriteria
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string HighRiskCriteria
        {
            get
            {
                return GetSystemString(PatientAssessmentMetadata.ColumnNames.HighRiskCriteria);
            }

            set
            {
                if (SetSystemString(PatientAssessmentMetadata.ColumnNames.HighRiskCriteria, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.HighRiskCriteria);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.ConsultDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? ConsultDate
        {
            get
            {
                return GetSystemDateTime(PatientAssessmentMetadata.ColumnNames.ConsultDate);
            }

            set
            {
                if (SetSystemDateTime(PatientAssessmentMetadata.ColumnNames.ConsultDate, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.ConsultDate);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.ReferToHospital
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ReferToHospital
        {
            get
            {
                return GetSystemString(PatientAssessmentMetadata.ColumnNames.ReferToHospital);
            }

            set
            {
                if (SetSystemString(PatientAssessmentMetadata.ColumnNames.ReferToHospital, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.ReferToHospital);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.ReferToFamilyDoctor
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ReferToFamilyDoctor
        {
            get
            {
                return GetSystemString(PatientAssessmentMetadata.ColumnNames.ReferToFamilyDoctor);
            }

            set
            {
                if (SetSystemString(PatientAssessmentMetadata.ColumnNames.ReferToFamilyDoctor, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.ReferToFamilyDoctor);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.RoomInPatient
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RoomInPatient
        {
            get
            {
                return GetSystemString(PatientAssessmentMetadata.ColumnNames.RoomInPatient);
            }

            set
            {
                if (SetSystemString(PatientAssessmentMetadata.ColumnNames.RoomInPatient, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.RoomInPatient);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.DpjpInPatient
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DpjpInPatient
        {
            get
            {
                return GetSystemString(PatientAssessmentMetadata.ColumnNames.DpjpInPatient);
            }

            set
            {
                if (SetSystemString(PatientAssessmentMetadata.ColumnNames.DpjpInPatient, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.DpjpInPatient);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.IsInPatientGuide
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsInPatientGuide
        {
            get
            {
                return GetSystemBoolean(PatientAssessmentMetadata.ColumnNames.IsInPatientGuide);
            }

            set
            {
                if (SetSystemBoolean(PatientAssessmentMetadata.ColumnNames.IsInPatientGuide, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.IsInPatientGuide);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.PatientEducationSeqNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? PatientEducationSeqNo
        {
            get
            {
                return GetSystemInt32(PatientAssessmentMetadata.ColumnNames.PatientEducationSeqNo);
            }

            set
            {
                if (SetSystemInt32(PatientAssessmentMetadata.ColumnNames.PatientEducationSeqNo, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.PatientEducationSeqNo);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.DischargeDatePlan
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? DischargeDatePlan
        {
            get
            {
                return GetSystemDateTime(PatientAssessmentMetadata.ColumnNames.DischargeDatePlan);
            }

            set
            {
                if (SetSystemDateTime(PatientAssessmentMetadata.ColumnNames.DischargeDatePlan, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.DischargeDatePlan);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.DischargeMedicalPlan
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DischargeMedicalPlan
        {
            get
            {
                return GetSystemString(PatientAssessmentMetadata.ColumnNames.DischargeMedicalPlan);
            }

            set
            {
                if (SetSystemString(PatientAssessmentMetadata.ColumnNames.DischargeMedicalPlan, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.DischargeMedicalPlan);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.DoaDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? DoaDateTime
        {
            get
            {
                return GetSystemDateTime(PatientAssessmentMetadata.ColumnNames.DoaDateTime);
            }

            set
            {
                if (SetSystemDateTime(PatientAssessmentMetadata.ColumnNames.DoaDateTime, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.DoaDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.SurgicalDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? SurgicalDateTime
        {
            get
            {
                return GetSystemDateTime(PatientAssessmentMetadata.ColumnNames.SurgicalDateTime);
            }

            set
            {
                if (SetSystemDateTime(PatientAssessmentMetadata.ColumnNames.SurgicalDateTime, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.SurgicalDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.InPatientRejectReason
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string InPatientRejectReason
        {
            get
            {
                return GetSystemString(PatientAssessmentMetadata.ColumnNames.InPatientRejectReason);
            }

            set
            {
                if (SetSystemString(PatientAssessmentMetadata.ColumnNames.InPatientRejectReason, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.InPatientRejectReason);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.ReferReason
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ReferReason
        {
            get
            {
                return GetSystemString(PatientAssessmentMetadata.ColumnNames.ReferReason);
            }

            set
            {
                if (SetSystemString(PatientAssessmentMetadata.ColumnNames.ReferReason, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.ReferReason);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.IsDeleted
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsDeleted
        {
            get
            {
                return GetSystemBoolean(PatientAssessmentMetadata.ColumnNames.IsDeleted);
            }

            set
            {
                if (SetSystemBoolean(PatientAssessmentMetadata.ColumnNames.IsDeleted, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.IsDeleted);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.Photo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public byte[] Photo
        {
            get
            {
                return GetSystemByteArray(PatientAssessmentMetadata.ColumnNames.Photo);
            }

            set
            {
                if (SetSystemByteArray(PatientAssessmentMetadata.ColumnNames.Photo, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.Photo);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.AdditionalNotes
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string AdditionalNotes
        {
            get
            {
                return GetSystemString(PatientAssessmentMetadata.ColumnNames.AdditionalNotes);
            }

            set
            {
                if (SetSystemString(PatientAssessmentMetadata.ColumnNames.AdditionalNotes, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.AdditionalNotes);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.DpjpInPatientID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DpjpInPatientID
        {
            get
            {
                return GetSystemString(PatientAssessmentMetadata.ColumnNames.DpjpInPatientID);
            }

            set
            {
                if (SetSystemString(PatientAssessmentMetadata.ColumnNames.DpjpInPatientID, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.DpjpInPatientID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.SignImg
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public byte[] SignImg
        {
            get
            {
                return GetSystemByteArray(PatientAssessmentMetadata.ColumnNames.SignImg);
            }

            set
            {
                if (SetSystemByteArray(PatientAssessmentMetadata.ColumnNames.SignImg, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.SignImg);
                }
            }
        }

        /// <summary>
        /// Maps to PatientAssessment.PatientSignImg
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public byte[] PatientSignImg
        {
            get
            {
                return GetSystemByteArray(PatientAssessmentMetadata.ColumnNames.PatientSignImg);
            }

            set
            {
                if (SetSystemByteArray(PatientAssessmentMetadata.ColumnNames.PatientSignImg, value))
                {
                    OnPropertyChanged(PatientAssessmentMetadata.PropertyNames.PatientSignImg);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return PatientAssessmentMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public PatientAssessmentQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new PatientAssessmentQuery("paQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(PatientAssessmentQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(PatientAssessmentQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((PatientAssessmentQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private PatientAssessmentQuery query;
    }



    [Serializable]
    abstract public partial class esPatientAssessmentCollection : esEntityCollection<PatientAssessment>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return PatientAssessmentMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "PatientAssessmentCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public PatientAssessmentQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new PatientAssessmentQuery("paQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(PatientAssessmentQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new PatientAssessmentQuery("paQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(PatientAssessmentQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((PatientAssessmentQuery)query);
        }

        #endregion

        private PatientAssessmentQuery query;
    }



    [Serializable]
    abstract public partial class esPatientAssessmentQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return PatientAssessmentMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "RegistrationInfoMedicID": return RegistrationInfoMedicID;
                case "PatientID": return PatientID;
                case "SRAssessmentType": return SRAssessmentType;
                case "AssessmentDateTime": return AssessmentDateTime;
                case "RegistrationNo": return RegistrationNo;
                case "ServiceUnitID": return ServiceUnitID;
                case "IsAutoAnamnesis": return IsAutoAnamnesis;
                case "AllowAnamnesisSource": return AllowAnamnesisSource;
                case "Hpi": return Hpi;
                case "Medikamentosa": return Medikamentosa;
                case "ReviewOfSystem": return ReviewOfSystem;
                case "PhysicalExam": return PhysicalExam;
                case "OtherExam": return OtherExam;
                case "Diagnose": return Diagnose;
                case "Therapy": return Therapy;
                case "Education": return Education;
                case "Genogram": return Genogram;
                case "Notes": return Notes;
                case "CreatedByUserID": return CreatedByUserID;
                case "CreatedDateTime": return CreatedDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "AnamnesisNotes": return AnamnesisNotes;
                case "IsInitialAssessment": return IsInitialAssessment;
                case "EstimatedDayInPatient": return EstimatedDayInPatient;
                case "Prognosis": return Prognosis;
                case "FollowUpPlanType": return FollowUpPlanType;
                case "ConsulToType": return ConsulToType;
                case "ConsulTo": return ConsulTo;
                case "InpatientIndication": return InpatientIndication;
                case "ControlPlan": return ControlPlan;
                case "JobHistNotes": return JobHistNotes;
                case "HighRiskCriteria": return HighRiskCriteria;
                case "ConsultDate": return ConsultDate;
                case "ReferToHospital": return ReferToHospital;
                case "ReferToFamilyDoctor": return ReferToFamilyDoctor;
                case "RoomInPatient": return RoomInPatient;
                case "DpjpInPatient": return DpjpInPatient;
                case "IsInPatientGuide": return IsInPatientGuide;
                case "PatientEducationSeqNo": return PatientEducationSeqNo;
                case "DischargeDatePlan": return DischargeDatePlan;
                case "DischargeMedicalPlan": return DischargeMedicalPlan;
                case "DoaDateTime": return DoaDateTime;
                case "SurgicalDateTime": return SurgicalDateTime;
                case "InPatientRejectReason": return InPatientRejectReason;
                case "ReferReason": return ReferReason;
                case "IsDeleted": return IsDeleted;
                case "Photo": return Photo;
                case "AdditionalNotes": return AdditionalNotes;
                case "DpjpInPatientID": return DpjpInPatientID;
                case "SignImg": return SignImg;
                case "PatientSignImg": return PatientSignImg;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem RegistrationInfoMedicID
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.RegistrationInfoMedicID, esSystemType.String); }
        }

        public esQueryItem PatientID
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.PatientID, esSystemType.String); }
        }

        public esQueryItem SRAssessmentType
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.SRAssessmentType, esSystemType.String); }
        }

        public esQueryItem AssessmentDateTime
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.AssessmentDateTime, esSystemType.DateTime); }
        }

        public esQueryItem RegistrationNo
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.RegistrationNo, esSystemType.String); }
        }

        public esQueryItem ServiceUnitID
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.ServiceUnitID, esSystemType.String); }
        }

        public esQueryItem IsAutoAnamnesis
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.IsAutoAnamnesis, esSystemType.Boolean); }
        }

        public esQueryItem AllowAnamnesisSource
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.AllowAnamnesisSource, esSystemType.String); }
        }

        public esQueryItem Hpi
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.Hpi, esSystemType.String); }
        }

        public esQueryItem Medikamentosa
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.Medikamentosa, esSystemType.String); }
        }

        public esQueryItem ReviewOfSystem
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.ReviewOfSystem, esSystemType.String); }
        }

        public esQueryItem PhysicalExam
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.PhysicalExam, esSystemType.String); }
        }

        public esQueryItem OtherExam
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.OtherExam, esSystemType.String); }
        }

        public esQueryItem Diagnose
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.Diagnose, esSystemType.String); }
        }

        public esQueryItem Therapy
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.Therapy, esSystemType.String); }
        }

        public esQueryItem Education
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.Education, esSystemType.String); }
        }

        public esQueryItem Genogram
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.Genogram, esSystemType.ByteArray); }
        }

        public esQueryItem Notes
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.Notes, esSystemType.String); }
        }

        public esQueryItem CreatedByUserID
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.CreatedByUserID, esSystemType.String); }
        }

        public esQueryItem CreatedDateTime
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.CreatedDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem AnamnesisNotes
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.AnamnesisNotes, esSystemType.String); }
        }

        public esQueryItem IsInitialAssessment
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.IsInitialAssessment, esSystemType.Boolean); }
        }

        public esQueryItem EstimatedDayInPatient
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.EstimatedDayInPatient, esSystemType.Int32); }
        }

        public esQueryItem Prognosis
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.Prognosis, esSystemType.String); }
        }

        public esQueryItem FollowUpPlanType
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.FollowUpPlanType, esSystemType.String); }
        }

        public esQueryItem ConsulToType
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.ConsulToType, esSystemType.String); }
        }

        public esQueryItem ConsulTo
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.ConsulTo, esSystemType.String); }
        }

        public esQueryItem InpatientIndication
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.InpatientIndication, esSystemType.String); }
        }

        public esQueryItem ControlPlan
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.ControlPlan, esSystemType.String); }
        }

        public esQueryItem JobHistNotes
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.JobHistNotes, esSystemType.String); }
        }

        public esQueryItem HighRiskCriteria
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.HighRiskCriteria, esSystemType.String); }
        }

        public esQueryItem ConsultDate
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.ConsultDate, esSystemType.DateTime); }
        }

        public esQueryItem ReferToHospital
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.ReferToHospital, esSystemType.String); }
        }

        public esQueryItem ReferToFamilyDoctor
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.ReferToFamilyDoctor, esSystemType.String); }
        }

        public esQueryItem RoomInPatient
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.RoomInPatient, esSystemType.String); }
        }

        public esQueryItem DpjpInPatient
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.DpjpInPatient, esSystemType.String); }
        }

        public esQueryItem IsInPatientGuide
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.IsInPatientGuide, esSystemType.Boolean); }
        }

        public esQueryItem PatientEducationSeqNo
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.PatientEducationSeqNo, esSystemType.Int32); }
        }

        public esQueryItem DischargeDatePlan
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.DischargeDatePlan, esSystemType.DateTime); }
        }

        public esQueryItem DischargeMedicalPlan
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.DischargeMedicalPlan, esSystemType.String); }
        }

        public esQueryItem DoaDateTime
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.DoaDateTime, esSystemType.DateTime); }
        }

        public esQueryItem SurgicalDateTime
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.SurgicalDateTime, esSystemType.DateTime); }
        }

        public esQueryItem InPatientRejectReason
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.InPatientRejectReason, esSystemType.String); }
        }

        public esQueryItem ReferReason
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.ReferReason, esSystemType.String); }
        }

        public esQueryItem IsDeleted
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.IsDeleted, esSystemType.Boolean); }
        }

        public esQueryItem Photo
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.Photo, esSystemType.ByteArray); }
        }

        public esQueryItem AdditionalNotes
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.AdditionalNotes, esSystemType.String); }
        }

        public esQueryItem DpjpInPatientID
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.DpjpInPatientID, esSystemType.String); }
        }

        public esQueryItem SignImg
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.SignImg, esSystemType.ByteArray); }
        }

        public esQueryItem PatientSignImg
        {
            get { return new esQueryItem(this, PatientAssessmentMetadata.ColumnNames.PatientSignImg, esSystemType.ByteArray); }
        }

        #endregion

    }



    [Serializable]
    public partial class PatientAssessmentMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected PatientAssessmentMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.RegistrationInfoMedicID, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RegistrationInfoMedicID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 20;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PatientID, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PatientID;
            c.CharacterMaxLength = 15;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRAssessmentType, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRAssessmentType;
            c.CharacterMaxLength = 5;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AssessmentDateTime, 3, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.AssessmentDateTime;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RegistrationNo, 4, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RegistrationNo;
            c.CharacterMaxLength = 20;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ServiceUnitID, 5, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ServiceUnitID;
            c.CharacterMaxLength = 10;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsAutoAnamnesis, 6, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsAutoAnamnesis;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AllowAnamnesisSource, 7, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.AllowAnamnesisSource;
            c.CharacterMaxLength = 200;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Hpi, 8, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Hpi;
            c.CharacterMaxLength = 8000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Medikamentosa, 9, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Medikamentosa;
            c.CharacterMaxLength = 8000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ReviewOfSystem, 10, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ReviewOfSystem;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PhysicalExam, 11, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PhysicalExam;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.OtherExam, 12, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.OtherExam;
            c.CharacterMaxLength = 8000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Diagnose, 13, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Diagnose;
            c.CharacterMaxLength = 8000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Therapy, 14, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Therapy;
            c.CharacterMaxLength = 8000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Education, 15, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Education;
            c.CharacterMaxLength = 8000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Genogram, 16, typeof(byte[]), esSystemType.ByteArray);
            c.PropertyName = PropertyNames.Genogram;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Notes, 17, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Notes;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreatedByUserID, 18, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.CreatedByUserID;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreatedDateTime, 19, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.CreatedDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 20, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 21, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AnamnesisNotes, 22, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.AnamnesisNotes;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsInitialAssessment, 23, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsInitialAssessment;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.EstimatedDayInPatient, 24, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.EstimatedDayInPatient;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Prognosis, 25, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Prognosis;
            c.CharacterMaxLength = 8000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FollowUpPlanType, 26, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.FollowUpPlanType;
            c.CharacterMaxLength = 3;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ConsulToType, 27, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ConsulToType;
            c.CharacterMaxLength = 3;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ConsulTo, 28, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ConsulTo;
            c.CharacterMaxLength = 200;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.InpatientIndication, 29, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.InpatientIndication;
            c.CharacterMaxLength = 500;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ControlPlan, 30, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ControlPlan;
            c.CharacterMaxLength = 200;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.JobHistNotes, 31, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.JobHistNotes;
            c.CharacterMaxLength = 500;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.HighRiskCriteria, 32, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.HighRiskCriteria;
            c.CharacterMaxLength = 8000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ConsultDate, 33, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.ConsultDate;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ReferToHospital, 34, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ReferToHospital;
            c.CharacterMaxLength = 200;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ReferToFamilyDoctor, 35, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ReferToFamilyDoctor;
            c.CharacterMaxLength = 200;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RoomInPatient, 36, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RoomInPatient;
            c.CharacterMaxLength = 200;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DpjpInPatient, 37, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DpjpInPatient;
            c.CharacterMaxLength = 200;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsInPatientGuide, 38, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsInPatientGuide;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PatientEducationSeqNo, 39, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.PatientEducationSeqNo;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DischargeDatePlan, 40, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.DischargeDatePlan;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DischargeMedicalPlan, 41, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DischargeMedicalPlan;
            c.CharacterMaxLength = 8000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DoaDateTime, 42, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.DoaDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SurgicalDateTime, 43, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.SurgicalDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.InPatientRejectReason, 44, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.InPatientRejectReason;
            c.CharacterMaxLength = 500;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ReferReason, 45, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ReferReason;
            c.CharacterMaxLength = 500;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsDeleted, 46, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsDeleted;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Photo, 47, typeof(byte[]), esSystemType.ByteArray);
            c.PropertyName = PropertyNames.Photo;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AdditionalNotes, 48, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.AdditionalNotes;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DpjpInPatientID, 49, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DpjpInPatientID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SignImg, 50, typeof(byte[]), esSystemType.ByteArray);
            c.PropertyName = PropertyNames.SignImg;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PatientSignImg, 51, typeof(byte[]), esSystemType.ByteArray);
            c.PropertyName = PropertyNames.PatientSignImg;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public PatientAssessmentMetadata Meta()
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
            public const string RegistrationInfoMedicID = "RegistrationInfoMedicID";
            public const string PatientID = "PatientID";
            public const string SRAssessmentType = "SRAssessmentType";
            public const string AssessmentDateTime = "AssessmentDateTime";
            public const string RegistrationNo = "RegistrationNo";
            public const string ServiceUnitID = "ServiceUnitID";
            public const string IsAutoAnamnesis = "IsAutoAnamnesis";
            public const string AllowAnamnesisSource = "AllowAnamnesisSource";
            public const string Hpi = "Hpi";
            public const string Medikamentosa = "Medikamentosa";
            public const string ReviewOfSystem = "ReviewOfSystem";
            public const string PhysicalExam = "PhysicalExam";
            public const string OtherExam = "OtherExam";
            public const string Diagnose = "Diagnose";
            public const string Therapy = "Therapy";
            public const string Education = "Education";
            public const string Genogram = "Genogram";
            public const string Notes = "Notes";
            public const string CreatedByUserID = "CreatedByUserID";
            public const string CreatedDateTime = "CreatedDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string AnamnesisNotes = "AnamnesisNotes";
            public const string IsInitialAssessment = "IsInitialAssessment";
            public const string EstimatedDayInPatient = "EstimatedDayInPatient";
            public const string Prognosis = "Prognosis";
            public const string FollowUpPlanType = "FollowUpPlanType";
            public const string ConsulToType = "ConsulToType";
            public const string ConsulTo = "ConsulTo";
            public const string InpatientIndication = "InpatientIndication";
            public const string ControlPlan = "ControlPlan";
            public const string JobHistNotes = "JobHistNotes";
            public const string HighRiskCriteria = "HighRiskCriteria";
            public const string ConsultDate = "ConsultDate";
            public const string ReferToHospital = "ReferToHospital";
            public const string ReferToFamilyDoctor = "ReferToFamilyDoctor";
            public const string RoomInPatient = "RoomInPatient";
            public const string DpjpInPatient = "DpjpInPatient";
            public const string IsInPatientGuide = "IsInPatientGuide";
            public const string PatientEducationSeqNo = "PatientEducationSeqNo";
            public const string DischargeDatePlan = "DischargeDatePlan";
            public const string DischargeMedicalPlan = "DischargeMedicalPlan";
            public const string DoaDateTime = "DoaDateTime";
            public const string SurgicalDateTime = "SurgicalDateTime";
            public const string InPatientRejectReason = "InPatientRejectReason";
            public const string ReferReason = "ReferReason";
            public const string IsDeleted = "IsDeleted";
            public const string Photo = "Photo";
            public const string AdditionalNotes = "AdditionalNotes";
            public const string DpjpInPatientID = "DpjpInPatientID";
            public const string SignImg = "SignImg";
            public const string PatientSignImg = "PatientSignImg";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string RegistrationInfoMedicID = "RegistrationInfoMedicID";
            public const string PatientID = "PatientID";
            public const string SRAssessmentType = "SRAssessmentType";
            public const string AssessmentDateTime = "AssessmentDateTime";
            public const string RegistrationNo = "RegistrationNo";
            public const string ServiceUnitID = "ServiceUnitID";
            public const string IsAutoAnamnesis = "IsAutoAnamnesis";
            public const string AllowAnamnesisSource = "AllowAnamnesisSource";
            public const string Hpi = "Hpi";
            public const string Medikamentosa = "Medikamentosa";
            public const string ReviewOfSystem = "ReviewOfSystem";
            public const string PhysicalExam = "PhysicalExam";
            public const string OtherExam = "OtherExam";
            public const string Diagnose = "Diagnose";
            public const string Therapy = "Therapy";
            public const string Education = "Education";
            public const string Genogram = "Genogram";
            public const string Notes = "Notes";
            public const string CreatedByUserID = "CreatedByUserID";
            public const string CreatedDateTime = "CreatedDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string AnamnesisNotes = "AnamnesisNotes";
            public const string IsInitialAssessment = "IsInitialAssessment";
            public const string EstimatedDayInPatient = "EstimatedDayInPatient";
            public const string Prognosis = "Prognosis";
            public const string FollowUpPlanType = "FollowUpPlanType";
            public const string ConsulToType = "ConsulToType";
            public const string ConsulTo = "ConsulTo";
            public const string InpatientIndication = "InpatientIndication";
            public const string ControlPlan = "ControlPlan";
            public const string JobHistNotes = "JobHistNotes";
            public const string HighRiskCriteria = "HighRiskCriteria";
            public const string ConsultDate = "ConsultDate";
            public const string ReferToHospital = "ReferToHospital";
            public const string ReferToFamilyDoctor = "ReferToFamilyDoctor";
            public const string RoomInPatient = "RoomInPatient";
            public const string DpjpInPatient = "DpjpInPatient";
            public const string IsInPatientGuide = "IsInPatientGuide";
            public const string PatientEducationSeqNo = "PatientEducationSeqNo";
            public const string DischargeDatePlan = "DischargeDatePlan";
            public const string DischargeMedicalPlan = "DischargeMedicalPlan";
            public const string DoaDateTime = "DoaDateTime";
            public const string SurgicalDateTime = "SurgicalDateTime";
            public const string InPatientRejectReason = "InPatientRejectReason";
            public const string ReferReason = "ReferReason";
            public const string IsDeleted = "IsDeleted";
            public const string Photo = "Photo";
            public const string AdditionalNotes = "AdditionalNotes";
            public const string DpjpInPatientID = "DpjpInPatientID";
            public const string SignImg = "SignImg";
            public const string PatientSignImg = "PatientSignImg";
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
            lock (typeof(PatientAssessmentMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new PatientAssessmentMetadata();
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


                meta.AddTypeMap("RegistrationInfoMedicID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PatientID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRAssessmentType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("AssessmentDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("RegistrationNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ServiceUnitID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsAutoAnamnesis", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("AllowAnamnesisSource", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Hpi", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Medikamentosa", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ReviewOfSystem", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PhysicalExam", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("OtherExam", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Diagnose", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Therapy", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Education", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Genogram", new esTypeMap("image", "System.Byte[]"));
                meta.AddTypeMap("Notes", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CreatedByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CreatedDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("AnamnesisNotes", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsInitialAssessment", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("EstimatedDayInPatient", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("Prognosis", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("FollowUpPlanType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ConsulToType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ConsulTo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("InpatientIndication", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ControlPlan", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("JobHistNotes", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("HighRiskCriteria", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ConsultDate", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("ReferToHospital", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ReferToFamilyDoctor", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("RoomInPatient", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("DpjpInPatient", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsInPatientGuide", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("PatientEducationSeqNo", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("DischargeDatePlan", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("DischargeMedicalPlan", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("DoaDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("SurgicalDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("InPatientRejectReason", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ReferReason", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsDeleted", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("Photo", new esTypeMap("image", "System.Byte[]"));
                meta.AddTypeMap("AdditionalNotes", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("DpjpInPatientID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SignImg", new esTypeMap("image", "System.Byte[]"));
                meta.AddTypeMap("PatientSignImg", new esTypeMap("image", "System.Byte[]"));



                meta.Source = "PatientAssessment";
                meta.Destination = "PatientAssessment";

                meta.spInsert = "proc_PatientAssessmentInsert";
                meta.spUpdate = "proc_PatientAssessmentUpdate";
                meta.spDelete = "proc_PatientAssessmentDelete";
                meta.spLoadAll = "proc_PatientAssessmentLoadAll";
                meta.spLoadByPrimaryKey = "proc_PatientAssessmentLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private PatientAssessmentMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
