using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculadora
    {
        // Realiza la operación indicada entre dos números, retorna el resultado numerico de dicha operación.
        public double operar(Numero numero1, Numero numero2, string operador)
        {
            double result = 0;

            string operadorUsar = validarOperador(operador);

            switch (operadorUsar)
            {
                case "+":
                    result = numero1.getNumero() + numero2.getNumero();
                    break;

                case "-":
                    result = numero1.getNumero() - numero2.getNumero();
                    break;

                case "*":
                    result = numero1.getNumero() * numero2.getNumero();
                    break;

                case "/":
                    if (numero2.getNumero() != 0)
                    {
                        result = numero1.getNumero() / numero2.getNumero();
                    }
                    break;

            }

            return result;
     }

        // Valida el operador si es alguno de los validos, caso contrario toma por defecto el "+"
        public string validarOperador(string operador)
        {
            string resultado = operador;

            if (operador != "+" &&
                operador != "-" &&
                operador != "*" &&
                operador != "/")
            {
                resultado = "+";
            }

            return resultado;
        }


    }
}
