using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrzalNaPlus
{
    internal class ValuesGenerator
    {
        private List<MathOperation> mathOperations;

        private List<char> availableOperators;

        public ValuesGenerator(int difficulty)
        {
            availableOperators = new List<char>();

            switch (difficulty)
            {
                case 0:
                    availableOperators.Add('+');
                    availableOperators.Add('-');
                    break;
                case 1:
                    availableOperators.Add('+');
                    availableOperators.Add('-');
                    availableOperators.Add('*');
                    break;
                case 2:
                    availableOperators.Add('+');
                    availableOperators.Add('-');
                    availableOperators.Add('*');
                    availableOperators.Add('/');
                    break;
            }

            mathOperations = new List<MathOperation>(MainMenu.GetDeffendersCount());
        }

        public MathOperation GetOperation(int id)
        {
            return mathOperations[id];
        }

        public void GenerateValues()
        {
            for (int i = 0; i < MainMenu.GetDeffendersCount(); i++)
            {
                int a = GetRandomValue(0, 10);
                int b = GetRandomValue(0, 10);
                char op;

                do
                {
                    op = availableOperators[GetRandomValue(0, availableOperators.Count)];

                } while ((mathOperations.Find(o => o.GetOperator() == op) != null) && MainMenu.Difficulty != 2);


                if (op == '/')
                {
                    do
                    {
                        a = GetRandomValue(1, 100);
                        b = GetRandomValue(1, 10);
                    } while (a % b != 0);
                }

                var tmp = new MathOperation(a, b, op);
                mathOperations.Add(tmp);
            }
        }

        public int GetRandomValue(int min, int max)
        {
            System.Threading.Thread.Sleep(10);
            var r = new Random();
            
            return r.Next(min, max);
        } 
    }

    public class MathOperation
    {
        private int answer;
        private int a, b;
        private char _operator;

        public MathOperation(int a, int b, char op)
        {
            this.a = a;
            this.b = b;
            _operator = op;

            switch (op)
            {
                case '+':
                    answer = a + b;
                    break;
                case '-':
                    answer = a - b;
                    break;
                case '*':
                    answer = a * b;
                    break;
                case '/':
                    answer = a / b;
                    break;
            }
        }
        public char GetOperator()
        {
            return _operator;
        }

        public int GetAnswer()
        {
            return answer;
        }

        public string GetOperationAsText()
        {
            return a.ToString() + " " +_operator + " " + b.ToString();
        }
    }

}
