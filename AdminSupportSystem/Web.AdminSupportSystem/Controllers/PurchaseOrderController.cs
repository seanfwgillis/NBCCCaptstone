using Model;
using Model.Entities;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.AdminSupportSystem.Models;

namespace Web.AdminSupportSystem.Controllers
{
    public class PurchaseOrderController : Controller
    {

        // GET: Purchase Orders
        private PurchaseService ps = new PurchaseService();

        public ActionResult Index(string searchBy, string search)
        {
            try
            {
                DateTime fromDate = ViewBag.fromDate;
                DateTime toDate = ViewBag.toDate;

                List<Purchase> purchaseOrders = new List<Purchase>();
                if (searchBy == "Id" && search != "")
                {
                    purchaseOrders = ps.GetPurchaseOrderByID(Convert.ToInt32(search));
                    if (purchaseOrders.Count() == 0)
                    {
                        purchaseOrders.Add(new Purchase { SingleError = "None" });
                    }
                    return View(purchaseOrders);
                }
                if (searchBy == "Date" && search != "")
                {               
                        purchaseOrders = ps.GetPurchaseOrderByDate(fromDate, toDate);
                        if (purchaseOrders.Count() == 0)
                        {
                            purchaseOrders.Add(new Purchase { SingleError = "None" });
                        }
                 }
                
                if (search == "")
                {
                Purchase p = new Purchase();
                p.SingleError = "Blank";
                purchaseOrders.Add(p);
                return View(purchaseOrders);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Purchase", "PurchaseOrderDetails"));
            }
      }

    }
}