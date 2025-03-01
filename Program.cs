namespace Final_Project_Gym
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to the Gym Membership Management");
            while (true) 
            {
                int menuSelection = 0;

                Console.WriteLine("\nPlease choose an option");
                Console.WriteLine("1. Add member");
                Console.WriteLine("2. Remove member");
                Console.WriteLine("3. View all members");
                Console.WriteLine("4. View member account");
                Console.WriteLine("5. Exit");
                Console.Write("Your choice:");


                try
                {
                    menuSelection = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    throw;
                }



                if (menuSelection == 1) 
                {

                }

                if (menuSelection == 2)
                { 
                
                }

                if(menuSelection == 3)
                {

                }

                if (menuSelection == 4)
                { 
                
                }

                if (menuSelection == 5)
                { 
                
                }


































            }


        }
    }
}
