using FluentAssertions;
using PublicApiGenerator;
using System.Threading.Tasks;
using VerifyXunit;
using Xunit;

namespace DataFac.Runtime.Tests
{
    public class AssemblyRegressionTests
    {
        [Fact]
        public void CheckVersion()
        {
            ThisAssembly.AssemblyVersion.Should().Be("0.2.0.0");
        }

        [Fact]
        public async Task CheckPublicApi()
        {
            // act
            var options = new ApiGeneratorOptions()
            {
                IncludeAssemblyAttributes = false
            };
            string currentApi = ApiGenerator.GeneratePublicApi(typeof(IMutability).Assembly, options);

            // assert
            await Verifier.Verify(currentApi);
        }

    }
}