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
    [Table("categories_goods")]
    public class CategoryGood
    {
        [Column("category_id")]
        public int Category_Id { get; set; }
        public Category Category { get; set; }

        [Column("good_id")]
        public int Good_Id { get; set; }
        public Good Good { get; set; }


    }
}
