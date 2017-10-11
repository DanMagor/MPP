using System.Collections.Generic;

namespace Assignment72
{
    public abstract class Expression
    {
        protected Expression _left, _right;

        protected  long _value;

        
        public Expression Left => _left;

        public Expression Right => _right;
    }
}