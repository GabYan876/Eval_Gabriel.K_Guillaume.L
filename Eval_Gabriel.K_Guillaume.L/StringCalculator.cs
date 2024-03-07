namespace Eval_Gabriel.K_Guillaume.L
{
    public class StringCalculator
    {
        public static int Parse(string input)
        {
            input = input.Replace(" ", "");
            var data = input.Split(',');

            int sum = 0;

            foreach (var str in data)
            {
                int num = int.Parse(str);
                if (num < 0)
                {
                    throw new ArgumentException("Les nombres négatifs ne sont pas autorisés.");
                }
                sum += num;
            }

            return sum;
        }
    }
}
