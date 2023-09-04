// generics add compile time checking

// the most common form of generics is the list:
var intList = new List<int>();
intList.Add(1);
//intList.Add("string");
// here we are saying we want a list but it only has integers in it


// we can create a new clock with a printer
var analogueClock = new Clock<AnaloguePrinter>();
var romanClock = new Clock<Sundial>();

// uses the analogue printer to print the time
Console.WriteLine(analogueClock.PrintTime());

// uses the sundial to print the time
Console.WriteLine(romanClock.PrintTime());

// We can use generics pass certain types into methods:
PrintType<int>(1);
PrintType<string>("One");


void PrintType<T>(T item)
{
    Console.WriteLine(item);
}

//we can set restrictions on what type we want the generic class to be:
public class Clock<T> where T : Printer, new()
{
    private T _printer;

    public Clock()
    {
        _printer = new T();
    }
    
    public string PrintTime()
    {
        return _printer.Print();
    }
}

public abstract class Printer
{
    public abstract string Print();
}

public class AnaloguePrinter: Printer
{
    public override string Print()
    {
        return "12:26";
    }
}

public class Sundial: Printer
{
    public override string Print()
    {
        return "IVVI";
    }
}