namespace Eval_Gabriel.K_Guillaume.L.Test
{
    public class StringCalculatorTest
    {
        [Fact]
        public void Test1()
        {
            const string input = "1";

            var result = StringCalculator.Parse(input);

            Assert.Equal(1, result);
        }
    }
}