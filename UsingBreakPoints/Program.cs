

//for (int i = 0; i < 20; i++)
//{
//    Console.WriteLine($"The value of i is { i }");
//    for (int j = 0; j < 10; j++)
//	{
//        Console.WriteLine($"The value of j is { j }");
//    }
//}


//Console.ReadLine();

//Console Application?
//For loop multiplies a number by five and adds it to the total each time?
//Step through code?

int j = 1;

for (int i = 0; i < 10; i++)
{
    j += (j * 5);

    Console.WriteLine($"The value of i is {i}");
    Console.WriteLine($"The value of j is {j}");
}

Console.ReadLine();