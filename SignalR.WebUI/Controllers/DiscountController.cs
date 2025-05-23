﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Newtonsoft.Json;
using SignalR.WebUI.Dtos.CategoryDtos;
using SignalR.WebUI.Dtos.DiscountDtos;
using System.Text;

namespace SignalR.WebUI.Controllers
{
    public class DiscountController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

		public DiscountController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5271/api/Discount");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData=await responseMessage.Content.ReadAsStringAsync();
                var values=JsonConvert.DeserializeObject<List<ResultDiscountDto>>(jsonData);

                return View(values);
            }

            return View();
        }

        [HttpGet]
        public IActionResult CreateDiscount()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateDiscount(CreateDiscountDto createDiscountDto)
        {

            var client=_httpClientFactory.CreateClient();
            var jsonData=JsonConvert.SerializeObject(createDiscountDto);

            StringContent stringContent = new StringContent(jsonData,Encoding.UTF8,"application/json");

            var responseMessage = await client.PostAsync("http://localhost:5271/api/Discount", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateDiscount(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5271/api/Discount/{id}");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateDiscountDto>(jsonData);

                return View(values);
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateDiscount(UpdateDiscountDto updateDiscountDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData=JsonConvert.SerializeObject(updateDiscountDto);

            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var responseMessage = await client.PutAsync("http://localhost:5271/api/Discount/", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }

            return View();

        }

        public async Task<IActionResult> DeleteDiscount(int id)
        {
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:5271/api/Discount/{id}");

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public async Task<IActionResult> ChangeStatusToTrue(int id)
        {
			var client = _httpClientFactory.CreateClient();
			await client.GetAsync($"http://localhost:5271/api/Discount/ChangeStatusToTrue/{id}");

			return RedirectToAction(nameof(Index));
		}

		public async Task<IActionResult> ChangeStatusToFalse(int id)
		{
			var client = _httpClientFactory.CreateClient();
			await client.GetAsync($"http://localhost:5271/api/Discount/ChangeStatusToFalse/{id}");

			return RedirectToAction(nameof(Index));
		}

	}
}
