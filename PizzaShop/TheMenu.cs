using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace PizzaShop
{
    public class TheMenu
    {
        public List<Pizza> menu = new List<Pizza>();
        public List<Additions> additions = new List<Additions>();
        public List<Object> basket = new List<Object>();

        public TheMenu()
        {
            Pizza Mafioso = new Pizza(1, "Mafioso", "Cheese, tomato, salami, olives", 5);

            Pizza Hawaii = new Pizza(2, "Hawaii", "Cheese, tomato, pineapple, chicken", 6);

            Pizza Bolognese = new Pizza(3, "Bolognese", "Cheese, tex-mex sauce, jalapeno, minced meat", 6);

            Pizza Francescana = new Pizza(4, "Francescana", "Cheese, tomato, mushrooms, ham", 7);

            Pizza Pepperone = new Pizza(5, "Pepperone", "Cheese, tomato, onions, pepperoni", 8);

            menu.Add(Mafioso);
            menu.Add(Hawaii);
            menu.Add(Bolognese);
            menu.Add(Francescana);
            menu.Add(Pepperone);

            Additions Tomato = new Additions("Tomato", 0.5, 0, 1);
            Additions Onion = new Additions("Onion", 0.5, 0, 2);
            Additions Tobasco = new Additions("Tobasco", 0.5, 0, 3);
            Additions Jalapeno = new Additions("Jalapeno", 1, 0, 4);
            Additions Bacon = new Additions("Bacon", 1, 0, 5);

            additions.Add(Tomato);
            additions.Add(Onion);
            additions.Add(Tobasco);
            additions.Add(Jalapeno);
            additions.Add(Bacon);
        }

        public void ShowTheMenu()
        {
            foreach (Pizza pizza in menu)
            {
                Console.WriteLine($"Name: {pizza.name} [index: {pizza.index}]");
                Console.WriteLine($"Ingridients: {pizza.ingridients}");
                Console.WriteLine($"Price: {pizza.price}");
                Console.WriteLine();
            }
        }

        public void ShowAdditions()
        {
            foreach(Additions additions in additions)
            {
                Console.WriteLine($"{additions.name} [index: {additions.index}]");
                Console.WriteLine($"Price: {additions.price}");
                
            }
        }

        public void ChooseAdditions(double price)
        {
            ShowAdditions();
            Console.WriteLine("Choose the index of that addition which you want to add. If everythin is OK" +
                                 "press 'ENTER': ");
            int userAdditionChoice = int.Parse(Console.ReadLine());
            foreach (Additions additions in additions)
            {
                if (additions.index == userAdditionChoice)
                {
                    Console.WriteLine("If you want addition on half of the pizza press 0.5 if you want it normal press 1" +
                                         "if you want a double dose press 2");
                    double userAdditionAmount = double.Parse(Console.ReadLine());
                    if (CalculateAddition(userAdditionAmount, additions) > 0) // kas try/catch on mõistlikum?
                    {
                        price += CalculateAddition(userAdditionAmount, additions);
                    }

                    price += additions.price;
                    basket.Add(additions);

                }
            }

            Console.WriteLine("If you don't want to add any more additions press 'ENTER'");
            var key = Console.ReadKey();
            if(key.Key == ConsoleKey.Enter)
            {
               
            }
        }

        public void ChooseThePizza(double price)
        {
            int userPizzaChoice;
            Console.WriteLine("Please choose the index of that pizza which you want to buy: ");
            userPizzaChoice = int.Parse(Console.ReadLine());
            foreach (Pizza pizza in menu)
            {
                if (pizza.Index == userPizzaChoice)
                {
                    ChooseTheDough(price);
                    Console.Clear();
                    Console.WriteLine("The pizza(s) you chose: ");
                    ShowThePizza(pizza);
                    price += pizza.price;
                    basket.Add(pizza);
                }
                else { }

            }
        }

        public void ShowThePizza(Pizza _pizza)
        {
            Console.WriteLine($"{_pizza.name}");
            Console.WriteLine($"{_pizza.ingridients}");
            Console.WriteLine($"{_pizza.price}");
            Console.WriteLine();
        }

        public void ChooseTheDough(double price)
        {
            int doughChoice;
            Console.WriteLine("If you prefer thin pizza (normal price) press '1' or pan pizza(+1€ extra) press '2'.");
            doughChoice = int.Parse(Console.ReadLine());

            if (doughChoice == 1)
            {

                Console.WriteLine();
            }

            else if (doughChoice == 2)
            {
                price += 1;
            }
        }

        public double CalculateAddition(double amount, Additions addition)
        {
            double a = (addition.price * amount);
            return a;
        }

        /*public double CalculateTheBasket()
        {
            foreach(Object item in basket)
            {
                
            }
        }*/
    }

    public class Item
    {
        public double price;
        public int amount; 
    }
}
