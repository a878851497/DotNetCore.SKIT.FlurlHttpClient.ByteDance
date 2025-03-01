using SKIT.FlurlHttpClient.Tools.CodeAnalyzer;
using Xunit;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.UnitTests
{
    public class TestCase_CodeReview
    {
        [Fact(DisplayName = "测试用例：代码质量分析")]
        public void TestCodeAnalyzer()
        {
            Assert.Null(Record.Exception(() =>
            {
                CodeAnalyzerOptions options = new CodeAnalyzerOptions()
                {
                    AssemblyName = "SKIT.FlurlHttpClient.ByteDance.MicroApp",
                    WorkDirectoryForSourceCode = TestConfigs.WorkDirectoryForSdk,
                    WorkDirectoryForTestSample = TestConfigs.WorkDirectoryForTest,
                    WorkSubDirectoryForApiModelSamples = "ModelSamples/_",
                    WorkSubDirectoryForApiEventSamples = "EventSamples/_",
                };
                CodeAnalyzer analyzer = new CodeAnalyzer(options);
                analyzer.Start();
                analyzer.Assert();
                analyzer.Flush();
            }));

            Assert.Null(Record.Exception(() =>
            {
                CodeAnalyzerOptions options = new CodeAnalyzerOptions()
                {
                    AssemblyName = "SKIT.FlurlHttpClient.ByteDance.MicroApp",
                    TargetSdkApiModelNamespaceUnderAssemblyIdentifier = "SDK.ProductApi.Models",
                    TargetSdkApiEventNamespaceUnderAssemblyIdentifier = "SDK.ProductApi.Events",
                    //TargetSdkApiMethodNamespaceUnderAssemblyIdentifier = "SDK.ProductApi",
                    WorkDirectoryForSourceCode = TestConfigs.WorkDirectoryForSdk,
                    WorkDirectoryForTestSample = TestConfigs.WorkDirectoryForTest,
                    WorkSubDirectoryForApiMethods = "SDK/ProductApi/Extensions",
                    WorkSubDirectoryForApiModels = "SDK/ProductApi/Models",
                    WorkSubDirectoryForApiEvents = "SDK/ProductApi/Events",
                    WorkSubDirectoryForApiModelSamples = "ModelSamples/ProductApi",
                    WorkSubDirectoryForApiEventSamples = "EventSamples/ProductApi"
                };
                CodeAnalyzer analyzer = new CodeAnalyzer(options);
                analyzer.Start();
                analyzer.Assert();
                analyzer.Flush();
            }));

            Assert.Null(Record.Exception(() =>
            {
                CodeAnalyzerOptions options = new CodeAnalyzerOptions()
                {
                    AssemblyName = "SKIT.FlurlHttpClient.ByteDance.MicroApp",
                    TargetSdkApiModelNamespaceUnderAssemblyIdentifier = "SDK.RoleApi.Models",
                    TargetSdkApiEventNamespaceUnderAssemblyIdentifier = "SDK.RoleApi.Events",
                    //TargetSdkApiMethodNamespaceUnderAssemblyIdentifier = "SDK.RoleApi",
                    WorkDirectoryForSourceCode = TestConfigs.WorkDirectoryForSdk,
                    WorkDirectoryForTestSample = TestConfigs.WorkDirectoryForTest,
                    WorkSubDirectoryForApiMethods = "SDK/RoleApi/Extensions",
                    WorkSubDirectoryForApiModels = "SDK/RoleApi/Models",
                    WorkSubDirectoryForApiEvents = "SDK/RoleApi/Events",
                    WorkSubDirectoryForApiModelSamples = "ModelSamples/RoleApi",
                    WorkSubDirectoryForApiEventSamples = "EventSamples/RoleApi",
                    AllowNotFoundEventTypes = true,
                    AllowNotFoundEventSamples = true
                };
                CodeAnalyzer analyzer = new CodeAnalyzer(options);
                analyzer.Start();
                analyzer.Assert();
                analyzer.Flush();
            }));

            Assert.Null(Record.Exception(() =>
            {
                CodeAnalyzerOptions options = new CodeAnalyzerOptions()
                {
                    AssemblyName = "SKIT.FlurlHttpClient.ByteDance.MicroApp",
                    TargetSdkApiModelNamespaceUnderAssemblyIdentifier = "SDK.OpenApi.Models",
                    TargetSdkApiEventNamespaceUnderAssemblyIdentifier = "SDK.OpenApi.Events",
                    //TargetSdkApiMethodNamespaceUnderAssemblyIdentifier = "SDK.OpenApi",
                    WorkDirectoryForSourceCode = TestConfigs.WorkDirectoryForSdk,
                    WorkDirectoryForTestSample = TestConfigs.WorkDirectoryForTest,
                    WorkSubDirectoryForApiMethods = "SDK/OpenApi/Extensions",
                    WorkSubDirectoryForApiModels = "SDK/OpenApi/Models",
                    WorkSubDirectoryForApiEvents = "SDK/OpenApi/Events",
                    WorkSubDirectoryForApiModelSamples = "ModelSamples/OpenApi",
                    WorkSubDirectoryForApiEventSamples = "EventSamples/OpenApi"
                };
                CodeAnalyzer analyzer = new CodeAnalyzer(options);
                analyzer.Start();
                analyzer.Assert();
                analyzer.Flush();
            }));
        }
    }
}
