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

        [Theory]
        [InlineData("1,2,3")]
        [InlineData("0012,9821,3,4,8")]
        public void CasPeutPrendrePlusDeDeuxEntrees(string inputString)
        {
            // ÉTANT DONNÉ un string "x,y,z"

            // QUAND on utilise la méthode Parse
            int result = StringCalculator.Parse(inputString);

            // ALORS le résultat doit être la somme des valeurs
            int attendu = inputString.Split(',').Select(int.Parse).Sum();
            Assert.Equal(attendu, result);
        }

        [Fact]

        public void CasAvecEspaces()
        {
            //ETANT DONNE un inputString avec des espaces aléatoires
            const string inputString = "1 0, 1 0  ";

            //QUAND on utilise la methode Parse on remplace les espaces par une chaîne vide
            var attendu = StringCalculator.Parse(inputString.Replace(" ", ""));

            var result = StringCalculator.Parse(inputString);

            //ALORS le résultat doit être la somme des valeurs sans prendre en compte les espaces
            Assert.Equal(attendu, result);
        }

        [Fact]
        public void SiCasAvecNombresNegatifsAlorsOnRetourneLesNombresEtLeurPositions()
        {
            //ETANT DONNE un inputString avec un nombre négatif
            const string inputString = "-1,0";

            //ALORS on envoie une exception qui renvoie le nombre et la position
            var exception = Assert.Throws<ExceptionNombresNegatifs>(() => StringCalculator.Parse(inputString));
            Assert.Equal(-1, exception.NombreFautif);
            Assert.Equal(1, exception.Position); 
        }



    }
}