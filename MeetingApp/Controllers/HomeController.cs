using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers{

    public class HomeController : Controller{

        public IActionResult Index(){
            int saat = DateTime.Now.Hour;
            ViewBag.Selamlama = saat > 12 ? "İyi Günler" : "Günaydın";
            ViewBag.Ad = "Ali Murat";

            var meetingInfo = new MeetingInfo(){
                Id = 1,
                Location = "Elazığ , X Kongre Merkezi",
                Date = new DateTime(2024,12,15,20,0,0),
                NumberOfPeople = Repository.Users.Count
            };
            return View(meetingInfo);
        }
    }
}