namespace Eval_Gabriel.K_Guillaume.L.Test
{
    public class StringCalculatorTest
    {
        [Fact]
        public void StringEstEgalAUn()
        {

            //ETANT DONNE un string "1"
            const string input = "1";

            //QUAND on utilise la methode Parse
            var result = StringCalculator.Parse(input);

            //ALORS le string "1" devient l'int 1
            Assert.Equal(1, result);
        }
    }
}