namespace Aufgabe01_Generic_Stack;

class Program
{
    static void Main(string[] args)
    {
        GenericStack<int> iStack = new GenericStack<int>();
        Console.WriteLine("5 Integer auf dem Stapel laden: ");
        iStack.Push(10);
        iStack.Push(20);
        iStack.Push(30);
        iStack.Push(40);
        iStack.Push(50);

        foreach (var item in iStack)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($"\nIst das Element mit der Zahl 40 enthalten: {iStack.Contains(40)}");

        Console.WriteLine("\nFolgende zwei Integer werden vom Stapel genommen: ");

        try
        {
            Console.WriteLine(iStack.Pop());
            Console.WriteLine(iStack.Pop());

        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }

        Console.WriteLine($"\nIst das Element mit der Zahl 40 noch enthalten: {iStack.Contains(40)}");
        Console.WriteLine("________________________________\n\n");
        
        GenericStack<string> sStack = new GenericStack<string>();
        Console.WriteLine("5 Strings auf dem Stapel laden: ");
        sStack.Push("Zehn");
        sStack.Push("Zwanzig");
        sStack.Push("Dreizig");
        sStack.Push("Vierzig");
        sStack.Push("Fühfzig");

        foreach (var item in sStack)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($"\nIst das Element mit dem Text 'Vierzig' enthalten: {sStack.Contains("Vierzig")}");

        Console.WriteLine("\nFolgende zwei Strings werden vom Stapel genommen: ");

        try
        {
            Console.WriteLine(sStack.Pop());
            Console.WriteLine(sStack.Pop());

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        Console.WriteLine($"\nIst das Element mit dem Text 'Vierzig' noch enthalten: {sStack.Contains("Vierzig")}");
        Console.WriteLine("________________________________\n\n");

        GenericStack<Kontakt> kStack = new GenericStack<Kontakt>();
        Console.WriteLine("4 Kontakte auf dem Stapel laden: ");

        kStack.Push(new Kontakt("Hans", 10));
        kStack.Push(new Kontakt("Peter", 20));
        kStack.Push(new Kontakt("Friedhelm", 30));
        kStack.Push(new Kontakt("Wolfgang", 55));


        foreach (var item in kStack)
        {
            Console.WriteLine(item);
        }

        Kontakt a = new Kontakt("Wolfgang", 55);
        Console.WriteLine($"\nIst der Kontakt zu'Wolfgang, 55' enthalten: {kStack.Contains(a)}");

        Console.WriteLine("\nFolgender Kontakt wird vom Stapel genommen: ");

        try
        {
            Console.WriteLine(kStack.Pop());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        Console.WriteLine($"\nIst der Kontakt zu 'Wolfgang, 55' noch enthalten: {kStack.Contains(a)}");
        Console.WriteLine("________________________________\n\n");
    }
}

