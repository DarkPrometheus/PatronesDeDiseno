using PatronesDeDiseño.ClasesVarias;
using PatronesDeDiseño.Strategy;

while (true)
{
    MainProgram.Main();
}

class MainProgram
{
    public static void Main()
    {
        InitialMessage();
        try
        {
            switch (Please.AskToUser())
            {
                case 1:
                    Strategy strategy = new();
                    strategy.Menu();
                    break;
                default:
                    Please.WriteWithTop("Mmmmmmm, no, ese numero no esta en la lista");
                    break;
            }
        }
        catch (FormatException)
        {
            Console.Clear();
            Please.WriteWithTop("Hey, esperaba un numero");
        }
        catch (Exception ex)
        {
            Please.WriteExteption(ex);
        }
        Please.WriteLine("Presiona una tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
    }

    static void InitialMessage()
    {
        Please.WriteWithTop("Selecciona un patron");
        Please.WriteLine("1. Strategy");
        Please.GiveMePadding();
    }
}