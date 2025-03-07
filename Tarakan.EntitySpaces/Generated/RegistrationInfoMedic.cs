
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 9/23/2024 2:32:11 PM
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
    /// Encapsulates the 'RegistrationInfoMedic' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(RegistrationInfoMedic))]
    [XmlType("RegistrationInfoMedic")]
    public partial class RegistrationInfoMedic : esRegistrationInfoMedic
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new RegistrationInfoMedic();
        }

        #region Static Quick Access Methods
        static public void Delete(string registrationInfoMedicID)
        {
            var obj = new RegistrationInfoMedic();
            obj.RegistrationInfoMedicID = registrationInfoMedicID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string registrationInfoMedicID, esSqlAccessType sqlAccessType)
        {
            var obj = new RegistrationInfoMedic();
            obj.RegistrationInfoMedicID = registrationInfoMedicID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("RegistrationInfoMedicCollection")]
    public partial class RegistrationInfoMedicCollection : esRegistrationInfoMedicCollection, IEnumerable<RegistrationInfoMedic>
    {
        public RegistrationInfoMedic FindByPrimaryKey(string registrationInfoMedicID)
        {
            return this.SingleOrDefault(e => e.RegistrationInfoMedicID == registrationInfoMedicID);
        }



    }



    [Serializable]
    public partial class RegistrationInfoMedicQuery : esRegistrationInfoMedicQuery
    {
        public RegistrationInfoMedicQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public RegistrationInfoMedicQuery(string joinAlias, out RegistrationInfoMedicQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "RegistrationInfoMedicQuery";
        }



        #region Explicit Casts

        public static explicit operator string(RegistrationInfoMedicQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator RegistrationInfoMedicQuery(string query)
        {
            return (RegistrationInfoMedicQuery)SerializeHelper.FromXml(query, typeof(RegistrationInfoMedicQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esRegistrationInfoMedic : esEntity
    {
        public esRegistrationInfoMedic()
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
            RegistrationInfoMedicQuery query = new RegistrationInfoMedicQuery("rimQ");
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
        /// Maps to RegistrationInfoMedic.RegistrationInfoMedicID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RegistrationInfoMedicID
        {
            get
            {
                return GetSystemString(RegistrationInfoMedicMetadata.ColumnNames.RegistrationInfoMedicID);
            }

            set
            {
                if (SetSystemString(RegistrationInfoMedicMetadata.ColumnNames.RegistrationInfoMedicID, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.RegistrationInfoMedicID);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoMedic.RegistrationNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RegistrationNo
        {
            get
            {
                return GetSystemString(RegistrationInfoMedicMetadata.ColumnNames.RegistrationNo);
            }

            set
            {
                if (SetSystemString(RegistrationInfoMedicMetadata.ColumnNames.RegistrationNo, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.RegistrationNo);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoMedic.SRMedicalNotesInputType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRMedicalNotesInputType
        {
            get
            {
                return GetSystemString(RegistrationInfoMedicMetadata.ColumnNames.SRMedicalNotesInputType);
            }

            set
            {
                if (SetSystemString(RegistrationInfoMedicMetadata.ColumnNames.SRMedicalNotesInputType, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.SRMedicalNotesInputType);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoMedic.DateTimeInfo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? DateTimeInfo
        {
            get
            {
                return GetSystemDateTime(RegistrationInfoMedicMetadata.ColumnNames.DateTimeInfo);
            }

            set
            {
                if (SetSystemDateTime(RegistrationInfoMedicMetadata.ColumnNames.DateTimeInfo, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.DateTimeInfo);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoMedic.Info1
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Info1
        {
            get
            {
                return GetSystemString(RegistrationInfoMedicMetadata.ColumnNames.Info1);
            }

            set
            {
                if (SetSystemString(RegistrationInfoMedicMetadata.ColumnNames.Info1, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.Info1);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoMedic.Info2
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Info2
        {
            get
            {
                return GetSystemString(RegistrationInfoMedicMetadata.ColumnNames.Info2);
            }

            set
            {
                if (SetSystemString(RegistrationInfoMedicMetadata.ColumnNames.Info2, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.Info2);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoMedic.Info3
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Info3
        {
            get
            {
                return GetSystemString(RegistrationInfoMedicMetadata.ColumnNames.Info3);
            }

            set
            {
                if (SetSystemString(RegistrationInfoMedicMetadata.ColumnNames.Info3, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.Info3);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoMedic.Info4
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Info4
        {
            get
            {
                return GetSystemString(RegistrationInfoMedicMetadata.ColumnNames.Info4);
            }

            set
            {
                if (SetSystemString(RegistrationInfoMedicMetadata.ColumnNames.Info4, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.Info4);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoMedic.CreatedByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string CreatedByUserID
        {
            get
            {
                return GetSystemString(RegistrationInfoMedicMetadata.ColumnNames.CreatedByUserID);
            }

            set
            {
                if (SetSystemString(RegistrationInfoMedicMetadata.ColumnNames.CreatedByUserID, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.CreatedByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoMedic.CreatedDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? CreatedDateTime
        {
            get
            {
                return GetSystemDateTime(RegistrationInfoMedicMetadata.ColumnNames.CreatedDateTime);
            }

            set
            {
                if (SetSystemDateTime(RegistrationInfoMedicMetadata.ColumnNames.CreatedDateTime, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.CreatedDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoMedic.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(RegistrationInfoMedicMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(RegistrationInfoMedicMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoMedic.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(RegistrationInfoMedicMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(RegistrationInfoMedicMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoMedic.Info1Log
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Info1Log
        {
            get
            {
                return GetSystemString(RegistrationInfoMedicMetadata.ColumnNames.Info1Log);
            }

            set
            {
                if (SetSystemString(RegistrationInfoMedicMetadata.ColumnNames.Info1Log, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.Info1Log);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoMedic.Info2Log
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Info2Log
        {
            get
            {
                return GetSystemString(RegistrationInfoMedicMetadata.ColumnNames.Info2Log);
            }

            set
            {
                if (SetSystemString(RegistrationInfoMedicMetadata.ColumnNames.Info2Log, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.Info2Log);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoMedic.Info3Log
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Info3Log
        {
            get
            {
                return GetSystemString(RegistrationInfoMedicMetadata.ColumnNames.Info3Log);
            }

            set
            {
                if (SetSystemString(RegistrationInfoMedicMetadata.ColumnNames.Info3Log, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.Info3Log);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoMedic.Info4Log
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Info4Log
        {
            get
            {
                return GetSystemString(RegistrationInfoMedicMetadata.ColumnNames.Info4Log);
            }

            set
            {
                if (SetSystemString(RegistrationInfoMedicMetadata.ColumnNames.Info4Log, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.Info4Log);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoMedic.IsDeleted
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsDeleted
        {
            get
            {
                return GetSystemBoolean(RegistrationInfoMedicMetadata.ColumnNames.IsDeleted);
            }

            set
            {
                if (SetSystemBoolean(RegistrationInfoMedicMetadata.ColumnNames.IsDeleted, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.IsDeleted);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoMedic.ServiceUnitID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ServiceUnitID
        {
            get
            {
                return GetSystemString(RegistrationInfoMedicMetadata.ColumnNames.ServiceUnitID);
            }

            set
            {
                if (SetSystemString(RegistrationInfoMedicMetadata.ColumnNames.ServiceUnitID, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.ServiceUnitID);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoMedic.AttendingNotes
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string AttendingNotes
        {
            get
            {
                return GetSystemString(RegistrationInfoMedicMetadata.ColumnNames.AttendingNotes);
            }

            set
            {
                if (SetSystemString(RegistrationInfoMedicMetadata.ColumnNames.AttendingNotes, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.AttendingNotes);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoMedic.IsInformConcern
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsInformConcern
        {
            get
            {
                return GetSystemBoolean(RegistrationInfoMedicMetadata.ColumnNames.IsInformConcern);
            }

            set
            {
                if (SetSystemBoolean(RegistrationInfoMedicMetadata.ColumnNames.IsInformConcern, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.IsInformConcern);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoMedic.ParamedicID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParamedicID
        {
            get
            {
                return GetSystemString(RegistrationInfoMedicMetadata.ColumnNames.ParamedicID);
            }

            set
            {
                if (SetSystemString(RegistrationInfoMedicMetadata.ColumnNames.ParamedicID, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.ParamedicID);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoMedic.ApprovedDatetime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? ApprovedDatetime
        {
            get
            {
                return GetSystemDateTime(RegistrationInfoMedicMetadata.ColumnNames.ApprovedDatetime);
            }

            set
            {
                if (SetSystemDateTime(RegistrationInfoMedicMetadata.ColumnNames.ApprovedDatetime, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.ApprovedDatetime);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoMedic.IsApproved
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsApproved
        {
            get
            {
                return GetSystemBoolean(RegistrationInfoMedicMetadata.ColumnNames.IsApproved);
            }

            set
            {
                if (SetSystemBoolean(RegistrationInfoMedicMetadata.ColumnNames.IsApproved, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.IsApproved);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoMedic.ApprovedByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ApprovedByUserID
        {
            get
            {
                return GetSystemString(RegistrationInfoMedicMetadata.ColumnNames.ApprovedByUserID);
            }

            set
            {
                if (SetSystemString(RegistrationInfoMedicMetadata.ColumnNames.ApprovedByUserID, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.ApprovedByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoMedic.IsPRMRJ
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsPRMRJ
        {
            get
            {
                return GetSystemBoolean(RegistrationInfoMedicMetadata.ColumnNames.IsPRMRJ);
            }

            set
            {
                if (SetSystemBoolean(RegistrationInfoMedicMetadata.ColumnNames.IsPRMRJ, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.IsPRMRJ);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoMedic.PpaInstruction
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PpaInstruction
        {
            get
            {
                return GetSystemString(RegistrationInfoMedicMetadata.ColumnNames.PpaInstruction);
            }

            set
            {
                if (SetSystemString(RegistrationInfoMedicMetadata.ColumnNames.PpaInstruction, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.PpaInstruction);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoMedic.IsCreatedByUserDpjp
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsCreatedByUserDpjp
        {
            get
            {
                return GetSystemBoolean(RegistrationInfoMedicMetadata.ColumnNames.IsCreatedByUserDpjp);
            }

            set
            {
                if (SetSystemBoolean(RegistrationInfoMedicMetadata.ColumnNames.IsCreatedByUserDpjp, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.IsCreatedByUserDpjp);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoMedic.SRUserType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRUserType
        {
            get
            {
                return GetSystemString(RegistrationInfoMedicMetadata.ColumnNames.SRUserType);
            }

            set
            {
                if (SetSystemString(RegistrationInfoMedicMetadata.ColumnNames.SRUserType, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.SRUserType);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoMedic.PrescriptionCurrentDay
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PrescriptionCurrentDay
        {
            get
            {
                return GetSystemString(RegistrationInfoMedicMetadata.ColumnNames.PrescriptionCurrentDay);
            }

            set
            {
                if (SetSystemString(RegistrationInfoMedicMetadata.ColumnNames.PrescriptionCurrentDay, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.PrescriptionCurrentDay);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoMedic.ReferenceType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ReferenceType
        {
            get
            {
                return GetSystemString(RegistrationInfoMedicMetadata.ColumnNames.ReferenceType);
            }

            set
            {
                if (SetSystemString(RegistrationInfoMedicMetadata.ColumnNames.ReferenceType, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.ReferenceType);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoMedic.Info1Entry
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Info1Entry
        {
            get
            {
                return GetSystemString(RegistrationInfoMedicMetadata.ColumnNames.Info1Entry);
            }

            set
            {
                if (SetSystemString(RegistrationInfoMedicMetadata.ColumnNames.Info1Entry, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.Info1Entry);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoMedic.Info3Entry
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Info3Entry
        {
            get
            {
                return GetSystemString(RegistrationInfoMedicMetadata.ColumnNames.Info3Entry);
            }

            set
            {
                if (SetSystemString(RegistrationInfoMedicMetadata.ColumnNames.Info3Entry, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.Info3Entry);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoMedic.ReferenceNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ReferenceNo
        {
            get
            {
                return GetSystemString(RegistrationInfoMedicMetadata.ColumnNames.ReferenceNo);
            }

            set
            {
                if (SetSystemString(RegistrationInfoMedicMetadata.ColumnNames.ReferenceNo, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.ReferenceNo);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoMedic.Info5
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Info5
        {
            get
            {
                return GetSystemString(RegistrationInfoMedicMetadata.ColumnNames.Info5);
            }

            set
            {
                if (SetSystemString(RegistrationInfoMedicMetadata.ColumnNames.Info5, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.Info5);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoMedic.DpjpNotes
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DpjpNotes
        {
            get
            {
                return GetSystemString(RegistrationInfoMedicMetadata.ColumnNames.DpjpNotes);
            }

            set
            {
                if (SetSystemString(RegistrationInfoMedicMetadata.ColumnNames.DpjpNotes, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.DpjpNotes);
                }
            }
        }

        /// <summary>
        /// Maps to RegistrationInfoMedic.ReceiveBy
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ReceiveBy
        {
            get
            {
                return GetSystemString(RegistrationInfoMedicMetadata.ColumnNames.ReceiveBy);
            }

            set
            {
                if (SetSystemString(RegistrationInfoMedicMetadata.ColumnNames.ReceiveBy, value))
                {
                    OnPropertyChanged(RegistrationInfoMedicMetadata.PropertyNames.ReceiveBy);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return RegistrationInfoMedicMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public RegistrationInfoMedicQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new RegistrationInfoMedicQuery("rimQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(RegistrationInfoMedicQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(RegistrationInfoMedicQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((RegistrationInfoMedicQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private RegistrationInfoMedicQuery query;
    }



    [Serializable]
    abstract public partial class esRegistrationInfoMedicCollection : esEntityCollection<RegistrationInfoMedic>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return RegistrationInfoMedicMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "RegistrationInfoMedicCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public RegistrationInfoMedicQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new RegistrationInfoMedicQuery("rimQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(RegistrationInfoMedicQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new RegistrationInfoMedicQuery("rimQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(RegistrationInfoMedicQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((RegistrationInfoMedicQuery)query);
        }

        #endregion

        private RegistrationInfoMedicQuery query;
    }



    [Serializable]
    abstract public partial class esRegistrationInfoMedicQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return RegistrationInfoMedicMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "RegistrationInfoMedicID": return RegistrationInfoMedicID;
                case "RegistrationNo": return RegistrationNo;
                case "SRMedicalNotesInputType": return SRMedicalNotesInputType;
                case "DateTimeInfo": return DateTimeInfo;
                case "Info1": return Info1;
                case "Info2": return Info2;
                case "Info3": return Info3;
                case "Info4": return Info4;
                case "CreatedByUserID": return CreatedByUserID;
                case "CreatedDateTime": return CreatedDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "Info1Log": return Info1Log;
                case "Info2Log": return Info2Log;
                case "Info3Log": return Info3Log;
                case "Info4Log": return Info4Log;
                case "IsDeleted": return IsDeleted;
                case "ServiceUnitID": return ServiceUnitID;
                case "AttendingNotes": return AttendingNotes;
                case "IsInformConcern": return IsInformConcern;
                case "ParamedicID": return ParamedicID;
                case "ApprovedDatetime": return ApprovedDatetime;
                case "IsApproved": return IsApproved;
                case "ApprovedByUserID": return ApprovedByUserID;
                case "IsPRMRJ": return IsPRMRJ;
                case "PpaInstruction": return PpaInstruction;
                case "IsCreatedByUserDpjp": return IsCreatedByUserDpjp;
                case "SRUserType": return SRUserType;
                case "PrescriptionCurrentDay": return PrescriptionCurrentDay;
                case "ReferenceType": return ReferenceType;
                case "Info1Entry": return Info1Entry;
                case "Info3Entry": return Info3Entry;
                case "ReferenceNo": return ReferenceNo;
                case "Info5": return Info5;
                case "DpjpNotes": return DpjpNotes;
                case "ReceiveBy": return ReceiveBy;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem RegistrationInfoMedicID
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.RegistrationInfoMedicID, esSystemType.String); }
        }

        public esQueryItem RegistrationNo
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.RegistrationNo, esSystemType.String); }
        }

        public esQueryItem SRMedicalNotesInputType
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.SRMedicalNotesInputType, esSystemType.String); }
        }

        public esQueryItem DateTimeInfo
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.DateTimeInfo, esSystemType.DateTime); }
        }

        public esQueryItem Info1
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.Info1, esSystemType.String); }
        }

        public esQueryItem Info2
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.Info2, esSystemType.String); }
        }

        public esQueryItem Info3
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.Info3, esSystemType.String); }
        }

        public esQueryItem Info4
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.Info4, esSystemType.String); }
        }

        public esQueryItem CreatedByUserID
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.CreatedByUserID, esSystemType.String); }
        }

        public esQueryItem CreatedDateTime
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.CreatedDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem Info1Log
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.Info1Log, esSystemType.String); }
        }

        public esQueryItem Info2Log
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.Info2Log, esSystemType.String); }
        }

        public esQueryItem Info3Log
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.Info3Log, esSystemType.String); }
        }

        public esQueryItem Info4Log
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.Info4Log, esSystemType.String); }
        }

        public esQueryItem IsDeleted
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.IsDeleted, esSystemType.Boolean); }
        }

        public esQueryItem ServiceUnitID
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.ServiceUnitID, esSystemType.String); }
        }

        public esQueryItem AttendingNotes
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.AttendingNotes, esSystemType.String); }
        }

        public esQueryItem IsInformConcern
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.IsInformConcern, esSystemType.Boolean); }
        }

        public esQueryItem ParamedicID
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.ParamedicID, esSystemType.String); }
        }

        public esQueryItem ApprovedDatetime
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.ApprovedDatetime, esSystemType.DateTime); }
        }

        public esQueryItem IsApproved
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.IsApproved, esSystemType.Boolean); }
        }

        public esQueryItem ApprovedByUserID
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.ApprovedByUserID, esSystemType.String); }
        }

        public esQueryItem IsPRMRJ
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.IsPRMRJ, esSystemType.Boolean); }
        }

        public esQueryItem PpaInstruction
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.PpaInstruction, esSystemType.String); }
        }

        public esQueryItem IsCreatedByUserDpjp
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.IsCreatedByUserDpjp, esSystemType.Boolean); }
        }

        public esQueryItem SRUserType
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.SRUserType, esSystemType.String); }
        }

        public esQueryItem PrescriptionCurrentDay
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.PrescriptionCurrentDay, esSystemType.String); }
        }

        public esQueryItem ReferenceType
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.ReferenceType, esSystemType.String); }
        }

        public esQueryItem Info1Entry
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.Info1Entry, esSystemType.String); }
        }

        public esQueryItem Info3Entry
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.Info3Entry, esSystemType.String); }
        }

        public esQueryItem ReferenceNo
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.ReferenceNo, esSystemType.String); }
        }

        public esQueryItem Info5
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.Info5, esSystemType.String); }
        }

        public esQueryItem DpjpNotes
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.DpjpNotes, esSystemType.String); }
        }

        public esQueryItem ReceiveBy
        {
            get { return new esQueryItem(this, RegistrationInfoMedicMetadata.ColumnNames.ReceiveBy, esSystemType.String); }
        }

        #endregion

    }



    [Serializable]
    public partial class RegistrationInfoMedicMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected RegistrationInfoMedicMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.RegistrationInfoMedicID, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RegistrationInfoMedicID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 20;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RegistrationNo, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RegistrationNo;
            c.CharacterMaxLength = 20;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRMedicalNotesInputType, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRMedicalNotesInputType;
            c.CharacterMaxLength = 20;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DateTimeInfo, 3, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.DateTimeInfo;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Info1, 4, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Info1;
            c.CharacterMaxLength = 2147483647;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Info2, 5, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Info2;
            c.CharacterMaxLength = 8000;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Info3, 6, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Info3;
            c.CharacterMaxLength = 8000;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Info4, 7, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Info4;
            c.CharacterMaxLength = 8000;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreatedByUserID, 8, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.CreatedByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreatedDateTime, 9, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.CreatedDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 10, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 11, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Info1Log, 12, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Info1Log;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Info2Log, 13, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Info2Log;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Info3Log, 14, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Info3Log;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Info4Log, 15, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Info4Log;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsDeleted, 16, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsDeleted;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ServiceUnitID, 17, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ServiceUnitID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AttendingNotes, 18, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.AttendingNotes;
            c.CharacterMaxLength = 255;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsInformConcern, 19, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsInformConcern;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParamedicID, 20, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParamedicID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ApprovedDatetime, 21, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.ApprovedDatetime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsApproved, 22, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsApproved;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ApprovedByUserID, 23, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ApprovedByUserID;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsPRMRJ, 24, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsPRMRJ;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PpaInstruction, 25, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PpaInstruction;
            c.CharacterMaxLength = 8000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsCreatedByUserDpjp, 26, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsCreatedByUserDpjp;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRUserType, 27, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRUserType;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PrescriptionCurrentDay, 28, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PrescriptionCurrentDay;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ReferenceType, 29, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ReferenceType;
            c.CharacterMaxLength = 5;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Info1Entry, 30, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Info1Entry;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Info3Entry, 31, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Info3Entry;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ReferenceNo, 32, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ReferenceNo;
            c.CharacterMaxLength = 40;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Info5, 33, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Info5;
            c.CharacterMaxLength = 8000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DpjpNotes, 34, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DpjpNotes;
            c.CharacterMaxLength = 8000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ReceiveBy, 35, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ReceiveBy;
            c.CharacterMaxLength = 200;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public RegistrationInfoMedicMetadata Meta()
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
            public const string RegistrationNo = "RegistrationNo";
            public const string SRMedicalNotesInputType = "SRMedicalNotesInputType";
            public const string DateTimeInfo = "DateTimeInfo";
            public const string Info1 = "Info1";
            public const string Info2 = "Info2";
            public const string Info3 = "Info3";
            public const string Info4 = "Info4";
            public const string CreatedByUserID = "CreatedByUserID";
            public const string CreatedDateTime = "CreatedDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string Info1Log = "Info1Log";
            public const string Info2Log = "Info2Log";
            public const string Info3Log = "Info3Log";
            public const string Info4Log = "Info4Log";
            public const string IsDeleted = "IsDeleted";
            public const string ServiceUnitID = "ServiceUnitID";
            public const string AttendingNotes = "AttendingNotes";
            public const string IsInformConcern = "IsInformConcern";
            public const string ParamedicID = "ParamedicID";
            public const string ApprovedDatetime = "ApprovedDatetime";
            public const string IsApproved = "IsApproved";
            public const string ApprovedByUserID = "ApprovedByUserID";
            public const string IsPRMRJ = "IsPRMRJ";
            public const string PpaInstruction = "PpaInstruction";
            public const string IsCreatedByUserDpjp = "IsCreatedByUserDpjp";
            public const string SRUserType = "SRUserType";
            public const string PrescriptionCurrentDay = "PrescriptionCurrentDay";
            public const string ReferenceType = "ReferenceType";
            public const string Info1Entry = "Info1Entry";
            public const string Info3Entry = "Info3Entry";
            public const string ReferenceNo = "ReferenceNo";
            public const string Info5 = "Info5";
            public const string DpjpNotes = "DpjpNotes";
            public const string ReceiveBy = "ReceiveBy";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string RegistrationInfoMedicID = "RegistrationInfoMedicID";
            public const string RegistrationNo = "RegistrationNo";
            public const string SRMedicalNotesInputType = "SRMedicalNotesInputType";
            public const string DateTimeInfo = "DateTimeInfo";
            public const string Info1 = "Info1";
            public const string Info2 = "Info2";
            public const string Info3 = "Info3";
            public const string Info4 = "Info4";
            public const string CreatedByUserID = "CreatedByUserID";
            public const string CreatedDateTime = "CreatedDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string Info1Log = "Info1Log";
            public const string Info2Log = "Info2Log";
            public const string Info3Log = "Info3Log";
            public const string Info4Log = "Info4Log";
            public const string IsDeleted = "IsDeleted";
            public const string ServiceUnitID = "ServiceUnitID";
            public const string AttendingNotes = "AttendingNotes";
            public const string IsInformConcern = "IsInformConcern";
            public const string ParamedicID = "ParamedicID";
            public const string ApprovedDatetime = "ApprovedDatetime";
            public const string IsApproved = "IsApproved";
            public const string ApprovedByUserID = "ApprovedByUserID";
            public const string IsPRMRJ = "IsPRMRJ";
            public const string PpaInstruction = "PpaInstruction";
            public const string IsCreatedByUserDpjp = "IsCreatedByUserDpjp";
            public const string SRUserType = "SRUserType";
            public const string PrescriptionCurrentDay = "PrescriptionCurrentDay";
            public const string ReferenceType = "ReferenceType";
            public const string Info1Entry = "Info1Entry";
            public const string Info3Entry = "Info3Entry";
            public const string ReferenceNo = "ReferenceNo";
            public const string Info5 = "Info5";
            public const string DpjpNotes = "DpjpNotes";
            public const string ReceiveBy = "ReceiveBy";
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
            lock (typeof(RegistrationInfoMedicMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new RegistrationInfoMedicMetadata();
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
                meta.AddTypeMap("RegistrationNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRMedicalNotesInputType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("DateTimeInfo", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("Info1", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Info2", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Info3", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Info4", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CreatedByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CreatedDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("Info1Log", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Info2Log", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Info3Log", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Info4Log", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsDeleted", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ServiceUnitID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("AttendingNotes", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsInformConcern", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ParamedicID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ApprovedDatetime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("IsApproved", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ApprovedByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsPRMRJ", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("PpaInstruction", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsCreatedByUserDpjp", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("SRUserType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PrescriptionCurrentDay", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ReferenceType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Info1Entry", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Info3Entry", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ReferenceNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Info5", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("DpjpNotes", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ReceiveBy", new esTypeMap("varchar", "System.String"));



                meta.Source = "RegistrationInfoMedic";
                meta.Destination = "RegistrationInfoMedic";

                meta.spInsert = "proc_RegistrationInfoMedicInsert";
                meta.spUpdate = "proc_RegistrationInfoMedicUpdate";
                meta.spDelete = "proc_RegistrationInfoMedicDelete";
                meta.spLoadAll = "proc_RegistrationInfoMedicLoadAll";
                meta.spLoadByPrimaryKey = "proc_RegistrationInfoMedicLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private RegistrationInfoMedicMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
