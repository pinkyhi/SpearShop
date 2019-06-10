using SpearShopDesktop.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SpearShopDesktop
{
    public partial class MainForm : Form
    {
        public string imagesDirectory;
        public string videosDirectory;
        public List<OrderGood> OrderGoods;
        public List<Delivery_Type> Delivery_Types;
        public List<Order> Orders;
        public List<Customer> Customers;
        public List<Video> Videos;
        public List<Img> Imgs;
        public List<CategoryGood> CategoryGoods;
        public List<Category> Categories;
        public List<Manufacturer> Manufacturers;
        public List<Good> Goods;
        



        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {

                System.IO.Directory.SetCurrentDirectory(System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).FullName);
                System.IO.Directory.SetCurrentDirectory(System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).FullName);
                videosDirectory = Path.GetFullPath(Path.Combine(System.IO.Directory.GetCurrentDirectory(),@"..\SpearShopWeb\wwwroot\videos")); 
                imagesDirectory = Path.GetFullPath(Path.Combine(System.IO.Directory.GetCurrentDirectory(), @"..\SpearShopWeb\wwwroot\images"));
            }
            catch (Exception ex) { MessageBox.Show("Img or videos founding problem: "+ex.Message); }
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    Delivery_Types = new List<Delivery_Type>(db.Delivery_Types.ToList());
                    Orders = new List<Order>(db.Orders.ToList());
                    Customers = new List<Customer> (db.Customers.ToList());
                    Videos = new List<Video>(db.Videos.ToList());
                    Imgs = new List<Img>(db.Imgs.ToList());
                    CategoryGoods = new List<CategoryGood>( db.CategoryGoods.ToList());
                    Categories = new List<Category>(db.Categories.ToList());
                    Manufacturers = new List<Manufacturer>(db.Manufacturers.ToList());
                    OrderGoods = new List<OrderGood>(db.OrderGoods.ToList());
                    Goods = new List<Good>(db.Goods.ToList());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
            RePaintOrdersLayoutPanel(Orders);
            RePaintGoodsLayoutPanel(Goods);
            RePaintCustomersLayoutPanel(Customers);
            RePaintCategoriesLayoutPanel(Categories);
            RePaintManufacturersLayoutPanel(Manufacturers);
            RePaintDelivery_TypesLayoutPanel(Delivery_Types);


        }
        public class MyTextBox : TextBox
        {
            public object MyOwner { get; set; }
        }
        public void RePaintDelivery_TypesLayoutPanel(List<Delivery_Type> dtps)
        {
            Delivery_TypesLayoutTable.Visible = false;
            Delivery_TypesLayoutTable.Controls.Clear();
            Label goodsColumn1 = new Label();
            goodsColumn1.Margin = new Padding(0, 0, 0, 0);
            goodsColumn1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            goodsColumn1.TextAlign = ContentAlignment.MiddleCenter;
            goodsColumn1.Font = new Font("Microsoft Sans Serif", 16);
            goodsColumn1.Text = "Delivery type ID";
            Label goodsColumn2 = new Label();
            goodsColumn2.Margin = new Padding(0, 0, 0, 0);
            goodsColumn2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            goodsColumn2.TextAlign = ContentAlignment.MiddleCenter;
            goodsColumn2.Font = new Font("Microsoft Sans Serif", 16);
            goodsColumn2.Text = "Name";
            Delivery_TypesLayoutTable.Controls.AddRange(new Control[] { goodsColumn1, goodsColumn2});

            foreach(Delivery_Type dt in Delivery_Types)
            {
                Label column2Val = new Label();
                column2Val.Margin = new Padding(0, 0, 0, 0);
                column2Val.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
                column2Val.TextAlign = ContentAlignment.MiddleCenter;
                column2Val.Font = new Font("Microsoft Sans Serif", 12);
                column2Val.Text = Convert.ToString(dt.Type_Id);
                MyTextBox column3Val = new MyTextBox();
                column3Val.MyOwner = dt;
                column3Val.Margin = new Padding(0, 0, 0, 0);
                column3Val.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
                column3Val.Font = new Font("Microsoft Sans Serif", 12);
                column3Val.Text = Convert.ToString(dt.Name);
                Delivery_TypesLayoutTable.Controls.AddRange(new Control[] {column2Val, column3Val });
            }

            Delivery_TypesLayoutTable.Visible = true;

        }
        private void Delivery_TypesAddButton_Click(object sender, EventArgs e)
        {
            Delivery_Type newDt = new Delivery_Type();
            Label column2Val = new Label();
            column2Val.Margin = new Padding(0, 0, 0, 0);
            column2Val.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            column2Val.TextAlign = ContentAlignment.MiddleCenter;
            column2Val.Font = new Font("Microsoft Sans Serif", 12);
            column2Val.Text = "AUTO";
            MyTextBox column3Val = new MyTextBox();
            column3Val.MyOwner = newDt;
            column3Val.Margin = new Padding(0, 0, 0, 0);
            column3Val.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            column3Val.Font = new Font("Microsoft Sans Serif", 12);
            column3Val.Text = "newType";
            Delivery_TypesLayoutTable.Controls.AddRange(new Control[] { column2Val, column3Val });
        }

        private void Delivery_TypesSubmitButton_Click(object sender, EventArgs e)
        {
            using (MyDbContext db = new MyDbContext())
            {
                foreach (object myTb in Delivery_TypesLayoutTable.Controls)
                {
                    
                    if(myTb.GetType()== typeof(MyTextBox))
                    {
                        Delivery_Type t = db.Delivery_Types.FirstOrDefault(s => s.Type_Id == ((Delivery_Type)(((MyTextBox)myTb).MyOwner)).Type_Id);
                        if (t != null)
                        {
                            t.Name = ((Delivery_Type)(((MyTextBox)myTb).MyOwner)).Name;
                            db.SaveChanges();
                        }
                        else
                        {
                            if (((MyTextBox)myTb).Text != null && ((MyTextBox)myTb).Text.Length > 0)
                            {
                                Delivery_Type nDt = new Delivery_Type { Name = ((MyTextBox)myTb).Text };
                                db.Delivery_Types.Add(nDt);
                                db.SaveChanges();
                            }
                        }
                    }
                    else { }
                }
                
            }
            using (MyDbContext db = new MyDbContext())
            {
                OrderGoods = db.OrderGoods.ToList();
                Delivery_Types = db.Delivery_Types.ToList();
                Orders = db.Orders.ToList();
                Customers = db.Customers.ToList();
                Videos = db.Videos.ToList();
                Imgs = db.Imgs.ToList();
                CategoryGoods = db.CategoryGoods.ToList();
                Categories = db.Categories.ToList();
                Manufacturers = db.Manufacturers.ToList();
                Goods = db.Goods.ToList();
                RePaintDelivery_TypesLayoutPanel(Delivery_Types);
                RePaintOrdersLayoutPanel(Orders);
                RePaintGoodsLayoutPanel(Goods);
                RePaintCustomersLayoutPanel(Customers);
                RePaintCategoriesLayoutPanel(Categories);
                RePaintManufacturersLayoutPanel(Manufacturers);

            }
        }

        private void Delivery_TypesDeleteByIdButton_Click(object sender, EventArgs e)
        {
            using (MyDbContext db = new MyDbContext())
            {
                int idToDel = (int)Delivery_TypesDeleteCounter.Value;
                if (db.Delivery_Types.FirstOrDefault(s => s.Type_Id == idToDel) != null)
                {
                    db.Delivery_Types.Remove(db.Delivery_Types.FirstOrDefault(s => s.Type_Id == idToDel));
                    db.SaveChanges();

                    OrderGoods = db.OrderGoods.ToList();
                    Delivery_Types = db.Delivery_Types.ToList();
                    Orders = db.Orders.ToList();
                    Customers = db.Customers.ToList();
                    Videos = db.Videos.ToList();
                    Imgs = db.Imgs.ToList();
                    CategoryGoods = db.CategoryGoods.ToList();
                    Categories = db.Categories.ToList();
                    Manufacturers = db.Manufacturers.ToList();
                    Goods = db.Goods.ToList();
                    RePaintDelivery_TypesLayoutPanel(Delivery_Types);
                    RePaintOrdersLayoutPanel(Orders);
                    RePaintGoodsLayoutPanel(Goods);
                    RePaintCustomersLayoutPanel(Customers);
                    RePaintCategoriesLayoutPanel(Categories);
                    RePaintManufacturersLayoutPanel(Manufacturers);
                }
                else
                {

                }

            }
        }



        private void Button1_Click(object sender, EventArgs e)
        {

            using (MyDbContext db = new MyDbContext())
            {
                db.Database.EnsureCreated();

                Console.WriteLine("Объекты успешно сохранены");


                //Sorted
                //goods=goods.OrderBy(g => g.Price).ToList();
                //goods=goods.OrderByDescending(g => g.Price).ToList();

                //Adding
                //Good god1 = new Good { Name = "TomasMraz11", Available = 63, Price = 2008, Manufacturer = users[0], CategoryGoods = new List<CategoryGood>()  };
                //db.Goods.Add(god1);
                //db.SaveChanges();
                //god1.CategoryGoods.Add(new CategoryGood { Category_Id = categories[0].Category_Id, Good_Id = god1.Good_Id });
                //db.SaveChanges();

                //Deleting
                //Good student = db.Goods.FirstOrDefault();
                //db.Goods.Remove(student);

            }
        }


        ////
        ///
        //
        /*GOOD PART*/
        //
        //
        //
        private void GoodIdButtonClick(object sender, EventArgs e)
        {
            try
            {
                Good goodNow = ((Good)((MyIDButton)sender).MyOwner);
                GoodItemForm itemForm = new GoodItemForm(this, goodNow);
                itemForm.Show();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void RePaintGoodsLayoutPanel(List<Good> goodsToPaint)
        {
            GoodsLayoutTable.Visible = false;
            GoodsLayoutTable.Controls.Clear();
            Label goodsColumn1 = new Label();
            goodsColumn1.Margin = new Padding(0, 0, 0, 0);
            goodsColumn1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            goodsColumn1.TextAlign = ContentAlignment.MiddleCenter;
            goodsColumn1.Font = new Font("Microsoft Sans Serif", 16);
            goodsColumn1.Text = "Good ID";
            Label goodsColumn2 = new Label();
            goodsColumn2.Margin = new Padding(0, 0, 0, 0);
            goodsColumn2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            goodsColumn2.TextAlign = ContentAlignment.MiddleCenter;
            goodsColumn2.Font = new Font("Microsoft Sans Serif", 16);
            goodsColumn2.Text = "Name";
            Label goodsColumn3 = new Label();
            goodsColumn3.Margin = new Padding(0, 0, 0, 0);
            goodsColumn3.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            goodsColumn3.TextAlign = ContentAlignment.MiddleCenter;
            goodsColumn3.Font = new Font("Microsoft Sans Serif", 16);
            goodsColumn3.Text = "Price";
            Label goodsColumn4 = new Label();
            goodsColumn4.Margin = new Padding(0, 0, 0, 0);
            goodsColumn4.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            goodsColumn4.TextAlign = ContentAlignment.MiddleCenter;
            goodsColumn4.Font = new Font("Microsoft Sans Serif", 16);
            goodsColumn4.Text = "Available";
            Label goodsColumn5 = new Label();
            goodsColumn5.Margin = new Padding(0, 0, 0, 0);
            goodsColumn5.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            goodsColumn5.TextAlign = ContentAlignment.MiddleCenter;
            goodsColumn5.Font = new Font("Microsoft Sans Serif", 16);
            goodsColumn5.Text = "Description";
            Label goodsColumn6 = new Label();
            goodsColumn6.Margin = new Padding(0, 0, 0, 0);
            goodsColumn6.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            goodsColumn6.TextAlign = ContentAlignment.MiddleCenter;
            goodsColumn6.Font = new Font("Microsoft Sans Serif", 14);
            goodsColumn6.Text = "Manufacturer";
            Label goodsColumn7 = new Label();
            goodsColumn7.Margin = new Padding(0, 0, 0, 0);
            goodsColumn7.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            goodsColumn7.TextAlign = ContentAlignment.MiddleCenter;
            goodsColumn7.Font = new Font("Microsoft Sans Serif", 16);
            goodsColumn7.Text = "Images";
            Label goodsColumn8 = new Label();
            goodsColumn8.Margin = new Padding(0, 0, 0, 0);
            goodsColumn8.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            goodsColumn8.TextAlign = ContentAlignment.MiddleCenter;
            goodsColumn8.Font = new Font("Microsoft Sans Serif", 16);
            goodsColumn8.Text = "Videos";

            GoodsLayoutTable.Controls.AddRange(new Control[] { goodsColumn1, goodsColumn2, goodsColumn3, goodsColumn4, goodsColumn5, goodsColumn6, goodsColumn7, goodsColumn8 });
            GoodsLayoutTable.Visible = false;
            foreach (Good good in goodsToPaint)
            {
                
                MyIDButton idButton = new MyIDButton();
                idButton.MyOwner = good;
                idButton.Cursor = Cursors.Hand;
                idButton.Text = Convert.ToString(good.Good_Id);
                idButton.Margin = new Padding(0, 0, 0, 0);
                idButton.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
                idButton.Font = new Font("Microsoft Sans Serif", 12);
                idButton.FlatStyle = FlatStyle.Popup;
                idButton.Height = 30;
                idButton.Click += GoodIdButtonClick;

                Label column2Val = new Label();
                column2Val.Margin = new Padding(0, 0, 0, 0);
                column2Val.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
                column2Val.TextAlign = ContentAlignment.MiddleCenter;
                column2Val.Font = new Font("Microsoft Sans Serif", 12);
                column2Val.Text = good.Name;

                Label column3Val = new Label();
                column3Val.Margin = new Padding(0, 0, 0, 0);
                column3Val.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
                column3Val.TextAlign = ContentAlignment.MiddleCenter;
                column3Val.Font = new Font("Microsoft Sans Serif", 12);
                column3Val.Text = Convert.ToString(good.Price);

                Label column4Val = new Label();
                column4Val.Margin = new Padding(0, 0, 0, 0);
                column4Val.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
                column4Val.TextAlign = ContentAlignment.MiddleCenter;
                column4Val.Font = new Font("Microsoft Sans Serif", 12);
                column4Val.Text = Convert.ToString(good.Available);

                Label column5Val = new Label();
                column5Val.Margin = new Padding(0, 0, 0, 0);
                column5Val.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
                column5Val.TextAlign = ContentAlignment.MiddleCenter;
                column5Val.Font = new Font("Microsoft Sans Serif", 12);
                if (good.Description != null && good.Description.Length>0)
                {
                    column5Val.Text = "Length = " + good.Description.Length;
                    column5Val.BackColor = Color.GreenYellow;
                }
                else
                {
                    column5Val.Text = "NONE";
                    column5Val.BackColor = Color.IndianRed;
                }

                Label column6Val = new Label();
                column6Val.Margin = new Padding(0, 0, 0, 0);
                column6Val.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
                column6Val.TextAlign = ContentAlignment.MiddleCenter;
                column6Val.Font = new Font("Microsoft Sans Serif", 12);
                if (good.Manufacturer != null)
                {
                    column6Val.Text = good.Manufacturer.Name != null ? good.Manufacturer.Name : "";
                }
                

                Label column7Val = new Label();
                column7Val.Margin = new Padding(0, 0, 0, 0);
                column7Val.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
                column7Val.TextAlign = ContentAlignment.MiddleCenter;
                column7Val.Font = new Font("Microsoft Sans Serif", 12);

                Label column8Val = new Label();
                column8Val.Margin = new Padding(0, 0, 0, 0);
                column8Val.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
                column8Val.TextAlign = ContentAlignment.MiddleCenter;
                column8Val.Font = new Font("Microsoft Sans Serif", 12);

                if (good.Imgs != null && good.Imgs.Count > 0)
                {
                    column7Val.Text = "YES";
                    column7Val.BackColor = Color.GreenYellow;
                }
                else
                {
                    column7Val.Text = "NO";
                    column7Val.BackColor = Color.IndianRed;
                }
                if (good.Videos != null && good.Videos.Count > 0)
                {
                    column8Val.Text = "YES";
                    column8Val.BackColor = Color.GreenYellow;
                }
                else
                {
                    column8Val.Text = "NO";
                    column8Val.BackColor = Color.IndianRed;
                }

                GoodsLayoutTable.Controls.AddRange(new Control[] { idButton, column2Val, column3Val, column4Val, column5Val, column6Val, column7Val, column8Val });
            }
            GoodsLayoutTable.Visible = true;
        }

        private void GoodsAddGoodButton_Click(object sender, EventArgs e)
        {
            using(MyDbContext db = new MyDbContext())
            {
                db.Goods.Add(new Good { Name = "newGood", Price = 9999999, Available = 0 });
                db.SaveChanges();
                Goods = db.Goods.ToList();
                RePaintGoodsLayoutPanel(db.Goods.ToList());
            }
        }

        private void GoodsSortButton_Click(object sender, EventArgs e)
        {
            List<Good> goods = new List<Good>(Goods);
            if (goods != null)
            {
                for (int i = 0; i < goods.Count; i++)
                {
                    Good g = goods[i];
                    if (GoodsAvailableRadio.Checked)
                    {
                        if (g.Available == 0)
                        {
                            goods.Remove(g);
                            i--;
                            continue;
                        }
                    }
                    else if (GoodsNotAvailableRadio.Checked)
                    {
                        if (g.Available != 0)
                        {
                            goods.Remove(g);
                            i--;
                            continue;
                        }
                    }
                    if (GoodsImgTrueRadio.Checked)
                    {
                        if (g.Imgs == null || g.Imgs.Count < 1)
                        {
                            goods.Remove(g);
                            i--;
                            continue;
                        }
                    }
                    else if (GoodsImgFalseRadio.Checked)
                    {
                        if (g.Imgs != null && g.Imgs.Count > 0)
                        {
                            goods.Remove(g);
                            i--;
                            continue;
                        }
                    }
                    if (GoodsVideoTrueRadio.Checked)
                    {
                        if (g.Videos == null || g.Videos.Count < 1)
                        {
                            goods.Remove(g);
                            i--;
                            continue;
                        }
                    }
                    else if (GoodsVideoFalseRadio.Checked)
                    {
                        if (g.Videos != null && g.Videos.Count > 0)
                        {
                            goods.Remove(g);
                            i--;
                            continue;
                        }
                    }
                    if (GoodsAllFieldsTrueRadio.Checked)
                    {
                        if (g.Imgs == null || g.Videos == null || g.Manufacturer == null || g.CategoryGoods == null || g.Description == null || g.Description.Length < 1 || g.Imgs.Count < 1 || g.Videos.Count < 1 || g.Name == null || g.Name.Length < 1)
                        {
                            goods.Remove(g);
                            i--;
                            continue;
                        }
                    }
                    else if (GoodsAllFieldsFalseRadio.Checked)
                    {
                        if (g.Imgs != null && g.Videos != null && g.Manufacturer != null && g.CategoryGoods != null && g.Description != null && g.Description.Length > 0 && g.Imgs.Count > 0 && g.Videos.Count > 0 && g.Name != null && g.Name.Length > 0)
                        {
                            goods.Remove(g);
                            i--;
                            continue;
                        }
                    }
                }

                if (GoodsPriceBLRadio.Checked)
                {
                    goods = goods.OrderByDescending(g => g.Price).ToList();
                }
                else if (GoodsPriceLBRadio.Checked)
                {
                    goods = goods.OrderBy(g => g.Price).ToList();
                }
                RePaintGoodsLayoutPanel(goods);
            }
        }

        private void SortPriceClearButton_Click(object sender, EventArgs e)
        {
            GoodsPriceBLRadio.Checked = false;
            GoodsPriceLBRadio.Checked = false;
        }

        private void SortAvailableClearButton_Click(object sender, EventArgs e)
        {
            GoodsAvailableRadio.Checked = false;
            GoodsNotAvailableRadio.Checked = false;
        }

        private void SortVideoClearButton_Click(object sender, EventArgs e)
        {
            GoodsImgFalseRadio.Checked = false;
            GoodsImgTrueRadio.Checked = false;
        }

        private void SortImgClearButton_Click(object sender, EventArgs e)
        {
            GoodsVideoFalseRadio.Checked = false;
            GoodsVideoTrueRadio.Checked = false;
        }

        private void SortAllFieldsClearButton_Click(object sender, EventArgs e)
        {
            GoodsAllFieldsFalseRadio.Checked = false;
            GoodsAllFieldsTrueRadio.Checked = false;
        }


        
        private void GoodsSearchTextBox_TextChanged(object sender, EventArgs e)
        {

            List<Good> goodsToSearch;
            using (MyDbContext db = new MyDbContext())
            {
                goodsToSearch = new List<Good>(db.Goods);
            }
            
            if(GoodsSearchTextBox.Text!= null && GoodsSearchTextBox.Text.Length!=0)
            {
                if (GoodsSearchByIdRadio.Checked == true) {
                    RePaintGoodsLayoutPanel(SearchByIdOrName(true, goodsToSearch, GoodsSearchTextBox.Text));
                }
                else if(GoodsSearchByNameRadio.Checked == true)
                {
                    RePaintGoodsLayoutPanel(SearchByIdOrName(false, goodsToSearch, GoodsSearchTextBox.Text));
                }
            }
            else
            {
                Goods = goodsToSearch;
                RePaintGoodsLayoutPanel(Goods);
            }
            Goods = goodsToSearch;
        }
        private List<Good> SearchByIdOrName(bool byId, List<Good> gdsToSearch,string searchPart)
        {
            for(int i = 0; i< gdsToSearch.Count; i++)
            {
                Good gn = gdsToSearch[i];
                if (byId)
                {
                    string idStr = Convert.ToString(gn.Good_Id);
                    if ((Convert.ToString(gn.Good_Id)).IndexOf(searchPart) == -1)
                    {
                        gdsToSearch.Remove(gn);
                        i--;
                        continue;
                    }
                }
                else
                {
                    
                    if (gn.Name==null || gn.Name.IndexOf(searchPart) == -1)
                    {
                        gdsToSearch.Remove(gn);
                        i--;
                        continue;
                    }
                }
            }
            return gdsToSearch;
        }

        private void GoodsSearchByIdRadio_CheckedChanged(object sender, EventArgs e)
        {
            List<Good> goodsToSearch;
            using (MyDbContext db = new MyDbContext())
            {
                goodsToSearch = new List<Good>(db.Goods);
            }

            if (GoodsSearchTextBox.Text != null && GoodsSearchTextBox.Text.Length != 0)
            {
                if (GoodsSearchByIdRadio.Checked == true)
                {
                    RePaintGoodsLayoutPanel(SearchByIdOrName(true, goodsToSearch, GoodsSearchTextBox.Text));
                }
                else if (GoodsSearchByNameRadio.Checked == true)
                {
                    RePaintGoodsLayoutPanel(SearchByIdOrName(false, goodsToSearch, GoodsSearchTextBox.Text));
                }
            }
            else
            {
                Goods = goodsToSearch;
                RePaintGoodsLayoutPanel(Goods);
            }
            Goods = goodsToSearch;
        }

        private void GoodsSearchByNameRadio_CheckedChanged(object sender, EventArgs e)
        {
            List<Good> goodsToSearch;
            using (MyDbContext db = new MyDbContext())
            {
                goodsToSearch = new List<Good>(db.Goods);
            }

            if (GoodsSearchTextBox.Text != null && GoodsSearchTextBox.Text.Length != 0)
            {
                if (GoodsSearchByIdRadio.Checked == true)
                {
                    RePaintGoodsLayoutPanel(SearchByIdOrName(true, goodsToSearch, GoodsSearchTextBox.Text));
                }
                else if (GoodsSearchByNameRadio.Checked == true)
                {
                    RePaintGoodsLayoutPanel(SearchByIdOrName(false, goodsToSearch, GoodsSearchTextBox.Text));
                }
            }
            else
            {
                Goods = goodsToSearch;
                RePaintGoodsLayoutPanel(Goods);
            }
            Goods = goodsToSearch;
        }


        ////
        ///
        //
        /*ORDER PART*/
        //
        //
        private void OrderIdButtonClick(object sender, EventArgs e)
        {
            try
            {
                Order orderNow = ((Order)((MyIDButton)sender).MyOwner);
                OrderItemForm orderForm = new OrderItemForm(this, orderNow);
                orderForm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void RePaintOrdersLayoutPanel(List<Order> ordersToPaint)
        {
            OrdersLayoutTable.Visible = false;
            OrdersLayoutTable.Controls.Clear();
            Label goodsColumn1 = new Label();
            goodsColumn1.Margin = new Padding(0, 0, 0, 0);
            goodsColumn1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            goodsColumn1.TextAlign = ContentAlignment.MiddleCenter;
            goodsColumn1.Font = new Font("Microsoft Sans Serif", 16);
            goodsColumn1.Text = "Order ID";
            Label goodsColumn2 = new Label();
            goodsColumn2.Margin = new Padding(0, 0, 0, 0);
            goodsColumn2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            goodsColumn2.TextAlign = ContentAlignment.MiddleCenter;
            goodsColumn2.Font = new Font("Microsoft Sans Serif", 16);
            goodsColumn2.Text = "Cutomer name";
            Label goodsColumn3 = new Label();
            goodsColumn3.Margin = new Padding(0, 0, 0, 0);
            goodsColumn3.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            goodsColumn3.TextAlign = ContentAlignment.MiddleCenter;
            goodsColumn3.Font = new Font("Microsoft Sans Serif", 16);
            goodsColumn3.Text = "Full price";
            Label goodsColumn4 = new Label();
            goodsColumn4.Margin = new Padding(0, 0, 0, 0);
            goodsColumn4.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            goodsColumn4.TextAlign = ContentAlignment.MiddleCenter;
            goodsColumn4.Font = new Font("Microsoft Sans Serif", 16);
            goodsColumn4.Text = "Goods";
            Label goodsColumn5 = new Label();
            goodsColumn5.Margin = new Padding(0, 0, 0, 0);
            goodsColumn5.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            goodsColumn5.TextAlign = ContentAlignment.MiddleCenter;
            goodsColumn5.Font = new Font("Microsoft Sans Serif", 16);
            goodsColumn5.Text = "Status";
            

            OrdersLayoutTable.Controls.AddRange(new Control[] { goodsColumn1, goodsColumn2, goodsColumn3, goodsColumn4, goodsColumn5 });

            foreach (Order order in ordersToPaint)
            {
                MyIDButton idButton = new MyIDButton();
                idButton.MyOwner = order;
                idButton.Cursor = Cursors.Hand;
                idButton.Text = Convert.ToString(order.Order_Id);
                idButton.Margin = new Padding(0, 0, 0, 0);
                idButton.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
                idButton.Font = new Font("Microsoft Sans Serif", 12);
                idButton.FlatStyle = FlatStyle.Popup;
                idButton.Height = 30;
                idButton.Click += OrderIdButtonClick;

                Label column2Val = new Label();
                column2Val.Margin = new Padding(0, 0, 0, 0);
                column2Val.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
                column2Val.TextAlign = ContentAlignment.MiddleCenter;
                column2Val.Font = new Font("Microsoft Sans Serif", 12);
                try
                {
                    column2Val.Text = order.Customer.Name;
                }
                catch { }

                Label column3Val = new Label();
                column3Val.Margin = new Padding(0, 0, 0, 0);
                column3Val.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
                column3Val.TextAlign = ContentAlignment.MiddleCenter;
                column3Val.Font = new Font("Microsoft Sans Serif", 12);
                double fullPrice = 0;
                if (order.OrderGoods != null)
                {
                    foreach (OrderGood og in order.OrderGoods)
                    {
                        try
                        {
                            fullPrice += og.Good.Price * og.Count;
                        }
                        catch
                        {
                            idButton.BackColor = Color.IndianRed;
                        }
                    }
                }
                column3Val.Text = Convert.ToString(fullPrice);

                Label column4Val = new Label();
                column4Val.Margin = new Padding(0, 0, 0, 0);
                column4Val.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
                column4Val.TextAlign = ContentAlignment.MiddleCenter;
                column4Val.Font = new Font("Microsoft Sans Serif", 12);
                if (order.OrderGoods != null) {
                    column4Val.Text = Convert.ToString(order.OrderGoods.Count);
                }
                

                Label column5Val = new Label();
                column5Val.Margin = new Padding(0, 0, 0, 0);
                column5Val.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
                column5Val.TextAlign = ContentAlignment.MiddleCenter;
                column5Val.Font = new Font("Microsoft Sans Serif", 12);
                if (order.Status != null && order.Status.Length > 0 && order.Status.Equals("Ready"))
                {
                    column5Val.Text = "Ready";
                    column5Val.BackColor = Color.GreenYellow;
                }
                else if(order.Status != null && order.Status.Length > 0 && order.Status.Equals("Processed"))
                {
                    column5Val.Text = "Processed";
                    column5Val.BackColor = Color.LightYellow;
                }
                else if (order.Status != null && order.Status.Length > 0 && order.Status.Equals("New order"))
                {
                    column5Val.Text = "New order";
                    column5Val.BackColor = Color.IndianRed;
                }
                else
                {
                    column5Val.Text = "Undefined";
                    column5Val.BackColor = Color.Red;
                }

                OrdersLayoutTable.Controls.AddRange(new Control[] { idButton, column2Val, column3Val, column4Val, column5Val });
            }
            OrdersLayoutTable.Visible = true;
        }

        private void OrdersSearchTextBox_TextChanged(object sender, EventArgs e)
        {

            List<Order> ordersToSearch;
            using (MyDbContext db = new MyDbContext())
            {
                List<Good> gdst = db.Goods.ToList();
                List<Customer> cstst = db.Customers.ToList();
                List<Img> imgst= db.Imgs.ToList();
                List<Video> vidst = db.Videos.ToList();
                List<Category> ctgrst = db.Categories.ToList();
                List<Manufacturer> mnfctrs = db.Manufacturers.ToList();
                List<OrderGood> ogst = db.OrderGoods.ToList();
                List<CategoryGood> ctgrgds = db.CategoryGoods.ToList();
                ordersToSearch = new List<Order>(db.Orders);
            }

            if (OrdersSearchTextBox.Text != null && OrdersSearchTextBox.Text.Length != 0)
            {
                if (OrdersSearchByOrderIdRadio.Checked == true)
                {

                    RePaintOrdersLayoutPanel(SearchOrderByIdOrName(true, ordersToSearch, OrdersSearchTextBox.Text));
                }
                else if (OrdersSearchByCustomerNameRadio.Checked == true)
                {
                    RePaintOrdersLayoutPanel(SearchOrderByIdOrName(false, ordersToSearch, OrdersSearchTextBox.Text));
                }
            }
            else
            {
                Orders = ordersToSearch;
                ValidateByStatus(Orders);
                RePaintOrdersLayoutPanel(Orders);
            }
            Orders = ordersToSearch;
        }
        private List<Order> SearchOrderByIdOrName(bool byId, List<Order> rdsToSearch, string searchPart)
        {
            for (int i = 0; i < rdsToSearch.Count; i++)
            {
                Order rd = rdsToSearch[i];
                if (byId)
                {
                    string idStr = Convert.ToString(rd.Order_Id);
                    if ((Convert.ToString(rd.Order_Id)).IndexOf(searchPart) == -1)
                    {
                        rdsToSearch.Remove(rd);
                        i--;
                        continue;
                    }
                }
                else
                {

                    if (rd.Customer==null || rd.Customer.Name == null || rd.Customer.Name.IndexOf(searchPart) == -1)
                    {
                        rdsToSearch.Remove(rd);
                        i--;
                        continue;
                    }
                }
            }
            ValidateByStatus(rdsToSearch);
            return rdsToSearch;
        }
        public List<Order> ValidateByStatus(List<Order> srcList)
        {
            if (NewStatusRadio.Checked)
            {
                for(int i=0; i < srcList.Count; i++)
                {
                    if (!srcList[i].Status.Equals("New order"))
                    {
                        srcList.Remove(srcList[i]);
                        i--;
                    }
                }
            }
            else if (ReadyStatusRadio.Checked)
            {
                for (int i = 0; i < srcList.Count; i++)
                {
                    if (!srcList[i].Status.Equals("Ready"))
                    {
                        srcList.Remove(srcList[i]);
                        i--;
                    }
                }
            }
            else if(ProcessedStatusRadio.Checked)
            {
                for (int i = 0; i < srcList.Count; i++)
                {
                    if (!srcList[i].Status.Equals("Processed"))
                    {
                        srcList.Remove(srcList[i]);
                        i--;
                    }
                }
            }

            return srcList;

        }

        private void AllStatusRadio_CheckedChanged(object sender, EventArgs e)
        {
            OrdersSearchTextBox_TextChanged(null, null);
        }

        private void NewStatusRadio_CheckedChanged(object sender, EventArgs e)
        {
            OrdersSearchTextBox_TextChanged(null, null);
        }

        private void ReadyStatusRadio_CheckedChanged(object sender, EventArgs e)
        {
            OrdersSearchTextBox_TextChanged(null, null);
        }

        private void ProcessedStatusRadio_CheckedChanged(object sender, EventArgs e)
        {
            OrdersSearchTextBox_TextChanged(null, null);
        }

        private void OrdersSearchByOrderIdRadio_CheckedChanged(object sender, EventArgs e)
        {
            OrdersSearchTextBox_TextChanged(null, null);
        }

        private void OrdersSearchByCustomerNameRadio_CheckedChanged(object sender, EventArgs e)
        {
            OrdersSearchTextBox_TextChanged(null, null);
        }

        ////
        ///
        //
        /*CUSTOMER PART*/
        //
        //
        private void CustomerIdButtonClick(object sender, EventArgs e)
        {
            try
            {
                Customer customerNow = ((Customer)((MyIDButton)sender).MyOwner);
                CustomerItemForm customerForm = new CustomerItemForm(this, customerNow);
                customerForm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void RePaintCustomersLayoutPanel(List<Customer> customersToPaint)
        {
            CustomersLayoutTable.Visible = false;
            CustomersLayoutTable.Controls.Clear();
            Label goodsColumn1 = new Label();
            goodsColumn1.Margin = new Padding(0, 0, 0, 0);
            goodsColumn1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            goodsColumn1.TextAlign = ContentAlignment.MiddleCenter;
            goodsColumn1.Font = new Font("Microsoft Sans Serif", 16);
            goodsColumn1.Text = "Customer ID";
            Label goodsColumn2 = new Label();
            goodsColumn2.Margin = new Padding(0, 0, 0, 0);
            goodsColumn2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            goodsColumn2.TextAlign = ContentAlignment.MiddleCenter;
            goodsColumn2.Font = new Font("Microsoft Sans Serif", 16);
            goodsColumn2.Text = "Mail";
            Label goodsColumn3 = new Label();
            goodsColumn3.Margin = new Padding(0, 0, 0, 0);
            goodsColumn3.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            goodsColumn3.TextAlign = ContentAlignment.MiddleCenter;
            goodsColumn3.Font = new Font("Microsoft Sans Serif", 16);
            goodsColumn3.Text = "Phone";
            Label goodsColumn4 = new Label();
            goodsColumn4.Margin = new Padding(0, 0, 0, 0);
            goodsColumn4.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            goodsColumn4.TextAlign = ContentAlignment.MiddleCenter;
            goodsColumn4.Font = new Font("Microsoft Sans Serif", 16);
            goodsColumn4.Text = "IP";
            Label goodsColumn5 = new Label();
            goodsColumn5.Margin = new Padding(0, 0, 0, 0);
            goodsColumn5.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            goodsColumn5.TextAlign = ContentAlignment.MiddleCenter;
            goodsColumn5.Font = new Font("Microsoft Sans Serif", 16);
            goodsColumn5.Text = "Name";
            Label goodsColumn6 = new Label();
            goodsColumn6.Margin = new Padding(0, 0, 0, 0);
            goodsColumn6.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            goodsColumn6.TextAlign = ContentAlignment.MiddleCenter;
            goodsColumn6.Font = new Font("Microsoft Sans Serif", 16);
            goodsColumn6.Text = "Zone";


            CustomersLayoutTable.Controls.AddRange(new Control[] { goodsColumn1, goodsColumn2, goodsColumn3, goodsColumn4, goodsColumn5, goodsColumn6 });

            foreach (Customer customer in customersToPaint)
            {
                MyIDButton idButton = new MyIDButton();
                idButton.MyOwner = customer;
                idButton.Cursor = Cursors.Hand;
                idButton.Text = Convert.ToString(customer.Customer_Id);
                idButton.Margin = new Padding(0, 0, 0, 0);
                idButton.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
                idButton.Font = new Font("Microsoft Sans Serif", 12);
                idButton.FlatStyle = FlatStyle.Popup;
                idButton.Height = 30;
                idButton.Click += CustomerIdButtonClick;

                Label column2Val = new Label();
                column2Val.Margin = new Padding(0, 0, 0, 0);
                column2Val.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
                column2Val.TextAlign = ContentAlignment.MiddleCenter;
                column2Val.Font = new Font("Microsoft Sans Serif", 12);
                try
                {
                    column2Val.Text = customer.Mail;
                }
                catch { }

                Label column3Val = new Label();
                column3Val.Margin = new Padding(0, 0, 0, 0);
                column3Val.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
                column3Val.TextAlign = ContentAlignment.MiddleCenter;
                column3Val.Font = new Font("Microsoft Sans Serif", 12);
                try
                {
                    column3Val.Text = Convert.ToString(customer.Phone);
                }
                catch { }

                Label column4Val = new Label();
                column4Val.Margin = new Padding(0, 0, 0, 0);
                column4Val.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
                column4Val.TextAlign = ContentAlignment.MiddleCenter;
                column4Val.Font = new Font("Microsoft Sans Serif", 12);
                if (customer.Ip != null)
                {
                    column4Val.Text = Convert.ToString(customer.Ip);
                }


                Label column5Val = new Label();
                column5Val.Margin = new Padding(0, 0, 0, 0);
                column5Val.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
                column5Val.TextAlign = ContentAlignment.MiddleCenter;
                column5Val.Font = new Font("Microsoft Sans Serif", 12);
                try
                {
                    column5Val.Text = customer.Name;
                }
                catch
                {

                }
                Label column6Val = new Label();
                column6Val.Margin = new Padding(0, 0, 0, 0);
                column6Val.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
                column6Val.TextAlign = ContentAlignment.MiddleCenter;
                column6Val.Font = new Font("Microsoft Sans Serif", 12);
                try
                {
                    column6Val.Text = "UTC "+customer.Zone/-60;
                }
                catch
                {

                }


                CustomersLayoutTable.Controls.AddRange(new Control[] { idButton, column2Val, column3Val, column4Val, column5Val, column6Val });
            }
            CustomersLayoutTable.Visible = true;
        }
        ////
        ///
        //
        /*CATEGORY PART*/
        //
        //
        private void CategoryIdButtonClick(object sender, EventArgs e)
        {
            try
            {
                Category categoryNow = ((Category)((MyIDButton)sender).MyOwner);
                CategoryItemForm categoryForm = new CategoryItemForm(this, categoryNow);
                categoryForm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void RePaintCategoriesLayoutPanel(List<Category> categoriesToPaint)
        {
            CategoriesLayoutTable.Visible = false;
            CategoriesLayoutTable.Controls.Clear();
            Label goodsColumn1 = new Label();
            goodsColumn1.Margin = new Padding(0, 0, 0, 0);
            goodsColumn1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            goodsColumn1.TextAlign = ContentAlignment.MiddleCenter;
            goodsColumn1.Font = new Font("Microsoft Sans Serif", 16);
            goodsColumn1.Text = "Category ID";
            Label goodsColumn2 = new Label();
            goodsColumn2.Margin = new Padding(0, 0, 0, 0);
            goodsColumn2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            goodsColumn2.TextAlign = ContentAlignment.MiddleCenter;
            goodsColumn2.Font = new Font("Microsoft Sans Serif", 16);
            goodsColumn2.Text = "Name";
            Label goodsColumn3 = new Label();
            goodsColumn3.Margin = new Padding(0, 0, 0, 0);
            goodsColumn3.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            goodsColumn3.TextAlign = ContentAlignment.MiddleCenter;
            goodsColumn3.Font = new Font("Microsoft Sans Serif", 16);
            goodsColumn3.Text = "Description";
            Label goodsColumn4 = new Label();
            goodsColumn4.Margin = new Padding(0, 0, 0, 0);
            goodsColumn4.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            goodsColumn4.TextAlign = ContentAlignment.MiddleCenter;
            goodsColumn4.Font = new Font("Microsoft Sans Serif", 16);
            goodsColumn4.Text = "Parent id";
            Label goodsColumn5 = new Label();
            goodsColumn5.Margin = new Padding(0, 0, 0, 0);
            goodsColumn5.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            goodsColumn5.TextAlign = ContentAlignment.MiddleCenter;
            goodsColumn5.Font = new Font("Microsoft Sans Serif", 16);
            goodsColumn5.Text = "Level";



            CategoriesLayoutTable.Controls.AddRange(new Control[] { goodsColumn1, goodsColumn2, goodsColumn3, goodsColumn4, goodsColumn5 });

            foreach (Category category in categoriesToPaint)
            {
                MyIDButton idButton = new MyIDButton();
                idButton.MyOwner = category;
                idButton.Cursor = Cursors.Hand;
                idButton.Text = Convert.ToString(category.Category_Id);
                idButton.Margin = new Padding(0, 0, 0, 0);
                idButton.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
                idButton.Font = new Font("Microsoft Sans Serif", 12);
                idButton.FlatStyle = FlatStyle.Popup;
                idButton.Height = 30;
                idButton.Click += CategoryIdButtonClick;

                Label column2Val = new Label();
                column2Val.Margin = new Padding(0, 0, 0, 0);
                column2Val.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
                column2Val.TextAlign = ContentAlignment.MiddleCenter;
                column2Val.Font = new Font("Microsoft Sans Serif", 12);
                try
                {
                    column2Val.Text = category.Name;
                }
                catch { }

                Label column3Val = new Label();
                column3Val.Margin = new Padding(0, 0, 0, 0);
                column3Val.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
                column3Val.TextAlign = ContentAlignment.MiddleCenter;
                column3Val.Font = new Font("Microsoft Sans Serif", 12);
                try
                {
                    column3Val.Text = Convert.ToString(category.Description.Length);
                }
                catch { }

                Label column4Val = new Label();
                column4Val.Margin = new Padding(0, 0, 0, 0);
                column4Val.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
                column4Val.TextAlign = ContentAlignment.MiddleCenter;
                column4Val.Font = new Font("Microsoft Sans Serif", 12);
                if (category.Parent_Id != null)
                {
                    column4Val.Text = Convert.ToString(category.Parent_Id);
                }


                Label column5Val = new Label();
                column5Val.Margin = new Padding(0, 0, 0, 0);
                column5Val.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
                column5Val.TextAlign = ContentAlignment.MiddleCenter;
                column5Val.Font = new Font("Microsoft Sans Serif", 12);
                try
                {
                    column5Val.Text = Convert.ToString(category.Level);
                }
                catch
                {

                }



                CategoriesLayoutTable.Controls.AddRange(new Control[] { idButton, column2Val, column3Val, column4Val, column5Val});
            }
            CategoriesLayoutTable.Visible = true;
        }
        ////
        ///
        //
        /*MANUFACTURER PART*/
        //
        //
        private void ManufacturerIdButtonClick(object sender, EventArgs e)
        {
            try
            {
                Manufacturer manufacturerNow = ((Manufacturer)((MyIDButton)sender).MyOwner);
                ManufacturerItemForm manufacturerForm = new ManufacturerItemForm(this, manufacturerNow);
                manufacturerForm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void RePaintManufacturersLayoutPanel(List<Manufacturer> manufacturersToPaint)
        {
            ManufacturersLayoutTable.Visible = false;
            ManufacturersLayoutTable.Controls.Clear();
            Label goodsColumn1 = new Label();
            goodsColumn1.Margin = new Padding(0, 0, 0, 0);
            goodsColumn1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            goodsColumn1.TextAlign = ContentAlignment.MiddleCenter;
            goodsColumn1.Font = new Font("Microsoft Sans Serif", 16);
            goodsColumn1.Text = "Manufacturer ID";
            Label goodsColumn2 = new Label();
            goodsColumn2.Margin = new Padding(0, 0, 0, 0);
            goodsColumn2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            goodsColumn2.TextAlign = ContentAlignment.MiddleCenter;
            goodsColumn2.Font = new Font("Microsoft Sans Serif", 16);
            goodsColumn2.Text = "Name";
            Label goodsColumn3 = new Label();
            goodsColumn3.Margin = new Padding(0, 0, 0, 0);
            goodsColumn3.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            goodsColumn3.TextAlign = ContentAlignment.MiddleCenter;
            goodsColumn3.Font = new Font("Microsoft Sans Serif", 16);
            goodsColumn3.Text = "Description";
            


            ManufacturersLayoutTable.Controls.AddRange(new Control[] { goodsColumn1, goodsColumn2, goodsColumn3 });

            foreach (Manufacturer manufacturer in manufacturersToPaint)
            {
                MyIDButton idButton = new MyIDButton();
                idButton.MyOwner = manufacturer;
                idButton.Cursor = Cursors.Hand;
                idButton.Text = Convert.ToString(manufacturer.Manufacturer_Id);
                idButton.Margin = new Padding(0, 0, 0, 0);
                idButton.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
                idButton.Font = new Font("Microsoft Sans Serif", 12);
                idButton.FlatStyle = FlatStyle.Popup;
                idButton.Height = 30;
                idButton.Click += ManufacturerIdButtonClick;

                Label column2Val = new Label();
                column2Val.Margin = new Padding(0, 0, 0, 0);
                column2Val.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
                column2Val.TextAlign = ContentAlignment.MiddleCenter;
                column2Val.Font = new Font("Microsoft Sans Serif", 12);
                try
                {
                    column2Val.Text = manufacturer.Name;
                }
                catch { }

                Label column3Val = new Label();
                column3Val.Margin = new Padding(0, 0, 0, 0);
                column3Val.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
                column3Val.TextAlign = ContentAlignment.MiddleCenter;
                column3Val.Font = new Font("Microsoft Sans Serif", 12);
                try
                {
                    column3Val.Text = Convert.ToString(manufacturer.Description.Length);
                }
                catch { }

                


                ManufacturersLayoutTable.Controls.AddRange(new Control[] { idButton, column2Val, column3Val});
            }
            ManufacturersLayoutTable.Visible = true;
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            using (MyDbContext db = new MyDbContext())
            {
                db.Orders.Add(new Order { Status = "New order"});
                db.SaveChanges();
                Orders = db.Orders.ToList();
                RePaintOrdersLayoutPanel(db.Orders.ToList());
            }
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            using (MyDbContext db = new MyDbContext())
            {
                db.Customers.Add(new Customer { Zone = -120 });
                db.SaveChanges();
                Customers = db.Customers.ToList();
                RePaintCustomersLayoutPanel(db.Customers.ToList());
            }
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            using (MyDbContext db = new MyDbContext())
            {
                db.Categories.Add(new Category { Level = 0, Parent_Id = 0 });
                db.SaveChanges();
                Categories = db.Categories.ToList();
                RePaintCategoriesLayoutPanel(db.Categories.ToList());
            }
        }

        private void AddManufacturerButton_Click(object sender, EventArgs e)
        {
            using (MyDbContext db = new MyDbContext())
            {
                db.Manufacturers.Add(new Manufacturer {});
                db.SaveChanges();
                Manufacturers = db.Manufacturers.ToList();
                RePaintManufacturersLayoutPanel(db.Manufacturers.ToList());
            }
        }


    }



    public class MyIDButton : Button
    {
        public object MyOwner { get; set; }
    }
    
}