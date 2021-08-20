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
            //txt_Radius.Enable = (rbt_Circulo.Checked)?false:true;

            if(rbt_Rectangle.Checked)
            {
                txt_Radius.Enabled = false;
                txt_Base.Enabled = true;
                txt_Height.Enabled = true;
            }
        }
        private void rbt_Triangulo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_Triangle.Checked)
            {
                txt_Radius.Enabled = false;
                txt_Base.Enabled = true;
                txt_Height.Enabled = true;
            }
        }
        private void rbt_Circulo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_Circle.Checked)
            {
                txt_Radius.Enabled = true;
                txt_Base.Enabled = false;
                txt_Height.Enabled = false;
            }
        }
        private void bCalculate_Click(object sender, EventArgs e)
        {
            if (rbt_Rectangle.Checked)
            {
                if(float.TryParse(txt_Base.Text, out _) && float.TryParse(txt_Height.Text, out _))
                    txt_Area.Text = (float.Parse(txt_Base.Text) * float.Parse(txt_Height.Text)).ToString();
            }

            if (rbt_Triangle.Checked)
            {
                if (float.TryParse(txt_Base.Text, out _) && float.TryParse(txt_Height.Text, out _))
                    txt_Area.Text = ((float.Parse(txt_Base.Text) * float.Parse(txt_Height.Text)) / 2).ToString();
            }

            if (rbt_Circle.Checked)
            {
                if (float.TryParse(txt_Radius.Text, out _))
                    txt_Area.Text = (Math.Pow(float.Parse(txt_Radius.Text), 2) * Math.PI).ToString();
                
            }
        }
        private void bClear_Click(object sender, EventArgs e)
        {
            rbt_Circle.Checked = false;
            rbt_Rectangle.Checked = false;
            rbt_Triangle.Checked = false;

            txt_Height.Enabled = true;
            txt_Radius.Enabled = true;
            txt_Base.Enabled = true;


            txt_Area.Text = "";
            txt_Base.Text = "";
            txt_Height.Text = "";
            txt_Radius.Text = "";
        }
        //private void txt_Base_MouseHover(object sender, EventArgs e)
        //{
        //    if(!txt_Base.Enabled)
        //        Cursor = System.Windows.Forms.Cursors.No;
        //}
    }
}
