// See https://aka.ms/new-console-template for more information

//Branches(if-statement) and Loops (Conditional Loops Statements)

/*int a = 5;
int b = 3;
int c = 4;

if (a + b > 10)//if statements return true or false
{
    Console.WriteLine("The answer is greater than 10.");
}
else
{
    Console.WriteLine("The answer is not greater than 10.");
}

if ((a + b + c > 10) && (a == b))
{
    Console.WriteLine("The answer is greater than 10.");
    Console.WriteLine("The first number is equal to the second number.");
}
else
{
    Console.WriteLine("The answer is NOT greater than 10.");
    Console.WriteLine("The first number is NOT equal to the second number.");
}


if ((a + b + c > 10) || (a == b)) // one of the both conditions need to be true
{
    Console.WriteLine("The answer is greater than 10.");
    Console.WriteLine("The first number is equal to the second number.");
}
else
{
    Console.WriteLine("The answer is NOT greater than 10.");
    Console.WriteLine("The first number is NOT equal to the second number.");
}

//Using Loops to repeat operations
/*int counter = 0;
while (counter < 10) //condition first before executing the statement
{

  Console.WriteLine($"The counter is {counter}");
  counter++; //counter = counter + 1

}

while (true)   //Ctrl C when its an infinite loop
{

  Console.WriteLine($"The counter is {counter}");
  counter++; //counter = counter + 1

}

do   //statement runs atleast once before checking the condition
{ 

  Console.WriteLine($"The counter is {counter}");
  counter++; //counter = counter + 1

} while (counter < 10);  

for (int index = 0; index < 10; index++)
{
  Console.WriteLine($"The counter is {index}");

}*/

//Combining IF-statements and Loops together

 int sum = 0;

for (int i = 1; i <= 20; i++)
{

    if (i % 3 == 0)
    {
      sum = sum + i;

    }
    
}

 Console.WriteLine($"The sum is {sum}");












