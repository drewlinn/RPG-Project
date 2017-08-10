using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace RPG.Models
{
    [Table("Inventories")]
    public class Inventory
    {   
        [Key]
        public int id { get; set; }
        public int helmetId { get; set; }
        public int armorId { get; set; }
        public int gloveId { get; set; }
        public int bootId { get; set; }
        public int accessoryId { get; set; }
        public int rEquipId { get; set; }
        public int lEquipId { get; set; }
    }
}
