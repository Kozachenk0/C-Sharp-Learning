string operand = "";

for (int num = 0; num <= 100; num++)
{
    if ((num % 3 == 0) && (num % 5 == 0)){
        operand = "- FizzBuzz";
            Console.WriteLine($"{num} {operand}");
    }
    else if(num % 5 == 0)
    {
        operand = "- Buzz";
            Console.WriteLine($"{num} {operand}");
    }
    else if (num % 3 == 0)
    {
        operand = "- Fizz";
            Console.WriteLine($"{num} {operand}");
    }
    else
    {
        Console.WriteLine(num);
    }


        
}
