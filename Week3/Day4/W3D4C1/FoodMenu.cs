using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3D4C1 {
    internal class FoodMenu {
        private List<string> foodItems;

        public FoodMenu(List<string> foodItems) {
            this.foodItems = foodItems;
        }

        public int Count { get { return foodItems.Count; } }

        public string this[int index] {
            get { 
                if(index < this.Count && index > -1) {
                    return this.foodItems[index];
                }
                return string.Empty;
            }
            set {
                if (!this.foodItems.Contains(value)) {
                    this.foodItems.Add(value);
                }
            }
        }

    }
}
