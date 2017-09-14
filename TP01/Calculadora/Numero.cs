using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Numero
    {
        
        private double _numero;
                  
        /// <summary>
        /// metodo para la obtención del valor de numero.
        /// </summary>
        /// <returns></returns>
        public double getNumero()
        {
            return _numero;
        }
        
        /// <summary>
        /// constructor de inicializacion del atributo numero en cero.
        /// </summary>
        public Numero()
        {
            _numero = 0;
        }
        
        /// <summary>
        /// constructor que recibe un double y carga el numero.
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this._numero = numero; 
        }

        /// <summary>
        /// constructor que recibe un string que validara y cargara un numero.
        /// </summary>
        /// <param name="numero"></param>
        public Numero(string numero)
        {
           setNumero(numero);
        }
        
        /// <summary>
        /// metodo privado del tipo setter, es para setear el valor de numero.
        /// <param name="numero"></param>
        private void setNumero(string numero)
        {
            if (!double.TryParse(numero, out _numero))
            {
                _numero = 0;
            }
        }
        
        /// <summary>
        /// metodo privado valida que sea un double valido y caso contrario retorna un cero.
        /// </summary>
        /// <param name="numeroString"></param>
        /// <returns></returns>
        private double validarNumero(string numeroString)
        {
            double valido;
            bool result;

            result = double.TryParse(numeroString, out valido);

            return valido; 
        }
    }
}
