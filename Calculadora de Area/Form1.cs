using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_Area
{
    public partial class CalculArea : Form
    {
        public CalculArea()
        {
            InitializeComponent();
        }

        private void rbt_Rectangulo_CheckedChanged(object sender, EventArgs e)
        {
            if(rbt_Rectangulo.Checked)
            {
                txt_Radius.Enabled = false;
                txt_Base.Enabled = true;
                txt_Height.Enabled = true;
            }
                
        }

        private void rbt_Triangulo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_Triangulo.Checked)
            {
                txt_Radius.Enabled = false;
                txt_Base.Enabled = true;
                txt_Height.Enabled = true;
            }
        }
        private void rbt_Circulo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_Circulo.Checked)
            {
                txt_Radius.Enabled = true;
                txt_Base.Enabled = false;
                txt_Height.Enabled = false;
            }
        }
        private void bCalculate_Click(object sender, EventArgs e)
        {
            if (rbt_Rectangulo.Checked)
            {
                if(float.TryParse(txt_Base.Text, out _) && float.TryParse(txt_Height.Text, out _))
                    txt_Area.Text = (float.Parse(txt_Base.Text) * float.Parse(txt_Height.Text)).ToString();
            }

            if (rbt_Triangulo.Checked)
            {
                if (float.TryParse(txt_Base.Text, out _) && float.TryParse(txt_Height.Text, out _))
                    txt_Area.Text = ((float.Parse(txt_Base.Text) * float.Parse(txt_Height.Text)) / 2).ToString();
            }

            if (rbt_Circulo.Checked)
            {
                if (float.TryParse(txt_Radius.Text, out _))
                    txt_Area.Text = (Math.Pow(float.Parse(txt_Radius.Text), 2) * Math.PI).ToString();
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            rbt_Circulo.Checked = false;
            rbt_Rectangulo.Checked = false;
            rbt_Triangulo.Checked = false;

            txt_Area.Text = "";
            txt_Base.Text = "";
            txt_Height.Text = "";
            txt_Radius.Text = "";
        }
    }
}
