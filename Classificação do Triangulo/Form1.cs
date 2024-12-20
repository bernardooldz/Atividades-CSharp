using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            double l1, l2, l3, a1, a2, a3;

            l1 = double.Parse(txtL1.Text);
            l2 = double.Parse(txtL2.Text);
            l3 = double.Parse(txtL3.Text);
            a1 = double.Parse(txtA1.Text);
            a2 = double.Parse(txtA2.Text);
            a3 = double.Parse(txtA3.Text);

            if ((l1 + l2) > l3 && (l2 + l3) > l1 && (l1 + l3) > l2)
            {
                if (l1 != l2 && l2 != l3 && l3 != l1)
                {
                    txtClassLados.Text = ("Triângulo Escaleno");
                }
                else if (l1 == l2 && l2 == l3 && l3 == l1)
                {
                    txtClassLados.Text = ("Triângulo Equilátero");
                }
                else if ((l1 == l2 && l1!= l3) || (l2 == l3 && l2 != l1) || (l3 == l1 && l3 != l2))
                {
                    txtClassLados.Text = ("Triângulo Isóceles");
                }
            }
            else
            {
                MessageBox.Show ("Não é um triângulo");
            }

            
            if(a1 + a2 +a3 == 180)
            {
                if (a1 == 90 || a2 == 90 || a3 == 90)
                {
                    txtClassAngulos.Text = ("Retângulo");
                }

                else if (a1 + a2 + a3 < 90)
                {
                    txtClassAngulos.Text = ("Acutângulo");

                }

                else if (a1 > 90 || a2 > 90 || a3 >90)

                {
                    txtClassAngulos.Text = ("Obtusângulo");
                }
            }
        }
    }
}
