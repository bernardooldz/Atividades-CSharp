using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPVA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntVerificar_Click(object sender, EventArgs e)
        {
            double fipe, valorFinal;

            fipe = double.Parse(txtFipe.Text);

            if(cmbEstado.SelectedIndex == 0)
            {
                if(rdbCarro.Checked == true)
                {
                    valorFinal = fipe / 100 * 2;
                    txtValorFinal.Text = valorFinal.ToString();
                }
                else if(rdbCaminhonetes.Checked == true || rdbMoto.Checked == true)
                {
                    valorFinal = fipe / 100 * 1;
                    txtValorFinal.Text = valorFinal.ToString();
                }               
            }
            else if (cmbEstado.SelectedIndex == 1 || cmbEstado.SelectedIndex == 4 || cmbEstado.SelectedIndex == 14 || cmbEstado.SelectedIndex == 16)
            {
                if (rdbCarro.Checked == true || rdbCaminhonetes.Checked == true || rdbCaminhonetes.Checked == true)
                {
                    valorFinal = fipe / 100 * 3;
                    txtValorFinal.Text = valorFinal.ToString();
                }
            }
            else if (cmbEstado.SelectedIndex == 2 || cmbEstado.SelectedIndex == 3 || cmbEstado.SelectedIndex == 5 || cmbEstado.SelectedIndex == 17 || cmbEstado.SelectedIndex == 19 || cmbEstado.SelectedIndex == 20 || cmbEstado.SelectedIndex == 21 || cmbEstado.SelectedIndex == 25)
            {
                if (rdbCaminhonetes.Checked == true || rdbCarro.Checked == true)
                {
                    valorFinal = fipe / 100 * 3;
                    txtValorFinal.Text = valorFinal.ToString();
                }
                else if (rdbMoto.Checked == true)
                {
                    valorFinal = fipe / 100 * 2;
                    txtValorFinal.Text = valorFinal.ToString();
                }
            }
            else if (cmbEstado.SelectedIndex == 6)
            {
                if (rdbCarro.Checked == true)
                {
                    valorFinal = fipe / 100 * 4;
                    txtValorFinal.Text = valorFinal.ToString();
                }
                if (rdbCaminhonetes.Checked == true)
                {
                    valorFinal = fipe / 100 * 1;
                    txtValorFinal.Text = valorFinal.ToString();
                }
                else if (rdbMoto.Checked == true)
                {
                    valorFinal = fipe / 100 * 2;
                    txtValorFinal.Text = valorFinal.ToString();
                }
            }
            else if (cmbEstado.SelectedIndex == 7 || cmbEstado.SelectedIndex == 23)
            {
                if (rdbCaminhonetes.Checked == true || rdbCarro.Checked == true)
                {
                    valorFinal = fipe / 100 * 2;
                    txtValorFinal.Text = valorFinal.ToString();
                }
                else if (rdbMoto.Checked == true)
                {
                    valorFinal = fipe / 100 * 1;
                    txtValorFinal.Text = valorFinal.ToString();
                }
            }
            else if (cmbEstado.SelectedIndex == 8)
            {
                if (rdbCarro.Checked == true)
                {
                    valorFinal = fipe / 100 * 4;
                    txtValorFinal.Text = valorFinal.ToString();
                }
                else if (rdbCaminhonetes.Checked == true || rdbMoto.Checked == true)
                {
                    valorFinal = fipe / 100 * 3;
                    txtValorFinal.Text = valorFinal.ToString();
                }
            }
            else if (cmbEstado.SelectedIndex == 9 || cmbEstado.SelectedIndex == 10 || cmbEstado.SelectedIndex == 13)
            {
                if (rdbCaminhonetes.Checked == true || rdbCarro.Checked == true)
                {
                    valorFinal = fipe / 100 * 3;
                    txtValorFinal.Text = valorFinal.ToString();
                }
                else if (rdbMoto.Checked == true)
                {
                    valorFinal = fipe / 100 * 1;
                    txtValorFinal.Text = valorFinal.ToString();
                }
            }
            else if (cmbEstado.SelectedIndex == 11)
            {
                if (rdbCarro.Checked == true)
                {
                    valorFinal = fipe / 100 * 3;
                    txtValorFinal.Text = valorFinal.ToString();
                }
                if (rdbCaminhonetes.Checked == true)
                {
                    valorFinal = fipe / 100 * 4;
                    txtValorFinal.Text = valorFinal.ToString();
                }
                else if (rdbMoto.Checked == true)
                {
                    valorFinal = fipe / 100 * 2;
                    txtValorFinal.Text = valorFinal.ToString();
                }
            }
            else if (cmbEstado.SelectedIndex == 12 || cmbEstado.SelectedIndex == 18)
            {
                if (rdbCarro.Checked == true)
                {
                    valorFinal = fipe / 100 * 4;
                    txtValorFinal.Text = valorFinal.ToString();
                }
                if (rdbCaminhonetes.Checked == true)
                {
                    valorFinal = fipe / 100 * 3;
                    txtValorFinal.Text = valorFinal.ToString();
                }
                else if (rdbMoto.Checked == true)
                {
                    valorFinal = fipe / 100 * 2;
                    txtValorFinal.Text = valorFinal.ToString();
                }
            }
            else if (cmbEstado.SelectedIndex == 15)
            {
                if (rdbCarro.Checked == true || rdbCaminhonetes.Checked == true || rdbCaminhonetes.Checked == true)
                {
                    valorFinal = fipe / 100 * 4;
                    txtValorFinal.Text = valorFinal.ToString();
                }
            }
            else if (cmbEstado.SelectedIndex == 22)
            {
                if (rdbCarro.Checked == true)
                {
                    valorFinal = fipe / 100 * 3;
                    txtValorFinal.Text = valorFinal.ToString();
                }
                else if (rdbCaminhonetes.Checked == true || rdbMoto.Checked == true)
                {
                    valorFinal = fipe / 100 * 2;
                    txtValorFinal.Text = valorFinal.ToString();
                }
            }
            else if (cmbEstado.SelectedIndex == 24)
            {
                if (rdbCarro.Checked == true)
                {
                    valorFinal = fipe / 100 * 4;
                    txtValorFinal.Text = valorFinal.ToString();
                }
                else if (rdbCaminhonetes.Checked == true || rdbMoto.Checked == true)
                {
                    valorFinal = fipe / 100 * 2;
                    txtValorFinal.Text = valorFinal.ToString();
                }
            }
            else if (cmbEstado.SelectedIndex == 26)
            {
                if (rdbCaminhonetes.Checked == true)
                {
                    valorFinal = fipe / 100 * 3;
                    txtValorFinal.Text = valorFinal.ToString();
                }
                else if (rdbCarro.Checked == true || rdbMoto.Checked == true)
                {
                    valorFinal = fipe / 100 * 2;
                    txtValorFinal.Text = valorFinal.ToString();
                }
            }
        }
    }
}
