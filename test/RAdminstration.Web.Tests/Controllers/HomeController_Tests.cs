using System.Threading.Tasks;
using RAdminstration.Models.TokenAuth;
using RAdminstration.Web.Controllers;
using Shouldly;
using Xunit;

namespace RAdminstration.Web.Tests.Controllers
{
    public class HomeController_Tests: RAdminstrationWebTestBase
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