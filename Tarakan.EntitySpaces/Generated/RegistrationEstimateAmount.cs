
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 6/7/2024 11:23:12 AM
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
	/// Encapsulates the 'RegistrationEstimateAmount' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(RegistrationEstimateAmount))]	
	[XmlType("RegistrationEstimateAmount")]
	public partial class RegistrationEstimateAmount : esRegistrationEstimateAmount
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new RegistrationEstimateAmount();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.String registrationNo)
		{
			var obj = new RegistrationEstimateAmount();
			obj.RegistrationNo = registrationNo;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.String registrationNo, esSqlAccessType sqlAccessType)
		{
			var obj = new RegistrationEstimateAmount();
			obj.RegistrationNo = registrationNo;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("RegistrationEstimateAmountCollection")]
	public partial class RegistrationEstimateAmountCollection : esRegistrationEstimateAmountCollection, IEnumerable<RegistrationEstimateAmount>
	{
		public RegistrationEstimateAmount FindByPrimaryKey(System.String registrationNo)
		{
			return this.SingleOrDefault(e => e.RegistrationNo == registrationNo);
		}

		
				
	}



	[Serializable]	
	public partial class RegistrationEstimateAmountQuery : esRegistrationEstimateAmountQuery
	{
		public RegistrationEstimateAmountQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public RegistrationEstimateAmountQuery(string joinAlias, out RegistrationEstimateAmountQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "RegistrationEstimateAmountQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(RegistrationEstimateAmountQuery query)
		{
			return RegistrationEstimateAmountQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator RegistrationEstimateAmountQuery(string query)
		{
			return (RegistrationEstimateAmountQuery)RegistrationEstimateAmountQuery.SerializeHelper.FromXml(query, typeof(RegistrationEstimateAmountQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esRegistrationEstimateAmount : esEntity
	{
		public esRegistrationEstimateAmount()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.String registrationNo)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(registrationNo);
			else
				return LoadByPrimaryKeyStoredProcedure(registrationNo);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.String registrationNo)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(registrationNo);
			else
				return LoadByPrimaryKeyStoredProcedure(registrationNo);
		}

		private bool LoadByPrimaryKeyDynamic(System.String registrationNo)
		{
			RegistrationEstimateAmountQuery query = new RegistrationEstimateAmountQuery("RegistrationEstimateAmount");
			query.Where(query.RegistrationNo == registrationNo);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String registrationNo)
		{
			esParameters parms = new esParameters();
			parms.Add("RegistrationNo", registrationNo);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to RegistrationEstimateAmount.RegistrationNo
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String RegistrationNo
		{
			get
			{
				return base.GetSystemString(RegistrationEstimateAmountMetadata.ColumnNames.RegistrationNo);
			}
			
			set
			{
				if(base.SetSystemString(RegistrationEstimateAmountMetadata.ColumnNames.RegistrationNo, value))
				{
					OnPropertyChanged(RegistrationEstimateAmountMetadata.PropertyNames.RegistrationNo);
				}
			}
		}
		
		/// <summary>
		/// Maps to RegistrationEstimateAmount.PatientAmount
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? PatientAmount
		{
			get
			{
				return base.GetSystemDecimal(RegistrationEstimateAmountMetadata.ColumnNames.PatientAmount);
			}
			
			set
			{
				if(base.SetSystemDecimal(RegistrationEstimateAmountMetadata.ColumnNames.PatientAmount, value))
				{
					OnPropertyChanged(RegistrationEstimateAmountMetadata.PropertyNames.PatientAmount);
				}
			}
		}
		
		/// <summary>
		/// Maps to RegistrationEstimateAmount.LastCreateDateTime
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? LastCreateDateTime
		{
			get
			{
				return base.GetSystemDateTime(RegistrationEstimateAmountMetadata.ColumnNames.LastCreateDateTime);
			}
			
			set
			{
				if(base.SetSystemDateTime(RegistrationEstimateAmountMetadata.ColumnNames.LastCreateDateTime, value))
				{
					OnPropertyChanged(RegistrationEstimateAmountMetadata.PropertyNames.LastCreateDateTime);
				}
			}
		}
		
		/// <summary>
		/// Maps to RegistrationEstimateAmount.LastCreateUserID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String LastCreateUserID
		{
			get
			{
				return base.GetSystemString(RegistrationEstimateAmountMetadata.ColumnNames.LastCreateUserID);
			}
			
			set
			{
				if(base.SetSystemString(RegistrationEstimateAmountMetadata.ColumnNames.LastCreateUserID, value))
				{
					OnPropertyChanged(RegistrationEstimateAmountMetadata.PropertyNames.LastCreateUserID);
				}
			}
		}
		
		/// <summary>
		/// Maps to RegistrationEstimateAmount.LastUpdateDateTime
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? LastUpdateDateTime
		{
			get
			{
				return base.GetSystemDateTime(RegistrationEstimateAmountMetadata.ColumnNames.LastUpdateDateTime);
			}
			
			set
			{
				if(base.SetSystemDateTime(RegistrationEstimateAmountMetadata.ColumnNames.LastUpdateDateTime, value))
				{
					OnPropertyChanged(RegistrationEstimateAmountMetadata.PropertyNames.LastUpdateDateTime);
				}
			}
		}
		
		/// <summary>
		/// Maps to RegistrationEstimateAmount.LastUpdateByUserID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String LastUpdateByUserID
		{
			get
			{
				return base.GetSystemString(RegistrationEstimateAmountMetadata.ColumnNames.LastUpdateByUserID);
			}
			
			set
			{
				if(base.SetSystemString(RegistrationEstimateAmountMetadata.ColumnNames.LastUpdateByUserID, value))
				{
					OnPropertyChanged(RegistrationEstimateAmountMetadata.PropertyNames.LastUpdateByUserID);
				}
			}
		}
		
		/// <summary>
		/// Maps to RegistrationEstimateAmount.CbgID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String CbgID
		{
			get
			{
				return base.GetSystemString(RegistrationEstimateAmountMetadata.ColumnNames.CbgID);
			}
			
			set
			{
				if(base.SetSystemString(RegistrationEstimateAmountMetadata.ColumnNames.CbgID, value))
				{
					OnPropertyChanged(RegistrationEstimateAmountMetadata.PropertyNames.CbgID);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return RegistrationEstimateAmountMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public RegistrationEstimateAmountQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new RegistrationEstimateAmountQuery("RegistrationEstimateAmount");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(RegistrationEstimateAmountQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(RegistrationEstimateAmountQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((RegistrationEstimateAmountQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private RegistrationEstimateAmountQuery query;		
	}



	[Serializable]
	abstract public partial class esRegistrationEstimateAmountCollection : esEntityCollection<RegistrationEstimateAmount>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return RegistrationEstimateAmountMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "RegistrationEstimateAmountCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public RegistrationEstimateAmountQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new RegistrationEstimateAmountQuery("RegistrationEstimateAmount");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(RegistrationEstimateAmountQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new RegistrationEstimateAmountQuery("RegistrationEstimateAmount");
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(RegistrationEstimateAmountQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((RegistrationEstimateAmountQuery)query);
		}

		#endregion
		
		private RegistrationEstimateAmountQuery query;
	}



	[Serializable]
	abstract public partial class esRegistrationEstimateAmountQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return RegistrationEstimateAmountMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "RegistrationNo": return this.RegistrationNo;
				case "PatientAmount": return this.PatientAmount;
				case "LastCreateDateTime": return this.LastCreateDateTime;
				case "LastCreateUserID": return this.LastCreateUserID;
				case "LastUpdateDateTime": return this.LastUpdateDateTime;
				case "LastUpdateByUserID": return this.LastUpdateByUserID;
				case "CbgID": return this.CbgID;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem RegistrationNo
		{
			get { return new esQueryItem(this, RegistrationEstimateAmountMetadata.ColumnNames.RegistrationNo, esSystemType.String); }
		} 
		
		public esQueryItem PatientAmount
		{
			get { return new esQueryItem(this, RegistrationEstimateAmountMetadata.ColumnNames.PatientAmount, esSystemType.Decimal); }
		} 
		
		public esQueryItem LastCreateDateTime
		{
			get { return new esQueryItem(this, RegistrationEstimateAmountMetadata.ColumnNames.LastCreateDateTime, esSystemType.DateTime); }
		} 
		
		public esQueryItem LastCreateUserID
		{
			get { return new esQueryItem(this, RegistrationEstimateAmountMetadata.ColumnNames.LastCreateUserID, esSystemType.String); }
		} 
		
		public esQueryItem LastUpdateDateTime
		{
			get { return new esQueryItem(this, RegistrationEstimateAmountMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
		} 
		
		public esQueryItem LastUpdateByUserID
		{
			get { return new esQueryItem(this, RegistrationEstimateAmountMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
		} 
		
		public esQueryItem CbgID
		{
			get { return new esQueryItem(this, RegistrationEstimateAmountMetadata.ColumnNames.CbgID, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class RegistrationEstimateAmount : esRegistrationEstimateAmount
	{

		
		
	}
	



	[Serializable]
	public partial class RegistrationEstimateAmountMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected RegistrationEstimateAmountMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(RegistrationEstimateAmountMetadata.ColumnNames.RegistrationNo, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = RegistrationEstimateAmountMetadata.PropertyNames.RegistrationNo;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);
				
			c = new esColumnMetadata(RegistrationEstimateAmountMetadata.ColumnNames.PatientAmount, 1, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = RegistrationEstimateAmountMetadata.PropertyNames.PatientAmount;
			c.NumericPrecision = 18;
			c.NumericScale = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(RegistrationEstimateAmountMetadata.ColumnNames.LastCreateDateTime, 2, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = RegistrationEstimateAmountMetadata.PropertyNames.LastCreateDateTime;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(RegistrationEstimateAmountMetadata.ColumnNames.LastCreateUserID, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = RegistrationEstimateAmountMetadata.PropertyNames.LastCreateUserID;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(RegistrationEstimateAmountMetadata.ColumnNames.LastUpdateDateTime, 4, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = RegistrationEstimateAmountMetadata.PropertyNames.LastUpdateDateTime;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(RegistrationEstimateAmountMetadata.ColumnNames.LastUpdateByUserID, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = RegistrationEstimateAmountMetadata.PropertyNames.LastUpdateByUserID;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(RegistrationEstimateAmountMetadata.ColumnNames.CbgID, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = RegistrationEstimateAmountMetadata.PropertyNames.CbgID;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public RegistrationEstimateAmountMetadata Meta()
		{
			return meta;
		}	
		
		public Guid DataID
		{
			get { return base.m_dataID; }
		}	
		
		public bool MultiProviderMode
		{
			get { return false; }
		}		

		public esColumnMetadataCollection Columns
		{
			get	{ return base.m_columns; }
		}
		
		#region ColumnNames
		public class ColumnNames
		{ 
			 public const string RegistrationNo = "RegistrationNo";
			 public const string PatientAmount = "PatientAmount";
			 public const string LastCreateDateTime = "LastCreateDateTime";
			 public const string LastCreateUserID = "LastCreateUserID";
			 public const string LastUpdateDateTime = "LastUpdateDateTime";
			 public const string LastUpdateByUserID = "LastUpdateByUserID";
			 public const string CbgID = "CbgID";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string RegistrationNo = "RegistrationNo";
			 public const string PatientAmount = "PatientAmount";
			 public const string LastCreateDateTime = "LastCreateDateTime";
			 public const string LastCreateUserID = "LastCreateUserID";
			 public const string LastUpdateDateTime = "LastUpdateDateTime";
			 public const string LastUpdateByUserID = "LastUpdateByUserID";
			 public const string CbgID = "CbgID";
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
			lock (typeof(RegistrationEstimateAmountMetadata))
			{
				if(RegistrationEstimateAmountMetadata.mapDelegates == null)
				{
					RegistrationEstimateAmountMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (RegistrationEstimateAmountMetadata.meta == null)
				{
					RegistrationEstimateAmountMetadata.meta = new RegistrationEstimateAmountMetadata();
				}
				
				MapToMeta mapMethod = new MapToMeta(meta.esDefault);
				mapDelegates.Add("esDefault", mapMethod);
				mapMethod("esDefault");
			}
			return 0;
		}			

		private esProviderSpecificMetadata esDefault(string mapName)
		{
			if(!m_providerMetadataMaps.ContainsKey(mapName))
			{
				esProviderSpecificMetadata meta = new esProviderSpecificMetadata();			


				meta.AddTypeMap("RegistrationNo", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("PatientAmount", new esTypeMap("numeric", "System.Decimal"));
				meta.AddTypeMap("LastCreateDateTime", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("LastCreateUserID", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("CbgID", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "RegistrationEstimateAmount";
				meta.Destination = "RegistrationEstimateAmount";
				
				meta.spInsert = "proc_RegistrationEstimateAmountInsert";				
				meta.spUpdate = "proc_RegistrationEstimateAmountUpdate";		
				meta.spDelete = "proc_RegistrationEstimateAmountDelete";
				meta.spLoadAll = "proc_RegistrationEstimateAmountLoadAll";
				meta.spLoadByPrimaryKey = "proc_RegistrationEstimateAmountLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private RegistrationEstimateAmountMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
