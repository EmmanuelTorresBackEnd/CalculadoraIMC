using System;
using Xunit;

namespace XUnitTest
{
    public class Operacoes
    {
        public static double Calculo(double peso, double altura)
        {
            return (peso / (altura * altura));
        }

    }
    public class XUnitTest
    {
        //Arrange -- Organizar

        public double peso = 75;
        public double altura = 1.84;

        [Fact]
        public string Calculo_NotInRange()
        {

            //Act -- Agir

            var resultado = Operacoes.Calculo(peso, altura);

            //Assert -- Verificar

            Assert.NotInRange(resultado, 0, 999);
            return ("Dados Invalidos");


        }

        [Fact]
        public string Calculo_Magreza()
        {
            //Act -- Agir

            var resultado = Operacoes.Calculo(peso, altura);

            //Assert -- Verificar

            Assert.InRange(resultado, 0, 18.4);
            return ("Magreza");

        }

        [Fact]
        public string Calculo_Normal()
        {
            //Act -- Agir

            var resultado = Operacoes.Calculo(peso, altura);

            //Assert -- Verificar

            Assert.InRange(resultado, 18.5, 24.9);
            return ("Peso Normal");

        }

        [Fact]
        public string Calculo_Sobrepeso()
        {
            //Act -- Agir

            var resultado = Operacoes.Calculo(peso, altura);

            //Assert -- Verificar

            Assert.InRange(resultado, 25, 29.9);
            return ("Sobrepeso");

        }

        [Fact]
        public string Calculo_Obesidade()
        {
            //Act -- Agir

            var resultado = Operacoes.Calculo(peso, altura);

            //Assert -- Verificar

            Assert.InRange(resultado, 30, 34.9);
            return ("Grau de Obesidade I");

        }

        [Fact]
        public string Calculo_Obesidade_II()
        {
            //Act -- Agir

            var resultado = Operacoes.Calculo(peso, altura);

            //Assert -- Verificar

            Assert.InRange(resultado, 35, 39.9);
            return ("Grau de Obesidade II");

        }

        [Fact]
        public string Calculo_Obesidade_III()
        {
            //Act -- Agir

            var resultado = Operacoes.Calculo(peso, altura);

            //Assert -- Verificar

            Assert.InRange(resultado, 40, 999);
            return ("Grau de Obesidade III");

        }
    }
}
