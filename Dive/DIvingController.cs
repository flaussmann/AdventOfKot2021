using System;

namespace Dive
{
    public class DivingController
    {
        private int _depth = 0;
        private int _trust = 0;

        public int UpDown(int value)
        {
            _depth += value;
            return _depth;
        }

        public int AddForward(int value)
        {
            _trust += value;
            return _trust;
        }
    }
}

