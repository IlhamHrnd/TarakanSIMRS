
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 2/11/2025 11:26:00 AM
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
    /// Encapsulates the 'Paramedic' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(Paramedic))]
    [XmlType("Paramedic")]
    public partial class Paramedic : esParamedic
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new Paramedic();
        }

        #region Static Quick Access Methods
        static public void Delete(string paramedicID)
        {
            var obj = new Paramedic();
            obj.ParamedicID = paramedicID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string paramedicID, esSqlAccessType sqlAccessType)
        {
            var obj = new Paramedic();
            obj.ParamedicID = paramedicID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("ParamedicCollection")]
    public partial class ParamedicCollection : esParamedicCollection, IEnumerable<Paramedic>
    {
        public Paramedic FindByPrimaryKey(string paramedicID)
        {
            return this.SingleOrDefault(e => e.ParamedicID == paramedicID);
        }



    }



    [Serializable]
    public partial class ParamedicQuery : esParamedicQuery
    {
        public ParamedicQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public ParamedicQuery(string joinAlias, out ParamedicQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "ParamedicQuery";
        }



        #region Explicit Casts

        public static explicit operator string(ParamedicQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator ParamedicQuery(string query)
        {
            return (ParamedicQuery)SerializeHelper.FromXml(query, typeof(ParamedicQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esParamedic : esEntity
    {
        public esParamedic()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string paramedicID)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(paramedicID);
            else
                return LoadByPrimaryKeyStoredProcedure(paramedicID);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string paramedicID)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(paramedicID);
            else
                return LoadByPrimaryKeyStoredProcedure(paramedicID);
        }

        private bool LoadByPrimaryKeyDynamic(string paramedicID)
        {
            ParamedicQuery query = new ParamedicQuery("pQ");
            query.Where(query.ParamedicID == paramedicID);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string paramedicID)
        {
            esParameters parms = new esParameters();
            parms.Add("ParamedicID", paramedicID);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to Paramedic.ParamedicID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParamedicID
        {
            get
            {
                return GetSystemString(ParamedicMetadata.ColumnNames.ParamedicID);
            }

            set
            {
                if (SetSystemString(ParamedicMetadata.ColumnNames.ParamedicID, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.ParamedicID);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.ParamedicName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParamedicName
        {
            get
            {
                return GetSystemString(ParamedicMetadata.ColumnNames.ParamedicName);
            }

            set
            {
                if (SetSystemString(ParamedicMetadata.ColumnNames.ParamedicName, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.ParamedicName);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.ParamedicInitial
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParamedicInitial
        {
            get
            {
                return GetSystemString(ParamedicMetadata.ColumnNames.ParamedicInitial);
            }

            set
            {
                if (SetSystemString(ParamedicMetadata.ColumnNames.ParamedicInitial, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.ParamedicInitial);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.DateOfBirth
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? DateOfBirth
        {
            get
            {
                return GetSystemDateTime(ParamedicMetadata.ColumnNames.DateOfBirth);
            }

            set
            {
                if (SetSystemDateTime(ParamedicMetadata.ColumnNames.DateOfBirth, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.DateOfBirth);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.SRParamedicType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRParamedicType
        {
            get
            {
                return GetSystemString(ParamedicMetadata.ColumnNames.SRParamedicType);
            }

            set
            {
                if (SetSystemString(ParamedicMetadata.ColumnNames.SRParamedicType, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.SRParamedicType);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.SRParamedicStatus
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRParamedicStatus
        {
            get
            {
                return GetSystemString(ParamedicMetadata.ColumnNames.SRParamedicStatus);
            }

            set
            {
                if (SetSystemString(ParamedicMetadata.ColumnNames.SRParamedicStatus, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.SRParamedicStatus);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.SRReligion
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRReligion
        {
            get
            {
                return GetSystemString(ParamedicMetadata.ColumnNames.SRReligion);
            }

            set
            {
                if (SetSystemString(ParamedicMetadata.ColumnNames.SRReligion, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.SRReligion);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.SRNationality
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRNationality
        {
            get
            {
                return GetSystemString(ParamedicMetadata.ColumnNames.SRNationality);
            }

            set
            {
                if (SetSystemString(ParamedicMetadata.ColumnNames.SRNationality, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.SRNationality);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.SRSpecialty
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRSpecialty
        {
            get
            {
                return GetSystemString(ParamedicMetadata.ColumnNames.SRSpecialty);
            }

            set
            {
                if (SetSystemString(ParamedicMetadata.ColumnNames.SRSpecialty, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.SRSpecialty);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.StreetName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string StreetName
        {
            get
            {
                return GetSystemString(ParamedicMetadata.ColumnNames.StreetName);
            }

            set
            {
                if (SetSystemString(ParamedicMetadata.ColumnNames.StreetName, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.StreetName);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.District
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string District
        {
            get
            {
                return GetSystemString(ParamedicMetadata.ColumnNames.District);
            }

            set
            {
                if (SetSystemString(ParamedicMetadata.ColumnNames.District, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.District);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.City
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string City
        {
            get
            {
                return GetSystemString(ParamedicMetadata.ColumnNames.City);
            }

            set
            {
                if (SetSystemString(ParamedicMetadata.ColumnNames.City, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.City);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.County
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string County
        {
            get
            {
                return GetSystemString(ParamedicMetadata.ColumnNames.County);
            }

            set
            {
                if (SetSystemString(ParamedicMetadata.ColumnNames.County, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.County);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.State
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string State
        {
            get
            {
                return GetSystemString(ParamedicMetadata.ColumnNames.State);
            }

            set
            {
                if (SetSystemString(ParamedicMetadata.ColumnNames.State, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.State);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.ZipCode
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ZipCode
        {
            get
            {
                return GetSystemString(ParamedicMetadata.ColumnNames.ZipCode);
            }

            set
            {
                if (SetSystemString(ParamedicMetadata.ColumnNames.ZipCode, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.ZipCode);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.PhoneNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PhoneNo
        {
            get
            {
                return GetSystemString(ParamedicMetadata.ColumnNames.PhoneNo);
            }

            set
            {
                if (SetSystemString(ParamedicMetadata.ColumnNames.PhoneNo, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.PhoneNo);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.FaxNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string FaxNo
        {
            get
            {
                return GetSystemString(ParamedicMetadata.ColumnNames.FaxNo);
            }

            set
            {
                if (SetSystemString(ParamedicMetadata.ColumnNames.FaxNo, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.FaxNo);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.Email
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Email
        {
            get
            {
                return GetSystemString(ParamedicMetadata.ColumnNames.Email);
            }

            set
            {
                if (SetSystemString(ParamedicMetadata.ColumnNames.Email, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.Email);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.MobilePhoneNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string MobilePhoneNo
        {
            get
            {
                return GetSystemString(ParamedicMetadata.ColumnNames.MobilePhoneNo);
            }

            set
            {
                if (SetSystemString(ParamedicMetadata.ColumnNames.MobilePhoneNo, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.MobilePhoneNo);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.LicenseNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LicenseNo
        {
            get
            {
                return GetSystemString(ParamedicMetadata.ColumnNames.LicenseNo);
            }

            set
            {
                if (SetSystemString(ParamedicMetadata.ColumnNames.LicenseNo, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.LicenseNo);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.TaxRegistrationNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TaxRegistrationNo
        {
            get
            {
                return GetSystemString(ParamedicMetadata.ColumnNames.TaxRegistrationNo);
            }

            set
            {
                if (SetSystemString(ParamedicMetadata.ColumnNames.TaxRegistrationNo, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.TaxRegistrationNo);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.IsPKP
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsPKP
        {
            get
            {
                return GetSystemBoolean(ParamedicMetadata.ColumnNames.IsPKP);
            }

            set
            {
                if (SetSystemBoolean(ParamedicMetadata.ColumnNames.IsPKP, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.IsPKP);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.IsAvailable
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsAvailable
        {
            get
            {
                return GetSystemBoolean(ParamedicMetadata.ColumnNames.IsAvailable);
            }

            set
            {
                if (SetSystemBoolean(ParamedicMetadata.ColumnNames.IsAvailable, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.IsAvailable);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.NotAvailableUntil
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? NotAvailableUntil
        {
            get
            {
                return GetSystemDateTime(ParamedicMetadata.ColumnNames.NotAvailableUntil);
            }

            set
            {
                if (SetSystemDateTime(ParamedicMetadata.ColumnNames.NotAvailableUntil, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.NotAvailableUntil);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.IsAnesthetist
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsAnesthetist
        {
            get
            {
                return GetSystemBoolean(ParamedicMetadata.ColumnNames.IsAnesthetist);
            }

            set
            {
                if (SetSystemBoolean(ParamedicMetadata.ColumnNames.IsAnesthetist, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.IsAnesthetist);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.IsAudiologist
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsAudiologist
        {
            get
            {
                return GetSystemBoolean(ParamedicMetadata.ColumnNames.IsAudiologist);
            }

            set
            {
                if (SetSystemBoolean(ParamedicMetadata.ColumnNames.IsAudiologist, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.IsAudiologist);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.IsActive
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsActive
        {
            get
            {
                return GetSystemBoolean(ParamedicMetadata.ColumnNames.IsActive);
            }

            set
            {
                if (SetSystemBoolean(ParamedicMetadata.ColumnNames.IsActive, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.IsActive);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.Notes
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Notes
        {
            get
            {
                return GetSystemString(ParamedicMetadata.ColumnNames.Notes);
            }

            set
            {
                if (SetSystemString(ParamedicMetadata.ColumnNames.Notes, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.Notes);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(ParamedicMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(ParamedicMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(ParamedicMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(ParamedicMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.RegistrationNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RegistrationNo
        {
            get
            {
                return GetSystemString(ParamedicMetadata.ColumnNames.RegistrationNo);
            }

            set
            {
                if (SetSystemString(ParamedicMetadata.ColumnNames.RegistrationNo, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.RegistrationNo);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.LicensePeriodeStart
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LicensePeriodeStart
        {
            get
            {
                return GetSystemDateTime(ParamedicMetadata.ColumnNames.LicensePeriodeStart);
            }

            set
            {
                if (SetSystemDateTime(ParamedicMetadata.ColumnNames.LicensePeriodeStart, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.LicensePeriodeStart);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.LicensePeriodeEnd
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LicensePeriodeEnd
        {
            get
            {
                return GetSystemDateTime(ParamedicMetadata.ColumnNames.LicensePeriodeEnd);
            }

            set
            {
                if (SetSystemDateTime(ParamedicMetadata.ColumnNames.LicensePeriodeEnd, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.LicensePeriodeEnd);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.IsParamedicFeeUsePercentage
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsParamedicFeeUsePercentage
        {
            get
            {
                return GetSystemBoolean(ParamedicMetadata.ColumnNames.IsParamedicFeeUsePercentage);
            }

            set
            {
                if (SetSystemBoolean(ParamedicMetadata.ColumnNames.IsParamedicFeeUsePercentage, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.IsParamedicFeeUsePercentage);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.ParamedicFeeAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? ParamedicFeeAmount
        {
            get
            {
                return GetSystemDecimal(ParamedicMetadata.ColumnNames.ParamedicFeeAmount);
            }

            set
            {
                if (SetSystemDecimal(ParamedicMetadata.ColumnNames.ParamedicFeeAmount, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.ParamedicFeeAmount);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.Bank
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Bank
        {
            get
            {
                return GetSystemString(ParamedicMetadata.ColumnNames.Bank);
            }

            set
            {
                if (SetSystemString(ParamedicMetadata.ColumnNames.Bank, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.Bank);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.BankAccount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string BankAccount
        {
            get
            {
                return GetSystemString(ParamedicMetadata.ColumnNames.BankAccount);
            }

            set
            {
                if (SetSystemString(ParamedicMetadata.ColumnNames.BankAccount, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.BankAccount);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.ParamedicFeeAmountReferral
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? ParamedicFeeAmountReferral
        {
            get
            {
                return GetSystemDecimal(ParamedicMetadata.ColumnNames.ParamedicFeeAmountReferral);
            }

            set
            {
                if (SetSystemDecimal(ParamedicMetadata.ColumnNames.ParamedicFeeAmountReferral, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.ParamedicFeeAmountReferral);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.IsUsingQue
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsUsingQue
        {
            get
            {
                return GetSystemBoolean(ParamedicMetadata.ColumnNames.IsUsingQue);
            }

            set
            {
                if (SetSystemBoolean(ParamedicMetadata.ColumnNames.IsUsingQue, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.IsUsingQue);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.SRParamedicRL1
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRParamedicRL1
        {
            get
            {
                return GetSystemString(ParamedicMetadata.ColumnNames.SRParamedicRL1);
            }

            set
            {
                if (SetSystemString(ParamedicMetadata.ColumnNames.SRParamedicRL1, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.SRParamedicRL1);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.IsDeductionFeeUsePercentage
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsDeductionFeeUsePercentage
        {
            get
            {
                return GetSystemBoolean(ParamedicMetadata.ColumnNames.IsDeductionFeeUsePercentage);
            }

            set
            {
                if (SetSystemBoolean(ParamedicMetadata.ColumnNames.IsDeductionFeeUsePercentage, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.IsDeductionFeeUsePercentage);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.DeductionFeeAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? DeductionFeeAmount
        {
            get
            {
                return GetSystemDecimal(ParamedicMetadata.ColumnNames.DeductionFeeAmount);
            }

            set
            {
                if (SetSystemDecimal(ParamedicMetadata.ColumnNames.DeductionFeeAmount, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.DeductionFeeAmount);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.DeductionFeeAmountReferral
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? DeductionFeeAmountReferral
        {
            get
            {
                return GetSystemDecimal(ParamedicMetadata.ColumnNames.DeductionFeeAmountReferral);
            }

            set
            {
                if (SetSystemDecimal(ParamedicMetadata.ColumnNames.DeductionFeeAmountReferral, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.DeductionFeeAmountReferral);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.ChartOfAccountIdAPParamedicFee
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? ChartOfAccountIdAPParamedicFee
        {
            get
            {
                return GetSystemInt32(ParamedicMetadata.ColumnNames.ChartOfAccountIdAPParamedicFee);
            }

            set
            {
                if (SetSystemInt32(ParamedicMetadata.ColumnNames.ChartOfAccountIdAPParamedicFee, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.ChartOfAccountIdAPParamedicFee);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.SubledgerIdAPParamedicFee
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? SubledgerIdAPParamedicFee
        {
            get
            {
                return GetSystemInt32(ParamedicMetadata.ColumnNames.SubledgerIdAPParamedicFee);
            }

            set
            {
                if (SetSystemInt32(ParamedicMetadata.ColumnNames.SubledgerIdAPParamedicFee, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.SubledgerIdAPParamedicFee);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.ParamedicFee
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? ParamedicFee
        {
            get
            {
                return GetSystemBoolean(ParamedicMetadata.ColumnNames.ParamedicFee);
            }

            set
            {
                if (SetSystemBoolean(ParamedicMetadata.ColumnNames.ParamedicFee, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.ParamedicFee);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.IsPrintInSlip
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsPrintInSlip
        {
            get
            {
                return GetSystemBoolean(ParamedicMetadata.ColumnNames.IsPrintInSlip);
            }

            set
            {
                if (SetSystemBoolean(ParamedicMetadata.ColumnNames.IsPrintInSlip, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.IsPrintInSlip);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.Bank2
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Bank2
        {
            get
            {
                return GetSystemString(ParamedicMetadata.ColumnNames.Bank2);
            }

            set
            {
                if (SetSystemString(ParamedicMetadata.ColumnNames.Bank2, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.Bank2);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.BankAccount2
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string BankAccount2
        {
            get
            {
                return GetSystemString(ParamedicMetadata.ColumnNames.BankAccount2);
            }

            set
            {
                if (SetSystemString(ParamedicMetadata.ColumnNames.BankAccount2, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.BankAccount2);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.Foto
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public byte[] Foto
        {
            get
            {
                return GetSystemByteArray(ParamedicMetadata.ColumnNames.Foto);
            }

            set
            {
                if (SetSystemByteArray(ParamedicMetadata.ColumnNames.Foto, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.Foto);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.GuaranteeFee
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? GuaranteeFee
        {
            get
            {
                return GetSystemDecimal(ParamedicMetadata.ColumnNames.GuaranteeFee);
            }

            set
            {
                if (SetSystemDecimal(ParamedicMetadata.ColumnNames.GuaranteeFee, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.GuaranteeFee);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.CoorporateGradeID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? CoorporateGradeID
        {
            get
            {
                return GetSystemInt32(ParamedicMetadata.ColumnNames.CoorporateGradeID);
            }

            set
            {
                if (SetSystemInt32(ParamedicMetadata.ColumnNames.CoorporateGradeID, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.CoorporateGradeID);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.CoorporateGradeValue
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? CoorporateGradeValue
        {
            get
            {
                return GetSystemDecimal(ParamedicMetadata.ColumnNames.CoorporateGradeValue);
            }

            set
            {
                if (SetSystemDecimal(ParamedicMetadata.ColumnNames.CoorporateGradeValue, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.CoorporateGradeValue);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.BankAccountName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string BankAccountName
        {
            get
            {
                return GetSystemString(ParamedicMetadata.ColumnNames.BankAccountName);
            }

            set
            {
                if (SetSystemString(ParamedicMetadata.ColumnNames.BankAccountName, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.BankAccountName);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.BankAccountName2
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string BankAccountName2
        {
            get
            {
                return GetSystemString(ParamedicMetadata.ColumnNames.BankAccountName2);
            }

            set
            {
                if (SetSystemString(ParamedicMetadata.ColumnNames.BankAccountName2, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.BankAccountName2);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.KTP
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Ktp
        {
            get
            {
                return GetSystemString(ParamedicMetadata.ColumnNames.Ktp);
            }

            set
            {
                if (SetSystemString(ParamedicMetadata.ColumnNames.Ktp, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.Ktp);
                }
            }
        }

        /// <summary>
        /// Maps to Paramedic.Ssn
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Ssn
        {
            get
            {
                return GetSystemString(ParamedicMetadata.ColumnNames.Ssn);
            }

            set
            {
                if (SetSystemString(ParamedicMetadata.ColumnNames.Ssn, value))
                {
                    OnPropertyChanged(ParamedicMetadata.PropertyNames.Ssn);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return ParamedicMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public ParamedicQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new ParamedicQuery("pQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(ParamedicQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(ParamedicQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((ParamedicQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private ParamedicQuery query;
    }



    [Serializable]
    abstract public partial class esParamedicCollection : esEntityCollection<Paramedic>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return ParamedicMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "ParamedicCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public ParamedicQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new ParamedicQuery("pQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(ParamedicQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new ParamedicQuery("pQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(ParamedicQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((ParamedicQuery)query);
        }

        #endregion

        private ParamedicQuery query;
    }



    [Serializable]
    abstract public partial class esParamedicQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return ParamedicMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "ParamedicID": return ParamedicID;
                case "ParamedicName": return ParamedicName;
                case "ParamedicInitial": return ParamedicInitial;
                case "DateOfBirth": return DateOfBirth;
                case "SRParamedicType": return SRParamedicType;
                case "SRParamedicStatus": return SRParamedicStatus;
                case "SRReligion": return SRReligion;
                case "SRNationality": return SRNationality;
                case "SRSpecialty": return SRSpecialty;
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
                case "LicenseNo": return LicenseNo;
                case "TaxRegistrationNo": return TaxRegistrationNo;
                case "IsPKP": return IsPKP;
                case "IsAvailable": return IsAvailable;
                case "NotAvailableUntil": return NotAvailableUntil;
                case "IsAnesthetist": return IsAnesthetist;
                case "IsAudiologist": return IsAudiologist;
                case "IsActive": return IsActive;
                case "Notes": return Notes;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "RegistrationNo": return RegistrationNo;
                case "LicensePeriodeStart": return LicensePeriodeStart;
                case "LicensePeriodeEnd": return LicensePeriodeEnd;
                case "IsParamedicFeeUsePercentage": return IsParamedicFeeUsePercentage;
                case "ParamedicFeeAmount": return ParamedicFeeAmount;
                case "Bank": return Bank;
                case "BankAccount": return BankAccount;
                case "ParamedicFeeAmountReferral": return ParamedicFeeAmountReferral;
                case "IsUsingQue": return IsUsingQue;
                case "SRParamedicRL1": return SRParamedicRL1;
                case "IsDeductionFeeUsePercentage": return IsDeductionFeeUsePercentage;
                case "DeductionFeeAmount": return DeductionFeeAmount;
                case "DeductionFeeAmountReferral": return DeductionFeeAmountReferral;
                case "ChartOfAccountIdAPParamedicFee": return ChartOfAccountIdAPParamedicFee;
                case "SubledgerIdAPParamedicFee": return SubledgerIdAPParamedicFee;
                case "ParamedicFee": return ParamedicFee;
                case "IsPrintInSlip": return IsPrintInSlip;
                case "Bank2": return Bank2;
                case "BankAccount2": return BankAccount2;
                case "Foto": return Foto;
                case "GuaranteeFee": return GuaranteeFee;
                case "CoorporateGradeID": return CoorporateGradeID;
                case "CoorporateGradeValue": return CoorporateGradeValue;
                case "BankAccountName": return BankAccountName;
                case "BankAccountName2": return BankAccountName2;
                case "Ktp": return Ktp;
                case "Ssn": return Ssn;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem ParamedicID
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.ParamedicID, esSystemType.String); }
        }

        public esQueryItem ParamedicName
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.ParamedicName, esSystemType.String); }
        }

        public esQueryItem ParamedicInitial
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.ParamedicInitial, esSystemType.String); }
        }

        public esQueryItem DateOfBirth
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.DateOfBirth, esSystemType.DateTime); }
        }

        public esQueryItem SRParamedicType
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.SRParamedicType, esSystemType.String); }
        }

        public esQueryItem SRParamedicStatus
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.SRParamedicStatus, esSystemType.String); }
        }

        public esQueryItem SRReligion
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.SRReligion, esSystemType.String); }
        }

        public esQueryItem SRNationality
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.SRNationality, esSystemType.String); }
        }

        public esQueryItem SRSpecialty
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.SRSpecialty, esSystemType.String); }
        }

        public esQueryItem StreetName
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.StreetName, esSystemType.String); }
        }

        public esQueryItem District
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.District, esSystemType.String); }
        }

        public esQueryItem City
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.City, esSystemType.String); }
        }

        public esQueryItem County
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.County, esSystemType.String); }
        }

        public esQueryItem State
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.State, esSystemType.String); }
        }

        public esQueryItem ZipCode
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.ZipCode, esSystemType.String); }
        }

        public esQueryItem PhoneNo
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.PhoneNo, esSystemType.String); }
        }

        public esQueryItem FaxNo
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.FaxNo, esSystemType.String); }
        }

        public esQueryItem Email
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.Email, esSystemType.String); }
        }

        public esQueryItem MobilePhoneNo
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.MobilePhoneNo, esSystemType.String); }
        }

        public esQueryItem LicenseNo
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.LicenseNo, esSystemType.String); }
        }

        public esQueryItem TaxRegistrationNo
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.TaxRegistrationNo, esSystemType.String); }
        }

        public esQueryItem IsPKP
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.IsPKP, esSystemType.Boolean); }
        }

        public esQueryItem IsAvailable
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.IsAvailable, esSystemType.Boolean); }
        }

        public esQueryItem NotAvailableUntil
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.NotAvailableUntil, esSystemType.DateTime); }
        }

        public esQueryItem IsAnesthetist
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.IsAnesthetist, esSystemType.Boolean); }
        }

        public esQueryItem IsAudiologist
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.IsAudiologist, esSystemType.Boolean); }
        }

        public esQueryItem IsActive
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.IsActive, esSystemType.Boolean); }
        }

        public esQueryItem Notes
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.Notes, esSystemType.String); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem RegistrationNo
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.RegistrationNo, esSystemType.String); }
        }

        public esQueryItem LicensePeriodeStart
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.LicensePeriodeStart, esSystemType.DateTime); }
        }

        public esQueryItem LicensePeriodeEnd
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.LicensePeriodeEnd, esSystemType.DateTime); }
        }

        public esQueryItem IsParamedicFeeUsePercentage
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.IsParamedicFeeUsePercentage, esSystemType.Boolean); }
        }

        public esQueryItem ParamedicFeeAmount
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.ParamedicFeeAmount, esSystemType.Decimal); }
        }

        public esQueryItem Bank
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.Bank, esSystemType.String); }
        }

        public esQueryItem BankAccount
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.BankAccount, esSystemType.String); }
        }

        public esQueryItem ParamedicFeeAmountReferral
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.ParamedicFeeAmountReferral, esSystemType.Decimal); }
        }

        public esQueryItem IsUsingQue
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.IsUsingQue, esSystemType.Boolean); }
        }

        public esQueryItem SRParamedicRL1
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.SRParamedicRL1, esSystemType.String); }
        }

        public esQueryItem IsDeductionFeeUsePercentage
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.IsDeductionFeeUsePercentage, esSystemType.Boolean); }
        }

        public esQueryItem DeductionFeeAmount
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.DeductionFeeAmount, esSystemType.Decimal); }
        }

        public esQueryItem DeductionFeeAmountReferral
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.DeductionFeeAmountReferral, esSystemType.Decimal); }
        }

        public esQueryItem ChartOfAccountIdAPParamedicFee
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.ChartOfAccountIdAPParamedicFee, esSystemType.Int32); }
        }

        public esQueryItem SubledgerIdAPParamedicFee
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.SubledgerIdAPParamedicFee, esSystemType.Int32); }
        }

        public esQueryItem ParamedicFee
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.ParamedicFee, esSystemType.Boolean); }
        }

        public esQueryItem IsPrintInSlip
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.IsPrintInSlip, esSystemType.Boolean); }
        }

        public esQueryItem Bank2
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.Bank2, esSystemType.String); }
        }

        public esQueryItem BankAccount2
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.BankAccount2, esSystemType.String); }
        }

        public esQueryItem Foto
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.Foto, esSystemType.ByteArray); }
        }

        public esQueryItem GuaranteeFee
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.GuaranteeFee, esSystemType.Decimal); }
        }

        public esQueryItem CoorporateGradeID
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.CoorporateGradeID, esSystemType.Int32); }
        }

        public esQueryItem CoorporateGradeValue
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.CoorporateGradeValue, esSystemType.Decimal); }
        }

        public esQueryItem BankAccountName
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.BankAccountName, esSystemType.String); }
        }

        public esQueryItem BankAccountName2
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.BankAccountName2, esSystemType.String); }
        }

        public esQueryItem Ktp
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.Ktp, esSystemType.String); }
        }

        public esQueryItem Ssn
        {
            get { return new esQueryItem(this, ParamedicMetadata.ColumnNames.Ssn, esSystemType.String); }
        }

        #endregion

    }



    [Serializable]
    public partial class ParamedicMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected ParamedicMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.ParamedicID, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParamedicID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParamedicName, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParamedicName;
            c.CharacterMaxLength = 255;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParamedicInitial, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParamedicInitial;
            c.CharacterMaxLength = 5;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DateOfBirth, 3, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.DateOfBirth;
            c.HasDefault = true;
            c.Default = @"(CONVERT([smalldatetime],'19000101',(105)))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRParamedicType, 4, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRParamedicType;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRParamedicStatus, 5, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRParamedicStatus;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRReligion, 6, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRReligion;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRNationality, 7, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRNationality;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRSpecialty, 8, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRSpecialty;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.StreetName, 9, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.StreetName;
            c.CharacterMaxLength = 250;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.District, 10, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.District;
            c.CharacterMaxLength = 50;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.City, 11, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.City;
            c.CharacterMaxLength = 50;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.County, 12, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.County;
            c.CharacterMaxLength = 50;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.State, 13, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.State;
            c.CharacterMaxLength = 50;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ZipCode, 14, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ZipCode;
            c.CharacterMaxLength = 15;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PhoneNo, 15, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PhoneNo;
            c.CharacterMaxLength = 50;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FaxNo, 16, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.FaxNo;
            c.CharacterMaxLength = 50;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Email, 17, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Email;
            c.CharacterMaxLength = 50;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.MobilePhoneNo, 18, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.MobilePhoneNo;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LicenseNo, 19, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LicenseNo;
            c.CharacterMaxLength = 50;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TaxRegistrationNo, 20, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TaxRegistrationNo;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsPKP, 21, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsPKP;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsAvailable, 22, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsAvailable;
            c.HasDefault = true;
            c.Default = @"(CONVERT([bit],(1),0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.NotAvailableUntil, 23, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.NotAvailableUntil;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsAnesthetist, 24, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsAnesthetist;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsAudiologist, 25, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsAudiologist;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsActive, 26, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsActive;
            c.HasDefault = true;
            c.Default = @"(CONVERT([bit],(1),0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Notes, 27, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Notes;
            c.CharacterMaxLength = 4000;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 28, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 29, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 40;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RegistrationNo, 30, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RegistrationNo;
            c.CharacterMaxLength = 70;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LicensePeriodeStart, 31, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LicensePeriodeStart;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LicensePeriodeEnd, 32, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LicensePeriodeEnd;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsParamedicFeeUsePercentage, 33, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsParamedicFeeUsePercentage;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParamedicFeeAmount, 34, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.ParamedicFeeAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Bank, 35, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Bank;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.BankAccount, 36, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.BankAccount;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParamedicFeeAmountReferral, 37, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.ParamedicFeeAmountReferral;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsUsingQue, 38, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsUsingQue;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRParamedicRL1, 39, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRParamedicRL1;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsDeductionFeeUsePercentage, 40, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsDeductionFeeUsePercentage;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DeductionFeeAmount, 41, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.DeductionFeeAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DeductionFeeAmountReferral, 42, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.DeductionFeeAmountReferral;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ChartOfAccountIdAPParamedicFee, 43, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.ChartOfAccountIdAPParamedicFee;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SubledgerIdAPParamedicFee, 44, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.SubledgerIdAPParamedicFee;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParamedicFee, 45, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.ParamedicFee;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsPrintInSlip, 46, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsPrintInSlip;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Bank2, 47, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Bank2;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.BankAccount2, 48, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.BankAccount2;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Foto, 49, typeof(byte[]), esSystemType.ByteArray);
            c.PropertyName = PropertyNames.Foto;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.GuaranteeFee, 50, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.GuaranteeFee;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CoorporateGradeID, 51, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.CoorporateGradeID;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CoorporateGradeValue, 52, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.CoorporateGradeValue;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.BankAccountName, 53, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.BankAccountName;
            c.CharacterMaxLength = 200;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.BankAccountName2, 54, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.BankAccountName2;
            c.CharacterMaxLength = 200;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Ktp, 55, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Ktp;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Ssn, 56, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Ssn;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public ParamedicMetadata Meta()
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
            public const string ParamedicID = "ParamedicID";
            public const string ParamedicName = "ParamedicName";
            public const string ParamedicInitial = "ParamedicInitial";
            public const string DateOfBirth = "DateOfBirth";
            public const string SRParamedicType = "SRParamedicType";
            public const string SRParamedicStatus = "SRParamedicStatus";
            public const string SRReligion = "SRReligion";
            public const string SRNationality = "SRNationality";
            public const string SRSpecialty = "SRSpecialty";
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
            public const string LicenseNo = "LicenseNo";
            public const string TaxRegistrationNo = "TaxRegistrationNo";
            public const string IsPKP = "IsPKP";
            public const string IsAvailable = "IsAvailable";
            public const string NotAvailableUntil = "NotAvailableUntil";
            public const string IsAnesthetist = "IsAnesthetist";
            public const string IsAudiologist = "IsAudiologist";
            public const string IsActive = "IsActive";
            public const string Notes = "Notes";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string RegistrationNo = "RegistrationNo";
            public const string LicensePeriodeStart = "LicensePeriodeStart";
            public const string LicensePeriodeEnd = "LicensePeriodeEnd";
            public const string IsParamedicFeeUsePercentage = "IsParamedicFeeUsePercentage";
            public const string ParamedicFeeAmount = "ParamedicFeeAmount";
            public const string Bank = "Bank";
            public const string BankAccount = "BankAccount";
            public const string ParamedicFeeAmountReferral = "ParamedicFeeAmountReferral";
            public const string IsUsingQue = "IsUsingQue";
            public const string SRParamedicRL1 = "SRParamedicRL1";
            public const string IsDeductionFeeUsePercentage = "IsDeductionFeeUsePercentage";
            public const string DeductionFeeAmount = "DeductionFeeAmount";
            public const string DeductionFeeAmountReferral = "DeductionFeeAmountReferral";
            public const string ChartOfAccountIdAPParamedicFee = "ChartOfAccountIdAPParamedicFee";
            public const string SubledgerIdAPParamedicFee = "SubledgerIdAPParamedicFee";
            public const string ParamedicFee = "ParamedicFee";
            public const string IsPrintInSlip = "IsPrintInSlip";
            public const string Bank2 = "Bank2";
            public const string BankAccount2 = "BankAccount2";
            public const string Foto = "Foto";
            public const string GuaranteeFee = "GuaranteeFee";
            public const string CoorporateGradeID = "CoorporateGradeID";
            public const string CoorporateGradeValue = "CoorporateGradeValue";
            public const string BankAccountName = "BankAccountName";
            public const string BankAccountName2 = "BankAccountName2";
            public const string Ktp = "KTP";
            public const string Ssn = "Ssn";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string ParamedicID = "ParamedicID";
            public const string ParamedicName = "ParamedicName";
            public const string ParamedicInitial = "ParamedicInitial";
            public const string DateOfBirth = "DateOfBirth";
            public const string SRParamedicType = "SRParamedicType";
            public const string SRParamedicStatus = "SRParamedicStatus";
            public const string SRReligion = "SRReligion";
            public const string SRNationality = "SRNationality";
            public const string SRSpecialty = "SRSpecialty";
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
            public const string LicenseNo = "LicenseNo";
            public const string TaxRegistrationNo = "TaxRegistrationNo";
            public const string IsPKP = "IsPKP";
            public const string IsAvailable = "IsAvailable";
            public const string NotAvailableUntil = "NotAvailableUntil";
            public const string IsAnesthetist = "IsAnesthetist";
            public const string IsAudiologist = "IsAudiologist";
            public const string IsActive = "IsActive";
            public const string Notes = "Notes";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string RegistrationNo = "RegistrationNo";
            public const string LicensePeriodeStart = "LicensePeriodeStart";
            public const string LicensePeriodeEnd = "LicensePeriodeEnd";
            public const string IsParamedicFeeUsePercentage = "IsParamedicFeeUsePercentage";
            public const string ParamedicFeeAmount = "ParamedicFeeAmount";
            public const string Bank = "Bank";
            public const string BankAccount = "BankAccount";
            public const string ParamedicFeeAmountReferral = "ParamedicFeeAmountReferral";
            public const string IsUsingQue = "IsUsingQue";
            public const string SRParamedicRL1 = "SRParamedicRL1";
            public const string IsDeductionFeeUsePercentage = "IsDeductionFeeUsePercentage";
            public const string DeductionFeeAmount = "DeductionFeeAmount";
            public const string DeductionFeeAmountReferral = "DeductionFeeAmountReferral";
            public const string ChartOfAccountIdAPParamedicFee = "ChartOfAccountIdAPParamedicFee";
            public const string SubledgerIdAPParamedicFee = "SubledgerIdAPParamedicFee";
            public const string ParamedicFee = "ParamedicFee";
            public const string IsPrintInSlip = "IsPrintInSlip";
            public const string Bank2 = "Bank2";
            public const string BankAccount2 = "BankAccount2";
            public const string Foto = "Foto";
            public const string GuaranteeFee = "GuaranteeFee";
            public const string CoorporateGradeID = "CoorporateGradeID";
            public const string CoorporateGradeValue = "CoorporateGradeValue";
            public const string BankAccountName = "BankAccountName";
            public const string BankAccountName2 = "BankAccountName2";
            public const string Ktp = "Ktp";
            public const string Ssn = "Ssn";
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
            lock (typeof(ParamedicMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new ParamedicMetadata();
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


                meta.AddTypeMap("ParamedicID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ParamedicName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ParamedicInitial", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("DateOfBirth", new esTypeMap("smalldatetime", "System.DateTime"));
                meta.AddTypeMap("SRParamedicType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRParamedicStatus", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRReligion", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRNationality", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRSpecialty", new esTypeMap("varchar", "System.String"));
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
                meta.AddTypeMap("LicenseNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TaxRegistrationNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsPKP", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsAvailable", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("NotAvailableUntil", new esTypeMap("smalldatetime", "System.DateTime"));
                meta.AddTypeMap("IsAnesthetist", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsAudiologist", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsActive", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("Notes", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("RegistrationNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LicensePeriodeStart", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LicensePeriodeEnd", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("IsParamedicFeeUsePercentage", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ParamedicFeeAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("Bank", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("BankAccount", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ParamedicFeeAmountReferral", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("IsUsingQue", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("SRParamedicRL1", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsDeductionFeeUsePercentage", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("DeductionFeeAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("DeductionFeeAmountReferral", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("ChartOfAccountIdAPParamedicFee", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("SubledgerIdAPParamedicFee", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("ParamedicFee", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsPrintInSlip", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("Bank2", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("BankAccount2", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Foto", new esTypeMap("image", "System.Byte[]"));
                meta.AddTypeMap("GuaranteeFee", new esTypeMap("decimal", "System.Decimal"));
                meta.AddTypeMap("CoorporateGradeID", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("CoorporateGradeValue", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("BankAccountName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("BankAccountName2", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Ktp", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Ssn", new esTypeMap("varchar", "System.String"));



                meta.Source = "Paramedic";
                meta.Destination = "Paramedic";

                meta.spInsert = "proc_ParamedicInsert";
                meta.spUpdate = "proc_ParamedicUpdate";
                meta.spDelete = "proc_ParamedicDelete";
                meta.spLoadAll = "proc_ParamedicLoadAll";
                meta.spLoadByPrimaryKey = "proc_ParamedicLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private ParamedicMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
