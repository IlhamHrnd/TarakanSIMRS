
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 2/13/2025 8:44:42 AM
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
    /// Encapsulates the 'ServiceUnitBooking' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(ServiceUnitBooking))]
    [XmlType("ServiceUnitBooking")]
    public partial class ServiceUnitBooking : esServiceUnitBooking
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new ServiceUnitBooking();
        }

        #region Static Quick Access Methods
        static public void Delete(string bookingNo)
        {
            var obj = new ServiceUnitBooking();
            obj.BookingNo = bookingNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string bookingNo, esSqlAccessType sqlAccessType)
        {
            var obj = new ServiceUnitBooking();
            obj.BookingNo = bookingNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("ServiceUnitBookingCollection")]
    public partial class ServiceUnitBookingCollection : esServiceUnitBookingCollection, IEnumerable<ServiceUnitBooking>
    {
        public ServiceUnitBooking FindByPrimaryKey(string bookingNo)
        {
            return this.SingleOrDefault(e => e.BookingNo == bookingNo);
        }



    }



    [Serializable]
    public partial class ServiceUnitBookingQuery : esServiceUnitBookingQuery
    {
        public ServiceUnitBookingQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public ServiceUnitBookingQuery(string joinAlias, out ServiceUnitBookingQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "ServiceUnitBookingQuery";
        }



        #region Explicit Casts

        public static explicit operator string(ServiceUnitBookingQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator ServiceUnitBookingQuery(string query)
        {
            return (ServiceUnitBookingQuery)SerializeHelper.FromXml(query, typeof(ServiceUnitBookingQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esServiceUnitBooking : esEntity
    {
        public esServiceUnitBooking()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string bookingNo)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(bookingNo);
            else
                return LoadByPrimaryKeyStoredProcedure(bookingNo);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string bookingNo)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(bookingNo);
            else
                return LoadByPrimaryKeyStoredProcedure(bookingNo);
        }

        private bool LoadByPrimaryKeyDynamic(string bookingNo)
        {
            ServiceUnitBookingQuery query = new ServiceUnitBookingQuery("subQ");
            query.Where(query.BookingNo == bookingNo);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string bookingNo)
        {
            esParameters parms = new esParameters();
            parms.Add("BookingNo", bookingNo);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to ServiceUnitBooking.BookingNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string BookingNo
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.BookingNo);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.BookingNo, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.BookingNo);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.BookingDateTimeFrom
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? BookingDateTimeFrom
        {
            get
            {
                return GetSystemDateTime(ServiceUnitBookingMetadata.ColumnNames.BookingDateTimeFrom);
            }

            set
            {
                if (SetSystemDateTime(ServiceUnitBookingMetadata.ColumnNames.BookingDateTimeFrom, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.BookingDateTimeFrom);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.BookingDateTimeTo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? BookingDateTimeTo
        {
            get
            {
                return GetSystemDateTime(ServiceUnitBookingMetadata.ColumnNames.BookingDateTimeTo);
            }

            set
            {
                if (SetSystemDateTime(ServiceUnitBookingMetadata.ColumnNames.BookingDateTimeTo, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.BookingDateTimeTo);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.ServiceUnitID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ServiceUnitID
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.ServiceUnitID);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.ServiceUnitID, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.ServiceUnitID);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.RoomID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RoomID
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.RoomID);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.RoomID, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.RoomID);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.PatientID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PatientID
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.PatientID);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.PatientID, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.PatientID);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.RegistrationNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RegistrationNo
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.RegistrationNo);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.RegistrationNo, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.RegistrationNo);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.ParamedicID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParamedicID
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.ParamedicID);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.ParamedicID, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.ParamedicID);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.IsApproved
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsApproved
        {
            get
            {
                return GetSystemBoolean(ServiceUnitBookingMetadata.ColumnNames.IsApproved);
            }

            set
            {
                if (SetSystemBoolean(ServiceUnitBookingMetadata.ColumnNames.IsApproved, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.IsApproved);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.IsVoid
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsVoid
        {
            get
            {
                return GetSystemBoolean(ServiceUnitBookingMetadata.ColumnNames.IsVoid);
            }

            set
            {
                if (SetSystemBoolean(ServiceUnitBookingMetadata.ColumnNames.IsVoid, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.IsVoid);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.Notes
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Notes
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.Notes);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.Notes, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.Notes);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(ServiceUnitBookingMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(ServiceUnitBookingMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.LastCreateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastCreateDateTime
        {
            get
            {
                return GetSystemDateTime(ServiceUnitBookingMetadata.ColumnNames.LastCreateDateTime);
            }

            set
            {
                if (SetSystemDateTime(ServiceUnitBookingMetadata.ColumnNames.LastCreateDateTime, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.LastCreateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.LastCreateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastCreateByUserID
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.LastCreateByUserID);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.LastCreateByUserID, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.LastCreateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.SRAnestesiPlan
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRAnestesiPlan
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.SRAnestesiPlan);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.SRAnestesiPlan, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.SRAnestesiPlan);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.ParamedicID2
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParamedicID2
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.ParamedicID2);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.ParamedicID2, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.ParamedicID2);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.ParamedicID3
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParamedicID3
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.ParamedicID3);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.ParamedicID3, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.ParamedicID3);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.ParamedicID4
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParamedicID4
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.ParamedicID4);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.ParamedicID4, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.ParamedicID4);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.ParamedicIDAnestesi
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParamedicIDAnestesi
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.ParamedicIDAnestesi);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.ParamedicIDAnestesi, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.ParamedicIDAnestesi);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.AssistantID1
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string AssistantID1
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.AssistantID1);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.AssistantID1, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.AssistantID1);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.AssistantID2
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string AssistantID2
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.AssistantID2);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.AssistantID2, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.AssistantID2);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.AssistantID3
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string AssistantID3
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.AssistantID3);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.AssistantID3, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.AssistantID3);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.AssistantID4
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string AssistantID4
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.AssistantID4);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.AssistantID4, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.AssistantID4);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.AssistantIDAnestesi
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string AssistantIDAnestesi
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.AssistantIDAnestesi);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.AssistantIDAnestesi, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.AssistantIDAnestesi);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.Diagnose
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Diagnose
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.Diagnose);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.Diagnose, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.Diagnose);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.OperationType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string OperationType
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.OperationType);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.OperationType, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.OperationType);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.IsCito
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsCito
        {
            get
            {
                return GetSystemBoolean(ServiceUnitBookingMetadata.ColumnNames.IsCito);
            }

            set
            {
                if (SetSystemBoolean(ServiceUnitBookingMetadata.ColumnNames.IsCito, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.IsCito);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.ProcedureChargeClassID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ProcedureChargeClassID
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.ProcedureChargeClassID);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.ProcedureChargeClassID, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.ProcedureChargeClassID);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.OperatingNotes
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string OperatingNotes
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.OperatingNotes);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.OperatingNotes, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.OperatingNotes);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.Instrumentator1
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Instrumentator1
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.Instrumentator1);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.Instrumentator1, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.Instrumentator1);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.Instrumentator2
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Instrumentator2
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.Instrumentator2);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.Instrumentator2, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.Instrumentator2);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.SRProcedureCategory
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRProcedureCategory
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.SRProcedureCategory);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.SRProcedureCategory, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.SRProcedureCategory);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.RealizationDateTimeFrom
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? RealizationDateTimeFrom
        {
            get
            {
                return GetSystemDateTime(ServiceUnitBookingMetadata.ColumnNames.RealizationDateTimeFrom);
            }

            set
            {
                if (SetSystemDateTime(ServiceUnitBookingMetadata.ColumnNames.RealizationDateTimeFrom, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.RealizationDateTimeFrom);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.RealizationDateTimeTo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? RealizationDateTimeTo
        {
            get
            {
                return GetSystemDateTime(ServiceUnitBookingMetadata.ColumnNames.RealizationDateTimeTo);
            }

            set
            {
                if (SetSystemDateTime(ServiceUnitBookingMetadata.ColumnNames.RealizationDateTimeTo, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.RealizationDateTimeTo);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.Resident
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Resident
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.Resident);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.Resident, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.Resident);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.AssistantIDInstrumentator
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string AssistantIDInstrumentator
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.AssistantIDInstrumentator);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.AssistantIDInstrumentator, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.AssistantIDInstrumentator);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.SmfID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SmfID
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.SmfID);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.SmfID, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.SmfID);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.IsExtendedSurgery
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsExtendedSurgery
        {
            get
            {
                return GetSystemBoolean(ServiceUnitBookingMetadata.ColumnNames.IsExtendedSurgery);
            }

            set
            {
                if (SetSystemBoolean(ServiceUnitBookingMetadata.ColumnNames.IsExtendedSurgery, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.IsExtendedSurgery);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.SRIndication
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRIndication
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.SRIndication);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.SRIndication, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.SRIndication);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.IsNeedPa
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsNeedPa
        {
            get
            {
                return GetSystemBoolean(ServiceUnitBookingMetadata.ColumnNames.IsNeedPa);
            }

            set
            {
                if (SetSystemBoolean(ServiceUnitBookingMetadata.ColumnNames.IsNeedPa, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.IsNeedPa);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.AssistantID5
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string AssistantID5
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.AssistantID5);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.AssistantID5, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.AssistantID5);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.AssistantIDInstrumentator2
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string AssistantIDInstrumentator2
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.AssistantIDInstrumentator2);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.AssistantIDInstrumentator2, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.AssistantIDInstrumentator2);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.AssistantIDInstrumentator3
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string AssistantIDInstrumentator3
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.AssistantIDInstrumentator3);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.AssistantIDInstrumentator3, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.AssistantIDInstrumentator3);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.AssistantIDInstrumentator4
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string AssistantIDInstrumentator4
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.AssistantIDInstrumentator4);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.AssistantIDInstrumentator4, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.AssistantIDInstrumentator4);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.AssistantIDInstrumentator5
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string AssistantIDInstrumentator5
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.AssistantIDInstrumentator5);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.AssistantIDInstrumentator5, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.AssistantIDInstrumentator5);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.Instrumentator3
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Instrumentator3
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.Instrumentator3);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.Instrumentator3, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.Instrumentator3);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.Instrumentator4
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Instrumentator4
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.Instrumentator4);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.Instrumentator4, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.Instrumentator4);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.Instrumentator5
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Instrumentator5
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.Instrumentator5);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.Instrumentator5, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.Instrumentator5);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.AnestesyNotes
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string AnestesyNotes
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.AnestesyNotes);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.AnestesyNotes, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.AnestesyNotes);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.SRProcedure1
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRProcedure1
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.SRProcedure1);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.SRProcedure1, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.SRProcedure1);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.SRProcedure2
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRProcedure2
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.SRProcedure2);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.SRProcedure2, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.SRProcedure2);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.PostDiagnosis
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PostDiagnosis
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.PostDiagnosis);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.PostDiagnosis, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.PostDiagnosis);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.PaDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? PaDate
        {
            get
            {
                return GetSystemDateTime(ServiceUnitBookingMetadata.ColumnNames.PaDate);
            }

            set
            {
                if (SetSystemDateTime(ServiceUnitBookingMetadata.ColumnNames.PaDate, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.PaDate);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.SourceOfTissue
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SourceOfTissue
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.SourceOfTissue);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.SourceOfTissue, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.SourceOfTissue);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.ArrivedDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? ArrivedDateTime
        {
            get
            {
                return GetSystemDateTime(ServiceUnitBookingMetadata.ColumnNames.ArrivedDateTime);
            }

            set
            {
                if (SetSystemDateTime(ServiceUnitBookingMetadata.ColumnNames.ArrivedDateTime, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.ArrivedDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.IsAnestheticConversion
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsAnestheticConversion
        {
            get
            {
                return GetSystemBoolean(ServiceUnitBookingMetadata.ColumnNames.IsAnestheticConversion);
            }

            set
            {
                if (SetSystemBoolean(ServiceUnitBookingMetadata.ColumnNames.IsAnestheticConversion, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.IsAnestheticConversion);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.IsValidate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsValidate
        {
            get
            {
                return GetSystemBoolean(ServiceUnitBookingMetadata.ColumnNames.IsValidate);
            }

            set
            {
                if (SetSystemBoolean(ServiceUnitBookingMetadata.ColumnNames.IsValidate, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.IsValidate);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.ValidateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? ValidateDateTime
        {
            get
            {
                return GetSystemDateTime(ServiceUnitBookingMetadata.ColumnNames.ValidateDateTime);
            }

            set
            {
                if (SetSystemDateTime(ServiceUnitBookingMetadata.ColumnNames.ValidateDateTime, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.ValidateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.ValidateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ValidateByUserID
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.ValidateByUserID);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.ValidateByUserID, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.ValidateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.PreSurgeryDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? PreSurgeryDateTime
        {
            get
            {
                return GetSystemDateTime(ServiceUnitBookingMetadata.ColumnNames.PreSurgeryDateTime);
            }

            set
            {
                if (SetSystemDateTime(ServiceUnitBookingMetadata.ColumnNames.PreSurgeryDateTime, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.PreSurgeryDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.PreSurgeryByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PreSurgeryByUserID
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.PreSurgeryByUserID);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.PreSurgeryByUserID, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.PreSurgeryByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.AnesthesiaDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? AnesthesiaDateTime
        {
            get
            {
                return GetSystemDateTime(ServiceUnitBookingMetadata.ColumnNames.AnesthesiaDateTime);
            }

            set
            {
                if (SetSystemDateTime(ServiceUnitBookingMetadata.ColumnNames.AnesthesiaDateTime, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.AnesthesiaDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.AnesthesiaByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string AnesthesiaByUserID
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.AnesthesiaByUserID);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.AnesthesiaByUserID, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.AnesthesiaByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.SurgeryDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? SurgeryDateTime
        {
            get
            {
                return GetSystemDateTime(ServiceUnitBookingMetadata.ColumnNames.SurgeryDateTime);
            }

            set
            {
                if (SetSystemDateTime(ServiceUnitBookingMetadata.ColumnNames.SurgeryDateTime, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.SurgeryDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.SurgeryByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SurgeryByUserID
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.SurgeryByUserID);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.SurgeryByUserID, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.SurgeryByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.PostSurgeryDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? PostSurgeryDateTime
        {
            get
            {
                return GetSystemDateTime(ServiceUnitBookingMetadata.ColumnNames.PostSurgeryDateTime);
            }

            set
            {
                if (SetSystemDateTime(ServiceUnitBookingMetadata.ColumnNames.PostSurgeryDateTime, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.PostSurgeryDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.PostSurgeryByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PostSurgeryByUserID
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.PostSurgeryByUserID);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.PostSurgeryByUserID, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.PostSurgeryByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.VoidReason
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string VoidReason
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.VoidReason);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.VoidReason, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.VoidReason);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.FromServiceUnitID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string FromServiceUnitID
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.FromServiceUnitID);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.FromServiceUnitID, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.FromServiceUnitID);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.IsInsertionImplant
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsInsertionImplant
        {
            get
            {
                return GetSystemBoolean(ServiceUnitBookingMetadata.ColumnNames.IsInsertionImplant);
            }

            set
            {
                if (SetSystemBoolean(ServiceUnitBookingMetadata.ColumnNames.IsInsertionImplant, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.IsInsertionImplant);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.IncisionDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? IncisionDateTime
        {
            get
            {
                return GetSystemDateTime(ServiceUnitBookingMetadata.ColumnNames.IncisionDateTime);
            }

            set
            {
                if (SetSystemDateTime(ServiceUnitBookingMetadata.ColumnNames.IncisionDateTime, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.IncisionDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.SRProcedureDiagnoseType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRProcedureDiagnoseType
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.SRProcedureDiagnoseType);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.SRProcedureDiagnoseType, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.SRProcedureDiagnoseType);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.MoveToTheWardDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? MoveToTheWardDateTime
        {
            get
            {
                return GetSystemDateTime(ServiceUnitBookingMetadata.ColumnNames.MoveToTheWardDateTime);
            }

            set
            {
                if (SetSystemDateTime(ServiceUnitBookingMetadata.ColumnNames.MoveToTheWardDateTime, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.MoveToTheWardDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.MoveToTheWardByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string MoveToTheWardByUserID
        {
            get
            {
                return GetSystemString(ServiceUnitBookingMetadata.ColumnNames.MoveToTheWardByUserID);
            }

            set
            {
                if (SetSystemString(ServiceUnitBookingMetadata.ColumnNames.MoveToTheWardByUserID, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.MoveToTheWardByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceUnitBooking.AnesthesiologistSign
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public byte[] AnesthesiologistSign
        {
            get
            {
                return GetSystemByteArray(ServiceUnitBookingMetadata.ColumnNames.AnesthesiologistSign);
            }

            set
            {
                if (SetSystemByteArray(ServiceUnitBookingMetadata.ColumnNames.AnesthesiologistSign, value))
                {
                    OnPropertyChanged(ServiceUnitBookingMetadata.PropertyNames.AnesthesiologistSign);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return ServiceUnitBookingMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public ServiceUnitBookingQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new ServiceUnitBookingQuery("subQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(ServiceUnitBookingQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(ServiceUnitBookingQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((ServiceUnitBookingQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private ServiceUnitBookingQuery query;
    }



    [Serializable]
    abstract public partial class esServiceUnitBookingCollection : esEntityCollection<ServiceUnitBooking>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return ServiceUnitBookingMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "ServiceUnitBookingCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public ServiceUnitBookingQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new ServiceUnitBookingQuery("subQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(ServiceUnitBookingQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new ServiceUnitBookingQuery("subQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(ServiceUnitBookingQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((ServiceUnitBookingQuery)query);
        }

        #endregion

        private ServiceUnitBookingQuery query;
    }



    [Serializable]
    abstract public partial class esServiceUnitBookingQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return ServiceUnitBookingMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "BookingNo": return BookingNo;
                case "BookingDateTimeFrom": return BookingDateTimeFrom;
                case "BookingDateTimeTo": return BookingDateTimeTo;
                case "ServiceUnitID": return ServiceUnitID;
                case "RoomID": return RoomID;
                case "PatientID": return PatientID;
                case "RegistrationNo": return RegistrationNo;
                case "ParamedicID": return ParamedicID;
                case "IsApproved": return IsApproved;
                case "IsVoid": return IsVoid;
                case "Notes": return Notes;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "LastCreateDateTime": return LastCreateDateTime;
                case "LastCreateByUserID": return LastCreateByUserID;
                case "SRAnestesiPlan": return SRAnestesiPlan;
                case "ParamedicID2": return ParamedicID2;
                case "ParamedicID3": return ParamedicID3;
                case "ParamedicID4": return ParamedicID4;
                case "ParamedicIDAnestesi": return ParamedicIDAnestesi;
                case "AssistantID1": return AssistantID1;
                case "AssistantID2": return AssistantID2;
                case "AssistantID3": return AssistantID3;
                case "AssistantID4": return AssistantID4;
                case "AssistantIDAnestesi": return AssistantIDAnestesi;
                case "Diagnose": return Diagnose;
                case "OperationType": return OperationType;
                case "IsCito": return IsCito;
                case "ProcedureChargeClassID": return ProcedureChargeClassID;
                case "OperatingNotes": return OperatingNotes;
                case "Instrumentator1": return Instrumentator1;
                case "Instrumentator2": return Instrumentator2;
                case "SRProcedureCategory": return SRProcedureCategory;
                case "RealizationDateTimeFrom": return RealizationDateTimeFrom;
                case "RealizationDateTimeTo": return RealizationDateTimeTo;
                case "Resident": return Resident;
                case "AssistantIDInstrumentator": return AssistantIDInstrumentator;
                case "SmfID": return SmfID;
                case "IsExtendedSurgery": return IsExtendedSurgery;
                case "SRIndication": return SRIndication;
                case "IsNeedPa": return IsNeedPa;
                case "AssistantID5": return AssistantID5;
                case "AssistantIDInstrumentator2": return AssistantIDInstrumentator2;
                case "AssistantIDInstrumentator3": return AssistantIDInstrumentator3;
                case "AssistantIDInstrumentator4": return AssistantIDInstrumentator4;
                case "AssistantIDInstrumentator5": return AssistantIDInstrumentator5;
                case "Instrumentator3": return Instrumentator3;
                case "Instrumentator4": return Instrumentator4;
                case "Instrumentator5": return Instrumentator5;
                case "AnestesyNotes": return AnestesyNotes;
                case "SRProcedure1": return SRProcedure1;
                case "SRProcedure2": return SRProcedure2;
                case "PostDiagnosis": return PostDiagnosis;
                case "PaDate": return PaDate;
                case "SourceOfTissue": return SourceOfTissue;
                case "ArrivedDateTime": return ArrivedDateTime;
                case "IsAnestheticConversion": return IsAnestheticConversion;
                case "IsValidate": return IsValidate;
                case "ValidateDateTime": return ValidateDateTime;
                case "ValidateByUserID": return ValidateByUserID;
                case "PreSurgeryDateTime": return PreSurgeryDateTime;
                case "PreSurgeryByUserID": return PreSurgeryByUserID;
                case "AnesthesiaDateTime": return AnesthesiaDateTime;
                case "AnesthesiaByUserID": return AnesthesiaByUserID;
                case "SurgeryDateTime": return SurgeryDateTime;
                case "SurgeryByUserID": return SurgeryByUserID;
                case "PostSurgeryDateTime": return PostSurgeryDateTime;
                case "PostSurgeryByUserID": return PostSurgeryByUserID;
                case "VoidReason": return VoidReason;
                case "FromServiceUnitID": return FromServiceUnitID;
                case "IsInsertionImplant": return IsInsertionImplant;
                case "IncisionDateTime": return IncisionDateTime;
                case "SRProcedureDiagnoseType": return SRProcedureDiagnoseType;
                case "MoveToTheWardDateTime": return MoveToTheWardDateTime;
                case "MoveToTheWardByUserID": return MoveToTheWardByUserID;
                case "AnesthesiologistSign": return AnesthesiologistSign;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem BookingNo
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.BookingNo, esSystemType.String); }
        }

        public esQueryItem BookingDateTimeFrom
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.BookingDateTimeFrom, esSystemType.DateTime); }
        }

        public esQueryItem BookingDateTimeTo
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.BookingDateTimeTo, esSystemType.DateTime); }
        }

        public esQueryItem ServiceUnitID
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.ServiceUnitID, esSystemType.String); }
        }

        public esQueryItem RoomID
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.RoomID, esSystemType.String); }
        }

        public esQueryItem PatientID
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.PatientID, esSystemType.String); }
        }

        public esQueryItem RegistrationNo
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.RegistrationNo, esSystemType.String); }
        }

        public esQueryItem ParamedicID
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.ParamedicID, esSystemType.String); }
        }

        public esQueryItem IsApproved
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.IsApproved, esSystemType.Boolean); }
        }

        public esQueryItem IsVoid
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.IsVoid, esSystemType.Boolean); }
        }

        public esQueryItem Notes
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.Notes, esSystemType.String); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem LastCreateDateTime
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.LastCreateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastCreateByUserID
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.LastCreateByUserID, esSystemType.String); }
        }

        public esQueryItem SRAnestesiPlan
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.SRAnestesiPlan, esSystemType.String); }
        }

        public esQueryItem ParamedicID2
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.ParamedicID2, esSystemType.String); }
        }

        public esQueryItem ParamedicID3
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.ParamedicID3, esSystemType.String); }
        }

        public esQueryItem ParamedicID4
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.ParamedicID4, esSystemType.String); }
        }

        public esQueryItem ParamedicIDAnestesi
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.ParamedicIDAnestesi, esSystemType.String); }
        }

        public esQueryItem AssistantID1
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.AssistantID1, esSystemType.String); }
        }

        public esQueryItem AssistantID2
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.AssistantID2, esSystemType.String); }
        }

        public esQueryItem AssistantID3
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.AssistantID3, esSystemType.String); }
        }

        public esQueryItem AssistantID4
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.AssistantID4, esSystemType.String); }
        }

        public esQueryItem AssistantIDAnestesi
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.AssistantIDAnestesi, esSystemType.String); }
        }

        public esQueryItem Diagnose
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.Diagnose, esSystemType.String); }
        }

        public esQueryItem OperationType
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.OperationType, esSystemType.String); }
        }

        public esQueryItem IsCito
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.IsCito, esSystemType.Boolean); }
        }

        public esQueryItem ProcedureChargeClassID
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.ProcedureChargeClassID, esSystemType.String); }
        }

        public esQueryItem OperatingNotes
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.OperatingNotes, esSystemType.String); }
        }

        public esQueryItem Instrumentator1
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.Instrumentator1, esSystemType.String); }
        }

        public esQueryItem Instrumentator2
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.Instrumentator2, esSystemType.String); }
        }

        public esQueryItem SRProcedureCategory
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.SRProcedureCategory, esSystemType.String); }
        }

        public esQueryItem RealizationDateTimeFrom
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.RealizationDateTimeFrom, esSystemType.DateTime); }
        }

        public esQueryItem RealizationDateTimeTo
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.RealizationDateTimeTo, esSystemType.DateTime); }
        }

        public esQueryItem Resident
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.Resident, esSystemType.String); }
        }

        public esQueryItem AssistantIDInstrumentator
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.AssistantIDInstrumentator, esSystemType.String); }
        }

        public esQueryItem SmfID
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.SmfID, esSystemType.String); }
        }

        public esQueryItem IsExtendedSurgery
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.IsExtendedSurgery, esSystemType.Boolean); }
        }

        public esQueryItem SRIndication
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.SRIndication, esSystemType.String); }
        }

        public esQueryItem IsNeedPa
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.IsNeedPa, esSystemType.Boolean); }
        }

        public esQueryItem AssistantID5
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.AssistantID5, esSystemType.String); }
        }

        public esQueryItem AssistantIDInstrumentator2
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.AssistantIDInstrumentator2, esSystemType.String); }
        }

        public esQueryItem AssistantIDInstrumentator3
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.AssistantIDInstrumentator3, esSystemType.String); }
        }

        public esQueryItem AssistantIDInstrumentator4
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.AssistantIDInstrumentator4, esSystemType.String); }
        }

        public esQueryItem AssistantIDInstrumentator5
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.AssistantIDInstrumentator5, esSystemType.String); }
        }

        public esQueryItem Instrumentator3
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.Instrumentator3, esSystemType.String); }
        }

        public esQueryItem Instrumentator4
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.Instrumentator4, esSystemType.String); }
        }

        public esQueryItem Instrumentator5
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.Instrumentator5, esSystemType.String); }
        }

        public esQueryItem AnestesyNotes
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.AnestesyNotes, esSystemType.String); }
        }

        public esQueryItem SRProcedure1
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.SRProcedure1, esSystemType.String); }
        }

        public esQueryItem SRProcedure2
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.SRProcedure2, esSystemType.String); }
        }

        public esQueryItem PostDiagnosis
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.PostDiagnosis, esSystemType.String); }
        }

        public esQueryItem PaDate
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.PaDate, esSystemType.DateTime); }
        }

        public esQueryItem SourceOfTissue
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.SourceOfTissue, esSystemType.String); }
        }

        public esQueryItem ArrivedDateTime
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.ArrivedDateTime, esSystemType.DateTime); }
        }

        public esQueryItem IsAnestheticConversion
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.IsAnestheticConversion, esSystemType.Boolean); }
        }

        public esQueryItem IsValidate
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.IsValidate, esSystemType.Boolean); }
        }

        public esQueryItem ValidateDateTime
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.ValidateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem ValidateByUserID
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.ValidateByUserID, esSystemType.String); }
        }

        public esQueryItem PreSurgeryDateTime
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.PreSurgeryDateTime, esSystemType.DateTime); }
        }

        public esQueryItem PreSurgeryByUserID
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.PreSurgeryByUserID, esSystemType.String); }
        }

        public esQueryItem AnesthesiaDateTime
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.AnesthesiaDateTime, esSystemType.DateTime); }
        }

        public esQueryItem AnesthesiaByUserID
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.AnesthesiaByUserID, esSystemType.String); }
        }

        public esQueryItem SurgeryDateTime
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.SurgeryDateTime, esSystemType.DateTime); }
        }

        public esQueryItem SurgeryByUserID
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.SurgeryByUserID, esSystemType.String); }
        }

        public esQueryItem PostSurgeryDateTime
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.PostSurgeryDateTime, esSystemType.DateTime); }
        }

        public esQueryItem PostSurgeryByUserID
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.PostSurgeryByUserID, esSystemType.String); }
        }

        public esQueryItem VoidReason
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.VoidReason, esSystemType.String); }
        }

        public esQueryItem FromServiceUnitID
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.FromServiceUnitID, esSystemType.String); }
        }

        public esQueryItem IsInsertionImplant
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.IsInsertionImplant, esSystemType.Boolean); }
        }

        public esQueryItem IncisionDateTime
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.IncisionDateTime, esSystemType.DateTime); }
        }

        public esQueryItem SRProcedureDiagnoseType
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.SRProcedureDiagnoseType, esSystemType.String); }
        }

        public esQueryItem MoveToTheWardDateTime
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.MoveToTheWardDateTime, esSystemType.DateTime); }
        }

        public esQueryItem MoveToTheWardByUserID
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.MoveToTheWardByUserID, esSystemType.String); }
        }

        public esQueryItem AnesthesiologistSign
        {
            get { return new esQueryItem(this, ServiceUnitBookingMetadata.ColumnNames.AnesthesiologistSign, esSystemType.ByteArray); }
        }

        #endregion

    }



    [Serializable]
    public partial class ServiceUnitBookingMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected ServiceUnitBookingMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.BookingNo, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.BookingNo;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 20;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.BookingDateTimeFrom, 1, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.BookingDateTimeFrom;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.BookingDateTimeTo, 2, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.BookingDateTimeTo;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ServiceUnitID, 3, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ServiceUnitID;
            c.CharacterMaxLength = 10;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RoomID, 4, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RoomID;
            c.CharacterMaxLength = 10;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PatientID, 5, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PatientID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RegistrationNo, 6, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RegistrationNo;
            c.CharacterMaxLength = 20;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParamedicID, 7, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParamedicID;
            c.CharacterMaxLength = 10;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsApproved, 8, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsApproved;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsVoid, 9, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsVoid;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Notes, 10, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Notes;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 11, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 12, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastCreateDateTime, 13, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastCreateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastCreateByUserID, 14, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastCreateByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRAnestesiPlan, 15, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRAnestesiPlan;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParamedicID2, 16, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParamedicID2;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParamedicID3, 17, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParamedicID3;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParamedicID4, 18, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParamedicID4;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParamedicIDAnestesi, 19, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParamedicIDAnestesi;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AssistantID1, 20, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.AssistantID1;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AssistantID2, 21, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.AssistantID2;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AssistantID3, 22, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.AssistantID3;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AssistantID4, 23, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.AssistantID4;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AssistantIDAnestesi, 24, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.AssistantIDAnestesi;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Diagnose, 25, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Diagnose;
            c.CharacterMaxLength = 100;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.OperationType, 26, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.OperationType;
            c.CharacterMaxLength = 100;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsCito, 27, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsCito;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ProcedureChargeClassID, 28, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ProcedureChargeClassID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.OperatingNotes, 29, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.OperatingNotes;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Instrumentator1, 30, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Instrumentator1;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Instrumentator2, 31, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Instrumentator2;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRProcedureCategory, 32, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRProcedureCategory;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RealizationDateTimeFrom, 33, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.RealizationDateTimeFrom;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RealizationDateTimeTo, 34, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.RealizationDateTimeTo;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Resident, 35, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Resident;
            c.CharacterMaxLength = 255;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AssistantIDInstrumentator, 36, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.AssistantIDInstrumentator;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SmfID, 37, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SmfID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsExtendedSurgery, 38, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsExtendedSurgery;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRIndication, 39, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRIndication;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsNeedPa, 40, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsNeedPa;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AssistantID5, 41, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.AssistantID5;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AssistantIDInstrumentator2, 42, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.AssistantIDInstrumentator2;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AssistantIDInstrumentator3, 43, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.AssistantIDInstrumentator3;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AssistantIDInstrumentator4, 44, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.AssistantIDInstrumentator4;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AssistantIDInstrumentator5, 45, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.AssistantIDInstrumentator5;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Instrumentator3, 46, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Instrumentator3;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Instrumentator4, 47, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Instrumentator4;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Instrumentator5, 48, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Instrumentator5;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AnestesyNotes, 49, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.AnestesyNotes;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRProcedure1, 50, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRProcedure1;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRProcedure2, 51, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRProcedure2;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PostDiagnosis, 52, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PostDiagnosis;
            c.CharacterMaxLength = 100;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PaDate, 53, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.PaDate;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SourceOfTissue, 54, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SourceOfTissue;
            c.CharacterMaxLength = 100;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ArrivedDateTime, 55, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.ArrivedDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsAnestheticConversion, 56, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsAnestheticConversion;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsValidate, 57, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsValidate;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ValidateDateTime, 58, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.ValidateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ValidateByUserID, 59, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ValidateByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PreSurgeryDateTime, 60, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.PreSurgeryDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PreSurgeryByUserID, 61, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PreSurgeryByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AnesthesiaDateTime, 62, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.AnesthesiaDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AnesthesiaByUserID, 63, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.AnesthesiaByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SurgeryDateTime, 64, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.SurgeryDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SurgeryByUserID, 65, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SurgeryByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PostSurgeryDateTime, 66, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.PostSurgeryDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PostSurgeryByUserID, 67, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PostSurgeryByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.VoidReason, 68, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.VoidReason;
            c.CharacterMaxLength = 500;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FromServiceUnitID, 69, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.FromServiceUnitID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsInsertionImplant, 70, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsInsertionImplant;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IncisionDateTime, 71, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.IncisionDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRProcedureDiagnoseType, 72, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRProcedureDiagnoseType;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.MoveToTheWardDateTime, 73, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.MoveToTheWardDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.MoveToTheWardByUserID, 74, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.MoveToTheWardByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AnesthesiologistSign, 75, typeof(byte[]), esSystemType.ByteArray);
            c.PropertyName = PropertyNames.AnesthesiologistSign;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public ServiceUnitBookingMetadata Meta()
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
            public const string BookingNo = "BookingNo";
            public const string BookingDateTimeFrom = "BookingDateTimeFrom";
            public const string BookingDateTimeTo = "BookingDateTimeTo";
            public const string ServiceUnitID = "ServiceUnitID";
            public const string RoomID = "RoomID";
            public const string PatientID = "PatientID";
            public const string RegistrationNo = "RegistrationNo";
            public const string ParamedicID = "ParamedicID";
            public const string IsApproved = "IsApproved";
            public const string IsVoid = "IsVoid";
            public const string Notes = "Notes";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string LastCreateDateTime = "LastCreateDateTime";
            public const string LastCreateByUserID = "LastCreateByUserID";
            public const string SRAnestesiPlan = "SRAnestesiPlan";
            public const string ParamedicID2 = "ParamedicID2";
            public const string ParamedicID3 = "ParamedicID3";
            public const string ParamedicID4 = "ParamedicID4";
            public const string ParamedicIDAnestesi = "ParamedicIDAnestesi";
            public const string AssistantID1 = "AssistantID1";
            public const string AssistantID2 = "AssistantID2";
            public const string AssistantID3 = "AssistantID3";
            public const string AssistantID4 = "AssistantID4";
            public const string AssistantIDAnestesi = "AssistantIDAnestesi";
            public const string Diagnose = "Diagnose";
            public const string OperationType = "OperationType";
            public const string IsCito = "IsCito";
            public const string ProcedureChargeClassID = "ProcedureChargeClassID";
            public const string OperatingNotes = "OperatingNotes";
            public const string Instrumentator1 = "Instrumentator1";
            public const string Instrumentator2 = "Instrumentator2";
            public const string SRProcedureCategory = "SRProcedureCategory";
            public const string RealizationDateTimeFrom = "RealizationDateTimeFrom";
            public const string RealizationDateTimeTo = "RealizationDateTimeTo";
            public const string Resident = "Resident";
            public const string AssistantIDInstrumentator = "AssistantIDInstrumentator";
            public const string SmfID = "SmfID";
            public const string IsExtendedSurgery = "IsExtendedSurgery";
            public const string SRIndication = "SRIndication";
            public const string IsNeedPa = "IsNeedPa";
            public const string AssistantID5 = "AssistantID5";
            public const string AssistantIDInstrumentator2 = "AssistantIDInstrumentator2";
            public const string AssistantIDInstrumentator3 = "AssistantIDInstrumentator3";
            public const string AssistantIDInstrumentator4 = "AssistantIDInstrumentator4";
            public const string AssistantIDInstrumentator5 = "AssistantIDInstrumentator5";
            public const string Instrumentator3 = "Instrumentator3";
            public const string Instrumentator4 = "Instrumentator4";
            public const string Instrumentator5 = "Instrumentator5";
            public const string AnestesyNotes = "AnestesyNotes";
            public const string SRProcedure1 = "SRProcedure1";
            public const string SRProcedure2 = "SRProcedure2";
            public const string PostDiagnosis = "PostDiagnosis";
            public const string PaDate = "PaDate";
            public const string SourceOfTissue = "SourceOfTissue";
            public const string ArrivedDateTime = "ArrivedDateTime";
            public const string IsAnestheticConversion = "IsAnestheticConversion";
            public const string IsValidate = "IsValidate";
            public const string ValidateDateTime = "ValidateDateTime";
            public const string ValidateByUserID = "ValidateByUserID";
            public const string PreSurgeryDateTime = "PreSurgeryDateTime";
            public const string PreSurgeryByUserID = "PreSurgeryByUserID";
            public const string AnesthesiaDateTime = "AnesthesiaDateTime";
            public const string AnesthesiaByUserID = "AnesthesiaByUserID";
            public const string SurgeryDateTime = "SurgeryDateTime";
            public const string SurgeryByUserID = "SurgeryByUserID";
            public const string PostSurgeryDateTime = "PostSurgeryDateTime";
            public const string PostSurgeryByUserID = "PostSurgeryByUserID";
            public const string VoidReason = "VoidReason";
            public const string FromServiceUnitID = "FromServiceUnitID";
            public const string IsInsertionImplant = "IsInsertionImplant";
            public const string IncisionDateTime = "IncisionDateTime";
            public const string SRProcedureDiagnoseType = "SRProcedureDiagnoseType";
            public const string MoveToTheWardDateTime = "MoveToTheWardDateTime";
            public const string MoveToTheWardByUserID = "MoveToTheWardByUserID";
            public const string AnesthesiologistSign = "AnesthesiologistSign";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string BookingNo = "BookingNo";
            public const string BookingDateTimeFrom = "BookingDateTimeFrom";
            public const string BookingDateTimeTo = "BookingDateTimeTo";
            public const string ServiceUnitID = "ServiceUnitID";
            public const string RoomID = "RoomID";
            public const string PatientID = "PatientID";
            public const string RegistrationNo = "RegistrationNo";
            public const string ParamedicID = "ParamedicID";
            public const string IsApproved = "IsApproved";
            public const string IsVoid = "IsVoid";
            public const string Notes = "Notes";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string LastCreateDateTime = "LastCreateDateTime";
            public const string LastCreateByUserID = "LastCreateByUserID";
            public const string SRAnestesiPlan = "SRAnestesiPlan";
            public const string ParamedicID2 = "ParamedicID2";
            public const string ParamedicID3 = "ParamedicID3";
            public const string ParamedicID4 = "ParamedicID4";
            public const string ParamedicIDAnestesi = "ParamedicIDAnestesi";
            public const string AssistantID1 = "AssistantID1";
            public const string AssistantID2 = "AssistantID2";
            public const string AssistantID3 = "AssistantID3";
            public const string AssistantID4 = "AssistantID4";
            public const string AssistantIDAnestesi = "AssistantIDAnestesi";
            public const string Diagnose = "Diagnose";
            public const string OperationType = "OperationType";
            public const string IsCito = "IsCito";
            public const string ProcedureChargeClassID = "ProcedureChargeClassID";
            public const string OperatingNotes = "OperatingNotes";
            public const string Instrumentator1 = "Instrumentator1";
            public const string Instrumentator2 = "Instrumentator2";
            public const string SRProcedureCategory = "SRProcedureCategory";
            public const string RealizationDateTimeFrom = "RealizationDateTimeFrom";
            public const string RealizationDateTimeTo = "RealizationDateTimeTo";
            public const string Resident = "Resident";
            public const string AssistantIDInstrumentator = "AssistantIDInstrumentator";
            public const string SmfID = "SmfID";
            public const string IsExtendedSurgery = "IsExtendedSurgery";
            public const string SRIndication = "SRIndication";
            public const string IsNeedPa = "IsNeedPa";
            public const string AssistantID5 = "AssistantID5";
            public const string AssistantIDInstrumentator2 = "AssistantIDInstrumentator2";
            public const string AssistantIDInstrumentator3 = "AssistantIDInstrumentator3";
            public const string AssistantIDInstrumentator4 = "AssistantIDInstrumentator4";
            public const string AssistantIDInstrumentator5 = "AssistantIDInstrumentator5";
            public const string Instrumentator3 = "Instrumentator3";
            public const string Instrumentator4 = "Instrumentator4";
            public const string Instrumentator5 = "Instrumentator5";
            public const string AnestesyNotes = "AnestesyNotes";
            public const string SRProcedure1 = "SRProcedure1";
            public const string SRProcedure2 = "SRProcedure2";
            public const string PostDiagnosis = "PostDiagnosis";
            public const string PaDate = "PaDate";
            public const string SourceOfTissue = "SourceOfTissue";
            public const string ArrivedDateTime = "ArrivedDateTime";
            public const string IsAnestheticConversion = "IsAnestheticConversion";
            public const string IsValidate = "IsValidate";
            public const string ValidateDateTime = "ValidateDateTime";
            public const string ValidateByUserID = "ValidateByUserID";
            public const string PreSurgeryDateTime = "PreSurgeryDateTime";
            public const string PreSurgeryByUserID = "PreSurgeryByUserID";
            public const string AnesthesiaDateTime = "AnesthesiaDateTime";
            public const string AnesthesiaByUserID = "AnesthesiaByUserID";
            public const string SurgeryDateTime = "SurgeryDateTime";
            public const string SurgeryByUserID = "SurgeryByUserID";
            public const string PostSurgeryDateTime = "PostSurgeryDateTime";
            public const string PostSurgeryByUserID = "PostSurgeryByUserID";
            public const string VoidReason = "VoidReason";
            public const string FromServiceUnitID = "FromServiceUnitID";
            public const string IsInsertionImplant = "IsInsertionImplant";
            public const string IncisionDateTime = "IncisionDateTime";
            public const string SRProcedureDiagnoseType = "SRProcedureDiagnoseType";
            public const string MoveToTheWardDateTime = "MoveToTheWardDateTime";
            public const string MoveToTheWardByUserID = "MoveToTheWardByUserID";
            public const string AnesthesiologistSign = "AnesthesiologistSign";
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
            lock (typeof(ServiceUnitBookingMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new ServiceUnitBookingMetadata();
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


                meta.AddTypeMap("BookingNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("BookingDateTimeFrom", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("BookingDateTimeTo", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("ServiceUnitID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("RoomID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PatientID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("RegistrationNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ParamedicID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsApproved", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsVoid", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("Notes", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastCreateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastCreateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRAnestesiPlan", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ParamedicID2", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ParamedicID3", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ParamedicID4", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ParamedicIDAnestesi", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("AssistantID1", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("AssistantID2", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("AssistantID3", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("AssistantID4", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("AssistantIDAnestesi", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Diagnose", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("OperationType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsCito", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ProcedureChargeClassID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("OperatingNotes", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Instrumentator1", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Instrumentator2", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRProcedureCategory", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("RealizationDateTimeFrom", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("RealizationDateTimeTo", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("Resident", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("AssistantIDInstrumentator", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SmfID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsExtendedSurgery", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("SRIndication", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsNeedPa", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("AssistantID5", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("AssistantIDInstrumentator2", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("AssistantIDInstrumentator3", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("AssistantIDInstrumentator4", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("AssistantIDInstrumentator5", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Instrumentator3", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Instrumentator4", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Instrumentator5", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("AnestesyNotes", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRProcedure1", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRProcedure2", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PostDiagnosis", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PaDate", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("SourceOfTissue", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ArrivedDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("IsAnestheticConversion", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsValidate", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ValidateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("ValidateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PreSurgeryDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("PreSurgeryByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("AnesthesiaDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("AnesthesiaByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SurgeryDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("SurgeryByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PostSurgeryDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("PostSurgeryByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("VoidReason", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("FromServiceUnitID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsInsertionImplant", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IncisionDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("SRProcedureDiagnoseType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("MoveToTheWardDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("MoveToTheWardByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("AnesthesiologistSign", new esTypeMap("image", "System.Byte[]"));



                meta.Source = "ServiceUnitBooking";
                meta.Destination = "ServiceUnitBooking";

                meta.spInsert = "proc_ServiceUnitBookingInsert";
                meta.spUpdate = "proc_ServiceUnitBookingUpdate";
                meta.spDelete = "proc_ServiceUnitBookingDelete";
                meta.spLoadAll = "proc_ServiceUnitBookingLoadAll";
                meta.spLoadByPrimaryKey = "proc_ServiceUnitBookingLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private ServiceUnitBookingMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
