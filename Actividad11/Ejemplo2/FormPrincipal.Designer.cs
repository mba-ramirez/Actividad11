namespace Ejemplo2
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
            tbValor = new TextBox();
            btnRegistrar = new Button();
            label1 = new Label();
            lbPromedio = new Label();
            btnPromedio = new Button();
            tbPromedio = new TextBox();
            SuspendLayout();
            // 
            // tbValor
            // 
            tbValor.Location = new Point(80, 24);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(100, 23);
            tbValor.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(206, 17);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 35);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 24);
            label1.Name = "label1";
            label1.Size = new Size(38, 17);
            label1.TabIndex = 3;
            label1.Text = "Valor";
            // 
            // lbPromedio
            // 
            lbPromedio.AutoSize = true;
            lbPromedio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPromedio.Location = new Point(92, 81);
            lbPromedio.Name = "lbPromedio";
            lbPromedio.Size = new Size(76, 17);
            lbPromedio.TabIndex = 4;
            lbPromedio.Text = "lbPromedio";
            // 
            // btnPromedio
            // 
            btnPromedio.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPromedio.Location = new Point(206, 64);
            btnPromedio.Name = "btnPromedio";
            btnPromedio.Size = new Size(75, 53);
            btnPromedio.TabIndex = 5;
            btnPromedio.Text = "Calcular Promedio";
            btnPromedio.UseVisualStyleBackColor = true;
            btnPromedio.Click += btnPromedio_Click;
            // 
            // tbPromedio
            // 
            tbPromedio.Location = new Point(25, 130);
            tbPromedio.Multiline = true;
            tbPromedio.Name = "tbPromedio";
            tbPromedio.Size = new Size(256, 134);
            tbPromedio.TabIndex = 6;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 288);
            Controls.Add(tbPromedio);
            Controls.Add(btnPromedio);
            Controls.Add(lbPromedio);
            Controls.Add(label1);
            Controls.Add(btnRegistrar);
            Controls.Add(tbValor);
            Name = "FormPrincipal";
            Text = "Ejemplo2. Sin vectores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbValor;
        private Button btnRegistrar;
        private Label label1;
        private Label lbPromedio;
        private Button btnPromedio;
        private TextBox tbPromedio;
    }
}
