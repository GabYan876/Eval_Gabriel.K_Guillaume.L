namespace Eval_Gabriel.K_Guillaume.L
{
    public class StringCalculator
    {
        public static int Parse(string input)
        {
            var data = input.Split(',');
            int sum = 0;

            foreach (var str in data)
            {
                sum += int.Parse(str);
            }

            return sum;
        }
    }
}
