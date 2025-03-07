
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 2/12/2025 11:58:56 AM
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
    /// Encapsulates the 'TransChargesItemComp' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(TransChargesItemComp))]
    [XmlType("TransChargesItemComp")]
    public partial class TransChargesItemComp : esTransChargesItemComp
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new TransChargesItemComp();
        }

        #region Static Quick Access Methods
        static public void Delete(string sequenceNo, string tariffComponentID, string transactionNo)
        {
            var obj = new TransChargesItemComp();
            obj.SequenceNo = sequenceNo;
            obj.TariffComponentID = tariffComponentID;
            obj.TransactionNo = transactionNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string sequenceNo, string tariffComponentID, string transactionNo, esSqlAccessType sqlAccessType)
        {
            var obj = new TransChargesItemComp();
            obj.SequenceNo = sequenceNo;
            obj.TariffComponentID = tariffComponentID;
            obj.TransactionNo = transactionNo;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("TransChargesItemCompCollection")]
    public partial class TransChargesItemCompCollection : esTransChargesItemCompCollection, IEnumerable<TransChargesItemComp>
    {
        public TransChargesItemComp FindByPrimaryKey(string sequenceNo, string tariffComponentID, string transactionNo)
        {
            return this.SingleOrDefault(e => e.SequenceNo == sequenceNo && e.TariffComponentID == tariffComponentID && e.TransactionNo == transactionNo);
        }



    }



    [Serializable]
    public partial class TransChargesItemCompQuery : esTransChargesItemCompQuery
    {
        public TransChargesItemCompQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public TransChargesItemCompQuery(string joinAlias, out TransChargesItemCompQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "TransChargesItemCompQuery";
        }



        #region Explicit Casts

        public static explicit operator string(TransChargesItemCompQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator TransChargesItemCompQuery(string query)
        {
            return (TransChargesItemCompQuery)SerializeHelper.FromXml(query, typeof(TransChargesItemCompQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esTransChargesItemComp : esEntity
    {
        public esTransChargesItemComp()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string sequenceNo, string tariffComponentID, string transactionNo)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(sequenceNo, tariffComponentID, transactionNo);
            else
                return LoadByPrimaryKeyStoredProcedure(sequenceNo, tariffComponentID, transactionNo);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string sequenceNo, string tariffComponentID, string transactionNo)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(sequenceNo, tariffComponentID, transactionNo);
            else
                return LoadByPrimaryKeyStoredProcedure(sequenceNo, tariffComponentID, transactionNo);
        }

        private bool LoadByPrimaryKeyDynamic(string sequenceNo, string tariffComponentID, string transactionNo)
        {
            TransChargesItemCompQuery query = new TransChargesItemCompQuery("tcicQ");
            query.Where(query.SequenceNo == sequenceNo, query.TariffComponentID == tariffComponentID, query.TransactionNo == transactionNo);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string sequenceNo, string tariffComponentID, string transactionNo)
        {
            esParameters parms = new esParameters();
            parms.Add("SequenceNo", sequenceNo); parms.Add("TariffComponentID", tariffComponentID); parms.Add("TransactionNo", transactionNo);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to TransChargesItemComp.TransactionNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TransactionNo
        {
            get
            {
                return GetSystemString(TransChargesItemCompMetadata.ColumnNames.TransactionNo);
            }

            set
            {
                if (SetSystemString(TransChargesItemCompMetadata.ColumnNames.TransactionNo, value))
                {
                    OnPropertyChanged(TransChargesItemCompMetadata.PropertyNames.TransactionNo);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItemComp.SequenceNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SequenceNo
        {
            get
            {
                return GetSystemString(TransChargesItemCompMetadata.ColumnNames.SequenceNo);
            }

            set
            {
                if (SetSystemString(TransChargesItemCompMetadata.ColumnNames.SequenceNo, value))
                {
                    OnPropertyChanged(TransChargesItemCompMetadata.PropertyNames.SequenceNo);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItemComp.TariffComponentID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string TariffComponentID
        {
            get
            {
                return GetSystemString(TransChargesItemCompMetadata.ColumnNames.TariffComponentID);
            }

            set
            {
                if (SetSystemString(TransChargesItemCompMetadata.ColumnNames.TariffComponentID, value))
                {
                    OnPropertyChanged(TransChargesItemCompMetadata.PropertyNames.TariffComponentID);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItemComp.Price
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? Price
        {
            get
            {
                return GetSystemDecimal(TransChargesItemCompMetadata.ColumnNames.Price);
            }

            set
            {
                if (SetSystemDecimal(TransChargesItemCompMetadata.ColumnNames.Price, value))
                {
                    OnPropertyChanged(TransChargesItemCompMetadata.PropertyNames.Price);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItemComp.DiscountAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? DiscountAmount
        {
            get
            {
                return GetSystemDecimal(TransChargesItemCompMetadata.ColumnNames.DiscountAmount);
            }

            set
            {
                if (SetSystemDecimal(TransChargesItemCompMetadata.ColumnNames.DiscountAmount, value))
                {
                    OnPropertyChanged(TransChargesItemCompMetadata.PropertyNames.DiscountAmount);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItemComp.ParamedicID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParamedicID
        {
            get
            {
                return GetSystemString(TransChargesItemCompMetadata.ColumnNames.ParamedicID);
            }

            set
            {
                if (SetSystemString(TransChargesItemCompMetadata.ColumnNames.ParamedicID, value))
                {
                    OnPropertyChanged(TransChargesItemCompMetadata.PropertyNames.ParamedicID);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItemComp.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(TransChargesItemCompMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(TransChargesItemCompMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(TransChargesItemCompMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItemComp.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(TransChargesItemCompMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(TransChargesItemCompMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(TransChargesItemCompMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItemComp.IsPackage
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsPackage
        {
            get
            {
                return GetSystemBoolean(TransChargesItemCompMetadata.ColumnNames.IsPackage);
            }

            set
            {
                if (SetSystemBoolean(TransChargesItemCompMetadata.ColumnNames.IsPackage, value))
                {
                    OnPropertyChanged(TransChargesItemCompMetadata.PropertyNames.IsPackage);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItemComp.AutoProcessCalculation
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? AutoProcessCalculation
        {
            get
            {
                return GetSystemDecimal(TransChargesItemCompMetadata.ColumnNames.AutoProcessCalculation);
            }

            set
            {
                if (SetSystemDecimal(TransChargesItemCompMetadata.ColumnNames.AutoProcessCalculation, value))
                {
                    OnPropertyChanged(TransChargesItemCompMetadata.PropertyNames.AutoProcessCalculation);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItemComp.CitoAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? CitoAmount
        {
            get
            {
                return GetSystemDecimal(TransChargesItemCompMetadata.ColumnNames.CitoAmount);
            }

            set
            {
                if (SetSystemDecimal(TransChargesItemCompMetadata.ColumnNames.CitoAmount, value))
                {
                    OnPropertyChanged(TransChargesItemCompMetadata.PropertyNames.CitoAmount);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItemComp.FeeSettledNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string FeeSettledNo
        {
            get
            {
                return GetSystemString(TransChargesItemCompMetadata.ColumnNames.FeeSettledNo);
            }

            set
            {
                if (SetSystemString(TransChargesItemCompMetadata.ColumnNames.FeeSettledNo, value))
                {
                    OnPropertyChanged(TransChargesItemCompMetadata.PropertyNames.FeeSettledNo);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItemComp.FeeCalculated
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? FeeCalculated
        {
            get
            {
                return GetSystemDecimal(TransChargesItemCompMetadata.ColumnNames.FeeCalculated);
            }

            set
            {
                if (SetSystemDecimal(TransChargesItemCompMetadata.ColumnNames.FeeCalculated, value))
                {
                    OnPropertyChanged(TransChargesItemCompMetadata.PropertyNames.FeeCalculated);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItemComp.FeeDiscountPercentage
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? FeeDiscountPercentage
        {
            get
            {
                return GetSystemDecimal(TransChargesItemCompMetadata.ColumnNames.FeeDiscountPercentage);
            }

            set
            {
                if (SetSystemDecimal(TransChargesItemCompMetadata.ColumnNames.FeeDiscountPercentage, value))
                {
                    OnPropertyChanged(TransChargesItemCompMetadata.PropertyNames.FeeDiscountPercentage);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItemComp.FeeDiscount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? FeeDiscount
        {
            get
            {
                return GetSystemDecimal(TransChargesItemCompMetadata.ColumnNames.FeeDiscount);
            }

            set
            {
                if (SetSystemDecimal(TransChargesItemCompMetadata.ColumnNames.FeeDiscount, value))
                {
                    OnPropertyChanged(TransChargesItemCompMetadata.PropertyNames.FeeDiscount);
                }
            }
        }

        /// <summary>
        /// Maps to TransChargesItemComp.PriceAdjusted
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? PriceAdjusted
        {
            get
            {
                return GetSystemDecimal(TransChargesItemCompMetadata.ColumnNames.PriceAdjusted);
            }

            set
            {
                if (SetSystemDecimal(TransChargesItemCompMetadata.ColumnNames.PriceAdjusted, value))
                {
                    OnPropertyChanged(TransChargesItemCompMetadata.PropertyNames.PriceAdjusted);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return TransChargesItemCompMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public TransChargesItemCompQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new TransChargesItemCompQuery("tcicQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(TransChargesItemCompQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(TransChargesItemCompQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((TransChargesItemCompQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private TransChargesItemCompQuery query;
    }



    [Serializable]
    abstract public partial class esTransChargesItemCompCollection : esEntityCollection<TransChargesItemComp>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return TransChargesItemCompMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "TransChargesItemCompCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public TransChargesItemCompQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new TransChargesItemCompQuery("tcicQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(TransChargesItemCompQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new TransChargesItemCompQuery("tcicQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(TransChargesItemCompQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((TransChargesItemCompQuery)query);
        }

        #endregion

        private TransChargesItemCompQuery query;
    }



    [Serializable]
    abstract public partial class esTransChargesItemCompQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return TransChargesItemCompMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "TransactionNo": return TransactionNo;
                case "SequenceNo": return SequenceNo;
                case "TariffComponentID": return TariffComponentID;
                case "Price": return Price;
                case "DiscountAmount": return DiscountAmount;
                case "ParamedicID": return ParamedicID;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "IsPackage": return IsPackage;
                case "AutoProcessCalculation": return AutoProcessCalculation;
                case "CitoAmount": return CitoAmount;
                case "FeeSettledNo": return FeeSettledNo;
                case "FeeCalculated": return FeeCalculated;
                case "FeeDiscountPercentage": return FeeDiscountPercentage;
                case "FeeDiscount": return FeeDiscount;
                case "PriceAdjusted": return PriceAdjusted;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem TransactionNo
        {
            get { return new esQueryItem(this, TransChargesItemCompMetadata.ColumnNames.TransactionNo, esSystemType.String); }
        }

        public esQueryItem SequenceNo
        {
            get { return new esQueryItem(this, TransChargesItemCompMetadata.ColumnNames.SequenceNo, esSystemType.String); }
        }

        public esQueryItem TariffComponentID
        {
            get { return new esQueryItem(this, TransChargesItemCompMetadata.ColumnNames.TariffComponentID, esSystemType.String); }
        }

        public esQueryItem Price
        {
            get { return new esQueryItem(this, TransChargesItemCompMetadata.ColumnNames.Price, esSystemType.Decimal); }
        }

        public esQueryItem DiscountAmount
        {
            get { return new esQueryItem(this, TransChargesItemCompMetadata.ColumnNames.DiscountAmount, esSystemType.Decimal); }
        }

        public esQueryItem ParamedicID
        {
            get { return new esQueryItem(this, TransChargesItemCompMetadata.ColumnNames.ParamedicID, esSystemType.String); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, TransChargesItemCompMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, TransChargesItemCompMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem IsPackage
        {
            get { return new esQueryItem(this, TransChargesItemCompMetadata.ColumnNames.IsPackage, esSystemType.Boolean); }
        }

        public esQueryItem AutoProcessCalculation
        {
            get { return new esQueryItem(this, TransChargesItemCompMetadata.ColumnNames.AutoProcessCalculation, esSystemType.Decimal); }
        }

        public esQueryItem CitoAmount
        {
            get { return new esQueryItem(this, TransChargesItemCompMetadata.ColumnNames.CitoAmount, esSystemType.Decimal); }
        }

        public esQueryItem FeeSettledNo
        {
            get { return new esQueryItem(this, TransChargesItemCompMetadata.ColumnNames.FeeSettledNo, esSystemType.String); }
        }

        public esQueryItem FeeCalculated
        {
            get { return new esQueryItem(this, TransChargesItemCompMetadata.ColumnNames.FeeCalculated, esSystemType.Decimal); }
        }

        public esQueryItem FeeDiscountPercentage
        {
            get { return new esQueryItem(this, TransChargesItemCompMetadata.ColumnNames.FeeDiscountPercentage, esSystemType.Decimal); }
        }

        public esQueryItem FeeDiscount
        {
            get { return new esQueryItem(this, TransChargesItemCompMetadata.ColumnNames.FeeDiscount, esSystemType.Decimal); }
        }

        public esQueryItem PriceAdjusted
        {
            get { return new esQueryItem(this, TransChargesItemCompMetadata.ColumnNames.PriceAdjusted, esSystemType.Decimal); }
        }

        #endregion

    }



    [Serializable]
    public partial class TransChargesItemCompMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected TransChargesItemCompMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.TransactionNo, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TransactionNo;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SequenceNo, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SequenceNo;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 12;
            c.HasDefault = true;
            c.Default = @"('000')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.TariffComponentID, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.TariffComponentID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 2;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Price, 3, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.Price;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.DiscountAmount, 4, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.DiscountAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParamedicID, 5, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParamedicID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 6, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 7, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 40;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsPackage, 8, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsPackage;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AutoProcessCalculation, 9, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.AutoProcessCalculation;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CitoAmount, 10, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.CitoAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FeeSettledNo, 11, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.FeeSettledNo;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FeeCalculated, 12, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.FeeCalculated;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FeeDiscountPercentage, 13, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.FeeDiscountPercentage;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.FeeDiscount, 14, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.FeeDiscount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PriceAdjusted, 15, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.PriceAdjusted;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public TransChargesItemCompMetadata Meta()
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
            public const string TransactionNo = "TransactionNo";
            public const string SequenceNo = "SequenceNo";
            public const string TariffComponentID = "TariffComponentID";
            public const string Price = "Price";
            public const string DiscountAmount = "DiscountAmount";
            public const string ParamedicID = "ParamedicID";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string IsPackage = "IsPackage";
            public const string AutoProcessCalculation = "AutoProcessCalculation";
            public const string CitoAmount = "CitoAmount";
            public const string FeeSettledNo = "FeeSettledNo";
            public const string FeeCalculated = "FeeCalculated";
            public const string FeeDiscountPercentage = "FeeDiscountPercentage";
            public const string FeeDiscount = "FeeDiscount";
            public const string PriceAdjusted = "PriceAdjusted";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string TransactionNo = "TransactionNo";
            public const string SequenceNo = "SequenceNo";
            public const string TariffComponentID = "TariffComponentID";
            public const string Price = "Price";
            public const string DiscountAmount = "DiscountAmount";
            public const string ParamedicID = "ParamedicID";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string IsPackage = "IsPackage";
            public const string AutoProcessCalculation = "AutoProcessCalculation";
            public const string CitoAmount = "CitoAmount";
            public const string FeeSettledNo = "FeeSettledNo";
            public const string FeeCalculated = "FeeCalculated";
            public const string FeeDiscountPercentage = "FeeDiscountPercentage";
            public const string FeeDiscount = "FeeDiscount";
            public const string PriceAdjusted = "PriceAdjusted";
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
            lock (typeof(TransChargesItemCompMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new TransChargesItemCompMetadata();
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


                meta.AddTypeMap("TransactionNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SequenceNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("TariffComponentID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Price", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("DiscountAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("ParamedicID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsPackage", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("AutoProcessCalculation", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("CitoAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("FeeSettledNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("FeeCalculated", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("FeeDiscountPercentage", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("FeeDiscount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("PriceAdjusted", new esTypeMap("decimal", "System.Decimal"));



                meta.Source = "TransChargesItemComp";
                meta.Destination = "TransChargesItemComp";

                meta.spInsert = "proc_TransChargesItemCompInsert";
                meta.spUpdate = "proc_TransChargesItemCompUpdate";
                meta.spDelete = "proc_TransChargesItemCompDelete";
                meta.spLoadAll = "proc_TransChargesItemCompLoadAll";
                meta.spLoadByPrimaryKey = "proc_TransChargesItemCompLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private TransChargesItemCompMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
