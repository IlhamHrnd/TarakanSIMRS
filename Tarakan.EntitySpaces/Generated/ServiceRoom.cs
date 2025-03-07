
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 9/19/2024 3:39:28 PM
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
    /// Encapsulates the 'ServiceRoom' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(ServiceRoom))]
    [XmlType("ServiceRoom")]
    public partial class ServiceRoom : esServiceRoom
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new ServiceRoom();
        }

        #region Static Quick Access Methods
        static public void Delete(string roomID)
        {
            var obj = new ServiceRoom();
            obj.RoomID = roomID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string roomID, esSqlAccessType sqlAccessType)
        {
            var obj = new ServiceRoom();
            obj.RoomID = roomID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("ServiceRoomCollection")]
    public partial class ServiceRoomCollection : esServiceRoomCollection, IEnumerable<ServiceRoom>
    {
        public ServiceRoom FindByPrimaryKey(string roomID)
        {
            return this.SingleOrDefault(e => e.RoomID == roomID);
        }



    }



    [Serializable]
    public partial class ServiceRoomQuery : esServiceRoomQuery
    {
        public ServiceRoomQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public ServiceRoomQuery(string joinAlias, out ServiceRoomQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "ServiceRoomQuery";
        }



        #region Explicit Casts

        public static explicit operator string(ServiceRoomQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator ServiceRoomQuery(string query)
        {
            return (ServiceRoomQuery)SerializeHelper.FromXml(query, typeof(ServiceRoomQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esServiceRoom : esEntity
    {
        public esServiceRoom()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string roomID)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(roomID);
            else
                return LoadByPrimaryKeyStoredProcedure(roomID);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string roomID)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(roomID);
            else
                return LoadByPrimaryKeyStoredProcedure(roomID);
        }

        private bool LoadByPrimaryKeyDynamic(string roomID)
        {
            ServiceRoomQuery query = new ServiceRoomQuery("srQ");
            query.Where(query.RoomID == roomID);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string roomID)
        {
            esParameters parms = new esParameters();
            parms.Add("RoomID", roomID);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to ServiceRoom.RoomID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RoomID
        {
            get
            {
                return GetSystemString(ServiceRoomMetadata.ColumnNames.RoomID);
            }

            set
            {
                if (SetSystemString(ServiceRoomMetadata.ColumnNames.RoomID, value))
                {
                    OnPropertyChanged(ServiceRoomMetadata.PropertyNames.RoomID);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceRoom.ServiceUnitID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ServiceUnitID
        {
            get
            {
                return GetSystemString(ServiceRoomMetadata.ColumnNames.ServiceUnitID);
            }

            set
            {
                if (SetSystemString(ServiceRoomMetadata.ColumnNames.ServiceUnitID, value))
                {
                    OnPropertyChanged(ServiceRoomMetadata.PropertyNames.ServiceUnitID);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceRoom.RoomName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RoomName
        {
            get
            {
                return GetSystemString(ServiceRoomMetadata.ColumnNames.RoomName);
            }

            set
            {
                if (SetSystemString(ServiceRoomMetadata.ColumnNames.RoomName, value))
                {
                    OnPropertyChanged(ServiceRoomMetadata.PropertyNames.RoomName);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceRoom.ItemID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ItemID
        {
            get
            {
                return GetSystemString(ServiceRoomMetadata.ColumnNames.ItemID);
            }

            set
            {
                if (SetSystemString(ServiceRoomMetadata.ColumnNames.ItemID, value))
                {
                    OnPropertyChanged(ServiceRoomMetadata.PropertyNames.ItemID);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceRoom.Notes
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Notes
        {
            get
            {
                return GetSystemString(ServiceRoomMetadata.ColumnNames.Notes);
            }

            set
            {
                if (SetSystemString(ServiceRoomMetadata.ColumnNames.Notes, value))
                {
                    OnPropertyChanged(ServiceRoomMetadata.PropertyNames.Notes);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceRoom.IsOperatingRoom
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsOperatingRoom
        {
            get
            {
                return GetSystemBoolean(ServiceRoomMetadata.ColumnNames.IsOperatingRoom);
            }

            set
            {
                if (SetSystemBoolean(ServiceRoomMetadata.ColumnNames.IsOperatingRoom, value))
                {
                    OnPropertyChanged(ServiceRoomMetadata.PropertyNames.IsOperatingRoom);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceRoom.IsActive
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsActive
        {
            get
            {
                return GetSystemBoolean(ServiceRoomMetadata.ColumnNames.IsActive);
            }

            set
            {
                if (SetSystemBoolean(ServiceRoomMetadata.ColumnNames.IsActive, value))
                {
                    OnPropertyChanged(ServiceRoomMetadata.PropertyNames.IsActive);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceRoom.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(ServiceRoomMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(ServiceRoomMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(ServiceRoomMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceRoom.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(ServiceRoomMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(ServiceRoomMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(ServiceRoomMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceRoom.ParamedicID1
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParamedicID1
        {
            get
            {
                return GetSystemString(ServiceRoomMetadata.ColumnNames.ParamedicID1);
            }

            set
            {
                if (SetSystemString(ServiceRoomMetadata.ColumnNames.ParamedicID1, value))
                {
                    OnPropertyChanged(ServiceRoomMetadata.PropertyNames.ParamedicID1);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceRoom.ParamedicID2
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParamedicID2
        {
            get
            {
                return GetSystemString(ServiceRoomMetadata.ColumnNames.ParamedicID2);
            }

            set
            {
                if (SetSystemString(ServiceRoomMetadata.ColumnNames.ParamedicID2, value))
                {
                    OnPropertyChanged(ServiceRoomMetadata.PropertyNames.ParamedicID2);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceRoom.NumberOfBeds
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public short? NumberOfBeds
        {
            get
            {
                return GetSystemInt16(ServiceRoomMetadata.ColumnNames.NumberOfBeds);
            }

            set
            {
                if (SetSystemInt16(ServiceRoomMetadata.ColumnNames.NumberOfBeds, value))
                {
                    OnPropertyChanged(ServiceRoomMetadata.PropertyNames.NumberOfBeds);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceRoom.ItemBookedID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ItemBookedID
        {
            get
            {
                return GetSystemString(ServiceRoomMetadata.ColumnNames.ItemBookedID);
            }

            set
            {
                if (SetSystemString(ServiceRoomMetadata.ColumnNames.ItemBookedID, value))
                {
                    OnPropertyChanged(ServiceRoomMetadata.PropertyNames.ItemBookedID);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceRoom.TariffDiscountForRoomIn
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? TariffDiscountForRoomIn
        {
            get
            {
                return GetSystemDecimal(ServiceRoomMetadata.ColumnNames.TariffDiscountForRoomIn);
            }

            set
            {
                if (SetSystemDecimal(ServiceRoomMetadata.ColumnNames.TariffDiscountForRoomIn, value))
                {
                    OnPropertyChanged(ServiceRoomMetadata.PropertyNames.TariffDiscountForRoomIn);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceRoom.SRFloor
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRFloor
        {
            get
            {
                return GetSystemString(ServiceRoomMetadata.ColumnNames.SRFloor);
            }

            set
            {
                if (SetSystemString(ServiceRoomMetadata.ColumnNames.SRFloor, value))
                {
                    OnPropertyChanged(ServiceRoomMetadata.PropertyNames.SRFloor);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceRoom.IsBpjs
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsBpjs
        {
            get
            {
                return GetSystemBoolean(ServiceRoomMetadata.ColumnNames.IsBpjs);
            }

            set
            {
                if (SetSystemBoolean(ServiceRoomMetadata.ColumnNames.IsBpjs, value))
                {
                    OnPropertyChanged(ServiceRoomMetadata.PropertyNames.IsBpjs);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceRoom.SRGenderType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRGenderType
        {
            get
            {
                return GetSystemString(ServiceRoomMetadata.ColumnNames.SRGenderType);
            }

            set
            {
                if (SetSystemString(ServiceRoomMetadata.ColumnNames.SRGenderType, value))
                {
                    OnPropertyChanged(ServiceRoomMetadata.PropertyNames.SRGenderType);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceRoom.IsShowOnBookingOT
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsShowOnBookingOT
        {
            get
            {
                return GetSystemBoolean(ServiceRoomMetadata.ColumnNames.IsShowOnBookingOT);
            }

            set
            {
                if (SetSystemBoolean(ServiceRoomMetadata.ColumnNames.IsShowOnBookingOT, value))
                {
                    OnPropertyChanged(ServiceRoomMetadata.PropertyNames.IsShowOnBookingOT);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceRoom.IsResetPrice
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsResetPrice
        {
            get
            {
                return GetSystemBoolean(ServiceRoomMetadata.ColumnNames.IsResetPrice);
            }

            set
            {
                if (SetSystemBoolean(ServiceRoomMetadata.ColumnNames.IsResetPrice, value))
                {
                    OnPropertyChanged(ServiceRoomMetadata.PropertyNames.IsResetPrice);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceRoom.IsIsolationRoom
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsIsolationRoom
        {
            get
            {
                return GetSystemBoolean(ServiceRoomMetadata.ColumnNames.IsIsolationRoom);
            }

            set
            {
                if (SetSystemBoolean(ServiceRoomMetadata.ColumnNames.IsIsolationRoom, value))
                {
                    OnPropertyChanged(ServiceRoomMetadata.PropertyNames.IsIsolationRoom);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceRoom.IsNegativePressureRoom
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsNegativePressureRoom
        {
            get
            {
                return GetSystemBoolean(ServiceRoomMetadata.ColumnNames.IsNegativePressureRoom);
            }

            set
            {
                if (SetSystemBoolean(ServiceRoomMetadata.ColumnNames.IsNegativePressureRoom, value))
                {
                    OnPropertyChanged(ServiceRoomMetadata.PropertyNames.IsNegativePressureRoom);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceRoom.IsPandemicRoom
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsPandemicRoom
        {
            get
            {
                return GetSystemBoolean(ServiceRoomMetadata.ColumnNames.IsPandemicRoom);
            }

            set
            {
                if (SetSystemBoolean(ServiceRoomMetadata.ColumnNames.IsPandemicRoom, value))
                {
                    OnPropertyChanged(ServiceRoomMetadata.PropertyNames.IsPandemicRoom);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceRoom.IsVentilator
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsVentilator
        {
            get
            {
                return GetSystemBoolean(ServiceRoomMetadata.ColumnNames.IsVentilator);
            }

            set
            {
                if (SetSystemBoolean(ServiceRoomMetadata.ColumnNames.IsVentilator, value))
                {
                    OnPropertyChanged(ServiceRoomMetadata.PropertyNames.IsVentilator);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceRoom.ElectiveSurgeryQuotaDay1
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? ElectiveSurgeryQuotaDay1
        {
            get
            {
                return GetSystemInt32(ServiceRoomMetadata.ColumnNames.ElectiveSurgeryQuotaDay1);
            }

            set
            {
                if (SetSystemInt32(ServiceRoomMetadata.ColumnNames.ElectiveSurgeryQuotaDay1, value))
                {
                    OnPropertyChanged(ServiceRoomMetadata.PropertyNames.ElectiveSurgeryQuotaDay1);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceRoom.ElectiveSurgeryQuotaDay2
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? ElectiveSurgeryQuotaDay2
        {
            get
            {
                return GetSystemInt32(ServiceRoomMetadata.ColumnNames.ElectiveSurgeryQuotaDay2);
            }

            set
            {
                if (SetSystemInt32(ServiceRoomMetadata.ColumnNames.ElectiveSurgeryQuotaDay2, value))
                {
                    OnPropertyChanged(ServiceRoomMetadata.PropertyNames.ElectiveSurgeryQuotaDay2);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceRoom.ElectiveSurgeryQuotaDay3
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? ElectiveSurgeryQuotaDay3
        {
            get
            {
                return GetSystemInt32(ServiceRoomMetadata.ColumnNames.ElectiveSurgeryQuotaDay3);
            }

            set
            {
                if (SetSystemInt32(ServiceRoomMetadata.ColumnNames.ElectiveSurgeryQuotaDay3, value))
                {
                    OnPropertyChanged(ServiceRoomMetadata.PropertyNames.ElectiveSurgeryQuotaDay3);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceRoom.ElectiveSurgeryQuotaDay4
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? ElectiveSurgeryQuotaDay4
        {
            get
            {
                return GetSystemInt32(ServiceRoomMetadata.ColumnNames.ElectiveSurgeryQuotaDay4);
            }

            set
            {
                if (SetSystemInt32(ServiceRoomMetadata.ColumnNames.ElectiveSurgeryQuotaDay4, value))
                {
                    OnPropertyChanged(ServiceRoomMetadata.PropertyNames.ElectiveSurgeryQuotaDay4);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceRoom.ElectiveSurgeryQuotaDay5
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? ElectiveSurgeryQuotaDay5
        {
            get
            {
                return GetSystemInt32(ServiceRoomMetadata.ColumnNames.ElectiveSurgeryQuotaDay5);
            }

            set
            {
                if (SetSystemInt32(ServiceRoomMetadata.ColumnNames.ElectiveSurgeryQuotaDay5, value))
                {
                    OnPropertyChanged(ServiceRoomMetadata.PropertyNames.ElectiveSurgeryQuotaDay5);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceRoom.ElectiveSurgeryQuotaDay6
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? ElectiveSurgeryQuotaDay6
        {
            get
            {
                return GetSystemInt32(ServiceRoomMetadata.ColumnNames.ElectiveSurgeryQuotaDay6);
            }

            set
            {
                if (SetSystemInt32(ServiceRoomMetadata.ColumnNames.ElectiveSurgeryQuotaDay6, value))
                {
                    OnPropertyChanged(ServiceRoomMetadata.PropertyNames.ElectiveSurgeryQuotaDay6);
                }
            }
        }

        /// <summary>
        /// Maps to ServiceRoom.ElectiveSurgeryQuotaDay7
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? ElectiveSurgeryQuotaDay7
        {
            get
            {
                return GetSystemInt32(ServiceRoomMetadata.ColumnNames.ElectiveSurgeryQuotaDay7);
            }

            set
            {
                if (SetSystemInt32(ServiceRoomMetadata.ColumnNames.ElectiveSurgeryQuotaDay7, value))
                {
                    OnPropertyChanged(ServiceRoomMetadata.PropertyNames.ElectiveSurgeryQuotaDay7);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return ServiceRoomMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public ServiceRoomQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new ServiceRoomQuery("srQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(ServiceRoomQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(ServiceRoomQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((ServiceRoomQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private ServiceRoomQuery query;
    }



    [Serializable]
    abstract public partial class esServiceRoomCollection : esEntityCollection<ServiceRoom>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return ServiceRoomMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "ServiceRoomCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public ServiceRoomQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new ServiceRoomQuery("srQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(ServiceRoomQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new ServiceRoomQuery("srQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(ServiceRoomQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((ServiceRoomQuery)query);
        }

        #endregion

        private ServiceRoomQuery query;
    }



    [Serializable]
    abstract public partial class esServiceRoomQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return ServiceRoomMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "RoomID": return RoomID;
                case "ServiceUnitID": return ServiceUnitID;
                case "RoomName": return RoomName;
                case "ItemID": return ItemID;
                case "Notes": return Notes;
                case "IsOperatingRoom": return IsOperatingRoom;
                case "IsActive": return IsActive;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "ParamedicID1": return ParamedicID1;
                case "ParamedicID2": return ParamedicID2;
                case "NumberOfBeds": return NumberOfBeds;
                case "ItemBookedID": return ItemBookedID;
                case "TariffDiscountForRoomIn": return TariffDiscountForRoomIn;
                case "SRFloor": return SRFloor;
                case "IsBpjs": return IsBpjs;
                case "SRGenderType": return SRGenderType;
                case "IsShowOnBookingOT": return IsShowOnBookingOT;
                case "IsResetPrice": return IsResetPrice;
                case "IsIsolationRoom": return IsIsolationRoom;
                case "IsNegativePressureRoom": return IsNegativePressureRoom;
                case "IsPandemicRoom": return IsPandemicRoom;
                case "IsVentilator": return IsVentilator;
                case "ElectiveSurgeryQuotaDay1": return ElectiveSurgeryQuotaDay1;
                case "ElectiveSurgeryQuotaDay2": return ElectiveSurgeryQuotaDay2;
                case "ElectiveSurgeryQuotaDay3": return ElectiveSurgeryQuotaDay3;
                case "ElectiveSurgeryQuotaDay4": return ElectiveSurgeryQuotaDay4;
                case "ElectiveSurgeryQuotaDay5": return ElectiveSurgeryQuotaDay5;
                case "ElectiveSurgeryQuotaDay6": return ElectiveSurgeryQuotaDay6;
                case "ElectiveSurgeryQuotaDay7": return ElectiveSurgeryQuotaDay7;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem RoomID
        {
            get { return new esQueryItem(this, ServiceRoomMetadata.ColumnNames.RoomID, esSystemType.String); }
        }

        public esQueryItem ServiceUnitID
        {
            get { return new esQueryItem(this, ServiceRoomMetadata.ColumnNames.ServiceUnitID, esSystemType.String); }
        }

        public esQueryItem RoomName
        {
            get { return new esQueryItem(this, ServiceRoomMetadata.ColumnNames.RoomName, esSystemType.String); }
        }

        public esQueryItem ItemID
        {
            get { return new esQueryItem(this, ServiceRoomMetadata.ColumnNames.ItemID, esSystemType.String); }
        }

        public esQueryItem Notes
        {
            get { return new esQueryItem(this, ServiceRoomMetadata.ColumnNames.Notes, esSystemType.String); }
        }

        public esQueryItem IsOperatingRoom
        {
            get { return new esQueryItem(this, ServiceRoomMetadata.ColumnNames.IsOperatingRoom, esSystemType.Boolean); }
        }

        public esQueryItem IsActive
        {
            get { return new esQueryItem(this, ServiceRoomMetadata.ColumnNames.IsActive, esSystemType.Boolean); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, ServiceRoomMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, ServiceRoomMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem ParamedicID1
        {
            get { return new esQueryItem(this, ServiceRoomMetadata.ColumnNames.ParamedicID1, esSystemType.String); }
        }

        public esQueryItem ParamedicID2
        {
            get { return new esQueryItem(this, ServiceRoomMetadata.ColumnNames.ParamedicID2, esSystemType.String); }
        }

        public esQueryItem NumberOfBeds
        {
            get { return new esQueryItem(this, ServiceRoomMetadata.ColumnNames.NumberOfBeds, esSystemType.Int16); }
        }

        public esQueryItem ItemBookedID
        {
            get { return new esQueryItem(this, ServiceRoomMetadata.ColumnNames.ItemBookedID, esSystemType.String); }
        }

        public esQueryItem TariffDiscountForRoomIn
        {
            get { return new esQueryItem(this, ServiceRoomMetadata.ColumnNames.TariffDiscountForRoomIn, esSystemType.Decimal); }
        }

        public esQueryItem SRFloor
        {
            get { return new esQueryItem(this, ServiceRoomMetadata.ColumnNames.SRFloor, esSystemType.String); }
        }

        public esQueryItem IsBpjs
        {
            get { return new esQueryItem(this, ServiceRoomMetadata.ColumnNames.IsBpjs, esSystemType.Boolean); }
        }

        public esQueryItem SRGenderType
        {
            get { return new esQueryItem(this, ServiceRoomMetadata.ColumnNames.SRGenderType, esSystemType.String); }
        }

        public esQueryItem IsShowOnBookingOT
        {
            get { return new esQueryItem(this, ServiceRoomMetadata.ColumnNames.IsShowOnBookingOT, esSystemType.Boolean); }
        }

        public esQueryItem IsResetPrice
        {
            get { return new esQueryItem(this, ServiceRoomMetadata.ColumnNames.IsResetPrice, esSystemType.Boolean); }
        }

        public esQueryItem IsIsolationRoom
        {
            get { return new esQueryItem(this, ServiceRoomMetadata.ColumnNames.IsIsolationRoom, esSystemType.Boolean); }
        }

        public esQueryItem IsNegativePressureRoom
        {
            get { return new esQueryItem(this, ServiceRoomMetadata.ColumnNames.IsNegativePressureRoom, esSystemType.Boolean); }
        }

        public esQueryItem IsPandemicRoom
        {
            get { return new esQueryItem(this, ServiceRoomMetadata.ColumnNames.IsPandemicRoom, esSystemType.Boolean); }
        }

        public esQueryItem IsVentilator
        {
            get { return new esQueryItem(this, ServiceRoomMetadata.ColumnNames.IsVentilator, esSystemType.Boolean); }
        }

        public esQueryItem ElectiveSurgeryQuotaDay1
        {
            get { return new esQueryItem(this, ServiceRoomMetadata.ColumnNames.ElectiveSurgeryQuotaDay1, esSystemType.Int32); }
        }

        public esQueryItem ElectiveSurgeryQuotaDay2
        {
            get { return new esQueryItem(this, ServiceRoomMetadata.ColumnNames.ElectiveSurgeryQuotaDay2, esSystemType.Int32); }
        }

        public esQueryItem ElectiveSurgeryQuotaDay3
        {
            get { return new esQueryItem(this, ServiceRoomMetadata.ColumnNames.ElectiveSurgeryQuotaDay3, esSystemType.Int32); }
        }

        public esQueryItem ElectiveSurgeryQuotaDay4
        {
            get { return new esQueryItem(this, ServiceRoomMetadata.ColumnNames.ElectiveSurgeryQuotaDay4, esSystemType.Int32); }
        }

        public esQueryItem ElectiveSurgeryQuotaDay5
        {
            get { return new esQueryItem(this, ServiceRoomMetadata.ColumnNames.ElectiveSurgeryQuotaDay5, esSystemType.Int32); }
        }

        public esQueryItem ElectiveSurgeryQuotaDay6
        {
            get { return new esQueryItem(this, ServiceRoomMetadata.ColumnNames.ElectiveSurgeryQuotaDay6, esSystemType.Int32); }
        }

        public esQueryItem ElectiveSurgeryQuotaDay7
        {
            get { return new esQueryItem(this, ServiceRoomMetadata.ColumnNames.ElectiveSurgeryQuotaDay7, esSystemType.Int32); }
        }

        #endregion

    }



    [Serializable]
    public partial class ServiceRoomMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected ServiceRoomMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.RoomID, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RoomID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ServiceUnitID, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ServiceUnitID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RoomName, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RoomName;
            c.CharacterMaxLength = 100;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ItemID, 3, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ItemID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Notes, 4, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Notes;
            c.CharacterMaxLength = 500;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsOperatingRoom, 5, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsOperatingRoom;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsActive, 6, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsActive;
            c.HasDefault = true;
            c.Default = @"((1))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 7, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 8, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 40;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParamedicID1, 9, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParamedicID1;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParamedicID2, 10, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParamedicID2;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.NumberOfBeds, 11, typeof(short), esSystemType.Int16);
            c.PropertyName = PropertyNames.NumberOfBeds;
            c.NumericPrecision = 5;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ItemBookedID, 12, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ItemBookedID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TariffDiscountForRoomIn, 13, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.TariffDiscountForRoomIn;
            c.NumericPrecision = 10;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRFloor, 14, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRFloor;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsBpjs, 15, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsBpjs;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRGenderType, 16, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRGenderType;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsShowOnBookingOT, 17, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsShowOnBookingOT;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsResetPrice, 18, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsResetPrice;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsIsolationRoom, 19, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsIsolationRoom;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsNegativePressureRoom, 20, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsNegativePressureRoom;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsPandemicRoom, 21, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsPandemicRoom;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsVentilator, 22, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsVentilator;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ElectiveSurgeryQuotaDay1, 23, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.ElectiveSurgeryQuotaDay1;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ElectiveSurgeryQuotaDay2, 24, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.ElectiveSurgeryQuotaDay2;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ElectiveSurgeryQuotaDay3, 25, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.ElectiveSurgeryQuotaDay3;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ElectiveSurgeryQuotaDay4, 26, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.ElectiveSurgeryQuotaDay4;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ElectiveSurgeryQuotaDay5, 27, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.ElectiveSurgeryQuotaDay5;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ElectiveSurgeryQuotaDay6, 28, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.ElectiveSurgeryQuotaDay6;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ElectiveSurgeryQuotaDay7, 29, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.ElectiveSurgeryQuotaDay7;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public ServiceRoomMetadata Meta()
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
            public const string RoomID = "RoomID";
            public const string ServiceUnitID = "ServiceUnitID";
            public const string RoomName = "RoomName";
            public const string ItemID = "ItemID";
            public const string Notes = "Notes";
            public const string IsOperatingRoom = "IsOperatingRoom";
            public const string IsActive = "IsActive";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string ParamedicID1 = "ParamedicID1";
            public const string ParamedicID2 = "ParamedicID2";
            public const string NumberOfBeds = "NumberOfBeds";
            public const string ItemBookedID = "ItemBookedID";
            public const string TariffDiscountForRoomIn = "TariffDiscountForRoomIn";
            public const string SRFloor = "SRFloor";
            public const string IsBpjs = "IsBpjs";
            public const string SRGenderType = "SRGenderType";
            public const string IsShowOnBookingOT = "IsShowOnBookingOT";
            public const string IsResetPrice = "IsResetPrice";
            public const string IsIsolationRoom = "IsIsolationRoom";
            public const string IsNegativePressureRoom = "IsNegativePressureRoom";
            public const string IsPandemicRoom = "IsPandemicRoom";
            public const string IsVentilator = "IsVentilator";
            public const string ElectiveSurgeryQuotaDay1 = "ElectiveSurgeryQuotaDay1";
            public const string ElectiveSurgeryQuotaDay2 = "ElectiveSurgeryQuotaDay2";
            public const string ElectiveSurgeryQuotaDay3 = "ElectiveSurgeryQuotaDay3";
            public const string ElectiveSurgeryQuotaDay4 = "ElectiveSurgeryQuotaDay4";
            public const string ElectiveSurgeryQuotaDay5 = "ElectiveSurgeryQuotaDay5";
            public const string ElectiveSurgeryQuotaDay6 = "ElectiveSurgeryQuotaDay6";
            public const string ElectiveSurgeryQuotaDay7 = "ElectiveSurgeryQuotaDay7";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string RoomID = "RoomID";
            public const string ServiceUnitID = "ServiceUnitID";
            public const string RoomName = "RoomName";
            public const string ItemID = "ItemID";
            public const string Notes = "Notes";
            public const string IsOperatingRoom = "IsOperatingRoom";
            public const string IsActive = "IsActive";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string ParamedicID1 = "ParamedicID1";
            public const string ParamedicID2 = "ParamedicID2";
            public const string NumberOfBeds = "NumberOfBeds";
            public const string ItemBookedID = "ItemBookedID";
            public const string TariffDiscountForRoomIn = "TariffDiscountForRoomIn";
            public const string SRFloor = "SRFloor";
            public const string IsBpjs = "IsBpjs";
            public const string SRGenderType = "SRGenderType";
            public const string IsShowOnBookingOT = "IsShowOnBookingOT";
            public const string IsResetPrice = "IsResetPrice";
            public const string IsIsolationRoom = "IsIsolationRoom";
            public const string IsNegativePressureRoom = "IsNegativePressureRoom";
            public const string IsPandemicRoom = "IsPandemicRoom";
            public const string IsVentilator = "IsVentilator";
            public const string ElectiveSurgeryQuotaDay1 = "ElectiveSurgeryQuotaDay1";
            public const string ElectiveSurgeryQuotaDay2 = "ElectiveSurgeryQuotaDay2";
            public const string ElectiveSurgeryQuotaDay3 = "ElectiveSurgeryQuotaDay3";
            public const string ElectiveSurgeryQuotaDay4 = "ElectiveSurgeryQuotaDay4";
            public const string ElectiveSurgeryQuotaDay5 = "ElectiveSurgeryQuotaDay5";
            public const string ElectiveSurgeryQuotaDay6 = "ElectiveSurgeryQuotaDay6";
            public const string ElectiveSurgeryQuotaDay7 = "ElectiveSurgeryQuotaDay7";
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
            lock (typeof(ServiceRoomMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new ServiceRoomMetadata();
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


                meta.AddTypeMap("RoomID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ServiceUnitID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("RoomName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ItemID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Notes", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsOperatingRoom", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsActive", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ParamedicID1", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ParamedicID2", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("NumberOfBeds", new esTypeMap("smallint", "System.Int16"));
                meta.AddTypeMap("ItemBookedID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TariffDiscountForRoomIn", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("SRFloor", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsBpjs", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("SRGenderType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsShowOnBookingOT", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsResetPrice", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsIsolationRoom", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsNegativePressureRoom", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsPandemicRoom", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsVentilator", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ElectiveSurgeryQuotaDay1", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("ElectiveSurgeryQuotaDay2", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("ElectiveSurgeryQuotaDay3", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("ElectiveSurgeryQuotaDay4", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("ElectiveSurgeryQuotaDay5", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("ElectiveSurgeryQuotaDay6", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("ElectiveSurgeryQuotaDay7", new esTypeMap("int", "System.Int32"));



                meta.Source = "ServiceRoom";
                meta.Destination = "ServiceRoom";

                meta.spInsert = "proc_ServiceRoomInsert";
                meta.spUpdate = "proc_ServiceRoomUpdate";
                meta.spDelete = "proc_ServiceRoomDelete";
                meta.spLoadAll = "proc_ServiceRoomLoadAll";
                meta.spLoadByPrimaryKey = "proc_ServiceRoomLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private ServiceRoomMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
