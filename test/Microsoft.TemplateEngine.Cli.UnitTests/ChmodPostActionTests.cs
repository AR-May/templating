using Xunit;

namespace Microsoft.TemplateEngine.Cli.UnitTests
{
    public class ChmodPostActionTests : EndToEndTestBase
    {
        [Theory(DisplayName = nameof(VerifyTemplatesWithChmodPostAction))]
        [InlineData("TestAssets.TemplateWithChmodPostaction", "TemplateWithChmodPostaction.json")]
        public void VerifyTemplatesWithChmodPostAction(string args, params string[] scripts)
        {
            Run(args, scripts);
        }
    }
}
