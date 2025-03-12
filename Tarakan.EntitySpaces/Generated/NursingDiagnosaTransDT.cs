
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 3/12/2025 9:53:14 AM
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
    /// Encapsulates the 'NursingDiagnosaTransDT' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(NursingDiagnosaTransDT))]
    [XmlType("NursingDiagnosaTransDT")]
    public partial class NursingDiagnosaTransDT : esNursingDiagnosaTransDT
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new NursingDiagnosaTransDT();
        }

        #region Static Quick Access Methods
        static public void Delete(long id)
        {
            var obj = new NursingDiagnosaTransDT();
            obj.Id = id;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(long id, esSqlAccessType sqlAccessType)
        {
            var obj = new NursingDiagnosaTransDT();
            obj.Id = id;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("NursingDiagnosaTransDTCollection")]
    public partial class NursingDiagnosaTransDTCollection : esNursingDiagnosaTransDTCollection, IEnumerable<NursingDiagnosaTransDT>
    {
        public NursingDiagnosaTransDT FindByPrimaryKey(long id)
        {
            return this.SingleOrDefault(e => e.Id == id);
        }



    }



    [Serializable]
    public partial class NursingDiagnosaTransDTQuery : esNursingDiagnosaTransDTQuery
    {
        public NursingDiagnosaTransDTQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public NursingDiagnosaTransDTQuery(string joinAlias, out NursingDiagnosaTransDTQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "NursingDiagnosaTransDTQuery";
        }



        #region Explicit Casts

        public static explicit operator string(NursingDiagnosaTransDTQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator NursingDiagnosaTransDTQuery(string query)
        {
            return (NursingDiagnosaTransDTQuery)SerializeHelper.FromXml(query, typeof(NursingDiagnosaTransDTQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esNursingDiagnosaTransDT : esEntity
    {
        public esNursingDiagnosaTransDT()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(long id)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(id);
            else
                return LoadByPrimaryKeyStoredProcedure(id);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, long id)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(id);
            else
                return LoadByPrimaryKeyStoredProcedure(id);
        }

        private bool LoadByPrimaryKeyDynamic(long id)
        {
            NursingDiagnosaTransDTQuery query = new NursingDiagnosaTransDTQuery("ndtQ");
            query.Where(query.Id == id);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(long id)
        {
            esParameters parms = new esParameters();
            parms.Add("Id", id);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to NursingDiagnosaTransDT.ID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public long? Id
        {
            get
            {
                return GetSystemInt64(NursingDiagnosaTransDTMetadata.ColumnNames.Id);
            }

            set
            {
                if (SetSystemInt64(NursingDiagnosaTransDTMetadata.ColumnNames.Id, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.Id);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.TransactionNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TransactionNo
        {
            get
            {
                return GetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.TransactionNo);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.TransactionNo, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.TransactionNo);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.NursingDiagnosaID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string NursingDiagnosaID
        {
            get
            {
                return GetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.NursingDiagnosaID);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.NursingDiagnosaID, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.NursingDiagnosaID);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.NursingDiagnosaName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string NursingDiagnosaName
        {
            get
            {
                return GetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.NursingDiagnosaName);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.NursingDiagnosaName, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.NursingDiagnosaName);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.SRNursingDiagnosaLevel
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRNursingDiagnosaLevel
        {
            get
            {
                return GetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.SRNursingDiagnosaLevel);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.SRNursingDiagnosaLevel, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.SRNursingDiagnosaLevel);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.NursingDiagnosaParentID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string NursingDiagnosaParentID
        {
            get
            {
                return GetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.NursingDiagnosaParentID);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.NursingDiagnosaParentID, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.NursingDiagnosaParentID);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.Priority
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? Priority
        {
            get
            {
                return GetSystemInt32(NursingDiagnosaTransDTMetadata.ColumnNames.Priority);
            }

            set
            {
                if (SetSystemInt32(NursingDiagnosaTransDTMetadata.ColumnNames.Priority, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.Priority);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.Skala
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? Skala
        {
            get
            {
                return GetSystemInt32(NursingDiagnosaTransDTMetadata.ColumnNames.Skala);
            }

            set
            {
                if (SetSystemInt32(NursingDiagnosaTransDTMetadata.ColumnNames.Skala, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.Skala);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.Target
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? Target
        {
            get
            {
                return GetSystemInt32(NursingDiagnosaTransDTMetadata.ColumnNames.Target);
            }

            set
            {
                if (SetSystemInt32(NursingDiagnosaTransDTMetadata.ColumnNames.Target, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.Target);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.Respond
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Respond
        {
            get
            {
                return GetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.Respond);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.Respond, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.Respond);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.Evaluasi
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? Evaluasi
        {
            get
            {
                return GetSystemInt32(NursingDiagnosaTransDTMetadata.ColumnNames.Evaluasi);
            }

            set
            {
                if (SetSystemInt32(NursingDiagnosaTransDTMetadata.ColumnNames.Evaluasi, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.Evaluasi);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.Reexamine
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? Reexamine
        {
            get
            {
                return GetSystemBoolean(NursingDiagnosaTransDTMetadata.ColumnNames.Reexamine);
            }

            set
            {
                if (SetSystemBoolean(NursingDiagnosaTransDTMetadata.ColumnNames.Reexamine, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.Reexamine);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.ExecuteDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? ExecuteDateTime
        {
            get
            {
                return GetSystemDateTime(NursingDiagnosaTransDTMetadata.ColumnNames.ExecuteDateTime);
            }

            set
            {
                if (SetSystemDateTime(NursingDiagnosaTransDTMetadata.ColumnNames.ExecuteDateTime, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.ExecuteDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.CreateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string CreateByUserID
        {
            get
            {
                return GetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.CreateByUserID);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.CreateByUserID, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.CreateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.CreateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? CreateDateTime
        {
            get
            {
                return GetSystemDateTime(NursingDiagnosaTransDTMetadata.ColumnNames.CreateDateTime);
            }

            set
            {
                if (SetSystemDateTime(NursingDiagnosaTransDTMetadata.ColumnNames.CreateDateTime, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.CreateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(NursingDiagnosaTransDTMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(NursingDiagnosaTransDTMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.TmpNursingDiagnosaID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TmpNursingDiagnosaID
        {
            get
            {
                return GetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.TmpNursingDiagnosaID);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.TmpNursingDiagnosaID, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.TmpNursingDiagnosaID);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.TmpNursingDiagnosaParentID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TmpNursingDiagnosaParentID
        {
            get
            {
                return GetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.TmpNursingDiagnosaParentID);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.TmpNursingDiagnosaParentID, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.TmpNursingDiagnosaParentID);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.EvalPeriod
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? EvalPeriod
        {
            get
            {
                return GetSystemInt32(NursingDiagnosaTransDTMetadata.ColumnNames.EvalPeriod);
            }

            set
            {
                if (SetSystemInt32(NursingDiagnosaTransDTMetadata.ColumnNames.EvalPeriod, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.EvalPeriod);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.PeriodConversionInHour
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? PeriodConversionInHour
        {
            get
            {
                return GetSystemInt32(NursingDiagnosaTransDTMetadata.ColumnNames.PeriodConversionInHour);
            }

            set
            {
                if (SetSystemInt32(NursingDiagnosaTransDTMetadata.ColumnNames.PeriodConversionInHour, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.PeriodConversionInHour);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.S
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string S
        {
            get
            {
                return GetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.S);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.S, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.S);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.O
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string O
        {
            get
            {
                return GetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.O);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.O, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.O);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.A
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string A
        {
            get
            {
                return GetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.A);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.A, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.A);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.SRNursingCarePlanning
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRNursingCarePlanning
        {
            get
            {
                return GetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.SRNursingCarePlanning);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.SRNursingCarePlanning, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.SRNursingCarePlanning);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.P
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string P
        {
            get
            {
                return GetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.P);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.P, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.P);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.ParentID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public long? ParentID
        {
            get
            {
                return GetSystemInt64(NursingDiagnosaTransDTMetadata.ColumnNames.ParentID);
            }

            set
            {
                if (SetSystemInt64(NursingDiagnosaTransDTMetadata.ColumnNames.ParentID, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.ParentID);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.IsDeleted
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsDeleted
        {
            get
            {
                return GetSystemBoolean(NursingDiagnosaTransDTMetadata.ColumnNames.IsDeleted);
            }

            set
            {
                if (SetSystemBoolean(NursingDiagnosaTransDTMetadata.ColumnNames.IsDeleted, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.IsDeleted);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.ReferenceToPhrNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ReferenceToPhrNo
        {
            get
            {
                return GetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.ReferenceToPhrNo);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.ReferenceToPhrNo, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.ReferenceToPhrNo);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.IsApproved
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsApproved
        {
            get
            {
                return GetSystemBoolean(NursingDiagnosaTransDTMetadata.ColumnNames.IsApproved);
            }

            set
            {
                if (SetSystemBoolean(NursingDiagnosaTransDTMetadata.ColumnNames.IsApproved, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.IsApproved);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.ApprovedDatetime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? ApprovedDatetime
        {
            get
            {
                return GetSystemDateTime(NursingDiagnosaTransDTMetadata.ColumnNames.ApprovedDatetime);
            }

            set
            {
                if (SetSystemDateTime(NursingDiagnosaTransDTMetadata.ColumnNames.ApprovedDatetime, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.ApprovedDatetime);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.ApprovedByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ApprovedByUserID
        {
            get
            {
                return GetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.ApprovedByUserID);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.ApprovedByUserID, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.ApprovedByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.IsPRMRJ
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsPRMRJ
        {
            get
            {
                return GetSystemBoolean(NursingDiagnosaTransDTMetadata.ColumnNames.IsPRMRJ);
            }

            set
            {
                if (SetSystemBoolean(NursingDiagnosaTransDTMetadata.ColumnNames.IsPRMRJ, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.IsPRMRJ);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.PpaInstruction
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PpaInstruction
        {
            get
            {
                return GetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.PpaInstruction);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.PpaInstruction, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.PpaInstruction);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.SRUserType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRUserType
        {
            get
            {
                return GetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.SRUserType);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.SRUserType, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.SRUserType);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.PrescriptionCurrentDay
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PrescriptionCurrentDay
        {
            get
            {
                return GetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.PrescriptionCurrentDay);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.PrescriptionCurrentDay, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.PrescriptionCurrentDay);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.SubmitBy
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SubmitBy
        {
            get
            {
                return GetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.SubmitBy);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.SubmitBy, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.SubmitBy);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.ReceiveBy
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ReceiveBy
        {
            get
            {
                return GetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.ReceiveBy);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.ReceiveBy, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.ReceiveBy);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.SRNsType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRNsType
        {
            get
            {
                return GetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.SRNsType);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.SRNsType, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.SRNsType);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.TemplateID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? TemplateID
        {
            get
            {
                return GetSystemInt32(NursingDiagnosaTransDTMetadata.ColumnNames.TemplateID);
            }

            set
            {
                if (SetSystemInt32(NursingDiagnosaTransDTMetadata.ColumnNames.TemplateID, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.TemplateID);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.Info5
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Info5
        {
            get
            {
                return GetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.Info5);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.Info5, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.Info5);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.DpjpNotes
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string DpjpNotes
        {
            get
            {
                return GetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.DpjpNotes);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.DpjpNotes, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.DpjpNotes);
                }
            }
        }

        /// <summary>
        /// Maps to NursingDiagnosaTransDT.ParamedicID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParamedicID
        {
            get
            {
                return GetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.ParamedicID);
            }

            set
            {
                if (SetSystemString(NursingDiagnosaTransDTMetadata.ColumnNames.ParamedicID, value))
                {
                    OnPropertyChanged(NursingDiagnosaTransDTMetadata.PropertyNames.ParamedicID);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return NursingDiagnosaTransDTMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public NursingDiagnosaTransDTQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new NursingDiagnosaTransDTQuery("ndtQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(NursingDiagnosaTransDTQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(NursingDiagnosaTransDTQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((NursingDiagnosaTransDTQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private NursingDiagnosaTransDTQuery query;
    }



    [Serializable]
    abstract public partial class esNursingDiagnosaTransDTCollection : esEntityCollection<NursingDiagnosaTransDT>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return NursingDiagnosaTransDTMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "NursingDiagnosaTransDTCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public NursingDiagnosaTransDTQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new NursingDiagnosaTransDTQuery("ndtQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(NursingDiagnosaTransDTQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new NursingDiagnosaTransDTQuery("ndtQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(NursingDiagnosaTransDTQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((NursingDiagnosaTransDTQuery)query);
        }

        #endregion

        private NursingDiagnosaTransDTQuery query;
    }



    [Serializable]
    abstract public partial class esNursingDiagnosaTransDTQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return NursingDiagnosaTransDTMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "Id": return Id;
                case "TransactionNo": return TransactionNo;
                case "NursingDiagnosaID": return NursingDiagnosaID;
                case "NursingDiagnosaName": return NursingDiagnosaName;
                case "SRNursingDiagnosaLevel": return SRNursingDiagnosaLevel;
                case "NursingDiagnosaParentID": return NursingDiagnosaParentID;
                case "Priority": return Priority;
                case "Skala": return Skala;
                case "Target": return Target;
                case "Respond": return Respond;
                case "Evaluasi": return Evaluasi;
                case "Reexamine": return Reexamine;
                case "ExecuteDateTime": return ExecuteDateTime;
                case "CreateByUserID": return CreateByUserID;
                case "CreateDateTime": return CreateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "TmpNursingDiagnosaID": return TmpNursingDiagnosaID;
                case "TmpNursingDiagnosaParentID": return TmpNursingDiagnosaParentID;
                case "EvalPeriod": return EvalPeriod;
                case "PeriodConversionInHour": return PeriodConversionInHour;
                case "S": return S;
                case "O": return O;
                case "A": return A;
                case "SRNursingCarePlanning": return SRNursingCarePlanning;
                case "P": return P;
                case "ParentID": return ParentID;
                case "IsDeleted": return IsDeleted;
                case "ReferenceToPhrNo": return ReferenceToPhrNo;
                case "IsApproved": return IsApproved;
                case "ApprovedDatetime": return ApprovedDatetime;
                case "ApprovedByUserID": return ApprovedByUserID;
                case "IsPRMRJ": return IsPRMRJ;
                case "PpaInstruction": return PpaInstruction;
                case "SRUserType": return SRUserType;
                case "PrescriptionCurrentDay": return PrescriptionCurrentDay;
                case "SubmitBy": return SubmitBy;
                case "ReceiveBy": return ReceiveBy;
                case "SRNsType": return SRNsType;
                case "TemplateID": return TemplateID;
                case "Info5": return Info5;
                case "DpjpNotes": return DpjpNotes;
                case "ParamedicID": return ParamedicID;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem Id
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.Id, esSystemType.Int64); }
        }

        public esQueryItem TransactionNo
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.TransactionNo, esSystemType.String); }
        }

        public esQueryItem NursingDiagnosaID
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.NursingDiagnosaID, esSystemType.String); }
        }

        public esQueryItem NursingDiagnosaName
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.NursingDiagnosaName, esSystemType.String); }
        }

        public esQueryItem SRNursingDiagnosaLevel
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.SRNursingDiagnosaLevel, esSystemType.String); }
        }

        public esQueryItem NursingDiagnosaParentID
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.NursingDiagnosaParentID, esSystemType.String); }
        }

        public esQueryItem Priority
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.Priority, esSystemType.Int32); }
        }

        public esQueryItem Skala
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.Skala, esSystemType.Int32); }
        }

        public esQueryItem Target
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.Target, esSystemType.Int32); }
        }

        public esQueryItem Respond
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.Respond, esSystemType.String); }
        }

        public esQueryItem Evaluasi
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.Evaluasi, esSystemType.Int32); }
        }

        public esQueryItem Reexamine
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.Reexamine, esSystemType.Boolean); }
        }

        public esQueryItem ExecuteDateTime
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.ExecuteDateTime, esSystemType.DateTime); }
        }

        public esQueryItem CreateByUserID
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.CreateByUserID, esSystemType.String); }
        }

        public esQueryItem CreateDateTime
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.CreateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem TmpNursingDiagnosaID
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.TmpNursingDiagnosaID, esSystemType.String); }
        }

        public esQueryItem TmpNursingDiagnosaParentID
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.TmpNursingDiagnosaParentID, esSystemType.String); }
        }

        public esQueryItem EvalPeriod
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.EvalPeriod, esSystemType.Int32); }
        }

        public esQueryItem PeriodConversionInHour
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.PeriodConversionInHour, esSystemType.Int32); }
        }

        public esQueryItem S
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.S, esSystemType.String); }
        }

        public esQueryItem O
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.O, esSystemType.String); }
        }

        public esQueryItem A
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.A, esSystemType.String); }
        }

        public esQueryItem SRNursingCarePlanning
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.SRNursingCarePlanning, esSystemType.String); }
        }

        public esQueryItem P
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.P, esSystemType.String); }
        }

        public esQueryItem ParentID
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.ParentID, esSystemType.Int64); }
        }

        public esQueryItem IsDeleted
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.IsDeleted, esSystemType.Boolean); }
        }

        public esQueryItem ReferenceToPhrNo
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.ReferenceToPhrNo, esSystemType.String); }
        }

        public esQueryItem IsApproved
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.IsApproved, esSystemType.Boolean); }
        }

        public esQueryItem ApprovedDatetime
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.ApprovedDatetime, esSystemType.DateTime); }
        }

        public esQueryItem ApprovedByUserID
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.ApprovedByUserID, esSystemType.String); }
        }

        public esQueryItem IsPRMRJ
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.IsPRMRJ, esSystemType.Boolean); }
        }

        public esQueryItem PpaInstruction
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.PpaInstruction, esSystemType.String); }
        }

        public esQueryItem SRUserType
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.SRUserType, esSystemType.String); }
        }

        public esQueryItem PrescriptionCurrentDay
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.PrescriptionCurrentDay, esSystemType.String); }
        }

        public esQueryItem SubmitBy
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.SubmitBy, esSystemType.String); }
        }

        public esQueryItem ReceiveBy
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.ReceiveBy, esSystemType.String); }
        }

        public esQueryItem SRNsType
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.SRNsType, esSystemType.String); }
        }

        public esQueryItem TemplateID
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.TemplateID, esSystemType.Int32); }
        }

        public esQueryItem Info5
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.Info5, esSystemType.String); }
        }

        public esQueryItem DpjpNotes
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.DpjpNotes, esSystemType.String); }
        }

        public esQueryItem ParamedicID
        {
            get { return new esQueryItem(this, NursingDiagnosaTransDTMetadata.ColumnNames.ParamedicID, esSystemType.String); }
        }

        #endregion

    }



    [Serializable]
    public partial class NursingDiagnosaTransDTMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected NursingDiagnosaTransDTMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.Id, 0, typeof(long), esSystemType.Int64);
            c.PropertyName = PropertyNames.Id;
            c.IsInPrimaryKey = true;
            c.IsAutoIncrement = true;
            c.NumericPrecision = 19;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TransactionNo, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TransactionNo;
            c.CharacterMaxLength = 20;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.NursingDiagnosaID, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.NursingDiagnosaID;
            c.CharacterMaxLength = 20;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.NursingDiagnosaName, 3, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.NursingDiagnosaName;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRNursingDiagnosaLevel, 4, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRNursingDiagnosaLevel;
            c.CharacterMaxLength = 20;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.NursingDiagnosaParentID, 5, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.NursingDiagnosaParentID;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Priority, 6, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.Priority;
            c.NumericPrecision = 10;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Skala, 7, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.Skala;
            c.NumericPrecision = 10;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Target, 8, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.Target;
            c.NumericPrecision = 10;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Respond, 9, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Respond;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Evaluasi, 10, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.Evaluasi;
            c.NumericPrecision = 10;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Reexamine, 11, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.Reexamine;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ExecuteDateTime, 12, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.ExecuteDateTime;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreateByUserID, 13, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.CreateByUserID;
            c.CharacterMaxLength = 15;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreateDateTime, 14, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.CreateDateTime;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 15, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 15;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 16, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TmpNursingDiagnosaID, 17, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TmpNursingDiagnosaID;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TmpNursingDiagnosaParentID, 18, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TmpNursingDiagnosaParentID;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.EvalPeriod, 19, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.EvalPeriod;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PeriodConversionInHour, 20, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.PeriodConversionInHour;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.S, 21, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.S;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.O, 22, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.O;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.A, 23, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.A;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRNursingCarePlanning, 24, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRNursingCarePlanning;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.P, 25, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.P;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParentID, 26, typeof(long), esSystemType.Int64);
            c.PropertyName = PropertyNames.ParentID;
            c.NumericPrecision = 19;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsDeleted, 27, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsDeleted;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ReferenceToPhrNo, 28, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ReferenceToPhrNo;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsApproved, 29, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsApproved;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ApprovedDatetime, 30, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.ApprovedDatetime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ApprovedByUserID, 31, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ApprovedByUserID;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsPRMRJ, 32, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsPRMRJ;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PpaInstruction, 33, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PpaInstruction;
            c.CharacterMaxLength = 4000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRUserType, 34, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRUserType;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PrescriptionCurrentDay, 35, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PrescriptionCurrentDay;
            c.CharacterMaxLength = 4000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SubmitBy, 36, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SubmitBy;
            c.CharacterMaxLength = 200;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ReceiveBy, 37, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ReceiveBy;
            c.CharacterMaxLength = 200;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRNsType, 38, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRNsType;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TemplateID, 39, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.TemplateID;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Info5, 40, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Info5;
            c.CharacterMaxLength = 4000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DpjpNotes, 41, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.DpjpNotes;
            c.CharacterMaxLength = 4000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParamedicID, 42, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParamedicID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public NursingDiagnosaTransDTMetadata Meta()
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
            public const string Id = "ID";
            public const string TransactionNo = "TransactionNo";
            public const string NursingDiagnosaID = "NursingDiagnosaID";
            public const string NursingDiagnosaName = "NursingDiagnosaName";
            public const string SRNursingDiagnosaLevel = "SRNursingDiagnosaLevel";
            public const string NursingDiagnosaParentID = "NursingDiagnosaParentID";
            public const string Priority = "Priority";
            public const string Skala = "Skala";
            public const string Target = "Target";
            public const string Respond = "Respond";
            public const string Evaluasi = "Evaluasi";
            public const string Reexamine = "Reexamine";
            public const string ExecuteDateTime = "ExecuteDateTime";
            public const string CreateByUserID = "CreateByUserID";
            public const string CreateDateTime = "CreateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string TmpNursingDiagnosaID = "TmpNursingDiagnosaID";
            public const string TmpNursingDiagnosaParentID = "TmpNursingDiagnosaParentID";
            public const string EvalPeriod = "EvalPeriod";
            public const string PeriodConversionInHour = "PeriodConversionInHour";
            public const string S = "S";
            public const string O = "O";
            public const string A = "A";
            public const string SRNursingCarePlanning = "SRNursingCarePlanning";
            public const string P = "P";
            public const string ParentID = "ParentID";
            public const string IsDeleted = "IsDeleted";
            public const string ReferenceToPhrNo = "ReferenceToPhrNo";
            public const string IsApproved = "IsApproved";
            public const string ApprovedDatetime = "ApprovedDatetime";
            public const string ApprovedByUserID = "ApprovedByUserID";
            public const string IsPRMRJ = "IsPRMRJ";
            public const string PpaInstruction = "PpaInstruction";
            public const string SRUserType = "SRUserType";
            public const string PrescriptionCurrentDay = "PrescriptionCurrentDay";
            public const string SubmitBy = "SubmitBy";
            public const string ReceiveBy = "ReceiveBy";
            public const string SRNsType = "SRNsType";
            public const string TemplateID = "TemplateID";
            public const string Info5 = "Info5";
            public const string DpjpNotes = "DpjpNotes";
            public const string ParamedicID = "ParamedicID";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string Id = "Id";
            public const string TransactionNo = "TransactionNo";
            public const string NursingDiagnosaID = "NursingDiagnosaID";
            public const string NursingDiagnosaName = "NursingDiagnosaName";
            public const string SRNursingDiagnosaLevel = "SRNursingDiagnosaLevel";
            public const string NursingDiagnosaParentID = "NursingDiagnosaParentID";
            public const string Priority = "Priority";
            public const string Skala = "Skala";
            public const string Target = "Target";
            public const string Respond = "Respond";
            public const string Evaluasi = "Evaluasi";
            public const string Reexamine = "Reexamine";
            public const string ExecuteDateTime = "ExecuteDateTime";
            public const string CreateByUserID = "CreateByUserID";
            public const string CreateDateTime = "CreateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string TmpNursingDiagnosaID = "TmpNursingDiagnosaID";
            public const string TmpNursingDiagnosaParentID = "TmpNursingDiagnosaParentID";
            public const string EvalPeriod = "EvalPeriod";
            public const string PeriodConversionInHour = "PeriodConversionInHour";
            public const string S = "S";
            public const string O = "O";
            public const string A = "A";
            public const string SRNursingCarePlanning = "SRNursingCarePlanning";
            public const string P = "P";
            public const string ParentID = "ParentID";
            public const string IsDeleted = "IsDeleted";
            public const string ReferenceToPhrNo = "ReferenceToPhrNo";
            public const string IsApproved = "IsApproved";
            public const string ApprovedDatetime = "ApprovedDatetime";
            public const string ApprovedByUserID = "ApprovedByUserID";
            public const string IsPRMRJ = "IsPRMRJ";
            public const string PpaInstruction = "PpaInstruction";
            public const string SRUserType = "SRUserType";
            public const string PrescriptionCurrentDay = "PrescriptionCurrentDay";
            public const string SubmitBy = "SubmitBy";
            public const string ReceiveBy = "ReceiveBy";
            public const string SRNsType = "SRNsType";
            public const string TemplateID = "TemplateID";
            public const string Info5 = "Info5";
            public const string DpjpNotes = "DpjpNotes";
            public const string ParamedicID = "ParamedicID";
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
            lock (typeof(NursingDiagnosaTransDTMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new NursingDiagnosaTransDTMetadata();
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


                meta.AddTypeMap("Id", new esTypeMap("bigint", "System.Int64"));
                meta.AddTypeMap("TransactionNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("NursingDiagnosaID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("NursingDiagnosaName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRNursingDiagnosaLevel", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("NursingDiagnosaParentID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Priority", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("Skala", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("Target", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("Respond", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Evaluasi", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("Reexamine", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ExecuteDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("CreateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CreateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("TmpNursingDiagnosaID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TmpNursingDiagnosaParentID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("EvalPeriod", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("PeriodConversionInHour", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("S", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("O", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("A", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRNursingCarePlanning", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("P", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ParentID", new esTypeMap("bigint", "System.Int64"));
                meta.AddTypeMap("IsDeleted", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ReferenceToPhrNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsApproved", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ApprovedDatetime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("ApprovedByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsPRMRJ", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("PpaInstruction", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRUserType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PrescriptionCurrentDay", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SubmitBy", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ReceiveBy", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRNsType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TemplateID", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("Info5", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("DpjpNotes", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ParamedicID", new esTypeMap("varchar", "System.String"));



                meta.Source = "NursingDiagnosaTransDT";
                meta.Destination = "NursingDiagnosaTransDT";

                meta.spInsert = "proc_NursingDiagnosaTransDTInsert";
                meta.spUpdate = "proc_NursingDiagnosaTransDTUpdate";
                meta.spDelete = "proc_NursingDiagnosaTransDTDelete";
                meta.spLoadAll = "proc_NursingDiagnosaTransDTLoadAll";
                meta.spLoadByPrimaryKey = "proc_NursingDiagnosaTransDTLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private NursingDiagnosaTransDTMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
