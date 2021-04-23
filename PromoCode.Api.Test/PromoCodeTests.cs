using Moq;
using NUnit.Framework;
using PromoCode.Api.Controllers;
using PromoCode.Model.API;
using PromoCode.Model.Response;
using PromoCode.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PromoCode.Api.Test
{
    class PromoCodeTests
    {
        Mock<IPromoCodeService> PromoCodeServiceMock = new Mock<IPromoCodeService>();
        private PromoCodeController PromoCodeController;

        [SetUp]
        public void Setup()
        {
            var promos = new List<PromoCodeResponse> { new PromoCodeResponse()
                            { 
                                Id=1,BonusActivated = true,PromoCode= "ITPROMOS", ProductName = "Appvision.com",
                                ProductDescription= "Appvision" }
                            };
            PromoCodeServiceMock.Setup(x => x.GetPromoCodesAsync())
                .ReturnsAsync(new ApiResponse(HttpStatusCode.OK) { ResponseObject = promos });

        }
        [Test]
        public async Task should_GetPromoCodes()
        {
            PromoCodeController = new PromoCodeController(PromoCodeServiceMock.Object);

            var result = await PromoCodeController.GetPromoCodes();

            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.HttpResponseCode);
        }
    }
}
