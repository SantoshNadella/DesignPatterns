using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CLAdapterSDP;
using CLBridgeSDP;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StructuralDesignPatternCoreWebApp.Controllers
{
    public class SDPController : Controller
    {
        public ActionResult AboutSDP()
        {
            return View();
        }
        public ActionResult AdapterSDP()
        {
            Employee objEmp = new Employee();
            List<string> objLeads = new List<string>();
            objLeads.Add(objEmp.LeadOn(new UMS_Module()));
            objLeads.Add(objEmp.LeadOn(new DMS_Module()));
            objLeads.Add(objEmp.LeadOn(new TMS_Module()));
            objLeads.Add(objEmp.LeadOn(new QMS_Module()));
            objLeads.Add(objEmp.LeadOn(new REG_Module()));

            return View();
        }
        public ActionResult BridgeSDP()
        {
            List<string> objReach = new List<string>();
            Bridge objBridge = new Bridge();
            EastGodavari objEGD = new EastGodavari();
            WestGodavari objWGD = new WestGodavari();
            objReach.Add(objBridge.ReachTo(objEGD));
            objReach.Add(objBridge.ReachTo(objWGD));

            return View();
        }
        public ActionResult CompositeSDP()
        {
            return View();
        }
        public ActionResult DecoratorSDP()
        {
            return View();
        }
        public ActionResult FacadeSDP()
        {
            return View();
        }
        public ActionResult FlyweightSDP()
        {
            return View();
        }
        public ActionResult ProxySDP()
        {
            return View();
        }
        // GET: SDP
        public ActionResult Index()
        {
            return View();
        }
        // GET: SDP/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SDP/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SDP/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SDP/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SDP/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SDP/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SDP/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}