using System;

class BasicCalculation

{

    public static void Main(string[] args)
    {

        Console.WriteLine("Anna kaksi lukua:");

        string usrInput1 = Console.ReadLine();
        string usrInput2 = Console.ReadLine();


        float num1 = float.Parse(usrInput1);
        float num2 = float.Parse(usrInput2);


        float sum = num1 + num2;
        float sub = num1 - num2;
        float prod = num1 * num2;
        float div = num1 / num2;

        Console.WriteLine(num1 + "+" + num2 + "=" + sum);
        Console.WriteLine(num1 + "-" + num2 + "=" + sub);
        Console.WriteLine(num1 + "*" + num2 + "=" + prod);
        Console.WriteLine(num1 + "/" + num2 + "=" + div);

    }
}