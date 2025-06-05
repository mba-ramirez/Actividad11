namespace Ejemplo1
{
    partial class FormPrincipal
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
            btnRegistrar = new Button();
            tbValor = new TextBox();
            lbResultado = new Label();
            tbResultado = new TextBox();
            btnPromedio = new Button();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(194, 27);
            btnRegistrar.Margin = new Padding(4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(129, 32);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // tbValor
            // 
            tbValor.Location = new Point(28, 28);
            tbValor.Margin = new Padding(4);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(127, 29);
            tbValor.TabIndex = 1;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.BackColor = SystemColors.ActiveCaption;
            lbResultado.Location = new Point(28, 106);
            lbResultado.Margin = new Padding(4, 0, 4, 0);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(92, 21);
            lbResultado.TabIndex = 2;
            lbResultado.Text = "lbResultado";
            // 
            // tbResultado
            // 
            tbResultado.Location = new Point(15, 169);
            tbResultado.Margin = new Padding(4);
            tbResultado.Multiline = true;
            tbResultado.Name = "tbResultado";
            tbResultado.Size = new Size(374, 134);
            tbResultado.TabIndex = 3;
            // 
            // btnPromedio
            // 
            btnPromedio.Location = new Point(194, 95);
            btnPromedio.Margin = new Padding(4);
            btnPromedio.Name = "btnPromedio";
            btnPromedio.Size = new Size(129, 66);
            btnPromedio.TabIndex = 4;
            btnPromedio.Text = "Calcular promedio";
            btnPromedio.UseVisualStyleBackColor = true;
            btnPromedio.Click += btnPromedio_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 309);
            Controls.Add(btnPromedio);
            Controls.Add(tbResultado);
            Controls.Add(lbResultado);
            Controls.Add(tbValor);
            Controls.Add(btnRegistrar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejemplo1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private TextBox tbValor;
        private Label lbResultado;
        private TextBox tbResultado;
        private Button btnPromedio;
    }
}
