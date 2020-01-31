using System;

namespace PizzaShop
{
    public class Pizza 
    {
        public int index;
        public string name;
        public string ingridients;
        public double price;


        public Pizza(int _index, string _name, string _ingridients, int _price)
        {
            index = _index;
            name = _name;
            ingridients = _ingridients;
            price = _price;
        }

        public int Index
        {
            get { return index; }
        }

        public string Name
        {
            get { return name; }
        }

        public string Ingridients
        {
            get { return ingridients; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

    }
}
