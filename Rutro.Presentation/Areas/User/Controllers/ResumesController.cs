﻿using Microsoft.AspNetCore.Mvc;

namespace Rutro.Presentation.Areas.User.Controllers;

[Area(nameof(User))]
public class ResumesController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}