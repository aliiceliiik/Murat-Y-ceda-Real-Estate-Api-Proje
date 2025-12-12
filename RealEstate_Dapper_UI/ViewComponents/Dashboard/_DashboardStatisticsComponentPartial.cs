using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace RealEstate_Dapper_UI.ViewComponents.Dashboard
{
    public class _DashboardStatisticsComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardStatisticsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            #region İstatistik1 - ToplamİlanSayısı
            var client1 = _httpClientFactory.CreateClient();
            var responseMessage1 = await client1.GetAsync("https://localhost:44308/api/Statistics/ProductCount");
            var jsondata1 = await responseMessage1.Content.ReadAsStringAsync();
            ViewBag.productCount = jsondata1;
            #endregion

            #region İstatistik2 - En Başarılı Personel
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("https://localhost:44308/api/Statistics/EmployeeNameByMaxProductCount");
            var jsondata2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.employeeNameByMaxProductCount = jsondata2;

            #endregion

            #region İstatistik 3 - İlandaki Şehir Sayıları
            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync("https://localhost:44308/api/Statistics/DifferentCityCount");
            var jsondata3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.differentCityCount = jsondata3;

            #endregion

            #region İstatistik 4 - Ortalama Kira
            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4 = await client4.GetAsync("https://localhost:44308/api/Statistics/AverageProductPriceByRent");
            var jsondata4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.averageProductPriceByRent = jsondata4;
            #endregion

            return View();
        }
    }
}
