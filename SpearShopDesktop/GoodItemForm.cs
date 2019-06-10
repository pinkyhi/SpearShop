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
    public partial class GoodItemForm : Form
    {
        Good goodNow;
        MainForm parentForm;

        public GoodItemForm()
        {
            InitializeComponent();
        }
        public GoodItemForm(MainForm parentF, Good good)
        {
            parentForm = parentF;
            goodNow = good;
            InitializeComponent();
        }

        private void GoodItemForm_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach(Category cat in parentForm.Categories)
            {
                ((ToolStripMenuItem)GoodItemCategoriesStripMenu.Items[0]).DropDownItems.Add(cat.Name);
                ((ToolStripMenuItem)((ToolStripMenuItem)GoodItemCategoriesStripMenu.Items[0]).DropDownItems[i]).CheckOnClick = true;
                foreach(CategoryGood cg in cat.CategoryGoods!=null? cat.CategoryGoods:new List<CategoryGood>())
                {
                    if (cg.Good_Id == goodNow.Good_Id)
                    {
                        ((ToolStripMenuItem)((ToolStripMenuItem)GoodItemCategoriesStripMenu.Items[0]).DropDownItems[i]).Checked = true;
                    }
                }

                i++;
            }
            i = 0;
            foreach (Manufacturer m in parentForm.Manufacturers)
            {
                if(m.Name!= null && !m.Name.Equals(""))
                GoodItemManufacturerComboBox.Items.Add(m.Name);
            }
            if (goodNow.Manufacturer != null)
            {
                GoodItemManufacturerComboBox.Text = goodNow.Manufacturer.Name;
            }

            GoodItemPriceNumeric.Value = Convert.ToDecimal(goodNow.Price);

            GoodItemDescriptionTextBox.Text = goodNow.Description;

            GoodItemIdLabel.Text += Convert.ToString(goodNow.Good_Id);

            GoodItemNameTextBox.Text = goodNow.Name;

            GoodItemAvailableCounter.Value = goodNow.Available;

            if (goodNow.Imgs != null)
            {
                try
                {
                    using (var bmpTemp = new Bitmap(goodNow.Imgs[0].Img_Path))
                    {
                        GoodItemPictureBox.Image = new Bitmap(bmpTemp);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't found img \n" + ex.Message);
                }
            }

            if (goodNow.Imgs != null)
            {
                foreach(Img x in goodNow.Imgs)
                {
                    GoodItemImgsList.Items.Add(x);
                }
            }

            if (goodNow.Videos != null)
            {
                foreach (Video x in goodNow.Videos)
                {
                    GoodItemVideosList.Items.Add(x);
                }
            }
        }

        private void GoodItemImgAddButton_Click(object sender, EventArgs e)
        {
            if (GoodItemOpenImgDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                // получаем выбранный файл
                string filename = GoodItemOpenImgDialog.FileName;

                

                using (MyDbContext db = new MyDbContext())
                {
                    Img newImg = new Img { Good_Id = goodNow.Good_Id };
                    db.Imgs.Add(newImg);
                    db.SaveChanges();
                    string newDestF = parentForm.imagesDirectory + "\\g" + Convert.ToString(goodNow.Good_Id) + "i" + Convert.ToString(newImg.Img_Id) + "."+ filename[filename.Length - 3] + filename[filename.Length - 2] + filename[filename.Length - 1];
                    System.IO.File.Copy(filename,newDestF, true);
                    newImg.Img_Path = newDestF;
                    db.SaveChanges();
                    GoodItemImgsList.Items.Add(newImg);
                    if (GoodItemImgsList.Items.Count == 1)
                    {
                        try
                        {
                            using (Bitmap bmpTemp = new Bitmap(newDestF))
                            {
                                GoodItemPictureBox.Image = new Bitmap(bmpTemp);
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }

            }
        }

        private void GoodItemImgDeleteButton_Click(object sender, EventArgs e)
        {
            if (GoodItemImgsList.SelectedItem != null)
            {
                if (GoodItemImgsList.SelectedIndex == 0)
                {
                    GoodItemPictureBox.Image = null;
                }
                string pathTD= ((Img)GoodItemImgsList.SelectedItem).Img_Path;
                using (MyDbContext db = new MyDbContext())
                {
                    db.Imgs.Remove((Img)GoodItemImgsList.SelectedItem);
                    db.SaveChanges();
                    int oldI = GoodItemImgsList.SelectedIndex;
                    GoodItemImgsList.Items.Remove(GoodItemImgsList.SelectedItem);
                    if (oldI == 0 && GoodItemImgsList.Items != null && GoodItemImgsList.Items.Count!=0)
                    {
                        using (var bmpTemp = new Bitmap(((Img)GoodItemImgsList.Items[0]).Img_Path))
                        {
                            GoodItemPictureBox.Image = new Bitmap(bmpTemp);
                        }
                    }
                }
                if (System.IO.File.Exists(pathTD))
                {
                    try
                    {
                        System.IO.File.Delete(pathTD);
                    }
                    catch (System.IO.IOException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void GoodItemImgOpen_Click(object sender, EventArgs e)
        {
            if (GoodItemImgsList.SelectedItem != null)
            {
                System.Diagnostics.Process.Start(((Img)GoodItemImgsList.SelectedItem).Img_Path);
            }
        }



        private void GoodItemVideoAddButton_Click(object sender, EventArgs e)
        {
            if (GoodItemOpenVideoDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                // получаем выбранный файл
                string filename = GoodItemOpenVideoDialog.FileName;

                using (MyDbContext db = new MyDbContext())
                {
                    Video newVid = new Video { Good_Id = goodNow.Good_Id };
                    db.Videos.Add(newVid);
                    db.SaveChanges();
                    string newDestF = parentForm.videosDirectory + "\\v" + Convert.ToString(goodNow.Good_Id) + "i" + Convert.ToString(newVid.Video_Id) + "." + filename[filename.Length - 3] + filename[filename.Length - 2] + filename[filename.Length - 1];
                    System.IO.File.Copy(filename, newDestF, true);
                    newVid.Video_Path = newDestF;
                    db.SaveChanges();
                    GoodItemVideosList.Items.Add(newVid);

                }
            }
        }

        private void GoodItemVideoDeleteButton_Click(object sender, EventArgs e)
        {
            if (GoodItemVideosList.SelectedItem != null)
            {
                string pathTD = ((Video)GoodItemVideosList.SelectedItem).Video_Path;
                using (MyDbContext db = new MyDbContext())
                {
                    db.Videos.Remove((Video)GoodItemVideosList.SelectedItem);
                    db.SaveChanges();
                    int oldI = GoodItemVideosList.SelectedIndex;
                    GoodItemVideosList.Items.Remove(GoodItemVideosList.SelectedItem);

                }
                if (System.IO.File.Exists(pathTD))
                {
                    try
                    {
                        System.IO.File.Delete(pathTD);
                    }
                    catch (System.IO.IOException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void GoodItemVideoOpen_Click(object sender, EventArgs e)
        {
            if (GoodItemVideosList.SelectedItem != null)
            {
                try
                {
                    System.Diagnostics.Process.Start(((Video)GoodItemVideosList.SelectedItem).Video_Path);

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }












        private void GoodItemForm_FormClosed(object sender, FormClosedEventArgs e)
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

        private void GoodItemSubmitButton_Click(object sender, EventArgs e)
        {
            using (MyDbContext db = new MyDbContext())
            {

                List<Good> gfc= db.Goods.ToList();
                List<CategoryGood> cgt = db.CategoryGoods.ToList();
                List<Category> cgc = db.Categories.ToList();

                var man = db.Manufacturers;
                goodNow = db.Goods.FirstOrDefault(s => s.Good_Id == goodNow.Good_Id);
                goodNow.Name = GoodItemNameTextBox.Text;
                goodNow.Description = GoodItemDescriptionTextBox.Text;
                goodNow.Price = Convert.ToDouble(GoodItemPriceNumeric.Value);
                goodNow.Available = Convert.ToInt32(GoodItemAvailableCounter.Value);
                //db.SaveChanges();
                foreach (Manufacturer rm in db.Manufacturers)
                {
                    if (GoodItemManufacturerComboBox.Text.Equals(rm.Name))
                    {
                        goodNow.Manufacturer = rm;

                    }
                }
                foreach (ToolStripMenuItem x in ((ToolStripMenuItem)GoodItemCategoriesStripMenu.Items[0]).DropDownItems)
                {
                    if (x.Checked == true)
                    {
                        bool toAdd = true;
                        if (goodNow.CategoryGoods != null)
                        {
                            foreach (CategoryGood cg in goodNow.CategoryGoods)
                            {
                                try
                                {
                                    if (cg.Category.Name.Equals(x.Text))
                                    {
                                        toAdd = false;
                                    }
                                }
                                catch
                                {

                                }
                                
                            }
                        }
                        if (toAdd)
                        {
                            Category cta = null;
                            foreach (Category c in db.Categories)
                            {
                                if (c.Name!=null && c.Name.Equals(x.Text))
                                {
                                    cta = c;

                                }
                            }
                            if (goodNow.CategoryGoods != null)
                            {
                                goodNow.CategoryGoods.Add(new CategoryGood { Category_Id = cta.Category_Id, Good_Id = goodNow.Good_Id });
                            }
                            else
                            {
                                goodNow.CategoryGoods = new List<CategoryGood>();
                                goodNow.CategoryGoods.Add(new CategoryGood { Category_Id = cta.Category_Id, Good_Id = goodNow.Good_Id });

                            }
                        }
                    }
                    else
                    {
                        if (goodNow.CategoryGoods != null)
                        {
                            for (int i = 0; i < goodNow.CategoryGoods.Count; i++)
                            {
                                CategoryGood cg = goodNow.CategoryGoods[i];
                                try
                                {
                                    if (cg.Category.Name.Equals(x.Text))
                                    {
                                        goodNow.CategoryGoods.Remove(cg);
                                        i--;
                                    }
                                }
                                catch  { }
                            }
                        }
                    }
                }

                //Good changed = db.Goods.FirstOrDefault(s => s.Good_Id == goodNow.Good_Id);
                //changed.Description = goodNow.Description;
                //changed.Name = goodNow.Name;
                ///changed.Price = goodNow.Price;
                //changed.Manufacturer = goodNow.Manufacturer;
                //changed.CategoryGoods = goodNow.CategoryGoods;
                db.SaveChanges();
                this.Close();
            
            }
        }

        private void GoodItemDeleteButton_Click(object sender, EventArgs e)
        {
            using(MyDbContext db = new MyDbContext())
            {
                Good g = db.Goods.FirstOrDefault(s => s.Good_Id == goodNow.Good_Id);
                db.Goods.Remove(g);
                db.SaveChanges();
                if (goodNow.Imgs != null)
                {
                    foreach (Img x in goodNow.Imgs)
                    {
                        string pathTD = x.Img_Path;
                        if (System.IO.File.Exists(pathTD))
                        {
                            try
                            {
                                System.IO.File.Delete(pathTD);
                            }
                            catch (System.IO.IOException ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
                
                if (goodNow.Videos != null)
                {
                    foreach (Video x in goodNow.Videos)
                    {
                        string pathTD = x.Video_Path;
                        if (System.IO.File.Exists(pathTD))
                        {
                            try
                            {
                                System.IO.File.Delete(pathTD);
                            }
                            catch (System.IO.IOException ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
                
                
                this.Close();
            }
        }
    }
}

        /*
        private void GoodItemImgMakeMainButton_Click(object sender, EventArgs e)
        {
            if (GoodItemImgsList.SelectedItem != null)
            {
                using (MyDbContext db = new MyDbContext())
                {
                    List<Img> imgs = db.Imgs.ToList();
                    int i = GoodItemImgsList.SelectedIndex;
                    Img im = (Img)GoodItemImgsList.SelectedItem;
                    imgs[i] = imgs[0];
                    imgs[0] = im;
                    db.SaveChanges();

                    GoodItemPictureBox.Image = Image.FromFile(im.Img_Path);

                }
            }
        }*/

