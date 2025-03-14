
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 3/14/2025 9:03:51 AM
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
    /// Encapsulates the 'ParamedicConsultRefer' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(ParamedicConsultRefer))]
    [XmlType("ParamedicConsultRefer")]
    public partial class ParamedicConsultRefer : esParamedicConsultRefer
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new ParamedicConsultRefer();
        }

        #region Static Quick Access Methods
        static public void Delete(string consultReferNo)
        {
            var obj = new ParamedicConsultRefer();
            obj.ConsultReferNo = consultReferNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string consultReferNo, esSqlAccessType sqlAccessType)
        {
            var obj = new ParamedicConsultRefer();
            obj.ConsultReferNo = consultReferNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("ParamedicConsultReferCollection")]
    public partial class ParamedicConsultReferCollection : esParamedicConsultReferCollection, IEnumerable<ParamedicConsultRefer>
    {
        public ParamedicConsultRefer FindByPrimaryKey(string consultReferNo)
        {
            return this.SingleOrDefault(e => e.ConsultReferNo == consultReferNo);
        }



    }



    [Serializable]
    public partial class ParamedicConsultReferQuery : esParamedicConsultReferQuery
    {
        public ParamedicConsultReferQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public ParamedicConsultReferQuery(string joinAlias, out ParamedicConsultReferQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "ParamedicConsultReferQuery";
        }



        #region Explicit Casts

        public static explicit operator string(ParamedicConsultReferQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator ParamedicConsultReferQuery(string query)
        {
            return (ParamedicConsultReferQuery)SerializeHelper.FromXml(query, typeof(ParamedicConsultReferQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esParamedicConsultRefer : esEntity
    {
        public esParamedicConsultRefer()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string consultReferNo)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(consultReferNo);
            else
                return LoadByPrimaryKeyStoredProcedure(consultReferNo);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string consultReferNo)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(consultReferNo);
            else
                return LoadByPrimaryKeyStoredProcedure(consultReferNo);
        }

        private bool LoadByPrimaryKeyDynamic(string consultReferNo)
        {
            ParamedicConsultReferQuery query = new ParamedicConsultReferQuery("pcrQ");
            query.Where(query.ConsultReferNo == consultReferNo);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string consultReferNo)
        {
            esParameters parms = new esParameters();
            parms.Add("ConsultReferNo", consultReferNo);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to ParamedicConsultRefer.ConsultReferNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ConsultReferNo
        {
            get
            {
                return GetSystemString(ParamedicConsultReferMetadata.ColumnNames.ConsultReferNo);
            }

            set
            {
                if (SetSystemString(ParamedicConsultReferMetadata.ColumnNames.ConsultReferNo, value))
                {
                    OnPropertyChanged(ParamedicConsultReferMetadata.PropertyNames.ConsultReferNo);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicConsultRefer.ConsultDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? ConsultDateTime
        {
            get
            {
                return GetSystemDateTime(ParamedicConsultReferMetadata.ColumnNames.ConsultDateTime);
            }

            set
            {
                if (SetSystemDateTime(ParamedicConsultReferMetadata.ColumnNames.ConsultDateTime, value))
                {
                    OnPropertyChanged(ParamedicConsultReferMetadata.PropertyNames.ConsultDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicConsultRefer.RegistrationNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string RegistrationNo
        {
            get
            {
                return GetSystemString(ParamedicConsultReferMetadata.ColumnNames.RegistrationNo);
            }

            set
            {
                if (SetSystemString(ParamedicConsultReferMetadata.ColumnNames.RegistrationNo, value))
                {
                    OnPropertyChanged(ParamedicConsultReferMetadata.PropertyNames.RegistrationNo);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicConsultRefer.ParamedicID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParamedicID
        {
            get
            {
                return GetSystemString(ParamedicConsultReferMetadata.ColumnNames.ParamedicID);
            }

            set
            {
                if (SetSystemString(ParamedicConsultReferMetadata.ColumnNames.ParamedicID, value))
                {
                    OnPropertyChanged(ParamedicConsultReferMetadata.PropertyNames.ParamedicID);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicConsultRefer.SRParamedicConsultType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRParamedicConsultType
        {
            get
            {
                return GetSystemString(ParamedicConsultReferMetadata.ColumnNames.SRParamedicConsultType);
            }

            set
            {
                if (SetSystemString(ParamedicConsultReferMetadata.ColumnNames.SRParamedicConsultType, value))
                {
                    OnPropertyChanged(ParamedicConsultReferMetadata.PropertyNames.SRParamedicConsultType);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicConsultRefer.ConsultReferType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public char? ConsultReferType
        {
            get
            {
                return GetSystemChar(ParamedicConsultReferMetadata.ColumnNames.ConsultReferType);
            }

            set
            {
                if (SetSystemChar(ParamedicConsultReferMetadata.ColumnNames.ConsultReferType, value))
                {
                    OnPropertyChanged(ParamedicConsultReferMetadata.PropertyNames.ConsultReferType);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicConsultRefer.ToServiceUnitID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ToServiceUnitID
        {
            get
            {
                return GetSystemString(ParamedicConsultReferMetadata.ColumnNames.ToServiceUnitID);
            }

            set
            {
                if (SetSystemString(ParamedicConsultReferMetadata.ColumnNames.ToServiceUnitID, value))
                {
                    OnPropertyChanged(ParamedicConsultReferMetadata.PropertyNames.ToServiceUnitID);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicConsultRefer.ToParamedicID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ToParamedicID
        {
            get
            {
                return GetSystemString(ParamedicConsultReferMetadata.ColumnNames.ToParamedicID);
            }

            set
            {
                if (SetSystemString(ParamedicConsultReferMetadata.ColumnNames.ToParamedicID, value))
                {
                    OnPropertyChanged(ParamedicConsultReferMetadata.PropertyNames.ToParamedicID);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicConsultRefer.ToRoomID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ToRoomID
        {
            get
            {
                return GetSystemString(ParamedicConsultReferMetadata.ColumnNames.ToRoomID);
            }

            set
            {
                if (SetSystemString(ParamedicConsultReferMetadata.ColumnNames.ToRoomID, value))
                {
                    OnPropertyChanged(ParamedicConsultReferMetadata.PropertyNames.ToRoomID);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicConsultRefer.ToRegistrationQue
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? ToRegistrationQue
        {
            get
            {
                return GetSystemInt32(ParamedicConsultReferMetadata.ColumnNames.ToRegistrationQue);
            }

            set
            {
                if (SetSystemInt32(ParamedicConsultReferMetadata.ColumnNames.ToRegistrationQue, value))
                {
                    OnPropertyChanged(ParamedicConsultReferMetadata.PropertyNames.ToRegistrationQue);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicConsultRefer.ChiefComplaint
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ChiefComplaint
        {
            get
            {
                return GetSystemString(ParamedicConsultReferMetadata.ColumnNames.ChiefComplaint);
            }

            set
            {
                if (SetSystemString(ParamedicConsultReferMetadata.ColumnNames.ChiefComplaint, value))
                {
                    OnPropertyChanged(ParamedicConsultReferMetadata.PropertyNames.ChiefComplaint);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicConsultRefer.PastMedicalHistory
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PastMedicalHistory
        {
            get
            {
                return GetSystemString(ParamedicConsultReferMetadata.ColumnNames.PastMedicalHistory);
            }

            set
            {
                if (SetSystemString(ParamedicConsultReferMetadata.ColumnNames.PastMedicalHistory, value))
                {
                    OnPropertyChanged(ParamedicConsultReferMetadata.PropertyNames.PastMedicalHistory);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicConsultRefer.Hpi
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Hpi
        {
            get
            {
                return GetSystemString(ParamedicConsultReferMetadata.ColumnNames.Hpi);
            }

            set
            {
                if (SetSystemString(ParamedicConsultReferMetadata.ColumnNames.Hpi, value))
                {
                    OnPropertyChanged(ParamedicConsultReferMetadata.PropertyNames.Hpi);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicConsultRefer.ActionExamTreatment
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ActionExamTreatment
        {
            get
            {
                return GetSystemString(ParamedicConsultReferMetadata.ColumnNames.ActionExamTreatment);
            }

            set
            {
                if (SetSystemString(ParamedicConsultReferMetadata.ColumnNames.ActionExamTreatment, value))
                {
                    OnPropertyChanged(ParamedicConsultReferMetadata.PropertyNames.ActionExamTreatment);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicConsultRefer.ActiveMotion
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ActiveMotion
        {
            get
            {
                return GetSystemString(ParamedicConsultReferMetadata.ColumnNames.ActiveMotion);
            }

            set
            {
                if (SetSystemString(ParamedicConsultReferMetadata.ColumnNames.ActiveMotion, value))
                {
                    OnPropertyChanged(ParamedicConsultReferMetadata.PropertyNames.ActiveMotion);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicConsultRefer.PassiveMotion
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PassiveMotion
        {
            get
            {
                return GetSystemString(ParamedicConsultReferMetadata.ColumnNames.PassiveMotion);
            }

            set
            {
                if (SetSystemString(ParamedicConsultReferMetadata.ColumnNames.PassiveMotion, value))
                {
                    OnPropertyChanged(ParamedicConsultReferMetadata.PropertyNames.PassiveMotion);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicConsultRefer.Notes
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Notes
        {
            get
            {
                return GetSystemString(ParamedicConsultReferMetadata.ColumnNames.Notes);
            }

            set
            {
                if (SetSystemString(ParamedicConsultReferMetadata.ColumnNames.Notes, value))
                {
                    OnPropertyChanged(ParamedicConsultReferMetadata.PropertyNames.Notes);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicConsultRefer.AnswerDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? AnswerDateTime
        {
            get
            {
                return GetSystemDateTime(ParamedicConsultReferMetadata.ColumnNames.AnswerDateTime);
            }

            set
            {
                if (SetSystemDateTime(ParamedicConsultReferMetadata.ColumnNames.AnswerDateTime, value))
                {
                    OnPropertyChanged(ParamedicConsultReferMetadata.PropertyNames.AnswerDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicConsultRefer.Answer
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Answer
        {
            get
            {
                return GetSystemString(ParamedicConsultReferMetadata.ColumnNames.Answer);
            }

            set
            {
                if (SetSystemString(ParamedicConsultReferMetadata.ColumnNames.Answer, value))
                {
                    OnPropertyChanged(ParamedicConsultReferMetadata.PropertyNames.Answer);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicConsultRefer.AnswerDiagnose
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string AnswerDiagnose
        {
            get
            {
                return GetSystemString(ParamedicConsultReferMetadata.ColumnNames.AnswerDiagnose);
            }

            set
            {
                if (SetSystemString(ParamedicConsultReferMetadata.ColumnNames.AnswerDiagnose, value))
                {
                    OnPropertyChanged(ParamedicConsultReferMetadata.PropertyNames.AnswerDiagnose);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicConsultRefer.AnswerPlan
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string AnswerPlan
        {
            get
            {
                return GetSystemString(ParamedicConsultReferMetadata.ColumnNames.AnswerPlan);
            }

            set
            {
                if (SetSystemString(ParamedicConsultReferMetadata.ColumnNames.AnswerPlan, value))
                {
                    OnPropertyChanged(ParamedicConsultReferMetadata.PropertyNames.AnswerPlan);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicConsultRefer.AnswerAction
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string AnswerAction
        {
            get
            {
                return GetSystemString(ParamedicConsultReferMetadata.ColumnNames.AnswerAction);
            }

            set
            {
                if (SetSystemString(ParamedicConsultReferMetadata.ColumnNames.AnswerAction, value))
                {
                    OnPropertyChanged(ParamedicConsultReferMetadata.PropertyNames.AnswerAction);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicConsultRefer.ToRegistrationNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ToRegistrationNo
        {
            get
            {
                return GetSystemString(ParamedicConsultReferMetadata.ColumnNames.ToRegistrationNo);
            }

            set
            {
                if (SetSystemString(ParamedicConsultReferMetadata.ColumnNames.ToRegistrationNo, value))
                {
                    OnPropertyChanged(ParamedicConsultReferMetadata.PropertyNames.ToRegistrationNo);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicConsultRefer.ToAppointmentNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ToAppointmentNo
        {
            get
            {
                return GetSystemString(ParamedicConsultReferMetadata.ColumnNames.ToAppointmentNo);
            }

            set
            {
                if (SetSystemString(ParamedicConsultReferMetadata.ColumnNames.ToAppointmentNo, value))
                {
                    OnPropertyChanged(ParamedicConsultReferMetadata.PropertyNames.ToAppointmentNo);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicConsultRefer.IsPhysiotherapy
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsPhysiotherapy
        {
            get
            {
                return GetSystemBoolean(ParamedicConsultReferMetadata.ColumnNames.IsPhysiotherapy);
            }

            set
            {
                if (SetSystemBoolean(ParamedicConsultReferMetadata.ColumnNames.IsPhysiotherapy, value))
                {
                    OnPropertyChanged(ParamedicConsultReferMetadata.PropertyNames.IsPhysiotherapy);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicConsultRefer.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(ParamedicConsultReferMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(ParamedicConsultReferMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(ParamedicConsultReferMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicConsultRefer.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(ParamedicConsultReferMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(ParamedicConsultReferMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(ParamedicConsultReferMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicConsultRefer.PatientID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PatientID
        {
            get
            {
                return GetSystemString(ParamedicConsultReferMetadata.ColumnNames.PatientID);
            }

            set
            {
                if (SetSystemString(ParamedicConsultReferMetadata.ColumnNames.PatientID, value))
                {
                    OnPropertyChanged(ParamedicConsultReferMetadata.PropertyNames.PatientID);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicConsultRefer.SRConsultAnswerType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRConsultAnswerType
        {
            get
            {
                return GetSystemString(ParamedicConsultReferMetadata.ColumnNames.SRConsultAnswerType);
            }

            set
            {
                if (SetSystemString(ParamedicConsultReferMetadata.ColumnNames.SRConsultAnswerType, value))
                {
                    OnPropertyChanged(ParamedicConsultReferMetadata.PropertyNames.SRConsultAnswerType);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicConsultRefer.IsVoid
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsVoid
        {
            get
            {
                return GetSystemBoolean(ParamedicConsultReferMetadata.ColumnNames.IsVoid);
            }

            set
            {
                if (SetSystemBoolean(ParamedicConsultReferMetadata.ColumnNames.IsVoid, value))
                {
                    OnPropertyChanged(ParamedicConsultReferMetadata.PropertyNames.IsVoid);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicConsultRefer.CreateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? CreateDateTime
        {
            get
            {
                return GetSystemDateTime(ParamedicConsultReferMetadata.ColumnNames.CreateDateTime);
            }

            set
            {
                if (SetSystemDateTime(ParamedicConsultReferMetadata.ColumnNames.CreateDateTime, value))
                {
                    OnPropertyChanged(ParamedicConsultReferMetadata.PropertyNames.CreateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicConsultRefer.CreateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string CreateByUserID
        {
            get
            {
                return GetSystemString(ParamedicConsultReferMetadata.ColumnNames.CreateByUserID);
            }

            set
            {
                if (SetSystemString(ParamedicConsultReferMetadata.ColumnNames.CreateByUserID, value))
                {
                    OnPropertyChanged(ParamedicConsultReferMetadata.PropertyNames.CreateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicConsultRefer.PhysicianSign
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public byte[] PhysicianSign
        {
            get
            {
                return GetSystemByteArray(ParamedicConsultReferMetadata.ColumnNames.PhysicianSign);
            }

            set
            {
                if (SetSystemByteArray(ParamedicConsultReferMetadata.ColumnNames.PhysicianSign, value))
                {
                    OnPropertyChanged(ParamedicConsultReferMetadata.PropertyNames.PhysicianSign);
                }
            }
        }

        /// <summary>
        /// Maps to ParamedicConsultRefer.PhysicianAnswerSign
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public byte[] PhysicianAnswerSign
        {
            get
            {
                return GetSystemByteArray(ParamedicConsultReferMetadata.ColumnNames.PhysicianAnswerSign);
            }

            set
            {
                if (SetSystemByteArray(ParamedicConsultReferMetadata.ColumnNames.PhysicianAnswerSign, value))
                {
                    OnPropertyChanged(ParamedicConsultReferMetadata.PropertyNames.PhysicianAnswerSign);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return ParamedicConsultReferMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public ParamedicConsultReferQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new ParamedicConsultReferQuery("pcrQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(ParamedicConsultReferQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(ParamedicConsultReferQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((ParamedicConsultReferQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private ParamedicConsultReferQuery query;
    }



    [Serializable]
    abstract public partial class esParamedicConsultReferCollection : esEntityCollection<ParamedicConsultRefer>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return ParamedicConsultReferMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "ParamedicConsultReferCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public ParamedicConsultReferQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new ParamedicConsultReferQuery("pcrQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(ParamedicConsultReferQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new ParamedicConsultReferQuery("pcrQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(ParamedicConsultReferQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((ParamedicConsultReferQuery)query);
        }

        #endregion

        private ParamedicConsultReferQuery query;
    }



    [Serializable]
    abstract public partial class esParamedicConsultReferQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return ParamedicConsultReferMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "ConsultReferNo": return ConsultReferNo;
                case "ConsultDateTime": return ConsultDateTime;
                case "RegistrationNo": return RegistrationNo;
                case "ParamedicID": return ParamedicID;
                case "SRParamedicConsultType": return SRParamedicConsultType;
                case "ConsultReferType": return ConsultReferType;
                case "ToServiceUnitID": return ToServiceUnitID;
                case "ToParamedicID": return ToParamedicID;
                case "ToRoomID": return ToRoomID;
                case "ToRegistrationQue": return ToRegistrationQue;
                case "ChiefComplaint": return ChiefComplaint;
                case "PastMedicalHistory": return PastMedicalHistory;
                case "Hpi": return Hpi;
                case "ActionExamTreatment": return ActionExamTreatment;
                case "ActiveMotion": return ActiveMotion;
                case "PassiveMotion": return PassiveMotion;
                case "Notes": return Notes;
                case "AnswerDateTime": return AnswerDateTime;
                case "Answer": return Answer;
                case "AnswerDiagnose": return AnswerDiagnose;
                case "AnswerPlan": return AnswerPlan;
                case "AnswerAction": return AnswerAction;
                case "ToRegistrationNo": return ToRegistrationNo;
                case "ToAppointmentNo": return ToAppointmentNo;
                case "IsPhysiotherapy": return IsPhysiotherapy;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "PatientID": return PatientID;
                case "SRConsultAnswerType": return SRConsultAnswerType;
                case "IsVoid": return IsVoid;
                case "CreateDateTime": return CreateDateTime;
                case "CreateByUserID": return CreateByUserID;
                case "PhysicianSign": return PhysicianSign;
                case "PhysicianAnswerSign": return PhysicianAnswerSign;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem ConsultReferNo
        {
            get { return new esQueryItem(this, ParamedicConsultReferMetadata.ColumnNames.ConsultReferNo, esSystemType.String); }
        }

        public esQueryItem ConsultDateTime
        {
            get { return new esQueryItem(this, ParamedicConsultReferMetadata.ColumnNames.ConsultDateTime, esSystemType.DateTime); }
        }

        public esQueryItem RegistrationNo
        {
            get { return new esQueryItem(this, ParamedicConsultReferMetadata.ColumnNames.RegistrationNo, esSystemType.String); }
        }

        public esQueryItem ParamedicID
        {
            get { return new esQueryItem(this, ParamedicConsultReferMetadata.ColumnNames.ParamedicID, esSystemType.String); }
        }

        public esQueryItem SRParamedicConsultType
        {
            get { return new esQueryItem(this, ParamedicConsultReferMetadata.ColumnNames.SRParamedicConsultType, esSystemType.String); }
        }

        public esQueryItem ConsultReferType
        {
            get { return new esQueryItem(this, ParamedicConsultReferMetadata.ColumnNames.ConsultReferType, esSystemType.Char); }
        }

        public esQueryItem ToServiceUnitID
        {
            get { return new esQueryItem(this, ParamedicConsultReferMetadata.ColumnNames.ToServiceUnitID, esSystemType.String); }
        }

        public esQueryItem ToParamedicID
        {
            get { return new esQueryItem(this, ParamedicConsultReferMetadata.ColumnNames.ToParamedicID, esSystemType.String); }
        }

        public esQueryItem ToRoomID
        {
            get { return new esQueryItem(this, ParamedicConsultReferMetadata.ColumnNames.ToRoomID, esSystemType.String); }
        }

        public esQueryItem ToRegistrationQue
        {
            get { return new esQueryItem(this, ParamedicConsultReferMetadata.ColumnNames.ToRegistrationQue, esSystemType.Int32); }
        }

        public esQueryItem ChiefComplaint
        {
            get { return new esQueryItem(this, ParamedicConsultReferMetadata.ColumnNames.ChiefComplaint, esSystemType.String); }
        }

        public esQueryItem PastMedicalHistory
        {
            get { return new esQueryItem(this, ParamedicConsultReferMetadata.ColumnNames.PastMedicalHistory, esSystemType.String); }
        }

        public esQueryItem Hpi
        {
            get { return new esQueryItem(this, ParamedicConsultReferMetadata.ColumnNames.Hpi, esSystemType.String); }
        }

        public esQueryItem ActionExamTreatment
        {
            get { return new esQueryItem(this, ParamedicConsultReferMetadata.ColumnNames.ActionExamTreatment, esSystemType.String); }
        }

        public esQueryItem ActiveMotion
        {
            get { return new esQueryItem(this, ParamedicConsultReferMetadata.ColumnNames.ActiveMotion, esSystemType.String); }
        }

        public esQueryItem PassiveMotion
        {
            get { return new esQueryItem(this, ParamedicConsultReferMetadata.ColumnNames.PassiveMotion, esSystemType.String); }
        }

        public esQueryItem Notes
        {
            get { return new esQueryItem(this, ParamedicConsultReferMetadata.ColumnNames.Notes, esSystemType.String); }
        }

        public esQueryItem AnswerDateTime
        {
            get { return new esQueryItem(this, ParamedicConsultReferMetadata.ColumnNames.AnswerDateTime, esSystemType.DateTime); }
        }

        public esQueryItem Answer
        {
            get { return new esQueryItem(this, ParamedicConsultReferMetadata.ColumnNames.Answer, esSystemType.String); }
        }

        public esQueryItem AnswerDiagnose
        {
            get { return new esQueryItem(this, ParamedicConsultReferMetadata.ColumnNames.AnswerDiagnose, esSystemType.String); }
        }

        public esQueryItem AnswerPlan
        {
            get { return new esQueryItem(this, ParamedicConsultReferMetadata.ColumnNames.AnswerPlan, esSystemType.String); }
        }

        public esQueryItem AnswerAction
        {
            get { return new esQueryItem(this, ParamedicConsultReferMetadata.ColumnNames.AnswerAction, esSystemType.String); }
        }

        public esQueryItem ToRegistrationNo
        {
            get { return new esQueryItem(this, ParamedicConsultReferMetadata.ColumnNames.ToRegistrationNo, esSystemType.String); }
        }

        public esQueryItem ToAppointmentNo
        {
            get { return new esQueryItem(this, ParamedicConsultReferMetadata.ColumnNames.ToAppointmentNo, esSystemType.String); }
        }

        public esQueryItem IsPhysiotherapy
        {
            get { return new esQueryItem(this, ParamedicConsultReferMetadata.ColumnNames.IsPhysiotherapy, esSystemType.Boolean); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, ParamedicConsultReferMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, ParamedicConsultReferMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem PatientID
        {
            get { return new esQueryItem(this, ParamedicConsultReferMetadata.ColumnNames.PatientID, esSystemType.String); }
        }

        public esQueryItem SRConsultAnswerType
        {
            get { return new esQueryItem(this, ParamedicConsultReferMetadata.ColumnNames.SRConsultAnswerType, esSystemType.String); }
        }

        public esQueryItem IsVoid
        {
            get { return new esQueryItem(this, ParamedicConsultReferMetadata.ColumnNames.IsVoid, esSystemType.Boolean); }
        }

        public esQueryItem CreateDateTime
        {
            get { return new esQueryItem(this, ParamedicConsultReferMetadata.ColumnNames.CreateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem CreateByUserID
        {
            get { return new esQueryItem(this, ParamedicConsultReferMetadata.ColumnNames.CreateByUserID, esSystemType.String); }
        }

        public esQueryItem PhysicianSign
        {
            get { return new esQueryItem(this, ParamedicConsultReferMetadata.ColumnNames.PhysicianSign, esSystemType.ByteArray); }
        }

        public esQueryItem PhysicianAnswerSign
        {
            get { return new esQueryItem(this, ParamedicConsultReferMetadata.ColumnNames.PhysicianAnswerSign, esSystemType.ByteArray); }
        }

        #endregion

    }



    [Serializable]
    public partial class ParamedicConsultReferMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected ParamedicConsultReferMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.ConsultReferNo, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ConsultReferNo;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 25;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ConsultDateTime, 1, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.ConsultDateTime;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RegistrationNo, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.RegistrationNo;
            c.CharacterMaxLength = 20;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParamedicID, 3, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParamedicID;
            c.CharacterMaxLength = 10;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRParamedicConsultType, 4, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRParamedicConsultType;
            c.CharacterMaxLength = 3;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ConsultReferType, 5, typeof(char), esSystemType.Char);
            c.PropertyName = PropertyNames.ConsultReferType;
            c.CharacterMaxLength = 1;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ToServiceUnitID, 6, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ToServiceUnitID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ToParamedicID, 7, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ToParamedicID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ToRoomID, 8, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ToRoomID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ToRegistrationQue, 9, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.ToRegistrationQue;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ChiefComplaint, 10, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ChiefComplaint;
            c.CharacterMaxLength = 4000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PastMedicalHistory, 11, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PastMedicalHistory;
            c.CharacterMaxLength = 4000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Hpi, 12, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Hpi;
            c.CharacterMaxLength = 4000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ActionExamTreatment, 13, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ActionExamTreatment;
            c.CharacterMaxLength = 4000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ActiveMotion, 14, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ActiveMotion;
            c.CharacterMaxLength = 4000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PassiveMotion, 15, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PassiveMotion;
            c.CharacterMaxLength = 4000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Notes, 16, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Notes;
            c.CharacterMaxLength = 8000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AnswerDateTime, 17, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.AnswerDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Answer, 18, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Answer;
            c.CharacterMaxLength = 2000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AnswerDiagnose, 19, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.AnswerDiagnose;
            c.CharacterMaxLength = 1000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AnswerPlan, 20, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.AnswerPlan;
            c.CharacterMaxLength = 2000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AnswerAction, 21, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.AnswerAction;
            c.CharacterMaxLength = 2000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ToRegistrationNo, 22, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ToRegistrationNo;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ToAppointmentNo, 23, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ToAppointmentNo;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsPhysiotherapy, 24, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsPhysiotherapy;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 25, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 26, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PatientID, 27, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PatientID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRConsultAnswerType, 28, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRConsultAnswerType;
            c.CharacterMaxLength = 3;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsVoid, 29, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsVoid;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreateDateTime, 30, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.CreateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreateByUserID, 31, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.CreateByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PhysicianSign, 32, typeof(byte[]), esSystemType.ByteArray);
            c.PropertyName = PropertyNames.PhysicianSign;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PhysicianAnswerSign, 33, typeof(byte[]), esSystemType.ByteArray);
            c.PropertyName = PropertyNames.PhysicianAnswerSign;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public ParamedicConsultReferMetadata Meta()
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
            public const string ConsultReferNo = "ConsultReferNo";
            public const string ConsultDateTime = "ConsultDateTime";
            public const string RegistrationNo = "RegistrationNo";
            public const string ParamedicID = "ParamedicID";
            public const string SRParamedicConsultType = "SRParamedicConsultType";
            public const string ConsultReferType = "ConsultReferType";
            public const string ToServiceUnitID = "ToServiceUnitID";
            public const string ToParamedicID = "ToParamedicID";
            public const string ToRoomID = "ToRoomID";
            public const string ToRegistrationQue = "ToRegistrationQue";
            public const string ChiefComplaint = "ChiefComplaint";
            public const string PastMedicalHistory = "PastMedicalHistory";
            public const string Hpi = "Hpi";
            public const string ActionExamTreatment = "ActionExamTreatment";
            public const string ActiveMotion = "ActiveMotion";
            public const string PassiveMotion = "PassiveMotion";
            public const string Notes = "Notes";
            public const string AnswerDateTime = "AnswerDateTime";
            public const string Answer = "Answer";
            public const string AnswerDiagnose = "AnswerDiagnose";
            public const string AnswerPlan = "AnswerPlan";
            public const string AnswerAction = "AnswerAction";
            public const string ToRegistrationNo = "ToRegistrationNo";
            public const string ToAppointmentNo = "ToAppointmentNo";
            public const string IsPhysiotherapy = "IsPhysiotherapy";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string PatientID = "PatientID";
            public const string SRConsultAnswerType = "SRConsultAnswerType";
            public const string IsVoid = "IsVoid";
            public const string CreateDateTime = "CreateDateTime";
            public const string CreateByUserID = "CreateByUserID";
            public const string PhysicianSign = "PhysicianSign";
            public const string PhysicianAnswerSign = "PhysicianAnswerSign";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string ConsultReferNo = "ConsultReferNo";
            public const string ConsultDateTime = "ConsultDateTime";
            public const string RegistrationNo = "RegistrationNo";
            public const string ParamedicID = "ParamedicID";
            public const string SRParamedicConsultType = "SRParamedicConsultType";
            public const string ConsultReferType = "ConsultReferType";
            public const string ToServiceUnitID = "ToServiceUnitID";
            public const string ToParamedicID = "ToParamedicID";
            public const string ToRoomID = "ToRoomID";
            public const string ToRegistrationQue = "ToRegistrationQue";
            public const string ChiefComplaint = "ChiefComplaint";
            public const string PastMedicalHistory = "PastMedicalHistory";
            public const string Hpi = "Hpi";
            public const string ActionExamTreatment = "ActionExamTreatment";
            public const string ActiveMotion = "ActiveMotion";
            public const string PassiveMotion = "PassiveMotion";
            public const string Notes = "Notes";
            public const string AnswerDateTime = "AnswerDateTime";
            public const string Answer = "Answer";
            public const string AnswerDiagnose = "AnswerDiagnose";
            public const string AnswerPlan = "AnswerPlan";
            public const string AnswerAction = "AnswerAction";
            public const string ToRegistrationNo = "ToRegistrationNo";
            public const string ToAppointmentNo = "ToAppointmentNo";
            public const string IsPhysiotherapy = "IsPhysiotherapy";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string PatientID = "PatientID";
            public const string SRConsultAnswerType = "SRConsultAnswerType";
            public const string IsVoid = "IsVoid";
            public const string CreateDateTime = "CreateDateTime";
            public const string CreateByUserID = "CreateByUserID";
            public const string PhysicianSign = "PhysicianSign";
            public const string PhysicianAnswerSign = "PhysicianAnswerSign";
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
            lock (typeof(ParamedicConsultReferMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new ParamedicConsultReferMetadata();
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


                meta.AddTypeMap("ConsultReferNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ConsultDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("RegistrationNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ParamedicID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRParamedicConsultType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ConsultReferType", new esTypeMap("char", "System.Char"));
                meta.AddTypeMap("ToServiceUnitID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ToParamedicID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ToRoomID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ToRegistrationQue", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("ChiefComplaint", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PastMedicalHistory", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Hpi", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ActionExamTreatment", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ActiveMotion", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PassiveMotion", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Notes", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("AnswerDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("Answer", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("AnswerDiagnose", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("AnswerPlan", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("AnswerAction", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ToRegistrationNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ToAppointmentNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsPhysiotherapy", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PatientID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRConsultAnswerType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsVoid", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("CreateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("CreateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PhysicianSign", new esTypeMap("image", "System.Byte[]"));
                meta.AddTypeMap("PhysicianAnswerSign", new esTypeMap("image", "System.Byte[]"));



                meta.Source = "ParamedicConsultRefer";
                meta.Destination = "ParamedicConsultRefer";

                meta.spInsert = "proc_ParamedicConsultReferInsert";
                meta.spUpdate = "proc_ParamedicConsultReferUpdate";
                meta.spDelete = "proc_ParamedicConsultReferDelete";
                meta.spLoadAll = "proc_ParamedicConsultReferLoadAll";
                meta.spLoadByPrimaryKey = "proc_ParamedicConsultReferLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private ParamedicConsultReferMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
