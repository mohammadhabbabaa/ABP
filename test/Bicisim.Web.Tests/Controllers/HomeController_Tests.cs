using System.Threading.Tasks;
using Bicisim.Models.TokenAuth;
using Bicisim.Web.Controllers;
using Shouldly;
using Xunit;

namespace Bicisim.Web.Tests.Controllers
{
    public class HomeController_Tests: BicisimWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}