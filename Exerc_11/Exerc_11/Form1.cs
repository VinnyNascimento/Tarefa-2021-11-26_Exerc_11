using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exerc_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calculo s;
            s = new Calculo();
            s.setNum1(double.Parse(txtNum1.Text));
            s.setNum2(double.Parse(txtNum2.Text));
            s.calcular();
            radAbaixo.Checked = s.getAbaixo();
            radIdeal.Checked = s.getIdeal();
            radAcima.Checked = s.getAcima();
            lblResultado.Text = s.getResultado().ToString();
        }
    }
}
