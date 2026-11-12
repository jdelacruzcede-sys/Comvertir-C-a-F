namespace Comvertir_C_a_F
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
            txtcelsius = new TextBox();
            Convertidor = new Label();
            btnComvertir = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 89);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 0;
            label1.Text = "Grado Celsius:";
            // 
            // txtcelsius
            // 
            txtcelsius.Location = new Point(171, 89);
            txtcelsius.Name = "txtcelsius";
            txtcelsius.Size = new Size(150, 31);
            txtcelsius.TabIndex = 1;
            // 
            // Convertidor
            // 
            Convertidor.AutoSize = true;
            Convertidor.Location = new Point(41, 27);
            Convertidor.Name = "Convertidor";
            Convertidor.Size = new Size(106, 25);
            Convertidor.TabIndex = 2;
            Convertidor.Text = "Convertidor";
            // 
            // btnComvertir
            // 
            btnComvertir.Location = new Point(41, 164);
            btnComvertir.Name = "btnComvertir";
            btnComvertir.Size = new Size(112, 34);
            btnComvertir.TabIndex = 3;
            btnComvertir.Text = "Convertir";
            btnComvertir.UseVisualStyleBackColor = true;
            btnComvertir.Click += Comvertir_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(198, 173);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(153, 25);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "Convertidor C A F";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnComvertir);
            Controls.Add(Convertidor);
            Controls.Add(txtcelsius);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtcelsius;
        private Label Convertidor;
        private Button btnComvertir;
        private Label lblResultado;
    }
}
