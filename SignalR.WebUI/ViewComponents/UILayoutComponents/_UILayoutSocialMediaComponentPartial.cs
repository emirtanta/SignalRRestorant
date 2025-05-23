﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalR.WebUI.Dtos.SocialMediaDtos;

namespace SignalR.WebUI.ViewComponents.UILayoutComponents
{
    public class _UILayoutSocialMediaComponentPartial:ViewComponent
    {

		private readonly IHttpClientFactory _httpClientFactory;

		public _UILayoutSocialMediaComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> Invoke()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("http://localhost:5271/api/SocialMedia");

			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultSocialMediaDto>>(jsonData);

				return View(values);
			}

			return View();
		}
    }
}
