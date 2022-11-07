
using COR_project.ConcreetHandlers;
using COR_project;

public class Program
{
    public static void Main(string[] args)
    {
        // Setup Chain of Responsibility
        AbstractApprover Dia_Richad = new Director();
        AbstractApprover Vich_Pris  = new VicePresident();
        AbstractApprover Peter      = new President();

        Dia_Richad.SetNext(Vich_Pris).SetNext(Peter);

        // Generate and process purchase requests
        Purchase p = new Purchase(2034, 350.00, "Supplies");
        Console.WriteLine(   Dia_Richad.Handle(p));
        p = new Purchase(2035, 32590.10, "Project X");
        Console.WriteLine(Dia_Richad.Handle(p));
        p = new Purchase(2036, 122100.00, "Project Y");
        Console.WriteLine(Dia_Richad.Handle(p));
        // Wait for user
        Console.ReadKey();
    }
}