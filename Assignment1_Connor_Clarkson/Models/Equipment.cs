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



        public static IEnumerable<Equipment> GetEquipments()
        {
            return new List<Equipment>
            {
                new Equipment()
                {
                    EquipName = "Lenovo S145",
                    EquipId = 1,
                    EquipCategory = Category.Laptop,
                    EquipDescription = "15.6 HD Laptop with 4GB RAM, 500GB SSD, Windows 10",
                    EquipAvailable = true
                },
                new Equipment()
                {
                    EquipName = "ASUS Vivobook",
                    EquipId = 2,
                    EquipCategory = Category.Laptop,
                    EquipDescription = "15.6 FHD Laptop with 8GB RAM, 128GB SSD, Windows 10",
                    EquipAvailable = false
                },
                new Equipment()
                {
                    EquipName = "Razer Phone 2",
                    EquipId = 3,
                    EquipCategory = Category.Phone,
                    EquipDescription = "120Hz QHD Display, Wireless Charging, 8GB RAM, 64GB Storage",
                    EquipAvailable = false
                },
                new Equipment()
                {
                    EquipName = "BlackBerry KEYone",
                    EquipId = 4,
                    EquipCategory = Category.Phone,
                    EquipDescription = "64GB Storage, 4GB RAM",
                    EquipAvailable = true
                },
                new Equipment()
                {
                    EquipName = "Samsung Galaxy Tab A",
                    EquipId = 5,
                    EquipCategory = Category.Tablet,
                    EquipDescription = "10.1inch Tablet with 2GB RAM, 16GB ROM, 10.5GB Storage",
                    EquipAvailable = true
                },
                new Equipment()
                {
                    EquipName = "Fire HD 8",
                    EquipId = 6,
                    EquipCategory = Category.Tablet,
                    EquipDescription = "8inch Tablet with 1.5GB RAM, 32GB Storage",
                    EquipAvailable = true
                },
                new Equipment()
                {
                    EquipName = "Nintendo Switch with Neon Blue and Neon Red Joy‑Con",
                    EquipId = 7,
                    EquipCategory = Category.Another,
                    EquipDescription = "The Nintendo Switch Gaming Console",
                    EquipAvailable = false
                },
                new Equipment()
                {
                    EquipName = "PS Vita",
                    EquipId = 8,
                    EquipCategory = Category.Another,
                    EquipDescription = "PlayStation Portable Vita HandHeld Gaming Console",
                    EquipAvailable = true
                },


            };


        }

    }
}
