using System;

namespace JobApplicationManagement
{
    public class Login
    {

        public String readUsername { get; set; } //setter-getter methods.
        public int readPassword { get; set; }

        public Login() //non-parameterized constructor.
        {

            this.readPassword = readPassword;
            this.readUsername = readUsername;

        }

        public void entry()
        {



            while (true)
            {
                Console.WriteLine("Please enter your username: ");
                readUsername = Console.ReadLine();


                if (readUsername == "gokcehanpak" || readUsername == "egekural" || readUsername == "lewandowski09")
                {
                    Console.WriteLine("Please enter your password: ");
                    readPassword = Convert.ToInt32(Console.ReadLine());


                    if (readPassword == 1234)
                    {
                        Console.WriteLine("WELCOME " + readUsername);
                        break;
                    }
                    else if (readPassword != 1234)
                    {
                        Console.WriteLine("INVALID PASSWORD!");


                    }
                }
                else
                    Console.WriteLine("TRY AGAIN");

            }
            return;
        }
    }
}