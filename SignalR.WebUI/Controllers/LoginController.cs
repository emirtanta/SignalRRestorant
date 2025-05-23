﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Execution;
using SignalR.EntityLayer.Entities;
using SignalR.WebUI.Dtos.IdentityDtos;

namespace SignalR.WebUI.Controllers
{
	[AllowAnonymous]
	public class LoginController : Controller
	{
		private readonly SignInManager<AppUser> _signInManager;

		public LoginController(SignInManager<AppUser> signInManager)
		{
			_signInManager = signInManager;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Index(LoginDto loginDto)
		{
			var result = await _signInManager.PasswordSignInAsync(loginDto.Username, loginDto.Password, false, false);
			
			if (result.Succeeded) 
			{
				return RedirectToAction("Index", "Category");
			}

			return View();
		}

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
			await _signInManager.SignOutAsync();

            return RedirectToAction("Index","Login");
        }
    }
}
