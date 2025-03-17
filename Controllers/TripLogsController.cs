using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TRIPLOGS.Models;

namespace TRIPLOGS.Controllers
{
    public class TripLogsController : Controller
    {
        private static List<TripLog> tripLogs = new List<TripLog>
        {
            new TripLog { TripLogID = 1, Driver = "LAGASCA", Helper = "", BrokerClient = "URC", Consignee = "URC", Destination = "SAN SIMON", ContainerNumber = "EGHU3796297", ContainerSize = "1X20", ShippingLine = "EVER", BLRefNo = "", Status = "CHECK", Dispatcher = "JAYR", CashAdvance = 2000.00M, AdditionalCashAdvance = 0.00M, DieselCash = 4000.00M, TotalAmount = 6000.00M, FCL = "MIP", DateAdded = DateTime.Now }
        };

        public IActionResult Index()
        {
            var trips = new List<TripLog>
    {
        new TripLog { TripLogID = 1, Driver = "John Doe", Helper = "Jane Smith", BrokerClient = "Client A", Consignee = "Consignee A", Destination = "Destination A", ContainerNumber = "12345", ContainerSize = "20ft", ShippingLine = "Line A", BLRefNo = "BL123", Status = "Pending", Dispatcher = "Dispatcher A", CashAdvance = 100, AdditionalCashAdvance = 50, DieselCash = 30, TotalAmount = 180, FCL = "Yes", DateAdded = DateTime.Now }
    };
            return View(trips);
        }





        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Create([FromBody] TripLog tripLog)
        {
            if (ModelState.IsValid)
            {
                tripLog.TripLogID = tripLogs.Count + 1;
                tripLogs.Add(tripLog);
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }

    }
}
