using System;
using System.Collections.Generic;


namespace JobApplicationManagement
{


    public class Creator : Allthejobs  // Allthejobs HAS-A Creator.(Has-a relationship) Which means Creator is child and Allthejobs is parent.
    {
        public int choosetype1;

        public String jobnameadd { get; set; }
        public String jobtypeadd { get; set; }

        public Creator(String Jobnameadd, String Jobtypeadd)
        {
            this.jobnameadd = Jobnameadd;
            this.jobtypeadd = Jobtypeadd;

        }

        public Creator()
        {


        }

        List<string> joblist = new List<string>();
        Login loginfo = new Login();

        public void add() // add method for creating new job positions.
        {

            Allthejobs eng1 = new Allthejobs(); //objects to add new different type of jobs.
            Allthejobs med1 = new Allthejobs();
            Allthejobs law1 = new Allthejobs();

            while (true)
            {
                Console.WriteLine("Please enter company name: " + loginfo.readUsername);
                jobnameadd = Console.ReadLine();

                Console.WriteLine("Please enter job expectations: " + loginfo.readUsername);
                jobtypeadd = Console.ReadLine();




                Console.WriteLine("Please select your profession with pressing numbers");
                Console.WriteLine("1 for Engineering");
                Console.WriteLine("2 for Medical Staff");
                Console.WriteLine("3 for Law");
                Console.WriteLine("Another number for Exit.");
                choosetype1 = Convert.ToInt32(Console.ReadLine());

                switch (choosetype1) //switch-case statement for create which type of job.
                {
                    case 1:
                        eng1.Choiceforeng();
                        break;
                    case 2:
                        med1.Choiceformed();
                        break;
                    case 3:
                        law1.Choiceforlaw();
                        break;
                    default:
                        break;
                }
                break;


            }

            joblist.Add(jobnameadd); //adding operations to list.
            joblist.Add(jobtypeadd);


            Console.WriteLine("------------");

            Console.WriteLine("You added succesfully a job position.");

            Console.WriteLine("------------");




        }

        public void Display()
        {

            joblist.ForEach(Console.WriteLine);
        }


    }
}