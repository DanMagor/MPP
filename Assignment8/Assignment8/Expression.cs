using System.Collections.Generic;

namespace Assignment8
{
    public abstract class Expression
    {
        protected Expression _left;
        protected Expression _right;

        public abstract long Calculate();
//        public abstract string ToJson();

        
        public Expression Left => _left;

        public Expression Right => _right;
    }
}