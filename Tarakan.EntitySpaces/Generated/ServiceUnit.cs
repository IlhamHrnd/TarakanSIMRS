
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 9/19/2024 3:39:05 PM
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
    /// Encapsulates the 'ServiceUnit' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(ServiceUnit))]
    [XmlType("ServiceUnit")]
    public partial class ServiceUnit : esServiceUnit
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new ServiceUnit();
        }

        #region Static Quick Access Methods
        static public void Delete(string serviceUnitID)
        {
            var obj = new ServiceUnit();
            obj.ServiceUnitID = serviceUnitID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string serviceUnitID, esSqlAccessType sqlAccessType)
        {
            var obj = new ServiceUnit();
            obj.ServiceUnitID = serviceUnitID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("ServiceUnitCollection")]
    public partial class ServiceUnitCollection : esServiceUnitCollection, IEnumerable<ServiceUnit>
    {
        public ServiceUnit FindByPrimaryKey(string serviceUnitID)
        {
            return this.SingleOrDefault(e => e.ServiceUnitID == serviceUnitID);
        }



    }



    [Serializable]
    public partial class ServiceUnitQuery : esServiceUnitQuery
    {
        public ServiceUnitQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public ServiceUnitQuery(string joinAlias, out ServiceUnitQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "ServiceUnitQuery";
        }



        #region Explicit Casts

        public static explicit operator string(ServiceUnitQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator ServiceUnitQuery(string query)
        {
            return (ServiceUnitQuery)SerializeHelper.FromXml(query, typeof(ServiceUnitQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esServiceUnit : esEntity
    {
        public esServiceUnit()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string serviceUnitID)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(serviceUnitID);
            else
                return LoadByPrimaryKeyStoredProcedure(serviceUnitID);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string serviceUnitID)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(serviceUnitID);
            else
                return LoadByPrimaryKeyStoredProcedure(serviceUnitID);
        }

        private bool LoadByPrimaryKeyDynamic(string serviceUnitID)
        {
            ServiceUnitQuery query = new ServiceUnitQuery("suQ");
            query.Where(query.ServiceUnitID == serviceUnitID);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string serviceUnitID)
        {
            esParameters parms = new esParameters();
            parms.Add("ServiceUnitID", serviceUnitID);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to ServiceUnit.ServiceUnitID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ServiceUnitID
        {
            get
            {
                return GetSystemString(ServiceUnitMetadata.ColumnNames.ServiceUnitID);
            }

            set
            {
                if (SetSystemString(ServiceUnitMetadata.ColumnNames.ServiceUnitID, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.ServiceUnitID);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.DepartmentID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DepartmentID
        {
            get
            {
                return GetSystemString(ServiceUnitMetadata.ColumnNames.DepartmentID);
            }

            set
            {
                if (SetSystemString(ServiceUnitMetadata.ColumnNames.DepartmentID, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.DepartmentID);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.ServiceUnitName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ServiceUnitName
        {
            get
            {
                return GetSystemString(ServiceUnitMetadata.ColumnNames.ServiceUnitName);
            }

            set
            {
                if (SetSystemString(ServiceUnitMetadata.ColumnNames.ServiceUnitName, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.ServiceUnitName);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.ShortName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ShortName
        {
            get
            {
                return GetSystemString(ServiceUnitMetadata.ColumnNames.ShortName);
            }

            set
            {
                if (SetSystemString(ServiceUnitMetadata.ColumnNames.ShortName, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.ShortName);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.ServiceUnitOfficer
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ServiceUnitOfficer
        {
            get
            {
                return GetSystemString(ServiceUnitMetadata.ColumnNames.ServiceUnitOfficer);
            }

            set
            {
                if (SetSystemString(ServiceUnitMetadata.ColumnNames.ServiceUnitOfficer, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.ServiceUnitOfficer);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.SRRegistrationType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRRegistrationType
        {
            get
            {
                return GetSystemString(ServiceUnitMetadata.ColumnNames.SRRegistrationType);
            }

            set
            {
                if (SetSystemString(ServiceUnitMetadata.ColumnNames.SRRegistrationType, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.SRRegistrationType);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.IsUsingJobOrder
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsUsingJobOrder
        {
            get
            {
                return GetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsUsingJobOrder);
            }

            set
            {
                if (SetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsUsingJobOrder, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.IsUsingJobOrder);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.IsPatientTransaction
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsPatientTransaction
        {
            get
            {
                return GetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsPatientTransaction);
            }

            set
            {
                if (SetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsPatientTransaction, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.IsPatientTransaction);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.IsTransactionEntry
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsTransactionEntry
        {
            get
            {
                return GetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsTransactionEntry);
            }

            set
            {
                if (SetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsTransactionEntry, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.IsTransactionEntry);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.IsDispensaryUnit
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsDispensaryUnit
        {
            get
            {
                return GetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsDispensaryUnit);
            }

            set
            {
                if (SetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsDispensaryUnit, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.IsDispensaryUnit);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.IsPurchasingUnit
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsPurchasingUnit
        {
            get
            {
                return GetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsPurchasingUnit);
            }

            set
            {
                if (SetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsPurchasingUnit, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.IsPurchasingUnit);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.IsGenerateMedicalNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsGenerateMedicalNo
        {
            get
            {
                return GetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsGenerateMedicalNo);
            }

            set
            {
                if (SetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsGenerateMedicalNo, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.IsGenerateMedicalNo);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.IsActive
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsActive
        {
            get
            {
                return GetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsActive);
            }

            set
            {
                if (SetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsActive, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.IsActive);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.ChartOfAccountIdIncome
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? ChartOfAccountIdIncome
        {
            get
            {
                return GetSystemInt32(ServiceUnitMetadata.ColumnNames.ChartOfAccountIdIncome);
            }

            set
            {
                if (SetSystemInt32(ServiceUnitMetadata.ColumnNames.ChartOfAccountIdIncome, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.ChartOfAccountIdIncome);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.SubledgerIdIncome
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? SubledgerIdIncome
        {
            get
            {
                return GetSystemInt32(ServiceUnitMetadata.ColumnNames.SubledgerIdIncome);
            }

            set
            {
                if (SetSystemInt32(ServiceUnitMetadata.ColumnNames.SubledgerIdIncome, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.SubledgerIdIncome);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.ChartOfAccountIdAcrual
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? ChartOfAccountIdAcrual
        {
            get
            {
                return GetSystemInt32(ServiceUnitMetadata.ColumnNames.ChartOfAccountIdAcrual);
            }

            set
            {
                if (SetSystemInt32(ServiceUnitMetadata.ColumnNames.ChartOfAccountIdAcrual, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.ChartOfAccountIdAcrual);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.SubledgerIdAcrual
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? SubledgerIdAcrual
        {
            get
            {
                return GetSystemInt32(ServiceUnitMetadata.ColumnNames.SubledgerIdAcrual);
            }

            set
            {
                if (SetSystemInt32(ServiceUnitMetadata.ColumnNames.SubledgerIdAcrual, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.SubledgerIdAcrual);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.ChartOfAccountIdDiscount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? ChartOfAccountIdDiscount
        {
            get
            {
                return GetSystemInt32(ServiceUnitMetadata.ColumnNames.ChartOfAccountIdDiscount);
            }

            set
            {
                if (SetSystemInt32(ServiceUnitMetadata.ColumnNames.ChartOfAccountIdDiscount, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.ChartOfAccountIdDiscount);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.SubledgerIdDiscount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? SubledgerIdDiscount
        {
            get
            {
                return GetSystemInt32(ServiceUnitMetadata.ColumnNames.SubledgerIdDiscount);
            }

            set
            {
                if (SetSystemInt32(ServiceUnitMetadata.ColumnNames.SubledgerIdDiscount, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.SubledgerIdDiscount);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(ServiceUnitMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(ServiceUnitMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(ServiceUnitMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(ServiceUnitMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.ChartOfAccountIdCost
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? ChartOfAccountIdCost
        {
            get
            {
                return GetSystemInt32(ServiceUnitMetadata.ColumnNames.ChartOfAccountIdCost);
            }

            set
            {
                if (SetSystemInt32(ServiceUnitMetadata.ColumnNames.ChartOfAccountIdCost, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.ChartOfAccountIdCost);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.SubledgerIdCost
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? SubledgerIdCost
        {
            get
            {
                return GetSystemInt32(ServiceUnitMetadata.ColumnNames.SubledgerIdCost);
            }

            set
            {
                if (SetSystemInt32(ServiceUnitMetadata.ColumnNames.SubledgerIdCost, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.SubledgerIdCost);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.IsDirectPayment
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsDirectPayment
        {
            get
            {
                return GetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsDirectPayment);
            }

            set
            {
                if (SetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsDirectPayment, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.IsDirectPayment);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.ChartOfAccountIdCostNonMedic
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? ChartOfAccountIdCostNonMedic
        {
            get
            {
                return GetSystemInt32(ServiceUnitMetadata.ColumnNames.ChartOfAccountIdCostNonMedic);
            }

            set
            {
                if (SetSystemInt32(ServiceUnitMetadata.ColumnNames.ChartOfAccountIdCostNonMedic, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.ChartOfAccountIdCostNonMedic);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.SubledgerIdCostNonMedic
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? SubledgerIdCostNonMedic
        {
            get
            {
                return GetSystemInt32(ServiceUnitMetadata.ColumnNames.SubledgerIdCostNonMedic);
            }

            set
            {
                if (SetSystemInt32(ServiceUnitMetadata.ColumnNames.SubledgerIdCostNonMedic, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.SubledgerIdCostNonMedic);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.SRGenderType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRGenderType
        {
            get
            {
                return GetSystemString(ServiceUnitMetadata.ColumnNames.SRGenderType);
            }

            set
            {
                if (SetSystemString(ServiceUnitMetadata.ColumnNames.SRGenderType, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.SRGenderType);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.ServiceUnitPharmacyID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ServiceUnitPharmacyID
        {
            get
            {
                return GetSystemString(ServiceUnitMetadata.ColumnNames.ServiceUnitPharmacyID);
            }

            set
            {
                if (SetSystemString(ServiceUnitMetadata.ColumnNames.ServiceUnitPharmacyID, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.ServiceUnitPharmacyID);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.ChartOfAccountIdCostParamedicFee
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? ChartOfAccountIdCostParamedicFee
        {
            get
            {
                return GetSystemInt32(ServiceUnitMetadata.ColumnNames.ChartOfAccountIdCostParamedicFee);
            }

            set
            {
                if (SetSystemInt32(ServiceUnitMetadata.ColumnNames.ChartOfAccountIdCostParamedicFee, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.ChartOfAccountIdCostParamedicFee);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.SubledgerIdCostParamedicFee
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? SubledgerIdCostParamedicFee
        {
            get
            {
                return GetSystemInt32(ServiceUnitMetadata.ColumnNames.SubledgerIdCostParamedicFee);
            }

            set
            {
                if (SetSystemInt32(ServiceUnitMetadata.ColumnNames.SubledgerIdCostParamedicFee, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.SubledgerIdCostParamedicFee);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.SRAssessmentType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRAssessmentType
        {
            get
            {
                return GetSystemString(ServiceUnitMetadata.ColumnNames.SRAssessmentType);
            }

            set
            {
                if (SetSystemString(ServiceUnitMetadata.ColumnNames.SRAssessmentType, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.SRAssessmentType);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.IsNeedConfirmationOfAttendance
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsNeedConfirmationOfAttendance
        {
            get
            {
                return GetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsNeedConfirmationOfAttendance);
            }

            set
            {
                if (SetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsNeedConfirmationOfAttendance, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.IsNeedConfirmationOfAttendance);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.SRServiceUnitGroup
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRServiceUnitGroup
        {
            get
            {
                return GetSystemString(ServiceUnitMetadata.ColumnNames.SRServiceUnitGroup);
            }

            set
            {
                if (SetSystemString(ServiceUnitMetadata.ColumnNames.SRServiceUnitGroup, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.SRServiceUnitGroup);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.LocationPharmacyID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LocationPharmacyID
        {
            get
            {
                return GetSystemString(ServiceUnitMetadata.ColumnNames.LocationPharmacyID);
            }

            set
            {
                if (SetSystemString(ServiceUnitMetadata.ColumnNames.LocationPharmacyID, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.LocationPharmacyID);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.Email
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Email
        {
            get
            {
                return GetSystemString(ServiceUnitMetadata.ColumnNames.Email);
            }

            set
            {
                if (SetSystemString(ServiceUnitMetadata.ColumnNames.Email, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.Email);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.ServiceUnitPorID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ServiceUnitPorID
        {
            get
            {
                return GetSystemString(ServiceUnitMetadata.ColumnNames.ServiceUnitPorID);
            }

            set
            {
                if (SetSystemString(ServiceUnitMetadata.ColumnNames.ServiceUnitPorID, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.ServiceUnitPorID);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.LocationPorID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LocationPorID
        {
            get
            {
                return GetSystemString(ServiceUnitMetadata.ColumnNames.LocationPorID);
            }

            set
            {
                if (SetSystemString(ServiceUnitMetadata.ColumnNames.LocationPorID, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.LocationPorID);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.ChartOfAccountIdPpnIn
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? ChartOfAccountIdPpnIn
        {
            get
            {
                return GetSystemInt32(ServiceUnitMetadata.ColumnNames.ChartOfAccountIdPpnIn);
            }

            set
            {
                if (SetSystemInt32(ServiceUnitMetadata.ColumnNames.ChartOfAccountIdPpnIn, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.ChartOfAccountIdPpnIn);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.SubledgerIdPpnIn
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? SubledgerIdPpnIn
        {
            get
            {
                return GetSystemInt32(ServiceUnitMetadata.ColumnNames.SubledgerIdPpnIn);
            }

            set
            {
                if (SetSystemInt32(ServiceUnitMetadata.ColumnNames.SubledgerIdPpnIn, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.SubledgerIdPpnIn);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.IsShowOnKiosk
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsShowOnKiosk
        {
            get
            {
                return GetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsShowOnKiosk);
            }

            set
            {
                if (SetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsShowOnKiosk, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.IsShowOnKiosk);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.DefaultChargeClassID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DefaultChargeClassID
        {
            get
            {
                return GetSystemString(ServiceUnitMetadata.ColumnNames.DefaultChargeClassID);
            }

            set
            {
                if (SetSystemString(ServiceUnitMetadata.ColumnNames.DefaultChargeClassID, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.DefaultChargeClassID);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.CustomDisplay
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string CustomDisplay
        {
            get
            {
                return GetSystemString(ServiceUnitMetadata.ColumnNames.CustomDisplay);
            }

            set
            {
                if (SetSystemString(ServiceUnitMetadata.ColumnNames.CustomDisplay, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.CustomDisplay);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.IsAllowAccessPatientWithServiceUnitParamedic
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsAllowAccessPatientWithServiceUnitParamedic
        {
            get
            {
                return GetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsAllowAccessPatientWithServiceUnitParamedic);
            }

            set
            {
                if (SetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsAllowAccessPatientWithServiceUnitParamedic, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.IsAllowAccessPatientWithServiceUnitParamedic);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.MedicalFileFolderColor
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string MedicalFileFolderColor
        {
            get
            {
                return GetSystemString(ServiceUnitMetadata.ColumnNames.MedicalFileFolderColor);
            }

            set
            {
                if (SetSystemString(ServiceUnitMetadata.ColumnNames.MedicalFileFolderColor, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.MedicalFileFolderColor);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.SRInpatientClassificationUnit
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRInpatientClassificationUnit
        {
            get
            {
                return GetSystemString(ServiceUnitMetadata.ColumnNames.SRInpatientClassificationUnit);
            }

            set
            {
                if (SetSystemString(ServiceUnitMetadata.ColumnNames.SRInpatientClassificationUnit, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.SRInpatientClassificationUnit);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.IsHelpdesk
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsHelpdesk
        {
            get
            {
                return GetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsHelpdesk);
            }

            set
            {
                if (SetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsHelpdesk, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.IsHelpdesk);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.SRBuilding
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRBuilding
        {
            get
            {
                return GetSystemString(ServiceUnitMetadata.ColumnNames.SRBuilding);
            }

            set
            {
                if (SetSystemString(ServiceUnitMetadata.ColumnNames.SRBuilding, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.SRBuilding);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.SoundFilePath
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SoundFilePath
        {
            get
            {
                return GetSystemString(ServiceUnitMetadata.ColumnNames.SoundFilePath);
            }

            set
            {
                if (SetSystemString(ServiceUnitMetadata.ColumnNames.SoundFilePath, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.SoundFilePath);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.QueueCode
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string QueueCode
        {
            get
            {
                return GetSystemString(ServiceUnitMetadata.ColumnNames.QueueCode);
            }

            set
            {
                if (SetSystemString(ServiceUnitMetadata.ColumnNames.QueueCode, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.QueueCode);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.SRQueueingLocation_Reg
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRQueueingLocationReg
        {
            get
            {
                return GetSystemString(ServiceUnitMetadata.ColumnNames.SRQueueingLocationReg);
            }

            set
            {
                if (SetSystemString(ServiceUnitMetadata.ColumnNames.SRQueueingLocationReg, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.SRQueueingLocationReg);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.SRQueueingLocation_Poli
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRQueueingLocationPoli
        {
            get
            {
                return GetSystemString(ServiceUnitMetadata.ColumnNames.SRQueueingLocationPoli);
            }

            set
            {
                if (SetSystemString(ServiceUnitMetadata.ColumnNames.SRQueueingLocationPoli, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.SRQueueingLocationPoli);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.SRClassification
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRClassification
        {
            get
            {
                return GetSystemString(ServiceUnitMetadata.ColumnNames.SRClassification);
            }

            set
            {
                if (SetSystemString(ServiceUnitMetadata.ColumnNames.SRClassification, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.SRClassification);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.SRClassificationRoom
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRClassificationRoom
        {
            get
            {
                return GetSystemString(ServiceUnitMetadata.ColumnNames.SRClassificationRoom);
            }

            set
            {
                if (SetSystemString(ServiceUnitMetadata.ColumnNames.SRClassificationRoom, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.SRClassificationRoom);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.QueueName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string QueueName
        {
            get
            {
                return GetSystemString(ServiceUnitMetadata.ColumnNames.QueueName);
            }

            set
            {
                if (SetSystemString(ServiceUnitMetadata.ColumnNames.QueueName, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.QueueName);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.IsDiagnostic
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsDiagnostic
        {
            get
            {
                return GetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsDiagnostic);
            }

            set
            {
                if (SetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsDiagnostic, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.IsDiagnostic);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.IsAdmitting
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsAdmitting
        {
            get
            {
                return GetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsAdmitting);
            }

            set
            {
                if (SetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsAdmitting, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.IsAdmitting);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.SRCardexMonitoring
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRCardexMonitoring
        {
            get
            {
                return GetSystemString(ServiceUnitMetadata.ColumnNames.SRCardexMonitoring);
            }

            set
            {
                if (SetSystemString(ServiceUnitMetadata.ColumnNames.SRCardexMonitoring, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.SRCardexMonitoring);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.IsReservation
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsReservation
        {
            get
            {
                return GetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsReservation);
            }

            set
            {
                if (SetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsReservation, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.IsReservation);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnit.IsClinicalDiagnoseMandatory
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsClinicalDiagnoseMandatory
        {
            get
            {
                return GetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsClinicalDiagnoseMandatory);
            }

            set
            {
                if (SetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsClinicalDiagnoseMandatory, value))
                {
                    OnPropertyChanged(ServiceUnitMetadata.PropertyNames.IsClinicalDiagnoseMandatory);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return ServiceUnitMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public ServiceUnitQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new ServiceUnitQuery("suQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(ServiceUnitQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(ServiceUnitQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((ServiceUnitQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private ServiceUnitQuery query;
    }



    [Serializable]
    abstract public partial class esServiceUnitCollection : esEntityCollection<ServiceUnit>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return ServiceUnitMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "ServiceUnitCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public ServiceUnitQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new ServiceUnitQuery("suQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(ServiceUnitQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new ServiceUnitQuery("suQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(ServiceUnitQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((ServiceUnitQuery)query);
        }

        #endregion

        private ServiceUnitQuery query;
    }



    [Serializable]
    abstract public partial class esServiceUnitQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return ServiceUnitMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "ServiceUnitID": return ServiceUnitID;
                case "DepartmentID": return DepartmentID;
                case "ServiceUnitName": return ServiceUnitName;
                case "ShortName": return ShortName;
                case "ServiceUnitOfficer": return ServiceUnitOfficer;
                case "SRRegistrationType": return SRRegistrationType;
                case "IsUsingJobOrder": return IsUsingJobOrder;
                case "IsPatientTransaction": return IsPatientTransaction;
                case "IsTransactionEntry": return IsTransactionEntry;
                case "IsDispensaryUnit": return IsDispensaryUnit;
                case "IsPurchasingUnit": return IsPurchasingUnit;
                case "IsGenerateMedicalNo": return IsGenerateMedicalNo;
                case "IsActive": return IsActive;
                case "ChartOfAccountIdIncome": return ChartOfAccountIdIncome;
                case "SubledgerIdIncome": return SubledgerIdIncome;
                case "ChartOfAccountIdAcrual": return ChartOfAccountIdAcrual;
                case "SubledgerIdAcrual": return SubledgerIdAcrual;
                case "ChartOfAccountIdDiscount": return ChartOfAccountIdDiscount;
                case "SubledgerIdDiscount": return SubledgerIdDiscount;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "ChartOfAccountIdCost": return ChartOfAccountIdCost;
                case "SubledgerIdCost": return SubledgerIdCost;
                case "IsDirectPayment": return IsDirectPayment;
                case "ChartOfAccountIdCostNonMedic": return ChartOfAccountIdCostNonMedic;
                case "SubledgerIdCostNonMedic": return SubledgerIdCostNonMedic;
                case "SRGenderType": return SRGenderType;
                case "ServiceUnitPharmacyID": return ServiceUnitPharmacyID;
                case "ChartOfAccountIdCostParamedicFee": return ChartOfAccountIdCostParamedicFee;
                case "SubledgerIdCostParamedicFee": return SubledgerIdCostParamedicFee;
                case "SRAssessmentType": return SRAssessmentType;
                case "IsNeedConfirmationOfAttendance": return IsNeedConfirmationOfAttendance;
                case "SRServiceUnitGroup": return SRServiceUnitGroup;
                case "LocationPharmacyID": return LocationPharmacyID;
                case "Email": return Email;
                case "ServiceUnitPorID": return ServiceUnitPorID;
                case "LocationPorID": return LocationPorID;
                case "ChartOfAccountIdPpnIn": return ChartOfAccountIdPpnIn;
                case "SubledgerIdPpnIn": return SubledgerIdPpnIn;
                case "IsShowOnKiosk": return IsShowOnKiosk;
                case "DefaultChargeClassID": return DefaultChargeClassID;
                case "CustomDisplay": return CustomDisplay;
                case "IsAllowAccessPatientWithServiceUnitParamedic": return IsAllowAccessPatientWithServiceUnitParamedic;
                case "MedicalFileFolderColor": return MedicalFileFolderColor;
                case "SRInpatientClassificationUnit": return SRInpatientClassificationUnit;
                case "IsHelpdesk": return IsHelpdesk;
                case "SRBuilding": return SRBuilding;
                case "SoundFilePath": return SoundFilePath;
                case "QueueCode": return QueueCode;
                case "SRQueueingLocationReg": return SRQueueingLocationReg;
                case "SRQueueingLocationPoli": return SRQueueingLocationPoli;
                case "SRClassification": return SRClassification;
                case "SRClassificationRoom": return SRClassificationRoom;
                case "QueueName": return QueueName;
                case "IsDiagnostic": return IsDiagnostic;
                case "IsAdmitting": return IsAdmitting;
                case "SRCardexMonitoring": return SRCardexMonitoring;
                case "IsReservation": return IsReservation;
                case "IsClinicalDiagnoseMandatory": return IsClinicalDiagnoseMandatory;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem ServiceUnitID
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.ServiceUnitID, esSystemType.String); }
        }

        public esQueryItem DepartmentID
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.DepartmentID, esSystemType.String); }
        }

        public esQueryItem ServiceUnitName
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.ServiceUnitName, esSystemType.String); }
        }

        public esQueryItem ShortName
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.ShortName, esSystemType.String); }
        }

        public esQueryItem ServiceUnitOfficer
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.ServiceUnitOfficer, esSystemType.String); }
        }

        public esQueryItem SRRegistrationType
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.SRRegistrationType, esSystemType.String); }
        }

        public esQueryItem IsUsingJobOrder
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.IsUsingJobOrder, esSystemType.Boolean); }
        }

        public esQueryItem IsPatientTransaction
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.IsPatientTransaction, esSystemType.Boolean); }
        }

        public esQueryItem IsTransactionEntry
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.IsTransactionEntry, esSystemType.Boolean); }
        }

        public esQueryItem IsDispensaryUnit
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.IsDispensaryUnit, esSystemType.Boolean); }
        }

        public esQueryItem IsPurchasingUnit
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.IsPurchasingUnit, esSystemType.Boolean); }
        }

        public esQueryItem IsGenerateMedicalNo
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.IsGenerateMedicalNo, esSystemType.Boolean); }
        }

        public esQueryItem IsActive
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.IsActive, esSystemType.Boolean); }
        }

        public esQueryItem ChartOfAccountIdIncome
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.ChartOfAccountIdIncome, esSystemType.Int32); }
        }

        public esQueryItem SubledgerIdIncome
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.SubledgerIdIncome, esSystemType.Int32); }
        }

        public esQueryItem ChartOfAccountIdAcrual
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.ChartOfAccountIdAcrual, esSystemType.Int32); }
        }

        public esQueryItem SubledgerIdAcrual
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.SubledgerIdAcrual, esSystemType.Int32); }
        }

        public esQueryItem ChartOfAccountIdDiscount
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.ChartOfAccountIdDiscount, esSystemType.Int32); }
        }

        public esQueryItem SubledgerIdDiscount
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.SubledgerIdDiscount, esSystemType.Int32); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem ChartOfAccountIdCost
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.ChartOfAccountIdCost, esSystemType.Int32); }
        }

        public esQueryItem SubledgerIdCost
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.SubledgerIdCost, esSystemType.Int32); }
        }

        public esQueryItem IsDirectPayment
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.IsDirectPayment, esSystemType.Boolean); }
        }

        public esQueryItem ChartOfAccountIdCostNonMedic
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.ChartOfAccountIdCostNonMedic, esSystemType.Int32); }
        }

        public esQueryItem SubledgerIdCostNonMedic
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.SubledgerIdCostNonMedic, esSystemType.Int32); }
        }

        public esQueryItem SRGenderType
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.SRGenderType, esSystemType.String); }
        }

        public esQueryItem ServiceUnitPharmacyID
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.ServiceUnitPharmacyID, esSystemType.String); }
        }

        public esQueryItem ChartOfAccountIdCostParamedicFee
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.ChartOfAccountIdCostParamedicFee, esSystemType.Int32); }
        }

        public esQueryItem SubledgerIdCostParamedicFee
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.SubledgerIdCostParamedicFee, esSystemType.Int32); }
        }

        public esQueryItem SRAssessmentType
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.SRAssessmentType, esSystemType.String); }
        }

        public esQueryItem IsNeedConfirmationOfAttendance
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.IsNeedConfirmationOfAttendance, esSystemType.Boolean); }
        }

        public esQueryItem SRServiceUnitGroup
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.SRServiceUnitGroup, esSystemType.String); }
        }

        public esQueryItem LocationPharmacyID
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.LocationPharmacyID, esSystemType.String); }
        }

        public esQueryItem Email
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.Email, esSystemType.String); }
        }

        public esQueryItem ServiceUnitPorID
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.ServiceUnitPorID, esSystemType.String); }
        }

        public esQueryItem LocationPorID
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.LocationPorID, esSystemType.String); }
        }

        public esQueryItem ChartOfAccountIdPpnIn
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.ChartOfAccountIdPpnIn, esSystemType.Int32); }
        }

        public esQueryItem SubledgerIdPpnIn
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.SubledgerIdPpnIn, esSystemType.Int32); }
        }

        public esQueryItem IsShowOnKiosk
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.IsShowOnKiosk, esSystemType.Boolean); }
        }

        public esQueryItem DefaultChargeClassID
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.DefaultChargeClassID, esSystemType.String); }
        }

        public esQueryItem CustomDisplay
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.CustomDisplay, esSystemType.String); }
        }

        public esQueryItem IsAllowAccessPatientWithServiceUnitParamedic
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.IsAllowAccessPatientWithServiceUnitParamedic, esSystemType.Boolean); }
        }

        public esQueryItem MedicalFileFolderColor
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.MedicalFileFolderColor, esSystemType.String); }
        }

        public esQueryItem SRInpatientClassificationUnit
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.SRInpatientClassificationUnit, esSystemType.String); }
        }

        public esQueryItem IsHelpdesk
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.IsHelpdesk, esSystemType.Boolean); }
        }

        public esQueryItem SRBuilding
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.SRBuilding, esSystemType.String); }
        }

        public esQueryItem SoundFilePath
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.SoundFilePath, esSystemType.String); }
        }

        public esQueryItem QueueCode
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.QueueCode, esSystemType.String); }
        }

        public esQueryItem SRQueueingLocationReg
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.SRQueueingLocationReg, esSystemType.String); }
        }

        public esQueryItem SRQueueingLocationPoli
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.SRQueueingLocationPoli, esSystemType.String); }
        }

        public esQueryItem SRClassification
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.SRClassification, esSystemType.String); }
        }

        public esQueryItem SRClassificationRoom
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.SRClassificationRoom, esSystemType.String); }
        }

        public esQueryItem QueueName
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.QueueName, esSystemType.String); }
        }

        public esQueryItem IsDiagnostic
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.IsDiagnostic, esSystemType.Boolean); }
        }

        public esQueryItem IsAdmitting
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.IsAdmitting, esSystemType.Boolean); }
        }

        public esQueryItem SRCardexMonitoring
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.SRCardexMonitoring, esSystemType.String); }
        }

        public esQueryItem IsReservation
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.IsReservation, esSystemType.Boolean); }
        }

        public esQueryItem IsClinicalDiagnoseMandatory
        {
            get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.IsClinicalDiagnoseMandatory, esSystemType.Boolean); }
        }

        #endregion

    }



    [Serializable]
    public partial class ServiceUnitMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected ServiceUnitMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.ServiceUnitID, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ServiceUnitID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DepartmentID, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DepartmentID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ServiceUnitName, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ServiceUnitName;
            c.CharacterMaxLength = 100;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ShortName, 3, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ShortName;
            c.CharacterMaxLength = 35;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ServiceUnitOfficer, 4, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ServiceUnitOfficer;
            c.CharacterMaxLength = 100;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRRegistrationType, 5, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRRegistrationType;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsUsingJobOrder, 6, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsUsingJobOrder;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsPatientTransaction, 7, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsPatientTransaction;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsTransactionEntry, 8, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsTransactionEntry;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsDispensaryUnit, 9, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsDispensaryUnit;
            c.HasDefault = true;
            c.Default = @"((0))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsPurchasingUnit, 10, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsPurchasingUnit;
            c.HasDefault = true;
            c.Default = @"((0))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsGenerateMedicalNo, 11, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsGenerateMedicalNo;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsActive, 12, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsActive;
            c.HasDefault = true;
            c.Default = @"((1))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ChartOfAccountIdIncome, 13, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.ChartOfAccountIdIncome;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SubledgerIdIncome, 14, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.SubledgerIdIncome;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ChartOfAccountIdAcrual, 15, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.ChartOfAccountIdAcrual;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SubledgerIdAcrual, 16, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.SubledgerIdAcrual;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ChartOfAccountIdDiscount, 17, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.ChartOfAccountIdDiscount;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SubledgerIdDiscount, 18, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.SubledgerIdDiscount;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 19, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 20, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 40;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ChartOfAccountIdCost, 21, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.ChartOfAccountIdCost;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SubledgerIdCost, 22, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.SubledgerIdCost;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsDirectPayment, 23, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsDirectPayment;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ChartOfAccountIdCostNonMedic, 24, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.ChartOfAccountIdCostNonMedic;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SubledgerIdCostNonMedic, 25, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.SubledgerIdCostNonMedic;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRGenderType, 26, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRGenderType;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ServiceUnitPharmacyID, 27, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ServiceUnitPharmacyID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ChartOfAccountIdCostParamedicFee, 28, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.ChartOfAccountIdCostParamedicFee;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SubledgerIdCostParamedicFee, 29, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.SubledgerIdCostParamedicFee;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRAssessmentType, 30, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRAssessmentType;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsNeedConfirmationOfAttendance, 31, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsNeedConfirmationOfAttendance;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRServiceUnitGroup, 32, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRServiceUnitGroup;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LocationPharmacyID, 33, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LocationPharmacyID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Email, 34, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Email;
            c.CharacterMaxLength = 300;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ServiceUnitPorID, 35, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ServiceUnitPorID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LocationPorID, 36, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LocationPorID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ChartOfAccountIdPpnIn, 37, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.ChartOfAccountIdPpnIn;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SubledgerIdPpnIn, 38, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.SubledgerIdPpnIn;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsShowOnKiosk, 39, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsShowOnKiosk;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DefaultChargeClassID, 40, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DefaultChargeClassID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CustomDisplay, 41, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.CustomDisplay;
            c.CharacterMaxLength = 500;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsAllowAccessPatientWithServiceUnitParamedic, 42, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsAllowAccessPatientWithServiceUnitParamedic;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.MedicalFileFolderColor, 43, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.MedicalFileFolderColor;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRInpatientClassificationUnit, 44, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRInpatientClassificationUnit;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsHelpdesk, 45, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsHelpdesk;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRBuilding, 46, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRBuilding;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SoundFilePath, 47, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SoundFilePath;
            c.CharacterMaxLength = 500;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.QueueCode, 48, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.QueueCode;
            c.CharacterMaxLength = 3;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRQueueingLocationReg, 49, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRQueueingLocationReg;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRQueueingLocationPoli, 50, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRQueueingLocationPoli;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRClassification, 51, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRClassification;
            c.CharacterMaxLength = 200;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRClassificationRoom, 52, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRClassificationRoom;
            c.CharacterMaxLength = 200;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.QueueName, 53, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.QueueName;
            c.CharacterMaxLength = 200;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsDiagnostic, 54, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsDiagnostic;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsAdmitting, 55, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsAdmitting;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRCardexMonitoring, 56, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRCardexMonitoring;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsReservation, 57, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsReservation;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsClinicalDiagnoseMandatory, 58, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsClinicalDiagnoseMandatory;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public ServiceUnitMetadata Meta()
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
            public const string ServiceUnitID = "ServiceUnitID";
            public const string DepartmentID = "DepartmentID";
            public const string ServiceUnitName = "ServiceUnitName";
            public const string ShortName = "ShortName";
            public const string ServiceUnitOfficer = "ServiceUnitOfficer";
            public const string SRRegistrationType = "SRRegistrationType";
            public const string IsUsingJobOrder = "IsUsingJobOrder";
            public const string IsPatientTransaction = "IsPatientTransaction";
            public const string IsTransactionEntry = "IsTransactionEntry";
            public const string IsDispensaryUnit = "IsDispensaryUnit";
            public const string IsPurchasingUnit = "IsPurchasingUnit";
            public const string IsGenerateMedicalNo = "IsGenerateMedicalNo";
            public const string IsActive = "IsActive";
            public const string ChartOfAccountIdIncome = "ChartOfAccountIdIncome";
            public const string SubledgerIdIncome = "SubledgerIdIncome";
            public const string ChartOfAccountIdAcrual = "ChartOfAccountIdAcrual";
            public const string SubledgerIdAcrual = "SubledgerIdAcrual";
            public const string ChartOfAccountIdDiscount = "ChartOfAccountIdDiscount";
            public const string SubledgerIdDiscount = "SubledgerIdDiscount";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string ChartOfAccountIdCost = "ChartOfAccountIdCost";
            public const string SubledgerIdCost = "SubledgerIdCost";
            public const string IsDirectPayment = "IsDirectPayment";
            public const string ChartOfAccountIdCostNonMedic = "ChartOfAccountIdCostNonMedic";
            public const string SubledgerIdCostNonMedic = "SubledgerIdCostNonMedic";
            public const string SRGenderType = "SRGenderType";
            public const string ServiceUnitPharmacyID = "ServiceUnitPharmacyID";
            public const string ChartOfAccountIdCostParamedicFee = "ChartOfAccountIdCostParamedicFee";
            public const string SubledgerIdCostParamedicFee = "SubledgerIdCostParamedicFee";
            public const string SRAssessmentType = "SRAssessmentType";
            public const string IsNeedConfirmationOfAttendance = "IsNeedConfirmationOfAttendance";
            public const string SRServiceUnitGroup = "SRServiceUnitGroup";
            public const string LocationPharmacyID = "LocationPharmacyID";
            public const string Email = "Email";
            public const string ServiceUnitPorID = "ServiceUnitPorID";
            public const string LocationPorID = "LocationPorID";
            public const string ChartOfAccountIdPpnIn = "ChartOfAccountIdPpnIn";
            public const string SubledgerIdPpnIn = "SubledgerIdPpnIn";
            public const string IsShowOnKiosk = "IsShowOnKiosk";
            public const string DefaultChargeClassID = "DefaultChargeClassID";
            public const string CustomDisplay = "CustomDisplay";
            public const string IsAllowAccessPatientWithServiceUnitParamedic = "IsAllowAccessPatientWithServiceUnitParamedic";
            public const string MedicalFileFolderColor = "MedicalFileFolderColor";
            public const string SRInpatientClassificationUnit = "SRInpatientClassificationUnit";
            public const string IsHelpdesk = "IsHelpdesk";
            public const string SRBuilding = "SRBuilding";
            public const string SoundFilePath = "SoundFilePath";
            public const string QueueCode = "QueueCode";
            public const string SRQueueingLocationReg = "SRQueueingLocation_Reg";
            public const string SRQueueingLocationPoli = "SRQueueingLocation_Poli";
            public const string SRClassification = "SRClassification";
            public const string SRClassificationRoom = "SRClassificationRoom";
            public const string QueueName = "QueueName";
            public const string IsDiagnostic = "IsDiagnostic";
            public const string IsAdmitting = "IsAdmitting";
            public const string SRCardexMonitoring = "SRCardexMonitoring";
            public const string IsReservation = "IsReservation";
            public const string IsClinicalDiagnoseMandatory = "IsClinicalDiagnoseMandatory";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string ServiceUnitID = "ServiceUnitID";
            public const string DepartmentID = "DepartmentID";
            public const string ServiceUnitName = "ServiceUnitName";
            public const string ShortName = "ShortName";
            public const string ServiceUnitOfficer = "ServiceUnitOfficer";
            public const string SRRegistrationType = "SRRegistrationType";
            public const string IsUsingJobOrder = "IsUsingJobOrder";
            public const string IsPatientTransaction = "IsPatientTransaction";
            public const string IsTransactionEntry = "IsTransactionEntry";
            public const string IsDispensaryUnit = "IsDispensaryUnit";
            public const string IsPurchasingUnit = "IsPurchasingUnit";
            public const string IsGenerateMedicalNo = "IsGenerateMedicalNo";
            public const string IsActive = "IsActive";
            public const string ChartOfAccountIdIncome = "ChartOfAccountIdIncome";
            public const string SubledgerIdIncome = "SubledgerIdIncome";
            public const string ChartOfAccountIdAcrual = "ChartOfAccountIdAcrual";
            public const string SubledgerIdAcrual = "SubledgerIdAcrual";
            public const string ChartOfAccountIdDiscount = "ChartOfAccountIdDiscount";
            public const string SubledgerIdDiscount = "SubledgerIdDiscount";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string ChartOfAccountIdCost = "ChartOfAccountIdCost";
            public const string SubledgerIdCost = "SubledgerIdCost";
            public const string IsDirectPayment = "IsDirectPayment";
            public const string ChartOfAccountIdCostNonMedic = "ChartOfAccountIdCostNonMedic";
            public const string SubledgerIdCostNonMedic = "SubledgerIdCostNonMedic";
            public const string SRGenderType = "SRGenderType";
            public const string ServiceUnitPharmacyID = "ServiceUnitPharmacyID";
            public const string ChartOfAccountIdCostParamedicFee = "ChartOfAccountIdCostParamedicFee";
            public const string SubledgerIdCostParamedicFee = "SubledgerIdCostParamedicFee";
            public const string SRAssessmentType = "SRAssessmentType";
            public const string IsNeedConfirmationOfAttendance = "IsNeedConfirmationOfAttendance";
            public const string SRServiceUnitGroup = "SRServiceUnitGroup";
            public const string LocationPharmacyID = "LocationPharmacyID";
            public const string Email = "Email";
            public const string ServiceUnitPorID = "ServiceUnitPorID";
            public const string LocationPorID = "LocationPorID";
            public const string ChartOfAccountIdPpnIn = "ChartOfAccountIdPpnIn";
            public const string SubledgerIdPpnIn = "SubledgerIdPpnIn";
            public const string IsShowOnKiosk = "IsShowOnKiosk";
            public const string DefaultChargeClassID = "DefaultChargeClassID";
            public const string CustomDisplay = "CustomDisplay";
            public const string IsAllowAccessPatientWithServiceUnitParamedic = "IsAllowAccessPatientWithServiceUnitParamedic";
            public const string MedicalFileFolderColor = "MedicalFileFolderColor";
            public const string SRInpatientClassificationUnit = "SRInpatientClassificationUnit";
            public const string IsHelpdesk = "IsHelpdesk";
            public const string SRBuilding = "SRBuilding";
            public const string SoundFilePath = "SoundFilePath";
            public const string QueueCode = "QueueCode";
            public const string SRQueueingLocationReg = "SRQueueingLocationReg";
            public const string SRQueueingLocationPoli = "SRQueueingLocationPoli";
            public const string SRClassification = "SRClassification";
            public const string SRClassificationRoom = "SRClassificationRoom";
            public const string QueueName = "QueueName";
            public const string IsDiagnostic = "IsDiagnostic";
            public const string IsAdmitting = "IsAdmitting";
            public const string SRCardexMonitoring = "SRCardexMonitoring";
            public const string IsReservation = "IsReservation";
            public const string IsClinicalDiagnoseMandatory = "IsClinicalDiagnoseMandatory";
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
            lock (typeof(ServiceUnitMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new ServiceUnitMetadata();
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


                meta.AddTypeMap("ServiceUnitID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("DepartmentID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ServiceUnitName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ShortName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ServiceUnitOfficer", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRRegistrationType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsUsingJobOrder", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsPatientTransaction", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsTransactionEntry", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsDispensaryUnit", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsPurchasingUnit", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsGenerateMedicalNo", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsActive", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ChartOfAccountIdIncome", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("SubledgerIdIncome", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("ChartOfAccountIdAcrual", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("SubledgerIdAcrual", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("ChartOfAccountIdDiscount", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("SubledgerIdDiscount", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ChartOfAccountIdCost", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("SubledgerIdCost", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("IsDirectPayment", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ChartOfAccountIdCostNonMedic", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("SubledgerIdCostNonMedic", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("SRGenderType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ServiceUnitPharmacyID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ChartOfAccountIdCostParamedicFee", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("SubledgerIdCostParamedicFee", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("SRAssessmentType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsNeedConfirmationOfAttendance", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("SRServiceUnitGroup", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LocationPharmacyID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Email", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ServiceUnitPorID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LocationPorID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ChartOfAccountIdPpnIn", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("SubledgerIdPpnIn", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("IsShowOnKiosk", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("DefaultChargeClassID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CustomDisplay", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsAllowAccessPatientWithServiceUnitParamedic", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("MedicalFileFolderColor", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRInpatientClassificationUnit", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsHelpdesk", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("SRBuilding", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SoundFilePath", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("QueueCode", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRQueueingLocationReg", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRQueueingLocationPoli", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRClassification", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRClassificationRoom", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("QueueName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsDiagnostic", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsAdmitting", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("SRCardexMonitoring", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsReservation", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsClinicalDiagnoseMandatory", new esTypeMap("bit", "System.Boolean"));



                meta.Source = "ServiceUnit";
                meta.Destination = "ServiceUnit";

                meta.spInsert = "proc_ServiceUnitInsert";
                meta.spUpdate = "proc_ServiceUnitUpdate";
                meta.spDelete = "proc_ServiceUnitDelete";
                meta.spLoadAll = "proc_ServiceUnitLoadAll";
                meta.spLoadByPrimaryKey = "proc_ServiceUnitLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private ServiceUnitMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
