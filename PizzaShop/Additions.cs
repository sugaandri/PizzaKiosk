namespace PizzaShop
{
    public class Additions 
    {
        public string name;
        public double price;
        public double amount;
        public int index;

        public Additions(string _name, double _price, double _amount, int _index)
        {
            name = _name;
            price = _price;
            amount = _amount;
            index = _index;
        }

        public string Name
        {
            get { return name; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public int Index
        {
            get { return index; }
        }
    }
}
