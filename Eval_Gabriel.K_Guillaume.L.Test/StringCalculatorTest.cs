using System.IO;

namespace Eval_Gabriel.K_Guillaume.L.Test
{
    public class StringCalculatorTest
    {

        [Theory]
        [InlineData("1, 0",1)]
        [InlineData("2, 0",2)]
        [InlineData("1, 2",3)]
        [InlineData("1,3",4)]

        public void CasAPlusB(string parts, int attendu)
        {
            //ETANT DONNE un string "1,2"


            //QUAND on utilise la methode Parse
            var input = string.Join(',', parts);

            var result = StringCalculator.Parse(input);

            //ALORS le string "1,2" devient l'int 3
            Assert.Equal(attendu, result);
        }
    }
}