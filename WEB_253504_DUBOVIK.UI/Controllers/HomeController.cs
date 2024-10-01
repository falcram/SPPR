using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEB_253504_DUBOVIK.UI.Models;
using System.Collections.Generic;
namespace WEB_253504_DUBOVIK.UI.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var selectList = new List<ListDemo>
        {
            new ListDemo { Id = 1, Name = "Элемент 1" },
            new ListDemo { Id = 2, Name = "Элемент 2" },
            new ListDemo { Id = 3, Name = "Элемент 3" }
        };
        ViewBag.ListD = new SelectList(selectList, "Id", "Name");
        ViewData["SelectList"] = selectList; // передаем данные в представление
        ViewData["Title"] = "Лабораторная работа 2"; // передаем заголовок в представление

        return View();
    }
 

    [HttpPost]
    public IActionResult Index(int selectedItem)
    {
        // Обработка выбранного элемента
        // Вы можете сделать что-то с selectedItem (например, сохранить его в базу данных или выполнить другую логику)

        // Перенаправляем на тот же метод Index, чтобы отобразить страницу заново
        return RedirectToAction("Index");
    }


    public IActionResult Privacy()
    {
        // Логика обработки
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