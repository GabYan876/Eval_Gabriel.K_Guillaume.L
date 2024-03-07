using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Eval_Gabriel.K_Guillaume.L.Test
{
    public class StringCalculatorTest
    {

        [Theory]
        [InlineData("1, 0")]
        [InlineData("2, 0")]
        [InlineData("1, 2")]
        [InlineData("1,3")]
        [InlineData("0123,34866532")]

        public void CasXPlusY(string parts)
        {
            //ETANT DONNE un string "x,y"
            //QUAND on utilise la methode Parse
            var input = string.Join(',', parts);
            var result = StringCalculator.Parse(input);

            var data = input.Split(',');

            var attendu = int.Parse(data.First()) + int.Parse(data.Last());
            //ALORS le string "x,y" devient l'int x+y
            Assert.Equal(attendu, result);
        }
    }
}