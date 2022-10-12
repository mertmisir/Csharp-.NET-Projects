using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTask
{
    internal class Collegue
    {
        private string name;
        private double foodPrice; 
        private double money; // to keep track of how much each collegue have!

        //default constructor
        public Collegue() 
        {
            name = "no name";
            foodPrice = 50; //by default let's our total food price be 50 euros!
            money = 0;
        }
        //constructor
        public Collegue(string name, double money) 
        {
            this.name = name;
            this.money = money;
        }
        //setters & getters
        public string getName() { return name; }
        public double getFoodPrice() { return foodPrice; }
        public double getMoney() { return money; }

        public void setName(string name) { this.name = name; }
        public void setFoodPrice(double foodPrice) { this.foodPrice = foodPrice; }
        public void setMoney(double money) { this.money = money; }

    }

   
}
