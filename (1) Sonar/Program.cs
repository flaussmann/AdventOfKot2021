// See https://aka.ms/new-console-template for more information
using System.IO;
using System.Runtime.CompilerServices;



int? lastValue = null;
int increasedCounter = 0;

List<int> inputList = new();

foreach (string line in System.IO.File.ReadLines(@"Day1Input.txt"))
{
    inputList.Add(int.Parse(line));
}
int index = 0;
foreach (var input in inputList)
{

    var listOf3 = new List<int>();

    try
    {
       listOf3 =  inputList.GetRange(index, 3);
        index++;
    }
    catch (System.ArgumentException)
    {
        break;
    }


    if (lastValue == null)
    {
        lastValue = listOf3.Sum();
        continue;
    }
    var tempValue = listOf3.Sum();
    if (tempValue > lastValue)
        increasedCounter++;

    lastValue = tempValue;

}

Console.WriteLine(increasedCounter);

