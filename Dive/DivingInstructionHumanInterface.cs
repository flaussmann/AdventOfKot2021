using System;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _Dive
{
    public class DivingInstructionHumanInterface
    {
        public const   string _forward = "forward";
        public const   string _up = "up";
        public const  string _down = "down";


        public int ReturnForwardPosition(string foward)
        {
            var trustValue = int.Parse(foward.Substring(foward.Count() - 1));
            return trustValue;
        }

        public int ReturnUpDownValue(string upDown)
        {
            var upDownNumber = int.Parse(upDown.Substring(upDown.Count() - 1));

            if (upDown.Equals(_up))
                return upDownNumber;

            return upDownNumber * -1;
        }

    }
}

