using System;



Console.WriteLine("\n=================================");

Action action = GoForward;
action += GoLeft;
action += GoRight;

action();

static void GoForward() => Console.WriteLine("직진");
static void GoLeft() => Console.WriteLine("좌회전");
static void GoRight() => Console.WriteLine("우회전");



Console.WriteLine("\n=================================");

Action a = GoForward;
a += GoLeft;
a += () => Console.WriteLine("우회전");

a();

