﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
namespace BotFrameworkDsl
{
	/// <summary>
	/// DomainClass BotFrameworkModel
	/// The root in which all other elements are embedded. Appears as a diagram.
	/// </summary>
	[DslDesign::DisplayNameResource("BotFrameworkDsl.BotFrameworkModel.DisplayName", typeof(global::BotFrameworkDsl.BotFrameworkDslDomainModel), "BotFrameworkDsl.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("BotFrameworkDsl.BotFrameworkModel.Description", typeof(global::BotFrameworkDsl.BotFrameworkDslDomainModel), "BotFrameworkDsl.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::BotFrameworkDsl.BotFrameworkDslDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("5173e501-07c6-402a-ac38-aed9072ff8da")]
	public partial class BotFrameworkModel : DslModeling::ModelElement
	{
		#region Constructors, domain class Id
	
		/// <summary>
		/// BotFrameworkModel domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x5173e501, 0x07c6, 0x402a, 0xac, 0x38, 0xae, 0xd9, 0x07, 0x2f, 0xf8, 0xda);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public BotFrameworkModel(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public BotFrameworkModel(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region Elements opposite domain role accessor
		
		/// <summary>
		/// Gets a list of Elements.
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<Node> Elements
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<Node>, Node>(global::BotFrameworkDsl.BotFrameworkModelHasElements.BotFrameworkModelDomainRoleId);
			}
		}
		#endregion
		#region ElementGroupPrototype Merge methods
		/// <summary>
		/// Returns a value indicating whether the source element represented by the
		/// specified root ProtoElement can be added to this element.
		/// </summary>
		/// <param name="rootElement">
		/// The root ProtoElement representing a source element.  This can be null, 
		/// in which case the ElementGroupPrototype does not contain an ProtoElements
		/// and the code should inspect the ElementGroupPrototype context information.
		/// </param>
		/// <param name="elementGroupPrototype">The ElementGroupPrototype that contains the root ProtoElement.</param>
		/// <returns>true if the source element represented by the ProtoElement can be added to this target element.</returns>
		protected override bool CanMerge(DslModeling::ProtoElementBase rootElement, DslModeling::ElementGroupPrototype elementGroupPrototype)
		{
			if ( elementGroupPrototype == null ) throw new global::System.ArgumentNullException("elementGroupPrototype");
			
			if (rootElement != null)
			{
				DslModeling::DomainClassInfo rootElementDomainInfo = this.Partition.DomainDataDirectory.GetDomainClass(rootElement.DomainClassId);
				
				if (rootElementDomainInfo.IsDerivedFrom(global::BotFrameworkDsl.Node.DomainClassId)) 
				{
					return true;
				}
			}
			return base.CanMerge(rootElement, elementGroupPrototype);
		}
		
		/// <summary>
		/// Called by the Merge process to create a relationship between 
		/// this target element and the specified source element. 
		/// Typically, a parent-child relationship is established
		/// between the target element (the parent) and the source element 
		/// (the child), but any relationship can be established.
		/// </summary>
		/// <param name="sourceElement">The element that is to be related to this model element.</param>
		/// <param name="elementGroup">The group of source ModelElements that have been rehydrated into the target store.</param>
		/// <remarks>
		/// This method is overriden to create the relationship between the target element and the specified source element.
		/// The base method does nothing.
		/// </remarks>
		protected override void MergeRelate(DslModeling::ModelElement sourceElement, DslModeling::ElementGroup elementGroup)
		{
			// In general, sourceElement is allowed to be null, meaning that the elementGroup must be parsed for special cases.
			// However this is not supported in generated code.  Use double-deriving on this class and then override MergeRelate completely if you 
			// need to support this case.
			if ( sourceElement == null ) throw new global::System.ArgumentNullException("sourceElement");
		
				
			global::BotFrameworkDsl.Node sourceNode1 = sourceElement as global::BotFrameworkDsl.Node;
			if (sourceNode1 != null)
			{
				// Create link for path BotFrameworkModelHasElements.Elements
				this.Elements.Add(sourceNode1);

				return;
			}
		
			// Sdk workaround to runtime bug #879350 (DSL: can't copy and paste a MEL that has a MEX). Avoid MergeRelate on ModelElementExtension
			// during a "Paste".
			if (sourceElement is DslModeling::ExtensionElement
				&& sourceElement.Store.TransactionManager.CurrentTransaction.TopLevelTransaction.Context.ContextInfo.ContainsKey("{9DAFD42A-DC0E-4d78-8C3F-8266B2CF8B33}"))
			{
				return;
			}
		
			// Fall through to base class if this class hasn't handled the merge.
			base.MergeRelate(sourceElement, elementGroup);
		}
		
		/// <summary>
		/// Performs operation opposite to MergeRelate - i.e. disconnects a given
		/// element from the current one (removes links created by MergeRelate).
		/// </summary>
		/// <param name="sourceElement">Element to be unmerged/disconnected.</param>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		protected override void MergeDisconnect(DslModeling::ModelElement sourceElement)
		{
			if (sourceElement == null) throw new global::System.ArgumentNullException("sourceElement");
				
			global::BotFrameworkDsl.Node sourceNode1 = sourceElement as global::BotFrameworkDsl.Node;
			if (sourceNode1 != null)
			{
				// Delete link for path BotFrameworkModelHasElements.Elements
				
				foreach (DslModeling::ElementLink link in global::BotFrameworkDsl.BotFrameworkModelHasElements.GetLinks((global::BotFrameworkDsl.BotFrameworkModel)this, sourceNode1))
				{
					// Delete the link, but without possible delete propagation to the element since it's moving to a new location.
					link.Delete(global::BotFrameworkDsl.BotFrameworkModelHasElements.BotFrameworkModelDomainRoleId, global::BotFrameworkDsl.BotFrameworkModelHasElements.ElementDomainRoleId);
				}

				return;
			}
			// Fall through to base class if this class hasn't handled the unmerge.
			base.MergeDisconnect(sourceElement);
		}
		#endregion
	}
}
namespace BotFrameworkDsl
{
	/// <summary>
	/// DomainClass Node
	/// Elements embedded in the model. Appear as boxes on the diagram.
	/// </summary>
	[DslDesign::DisplayNameResource("BotFrameworkDsl.Node.DisplayName", typeof(global::BotFrameworkDsl.BotFrameworkDslDomainModel), "BotFrameworkDsl.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("BotFrameworkDsl.Node.Description", typeof(global::BotFrameworkDsl.BotFrameworkDslDomainModel), "BotFrameworkDsl.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::BotFrameworkDsl.BotFrameworkDslDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("3aa3b9cf-4307-4ef7-b3b2-9f0d5f80959b")]
	public abstract partial class Node : DslModeling::ModelElement
	{
		#region Constructors, domain class Id
	
		/// <summary>
		/// Node domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x3aa3b9cf, 0x4307, 0x4ef7, 0xb3, 0xb2, 0x9f, 0x0d, 0x5f, 0x80, 0x95, 0x9b);
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		protected Node(DslModeling::Partition partition, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region BotFrameworkModel opposite domain role accessor
		/// <summary>
		/// Gets or sets BotFrameworkModel.
		/// </summary>
		public virtual BotFrameworkModel BotFrameworkModel
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return DslModeling::DomainRoleInfo.GetLinkedElement(this, global::BotFrameworkDsl.BotFrameworkModelHasElements.ElementDomainRoleId) as BotFrameworkModel;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetLinkedElement(this, global::BotFrameworkDsl.BotFrameworkModelHasElements.ElementDomainRoleId, value);
			}
		}
		#endregion
		#region Targets opposite domain role accessor
		
		/// <summary>
		/// Gets a list of Targets.
		/// Description for BotFrameworkDsl.ExampleRelationship.Target
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<Node> Targets
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<Node>, Node>(global::BotFrameworkDsl.NodeReferencesTargets.SourceDomainRoleId);
			}
		}
		#endregion
		#region Sources opposite domain role accessor
		
		/// <summary>
		/// Gets a list of Sources.
		/// Description for BotFrameworkDsl.ExampleRelationship.Source
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<Node> Sources
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<Node>, Node>(global::BotFrameworkDsl.NodeReferencesTargets.TargetDomainRoleId);
			}
		}
		#endregion
	}
}
namespace BotFrameworkDsl
{
	/// <summary>
	/// DomainClass Start
	/// Description for BotFrameworkDsl.Start
	/// </summary>
	[DslDesign::DisplayNameResource("BotFrameworkDsl.Start.DisplayName", typeof(global::BotFrameworkDsl.BotFrameworkDslDomainModel), "BotFrameworkDsl.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("BotFrameworkDsl.Start.Description", typeof(global::BotFrameworkDsl.BotFrameworkDslDomainModel), "BotFrameworkDsl.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::BotFrameworkDsl.BotFrameworkDslDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("6e9695db-637f-4c50-9a6b-46c6aa300ef1")]
	public partial class Start : Node
	{
		#region Constructors, domain class Id
	
		/// <summary>
		/// Start domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x6e9695db, 0x637f, 0x4c50, 0x9a, 0x6b, 0x46, 0xc6, 0xaa, 0x30, 0x0e, 0xf1);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public Start(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public Start(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region Name domain property code
		
		/// <summary>
		/// Name domain property Id.
		/// </summary>
		public static readonly global::System.Guid NameDomainPropertyId = new global::System.Guid(0xa53459fa, 0x3e00, 0x497f, 0xa4, 0x2e, 0xb4, 0x7f, 0xab, 0x5d, 0x7b, 0xad);
		
		/// <summary>
		/// Storage for Name
		/// </summary>
		private global::System.String namePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of Name domain property.
		/// Description for BotFrameworkDsl.Start.Name
		/// </summary>
		[DslDesign::DisplayNameResource("BotFrameworkDsl.Start/Name.DisplayName", typeof(global::BotFrameworkDsl.BotFrameworkDslDomainModel), "BotFrameworkDsl.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("BotFrameworkDsl.Start/Name.Description", typeof(global::BotFrameworkDsl.BotFrameworkDslDomainModel), "BotFrameworkDsl.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("a53459fa-3e00-497f-a42e-b47fab5d7bad")]
		public global::System.String Name
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return namePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				NamePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Start.Name domain property.
		/// </summary>
		internal sealed partial class NamePropertyHandler : DslModeling::DomainPropertyValueHandler<Start, global::System.String>
		{
			private NamePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Start.Name domain property value handler.
			/// </summary>
			public static readonly NamePropertyHandler Instance = new NamePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Start.Name domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return NameDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Start element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.namePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Start element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.namePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
	}
}
namespace BotFrameworkDsl
{
	/// <summary>
	/// DomainClass Speak
	/// Description for BotFrameworkDsl.Speak
	/// </summary>
	[DslDesign::DisplayNameResource("BotFrameworkDsl.Speak.DisplayName", typeof(global::BotFrameworkDsl.BotFrameworkDslDomainModel), "BotFrameworkDsl.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("BotFrameworkDsl.Speak.Description", typeof(global::BotFrameworkDsl.BotFrameworkDslDomainModel), "BotFrameworkDsl.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::BotFrameworkDsl.BotFrameworkDslDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("643a56d9-60cf-4ddf-8ea5-d92b585768f6")]
	public partial class Speak : Node
	{
		#region Constructors, domain class Id
	
		/// <summary>
		/// Speak domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x643a56d9, 0x60cf, 0x4ddf, 0x8e, 0xa5, 0xd9, 0x2b, 0x58, 0x57, 0x68, 0xf6);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public Speak(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public Speak(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region Name domain property code
		
		/// <summary>
		/// Name domain property Id.
		/// </summary>
		public static readonly global::System.Guid NameDomainPropertyId = new global::System.Guid(0xc8234a11, 0x4f23, 0x4caf, 0x84, 0xe9, 0x5f, 0x19, 0xd8, 0x53, 0x9b, 0x31);
		
		/// <summary>
		/// Storage for Name
		/// </summary>
		private global::System.String namePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of Name domain property.
		/// Description for BotFrameworkDsl.Speak.Name
		/// </summary>
		[DslDesign::DisplayNameResource("BotFrameworkDsl.Speak/Name.DisplayName", typeof(global::BotFrameworkDsl.BotFrameworkDslDomainModel), "BotFrameworkDsl.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("BotFrameworkDsl.Speak/Name.Description", typeof(global::BotFrameworkDsl.BotFrameworkDslDomainModel), "BotFrameworkDsl.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("c8234a11-4f23-4caf-84e9-5f19d8539b31")]
		public global::System.String Name
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return namePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				NamePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Speak.Name domain property.
		/// </summary>
		internal sealed partial class NamePropertyHandler : DslModeling::DomainPropertyValueHandler<Speak, global::System.String>
		{
			private NamePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Speak.Name domain property value handler.
			/// </summary>
			public static readonly NamePropertyHandler Instance = new NamePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Speak.Name domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return NameDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Speak element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.namePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Speak element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.namePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
	}
}
namespace BotFrameworkDsl
{
	/// <summary>
	/// DomainClass Listen
	/// Description for BotFrameworkDsl.Listen
	/// </summary>
	[DslDesign::DisplayNameResource("BotFrameworkDsl.Listen.DisplayName", typeof(global::BotFrameworkDsl.BotFrameworkDslDomainModel), "BotFrameworkDsl.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("BotFrameworkDsl.Listen.Description", typeof(global::BotFrameworkDsl.BotFrameworkDslDomainModel), "BotFrameworkDsl.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::BotFrameworkDsl.BotFrameworkDslDomainModel))]
	[global::System.CLSCompliant(true)]
	[global::System.Diagnostics.DebuggerDisplay("{GetType().Name,nq} (Name = {namePropertyStorage})")]
	[DslModeling::DomainObjectId("ae7a8935-0d81-4360-b52b-d3277093a204")]
	public partial class Listen : Node
	{
		#region Constructors, domain class Id
	
		/// <summary>
		/// Listen domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0xae7a8935, 0x0d81, 0x4360, 0xb5, 0x2b, 0xd3, 0x27, 0x70, 0x93, 0xa2, 0x04);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public Listen(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public Listen(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region Name domain property code
		
		/// <summary>
		/// Name domain property Id.
		/// </summary>
		public static readonly global::System.Guid NameDomainPropertyId = new global::System.Guid(0x3f958f4e, 0x5721, 0x4ee0, 0xb4, 0xbc, 0x5d, 0x0e, 0xb6, 0x1b, 0x7e, 0x4b);
		
		/// <summary>
		/// Storage for Name
		/// </summary>
		private global::System.String namePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of Name domain property.
		/// Description for BotFrameworkDsl.Listen.Name
		/// </summary>
		[DslDesign::DisplayNameResource("BotFrameworkDsl.Listen/Name.DisplayName", typeof(global::BotFrameworkDsl.BotFrameworkDslDomainModel), "BotFrameworkDsl.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("BotFrameworkDsl.Listen/Name.Description", typeof(global::BotFrameworkDsl.BotFrameworkDslDomainModel), "BotFrameworkDsl.GeneratedCode.DomainModelResx")]
		[DslModeling::ElementName]
		[DslModeling::DomainObjectId("3f958f4e-5721-4ee0-b4bc-5d0eb61b7e4b")]
		public global::System.String Name
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return namePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				NamePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Listen.Name domain property.
		/// </summary>
		internal sealed partial class NamePropertyHandler : DslModeling::DomainPropertyValueHandler<Listen, global::System.String>
		{
			private NamePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Listen.Name domain property value handler.
			/// </summary>
			public static readonly NamePropertyHandler Instance = new NamePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Listen.Name domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return NameDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Listen element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.namePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Listen element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.namePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
	}
}
namespace BotFrameworkDsl
{
	/// <summary>
	/// DomainClass End
	/// Description for BotFrameworkDsl.End
	/// </summary>
	[DslDesign::DisplayNameResource("BotFrameworkDsl.End.DisplayName", typeof(global::BotFrameworkDsl.BotFrameworkDslDomainModel), "BotFrameworkDsl.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("BotFrameworkDsl.End.Description", typeof(global::BotFrameworkDsl.BotFrameworkDslDomainModel), "BotFrameworkDsl.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::BotFrameworkDsl.BotFrameworkDslDomainModel))]
	[global::System.CLSCompliant(true)]
	[global::System.Diagnostics.DebuggerDisplay("{GetType().Name,nq} (Name = {namePropertyStorage})")]
	[DslModeling::DomainObjectId("819f7208-a421-47b7-a363-2cb27f2979f3")]
	public partial class End : Node
	{
		#region Constructors, domain class Id
	
		/// <summary>
		/// End domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x819f7208, 0xa421, 0x47b7, 0xa3, 0x63, 0x2c, 0xb2, 0x7f, 0x29, 0x79, 0xf3);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public End(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public End(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region Name domain property code
		
		/// <summary>
		/// Name domain property Id.
		/// </summary>
		public static readonly global::System.Guid NameDomainPropertyId = new global::System.Guid(0x6b7a724c, 0x0529, 0x428c, 0x8b, 0x53, 0x00, 0x97, 0x9a, 0x1c, 0x6e, 0xb7);
		
		/// <summary>
		/// Storage for Name
		/// </summary>
		private global::System.String namePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of Name domain property.
		/// Description for BotFrameworkDsl.End.Name
		/// </summary>
		[DslDesign::DisplayNameResource("BotFrameworkDsl.End/Name.DisplayName", typeof(global::BotFrameworkDsl.BotFrameworkDslDomainModel), "BotFrameworkDsl.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("BotFrameworkDsl.End/Name.Description", typeof(global::BotFrameworkDsl.BotFrameworkDslDomainModel), "BotFrameworkDsl.GeneratedCode.DomainModelResx")]
		[DslModeling::ElementName]
		[DslModeling::DomainObjectId("6b7a724c-0529-428c-8b53-00979a1c6eb7")]
		public global::System.String Name
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return namePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				NamePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the End.Name domain property.
		/// </summary>
		internal sealed partial class NamePropertyHandler : DslModeling::DomainPropertyValueHandler<End, global::System.String>
		{
			private NamePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the End.Name domain property value handler.
			/// </summary>
			public static readonly NamePropertyHandler Instance = new NamePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the End.Name domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return NameDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(End element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.namePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(End element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.namePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
	}
}
