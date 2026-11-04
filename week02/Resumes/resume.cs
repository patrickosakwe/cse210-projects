using System;

public class Resume
{
    public string _name;

    // Initialize the list to a new List before you use it.
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // custom data type "Job" in this loop
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}