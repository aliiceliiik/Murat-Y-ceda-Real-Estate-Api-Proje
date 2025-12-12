using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace RealEstate_Dapper_UI.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            #region İstatistik 1
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44308/api/Statistics/ActiveCategoryCount");
            var jsondata = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.activeCategoryCount = jsondata;

            #endregion

            #region İstatistik 2
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client.GetAsync("https://localhost:44308/api/Statistics/ActiveEmployeeCount");
            var jsondata2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.activeEmployeeCount = jsondata2;

            #endregion

            #region İstatistik 3
            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync("https://localhost:44308/api/Statistics/ApartmentCount");
            var jsondata3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.activeApartmentCount = jsondata3;
            
            #endregion

            #region İstatistik 4
            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4 = await client4.GetAsync("https://localhost:44308/api/Statistics/AverageProductPriceByRent");
            var jsondata4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.averageProductPriceByRent = jsondata4;
            #endregion

            #region İstatistik 5
            var client5 = _httpClientFactory.CreateClient();
            var responseMessage5 = await client5.GetAsync("https://localhost:44308/api/Statistics/AverageProductPriceBySale");
            var jsondata5 = await responseMessage5.Content.ReadAsStringAsync();
            ViewBag.AverageProductPriceBySale = jsondata5;

            #endregion

            #region İstatistik 6
            var client6 = _httpClientFactory.CreateClient();
            var responseMessage6 = await client6.GetAsync("https://localhost:44308/api/Statistics/AverageRoomCount");
            var jsondata6 = await responseMessage6.Content.ReadAsStringAsync();
            ViewBag.averageRoomCount = jsondata6;

            #endregion

            #region İstatistik 7
            var client7 = _httpClientFactory.CreateClient();
            var responseMessage7 = await client7.GetAsync("https://localhost:44308/api/Statistics/CategoryCount");
            var jsondata7 = await responseMessage7.Content.ReadAsStringAsync();
            ViewBag.categoryCount = jsondata7;

            #endregion

            #region İstatistik 8
            var client8 = _httpClientFactory.CreateClient();
            var responseMessage8 = await client8.GetAsync("https://localhost:44308/api/Statistics/CategoryNameByMaxProductCount");
            var jsondata8 = await responseMessage8.Content.ReadAsStringAsync();
            ViewBag.categoryNameByMaxProductCount = jsondata8;
            #endregion

            #region İstatistik 9
            var client9 = _httpClientFactory.CreateClient();
            var responseMessage9 = await client9.GetAsync("https://localhost:44308/api/Statistics/CityNameByMaxProductCount");
            var jsondata9 = await responseMessage9.Content.ReadAsStringAsync();
            ViewBag.cityNameByMaxProductCount = jsondata9;

            #endregion

            #region İstatistik 10
            var client10 = _httpClientFactory.CreateClient();
            var responseMessage10 = await client10.GetAsync("https://localhost:44308/api/Statistics/DifferentCityCount");
            var jsondata10 = await responseMessage10.Content.ReadAsStringAsync();
            ViewBag.differentCityCount = jsondata10;

            #endregion

            #region İstatistik 11
            var client11 = _httpClientFactory.CreateClient();
            var responseMessage11 = await client11.GetAsync("https://localhost:44308/api/Statistics/EmployeeNameByMaxProductCount");
            var jsondata11 = await responseMessage11.Content.ReadAsStringAsync();
            ViewBag.employeeNameByMaxProductCount = jsondata11;

            #endregion

            #region İstatistik 12
            var client12 = _httpClientFactory.CreateClient();
            var responseMessage12 = await client12.GetAsync("https://localhost:44308/api/Statistics/LastProductPrice");
            var jsondata12 = await responseMessage12.Content.ReadAsStringAsync();
            ViewBag.lastProductPrice = jsondata12;
            #endregion

            #region İstatistik 13
            var client13 = _httpClientFactory.CreateClient();
            var responseMessage13 = await client13.GetAsync("https://localhost:44308/api/Statistics/NewestBuildingYear");
            var jsondata13 = await responseMessage13.Content.ReadAsStringAsync();
            ViewBag.newestBuildingYear = jsondata13;

            #endregion

            #region İstatistik 14
            var client14 = _httpClientFactory.CreateClient();
            var responseMessage14 = await client14.GetAsync("https://localhost:44308/api/Statistics/OldestBuildingYear");
            var jsondata14 = await responseMessage14.Content.ReadAsStringAsync();
            ViewBag.oldestBuildingYear = jsondata14;

            #endregion

            #region İstatistik 15
            var client15 = _httpClientFactory.CreateClient();
            var responseMessage15 = await client15.GetAsync("https://localhost:44308/api/Statistics/PassiveCategoryCount");
            var jsondata15 = await responseMessage15.Content.ReadAsStringAsync();
            ViewBag.passiveCategoryCount = jsondata15;

            #endregion

            #region İstatistik 16
            var client16 = _httpClientFactory.CreateClient();
            var responseMessage16 = await client16.GetAsync("https://localhost:44308/api/Statistics/ProductCount");
            var jsondata16 = await responseMessage16.Content.ReadAsStringAsync();
            ViewBag.productCount = jsondata16;
            #endregion

            return View();

        }
    }
}
