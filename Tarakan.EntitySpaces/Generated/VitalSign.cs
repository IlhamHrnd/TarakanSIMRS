
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 2/12/2025 10:24:45 AM
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
    /// Encapsulates the 'VitalSign' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(VitalSign))]
    [XmlType("VitalSign")]
    public partial class VitalSign : esVitalSign
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new VitalSign();
        }

        #region Static Quick Access Methods
        static public void Delete(string vitalSignID)
        {
            var obj = new VitalSign();
            obj.VitalSignID = vitalSignID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string vitalSignID, esSqlAccessType sqlAccessType)
        {
            var obj = new VitalSign();
            obj.VitalSignID = vitalSignID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("VitalSignCollection")]
    public partial class VitalSignCollection : esVitalSignCollection, IEnumerable<VitalSign>
    {
        public VitalSign FindByPrimaryKey(string vitalSignID)
        {
            return this.SingleOrDefault(e => e.VitalSignID == vitalSignID);
        }



    }



    [Serializable]
    public partial class VitalSignQuery : esVitalSignQuery
    {
        public VitalSignQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public VitalSignQuery(string joinAlias, out VitalSignQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "VitalSignQuery";
        }



        #region Explicit Casts

        public static explicit operator string(VitalSignQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator VitalSignQuery(string query)
        {
            return (VitalSignQuery)SerializeHelper.FromXml(query, typeof(VitalSignQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esVitalSign : esEntity
    {
        public esVitalSign()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string vitalSignID)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(vitalSignID);
            else
                return LoadByPrimaryKeyStoredProcedure(vitalSignID);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string vitalSignID)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(vitalSignID);
            else
                return LoadByPrimaryKeyStoredProcedure(vitalSignID);
        }

        private bool LoadByPrimaryKeyDynamic(string vitalSignID)
        {
            VitalSignQuery query = new VitalSignQuery("vsQ");
            query.Where(query.VitalSignID == vitalSignID);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string vitalSignID)
        {
            esParameters parms = new esParameters();
            parms.Add("VitalSignID", vitalSignID);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to VitalSign.VitalSignID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string VitalSignID
        {
            get
            {
                return GetSystemString(VitalSignMetadata.ColumnNames.VitalSignID);
            }

            set
            {
                if (SetSystemString(VitalSignMetadata.ColumnNames.VitalSignID, value))
                {
                    OnPropertyChanged(VitalSignMetadata.PropertyNames.VitalSignID);
                }
            }
        }

        /// <summary>
        /// Maps to VitalSign.VitalSignName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string VitalSignName
        {
            get
            {
                return GetSystemString(VitalSignMetadata.ColumnNames.VitalSignName);
            }

            set
            {
                if (SetSystemString(VitalSignMetadata.ColumnNames.VitalSignName, value))
                {
                    OnPropertyChanged(VitalSignMetadata.PropertyNames.VitalSignName);
                }
            }
        }

        /// <summary>
        /// Maps to VitalSign.VitalSignInitial
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string VitalSignInitial
        {
            get
            {
                return GetSystemString(VitalSignMetadata.ColumnNames.VitalSignInitial);
            }

            set
            {
                if (SetSystemString(VitalSignMetadata.ColumnNames.VitalSignInitial, value))
                {
                    OnPropertyChanged(VitalSignMetadata.PropertyNames.VitalSignInitial);
                }
            }
        }

        /// <summary>
        /// Maps to VitalSign.SRVitalSignGroup
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRVitalSignGroup
        {
            get
            {
                return GetSystemString(VitalSignMetadata.ColumnNames.SRVitalSignGroup);
            }

            set
            {
                if (SetSystemString(VitalSignMetadata.ColumnNames.SRVitalSignGroup, value))
                {
                    OnPropertyChanged(VitalSignMetadata.PropertyNames.SRVitalSignGroup);
                }
            }
        }

        /// <summary>
        /// Maps to VitalSign.RowIndexInGroup
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? RowIndexInGroup
        {
            get
            {
                return GetSystemInt32(VitalSignMetadata.ColumnNames.RowIndexInGroup);
            }

            set
            {
                if (SetSystemInt32(VitalSignMetadata.ColumnNames.RowIndexInGroup, value))
                {
                    OnPropertyChanged(VitalSignMetadata.PropertyNames.RowIndexInGroup);
                }
            }
        }

        /// <summary>
        /// Maps to VitalSign.ValueType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ValueType
        {
            get
            {
                return GetSystemString(VitalSignMetadata.ColumnNames.ValueType);
            }

            set
            {
                if (SetSystemString(VitalSignMetadata.ColumnNames.ValueType, value))
                {
                    OnPropertyChanged(VitalSignMetadata.PropertyNames.ValueType);
                }
            }
        }

        /// <summary>
        /// Maps to VitalSign.StandardReferenceID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string StandardReferenceID
        {
            get
            {
                return GetSystemString(VitalSignMetadata.ColumnNames.StandardReferenceID);
            }

            set
            {
                if (SetSystemString(VitalSignMetadata.ColumnNames.StandardReferenceID, value))
                {
                    OnPropertyChanged(VitalSignMetadata.PropertyNames.StandardReferenceID);
                }
            }
        }

        /// <summary>
        /// Maps to VitalSign.EntryMask
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string EntryMask
        {
            get
            {
                return GetSystemString(VitalSignMetadata.ColumnNames.EntryMask);
            }

            set
            {
                if (SetSystemString(VitalSignMetadata.ColumnNames.EntryMask, value))
                {
                    OnPropertyChanged(VitalSignMetadata.PropertyNames.EntryMask);
                }
            }
        }

        /// <summary>
        /// Maps to VitalSign.VitalSignUnit
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string VitalSignUnit
        {
            get
            {
                return GetSystemString(VitalSignMetadata.ColumnNames.VitalSignUnit);
            }

            set
            {
                if (SetSystemString(VitalSignMetadata.ColumnNames.VitalSignUnit, value))
                {
                    OnPropertyChanged(VitalSignMetadata.PropertyNames.VitalSignUnit);
                }
            }
        }

        /// <summary>
        /// Maps to VitalSign.NumType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string NumType
        {
            get
            {
                return GetSystemString(VitalSignMetadata.ColumnNames.NumType);
            }

            set
            {
                if (SetSystemString(VitalSignMetadata.ColumnNames.NumType, value))
                {
                    OnPropertyChanged(VitalSignMetadata.PropertyNames.NumType);
                }
            }
        }

        /// <summary>
        /// Maps to VitalSign.NumDecimalDigits
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? NumDecimalDigits
        {
            get
            {
                return GetSystemInt32(VitalSignMetadata.ColumnNames.NumDecimalDigits);
            }

            set
            {
                if (SetSystemInt32(VitalSignMetadata.ColumnNames.NumDecimalDigits, value))
                {
                    OnPropertyChanged(VitalSignMetadata.PropertyNames.NumDecimalDigits);
                }
            }
        }

        /// <summary>
        /// Maps to VitalSign.NumMinValue
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? NumMinValue
        {
            get
            {
                return GetSystemInt32(VitalSignMetadata.ColumnNames.NumMinValue);
            }

            set
            {
                if (SetSystemInt32(VitalSignMetadata.ColumnNames.NumMinValue, value))
                {
                    OnPropertyChanged(VitalSignMetadata.PropertyNames.NumMinValue);
                }
            }
        }

        /// <summary>
        /// Maps to VitalSign.NumMaxValue
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? NumMaxValue
        {
            get
            {
                return GetSystemInt32(VitalSignMetadata.ColumnNames.NumMaxValue);
            }

            set
            {
                if (SetSystemInt32(VitalSignMetadata.ColumnNames.NumMaxValue, value))
                {
                    OnPropertyChanged(VitalSignMetadata.PropertyNames.NumMaxValue);
                }
            }
        }

        /// <summary>
        /// Maps to VitalSign.NumMaxLength
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? NumMaxLength
        {
            get
            {
                return GetSystemInt32(VitalSignMetadata.ColumnNames.NumMaxLength);
            }

            set
            {
                if (SetSystemInt32(VitalSignMetadata.ColumnNames.NumMaxLength, value))
                {
                    OnPropertyChanged(VitalSignMetadata.PropertyNames.NumMaxLength);
                }
            }
        }

        /// <summary>
        /// Maps to VitalSign.IsMonitoring
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsMonitoring
        {
            get
            {
                return GetSystemBoolean(VitalSignMetadata.ColumnNames.IsMonitoring);
            }

            set
            {
                if (SetSystemBoolean(VitalSignMetadata.ColumnNames.IsMonitoring, value))
                {
                    OnPropertyChanged(VitalSignMetadata.PropertyNames.IsMonitoring);
                }
            }
        }

        /// <summary>
        /// Maps to VitalSign.IsChart
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsChart
        {
            get
            {
                return GetSystemBoolean(VitalSignMetadata.ColumnNames.IsChart);
            }

            set
            {
                if (SetSystemBoolean(VitalSignMetadata.ColumnNames.IsChart, value))
                {
                    OnPropertyChanged(VitalSignMetadata.PropertyNames.IsChart);
                }
            }
        }

        /// <summary>
        /// Maps to VitalSign.ChartColor
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? ChartColor
        {
            get
            {
                return GetSystemInt32(VitalSignMetadata.ColumnNames.ChartColor);
            }

            set
            {
                if (SetSystemInt32(VitalSignMetadata.ColumnNames.ChartColor, value))
                {
                    OnPropertyChanged(VitalSignMetadata.PropertyNames.ChartColor);
                }
            }
        }

        /// <summary>
        /// Maps to VitalSign.ChartMinValue
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? ChartMinValue
        {
            get
            {
                return GetSystemInt32(VitalSignMetadata.ColumnNames.ChartMinValue);
            }

            set
            {
                if (SetSystemInt32(VitalSignMetadata.ColumnNames.ChartMinValue, value))
                {
                    OnPropertyChanged(VitalSignMetadata.PropertyNames.ChartMinValue);
                }
            }
        }

        /// <summary>
        /// Maps to VitalSign.ChartMaxValue
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? ChartMaxValue
        {
            get
            {
                return GetSystemInt32(VitalSignMetadata.ColumnNames.ChartMaxValue);
            }

            set
            {
                if (SetSystemInt32(VitalSignMetadata.ColumnNames.ChartMaxValue, value))
                {
                    OnPropertyChanged(VitalSignMetadata.PropertyNames.ChartMaxValue);
                }
            }
        }

        /// <summary>
        /// Maps to VitalSign.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(VitalSignMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(VitalSignMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(VitalSignMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to VitalSign.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(VitalSignMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(VitalSignMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(VitalSignMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Untuk keperluan import data dari PHR
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string QuestionID
        {
            get
            {
                return GetSystemString(VitalSignMetadata.ColumnNames.QuestionID);
            }

            set
            {
                if (SetSystemString(VitalSignMetadata.ColumnNames.QuestionID, value))
                {
                    OnPropertyChanged(VitalSignMetadata.PropertyNames.QuestionID);
                }
            }
        }

        /// <summary>
        /// Maps to VitalSign.ParentVitalSignID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParentVitalSignID
        {
            get
            {
                return GetSystemString(VitalSignMetadata.ColumnNames.ParentVitalSignID);
            }

            set
            {
                if (SetSystemString(VitalSignMetadata.ColumnNames.ParentVitalSignID, value))
                {
                    OnPropertyChanged(VitalSignMetadata.PropertyNames.ParentVitalSignID);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return VitalSignMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public VitalSignQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new VitalSignQuery("vsQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(VitalSignQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(VitalSignQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((VitalSignQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private VitalSignQuery query;
    }



    [Serializable]
    abstract public partial class esVitalSignCollection : esEntityCollection<VitalSign>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return VitalSignMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "VitalSignCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public VitalSignQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new VitalSignQuery("vsQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(VitalSignQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new VitalSignQuery("vsQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(VitalSignQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((VitalSignQuery)query);
        }

        #endregion

        private VitalSignQuery query;
    }



    [Serializable]
    abstract public partial class esVitalSignQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return VitalSignMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "VitalSignID": return VitalSignID;
                case "VitalSignName": return VitalSignName;
                case "VitalSignInitial": return VitalSignInitial;
                case "SRVitalSignGroup": return SRVitalSignGroup;
                case "RowIndexInGroup": return RowIndexInGroup;
                case "ValueType": return ValueType;
                case "StandardReferenceID": return StandardReferenceID;
                case "EntryMask": return EntryMask;
                case "VitalSignUnit": return VitalSignUnit;
                case "NumType": return NumType;
                case "NumDecimalDigits": return NumDecimalDigits;
                case "NumMinValue": return NumMinValue;
                case "NumMaxValue": return NumMaxValue;
                case "NumMaxLength": return NumMaxLength;
                case "IsMonitoring": return IsMonitoring;
                case "IsChart": return IsChart;
                case "ChartColor": return ChartColor;
                case "ChartMinValue": return ChartMinValue;
                case "ChartMaxValue": return ChartMaxValue;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "QuestionID": return QuestionID;
                case "ParentVitalSignID": return ParentVitalSignID;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem VitalSignID
        {
            get { return new esQueryItem(this, VitalSignMetadata.ColumnNames.VitalSignID, esSystemType.String); }
        }

        public esQueryItem VitalSignName
        {
            get { return new esQueryItem(this, VitalSignMetadata.ColumnNames.VitalSignName, esSystemType.String); }
        }

        public esQueryItem VitalSignInitial
        {
            get { return new esQueryItem(this, VitalSignMetadata.ColumnNames.VitalSignInitial, esSystemType.String); }
        }

        public esQueryItem SRVitalSignGroup
        {
            get { return new esQueryItem(this, VitalSignMetadata.ColumnNames.SRVitalSignGroup, esSystemType.String); }
        }

        public esQueryItem RowIndexInGroup
        {
            get { return new esQueryItem(this, VitalSignMetadata.ColumnNames.RowIndexInGroup, esSystemType.Int32); }
        }

        public esQueryItem ValueType
        {
            get { return new esQueryItem(this, VitalSignMetadata.ColumnNames.ValueType, esSystemType.String); }
        }

        public esQueryItem StandardReferenceID
        {
            get { return new esQueryItem(this, VitalSignMetadata.ColumnNames.StandardReferenceID, esSystemType.String); }
        }

        public esQueryItem EntryMask
        {
            get { return new esQueryItem(this, VitalSignMetadata.ColumnNames.EntryMask, esSystemType.String); }
        }

        public esQueryItem VitalSignUnit
        {
            get { return new esQueryItem(this, VitalSignMetadata.ColumnNames.VitalSignUnit, esSystemType.String); }
        }

        public esQueryItem NumType
        {
            get { return new esQueryItem(this, VitalSignMetadata.ColumnNames.NumType, esSystemType.String); }
        }

        public esQueryItem NumDecimalDigits
        {
            get { return new esQueryItem(this, VitalSignMetadata.ColumnNames.NumDecimalDigits, esSystemType.Int32); }
        }

        public esQueryItem NumMinValue
        {
            get { return new esQueryItem(this, VitalSignMetadata.ColumnNames.NumMinValue, esSystemType.Int32); }
        }

        public esQueryItem NumMaxValue
        {
            get { return new esQueryItem(this, VitalSignMetadata.ColumnNames.NumMaxValue, esSystemType.Int32); }
        }

        public esQueryItem NumMaxLength
        {
            get { return new esQueryItem(this, VitalSignMetadata.ColumnNames.NumMaxLength, esSystemType.Int32); }
        }

        public esQueryItem IsMonitoring
        {
            get { return new esQueryItem(this, VitalSignMetadata.ColumnNames.IsMonitoring, esSystemType.Boolean); }
        }

        public esQueryItem IsChart
        {
            get { return new esQueryItem(this, VitalSignMetadata.ColumnNames.IsChart, esSystemType.Boolean); }
        }

        public esQueryItem ChartColor
        {
            get { return new esQueryItem(this, VitalSignMetadata.ColumnNames.ChartColor, esSystemType.Int32); }
        }

        public esQueryItem ChartMinValue
        {
            get { return new esQueryItem(this, VitalSignMetadata.ColumnNames.ChartMinValue, esSystemType.Int32); }
        }

        public esQueryItem ChartMaxValue
        {
            get { return new esQueryItem(this, VitalSignMetadata.ColumnNames.ChartMaxValue, esSystemType.Int32); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, VitalSignMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, VitalSignMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem QuestionID
        {
            get { return new esQueryItem(this, VitalSignMetadata.ColumnNames.QuestionID, esSystemType.String); }
        }

        public esQueryItem ParentVitalSignID
        {
            get { return new esQueryItem(this, VitalSignMetadata.ColumnNames.ParentVitalSignID, esSystemType.String); }
        }

        #endregion

    }



    [Serializable]
    public partial class VitalSignMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected VitalSignMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.VitalSignID, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.VitalSignID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 20;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.VitalSignName, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.VitalSignName;
            c.CharacterMaxLength = 50;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.VitalSignInitial, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.VitalSignInitial;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRVitalSignGroup, 3, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRVitalSignGroup;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.RowIndexInGroup, 4, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.RowIndexInGroup;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ValueType, 5, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ValueType;
            c.CharacterMaxLength = 3;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.StandardReferenceID, 6, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.StandardReferenceID;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.EntryMask, 7, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.EntryMask;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.VitalSignUnit, 8, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.VitalSignUnit;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.NumType, 9, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.NumType;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.NumDecimalDigits, 10, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.NumDecimalDigits;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.NumMinValue, 11, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.NumMinValue;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.NumMaxValue, 12, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.NumMaxValue;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.NumMaxLength, 13, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.NumMaxLength;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsMonitoring, 14, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsMonitoring;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsChart, 15, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsChart;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ChartColor, 16, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.ChartColor;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ChartMinValue, 17, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.ChartMinValue;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ChartMaxValue, 18, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.ChartMaxValue;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 19, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 20, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.QuestionID, 21, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.QuestionID;
            c.CharacterMaxLength = 20;
            c.Description = "Untuk keperluan import data dari PHR";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParentVitalSignID, 22, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParentVitalSignID;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public VitalSignMetadata Meta()
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
            public const string VitalSignID = "VitalSignID";
            public const string VitalSignName = "VitalSignName";
            public const string VitalSignInitial = "VitalSignInitial";
            public const string SRVitalSignGroup = "SRVitalSignGroup";
            public const string RowIndexInGroup = "RowIndexInGroup";
            public const string ValueType = "ValueType";
            public const string StandardReferenceID = "StandardReferenceID";
            public const string EntryMask = "EntryMask";
            public const string VitalSignUnit = "VitalSignUnit";
            public const string NumType = "NumType";
            public const string NumDecimalDigits = "NumDecimalDigits";
            public const string NumMinValue = "NumMinValue";
            public const string NumMaxValue = "NumMaxValue";
            public const string NumMaxLength = "NumMaxLength";
            public const string IsMonitoring = "IsMonitoring";
            public const string IsChart = "IsChart";
            public const string ChartColor = "ChartColor";
            public const string ChartMinValue = "ChartMinValue";
            public const string ChartMaxValue = "ChartMaxValue";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string QuestionID = "QuestionID";
            public const string ParentVitalSignID = "ParentVitalSignID";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string VitalSignID = "VitalSignID";
            public const string VitalSignName = "VitalSignName";
            public const string VitalSignInitial = "VitalSignInitial";
            public const string SRVitalSignGroup = "SRVitalSignGroup";
            public const string RowIndexInGroup = "RowIndexInGroup";
            public const string ValueType = "ValueType";
            public const string StandardReferenceID = "StandardReferenceID";
            public const string EntryMask = "EntryMask";
            public const string VitalSignUnit = "VitalSignUnit";
            public const string NumType = "NumType";
            public const string NumDecimalDigits = "NumDecimalDigits";
            public const string NumMinValue = "NumMinValue";
            public const string NumMaxValue = "NumMaxValue";
            public const string NumMaxLength = "NumMaxLength";
            public const string IsMonitoring = "IsMonitoring";
            public const string IsChart = "IsChart";
            public const string ChartColor = "ChartColor";
            public const string ChartMinValue = "ChartMinValue";
            public const string ChartMaxValue = "ChartMaxValue";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string QuestionID = "QuestionID";
            public const string ParentVitalSignID = "ParentVitalSignID";
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
            lock (typeof(VitalSignMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new VitalSignMetadata();
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


                meta.AddTypeMap("VitalSignID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("VitalSignName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("VitalSignInitial", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRVitalSignGroup", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("RowIndexInGroup", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("ValueType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("StandardReferenceID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("EntryMask", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("VitalSignUnit", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("NumType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("NumDecimalDigits", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("NumMinValue", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("NumMaxValue", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("NumMaxLength", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("IsMonitoring", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsChart", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("ChartColor", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("ChartMinValue", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("ChartMaxValue", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("QuestionID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ParentVitalSignID", new esTypeMap("varchar", "System.String"));



                meta.Source = "VitalSign";
                meta.Destination = "VitalSign";

                meta.spInsert = "proc_VitalSignInsert";
                meta.spUpdate = "proc_VitalSignUpdate";
                meta.spDelete = "proc_VitalSignDelete";
                meta.spLoadAll = "proc_VitalSignLoadAll";
                meta.spLoadByPrimaryKey = "proc_VitalSignLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private VitalSignMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
