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
            btnOrdenar = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // tbPromedio
            // 
            tbPromedio.Location = new Point(12, 132);
            tbPromedio.Multiline = true;
            tbPromedio.Name = "tbPromedio";
            tbPromedio.Size = new Size(407, 134);
            tbPromedio.TabIndex = 12;
            // 
            // btnPromedio
            // 
            btnPromedio.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPromedio.Location = new Point(311, 65);
            btnPromedio.Name = "btnPromedio";
            btnPromedio.Size = new Size(75, 53);
            btnPromedio.TabIndex = 11;
            btnPromedio.Text = "Calcular Promedio";
            btnPromedio.UseVisualStyleBackColor = true;
            btnPromedio.Click += btnPromedio_Click;
            // 
            // lbPromedio
            // 
            lbPromedio.AutoSize = true;
            lbPromedio.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPromedio.Location = new Point(153, 82);
            lbPromedio.Name = "lbPromedio";
            lbPromedio.Size = new Size(78, 17);
            lbPromedio.TabIndex = 10;
            lbPromedio.Text = "lbPromedio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 24);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 9;
            label1.Text = "Valor";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(311, 18);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 35);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // tbValor
            // 
            tbValor.Location = new Point(115, 25);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(160, 23);
            tbValor.TabIndex = 7;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrdenar.Location = new Point(344, 283);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(75, 30);
            btnOrdenar.TabIndex = 13;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += this.btnOrdenar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkTurquoise;
            label2.Location = new Point(4, 309);
            label2.Name = "label2";
            label2.Size = new Size(33, 13);
            label2.TabIndex = 14;
            label2.Text = "Miku";
            // 
            // FormVectores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 329);
            Controls.Add(label2);
            Controls.Add(btnOrdenar);
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
        private Button btnOrdenar;
        private Label label2;
    }
}
