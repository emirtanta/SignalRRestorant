﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalR.WebUI.Dtos.MenuTableDtos;
using System.Text;

namespace SignalR.WebUI.Controllers
{
	public class MenuTableController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public MenuTableController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("http://localhost:5271/api/MenuTable");

			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultMenuTableDto>>(jsonData);

				return View(values);
			}

			return View();
		}

		[HttpGet]
		public IActionResult CreateMenuTable()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> CreateMenuTable(CreateMenuTableDto createMenuTableDto)
		{
			createMenuTableDto.Status = false;
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(createMenuTableDto);

			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

			var responseMessage = await client.PostAsync("http://localhost:5271/api/MenuTable", stringContent);

			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction(nameof(Index));
			}

			return View();
		}

		[HttpGet]
		public async Task<IActionResult> UpdateMenuTable(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync($"http://localhost:5271/api/MenuTable/{id}");

			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<UpdateMenuTableDto>(jsonData);

				return View(values);
			}

			return View();
		}

		[HttpPost]
		public async Task<IActionResult> UpdateMenuTable(UpdateMenuTableDto updateAboutDto)
		{
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(updateAboutDto);

			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

			var responseMessage = await client.PutAsync("http://localhost:5271/api/MenuTable/", stringContent);

			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction(nameof(Index));
			}

			return View();

		}

		public async Task<IActionResult> DeleteMenuTable(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.DeleteAsync($"http://localhost:5271/api/MenuTable/{id}");

			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction(nameof(Index));
			}
			return View();
		}

		[HttpGet]
		public async Task<IActionResult> TableListByStatus()
		{
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5271/api/MenuTable");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultMenuTableDto>>(jsonData);

                return View(values);
            }

            return View();
        }
	}
}
