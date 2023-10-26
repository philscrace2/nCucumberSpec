using System.Diagnostics;
using System.IO;
using Gherkin.Specs.Helper;
using Xunit;

namespace Gherkin.Specs
{
    public class nCucumberSpecTests
    {
        [Theory, MemberData(nameof(TestFileProvider.GetnCucumberSpecTestFiles), MemberType = typeof(TestFileProvider))]
        public void TestParsingBasicFile(string testFeatureFile)
        {
            var fullPathToTestFeatureFile = Path.Combine(TestFileProvider.GetTestFileFolder("nCucumberSpec"), testFeatureFile);
            var featureFileFolder = Path.GetDirectoryName(fullPathToTestFeatureFile);
            Debug.Assert(featureFileFolder != null);
            //var expectedTokensFile = fullPathToTestFeatureFile + ".tokens";

            var tokensText = Tokens.TokensGenerator.GenerateTokens(fullPathToTestFeatureFile);
            //var expectedTokensText = LineEndingHelper.NormalizeLineEndings(File.ReadAllText(expectedTokensFile));

            //Assert.Equal(expectedTokensText, tokensText);
        }
    }
}
