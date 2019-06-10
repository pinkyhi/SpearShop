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
    public partial class ManufacturerItemForm : Form
    {
        Manufacturer manufacturerNow;
        MainForm parentForm;
        public ManufacturerItemForm()
        {
            InitializeComponent();
        }
        public ManufacturerItemForm(MainForm parentF, Manufacturer manufacturer)
        {
            parentForm = parentF;
            manufacturerNow = manufacturer;
            InitializeComponent();
        }

        private void ManufacturerItemDeleteButton_Click(object sender, EventArgs e)
        {
            using (MyDbContext db = new MyDbContext())
            {
                Manufacturer td = db.Manufacturers.FirstOrDefault(s => s.Manufacturer_Id == manufacturerNow.Manufacturer_Id);
                db.Manufacturers.Remove(td);
                db.SaveChanges();
            }
            this.Close();
        }

        private void ManufacturerItemSubmitButton_Click(object sender, EventArgs e)
        {
            using (MyDbContext db = new MyDbContext())
            {
                try
                {
                    (db.Manufacturers.FirstOrDefault(s => s.Manufacturer_Id == manufacturerNow.Manufacturer_Id).Name) = ManufacturerItemNameTextBox.Text;
                    (db.Manufacturers.FirstOrDefault(s => s.Manufacturer_Id == manufacturerNow.Manufacturer_Id).Description) = ManufacturerItemDescriptionTextBox.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("\n" + ex.Message);
                }

                db.SaveChanges();
            }
            this.Close();
        }

        private void ManufacturerItemForm_Load(object sender, EventArgs e)
        {
            ManufacturerItemNameTextBox.Text = manufacturerNow.Name;
            ManufacturerItemDescriptionTextBox.Text = manufacturerNow.Description;
            ManufacturerItemIdLabel.Text += Convert.ToInt32(manufacturerNow.Manufacturer_Id);

        }

        private void ManufacturerItemForm_FormClosed(object sender, FormClosedEventArgs e)
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
    }
}
