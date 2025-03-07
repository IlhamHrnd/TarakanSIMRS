
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 9/18/2024 4:24:04 PM
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
    /// Encapsulates the 'Patient' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(Patient))]
    [XmlType("Patient")]
    public partial class Patient : esPatient
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new Patient();
        }

        #region Static Quick Access Methods
        static public void Delete(string patientID)
        {
            var obj = new Patient();
            obj.PatientID = patientID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string patientID, esSqlAccessType sqlAccessType)
        {
            var obj = new Patient();
            obj.PatientID = patientID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("PatientCollection")]
    public partial class PatientCollection : esPatientCollection, IEnumerable<Patient>
    {
        public Patient FindByPrimaryKey(string patientID)
        {
            return this.SingleOrDefault(e => e.PatientID == patientID);
        }



    }



    [Serializable]
    public partial class PatientQuery : esPatientQuery
    {
        public PatientQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public PatientQuery(string joinAlias, out PatientQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "PatientQuery";
        }



        #region Explicit Casts

        public static explicit operator string(PatientQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator PatientQuery(string query)
        {
            return (PatientQuery)SerializeHelper.FromXml(query, typeof(PatientQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esPatient : esEntity
    {
        public esPatient()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string patientID)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(patientID);
            else
                return LoadByPrimaryKeyStoredProcedure(patientID);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string patientID)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(patientID);
            else
                return LoadByPrimaryKeyStoredProcedure(patientID);
        }

        private bool LoadByPrimaryKeyDynamic(string patientID)
        {
            PatientQuery query = new PatientQuery("pQ");
            query.Where(query.PatientID == patientID);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string patientID)
        {
            esParameters parms = new esParameters();
            parms.Add("PatientID", patientID);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to Patient.PatientID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PatientID
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.PatientID);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.PatientID, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.PatientID);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.MedicalNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string MedicalNo
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.MedicalNo);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.MedicalNo, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.MedicalNo);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.Ssn
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Ssn
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.Ssn);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.Ssn, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.Ssn);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.SRSalutation
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRSalutation
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.SRSalutation);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.SRSalutation, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.SRSalutation);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.FirstName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string FirstName
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.FirstName);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.FirstName, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.FirstName);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.MiddleName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string MiddleName
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.MiddleName);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.MiddleName, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.MiddleName);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.LastName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastName
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.LastName);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.LastName, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.LastName);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.ParentSpouseName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParentSpouseName
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.ParentSpouseName);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.ParentSpouseName, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.ParentSpouseName);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.CityOfBirth
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string CityOfBirth
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.CityOfBirth);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.CityOfBirth, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.CityOfBirth);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.DateOfBirth
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? DateOfBirth
        {
            get
            {
                return GetSystemDateTime(PatientMetadata.ColumnNames.DateOfBirth);
            }

            set
            {
                if (SetSystemDateTime(PatientMetadata.ColumnNames.DateOfBirth, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.DateOfBirth);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.Sex
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public char? Sex
        {
            get
            {
                return GetSystemChar(PatientMetadata.ColumnNames.Sex);
            }

            set
            {
                if (SetSystemChar(PatientMetadata.ColumnNames.Sex, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.Sex);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.SRBloodType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRBloodType
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.SRBloodType);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.SRBloodType, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.SRBloodType);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.BloodRhesus
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public char? BloodRhesus
        {
            get
            {
                return GetSystemChar(PatientMetadata.ColumnNames.BloodRhesus);
            }

            set
            {
                if (SetSystemChar(PatientMetadata.ColumnNames.BloodRhesus, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.BloodRhesus);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.SREthnic
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SREthnic
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.SREthnic);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.SREthnic, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.SREthnic);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.SREducation
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SREducation
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.SREducation);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.SREducation, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.SREducation);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.SRMaritalStatus
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRMaritalStatus
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.SRMaritalStatus);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.SRMaritalStatus, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.SRMaritalStatus);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.SRNationality
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRNationality
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.SRNationality);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.SRNationality, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.SRNationality);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.SROccupation
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SROccupation
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.SROccupation);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.SROccupation, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.SROccupation);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.SRTitle
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRTitle
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.SRTitle);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.SRTitle, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.SRTitle);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.SRPatientCategory
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRPatientCategory
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.SRPatientCategory);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.SRPatientCategory, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.SRPatientCategory);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.SRReligion
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRReligion
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.SRReligion);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.SRReligion, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.SRReligion);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.SRMedicalFileBin
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRMedicalFileBin
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.SRMedicalFileBin);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.SRMedicalFileBin, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.SRMedicalFileBin);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.SRMedicalFileStatus
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRMedicalFileStatus
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.SRMedicalFileStatus);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.SRMedicalFileStatus, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.SRMedicalFileStatus);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.GuarantorID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string GuarantorID
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.GuarantorID);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.GuarantorID, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.GuarantorID);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.Company
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Company
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.Company);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.Company, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.Company);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.StreetName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string StreetName
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.StreetName);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.StreetName, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.StreetName);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.District
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string District
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.District);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.District, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.District);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.City
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string City
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.City);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.City, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.City);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.County
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string County
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.County);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.County, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.County);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.State
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string State
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.State);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.State, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.State);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.ZipCode
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ZipCode
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.ZipCode);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.ZipCode, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.ZipCode);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.PhoneNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PhoneNo
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.PhoneNo);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.PhoneNo, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.PhoneNo);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.FaxNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string FaxNo
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.FaxNo);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.FaxNo, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.FaxNo);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.Email
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Email
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.Email);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.Email, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.Email);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.MobilePhoneNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string MobilePhoneNo
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.MobilePhoneNo);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.MobilePhoneNo, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.MobilePhoneNo);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.TempAddressStreetName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TempAddressStreetName
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.TempAddressStreetName);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.TempAddressStreetName, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.TempAddressStreetName);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.TempAddressDistrict
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TempAddressDistrict
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.TempAddressDistrict);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.TempAddressDistrict, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.TempAddressDistrict);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.TempAddressCity
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TempAddressCity
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.TempAddressCity);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.TempAddressCity, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.TempAddressCity);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.TempAddressCounty
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TempAddressCounty
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.TempAddressCounty);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.TempAddressCounty, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.TempAddressCounty);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.TempAddressState
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TempAddressState
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.TempAddressState);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.TempAddressState, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.TempAddressState);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.TempAddressZipCode
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TempAddressZipCode
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.TempAddressZipCode);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.TempAddressZipCode, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.TempAddressZipCode);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.TempAddressPhoneNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TempAddressPhoneNo
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.TempAddressPhoneNo);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.TempAddressPhoneNo, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.TempAddressPhoneNo);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.LastVisitDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastVisitDate
        {
            get
            {
                return GetSystemDateTime(PatientMetadata.ColumnNames.LastVisitDate);
            }

            set
            {
                if (SetSystemDateTime(PatientMetadata.ColumnNames.LastVisitDate, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.LastVisitDate);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.NumberOfVisit
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public byte? NumberOfVisit
        {
            get
            {
                return GetSystemByte(PatientMetadata.ColumnNames.NumberOfVisit);
            }

            set
            {
                if (SetSystemByte(PatientMetadata.ColumnNames.NumberOfVisit, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.NumberOfVisit);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.OldMedicalNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string OldMedicalNo
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.OldMedicalNo);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.OldMedicalNo, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.OldMedicalNo);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.AccountNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string AccountNo
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.AccountNo);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.AccountNo, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.AccountNo);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.PictureFileName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PictureFileName
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.PictureFileName);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.PictureFileName, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.PictureFileName);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.IsDonor
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsDonor
        {
            get
            {
                return GetSystemBoolean(PatientMetadata.ColumnNames.IsDonor);
            }

            set
            {
                if (SetSystemBoolean(PatientMetadata.ColumnNames.IsDonor, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.IsDonor);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.NumberOfDonor
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? NumberOfDonor
        {
            get
            {
                return GetSystemDecimal(PatientMetadata.ColumnNames.NumberOfDonor);
            }

            set
            {
                if (SetSystemDecimal(PatientMetadata.ColumnNames.NumberOfDonor, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.NumberOfDonor);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.LastDonorDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastDonorDate
        {
            get
            {
                return GetSystemDateTime(PatientMetadata.ColumnNames.LastDonorDate);
            }

            set
            {
                if (SetSystemDateTime(PatientMetadata.ColumnNames.LastDonorDate, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.LastDonorDate);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.IsBlackList
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsBlackList
        {
            get
            {
                return GetSystemBoolean(PatientMetadata.ColumnNames.IsBlackList);
            }

            set
            {
                if (SetSystemBoolean(PatientMetadata.ColumnNames.IsBlackList, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.IsBlackList);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.IsAlive
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsAlive
        {
            get
            {
                return GetSystemBoolean(PatientMetadata.ColumnNames.IsAlive);
            }

            set
            {
                if (SetSystemBoolean(PatientMetadata.ColumnNames.IsAlive, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.IsAlive);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.IsActive
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsActive
        {
            get
            {
                return GetSystemBoolean(PatientMetadata.ColumnNames.IsActive);
            }

            set
            {
                if (SetSystemBoolean(PatientMetadata.ColumnNames.IsActive, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.IsActive);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.Notes
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Notes
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.Notes);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.Notes, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.Notes);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.DiagnosticNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DiagnosticNo
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.DiagnosticNo);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.DiagnosticNo, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.DiagnosticNo);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.MemberID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string MemberID
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.MemberID);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.MemberID, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.MemberID);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(PatientMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(PatientMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.PackageBalance
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? PackageBalance
        {
            get
            {
                return GetSystemDecimal(PatientMetadata.ColumnNames.PackageBalance);
            }

            set
            {
                if (SetSystemDecimal(PatientMetadata.ColumnNames.PackageBalance, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.PackageBalance);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.HealthcareID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string HealthcareID
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.HealthcareID);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.HealthcareID, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.HealthcareID);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.ResponTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public TimeSpan? ResponTime
        {
            get
            {
                return GetSystemTimeSpan(PatientMetadata.ColumnNames.ResponTime);
            }

            set
            {
                if (SetSystemTimeSpan(PatientMetadata.ColumnNames.ResponTime, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.ResponTime);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.SRInformationFrom
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRInformationFrom
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.SRInformationFrom);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.SRInformationFrom, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.SRInformationFrom);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.SRPatienRelation
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRPatienRelation
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.SRPatienRelation);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.SRPatienRelation, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.SRPatienRelation);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.PersonID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? PersonID
        {
            get
            {
                return GetSystemInt32(PatientMetadata.ColumnNames.PersonID);
            }

            set
            {
                if (SetSystemInt32(PatientMetadata.ColumnNames.PersonID, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.PersonID);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.EmployeeNumber
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string EmployeeNumber
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.EmployeeNumber);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.EmployeeNumber, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.EmployeeNumber);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.SREmployeeRelationship
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SREmployeeRelationship
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.SREmployeeRelationship);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.SREmployeeRelationship, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.SREmployeeRelationship);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.GuarantorCardNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string GuarantorCardNo
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.GuarantorCardNo);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.GuarantorCardNo, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.GuarantorCardNo);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.IsNonPatient
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsNonPatient
        {
            get
            {
                return GetSystemBoolean(PatientMetadata.ColumnNames.IsNonPatient);
            }

            set
            {
                if (SetSystemBoolean(PatientMetadata.ColumnNames.IsNonPatient, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.IsNonPatient);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.ParentSpouseAge
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public short? ParentSpouseAge
        {
            get
            {
                return GetSystemInt16(PatientMetadata.ColumnNames.ParentSpouseAge);
            }

            set
            {
                if (SetSystemInt16(PatientMetadata.ColumnNames.ParentSpouseAge, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.ParentSpouseAge);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.SRParentSpouseOccupation
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRParentSpouseOccupation
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.SRParentSpouseOccupation);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.SRParentSpouseOccupation, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.SRParentSpouseOccupation);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.ParentSpouseOccupationDesc
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParentSpouseOccupationDesc
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.ParentSpouseOccupationDesc);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.ParentSpouseOccupationDesc, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.ParentSpouseOccupationDesc);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.SRMotherOccupation
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRMotherOccupation
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.SRMotherOccupation);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.SRMotherOccupation, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.SRMotherOccupation);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.MotherOccupationDesc
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string MotherOccupationDesc
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.MotherOccupationDesc);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.MotherOccupationDesc, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.MotherOccupationDesc);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.MotherName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string MotherName
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.MotherName);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.MotherName, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.MotherName);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.MotherAge
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public short? MotherAge
        {
            get
            {
                return GetSystemInt16(PatientMetadata.ColumnNames.MotherAge);
            }

            set
            {
                if (SetSystemInt16(PatientMetadata.ColumnNames.MotherAge, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.MotherAge);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.IsNotPaidOff
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsNotPaidOff
        {
            get
            {
                return GetSystemBoolean(PatientMetadata.ColumnNames.IsNotPaidOff);
            }

            set
            {
                if (SetSystemBoolean(PatientMetadata.ColumnNames.IsNotPaidOff, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.IsNotPaidOff);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.ParentSpouseMedicalNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParentSpouseMedicalNo
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.ParentSpouseMedicalNo);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.ParentSpouseMedicalNo, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.ParentSpouseMedicalNo);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.MotherMedicalNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string MotherMedicalNo
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.MotherMedicalNo);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.MotherMedicalNo, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.MotherMedicalNo);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.CompanyAddress
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string CompanyAddress
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.CompanyAddress);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.CompanyAddress, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.CompanyAddress);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.CreatedByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string CreatedByUserID
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.CreatedByUserID);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.CreatedByUserID, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.CreatedByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.CreatedDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? CreatedDateTime
        {
            get
            {
                return GetSystemDateTime(PatientMetadata.ColumnNames.CreatedDateTime);
            }

            set
            {
                if (SetSystemDateTime(PatientMetadata.ColumnNames.CreatedDateTime, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.CreatedDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.SRRelationshipQuality
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRRelationshipQuality
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.SRRelationshipQuality);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.SRRelationshipQuality, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.SRRelationshipQuality);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.SRResidentialHome
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRResidentialHome
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.SRResidentialHome);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.SRResidentialHome, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.SRResidentialHome);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.IsStoredToLokadok
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsStoredToLokadok
        {
            get
            {
                return GetSystemBoolean(PatientMetadata.ColumnNames.IsStoredToLokadok);
            }

            set
            {
                if (SetSystemBoolean(PatientMetadata.ColumnNames.IsStoredToLokadok, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.IsStoredToLokadok);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.FatherName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string FatherName
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.FatherName);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.FatherName, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.FatherName);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.FatherAge
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public short? FatherAge
        {
            get
            {
                return GetSystemInt16(PatientMetadata.ColumnNames.FatherAge);
            }

            set
            {
                if (SetSystemInt16(PatientMetadata.ColumnNames.FatherAge, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.FatherAge);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.FatherMedicalNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string FatherMedicalNo
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.FatherMedicalNo);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.FatherMedicalNo, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.FatherMedicalNo);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.SRFatherOccupation
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRFatherOccupation
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.SRFatherOccupation);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.SRFatherOccupation, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.SRFatherOccupation);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.FatherOccupationDesc
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string FatherOccupationDesc
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.FatherOccupationDesc);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.FatherOccupationDesc, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.FatherOccupationDesc);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.DeathCertificateNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DeathCertificateNo
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.DeathCertificateNo);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.DeathCertificateNo, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.DeathCertificateNo);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.EmployeeNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string EmployeeNo
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.EmployeeNo);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.EmployeeNo, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.EmployeeNo);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.EmployeeJobTitleName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string EmployeeJobTitleName
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.EmployeeJobTitleName);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.EmployeeJobTitleName, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.EmployeeJobTitleName);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.EmployeeJobDepartementName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string EmployeeJobDepartementName
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.EmployeeJobDepartementName);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.EmployeeJobDepartementName, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.EmployeeJobDepartementName);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.ValuesOfTrust
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ValuesOfTrust
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.ValuesOfTrust);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.ValuesOfTrust, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.ValuesOfTrust);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.DeceasedDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? DeceasedDateTime
        {
            get
            {
                return GetSystemDateTime(PatientMetadata.ColumnNames.DeceasedDateTime);
            }

            set
            {
                if (SetSystemDateTime(PatientMetadata.ColumnNames.DeceasedDateTime, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.DeceasedDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.FamilyRegisterNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string FamilyRegisterNo
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.FamilyRegisterNo);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.FamilyRegisterNo, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.FamilyRegisterNo);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.IsSyncWithDukcapil
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsSyncWithDukcapil
        {
            get
            {
                return GetSystemBoolean(PatientMetadata.ColumnNames.IsSyncWithDukcapil);
            }

            set
            {
                if (SetSystemBoolean(PatientMetadata.ColumnNames.IsSyncWithDukcapil, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.IsSyncWithDukcapil);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.IsDisability
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsDisability
        {
            get
            {
                return GetSystemBoolean(PatientMetadata.ColumnNames.IsDisability);
            }

            set
            {
                if (SetSystemBoolean(PatientMetadata.ColumnNames.IsDisability, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.IsDisability);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.PassportNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PassportNo
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.PassportNo);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.PassportNo, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.PassportNo);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.SRBPJSClass
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRBPJSClass
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.SRBPJSClass);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.SRBPJSClass, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.SRBPJSClass);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.ReverseMedicalNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ReverseMedicalNo
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.ReverseMedicalNo);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.ReverseMedicalNo, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.ReverseMedicalNo);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.ReverseOldMedicalNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ReverseOldMedicalNo
        {
            get
            {
                return GetSystemString(PatientMetadata.ColumnNames.ReverseOldMedicalNo);
            }

            set
            {
                if (SetSystemString(PatientMetadata.ColumnNames.ReverseOldMedicalNo, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.ReverseOldMedicalNo);
                }
            }
        }

        /// <summary>
        /// Maps to Patient.IsAllowLogin
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsAllowLogin
        {
            get
            {
                return GetSystemBoolean(PatientMetadata.ColumnNames.IsAllowLogin);
            }

            set
            {
                if (SetSystemBoolean(PatientMetadata.ColumnNames.IsAllowLogin, value))
                {
                    OnPropertyChanged(PatientMetadata.PropertyNames.IsAllowLogin);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return PatientMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public PatientQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new PatientQuery("pQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(PatientQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(PatientQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((PatientQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private PatientQuery query;
    }



    [Serializable]
    abstract public partial class esPatientCollection : esEntityCollection<Patient>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return PatientMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "PatientCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public PatientQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new PatientQuery("pQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(PatientQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new PatientQuery("pQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(PatientQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((PatientQuery)query);
        }

        #endregion

        private PatientQuery query;
    }



    [Serializable]
    abstract public partial class esPatientQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return PatientMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "PatientID": return PatientID;
                case "MedicalNo": return MedicalNo;
                case "Ssn": return Ssn;
                case "SRSalutation": return SRSalutation;
                case "FirstName": return FirstName;
                case "MiddleName": return MiddleName;
                case "LastName": return LastName;
                case "ParentSpouseName": return ParentSpouseName;
                case "CityOfBirth": return CityOfBirth;
                case "DateOfBirth": return DateOfBirth;
                case "Sex": return Sex;
                case "SRBloodType": return SRBloodType;
                case "BloodRhesus": return BloodRhesus;
                case "SREthnic": return SREthnic;
                case "SREducation": return SREducation;
                case "SRMaritalStatus": return SRMaritalStatus;
                case "SRNationality": return SRNationality;
                case "SROccupation": return SROccupation;
                case "SRTitle": return SRTitle;
                case "SRPatientCategory": return SRPatientCategory;
                case "SRReligion": return SRReligion;
                case "SRMedicalFileBin": return SRMedicalFileBin;
                case "SRMedicalFileStatus": return SRMedicalFileStatus;
                case "GuarantorID": return GuarantorID;
                case "Company": return Company;
                case "StreetName": return StreetName;
                case "District": return District;
                case "City": return City;
                case "County": return County;
                case "State": return State;
                case "ZipCode": return ZipCode;
                case "PhoneNo": return PhoneNo;
                case "FaxNo": return FaxNo;
                case "Email": return Email;
                case "MobilePhoneNo": return MobilePhoneNo;
                case "TempAddressStreetName": return TempAddressStreetName;
                case "TempAddressDistrict": return TempAddressDistrict;
                case "TempAddressCity": return TempAddressCity;
                case "TempAddressCounty": return TempAddressCounty;
                case "TempAddressState": return TempAddressState;
                case "TempAddressZipCode": return TempAddressZipCode;
                case "TempAddressPhoneNo": return TempAddressPhoneNo;
                case "LastVisitDate": return LastVisitDate;
                case "NumberOfVisit": return NumberOfVisit;
                case "OldMedicalNo": return OldMedicalNo;
                case "AccountNo": return AccountNo;
                case "PictureFileName": return PictureFileName;
                case "IsDonor": return IsDonor;
                case "NumberOfDonor": return NumberOfDonor;
                case "LastDonorDate": return LastDonorDate;
                case "IsBlackList": return IsBlackList;
                case "IsAlive": return IsAlive;
                case "IsActive": return IsActive;
                case "Notes": return Notes;
                case "DiagnosticNo": return DiagnosticNo;
                case "MemberID": return MemberID;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "PackageBalance": return PackageBalance;
                case "HealthcareID": return HealthcareID;
                case "ResponTime": return ResponTime;
                case "SRInformationFrom": return SRInformationFrom;
                case "SRPatienRelation": return SRPatienRelation;
                case "PersonID": return PersonID;
                case "EmployeeNumber": return EmployeeNumber;
                case "SREmployeeRelationship": return SREmployeeRelationship;
                case "GuarantorCardNo": return GuarantorCardNo;
                case "IsNonPatient": return IsNonPatient;
                case "ParentSpouseAge": return ParentSpouseAge;
                case "SRParentSpouseOccupation": return SRParentSpouseOccupation;
                case "ParentSpouseOccupationDesc": return ParentSpouseOccupationDesc;
                case "SRMotherOccupation": return SRMotherOccupation;
                case "MotherOccupationDesc": return MotherOccupationDesc;
                case "MotherName": return MotherName;
                case "MotherAge": return MotherAge;
                case "IsNotPaidOff": return IsNotPaidOff;
                case "ParentSpouseMedicalNo": return ParentSpouseMedicalNo;
                case "MotherMedicalNo": return MotherMedicalNo;
                case "CompanyAddress": return CompanyAddress;
                case "CreatedByUserID": return CreatedByUserID;
                case "CreatedDateTime": return CreatedDateTime;
                case "SRRelationshipQuality": return SRRelationshipQuality;
                case "SRResidentialHome": return SRResidentialHome;
                case "IsStoredToLokadok": return IsStoredToLokadok;
                case "FatherName": return FatherName;
                case "FatherAge": return FatherAge;
                case "FatherMedicalNo": return FatherMedicalNo;
                case "SRFatherOccupation": return SRFatherOccupation;
                case "FatherOccupationDesc": return FatherOccupationDesc;
                case "DeathCertificateNo": return DeathCertificateNo;
                case "EmployeeNo": return EmployeeNo;
                case "EmployeeJobTitleName": return EmployeeJobTitleName;
                case "EmployeeJobDepartementName": return EmployeeJobDepartementName;
                case "ValuesOfTrust": return ValuesOfTrust;
                case "DeceasedDateTime": return DeceasedDateTime;
                case "FamilyRegisterNo": return FamilyRegisterNo;
                case "IsSyncWithDukcapil": return IsSyncWithDukcapil;
                case "IsDisability": return IsDisability;
                case "PassportNo": return PassportNo;
                case "SRBPJSClass": return SRBPJSClass;
                case "ReverseMedicalNo": return ReverseMedicalNo;
                case "ReverseOldMedicalNo": return ReverseOldMedicalNo;
                case "IsAllowLogin": return IsAllowLogin;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem PatientID
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.PatientID, esSystemType.String); }
        }

        public esQueryItem MedicalNo
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.MedicalNo, esSystemType.String); }
        }

        public esQueryItem Ssn
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.Ssn, esSystemType.String); }
        }

        public esQueryItem SRSalutation
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.SRSalutation, esSystemType.String); }
        }

        public esQueryItem FirstName
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.FirstName, esSystemType.String); }
        }

        public esQueryItem MiddleName
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.MiddleName, esSystemType.String); }
        }

        public esQueryItem LastName
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.LastName, esSystemType.String); }
        }

        public esQueryItem ParentSpouseName
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.ParentSpouseName, esSystemType.String); }
        }

        public esQueryItem CityOfBirth
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.CityOfBirth, esSystemType.String); }
        }

        public esQueryItem DateOfBirth
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.DateOfBirth, esSystemType.DateTime); }
        }

        public esQueryItem Sex
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.Sex, esSystemType.Char); }
        }

        public esQueryItem SRBloodType
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.SRBloodType, esSystemType.String); }
        }

        public esQueryItem BloodRhesus
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.BloodRhesus, esSystemType.Char); }
        }

        public esQueryItem SREthnic
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.SREthnic, esSystemType.String); }
        }

        public esQueryItem SREducation
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.SREducation, esSystemType.String); }
        }

        public esQueryItem SRMaritalStatus
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.SRMaritalStatus, esSystemType.String); }
        }

        public esQueryItem SRNationality
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.SRNationality, esSystemType.String); }
        }

        public esQueryItem SROccupation
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.SROccupation, esSystemType.String); }
        }

        public esQueryItem SRTitle
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.SRTitle, esSystemType.String); }
        }

        public esQueryItem SRPatientCategory
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.SRPatientCategory, esSystemType.String); }
        }

        public esQueryItem SRReligion
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.SRReligion, esSystemType.String); }
        }

        public esQueryItem SRMedicalFileBin
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.SRMedicalFileBin, esSystemType.String); }
        }

        public esQueryItem SRMedicalFileStatus
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.SRMedicalFileStatus, esSystemType.String); }
        }

        public esQueryItem GuarantorID
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.GuarantorID, esSystemType.String); }
        }

        public esQueryItem Company
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.Company, esSystemType.String); }
        }

        public esQueryItem StreetName
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.StreetName, esSystemType.String); }
        }

        public esQueryItem District
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.District, esSystemType.String); }
        }

        public esQueryItem City
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.City, esSystemType.String); }
        }

        public esQueryItem County
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.County, esSystemType.String); }
        }

        public esQueryItem State
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.State, esSystemType.String); }
        }

        public esQueryItem ZipCode
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.ZipCode, esSystemType.String); }
        }

        public esQueryItem PhoneNo
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.PhoneNo, esSystemType.String); }
        }

        public esQueryItem FaxNo
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.FaxNo, esSystemType.String); }
        }

        public esQueryItem Email
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.Email, esSystemType.String); }
        }

        public esQueryItem MobilePhoneNo
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.MobilePhoneNo, esSystemType.String); }
        }

        public esQueryItem TempAddressStreetName
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.TempAddressStreetName, esSystemType.String); }
        }

        public esQueryItem TempAddressDistrict
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.TempAddressDistrict, esSystemType.String); }
        }

        public esQueryItem TempAddressCity
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.TempAddressCity, esSystemType.String); }
        }

        public esQueryItem TempAddressCounty
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.TempAddressCounty, esSystemType.String); }
        }

        public esQueryItem TempAddressState
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.TempAddressState, esSystemType.String); }
        }

        public esQueryItem TempAddressZipCode
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.TempAddressZipCode, esSystemType.String); }
        }

        public esQueryItem TempAddressPhoneNo
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.TempAddressPhoneNo, esSystemType.String); }
        }

        public esQueryItem LastVisitDate
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.LastVisitDate, esSystemType.DateTime); }
        }

        public esQueryItem NumberOfVisit
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.NumberOfVisit, esSystemType.Byte); }
        }

        public esQueryItem OldMedicalNo
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.OldMedicalNo, esSystemType.String); }
        }

        public esQueryItem AccountNo
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.AccountNo, esSystemType.String); }
        }

        public esQueryItem PictureFileName
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.PictureFileName, esSystemType.String); }
        }

        public esQueryItem IsDonor
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.IsDonor, esSystemType.Boolean); }
        }

        public esQueryItem NumberOfDonor
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.NumberOfDonor, esSystemType.Decimal); }
        }

        public esQueryItem LastDonorDate
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.LastDonorDate, esSystemType.DateTime); }
        }

        public esQueryItem IsBlackList
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.IsBlackList, esSystemType.Boolean); }
        }

        public esQueryItem IsAlive
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.IsAlive, esSystemType.Boolean); }
        }

        public esQueryItem IsActive
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.IsActive, esSystemType.Boolean); }
        }

        public esQueryItem Notes
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.Notes, esSystemType.String); }
        }

        public esQueryItem DiagnosticNo
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.DiagnosticNo, esSystemType.String); }
        }

        public esQueryItem MemberID
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.MemberID, esSystemType.String); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem PackageBalance
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.PackageBalance, esSystemType.Decimal); }
        }

        public esQueryItem HealthcareID
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.HealthcareID, esSystemType.String); }
        }

        public esQueryItem ResponTime
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.ResponTime, esSystemType.TimeSpan); }
        }

        public esQueryItem SRInformationFrom
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.SRInformationFrom, esSystemType.String); }
        }

        public esQueryItem SRPatienRelation
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.SRPatienRelation, esSystemType.String); }
        }

        public esQueryItem PersonID
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.PersonID, esSystemType.Int32); }
        }

        public esQueryItem EmployeeNumber
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.EmployeeNumber, esSystemType.String); }
        }

        public esQueryItem SREmployeeRelationship
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.SREmployeeRelationship, esSystemType.String); }
        }

        public esQueryItem GuarantorCardNo
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.GuarantorCardNo, esSystemType.String); }
        }

        public esQueryItem IsNonPatient
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.IsNonPatient, esSystemType.Boolean); }
        }

        public esQueryItem ParentSpouseAge
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.ParentSpouseAge, esSystemType.Int16); }
        }

        public esQueryItem SRParentSpouseOccupation
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.SRParentSpouseOccupation, esSystemType.String); }
        }

        public esQueryItem ParentSpouseOccupationDesc
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.ParentSpouseOccupationDesc, esSystemType.String); }
        }

        public esQueryItem SRMotherOccupation
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.SRMotherOccupation, esSystemType.String); }
        }

        public esQueryItem MotherOccupationDesc
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.MotherOccupationDesc, esSystemType.String); }
        }

        public esQueryItem MotherName
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.MotherName, esSystemType.String); }
        }

        public esQueryItem MotherAge
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.MotherAge, esSystemType.Int16); }
        }

        public esQueryItem IsNotPaidOff
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.IsNotPaidOff, esSystemType.Boolean); }
        }

        public esQueryItem ParentSpouseMedicalNo
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.ParentSpouseMedicalNo, esSystemType.String); }
        }

        public esQueryItem MotherMedicalNo
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.MotherMedicalNo, esSystemType.String); }
        }

        public esQueryItem CompanyAddress
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.CompanyAddress, esSystemType.String); }
        }

        public esQueryItem CreatedByUserID
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.CreatedByUserID, esSystemType.String); }
        }

        public esQueryItem CreatedDateTime
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.CreatedDateTime, esSystemType.DateTime); }
        }

        public esQueryItem SRRelationshipQuality
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.SRRelationshipQuality, esSystemType.String); }
        }

        public esQueryItem SRResidentialHome
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.SRResidentialHome, esSystemType.String); }
        }

        public esQueryItem IsStoredToLokadok
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.IsStoredToLokadok, esSystemType.Boolean); }
        }

        public esQueryItem FatherName
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.FatherName, esSystemType.String); }
        }

        public esQueryItem FatherAge
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.FatherAge, esSystemType.Int16); }
        }

        public esQueryItem FatherMedicalNo
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.FatherMedicalNo, esSystemType.String); }
        }

        public esQueryItem SRFatherOccupation
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.SRFatherOccupation, esSystemType.String); }
        }

        public esQueryItem FatherOccupationDesc
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.FatherOccupationDesc, esSystemType.String); }
        }

        public esQueryItem DeathCertificateNo
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.DeathCertificateNo, esSystemType.String); }
        }

        public esQueryItem EmployeeNo
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.EmployeeNo, esSystemType.String); }
        }

        public esQueryItem EmployeeJobTitleName
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.EmployeeJobTitleName, esSystemType.String); }
        }

        public esQueryItem EmployeeJobDepartementName
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.EmployeeJobDepartementName, esSystemType.String); }
        }

        public esQueryItem ValuesOfTrust
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.ValuesOfTrust, esSystemType.String); }
        }

        public esQueryItem DeceasedDateTime
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.DeceasedDateTime, esSystemType.DateTime); }
        }

        public esQueryItem FamilyRegisterNo
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.FamilyRegisterNo, esSystemType.String); }
        }

        public esQueryItem IsSyncWithDukcapil
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.IsSyncWithDukcapil, esSystemType.Boolean); }
        }

        public esQueryItem IsDisability
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.IsDisability, esSystemType.Boolean); }
        }

        public esQueryItem PassportNo
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.PassportNo, esSystemType.String); }
        }

        public esQueryItem SRBPJSClass
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.SRBPJSClass, esSystemType.String); }
        }

        public esQueryItem ReverseMedicalNo
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.ReverseMedicalNo, esSystemType.String); }
        }

        public esQueryItem ReverseOldMedicalNo
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.ReverseOldMedicalNo, esSystemType.String); }
        }

        public esQueryItem IsAllowLogin
        {
            get { return new esQueryItem(this, PatientMetadata.ColumnNames.IsAllowLogin, esSystemType.Boolean); }
        }

        #endregion

    }



    [Serializable]
    public partial class PatientMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected PatientMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.PatientID, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PatientID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 15;
            c.HasDefault = true;
            c.Default = @"(' ')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.MedicalNo, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.MedicalNo;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Ssn, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Ssn;
            c.CharacterMaxLength = 50;
            c.HasDefault = true;
            c.Default = @"(' ')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRSalutation, 3, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRSalutation;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"(' ')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FirstName, 4, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.FirstName;
            c.CharacterMaxLength = 50;
            c.HasDefault = true;
            c.Default = @"(' ')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.MiddleName, 5, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.MiddleName;
            c.CharacterMaxLength = 50;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastName, 6, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastName;
            c.CharacterMaxLength = 50;
            c.HasDefault = true;
            c.Default = @"(' ')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParentSpouseName, 7, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParentSpouseName;
            c.CharacterMaxLength = 100;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CityOfBirth, 8, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.CityOfBirth;
            c.CharacterMaxLength = 50;
            c.HasDefault = true;
            c.Default = @"(' ')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DateOfBirth, 9, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.DateOfBirth;
            c.HasDefault = true;
            c.Default = @"(CONVERT([smalldatetime],'19000101',(0)))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Sex, 10, typeof(char), esSystemType.Char);
            c.PropertyName = PropertyNames.Sex;
            c.CharacterMaxLength = 1;
            c.HasDefault = true;
            c.Default = @"('M')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRBloodType, 11, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRBloodType;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.BloodRhesus, 12, typeof(char), esSystemType.Char);
            c.PropertyName = PropertyNames.BloodRhesus;
            c.CharacterMaxLength = 1;
            c.HasDefault = true;
            c.Default = @"('+')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SREthnic, 13, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SREthnic;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SREducation, 14, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SREducation;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRMaritalStatus, 15, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRMaritalStatus;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRNationality, 16, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRNationality;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SROccupation, 17, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SROccupation;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRTitle, 18, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRTitle;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRPatientCategory, 19, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRPatientCategory;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRReligion, 20, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRReligion;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRMedicalFileBin, 21, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRMedicalFileBin;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRMedicalFileStatus, 22, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRMedicalFileStatus;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.GuarantorID, 23, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.GuarantorID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Company, 24, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Company;
            c.CharacterMaxLength = 100;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.StreetName, 25, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.StreetName;
            c.CharacterMaxLength = 250;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.District, 26, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.District;
            c.CharacterMaxLength = 50;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.City, 27, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.City;
            c.CharacterMaxLength = 50;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.County, 28, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.County;
            c.CharacterMaxLength = 50;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.State, 29, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.State;
            c.CharacterMaxLength = 50;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ZipCode, 30, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ZipCode;
            c.CharacterMaxLength = 15;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PhoneNo, 31, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PhoneNo;
            c.CharacterMaxLength = 255;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FaxNo, 32, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.FaxNo;
            c.CharacterMaxLength = 50;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Email, 33, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Email;
            c.CharacterMaxLength = 50;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.MobilePhoneNo, 34, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.MobilePhoneNo;
            c.CharacterMaxLength = 255;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TempAddressStreetName, 35, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TempAddressStreetName;
            c.CharacterMaxLength = 250;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TempAddressDistrict, 36, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TempAddressDistrict;
            c.CharacterMaxLength = 50;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TempAddressCity, 37, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TempAddressCity;
            c.CharacterMaxLength = 50;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TempAddressCounty, 38, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TempAddressCounty;
            c.CharacterMaxLength = 50;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TempAddressState, 39, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TempAddressState;
            c.CharacterMaxLength = 50;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TempAddressZipCode, 40, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TempAddressZipCode;
            c.CharacterMaxLength = 50;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TempAddressPhoneNo, 41, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TempAddressPhoneNo;
            c.CharacterMaxLength = 255;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastVisitDate, 42, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastVisitDate;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.NumberOfVisit, 43, typeof(byte), esSystemType.Byte);
            c.PropertyName = PropertyNames.NumberOfVisit;
            c.NumericPrecision = 3;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.OldMedicalNo, 44, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.OldMedicalNo;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AccountNo, 45, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.AccountNo;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PictureFileName, 46, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PictureFileName;
            c.CharacterMaxLength = 50;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsDonor, 47, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsDonor;
            c.HasDefault = true;
            c.Default = @"((0))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.NumberOfDonor, 48, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.NumberOfDonor;
            c.NumericPrecision = 3;
            c.HasDefault = true;
            c.Default = @"((0))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastDonorDate, 49, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastDonorDate;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsBlackList, 50, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsBlackList;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsAlive, 51, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsAlive;
            c.HasDefault = true;
            c.Default = @"((1))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsActive, 52, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsActive;
            c.HasDefault = true;
            c.Default = @"((1))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Notes, 53, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Notes;
            c.CharacterMaxLength = 4000;
            c.HasDefault = true;
            c.Default = @"(' ')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DiagnosticNo, 54, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DiagnosticNo;
            c.CharacterMaxLength = 100;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.MemberID, 55, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.MemberID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 56, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 57, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 40;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PackageBalance, 58, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.PackageBalance;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.HasDefault = true;
            c.Default = @"((0))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.HealthcareID, 59, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.HealthcareID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ResponTime, 60, typeof(TimeSpan), esSystemType.TimeSpan);
            c.PropertyName = PropertyNames.ResponTime;
            c.CharacterMaxLength = 8;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRInformationFrom, 61, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRInformationFrom;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRPatienRelation, 62, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRPatienRelation;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PersonID, 63, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.PersonID;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.EmployeeNumber, 64, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.EmployeeNumber;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SREmployeeRelationship, 65, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SREmployeeRelationship;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.GuarantorCardNo, 66, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.GuarantorCardNo;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsNonPatient, 67, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsNonPatient;
            c.HasDefault = true;
            c.Default = @"((0))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParentSpouseAge, 68, typeof(short), esSystemType.Int16);
            c.PropertyName = PropertyNames.ParentSpouseAge;
            c.NumericPrecision = 5;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRParentSpouseOccupation, 69, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRParentSpouseOccupation;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParentSpouseOccupationDesc, 70, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParentSpouseOccupationDesc;
            c.CharacterMaxLength = 250;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRMotherOccupation, 71, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRMotherOccupation;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.MotherOccupationDesc, 72, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.MotherOccupationDesc;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.MotherName, 73, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.MotherName;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.MotherAge, 74, typeof(short), esSystemType.Int16);
            c.PropertyName = PropertyNames.MotherAge;
            c.NumericPrecision = 5;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsNotPaidOff, 75, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsNotPaidOff;
            c.HasDefault = true;
            c.Default = @"((0))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParentSpouseMedicalNo, 76, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParentSpouseMedicalNo;
            c.CharacterMaxLength = 15;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.MotherMedicalNo, 77, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.MotherMedicalNo;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CompanyAddress, 78, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.CompanyAddress;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreatedByUserID, 79, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.CreatedByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreatedDateTime, 80, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.CreatedDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRRelationshipQuality, 81, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRRelationshipQuality;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRResidentialHome, 82, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRResidentialHome;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsStoredToLokadok, 83, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsStoredToLokadok;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FatherName, 84, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.FatherName;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FatherAge, 85, typeof(short), esSystemType.Int16);
            c.PropertyName = PropertyNames.FatherAge;
            c.NumericPrecision = 5;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FatherMedicalNo, 86, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.FatherMedicalNo;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRFatherOccupation, 87, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRFatherOccupation;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FatherOccupationDesc, 88, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.FatherOccupationDesc;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DeathCertificateNo, 89, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DeathCertificateNo;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.EmployeeNo, 90, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.EmployeeNo;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.EmployeeJobTitleName, 91, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.EmployeeJobTitleName;
            c.CharacterMaxLength = 255;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.EmployeeJobDepartementName, 92, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.EmployeeJobDepartementName;
            c.CharacterMaxLength = 255;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ValuesOfTrust, 93, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ValuesOfTrust;
            c.CharacterMaxLength = 1000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DeceasedDateTime, 94, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.DeceasedDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FamilyRegisterNo, 95, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.FamilyRegisterNo;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsSyncWithDukcapil, 96, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsSyncWithDukcapil;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsDisability, 97, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsDisability;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PassportNo, 98, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PassportNo;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRBPJSClass, 99, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRBPJSClass;
            c.CharacterMaxLength = 25;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ReverseMedicalNo, 100, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ReverseMedicalNo;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ReverseOldMedicalNo, 101, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ReverseOldMedicalNo;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsAllowLogin, 102, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsAllowLogin;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public PatientMetadata Meta()
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
            public const string PatientID = "PatientID";
            public const string MedicalNo = "MedicalNo";
            public const string Ssn = "Ssn";
            public const string SRSalutation = "SRSalutation";
            public const string FirstName = "FirstName";
            public const string MiddleName = "MiddleName";
            public const string LastName = "LastName";
            public const string ParentSpouseName = "ParentSpouseName";
            public const string CityOfBirth = "CityOfBirth";
            public const string DateOfBirth = "DateOfBirth";
            public const string Sex = "Sex";
            public const string SRBloodType = "SRBloodType";
            public const string BloodRhesus = "BloodRhesus";
            public const string SREthnic = "SREthnic";
            public const string SREducation = "SREducation";
            public const string SRMaritalStatus = "SRMaritalStatus";
            public const string SRNationality = "SRNationality";
            public const string SROccupation = "SROccupation";
            public const string SRTitle = "SRTitle";
            public const string SRPatientCategory = "SRPatientCategory";
            public const string SRReligion = "SRReligion";
            public const string SRMedicalFileBin = "SRMedicalFileBin";
            public const string SRMedicalFileStatus = "SRMedicalFileStatus";
            public const string GuarantorID = "GuarantorID";
            public const string Company = "Company";
            public const string StreetName = "StreetName";
            public const string District = "District";
            public const string City = "City";
            public const string County = "County";
            public const string State = "State";
            public const string ZipCode = "ZipCode";
            public const string PhoneNo = "PhoneNo";
            public const string FaxNo = "FaxNo";
            public const string Email = "Email";
            public const string MobilePhoneNo = "MobilePhoneNo";
            public const string TempAddressStreetName = "TempAddressStreetName";
            public const string TempAddressDistrict = "TempAddressDistrict";
            public const string TempAddressCity = "TempAddressCity";
            public const string TempAddressCounty = "TempAddressCounty";
            public const string TempAddressState = "TempAddressState";
            public const string TempAddressZipCode = "TempAddressZipCode";
            public const string TempAddressPhoneNo = "TempAddressPhoneNo";
            public const string LastVisitDate = "LastVisitDate";
            public const string NumberOfVisit = "NumberOfVisit";
            public const string OldMedicalNo = "OldMedicalNo";
            public const string AccountNo = "AccountNo";
            public const string PictureFileName = "PictureFileName";
            public const string IsDonor = "IsDonor";
            public const string NumberOfDonor = "NumberOfDonor";
            public const string LastDonorDate = "LastDonorDate";
            public const string IsBlackList = "IsBlackList";
            public const string IsAlive = "IsAlive";
            public const string IsActive = "IsActive";
            public const string Notes = "Notes";
            public const string DiagnosticNo = "DiagnosticNo";
            public const string MemberID = "MemberID";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string PackageBalance = "PackageBalance";
            public const string HealthcareID = "HealthcareID";
            public const string ResponTime = "ResponTime";
            public const string SRInformationFrom = "SRInformationFrom";
            public const string SRPatienRelation = "SRPatienRelation";
            public const string PersonID = "PersonID";
            public const string EmployeeNumber = "EmployeeNumber";
            public const string SREmployeeRelationship = "SREmployeeRelationship";
            public const string GuarantorCardNo = "GuarantorCardNo";
            public const string IsNonPatient = "IsNonPatient";
            public const string ParentSpouseAge = "ParentSpouseAge";
            public const string SRParentSpouseOccupation = "SRParentSpouseOccupation";
            public const string ParentSpouseOccupationDesc = "ParentSpouseOccupationDesc";
            public const string SRMotherOccupation = "SRMotherOccupation";
            public const string MotherOccupationDesc = "MotherOccupationDesc";
            public const string MotherName = "MotherName";
            public const string MotherAge = "MotherAge";
            public const string IsNotPaidOff = "IsNotPaidOff";
            public const string ParentSpouseMedicalNo = "ParentSpouseMedicalNo";
            public const string MotherMedicalNo = "MotherMedicalNo";
            public const string CompanyAddress = "CompanyAddress";
            public const string CreatedByUserID = "CreatedByUserID";
            public const string CreatedDateTime = "CreatedDateTime";
            public const string SRRelationshipQuality = "SRRelationshipQuality";
            public const string SRResidentialHome = "SRResidentialHome";
            public const string IsStoredToLokadok = "IsStoredToLokadok";
            public const string FatherName = "FatherName";
            public const string FatherAge = "FatherAge";
            public const string FatherMedicalNo = "FatherMedicalNo";
            public const string SRFatherOccupation = "SRFatherOccupation";
            public const string FatherOccupationDesc = "FatherOccupationDesc";
            public const string DeathCertificateNo = "DeathCertificateNo";
            public const string EmployeeNo = "EmployeeNo";
            public const string EmployeeJobTitleName = "EmployeeJobTitleName";
            public const string EmployeeJobDepartementName = "EmployeeJobDepartementName";
            public const string ValuesOfTrust = "ValuesOfTrust";
            public const string DeceasedDateTime = "DeceasedDateTime";
            public const string FamilyRegisterNo = "FamilyRegisterNo";
            public const string IsSyncWithDukcapil = "IsSyncWithDukcapil";
            public const string IsDisability = "IsDisability";
            public const string PassportNo = "PassportNo";
            public const string SRBPJSClass = "SRBPJSClass";
            public const string ReverseMedicalNo = "ReverseMedicalNo";
            public const string ReverseOldMedicalNo = "ReverseOldMedicalNo";
            public const string IsAllowLogin = "IsAllowLogin";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string PatientID = "PatientID";
            public const string MedicalNo = "MedicalNo";
            public const string Ssn = "Ssn";
            public const string SRSalutation = "SRSalutation";
            public const string FirstName = "FirstName";
            public const string MiddleName = "MiddleName";
            public const string LastName = "LastName";
            public const string ParentSpouseName = "ParentSpouseName";
            public const string CityOfBirth = "CityOfBirth";
            public const string DateOfBirth = "DateOfBirth";
            public const string Sex = "Sex";
            public const string SRBloodType = "SRBloodType";
            public const string BloodRhesus = "BloodRhesus";
            public const string SREthnic = "SREthnic";
            public const string SREducation = "SREducation";
            public const string SRMaritalStatus = "SRMaritalStatus";
            public const string SRNationality = "SRNationality";
            public const string SROccupation = "SROccupation";
            public const string SRTitle = "SRTitle";
            public const string SRPatientCategory = "SRPatientCategory";
            public const string SRReligion = "SRReligion";
            public const string SRMedicalFileBin = "SRMedicalFileBin";
            public const string SRMedicalFileStatus = "SRMedicalFileStatus";
            public const string GuarantorID = "GuarantorID";
            public const string Company = "Company";
            public const string StreetName = "StreetName";
            public const string District = "District";
            public const string City = "City";
            public const string County = "County";
            public const string State = "State";
            public const string ZipCode = "ZipCode";
            public const string PhoneNo = "PhoneNo";
            public const string FaxNo = "FaxNo";
            public const string Email = "Email";
            public const string MobilePhoneNo = "MobilePhoneNo";
            public const string TempAddressStreetName = "TempAddressStreetName";
            public const string TempAddressDistrict = "TempAddressDistrict";
            public const string TempAddressCity = "TempAddressCity";
            public const string TempAddressCounty = "TempAddressCounty";
            public const string TempAddressState = "TempAddressState";
            public const string TempAddressZipCode = "TempAddressZipCode";
            public const string TempAddressPhoneNo = "TempAddressPhoneNo";
            public const string LastVisitDate = "LastVisitDate";
            public const string NumberOfVisit = "NumberOfVisit";
            public const string OldMedicalNo = "OldMedicalNo";
            public const string AccountNo = "AccountNo";
            public const string PictureFileName = "PictureFileName";
            public const string IsDonor = "IsDonor";
            public const string NumberOfDonor = "NumberOfDonor";
            public const string LastDonorDate = "LastDonorDate";
            public const string IsBlackList = "IsBlackList";
            public const string IsAlive = "IsAlive";
            public const string IsActive = "IsActive";
            public const string Notes = "Notes";
            public const string DiagnosticNo = "DiagnosticNo";
            public const string MemberID = "MemberID";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string PackageBalance = "PackageBalance";
            public const string HealthcareID = "HealthcareID";
            public const string ResponTime = "ResponTime";
            public const string SRInformationFrom = "SRInformationFrom";
            public const string SRPatienRelation = "SRPatienRelation";
            public const string PersonID = "PersonID";
            public const string EmployeeNumber = "EmployeeNumber";
            public const string SREmployeeRelationship = "SREmployeeRelationship";
            public const string GuarantorCardNo = "GuarantorCardNo";
            public const string IsNonPatient = "IsNonPatient";
            public const string ParentSpouseAge = "ParentSpouseAge";
            public const string SRParentSpouseOccupation = "SRParentSpouseOccupation";
            public const string ParentSpouseOccupationDesc = "ParentSpouseOccupationDesc";
            public const string SRMotherOccupation = "SRMotherOccupation";
            public const string MotherOccupationDesc = "MotherOccupationDesc";
            public const string MotherName = "MotherName";
            public const string MotherAge = "MotherAge";
            public const string IsNotPaidOff = "IsNotPaidOff";
            public const string ParentSpouseMedicalNo = "ParentSpouseMedicalNo";
            public const string MotherMedicalNo = "MotherMedicalNo";
            public const string CompanyAddress = "CompanyAddress";
            public const string CreatedByUserID = "CreatedByUserID";
            public const string CreatedDateTime = "CreatedDateTime";
            public const string SRRelationshipQuality = "SRRelationshipQuality";
            public const string SRResidentialHome = "SRResidentialHome";
            public const string IsStoredToLokadok = "IsStoredToLokadok";
            public const string FatherName = "FatherName";
            public const string FatherAge = "FatherAge";
            public const string FatherMedicalNo = "FatherMedicalNo";
            public const string SRFatherOccupation = "SRFatherOccupation";
            public const string FatherOccupationDesc = "FatherOccupationDesc";
            public const string DeathCertificateNo = "DeathCertificateNo";
            public const string EmployeeNo = "EmployeeNo";
            public const string EmployeeJobTitleName = "EmployeeJobTitleName";
            public const string EmployeeJobDepartementName = "EmployeeJobDepartementName";
            public const string ValuesOfTrust = "ValuesOfTrust";
            public const string DeceasedDateTime = "DeceasedDateTime";
            public const string FamilyRegisterNo = "FamilyRegisterNo";
            public const string IsSyncWithDukcapil = "IsSyncWithDukcapil";
            public const string IsDisability = "IsDisability";
            public const string PassportNo = "PassportNo";
            public const string SRBPJSClass = "SRBPJSClass";
            public const string ReverseMedicalNo = "ReverseMedicalNo";
            public const string ReverseOldMedicalNo = "ReverseOldMedicalNo";
            public const string IsAllowLogin = "IsAllowLogin";
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
            lock (typeof(PatientMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new PatientMetadata();
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


                meta.AddTypeMap("PatientID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("MedicalNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Ssn", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRSalutation", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("FirstName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("MiddleName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ParentSpouseName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CityOfBirth", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("DateOfBirth", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("Sex", new esTypeMap("char", "System.Char"));
                meta.AddTypeMap("SRBloodType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("BloodRhesus", new esTypeMap("char", "System.Char"));
                meta.AddTypeMap("SREthnic", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SREducation", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRMaritalStatus", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRNationality", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SROccupation", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRTitle", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRPatientCategory", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRReligion", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRMedicalFileBin", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRMedicalFileStatus", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("GuarantorID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Company", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("StreetName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("District", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("City", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("County", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("State", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ZipCode", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PhoneNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("FaxNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Email", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("MobilePhoneNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TempAddressStreetName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TempAddressDistrict", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TempAddressCity", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TempAddressCounty", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TempAddressState", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TempAddressZipCode", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TempAddressPhoneNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastVisitDate", new esTypeMap("smalldatetime", "System.DateTime"));
                meta.AddTypeMap("NumberOfVisit", new esTypeMap("tinyint", "System.Byte"));
                meta.AddTypeMap("OldMedicalNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("AccountNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PictureFileName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsDonor", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("NumberOfDonor", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("LastDonorDate", new esTypeMap("smalldatetime", "System.DateTime"));
                meta.AddTypeMap("IsBlackList", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsAlive", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsActive", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("Notes", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("DiagnosticNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("MemberID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PackageBalance", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("HealthcareID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ResponTime", new esTypeMap("time", "System.TimeSpan"));
                meta.AddTypeMap("SRInformationFrom", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRPatienRelation", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PersonID", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("EmployeeNumber", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SREmployeeRelationship", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("GuarantorCardNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsNonPatient", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ParentSpouseAge", new esTypeMap("smallint", "System.Int16"));
                meta.AddTypeMap("SRParentSpouseOccupation", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ParentSpouseOccupationDesc", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRMotherOccupation", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("MotherOccupationDesc", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("MotherName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("MotherAge", new esTypeMap("smallint", "System.Int16"));
                meta.AddTypeMap("IsNotPaidOff", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ParentSpouseMedicalNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("MotherMedicalNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CompanyAddress", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CreatedByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CreatedDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("SRRelationshipQuality", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRResidentialHome", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsStoredToLokadok", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("FatherName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("FatherAge", new esTypeMap("smallint", "System.Int16"));
                meta.AddTypeMap("FatherMedicalNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRFatherOccupation", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("FatherOccupationDesc", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("DeathCertificateNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("EmployeeNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("EmployeeJobTitleName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("EmployeeJobDepartementName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ValuesOfTrust", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("DeceasedDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("FamilyRegisterNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsSyncWithDukcapil", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsDisability", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("PassportNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRBPJSClass", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ReverseMedicalNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ReverseOldMedicalNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsAllowLogin", new esTypeMap("bit", "System.Boolean"));



                meta.Source = "Patient";
                meta.Destination = "Patient";

                meta.spInsert = "proc_PatientInsert";
                meta.spUpdate = "proc_PatientUpdate";
                meta.spDelete = "proc_PatientDelete";
                meta.spLoadAll = "proc_PatientLoadAll";
                meta.spLoadByPrimaryKey = "proc_PatientLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private PatientMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
