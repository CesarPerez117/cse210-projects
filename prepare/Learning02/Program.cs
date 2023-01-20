using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Security Supervisor";
        job1._company = "City Bank";
        job1._startYear = 2005;
        job1._endYear = 2018;

        Job job2 = new Job();
        job2._jobTitle = "Security Agent";
        job2._company = "Back Of America";
        job2._startYear = 2002;
        job2._endYear = 2005;

        Resume myResume = new Resume();
        myResume._name = "George Rojas";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}