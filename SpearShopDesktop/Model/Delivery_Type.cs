using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;
namespace SpearShopDesktop.Model
{
    [Table("delivery_types")]
    public class Delivery_Type
    {
        [Column("delivery_type_id"), Key]
        public int Type_Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
