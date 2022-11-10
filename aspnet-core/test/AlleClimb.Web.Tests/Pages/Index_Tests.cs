using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace AlleClimb.Pages;

public class Index_Tests : AlleClimbWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
