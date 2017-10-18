﻿using System;

namespace Assignment8
{
    public class Relation:Expression
    {
        public enum Opcode { Less,LessEq,Greater,GreaterEq,Equal,NotEq,None }

        private Opcode _op;


        

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

        public override long Calculate()
        {
            var left = Left.Calculate();
            var right = Right.Calculate();
            switch (_op)
            {
                case Opcode.Equal: return left == right? 1 : 0;
                case Opcode.Greater: return left > right ? 1 : 0;
                case Opcode.GreaterEq: return left >= right ? 1 : 0;
                case Opcode.Less: return left < right ? 1 : 0;
                case Opcode.LessEq: return left <= right ? 1 : 0;
                case Opcode.NotEq: return left != right ? 1 : 0;
                default:
                    throw new ArgumentOutOfRangeException();
            }
           
        }
    }
}