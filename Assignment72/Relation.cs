namespace Assignment72
{
    public class Relation:Expression
    {
        public enum Opcode { Less,LessEq,Greater,GreaterEq,Equal,NotEq,None }

        private Opcode _op;


        //#TODO : DELETE
        public Relation()
        {
        }

        public Relation(Opcode op, Expression left, Expression right)
        {
            _op = op;
            _left = left;
            _right = right;
        }

        public Opcode Op
        {
            get { return _op; }
            set { _op = value; }
        }
        
    }
}