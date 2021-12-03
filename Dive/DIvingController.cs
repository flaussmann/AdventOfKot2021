using System;

namespace Dive
{
    public class DivingController
    {
        private int _depth = 0;
        private int _aim = 0;
        private int horizontalPosition = 0;

        public int UpDown(int value)
        {
        
                _aim += value;
           
            return _depth;
        }

        public (int horizontalPosition, int depth) AddForward(int value)
        {
            horizontalPosition += value;
            _depth += _aim * value;
            return (horizontalPosition,_depth);
        }
    }
}

