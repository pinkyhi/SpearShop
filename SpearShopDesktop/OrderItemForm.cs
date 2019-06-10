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
    public partial class OrderItemForm : Form
    {
        Order orderNow;
        MainForm parentForm;
        public OrderItemForm()
        {
            InitializeComponent();
        }
        public OrderItemForm(MainForm parentF, Order order)
        {
            parentForm = parentF;
            orderNow = order;
            InitializeComponent();
        }

        private void OrderItemForm_Load(object sender, EventArgs e)
        {
            try
            {

                OrderItemStatusComboBox.Items.Add("New order");
                OrderItemStatusComboBox.Items.Add("Processed");
                OrderItemStatusComboBox.Items.Add("Ready");

                if (orderNow.Status != null)
                {
                    OrderItemStatusComboBox.Text = orderNow.Status;
                }

                double fullPrice = 0;
                if (orderNow.OrderGoods != null)
                {
                    foreach (OrderGood og in orderNow.OrderGoods)
                    {
                        fullPrice += og.Good.Price * og.Count;
                    }
                }

                OrderItemPriceLabel.Text += Convert.ToString(fullPrice);

                OrderItemDescriptionLabel.Text = orderNow.Description;

                OrderItemIdLabel.Text += Convert.ToString(orderNow.Order_Id);

                DeliveryTypeLabel.Text += orderNow.Delivery_Type;


                if (orderNow.OrderGoods != null)
                {
                    foreach (OrderGood x in orderNow.OrderGoods)
                    {
                        OrderItemGoodsList.Items.Add(x);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void OrderItemGoodAddButton_Click(object sender, EventArgs e)
        {
            if (OrderItemGoodIdToAddTextBox.Text == null || OrderItemGoodIdToAddTextBox.Text.Length == 0)
            {
                return;
            }
            else
            {
                using (MyDbContext db = new MyDbContext())
                {
                    List<Good> gds = db.Goods.ToList();
                    List<Order> ors = db.Orders.ToList();
                    List<OrderGood> ogs = db.OrderGoods.ToList();
                    int idGoodToAdd;
                    try
                    {
                        idGoodToAdd = Convert.ToInt32(OrderItemGoodIdToAddTextBox.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно преобразовать ID");
                        return;
                    }
                    Good goodToAdd = db.Goods.FirstOrDefault(id => id.Good_Id == idGoodToAdd);

                    if (goodToAdd != null)
                    {
                        if (goodToAdd.Available < OrderItemAddGoodCounter.Value)
                        {
                            MessageBox.Show("На складе доступно только " + goodToAdd.Available + " товаров с этим ID");
                            return;
                        }
                        else
                        {
                            goodToAdd.Available -= (int)OrderItemAddGoodCounter.Value;
                            db.SaveChanges();
                        }
                        if (db.OrderGoods.FirstOrDefault(s => s.Good_Id == goodToAdd.Good_Id && s.Order_Id == orderNow.Order_Id) == null)
                        {
                            OrderGood newRelat = new OrderGood { Count = (int)OrderItemAddGoodCounter.Value, Order_Id = orderNow.Order_Id, Good_Id = goodToAdd.Good_Id };
                            db.OrderGoods.Add(newRelat);
                            if (orderNow.OrderGoods!= null)
                            {
                                orderNow.OrderGoods.Add(newRelat);
                            }
                            else
                            {
                                orderNow.OrderGoods = new List<OrderGood>();
                                orderNow.OrderGoods.Add(newRelat);
                            }
                            
                            OrderItemGoodsList.Items.Add(newRelat);
                            db.SaveChanges();
                        }
                        else
                        {
                            db.OrderGoods.FirstOrDefault(s => s.Good_Id == goodToAdd.Good_Id && s.Order_Id == orderNow.Order_Id).Count += (int)OrderItemAddGoodCounter.Value;
                            db.SaveChanges();
                            
                            foreach (OrderGood og in orderNow.OrderGoods)
                            {
                                if(og.Good_Id== goodToAdd.Good_Id && og.Order_Id == orderNow.Order_Id)
                                {
                                    og.Count += (int)OrderItemAddGoodCounter.Value;
                                }
                            }
                            OrderItemGoodsList.Items.Clear();
                            if (orderNow.OrderGoods != null)
                            {
                                foreach (OrderGood x in orderNow.OrderGoods)
                                {
                                    OrderItemGoodsList.Items.Add(x);
                                }
                            }



                        }

                        db.SaveChanges();

                        double fullPrice = 0;
                        if (orderNow.OrderGoods != null)
                        {
                            foreach (OrderGood og in orderNow.OrderGoods)
                            {
                                fullPrice += og.Good.Price * og.Count;
                            }
                        }

                        OrderItemPriceLabel.Text = "Price: " + Convert.ToString(fullPrice);
                    }
                    else
                    {
                        MessageBox.Show("Товар с таки ID не найден");

                    }
                }
            }
        }

        private void OrderItemGoodDelete(OrderGood toDelete)
        {
            if (toDelete != null)
            {
                using (MyDbContext db = new MyDbContext())
                {
                    int countToDelete = (toDelete).Count;
                    try
                    {
                        (db.Goods.FirstOrDefault(s => s.Good_Id == (toDelete).Good_Id).Available) += countToDelete;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Товар не существует\n"+ex.Message);
                    }
                    db.OrderGoods.Remove(toDelete);
                    OrderItemGoodsList.Items.Remove(toDelete);
                    db.SaveChanges();
                }

            }
        }

        private void OrderItemGoodOpen_Click(object sender, EventArgs e)
        {
            if (OrderItemGoodsList.SelectedItem != null)
            {
                using (MyDbContext db = new MyDbContext())
                {
                    List<Img> imgst = db.Imgs.ToList();
                    List<Category> ctt = db.Categories.ToList();
                    List<CategoryGood> ctgdt = db.CategoryGoods.ToList();
                    List<Manufacturer> mndt = db.Manufacturers.ToList();
                    List<Video> vidst = db.Videos.ToList();



                    GoodItemForm ngif = new GoodItemForm(parentForm, db.Goods.FirstOrDefault(s => s.Good_Id == ((OrderGood)OrderItemGoodsList.SelectedItem).Good_Id));
                    ngif.Show();
                }
            }
        }

        private void OrderItemSubmitButton_Click(object sender, EventArgs e)
        {
            using (MyDbContext db = new MyDbContext())
            {
                try
                {
                    (db.Orders.FirstOrDefault(s => s.Order_Id == orderNow.Order_Id).Status)= OrderItemStatusComboBox.Text;
                    (db.Orders.FirstOrDefault(s => s.Order_Id == orderNow.Order_Id).Description) = OrderItemDescriptionLabel.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("\n" + ex.Message);
                }

                db.SaveChanges();
            }
            this.Close();
        }

        private void OrderItemShowCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerItemForm cif = new CustomerItemForm(parentForm, orderNow.Customer);
                cif.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OrderItemForm_FormClosed(object sender, FormClosedEventArgs e)
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

        private void OrderItemDeleteButton_Click(object sender, EventArgs e)
        {
            if(OrderItemGoodsList.Items != null)
            {
                while (OrderItemGoodsList.Items.Count != 0)
                {
                   OrderItemGoodDelete((OrderGood)OrderItemGoodsList.Items[0]);
                }
            }
            
            using (MyDbContext db = new MyDbContext())
            {
                Order td = db.Orders.FirstOrDefault(s => s.Order_Id == orderNow.Order_Id);
                db.Orders.Remove(td);
                db.SaveChanges();
            }
            this.Close();
        }
    }
}
