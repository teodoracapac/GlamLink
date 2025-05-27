using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class Models
    {
        public class ClothingItem
        {
            public int IdClothes { get; set; }    // Corresponds to idClothes
            public string Name { get; set; }       // Corresponds to Name
            public string Category { get; set; }   // Corresponds to Category
            public string Color { get; set; }      // Corresponds to Color
            public string Season { get; set; }
        }
        }
}
