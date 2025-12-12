using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_Dapper_UI.Dtos.ProductDtos;

namespace RealEstate_Dapper_UI.ViewComponents.HomePage
{
    public class _DefaultHomePageProductList : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultHomePageProductList(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();

            // ❗ BURASI CATEGORIES DEĞİL, ÜRÜN ENDPOINTİ OLACAK
            var responseMessage = await client.GetAsync("https://localhost:44308/api/Products/GetProductByDealOfTheDayWithCategoryAsync");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();

                // ❗ BURASI KESİNLİKLE ProductDto olacak
                var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);

                // View'e giden tip: List<ResultProductDto>
                return View(values);
            }

            // Hata durumunda boş liste gönder, null gönderme
            return View(new List<ResultProductDto>());
        }
    }
}
