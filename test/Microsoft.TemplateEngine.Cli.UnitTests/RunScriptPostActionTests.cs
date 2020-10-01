using Xunit;

namespace Microsoft.TemplateEngine.Cli.UnitTests
{
    public class RunScriptPostActionTests : EndToEndTestBase
    {
        [Theory(DisplayName = nameof(VerifyTemplatesWithRunScriptPostAction))]
        [InlineData("TestAssets.TemplateWithRunScriptPostaction --allow-scripts yes", "TemplateWithRunScriptPostaction.json")]
        public void VerifyTemplatesWithRunScriptPostAction(string args, params string[] scripts)
        {
            Run(args, scripts);
        }
    }
}
