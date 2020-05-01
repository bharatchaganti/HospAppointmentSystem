using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Hosp.Models;

namespace Hosp.Controllers
{
    public class AppointmentsController : Controller
    {
        HospitalAppContext db = new HospitalAppContext();
        public ActionResult Appointments()
        {
            ViewBag.count = db.Appointments.Count();
            return View(db.Appointments.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create([Bind(Include = "PatientId,PatientName,DoctorName,AppointmentDate,HealthProblem")] Appointment appointment)

        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Appointments.Add(appointment);
                    db.SaveChanges();
                    return RedirectToAction("Appointments");
                }
            }
            catch (Exception)
            {
                return View("Error");
            }
            return View(appointment);
        }
    }

}
