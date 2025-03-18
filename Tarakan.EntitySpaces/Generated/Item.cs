
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 3/17/2025 1:56:59 PM
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
    /// Encapsulates the 'Item' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(Item))]
    [XmlType("Item")]
    public partial class Item : esItem
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new Item();
        }

        #region Static Quick Access Methods
        static public void Delete(string itemID)
        {
            var obj = new Item();
            obj.ItemID = itemID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string itemID, esSqlAccessType sqlAccessType)
        {
            var obj = new Item();
            obj.ItemID = itemID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("ItemCollection")]
    public partial class ItemCollection : esItemCollection, IEnumerable<Item>
    {
        public Item FindByPrimaryKey(string itemID)
        {
            return this.SingleOrDefault(e => e.ItemID == itemID);
        }



    }



    [Serializable]
    public partial class ItemQuery : esItemQuery
    {
        public ItemQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public ItemQuery(string joinAlias, out ItemQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "ItemQuery";
        }



        #region Explicit Casts

        public static explicit operator string(ItemQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator ItemQuery(string query)
        {
            return (ItemQuery)SerializeHelper.FromXml(query, typeof(ItemQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esItem : esEntity
    {
        public esItem()
        {

        }

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string itemID)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(itemID);
            else
                return LoadByPrimaryKeyStoredProcedure(itemID);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string itemID)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(itemID);
            else
                return LoadByPrimaryKeyStoredProcedure(itemID);
        }

        private bool LoadByPrimaryKeyDynamic(string itemID)
        {
            ItemQuery query = new ItemQuery("iQ");
            query.Where(query.ItemID == itemID);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string itemID)
        {
            esParameters parms = new esParameters();
            parms.Add("ItemID", itemID);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to Item.ItemID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ItemID
        {
            get
            {
                return GetSystemString(ItemMetadata.ColumnNames.ItemID);
            }

            set
            {
                if (SetSystemString(ItemMetadata.ColumnNames.ItemID, value))
                {
                    OnPropertyChanged(ItemMetadata.PropertyNames.ItemID);
                }
            }
        }

        /// <summary>
        /// Maps to Item.ItemGroupID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ItemGroupID
        {
            get
            {
                return GetSystemString(ItemMetadata.ColumnNames.ItemGroupID);
            }

            set
            {
                if (SetSystemString(ItemMetadata.ColumnNames.ItemGroupID, value))
                {
                    OnPropertyChanged(ItemMetadata.PropertyNames.ItemGroupID);
                }
            }
        }

        /// <summary>
        /// Maps to Item.SRItemType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRItemType
        {
            get
            {
                return GetSystemString(ItemMetadata.ColumnNames.SRItemType);
            }

            set
            {
                if (SetSystemString(ItemMetadata.ColumnNames.SRItemType, value))
                {
                    OnPropertyChanged(ItemMetadata.PropertyNames.SRItemType);
                }
            }
        }

        /// <summary>
        /// Maps to Item.ItemName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ItemName
        {
            get
            {
                return GetSystemString(ItemMetadata.ColumnNames.ItemName);
            }

            set
            {
                if (SetSystemString(ItemMetadata.ColumnNames.ItemName, value))
                {
                    OnPropertyChanged(ItemMetadata.PropertyNames.ItemName);
                }
            }
        }

        /// <summary>
        /// Maps to Item.IsActive
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsActive
        {
            get
            {
                return GetSystemBoolean(ItemMetadata.ColumnNames.IsActive);
            }

            set
            {
                if (SetSystemBoolean(ItemMetadata.ColumnNames.IsActive, value))
                {
                    OnPropertyChanged(ItemMetadata.PropertyNames.IsActive);
                }
            }
        }

        /// <summary>
        /// Maps to Item.Notes
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Notes
        {
            get
            {
                return GetSystemString(ItemMetadata.ColumnNames.Notes);
            }

            set
            {
                if (SetSystemString(ItemMetadata.ColumnNames.Notes, value))
                {
                    OnPropertyChanged(ItemMetadata.PropertyNames.Notes);
                }
            }
        }

        /// <summary>
        /// Maps to Item.ItemIDExternal
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ItemIDExternal
        {
            get
            {
                return GetSystemString(ItemMetadata.ColumnNames.ItemIDExternal);
            }

            set
            {
                if (SetSystemString(ItemMetadata.ColumnNames.ItemIDExternal, value))
                {
                    OnPropertyChanged(ItemMetadata.PropertyNames.ItemIDExternal);
                }
            }
        }

        /// <summary>
        /// Maps to Item.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(ItemMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(ItemMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(ItemMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to Item.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(ItemMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(ItemMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(ItemMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to Item.SRBillingGroup
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRBillingGroup
        {
            get
            {
                return GetSystemString(ItemMetadata.ColumnNames.SRBillingGroup);
            }

            set
            {
                if (SetSystemString(ItemMetadata.ColumnNames.SRBillingGroup, value))
                {
                    OnPropertyChanged(ItemMetadata.PropertyNames.SRBillingGroup);
                }
            }
        }

        /// <summary>
        /// Maps to Item.ProductAccountID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ProductAccountID
        {
            get
            {
                return GetSystemString(ItemMetadata.ColumnNames.ProductAccountID);
            }

            set
            {
                if (SetSystemString(ItemMetadata.ColumnNames.ProductAccountID, value))
                {
                    OnPropertyChanged(ItemMetadata.PropertyNames.ProductAccountID);
                }
            }
        }

        /// <summary>
        /// Maps to Item.IsItemProduction
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsItemProduction
        {
            get
            {
                return GetSystemBoolean(ItemMetadata.ColumnNames.IsItemProduction);
            }

            set
            {
                if (SetSystemBoolean(ItemMetadata.ColumnNames.IsItemProduction, value))
                {
                    OnPropertyChanged(ItemMetadata.PropertyNames.IsItemProduction);
                }
            }
        }

        /// <summary>
        /// Maps to Item.GuarantorID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string GuarantorID
        {
            get
            {
                return GetSystemString(ItemMetadata.ColumnNames.GuarantorID);
            }

            set
            {
                if (SetSystemString(ItemMetadata.ColumnNames.GuarantorID, value))
                {
                    OnPropertyChanged(ItemMetadata.PropertyNames.GuarantorID);
                }
            }
        }

        /// <summary>
        /// Maps to Item.CreatedDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? CreatedDateTime
        {
            get
            {
                return GetSystemDateTime(ItemMetadata.ColumnNames.CreatedDateTime);
            }

            set
            {
                if (SetSystemDateTime(ItemMetadata.ColumnNames.CreatedDateTime, value))
                {
                    OnPropertyChanged(ItemMetadata.PropertyNames.CreatedDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to Item.CreatedByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string CreatedByUserID
        {
            get
            {
                return GetSystemString(ItemMetadata.ColumnNames.CreatedByUserID);
            }

            set
            {
                if (SetSystemString(ItemMetadata.ColumnNames.CreatedByUserID, value))
                {
                    OnPropertyChanged(ItemMetadata.PropertyNames.CreatedByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to Item.IsHasTestResults
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsHasTestResults
        {
            get
            {
                return GetSystemBoolean(ItemMetadata.ColumnNames.IsHasTestResults);
            }

            set
            {
                if (SetSystemBoolean(ItemMetadata.ColumnNames.IsHasTestResults, value))
                {
                    OnPropertyChanged(ItemMetadata.PropertyNames.IsHasTestResults);
                }
            }
        }

        /// <summary>
        /// Maps to Item.IsNeedToBeSterilized
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsNeedToBeSterilized
        {
            get
            {
                return GetSystemBoolean(ItemMetadata.ColumnNames.IsNeedToBeSterilized);
            }

            set
            {
                if (SetSystemBoolean(ItemMetadata.ColumnNames.IsNeedToBeSterilized, value))
                {
                    OnPropertyChanged(ItemMetadata.PropertyNames.IsNeedToBeSterilized);
                }
            }
        }

        /// <summary>
        /// Maps to Item.SRBridgingType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRBridgingType
        {
            get
            {
                return GetSystemString(ItemMetadata.ColumnNames.SRBridgingType);
            }

            set
            {
                if (SetSystemString(ItemMetadata.ColumnNames.SRBridgingType, value))
                {
                    OnPropertyChanged(ItemMetadata.PropertyNames.SRBridgingType);
                }
            }
        }

        /// <summary>
        /// Maps to Item.SRCssdItemGroup
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRCssdItemGroup
        {
            get
            {
                return GetSystemString(ItemMetadata.ColumnNames.SRCssdItemGroup);
            }

            set
            {
                if (SetSystemString(ItemMetadata.ColumnNames.SRCssdItemGroup, value))
                {
                    OnPropertyChanged(ItemMetadata.PropertyNames.SRCssdItemGroup);
                }
            }
        }

        /// <summary>
        /// Maps to Item.SRBpjsItemGroup
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRBpjsItemGroup
        {
            get
            {
                return GetSystemString(ItemMetadata.ColumnNames.SRBpjsItemGroup);
            }

            set
            {
                if (SetSystemString(ItemMetadata.ColumnNames.SRBpjsItemGroup, value))
                {
                    OnPropertyChanged(ItemMetadata.PropertyNames.SRBpjsItemGroup);
                }
            }
        }

        /// <summary>
        /// Maps to Item.SREklaimTariffGroup
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SREklaimTariffGroup
        {
            get
            {
                return GetSystemString(ItemMetadata.ColumnNames.SREklaimTariffGroup);
            }

            set
            {
                if (SetSystemString(ItemMetadata.ColumnNames.SREklaimTariffGroup, value))
                {
                    OnPropertyChanged(ItemMetadata.PropertyNames.SREklaimTariffGroup);
                }
            }
        }

        /// <summary>
        /// Maps to Item.Barcode
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Barcode
        {
            get
            {
                return GetSystemString(ItemMetadata.ColumnNames.Barcode);
            }

            set
            {
                if (SetSystemString(ItemMetadata.ColumnNames.Barcode, value))
                {
                    OnPropertyChanged(ItemMetadata.PropertyNames.Barcode);
                }
            }
        }

        /// <summary>
        /// Maps to Item.Photo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public byte[] Photo
        {
            get
            {
                return GetSystemByteArray(ItemMetadata.ColumnNames.Photo);
            }

            set
            {
                if (SetSystemByteArray(ItemMetadata.ColumnNames.Photo, value))
                {
                    OnPropertyChanged(ItemMetadata.PropertyNames.Photo);
                }
            }
        }

        /// <summary>
        /// Maps to Item.SRItemCategory
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRItemCategory
        {
            get
            {
                return GetSystemString(ItemMetadata.ColumnNames.SRItemCategory);
            }

            set
            {
                if (SetSystemString(ItemMetadata.ColumnNames.SRItemCategory, value))
                {
                    OnPropertyChanged(ItemMetadata.PropertyNames.SRItemCategory);
                }
            }
        }

        /// <summary>
        /// Maps to Item.CssdPackagingCostAmount
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public decimal? CssdPackagingCostAmount
        {
            get
            {
                return GetSystemDecimal(ItemMetadata.ColumnNames.CssdPackagingCostAmount);
            }

            set
            {
                if (SetSystemDecimal(ItemMetadata.ColumnNames.CssdPackagingCostAmount, value))
                {
                    OnPropertyChanged(ItemMetadata.PropertyNames.CssdPackagingCostAmount);
                }
            }
        }

        /// <summary>
        /// Maps to Item.IntervalOrderWarning
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public short? IntervalOrderWarning
        {
            get
            {
                return GetSystemInt16(ItemMetadata.ColumnNames.IntervalOrderWarning);
            }

            set
            {
                if (SetSystemInt16(ItemMetadata.ColumnNames.IntervalOrderWarning, value))
                {
                    OnPropertyChanged(ItemMetadata.PropertyNames.IntervalOrderWarning);
                }
            }
        }

        /// <summary>
        /// Maps to Item.SREklaimFactorGroup
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SREklaimFactorGroup
        {
            get
            {
                return GetSystemString(ItemMetadata.ColumnNames.SREklaimFactorGroup);
            }

            set
            {
                if (SetSystemString(ItemMetadata.ColumnNames.SREklaimFactorGroup, value))
                {
                    OnPropertyChanged(ItemMetadata.PropertyNames.SREklaimFactorGroup);
                }
            }
        }

        /// <summary>
        /// Maps to Item.SRItemSubGroup
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRItemSubGroup
        {
            get
            {
                return GetSystemString(ItemMetadata.ColumnNames.SRItemSubGroup);
            }

            set
            {
                if (SetSystemString(ItemMetadata.ColumnNames.SRItemSubGroup, value))
                {
                    OnPropertyChanged(ItemMetadata.PropertyNames.SRItemSubGroup);
                }
            }
        }

        /// <summary>
        /// Maps to Item.ValidityPeriodFrom
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? ValidityPeriodFrom
        {
            get
            {
                return GetSystemDateTime(ItemMetadata.ColumnNames.ValidityPeriodFrom);
            }

            set
            {
                if (SetSystemDateTime(ItemMetadata.ColumnNames.ValidityPeriodFrom, value))
                {
                    OnPropertyChanged(ItemMetadata.PropertyNames.ValidityPeriodFrom);
                }
            }
        }

        /// <summary>
        /// Maps to Item.ValidityPeriodTo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? ValidityPeriodTo
        {
            get
            {
                return GetSystemDateTime(ItemMetadata.ColumnNames.ValidityPeriodTo);
            }

            set
            {
                if (SetSystemDateTime(ItemMetadata.ColumnNames.ValidityPeriodTo, value))
                {
                    OnPropertyChanged(ItemMetadata.PropertyNames.ValidityPeriodTo);
                }
            }
        }

        /// <summary>
        /// Maps to Item.IsAsset
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsAsset
        {
            get
            {
                return GetSystemBoolean(ItemMetadata.ColumnNames.IsAsset);
            }

            set
            {
                if (SetSystemBoolean(ItemMetadata.ColumnNames.IsAsset, value))
                {
                    OnPropertyChanged(ItemMetadata.PropertyNames.IsAsset);
                }
            }
        }

        /// <summary>
        /// Maps to Item.AssetGroupID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string AssetGroupID
        {
            get
            {
                return GetSystemString(ItemMetadata.ColumnNames.AssetGroupID);
            }

            set
            {
                if (SetSystemString(ItemMetadata.ColumnNames.AssetGroupID, value))
                {
                    OnPropertyChanged(ItemMetadata.PropertyNames.AssetGroupID);
                }
            }
        }

        /// <summary>
        /// Maps to Item.IsDelegationToNurse
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsDelegationToNurse
        {
            get
            {
                return GetSystemBoolean(ItemMetadata.ColumnNames.IsDelegationToNurse);
            }

            set
            {
                if (SetSystemBoolean(ItemMetadata.ColumnNames.IsDelegationToNurse, value))
                {
                    OnPropertyChanged(ItemMetadata.PropertyNames.IsDelegationToNurse);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return ItemMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public ItemQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new ItemQuery("iQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(ItemQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(ItemQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((ItemQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private ItemQuery query;
    }



    [Serializable]
    abstract public partial class esItemCollection : esEntityCollection<Item>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return ItemMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "ItemCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public ItemQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new ItemQuery("iQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(ItemQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new ItemQuery("iQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(ItemQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((ItemQuery)query);
        }

        #endregion

        private ItemQuery query;
    }



    [Serializable]
    abstract public partial class esItemQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return ItemMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "ItemID": return ItemID;
                case "ItemGroupID": return ItemGroupID;
                case "SRItemType": return SRItemType;
                case "ItemName": return ItemName;
                case "IsActive": return IsActive;
                case "Notes": return Notes;
                case "ItemIDExternal": return ItemIDExternal;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "SRBillingGroup": return SRBillingGroup;
                case "ProductAccountID": return ProductAccountID;
                case "IsItemProduction": return IsItemProduction;
                case "GuarantorID": return GuarantorID;
                case "CreatedDateTime": return CreatedDateTime;
                case "CreatedByUserID": return CreatedByUserID;
                case "IsHasTestResults": return IsHasTestResults;
                case "IsNeedToBeSterilized": return IsNeedToBeSterilized;
                case "SRBridgingType": return SRBridgingType;
                case "SRCssdItemGroup": return SRCssdItemGroup;
                case "SRBpjsItemGroup": return SRBpjsItemGroup;
                case "SREklaimTariffGroup": return SREklaimTariffGroup;
                case "Barcode": return Barcode;
                case "Photo": return Photo;
                case "SRItemCategory": return SRItemCategory;
                case "CssdPackagingCostAmount": return CssdPackagingCostAmount;
                case "IntervalOrderWarning": return IntervalOrderWarning;
                case "SREklaimFactorGroup": return SREklaimFactorGroup;
                case "SRItemSubGroup": return SRItemSubGroup;
                case "ValidityPeriodFrom": return ValidityPeriodFrom;
                case "ValidityPeriodTo": return ValidityPeriodTo;
                case "IsAsset": return IsAsset;
                case "AssetGroupID": return AssetGroupID;
                case "IsDelegationToNurse": return IsDelegationToNurse;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem ItemID
        {
            get { return new esQueryItem(this, ItemMetadata.ColumnNames.ItemID, esSystemType.String); }
        }

        public esQueryItem ItemGroupID
        {
            get { return new esQueryItem(this, ItemMetadata.ColumnNames.ItemGroupID, esSystemType.String); }
        }

        public esQueryItem SRItemType
        {
            get { return new esQueryItem(this, ItemMetadata.ColumnNames.SRItemType, esSystemType.String); }
        }

        public esQueryItem ItemName
        {
            get { return new esQueryItem(this, ItemMetadata.ColumnNames.ItemName, esSystemType.String); }
        }

        public esQueryItem IsActive
        {
            get { return new esQueryItem(this, ItemMetadata.ColumnNames.IsActive, esSystemType.Boolean); }
        }

        public esQueryItem Notes
        {
            get { return new esQueryItem(this, ItemMetadata.ColumnNames.Notes, esSystemType.String); }
        }

        public esQueryItem ItemIDExternal
        {
            get { return new esQueryItem(this, ItemMetadata.ColumnNames.ItemIDExternal, esSystemType.String); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, ItemMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, ItemMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem SRBillingGroup
        {
            get { return new esQueryItem(this, ItemMetadata.ColumnNames.SRBillingGroup, esSystemType.String); }
        }

        public esQueryItem ProductAccountID
        {
            get { return new esQueryItem(this, ItemMetadata.ColumnNames.ProductAccountID, esSystemType.String); }
        }

        public esQueryItem IsItemProduction
        {
            get { return new esQueryItem(this, ItemMetadata.ColumnNames.IsItemProduction, esSystemType.Boolean); }
        }

        public esQueryItem GuarantorID
        {
            get { return new esQueryItem(this, ItemMetadata.ColumnNames.GuarantorID, esSystemType.String); }
        }

        public esQueryItem CreatedDateTime
        {
            get { return new esQueryItem(this, ItemMetadata.ColumnNames.CreatedDateTime, esSystemType.DateTime); }
        }

        public esQueryItem CreatedByUserID
        {
            get { return new esQueryItem(this, ItemMetadata.ColumnNames.CreatedByUserID, esSystemType.String); }
        }

        public esQueryItem IsHasTestResults
        {
            get { return new esQueryItem(this, ItemMetadata.ColumnNames.IsHasTestResults, esSystemType.Boolean); }
        }

        public esQueryItem IsNeedToBeSterilized
        {
            get { return new esQueryItem(this, ItemMetadata.ColumnNames.IsNeedToBeSterilized, esSystemType.Boolean); }
        }

        public esQueryItem SRBridgingType
        {
            get { return new esQueryItem(this, ItemMetadata.ColumnNames.SRBridgingType, esSystemType.String); }
        }

        public esQueryItem SRCssdItemGroup
        {
            get { return new esQueryItem(this, ItemMetadata.ColumnNames.SRCssdItemGroup, esSystemType.String); }
        }

        public esQueryItem SRBpjsItemGroup
        {
            get { return new esQueryItem(this, ItemMetadata.ColumnNames.SRBpjsItemGroup, esSystemType.String); }
        }

        public esQueryItem SREklaimTariffGroup
        {
            get { return new esQueryItem(this, ItemMetadata.ColumnNames.SREklaimTariffGroup, esSystemType.String); }
        }

        public esQueryItem Barcode
        {
            get { return new esQueryItem(this, ItemMetadata.ColumnNames.Barcode, esSystemType.String); }
        }

        public esQueryItem Photo
        {
            get { return new esQueryItem(this, ItemMetadata.ColumnNames.Photo, esSystemType.ByteArray); }
        }

        public esQueryItem SRItemCategory
        {
            get { return new esQueryItem(this, ItemMetadata.ColumnNames.SRItemCategory, esSystemType.String); }
        }

        public esQueryItem CssdPackagingCostAmount
        {
            get { return new esQueryItem(this, ItemMetadata.ColumnNames.CssdPackagingCostAmount, esSystemType.Decimal); }
        }

        public esQueryItem IntervalOrderWarning
        {
            get { return new esQueryItem(this, ItemMetadata.ColumnNames.IntervalOrderWarning, esSystemType.Int16); }
        }

        public esQueryItem SREklaimFactorGroup
        {
            get { return new esQueryItem(this, ItemMetadata.ColumnNames.SREklaimFactorGroup, esSystemType.String); }
        }

        public esQueryItem SRItemSubGroup
        {
            get { return new esQueryItem(this, ItemMetadata.ColumnNames.SRItemSubGroup, esSystemType.String); }
        }

        public esQueryItem ValidityPeriodFrom
        {
            get { return new esQueryItem(this, ItemMetadata.ColumnNames.ValidityPeriodFrom, esSystemType.DateTime); }
        }

        public esQueryItem ValidityPeriodTo
        {
            get { return new esQueryItem(this, ItemMetadata.ColumnNames.ValidityPeriodTo, esSystemType.DateTime); }
        }

        public esQueryItem IsAsset
        {
            get { return new esQueryItem(this, ItemMetadata.ColumnNames.IsAsset, esSystemType.Boolean); }
        }

        public esQueryItem AssetGroupID
        {
            get { return new esQueryItem(this, ItemMetadata.ColumnNames.AssetGroupID, esSystemType.String); }
        }

        public esQueryItem IsDelegationToNurse
        {
            get { return new esQueryItem(this, ItemMetadata.ColumnNames.IsDelegationToNurse, esSystemType.Boolean); }
        }

        #endregion

    }



    [Serializable]
    public partial class ItemMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected ItemMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.ItemID, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ItemID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ItemGroupID, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ItemGroupID;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRItemType, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRItemType;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ItemName, 3, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ItemName;
            c.CharacterMaxLength = 200;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsActive, 4, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsActive;
            c.HasDefault = true;
            c.Default = @"((1))";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Notes, 5, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Notes;
            c.CharacterMaxLength = 4000;
            c.HasDefault = true;
            c.Default = @"('')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ItemIDExternal, 6, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ItemIDExternal;
            c.CharacterMaxLength = 20;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
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

            c = new esColumnMetadata(ColumnNames.SRBillingGroup, 9, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRBillingGroup;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ProductAccountID, 10, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ProductAccountID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsItemProduction, 11, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsItemProduction;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.GuarantorID, 12, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.GuarantorID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreatedDateTime, 13, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.CreatedDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CreatedByUserID, 14, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.CreatedByUserID;
            c.CharacterMaxLength = 15;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsHasTestResults, 15, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsHasTestResults;
            c.HasDefault = true;
            c.Default = @"((0))";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsNeedToBeSterilized, 16, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsNeedToBeSterilized;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRBridgingType, 17, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRBridgingType;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRCssdItemGroup, 18, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRCssdItemGroup;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRBpjsItemGroup, 19, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRBpjsItemGroup;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SREklaimTariffGroup, 20, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SREklaimTariffGroup;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Barcode, 21, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Barcode;
            c.CharacterMaxLength = 35;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Photo, 22, typeof(byte[]), esSystemType.ByteArray);
            c.PropertyName = PropertyNames.Photo;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRItemCategory, 23, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRItemCategory;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CssdPackagingCostAmount, 24, typeof(decimal), esSystemType.Decimal);
            c.PropertyName = PropertyNames.CssdPackagingCostAmount;
            c.NumericPrecision = 18;
            c.NumericScale = 2;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IntervalOrderWarning, 25, typeof(short), esSystemType.Int16);
            c.PropertyName = PropertyNames.IntervalOrderWarning;
            c.NumericPrecision = 5;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SREklaimFactorGroup, 26, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SREklaimFactorGroup;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRItemSubGroup, 27, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRItemSubGroup;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ValidityPeriodFrom, 28, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.ValidityPeriodFrom;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ValidityPeriodTo, 29, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.ValidityPeriodTo;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsAsset, 30, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsAsset;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.AssetGroupID, 31, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.AssetGroupID;
            c.CharacterMaxLength = 30;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsDelegationToNurse, 32, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsDelegationToNurse;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public ItemMetadata Meta()
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
            public const string ItemID = "ItemID";
            public const string ItemGroupID = "ItemGroupID";
            public const string SRItemType = "SRItemType";
            public const string ItemName = "ItemName";
            public const string IsActive = "IsActive";
            public const string Notes = "Notes";
            public const string ItemIDExternal = "ItemIDExternal";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string SRBillingGroup = "SRBillingGroup";
            public const string ProductAccountID = "ProductAccountID";
            public const string IsItemProduction = "IsItemProduction";
            public const string GuarantorID = "GuarantorID";
            public const string CreatedDateTime = "CreatedDateTime";
            public const string CreatedByUserID = "CreatedByUserID";
            public const string IsHasTestResults = "IsHasTestResults";
            public const string IsNeedToBeSterilized = "IsNeedToBeSterilized";
            public const string SRBridgingType = "SRBridgingType";
            public const string SRCssdItemGroup = "SRCssdItemGroup";
            public const string SRBpjsItemGroup = "SRBpjsItemGroup";
            public const string SREklaimTariffGroup = "SREklaimTariffGroup";
            public const string Barcode = "Barcode";
            public const string Photo = "Photo";
            public const string SRItemCategory = "SRItemCategory";
            public const string CssdPackagingCostAmount = "CssdPackagingCostAmount";
            public const string IntervalOrderWarning = "IntervalOrderWarning";
            public const string SREklaimFactorGroup = "SREklaimFactorGroup";
            public const string SRItemSubGroup = "SRItemSubGroup";
            public const string ValidityPeriodFrom = "ValidityPeriodFrom";
            public const string ValidityPeriodTo = "ValidityPeriodTo";
            public const string IsAsset = "IsAsset";
            public const string AssetGroupID = "AssetGroupID";
            public const string IsDelegationToNurse = "IsDelegationToNurse";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string ItemID = "ItemID";
            public const string ItemGroupID = "ItemGroupID";
            public const string SRItemType = "SRItemType";
            public const string ItemName = "ItemName";
            public const string IsActive = "IsActive";
            public const string Notes = "Notes";
            public const string ItemIDExternal = "ItemIDExternal";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string SRBillingGroup = "SRBillingGroup";
            public const string ProductAccountID = "ProductAccountID";
            public const string IsItemProduction = "IsItemProduction";
            public const string GuarantorID = "GuarantorID";
            public const string CreatedDateTime = "CreatedDateTime";
            public const string CreatedByUserID = "CreatedByUserID";
            public const string IsHasTestResults = "IsHasTestResults";
            public const string IsNeedToBeSterilized = "IsNeedToBeSterilized";
            public const string SRBridgingType = "SRBridgingType";
            public const string SRCssdItemGroup = "SRCssdItemGroup";
            public const string SRBpjsItemGroup = "SRBpjsItemGroup";
            public const string SREklaimTariffGroup = "SREklaimTariffGroup";
            public const string Barcode = "Barcode";
            public const string Photo = "Photo";
            public const string SRItemCategory = "SRItemCategory";
            public const string CssdPackagingCostAmount = "CssdPackagingCostAmount";
            public const string IntervalOrderWarning = "IntervalOrderWarning";
            public const string SREklaimFactorGroup = "SREklaimFactorGroup";
            public const string SRItemSubGroup = "SRItemSubGroup";
            public const string ValidityPeriodFrom = "ValidityPeriodFrom";
            public const string ValidityPeriodTo = "ValidityPeriodTo";
            public const string IsAsset = "IsAsset";
            public const string AssetGroupID = "AssetGroupID";
            public const string IsDelegationToNurse = "IsDelegationToNurse";
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
            lock (typeof(ItemMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new ItemMetadata();
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


                meta.AddTypeMap("ItemID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ItemGroupID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRItemType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ItemName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsActive", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("Notes", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ItemIDExternal", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRBillingGroup", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ProductAccountID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsItemProduction", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("GuarantorID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CreatedDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("CreatedByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsHasTestResults", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("IsNeedToBeSterilized", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("SRBridgingType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRCssdItemGroup", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRBpjsItemGroup", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SREklaimTariffGroup", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Barcode", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Photo", new esTypeMap("image", "System.Byte[]"));
                meta.AddTypeMap("SRItemCategory", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CssdPackagingCostAmount", new esTypeMap("numeric", "System.Decimal"));
                meta.AddTypeMap("IntervalOrderWarning", new esTypeMap("smallint", "System.Int16"));
                meta.AddTypeMap("SREklaimFactorGroup", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRItemSubGroup", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ValidityPeriodFrom", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("ValidityPeriodTo", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("IsAsset", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("AssetGroupID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsDelegationToNurse", new esTypeMap("bit", "System.Boolean"));



                meta.Source = "Item";
                meta.Destination = "Item";

                meta.spInsert = "proc_ItemInsert";
                meta.spUpdate = "proc_ItemUpdate";
                meta.spDelete = "proc_ItemDelete";
                meta.spLoadAll = "proc_ItemLoadAll";
                meta.spLoadByPrimaryKey = "proc_ItemLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private ItemMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
