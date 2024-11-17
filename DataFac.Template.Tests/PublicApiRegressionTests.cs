﻿using FluentAssertions;
using PublicApiGenerator;
using System.Threading.Tasks;
using VerifyXunit;
using Xunit;

namespace DataFac.Template.Tests
{
    public class PublicApiRegressionTests
    {
        [Fact]
        public void VersionCheck()
        {
            ThisAssembly.AssemblyVersion.Should().Be("0.1.0.0");
        }

        [Fact]
        public async Task CheckPublicApi()
        {
            // act
            var options = new ApiGeneratorOptions()
            {
                IncludeAssemblyAttributes = false
            };
            string currentApi = ApiGenerator.GeneratePublicApi(typeof(MyClass).Assembly, options);

            // assert
            await Verifier.Verify(currentApi);
        }

    }
}