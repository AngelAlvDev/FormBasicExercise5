namespace FormBasicExercise5
{
    partial class FormBasicExercise5
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBasicExercise5));
            this.enunciadoLabel = new System.Windows.Forms.Label();
            this.resultadoListBox = new System.Windows.Forms.ListBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.parcialCheckBox = new System.Windows.Forms.CheckBox();
            this.iniciarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // enunciadoLabel
            // 
            this.enunciadoLabel.AutoSize = true;
            this.enunciadoLabel.Location = new System.Drawing.Point(40, 37);
            this.enunciadoLabel.Name = "enunciadoLabel";
            this.enunciadoLabel.Size = new System.Drawing.Size(149, 13);
            this.enunciadoLabel.TabIndex = 0;
            this.enunciadoLabel.Text = "Clacular suma desde 1 hasta: ";
            // 
            // resultadoListBox
            // 
            this.resultadoListBox.FormattingEnabled = true;
            this.resultadoListBox.Location = new System.Drawing.Point(43, 88);
            this.resultadoListBox.Name = "resultadoListBox";
            this.resultadoListBox.Size = new System.Drawing.Size(272, 95);
            this.resultadoListBox.TabIndex = 1;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(195, 35);
            this.numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown.TabIndex = 2;
            this.numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // parcialCheckBox
            // 
            this.parcialCheckBox.AutoSize = true;
            this.parcialCheckBox.Location = new System.Drawing.Point(43, 65);
            this.parcialCheckBox.Name = "parcialCheckBox";
            this.parcialCheckBox.Size = new System.Drawing.Size(138, 17);
            this.parcialCheckBox.TabIndex = 3;
            this.parcialCheckBox.Text = "Ver resultados parciales";
            this.parcialCheckBox.UseVisualStyleBackColor = true;
            // 
            // iniciarButton
            // 
            this.iniciarButton.Location = new System.Drawing.Point(151, 213);
            this.iniciarButton.Name = "iniciarButton";
            this.iniciarButton.Size = new System.Drawing.Size(75, 23);
            this.iniciarButton.TabIndex = 4;
            this.iniciarButton.Text = "Iniciar";
            this.iniciarButton.UseVisualStyleBackColor = true;
            this.iniciarButton.Click += new System.EventHandler(this.iniciarButton_Click);
            // 
            // FormBasicExercise5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 283);
            this.Controls.Add(this.iniciarButton);
            this.Controls.Add(this.parcialCheckBox);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.resultadoListBox);
            this.Controls.Add(this.enunciadoLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBasicExercise5";
            this.Text = "Suma 1...n";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enunciadoLabel;
        private System.Windows.Forms.ListBox resultadoListBox;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.CheckBox parcialCheckBox;
        private System.Windows.Forms.Button iniciarButton;
    }
}

