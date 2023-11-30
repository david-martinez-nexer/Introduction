//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v12.3.3+d2ff2ea
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
	/// <summary>Carousel Row Settings</summary>
	[PublishedModel("carouselRowSettings")]
	public partial class CarouselRowSettings : PublishedElementModel, IBlockVisibilitySettings
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.3+d2ff2ea")]
		public new const string ModelTypeAlias = "carouselRowSettings";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.3+d2ff2ea")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.3+d2ff2ea")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.3+d2ff2ea")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<CarouselRowSettings, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public CarouselRowSettings(IPublishedElement content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Show Dark Mode: Set this to true if you want the carousel to be in dark mode
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.3+d2ff2ea")]
		[ImplementPropertyType("showDarkMode")]
		public virtual bool ShowDarkMode => this.Value<bool>(_publishedValueFallback, "showDarkMode");

		///<summary>
		/// Show Indicators: Set this to true if you would like to show the indicators on this carousel
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.3+d2ff2ea")]
		[ImplementPropertyType("showIndicators")]
		public virtual bool ShowIndicators => this.Value<bool>(_publishedValueFallback, "showIndicators");

		///<summary>
		/// Show Navigation Arrows: Set this to true if you would like to show the navigation arrows
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.3+d2ff2ea")]
		[ImplementPropertyType("showNavigationArrows")]
		public virtual bool ShowNavigationArrows => this.Value<bool>(_publishedValueFallback, "showNavigationArrows");

		///<summary>
		/// Hide: Set this to true if you want to hide this item
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.3+d2ff2ea")]
		[ImplementPropertyType("hide")]
		public virtual bool Hide => global::Umbraco.Cms.Web.Common.PublishedModels.BlockVisibilitySettings.GetHide(this, _publishedValueFallback);
	}
}
