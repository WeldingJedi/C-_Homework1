// TASK #2: Max from 2 numbers.

void Task2()    // Simple solution by task conditions
{
    int a = 2;
    int b = 7;

    if (a <= b)
        Console.WriteLine(b);
    else
        Console.WriteLine(a);
}

void Task2_1()  // Elegant solution with universal data entering
{
    Console.WriteLine("Enter first integer: ");
    int int1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second integer: ");
    int int2 = Convert.ToInt32(Console.ReadLine());
        if (int1 <= int2)
            Console.WriteLine("Max entered integer is: " + int2);
        else
            Console.WriteLine("Max entered integer is: " + int1);
}
//---------------------------------------------------------------------------//

// TASK #4: Max from 3 numbers.

void Task4()    // Solution with universal data entering based on Task2_1
{
    Console.WriteLine("Enter first integer: ");
    int int1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second integer: ");
    int int2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter third integer: ");
    int int3 = Convert.ToInt32(Console.ReadLine());
        if (int1 > int2)
        {
            if (int1 > int3)
                Console.WriteLine("Max entered integer is: " + int1);
        else if (int2 > int3)
            Console.WriteLine("Max entered integer is: " + int2);
        }
        else
            Console.WriteLine("Max entered integer is: " + int3);
}        
//---------------------------------------------------------------------------//

// TASK #6: Even number determination.

void Task6()    // Simple solution based on division without remainder
{
    Console.WriteLine("Enter number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int result = num % 2;
    if (result == 0)
        Console.WriteLine("Entered number is even");
    else
        Console.WriteLine("Entered number is odd");
}
//---------------------------------------------------------------------------//

// TASK #8: Even numbers from 1 to the entered number N.

void Task8()    // Simple solution based on Task6
{
    Console.WriteLine("Enter number: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int start = 1;
    int check;
    if (N <= 1)
        Console.WriteLine("Please, try again");
    else
    {
        while (start <= N)
        {   
            check = start % 2;     
            if (check == 0)
            {
                Console.Write(start + " ");
                start++;
            }
            else
            {
                start++;
            }
        }
        Console.WriteLine();
    }
}
//---------------------------------------------------------------------------//

// TASK #2: Task2() and Task2_1()
// TASK #4: Task4()
// TASK #6: Task6()
// TASK #8: Task8()
// Please, enter the name of the function above to check the works:
