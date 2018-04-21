using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        
        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (txtNum1.Text == "" || txtNum2.Text == "")
            {
                lblResultado.Text = "Preencha as duas caixas!";
            }
            else {
                double num1 = System.Convert.ToDouble(txtNum1.Text);
                double num2 = System.Convert.ToDouble(txtNum2.Text);

                if (rbSoma.Checked == true)
                {
                    lblResultado.Text = num1 + num2 + "";
                }

                if (rbSubtracao.Checked == true)
                {
                    lblResultado.Text = num1 - num2 + "";
                }

                if (rbMultiplicacao.Checked == true)
                {
                    lblResultado.Text = num1 * num2 + "";
                }

                if (rbDivisao.Checked == true)
                {
                    lblResultado.Text = num1 / num2 + "";
                }
            }
        }
    }
}
