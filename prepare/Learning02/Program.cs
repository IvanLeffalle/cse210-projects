using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._jobTitle = "IT Help Desk";
        job1._company = "eAssist";
        job1._startYear = "2023";
        job1._endYear = "present";

        Job job2 = new Job();

        job2._jobTitle = "Dental Hygiene Scheduler";
        job2._company = "Reach";
        job2._startYear = "2023";
        job2._endYear = "2023";

        Resume myResume = new Resume();

        myResume._name = "Ivan Leffalle";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.DisplayResume();

    }
}
