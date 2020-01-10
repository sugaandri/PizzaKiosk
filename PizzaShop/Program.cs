using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PizzaShop
{

    /*Write a console app to allow your users to order pizza
     * 1.)Menu of five pizza types
     * 2.)User can choose from two types of pizza dough
     * 3.)User can add some additional ingridients to their order
     * 4.)User can choose a custom pizza with four ingridients
     * 5.)User can order more than one pizza
     * 6.)After the user confirms their order, the total is displayed.*/
    
    class Program
    {
        static void Main(string[] args)
        {
            ShowTheMenu()
        }

        private static void ShowTheMenu(List<Pizza> menu)
        {
            foreach (Pizza pizza in menu)
            {
                Console.WriteLine(pizza);
            }
        }
    }

    public class Pizza
    {
        public string name;
        public string ingridients;
        public int price;

        public void pizzaMaker(string _name, string _ingridients, int _price)
        {
            name = _name;
            ingridients = _ingridients;
            price = _price;
        }
    }

    public class TheMenu
    {
        List<Pizza> menu = new List<Pizza>();

        public void theMenu()
        {
            Pizza Mafioso = new Pizza();
            Mafioso.pizzaMaker("Mafioso", "Cheese, tomato, salami, olives", 5);

            Pizza Hawaii = new Pizza();
            Hawaii.pizzaMaker("Hawaii", "Cheese, tomato, pineapple, chicken", 6);

            Pizza Bolognese = new Pizza();
            Bolognese.pizzaMaker("Bolognese", "Cheese, tex-mex sauce, jalapeno, minced meat", 6);

            Pizza Francescana = new Pizza();
            Francescana.pizzaMaker("Francescana", "Cheese, tomato, mushrooms, ham", 7);

            Pizza Pepperone = new Pizza();
            Pepperone.pizzaMaker("Pepperone", "Cheese, tomato, onions, pepperoni", 8);

            menu.Add(Mafioso);
            menu.Add(Hawaii);
            menu.Add(Bolognese);
            menu.Add(Francescana);
            menu.Add(Pepperone);
        }
    }
}
