using Microsoft.AspNetCore.Mvc;
namespace RazonController.Controllers;
public class RazonController : Controller
{

    [HttpGet("")]
    public ViewResult Index()
    {
        return View();
    }
}