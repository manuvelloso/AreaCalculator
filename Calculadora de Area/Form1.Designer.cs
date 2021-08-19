
namespace Calculadora_de_Area
{
    partial class CalculArea
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculArea));
            this.rbt_Rectangulo = new System.Windows.Forms.RadioButton();
            this.rbt_Triangulo = new System.Windows.Forms.RadioButton();
            this.rbt_Circulo = new System.Windows.Forms.RadioButton();
            this.lBase = new System.Windows.Forms.Label();
            this.lAlto = new System.Windows.Forms.Label();
            this.lRadius = new System.Windows.Forms.Label();
            this.lArea = new System.Windows.Forms.Label();
            this.txt_Base = new System.Windows.Forms.MaskedTextBox();
            this.txt_Height = new System.Windows.Forms.MaskedTextBox();
            this.txt_Radius = new System.Windows.Forms.MaskedTextBox();
            this.txt_Area = new System.Windows.Forms.TextBox();
            this.bCalculate = new System.Windows.Forms.Button();
            this.lTitle = new System.Windows.Forms.Label();
            this.bClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbt_Rectangulo
            // 
            this.rbt_Rectangulo.AutoSize = true;
            this.rbt_Rectangulo.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Rectangulo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.rbt_Rectangulo.Location = new System.Drawing.Point(304, 142);
            this.rbt_Rectangulo.Name = "rbt_Rectangulo";
            this.rbt_Rectangulo.Size = new System.Drawing.Size(96, 25);
            this.rbt_Rectangulo.TabIndex = 0;
            this.rbt_Rectangulo.TabStop = true;
            this.rbt_Rectangulo.Text = "Rectangle";
            this.rbt_Rectangulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbt_Rectangulo.UseVisualStyleBackColor = true;
            this.rbt_Rectangulo.CheckedChanged += new System.EventHandler(this.rbt_Rectangulo_CheckedChanged);
            // 
            // rbt_Triangulo
            // 
            this.rbt_Triangulo.AutoSize = true;
            this.rbt_Triangulo.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Triangulo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.rbt_Triangulo.Location = new System.Drawing.Point(304, 173);
            this.rbt_Triangulo.Name = "rbt_Triangulo";
            this.rbt_Triangulo.Size = new System.Drawing.Size(84, 25);
            this.rbt_Triangulo.TabIndex = 1;
            this.rbt_Triangulo.TabStop = true;
            this.rbt_Triangulo.Text = "Triangle";
            this.rbt_Triangulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbt_Triangulo.UseVisualStyleBackColor = true;
            this.rbt_Triangulo.CheckedChanged += new System.EventHandler(this.rbt_Triangulo_CheckedChanged);
            // 
            // rbt_Circulo
            // 
            this.rbt_Circulo.AutoSize = true;
            this.rbt_Circulo.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Circulo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.rbt_Circulo.Location = new System.Drawing.Point(304, 204);
            this.rbt_Circulo.Name = "rbt_Circulo";
            this.rbt_Circulo.Size = new System.Drawing.Size(67, 25);
            this.rbt_Circulo.TabIndex = 2;
            this.rbt_Circulo.TabStop = true;
            this.rbt_Circulo.Text = "Circle";
            this.rbt_Circulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbt_Circulo.UseVisualStyleBackColor = true;
            this.rbt_Circulo.CheckedChanged += new System.EventHandler(this.rbt_Circulo_CheckedChanged);
            // 
            // lBase
            // 
            this.lBase.AllowDrop = true;
            this.lBase.BackColor = System.Drawing.Color.NavajoWhite;
            this.lBase.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lBase.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBase.Location = new System.Drawing.Point(65, 142);
            this.lBase.Name = "lBase";
            this.lBase.Size = new System.Drawing.Size(89, 24);
            this.lBase.TabIndex = 4;
            this.lBase.Text = "Base";
            this.lBase.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lAlto
            // 
            this.lAlto.AllowDrop = true;
            this.lAlto.BackColor = System.Drawing.Color.NavajoWhite;
            this.lAlto.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lAlto.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAlto.Location = new System.Drawing.Point(65, 182);
            this.lAlto.Name = "lAlto";
            this.lAlto.Size = new System.Drawing.Size(89, 24);
            this.lAlto.TabIndex = 6;
            this.lAlto.Text = "Height";
            this.lAlto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lRadius
            // 
            this.lRadius.AllowDrop = true;
            this.lRadius.BackColor = System.Drawing.Color.NavajoWhite;
            this.lRadius.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lRadius.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRadius.Location = new System.Drawing.Point(65, 218);
            this.lRadius.Name = "lRadius";
            this.lRadius.Size = new System.Drawing.Size(89, 24);
            this.lRadius.TabIndex = 8;
            this.lRadius.Text = "Radius";
            this.lRadius.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lArea
            // 
            this.lArea.AllowDrop = true;
            this.lArea.BackColor = System.Drawing.Color.Coral;
            this.lArea.Cursor = System.Windows.Forms.Cursors.Default;
            this.lArea.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lArea.Location = new System.Drawing.Point(65, 260);
            this.lArea.Name = "lArea";
            this.lArea.Size = new System.Drawing.Size(89, 24);
            this.lArea.TabIndex = 10;
            this.lArea.Text = "Area";
            this.lArea.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_Base
            // 
            this.txt_Base.BackColor = System.Drawing.Color.SeaShell;
            this.txt_Base.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Base.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Base.Location = new System.Drawing.Point(173, 144);
            this.txt_Base.Mask = "99999";
            this.txt_Base.Name = "txt_Base";
            this.txt_Base.Size = new System.Drawing.Size(100, 22);
            this.txt_Base.TabIndex = 11;
            this.txt_Base.ValidatingType = typeof(int);
            // 
            // txt_Height
            // 
            this.txt_Height.BackColor = System.Drawing.Color.SeaShell;
            this.txt_Height.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Height.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Height.Location = new System.Drawing.Point(173, 184);
            this.txt_Height.Mask = "99999";
            this.txt_Height.Name = "txt_Height";
            this.txt_Height.Size = new System.Drawing.Size(100, 22);
            this.txt_Height.TabIndex = 12;
            this.txt_Height.ValidatingType = typeof(int);
            // 
            // txt_Radius
            // 
            this.txt_Radius.BackColor = System.Drawing.Color.SeaShell;
            this.txt_Radius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Radius.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Radius.Location = new System.Drawing.Point(173, 222);
            this.txt_Radius.Mask = "99999";
            this.txt_Radius.Name = "txt_Radius";
            this.txt_Radius.Size = new System.Drawing.Size(100, 22);
            this.txt_Radius.TabIndex = 13;
            this.txt_Radius.ValidatingType = typeof(int);
            // 
            // txt_Area
            // 
            this.txt_Area.BackColor = System.Drawing.Color.SeaShell;
            this.txt_Area.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Area.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Area.Location = new System.Drawing.Point(173, 260);
            this.txt_Area.Name = "txt_Area";
            this.txt_Area.ReadOnly = true;
            this.txt_Area.Size = new System.Drawing.Size(100, 22);
            this.txt_Area.TabIndex = 14;
            // 
            // bCalculate
            // 
            this.bCalculate.BackColor = System.Drawing.Color.PeachPuff;
            this.bCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bCalculate.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.bCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCalculate.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCalculate.Location = new System.Drawing.Point(145, 311);
            this.bCalculate.Name = "bCalculate";
            this.bCalculate.Size = new System.Drawing.Size(91, 24);
            this.bCalculate.TabIndex = 15;
            this.bCalculate.Text = "Calculate";
            this.bCalculate.UseVisualStyleBackColor = false;
            this.bCalculate.Click += new System.EventHandler(this.bCalculate_Click);
            // 
            // lTitle
            // 
            this.lTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lTitle.Location = new System.Drawing.Point(69, 54);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(331, 41);
            this.lTitle.TabIndex = 16;
            this.lTitle.Text = "AREA CALCULATOR";
            this.lTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bClear
            // 
            this.bClear.BackColor = System.Drawing.Color.DarkOrange;
            this.bClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bClear.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClear.Location = new System.Drawing.Point(242, 311);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(91, 24);
            this.bClear.TabIndex = 17;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = false;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // CalculArea
            // 
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(464, 395);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.bCalculate);
            this.Controls.Add(this.txt_Area);
            this.Controls.Add(this.txt_Radius);
            this.Controls.Add(this.txt_Height);
            this.Controls.Add(this.txt_Base);
            this.Controls.Add(this.lArea);
            this.Controls.Add(this.lRadius);
            this.Controls.Add(this.lAlto);
            this.Controls.Add(this.lBase);
            this.Controls.Add(this.rbt_Circulo);
            this.Controls.Add(this.rbt_Triangulo);
            this.Controls.Add(this.rbt_Rectangulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculArea";
            this.Text = "CalculArea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbt_Rectangulo;
        private System.Windows.Forms.RadioButton rbt_Triangulo;
        private System.Windows.Forms.RadioButton rbt_Circulo;
        private System.Windows.Forms.Label lBase;
        private System.Windows.Forms.Label lAlto;
        private System.Windows.Forms.Label lRadius;
        private System.Windows.Forms.Label lArea;
        private System.Windows.Forms.MaskedTextBox txt_Base;
        private System.Windows.Forms.MaskedTextBox txt_Height;
        private System.Windows.Forms.MaskedTextBox txt_Radius;
        private System.Windows.Forms.TextBox txt_Area;
        private System.Windows.Forms.Button bCalculate;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Button bClear;
    }
}

