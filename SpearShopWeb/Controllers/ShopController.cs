using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpearShopWeb.Models;

namespace SpearShopWeb.Controllers
{
    public class ShopController : Controller
    {
        MyDbContext db = new MyDbContext();

        public RedirectResult Index()
        {
            //List<Manufacturer> manufacturers = db.Manufacturers.ToList();
            //List<Good> goods = db.Goods.ToList();
            //ViewBag.Goods = goods.Where(s => s.Good_Id == 44).SelectMany(s => s.Name).ToList();
            //ViewBag.Manufacturers = manufacturers;
            // возвращаем представление
            return Redirect("/Shop/Categories/?page=1");
        }
        [HttpPost]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public ActionResult Good(int id)
        {
            ViewBag.db = db;
            ViewBag.Categories = db.Categories.ToList();
            ViewBag.Manufacturers = db.Manufacturers.ToList();
            ViewBag.Imgs = db.Imgs.ToList();
            ViewBag.Videos = db.Videos.ToList();
            ViewBag.DeliveryTypes = db.Delivery_Types.ToList();
            ViewBag.good = db.Goods.ToList().FirstOrDefault(s => s.Good_Id == id);

            if (ViewBag.good != null)
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
            else
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }
        [HttpPost]
        public RedirectResult Good(int Count, int Good_Id, int Zone, string Description, int Delivery_Type_Id, string Name, string Phone, string Mail)
        {
            string clientRemoteIP = HttpContext.Request.HttpContext.Connection.RemoteIpAddress.ToString();
            Customer customer = new Customer { Ip = clientRemoteIP, Name = Name, Mail = Mail, Phone = Phone, Zone = Zone };
            db.Customers.Add(customer);
            db.SaveChanges();
            List<OrderGood> OrderGoods = new List<OrderGood>();
            OrderGoods.Add(new OrderGood { Good_Id = Good_Id, Count = Count });
            Order order = new Order { Customer_Id = customer.Customer_Id, Status = "New order", Description = Description, OrderGoods = OrderGoods, Type_Id = Delivery_Type_Id };
            db.Orders.Add(order);
            db.SaveChanges();
            db.Goods.FirstOrDefault(s => s.Good_Id == Good_Id).Available -= Count;
            db.SaveChanges();
            return Redirect("/");
        }


        [HttpGet]
        
        public ActionResult Categories(string categoryName)
        {
            ViewBag.CategoryName=categoryName;

            List<Category> categories = new List<Category>(db.Categories.ToList());
            ViewBag.Categories = categories;
            List<Img> Imgs = new List<Img>(db.Imgs.ToList());
            ViewBag.Imgs = Imgs;
            List<CategoryGood> categoryGoods = new List<CategoryGood>(db.CategoryGoods.ToList());
            string sort = Request.Query["sort"];
            ViewBag.Sort = sort;
            string searchstr = Request.Query["searchstr"];
            ViewBag.Searchstr = searchstr;
            int page = Convert.ToInt32(Request.Query["page"]);
            ViewBag.Page = page;
            bool isNext = true;
            bool isBack = true;
            List<Good> goodsToCheck = new List<Good>(db.Goods);
            if (sort!= null)
            {
                if (sort.Equals("lb"))
                {
                    goodsToCheck = goodsToCheck.OrderBy(s => s.Price).ToList();
                }
                else if (sort.Equals("bl"))
                {
                    goodsToCheck = goodsToCheck.OrderByDescending(s => s.Price).ToList();
                }
            }
            if (searchstr != null)
            {
                for(int i = 0; i < goodsToCheck.Count; i++)
                {
                    Good gn = goodsToCheck[i];
                    if (gn.Name.IndexOf(searchstr) <0)
                    {
                        if ((Convert.ToString(gn.Good_Id)).IndexOf(searchstr) <0)
                        {
                            goodsToCheck.Remove(gn);
                            i--;
                        }
                    }
                }
            }


            int categoryId=-1;
            if (categoryName != null)
            {
                Category ccc = categories.FirstOrDefault(s => s.Name == categoryName);
                if (ccc != null)
                {
                    categoryId = ccc.Category_Id;
                }
                else
                {
                    ViewBag.Goods = new List<Good>();
                    ViewBag.IsNext = false;
                    ViewBag.IsBack = false;
                    return View();
                }
                if (categoryName != null && categoryName.Length > 0)
                {
                    if (!categoryName.Equals("All"))
                    {
                        for (int i = 0; i < goodsToCheck.Count; i++)
                        {
                            Good gn = goodsToCheck[i];
                            
                            if (gn.CategoryGoods==null || gn.CategoryGoods.FirstOrDefault(s => s.Category.Category_Id == categoryId) == null)
                            {
                                goodsToCheck.Remove(gn);
                                i--;
                            }
                        }
                    }
                }
            }
            
            


            List<Good> goodsToPaint = new List<Good>();
            if (1 > goodsToCheck.Count || page < 0)
            {
                goodsToCheck.Clear();
                isNext = false;
                isBack = false;
            }
            else
            {
                if (page * 12 >= goodsToCheck.Count)
                {
                    isNext = false;
                }
                if (page == 1)
                {
                    isBack = false;
                }

                int begin = (page - 1) * 12;
                int end = isNext?page * 12:goodsToCheck.Count;
                while (begin < end)
                {
                    goodsToPaint.Add(goodsToCheck[begin]);
                    begin++;
                }


            }
            ViewBag.Goods = goodsToPaint;
            ViewBag.IsNext = isNext;
            ViewBag.IsBack = isBack;
            return View();

        }



        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.db = db;
            ViewBag.Good = db.Goods.ToList().FirstOrDefault(s=>s.Good_Id == id);
            return View();
        }
        [HttpPost]
        public string Buy(Order order)
        {
            
            // добавляем информацию о покупке в базу данных
            db.Orders.Add(order);
            // сохраняем в бд все изменения
            //db.SaveChanges();
            return "Спасибо," + order.Status + ", за покупку!";
        }
    }
}
