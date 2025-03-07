
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 2/11/2025 5:03:12 PM
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
    /// Encapsulates the 'PatientTransferHistory' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(PatientTransferHistory))]
    [XmlType("PatientTransferHistory")]
    public partial class PatientTransferHistory : esPatientTransferHistory
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new PatientTransferHistory();
        }

        #region Static Quick Access Methods
        static public void Delete(string registrationNo, string transferNo)
        {
            var obj = new PatientTransferHistory();
            obj.RegistrationNo = registrationNo;
            obj.TransferNo = transferNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string registrationNo, string transferNo, esSqlAccessType sqlAccessType)
        {
            var obj = new PatientTransferHistory();
            obj.RegistrationNo = registrationNo;
            obj.TransferNo = transferNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("PatientTransferHistoryCollection")]
    public partial class PatientTransferHistoryCollection : esPatientTransferHistoryCollection, IEnumerable<PatientTransferHistory>
    {
        public PatientTransferHistory FindByPrimaryKey(string registrationNo, string transferNo)
        {
            return this.SingleOrDefault(e => e.RegistrationNo == registrationNo && e.TransferNo == transferNo);
        }



    }



    [Serializable]
    public partial class PatientTransferHistoryQuery : esPatientTransferHistoryQuery
    {
        public PatientTransferHistoryQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public PatientTransferHistoryQuery(string joinAlias, out PatientTransferHistoryQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "PatientTransferHistoryQuery";
        }



        #region Explicit Casts

        public static explicit operator string(PatientTransferHistoryQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator PatientTransferHistoryQuery(string query)
        {
            return (PatientTransferHistoryQuery)SerializeHelper.FromXml(query, typeof(PatientTransferHistoryQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esPatientTransferHistory : esEntity
    {
        public esPatientTransferHistory()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string registrationNo, string transferNo)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(registrationNo, transferNo);
            else
                return LoadByPrimaryKeyStoredProcedure(registrationNo, transferNo);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string registrationNo, string transferNo)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(registrationNo, transferNo);
            else
                return LoadByPrimaryKeyStoredProcedure(registrationNo, transferNo);
        }

        private bool LoadByPrimaryKeyDynamic(string registrationNo, string transferNo)
        {
            PatientTransferHistoryQuery query = new PatientTransferHistoryQuery("pthQ");
            query.Where(query.RegistrationNo == registrationNo, query.TransferNo == transferNo);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string registrationNo, string transferNo)
        {
            esParameters parms = new esParameters();
            parms.Add("RegistrationNo", registrationNo); parms.Add("TransferNo", transferNo);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to PatientTransferHistory.RegistrationNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RegistrationNo
        {
            get
            {
                return GetSystemString(PatientTransferHistoryMetadata.ColumnNames.RegistrationNo);
            }

            set
            {
                if (SetSystemString(PatientTransferHistoryMetadata.ColumnNames.RegistrationNo, value))
                {
                    OnPropertyChanged(PatientTransferHistoryMetadata.PropertyNames.RegistrationNo);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransferHistory.TransferNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TransferNo
        {
            get
            {
                return GetSystemString(PatientTransferHistoryMetadata.ColumnNames.TransferNo);
            }

            set
            {
                if (SetSystemString(PatientTransferHistoryMetadata.ColumnNames.TransferNo, value))
                {
                    OnPropertyChanged(PatientTransferHistoryMetadata.PropertyNames.TransferNo);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransferHistory.ServiceUnitID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ServiceUnitID
        {
            get
            {
                return GetSystemString(PatientTransferHistoryMetadata.ColumnNames.ServiceUnitID);
            }

            set
            {
                if (SetSystemString(PatientTransferHistoryMetadata.ColumnNames.ServiceUnitID, value))
                {
                    OnPropertyChanged(PatientTransferHistoryMetadata.PropertyNames.ServiceUnitID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransferHistory.ClassID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ClassID
        {
            get
            {
                return GetSystemString(PatientTransferHistoryMetadata.ColumnNames.ClassID);
            }

            set
            {
                if (SetSystemString(PatientTransferHistoryMetadata.ColumnNames.ClassID, value))
                {
                    OnPropertyChanged(PatientTransferHistoryMetadata.PropertyNames.ClassID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransferHistory.RoomID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RoomID
        {
            get
            {
                return GetSystemString(PatientTransferHistoryMetadata.ColumnNames.RoomID);
            }

            set
            {
                if (SetSystemString(PatientTransferHistoryMetadata.ColumnNames.RoomID, value))
                {
                    OnPropertyChanged(PatientTransferHistoryMetadata.PropertyNames.RoomID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransferHistory.BedID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string BedID
        {
            get
            {
                return GetSystemString(PatientTransferHistoryMetadata.ColumnNames.BedID);
            }

            set
            {
                if (SetSystemString(PatientTransferHistoryMetadata.ColumnNames.BedID, value))
                {
                    OnPropertyChanged(PatientTransferHistoryMetadata.PropertyNames.BedID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransferHistory.ChargeClassID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ChargeClassID
        {
            get
            {
                return GetSystemString(PatientTransferHistoryMetadata.ColumnNames.ChargeClassID);
            }

            set
            {
                if (SetSystemString(PatientTransferHistoryMetadata.ColumnNames.ChargeClassID, value))
                {
                    OnPropertyChanged(PatientTransferHistoryMetadata.PropertyNames.ChargeClassID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransferHistory.DateOfEntry
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? DateOfEntry
        {
            get
            {
                return GetSystemDateTime(PatientTransferHistoryMetadata.ColumnNames.DateOfEntry);
            }

            set
            {
                if (SetSystemDateTime(PatientTransferHistoryMetadata.ColumnNames.DateOfEntry, value))
                {
                    OnPropertyChanged(PatientTransferHistoryMetadata.PropertyNames.DateOfEntry);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransferHistory.TimeOfEntry
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TimeOfEntry
        {
            get
            {
                return GetSystemString(PatientTransferHistoryMetadata.ColumnNames.TimeOfEntry);
            }

            set
            {
                if (SetSystemString(PatientTransferHistoryMetadata.ColumnNames.TimeOfEntry, value))
                {
                    OnPropertyChanged(PatientTransferHistoryMetadata.PropertyNames.TimeOfEntry);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransferHistory.DateOfExit
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? DateOfExit
        {
            get
            {
                return GetSystemDateTime(PatientTransferHistoryMetadata.ColumnNames.DateOfExit);
            }

            set
            {
                if (SetSystemDateTime(PatientTransferHistoryMetadata.ColumnNames.DateOfExit, value))
                {
                    OnPropertyChanged(PatientTransferHistoryMetadata.PropertyNames.DateOfExit);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransferHistory.TimeOfExit
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TimeOfExit
        {
            get
            {
                return GetSystemString(PatientTransferHistoryMetadata.ColumnNames.TimeOfExit);
            }

            set
            {
                if (SetSystemString(PatientTransferHistoryMetadata.ColumnNames.TimeOfExit, value))
                {
                    OnPropertyChanged(PatientTransferHistoryMetadata.PropertyNames.TimeOfExit);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransferHistory.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(PatientTransferHistoryMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(PatientTransferHistoryMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(PatientTransferHistoryMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransferHistory.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(PatientTransferHistoryMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(PatientTransferHistoryMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(PatientTransferHistoryMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransferHistory.SmfID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SmfID
        {
            get
            {
                return GetSystemString(PatientTransferHistoryMetadata.ColumnNames.SmfID);
            }

            set
            {
                if (SetSystemString(PatientTransferHistoryMetadata.ColumnNames.SmfID, value))
                {
                    OnPropertyChanged(PatientTransferHistoryMetadata.PropertyNames.SmfID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransferHistory.SmfIDBefore
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SmfIDBefore
        {
            get
            {
                return GetSystemString(PatientTransferHistoryMetadata.ColumnNames.SmfIDBefore);
            }

            set
            {
                if (SetSystemString(PatientTransferHistoryMetadata.ColumnNames.SmfIDBefore, value))
                {
                    OnPropertyChanged(PatientTransferHistoryMetadata.PropertyNames.SmfIDBefore);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransferHistory.ArrivedDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? ArrivedDateTime
        {
            get
            {
                return GetSystemDateTime(PatientTransferHistoryMetadata.ColumnNames.ArrivedDateTime);
            }

            set
            {
                if (SetSystemDateTime(PatientTransferHistoryMetadata.ColumnNames.ArrivedDateTime, value))
                {
                    OnPropertyChanged(PatientTransferHistoryMetadata.PropertyNames.ArrivedDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransferHistory.SRTransferredPatientWith
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRTransferredPatientWith
        {
            get
            {
                return GetSystemString(PatientTransferHistoryMetadata.ColumnNames.SRTransferredPatientWith);
            }

            set
            {
                if (SetSystemString(PatientTransferHistoryMetadata.ColumnNames.SRTransferredPatientWith, value))
                {
                    OnPropertyChanged(PatientTransferHistoryMetadata.PropertyNames.SRTransferredPatientWith);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransferHistory.TransferredByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TransferredByUserID
        {
            get
            {
                return GetSystemString(PatientTransferHistoryMetadata.ColumnNames.TransferredByUserID);
            }

            set
            {
                if (SetSystemString(PatientTransferHistoryMetadata.ColumnNames.TransferredByUserID, value))
                {
                    OnPropertyChanged(PatientTransferHistoryMetadata.PropertyNames.TransferredByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransferHistory.ReceivedByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ReceivedByUserID
        {
            get
            {
                return GetSystemString(PatientTransferHistoryMetadata.ColumnNames.ReceivedByUserID);
            }

            set
            {
                if (SetSystemString(PatientTransferHistoryMetadata.ColumnNames.ReceivedByUserID, value))
                {
                    OnPropertyChanged(PatientTransferHistoryMetadata.PropertyNames.ReceivedByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransferHistory.FromServiceUnitID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string FromServiceUnitID
        {
            get
            {
                return GetSystemString(PatientTransferHistoryMetadata.ColumnNames.FromServiceUnitID);
            }

            set
            {
                if (SetSystemString(PatientTransferHistoryMetadata.ColumnNames.FromServiceUnitID, value))
                {
                    OnPropertyChanged(PatientTransferHistoryMetadata.PropertyNames.FromServiceUnitID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransferHistory.FromClassID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string FromClassID
        {
            get
            {
                return GetSystemString(PatientTransferHistoryMetadata.ColumnNames.FromClassID);
            }

            set
            {
                if (SetSystemString(PatientTransferHistoryMetadata.ColumnNames.FromClassID, value))
                {
                    OnPropertyChanged(PatientTransferHistoryMetadata.PropertyNames.FromClassID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransferHistory.FromRoomID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string FromRoomID
        {
            get
            {
                return GetSystemString(PatientTransferHistoryMetadata.ColumnNames.FromRoomID);
            }

            set
            {
                if (SetSystemString(PatientTransferHistoryMetadata.ColumnNames.FromRoomID, value))
                {
                    OnPropertyChanged(PatientTransferHistoryMetadata.PropertyNames.FromRoomID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransferHistory.FromBedID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string FromBedID
        {
            get
            {
                return GetSystemString(PatientTransferHistoryMetadata.ColumnNames.FromBedID);
            }

            set
            {
                if (SetSystemString(PatientTransferHistoryMetadata.ColumnNames.FromBedID, value))
                {
                    OnPropertyChanged(PatientTransferHistoryMetadata.PropertyNames.FromBedID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransferHistory.FromChargeClassID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string FromChargeClassID
        {
            get
            {
                return GetSystemString(PatientTransferHistoryMetadata.ColumnNames.FromChargeClassID);
            }

            set
            {
                if (SetSystemString(PatientTransferHistoryMetadata.ColumnNames.FromChargeClassID, value))
                {
                    OnPropertyChanged(PatientTransferHistoryMetadata.PropertyNames.FromChargeClassID);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return PatientTransferHistoryMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public PatientTransferHistoryQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new PatientTransferHistoryQuery("pthQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(PatientTransferHistoryQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(PatientTransferHistoryQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((PatientTransferHistoryQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private PatientTransferHistoryQuery query;
    }



    [Serializable]
    abstract public partial class esPatientTransferHistoryCollection : esEntityCollection<PatientTransferHistory>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return PatientTransferHistoryMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "PatientTransferHistoryCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public PatientTransferHistoryQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new PatientTransferHistoryQuery("pthQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(PatientTransferHistoryQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new PatientTransferHistoryQuery("pthQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(PatientTransferHistoryQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((PatientTransferHistoryQuery)query);
        }

        #endregion

        private PatientTransferHistoryQuery query;
    }



    [Serializable]
    abstract public partial class esPatientTransferHistoryQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return PatientTransferHistoryMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "RegistrationNo": return RegistrationNo;
                case "TransferNo": return TransferNo;
                case "ServiceUnitID": return ServiceUnitID;
                case "ClassID": return ClassID;
                case "RoomID": return RoomID;
                case "BedID": return BedID;
                case "ChargeClassID": return ChargeClassID;
                case "DateOfEntry": return DateOfEntry;
                case "TimeOfEntry": return TimeOfEntry;
                case "DateOfExit": return DateOfExit;
                case "TimeOfExit": return TimeOfExit;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "SmfID": return SmfID;
                case "SmfIDBefore": return SmfIDBefore;
                case "ArrivedDateTime": return ArrivedDateTime;
                case "SRTransferredPatientWith": return SRTransferredPatientWith;
                case "TransferredByUserID": return TransferredByUserID;
                case "ReceivedByUserID": return ReceivedByUserID;
                case "FromServiceUnitID": return FromServiceUnitID;
                case "FromClassID": return FromClassID;
                case "FromRoomID": return FromRoomID;
                case "FromBedID": return FromBedID;
                case "FromChargeClassID": return FromChargeClassID;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem RegistrationNo
        {
            get { return new esQueryItem(this, PatientTransferHistoryMetadata.ColumnNames.RegistrationNo, esSystemType.String); }
        }

        public esQueryItem TransferNo
        {
            get { return new esQueryItem(this, PatientTransferHistoryMetadata.ColumnNames.TransferNo, esSystemType.String); }
        }

        public esQueryItem ServiceUnitID
        {
            get { return new esQueryItem(this, PatientTransferHistoryMetadata.ColumnNames.ServiceUnitID, esSystemType.String); }
        }

        public esQueryItem ClassID
        {
            get { return new esQueryItem(this, PatientTransferHistoryMetadata.ColumnNames.ClassID, esSystemType.String); }
        }

        public esQueryItem RoomID
        {
            get { return new esQueryItem(this, PatientTransferHistoryMetadata.ColumnNames.RoomID, esSystemType.String); }
        }

        public esQueryItem BedID
        {
            get { return new esQueryItem(this, PatientTransferHistoryMetadata.ColumnNames.BedID, esSystemType.String); }
        }

        public esQueryItem ChargeClassID
        {
            get { return new esQueryItem(this, PatientTransferHistoryMetadata.ColumnNames.ChargeClassID, esSystemType.String); }
        }

        public esQueryItem DateOfEntry
        {
            get { return new esQueryItem(this, PatientTransferHistoryMetadata.ColumnNames.DateOfEntry, esSystemType.DateTime); }
        }

        public esQueryItem TimeOfEntry
        {
            get { return new esQueryItem(this, PatientTransferHistoryMetadata.ColumnNames.TimeOfEntry, esSystemType.String); }
        }

        public esQueryItem DateOfExit
        {
            get { return new esQueryItem(this, PatientTransferHistoryMetadata.ColumnNames.DateOfExit, esSystemType.DateTime); }
        }

        public esQueryItem TimeOfExit
        {
            get { return new esQueryItem(this, PatientTransferHistoryMetadata.ColumnNames.TimeOfExit, esSystemType.String); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, PatientTransferHistoryMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, PatientTransferHistoryMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem SmfID
        {
            get { return new esQueryItem(this, PatientTransferHistoryMetadata.ColumnNames.SmfID, esSystemType.String); }
        }

        public esQueryItem SmfIDBefore
        {
            get { return new esQueryItem(this, PatientTransferHistoryMetadata.ColumnNames.SmfIDBefore, esSystemType.String); }
        }

        public esQueryItem ArrivedDateTime
        {
            get { return new esQueryItem(this, PatientTransferHistoryMetadata.ColumnNames.ArrivedDateTime, esSystemType.DateTime); }
        }

        public esQueryItem SRTransferredPatientWith
        {
            get { return new esQueryItem(this, PatientTransferHistoryMetadata.ColumnNames.SRTransferredPatientWith, esSystemType.String); }
        }

        public esQueryItem TransferredByUserID
        {
            get { return new esQueryItem(this, PatientTransferHistoryMetadata.ColumnNames.TransferredByUserID, esSystemType.String); }
        }

        public esQueryItem ReceivedByUserID
        {
            get { return new esQueryItem(this, PatientTransferHistoryMetadata.ColumnNames.ReceivedByUserID, esSystemType.String); }
        }

        public esQueryItem FromServiceUnitID
        {
            get { return new esQueryItem(this, PatientTransferHistoryMetadata.ColumnNames.FromServiceUnitID, esSystemType.String); }
        }

        public esQueryItem FromClassID
        {
            get { return new esQueryItem(this, PatientTransferHistoryMetadata.ColumnNames.FromClassID, esSystemType.String); }
        }

        public esQueryItem FromRoomID
        {
            get { return new esQueryItem(this, PatientTransferHistoryMetadata.ColumnNames.FromRoomID, esSystemType.String); }
        }

        public esQueryItem FromBedID
        {
            get { return new esQueryItem(this, PatientTransferHistoryMetadata.ColumnNames.FromBedID, esSystemType.String); }
        }

        public esQueryItem FromChargeClassID
        {
            get { return new esQueryItem(this, PatientTransferHistoryMetadata.ColumnNames.FromChargeClassID, esSystemType.String); }
        }

        #endregion

    }



    [Serializable]
    public partial class PatientTransferHistoryMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected PatientTransferHistoryMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.RegistrationNo, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RegistrationNo;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 20;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TransferNo, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TransferNo;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 20;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ServiceUnitID, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ServiceUnitID;
            c.CharacterMaxLength = 10;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ClassID, 3, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ClassID;
            c.CharacterMaxLength = 10;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RoomID, 4, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RoomID;
            c.CharacterMaxLength = 10;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.BedID, 5, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.BedID;
            c.CharacterMaxLength = 10;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ChargeClassID, 6, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ChargeClassID;
            c.CharacterMaxLength = 10;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DateOfEntry, 7, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.DateOfEntry;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TimeOfEntry, 8, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TimeOfEntry;
            c.CharacterMaxLength = 5;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DateOfExit, 9, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.DateOfExit;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TimeOfExit, 10, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TimeOfExit;
            c.CharacterMaxLength = 5;
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

            c = new esColumnMetadata(ColumnNames.SmfID, 13, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SmfID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SmfIDBefore, 14, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SmfIDBefore;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ArrivedDateTime, 15, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.ArrivedDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRTransferredPatientWith, 16, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRTransferredPatientWith;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TransferredByUserID, 17, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TransferredByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ReceivedByUserID, 18, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ReceivedByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FromServiceUnitID, 19, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.FromServiceUnitID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FromClassID, 20, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.FromClassID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FromRoomID, 21, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.FromRoomID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FromBedID, 22, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.FromBedID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FromChargeClassID, 23, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.FromChargeClassID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public PatientTransferHistoryMetadata Meta()
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
            public const string TransferNo = "TransferNo";
            public const string ServiceUnitID = "ServiceUnitID";
            public const string ClassID = "ClassID";
            public const string RoomID = "RoomID";
            public const string BedID = "BedID";
            public const string ChargeClassID = "ChargeClassID";
            public const string DateOfEntry = "DateOfEntry";
            public const string TimeOfEntry = "TimeOfEntry";
            public const string DateOfExit = "DateOfExit";
            public const string TimeOfExit = "TimeOfExit";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string SmfID = "SmfID";
            public const string SmfIDBefore = "SmfIDBefore";
            public const string ArrivedDateTime = "ArrivedDateTime";
            public const string SRTransferredPatientWith = "SRTransferredPatientWith";
            public const string TransferredByUserID = "TransferredByUserID";
            public const string ReceivedByUserID = "ReceivedByUserID";
            public const string FromServiceUnitID = "FromServiceUnitID";
            public const string FromClassID = "FromClassID";
            public const string FromRoomID = "FromRoomID";
            public const string FromBedID = "FromBedID";
            public const string FromChargeClassID = "FromChargeClassID";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string RegistrationNo = "RegistrationNo";
            public const string TransferNo = "TransferNo";
            public const string ServiceUnitID = "ServiceUnitID";
            public const string ClassID = "ClassID";
            public const string RoomID = "RoomID";
            public const string BedID = "BedID";
            public const string ChargeClassID = "ChargeClassID";
            public const string DateOfEntry = "DateOfEntry";
            public const string TimeOfEntry = "TimeOfEntry";
            public const string DateOfExit = "DateOfExit";
            public const string TimeOfExit = "TimeOfExit";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string SmfID = "SmfID";
            public const string SmfIDBefore = "SmfIDBefore";
            public const string ArrivedDateTime = "ArrivedDateTime";
            public const string SRTransferredPatientWith = "SRTransferredPatientWith";
            public const string TransferredByUserID = "TransferredByUserID";
            public const string ReceivedByUserID = "ReceivedByUserID";
            public const string FromServiceUnitID = "FromServiceUnitID";
            public const string FromClassID = "FromClassID";
            public const string FromRoomID = "FromRoomID";
            public const string FromBedID = "FromBedID";
            public const string FromChargeClassID = "FromChargeClassID";
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
            lock (typeof(PatientTransferHistoryMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new PatientTransferHistoryMetadata();
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
                meta.AddTypeMap("TransferNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ServiceUnitID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ClassID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("RoomID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("BedID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ChargeClassID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("DateOfEntry", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("TimeOfEntry", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("DateOfExit", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("TimeOfExit", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SmfID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SmfIDBefore", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ArrivedDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("SRTransferredPatientWith", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TransferredByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ReceivedByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("FromServiceUnitID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("FromClassID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("FromRoomID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("FromBedID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("FromChargeClassID", new esTypeMap("varchar", "System.String"));



                meta.Source = "PatientTransferHistory";
                meta.Destination = "PatientTransferHistory";

                meta.spInsert = "proc_PatientTransferHistoryInsert";
                meta.spUpdate = "proc_PatientTransferHistoryUpdate";
                meta.spDelete = "proc_PatientTransferHistoryDelete";
                meta.spLoadAll = "proc_PatientTransferHistoryLoadAll";
                meta.spLoadByPrimaryKey = "proc_PatientTransferHistoryLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private PatientTransferHistoryMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
