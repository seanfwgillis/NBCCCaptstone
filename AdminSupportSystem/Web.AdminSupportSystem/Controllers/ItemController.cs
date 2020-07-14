using Model;
using Model.Entities;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;
using Web.AdminSupportSystem.Models;

namespace Web.AdminSupportSystem.Controllers
{
    public class ItemController : Controller
    {
        private ItemService service = new ItemService();
        private ItemVM vm = new ItemVM();

        PurchaseService Pservice = new PurchaseService();
        private Purchase p = new Purchase();
       
        // GET: Item
        public ActionResult Index()
        {
            try
            {
                // return View(service.GetItemsByID(POId).OrderBy(item => item.Id).ToList());
                return View();
            } catch(Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Item", "Index"));
            }
        }
        public ActionResult Create()
        {
            try
            {
                Item i = new Item();

                service.GetItems(i);

                ItemVM vm = new ItemVM();

                return View(vm);
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Item", "Create"));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ItemVM vm)
        {
            try
            {
                var itemModel = ConvertVMToModel(vm);

                service.CreateItem(itemModel);

               return View(itemModel);

            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Item", "Create"));
            }
        }

        public Item ConvertVMToModel(ItemVM vm)
        {
            return new Item()
            {
                Name = vm.Name,
                Description = vm.Description,
                Quantity = vm.Quantity,
                UnitPrice = vm.UnitPrice,
                Justification = vm.Justification,
                Location = vm.Location

            };

        }
        public ActionResult Edit(int? id)
        {
            try
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(400);
                }

                Item i = new Item();
                i = service.GetItem((int)id);

                if (i == null)
                {
                    return new HttpStatusCodeResult(404);
                }

                ItemVM vm = new ItemVM()
                {
                    Item = i
                   
                };

                return View(vm);          
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Item", "Edit"));
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ItemVM vm)
        {
            try
            {
                if (service.UpdateItems(vm.Item))
                {
                    return View(vm);
                }
                return View(vm);
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Items", "Edit"));
            }
        }

        public void SubmitPO()
        {
            if (Session["EmployeeId"] != null)
            {
                Employee emp = new Employee();

                var employeeId = emp.Id;

                Pservice.CreatePurchaseOrder(p, employeeId);
            }

        }
    }
    }