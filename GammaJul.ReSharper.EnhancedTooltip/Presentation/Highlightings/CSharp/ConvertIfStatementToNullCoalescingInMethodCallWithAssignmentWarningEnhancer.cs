using GammaJul.ReSharper.EnhancedTooltip.DocumentMarkup;
using JetBrains.Annotations;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Daemon.CSharp.Errors;
using JetBrains.ReSharper.Psi.CodeAnnotations;

namespace GammaJul.ReSharper.EnhancedTooltip.Presentation.Highlightings.CSharp {

	[SolutionComponent]
	internal sealed class ConvertIfStatementToNullCoalescingInMethodCallWithAssignmentWarningEnhancer : CSharpHighlightingEnhancer<ConvertIfStatementToNullCoalescingInMethodCallWithAssignmentWarning> {

		protected override void AppendTooltip(ConvertIfStatementToNullCoalescingInMethodCallWithAssignmentWarning highlighting, CSharpColorizer colorizer) {
			colorizer.AppendPlainText("Convert to method call with '");
			colorizer.AppendOperator("??");
			colorizer.AppendPlainText("' expression inside");
		}
		
		public ConvertIfStatementToNullCoalescingInMethodCallWithAssignmentWarningEnhancer(
			[NotNull] TextStyleHighlighterManager textStyleHighlighterManager,
			[NotNull] CodeAnnotationsConfiguration codeAnnotationsConfiguration,
			[NotNull] HighlighterIdProviderFactory highlighterIdProviderFactory)
			: base(textStyleHighlighterManager, codeAnnotationsConfiguration, highlighterIdProviderFactory) {
		}

	}

}