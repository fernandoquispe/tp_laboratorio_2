﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //declaramos objeto numero
        Numero misNumeros = new Numero();
        Calculadora miCalculadora = new Calculadora();

        //Boton CC, el cual se encarga de limpiar la pantalla de la calculadora
        private void CC_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            lblResultado.Text = string.Empty;
            cmbOperacion.SelectedItem = null;
            cmbOperacion.Text = string.Empty;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Boton igual, con el cual
        private void btnOperar_Click(object sender, EventArgs e)
        {
            Calculadora calculadora = new Calculadora ();

            Numero numero1 = new Numero(txtNumero1.Text);
            Numero numero2 = new Numero(txtNumero2.Text);

            string operador = string.Empty;
            if (cmbOperacion.SelectedItem != null)
            {
                operador = cmbOperacion.SelectedItem.ToString();
            }

            double resultado = calculadora.operar(numero1, numero2, operador);

            lblResultado.Text = resultado.ToString();

        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
