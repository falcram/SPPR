using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WEB_253504_DUBOVIK.UI.Models;

namespace WEB_253504_DUBOVIK.UI.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        // Логика обработки
        return View();
    }

    public IActionResult Privacy()
    {
        // Логика обработки
        return View();
    }

    [HttpPost]
    public IActionResult Index(string Login, string password)
    {
        // Обработка данных формы
        return View();
    }

    [HttpPost]
    public IActionResult Submit() // Параметр color соответствует имени поля в форме
    {
        // Обработка данных
        //ViewBag.SelectedColor = Radio; // Например, сохраняем выбранный цвет в ViewBag
        return View(); // Возвращаем представление
    }
}
//&copy; 2024 - WEB_253504_DUBOVIK.UI - <a asp-area="" asp-controller="Home" asp-action="Privacy">Privacy</a>