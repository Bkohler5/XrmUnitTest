//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xyz.Xrm.Entities
{
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.0.1.7297")]
	public enum PickListMappingState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
	}
	
	/// <summary>
	/// In a data map, maps list values from the source file to Microsoft Dynamics CRM.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("picklistmapping")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.0.1.7297")]
	public partial class PickListMapping : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public struct Fields
		{
			public const string ColumnMappingId = "columnmappingid";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string PickListMappingId = "picklistmappingid";
			public const string Id = "picklistmappingid";
			public const string ProcessCode = "processcode";
			public const string SourceValue = "sourcevalue";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string TargetValue = "targetvalue";
			public const string lk_picklistmapping_createdby = "lk_picklistmapping_createdby";
			public const string lk_picklistmapping_createdonbehalfby = "lk_picklistmapping_createdonbehalfby";
			public const string lk_picklistmapping_modifiedby = "lk_picklistmapping_modifiedby";
			public const string lk_picklistmapping_modifiedonbehalfby = "lk_picklistmapping_modifiedonbehalfby";
			public const string PickListMapping_ColumnMapping = "PickListMapping_ColumnMapping";
		}

		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public PickListMapping() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "picklistmapping";
		
		public const int EntityTypeCode = 4418;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// Unique identifier of the column mapping with which this list value mapping is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("columnmappingid")]
		public Microsoft.Xrm.Sdk.EntityReference ColumnMappingId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("columnmappingid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ColumnMappingId");
				this.SetAttributeValue("columnmappingid", value);
				this.OnPropertyChanged("ColumnMappingId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the list value mapping.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedBy");
				this.SetAttributeValue("createdby", value);
				this.OnPropertyChanged("CreatedBy");
			}
		}
		
		/// <summary>
		/// Date and time when the list value mapping was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedOn");
				this.SetAttributeValue("createdon", value);
				this.OnPropertyChanged("CreatedOn");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the picklistmapping.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedOnBehalfBy");
				this.SetAttributeValue("createdonbehalfby", value);
				this.OnPropertyChanged("CreatedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the list value mapping.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedBy");
				this.SetAttributeValue("modifiedby", value);
				this.OnPropertyChanged("ModifiedBy");
			}
		}
		
		/// <summary>
		/// Date and time when the list value mapping was last modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedOn");
				this.SetAttributeValue("modifiedon", value);
				this.OnPropertyChanged("ModifiedOn");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the picklistmapping.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedOnBehalfBy");
				this.SetAttributeValue("modifiedonbehalfby", value);
				this.OnPropertyChanged("ModifiedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Unique identifier of the picklist mapping.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("picklistmappingid")]
		public System.Nullable<System.Guid> PickListMappingId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("picklistmappingid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PickListMappingId");
				this.SetAttributeValue("picklistmappingid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("PickListMappingId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("picklistmappingid")]
		public override System.Guid Id
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return base.Id;
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.PickListMappingId = value;
			}
		}
		
		/// <summary>
		/// Information about whether the list value mapping needs to be processed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue ProcessCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("processcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ProcessCode");
				this.SetAttributeValue("processcode", value);
				this.OnPropertyChanged("ProcessCode");
			}
		}
		
		/// <summary>
		/// Source value to be replaced.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sourcevalue")]
		public string SourceValue
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("sourcevalue");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SourceValue");
				this.SetAttributeValue("sourcevalue", value);
				this.OnPropertyChanged("SourceValue");
			}
		}
		
		/// <summary>
		/// Status of the picklist mapping.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<Xyz.Xrm.Entities.PickListMappingState> StateCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((Xyz.Xrm.Entities.PickListMappingState)(System.Enum.ToObject(typeof(Xyz.Xrm.Entities.PickListMappingState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
		}
		
		/// <summary>
		/// Reason for the status of the picklist mapping.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StatusCode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("StatusCode");
			}
		}
		
		/// <summary>
		/// Microsoft Dynamics CRM list value with which to replace the source value.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("targetvalue")]
		public System.Nullable<int> TargetValue
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("targetvalue");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TargetValue");
				this.SetAttributeValue("targetvalue", value);
				this.OnPropertyChanged("TargetValue");
			}
		}
		
		/// <summary>
		/// 1:N userentityinstancedata_picklistmapping
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_picklistmapping")]
		public System.Collections.Generic.IEnumerable<Xyz.Xrm.Entities.UserEntityInstanceData> userentityinstancedata_picklistmapping
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Xyz.Xrm.Entities.UserEntityInstanceData>("userentityinstancedata_picklistmapping", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("userentityinstancedata_picklistmapping");
				this.SetRelatedEntities<Xyz.Xrm.Entities.UserEntityInstanceData>("userentityinstancedata_picklistmapping", null, value);
				this.OnPropertyChanged("userentityinstancedata_picklistmapping");
			}
		}
		
		/// <summary>
		/// N:1 lk_picklistmapping_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_picklistmapping_createdby")]
		public Xyz.Xrm.Entities.SystemUser lk_picklistmapping_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.SystemUser>("lk_picklistmapping_createdby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_picklistmapping_createdby");
				this.SetRelatedEntity<Xyz.Xrm.Entities.SystemUser>("lk_picklistmapping_createdby", null, value);
				this.OnPropertyChanged("lk_picklistmapping_createdby");
			}
		}
		
		/// <summary>
		/// N:1 lk_picklistmapping_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_picklistmapping_createdonbehalfby")]
		public Xyz.Xrm.Entities.SystemUser lk_picklistmapping_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.SystemUser>("lk_picklistmapping_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_picklistmapping_createdonbehalfby");
				this.SetRelatedEntity<Xyz.Xrm.Entities.SystemUser>("lk_picklistmapping_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_picklistmapping_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_picklistmapping_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_picklistmapping_modifiedby")]
		public Xyz.Xrm.Entities.SystemUser lk_picklistmapping_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.SystemUser>("lk_picklistmapping_modifiedby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_picklistmapping_modifiedby");
				this.SetRelatedEntity<Xyz.Xrm.Entities.SystemUser>("lk_picklistmapping_modifiedby", null, value);
				this.OnPropertyChanged("lk_picklistmapping_modifiedby");
			}
		}
		
		/// <summary>
		/// N:1 lk_picklistmapping_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_picklistmapping_modifiedonbehalfby")]
		public Xyz.Xrm.Entities.SystemUser lk_picklistmapping_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.SystemUser>("lk_picklistmapping_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_picklistmapping_modifiedonbehalfby");
				this.SetRelatedEntity<Xyz.Xrm.Entities.SystemUser>("lk_picklistmapping_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_picklistmapping_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 PickListMapping_ColumnMapping
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("columnmappingid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("PickListMapping_ColumnMapping")]
		public Xyz.Xrm.Entities.ColumnMapping PickListMapping_ColumnMapping
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.ColumnMapping>("PickListMapping_ColumnMapping", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PickListMapping_ColumnMapping");
				this.SetRelatedEntity<Xyz.Xrm.Entities.ColumnMapping>("PickListMapping_ColumnMapping", null, value);
				this.OnPropertyChanged("PickListMapping_ColumnMapping");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public PickListMapping(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();
            
                if (name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int) value);
                    name = name.Remove(name.Length - "enum".Length);
                }
            
                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["picklistmappingid"] = base.Id;
                        break;
                    case "picklistmappingid":
                        var id = (System.Nullable<System.Guid>) value;
                        if(id == null){ continue; }
                        base.Id = id.Value;
                        Attributes[name] = base.Id;
                        break;
                    case "formattedvalues":
                        // Add Support for FormattedValues
                        FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                        break;
                    default:
                        Attributes[name] = value;
                        break;
                }
            }
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processcode")]
		public virtual PickListMapping_ProcessCode? ProcessCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((PickListMapping_ProcessCode?)(EntityOptionSetEnum.GetEnum(this, "processcode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				ProcessCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual PickListMapping_StatusCode? StatusCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((PickListMapping_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				StatusCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}