using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numero_fibinacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            int cant = int.Parse(txtCantidad.Text);
            int Cbase = 0;
            int resu = 1;
            int tempo;

            for (int i = 0; i < cant; i++) ;
            {
                lblFibinacci.Text = lblFibinacci + Cbase.ToString() + " ,"; //0 1 1 2 3 5 
                tempo = Cbase;// 0 1 1 2 3 5 
                Cbase = Cbase + resu;//1 1 2 3 5
                resu = tempo;//1 1 2 3 5 

            }
        }
    }
}
