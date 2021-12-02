using System;
using System.Runtime.CompilerServices;
using Dive;

namespace _Dive
{
    public class DivingService
    {
        public DivingService()
        {
            
        }

        public int MultiplyPositions()
        {
            var horizontalPosition = 0;
            var depth = 0;

            foreach (string line in System.IO.File.ReadLines(@"DivingParameter.txt"))
            {
                var humanInterface = new DivingInstructionHumanInterface();
                var divingController = new DivingController();

                switch (line)
                {
                    case DivingInstructionHumanInterface._forward:
                        horizontalPosition = divingController.AddForward(humanInterface.ReturnForwardPosition(line));
                            break;
                       
                    default:
                        depth = divingController.UpDown(humanInterface.ReturnUpDownValue(line));
                        break;
                }
            }

            return horizontalPosition * depth;
        }
        
    }
}

