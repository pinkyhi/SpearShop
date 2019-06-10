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
    [Table("customers")]
    public class Customer
    {
        [Column("customer_id")]
        [Key]
        public int Customer_Id { get; set; }

        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Ip { get; set; }
        public int Zone { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }
    }
}
