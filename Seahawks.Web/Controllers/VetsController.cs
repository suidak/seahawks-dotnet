using RestSharp;
using RestSharp.Deserializers;
using Seahawks.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seahawks.Web.Controllers
{
    public class VetsController : Controller
    {
        // GET: Vets
        public ActionResult Index()
        {
            var client = new RestClient("http://127.0.0.1:18080/seahawks-web/rest/");

            var request = new RestRequest("/users", Method.POST);
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(
                        new
                        {
                            id = 9
                        }); // AddJsonBody serializes the object automatically

            //client.AddHandler("my_custom_type", new JsonDeserializer());
            // execute the request
            IRestResponse response = client.Execute<List<user>>(request);
            var content = response.Content; // raw content as string
            
            ViewBag.Content = content;

            return View();
        }

        // GET: Vets/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Vets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vets/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Vets/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Vets/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Vets/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Vets/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
