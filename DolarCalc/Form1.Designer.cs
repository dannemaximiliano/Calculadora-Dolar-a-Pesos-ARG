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
            gb1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 63);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Dolar Oficial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 127);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Dolar MEP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 159);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Dolar Tarjeta";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(74, 202);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Actualizar";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtOficial
            // 
            txtOficial.Location = new Point(142, 59);
            txtOficial.Name = "txtOficial";
            txtOficial.Size = new Size(100, 23);
            txtOficial.TabIndex = 4;
            // 
            // txtMep
            // 
            txtMep.Location = new Point(142, 123);
            txtMep.Name = "txtMep";
            txtMep.Size = new Size(100, 23);
            txtMep.TabIndex = 5;
            // 
            // txtTarjeta
            // 
            txtTarjeta.Location = new Point(142, 155);
            txtTarjeta.Name = "txtTarjeta";
            txtTarjeta.Size = new Size(100, 23);
            txtTarjeta.TabIndex = 6;
            // 
            // gb1
            // 
            gb1.Controls.Add(rbBlue);
            gb1.Controls.Add(rbTarjeta);
            gb1.Controls.Add(rbMep);
            gb1.Controls.Add(rbOficial);
            gb1.Location = new Point(562, 106);
            gb1.Name = "gb1";
            gb1.Size = new Size(161, 153);
            gb1.TabIndex = 7;
            gb1.TabStop = false;
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
            label6.Location = new Point(562, 324);
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
            label5.Size = new Size(142, 15);
            label5.TabIndex = 13;
            label5.Text = "Monto en ARS a convertir";
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(562, 342);
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
            btnCalc.Location = new Point(562, 275);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(90, 23);
            btnCalc.TabIndex = 11;
            btnCalc.Text = "Calcular";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // txtBlue
            // 
            txtBlue.Location = new Point(142, 91);
            txtBlue.Name = "txtBlue";
            txtBlue.Size = new Size(100, 23);
            txtBlue.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 95);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 8;
            label4.Text = "Dolar Blue";
            // 
            // lOficial
            // 
            lOficial.AutoSize = true;
            lOficial.Location = new Point(258, 63);
            lOficial.Name = "lOficial";
            lOficial.Size = new Size(0, 15);
            lOficial.TabIndex = 15;
            // 
            // lTarjeta
            // 
            lTarjeta.AutoSize = true;
            lTarjeta.Location = new Point(258, 159);
            lTarjeta.Name = "lTarjeta";
            lTarjeta.Size = new Size(0, 15);
            lTarjeta.TabIndex = 16;
            // 
            // lMep
            // 
            lMep.AutoSize = true;
            lMep.Location = new Point(258, 127);
            lMep.Name = "lMep";
            lMep.Size = new Size(0, 15);
            lMep.TabIndex = 17;
            // 
            // lBlue
            // 
            lBlue.AutoSize = true;
            lBlue.Location = new Point(258, 95);
            lBlue.Name = "lBlue";
            lBlue.Size = new Size(0, 15);
            lBlue.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
