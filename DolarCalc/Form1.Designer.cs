namespace DolarCalc
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnRefresh = new Button();
            txtOficial = new TextBox();
            txtMep = new TextBox();
            txtTarjeta = new TextBox();
            gb1 = new GroupBox();
            rbUruguayo = new RadioButton();
            rbChileno = new RadioButton();
            rbReal = new RadioButton();
            rbEuro = new RadioButton();
            rbBlue = new RadioButton();
            rbTarjeta = new RadioButton();
            rbMep = new RadioButton();
            rbOficial = new RadioButton();
            label6 = new Label();
            label5 = new Label();
            txtOutput = new TextBox();
            txtInput = new TextBox();
            btnCalc = new Button();
            txtBlue = new TextBox();
            label4 = new Label();
            lOficial = new Label();
            lTarjeta = new Label();
            lMep = new Label();
            lBlue = new Label();
            lFecha = new Label();
            lEuro = new Label();
            txtEuro = new TextBox();
            label8 = new Label();
            lReal = new Label();
            txtReal = new TextBox();
            label10 = new Label();
            lChileno = new Label();
            txtChileno = new TextBox();
            label12 = new Label();
            lUruguayo = new Label();
            txtUruguayo = new TextBox();
            label14 = new Label();
            gb1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 63);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Dolar Oficial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 127);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Dolar MEP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 159);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Dolar Tarjeta";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(85, 360);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Actualizar";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtOficial
            // 
            txtOficial.Location = new Point(128, 59);
            txtOficial.Name = "txtOficial";
            txtOficial.Size = new Size(100, 23);
            txtOficial.TabIndex = 4;
            // 
            // txtMep
            // 
            txtMep.Location = new Point(128, 123);
            txtMep.Name = "txtMep";
            txtMep.Size = new Size(100, 23);
            txtMep.TabIndex = 5;
            // 
            // txtTarjeta
            // 
            txtTarjeta.Location = new Point(128, 155);
            txtTarjeta.Name = "txtTarjeta";
            txtTarjeta.Size = new Size(100, 23);
            txtTarjeta.TabIndex = 6;
            // 
            // gb1
            // 
            gb1.Controls.Add(rbUruguayo);
            gb1.Controls.Add(rbChileno);
            gb1.Controls.Add(rbReal);
            gb1.Controls.Add(rbEuro);
            gb1.Controls.Add(rbBlue);
            gb1.Controls.Add(rbTarjeta);
            gb1.Controls.Add(rbMep);
            gb1.Controls.Add(rbOficial);
            gb1.Location = new Point(562, 106);
            gb1.Name = "gb1";
            gb1.Size = new Size(161, 226);
            gb1.TabIndex = 7;
            gb1.TabStop = false;
            // 
            // rbUruguayo
            // 
            rbUruguayo.AutoSize = true;
            rbUruguayo.Location = new Point(19, 199);
            rbUruguayo.Name = "rbUruguayo";
            rbUruguayo.Size = new Size(105, 19);
            rbUruguayo.TabIndex = 7;
            rbUruguayo.Text = "Peso Uruguayo";
            rbUruguayo.UseVisualStyleBackColor = true;
            // 
            // rbChileno
            // 
            rbChileno.AutoSize = true;
            rbChileno.Location = new Point(19, 174);
            rbChileno.Name = "rbChileno";
            rbChileno.Size = new Size(92, 19);
            rbChileno.TabIndex = 6;
            rbChileno.Text = "Peso chileno";
            rbChileno.UseVisualStyleBackColor = true;
            // 
            // rbReal
            // 
            rbReal.AutoSize = true;
            rbReal.Location = new Point(19, 149);
            rbReal.Name = "rbReal";
            rbReal.Size = new Size(47, 19);
            rbReal.TabIndex = 5;
            rbReal.Text = "Real";
            rbReal.UseVisualStyleBackColor = true;
            // 
            // rbEuro
            // 
            rbEuro.AutoSize = true;
            rbEuro.Location = new Point(19, 124);
            rbEuro.Name = "rbEuro";
            rbEuro.Size = new Size(49, 19);
            rbEuro.TabIndex = 4;
            rbEuro.Text = "Euro";
            rbEuro.UseVisualStyleBackColor = true;
            // 
            // rbBlue
            // 
            rbBlue.AutoSize = true;
            rbBlue.Location = new Point(19, 50);
            rbBlue.Name = "rbBlue";
            rbBlue.Size = new Size(79, 19);
            rbBlue.TabIndex = 3;
            rbBlue.Text = "Dolar Blue";
            rbBlue.UseVisualStyleBackColor = true;
            // 
            // rbTarjeta
            // 
            rbTarjeta.AutoSize = true;
            rbTarjeta.Location = new Point(19, 99);
            rbTarjeta.Name = "rbTarjeta";
            rbTarjeta.Size = new Size(90, 19);
            rbTarjeta.TabIndex = 2;
            rbTarjeta.Text = "Dolar Tarjeta";
            rbTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbMep
            // 
            rbMep.AutoSize = true;
            rbMep.Location = new Point(19, 74);
            rbMep.Name = "rbMep";
            rbMep.Size = new Size(80, 19);
            rbMep.TabIndex = 1;
            rbMep.Text = "Dolar MEP";
            rbMep.UseVisualStyleBackColor = true;
            // 
            // rbOficial
            // 
            rbOficial.AutoSize = true;
            rbOficial.Checked = true;
            rbOficial.Location = new Point(19, 25);
            rbOficial.Name = "rbOficial";
            rbOficial.Size = new Size(90, 19);
            rbOficial.TabIndex = 0;
            rbOficial.TabStop = true;
            rbOficial.Text = "Dolar Oficial";
            rbOficial.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(562, 372);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 14;
            label6.Text = "Resultado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(581, 59);
            label5.Name = "label5";
            label5.Size = new Size(174, 15);
            label5.TabIndex = 13;
            label5.Text = "Monto a convertir en ARS";
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(562, 390);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(100, 23);
            txtOutput.TabIndex = 12;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(581, 77);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(100, 23);
            txtInput.TabIndex = 10;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(562, 338);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(90, 23);
            btnCalc.TabIndex = 11;
            btnCalc.Text = "Calcular";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // txtBlue
            // 
            txtBlue.Location = new Point(128, 91);
            txtBlue.Name = "txtBlue";
            txtBlue.Size = new Size(100, 23);
            txtBlue.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 95);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 8;
            label4.Text = "Dolar Blue";
            // 
            // lOficial
            // 
            lOficial.AutoSize = true;
            lOficial.Location = new Point(244, 63);
            lOficial.Name = "lOficial";
            lOficial.Size = new Size(25, 15);
            lOficial.TabIndex = 15;
            lOficial.Text = "asd";
            lOficial.Visible = false;
            // 
            // lTarjeta
            // 
            lTarjeta.AutoSize = true;
            lTarjeta.Location = new Point(244, 159);
            lTarjeta.Name = "lTarjeta";
            lTarjeta.Size = new Size(25, 15);
            lTarjeta.TabIndex = 16;
            lTarjeta.Text = "asd";
            lTarjeta.Visible = false;
            // 
            // lMep
            // 
            lMep.AutoSize = true;
            lMep.Location = new Point(244, 127);
            lMep.Name = "lMep";
            lMep.Size = new Size(25, 15);
            lMep.TabIndex = 17;
            lMep.Text = "asd";
            lMep.Visible = false;
            // 
            // lBlue
            // 
            lBlue.AutoSize = true;
            lBlue.Location = new Point(244, 95);
            lBlue.Name = "lBlue";
            lBlue.Size = new Size(25, 15);
            lBlue.TabIndex = 18;
            lBlue.Text = "asd";
            lBlue.Visible = false;
            // 
            // lFecha
            // 
            lFecha.AutoSize = true;
            lFecha.Location = new Point(258, 32);
            lFecha.Name = "lFecha";
            lFecha.Size = new Size(159, 15);
            lFecha.TabIndex = 19;
            lFecha.Text = "Fecha actualización del dolar";
            lFecha.Visible = false;
            // 
            // lEuro
            // 
            lEuro.AutoSize = true;
            lEuro.Location = new Point(244, 188);
            lEuro.Name = "lEuro";
            lEuro.Size = new Size(25, 15);
            lEuro.TabIndex = 22;
            lEuro.Text = "asd";
            lEuro.Visible = false;
            // 
            // txtEuro
            // 
            txtEuro.Location = new Point(128, 184);
            txtEuro.Name = "txtEuro";
            txtEuro.Size = new Size(100, 23);
            txtEuro.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(93, 188);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 20;
            label8.Text = "Euro";
            // 
            // lReal
            // 
            lReal.AutoSize = true;
            lReal.Location = new Point(244, 217);
            lReal.Name = "lReal";
            lReal.Size = new Size(25, 15);
            lReal.TabIndex = 25;
            lReal.Text = "asd";
            lReal.Visible = false;
            // 
            // txtReal
            // 
            txtReal.Location = new Point(128, 213);
            txtReal.Name = "txtReal";
            txtReal.Size = new Size(100, 23);
            txtReal.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(95, 217);
            label10.Name = "label10";
            label10.Size = new Size(29, 15);
            label10.TabIndex = 23;
            label10.Text = "Real";
            // 
            // lChileno
            // 
            lChileno.AutoSize = true;
            lChileno.Location = new Point(244, 246);
            lChileno.Name = "lChileno";
            lChileno.Size = new Size(25, 15);
            lChileno.TabIndex = 28;
            lChileno.Text = "asd";
            lChileno.Visible = false;
            // 
            // txtChileno
            // 
            txtChileno.Location = new Point(128, 242);
            txtChileno.Name = "txtChileno";
            txtChileno.Size = new Size(100, 23);
            txtChileno.TabIndex = 27;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(48, 246);
            label12.Name = "label12";
            label12.Size = new Size(76, 15);
            label12.TabIndex = 26;
            label12.Text = "Peso Chileno";
            // 
            // lUruguayo
            // 
            lUruguayo.AutoSize = true;
            lUruguayo.Location = new Point(244, 275);
            lUruguayo.Name = "lUruguayo";
            lUruguayo.Size = new Size(25, 15);
            lUruguayo.TabIndex = 31;
            lUruguayo.Text = "asd";
            lUruguayo.Visible = false;
            // 
            // txtUruguayo
            // 
            txtUruguayo.Location = new Point(128, 271);
            txtUruguayo.Name = "txtUruguayo";
            txtUruguayo.Size = new Size(100, 23);
            txtUruguayo.TabIndex = 30;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(37, 275);
            label14.Name = "label14";
            label14.Size = new Size(87, 15);
            label14.TabIndex = 29;
            label14.Text = "Peso Uruguayo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 511);
            Controls.Add(lUruguayo);
            Controls.Add(txtUruguayo);
            Controls.Add(label14);
            Controls.Add(lChileno);
            Controls.Add(txtChileno);
            Controls.Add(label12);
            Controls.Add(lReal);
            Controls.Add(txtReal);
            Controls.Add(label10);
            Controls.Add(lEuro);
            Controls.Add(txtEuro);
            Controls.Add(label8);
            Controls.Add(lFecha);
            Controls.Add(lBlue);
            Controls.Add(lMep);
            Controls.Add(lTarjeta);
            Controls.Add(lOficial);
            Controls.Add(label6);
            Controls.Add(txtBlue);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(gb1);
            Controls.Add(txtOutput);
            Controls.Add(txtTarjeta);
            Controls.Add(txtMep);
            Controls.Add(txtInput);
            Controls.Add(txtOficial);
            Controls.Add(btnCalc);
            Controls.Add(btnRefresh);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "DolarCalc";
            gb1.ResumeLayout(false);
            gb1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnRefresh;
        private TextBox txtOficial;
        private TextBox txtMep;
        private TextBox txtTarjeta;
        private GroupBox gb1;
        private RadioButton rbTarjeta;
        private RadioButton rbMep;
        private RadioButton rbOficial;
        private RadioButton rbBlue;
        private TextBox txtBlue;
        private Label label4;
        private TextBox txtInput;
        private Button btnCalc;
        private TextBox txtOutput;
        private Label label5;
        private Label label6;
        private Label lOficial;
        private Label lTarjeta;
        private Label lMep;
        private Label lBlue;
        private Label lFecha;
        private Label lEuro;
        private TextBox txtEuro;
        private Label label8;
        private Label lReal;
        private TextBox txtReal;
        private Label label10;
        private Label lChileno;
        private TextBox txtChileno;
        private Label label12;
        private Label lUruguayo;
        private TextBox txtUruguayo;
        private Label label14;
        private RadioButton rbUruguayo;
        private RadioButton rbChileno;
        private RadioButton rbReal;
        private RadioButton rbEuro;
    }
}
