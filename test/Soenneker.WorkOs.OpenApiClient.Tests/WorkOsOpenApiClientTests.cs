using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.WorkOs.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class WorkOsOpenApiClientTests : FixturedUnitTest
{
    public WorkOsOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
