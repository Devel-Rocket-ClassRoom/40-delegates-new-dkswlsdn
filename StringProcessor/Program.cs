using System;
using System.Linq;


Console.WriteLine("=== 문자열 가공기 ===\n");

Console.WriteLine("[대문자 변환]");
ProcessAndPrint("Hello World", ToUpperCase);

Console.WriteLine("\n[소문자 변환]");
ProcessAndPrint("Hello World", ToLowerCase);

Console.WriteLine("\n[괄호 추가]");
ProcessAndPrint("Hello World", AddBrackets);

Console.WriteLine("\n[문자열 뒤집기]");
ProcessAndPrint("Hello World", Reverse);



void ProcessAndPrint(string input, StringProcessor processor)
{
    Console.WriteLine($"결과: {processor(input)}");
}


string ToUpperCase(string s) => s.ToUpper();
string ToLowerCase(string s) => s.ToLower();
string AddBrackets(string s) => $"[{s}]";
string Reverse(string s)
{
    char[] chars = s.ToCharArray();

    for (int i = 0; i < chars.Length / 2; i++)
    {
        char temp = chars[i];
        chars[i] = chars[chars.Length - i - 1];
        chars[chars.Length - i - 1] = temp;
    }

    return new string(chars);
}

delegate string StringProcessor(string s);