using Soenneker.Tests.HostedUnit;

namespace Soenneker.WorkOs.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class WorkOsOpenApiClientTests : HostedUnitTest
{
    public WorkOsOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
