using Model;
using Model.Entities;
using Model.Enums;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service
{
    public class PurchaseService : BaseService
    {
        private Purchase _p = new Purchase();
        private Employee _e = new Employee();

        public Purchase GetTotals(int id)
        {
            PurchaseOrderRepo repo = new PurchaseOrderRepo();
            _p = repo.GetForTotals(id);
            return _p;
        }

        public List<Purchase> GetPurchaseOrderByID(int Id)
        {
            PurchaseOrderRepo POR = new PurchaseOrderRepo();
            return POR.GetPOById(Id);
        }
        public List<Purchase> GetPurchaseOrderByDate(DateTime start, DateTime end)
        {
            PurchaseOrderRepo POR = new PurchaseOrderRepo();
            return POR.GetPOByDate(start, end);
        }

        public bool CreatePurchaseOrder(Purchase p, int employeeId)
        {
            _p = p;

            PurchaseOrderRepo repo = new PurchaseOrderRepo();

            EmployeeService es = new EmployeeService();

            _e = es.GetEmployee(employeeId);

            //set PO status to pending
            p.ApprovalStatus = ApprovalStatus.Pending;

            //set to current employee
            p.EmployeeId = employeeId;

            //set supervisor
            p.Supervisor = _e.Supervisor;

            Validate();
            if (Errors.Count == 0)
            {
                return repo.AddPO(_p);
            }

            return false;

        }
        public ApprovalStatus GetPurchaseStatus(int Id)
        {
            PurchaseOrderRepo repo = new PurchaseOrderRepo();

            return repo.GetPurchaseStatus(Id);
        }

        public void Validate()
        {
            IsValidEntity();
        }
        private bool IsValidEntity()
        {
            ValidationContext context = new ValidationContext(_p);
            List<ValidationResult> results = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(_p, context, results, true);

            foreach (ValidationResult r in results)
            {
                Errors.Add(new Error(r.ErrorMessage));
            }

            return isValid;
        }

        public List<Purchase> UpdateTotal(int id, Purchase p)
        {
            PurchaseOrderRepo repo = new PurchaseOrderRepo();

            return repo.UpdatePurchaseTotals(id, p);
        }

        public Purchase CheckSupervisor(int id)
        {      
            PurchaseOrderRepo repo = new PurchaseOrderRepo();

            _p = repo.CheckSupervisorID(id);  
            
            return _p;
        }

        public List<Purchase> UpdatePOSupervisor(int POId, string modificationReason)
        {
            PurchaseOrderRepo repo = new PurchaseOrderRepo();

            return repo.UpdatePOSuper(POId, modificationReason);
        }

        public int GetPurchaseOrderByItemId(int Id)
        {
             PurchaseOrderRepo repo = new PurchaseOrderRepo();

            return repo.GetPurchaseIDFromItem(Id);
            }

        }
    }
