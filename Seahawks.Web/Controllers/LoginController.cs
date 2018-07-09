using RestSharp;
using Seahawks.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Seahawks.Service;
using Seahawks.Domain.Entities;

namespace Seahawks.Web.Controllers
{
    public class LoginController : Controller
    {
        //UserService uservice = new UserService();
        // GET: Login
        public ActionResult Index()
        {
            ViewBag.Message = TempData["token"].ToString();
            ViewBag.token = "aymen ya khraa";
            return View();
        }

        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            Session["email"] = "";
            Session["login"] = "";
            Session["password"] = "";
            Session["role"] = "";
            Session["firstname"] = "";
            Session["lastname"] = "";
            Session["orgname"] = "";
            Session["token"] = "";
            Session["addressid"] = "";
            Session["isvet"] = "";
            Session["phone"] = "";
            Session["status"] = "";
            Session["id"] = "";
            Session["DTYPE"] = "";

            return View();
        }

        // POST: Login/Create
        [HttpPost]
        public ActionResult Create(LoginModel lm)
        {
            UserService uservice = new UserService();
            try
            {
                var client = new RestClient("http://127.0.0.1:18080/seahawks-web/rest/");

                var request = new RestRequest("/users/authentificate", Method.POST);

                request.AddHeader("Content-type", "application/x-www-form-urlencoded");


                request.AddParameter("username", lm.email);
                request.AddParameter("password", lm.password);
                IRestResponse response = client.Execute(request);

                var code = response.StatusCode; 
                var token = response.Content;
                
                if (true)
                {
                    
                    IEnumerable<user> users = uservice.GetAll();
                    var user = new user();
                    foreach (var item in users)
                    {
                        if (item.email.Equals(lm.email))
                        {
                            user = item;
                            Session["email"] = user.email;
                            Session["login"] = user.login;
                            Session["password"] = user.password;
                            Session["role"] = user.role;
                            Session["firstname"] = user.firstName;
                            Session["lastname"] = user.lastName;
                            Session["orgname"] = user.orgName;
                            Session["token"] = token;
                            Session["addressid"] = user.address_id;
                            Session["isvet"] = user.vet;
                            Session["phone"] = user.phoneNumber;
                            Session["status"] = user.status;
                            Session["id"] = user.id;
                            Session["DTYPE"] = user.DTYPE;
                        }
                    }
                    TempData["token"] = token;
                    return RedirectToAction("Index");
                }
                else
                    return View();
            }
            catch
            {
                
                return View();
            }
        }

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5

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

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
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
