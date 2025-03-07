
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 8/1/2024 10:25:36 AM
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
    /// Encapsulates the 'AppUser' table
    /// </summary>

    [Serializable]
    [DataContract]
    [KnownType(typeof(AppUser))]
    [XmlType("AppUser")]
    public partial class AppUser : esAppUser
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

        override public esEntity CreateInstance()
        {
            return new AppUser();
        }

        #region Static Quick Access Methods
        static public void Delete(string userID)
        {
            var obj = new AppUser();
            obj.UserID = userID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save();
        }

        static public void Delete(string userID, esSqlAccessType sqlAccessType)
        {
            var obj = new AppUser();
            obj.UserID = userID;
            obj.AcceptChanges();
            obj.MarkAsDeleted();
            obj.Save(sqlAccessType);
        }
        #endregion





    }



    [Serializable]
    [CollectionDataContract]
    [XmlType("AppUserCollection")]
    public partial class AppUserCollection : esAppUserCollection, IEnumerable<AppUser>
    {
        public AppUser FindByPrimaryKey(string userID)
        {
            return this.SingleOrDefault(e => e.UserID == userID);
        }



    }



    [Serializable]
    public partial class AppUserQuery : esAppUserQuery
    {
        public AppUserQuery(string joinAlias)
        {
            es.JoinAlias = joinAlias;
        }

        public AppUserQuery(string joinAlias, out AppUserQuery query)
        {
            query = this;
            es.JoinAlias = joinAlias;
        }

        override protected string GetQueryName()
        {
            return "AppUserQuery";
        }



        #region Explicit Casts

        public static explicit operator string(AppUserQuery query)
        {
            return SerializeHelper.ToXml(query);
        }

        public static explicit operator AppUserQuery(string query)
        {
            return (AppUserQuery)SerializeHelper.FromXml(query, typeof(AppUserQuery));
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    abstract public partial class esAppUser : esEntity
    {
        public esAppUser()
        {

        }

        #region LoadByPrimaryKey Login
        public virtual bool LoadByPrimaryKey(string userID, string password)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(userID, password);
            else
                return LoadByPrimaryKeyStoredProcedure(userID, password);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string userID, string password)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(userID, password);
            else
                return LoadByPrimaryKeyStoredProcedure(userID, password);
        }

        private bool LoadByPrimaryKeyDynamic(string userID, string password)
        {
            AppUserQuery query = new AppUserQuery("auQ");
            query.Where(query.UserID == userID, query.Password == password);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string userID, string password)
        {
            esParameters parms = new esParameters();
            parms.Add("UserID", userID);
            parms.Add("Password", password);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region LoadByPrimaryKey
        public virtual bool LoadByPrimaryKey(string userID)
        {
            if (es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(userID);
            else
                return LoadByPrimaryKeyStoredProcedure(userID);
        }

        public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, string userID)
        {
            if (sqlAccessType == esSqlAccessType.DynamicSQL)
                return LoadByPrimaryKeyDynamic(userID);
            else
                return LoadByPrimaryKeyStoredProcedure(userID);
        }

        private bool LoadByPrimaryKeyDynamic(string userID)
        {
            AppUserQuery query = new AppUserQuery("auQ");
            query.Where(query.UserID == userID);
            return Load(query);
        }

        private bool LoadByPrimaryKeyStoredProcedure(string userID)
        {
            esParameters parms = new esParameters();
            parms.Add("UserID", userID);
            return Load(esQueryType.StoredProcedure, es.spLoadByPrimaryKey, parms);
        }
        #endregion

        #region Properties



        /// <summary>
        /// Maps to AppUser.UserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string UserID
        {
            get
            {
                return GetSystemString(AppUserMetadata.ColumnNames.UserID);
            }

            set
            {
                if (SetSystemString(AppUserMetadata.ColumnNames.UserID, value))
                {
                    OnPropertyChanged(AppUserMetadata.PropertyNames.UserID);
                }
            }
        }

        /// <summary>
        /// Maps to AppUser.UserName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string UserName
        {
            get
            {
                return GetSystemString(AppUserMetadata.ColumnNames.UserName);
            }

            set
            {
                if (SetSystemString(AppUserMetadata.ColumnNames.UserName, value))
                {
                    OnPropertyChanged(AppUserMetadata.PropertyNames.UserName);
                }
            }
        }

        /// <summary>
        /// Maps to AppUser.Password
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Password
        {
            get
            {
                return GetSystemString(AppUserMetadata.ColumnNames.Password);
            }

            set
            {
                if (SetSystemString(AppUserMetadata.ColumnNames.Password, value))
                {
                    OnPropertyChanged(AppUserMetadata.PropertyNames.Password);
                }
            }
        }

        /// <summary>
        /// Maps to AppUser.SRLanguage
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRLanguage
        {
            get
            {
                return GetSystemString(AppUserMetadata.ColumnNames.SRLanguage);
            }

            set
            {
                if (SetSystemString(AppUserMetadata.ColumnNames.SRLanguage, value))
                {
                    OnPropertyChanged(AppUserMetadata.PropertyNames.SRLanguage);
                }
            }
        }

        /// <summary>
        /// Maps to AppUser.ActiveDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? ActiveDate
        {
            get
            {
                return GetSystemDateTime(AppUserMetadata.ColumnNames.ActiveDate);
            }

            set
            {
                if (SetSystemDateTime(AppUserMetadata.ColumnNames.ActiveDate, value))
                {
                    OnPropertyChanged(AppUserMetadata.PropertyNames.ActiveDate);
                }
            }
        }

        /// <summary>
        /// Maps to AppUser.ExpireDate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? ExpireDate
        {
            get
            {
                return GetSystemDateTime(AppUserMetadata.ColumnNames.ExpireDate);
            }

            set
            {
                if (SetSystemDateTime(AppUserMetadata.ColumnNames.ExpireDate, value))
                {
                    OnPropertyChanged(AppUserMetadata.PropertyNames.ExpireDate);
                }
            }
        }

        /// <summary>
        /// Maps to AppUser.LastUpdateDateTime
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastUpdateDateTime
        {
            get
            {
                return GetSystemDateTime(AppUserMetadata.ColumnNames.LastUpdateDateTime);
            }

            set
            {
                if (SetSystemDateTime(AppUserMetadata.ColumnNames.LastUpdateDateTime, value))
                {
                    OnPropertyChanged(AppUserMetadata.PropertyNames.LastUpdateDateTime);
                }
            }
        }

        /// <summary>
        /// Maps to AppUser.LastUpdateByUserID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastUpdateByUserID
        {
            get
            {
                return GetSystemString(AppUserMetadata.ColumnNames.LastUpdateByUserID);
            }

            set
            {
                if (SetSystemString(AppUserMetadata.ColumnNames.LastUpdateByUserID, value))
                {
                    OnPropertyChanged(AppUserMetadata.PropertyNames.LastUpdateByUserID);
                }
            }
        }

        /// <summary>
        /// Maps to AppUser.ParamedicID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ParamedicID
        {
            get
            {
                return GetSystemString(AppUserMetadata.ColumnNames.ParamedicID);
            }

            set
            {
                if (SetSystemString(AppUserMetadata.ColumnNames.ParamedicID, value))
                {
                    OnPropertyChanged(AppUserMetadata.PropertyNames.ParamedicID);
                }
            }
        }

        /// <summary>
        /// Maps to AppUser.ServiceUnitID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ServiceUnitID
        {
            get
            {
                return GetSystemString(AppUserMetadata.ColumnNames.ServiceUnitID);
            }

            set
            {
                if (SetSystemString(AppUserMetadata.ColumnNames.ServiceUnitID, value))
                {
                    OnPropertyChanged(AppUserMetadata.PropertyNames.ServiceUnitID);
                }
            }
        }

        /// <summary>
        /// Maps to AppUser.LicenseNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LicenseNo
        {
            get
            {
                return GetSystemString(AppUserMetadata.ColumnNames.LicenseNo);
            }

            set
            {
                if (SetSystemString(AppUserMetadata.ColumnNames.LicenseNo, value))
                {
                    OnPropertyChanged(AppUserMetadata.PropertyNames.LicenseNo);
                }
            }
        }

        /// <summary>
        /// Maps to AppUser.PersonID
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public int? PersonID
        {
            get
            {
                return GetSystemInt32(AppUserMetadata.ColumnNames.PersonID);
            }

            set
            {
                if (SetSystemInt32(AppUserMetadata.ColumnNames.PersonID, value))
                {
                    OnPropertyChanged(AppUserMetadata.PropertyNames.PersonID);
                }
            }
        }

        /// <summary>
        /// Maps to AppUser.Email
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string Email
        {
            get
            {
                return GetSystemString(AppUserMetadata.ColumnNames.Email);
            }

            set
            {
                if (SetSystemString(AppUserMetadata.ColumnNames.Email, value))
                {
                    OnPropertyChanged(AppUserMetadata.PropertyNames.Email);
                }
            }
        }

        /// <summary>
        /// Maps to AppUser.IsLocked
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public bool? IsLocked
        {
            get
            {
                return GetSystemBoolean(AppUserMetadata.ColumnNames.IsLocked);
            }

            set
            {
                if (SetSystemBoolean(AppUserMetadata.ColumnNames.IsLocked, value))
                {
                    OnPropertyChanged(AppUserMetadata.PropertyNames.IsLocked);
                }
            }
        }

        /// <summary>
        /// Maps to AppUser.SRUserType
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string SRUserType
        {
            get
            {
                return GetSystemString(AppUserMetadata.ColumnNames.SRUserType);
            }

            set
            {
                if (SetSystemString(AppUserMetadata.ColumnNames.SRUserType, value))
                {
                    OnPropertyChanged(AppUserMetadata.PropertyNames.SRUserType);
                }
            }
        }

        /// <summary>
        /// Maps to AppUser.CashManagementNo
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string CashManagementNo
        {
            get
            {
                return GetSystemString(AppUserMetadata.ColumnNames.CashManagementNo);
            }

            set
            {
                if (SetSystemString(AppUserMetadata.ColumnNames.CashManagementNo, value))
                {
                    OnPropertyChanged(AppUserMetadata.PropertyNames.CashManagementNo);
                }
            }
        }

        /// <summary>
        /// Maps to AppUser.SignatureImage
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public byte[] SignatureImage
        {
            get
            {
                return GetSystemByteArray(AppUserMetadata.ColumnNames.SignatureImage);
            }

            set
            {
                if (SetSystemByteArray(AppUserMetadata.ColumnNames.SignatureImage, value))
                {
                    OnPropertyChanged(AppUserMetadata.PropertyNames.SignatureImage);
                }
            }
        }

        /// <summary>
        /// Maps to AppUser.LastCounterName
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string LastCounterName
        {
            get
            {
                return GetSystemString(AppUserMetadata.ColumnNames.LastCounterName);
            }

            set
            {
                if (SetSystemString(AppUserMetadata.ColumnNames.LastCounterName, value))
                {
                    OnPropertyChanged(AppUserMetadata.PropertyNames.LastCounterName);
                }
            }
        }

        /// <summary>
        /// Maps to AppUser.PasswordMd5
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string PasswordMd5
        {
            get
            {
                return GetSystemString(AppUserMetadata.ColumnNames.PasswordMd5);
            }

            set
            {
                if (SetSystemString(AppUserMetadata.ColumnNames.PasswordMd5, value))
                {
                    OnPropertyChanged(AppUserMetadata.PropertyNames.PasswordMd5);
                }
            }
        }

        /// <summary>
        /// Maps to AppUser.LastLogin
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public DateTime? LastLogin
        {
            get
            {
                return GetSystemDateTime(AppUserMetadata.ColumnNames.LastLogin);
            }

            set
            {
                if (SetSystemDateTime(AppUserMetadata.ColumnNames.LastLogin, value))
                {
                    OnPropertyChanged(AppUserMetadata.PropertyNames.LastLogin);
                }
            }
        }

        /// <summary>
        /// Maps to AppUser.ESignNik
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string ESignNik
        {
            get
            {
                return GetSystemString(AppUserMetadata.ColumnNames.ESignNik);
            }

            set
            {
                if (SetSystemString(AppUserMetadata.ColumnNames.ESignNik, value))
                {
                    OnPropertyChanged(AppUserMetadata.PropertyNames.ESignNik);
                }
            }
        }

        /// <summary>
        /// Maps to AppUser.EmployeeNumber
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        virtual public string EmployeeNumber
        {
            get
            {
                return GetSystemString(AppUserMetadata.ColumnNames.EmployeeNumber);
            }

            set
            {
                if (SetSystemString(AppUserMetadata.ColumnNames.EmployeeNumber, value))
                {
                    OnPropertyChanged(AppUserMetadata.PropertyNames.EmployeeNumber);
                }
            }
        }

        #endregion

        #region Housekeeping methods

        override protected IMetadata Meta
        {
            get
            {
                return AppUserMetadata.Meta();
            }
        }

        #endregion

        #region Query Logic

        public AppUserQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new AppUserQuery("auQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(AppUserQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        protected void InitQuery(AppUserQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntity)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((AppUserQuery)query);
        }

        #endregion

        [IgnoreDataMember]
        private AppUserQuery query;
    }



    [Serializable]
    abstract public partial class esAppUserCollection : esEntityCollection<AppUser>
    {
        #region Housekeeping methods
        override protected IMetadata Meta
        {
            get
            {
                return AppUserMetadata.Meta();
            }
        }

        protected override string GetCollectionName()
        {
            return "AppUserCollection";
        }

        #endregion

        #region Query Logic

#if (!WindowsCE)
        [Browsable(false)]
#endif
        public AppUserQuery Query
        {
            get
            {
                if (query == null)
                {
                    query = new AppUserQuery("auQ");
                    InitQuery(query);
                }

                return query;
            }
        }

        public bool Load(AppUserQuery query)
        {
            this.query = query;
            InitQuery(this.query);
            return Query.Load();
        }

        override protected esDynamicQuery GetDynamicQuery()
        {
            if (query == null)
            {
                query = new AppUserQuery("auQ");
                InitQuery(query);
            }
            return query;
        }

        protected void InitQuery(AppUserQuery query)
        {
            query.OnLoadDelegate = OnQueryLoaded;

            if (!query.es2.HasConnection)
            {
                query.es2.Connection = ((IEntityCollection)this).Connection;
            }
        }

        protected override void HookupQuery(esDynamicQuery query)
        {
            InitQuery((AppUserQuery)query);
        }

        #endregion

        private AppUserQuery query;
    }



    [Serializable]
    abstract public partial class esAppUserQuery : esDynamicQuery
    {
        override protected IMetadata Meta
        {
            get
            {
                return AppUserMetadata.Meta();
            }
        }

        #region QueryItemFromName

        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
                case "UserID": return UserID;
                case "UserName": return UserName;
                case "Password": return Password;
                case "SRLanguage": return SRLanguage;
                case "ActiveDate": return ActiveDate;
                case "ExpireDate": return ExpireDate;
                case "LastUpdateDateTime": return LastUpdateDateTime;
                case "LastUpdateByUserID": return LastUpdateByUserID;
                case "ParamedicID": return ParamedicID;
                case "ServiceUnitID": return ServiceUnitID;
                case "LicenseNo": return LicenseNo;
                case "PersonID": return PersonID;
                case "Email": return Email;
                case "IsLocked": return IsLocked;
                case "SRUserType": return SRUserType;
                case "CashManagementNo": return CashManagementNo;
                case "SignatureImage": return SignatureImage;
                case "LastCounterName": return LastCounterName;
                case "PasswordMd5": return PasswordMd5;
                case "LastLogin": return LastLogin;
                case "ESignNik": return ESignNik;
                case "EmployeeNumber": return EmployeeNumber;

                default: return null;
            }
        }

        #endregion

        #region esQueryItems

        public esQueryItem UserID
        {
            get { return new esQueryItem(this, AppUserMetadata.ColumnNames.UserID, esSystemType.String); }
        }

        public esQueryItem UserName
        {
            get { return new esQueryItem(this, AppUserMetadata.ColumnNames.UserName, esSystemType.String); }
        }

        public esQueryItem Password
        {
            get { return new esQueryItem(this, AppUserMetadata.ColumnNames.Password, esSystemType.String); }
        }

        public esQueryItem SRLanguage
        {
            get { return new esQueryItem(this, AppUserMetadata.ColumnNames.SRLanguage, esSystemType.String); }
        }

        public esQueryItem ActiveDate
        {
            get { return new esQueryItem(this, AppUserMetadata.ColumnNames.ActiveDate, esSystemType.DateTime); }
        }

        public esQueryItem ExpireDate
        {
            get { return new esQueryItem(this, AppUserMetadata.ColumnNames.ExpireDate, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateDateTime
        {
            get { return new esQueryItem(this, AppUserMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
        }

        public esQueryItem LastUpdateByUserID
        {
            get { return new esQueryItem(this, AppUserMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
        }

        public esQueryItem ParamedicID
        {
            get { return new esQueryItem(this, AppUserMetadata.ColumnNames.ParamedicID, esSystemType.String); }
        }

        public esQueryItem ServiceUnitID
        {
            get { return new esQueryItem(this, AppUserMetadata.ColumnNames.ServiceUnitID, esSystemType.String); }
        }

        public esQueryItem LicenseNo
        {
            get { return new esQueryItem(this, AppUserMetadata.ColumnNames.LicenseNo, esSystemType.String); }
        }

        public esQueryItem PersonID
        {
            get { return new esQueryItem(this, AppUserMetadata.ColumnNames.PersonID, esSystemType.Int32); }
        }

        public esQueryItem Email
        {
            get { return new esQueryItem(this, AppUserMetadata.ColumnNames.Email, esSystemType.String); }
        }

        public esQueryItem IsLocked
        {
            get { return new esQueryItem(this, AppUserMetadata.ColumnNames.IsLocked, esSystemType.Boolean); }
        }

        public esQueryItem SRUserType
        {
            get { return new esQueryItem(this, AppUserMetadata.ColumnNames.SRUserType, esSystemType.String); }
        }

        public esQueryItem CashManagementNo
        {
            get { return new esQueryItem(this, AppUserMetadata.ColumnNames.CashManagementNo, esSystemType.String); }
        }

        public esQueryItem SignatureImage
        {
            get { return new esQueryItem(this, AppUserMetadata.ColumnNames.SignatureImage, esSystemType.ByteArray); }
        }

        public esQueryItem LastCounterName
        {
            get { return new esQueryItem(this, AppUserMetadata.ColumnNames.LastCounterName, esSystemType.String); }
        }

        public esQueryItem PasswordMd5
        {
            get { return new esQueryItem(this, AppUserMetadata.ColumnNames.PasswordMd5, esSystemType.String); }
        }

        public esQueryItem LastLogin
        {
            get { return new esQueryItem(this, AppUserMetadata.ColumnNames.LastLogin, esSystemType.DateTime); }
        }

        public esQueryItem ESignNik
        {
            get { return new esQueryItem(this, AppUserMetadata.ColumnNames.ESignNik, esSystemType.String); }
        }

        public esQueryItem EmployeeNumber
        {
            get { return new esQueryItem(this, AppUserMetadata.ColumnNames.EmployeeNumber, esSystemType.String); }
        }

        #endregion

    }



    [Serializable]
    public partial class AppUserMetadata : esMetadata, IMetadata
    {
        #region Protected Constructor
        protected AppUserMetadata()
        {
            m_columns = new esColumnMetadataCollection();
            esColumnMetadata c;

            c = new esColumnMetadata(ColumnNames.UserID, 0, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.UserID;
            c.IsInPrimaryKey = true;
            c.CharacterMaxLength = 20;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.UserName, 1, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.UserName;
            c.CharacterMaxLength = 50;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Password, 2, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Password;
            c.CharacterMaxLength = 5000;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRLanguage, 3, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRLanguage;
            c.CharacterMaxLength = 10;
            c.HasDefault = true;
            c.Default = @"('id-ID')";
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ActiveDate, 4, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.ActiveDate;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ExpireDate, 5, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.ExpireDate;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateDateTime, 6, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastUpdateDateTime;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastUpdateByUserID, 7, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastUpdateByUserID;
            c.CharacterMaxLength = 40;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ParamedicID, 8, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ParamedicID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ServiceUnitID, 9, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ServiceUnitID;
            c.CharacterMaxLength = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LicenseNo, 10, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LicenseNo;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PersonID, 11, typeof(int), esSystemType.Int32);
            c.PropertyName = PropertyNames.PersonID;
            c.NumericPrecision = 10;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.Email, 12, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.Email;
            c.CharacterMaxLength = 300;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.IsLocked, 13, typeof(bool), esSystemType.Boolean);
            c.PropertyName = PropertyNames.IsLocked;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SRUserType, 14, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.SRUserType;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.CashManagementNo, 15, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.CashManagementNo;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.SignatureImage, 16, typeof(byte[]), esSystemType.ByteArray);
            c.PropertyName = PropertyNames.SignatureImage;
            c.CharacterMaxLength = 2147483647;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastCounterName, 17, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.LastCounterName;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.PasswordMd5, 18, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.PasswordMd5;
            c.CharacterMaxLength = 5000;
            c.HasDefault = true;
            c.Default = @"('')";
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.LastLogin, 19, typeof(DateTime), esSystemType.DateTime);
            c.PropertyName = PropertyNames.LastLogin;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.ESignNik, 20, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.ESignNik;
            c.CharacterMaxLength = 20;
            c.IsNullable = true;
            m_columns.Add(c);

            c = new esColumnMetadata(ColumnNames.EmployeeNumber, 21, typeof(string), esSystemType.String);
            c.PropertyName = PropertyNames.EmployeeNumber;
            c.CharacterMaxLength = 50;
            c.IsNullable = true;
            m_columns.Add(c);

        }
        #endregion

        static public AppUserMetadata Meta()
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
            public const string UserID = "UserID";
            public const string UserName = "UserName";
            public const string Password = "Password";
            public const string SRLanguage = "SRLanguage";
            public const string ActiveDate = "ActiveDate";
            public const string ExpireDate = "ExpireDate";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string ParamedicID = "ParamedicID";
            public const string ServiceUnitID = "ServiceUnitID";
            public const string LicenseNo = "LicenseNo";
            public const string PersonID = "PersonID";
            public const string Email = "Email";
            public const string IsLocked = "IsLocked";
            public const string SRUserType = "SRUserType";
            public const string CashManagementNo = "CashManagementNo";
            public const string SignatureImage = "SignatureImage";
            public const string LastCounterName = "LastCounterName";
            public const string PasswordMd5 = "PasswordMd5";
            public const string LastLogin = "LastLogin";
            public const string ESignNik = "ESignNik";
            public const string EmployeeNumber = "EmployeeNumber";
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string UserID = "UserID";
            public const string UserName = "UserName";
            public const string Password = "Password";
            public const string SRLanguage = "SRLanguage";
            public const string ActiveDate = "ActiveDate";
            public const string ExpireDate = "ExpireDate";
            public const string LastUpdateDateTime = "LastUpdateDateTime";
            public const string LastUpdateByUserID = "LastUpdateByUserID";
            public const string ParamedicID = "ParamedicID";
            public const string ServiceUnitID = "ServiceUnitID";
            public const string LicenseNo = "LicenseNo";
            public const string PersonID = "PersonID";
            public const string Email = "Email";
            public const string IsLocked = "IsLocked";
            public const string SRUserType = "SRUserType";
            public const string CashManagementNo = "CashManagementNo";
            public const string SignatureImage = "SignatureImage";
            public const string LastCounterName = "LastCounterName";
            public const string PasswordMd5 = "PasswordMd5";
            public const string LastLogin = "LastLogin";
            public const string ESignNik = "ESignNik";
            public const string EmployeeNumber = "EmployeeNumber";
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
            lock (typeof(AppUserMetadata))
            {
                if (mapDelegates == null)
                {
                    mapDelegates = new Dictionary<string, MapToMeta>();
                }

                if (meta == null)
                {
                    meta = new AppUserMetadata();
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


                meta.AddTypeMap("UserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("UserName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("Password", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SRLanguage", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ActiveDate", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("ExpireDate", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ParamedicID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("ServiceUnitID", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LicenseNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PersonID", new esTypeMap("int", "System.Int32"));
                meta.AddTypeMap("Email", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("IsLocked", new esTypeMap("bit", "System.Boolean"));
                meta.AddTypeMap("SRUserType", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("CashManagementNo", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("SignatureImage", new esTypeMap("image", "System.Byte[]"));
                meta.AddTypeMap("LastCounterName", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("PasswordMd5", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("LastLogin", new esTypeMap("datetime", "System.DateTime"));
                meta.AddTypeMap("ESignNik", new esTypeMap("varchar", "System.String"));
                meta.AddTypeMap("EmployeeNumber", new esTypeMap("varchar", "System.String"));



                meta.Source = "AppUser";
                meta.Destination = "AppUser";

                meta.spInsert = "proc_AppUserInsert";
                meta.spUpdate = "proc_AppUserUpdate";
                meta.spDelete = "proc_AppUserDelete";
                meta.spLoadAll = "proc_AppUserLoadAll";
                meta.spLoadByPrimaryKey = "proc_AppUserLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
            }

            return m_providerMetadataMaps["esDefault"];
        }

        #endregion

        static private AppUserMetadata meta;
        static protected Dictionary<string, MapToMeta> mapDelegates;
        static private int _esDefault = RegisterDelegateesDefault();
    }
}
