using Microsoft.VisualStudio.TestTools.UnitTesting;
using _Dive;
using System;

namespace SubmarineGeneralTest;

[TestClass]
public class DivingTest
{
    [TestMethod]
    public void CalulateDiving()
    {
        var divingService = new DivingService();
     var position =   divingService.MultiplyPositions();
        Console.WriteLine(position);
    }
}
