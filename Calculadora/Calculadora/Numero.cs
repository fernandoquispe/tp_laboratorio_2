using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Numero
    {
        //atributo
        private double _numero;


        //metodos
        public double getNumero()
        {
            return _numero;
        }

        //constructor de inicializacion
        public Numero()
        {
            _numero = 0;
        }

        //constructor que recibe un double y carga el numero
        public Numero(double numero)
        {
            this._numero = numero; 
        }

        //constructor que recibe un string que validara y cargara un numero
        public Numero(string numero)
        {
           setNumero(numero);
        }
        
        //metodo privado del tipo setter
        private void setNumero(string numero)
        {
            if (!double.TryParse(numero, out _numero))
            {
                _numero = 0;
            }
        }

        //metodo privado valida que sea un double valido y caso contrario retorna un cero
        private double validarNumero(string numeroString)
        {
            double valido;

            if (!double.TryParse(numeroString, out valido))
            {
                valido = 0;
            }

            return valido; 
        }
    }
}
