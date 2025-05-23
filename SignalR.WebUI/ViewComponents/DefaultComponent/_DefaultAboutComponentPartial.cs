﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalR.WebUI.Dtos.AboutDtos;

namespace SignalR.WebUI.ViewComponents.DefaultComponent
{
    public class _DefaultAboutComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultAboutComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5271/api/About");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsonData);

                return View(values);
            }

            return View();
        }
    }
}
