using System;


Action<string> action = PrintOriginal;

Console.WriteLine("=== 문자열 처리 파이프라인 ===");

Console.WriteLine("\n--- 단계 1: 원본 출력만 ---");

action("Hello World");

Console.WriteLine("\n--- 단계 2: 대문자 추가 ---");

action += PrintUpper;
action("Hello World");

Console.WriteLine("\n--- 단계 3: 소문자, 길이 추가 ---");

action += PrintLower;
action += PrintLength;
action("Hello World");

Console.WriteLine("\n--- 단계 4: 대문자 제거 ---");

action -= PrintUpper;
action("Hello World");





void PrintOriginal(string str) => Console.WriteLine($"원본: {str}");

void PrintUpper(string str) => Console.WriteLine($"대문자: {str.ToUpper()}");

void PrintLower(string str) => Console.WriteLine($"소문자: {str.ToLower()}");

void PrintLength(string str) => Console.WriteLine($"길이: {str.Length}");







