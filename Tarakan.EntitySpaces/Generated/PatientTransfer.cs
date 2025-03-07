
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 2/11/2025 5:02:55 PM
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
    /// Encapsulates the 'PatientTransfer' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(PatientTransfer))]
    [XmlType("PatientTransfer")]
    public partial class PatientTransfer : esPatientTransfer
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new PatientTransfer();
        }

        #region Static Quick Access Methods
        static public void Delete(string transferNo)
        {
            var obj = new PatientTransfer();
            obj.TransferNo = transferNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string transferNo, esSqlAccessType sqlAccessType)
        {
            var obj = new PatientTransfer();
            obj.TransferNo = transferNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("PatientTransferCollection")]
    public partial class PatientTransferCollection : esPatientTransferCollection, IEnumerable<PatientTransfer>
    {
        public PatientTransfer FindByPrimaryKey(string transferNo)
        {
            return this.SingleOrDefault(e => e.TransferNo == transferNo);
        }



    }



    [Serializable]
    public partial class PatientTransferQuery : esPatientTransferQuery
    {
        public PatientTransferQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public PatientTransferQuery(string joinAlias, out PatientTransferQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "PatientTransferQuery";
        }



        #region Explicit Casts

        public static explicit operator string(PatientTransferQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator PatientTransferQuery(string query)
        {
            return (PatientTransferQuery)SerializeHelper.FromXml(query, typeof(PatientTransferQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esPatientTransfer : esEntity
    {
        public esPatientTransfer()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string transferNo)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(transferNo);
            else
                return LoadByPrimaryKeyStoredProcedure(transferNo);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string transferNo)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(transferNo);
            else
                return LoadByPrimaryKeyStoredProcedure(transferNo);
        }

        private bool LoadByPrimaryKeyDynamic(string transferNo)
        {
            PatientTransferQuery query = new PatientTransferQuery("ptQ");
            query.Where(query.TransferNo == transferNo);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string transferNo)
        {
            esParameters parms = new esParameters();
            parms.Add("TransferNo", transferNo);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to PatientTransfer.TransferNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TransferNo
        {
            get
            {
                return GetSystemString(PatientTransferMetadata.ColumnNames.TransferNo);
            }

            set
            {
                if (SetSystemString(PatientTransferMetadata.ColumnNames.TransferNo, value))
                {
                    OnPropertyChanged(PatientTransferMetadata.PropertyNames.TransferNo);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransfer.RegistrationNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RegistrationNo
        {
            get
            {
                return GetSystemString(PatientTransferMetadata.ColumnNames.RegistrationNo);
            }

            set
            {
                if (SetSystemString(PatientTransferMetadata.ColumnNames.RegistrationNo, value))
                {
                    OnPropertyChanged(PatientTransferMetadata.PropertyNames.RegistrationNo);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransfer.DepartmentID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DepartmentID
        {
            get
            {
                return GetSystemString(PatientTransferMetadata.ColumnNames.DepartmentID);
            }

            set
            {
                if (SetSystemString(PatientTransferMetadata.ColumnNames.DepartmentID, value))
                {
                    OnPropertyChanged(PatientTransferMetadata.PropertyNames.DepartmentID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransfer.TransactionCode
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TransactionCode
        {
            get
            {
                return GetSystemString(PatientTransferMetadata.ColumnNames.TransactionCode);
            }

            set
            {
                if (SetSystemString(PatientTransferMetadata.ColumnNames.TransactionCode, value))
                {
                    OnPropertyChanged(PatientTransferMetadata.PropertyNames.TransactionCode);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransfer.TransferDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? TransferDate
        {
            get
            {
                return GetSystemDateTime(PatientTransferMetadata.ColumnNames.TransferDate);
            }

            set
            {
                if (SetSystemDateTime(PatientTransferMetadata.ColumnNames.TransferDate, value))
                {
                    OnPropertyChanged(PatientTransferMetadata.PropertyNames.TransferDate);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransfer.TransferTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TransferTime
        {
            get
            {
                return GetSystemString(PatientTransferMetadata.ColumnNames.TransferTime);
            }

            set
            {
                if (SetSystemString(PatientTransferMetadata.ColumnNames.TransferTime, value))
                {
                    OnPropertyChanged(PatientTransferMetadata.PropertyNames.TransferTime);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransfer.FromServiceUnitID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string FromServiceUnitID
        {
            get
            {
                return GetSystemString(PatientTransferMetadata.ColumnNames.FromServiceUnitID);
            }

            set
            {
                if (SetSystemString(PatientTransferMetadata.ColumnNames.FromServiceUnitID, value))
                {
                    OnPropertyChanged(PatientTransferMetadata.PropertyNames.FromServiceUnitID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransfer.FromClassID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string FromClassID
        {
            get
            {
                return GetSystemString(PatientTransferMetadata.ColumnNames.FromClassID);
            }

            set
            {
                if (SetSystemString(PatientTransferMetadata.ColumnNames.FromClassID, value))
                {
                    OnPropertyChanged(PatientTransferMetadata.PropertyNames.FromClassID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransfer.FromRoomID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string FromRoomID
        {
            get
            {
                return GetSystemString(PatientTransferMetadata.ColumnNames.FromRoomID);
            }

            set
            {
                if (SetSystemString(PatientTransferMetadata.ColumnNames.FromRoomID, value))
                {
                    OnPropertyChanged(PatientTransferMetadata.PropertyNames.FromRoomID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransfer.FromBedID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string FromBedID
        {
            get
            {
                return GetSystemString(PatientTransferMetadata.ColumnNames.FromBedID);
            }

            set
            {
                if (SetSystemString(PatientTransferMetadata.ColumnNames.FromBedID, value))
                {
                    OnPropertyChanged(PatientTransferMetadata.PropertyNames.FromBedID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransfer.FromChargeClassID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string FromChargeClassID
        {
            get
            {
                return GetSystemString(PatientTransferMetadata.ColumnNames.FromChargeClassID);
            }

            set
            {
                if (SetSystemString(PatientTransferMetadata.ColumnNames.FromChargeClassID, value))
                {
                    OnPropertyChanged(PatientTransferMetadata.PropertyNames.FromChargeClassID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransfer.FromSpecialtyID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string FromSpecialtyID
        {
            get
            {
                return GetSystemString(PatientTransferMetadata.ColumnNames.FromSpecialtyID);
            }

            set
            {
                if (SetSystemString(PatientTransferMetadata.ColumnNames.FromSpecialtyID, value))
                {
                    OnPropertyChanged(PatientTransferMetadata.PropertyNames.FromSpecialtyID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransfer.ToServiceUnitID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ToServiceUnitID
        {
            get
            {
                return GetSystemString(PatientTransferMetadata.ColumnNames.ToServiceUnitID);
            }

            set
            {
                if (SetSystemString(PatientTransferMetadata.ColumnNames.ToServiceUnitID, value))
                {
                    OnPropertyChanged(PatientTransferMetadata.PropertyNames.ToServiceUnitID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransfer.ToClassID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ToClassID
        {
            get
            {
                return GetSystemString(PatientTransferMetadata.ColumnNames.ToClassID);
            }

            set
            {
                if (SetSystemString(PatientTransferMetadata.ColumnNames.ToClassID, value))
                {
                    OnPropertyChanged(PatientTransferMetadata.PropertyNames.ToClassID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransfer.ToRoomID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ToRoomID
        {
            get
            {
                return GetSystemString(PatientTransferMetadata.ColumnNames.ToRoomID);
            }

            set
            {
                if (SetSystemString(PatientTransferMetadata.ColumnNames.ToRoomID, value))
                {
                    OnPropertyChanged(PatientTransferMetadata.PropertyNames.ToRoomID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransfer.ToBedID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ToBedID
        {
            get
            {
                return GetSystemString(PatientTransferMetadata.ColumnNames.ToBedID);
            }

            set
            {
                if (SetSystemString(PatientTransferMetadata.ColumnNames.ToBedID, value))
                {
                    OnPropertyChanged(PatientTransferMetadata.PropertyNames.ToBedID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransfer.ToChargeClassID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ToChargeClassID
        {
            get
            {
                return GetSystemString(PatientTransferMetadata.ColumnNames.ToChargeClassID);
            }

            set
            {
                if (SetSystemString(PatientTransferMetadata.ColumnNames.ToChargeClassID, value))
                {
                    OnPropertyChanged(PatientTransferMetadata.PropertyNames.ToChargeClassID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransfer.ToSpecialtyID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ToSpecialtyID
        {
            get
            {
                return GetSystemString(PatientTransferMetadata.ColumnNames.ToSpecialtyID);
            }

            set
            {
                if (SetSystemString(PatientTransferMetadata.ColumnNames.ToSpecialtyID, value))
                {
                    OnPropertyChanged(PatientTransferMetadata.PropertyNames.ToSpecialtyID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransfer.IsApprove
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsApprove
        {
            get
            {
                return GetSystemBoolean(PatientTransferMetadata.ColumnNames.IsApprove);
            }

            set
            {
                if (SetSystemBoolean(PatientTransferMetadata.ColumnNames.IsApprove, value))
                {
                    OnPropertyChanged(PatientTransferMetadata.PropertyNames.IsApprove);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransfer.IsVoid
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsVoid
        {
            get
            {
                return GetSystemBoolean(PatientTransferMetadata.ColumnNames.IsVoid);
            }

            set
            {
                if (SetSystemBoolean(PatientTransferMetadata.ColumnNames.IsVoid, value))
                {
                    OnPropertyChanged(PatientTransferMetadata.PropertyNames.IsVoid);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransfer.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(PatientTransferMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(PatientTransferMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(PatientTransferMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransfer.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(PatientTransferMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(PatientTransferMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(PatientTransferMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransfer.IsRoomInFrom
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsRoomInFrom
        {
            get
            {
                return GetSystemBoolean(PatientTransferMetadata.ColumnNames.IsRoomInFrom);
            }

            set
            {
                if (SetSystemBoolean(PatientTransferMetadata.ColumnNames.IsRoomInFrom, value))
                {
                    OnPropertyChanged(PatientTransferMetadata.PropertyNames.IsRoomInFrom);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransfer.IsRoomInTo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsRoomInTo
        {
            get
            {
                return GetSystemBoolean(PatientTransferMetadata.ColumnNames.IsRoomInTo);
            }

            set
            {
                if (SetSystemBoolean(PatientTransferMetadata.ColumnNames.IsRoomInTo, value))
                {
                    OnPropertyChanged(PatientTransferMetadata.PropertyNames.IsRoomInTo);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransfer.IsValidated
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsValidated
        {
            get
            {
                return GetSystemBoolean(PatientTransferMetadata.ColumnNames.IsValidated);
            }

            set
            {
                if (SetSystemBoolean(PatientTransferMetadata.ColumnNames.IsValidated, value))
                {
                    OnPropertyChanged(PatientTransferMetadata.PropertyNames.IsValidated);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransfer.ValidatedByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ValidatedByUserID
        {
            get
            {
                return GetSystemString(PatientTransferMetadata.ColumnNames.ValidatedByUserID);
            }

            set
            {
                if (SetSystemString(PatientTransferMetadata.ColumnNames.ValidatedByUserID, value))
                {
                    OnPropertyChanged(PatientTransferMetadata.PropertyNames.ValidatedByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to PatientTransfer.ValidatedDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? ValidatedDateTime
        {
            get
            {
                return GetSystemDateTime(PatientTransferMetadata.ColumnNames.ValidatedDateTime);
            }

            set
            {
                if (SetSystemDateTime(PatientTransferMetadata.ColumnNames.ValidatedDateTime, value))
                {
                    OnPropertyChanged(PatientTransferMetadata.PropertyNames.ValidatedDateTime);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return PatientTransferMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public PatientTransferQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new PatientTransferQuery("ptQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(PatientTransferQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(PatientTransferQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((PatientTransferQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private PatientTransferQuery query;
    }



    [Serializable]
    abstract public partial class esPatientTransferCollection : esEntityCollection<PatientTransfer>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return PatientTransferMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "PatientTransferCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public PatientTransferQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new PatientTransferQuery("ptQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(PatientTransferQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new PatientTransferQuery("ptQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(PatientTransferQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((PatientTransferQuery)query);
        }

        #endregion

        private PatientTransferQuery query;
    }



    [Serializable]
    abstract public partial class esPatientTransferQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return PatientTransferMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "TransferNo": return TransferNo;
                case "RegistrationNo": return RegistrationNo;
                case "DepartmentID": return DepartmentID;
                case "TransactionCode": return TransactionCode;
                case "TransferDate": return TransferDate;
                case "TransferTime": return TransferTime;
                case "FromServiceUnitID": return FromServiceUnitID;
                case "FromClassID": return FromClassID;
                case "FromRoomID": return FromRoomID;
                case "FromBedID": return FromBedID;
                case "FromChargeClassID": return FromChargeClassID;
                case "FromSpecialtyID": return FromSpecialtyID;
                case "ToServiceUnitID": return ToServiceUnitID;
                case "ToClassID": return ToClassID;
                case "ToRoomID": return ToRoomID;
                case "ToBedID": return ToBedID;
                case "ToChargeClassID": return ToChargeClassID;
                case "ToSpecialtyID": return ToSpecialtyID;
                case "IsApprove": return IsApprove;
                case "IsVoid": return IsVoid;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "IsRoomInFrom": return IsRoomInFrom;
                case "IsRoomInTo": return IsRoomInTo;
                case "IsValidated": return IsValidated;
                case "ValidatedByUserID": return ValidatedByUserID;
                case "ValidatedDateTime": return ValidatedDateTime;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem TransferNo
        {
            get { return new esQueryItem(this, PatientTransferMetadata.ColumnNames.TransferNo, esSystemType.String); }
        }

        public esQueryItem RegistrationNo
        {
            get { return new esQueryItem(this, PatientTransferMetadata.ColumnNames.RegistrationNo, esSystemType.String); }
        }

        public esQueryItem DepartmentID
        {
            get { return new esQueryItem(this, PatientTransferMetadata.ColumnNames.DepartmentID, esSystemType.String); }
        }

        public esQueryItem TransactionCode
        {
            get { return new esQueryItem(this, PatientTransferMetadata.ColumnNames.TransactionCode, esSystemType.String); }
        }

        public esQueryItem TransferDate
        {
            get { return new esQueryItem(this, PatientTransferMetadata.ColumnNames.TransferDate, esSystemType.DateTime); }
        }

        public esQueryItem TransferTime
        {
            get { return new esQueryItem(this, PatientTransferMetadata.ColumnNames.TransferTime, esSystemType.String); }
        }

        public esQueryItem FromServiceUnitID
        {
            get { return new esQueryItem(this, PatientTransferMetadata.ColumnNames.FromServiceUnitID, esSystemType.String); }
        }

        public esQueryItem FromClassID
        {
            get { return new esQueryItem(this, PatientTransferMetadata.ColumnNames.FromClassID, esSystemType.String); }
        }

        public esQueryItem FromRoomID
        {
            get { return new esQueryItem(this, PatientTransferMetadata.ColumnNames.FromRoomID, esSystemType.String); }
        }

        public esQueryItem FromBedID
        {
            get { return new esQueryItem(this, PatientTransferMetadata.ColumnNames.FromBedID, esSystemType.String); }
        }

        public esQueryItem FromChargeClassID
        {
            get { return new esQueryItem(this, PatientTransferMetadata.ColumnNames.FromChargeClassID, esSystemType.String); }
        }

        public esQueryItem FromSpecialtyID
        {
            get { return new esQueryItem(this, PatientTransferMetadata.ColumnNames.FromSpecialtyID, esSystemType.String); }
        }

        public esQueryItem ToServiceUnitID
        {
            get { return new esQueryItem(this, PatientTransferMetadata.ColumnNames.ToServiceUnitID, esSystemType.String); }
        }

        public esQueryItem ToClassID
        {
            get { return new esQueryItem(this, PatientTransferMetadata.ColumnNames.ToClassID, esSystemType.String); }
        }

        public esQueryItem ToRoomID
        {
            get { return new esQueryItem(this, PatientTransferMetadata.ColumnNames.ToRoomID, esSystemType.String); }
        }

        public esQueryItem ToBedID
        {
            get { return new esQueryItem(this, PatientTransferMetadata.ColumnNames.ToBedID, esSystemType.String); }
        }

        public esQueryItem ToChargeClassID
        {
            get { return new esQueryItem(this, PatientTransferMetadata.ColumnNames.ToChargeClassID, esSystemType.String); }
        }

        public esQueryItem ToSpecialtyID
        {
            get { return new esQueryItem(this, PatientTransferMetadata.ColumnNames.ToSpecialtyID, esSystemType.String); }
        }

        public esQueryItem IsApprove
        {
            get { return new esQueryItem(this, PatientTransferMetadata.ColumnNames.IsApprove, esSystemType.Boolean); }
        }

        public esQueryItem IsVoid
        {
            get { return new esQueryItem(this, PatientTransferMetadata.ColumnNames.IsVoid, esSystemType.Boolean); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, PatientTransferMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, PatientTransferMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem IsRoomInFrom
        {
            get { return new esQueryItem(this, PatientTransferMetadata.ColumnNames.IsRoomInFrom, esSystemType.Boolean); }
        }

        public esQueryItem IsRoomInTo
        {
            get { return new esQueryItem(this, PatientTransferMetadata.ColumnNames.IsRoomInTo, esSystemType.Boolean); }
        }

        public esQueryItem IsValidated
        {
            get { return new esQueryItem(this, PatientTransferMetadata.ColumnNames.IsValidated, esSystemType.Boolean); }
        }

        public esQueryItem ValidatedByUserID
        {
            get { return new esQueryItem(this, PatientTransferMetadata.ColumnNames.ValidatedByUserID, esSystemType.String); }
        }

        public esQueryItem ValidatedDateTime
        {
            get { return new esQueryItem(this, PatientTransferMetadata.ColumnNames.ValidatedDateTime, esSystemType.DateTime); }
        }

        #endregion

    }



    [Serializable]
    public partial class PatientTransferMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected PatientTransferMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.TransferNo, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TransferNo;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RegistrationNo, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RegistrationNo;
            c.CharacterMaxLength = 20;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DepartmentID, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DepartmentID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TransactionCode, 3, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TransactionCode;
            c.CharacterMaxLength = 3;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TransferDate, 4, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.TransferDate;
            c.HasDefault = true;
            c.Default = @"(getdate())";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TransferTime, 5, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TransferTime;
            c.CharacterMaxLength = 5;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FromServiceUnitID, 6, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.FromServiceUnitID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FromClassID, 7, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.FromClassID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FromRoomID, 8, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.FromRoomID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FromBedID, 9, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.FromBedID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FromChargeClassID, 10, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.FromChargeClassID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FromSpecialtyID, 11, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.FromSpecialtyID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ToServiceUnitID, 12, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ToServiceUnitID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ToClassID, 13, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ToClassID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ToRoomID, 14, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ToRoomID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ToBedID, 15, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ToBedID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ToChargeClassID, 16, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ToChargeClassID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ToSpecialtyID, 17, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ToSpecialtyID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsApprove, 18, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsApprove;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsVoid, 19, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsVoid;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 20, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 21, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 40;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsRoomInFrom, 22, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsRoomInFrom;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsRoomInTo, 23, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsRoomInTo;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsValidated, 24, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsValidated;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ValidatedByUserID, 25, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ValidatedByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ValidatedDateTime, 26, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.ValidatedDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public PatientTransferMetadata Meta()
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
            public const string TransferNo = "TransferNo";
            public const string RegistrationNo = "RegistrationNo";
            public const string DepartmentID = "DepartmentID";
            public const string TransactionCode = "TransactionCode";
            public const string TransferDate = "TransferDate";
            public const string TransferTime = "TransferTime";
            public const string FromServiceUnitID = "FromServiceUnitID";
            public const string FromClassID = "FromClassID";
            public const string FromRoomID = "FromRoomID";
            public const string FromBedID = "FromBedID";
            public const string FromChargeClassID = "FromChargeClassID";
            public const string FromSpecialtyID = "FromSpecialtyID";
            public const string ToServiceUnitID = "ToServiceUnitID";
            public const string ToClassID = "ToClassID";
            public const string ToRoomID = "ToRoomID";
            public const string ToBedID = "ToBedID";
            public const string ToChargeClassID = "ToChargeClassID";
            public const string ToSpecialtyID = "ToSpecialtyID";
            public const string IsApprove = "IsApprove";
            public const string IsVoid = "IsVoid";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string IsRoomInFrom = "IsRoomInFrom";
            public const string IsRoomInTo = "IsRoomInTo";
            public const string IsValidated = "IsValidated";
            public const string ValidatedByUserID = "ValidatedByUserID";
            public const string ValidatedDateTime = "ValidatedDateTime";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string TransferNo = "TransferNo";
            public const string RegistrationNo = "RegistrationNo";
            public const string DepartmentID = "DepartmentID";
            public const string TransactionCode = "TransactionCode";
            public const string TransferDate = "TransferDate";
            public const string TransferTime = "TransferTime";
            public const string FromServiceUnitID = "FromServiceUnitID";
            public const string FromClassID = "FromClassID";
            public const string FromRoomID = "FromRoomID";
            public const string FromBedID = "FromBedID";
            public const string FromChargeClassID = "FromChargeClassID";
            public const string FromSpecialtyID = "FromSpecialtyID";
            public const string ToServiceUnitID = "ToServiceUnitID";
            public const string ToClassID = "ToClassID";
            public const string ToRoomID = "ToRoomID";
            public const string ToBedID = "ToBedID";
            public const string ToChargeClassID = "ToChargeClassID";
            public const string ToSpecialtyID = "ToSpecialtyID";
            public const string IsApprove = "IsApprove";
            public const string IsVoid = "IsVoid";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string IsRoomInFrom = "IsRoomInFrom";
            public const string IsRoomInTo = "IsRoomInTo";
            public const string IsValidated = "IsValidated";
            public const string ValidatedByUserID = "ValidatedByUserID";
            public const string ValidatedDateTime = "ValidatedDateTime";
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
            lock (typeof(PatientTransferMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new PatientTransferMetadata();
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


                meta.AddTypeMap("TransferNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("RegistrationNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("DepartmentID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TransactionCode", new esTypeMap("char", "System.String"));
                meta.AddTypeMap("TransferDate", new esTypeMap("smalldatetime", "System.DateTime"));
                meta.AddTypeMap("TransferTime", new esTypeMap("char", "System.String"));
                meta.AddTypeMap("FromServiceUnitID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("FromClassID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("FromRoomID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("FromBedID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("FromChargeClassID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("FromSpecialtyID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ToServiceUnitID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ToClassID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ToRoomID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ToBedID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ToChargeClassID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ToSpecialtyID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsApprove", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsVoid", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsRoomInFrom", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsRoomInTo", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsValidated", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ValidatedByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ValidatedDateTime", new esTypeMap("datetime", "System.DateTime"));



                meta.Source = "PatientTransfer";
                meta.Destination = "PatientTransfer";

                meta.spInsert = "proc_PatientTransferInsert";
                meta.spUpdate = "proc_PatientTransferUpdate";
                meta.spDelete = "proc_PatientTransferDelete";
                meta.spLoadAll = "proc_PatientTransferLoadAll";
                meta.spLoadByPrimaryKey = "proc_PatientTransferLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private PatientTransferMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
