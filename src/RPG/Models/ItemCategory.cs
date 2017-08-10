using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace RPG.Models
{
    [Table("ItemCategories")]
    public class ItemCategory
    {
        [Key]
        public int id { get; set; }
        public string type { get; set; }
    }
}
