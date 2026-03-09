using System;


{
    Console.WriteLine("\n=================================");

    Calculator calculator = new Calculator();

    Transformer transformer = calculator.Multiply;

    Console.WriteLine(transformer(5));
}

{
    Console.WriteLine("\n=================================");

    CarDriver c = Go;
    c += Left;
    c += Right;

    c();
    Console.WriteLine();

    c -= Left;
    c();

    static void Go() => Console.WriteLine("직진");
    static void Left() => Console.WriteLine("좌회전");
    static void Right() => Console.WriteLine("우회전");
}

{
    Console.WriteLine("\n=================================");

    int[] numbers = { 1, 2, 3, 4, 5 };

    Transform(numbers, Square);

    numbers = new int[]{ 1, 2, 3, 4, 5 };

    Transform(numbers, Cube);


    static void Transform(int[] values, Transformer t)
    {
        for (int i = 0; i < values.Length; i++)
        {
            if (i == 0)
                Console.Write(t(values[i]));
            else
                Console.Write($", {t(values[i])}");
        }
        Console.WriteLine();
    }

    int Square(int i) => i * i;
    int Cube(int i) => i * i * i;
}

delegate int Transformer(int i);
delegate void CarDriver();