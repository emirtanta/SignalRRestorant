﻿using Microsoft.AspNetCore.Mvc;

namespace SignalR.WebUI.ViewComponents.AdminLayoutComponents
{
    public class _LayoutHeaderPartialComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
