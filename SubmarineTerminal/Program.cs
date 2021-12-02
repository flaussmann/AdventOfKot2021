// See https://aka.ms/new-console-template for more information
using _Dive;

Console.WriteLine("Hello, World!");
var allLines = System.IO.File.ReadAllLines(@"DivingParameter.txt");
var diveService = new DivingService();
var position  =  diveService.MultiplyPositions(allLines);
Console.WriteLine(position);
