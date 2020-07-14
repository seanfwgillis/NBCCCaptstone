using Model;
using Model.Entities;
using Model.Entities.Unique;
using Model.Enums;
using Service;
using Service.Unique;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AdminSupportSystem
{
    public partial class POModify : Form
    {
        private Employee _e = new Employee();
        private Item item = new Item();

        List<POEmployee> purchaseDetailsList;

        private Purchase _p;

        ItemService iService = new ItemService();

        POEmployeeService poService = new POEmployeeService();

        List<Item> items;

        public int flag = 0;

        //stop launching update on update click in create form
        public int stop = 0;

        public POModify(int employeeId)
        {
            stop = 0;
            flag = 0;

            InitializeComponent();

            //get current employee
            EmployeeService es = new EmployeeService();

            _e = es.GetEmployee(employeeId);

            //check if user is employee or supervisor

            //is supervisor   
            if (_e.IsSupervisor == true)
            {
                flag = 1;
            } 
        }
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            dgvPODetails.ReadOnly = true;

            if (radId.Checked == true)
            {

                //purchaseOrder = pService.GetPurchaseOrderByID(Convert.ToInt32(txtPOID.Text));
                purchaseDetailsList = poService.GetPurchaseOrderDetailsByID(Convert.ToInt32(txtPOID.Text));

                fillProducts();

                if (dgvPODetails.Rows.Count < 1 || dgvPODetails.Rows == null)
                {
                    MessageBox.Show("There are no purchase orders matching that search criteria.");
                }
                else
                {
                    items = iService.GetItemsByID(Convert.ToInt32(txtPOID.Text));


                    fillItems();
                }
            }

            else if (radDate.Checked == true)
            {
                // purchaseOrder = pService.GetPurchaseOrderByDate(dtpStart.Value, dtpEnd.Value);
                purchaseDetailsList = poService.GetPurchaseOrderDetailsByDate(dtpStart.Value, dtpEnd.Value);

                fillProducts();

                if (dgvPODetails.Rows.Count < 1 || dgvPODetails.Rows == null)
                {
                    MessageBox.Show("There are no purchase orders matching that search criteria.");
                    dgvItemDetails.DataSource = null;
                }
            }

            else
            {
                MessageBox.Show("Please select to filer either by date or Id.");
            }
        }

        private void fillProducts()
        {
            dgvPODetails.DataSource = new BindingSource
            {
                DataSource = purchaseDetailsList.Select(p =>
                new
                {
                    p.CreationDate,
                    p.FirstName,
                    p.LastName,
                    p.Department,
                    p.Supervisor,
                    p.PONumber,
                    p.ApprovalStatus,
                    p.Subtotal,
                    p.Tax,
                    p.GrandTotal
                })
            };
            //currency
            try
            {
                dgvPODetails.Columns[7].DefaultCellStyle.Format = "c";
                dgvPODetails.Columns[8].DefaultCellStyle.Format = "c";
                dgvPODetails.Columns[9].DefaultCellStyle.Format = "c";
            }

            catch (Exception e)
            {
                dgvPODetails.DataSource = null;
            }
        }
        private void fillItems() {
            dgvItemDetails.DataSource = new BindingSource
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
            dgvItemDetails.Columns[4].DefaultCellStyle.Format = "c";
            dgvItemDetails.Columns[8].DefaultCellStyle.Format = "c";
        }

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPOID.Text = "";
            radDate.Checked = false;
            radId.Checked = false;
            dgvPODetails.DataSource = null;
            dgvItemDetails.DataSource = null;
            dtpEnd.Value = DateTime.Now;
            dtpStart.Value = DateTime.Now;
        }

        
    private Item PopulateItemObject()
    {
            return new Item()
            {
                Name = txtName.Text,
                Description = txtDescription.Text,
                Quantity = Convert.ToInt32(txtQuantity.Text),
                UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                Justification = txtJustification.Text,
                Location = txtLocation.Text

            };
        }
        private void Clear()
        {
            txtDescription.Text = "";
            txtUnitPrice.Text = "";
            txtJustification.Text = "";
            txtLocation.Text = "";
            txtModReason.Text = "";
            txtPOID.Text = "";
            txtQuantity.Text = "";
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            stop = 1;

            if (stop == 1)
            {

                    //employee

                    //if item not yet approved or denied by the supervisor 
                    //all fields in item can be changed 
                    //as long as po request is not closed, employee may add new items to it   

                    //supervisors can modify po items - quantity, price and location fields but 
                    //must enter a reason

                    if (txtId.Text == "" || txtId.Text == null)
                    {
                        MessageBox.Show("You must enter an item id.");
                    }

                    else
                    {
                        ItemService i = new ItemService();
                        PurchaseService p = new PurchaseService();

                        int id = Convert.ToInt32(txtId.Text);

                        ItemStatusType itemStatus;
                        itemStatus = i.GetItemStatus(id);                        

                        ApprovalStatus approvalStatus;

                        int POId = p.GetPurchaseOrderByItemId(id);
                        approvalStatus = p.GetPurchaseStatus(POId);
                      


                        if (itemStatus == ItemStatusType.Denied)
                        {
                            MessageBox.Show("This item cannot be updated, the item is denied.");
                        }
                        else if (approvalStatus == ApprovalStatus.Closed)
                        {
                            MessageBox.Show("This purchase order cannot be updated, the order is closed.");
                        }
                        else
                        {

                            if (flag == 0)
                            {
                                PopulateItemObject();

                                if (i.UpdateItems(item))
                                {
                                    MessageBox.Show("Item Successfully Updated.");
                                    Clear();
                                }
                            }

                            else
                            {
                                PopulateItemObject();
                                if (txtModReason.Text == "" || txtModReason.Text == String.Empty)
                                {
                                    MessageBox.Show("You must enter a modification reason.");
                                }
                                else
                                {
                                    //check if purchase order belongs to the supervisor modifying 
                                    int POID = Convert.ToInt32(txtId.Text);
                                    PurchaseService ps = new PurchaseService();

                                    _p = ps.CheckSupervisor(POID);

                                    if (_p.Supervisor == _e.Id)
                                    {
                                        PopulateItemObject();

                                        if (i.UpdateItems(item))
                                        {
                                            MessageBox.Show("Item Successfully Updated.");
                                            Clear();
                                        }
                                    }

                                    try
                                    {
                                        if (i.UpdateItemsSupervisor(item))
                                        {
                                            String ModificationReason = txtModReason.Text;
                                            //update po mod reason and date
                                            ps.UpdatePOSupervisor(POID, ModificationReason);

                                            MessageBox.Show("Item Successfully Updated.");
                                            Clear();
                                        }
                                    }catch(Exception ex)
                                    {
                                        MessageBox.Show("You are only permitted to modify the quantity, price, and location fields.");
                                    }
                                }

                            }
                        }
                    }
                }
            }
        }

    }
