using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W10D3Assignment10._3.Models {
    public class Car {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CarID { get; set; } 
        public long Vin { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; } 
        public double Price { get; set; }
    }
}
