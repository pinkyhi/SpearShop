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
    public partial class CategoryItemForm : Form
    {
        Category categoryNow;
        MainForm parentForm;
        public CategoryItemForm()
        {
            InitializeComponent();
        }
        public CategoryItemForm(MainForm parentF, Category category)
        {
            parentForm = parentF;
            categoryNow = category;
            InitializeComponent();
        }

        private void CategoryItemForm_Load(object sender, EventArgs e)
        {
            CategoryItemIdLabel.Text = ""+categoryNow.Category_Id;
            CategoryItemNameTextBox.Text = categoryNow.Name;
            CategoryItemDescriptionTextBox.Text = categoryNow.Description;
            CategoryItemParentIdLabel.Text += Convert.ToInt32(categoryNow.Parent_Id);
            CategoryItemLevelLabel.Text += Convert.ToInt32(categoryNow.Level);

            foreach(Category cat in parentForm.Categories)
            {
                CategoryItemCategoriesList.Items.Add(cat);
            }
            for(int i=0; i< CategoryItemCategoriesList.Items.Count; i++)
            {
                if(( (Category) CategoryItemCategoriesList.Items[i]).Category_Id == categoryNow.Category_Id)
                {
                    CategoryItemCategoriesList.Items.Remove(CategoryItemCategoriesList.Items[i]);
                    break;
                }
            }
        }

        private void CategoryItemDeleteButton_Click(object sender, EventArgs e)
        {
            using (MyDbContext db = new MyDbContext())
            {
                Category td = db.Categories.FirstOrDefault(s => s.Category_Id == categoryNow.Category_Id);
                db.Categories.Remove(td);
                db.SaveChanges();
            }
            this.Close();
        }

        private void CategoryItemSubmitButton_Click(object sender, EventArgs e)
        {
            using (MyDbContext db = new MyDbContext())
            {
                try
                {
                    (db.Categories.FirstOrDefault(s => s.Category_Id == categoryNow.Category_Id).Name) = CategoryItemNameTextBox.Text;
                    (db.Categories.FirstOrDefault(s => s.Category_Id == categoryNow.Category_Id).Parent_Id) = categoryNow.Parent_Id;
                    (db.Categories.FirstOrDefault(s => s.Category_Id == categoryNow.Category_Id).Description) = CategoryItemDescriptionTextBox.Text;
                    (db.Categories.FirstOrDefault(s => s.Category_Id == categoryNow.Category_Id).Level) = categoryNow.Level;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("\n" + ex.Message);
                }

                db.SaveChanges();
            }
            this.Close();
        }

        private void CategoryItemOpenButton_Click(object sender, EventArgs e)
        {
            if (CategoryItemCategoriesList.SelectedItem != null)
            {
                CategoryItemForm cif = new CategoryItemForm(parentForm, (Category)CategoryItemCategoriesList.SelectedItem);
                cif.Show();
            }
        }

        private void CategoryItemChooseParentButton_Click(object sender, EventArgs e)
        {
            if (CategoryItemCategoriesList.SelectedItem != null)
            {
                CategoryItemParentIdLabel.Text = "Parent ID: "+((Category)CategoryItemCategoriesList.SelectedItem).Category_Id;
                categoryNow.Parent_Id = ((Category)CategoryItemCategoriesList.SelectedItem).Category_Id;
                categoryNow.Level = ((Category)CategoryItemCategoriesList.SelectedItem).Level +1;
                CategoryItemLevelLabel.Text = "Level: " + categoryNow.Level;
            }
        }

        private void CategoryItemDeleteParentButton_Click(object sender, EventArgs e)
        {
            CategoryItemParentIdLabel.Text = "Parent ID: 0";
            categoryNow.Parent_Id = 0;
        }

        private void CategoryItemForm_FormClosed(object sender, FormClosedEventArgs e)
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
