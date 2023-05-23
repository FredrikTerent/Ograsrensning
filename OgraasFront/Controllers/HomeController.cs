using Microsoft.AspNetCore.Mvc;
using OgraasFront.Data;
using OgraasFront.Dto;
using OgraasFront.Models;
using System.Diagnostics;
using System.Text.Json;

namespace OgraasFront.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWeeds _weedsservice;

        public HomeController(ILogger<HomeController> logger, IWeeds weedsservice)
        {
            _logger = logger;
            _weedsservice = weedsservice;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Click(ClickDto click)
        {
            //var response = new ResponseDto
            //{
            //    Row = click.Row,
            //    Col = click.Col,
            //    Hit = true,
            //    Winner = false,
            //};

            var response = _weedsservice.Click(click);

            string serializedResponse = JsonSerializer.Serialize(response);

            return Ok(serializedResponse);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}