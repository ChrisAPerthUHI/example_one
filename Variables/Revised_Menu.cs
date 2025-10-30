using System.Runtime.InteropServices;

namespace Assesment_21015956
{
    internal class Program


    {
        static string userfore;
        static string usersur;  // global varibales
        static int usernumb;

        static int getchoice()
        {
            Console.WriteLine("hello, what option would you like to pick? Option 1 Will get you to enter your first and last name  and then generate a Username. Option 2 will turm any number you enter into a factorial number. Option 3 Will Exit.");
            return int.Parse(Console.ReadLine());
        }

        static string getname()
        {
            userfore = "";
            Console.WriteLine("Please enter your forename ");
            userfore = Console.ReadLine(); // gets the users forename
            userfore = userfore.ToLower();
            usersur = "";
            Console.WriteLine("Please enter your surname ");
            usersur = Console.ReadLine(); // gets the users surname
            return (userfore + usersur);
        }

        static void getusername()
        {
            getname(); // runs the code that gets the users first and last name
            Console.WriteLine("your username is " + userfore[0] + usersur.ToUpper()); // displays users new username
        }
        static void getnumb(int usernumb)
        {

            int starting_num = usernumb;
            int fact = 1; // factorial code
            while (true)
            {
                Console.Write(usernumb);
                if (usernumb == 1)
                {
                    break;
                }
                Console.Write(" * ");
                fact *= usernumb;
                usernumb--;
            }

            Console.WriteLine(" = {0}", fact);

            Console.WriteLine("Fact {0}: {1}", starting_num, fact);

        }
        static void Main(String[] args)
        {
            int userchoice;
            bool program_running = true;
            while (program_running == true)
            {
                userchoice = getchoice();
                if (userchoice == 1)
                {
                    getusername();
                }
                else if (userchoice == 2)
                {
                    Console.WriteLine("Please enter a number ");
                    usernumb = int.Parse(Console.ReadLine());
                    getnumb(usernumb);
                }
                else if (userchoice == 3)
                {
                    program_running = false;
                    Console.WriteLine("thank you for using my program :)");
                }
                else
                {
                    Console.WriteLine("Please input either 1, 2 or 3");
                }

            }
        }
    }
}