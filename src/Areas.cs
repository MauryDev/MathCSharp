using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelApp
{
    public static class Areas
    {
        public enum FormatType
        {
            none,
            m,
            km,
            cm
        }
        public static string Format(BigFloat value, FormatType formatType)
        {
            // 22 m²
            switch (formatType)
            {
                case FormatType.m:
                    return value.ToString() + " m²";
                case FormatType.km:
                    return value.ToString() + " km²";
                case FormatType.cm:
                    return value.ToString() + " cm²";
                default:
                    return value.ToString();
            }
        }
        public static BigFloat Quadrado(BigFloat lado)
        {
            // 2 * 2 = 4;
            return lado * lado;
        }
        public static BigFloat Retângulo(BigFloat comprimento, BigFloat largura)
        {
            // 3 * 2 = 6;
            return comprimento * largura;
        }
        public static BigFloat Triângulo(BigFloat @base, BigFloat altura)
        {
            return (@base * altura) / 2;
        }
        public static BigFloat Losango(BigFloat diagonal_maior, BigFloat diagonal_menor)
        {
            return (diagonal_maior * diagonal_menor) / 2;
        }
        public static BigFloat Trapézio(BigFloat base_maior, BigFloat base_menor,BigFloat altura)
        {
            return ((base_maior + base_menor) / 2) * altura;
        }
        public static BigFloat Polígono_Regular(BigFloat perímetro, BigFloat apótema)
        {
            return (perímetro / 2) * apótema;
        }
        public static BigFloat Círculo(BigFloat raio)
        {
            return new BigFloat(Math.PI) * (raio * raio);
        }
        /// <summary>
        /// superfície da área lateral
        /// </summary>
        public static BigFloat Cone(BigFloat raio,BigFloat geratriz)
        {
            return new BigFloat(Math.PI) * raio * geratriz;
        }
        /// <summary>
        /// superfície esférica
        /// </summary>
        public static BigFloat Esfera(BigFloat raio, BigFloat geratriz)
        {
            return 4.0f * new BigFloat(Math.PI) * (raio * raio);
        }
    }
}
