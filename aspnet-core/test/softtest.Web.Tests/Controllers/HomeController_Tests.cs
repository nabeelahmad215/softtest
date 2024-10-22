using System.Threading.Tasks;
using softtest.Models.TokenAuth;
using softtest.Web.Controllers;
using Shouldly;
using Xunit;

namespace softtest.Web.Tests.Controllers
{
    public class HomeController_Tests: softtestWebTestBase
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