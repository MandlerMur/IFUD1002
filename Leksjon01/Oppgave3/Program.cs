using System;
public class Input
{
    public int Num1 { get; set; }
    public int Num2 { get; set; }
    public string Operation { get; set; }
    public int Sum { get; set; }

    public Input (int num1, int num2, string calc, int sum)
    {
        Num1 = num1;
        Num2 = num2;
        Operation = calc;
        Sum = sum;
    }

    public void Calculate (Input input)
    {        
        Console.WriteLine($@"Ditt regnestykke: {input.Num1} {input.Operation} {input.Num2} = {input.Sum} " );
    }


}

public class Entrypoint
{
    static void Main()
    {   
        
        int tall1;
        Console.WriteLine("Skriv inn tall1:");
        while (!(Int32.TryParse(Console.ReadLine(), out tall1)))
        {
            Console.Clear();
            Console.WriteLine("Skriv inn tall1:");
        }

        Console.WriteLine("Skriv inn operasjon +-*/: ");
        string operasjon = Console.ReadLine();



        int tall2;
        Console.WriteLine("Skriv inn tall2:");
        while (!(Int32.TryParse(Console.ReadLine(), out tall2)))
        {
            Console.Clear();
            Console.WriteLine("Skriv inn tall2:");
        }

        int sum = 0;

        switch (operasjon)
        {
            case "x":
                sum = tall1 * tall2;
                break;
            case "/":
                sum = tall1 / tall2;
                break;
            case "+":
                sum = tall1 + tall2;
                break;
            case "-":
                sum = tall1 - tall2;
                break;
        }


        Input test = new Input(tall1, tall2, operasjon, sum);

        test.Calculate(test);
      
    }
}






