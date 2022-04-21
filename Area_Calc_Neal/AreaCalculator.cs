namespace Area_Calc_Neal
{
    static public class AreaCalculator
    {
        static public double GetSquareArea(int input)
        {
            return MultiplyInts(input);
        }
        static public double? GetSquareArea(string input)
        {
            Dictionary<string, int> stringValues =
            new Dictionary<string, int>();

            stringValues.Add("one", 1);
            stringValues.Add("two", 2);
            stringValues.Add("three", 3);
            stringValues.Add("four", 4);
            stringValues.Add("five", 5);
            stringValues.Add("six", 6);
            stringValues.Add("seven", 7);
            stringValues.Add("eight", 8);
            stringValues.Add("nine", 9);
            stringValues.Add("ten", 10);

            if (stringValues.TryGetValue(input.ToLower(), out int output))
            {
                return MultiplyInts(output);
            }

            return null;
        }
        static public double GetRectangleArea(int one, int two)
        {
            return MultiplyInts(one, two);
        }
        static public double GetTriangleArea(int one, int two)
        {
            return DivideByTwoAndRound((double)one * two);
        }
        static public double GetParallelogramArea(int one, int two)
        {
            return MultiplyInts(one, two);
        }
        static public double GetCircleRadius(int input)
        {
            return DivideByTwoAndRound(input);
        }
        static public double GetCircleDiameter(int one)
        {
            return (double)one * 2;
        }
        static public double MultiplyInts(int input)
        {
            return (double)input * input;
        }
        static public double MultiplyInts(int one, int two)
        {
            return (double)one * two;
        }
        static public double DivideByTwoAndRound(double input)
        {
            return Math.Round((double)input / 2, 2);
        }
    }
}