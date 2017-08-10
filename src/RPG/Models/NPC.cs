using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace RPG.Models
{
    [Table("NPCs")]
    public class NPC
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public int inventoryId { get; set; }
    }
}
