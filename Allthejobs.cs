using System;
namespace JobApplicationManagement

{
    public class Allthejobs //Inheritance to make this class parent of Creator.

    {

        public int choose2 = 1;
        public String software = "Software";
        public String industrial = "Indsutrial";
        public String structural = "Structural";
        public int choose3 = 1;
        public String Doctor = "Doctor";
        public String Nurse = "Nurse";
        public String Laborant = "Laborant";
        public int choose4 = 1;
        public String criminal = "Criminal";
        public String civic = "Civic";
        public String publiclaw = "Public";


        public void Choiceforeng()
        {

            while (true) //loop for enginerring staff.
            {
                Console.WriteLine("Please select your specific type of engineering");
                Console.WriteLine("Press 1 for Software Eng.");
                Console.WriteLine("Press 2 for Industrial Eng.");
                Console.WriteLine("Press 3 for Structural Eng.");
                Console.WriteLine("Press another number for Exit.");
                choose2 = Convert.ToInt32(Console.ReadLine());



                switch (choose2)
                {
                    case 1:
                        Console.WriteLine("You created " + software + " Eng. position.");
                        break;

                    case 2:
                        Console.WriteLine("You created " + industrial + " Eng. position.");
                        break;
                    case 3:
                        Console.WriteLine("You created " + structural + " Eng. position.");
                        break;
                    default:
                        Console.WriteLine("EXITED");
                        break;



                }
                break;
            }
        }



        public void Choiceformed()
        {

            while (true) //loop for medical staff.
            {
                Console.WriteLine("Please select your specific type of medical staff");
                Console.WriteLine("Press 1 for Doctor");
                Console.WriteLine("Press 2 for Nurse");
                Console.WriteLine("Press 3 for Laborant");
                Console.WriteLine("Press another number for Exit.");
                choose3 = Convert.ToInt32(Console.ReadLine());


                switch (choose3)
                {
                    case 1:
                        Console.WriteLine("You created " + Doctor + " position.");
                        break;

                    case 2:
                        Console.WriteLine("You created " + Nurse + " position.");
                        break;
                    case 3:
                        Console.WriteLine("You created " + Laborant + " position.");
                        break;
                    default:
                        Console.WriteLine("EXITED");
                        break;



                }
                break;
            }
        }





        public void Choiceforlaw()
        {

            while (true) //loop for law staff.
            {
                Console.WriteLine("Please select your specific type of lawyer");
                Console.WriteLine("Press 1 for Criminal Lawyer");
                Console.WriteLine("Press 2 for Civic Lawyer");
                Console.WriteLine("Press 3 for Public Lawyer");
                Console.WriteLine("Press another number for Exit.");
                choose4 = Convert.ToInt32(Console.ReadLine());


                switch (choose4)
                {
                    case 1:
                        Console.WriteLine("You created " + criminal + " lawyer position.");
                        break;

                    case 2:
                        Console.WriteLine("You created " + civic + " lawyer position.");
                        break;
                    case 3:
                        Console.WriteLine("You created " + publiclaw + " lawyer position.");
                        break;
                    default:
                        Console.WriteLine("EXITED");
                        break;



                }
                break;
            }
        }

    }

}