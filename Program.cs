//Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}
int number1;
int number2;
number1 = Prompt("Введите первое число ");
number2 = Prompt("Введите второе число ");
if (number1 > number2){
    System.Console.WriteLine(number1);
}
else{
System.Console.WriteLine(number2);
}


//Напишите программу, которая принимает на вход три числа и выдаёт 
//максимальное из этих чисел.

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}
int number1;
int number2;
int number3;
number1 = Prompt("Введите первое число ");
number2 = Prompt("Введите второе число ");
number3 = Prompt("Введите третье число ");

int max = number1;
if (number1 > max) max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;

System.Console.WriteLine(max);



//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}
int number;
number = Prompt("Введите число ");
int evennumber = number % 2;
if (evennumber == 0){
    System.Console.WriteLine("Число четное");
}
else{
    System.Console.WriteLine("Число нечетное");
}


//Напишите программу, которая на вход принимает число (N),
 //а на выходе показывает все чётные числа от 1 до N.

 int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}
int N;
N = Prompt("Введите число N ");

for (int i = 2; i <= N; i=i+2)
{
 System.Console.WriteLine(i);
}

