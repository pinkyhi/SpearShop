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
    [Table("goods")]
    public class Good
    {
        
        [Column("good_id"), Key]
        public int Good_Id { get; set; }
        public string Name { get; set; }
        public int Available { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        [Column("manufacturer_id")]
        public int? Manufacturer_Id { get; set; }
        public Manufacturer Manufacturer { get; set; }

        public List<CategoryGood> CategoryGoods { get;set; }
        public List<OrderGood> OrderGoods { get; set; }

        public List<Img> Imgs { get; set; }

        public List<Video> Videos { get; set; }


    }

}

