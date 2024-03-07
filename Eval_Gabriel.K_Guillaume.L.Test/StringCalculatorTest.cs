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
        
        [Fact]
        public void StringEstEgalADeux()
        {

            //ETANT DONNE un string "2"
            const string input = "2";

            //QUAND on utilise la methode Parse
            var result = StringCalculator.Parse(input);

            //ALORS le string "1" devient l'int 1
            Assert.Equal(2, result);
        }
        
        [Fact]
        public void StringDeDeuxChiffres()
        {

            //ETANT DONNE un string "1,2"
            const string input = "1,2";

            //QUAND on utilise la methode Parse
            var result = StringCalculator.Parse(input);

            //ALORS le string "1,2" devient l'int 3
            Assert.Equal(3, result);
        }
    }
}