using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Dive;

namespace _Dive
{
    public class DivingService
    {
        public DivingService()
        {
            
        }

        public int MultiplyPositions(string[] listOfOperations)
        {
            var horizontalPosition = 0;
            var depth = 0;
                var humanInterface = new DivingInstructionHumanInterface();
                var divingController = new DivingController();

            foreach (string operation in listOfOperations)
            {
                var commandPrefix = operation.Substring(0, operation.Count() - 1).Trim();
                switch (commandPrefix)
                {
                    case DivingInstructionHumanInterface._forward:
                        horizontalPosition = divingController.AddForward(humanInterface.ReturnForwardPosition(operation));
                            break;
                       
                    default:
                        depth = divingController.UpDown(humanInterface.ReturnUpDownValue(operation));
                        break;
                }
            }

            return horizontalPosition * depth;
        }
        
    }
}

