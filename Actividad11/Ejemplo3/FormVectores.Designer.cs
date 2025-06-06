namespace Ejemplo3
{
    partial class FormVectores
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
            tbPromedio = new TextBox();
            btnPromedio = new Button();
            lbPromedio = new Label();
            label1 = new Label();
            btnRegistrar = new Button();
            tbValor = new TextBox();
            SuspendLayout();
            // 
            // tbPromedio
            // 
            tbPromedio.Location = new Point(23, 132);
            tbPromedio.Multiline = true;
            tbPromedio.Name = "tbPromedio";
            tbPromedio.Size = new Size(256, 134);
            tbPromedio.TabIndex = 12;
            // 
            // btnPromedio
            // 
            btnPromedio.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPromedio.Location = new Point(204, 66);
            btnPromedio.Name = "btnPromedio";
            btnPromedio.Size = new Size(75, 53);
            btnPromedio.TabIndex = 11;
            btnPromedio.Text = "Calcular Promedio";
            btnPromedio.UseVisualStyleBackColor = true;
            btnPromedio.Click += this.btnPromedio_Click;
            // 
            // lbPromedio
            // 
            lbPromedio.AutoSize = true;
            lbPromedio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPromedio.Location = new Point(90, 83);
            lbPromedio.Name = "lbPromedio";
            lbPromedio.Size = new Size(76, 17);
            lbPromedio.TabIndex = 10;
            lbPromedio.Text = "lbPromedio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 26);
            label1.Name = "label1";
            label1.Size = new Size(38, 17);
            label1.TabIndex = 9;
            label1.Text = "Valor";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(204, 19);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 35);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += this.btnRegistrar_Click;
            // 
            // tbValor
            // 
            tbValor.Location = new Point(78, 26);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(100, 23);
            tbValor.TabIndex = 7;
            // 
            // FormVectores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 303);
            Controls.Add(tbPromedio);
            Controls.Add(btnPromedio);
            Controls.Add(lbPromedio);
            Controls.Add(label1);
            Controls.Add(btnRegistrar);
            Controls.Add(tbValor);
            Name = "FormVectores";
            Text = "Ejemplo3. Vectores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbPromedio;
        private Button btnPromedio;
        private Label lbPromedio;
        private Label label1;
        private Button btnRegistrar;
        private TextBox tbValor;
    }
}
