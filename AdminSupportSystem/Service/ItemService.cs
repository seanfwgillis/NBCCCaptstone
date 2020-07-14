using Model.Entities;
using Model.Enums;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ItemService : BaseService
    {
        private Item _i = new Item();

        public ItemStatusType GetItemStatus(int Id)
        {
            ItemRepo repo = new ItemRepo();

            return repo.GetItemStatus(Id);
        }

        public bool CreateItem(Item i)
        {
            _i = i;

            ItemRepo repo = new ItemRepo();

            //pending
            //i.ItemStatus = 1;
            i.ItemStatus = ItemStatusType.Pending;

            Validate();
            if (Errors.Count == 0)
            {
                return repo.AddItem(_i);
            }

            return false;
        }
        public void Validate()
        {
            IsValidEntity();
        }
        private bool IsValidEntity()
        {
            ValidationContext context = new ValidationContext(_i);
            List<ValidationResult> results = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(_i, context, results, true);

            foreach (ValidationResult r in results)
            {
                Errors.Add(new Error(r.ErrorMessage));
            }

            return isValid;
        }

        public List<Item> GetItemsByID(int Id)
        {
            ItemRepo repo = new ItemRepo();
            return repo.GetItemsById(Id);
        }

        public List<Item> GetItemsByDate(DateTime start, DateTime end)
        {
            ItemRepo repo = new ItemRepo();
            return repo.GetItemsByDate(start, end);
        }

        public List<Item> UpdatePOID(int id)
        {
            ItemRepo repo = new ItemRepo();

            return repo.UpdateItemPO(id);
        }

        public List<Item> GetItems(Item item)
        {
            ItemRepo repo = new ItemRepo();
            return repo.GetItems();
        }

        public bool UpdateItems(Item i)
        {
            _i = i;

            ItemRepo repo = new ItemRepo();

            return repo.UpdateItem(_i);
        }

        public Item GetItem(int id)
        {
            ItemRepo repo = new ItemRepo();
            _i = repo.GetItemById(id);
            return _i;
        }

        public bool UpdateItemsSupervisor(Item i)
        {
            _i = i;

            ItemRepo repo = new ItemRepo();

            return repo.UpdateItemSuper(_i);
        }

    }
}
