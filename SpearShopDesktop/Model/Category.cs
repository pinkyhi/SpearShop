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
    [Table("categories")]
    public class Category
    {
        
        [Key, Column("category_id")]
        public int Category_Id { get; set; }

        [Column("parent_id")]
        public int? Parent_Id { get; set; }
        public int Level { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

        public List<CategoryGood> CategoryGoods { get; set; }

        public override string ToString()
        {
            return "ID: " + Category_Id + "| " + Name;
        }

    }
}
