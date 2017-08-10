using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace RPG.Models
{
    [Table("Items")]
    public class Item
    {
        [Key]
        public int id { get; set;  }
        public string name { get; set; }
        public int sizeId { get; set; }
        public int weight { get; set; }
        public int categoryId { get; set; }
    }
}
