using GammaJul.ReSharper.EnhancedTooltip.DocumentMarkup;
using JetBrains.Annotations;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Daemon.CSharp.Errors;
using JetBrains.ReSharper.Psi.CodeAnnotations;

namespace GammaJul.ReSharper.EnhancedTooltip.Presentation.Highlightings.CSharp {

	[SolutionComponent]
	internal sealed class CannotHaveEventAccessorsInAbstractEventErrorEnhancer : CSharpHighlightingEnhancer<CannotHaveEventAccessorsInAbstractEventError> {

		protected override void AppendTooltip(CannotHaveEventAccessorsInAbstractEventError highlighting, CSharpColorizer colorizer) {
			colorizer.AppendPlainText("Abstract event cannot have ");
			colorizer.AppendAccessorName("add");
			colorizer.AppendPlainText(" or ");
			colorizer.AppendAccessorName("remove");
			colorizer.AppendPlainText(" accessors");
		}

		public CannotHaveEventAccessorsInAbstractEventErrorEnhancer(
			[NotNull] TextStyleHighlighterManager textStyleHighlighterManager,
			[NotNull] CodeAnnotationsConfiguration codeAnnotationsConfiguration,
			[NotNull] HighlighterIdProviderFactory highlighterIdProviderFactory)
			: base(textStyleHighlighterManager, codeAnnotationsConfiguration, highlighterIdProviderFactory) {
		}

	}

}