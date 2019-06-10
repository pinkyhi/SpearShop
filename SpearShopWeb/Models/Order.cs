using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpearShopWeb.Models
{
    [Table("orders")]
    public class Order
    {
        [Column("order_id")]
        [Key]
        public int Order_Id { get; set; }

        [Column("customer_id")]
        public int Customer_Id { get; set; }

        [Column("delivery_type_id")]
        public int Type_Id { get; set; }
        public Delivery_Type Delivery_Type { get; set; }
        public string Description { get; set; }

        [Column("full_price")]
        public double Full_Price { get; set; }
        public string Status { get; set; }
        public Customer Customer { get; set; }
        public List<OrderGood> OrderGoods { get; set; }

        public override string ToString()
        {
            return Order_Id + " | " + Status;
        }
    }
}
