
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
            this.rbt_Rectangle = new System.Windows.Forms.RadioButton();
            this.rbt_Triangle = new System.Windows.Forms.RadioButton();
            this.rbt_Circle = new System.Windows.Forms.RadioButton();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbt_Rectangle
            // 
            this.rbt_Rectangle.AutoSize = true;
            this.rbt_Rectangle.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Rectangle.ForeColor = System.Drawing.SystemColors.MenuText;
            this.rbt_Rectangle.Location = new System.Drawing.Point(75, 90);
            this.rbt_Rectangle.Name = "rbt_Rectangle";
            this.rbt_Rectangle.Size = new System.Drawing.Size(96, 25);
            this.rbt_Rectangle.TabIndex = 0;
            this.rbt_Rectangle.TabStop = true;
            this.rbt_Rectangle.Text = "Rectangle";
            this.rbt_Rectangle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbt_Rectangle.UseVisualStyleBackColor = true;
            this.rbt_Rectangle.CheckedChanged += new System.EventHandler(this.rbt_Rectangulo_CheckedChanged);
            // 
            // rbt_Triangle
            // 
            this.rbt_Triangle.AutoSize = true;
            this.rbt_Triangle.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Triangle.ForeColor = System.Drawing.SystemColors.MenuText;
            this.rbt_Triangle.Location = new System.Drawing.Point(177, 90);
            this.rbt_Triangle.Name = "rbt_Triangle";
            this.rbt_Triangle.Size = new System.Drawing.Size(84, 25);
            this.rbt_Triangle.TabIndex = 1;
            this.rbt_Triangle.TabStop = true;
            this.rbt_Triangle.Text = "Triangle";
            this.rbt_Triangle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbt_Triangle.UseVisualStyleBackColor = true;
            this.rbt_Triangle.CheckedChanged += new System.EventHandler(this.rbt_Triangulo_CheckedChanged);
            // 
            // rbt_Circle
            // 
            this.rbt_Circle.AutoSize = true;
            this.rbt_Circle.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Circle.ForeColor = System.Drawing.SystemColors.MenuText;
            this.rbt_Circle.Location = new System.Drawing.Point(274, 90);
            this.rbt_Circle.Name = "rbt_Circle";
            this.rbt_Circle.Size = new System.Drawing.Size(67, 25);
            this.rbt_Circle.TabIndex = 2;
            this.rbt_Circle.TabStop = true;
            this.rbt_Circle.Text = "Circle";
            this.rbt_Circle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbt_Circle.UseVisualStyleBackColor = true;
            this.rbt_Circle.CheckedChanged += new System.EventHandler(this.rbt_Circulo_CheckedChanged);
            // 
            // lBase
            // 
            this.lBase.AllowDrop = true;
            this.lBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(107)))), ((int)(((byte)(111)))));
            this.lBase.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lBase.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBase.Location = new System.Drawing.Point(60, 140);
            this.lBase.Name = "lBase";
            this.lBase.Size = new System.Drawing.Size(147, 24);
            this.lBase.TabIndex = 4;
            this.lBase.Text = "Base";
            this.lBase.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lAlto
            // 
            this.lAlto.AllowDrop = true;
            this.lAlto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(107)))), ((int)(((byte)(111)))));
            this.lAlto.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lAlto.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAlto.Location = new System.Drawing.Point(60, 180);
            this.lAlto.Name = "lAlto";
            this.lAlto.Size = new System.Drawing.Size(147, 24);
            this.lAlto.TabIndex = 6;
            this.lAlto.Text = "Height";
            this.lAlto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lRadius
            // 
            this.lRadius.AllowDrop = true;
            this.lRadius.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(107)))), ((int)(((byte)(111)))));
            this.lRadius.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lRadius.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRadius.Location = new System.Drawing.Point(60, 216);
            this.lRadius.Name = "lRadius";
            this.lRadius.Size = new System.Drawing.Size(147, 24);
            this.lRadius.TabIndex = 8;
            this.lRadius.Text = "Radius";
            this.lRadius.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lArea
            // 
            this.lArea.AllowDrop = true;
            this.lArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(101)))), ((int)(((byte)(118)))));
            this.lArea.Cursor = System.Windows.Forms.Cursors.Default;
            this.lArea.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lArea.Location = new System.Drawing.Point(60, 258);
            this.lArea.Name = "lArea";
            this.lArea.Size = new System.Drawing.Size(147, 24);
            this.lArea.TabIndex = 10;
            this.lArea.Text = "Area";
            this.lArea.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_Base
            // 
            this.txt_Base.BackColor = System.Drawing.Color.SeaShell;
            this.txt_Base.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Base.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Base.Location = new System.Drawing.Point(226, 142);
            this.txt_Base.Mask = "99999";
            this.txt_Base.Name = "txt_Base";
            this.txt_Base.Size = new System.Drawing.Size(125, 22);
            this.txt_Base.TabIndex = 11;
            this.txt_Base.ValidatingType = typeof(int);
            // 
            // txt_Height
            // 
            this.txt_Height.BackColor = System.Drawing.Color.SeaShell;
            this.txt_Height.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Height.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Height.Location = new System.Drawing.Point(226, 182);
            this.txt_Height.Mask = "99999";
            this.txt_Height.Name = "txt_Height";
            this.txt_Height.Size = new System.Drawing.Size(125, 22);
            this.txt_Height.TabIndex = 12;
            this.txt_Height.ValidatingType = typeof(int);
            // 
            // txt_Radius
            // 
            this.txt_Radius.BackColor = System.Drawing.Color.SeaShell;
            this.txt_Radius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Radius.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Radius.Location = new System.Drawing.Point(226, 220);
            this.txt_Radius.Mask = "99999";
            this.txt_Radius.Name = "txt_Radius";
            this.txt_Radius.Size = new System.Drawing.Size(125, 22);
            this.txt_Radius.TabIndex = 13;
            this.txt_Radius.ValidatingType = typeof(int);
            // 
            // txt_Area
            // 
            this.txt_Area.BackColor = System.Drawing.Color.SeaShell;
            this.txt_Area.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Area.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Area.Location = new System.Drawing.Point(226, 258);
            this.txt_Area.Name = "txt_Area";
            this.txt_Area.ReadOnly = true;
            this.txt_Area.Size = new System.Drawing.Size(125, 22);
            this.txt_Area.TabIndex = 14;
            // 
            // bCalculate
            // 
            this.bCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(89)))), ((int)(((byte)(122)))));
            this.bCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bCalculate.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.bCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCalculate.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCalculate.ForeColor = System.Drawing.Color.Transparent;
            this.bCalculate.Location = new System.Drawing.Point(106, 318);
            this.bCalculate.Name = "bCalculate";
            this.bCalculate.Size = new System.Drawing.Size(101, 24);
            this.bCalculate.TabIndex = 15;
            this.bCalculate.Text = "Calculate";
            this.bCalculate.UseVisualStyleBackColor = false;
            this.bCalculate.Click += new System.EventHandler(this.bCalculate_Click);
            // 
            // lTitle
            // 
            this.lTitle.BackColor = System.Drawing.Color.Transparent;
            this.lTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lTitle.Location = new System.Drawing.Point(40, 9);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(331, 41);
            this.lTitle.TabIndex = 16;
            this.lTitle.Text = "AREA CALCULATOR";
            this.lTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bClear
            // 
            this.bClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(80)))), ((int)(((byte)(112)))));
            this.bClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bClear.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClear.ForeColor = System.Drawing.Color.Transparent;
            this.bClear.Location = new System.Drawing.Point(216, 318);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(101, 24);
            this.bClear.TabIndex = 17;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = false;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(80)))), ((int)(((byte)(112)))));
            this.panel1.Controls.Add(this.lTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 59);
            this.panel1.TabIndex = 18;
            // 
            // CalculArea
            // 
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(417, 395);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bCalculate);
            this.Controls.Add(this.txt_Area);
            this.Controls.Add(this.txt_Radius);
            this.Controls.Add(this.txt_Height);
            this.Controls.Add(this.txt_Base);
            this.Controls.Add(this.lArea);
            this.Controls.Add(this.lRadius);
            this.Controls.Add(this.lAlto);
            this.Controls.Add(this.lBase);
            this.Controls.Add(this.rbt_Circle);
            this.Controls.Add(this.rbt_Triangle);
            this.Controls.Add(this.rbt_Rectangle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CalculArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalculArea";
            //this.CursorChanged += new System.EventHandler(this.CalculArea_CursorChanged);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbt_Rectangle;
        private System.Windows.Forms.RadioButton rbt_Triangle;
        private System.Windows.Forms.RadioButton rbt_Circle;
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
        private System.Windows.Forms.Panel panel1;
    }
}

