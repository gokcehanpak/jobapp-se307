using System;
namespace JobApplicationManagement
{

    public class JobSeeker
    {

        public int choosetype4 { get; set; }
        public int choosetype3 { get; set; }
        public int choosetype2 { get; set; }
        public String jobname { get; set; }
        public String jobtype { get; set; }


        public JobSeeker(String Jobname, String Jobtype) //parameterized const. for take info from objects.
        {
            this.jobname = Jobname;
            this.jobtype = Jobtype;
        }

        public JobSeeker() //non-parameterized constructor.
        {
            this.jobname = jobname;
            this.jobtype = jobtype;
        }


        public void JobFind()
        {


            Console.WriteLine("What do you look for?");
            Console.WriteLine("Press 1 for search available Engineering jobs.");
            Console.WriteLine("Press 2 for search available Medical Staff jobs.");
            Console.WriteLine("Press 3 for search available Law jobs.");
            Console.WriteLine("Press another number for turn back to main menu.");
            choosetype2 = Convert.ToInt32(Console.ReadLine());
            JobSeeker jbs1 = new JobSeeker("Apple Inc.", "Software Engineer"); //created objects for each of available jobs to show.
            JobSeeker jbs2 = new JobSeeker("Facebook", "Software Engineer");
            JobSeeker jbs3 = new JobSeeker("Beko", "Industrial Engineer");
            JobSeeker jbs4 = new JobSeeker("Avis", "Industrial Engineer");
            JobSeeker jbs5 = new JobSeeker("Agaoglu İns.", "Structural Engineer");
            JobSeeker jbs6 = new JobSeeker("Avcilar İns.", "Structural Engineer");
            JobSeeker jbsmed1 = new JobSeeker("MedicalPark", "Doctor");
            JobSeeker jbsmed2 = new JobSeeker("Liv Hospital", "Doctor");
            JobSeeker jbsmed3 = new JobSeeker("MedicalPark", "Nurse");
            JobSeeker jbsmed4 = new JobSeeker("Dokuz Eylül", "Nurse");
            JobSeeker jbsmed5 = new JobSeeker("Ege Üniversitesi", "Laborant");
            JobSeeker jbsmed6 = new JobSeeker("Memorial", "Laborant");
            JobSeeker jbslaw1 = new JobSeeker("Kural Law Bureau", "Criminal Lawyer");
            JobSeeker jbslaw2 = new JobSeeker("Pak Bureau of Investigation", "Criminal Lawyer");
            JobSeeker jbslaw3 = new JobSeeker("John Law", "Civic Lawyer");
            JobSeeker jbslaw4 = new JobSeeker("Kural Law Bureau", "Civic Lawyer");
            JobSeeker jbslaw5 = new JobSeeker("Pak Bureau of Investigation", "Public Lawyer");
            JobSeeker jbslaw6 = new JobSeeker("John and Jack Law", "Public Lawyer");

            if (choosetype2 == 1) //if-else statements for choosing type of jobs.

            {

                Console.WriteLine("Please choose the type of engineering.");
                Console.WriteLine("Press 1 for Software Eng.");
                Console.WriteLine("Press 2 for Industrial Eng.");
                Console.WriteLine("Press 3 for Structural Eng.");


                choosetype3 = Convert.ToInt32(Console.ReadLine());
                if (choosetype3 == 1)
                {

                    Console.WriteLine(jbs1.jobname);
                    Console.WriteLine(jbs1.jobtype);

                    Console.WriteLine(" OR ");

                    Console.WriteLine(jbs2.jobname);
                    Console.WriteLine(jbs2.jobtype);

                    Console.WriteLine();
                    Console.WriteLine("Press 1 for " + jbs1.jobname);

                    Console.WriteLine("Press 2 for " + jbs2.jobname);

                    choosetype4 = Convert.ToInt32(Console.ReadLine());
                    if (choosetype4 == 1)
                    {
                        Console.WriteLine("You applied to " + jbs1.jobname);
                    }
                    else if (choosetype4 == 2)
                    {
                        Console.WriteLine("You applied to " + jbs2.jobname);
                    }

                }

                else if (choosetype3 == 2)
                {
                    Console.WriteLine(jbs3.jobname);
                    Console.WriteLine(jbs3.jobtype);

                    Console.WriteLine(" OR ");

                    Console.WriteLine(jbs4.jobname);
                    Console.WriteLine(jbs4.jobtype);

                    Console.WriteLine();
                    Console.WriteLine("Press 1 for " + jbs3.jobname);
                    Console.WriteLine("Press 2 for " + jbs4.jobname);

                    choosetype4 = Convert.ToInt32(Console.ReadLine());
                    if (choosetype4 == 1)
                    {
                        Console.WriteLine("You applied to " + jbs3.jobname);
                    }
                    else if (choosetype4 == 2)
                    {
                        Console.WriteLine("You applied to " + jbs4.jobname);
                    }
                }

                else if (choosetype3 == 3)
                {
                    Console.WriteLine(jbs5.jobname);
                    Console.WriteLine(jbs5.jobtype);

                    Console.WriteLine(" OR ");

                    Console.WriteLine(jbs6.jobname);
                    Console.WriteLine(jbs6.jobtype);

                    Console.WriteLine();
                    Console.WriteLine("Press 1 for " + jbs5.jobname);
                    Console.WriteLine("Press 2 for " + jbs6.jobname);

                    choosetype4 = Convert.ToInt32(Console.ReadLine());
                    if (choosetype4 == 1)
                    {
                        Console.WriteLine("You applied to " + jbs5.jobname);
                    }
                    else if (choosetype4 == 2)
                    {
                        Console.WriteLine("You applied to " + jbs6.jobname);
                    }
                }


            }
            if (choosetype2 == 2)

            {

                Console.WriteLine("Please choose the type of medical staff.");
                Console.WriteLine("Press 1 for Doctor");
                Console.WriteLine("Press 2 for Nurse");
                Console.WriteLine("Press 3 for Laborant");


                choosetype3 = Convert.ToInt32(Console.ReadLine());
                if (choosetype3 == 1)
                {

                    Console.WriteLine(jbsmed1.jobname);
                    Console.WriteLine(jbsmed1.jobtype);

                    Console.WriteLine(" OR ");

                    Console.WriteLine(jbsmed2.jobname);
                    Console.WriteLine(jbsmed2.jobtype);

                    Console.WriteLine();
                    Console.WriteLine("Press 1 for " + jbsmed1.jobname);
                    Console.WriteLine("Press 2 for " + jbsmed2.jobname);

                    choosetype4 = Convert.ToInt32(Console.ReadLine());
                    if (choosetype4 == 1)
                    {
                        Console.WriteLine("You applied to " + jbsmed1.jobname);
                    }
                    else if (choosetype4 == 2)
                    {
                        Console.WriteLine("You applied to " + jbsmed2.jobname);
                    }

                }

                else if (choosetype3 == 2)
                {
                    Console.WriteLine(jbsmed3.jobname);
                    Console.WriteLine(jbsmed3.jobtype);

                    Console.WriteLine(" OR ");

                    Console.WriteLine(jbsmed4.jobname);
                    Console.WriteLine(jbsmed4.jobtype);

                    Console.WriteLine();
                    Console.WriteLine("Press 1 for " + jbsmed3.jobname);
                    Console.WriteLine("Press 2 for " + jbsmed4.jobname);

                    choosetype4 = Convert.ToInt32(Console.ReadLine());
                    if (choosetype4 == 1)
                    {
                        Console.WriteLine("You applied to " + jbsmed3.jobname);
                    }
                    else if (choosetype4 == 2)
                    {
                        Console.WriteLine("You applied to " + jbsmed4.jobname);
                    }
                }

                else if (choosetype3 == 3)
                {
                    Console.WriteLine(jbsmed5.jobname);
                    Console.WriteLine(jbsmed5.jobtype);

                    Console.WriteLine(" OR ");

                    Console.WriteLine(jbsmed6.jobname);
                    Console.WriteLine(jbsmed6.jobtype);

                    Console.WriteLine();
                    Console.WriteLine("Press 1 for " + jbsmed5.jobname);
                    Console.WriteLine("Press 2 for " + jbsmed6.jobname);

                    choosetype4 = Convert.ToInt32(Console.ReadLine());
                    if (choosetype4 == 1)
                    {
                        Console.WriteLine("You applied to " + jbsmed5.jobname);
                    }
                    else if (choosetype4 == 2)
                    {
                        Console.WriteLine("You applied to " + jbsmed6.jobname);
                    }
                }


            }

            if (choosetype2 == 3)

            {

                Console.WriteLine("Please choose the type of lawyer.");
                Console.WriteLine("Press 1 for Criminal Lawyer.");
                Console.WriteLine("Press 2 for Civic Lawyer.");
                Console.WriteLine("Press 3 for Public Lawyer.");


                choosetype3 = Convert.ToInt32(Console.ReadLine());
                if (choosetype3 == 1)
                {

                    Console.WriteLine(jbslaw1.jobname);
                    Console.WriteLine(jbslaw1.jobtype);

                    Console.WriteLine(" OR ");

                    Console.WriteLine(jbslaw2.jobname);
                    Console.WriteLine(jbslaw2.jobtype);

                    Console.WriteLine();
                    Console.WriteLine("Press 1 for " + jbslaw1.jobname);
                    Console.WriteLine("Press 2 for " + jbslaw2.jobname);

                    choosetype4 = Convert.ToInt32(Console.ReadLine());
                    if (choosetype4 == 1)
                    {
                        Console.WriteLine("You applied to " + jbslaw1.jobname);
                    }
                    else if (choosetype4 == 2)
                    {
                        Console.WriteLine("You applied to " + jbslaw2.jobname);
                    }

                }

                else if (choosetype3 == 2)
                {
                    Console.WriteLine(jbslaw3.jobname);
                    Console.WriteLine(jbslaw3.jobtype);

                    Console.WriteLine(" OR ");

                    Console.WriteLine(jbslaw4.jobname);
                    Console.WriteLine(jbslaw4.jobtype);

                    Console.WriteLine();
                    Console.WriteLine("Press 1 for " + jbslaw3.jobname);
                    Console.WriteLine("Press 2 for " + jbslaw4.jobname);

                    choosetype4 = Convert.ToInt32(Console.ReadLine());
                    if (choosetype4 == 1)
                    {
                        Console.WriteLine("You applied to " + jbslaw3.jobname);
                    }
                    else if (choosetype4 == 2)
                    {
                        Console.WriteLine("You applied to " + jbslaw4.jobname);
                    }
                }

                else if (choosetype3 == 3)
                {
                    Console.WriteLine(jbslaw5.jobname);
                    Console.WriteLine(jbslaw5.jobtype);

                    Console.WriteLine(" OR ");

                    Console.WriteLine(jbslaw6.jobname);
                    Console.WriteLine(jbslaw6.jobtype);

                    Console.WriteLine();
                    Console.WriteLine("Press 1 for " + jbslaw5.jobname);
                    Console.WriteLine("Press 2 for " + jbslaw6.jobname);

                    choosetype4 = Convert.ToInt32(Console.ReadLine());
                    if (choosetype4 == 1)
                    {
                        Console.WriteLine("You applied to " + jbslaw5.jobname);
                    }
                    else if (choosetype4 == 2)
                    {
                        Console.WriteLine("You applied to " + jbslaw6.jobname);
                    }
                }


            }


        }

    }

}