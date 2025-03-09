
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 3/9/2025 5:59:38 PM
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
	/// Encapsulates the 'vw_Transaction' view
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(VwTransaction))]	
	[XmlType("VwTransaction")]
	public partial class VwTransaction : esVwTransaction
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new VwTransaction();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("VwTransactionCollection")]
	public partial class VwTransactionCollection : esVwTransactionCollection, IEnumerable<VwTransaction>
	{

		
				
	}



	[Serializable]	
	public partial class VwTransactionQuery : esVwTransactionQuery
	{
		public VwTransactionQuery(string joinAlias)
		{
            es.JoinAlias = joinAlias;
		}	

		public VwTransactionQuery(string joinAlias, out VwTransactionQuery query)
		{
			query = this;
            es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "VwTransactionQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(VwTransactionQuery query)
		{
			return SerializeHelper.ToXml(query);
		}

		public static explicit operator VwTransactionQuery(string query)
		{
			return (VwTransactionQuery)SerializeHelper.FromXml(query, typeof(VwTransactionQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esVwTransaction : esEntity
	{
		public esVwTransaction()
		{

		}
		
		#region LoadByPrimaryKey
		
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to vw_Transaction.TransactionNo
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public string TransactionNo
		{
			get
			{
				return GetSystemString(VwTransactionMetadata.ColumnNames.TransactionNo);
			}
			
			set
			{
				if(SetSystemString(VwTransactionMetadata.ColumnNames.TransactionNo, value))
				{
					OnPropertyChanged(VwTransactionMetadata.PropertyNames.TransactionNo);
				}
			}
		}
		
		/// <summary>
		/// Maps to vw_Transaction.TransactionDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public DateTime? TransactionDate
		{
			get
			{
				return GetSystemDateTime(VwTransactionMetadata.ColumnNames.TransactionDate);
			}
			
			set
			{
				if(SetSystemDateTime(VwTransactionMetadata.ColumnNames.TransactionDate, value))
				{
					OnPropertyChanged(VwTransactionMetadata.PropertyNames.TransactionDate);
				}
			}
		}
		
		/// <summary>
		/// Maps to vw_Transaction.RegistrationNo
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public string RegistrationNo
		{
			get
			{
				return GetSystemString(VwTransactionMetadata.ColumnNames.RegistrationNo);
			}
			
			set
			{
				if(SetSystemString(VwTransactionMetadata.ColumnNames.RegistrationNo, value))
				{
					OnPropertyChanged(VwTransactionMetadata.PropertyNames.RegistrationNo);
				}
			}
		}
		
		/// <summary>
		/// Maps to vw_Transaction.ServiceUnitID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public string ServiceUnitID
		{
			get
			{
				return GetSystemString(VwTransactionMetadata.ColumnNames.ServiceUnitID);
			}
			
			set
			{
				if(SetSystemString(VwTransactionMetadata.ColumnNames.ServiceUnitID, value))
				{
					OnPropertyChanged(VwTransactionMetadata.PropertyNames.ServiceUnitID);
				}
			}
		}
		
		/// <summary>
		/// Maps to vw_Transaction.ReferenceNo
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public string ReferenceNo
		{
			get
			{
				return GetSystemString(VwTransactionMetadata.ColumnNames.ReferenceNo);
			}
			
			set
			{
				if(SetSystemString(VwTransactionMetadata.ColumnNames.ReferenceNo, value))
				{
					OnPropertyChanged(VwTransactionMetadata.PropertyNames.ReferenceNo);
				}
			}
		}
		
		/// <summary>
		/// Maps to vw_Transaction.IsCorrection
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public bool? IsCorrection
		{
			get
			{
				return GetSystemBoolean(VwTransactionMetadata.ColumnNames.IsCorrection);
			}
			
			set
			{
				if(SetSystemBoolean(VwTransactionMetadata.ColumnNames.IsCorrection, value))
				{
					OnPropertyChanged(VwTransactionMetadata.PropertyNames.IsCorrection);
				}
			}
		}
		
		/// <summary>
		/// Maps to vw_Transaction.FilterDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public DateTime? FilterDate
		{
			get
			{
				return GetSystemDateTime(VwTransactionMetadata.ColumnNames.FilterDate);
			}
			
			set
			{
				if(SetSystemDateTime(VwTransactionMetadata.ColumnNames.FilterDate, value))
				{
					OnPropertyChanged(VwTransactionMetadata.PropertyNames.FilterDate);
				}
			}
		}
		
		/// <summary>
		/// Maps to vw_Transaction.OrderTransNo
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public string OrderTransNo
		{
			get
			{
				return GetSystemString(VwTransactionMetadata.ColumnNames.OrderTransNo);
			}
			
			set
			{
				if(SetSystemString(VwTransactionMetadata.ColumnNames.OrderTransNo, value))
				{
					OnPropertyChanged(VwTransactionMetadata.PropertyNames.OrderTransNo);
				}
			}
		}
		
		/// <summary>
		/// Maps to vw_Transaction.OrderDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public DateTime? OrderDate
		{
			get
			{
				return GetSystemDateTime(VwTransactionMetadata.ColumnNames.OrderDate);
			}
			
			set
			{
				if(SetSystemDateTime(VwTransactionMetadata.ColumnNames.OrderDate, value))
				{
					OnPropertyChanged(VwTransactionMetadata.PropertyNames.OrderDate);
				}
			}
		}
		
		/// <summary>
		/// Maps to vw_Transaction.IsPackage
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public int? IsPackage
		{
			get
			{
				return GetSystemInt32(VwTransactionMetadata.ColumnNames.IsPackage);
			}
			
			set
			{
				if(SetSystemInt32(VwTransactionMetadata.ColumnNames.IsPackage, value))
				{
					OnPropertyChanged(VwTransactionMetadata.PropertyNames.IsPackage);
				}
			}
		}
		
		/// <summary>
		/// Maps to vw_Transaction.PackageReferenceNo
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public string PackageReferenceNo
		{
			get
			{
				return GetSystemString(VwTransactionMetadata.ColumnNames.PackageReferenceNo);
			}
			
			set
			{
				if(SetSystemString(VwTransactionMetadata.ColumnNames.PackageReferenceNo, value))
				{
					OnPropertyChanged(VwTransactionMetadata.PropertyNames.PackageReferenceNo);
				}
			}
		}
		
		/// <summary>
		/// Maps to vw_Transaction.IsPrescription
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public bool? IsPrescription
		{
			get
			{
				return GetSystemBoolean(VwTransactionMetadata.ColumnNames.IsPrescription);
			}
			
			set
			{
				if(SetSystemBoolean(VwTransactionMetadata.ColumnNames.IsPrescription, value))
				{
					OnPropertyChanged(VwTransactionMetadata.PropertyNames.IsPrescription);
				}
			}
		}
		
		/// <summary>
		/// Maps to vw_Transaction.ClassID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public string ClassID
		{
			get
			{
				return GetSystemString(VwTransactionMetadata.ColumnNames.ClassID);
			}
			
			set
			{
				if(SetSystemString(VwTransactionMetadata.ColumnNames.ClassID, value))
				{
					OnPropertyChanged(VwTransactionMetadata.PropertyNames.ClassID);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return VwTransactionMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public VwTransactionQuery Query
		{
			get
			{
				if (query == null)
				{
                    query = new VwTransactionQuery("tQ");
					InitQuery(query);
				}

				return query;
			}
		}

		public bool Load(VwTransactionQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		protected void InitQuery(VwTransactionQuery query)
		{
			query.OnLoadDelegate = OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
            InitQuery((VwTransactionQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private VwTransactionQuery query;		
	}



	[Serializable]
	abstract public partial class esVwTransactionCollection : esEntityCollection<VwTransaction>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return VwTransactionMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "VwTransactionCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[Browsable(false)]
	#endif
		public VwTransactionQuery Query
		{
			get
			{
				if (query == null)
				{
                    query = new VwTransactionQuery("tQ");
					InitQuery(query);
				}

				return query;
			}
		}

		public bool Load(VwTransactionQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (query == null)
			{
                query = new VwTransactionQuery("tQ");
                InitQuery(query);
			}
			return query;
		}

		protected void InitQuery(VwTransactionQuery query)
		{
			query.OnLoadDelegate = OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
            InitQuery((VwTransactionQuery)query);
		}

		#endregion
		
		private VwTransactionQuery query;
	}



	[Serializable]
	abstract public partial class esVwTransactionQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return VwTransactionMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "TransactionNo": return TransactionNo;
				case "TransactionDate": return TransactionDate;
				case "RegistrationNo": return RegistrationNo;
				case "ServiceUnitID": return ServiceUnitID;
				case "ReferenceNo": return ReferenceNo;
				case "IsCorrection": return IsCorrection;
				case "FilterDate": return FilterDate;
				case "OrderTransNo": return OrderTransNo;
				case "OrderDate": return OrderDate;
				case "IsPackage": return IsPackage;
				case "PackageReferenceNo": return PackageReferenceNo;
				case "IsPrescription": return IsPrescription;
				case "ClassID": return ClassID;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem TransactionNo
		{
			get { return new esQueryItem(this, VwTransactionMetadata.ColumnNames.TransactionNo, esSystemType.String); }
		} 
		
		public esQueryItem TransactionDate
		{
			get { return new esQueryItem(this, VwTransactionMetadata.ColumnNames.TransactionDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem RegistrationNo
		{
			get { return new esQueryItem(this, VwTransactionMetadata.ColumnNames.RegistrationNo, esSystemType.String); }
		} 
		
		public esQueryItem ServiceUnitID
		{
			get { return new esQueryItem(this, VwTransactionMetadata.ColumnNames.ServiceUnitID, esSystemType.String); }
		} 
		
		public esQueryItem ReferenceNo
		{
			get { return new esQueryItem(this, VwTransactionMetadata.ColumnNames.ReferenceNo, esSystemType.String); }
		} 
		
		public esQueryItem IsCorrection
		{
			get { return new esQueryItem(this, VwTransactionMetadata.ColumnNames.IsCorrection, esSystemType.Boolean); }
		} 
		
		public esQueryItem FilterDate
		{
			get { return new esQueryItem(this, VwTransactionMetadata.ColumnNames.FilterDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem OrderTransNo
		{
			get { return new esQueryItem(this, VwTransactionMetadata.ColumnNames.OrderTransNo, esSystemType.String); }
		} 
		
		public esQueryItem OrderDate
		{
			get { return new esQueryItem(this, VwTransactionMetadata.ColumnNames.OrderDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem IsPackage
		{
			get { return new esQueryItem(this, VwTransactionMetadata.ColumnNames.IsPackage, esSystemType.Int32); }
		} 
		
		public esQueryItem PackageReferenceNo
		{
			get { return new esQueryItem(this, VwTransactionMetadata.ColumnNames.PackageReferenceNo, esSystemType.String); }
		} 
		
		public esQueryItem IsPrescription
		{
			get { return new esQueryItem(this, VwTransactionMetadata.ColumnNames.IsPrescription, esSystemType.Boolean); }
		} 
		
		public esQueryItem ClassID
		{
			get { return new esQueryItem(this, VwTransactionMetadata.ColumnNames.ClassID, esSystemType.String); }
		} 
		
		#endregion
		
	}



	[Serializable]
	public partial class VwTransactionMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected VwTransactionMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ColumnNames.TransactionNo, 0, typeof(string), esSystemType.String);
			c.PropertyName = PropertyNames.TransactionNo;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ColumnNames.TransactionDate, 1, typeof(DateTime), esSystemType.DateTime);
			c.PropertyName = PropertyNames.TransactionDate;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ColumnNames.RegistrationNo, 2, typeof(string), esSystemType.String);
			c.PropertyName = PropertyNames.RegistrationNo;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ColumnNames.ServiceUnitID, 3, typeof(string), esSystemType.String);
			c.PropertyName = PropertyNames.ServiceUnitID;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ColumnNames.ReferenceNo, 4, typeof(string), esSystemType.String);
			c.PropertyName = PropertyNames.ReferenceNo;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ColumnNames.IsCorrection, 5, typeof(bool), esSystemType.Boolean);
			c.PropertyName = PropertyNames.IsCorrection;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ColumnNames.FilterDate, 6, typeof(DateTime), esSystemType.DateTime);
			c.PropertyName = PropertyNames.FilterDate;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ColumnNames.OrderTransNo, 7, typeof(string), esSystemType.String);
			c.PropertyName = PropertyNames.OrderTransNo;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ColumnNames.OrderDate, 8, typeof(DateTime), esSystemType.DateTime);
			c.PropertyName = PropertyNames.OrderDate;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ColumnNames.IsPackage, 9, typeof(int), esSystemType.Int32);
			c.PropertyName = PropertyNames.IsPackage;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ColumnNames.PackageReferenceNo, 10, typeof(string), esSystemType.String);
			c.PropertyName = PropertyNames.PackageReferenceNo;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ColumnNames.IsPrescription, 11, typeof(bool), esSystemType.Boolean);
			c.PropertyName = PropertyNames.IsPrescription;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ColumnNames.ClassID, 12, typeof(string), esSystemType.String);
			c.PropertyName = PropertyNames.ClassID;
			c.CharacterMaxLength = 10;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public VwTransactionMetadata Meta()
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
			get	{ return m_columns; }
		}
		
		#region ColumnNames
		public class ColumnNames
		{ 
			 public const string TransactionNo = "TransactionNo";
			 public const string TransactionDate = "TransactionDate";
			 public const string RegistrationNo = "RegistrationNo";
			 public const string ServiceUnitID = "ServiceUnitID";
			 public const string ReferenceNo = "ReferenceNo";
			 public const string IsCorrection = "IsCorrection";
			 public const string FilterDate = "FilterDate";
			 public const string OrderTransNo = "OrderTransNo";
			 public const string OrderDate = "OrderDate";
			 public const string IsPackage = "IsPackage";
			 public const string PackageReferenceNo = "PackageReferenceNo";
			 public const string IsPrescription = "IsPrescription";
			 public const string ClassID = "ClassID";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string TransactionNo = "TransactionNo";
			 public const string TransactionDate = "TransactionDate";
			 public const string RegistrationNo = "RegistrationNo";
			 public const string ServiceUnitID = "ServiceUnitID";
			 public const string ReferenceNo = "ReferenceNo";
			 public const string IsCorrection = "IsCorrection";
			 public const string FilterDate = "FilterDate";
			 public const string OrderTransNo = "OrderTransNo";
			 public const string OrderDate = "OrderDate";
			 public const string IsPackage = "IsPackage";
			 public const string PackageReferenceNo = "PackageReferenceNo";
			 public const string IsPrescription = "IsPrescription";
			 public const string ClassID = "ClassID";
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
			lock (typeof(VwTransactionMetadata))
			{
				if(mapDelegates == null)
				{
                    mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (meta == null)
				{
                    meta = new VwTransactionMetadata();
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


				meta.AddTypeMap("TransactionNo", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("TransactionDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("RegistrationNo", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("ServiceUnitID", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("ReferenceNo", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("IsCorrection", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("FilterDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("OrderTransNo", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("OrderDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("IsPackage", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("PackageReferenceNo", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("IsPrescription", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("ClassID", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "vw_Transaction";
				meta.Destination = "vw_Transaction";
				
				meta.spInsert = "proc_vw_TransactionInsert";				
				meta.spUpdate = "proc_vw_TransactionUpdate";		
				meta.spDelete = "proc_vw_TransactionDelete";
				meta.spLoadAll = "proc_vw_TransactionLoadAll";
				meta.spLoadByPrimaryKey = "proc_vw_TransactionLoadByPrimaryKey";

                m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private VwTransactionMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
