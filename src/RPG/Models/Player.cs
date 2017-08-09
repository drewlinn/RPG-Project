using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace RPG.Models
{
    [Table("Players")]
    public class Player
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public int inventoryId { get; set;  }
    }
}
