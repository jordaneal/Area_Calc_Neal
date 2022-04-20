using System.Collections.Generic;

namespace Area_Calc_Neal
{
    public class AreaCalculator
    {
        public double GetSquareArea(int input)
        {
            return MultiplyInts(input);
        }
        public double GetSquareArea(string input)
        {
            string[] nums =
            {
                "one", "two", "three", "four", "five", "six", 
                "seven", "eight", "nine", "ten"
            };

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == input.ToLower())
                {
                    return MultiplyInts(i + 1);
                }
            }

            // lower maintainability as the price of higher complexity
            //Dictionary<string, int> stringValues =
            //new Dictionary<string, int>();
            //stringValues.Add("one",     1);
            //stringValues.Add("two",     2);
            //stringValues.Add("three",   3);
            //stringValues.Add("four",    4);
            //stringValues.Add("five",    5);
            //stringValues.Add("six",     6);
            //stringValues.Add("seven",   7);
            //stringValues.Add("eight",   8);
            //stringValues.Add("nine",    9);
            //stringValues.Add("ten",     10);

            //if (stringValues.TryGetValue(input, out int output))
            //{
            //    return MultiplyInts(output);
            //}

            return -1;
        }
        public double GetRectangleArea(int one, int two)
        {
            return MultiplyInts(one, two);
        }
        public double GetTriangleArea(int one, int two)
        {
            return DivideByTwoAndRound((double)one * two);
        }
        public double GetParallelogramArea(int one, int two)
        {
            return MultiplyInts(one, two);
        }
        public double GetCircleRadius(int input)
        {
            return DivideByTwoAndRound(input);
        }
        public double GetCircleDiameter(int one)
        {
            return (double)one * 2;
        }
        public double MultiplyInts(int input)
        {
            return (double)input * input;
        }
        public double MultiplyInts(int one, int two)
        {
            return (double)one * two;
        }
        public double DivideByTwoAndRound(double input)
        {
            return Math.Round((double)input / 2, 2);
        }
    }
}