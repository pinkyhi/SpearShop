using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SpearShopDesktop.Model;

namespace SpearShopDesktop
{
    public partial class CustomerItemForm : Form
    {
        Customer customerNow;
        MainForm parentForm;
        public CustomerItemForm()
        {
            InitializeComponent();
        }
        public CustomerItemForm(MainForm parentF, Customer customer)
        {
            parentForm = parentF;
            customerNow = customer;
            InitializeComponent();
        }

        private void CustomerItemForm_Load(object sender, EventArgs e)
        {

            CustomerItemIdLabel.Text += Convert.ToString(customerNow.Customer_Id);
            CustomerItemMailTextBox.Text = customerNow.Mail;
            CustomerItemNameTextBox.Text = customerNow.Name;
            CustomerItemPhoneTextBox.Text = customerNow.Phone;
            CustomerItemZoneTextBox.Text = "UTC" + customerNow.Zone/-60;
            foreach(Order og in customerNow.Orders)
            {
                CustomerItemOrdersList.Items.Add(og);
            }

        }

        private void CustomerItemForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (MyDbContext db = new MyDbContext())
            {
                parentForm.OrderGoods = db.OrderGoods.ToList();
                parentForm.Delivery_Types = db.Delivery_Types.ToList();
                parentForm.Orders = db.Orders.ToList();
                parentForm.Customers = db.Customers.ToList();
                parentForm.Videos = db.Videos.ToList();
                parentForm.Imgs = db.Imgs.ToList();
                parentForm.CategoryGoods = db.CategoryGoods.ToList();
                parentForm.Categories = db.Categories.ToList();
                parentForm.Manufacturers = db.Manufacturers.ToList();
                parentForm.Goods = db.Goods.ToList();
                parentForm.RePaintDelivery_TypesLayoutPanel(parentForm.Delivery_Types);
                parentForm.RePaintOrdersLayoutPanel(parentForm.Orders);
                parentForm.RePaintGoodsLayoutPanel(parentForm.Goods);
                parentForm.RePaintCustomersLayoutPanel(parentForm.Customers);
                parentForm.RePaintCategoriesLayoutPanel(parentForm.Categories);
                parentForm.RePaintManufacturersLayoutPanel(parentForm.Manufacturers);
            }
        }

        private void CustomerItemOrderOpenButton_Click(object sender, EventArgs e)
        {
            if (CustomerItemOrdersList.SelectedItem != null)
            {
                OrderItemForm ogf = new OrderItemForm(parentForm,(Order)CustomerItemOrdersList.SelectedItem);
                ogf.Show();
            }
        }

        private void CustomerItemSubmitButton_Click(object sender, EventArgs e)
        {
            using (MyDbContext db = new MyDbContext())
            {
                try
                {
                    (db.Customers.FirstOrDefault(s => s.Customer_Id == customerNow.Customer_Id).Name) = CustomerItemNameTextBox.Text;
                    (db.Customers.FirstOrDefault(s => s.Customer_Id == customerNow.Customer_Id).Mail) = CustomerItemMailTextBox.Text;
                    (db.Customers.FirstOrDefault(s => s.Customer_Id == customerNow.Customer_Id).Phone) = CustomerItemPhoneTextBox.Text;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("\n" + ex.Message);
                }

                db.SaveChanges();
            }
            this.Close();
        }
    }
}
