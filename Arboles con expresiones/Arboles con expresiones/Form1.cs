using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arboles_con_expresiones
{
    public partial class Form1 : Form
    {
        private Arbol Arbol1 = new Arbol();
        Nodo expresion;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            char[] arrayChar = txtAgregar.Text.ToCharArray();

            foreach (char character in arrayChar)
            {
                expresion = new Nodo(character.ToString());
                Arbol1.Agregar(expresion);
            }
            Arbol1.ArmarArbol();
        }

        private void btnPreOrd_Click(object sender, EventArgs e)
        {
            txtPreOrder.Text = Arbol1.PreOrder();
        }

        private void btnPostOrd_Click(object sender, EventArgs e)
        {
            txtPostOrder.Text = Arbol1.PostOrder();
        }
    }
}
