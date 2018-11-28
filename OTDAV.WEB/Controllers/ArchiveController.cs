using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using OTDAV.DOMAIN.Entities;
using OTDAV.SERVICE.SERVICE;
using OTDAV.WEB.Controllers;


namespace PIDEV.Web.Controllers
{
    public class ArchiveController : Controller
    {
        private ArchiveService AS = new ArchiveService();
      
        // GET: Archive
        public ActionResult Index()
        {
            var currentUser = (adherent)System.Web.HttpContext.Current.Session["IUser"];
            if (currentUser == null)
                return RedirectToAction("Login", "Login");
            ViewBag.result = AS.getAllArchives();
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }
        [HttpPost]
        public ActionResult Create(archive arch)
        {
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:8080");
            //arch.dateArchivage = DateTime.Now;
            Client.PostAsJsonAsync<archive>("/PIDEV-web/rest/archive", arch)
                .ContinueWith((postTask) => postTask.Result.EnsureSuccessStatusCode());
            return RedirectToAction("Index");
        }
       
        public ActionResult Delete( int  id)
        {
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:8080");
            Client.DeleteAsync("/PIDEV-web/rest/archive/"+id);
           return RedirectToAction("Index");
        }

        public ActionResult Update(archive arch)
        {
            return View(arch);
        }

       // [HttpPost]
       /* public ActionResult Update(archive arch)
        {
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:8080");
            Client.PutAsJsonAsync<archive>("/PIDEV-web/rest/archive",arch);
            return RedirectToAction("Index");   
        }*/
    }
}