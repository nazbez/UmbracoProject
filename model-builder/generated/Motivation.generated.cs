//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v9.0.0-beta003+b07f6519e7a1c890b534502982612ce6b3fea293
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	// Mixin Content Type with alias "motivation"
	/// <summary>Motivation</summary>
	public partial interface IMotivation : IPublishedContent
	{
		/// <summary>Motivation Block</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta003+b07f6519e7a1c890b534502982612ce6b3fea293")]
		global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.Block> MotivationBlock { get; }
	}

	/// <summary>Motivation</summary>
	[PublishedModel("motivation")]
	public partial class Motivation : PublishedContentModel, IMotivation
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta003+b07f6519e7a1c890b534502982612ce6b3fea293")]
		public new const string ModelTypeAlias = "motivation";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta003+b07f6519e7a1c890b534502982612ce6b3fea293")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta003+b07f6519e7a1c890b534502982612ce6b3fea293")]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta003+b07f6519e7a1c890b534502982612ce6b3fea293")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<Motivation, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public Motivation(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Motivation Block
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta003+b07f6519e7a1c890b534502982612ce6b3fea293")]
		[ImplementPropertyType("motivationBlock")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.Block> MotivationBlock => GetMotivationBlock(this, _publishedValueFallback);

		/// <summary>Static getter for Motivation Block</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta003+b07f6519e7a1c890b534502982612ce6b3fea293")]
		public static global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.Block> GetMotivationBlock(IMotivation that, IPublishedValueFallback publishedValueFallback) => that.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.Block>>(publishedValueFallback, "motivationBlock");
	}
}
