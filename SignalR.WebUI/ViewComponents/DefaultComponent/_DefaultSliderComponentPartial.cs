﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalR.WebUI.Dtos.SliderDtos;

namespace SignalR.WebUI.ViewComponents.DefaultComponent
{
    public class _DefaultSliderComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultSliderComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5271/api/Slider");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData=await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultSliderDto>>(jsonData);

                return View(values);
            }

            return View();
        }
    }
}
