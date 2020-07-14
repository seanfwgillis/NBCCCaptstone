using DAL;
using Model;
using Model.Entities;
using Repository;
using Service;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSupportSystem
{
    public partial class POCreate : Form
    {
        private Purchase p = new Purchase();
        private Purchase _p;
        private Employee _e = new Employee();

       // List<Purchase> purchaseOrder;

        public Employee e = new Employee();

        ItemService iService = new ItemService();

        List<Item> items;

        //stop on load launch on create submit po
        public int flag = 0;

        public POCreate(int employeeId)
        {
            flag = 0;

            InitializeComponent();
            //format date to just show date
            lblDate.Text = DateTime.Now.ToShortDateString();

            try
            {

                EmployeeService es = new EmployeeService();

                _e = es.GetEmployee(employeeId);

                lblFirstName.Text = Convert.ToString("Employee: " + _e.FirstName);
                lblLastName.Text = Convert.ToString(_e.LastName);
                lblDepartment.Text = Convert.ToString("Department: " + _e.Department);
                lblSupervisor.Text = Convert.ToString("Supervisor: " + _e.Supervisor);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Header Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                txtName.SelectAll();
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ItemService service = new ItemService();
                Item i = PopulateItemObject();

                if (service.CreateItem(i))
                {
                    MessageBox.Show("Item Added Successfully", "Status",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearForm();
                    txtName.Focus();

                    fillItems();

                }
                else
                {
                    string msg = "";
                    foreach (Error error in service.Errors)
                    {
                        msg += error.Description + Environment.NewLine;
                    }
                    MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Focus();
                    txtName.SelectAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                txtName.SelectAll();

            }
        }


        private void ClearForm()
        {
            txtName.Text = String.Empty;
            txtLocation.Text = String.Empty;
            txtQuantity.Text = String.Empty;
            txtPrice.Text = String.Empty;
            txtDescription.Text = String.Empty;
            txtJustification.Text = String.Empty;

            dgvPODetails.DataSource = null;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            PurchaseService Pservice = new PurchaseService();

            int employeeId = _e.Id;

            if (Pservice.CreatePurchaseOrder(p, employeeId))
            {

                //call to update po id
                int Id = getPOID();

                //use that to update po id
                ItemService i = new ItemService();
                i.UpdatePOID(Id);

                //finish math
                Purchase p = new Purchase();
                Pservice.UpdateTotal(Id, p);

                PurchaseService ps = new PurchaseService();
  
                //update labels
                _p = ps.GetTotals(Id);

                txtSubtotal.Text = String.Format("{0:C}",(_p.Subtotal));
                txtTax.Text = String.Format("{0:C}", (_p.Tax));
                txtTotal.Text = String.Format("{0:C}", (_p.GrandTotal));

                MessageBox.Show("Your Purchase Order ID is: " + Id.ToString());

                MessageBox.Show("PO Submitted Successfully", "Status",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
                txtName.Focus();

            }
            else
            {
                string msg = "";
                foreach (Error error in Pservice.Errors)
                {
                    msg += error.Description + Environment.NewLine;
                }
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                txtName.SelectAll();
            }
        }
        /* no longer needed 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvPODetails.ReadOnly = true;

                PurchaseService pService = new PurchaseService();

                purchaseOrder = pService.GetPurchaseOrderByID(Convert.ToInt32(txtPOID.Text));

                dgvPODetails.DataSource = new BindingSource
                {
                    DataSource = purchaseOrder.Select(p =>
                    new {
                        p.PONumber,
                        p.CreationDate,
                        p.Subtotal,
                        p.Tax,
                        p.GrandTotal,
                        p.ApprovalStatus
                    })
                };
                //currency
                dgvPODetails.Columns[2].DefaultCellStyle.Format = "c";
                dgvPODetails.Columns[3].DefaultCellStyle.Format = "c";
                dgvPODetails.Columns[4].DefaultCellStyle.Format = "c";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        */
        //populate item
        private Item PopulateItemObject()
        {
            return new Item()
            {
                Name = txtName.Text,
                Description = txtDescription.Text,
                Quantity = Convert.ToInt32(txtQuantity.Text),
                UnitPrice = Convert.ToDecimal(txtPrice.Text),
                Justification = txtJustification.Text,
                Location = txtLocation.Text

            };
        }

        //send user to main menu
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            var formToShow = Application.OpenForms.Cast<Form>()
           .FirstOrDefault(c => c is MainMenu);
            if (formToShow != null)
            {
                formToShow.Show();
                Close();
            }
        }

        //get the purchase order id to set the items po id
        public int getPOID()
        {
            string sql = "SELECT MAX(Id) AS Id FROM PurchaseOrder";
            DataAccess db = new DataAccess();

            return Convert.ToInt32(db.ExecuteScaler(sql, CommandType.Text));
        }


        //clear the item form
        private void btnClearForm_Click_1(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtDescription.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
            txtJustification.Text = "";
            txtLocation.Text = "";
        }
        private void fillItems()
        {

            Item item = new Item();

            ItemService iService = new ItemService();

            items = iService.GetItems(item);


            dgvPODetails.DataSource = new BindingSource
            {
                DataSource = items.Select(i =>
                new
                {
                    i.Id,
                    i.Quantity,
                    i.Name,
                    i.Description,
                    i.UnitPrice,
                    i.Justification,
                    i.Location,
                    i.ItemStatus,
                    i.ItemTotal
                })
            };
            //currency
            dgvPODetails.Columns[4].DefaultCellStyle.Format = "c";
            dgvPODetails.Columns[8].DefaultCellStyle.Format = "c";
        }

    }
 }
