using Validation;

var regexp = @"^[0-9]+$";

var str = "sdfsdfgsdd 54154sdfgsdgf 54154 asdgfasdgf";
var numbers = "123123123";

var result = str.Validation(regexp);
Console.WriteLine($"{str} -> valid : {result}");

result = numbers.Validation(regexp);
Console.WriteLine($"{numbers} -> valid : {result}");

PrintValid(numbers, s => s.Validation(regexp));
PrintValid(str, s => s.Validation(regexp));

PrintValid(numbers, str.Validation);
PrintValid(numbers, numbers.Validation);
return;

void PrintValid(string str, Predicate<string> predicate)
{
    if (predicate.Invoke(str))
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{str} is valid");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{str} is not valid");
    }
    Console.ResetColor();
}