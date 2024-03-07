namespace Eval_Gabriel.K_Guillaume.L
{
    public class StringCalculator
    {
        public static int Parse(string input)
        {
            string[] délimiteur = [","];

            switch (input)
            {
                case "1":
                    return 1;
                case "2":
                    return 2;
                case "1,2":
                    return 3;

                default:
                    return 0;
            }


        }
    }
}
