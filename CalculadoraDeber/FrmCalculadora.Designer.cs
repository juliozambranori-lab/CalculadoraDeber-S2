namespace CalculadoraDeber
{
    partial class FrmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            b1 = new Button();
            txtPantalla = new TextBox();
            b2 = new Button();
            b3 = new Button();
            b4 = new Button();
            b5 = new Button();
            b6 = new Button();
            b7 = new Button();
            b8 = new Button();
            b9 = new Button();
            bSuma = new Button();
            bResta = new Button();
            bMulti = new Button();
            b0 = new Button();
            bLimpiar = new Button();
            bIgual = new Button();
            bDivision = new Button();
            SuspendLayout();
            // 
            // b1
            // 
            b1.Location = new Point(12, 186);
            b1.Name = "b1";
            b1.Size = new Size(75, 23);
            b1.TabIndex = 0;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // txtPantalla
            // 
            txtPantalla.Location = new Point(31, 34);
            txtPantalla.Name = "txtPantalla";
            txtPantalla.ReadOnly = true;
            txtPantalla.Size = new Size(255, 23);
            txtPantalla.TabIndex = 1;
            txtPantalla.TextAlign = HorizontalAlignment.Right;
            // 
            // b2
            // 
            b2.Location = new Point(93, 186);
            b2.Name = "b2";
            b2.Size = new Size(75, 23);
            b2.TabIndex = 2;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = true;
            b2.Click += b2_Click;
            // 
            // b3
            // 
            b3.Location = new Point(174, 186);
            b3.Name = "b3";
            b3.Size = new Size(75, 23);
            b3.TabIndex = 3;
            b3.Text = "3";
            b3.UseVisualStyleBackColor = true;
            b3.Click += b3_Click;
            // 
            // b4
            // 
            b4.Location = new Point(12, 138);
            b4.Name = "b4";
            b4.Size = new Size(75, 23);
            b4.TabIndex = 4;
            b4.Text = "4";
            b4.UseVisualStyleBackColor = true;
            b4.Click += b4_Click;
            // 
            // b5
            // 
            b5.Location = new Point(93, 138);
            b5.Name = "b5";
            b5.Size = new Size(75, 23);
            b5.TabIndex = 5;
            b5.Text = "5";
            b5.UseVisualStyleBackColor = true;
            b5.Click += b5_Click;
            // 
            // b6
            // 
            b6.Location = new Point(174, 138);
            b6.Name = "b6";
            b6.Size = new Size(75, 23);
            b6.TabIndex = 6;
            b6.Text = "6";
            b6.UseVisualStyleBackColor = true;
            b6.Click += b6_Click;
            // 
            // b7
            // 
            b7.Location = new Point(12, 99);
            b7.Name = "b7";
            b7.Size = new Size(75, 23);
            b7.TabIndex = 7;
            b7.Text = "7";
            b7.UseVisualStyleBackColor = true;
            b7.Click += b7_Click;
            // 
            // b8
            // 
            b8.Location = new Point(93, 99);
            b8.Name = "b8";
            b8.Size = new Size(75, 23);
            b8.TabIndex = 8;
            b8.Text = "8";
            b8.UseVisualStyleBackColor = true;
            b8.Click += b8_Click;
            // 
            // b9
            // 
            b9.Location = new Point(174, 99);
            b9.Name = "b9";
            b9.Size = new Size(75, 23);
            b9.TabIndex = 9;
            b9.Text = "9";
            b9.UseVisualStyleBackColor = true;
            b9.Click += b9_Click;
            // 
            // bSuma
            // 
            bSuma.Location = new Point(255, 99);
            bSuma.Name = "bSuma";
            bSuma.Size = new Size(46, 23);
            bSuma.TabIndex = 10;
            bSuma.Text = "+";
            bSuma.UseVisualStyleBackColor = true;
            bSuma.Click += bSuma_Click;
            // 
            // bResta
            // 
            bResta.Location = new Point(255, 138);
            bResta.Name = "bResta";
            bResta.Size = new Size(46, 23);
            bResta.TabIndex = 11;
            bResta.Text = "-";
            bResta.UseVisualStyleBackColor = true;
            bResta.Click += bResta_Click;
            // 
            // bMulti
            // 
            bMulti.Location = new Point(255, 186);
            bMulti.Name = "bMulti";
            bMulti.Size = new Size(46, 23);
            bMulti.TabIndex = 12;
            bMulti.Text = "*";
            bMulti.UseVisualStyleBackColor = true;
            bMulti.Click += bMulti_Click;
            // 
            // b0
            // 
            b0.Location = new Point(12, 233);
            b0.Name = "b0";
            b0.Size = new Size(75, 23);
            b0.TabIndex = 13;
            b0.Text = "0";
            b0.UseVisualStyleBackColor = true;
            b0.Click += b0_Click;
            // 
            // bLimpiar
            // 
            bLimpiar.Location = new Point(93, 233);
            bLimpiar.Name = "bLimpiar";
            bLimpiar.Size = new Size(75, 23);
            bLimpiar.TabIndex = 14;
            bLimpiar.Text = "C";
            bLimpiar.UseVisualStyleBackColor = true;
            bLimpiar.Click += bLimpiar_Click;
            // 
            // bIgual
            // 
            bIgual.Location = new Point(174, 233);
            bIgual.Name = "bIgual";
            bIgual.Size = new Size(75, 23);
            bIgual.TabIndex = 15;
            bIgual.Text = "=";
            bIgual.UseVisualStyleBackColor = true;
            bIgual.Click += bIgual_Click;
            // 
            // bDivision
            // 
            bDivision.Location = new Point(255, 233);
            bDivision.Name = "bDivision";
            bDivision.Size = new Size(46, 23);
            bDivision.TabIndex = 16;
            bDivision.Text = "/";
            bDivision.UseVisualStyleBackColor = true;
            bDivision.Click += bDivision_Click;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(313, 331);
            Controls.Add(bDivision);
            Controls.Add(bIgual);
            Controls.Add(bLimpiar);
            Controls.Add(b0);
            Controls.Add(bMulti);
            Controls.Add(bResta);
            Controls.Add(bSuma);
            Controls.Add(b9);
            Controls.Add(b8);
            Controls.Add(b7);
            Controls.Add(b6);
            Controls.Add(b5);
            Controls.Add(b4);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(txtPantalla);
            Controls.Add(b1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b1;
        private TextBox txtPantalla;
        private Button b2;
        private Button b3;
        private Button b4;
        private Button b5;
        private Button b6;
        private Button b7;
        private Button b8;
        private Button b9;
        private Button bSuma;
        private Button bResta;
        private Button bMulti;
        private Button b0;
        private Button bLimpiar;
        private Button bIgual;
        private Button bDivision;
    }
}
