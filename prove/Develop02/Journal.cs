using System;

public class Journal
{
    // Make sure to initialize your list to a new List before you use it.
    public List<Entry> _entries = new List<Entry>();

    public void Display()
    {
        // Notice the use of the custom data type "Job" in this loop
        foreach (Entry entry in _entries)
        {
            // This calls the Display method on each job
            entry.Display();
        }
    }
}