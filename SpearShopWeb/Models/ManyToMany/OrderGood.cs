using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace SpearShopWeb.Models
{
    [Table("orders_goods")]
    public class OrderGood
    {
        [Column("order_id")]
        public int Order_Id { get; set; }
        public Order Order { get; set; }

        [Column("good_id")]
        public int Good_Id { get; set; }
        public Good Good { get; set; }
        public int Count { get; set; }

        public override string ToString()
        {
            return (Good.Good_Id + " " + Good.Name + "; Full price: " + (Count * Good.Price) + "; Count: " + Count);
        }

    }
}