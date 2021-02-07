using System;


namespace JobApplicationManagement
{
    public class MainClass
    {
        static void Main()
        {
            int choose1 = 1;

            Login logininfo1 = new Login(); //object of Login class.
            logininfo1.entry();



            JobSeeker jbskr = new JobSeeker(); //object of JobSeeker class.

            Creator addobj = new Creator(); //object of Creator class.



            while (true)
            {
                Console.WriteLine("Press 1 for create an empty job position.");
                Console.WriteLine("Press 2 for apply an available job position.");
                Console.WriteLine("Press another number for exit.");
                choose1 = Convert.ToInt32(Console.ReadLine());
                switch (choose1)  //project's core switch case statement for choosing whether you are a creator or job seeker.
                {
                    case 1:
                        Console.WriteLine();
                        addobj.add();
                        addobj.Display();
                        Console.WriteLine("Press 1 for create an empty job position.");
                        Console.WriteLine("Press 2 for apply an available job position.");
                        Console.WriteLine("Press another number for exit.");
                        choose1 = Convert.ToInt32(Console.ReadLine());
                        if (choose1 == 1)
                        {
                            Console.WriteLine();
                            addobj.add();
                            addobj.Display();
                        }
                        else if (choose1 == 2)
                        {

                        }

                        continue;



                    case 2:

                        Console.WriteLine();
                        jbskr.JobFind();
                        continue;

                    default:

                        Console.WriteLine("EXITED");
                        break;
                }
                break;
            }


        }
    }
}
