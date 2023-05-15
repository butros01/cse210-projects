using System;
public class Menu
{
    public string _write = "Write";
    public string _display = "Display";
    public string _save = "Save";
    public string _load = "Load";
    public string _quit = "Quit"; 

    public void Display()
    {
        Console.WriteLine($"Please select one of the following choices:\n1.{_write}\n2.{_display}\n3.{_save}\n4.{_load}\n5.{_quit}\n ");
    }
}