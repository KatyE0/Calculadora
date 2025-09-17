using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    internal class Operaciones
    {
        //Atributos
        private double resultado = 0.0;
        private String resultadoString = "";

        //Métodos
            //Suma
        public string Suma(double x, double y)
        {
            double resultado = x + y;
            resultadoString = resultado.ToString();
            return resultadoString;
        }
            //Resta
        public string Resta(double x, double y)
        {
            double resultado = x - y;
            resultadoString = resultado.ToString();
            return resultadoString;
        }
            //Multiplicación
        public string Multi(double x, double y)
        {
            double resultado = x * y;
            resultadoString = resultado.ToString();
            return resultadoString;
        }
            //División
        public String Division(double x, double y)
        {
            if (y == 0)
            {
                return "Error! :(";
            }
            else
            {
                double resultado = x / y;
                resultadoString = resultado.ToString();
                return resultadoString;
            }
        }
    }
}
