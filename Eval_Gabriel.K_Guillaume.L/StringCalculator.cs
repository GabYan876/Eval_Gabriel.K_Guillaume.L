namespace Eval_Gabriel.K_Guillaume.L
{
    public class StringCalculator
    {
        public static int Parse(string input)
        {
            input = input.Replace(" ", "");
            var data = input.Split(',');

            int sum = 0;

            for (int i = 0; i < data.Length; i++)
            {
                int num = int.Parse(data[i]);
                if (num < 0)
                {
                    throw new ExceptionNombresNegatifs(num, i + 1);
                }
                sum += num;
            }

            return sum;
        }

    }
}
