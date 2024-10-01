using Microsoft.AspNetCore.Mvc; // Необходима для создания ViewComponent
using System.Threading.Tasks;
using WEB_253504_DUBOVIK.UI.Models;


namespace WEB_253504_DUBOVIK.UI.Components;
public class CartViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var cartItems = new List<String> {"Item1", "Item2", "Item3"};
        return View(cartItems);
    }
}
