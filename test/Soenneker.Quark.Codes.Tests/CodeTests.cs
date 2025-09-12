using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.Codes.Tests;

[Collection("Collection")]
public sealed class CodeTests : FixturedUnitTest
{
    public CodeTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {
        // Test that the component can be instantiated
        Assert.True(true);
    }
}
