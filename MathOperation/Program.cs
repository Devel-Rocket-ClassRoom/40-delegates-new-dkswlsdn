using System;

MathOp mathOp = Add;

Console.WriteLine("=== 사칙연산 대리자 ===");

Console.WriteLine($"\n[덧셈]\n20 + 4 = {mathOp(20, 4)}");
mathOp = Subtract;

Console.WriteLine($"\n[뺄셈]\n20 - 4 = {mathOp(20, 4)}");
mathOp = Multiply;

Console.WriteLine($"\n[곱셈]\n20 * 4 = {mathOp(20, 4)}");
mathOp = Divide;

Console.WriteLine($"\n[나눗셈]\n20 / 4 = {mathOp(20, 4)}");

int Add(int a, int b) => a + b;
int Subtract(int a, int b) => a - b;
int Multiply(int a, int b) => a * b;
int Divide(int a, int b) => a / b;

delegate int MathOp(int a, int b);