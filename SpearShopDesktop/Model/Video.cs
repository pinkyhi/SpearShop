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
    [Table("videos")]
    public class Video
    {
        [Column("video_id")]
        [Key]
        public int Video_Id { get; set; }

        [Column("good_id")]
        public int Good_Id { get; set; }
        [Column("video_path")]
        public string Video_Path { get; set; }

        public Good Good { get; set; }

        public override string ToString()
        {
            return Video_Path;
        }
    }
}
