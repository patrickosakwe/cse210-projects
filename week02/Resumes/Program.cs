using System;
using System.Threading.Tasks.Dataflow;

public class Resume
{
    public string _name;

    //initialize the list to a new List before you use it.
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        //The use of the custom data type "Job" in this loop
        foreach (Job job in _jobs)
        {
            //Display method on each job
            job.Display();
        }
    }
}

