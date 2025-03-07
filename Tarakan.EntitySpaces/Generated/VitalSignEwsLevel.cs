
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 2/14/2025 10:46:14 AM
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
	/// Encapsulates the 'VitalSignEwsLevel' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(VitalSignEwsLevel))]	
	[XmlType("VitalSignEwsLevel")]
	public partial class VitalSignEwsLevel : esVitalSignEwsLevel
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new VitalSignEwsLevel();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 startAgeInDay, System.Decimal startValue, System.String vitalSignID)
		{
			var obj = new VitalSignEwsLevel();
			obj.StartAgeInDay = startAgeInDay;
			obj.StartValue = startValue;
			obj.VitalSignID = vitalSignID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 startAgeInDay, System.Decimal startValue, System.String vitalSignID, esSqlAccessType sqlAccessType)
		{
			var obj = new VitalSignEwsLevel();
			obj.StartAgeInDay = startAgeInDay;
			obj.StartValue = startValue;
			obj.VitalSignID = vitalSignID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("VitalSignEwsLevelCollection")]
	public partial class VitalSignEwsLevelCollection : esVitalSignEwsLevelCollection, IEnumerable<VitalSignEwsLevel>
	{
		public VitalSignEwsLevel FindByPrimaryKey(System.Int32 startAgeInDay, System.Decimal startValue, System.String vitalSignID)
		{
			return this.SingleOrDefault(e => e.StartAgeInDay == startAgeInDay && e.StartValue == startValue && e.VitalSignID == vitalSignID);
		}

		
				
	}



	[Serializable]	
	public partial class VitalSignEwsLevelQuery : esVitalSignEwsLevelQuery
	{
		public VitalSignEwsLevelQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public VitalSignEwsLevelQuery(string joinAlias, out VitalSignEwsLevelQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "VitalSignEwsLevelQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(VitalSignEwsLevelQuery query)
		{
			return VitalSignEwsLevelQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator VitalSignEwsLevelQuery(string query)
		{
			return (VitalSignEwsLevelQuery)VitalSignEwsLevelQuery.SerializeHelper.FromXml(query, typeof(VitalSignEwsLevelQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esVitalSignEwsLevel : esEntity
	{
		public esVitalSignEwsLevel()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 startAgeInDay, System.Decimal startValue, System.String vitalSignID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(startAgeInDay, startValue, vitalSignID);
			else
				return LoadByPrimaryKeyStoredProcedure(startAgeInDay, startValue, vitalSignID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 startAgeInDay, System.Decimal startValue, System.String vitalSignID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(startAgeInDay, startValue, vitalSignID);
			else
				return LoadByPrimaryKeyStoredProcedure(startAgeInDay, startValue, vitalSignID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 startAgeInDay, System.Decimal startValue, System.String vitalSignID)
		{
			VitalSignEwsLevelQuery query = new VitalSignEwsLevelQuery("vselQ");
			query.Where(query.StartAgeInDay == startAgeInDay, query.StartValue == startValue, query.VitalSignID == vitalSignID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 startAgeInDay, System.Decimal startValue, System.String vitalSignID)
		{
			esParameters parms = new esParameters();
			parms.Add("StartAgeInDay", startAgeInDay);			parms.Add("StartValue", startValue);			parms.Add("VitalSignID", vitalSignID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to VitalSignEwsLevel.VitalSignID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String VitalSignID
		{
			get
			{
				return base.GetSystemString(VitalSignEwsLevelMetadata.ColumnNames.VitalSignID);
			}
			
			set
			{
				if(base.SetSystemString(VitalSignEwsLevelMetadata.ColumnNames.VitalSignID, value))
				{
					OnPropertyChanged(VitalSignEwsLevelMetadata.PropertyNames.VitalSignID);
				}
			}
		}
		
		/// <summary>
		/// Maps to VitalSignEwsLevel.StartAgeInDay
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? StartAgeInDay
		{
			get
			{
				return base.GetSystemInt32(VitalSignEwsLevelMetadata.ColumnNames.StartAgeInDay);
			}
			
			set
			{
				if(base.SetSystemInt32(VitalSignEwsLevelMetadata.ColumnNames.StartAgeInDay, value))
				{
					OnPropertyChanged(VitalSignEwsLevelMetadata.PropertyNames.StartAgeInDay);
				}
			}
		}
		
		/// <summary>
		/// Maps to VitalSignEwsLevel.StartValue
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? StartValue
		{
			get
			{
				return base.GetSystemDecimal(VitalSignEwsLevelMetadata.ColumnNames.StartValue);
			}
			
			set
			{
				if(base.SetSystemDecimal(VitalSignEwsLevelMetadata.ColumnNames.StartValue, value))
				{
					OnPropertyChanged(VitalSignEwsLevelMetadata.PropertyNames.StartValue);
				}
			}
		}
		
		/// <summary>
		/// Maps to VitalSignEwsLevel.EwsLevel
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? EwsLevel
		{
			get
			{
				return base.GetSystemInt32(VitalSignEwsLevelMetadata.ColumnNames.EwsLevel);
			}
			
			set
			{
				if(base.SetSystemInt32(VitalSignEwsLevelMetadata.ColumnNames.EwsLevel, value))
				{
					OnPropertyChanged(VitalSignEwsLevelMetadata.PropertyNames.EwsLevel);
				}
			}
		}
		
		/// <summary>
		/// Maps to VitalSignEwsLevel.LastUpdateDateTime
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? LastUpdateDateTime
		{
			get
			{
				return base.GetSystemDateTime(VitalSignEwsLevelMetadata.ColumnNames.LastUpdateDateTime);
			}
			
			set
			{
				if(base.SetSystemDateTime(VitalSignEwsLevelMetadata.ColumnNames.LastUpdateDateTime, value))
				{
					OnPropertyChanged(VitalSignEwsLevelMetadata.PropertyNames.LastUpdateDateTime);
				}
			}
		}
		
		/// <summary>
		/// Maps to VitalSignEwsLevel.LastUpdateByUserID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String LastUpdateByUserID
		{
			get
			{
				return base.GetSystemString(VitalSignEwsLevelMetadata.ColumnNames.LastUpdateByUserID);
			}
			
			set
			{
				if(base.SetSystemString(VitalSignEwsLevelMetadata.ColumnNames.LastUpdateByUserID, value))
				{
					OnPropertyChanged(VitalSignEwsLevelMetadata.PropertyNames.LastUpdateByUserID);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return VitalSignEwsLevelMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public VitalSignEwsLevelQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new VitalSignEwsLevelQuery("vselQ");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(VitalSignEwsLevelQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(VitalSignEwsLevelQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((VitalSignEwsLevelQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private VitalSignEwsLevelQuery query;		
	}



	[Serializable]
	abstract public partial class esVitalSignEwsLevelCollection : esEntityCollection<VitalSignEwsLevel>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return VitalSignEwsLevelMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "VitalSignEwsLevelCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public VitalSignEwsLevelQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new VitalSignEwsLevelQuery("vselQ");
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(VitalSignEwsLevelQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new VitalSignEwsLevelQuery("vselQ");
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(VitalSignEwsLevelQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((VitalSignEwsLevelQuery)query);
		}

		#endregion
		
		private VitalSignEwsLevelQuery query;
	}



	[Serializable]
	abstract public partial class esVitalSignEwsLevelQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return VitalSignEwsLevelMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "VitalSignID": return this.VitalSignID;
				case "StartAgeInDay": return this.StartAgeInDay;
				case "StartValue": return this.StartValue;
				case "EwsLevel": return this.EwsLevel;
				case "LastUpdateDateTime": return this.LastUpdateDateTime;
				case "LastUpdateByUserID": return this.LastUpdateByUserID;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem VitalSignID
		{
			get { return new esQueryItem(this, VitalSignEwsLevelMetadata.ColumnNames.VitalSignID, esSystemType.String); }
		} 
		
		public esQueryItem StartAgeInDay
		{
			get { return new esQueryItem(this, VitalSignEwsLevelMetadata.ColumnNames.StartAgeInDay, esSystemType.Int32); }
		} 
		
		public esQueryItem StartValue
		{
			get { return new esQueryItem(this, VitalSignEwsLevelMetadata.ColumnNames.StartValue, esSystemType.Decimal); }
		} 
		
		public esQueryItem EwsLevel
		{
			get { return new esQueryItem(this, VitalSignEwsLevelMetadata.ColumnNames.EwsLevel, esSystemType.Int32); }
		} 
		
		public esQueryItem LastUpdateDateTime
		{
			get { return new esQueryItem(this, VitalSignEwsLevelMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
		} 
		
		public esQueryItem LastUpdateByUserID
		{
			get { return new esQueryItem(this, VitalSignEwsLevelMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class VitalSignEwsLevel : esVitalSignEwsLevel
	{

		
		
	}
	



	[Serializable]
	public partial class VitalSignEwsLevelMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected VitalSignEwsLevelMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(VitalSignEwsLevelMetadata.ColumnNames.VitalSignID, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = VitalSignEwsLevelMetadata.PropertyNames.VitalSignID;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);
				
			c = new esColumnMetadata(VitalSignEwsLevelMetadata.ColumnNames.StartAgeInDay, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VitalSignEwsLevelMetadata.PropertyNames.StartAgeInDay;
			c.IsInPrimaryKey = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(VitalSignEwsLevelMetadata.ColumnNames.StartValue, 2, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = VitalSignEwsLevelMetadata.PropertyNames.StartValue;
			c.IsInPrimaryKey = true;
			c.NumericPrecision = 18;
			c.NumericScale = 4;
			m_columns.Add(c);
				
			c = new esColumnMetadata(VitalSignEwsLevelMetadata.ColumnNames.EwsLevel, 3, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VitalSignEwsLevelMetadata.PropertyNames.EwsLevel;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(VitalSignEwsLevelMetadata.ColumnNames.LastUpdateDateTime, 4, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = VitalSignEwsLevelMetadata.PropertyNames.LastUpdateDateTime;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(VitalSignEwsLevelMetadata.ColumnNames.LastUpdateByUserID, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = VitalSignEwsLevelMetadata.PropertyNames.LastUpdateByUserID;
			c.CharacterMaxLength = 20;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public VitalSignEwsLevelMetadata Meta()
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
			 public const string VitalSignID = "VitalSignID";
			 public const string StartAgeInDay = "StartAgeInDay";
			 public const string StartValue = "StartValue";
			 public const string EwsLevel = "EwsLevel";
			 public const string LastUpdateDateTime = "LastUpdateDateTime";
			 public const string LastUpdateByUserID = "LastUpdateByUserID";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string VitalSignID = "VitalSignID";
			 public const string StartAgeInDay = "StartAgeInDay";
			 public const string StartValue = "StartValue";
			 public const string EwsLevel = "EwsLevel";
			 public const string LastUpdateDateTime = "LastUpdateDateTime";
			 public const string LastUpdateByUserID = "LastUpdateByUserID";
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
			lock (typeof(VitalSignEwsLevelMetadata))
			{
				if(VitalSignEwsLevelMetadata.mapDelegates == null)
				{
					VitalSignEwsLevelMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (VitalSignEwsLevelMetadata.meta == null)
				{
					VitalSignEwsLevelMetadata.meta = new VitalSignEwsLevelMetadata();
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


				meta.AddTypeMap("VitalSignID", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("StartAgeInDay", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("StartValue", new esTypeMap("numeric", "System.Decimal"));
				meta.AddTypeMap("EwsLevel", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "VitalSignEwsLevel";
				meta.Destination = "VitalSignEwsLevel";
				
				meta.spInsert = "proc_VitalSignEwsLevelInsert";				
				meta.spUpdate = "proc_VitalSignEwsLevelUpdate";		
				meta.spDelete = "proc_VitalSignEwsLevelDelete";
				meta.spLoadAll = "proc_VitalSignEwsLevelLoadAll";
				meta.spLoadByPrimaryKey = "proc_VitalSignEwsLevelLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private VitalSignEwsLevelMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
