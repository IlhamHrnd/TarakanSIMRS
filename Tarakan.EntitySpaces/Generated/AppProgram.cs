
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 3/12/2025 8:28:00 AM
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
    /// Encapsulates the 'AppProgram' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(AppProgram))]
    [XmlType("AppProgram")]
    public partial class AppProgram : esAppProgram
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new AppProgram();
        }

        #region Static Quick Access Methods
        static public void Delete(string programID)
        {
            var obj = new AppProgram();
            obj.ProgramID = programID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string programID, esSqlAccessType sqlAccessType)
        {
            var obj = new AppProgram();
            obj.ProgramID = programID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("AppProgramCollection")]
    public partial class AppProgramCollection : esAppProgramCollection, IEnumerable<AppProgram>
    {
        public AppProgram FindByPrimaryKey(string programID)
        {
            return this.SingleOrDefault(e => e.ProgramID == programID);
        }



    }



    [Serializable]
    public partial class AppProgramQuery : esAppProgramQuery
    {
        public AppProgramQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public AppProgramQuery(string joinAlias, out AppProgramQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "AppProgramQuery";
        }



        #region Explicit Casts

        public static explicit operator string(AppProgramQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator AppProgramQuery(string query)
        {
            return (AppProgramQuery)SerializeHelper.FromXml(query, typeof(AppProgramQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esAppProgram : esEntity
    {
        public esAppProgram()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string programID)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(programID);
            else
                return LoadByPrimaryKeyStoredProcedure(programID);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string programID)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(programID);
            else
                return LoadByPrimaryKeyStoredProcedure(programID);
        }

        private bool LoadByPrimaryKeyDynamic(string programID)
        {
            AppProgramQuery query = new AppProgramQuery("apQ");
            query.Where(query.ProgramID == programID);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string programID)
        {
            esParameters parms = new esParameters();
            parms.Add("ProgramID", programID);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to AppProgram.ProgramID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ProgramID
        {
            get
            {
                return GetSystemString(AppProgramMetadata.ColumnNames.ProgramID);
            }

            set
            {
                if (SetSystemString(AppProgramMetadata.ColumnNames.ProgramID, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.ProgramID);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.ParentProgramID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParentProgramID
        {
            get
            {
                return GetSystemString(AppProgramMetadata.ColumnNames.ParentProgramID);
            }

            set
            {
                if (SetSystemString(AppProgramMetadata.ColumnNames.ParentProgramID, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.ParentProgramID);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.ProgramName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ProgramName
        {
            get
            {
                return GetSystemString(AppProgramMetadata.ColumnNames.ProgramName);
            }

            set
            {
                if (SetSystemString(AppProgramMetadata.ColumnNames.ProgramName, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.ProgramName);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.TopLevelProgramID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TopLevelProgramID
        {
            get
            {
                return GetSystemString(AppProgramMetadata.ColumnNames.TopLevelProgramID);
            }

            set
            {
                if (SetSystemString(AppProgramMetadata.ColumnNames.TopLevelProgramID, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.TopLevelProgramID);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.RootLevel
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public byte? RootLevel
        {
            get
            {
                return GetSystemByte(AppProgramMetadata.ColumnNames.RootLevel);
            }

            set
            {
                if (SetSystemByte(AppProgramMetadata.ColumnNames.RootLevel, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.RootLevel);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.RowIndex
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public short? RowIndex
        {
            get
            {
                return GetSystemInt16(AppProgramMetadata.ColumnNames.RowIndex);
            }

            set
            {
                if (SetSystemInt16(AppProgramMetadata.ColumnNames.RowIndex, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.RowIndex);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.Note
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Note
        {
            get
            {
                return GetSystemString(AppProgramMetadata.ColumnNames.Note);
            }

            set
            {
                if (SetSystemString(AppProgramMetadata.ColumnNames.Note, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.Note);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.IsParentProgram
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsParentProgram
        {
            get
            {
                return GetSystemBoolean(AppProgramMetadata.ColumnNames.IsParentProgram);
            }

            set
            {
                if (SetSystemBoolean(AppProgramMetadata.ColumnNames.IsParentProgram, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.IsParentProgram);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.IsProgram
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsProgram
        {
            get
            {
                return GetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgram);
            }

            set
            {
                if (SetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgram, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgram);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.IsBeginGroup
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsBeginGroup
        {
            get
            {
                return GetSystemBoolean(AppProgramMetadata.ColumnNames.IsBeginGroup);
            }

            set
            {
                if (SetSystemBoolean(AppProgramMetadata.ColumnNames.IsBeginGroup, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.IsBeginGroup);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.ProgramType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ProgramType
        {
            get
            {
                return GetSystemString(AppProgramMetadata.ColumnNames.ProgramType);
            }

            set
            {
                if (SetSystemString(AppProgramMetadata.ColumnNames.ProgramType, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.ProgramType);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.IsProgramAddAble
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsProgramAddAble
        {
            get
            {
                return GetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramAddAble);
            }

            set
            {
                if (SetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramAddAble, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgramAddAble);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.IsProgramEditAble
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsProgramEditAble
        {
            get
            {
                return GetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramEditAble);
            }

            set
            {
                if (SetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramEditAble, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgramEditAble);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.IsProgramDeleteAble
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsProgramDeleteAble
        {
            get
            {
                return GetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramDeleteAble);
            }

            set
            {
                if (SetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramDeleteAble, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgramDeleteAble);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.IsProgramViewAble
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsProgramViewAble
        {
            get
            {
                return GetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramViewAble);
            }

            set
            {
                if (SetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramViewAble, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgramViewAble);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.IsProgramApprovalAble
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsProgramApprovalAble
        {
            get
            {
                return GetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramApprovalAble);
            }

            set
            {
                if (SetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramApprovalAble, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgramApprovalAble);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.IsProgramUnApprovalAble
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsProgramUnApprovalAble
        {
            get
            {
                return GetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramUnApprovalAble);
            }

            set
            {
                if (SetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramUnApprovalAble, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgramUnApprovalAble);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.IsProgramVoidAble
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsProgramVoidAble
        {
            get
            {
                return GetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramVoidAble);
            }

            set
            {
                if (SetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramVoidAble, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgramVoidAble);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.IsProgramUnVoidAble
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsProgramUnVoidAble
        {
            get
            {
                return GetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramUnVoidAble);
            }

            set
            {
                if (SetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramUnVoidAble, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgramUnVoidAble);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.IsProgramDirectVoid
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsProgramDirectVoid
        {
            get
            {
                return GetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramDirectVoid);
            }

            set
            {
                if (SetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramDirectVoid, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgramDirectVoid);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.IsProgramPrintAble
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsProgramPrintAble
        {
            get
            {
                return GetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramPrintAble);
            }

            set
            {
                if (SetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramPrintAble, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgramPrintAble);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.IsMenuAddVisible
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsMenuAddVisible
        {
            get
            {
                return GetSystemBoolean(AppProgramMetadata.ColumnNames.IsMenuAddVisible);
            }

            set
            {
                if (SetSystemBoolean(AppProgramMetadata.ColumnNames.IsMenuAddVisible, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.IsMenuAddVisible);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.IsMenuHomeVisible
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsMenuHomeVisible
        {
            get
            {
                return GetSystemBoolean(AppProgramMetadata.ColumnNames.IsMenuHomeVisible);
            }

            set
            {
                if (SetSystemBoolean(AppProgramMetadata.ColumnNames.IsMenuHomeVisible, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.IsMenuHomeVisible);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.IsVisible
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsVisible
        {
            get
            {
                return GetSystemBoolean(AppProgramMetadata.ColumnNames.IsVisible);
            }

            set
            {
                if (SetSystemBoolean(AppProgramMetadata.ColumnNames.IsVisible, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.IsVisible);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.IsDiscontinue
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsDiscontinue
        {
            get
            {
                return GetSystemBoolean(AppProgramMetadata.ColumnNames.IsDiscontinue);
            }

            set
            {
                if (SetSystemBoolean(AppProgramMetadata.ColumnNames.IsDiscontinue, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.IsDiscontinue);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.NavigateUrl
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string NavigateUrl
        {
            get
            {
                return GetSystemString(AppProgramMetadata.ColumnNames.NavigateUrl);
            }

            set
            {
                if (SetSystemString(AppProgramMetadata.ColumnNames.NavigateUrl, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.NavigateUrl);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.HelpLinkID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string HelpLinkID
        {
            get
            {
                return GetSystemString(AppProgramMetadata.ColumnNames.HelpLinkID);
            }

            set
            {
                if (SetSystemString(AppProgramMetadata.ColumnNames.HelpLinkID, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.HelpLinkID);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.AssemblyName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string AssemblyName
        {
            get
            {
                return GetSystemString(AppProgramMetadata.ColumnNames.AssemblyName);
            }

            set
            {
                if (SetSystemString(AppProgramMetadata.ColumnNames.AssemblyName, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.AssemblyName);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.AssemblyClassName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string AssemblyClassName
        {
            get
            {
                return GetSystemString(AppProgramMetadata.ColumnNames.AssemblyClassName);
            }

            set
            {
                if (SetSystemString(AppProgramMetadata.ColumnNames.AssemblyClassName, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.AssemblyClassName);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.StoreProcedureName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string StoreProcedureName
        {
            get
            {
                return GetSystemString(AppProgramMetadata.ColumnNames.StoreProcedureName);
            }

            set
            {
                if (SetSystemString(AppProgramMetadata.ColumnNames.StoreProcedureName, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.StoreProcedureName);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.AccessKey
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public char? AccessKey
        {
            get
            {
                return GetSystemChar(AppProgramMetadata.ColumnNames.AccessKey);
            }

            set
            {
                if (SetSystemChar(AppProgramMetadata.ColumnNames.AccessKey, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.AccessKey);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.IsUsingReportHeader
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsUsingReportHeader
        {
            get
            {
                return GetSystemBoolean(AppProgramMetadata.ColumnNames.IsUsingReportHeader);
            }

            set
            {
                if (SetSystemBoolean(AppProgramMetadata.ColumnNames.IsUsingReportHeader, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.IsUsingReportHeader);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.IsDirectPrintEnable
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsDirectPrintEnable
        {
            get
            {
                return GetSystemBoolean(AppProgramMetadata.ColumnNames.IsDirectPrintEnable);
            }

            set
            {
                if (SetSystemBoolean(AppProgramMetadata.ColumnNames.IsDirectPrintEnable, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.IsDirectPrintEnable);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.IsListLoadRecordOnInit
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsListLoadRecordOnInit
        {
            get
            {
                return GetSystemBoolean(AppProgramMetadata.ColumnNames.IsListLoadRecordOnInit);
            }

            set
            {
                if (SetSystemBoolean(AppProgramMetadata.ColumnNames.IsListLoadRecordOnInit, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.IsListLoadRecordOnInit);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.IsListLoadRecordIfFiltered
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsListLoadRecordIfFiltered
        {
            get
            {
                return GetSystemBoolean(AppProgramMetadata.ColumnNames.IsListLoadRecordIfFiltered);
            }

            set
            {
                if (SetSystemBoolean(AppProgramMetadata.ColumnNames.IsListLoadRecordIfFiltered, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.IsListLoadRecordIfFiltered);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.IsProgramRedirected
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsProgramRedirected
        {
            get
            {
                return GetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramRedirected);
            }

            set
            {
                if (SetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramRedirected, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgramRedirected);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.ApplicationID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ApplicationID
        {
            get
            {
                return GetSystemString(AppProgramMetadata.ColumnNames.ApplicationID);
            }

            set
            {
                if (SetSystemString(AppProgramMetadata.ColumnNames.ApplicationID, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.ApplicationID);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.ZplCommandTemplate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ZplCommandTemplate
        {
            get
            {
                return GetSystemString(AppProgramMetadata.ColumnNames.ZplCommandTemplate);
            }

            set
            {
                if (SetSystemString(AppProgramMetadata.ColumnNames.ZplCommandTemplate, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.ZplCommandTemplate);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.IsProgramExportAble
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsProgramExportAble
        {
            get
            {
                return GetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramExportAble);
            }

            set
            {
                if (SetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramExportAble, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgramExportAble);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.IsProgramCrossUnitAble
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsProgramCrossUnitAble
        {
            get
            {
                return GetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramCrossUnitAble);
            }

            set
            {
                if (SetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramCrossUnitAble, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgramCrossUnitAble);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.IsProgramPowerUserAble
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsProgramPowerUserAble
        {
            get
            {
                return GetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramPowerUserAble);
            }

            set
            {
                if (SetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramPowerUserAble, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgramPowerUserAble);
                }
            }
        }

        /// <summary>
        /// Maps to AppProgram.SRProgramCategory
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRProgramCategory
        {
            get
            {
                return GetSystemString(AppProgramMetadata.ColumnNames.SRProgramCategory);
            }

            set
            {
                if (SetSystemString(AppProgramMetadata.ColumnNames.SRProgramCategory, value))
                {
                    OnPropertyChanged(AppProgramMetadata.PropertyNames.SRProgramCategory);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return AppProgramMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public AppProgramQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new AppProgramQuery("apQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(AppProgramQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(AppProgramQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((AppProgramQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private AppProgramQuery query;
    }



    [Serializable]
    abstract public partial class esAppProgramCollection : esEntityCollection<AppProgram>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return AppProgramMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "AppProgramCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public AppProgramQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new AppProgramQuery("apQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(AppProgramQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new AppProgramQuery("apQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(AppProgramQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((AppProgramQuery)query);
        }

        #endregion

        private AppProgramQuery query;
    }



    [Serializable]
    abstract public partial class esAppProgramQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return AppProgramMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "ProgramID": return ProgramID;
                case "ParentProgramID": return ParentProgramID;
                case "ProgramName": return ProgramName;
                case "TopLevelProgramID": return TopLevelProgramID;
                case "RootLevel": return RootLevel;
                case "RowIndex": return RowIndex;
                case "Note": return Note;
                case "IsParentProgram": return IsParentProgram;
                case "IsProgram": return IsProgram;
                case "IsBeginGroup": return IsBeginGroup;
                case "ProgramType": return ProgramType;
                case "IsProgramAddAble": return IsProgramAddAble;
                case "IsProgramEditAble": return IsProgramEditAble;
                case "IsProgramDeleteAble": return IsProgramDeleteAble;
                case "IsProgramViewAble": return IsProgramViewAble;
                case "IsProgramApprovalAble": return IsProgramApprovalAble;
                case "IsProgramUnApprovalAble": return IsProgramUnApprovalAble;
                case "IsProgramVoidAble": return IsProgramVoidAble;
                case "IsProgramUnVoidAble": return IsProgramUnVoidAble;
                case "IsProgramDirectVoid": return IsProgramDirectVoid;
                case "IsProgramPrintAble": return IsProgramPrintAble;
                case "IsMenuAddVisible": return IsMenuAddVisible;
                case "IsMenuHomeVisible": return IsMenuHomeVisible;
                case "IsVisible": return IsVisible;
                case "IsDiscontinue": return IsDiscontinue;
                case "NavigateUrl": return NavigateUrl;
                case "HelpLinkID": return HelpLinkID;
                case "AssemblyName": return AssemblyName;
                case "AssemblyClassName": return AssemblyClassName;
                case "StoreProcedureName": return StoreProcedureName;
                case "AccessKey": return AccessKey;
                case "IsUsingReportHeader": return IsUsingReportHeader;
                case "IsDirectPrintEnable": return IsDirectPrintEnable;
                case "IsListLoadRecordOnInit": return IsListLoadRecordOnInit;
                case "IsListLoadRecordIfFiltered": return IsListLoadRecordIfFiltered;
                case "IsProgramRedirected": return IsProgramRedirected;
                case "ApplicationID": return ApplicationID;
                case "ZplCommandTemplate": return ZplCommandTemplate;
                case "IsProgramExportAble": return IsProgramExportAble;
                case "IsProgramCrossUnitAble": return IsProgramCrossUnitAble;
                case "IsProgramPowerUserAble": return IsProgramPowerUserAble;
                case "SRProgramCategory": return SRProgramCategory;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem ProgramID
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.ProgramID, esSystemType.String); }
        }

        public esQueryItem ParentProgramID
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.ParentProgramID, esSystemType.String); }
        }

        public esQueryItem ProgramName
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.ProgramName, esSystemType.String); }
        }

        public esQueryItem TopLevelProgramID
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.TopLevelProgramID, esSystemType.String); }
        }

        public esQueryItem RootLevel
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.RootLevel, esSystemType.Byte); }
        }

        public esQueryItem RowIndex
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.RowIndex, esSystemType.Int16); }
        }

        public esQueryItem Note
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.Note, esSystemType.String); }
        }

        public esQueryItem IsParentProgram
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsParentProgram, esSystemType.Boolean); }
        }

        public esQueryItem IsProgram
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsProgram, esSystemType.Boolean); }
        }

        public esQueryItem IsBeginGroup
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsBeginGroup, esSystemType.Boolean); }
        }

        public esQueryItem ProgramType
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.ProgramType, esSystemType.String); }
        }

        public esQueryItem IsProgramAddAble
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsProgramAddAble, esSystemType.Boolean); }
        }

        public esQueryItem IsProgramEditAble
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsProgramEditAble, esSystemType.Boolean); }
        }

        public esQueryItem IsProgramDeleteAble
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsProgramDeleteAble, esSystemType.Boolean); }
        }

        public esQueryItem IsProgramViewAble
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsProgramViewAble, esSystemType.Boolean); }
        }

        public esQueryItem IsProgramApprovalAble
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsProgramApprovalAble, esSystemType.Boolean); }
        }

        public esQueryItem IsProgramUnApprovalAble
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsProgramUnApprovalAble, esSystemType.Boolean); }
        }

        public esQueryItem IsProgramVoidAble
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsProgramVoidAble, esSystemType.Boolean); }
        }

        public esQueryItem IsProgramUnVoidAble
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsProgramUnVoidAble, esSystemType.Boolean); }
        }

        public esQueryItem IsProgramDirectVoid
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsProgramDirectVoid, esSystemType.Boolean); }
        }

        public esQueryItem IsProgramPrintAble
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsProgramPrintAble, esSystemType.Boolean); }
        }

        public esQueryItem IsMenuAddVisible
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsMenuAddVisible, esSystemType.Boolean); }
        }

        public esQueryItem IsMenuHomeVisible
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsMenuHomeVisible, esSystemType.Boolean); }
        }

        public esQueryItem IsVisible
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsVisible, esSystemType.Boolean); }
        }

        public esQueryItem IsDiscontinue
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsDiscontinue, esSystemType.Boolean); }
        }

        public esQueryItem NavigateUrl
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.NavigateUrl, esSystemType.String); }
        }

        public esQueryItem HelpLinkID
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.HelpLinkID, esSystemType.String); }
        }

        public esQueryItem AssemblyName
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.AssemblyName, esSystemType.String); }
        }

        public esQueryItem AssemblyClassName
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.AssemblyClassName, esSystemType.String); }
        }

        public esQueryItem StoreProcedureName
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.StoreProcedureName, esSystemType.String); }
        }

        public esQueryItem AccessKey
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.AccessKey, esSystemType.Char); }
        }

        public esQueryItem IsUsingReportHeader
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsUsingReportHeader, esSystemType.Boolean); }
        }

        public esQueryItem IsDirectPrintEnable
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsDirectPrintEnable, esSystemType.Boolean); }
        }

        public esQueryItem IsListLoadRecordOnInit
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsListLoadRecordOnInit, esSystemType.Boolean); }
        }

        public esQueryItem IsListLoadRecordIfFiltered
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsListLoadRecordIfFiltered, esSystemType.Boolean); }
        }

        public esQueryItem IsProgramRedirected
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsProgramRedirected, esSystemType.Boolean); }
        }

        public esQueryItem ApplicationID
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.ApplicationID, esSystemType.String); }
        }

        public esQueryItem ZplCommandTemplate
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.ZplCommandTemplate, esSystemType.String); }
        }

        public esQueryItem IsProgramExportAble
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsProgramExportAble, esSystemType.Boolean); }
        }

        public esQueryItem IsProgramCrossUnitAble
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsProgramCrossUnitAble, esSystemType.Boolean); }
        }

        public esQueryItem IsProgramPowerUserAble
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsProgramPowerUserAble, esSystemType.Boolean); }
        }

        public esQueryItem SRProgramCategory
        {
            get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.SRProgramCategory, esSystemType.String); }
        }

        #endregion

    }



    [Serializable]
    public partial class AppProgramMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected AppProgramMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.ProgramID, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ProgramID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 30;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParentProgramID, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParentProgramID;
            c.CharacterMaxLength = 30;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ProgramName, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ProgramName;
            c.CharacterMaxLength = 100;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TopLevelProgramID, 3, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TopLevelProgramID;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RootLevel, 4, typeof(byte), esSystemType.Byte);
            c.PropertyName = PropertyNames.RootLevel;
            c.NumericPrecision = 3;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RowIndex, 5, typeof(short), esSystemType.Int16);
            c.PropertyName = PropertyNames.RowIndex;
            c.NumericPrecision = 5;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Note, 6, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Note;
            c.CharacterMaxLength = 1000;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsParentProgram, 7, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsParentProgram;
            c.HasDefault = true;
            c.Default = @"((0))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsProgram, 8, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsProgram;
            c.HasDefault = true;
            c.Default = @"((1))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsBeginGroup, 9, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsBeginGroup;
            c.HasDefault = true;
            c.Default = @"((0))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ProgramType, 10, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ProgramType;
            c.CharacterMaxLength = 5;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsProgramAddAble, 11, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsProgramAddAble;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsProgramEditAble, 12, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsProgramEditAble;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsProgramDeleteAble, 13, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsProgramDeleteAble;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsProgramViewAble, 14, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsProgramViewAble;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsProgramApprovalAble, 15, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsProgramApprovalAble;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsProgramUnApprovalAble, 16, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsProgramUnApprovalAble;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsProgramVoidAble, 17, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsProgramVoidAble;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsProgramUnVoidAble, 18, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsProgramUnVoidAble;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsProgramDirectVoid, 19, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsProgramDirectVoid;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsProgramPrintAble, 20, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsProgramPrintAble;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsMenuAddVisible, 21, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsMenuAddVisible;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsMenuHomeVisible, 22, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsMenuHomeVisible;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsVisible, 23, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsVisible;
            c.HasDefault = true;
            c.Default = @"((0))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsDiscontinue, 24, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsDiscontinue;
            c.HasDefault = true;
            c.Default = @"((0))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.NavigateUrl, 25, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.NavigateUrl;
            c.CharacterMaxLength = 1000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.HelpLinkID, 26, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.HelpLinkID;
            c.CharacterMaxLength = 255;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AssemblyName, 27, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.AssemblyName;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AssemblyClassName, 28, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.AssemblyClassName;
            c.CharacterMaxLength = 200;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.StoreProcedureName, 29, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.StoreProcedureName;
            c.CharacterMaxLength = 200;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AccessKey, 30, typeof(char), esSystemType.Char);
            c.PropertyName = PropertyNames.AccessKey;
            c.CharacterMaxLength = 1;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsUsingReportHeader, 31, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsUsingReportHeader;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsDirectPrintEnable, 32, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsDirectPrintEnable;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsListLoadRecordOnInit, 33, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsListLoadRecordOnInit;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsListLoadRecordIfFiltered, 34, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsListLoadRecordIfFiltered;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsProgramRedirected, 35, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsProgramRedirected;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ApplicationID, 36, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ApplicationID;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ZplCommandTemplate, 37, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ZplCommandTemplate;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsProgramExportAble, 38, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsProgramExportAble;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsProgramCrossUnitAble, 39, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsProgramCrossUnitAble;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsProgramPowerUserAble, 40, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsProgramPowerUserAble;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRProgramCategory, 41, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRProgramCategory;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public AppProgramMetadata Meta()
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
            public const string ProgramID = "ProgramID";
            public const string ParentProgramID = "ParentProgramID";
            public const string ProgramName = "ProgramName";
            public const string TopLevelProgramID = "TopLevelProgramID";
            public const string RootLevel = "RootLevel";
            public const string RowIndex = "RowIndex";
            public const string Note = "Note";
            public const string IsParentProgram = "IsParentProgram";
            public const string IsProgram = "IsProgram";
            public const string IsBeginGroup = "IsBeginGroup";
            public const string ProgramType = "ProgramType";
            public const string IsProgramAddAble = "IsProgramAddAble";
            public const string IsProgramEditAble = "IsProgramEditAble";
            public const string IsProgramDeleteAble = "IsProgramDeleteAble";
            public const string IsProgramViewAble = "IsProgramViewAble";
            public const string IsProgramApprovalAble = "IsProgramApprovalAble";
            public const string IsProgramUnApprovalAble = "IsProgramUnApprovalAble";
            public const string IsProgramVoidAble = "IsProgramVoidAble";
            public const string IsProgramUnVoidAble = "IsProgramUnVoidAble";
            public const string IsProgramDirectVoid = "IsProgramDirectVoid";
            public const string IsProgramPrintAble = "IsProgramPrintAble";
            public const string IsMenuAddVisible = "IsMenuAddVisible";
            public const string IsMenuHomeVisible = "IsMenuHomeVisible";
            public const string IsVisible = "IsVisible";
            public const string IsDiscontinue = "IsDiscontinue";
            public const string NavigateUrl = "NavigateUrl";
            public const string HelpLinkID = "HelpLinkID";
            public const string AssemblyName = "AssemblyName";
            public const string AssemblyClassName = "AssemblyClassName";
            public const string StoreProcedureName = "StoreProcedureName";
            public const string AccessKey = "AccessKey";
            public const string IsUsingReportHeader = "IsUsingReportHeader";
            public const string IsDirectPrintEnable = "IsDirectPrintEnable";
            public const string IsListLoadRecordOnInit = "IsListLoadRecordOnInit";
            public const string IsListLoadRecordIfFiltered = "IsListLoadRecordIfFiltered";
            public const string IsProgramRedirected = "IsProgramRedirected";
            public const string ApplicationID = "ApplicationID";
            public const string ZplCommandTemplate = "ZplCommandTemplate";
            public const string IsProgramExportAble = "IsProgramExportAble";
            public const string IsProgramCrossUnitAble = "IsProgramCrossUnitAble";
            public const string IsProgramPowerUserAble = "IsProgramPowerUserAble";
            public const string SRProgramCategory = "SRProgramCategory";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string ProgramID = "ProgramID";
            public const string ParentProgramID = "ParentProgramID";
            public const string ProgramName = "ProgramName";
            public const string TopLevelProgramID = "TopLevelProgramID";
            public const string RootLevel = "RootLevel";
            public const string RowIndex = "RowIndex";
            public const string Note = "Note";
            public const string IsParentProgram = "IsParentProgram";
            public const string IsProgram = "IsProgram";
            public const string IsBeginGroup = "IsBeginGroup";
            public const string ProgramType = "ProgramType";
            public const string IsProgramAddAble = "IsProgramAddAble";
            public const string IsProgramEditAble = "IsProgramEditAble";
            public const string IsProgramDeleteAble = "IsProgramDeleteAble";
            public const string IsProgramViewAble = "IsProgramViewAble";
            public const string IsProgramApprovalAble = "IsProgramApprovalAble";
            public const string IsProgramUnApprovalAble = "IsProgramUnApprovalAble";
            public const string IsProgramVoidAble = "IsProgramVoidAble";
            public const string IsProgramUnVoidAble = "IsProgramUnVoidAble";
            public const string IsProgramDirectVoid = "IsProgramDirectVoid";
            public const string IsProgramPrintAble = "IsProgramPrintAble";
            public const string IsMenuAddVisible = "IsMenuAddVisible";
            public const string IsMenuHomeVisible = "IsMenuHomeVisible";
            public const string IsVisible = "IsVisible";
            public const string IsDiscontinue = "IsDiscontinue";
            public const string NavigateUrl = "NavigateUrl";
            public const string HelpLinkID = "HelpLinkID";
            public const string AssemblyName = "AssemblyName";
            public const string AssemblyClassName = "AssemblyClassName";
            public const string StoreProcedureName = "StoreProcedureName";
            public const string AccessKey = "AccessKey";
            public const string IsUsingReportHeader = "IsUsingReportHeader";
            public const string IsDirectPrintEnable = "IsDirectPrintEnable";
            public const string IsListLoadRecordOnInit = "IsListLoadRecordOnInit";
            public const string IsListLoadRecordIfFiltered = "IsListLoadRecordIfFiltered";
            public const string IsProgramRedirected = "IsProgramRedirected";
            public const string ApplicationID = "ApplicationID";
            public const string ZplCommandTemplate = "ZplCommandTemplate";
            public const string IsProgramExportAble = "IsProgramExportAble";
            public const string IsProgramCrossUnitAble = "IsProgramCrossUnitAble";
            public const string IsProgramPowerUserAble = "IsProgramPowerUserAble";
            public const string SRProgramCategory = "SRProgramCategory";
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
            lock (typeof(AppProgramMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new AppProgramMetadata();
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


                meta.AddTypeMap("ProgramID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ParentProgramID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ProgramName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TopLevelProgramID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("RootLevel", new esTypeMap("tinyint", "System.Byte"));
                meta.AddTypeMap("RowIndex", new esTypeMap("smallint", "System.Int16"));
                meta.AddTypeMap("Note", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsParentProgram", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsProgram", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsBeginGroup", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ProgramType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsProgramAddAble", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsProgramEditAble", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsProgramDeleteAble", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsProgramViewAble", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsProgramApprovalAble", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsProgramUnApprovalAble", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsProgramVoidAble", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsProgramUnVoidAble", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsProgramDirectVoid", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsProgramPrintAble", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsMenuAddVisible", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsMenuHomeVisible", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsVisible", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsDiscontinue", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("NavigateUrl", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("HelpLinkID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("AssemblyName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("AssemblyClassName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("StoreProcedureName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("AccessKey", new esTypeMap("char", "System.Char"));
                meta.AddTypeMap("IsUsingReportHeader", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsDirectPrintEnable", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsListLoadRecordOnInit", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsListLoadRecordIfFiltered", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsProgramRedirected", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ApplicationID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ZplCommandTemplate", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsProgramExportAble", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsProgramCrossUnitAble", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsProgramPowerUserAble", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("SRProgramCategory", new esTypeMap("varchar", "System.String"));



                meta.Source = "AppProgram";
                meta.Destination = "AppProgram";

                meta.spInsert = "proc_AppProgramInsert";
                meta.spUpdate = "proc_AppProgramUpdate";
                meta.spDelete = "proc_AppProgramDelete";
                meta.spLoadAll = "proc_AppProgramLoadAll";
                meta.spLoadByPrimaryKey = "proc_AppProgramLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private AppProgramMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
