namespace IterativoRecursivo
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
            comboBoxProblemas = new ComboBox();
            txtNumero = new TextBox();
            btnCalcular = new Button();
            lblResultadoIterativo = new Label();
            lblResultadoRecursivo = new Label();
            SuspendLayout();
            // 
            // comboBoxProblemas
            // 
            comboBoxProblemas.FormattingEnabled = true;
            comboBoxProblemas.Items.AddRange(new object[] { "Factorial", "Suma", "Fibonacci" });
            comboBoxProblemas.Location = new Point(30, 52);
            comboBoxProblemas.Name = "comboBoxProblemas";
            comboBoxProblemas.Size = new Size(151, 28);
            comboBoxProblemas.TabIndex = 0;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(30, 132);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 27);
            txtNumero.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(391, 58);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultadoIterativo
            // 
            lblResultadoIterativo.AutoSize = true;
            lblResultadoIterativo.Location = new Point(65, 254);
            lblResultadoIterativo.Name = "lblResultadoIterativo";
            lblResultadoIterativo.Size = new Size(12, 20);
            lblResultadoIterativo.TabIndex = 3;
            lblResultadoIterativo.Text = ",";
            // 
            // lblResultadoRecursivo
            // 
            lblResultadoRecursivo.AutoSize = true;
            lblResultadoRecursivo.Location = new Point(65, 306);
            lblResultadoRecursivo.Name = "lblResultadoRecursivo";
            lblResultadoRecursivo.Size = new Size(12, 20);
            lblResultadoRecursivo.TabIndex = 4;
            lblResultadoRecursivo.Text = ".";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultadoRecursivo);
            Controls.Add(lblResultadoIterativo);
            Controls.Add(btnCalcular);
            Controls.Add(txtNumero);
            Controls.Add(comboBoxProblemas);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxProblemas;
        private TextBox txtNumero;
        private Button btnCalcular;
        private Label lblResultadoIterativo;
        private Label lblResultadoRecursivo;
    }
}
