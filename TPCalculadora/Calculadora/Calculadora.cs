using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculadora
    {
        /// <summary>
        /// Realiza la operacion indicada entre dos numeros, retorna el resultado de dicha operacion.
        /// Si no se puede operar, division por cero, retornara cero.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public double operar(Numero numero1, Numero numero2, string operador)
        {
            double result = 0;
            double n1;
            double n2;

            operador = validarOperador(operador);
            n1 = numero1.getNumero();
            n2 = numero2.getNumero();

            switch (operador)
            {
                case "+":
                    result = n1 + n2;
                    break;

                case "-":
                    result = n1 - n2;
                    break;

                case "*":
                    result = n1 * n2;
                    break;

                case "/":
                    if (n2 != 0)
                    {
                        result = n1 / n2;
                    }
                    break;
            }
            return result;
     }

        /// <summary>
        /// Valida el operador si es alguno de los validos, caso contrario toma por defecto la suma.
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static string validarOperador(string operador)
        {
            string resultado = operador;

            if (operador != "+" && operador != "-" && operador != "*" && operador != "/")
            {
                resultado = "+";
            }
            return resultado;
        }
    }
}
