﻿// See https://aka.ms/new-console-template for more information
var inputs = new List<Int32>() { 3, 5, 6, 7, 13 }; //{ 1, 2, 3, 5, 6, 7, 11 };
List<int> missNumbers = new List<int>();
//List<int> x = new();
int index = 0;
int checkNumber = 0;

do
{
    checkNumber = checkNumber > inputs[index] ? checkNumber : inputs[index];
    if (inputs[index + 1] - checkNumber > 1)
    {
        missNumbers.Add(++checkNumber);

        if (checkNumber == inputs[index + 1])
        {
            index++;
        }
    }
    else
    {
        index++;
    }
} while (index < inputs.Count - 1);

missNumbers.ForEach(m => Console.WriteLine(m));

Console.WriteLine("end");
Console.ReadLine();
