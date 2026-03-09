using System;
using System.Reflection;
using System.Security.Cryptography;

{
    Console.WriteLine("\n=================================");

    SayDalagate hello = Hello;

    hello();
    hello.Invoke();

    static void Hello() => Console.WriteLine("Hello Delegate");
}

{
    Console.WriteLine("\n=================================");

    static void Hi() => Console.WriteLine("안녕하세요");

    SayDalagate hi = Hi;
    hi();
    new SayDalagate(Hi).Invoke();
}

{
    Console.WriteLine("\n=================================");

    GetAreaDelegate area = GetArea;

    Console.WriteLine(area.Invoke(10));
    Console.WriteLine(area(10));

    static double GetArea(int r) => 3.14 * r * r;
}

{
    Console.WriteLine("\n=================================");

    MathOperation math = Math.Pow;

    Console.WriteLine(math(2, 10));
}

{
    Console.WriteLine("\n=================================");

    Transformer t = Calculator.Square;

    Console.WriteLine(t(5));
}

{
    Console.WriteLine("\n=================================");

    ProgressReporter progress = WriteToConsole;
    progress += WriteToFile;

    for (int i = 0; i <= 100; i += 25)
    {
        progress(i);
        Console.WriteLine();
    }

    static void WriteToConsole(int percent) => Console.WriteLine($"진행률: {percent}");
    static void WriteToFile(int percent) => Console.WriteLine($"[파일 기록] {percent}%");
}

{
    Console.WriteLine("\n=================================");

    RunnerCall(Go);
    Console.WriteLine();
    RunnerCall(Back);

    static void Go() => Console.WriteLine("직진");
    static void Back() => Console.WriteLine("후진");

    static void RunnerCall(Runner runner)
    {
        Console.WriteLine($"=== 실행 시작 ===");
        runner();
        Console.WriteLine("=== 실행 종료 ===");
    }
}

{
    Console.WriteLine("\n=================================");

    Action action = () => Console.WriteLine("안녕하세요!");
    action();

    Action<string> action1 = (msg) => Console.WriteLine(msg);
    action1("Hello, Action!");

    Action<string, int> action2 = (msg, count) =>
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(msg);
        }
    };
    action2("반복", 3);
}

{
    Console.WriteLine("\n=================================");

    Func<int> func1 = () => 42;
    Console.WriteLine(func1());

    Func<int, int> func2 = (i) => i * i;
    Console.WriteLine(func2(5));

    Func<int, int, int> func3 = (i, j) => i + j;
    Console.WriteLine(func3(3, 7));

    Func<int, int, string> func4 = (i, j) => (i + j).ToString();
    Console.WriteLine(func4(2, 6));
}

{
    Console.WriteLine("\n=================================");

    Predicate<int> predicate1 = (i) => i % 2 == 0;
    Predicate<int> predicate2 = (i) => i > 0;

    Console.WriteLine(predicate1(4));
    Console.WriteLine(predicate1(7));
    Console.WriteLine(predicate2(5));
    Console.WriteLine(predicate2(-3));
}

{
    Console.WriteLine("\n=================================");

    SayDalagate sayDalagate = () => Console.WriteLine("반갑습니다");
    sayDalagate();
}

delegate void SayDalagate();
delegate double GetAreaDelegate(int i);
delegate double MathOperation(double a, double b);
delegate int Transformer(int i);
delegate void ProgressReporter(int i);
delegate void Runner();
delegate void SayDelegate();