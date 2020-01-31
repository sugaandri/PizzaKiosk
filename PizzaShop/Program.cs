using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

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
            double price = 0;
            TheMenu menu = new TheMenu();
            TheMenu additions = new TheMenu();
            menu.ShowTheMenu();
            menu.ChooseThePizza(price);
            additions.ChooseAdditions(price);
          
            /*Console.WriteLine("Please choose the index of that pizza which you want to buy: ");
            userPizzaChoice = int.Parse(Console.ReadLine());
            TheMenu pizza = new TheMenu();
            pizza.ChooseThePizza(userPizzaChoice);*/

        }
    }
}
