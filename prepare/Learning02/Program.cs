using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Clown";
        job1._company = "Kings Island";
        job1._startYear = 2009;
        job1._endYear = 2009;

        Job job2 = new Job();
        job2._jobTitle = "Easy Tech";
        job2._company = "Staples";
        job2._startYear = 2009;
        job2._endYear = 20010;

        Job job3 = new Job();
        job3._jobTitle = "Home Health Aide";
        job3._company = "Affinity Home Care";
        job3._startYear = 2013;
        job3._endYear = 2015;

        Job job4 = new Job();
        job4._jobTitle = "Sandwich Artist / Manager";
        job4._company = "Subway";
        job4._startYear = 2014;
        job4._endYear = 2015;

        Job job5 = new Job();
        job5._jobTitle = "Solar Proposal Specialist";
        job5._company = "Clear Solar";
        job5._startYear = 2015;
        job5._endYear = 2016;

        Job job6 = new Job();
        job6._jobTitle = "Jr. Salesforce administrator";
        job6._company = "Clear Solar";
        job6._startYear = 2016;
        job6._endYear = 2017;

        Job job7 = new Job();
        job7._jobTitle = "CRM Migrations and System Administrations";
        job7._company = "Solar Installs";
        job7._startYear = 2017;
        job7._endYear = 2017;

        Job job8 = new Job();
        job8._jobTitle = "System Administrator";
        job8._company = "Solcius Solar";
        job8._startYear = 2017;
        job8._endYear = 2018;

        Job job9 = new Job();
        job9._jobTitle = "Jr. Full Stack Developer";
        job9._company = "Solcius Solar";
        job9._startYear = 2018;
        job9._endYear = 2018;

        Job job10 = new Job();
        job10._jobTitle = "Full Stack Developer";
        job10._company = "Solcius Solar";
        job10._startYear = 2018;
        job10._endYear = 2019;

        Job job11 = new Job();
        job11._jobTitle = "Manager of Software Development";
        job11._company = "Solcius Solar";
        job11._startYear = 2019;
        job11._endYear = 2022;

        Job job12 = new Job();
        job12._jobTitle = "Salesforce Developer";
        job12._company = "Jolt";
        job12._startYear = 2022;
        job12._endYear = 2023;


        Resume r = new Resume();
        r._name = "Aaron Webster";
        r._jobs = new List<Job>();
        r._jobs.Add(job1);
        r._jobs.Add(job2);
        r._jobs.Add(job3);
        r._jobs.Add(job4);
        r._jobs.Add(job5);
        r._jobs.Add(job6);
        r._jobs.Add(job7);
        r._jobs.Add(job8);
        r._jobs.Add(job9);
        r._jobs.Add(job10);
        r._jobs.Add(job11);
        r._jobs.Add(job12);
        
        r.Display();
    }
}