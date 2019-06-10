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
    [Table("imgs")]
    public class Img
    {
        [Column("img_id")]
        [Key]
        public int Img_Id { get; set; }

        [Column("good_id")]
        public int Good_Id { get; set; }
        [Column("img_path")]
        public string Img_Path { get; set; }
        public Good Good { get; set; }

        public override string ToString()
        {
            return Img_Path;
        }
    }
}
