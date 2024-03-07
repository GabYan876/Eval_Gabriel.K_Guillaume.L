namespace Eval_Gabriel.K_Guillaume.L
{
    public class StringCalculator
    {
        public static int Parse(string input)
        {
            var data = input.Split(',');

            return int.Parse(data.First()) + int.Parse(data.Last());
        }
    }
}
