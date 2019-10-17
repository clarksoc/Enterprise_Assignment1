using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1_Connor_Clarkson.Models
{
    public class Equipment
    {
        public string EquipName { get; set; }
        public int EquipId { get; set; }
        public Category EquipCategory { get; set; }
        public string EquipDescription { get; set; }
        public bool EquipAvailable { get; set; }



    }
}
