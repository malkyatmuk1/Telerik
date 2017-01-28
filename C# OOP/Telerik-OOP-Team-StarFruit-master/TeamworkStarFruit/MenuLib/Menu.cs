namespace MenuLib
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    using CatalogueLib;

    public class Menu
    {
        public static Dictionary<string, string> menuPages = new Dictionary<string, string>();
        public static List<Product> list = new List<Product>();
        private const string adminPass = "starfruits";
        // TO DO add menu pages
        public static void CreateMenu()
        {
            //Catalogue pc = new Catalogue();
            //list = pc.Initialcatalog();
            //think about using only one obj of StringBuilder to pass the values to a dictionary 
            //or make objects for all categories
          
            menuPages.Add("1", "(1) --> Enter like admin.\n(2) --> Enter like customer.\n(3) --> Exit.");
            //admin
            menuPages.Add("11", "(1) --> Show categories.\n(2) --> Back.");
            menuPages
                .Add("111",
                "(1) --> Show Big Appliances.\n(2) --> Show Small Appliances.\n(3) --> Show Mobiles.\n(4) --> Show Computers.\n(5) --> Back");

            //customer
            menuPages.Add("12", "(1) --> Show categories.\n(2) --> Show your bag.\n(3) --> Back.");
            menuPages.Add("121", "(1) --> Show Big Appliances.\n(2) --> Show Small Appliances.\n(3) --> Show Mobiles.\n(4) --> Show Computers.\n(5) --> Back");
            //the product pages
            //need method to chek the id if it exist add it to bag.
            menuPages.Add("1211", "----- Big Appliances ------\n(1) --> Add to bag by ID\n(2) --> Show bag.\n(3) --> Back.");
            menuPages.Add("1212", "----- small Appliances ------\n(1) --> Add to bag by ID\n(2) --> Show bag.\n(3) --> Back.");
            menuPages.Add("1213", "----- Mobiles ------\n(1) --> Add to bag by ID\n(2) --> Show bag.\n(3) --> Back.");
            menuPages.Add("1214", "----- Computers ------\n(1) --> Add to bag by ID\n(2) --> Show bag.\n(3) --> Back.");
            




            //from key "1111" to key tha last product (type).

            StringBuilder cat = new StringBuilder();
            cat.Append("--This is Computers categorie--\n(1) --> Back.\n");
            foreach (var item in list)
            {
                cat.Append(item);
            }
            menuPages.Add("1114",cat.ToString());

        }

        public static void ShowMenu(string key)
        {
            Console.Clear();
            Console.WriteLine("Press the symbol in the brakets to navigate the menu.");
            Console.WriteLine("-----------------------------------------------------");
            foreach (KeyValuePair<string, string> kvp in menuPages)
            {
                if (key == kvp.Key)
                {
                    Console.WriteLine(kvp.Value);
                }
            }
        }

        //TO Do Exception handling or go to the top of the loop if the input is bad
        //and print msg
        public void Navigate()
        {
            string key = "1";
            string option = ""; 
            int bound = 0;
            while (true)
            {
                option = Console.ReadLine();

                if(option == "")
                {
                    return;
                }

                switch (key)
                {
                    //admin 
                    case "1": bound = 3; break;
                    case "11": bound = 2; break;
                    case "111": bound = 5; break;
                    //customer
                    case "12": bound = 3; break;
                    case "121": bound = 5; break;
                    //products
                    case "1211": bound = 3; break;
                    case "1212": bound = 3; break;
                    case "1213": bound = 3; break;
                    case "1214": bound = 3; break;
                    
                        //TO DO
                        //1)add to bag

                    //2) Show bag.

                }


                if (option.Length > 1)
                {
                    Console.WriteLine("plese use the numbers in the brackets");
                    continue;
                }
                else 
                if (!(Convert.ToChar(option) - '0' >= 0 && Convert.ToChar(option) - '0' <= bound))
                {
                    Console.WriteLine("Please use a digit which is in range between 1 and {0}", bound);
                    continue;
                }
                else if(Convert.ToInt32(option) <= bound)
                {
                    
                    if (Convert.ToInt32(option) == bound)
                    {
                        StringBuilder temp = new StringBuilder();
                        for (int i = 0; i < key.Length - 1; i++)
                        {
                            temp.Append(key[i]);
                        }
                        key = temp.ToString();
                        temp.Clear();
                    }
                    else
                    {
                        key = key + option.ToString();
                    }

                    if (key == "11")
                    {
                        key = CheckPassword(key);
                        Menu.ShowMenu(key);
                    }
                    //customers nodes
                    else if (key == "1211")
                    {
                        //big apl
                        Menu.ShowMenu(key);
                        Console.WriteLine("big apl collection .. .");
                    }
                    else if (key == "1212")
                    {
                        //small apl
                        Menu.ShowMenu(key);
                        Console.WriteLine("small apl collection .. .");

                    }
                    else if (key == "1213")
                    {
                        //mobiles
                        Menu.ShowMenu(key);
                        Console.WriteLine("mobiles collection .. .");

                    }
                    else if (key == "1214")
                    {
                        //show computers
                        //TO DO take the new value and asign it to the dictionari with key == "1114"
                        Menu.ShowMenu(key);
                        Console.WriteLine("some list of computers..............");
                    }
                    else
                    {
                        Menu.ShowMenu(key);
                    }
                }
            }
        }


        private string CheckPassword(string key)
        {
            Console.Clear();
            Console.Write("Password:");
            string pass = Console.ReadLine();
            if (pass != adminPass)
            {
                Console.WriteLine("Wrong password. Press any key to continue.\nFrom the previous menu.");
                Console.ReadKey();

                key = "1";
            }

            return key;
        }

        public static void AddProductMenu()
        {
            Console.WriteLine("What kind of product you want to add?");
            // TO DO
        }
    }
}
