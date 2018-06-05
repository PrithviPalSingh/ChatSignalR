using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalRNew.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        void SendMessage(string message)
        {
            var clients = GlobalHost
           .ConnectionManager
           .GetHubContext<ChatHub>().Clients; //..SendMessage(message);

            var clientIds = clients.All;
            clients.Clients(clientIds).SendMessage(message);
        }

        public ActionResult Chat()
        {
            return View();
        }
    }
}