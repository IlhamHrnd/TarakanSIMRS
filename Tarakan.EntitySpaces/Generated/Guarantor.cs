
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 2/11/2025 11:17:11 AM
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
    /// Encapsulates the 'Guarantor' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(Guarantor))]
    [XmlType("Guarantor")]
    public partial class Guarantor : esGuarantor
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new Guarantor();
        }

        #region Static Quick Access Methods
        static public void Delete(string guarantorID)
        {
            var obj = new Guarantor();
            obj.GuarantorID = guarantorID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string guarantorID, esSqlAccessType sqlAccessType)
        {
            var obj = new Guarantor();
            obj.GuarantorID = guarantorID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("GuarantorCollection")]
    public partial class GuarantorCollection : esGuarantorCollection, IEnumerable<Guarantor>
    {
        public Guarantor FindByPrimaryKey(string guarantorID)
        {
            return this.SingleOrDefault(e => e.GuarantorID == guarantorID);
        }



    }



    [Serializable]
    public partial class GuarantorQuery : esGuarantorQuery
    {
        public GuarantorQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public GuarantorQuery(string joinAlias, out GuarantorQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "GuarantorQuery";
        }



        #region Explicit Casts

        public static explicit operator string(GuarantorQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator GuarantorQuery(string query)
        {
            return (GuarantorQuery)SerializeHelper.FromXml(query, typeof(GuarantorQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esGuarantor : esEntity
    {
        public esGuarantor()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string guarantorID)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(guarantorID);
            else
                return LoadByPrimaryKeyStoredProcedure(guarantorID);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string guarantorID)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(guarantorID);
            else
                return LoadByPrimaryKeyStoredProcedure(guarantorID);
        }

        private bool LoadByPrimaryKeyDynamic(string guarantorID)
        {
            GuarantorQuery query = new GuarantorQuery("gQ");
            query.Where(query.GuarantorID == guarantorID);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string guarantorID)
        {
            esParameters parms = new esParameters();
            parms.Add("GuarantorID", guarantorID);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to Guarantor.GuarantorID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string GuarantorID
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.GuarantorID);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.GuarantorID, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.GuarantorID);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.GuarantorName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string GuarantorName
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.GuarantorName);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.GuarantorName, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.GuarantorName);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.ShortName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ShortName
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.ShortName);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.ShortName, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.ShortName);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.SRGuarantorType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRGuarantorType
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.SRGuarantorType);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.SRGuarantorType, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.SRGuarantorType);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.ContractNumber
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ContractNumber
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.ContractNumber);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.ContractNumber, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.ContractNumber);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.ContractStart
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? ContractStart
        {
            get
            {
                return GetSystemDateTime(GuarantorMetadata.ColumnNames.ContractStart);
            }

            set
            {
                if (SetSystemDateTime(GuarantorMetadata.ColumnNames.ContractStart, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.ContractStart);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.ContractEnd
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? ContractEnd
        {
            get
            {
                return GetSystemDateTime(GuarantorMetadata.ColumnNames.ContractEnd);
            }

            set
            {
                if (SetSystemDateTime(GuarantorMetadata.ColumnNames.ContractEnd, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.ContractEnd);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.ContractSummary
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ContractSummary
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.ContractSummary);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.ContractSummary, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.ContractSummary);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.ContactPerson
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ContactPerson
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.ContactPerson);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.ContactPerson, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.ContactPerson);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.IsActive
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsActive
        {
            get
            {
                return GetSystemBoolean(GuarantorMetadata.ColumnNames.IsActive);
            }

            set
            {
                if (SetSystemBoolean(GuarantorMetadata.ColumnNames.IsActive, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.IsActive);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.SRBusinessMethod
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRBusinessMethod
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.SRBusinessMethod);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.SRBusinessMethod, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.SRBusinessMethod);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.SRTariffType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRTariffType
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.SRTariffType);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.SRTariffType, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.SRTariffType);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.SRGuarantorRuleType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRGuarantorRuleType
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.SRGuarantorRuleType);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.SRGuarantorRuleType, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.SRGuarantorRuleType);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.IsValueInPercent
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsValueInPercent
        {
            get
            {
                return GetSystemBoolean(GuarantorMetadata.ColumnNames.IsValueInPercent);
            }

            set
            {
                if (SetSystemBoolean(GuarantorMetadata.ColumnNames.IsValueInPercent, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.IsValueInPercent);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.AmountValue
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? AmountValue
        {
            get
            {
                return GetSystemDecimal(GuarantorMetadata.ColumnNames.AmountValue);
            }

            set
            {
                if (SetSystemDecimal(GuarantorMetadata.ColumnNames.AmountValue, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.AmountValue);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.AdminPercentage
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? AdminPercentage
        {
            get
            {
                return GetSystemDecimal(GuarantorMetadata.ColumnNames.AdminPercentage);
            }

            set
            {
                if (SetSystemDecimal(GuarantorMetadata.ColumnNames.AdminPercentage, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.AdminPercentage);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.AdminAmountLimit
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? AdminAmountLimit
        {
            get
            {
                return GetSystemDecimal(GuarantorMetadata.ColumnNames.AdminAmountLimit);
            }

            set
            {
                if (SetSystemDecimal(GuarantorMetadata.ColumnNames.AdminAmountLimit, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.AdminAmountLimit);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.StreetName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string StreetName
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.StreetName);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.StreetName, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.StreetName);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.District
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string District
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.District);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.District, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.District);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.City
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string City
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.City);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.City, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.City);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.County
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string County
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.County);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.County, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.County);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.State
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string State
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.State);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.State, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.State);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.ZipCode
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ZipCode
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.ZipCode);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.ZipCode, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.ZipCode);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.PhoneNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PhoneNo
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.PhoneNo);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.PhoneNo, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.PhoneNo);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.FaxNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string FaxNo
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.FaxNo);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.FaxNo, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.FaxNo);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.Email
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Email
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.Email);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.Email, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.Email);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.MobilePhoneNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string MobilePhoneNo
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.MobilePhoneNo);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.MobilePhoneNo, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.MobilePhoneNo);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.ChartOfAccountId
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? ChartOfAccountId
        {
            get
            {
                return GetSystemInt32(GuarantorMetadata.ColumnNames.ChartOfAccountId);
            }

            set
            {
                if (SetSystemInt32(GuarantorMetadata.ColumnNames.ChartOfAccountId, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.ChartOfAccountId);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.SubLedgerId
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? SubLedgerId
        {
            get
            {
                return GetSystemInt32(GuarantorMetadata.ColumnNames.SubLedgerId);
            }

            set
            {
                if (SetSystemInt32(GuarantorMetadata.ColumnNames.SubLedgerId, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.SubLedgerId);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(GuarantorMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(GuarantorMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.IsIncludeItemMedical
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsIncludeItemMedical
        {
            get
            {
                return GetSystemBoolean(GuarantorMetadata.ColumnNames.IsIncludeItemMedical);
            }

            set
            {
                if (SetSystemBoolean(GuarantorMetadata.ColumnNames.IsIncludeItemMedical, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.IsIncludeItemMedical);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.IsIncludeItemNonMedical
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsIncludeItemNonMedical
        {
            get
            {
                return GetSystemBoolean(GuarantorMetadata.ColumnNames.IsIncludeItemNonMedical);
            }

            set
            {
                if (SetSystemBoolean(GuarantorMetadata.ColumnNames.IsIncludeItemNonMedical, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.IsIncludeItemNonMedical);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.IsIncludeItemOptic
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsIncludeItemOptic
        {
            get
            {
                return GetSystemBoolean(GuarantorMetadata.ColumnNames.IsIncludeItemOptic);
            }

            set
            {
                if (SetSystemBoolean(GuarantorMetadata.ColumnNames.IsIncludeItemOptic, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.IsIncludeItemOptic);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.IsIncludeItemMedicalToGuarantor
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsIncludeItemMedicalToGuarantor
        {
            get
            {
                return GetSystemBoolean(GuarantorMetadata.ColumnNames.IsIncludeItemMedicalToGuarantor);
            }

            set
            {
                if (SetSystemBoolean(GuarantorMetadata.ColumnNames.IsIncludeItemMedicalToGuarantor, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.IsIncludeItemMedicalToGuarantor);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.IsIncludeItemNonMedicalToGuarantor
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsIncludeItemNonMedicalToGuarantor
        {
            get
            {
                return GetSystemBoolean(GuarantorMetadata.ColumnNames.IsIncludeItemNonMedicalToGuarantor);
            }

            set
            {
                if (SetSystemBoolean(GuarantorMetadata.ColumnNames.IsIncludeItemNonMedicalToGuarantor, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.IsIncludeItemNonMedicalToGuarantor);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.IsIncludeItemOpticToGuarantor
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsIncludeItemOpticToGuarantor
        {
            get
            {
                return GetSystemBoolean(GuarantorMetadata.ColumnNames.IsIncludeItemOpticToGuarantor);
            }

            set
            {
                if (SetSystemBoolean(GuarantorMetadata.ColumnNames.IsIncludeItemOpticToGuarantor, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.IsIncludeItemOpticToGuarantor);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.IsCoverInpatient
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsCoverInpatient
        {
            get
            {
                return GetSystemBoolean(GuarantorMetadata.ColumnNames.IsCoverInpatient);
            }

            set
            {
                if (SetSystemBoolean(GuarantorMetadata.ColumnNames.IsCoverInpatient, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.IsCoverInpatient);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.IsCoverOutpatient
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsCoverOutpatient
        {
            get
            {
                return GetSystemBoolean(GuarantorMetadata.ColumnNames.IsCoverOutpatient);
            }

            set
            {
                if (SetSystemBoolean(GuarantorMetadata.ColumnNames.IsCoverOutpatient, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.IsCoverOutpatient);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.ItemMedicMarginPercentage
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? ItemMedicMarginPercentage
        {
            get
            {
                return GetSystemDecimal(GuarantorMetadata.ColumnNames.ItemMedicMarginPercentage);
            }

            set
            {
                if (SetSystemDecimal(GuarantorMetadata.ColumnNames.ItemMedicMarginPercentage, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.ItemMedicMarginPercentage);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.ItemMedicMarginID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ItemMedicMarginID
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.ItemMedicMarginID);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.ItemMedicMarginID, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.ItemMedicMarginID);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.ItemNonMedicMarginPercentage
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? ItemNonMedicMarginPercentage
        {
            get
            {
                return GetSystemDecimal(GuarantorMetadata.ColumnNames.ItemNonMedicMarginPercentage);
            }

            set
            {
                if (SetSystemDecimal(GuarantorMetadata.ColumnNames.ItemNonMedicMarginPercentage, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.ItemNonMedicMarginPercentage);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.ItemNonMedicMarginID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ItemNonMedicMarginID
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.ItemNonMedicMarginID);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.ItemNonMedicMarginID, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.ItemNonMedicMarginID);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.GuarantorHeaderID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string GuarantorHeaderID
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.GuarantorHeaderID);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.GuarantorHeaderID, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.GuarantorHeaderID);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.IsIncludeAdminValue
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsIncludeAdminValue
        {
            get
            {
                return GetSystemBoolean(GuarantorMetadata.ColumnNames.IsIncludeAdminValue);
            }

            set
            {
                if (SetSystemBoolean(GuarantorMetadata.ColumnNames.IsIncludeAdminValue, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.IsIncludeAdminValue);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.AdminValueMinimum
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? AdminValueMinimum
        {
            get
            {
                return GetSystemDecimal(GuarantorMetadata.ColumnNames.AdminValueMinimum);
            }

            set
            {
                if (SetSystemDecimal(GuarantorMetadata.ColumnNames.AdminValueMinimum, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.AdminValueMinimum);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.IsGlobalPlafond
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsGlobalPlafond
        {
            get
            {
                return GetSystemBoolean(GuarantorMetadata.ColumnNames.IsGlobalPlafond);
            }

            set
            {
                if (SetSystemBoolean(GuarantorMetadata.ColumnNames.IsGlobalPlafond, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.IsGlobalPlafond);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.IsAdminFromTotal
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsAdminFromTotal
        {
            get
            {
                return GetSystemBoolean(GuarantorMetadata.ColumnNames.IsAdminFromTotal);
            }

            set
            {
                if (SetSystemBoolean(GuarantorMetadata.ColumnNames.IsAdminFromTotal, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.IsAdminFromTotal);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.AdminPercentageOp
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? AdminPercentageOp
        {
            get
            {
                return GetSystemDecimal(GuarantorMetadata.ColumnNames.AdminPercentageOp);
            }

            set
            {
                if (SetSystemDecimal(GuarantorMetadata.ColumnNames.AdminPercentageOp, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.AdminPercentageOp);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.AdminAmountLimitOp
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? AdminAmountLimitOp
        {
            get
            {
                return GetSystemDecimal(GuarantorMetadata.ColumnNames.AdminAmountLimitOp);
            }

            set
            {
                if (SetSystemDecimal(GuarantorMetadata.ColumnNames.AdminAmountLimitOp, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.AdminAmountLimitOp);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.AdminValueMinimumOp
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? AdminValueMinimumOp
        {
            get
            {
                return GetSystemDecimal(GuarantorMetadata.ColumnNames.AdminValueMinimumOp);
            }

            set
            {
                if (SetSystemDecimal(GuarantorMetadata.ColumnNames.AdminValueMinimumOp, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.AdminValueMinimumOp);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.ChartOfAccountIdTemporary
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? ChartOfAccountIdTemporary
        {
            get
            {
                return GetSystemInt32(GuarantorMetadata.ColumnNames.ChartOfAccountIdTemporary);
            }

            set
            {
                if (SetSystemInt32(GuarantorMetadata.ColumnNames.ChartOfAccountIdTemporary, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.ChartOfAccountIdTemporary);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.SubledgerIdTemporary
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? SubledgerIdTemporary
        {
            get
            {
                return GetSystemInt32(GuarantorMetadata.ColumnNames.SubledgerIdTemporary);
            }

            set
            {
                if (SetSystemInt32(GuarantorMetadata.ColumnNames.SubledgerIdTemporary, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.SubledgerIdTemporary);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.IsItemRuleUsingDefaultAmountValue
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsItemRuleUsingDefaultAmountValue
        {
            get
            {
                return GetSystemBoolean(GuarantorMetadata.ColumnNames.IsItemRuleUsingDefaultAmountValue);
            }

            set
            {
                if (SetSystemBoolean(GuarantorMetadata.ColumnNames.IsItemRuleUsingDefaultAmountValue, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.IsItemRuleUsingDefaultAmountValue);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.OutpatientAmountValue
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? OutpatientAmountValue
        {
            get
            {
                return GetSystemDecimal(GuarantorMetadata.ColumnNames.OutpatientAmountValue);
            }

            set
            {
                if (SetSystemDecimal(GuarantorMetadata.ColumnNames.OutpatientAmountValue, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.OutpatientAmountValue);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.EmergencyAmountValue
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? EmergencyAmountValue
        {
            get
            {
                return GetSystemDecimal(GuarantorMetadata.ColumnNames.EmergencyAmountValue);
            }

            set
            {
                if (SetSystemDecimal(GuarantorMetadata.ColumnNames.EmergencyAmountValue, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.EmergencyAmountValue);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.SRPaymentType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRPaymentType
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.SRPaymentType);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.SRPaymentType, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.SRPaymentType);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.SRPhysicianFeeType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRPhysicianFeeType
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.SRPhysicianFeeType);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.SRPhysicianFeeType, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.SRPhysicianFeeType);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.ChartOfAccountIdDeposit
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? ChartOfAccountIdDeposit
        {
            get
            {
                return GetSystemInt32(GuarantorMetadata.ColumnNames.ChartOfAccountIdDeposit);
            }

            set
            {
                if (SetSystemInt32(GuarantorMetadata.ColumnNames.ChartOfAccountIdDeposit, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.ChartOfAccountIdDeposit);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.SubledgerIdDeposit
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? SubledgerIdDeposit
        {
            get
            {
                return GetSystemInt32(GuarantorMetadata.ColumnNames.SubledgerIdDeposit);
            }

            set
            {
                if (SetSystemInt32(GuarantorMetadata.ColumnNames.SubledgerIdDeposit, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.SubledgerIdDeposit);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.TermOfPayment
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? TermOfPayment
        {
            get
            {
                return GetSystemInt32(GuarantorMetadata.ColumnNames.TermOfPayment);
            }

            set
            {
                if (SetSystemInt32(GuarantorMetadata.ColumnNames.TermOfPayment, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.TermOfPayment);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.ChartOfAccountIdOverPayment
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? ChartOfAccountIdOverPayment
        {
            get
            {
                return GetSystemInt32(GuarantorMetadata.ColumnNames.ChartOfAccountIdOverPayment);
            }

            set
            {
                if (SetSystemInt32(GuarantorMetadata.ColumnNames.ChartOfAccountIdOverPayment, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.ChartOfAccountIdOverPayment);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.SubledgerIdOverPayment
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? SubledgerIdOverPayment
        {
            get
            {
                return GetSystemInt32(GuarantorMetadata.ColumnNames.SubledgerIdOverPayment);
            }

            set
            {
                if (SetSystemInt32(GuarantorMetadata.ColumnNames.SubledgerIdOverPayment, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.SubledgerIdOverPayment);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.SRPhysicianFeeCategory
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRPhysicianFeeCategory
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.SRPhysicianFeeCategory);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.SRPhysicianFeeCategory, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.SRPhysicianFeeCategory);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.ChartOfAccountIdCostParamedicFee
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? ChartOfAccountIdCostParamedicFee
        {
            get
            {
                return GetSystemInt32(GuarantorMetadata.ColumnNames.ChartOfAccountIdCostParamedicFee);
            }

            set
            {
                if (SetSystemInt32(GuarantorMetadata.ColumnNames.ChartOfAccountIdCostParamedicFee, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.ChartOfAccountIdCostParamedicFee);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.SubledgerIdCostParamedicFee
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? SubledgerIdCostParamedicFee
        {
            get
            {
                return GetSystemInt32(GuarantorMetadata.ColumnNames.SubledgerIdCostParamedicFee);
            }

            set
            {
                if (SetSystemInt32(GuarantorMetadata.ColumnNames.SubledgerIdCostParamedicFee, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.SubledgerIdCostParamedicFee);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.IsExcessPlafonToDiscount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsExcessPlafonToDiscount
        {
            get
            {
                return GetSystemBoolean(GuarantorMetadata.ColumnNames.IsExcessPlafonToDiscount);
            }

            set
            {
                if (SetSystemBoolean(GuarantorMetadata.ColumnNames.IsExcessPlafonToDiscount, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.IsExcessPlafonToDiscount);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.VirtualAccountNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string VirtualAccountNo
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.VirtualAccountNo);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.VirtualAccountNo, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.VirtualAccountNo);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.ReportRLID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ReportRLID
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.ReportRLID);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.ReportRLID, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.ReportRLID);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.RlMasterReportItemID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? RlMasterReportItemID
        {
            get
            {
                return GetSystemInt32(GuarantorMetadata.ColumnNames.RlMasterReportItemID);
            }

            set
            {
                if (SetSystemInt32(GuarantorMetadata.ColumnNames.RlMasterReportItemID, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.RlMasterReportItemID);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.IsCoverAllAdminCosts
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsCoverAllAdminCosts
        {
            get
            {
                return GetSystemBoolean(GuarantorMetadata.ColumnNames.IsCoverAllAdminCosts);
            }

            set
            {
                if (SetSystemBoolean(GuarantorMetadata.ColumnNames.IsCoverAllAdminCosts, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.IsCoverAllAdminCosts);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.SRGuarantorIncomeGroup
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRGuarantorIncomeGroup
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.SRGuarantorIncomeGroup);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.SRGuarantorIncomeGroup, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.SRGuarantorIncomeGroup);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.PrescriptionServiceUnitIdIPR
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PrescriptionServiceUnitIdIPR
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.PrescriptionServiceUnitIdIPR);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.PrescriptionServiceUnitIdIPR, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.PrescriptionServiceUnitIdIPR);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.PrescriptionLocationIdIPR
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PrescriptionLocationIdIPR
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.PrescriptionLocationIdIPR);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.PrescriptionLocationIdIPR, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.PrescriptionLocationIdIPR);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.PrescriptionServiceUnitIdOPR
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PrescriptionServiceUnitIdOPR
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.PrescriptionServiceUnitIdOPR);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.PrescriptionServiceUnitIdOPR, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.PrescriptionServiceUnitIdOPR);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.PrescriptionLocationIdOPR
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PrescriptionLocationIdOPR
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.PrescriptionLocationIdOPR);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.PrescriptionLocationIdOPR, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.PrescriptionLocationIdOPR);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.PrescriptionServiceUnitIdEMR
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PrescriptionServiceUnitIdEMR
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.PrescriptionServiceUnitIdEMR);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.PrescriptionServiceUnitIdEMR, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.PrescriptionServiceUnitIdEMR);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.PrescriptionLocationIdEMR
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PrescriptionLocationIdEMR
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.PrescriptionLocationIdEMR);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.PrescriptionLocationIdEMR, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.PrescriptionLocationIdEMR);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.IsItemRestrictionsFornas
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsItemRestrictionsFornas
        {
            get
            {
                return GetSystemBoolean(GuarantorMetadata.ColumnNames.IsItemRestrictionsFornas);
            }

            set
            {
                if (SetSystemBoolean(GuarantorMetadata.ColumnNames.IsItemRestrictionsFornas, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.IsItemRestrictionsFornas);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.IsProrateParamedicFee
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsProrateParamedicFee
        {
            get
            {
                return GetSystemBoolean(GuarantorMetadata.ColumnNames.IsProrateParamedicFee);
            }

            set
            {
                if (SetSystemBoolean(GuarantorMetadata.ColumnNames.IsProrateParamedicFee, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.IsProrateParamedicFee);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.TariffCalculationMethod
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public byte? TariffCalculationMethod
        {
            get
            {
                return GetSystemByte(GuarantorMetadata.ColumnNames.TariffCalculationMethod);
            }

            set
            {
                if (SetSystemByte(GuarantorMetadata.ColumnNames.TariffCalculationMethod, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.TariffCalculationMethod);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.NoteCompanyList
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string NoteCompanyList
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.NoteCompanyList);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.NoteCompanyList, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.NoteCompanyList);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.IsAdminCalcBeforeDiscount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsAdminCalcBeforeDiscount
        {
            get
            {
                return GetSystemBoolean(GuarantorMetadata.ColumnNames.IsAdminCalcBeforeDiscount);
            }

            set
            {
                if (SetSystemBoolean(GuarantorMetadata.ColumnNames.IsAdminCalcBeforeDiscount, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.IsAdminCalcBeforeDiscount);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.IsParamedicFeeRemun
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsParamedicFeeRemun
        {
            get
            {
                return GetSystemBoolean(GuarantorMetadata.ColumnNames.IsParamedicFeeRemun);
            }

            set
            {
                if (SetSystemBoolean(GuarantorMetadata.ColumnNames.IsParamedicFeeRemun, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.IsParamedicFeeRemun);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.RoundingTransaction
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? RoundingTransaction
        {
            get
            {
                return GetSystemDecimal(GuarantorMetadata.ColumnNames.RoundingTransaction);
            }

            set
            {
                if (SetSystemDecimal(GuarantorMetadata.ColumnNames.RoundingTransaction, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.RoundingTransaction);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.IsUsingRoundingDown
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsUsingRoundingDown
        {
            get
            {
                return GetSystemBoolean(GuarantorMetadata.ColumnNames.IsUsingRoundingDown);
            }

            set
            {
                if (SetSystemBoolean(GuarantorMetadata.ColumnNames.IsUsingRoundingDown, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.IsUsingRoundingDown);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.CreditLimit
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? CreditLimit
        {
            get
            {
                return GetSystemDecimal(GuarantorMetadata.ColumnNames.CreditLimit);
            }

            set
            {
                if (SetSystemDecimal(GuarantorMetadata.ColumnNames.CreditLimit, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.CreditLimit);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.CreditAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? CreditAmount
        {
            get
            {
                return GetSystemDecimal(GuarantorMetadata.ColumnNames.CreditAmount);
            }

            set
            {
                if (SetSystemDecimal(GuarantorMetadata.ColumnNames.CreditAmount, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.CreditAmount);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.VirtualAccountBank
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string VirtualAccountBank
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.VirtualAccountBank);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.VirtualAccountBank, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.VirtualAccountBank);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.VirtualAccountName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string VirtualAccountName
        {
            get
            {
                return GetSystemString(GuarantorMetadata.ColumnNames.VirtualAccountName);
            }

            set
            {
                if (SetSystemString(GuarantorMetadata.ColumnNames.VirtualAccountName, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.VirtualAccountName);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.IsFeeBrutoFromFeeAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsFeeBrutoFromFeeAmount
        {
            get
            {
                return GetSystemBoolean(GuarantorMetadata.ColumnNames.IsFeeBrutoFromFeeAmount);
            }

            set
            {
                if (SetSystemBoolean(GuarantorMetadata.ColumnNames.IsFeeBrutoFromFeeAmount, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.IsFeeBrutoFromFeeAmount);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.ChartOfAccountIdIPR
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? ChartOfAccountIdIPR
        {
            get
            {
                return GetSystemInt32(GuarantorMetadata.ColumnNames.ChartOfAccountIdIPR);
            }

            set
            {
                if (SetSystemInt32(GuarantorMetadata.ColumnNames.ChartOfAccountIdIPR, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.ChartOfAccountIdIPR);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.SubLedgerIdIPR
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? SubLedgerIdIPR
        {
            get
            {
                return GetSystemInt32(GuarantorMetadata.ColumnNames.SubLedgerIdIPR);
            }

            set
            {
                if (SetSystemInt32(GuarantorMetadata.ColumnNames.SubLedgerIdIPR, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.SubLedgerIdIPR);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.ChartOfAccountIdTemporaryIPR
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? ChartOfAccountIdTemporaryIPR
        {
            get
            {
                return GetSystemInt32(GuarantorMetadata.ColumnNames.ChartOfAccountIdTemporaryIPR);
            }

            set
            {
                if (SetSystemInt32(GuarantorMetadata.ColumnNames.ChartOfAccountIdTemporaryIPR, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.ChartOfAccountIdTemporaryIPR);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.SubledgerIdTemporaryIPR
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? SubledgerIdTemporaryIPR
        {
            get
            {
                return GetSystemInt32(GuarantorMetadata.ColumnNames.SubledgerIdTemporaryIPR);
            }

            set
            {
                if (SetSystemInt32(GuarantorMetadata.ColumnNames.SubledgerIdTemporaryIPR, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.SubledgerIdTemporaryIPR);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.IsItemRestrictionsFormularium
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsItemRestrictionsFormularium
        {
            get
            {
                return GetSystemBoolean(GuarantorMetadata.ColumnNames.IsItemRestrictionsFormularium);
            }

            set
            {
                if (SetSystemBoolean(GuarantorMetadata.ColumnNames.IsItemRestrictionsFormularium, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.IsItemRestrictionsFormularium);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.IsItemRestrictionsGeneric
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsItemRestrictionsGeneric
        {
            get
            {
                return GetSystemBoolean(GuarantorMetadata.ColumnNames.IsItemRestrictionsGeneric);
            }

            set
            {
                if (SetSystemBoolean(GuarantorMetadata.ColumnNames.IsItemRestrictionsGeneric, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.IsItemRestrictionsGeneric);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.IsItemRestrictionsNonGeneric
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsItemRestrictionsNonGeneric
        {
            get
            {
                return GetSystemBoolean(GuarantorMetadata.ColumnNames.IsItemRestrictionsNonGeneric);
            }

            set
            {
                if (SetSystemBoolean(GuarantorMetadata.ColumnNames.IsItemRestrictionsNonGeneric, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.IsItemRestrictionsNonGeneric);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.IsItemRestrictionsNonGenericLimited
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsItemRestrictionsNonGenericLimited
        {
            get
            {
                return GetSystemBoolean(GuarantorMetadata.ColumnNames.IsItemRestrictionsNonGenericLimited);
            }

            set
            {
                if (SetSystemBoolean(GuarantorMetadata.ColumnNames.IsItemRestrictionsNonGenericLimited, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.IsItemRestrictionsNonGenericLimited);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.ChartOfAccountIdOverPaymentMin
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? ChartOfAccountIdOverPaymentMin
        {
            get
            {
                return GetSystemInt32(GuarantorMetadata.ColumnNames.ChartOfAccountIdOverPaymentMin);
            }

            set
            {
                if (SetSystemInt32(GuarantorMetadata.ColumnNames.ChartOfAccountIdOverPaymentMin, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.ChartOfAccountIdOverPaymentMin);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.SubledgerIdOverPaymentMin
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? SubledgerIdOverPaymentMin
        {
            get
            {
                return GetSystemInt32(GuarantorMetadata.ColumnNames.SubledgerIdOverPaymentMin);
            }

            set
            {
                if (SetSystemInt32(GuarantorMetadata.ColumnNames.SubledgerIdOverPaymentMin, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.SubledgerIdOverPaymentMin);
                }
            }
        }

        /// <summary>
        /// Maps to Guarantor.IsDiscountProrataToRevenue
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsDiscountProrataToRevenue
        {
            get
            {
                return GetSystemBoolean(GuarantorMetadata.ColumnNames.IsDiscountProrataToRevenue);
            }

            set
            {
                if (SetSystemBoolean(GuarantorMetadata.ColumnNames.IsDiscountProrataToRevenue, value))
                {
                    OnPropertyChanged(GuarantorMetadata.PropertyNames.IsDiscountProrataToRevenue);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return GuarantorMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public GuarantorQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new GuarantorQuery("gQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(GuarantorQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(GuarantorQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((GuarantorQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private GuarantorQuery query;
    }



    [Serializable]
    abstract public partial class esGuarantorCollection : esEntityCollection<Guarantor>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return GuarantorMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "GuarantorCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public GuarantorQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new GuarantorQuery("gQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(GuarantorQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new GuarantorQuery("gQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(GuarantorQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((GuarantorQuery)query);
        }

        #endregion

        private GuarantorQuery query;
    }



    [Serializable]
    abstract public partial class esGuarantorQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return GuarantorMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "GuarantorID": return GuarantorID;
                case "GuarantorName": return GuarantorName;
                case "ShortName": return ShortName;
                case "SRGuarantorType": return SRGuarantorType;
                case "ContractNumber": return ContractNumber;
                case "ContractStart": return ContractStart;
                case "ContractEnd": return ContractEnd;
                case "ContractSummary": return ContractSummary;
                case "ContactPerson": return ContactPerson;
                case "IsActive": return IsActive;
                case "SRBusinessMethod": return SRBusinessMethod;
                case "SRTariffType": return SRTariffType;
                case "SRGuarantorRuleType": return SRGuarantorRuleType;
                case "IsValueInPercent": return IsValueInPercent;
                case "AmountValue": return AmountValue;
                case "AdminPercentage": return AdminPercentage;
                case "AdminAmountLimit": return AdminAmountLimit;
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
                case "ChartOfAccountId": return ChartOfAccountId;
                case "SubLedgerId": return SubLedgerId;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "IsIncludeItemMedical": return IsIncludeItemMedical;
                case "IsIncludeItemNonMedical": return IsIncludeItemNonMedical;
                case "IsIncludeItemOptic": return IsIncludeItemOptic;
                case "IsIncludeItemMedicalToGuarantor": return IsIncludeItemMedicalToGuarantor;
                case "IsIncludeItemNonMedicalToGuarantor": return IsIncludeItemNonMedicalToGuarantor;
                case "IsIncludeItemOpticToGuarantor": return IsIncludeItemOpticToGuarantor;
                case "IsCoverInpatient": return IsCoverInpatient;
                case "IsCoverOutpatient": return IsCoverOutpatient;
                case "ItemMedicMarginPercentage": return ItemMedicMarginPercentage;
                case "ItemMedicMarginID": return ItemMedicMarginID;
                case "ItemNonMedicMarginPercentage": return ItemNonMedicMarginPercentage;
                case "ItemNonMedicMarginID": return ItemNonMedicMarginID;
                case "GuarantorHeaderID": return GuarantorHeaderID;
                case "IsIncludeAdminValue": return IsIncludeAdminValue;
                case "AdminValueMinimum": return AdminValueMinimum;
                case "IsGlobalPlafond": return IsGlobalPlafond;
                case "IsAdminFromTotal": return IsAdminFromTotal;
                case "AdminPercentageOp": return AdminPercentageOp;
                case "AdminAmountLimitOp": return AdminAmountLimitOp;
                case "AdminValueMinimumOp": return AdminValueMinimumOp;
                case "ChartOfAccountIdTemporary": return ChartOfAccountIdTemporary;
                case "SubledgerIdTemporary": return SubledgerIdTemporary;
                case "IsItemRuleUsingDefaultAmountValue": return IsItemRuleUsingDefaultAmountValue;
                case "OutpatientAmountValue": return OutpatientAmountValue;
                case "EmergencyAmountValue": return EmergencyAmountValue;
                case "SRPaymentType": return SRPaymentType;
                case "SRPhysicianFeeType": return SRPhysicianFeeType;
                case "ChartOfAccountIdDeposit": return ChartOfAccountIdDeposit;
                case "SubledgerIdDeposit": return SubledgerIdDeposit;
                case "TermOfPayment": return TermOfPayment;
                case "ChartOfAccountIdOverPayment": return ChartOfAccountIdOverPayment;
                case "SubledgerIdOverPayment": return SubledgerIdOverPayment;
                case "SRPhysicianFeeCategory": return SRPhysicianFeeCategory;
                case "ChartOfAccountIdCostParamedicFee": return ChartOfAccountIdCostParamedicFee;
                case "SubledgerIdCostParamedicFee": return SubledgerIdCostParamedicFee;
                case "IsExcessPlafonToDiscount": return IsExcessPlafonToDiscount;
                case "VirtualAccountNo": return VirtualAccountNo;
                case "ReportRLID": return ReportRLID;
                case "RlMasterReportItemID": return RlMasterReportItemID;
                case "IsCoverAllAdminCosts": return IsCoverAllAdminCosts;
                case "SRGuarantorIncomeGroup": return SRGuarantorIncomeGroup;
                case "PrescriptionServiceUnitIdIPR": return PrescriptionServiceUnitIdIPR;
                case "PrescriptionLocationIdIPR": return PrescriptionLocationIdIPR;
                case "PrescriptionServiceUnitIdOPR": return PrescriptionServiceUnitIdOPR;
                case "PrescriptionLocationIdOPR": return PrescriptionLocationIdOPR;
                case "PrescriptionServiceUnitIdEMR": return PrescriptionServiceUnitIdEMR;
                case "PrescriptionLocationIdEMR": return PrescriptionLocationIdEMR;
                case "IsItemRestrictionsFornas": return IsItemRestrictionsFornas;
                case "IsProrateParamedicFee": return IsProrateParamedicFee;
                case "TariffCalculationMethod": return TariffCalculationMethod;
                case "NoteCompanyList": return NoteCompanyList;
                case "IsAdminCalcBeforeDiscount": return IsAdminCalcBeforeDiscount;
                case "IsParamedicFeeRemun": return IsParamedicFeeRemun;
                case "RoundingTransaction": return RoundingTransaction;
                case "IsUsingRoundingDown": return IsUsingRoundingDown;
                case "CreditLimit": return CreditLimit;
                case "CreditAmount": return CreditAmount;
                case "VirtualAccountBank": return VirtualAccountBank;
                case "VirtualAccountName": return VirtualAccountName;
                case "IsFeeBrutoFromFeeAmount": return IsFeeBrutoFromFeeAmount;
                case "ChartOfAccountIdIPR": return ChartOfAccountIdIPR;
                case "SubLedgerIdIPR": return SubLedgerIdIPR;
                case "ChartOfAccountIdTemporaryIPR": return ChartOfAccountIdTemporaryIPR;
                case "SubledgerIdTemporaryIPR": return SubledgerIdTemporaryIPR;
                case "IsItemRestrictionsFormularium": return IsItemRestrictionsFormularium;
                case "IsItemRestrictionsGeneric": return IsItemRestrictionsGeneric;
                case "IsItemRestrictionsNonGeneric": return IsItemRestrictionsNonGeneric;
                case "IsItemRestrictionsNonGenericLimited": return IsItemRestrictionsNonGenericLimited;
                case "ChartOfAccountIdOverPaymentMin": return ChartOfAccountIdOverPaymentMin;
                case "SubledgerIdOverPaymentMin": return SubledgerIdOverPaymentMin;
                case "IsDiscountProrataToRevenue": return IsDiscountProrataToRevenue;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem GuarantorID
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.GuarantorID, esSystemType.String); }
        }

        public esQueryItem GuarantorName
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.GuarantorName, esSystemType.String); }
        }

        public esQueryItem ShortName
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.ShortName, esSystemType.String); }
        }

        public esQueryItem SRGuarantorType
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.SRGuarantorType, esSystemType.String); }
        }

        public esQueryItem ContractNumber
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.ContractNumber, esSystemType.String); }
        }

        public esQueryItem ContractStart
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.ContractStart, esSystemType.DateTime); }
        }

        public esQueryItem ContractEnd
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.ContractEnd, esSystemType.DateTime); }
        }

        public esQueryItem ContractSummary
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.ContractSummary, esSystemType.String); }
        }

        public esQueryItem ContactPerson
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.ContactPerson, esSystemType.String); }
        }

        public esQueryItem IsActive
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.IsActive, esSystemType.Boolean); }
        }

        public esQueryItem SRBusinessMethod
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.SRBusinessMethod, esSystemType.String); }
        }

        public esQueryItem SRTariffType
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.SRTariffType, esSystemType.String); }
        }

        public esQueryItem SRGuarantorRuleType
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.SRGuarantorRuleType, esSystemType.String); }
        }

        public esQueryItem IsValueInPercent
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.IsValueInPercent, esSystemType.Boolean); }
        }

        public esQueryItem AmountValue
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.AmountValue, esSystemType.Decimal); }
        }

        public esQueryItem AdminPercentage
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.AdminPercentage, esSystemType.Decimal); }
        }

        public esQueryItem AdminAmountLimit
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.AdminAmountLimit, esSystemType.Decimal); }
        }

        public esQueryItem StreetName
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.StreetName, esSystemType.String); }
        }

        public esQueryItem District
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.District, esSystemType.String); }
        }

        public esQueryItem City
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.City, esSystemType.String); }
        }

        public esQueryItem County
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.County, esSystemType.String); }
        }

        public esQueryItem State
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.State, esSystemType.String); }
        }

        public esQueryItem ZipCode
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.ZipCode, esSystemType.String); }
        }

        public esQueryItem PhoneNo
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.PhoneNo, esSystemType.String); }
        }

        public esQueryItem FaxNo
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.FaxNo, esSystemType.String); }
        }

        public esQueryItem Email
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.Email, esSystemType.String); }
        }

        public esQueryItem MobilePhoneNo
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.MobilePhoneNo, esSystemType.String); }
        }

        public esQueryItem ChartOfAccountId
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.ChartOfAccountId, esSystemType.Int32); }
        }

        public esQueryItem SubLedgerId
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.SubLedgerId, esSystemType.Int32); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem IsIncludeItemMedical
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.IsIncludeItemMedical, esSystemType.Boolean); }
        }

        public esQueryItem IsIncludeItemNonMedical
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.IsIncludeItemNonMedical, esSystemType.Boolean); }
        }

        public esQueryItem IsIncludeItemOptic
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.IsIncludeItemOptic, esSystemType.Boolean); }
        }

        public esQueryItem IsIncludeItemMedicalToGuarantor
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.IsIncludeItemMedicalToGuarantor, esSystemType.Boolean); }
        }

        public esQueryItem IsIncludeItemNonMedicalToGuarantor
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.IsIncludeItemNonMedicalToGuarantor, esSystemType.Boolean); }
        }

        public esQueryItem IsIncludeItemOpticToGuarantor
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.IsIncludeItemOpticToGuarantor, esSystemType.Boolean); }
        }

        public esQueryItem IsCoverInpatient
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.IsCoverInpatient, esSystemType.Boolean); }
        }

        public esQueryItem IsCoverOutpatient
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.IsCoverOutpatient, esSystemType.Boolean); }
        }

        public esQueryItem ItemMedicMarginPercentage
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.ItemMedicMarginPercentage, esSystemType.Decimal); }
        }

        public esQueryItem ItemMedicMarginID
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.ItemMedicMarginID, esSystemType.String); }
        }

        public esQueryItem ItemNonMedicMarginPercentage
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.ItemNonMedicMarginPercentage, esSystemType.Decimal); }
        }

        public esQueryItem ItemNonMedicMarginID
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.ItemNonMedicMarginID, esSystemType.String); }
        }

        public esQueryItem GuarantorHeaderID
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.GuarantorHeaderID, esSystemType.String); }
        }

        public esQueryItem IsIncludeAdminValue
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.IsIncludeAdminValue, esSystemType.Boolean); }
        }

        public esQueryItem AdminValueMinimum
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.AdminValueMinimum, esSystemType.Decimal); }
        }

        public esQueryItem IsGlobalPlafond
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.IsGlobalPlafond, esSystemType.Boolean); }
        }

        public esQueryItem IsAdminFromTotal
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.IsAdminFromTotal, esSystemType.Boolean); }
        }

        public esQueryItem AdminPercentageOp
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.AdminPercentageOp, esSystemType.Decimal); }
        }

        public esQueryItem AdminAmountLimitOp
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.AdminAmountLimitOp, esSystemType.Decimal); }
        }

        public esQueryItem AdminValueMinimumOp
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.AdminValueMinimumOp, esSystemType.Decimal); }
        }

        public esQueryItem ChartOfAccountIdTemporary
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.ChartOfAccountIdTemporary, esSystemType.Int32); }
        }

        public esQueryItem SubledgerIdTemporary
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.SubledgerIdTemporary, esSystemType.Int32); }
        }

        public esQueryItem IsItemRuleUsingDefaultAmountValue
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.IsItemRuleUsingDefaultAmountValue, esSystemType.Boolean); }
        }

        public esQueryItem OutpatientAmountValue
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.OutpatientAmountValue, esSystemType.Decimal); }
        }

        public esQueryItem EmergencyAmountValue
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.EmergencyAmountValue, esSystemType.Decimal); }
        }

        public esQueryItem SRPaymentType
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.SRPaymentType, esSystemType.String); }
        }

        public esQueryItem SRPhysicianFeeType
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.SRPhysicianFeeType, esSystemType.String); }
        }

        public esQueryItem ChartOfAccountIdDeposit
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.ChartOfAccountIdDeposit, esSystemType.Int32); }
        }

        public esQueryItem SubledgerIdDeposit
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.SubledgerIdDeposit, esSystemType.Int32); }
        }

        public esQueryItem TermOfPayment
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.TermOfPayment, esSystemType.Int32); }
        }

        public esQueryItem ChartOfAccountIdOverPayment
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.ChartOfAccountIdOverPayment, esSystemType.Int32); }
        }

        public esQueryItem SubledgerIdOverPayment
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.SubledgerIdOverPayment, esSystemType.Int32); }
        }

        public esQueryItem SRPhysicianFeeCategory
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.SRPhysicianFeeCategory, esSystemType.String); }
        }

        public esQueryItem ChartOfAccountIdCostParamedicFee
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.ChartOfAccountIdCostParamedicFee, esSystemType.Int32); }
        }

        public esQueryItem SubledgerIdCostParamedicFee
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.SubledgerIdCostParamedicFee, esSystemType.Int32); }
        }

        public esQueryItem IsExcessPlafonToDiscount
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.IsExcessPlafonToDiscount, esSystemType.Boolean); }
        }

        public esQueryItem VirtualAccountNo
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.VirtualAccountNo, esSystemType.String); }
        }

        public esQueryItem ReportRLID
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.ReportRLID, esSystemType.String); }
        }

        public esQueryItem RlMasterReportItemID
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.RlMasterReportItemID, esSystemType.Int32); }
        }

        public esQueryItem IsCoverAllAdminCosts
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.IsCoverAllAdminCosts, esSystemType.Boolean); }
        }

        public esQueryItem SRGuarantorIncomeGroup
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.SRGuarantorIncomeGroup, esSystemType.String); }
        }

        public esQueryItem PrescriptionServiceUnitIdIPR
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.PrescriptionServiceUnitIdIPR, esSystemType.String); }
        }

        public esQueryItem PrescriptionLocationIdIPR
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.PrescriptionLocationIdIPR, esSystemType.String); }
        }

        public esQueryItem PrescriptionServiceUnitIdOPR
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.PrescriptionServiceUnitIdOPR, esSystemType.String); }
        }

        public esQueryItem PrescriptionLocationIdOPR
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.PrescriptionLocationIdOPR, esSystemType.String); }
        }

        public esQueryItem PrescriptionServiceUnitIdEMR
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.PrescriptionServiceUnitIdEMR, esSystemType.String); }
        }

        public esQueryItem PrescriptionLocationIdEMR
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.PrescriptionLocationIdEMR, esSystemType.String); }
        }

        public esQueryItem IsItemRestrictionsFornas
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.IsItemRestrictionsFornas, esSystemType.Boolean); }
        }

        public esQueryItem IsProrateParamedicFee
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.IsProrateParamedicFee, esSystemType.Boolean); }
        }

        public esQueryItem TariffCalculationMethod
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.TariffCalculationMethod, esSystemType.Byte); }
        }

        public esQueryItem NoteCompanyList
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.NoteCompanyList, esSystemType.String); }
        }

        public esQueryItem IsAdminCalcBeforeDiscount
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.IsAdminCalcBeforeDiscount, esSystemType.Boolean); }
        }

        public esQueryItem IsParamedicFeeRemun
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.IsParamedicFeeRemun, esSystemType.Boolean); }
        }

        public esQueryItem RoundingTransaction
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.RoundingTransaction, esSystemType.Decimal); }
        }

        public esQueryItem IsUsingRoundingDown
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.IsUsingRoundingDown, esSystemType.Boolean); }
        }

        public esQueryItem CreditLimit
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.CreditLimit, esSystemType.Decimal); }
        }

        public esQueryItem CreditAmount
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.CreditAmount, esSystemType.Decimal); }
        }

        public esQueryItem VirtualAccountBank
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.VirtualAccountBank, esSystemType.String); }
        }

        public esQueryItem VirtualAccountName
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.VirtualAccountName, esSystemType.String); }
        }

        public esQueryItem IsFeeBrutoFromFeeAmount
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.IsFeeBrutoFromFeeAmount, esSystemType.Boolean); }
        }

        public esQueryItem ChartOfAccountIdIPR
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.ChartOfAccountIdIPR, esSystemType.Int32); }
        }

        public esQueryItem SubLedgerIdIPR
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.SubLedgerIdIPR, esSystemType.Int32); }
        }

        public esQueryItem ChartOfAccountIdTemporaryIPR
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.ChartOfAccountIdTemporaryIPR, esSystemType.Int32); }
        }

        public esQueryItem SubledgerIdTemporaryIPR
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.SubledgerIdTemporaryIPR, esSystemType.Int32); }
        }

        public esQueryItem IsItemRestrictionsFormularium
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.IsItemRestrictionsFormularium, esSystemType.Boolean); }
        }

        public esQueryItem IsItemRestrictionsGeneric
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.IsItemRestrictionsGeneric, esSystemType.Boolean); }
        }

        public esQueryItem IsItemRestrictionsNonGeneric
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.IsItemRestrictionsNonGeneric, esSystemType.Boolean); }
        }

        public esQueryItem IsItemRestrictionsNonGenericLimited
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.IsItemRestrictionsNonGenericLimited, esSystemType.Boolean); }
        }

        public esQueryItem ChartOfAccountIdOverPaymentMin
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.ChartOfAccountIdOverPaymentMin, esSystemType.Int32); }
        }

        public esQueryItem SubledgerIdOverPaymentMin
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.SubledgerIdOverPaymentMin, esSystemType.Int32); }
        }

        public esQueryItem IsDiscountProrataToRevenue
        {
            get { return new esQueryItem(this, GuarantorMetadata.ColumnNames.IsDiscountProrataToRevenue, esSystemType.Boolean); }
        }

        #endregion

    }



    [Serializable]
    public partial class GuarantorMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected GuarantorMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.GuarantorID, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.GuarantorID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.GuarantorName, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.GuarantorName;
            c.CharacterMaxLength = 100;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ShortName, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ShortName;
            c.CharacterMaxLength = 35;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRGuarantorType, 3, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRGuarantorType;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ContractNumber, 4, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ContractNumber;
            c.CharacterMaxLength = 100;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ContractStart, 5, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.ContractStart;
            c.HasDefault = true;
            c.Default = @"(CONVERT([smalldatetime],'19000101',(105)))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ContractEnd, 6, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.ContractEnd;
            c.HasDefault = true;
            c.Default = @"(CONVERT([smalldatetime],'19000101',(105)))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ContractSummary, 7, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ContractSummary;
            c.CharacterMaxLength = 2147483647;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ContactPerson, 8, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ContactPerson;
            c.CharacterMaxLength = 500;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsActive, 9, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsActive;
            c.HasDefault = true;
            c.Default = @"(CONVERT([bit],(1),0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRBusinessMethod, 10, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRBusinessMethod;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRTariffType, 11, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRTariffType;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRGuarantorRuleType, 12, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRGuarantorRuleType;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsValueInPercent, 13, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsValueInPercent;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AmountValue, 14, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.AmountValue;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AdminPercentage, 15, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.AdminPercentage;
            c.NumericPrecision = 5;
            c.NumericScale = 2;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AdminAmountLimit, 16, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.AdminAmountLimit;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.StreetName, 17, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.StreetName;
            c.CharacterMaxLength = 250;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.District, 18, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.District;
            c.CharacterMaxLength = 50;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.City, 19, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.City;
            c.CharacterMaxLength = 50;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.County, 20, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.County;
            c.CharacterMaxLength = 50;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.State, 21, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.State;
            c.CharacterMaxLength = 50;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ZipCode, 22, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ZipCode;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PhoneNo, 23, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PhoneNo;
            c.CharacterMaxLength = 100;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FaxNo, 24, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.FaxNo;
            c.CharacterMaxLength = 50;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Email, 25, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Email;
            c.CharacterMaxLength = 200;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.MobilePhoneNo, 26, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.MobilePhoneNo;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ChartOfAccountId, 27, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.ChartOfAccountId;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SubLedgerId, 28, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.SubLedgerId;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 29, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 30, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 40;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsIncludeItemMedical, 31, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsIncludeItemMedical;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsIncludeItemNonMedical, 32, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsIncludeItemNonMedical;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsIncludeItemOptic, 33, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsIncludeItemOptic;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsIncludeItemMedicalToGuarantor, 34, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsIncludeItemMedicalToGuarantor;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsIncludeItemNonMedicalToGuarantor, 35, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsIncludeItemNonMedicalToGuarantor;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsIncludeItemOpticToGuarantor, 36, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsIncludeItemOpticToGuarantor;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsCoverInpatient, 37, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsCoverInpatient;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsCoverOutpatient, 38, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsCoverOutpatient;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ItemMedicMarginPercentage, 39, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.ItemMedicMarginPercentage;
            c.NumericPrecision = 5;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ItemMedicMarginID, 40, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ItemMedicMarginID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ItemNonMedicMarginPercentage, 41, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.ItemNonMedicMarginPercentage;
            c.NumericPrecision = 5;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ItemNonMedicMarginID, 42, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ItemNonMedicMarginID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.GuarantorHeaderID, 43, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.GuarantorHeaderID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsIncludeAdminValue, 44, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsIncludeAdminValue;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AdminValueMinimum, 45, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.AdminValueMinimum;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsGlobalPlafond, 46, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsGlobalPlafond;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsAdminFromTotal, 47, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsAdminFromTotal;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AdminPercentageOp, 48, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.AdminPercentageOp;
            c.NumericPrecision = 5;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AdminAmountLimitOp, 49, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.AdminAmountLimitOp;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AdminValueMinimumOp, 50, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.AdminValueMinimumOp;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ChartOfAccountIdTemporary, 51, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.ChartOfAccountIdTemporary;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SubledgerIdTemporary, 52, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.SubledgerIdTemporary;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsItemRuleUsingDefaultAmountValue, 53, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsItemRuleUsingDefaultAmountValue;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.OutpatientAmountValue, 54, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.OutpatientAmountValue;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.EmergencyAmountValue, 55, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.EmergencyAmountValue;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRPaymentType, 56, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRPaymentType;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRPhysicianFeeType, 57, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRPhysicianFeeType;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ChartOfAccountIdDeposit, 58, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.ChartOfAccountIdDeposit;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SubledgerIdDeposit, 59, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.SubledgerIdDeposit;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TermOfPayment, 60, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.TermOfPayment;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ChartOfAccountIdOverPayment, 61, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.ChartOfAccountIdOverPayment;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SubledgerIdOverPayment, 62, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.SubledgerIdOverPayment;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRPhysicianFeeCategory, 63, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRPhysicianFeeCategory;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ChartOfAccountIdCostParamedicFee, 64, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.ChartOfAccountIdCostParamedicFee;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SubledgerIdCostParamedicFee, 65, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.SubledgerIdCostParamedicFee;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsExcessPlafonToDiscount, 66, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsExcessPlafonToDiscount;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.VirtualAccountNo, 67, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.VirtualAccountNo;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ReportRLID, 68, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ReportRLID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RlMasterReportItemID, 69, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.RlMasterReportItemID;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsCoverAllAdminCosts, 70, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsCoverAllAdminCosts;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRGuarantorIncomeGroup, 71, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRGuarantorIncomeGroup;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PrescriptionServiceUnitIdIPR, 72, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PrescriptionServiceUnitIdIPR;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PrescriptionLocationIdIPR, 73, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PrescriptionLocationIdIPR;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PrescriptionServiceUnitIdOPR, 74, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PrescriptionServiceUnitIdOPR;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PrescriptionLocationIdOPR, 75, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PrescriptionLocationIdOPR;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PrescriptionServiceUnitIdEMR, 76, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PrescriptionServiceUnitIdEMR;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PrescriptionLocationIdEMR, 77, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PrescriptionLocationIdEMR;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsItemRestrictionsFornas, 78, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsItemRestrictionsFornas;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsProrateParamedicFee, 79, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsProrateParamedicFee;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TariffCalculationMethod, 80, typeof(byte), esSystemType.Byte);
            c.PropertyName = PropertyNames.TariffCalculationMethod;
            c.NumericPrecision = 3;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.NoteCompanyList, 81, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.NoteCompanyList;
            c.CharacterMaxLength = 1000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsAdminCalcBeforeDiscount, 82, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsAdminCalcBeforeDiscount;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsParamedicFeeRemun, 83, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsParamedicFeeRemun;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RoundingTransaction, 84, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.RoundingTransaction;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsUsingRoundingDown, 85, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsUsingRoundingDown;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreditLimit, 86, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.CreditLimit;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreditAmount, 87, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.CreditAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.VirtualAccountBank, 88, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.VirtualAccountBank;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.VirtualAccountName, 89, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.VirtualAccountName;
            c.CharacterMaxLength = 200;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsFeeBrutoFromFeeAmount, 90, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsFeeBrutoFromFeeAmount;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ChartOfAccountIdIPR, 91, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.ChartOfAccountIdIPR;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SubLedgerIdIPR, 92, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.SubLedgerIdIPR;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ChartOfAccountIdTemporaryIPR, 93, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.ChartOfAccountIdTemporaryIPR;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SubledgerIdTemporaryIPR, 94, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.SubledgerIdTemporaryIPR;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsItemRestrictionsFormularium, 95, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsItemRestrictionsFormularium;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsItemRestrictionsGeneric, 96, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsItemRestrictionsGeneric;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsItemRestrictionsNonGeneric, 97, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsItemRestrictionsNonGeneric;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsItemRestrictionsNonGenericLimited, 98, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsItemRestrictionsNonGenericLimited;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ChartOfAccountIdOverPaymentMin, 99, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.ChartOfAccountIdOverPaymentMin;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SubledgerIdOverPaymentMin, 100, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.SubledgerIdOverPaymentMin;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsDiscountProrataToRevenue, 101, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsDiscountProrataToRevenue;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public GuarantorMetadata Meta()
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
            public const string GuarantorID = "GuarantorID";
            public const string GuarantorName = "GuarantorName";
            public const string ShortName = "ShortName";
            public const string SRGuarantorType = "SRGuarantorType";
            public const string ContractNumber = "ContractNumber";
            public const string ContractStart = "ContractStart";
            public const string ContractEnd = "ContractEnd";
            public const string ContractSummary = "ContractSummary";
            public const string ContactPerson = "ContactPerson";
            public const string IsActive = "IsActive";
            public const string SRBusinessMethod = "SRBusinessMethod";
            public const string SRTariffType = "SRTariffType";
            public const string SRGuarantorRuleType = "SRGuarantorRuleType";
            public const string IsValueInPercent = "IsValueInPercent";
            public const string AmountValue = "AmountValue";
            public const string AdminPercentage = "AdminPercentage";
            public const string AdminAmountLimit = "AdminAmountLimit";
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
            public const string ChartOfAccountId = "ChartOfAccountId";
            public const string SubLedgerId = "SubLedgerId";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string IsIncludeItemMedical = "IsIncludeItemMedical";
            public const string IsIncludeItemNonMedical = "IsIncludeItemNonMedical";
            public const string IsIncludeItemOptic = "IsIncludeItemOptic";
            public const string IsIncludeItemMedicalToGuarantor = "IsIncludeItemMedicalToGuarantor";
            public const string IsIncludeItemNonMedicalToGuarantor = "IsIncludeItemNonMedicalToGuarantor";
            public const string IsIncludeItemOpticToGuarantor = "IsIncludeItemOpticToGuarantor";
            public const string IsCoverInpatient = "IsCoverInpatient";
            public const string IsCoverOutpatient = "IsCoverOutpatient";
            public const string ItemMedicMarginPercentage = "ItemMedicMarginPercentage";
            public const string ItemMedicMarginID = "ItemMedicMarginID";
            public const string ItemNonMedicMarginPercentage = "ItemNonMedicMarginPercentage";
            public const string ItemNonMedicMarginID = "ItemNonMedicMarginID";
            public const string GuarantorHeaderID = "GuarantorHeaderID";
            public const string IsIncludeAdminValue = "IsIncludeAdminValue";
            public const string AdminValueMinimum = "AdminValueMinimum";
            public const string IsGlobalPlafond = "IsGlobalPlafond";
            public const string IsAdminFromTotal = "IsAdminFromTotal";
            public const string AdminPercentageOp = "AdminPercentageOp";
            public const string AdminAmountLimitOp = "AdminAmountLimitOp";
            public const string AdminValueMinimumOp = "AdminValueMinimumOp";
            public const string ChartOfAccountIdTemporary = "ChartOfAccountIdTemporary";
            public const string SubledgerIdTemporary = "SubledgerIdTemporary";
            public const string IsItemRuleUsingDefaultAmountValue = "IsItemRuleUsingDefaultAmountValue";
            public const string OutpatientAmountValue = "OutpatientAmountValue";
            public const string EmergencyAmountValue = "EmergencyAmountValue";
            public const string SRPaymentType = "SRPaymentType";
            public const string SRPhysicianFeeType = "SRPhysicianFeeType";
            public const string ChartOfAccountIdDeposit = "ChartOfAccountIdDeposit";
            public const string SubledgerIdDeposit = "SubledgerIdDeposit";
            public const string TermOfPayment = "TermOfPayment";
            public const string ChartOfAccountIdOverPayment = "ChartOfAccountIdOverPayment";
            public const string SubledgerIdOverPayment = "SubledgerIdOverPayment";
            public const string SRPhysicianFeeCategory = "SRPhysicianFeeCategory";
            public const string ChartOfAccountIdCostParamedicFee = "ChartOfAccountIdCostParamedicFee";
            public const string SubledgerIdCostParamedicFee = "SubledgerIdCostParamedicFee";
            public const string IsExcessPlafonToDiscount = "IsExcessPlafonToDiscount";
            public const string VirtualAccountNo = "VirtualAccountNo";
            public const string ReportRLID = "ReportRLID";
            public const string RlMasterReportItemID = "RlMasterReportItemID";
            public const string IsCoverAllAdminCosts = "IsCoverAllAdminCosts";
            public const string SRGuarantorIncomeGroup = "SRGuarantorIncomeGroup";
            public const string PrescriptionServiceUnitIdIPR = "PrescriptionServiceUnitIdIPR";
            public const string PrescriptionLocationIdIPR = "PrescriptionLocationIdIPR";
            public const string PrescriptionServiceUnitIdOPR = "PrescriptionServiceUnitIdOPR";
            public const string PrescriptionLocationIdOPR = "PrescriptionLocationIdOPR";
            public const string PrescriptionServiceUnitIdEMR = "PrescriptionServiceUnitIdEMR";
            public const string PrescriptionLocationIdEMR = "PrescriptionLocationIdEMR";
            public const string IsItemRestrictionsFornas = "IsItemRestrictionsFornas";
            public const string IsProrateParamedicFee = "IsProrateParamedicFee";
            public const string TariffCalculationMethod = "TariffCalculationMethod";
            public const string NoteCompanyList = "NoteCompanyList";
            public const string IsAdminCalcBeforeDiscount = "IsAdminCalcBeforeDiscount";
            public const string IsParamedicFeeRemun = "IsParamedicFeeRemun";
            public const string RoundingTransaction = "RoundingTransaction";
            public const string IsUsingRoundingDown = "IsUsingRoundingDown";
            public const string CreditLimit = "CreditLimit";
            public const string CreditAmount = "CreditAmount";
            public const string VirtualAccountBank = "VirtualAccountBank";
            public const string VirtualAccountName = "VirtualAccountName";
            public const string IsFeeBrutoFromFeeAmount = "IsFeeBrutoFromFeeAmount";
            public const string ChartOfAccountIdIPR = "ChartOfAccountIdIPR";
            public const string SubLedgerIdIPR = "SubLedgerIdIPR";
            public const string ChartOfAccountIdTemporaryIPR = "ChartOfAccountIdTemporaryIPR";
            public const string SubledgerIdTemporaryIPR = "SubledgerIdTemporaryIPR";
            public const string IsItemRestrictionsFormularium = "IsItemRestrictionsFormularium";
            public const string IsItemRestrictionsGeneric = "IsItemRestrictionsGeneric";
            public const string IsItemRestrictionsNonGeneric = "IsItemRestrictionsNonGeneric";
            public const string IsItemRestrictionsNonGenericLimited = "IsItemRestrictionsNonGenericLimited";
            public const string ChartOfAccountIdOverPaymentMin = "ChartOfAccountIdOverPaymentMin";
            public const string SubledgerIdOverPaymentMin = "SubledgerIdOverPaymentMin";
            public const string IsDiscountProrataToRevenue = "IsDiscountProrataToRevenue";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string GuarantorID = "GuarantorID";
            public const string GuarantorName = "GuarantorName";
            public const string ShortName = "ShortName";
            public const string SRGuarantorType = "SRGuarantorType";
            public const string ContractNumber = "ContractNumber";
            public const string ContractStart = "ContractStart";
            public const string ContractEnd = "ContractEnd";
            public const string ContractSummary = "ContractSummary";
            public const string ContactPerson = "ContactPerson";
            public const string IsActive = "IsActive";
            public const string SRBusinessMethod = "SRBusinessMethod";
            public const string SRTariffType = "SRTariffType";
            public const string SRGuarantorRuleType = "SRGuarantorRuleType";
            public const string IsValueInPercent = "IsValueInPercent";
            public const string AmountValue = "AmountValue";
            public const string AdminPercentage = "AdminPercentage";
            public const string AdminAmountLimit = "AdminAmountLimit";
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
            public const string ChartOfAccountId = "ChartOfAccountId";
            public const string SubLedgerId = "SubLedgerId";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string IsIncludeItemMedical = "IsIncludeItemMedical";
            public const string IsIncludeItemNonMedical = "IsIncludeItemNonMedical";
            public const string IsIncludeItemOptic = "IsIncludeItemOptic";
            public const string IsIncludeItemMedicalToGuarantor = "IsIncludeItemMedicalToGuarantor";
            public const string IsIncludeItemNonMedicalToGuarantor = "IsIncludeItemNonMedicalToGuarantor";
            public const string IsIncludeItemOpticToGuarantor = "IsIncludeItemOpticToGuarantor";
            public const string IsCoverInpatient = "IsCoverInpatient";
            public const string IsCoverOutpatient = "IsCoverOutpatient";
            public const string ItemMedicMarginPercentage = "ItemMedicMarginPercentage";
            public const string ItemMedicMarginID = "ItemMedicMarginID";
            public const string ItemNonMedicMarginPercentage = "ItemNonMedicMarginPercentage";
            public const string ItemNonMedicMarginID = "ItemNonMedicMarginID";
            public const string GuarantorHeaderID = "GuarantorHeaderID";
            public const string IsIncludeAdminValue = "IsIncludeAdminValue";
            public const string AdminValueMinimum = "AdminValueMinimum";
            public const string IsGlobalPlafond = "IsGlobalPlafond";
            public const string IsAdminFromTotal = "IsAdminFromTotal";
            public const string AdminPercentageOp = "AdminPercentageOp";
            public const string AdminAmountLimitOp = "AdminAmountLimitOp";
            public const string AdminValueMinimumOp = "AdminValueMinimumOp";
            public const string ChartOfAccountIdTemporary = "ChartOfAccountIdTemporary";
            public const string SubledgerIdTemporary = "SubledgerIdTemporary";
            public const string IsItemRuleUsingDefaultAmountValue = "IsItemRuleUsingDefaultAmountValue";
            public const string OutpatientAmountValue = "OutpatientAmountValue";
            public const string EmergencyAmountValue = "EmergencyAmountValue";
            public const string SRPaymentType = "SRPaymentType";
            public const string SRPhysicianFeeType = "SRPhysicianFeeType";
            public const string ChartOfAccountIdDeposit = "ChartOfAccountIdDeposit";
            public const string SubledgerIdDeposit = "SubledgerIdDeposit";
            public const string TermOfPayment = "TermOfPayment";
            public const string ChartOfAccountIdOverPayment = "ChartOfAccountIdOverPayment";
            public const string SubledgerIdOverPayment = "SubledgerIdOverPayment";
            public const string SRPhysicianFeeCategory = "SRPhysicianFeeCategory";
            public const string ChartOfAccountIdCostParamedicFee = "ChartOfAccountIdCostParamedicFee";
            public const string SubledgerIdCostParamedicFee = "SubledgerIdCostParamedicFee";
            public const string IsExcessPlafonToDiscount = "IsExcessPlafonToDiscount";
            public const string VirtualAccountNo = "VirtualAccountNo";
            public const string ReportRLID = "ReportRLID";
            public const string RlMasterReportItemID = "RlMasterReportItemID";
            public const string IsCoverAllAdminCosts = "IsCoverAllAdminCosts";
            public const string SRGuarantorIncomeGroup = "SRGuarantorIncomeGroup";
            public const string PrescriptionServiceUnitIdIPR = "PrescriptionServiceUnitIdIPR";
            public const string PrescriptionLocationIdIPR = "PrescriptionLocationIdIPR";
            public const string PrescriptionServiceUnitIdOPR = "PrescriptionServiceUnitIdOPR";
            public const string PrescriptionLocationIdOPR = "PrescriptionLocationIdOPR";
            public const string PrescriptionServiceUnitIdEMR = "PrescriptionServiceUnitIdEMR";
            public const string PrescriptionLocationIdEMR = "PrescriptionLocationIdEMR";
            public const string IsItemRestrictionsFornas = "IsItemRestrictionsFornas";
            public const string IsProrateParamedicFee = "IsProrateParamedicFee";
            public const string TariffCalculationMethod = "TariffCalculationMethod";
            public const string NoteCompanyList = "NoteCompanyList";
            public const string IsAdminCalcBeforeDiscount = "IsAdminCalcBeforeDiscount";
            public const string IsParamedicFeeRemun = "IsParamedicFeeRemun";
            public const string RoundingTransaction = "RoundingTransaction";
            public const string IsUsingRoundingDown = "IsUsingRoundingDown";
            public const string CreditLimit = "CreditLimit";
            public const string CreditAmount = "CreditAmount";
            public const string VirtualAccountBank = "VirtualAccountBank";
            public const string VirtualAccountName = "VirtualAccountName";
            public const string IsFeeBrutoFromFeeAmount = "IsFeeBrutoFromFeeAmount";
            public const string ChartOfAccountIdIPR = "ChartOfAccountIdIPR";
            public const string SubLedgerIdIPR = "SubLedgerIdIPR";
            public const string ChartOfAccountIdTemporaryIPR = "ChartOfAccountIdTemporaryIPR";
            public const string SubledgerIdTemporaryIPR = "SubledgerIdTemporaryIPR";
            public const string IsItemRestrictionsFormularium = "IsItemRestrictionsFormularium";
            public const string IsItemRestrictionsGeneric = "IsItemRestrictionsGeneric";
            public const string IsItemRestrictionsNonGeneric = "IsItemRestrictionsNonGeneric";
            public const string IsItemRestrictionsNonGenericLimited = "IsItemRestrictionsNonGenericLimited";
            public const string ChartOfAccountIdOverPaymentMin = "ChartOfAccountIdOverPaymentMin";
            public const string SubledgerIdOverPaymentMin = "SubledgerIdOverPaymentMin";
            public const string IsDiscountProrataToRevenue = "IsDiscountProrataToRevenue";
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
            lock (typeof(GuarantorMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new GuarantorMetadata();
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


                meta.AddTypeMap("GuarantorID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("GuarantorName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ShortName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRGuarantorType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ContractNumber", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ContractStart", new esTypeMap("smalldatetime", "System.DateTime"));
                meta.AddTypeMap("ContractEnd", new esTypeMap("smalldatetime", "System.DateTime"));
                meta.AddTypeMap("ContractSummary", new esTypeMap("text", "System.String"));
                meta.AddTypeMap("ContactPerson", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsActive", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("SRBusinessMethod", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRTariffType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRGuarantorRuleType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsValueInPercent", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("AmountValue", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("AdminPercentage", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("AdminAmountLimit", new esTypeMap("numeric", "System.Decimal"));
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
                meta.AddTypeMap("ChartOfAccountId", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("SubLedgerId", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsIncludeItemMedical", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsIncludeItemNonMedical", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsIncludeItemOptic", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsIncludeItemMedicalToGuarantor", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsIncludeItemNonMedicalToGuarantor", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsIncludeItemOpticToGuarantor", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsCoverInpatient", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsCoverOutpatient", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ItemMedicMarginPercentage", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("ItemMedicMarginID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ItemNonMedicMarginPercentage", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("ItemNonMedicMarginID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("GuarantorHeaderID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsIncludeAdminValue", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("AdminValueMinimum", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("IsGlobalPlafond", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsAdminFromTotal", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("AdminPercentageOp", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("AdminAmountLimitOp", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("AdminValueMinimumOp", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("ChartOfAccountIdTemporary", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("SubledgerIdTemporary", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("IsItemRuleUsingDefaultAmountValue", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("OutpatientAmountValue", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("EmergencyAmountValue", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("SRPaymentType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRPhysicianFeeType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ChartOfAccountIdDeposit", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("SubledgerIdDeposit", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("TermOfPayment", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("ChartOfAccountIdOverPayment", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("SubledgerIdOverPayment", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("SRPhysicianFeeCategory", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ChartOfAccountIdCostParamedicFee", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("SubledgerIdCostParamedicFee", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("IsExcessPlafonToDiscount", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("VirtualAccountNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ReportRLID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("RlMasterReportItemID", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("IsCoverAllAdminCosts", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("SRGuarantorIncomeGroup", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PrescriptionServiceUnitIdIPR", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PrescriptionLocationIdIPR", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PrescriptionServiceUnitIdOPR", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PrescriptionLocationIdOPR", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PrescriptionServiceUnitIdEMR", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PrescriptionLocationIdEMR", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsItemRestrictionsFornas", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsProrateParamedicFee", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("TariffCalculationMethod", new esTypeMap("tinyint", "System.Byte"));
                meta.AddTypeMap("NoteCompanyList", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsAdminCalcBeforeDiscount", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsParamedicFeeRemun", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("RoundingTransaction", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("IsUsingRoundingDown", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("CreditLimit", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("CreditAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("VirtualAccountBank", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("VirtualAccountName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsFeeBrutoFromFeeAmount", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ChartOfAccountIdIPR", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("SubLedgerIdIPR", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("ChartOfAccountIdTemporaryIPR", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("SubledgerIdTemporaryIPR", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("IsItemRestrictionsFormularium", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsItemRestrictionsGeneric", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsItemRestrictionsNonGeneric", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsItemRestrictionsNonGenericLimited", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ChartOfAccountIdOverPaymentMin", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("SubledgerIdOverPaymentMin", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("IsDiscountProrataToRevenue", new esTypeMap("bit", "System.Boolean"));



                meta.Source = "Guarantor";
                meta.Destination = "Guarantor";

                meta.spInsert = "proc_GuarantorInsert";
                meta.spUpdate = "proc_GuarantorUpdate";
                meta.spDelete = "proc_GuarantorDelete";
                meta.spLoadAll = "proc_GuarantorLoadAll";
                meta.spLoadByPrimaryKey = "proc_GuarantorLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private GuarantorMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
