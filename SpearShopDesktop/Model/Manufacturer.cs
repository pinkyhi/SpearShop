using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpearShopDesktop.Model
{
    [Table("manufacturers")]
    public class Manufacturer
    {
        [Key,Column("manufacturer_id")]
        public int Manufacturer_Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public List<Good> Goods { get; set; }
    }
}
