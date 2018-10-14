using System;
using System.Diagnostics;
using static Controller;

namespace SPZ_Lab_One
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test
            Controller controller = new Controller();

            //1. create_machine
            CoffeeMachine coffeeMachine1 = controller.CreateMachine("machine", 100, 100, 100, 100);		
            Console.WriteLine("Test_1.1 'create_machine' passed");

            //2. empty_name		
            try
            {
                CoffeeMachine coffeeMachine2 = controller.CreateMachine("", 100, 100, 100, 100);
            }
            catch (Exception)
            {
                Console.WriteLine("Test_1.2 'empty_name' passed");
            }
            
            try
            {
                CoffeeMachine coffeeMachine2 = controller.CreateMachine("Coffee machine", 10, 10, 10, 10);
            }
            catch (Exception)
            {
                Console.WriteLine("Test_1.3 'name_with_spaces' passed");
            }

            //4. negative_coffee_amount 	
            try
            {
                CoffeeMachine coffeeMachine2 = controller.CreateMachine("machine", -10, 23, 39, 19);
            }
            catch (Exception)
            {
                Console.WriteLine("Test_1.4 'negative_coffee_amount' passed");
            }
            
            //5. negative_milk_amount
            try
            {
                CoffeeMachine coffeeMachine2 = controller.CreateMachine("machine", 10, -23, 39, 19);
            }
            catch (Exception)
            {
                Console.WriteLine("Test_1.5 'negative_milk_amount' passed");
            }
            
            //6. negative_water_amount 		
            try
            {
                CoffeeMachine coffeeMachine2 = controller.CreateMachine("machine", 10, 23, 39, -19);
            }
            catch (Exception)
            {
                Console.WriteLine("Test_1.6 'negative_water_amount' passed");
            }

            //7. negative_sugar_amount 		
            try
            {
                CoffeeMachine coffeeMachine2 = controller.CreateMachine("machine", 10, 23, -39, 19);
            }
            catch (Exception)
            {
                Console.WriteLine("Test_1.7 'negative_water_amount' passed");
            }

            //8. making_one_coffee	
            try
            {
                controller.MakeOneCoffee(ref coffeeMachine1, "Americano", 2.0f);
            }
            catch (Exception)
            {
                Console.WriteLine("Test_2.1 'making_one_coffee' passed");
            }

            //9. wrong_coffee_type			
            try
            {
                controller.MakeOneCoffee(ref coffeeMachine1, "Expresso", 10.0f);
            }
            catch (Exception)
            {
                Console.WriteLine("Test_2.2 'wrong_coffee_type' passed");
            }

            //10. making_coffee_with_no_money		
            try
            {
                controller.MakeOneCoffee(ref coffeeMachine1, "Cappuccino", 0);
            }
            catch (Exception)
            {
                Console.WriteLine("Test_2.3 'making_coffee_with_no_money' passed");
            }

            //11. coffee_with_not_enough_money	
            try
            {
                controller.MakeOneCoffee(ref coffeeMachine1, "Moccacino", 4.0f);
            }
            catch (Exception)
            {
                Console.WriteLine("Test_2.4 'coffee_with_not_enough_money' passed");
            }

            //12. making_several_cups
            controller.RefilIngredient(ref coffeeMachine1);
            controller.MakeSomeDrinks(ref coffeeMachine1, "Latte", 10.0f, 2);
            Console.WriteLine("Test_3.1 'making_several_cups'");
            
            //13. zero_amount					
            try
            {
                controller.MakeSomeDrinks(ref coffeeMachine1, "Latte", 100.0f, 0);
            }
            catch (Exception)
            {
                Console.WriteLine("Test_3.2 'zero_amount' passed");
            }
            

            //14. negative_amount
            try
            {
                controller.MakeSomeDrinks(ref coffeeMachine1, "Latte", 10.0f, -4);
            }
            catch (Exception)
            {
                Console.WriteLine("Test_3.3 'negative_amount' passed");
            }
            
            //15. wrong_coffee_type
            try
            {
                controller.MakeSomeDrinks(ref coffeeMachine1, "lattE", 50, 9);
            }
            catch (Exception)
            {
                Console.WriteLine("Test_3.4 'wrong_coffee_type' passed");
            }
            

            //16. making_coffee_with_no_money
            try
            {
                controller.MakeSomeDrinks(ref coffeeMachine1, "Americano", 0, 3);
            }
            catch (Exception)
            {
                Console.WriteLine("Test_3.5 'making_coffee_with_no_money' passed");
            }
            

            //17. coffee_with_not_enough_money
            try
            {
                controller.MakeSomeDrinks(ref coffeeMachine1, "Moccacino", 11, 3);
            }
            catch (Exception)
            {
                Console.WriteLine("Test_3.6 'coffee_with_not_enough_money' passed");
            }   
        }
    }
}
