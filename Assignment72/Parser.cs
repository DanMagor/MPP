﻿using System;

namespace Assignment72
{
    public class Parser
    {
        private string input;
        private int _currentChar;

        public Parser(string s)
        {
            input = s;
            _currentChar = 0;
        }

        public Expression Parse()
        {
            return ParseLogical();
        }

        private Expression ParseLogical()
        {
            Expression result = ParseRelation();

            Logical.Opcode op = ParseLogOperator();
            if (op != Logical.Opcode.None)
            {
                Expression right = ParseRelation();
                result = new Logical(op, result, right);
            }

            
            return result;
        }

        private Logical.Opcode ParseLogOperator()
        {
            if (_currentChar >= input.Length) return Logical.Opcode.None;
            switch (input[_currentChar])
            {
                case 'a':
                    return (input[_currentChar + 1] == 'n' && input[_currentChar + 2] == 'd')
                        ? Logical.Opcode.And
                        : Logical.Opcode.None;


                case 'x':
                    return (input[_currentChar + 1] == 'o' && input[_currentChar + 2] == 'r')
                        ? Logical.Opcode.Xor
                        : Logical.Opcode.None;


                case 'o':
                    return input[_currentChar + 1] == 'r' ? Logical.Opcode.Or : Logical.Opcode.None;
                default: return Logical.Opcode.None;
            }
        }

        private Expression ParseRelation()
        {
            var result = ParseTerm();

            var op = ParseRelationOperator();
            if (op == Relation.Opcode.None) return result;
            var right = ParseTerm();
            result = new Relation(op, result, right);

            return result;
        }

        private Relation.Opcode ParseRelationOperator()
        {
            if (_currentChar >= input.Length) return Relation.Opcode.None;
            switch (input[_currentChar])
            {
                case '<':
                    _currentChar++;
                    return input[_currentChar + 1] == '=' ? Relation.Opcode.LessEq : Relation.Opcode.Less;
                case '>':
                    _currentChar++;
                    return input[_currentChar + 1] == '=' ? Relation.Opcode.GreaterEq : Relation.Opcode.Greater;

                case '=':
                    _currentChar++;
                    return Relation.Opcode.Equal;
                case '!':
                    return input[_currentChar + 1] == '=' ? Relation.Opcode.NotEq : Relation.Opcode.None;
                default: return Relation.Opcode.None;
            }
        }

        private Expression ParseTerm()
        {
            var result = ParseFactor();

            var op = ParseTermOperator();
            if (op == Term.Opcode.None) return result;
            var right = ParseFactor();
            result = new Term(op, result, right);

            return result;
        }

        private Term.Opcode ParseTermOperator()
        {
            if (_currentChar >= input.Length) return Term.Opcode.None;
            switch (input[_currentChar])
            {
                case '+':
                    _currentChar++;
                    return Term.Opcode.Plus;
                case '-':
                    _currentChar++;
                    return Term.Opcode.Minus;
                default: return Term.Opcode.None;
            }
        }

        private Expression ParseFactor()
        {
            var result = ParsePrimary();

            var op = ParseFactorOperator();
            if (op != Factor.Opcode.None)
            {
                var right = ParsePrimary();
                result = new Factor(op, result, right);
            }

            return result;
        }

        private Factor.Opcode ParseFactorOperator()
        {
            if (_currentChar >= input.Length) return Factor.Opcode.None;
            switch (input[_currentChar])
            {
                case '*':
                    _currentChar++;
                    return Factor.Opcode.Multiply;
                case '/':
                    _currentChar++;
                    return Factor.Opcode.Division;
                default:
                    return Factor.Opcode.None;
            }
        }

        private Expression ParsePrimary()
        {
            Expression result = null;


            if (_currentChar < input.Length && char.IsDigit(input[_currentChar]))
                result = ParseInteger();
            else if (input[_currentChar] == '(')
            {
                _currentChar++;
                result = Parse();
                _currentChar++; // skip ‘)’
            }
            else
            {
                throw new Exception("Invalid input");
            }

            
            return result;
        }

        private Integer ParseInteger()
        {
            var temp = "";
            while (_currentChar < input.Length && char.IsDigit(input[_currentChar]))
            {
                temp += input[_currentChar];
                _currentChar++;
            }

            try
            {
                return new Integer(Convert.ToInt64(temp));
            }
            catch (Exception e)
            {
                Console.WriteLine("Convertation Exception!");
                throw;
            }
        }
    }
}