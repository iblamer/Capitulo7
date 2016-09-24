namespace JustificarCadena
{
    partial class JustificarCadena
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.stringBox = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.lboxString = new System.Windows.Forms.ListBox();
            this.lineCheck = new System.Windows.Forms.RadioButton();
            this.spaceCheck = new System.Windows.Forms.RadioButton();
            this.guionCheck = new System.Windows.Forms.RadioButton();
            this.slashCheck = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stringBox
            // 
            this.stringBox.Location = new System.Drawing.Point(12, 36);
            this.stringBox.Name = "stringBox";
            this.stringBox.Size = new System.Drawing.Size(166, 20);
            this.stringBox.TabIndex = 4;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(12, 117);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(166, 23);
            this.btn.TabIndex = 5;
            this.btn.Text = "Generar cadena";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lboxString
            // 
            this.lboxString.FormattingEnabled = true;
            this.lboxString.Location = new System.Drawing.Point(2, 154);
            this.lboxString.Name = "lboxString";
            this.lboxString.Size = new System.Drawing.Size(270, 95);
            this.lboxString.TabIndex = 6;
            // 
            // lineCheck
            // 
            this.lineCheck.AutoSize = true;
            this.lineCheck.Location = new System.Drawing.Point(12, 62);
            this.lineCheck.Name = "lineCheck";
            this.lineCheck.Size = new System.Drawing.Size(105, 17);
            this.lineCheck.TabIndex = 7;
            this.lineCheck.TabStop = true;
            this.lineCheck.Text = "Separar por linea";
            this.lineCheck.UseVisualStyleBackColor = true;
            // 
            // spaceCheck
            // 
            this.spaceCheck.AutoSize = true;
            this.spaceCheck.Location = new System.Drawing.Point(138, 94);
            this.spaceCheck.Name = "spaceCheck";
            this.spaceCheck.Size = new System.Drawing.Size(98, 17);
            this.spaceCheck.TabIndex = 8;
            this.spaceCheck.TabStop = true;
            this.spaceCheck.Text = "Quitar espacios";
            this.spaceCheck.UseVisualStyleBackColor = true;
            // 
            // guionCheck
            // 
            this.guionCheck.AutoSize = true;
            this.guionCheck.Location = new System.Drawing.Point(12, 94);
            this.guionCheck.Name = "guionCheck";
            this.guionCheck.Size = new System.Drawing.Size(120, 17);
            this.guionCheck.TabIndex = 9;
            this.guionCheck.TabStop = true;
            this.guionCheck.Text = "Separar por guiones";
            this.guionCheck.UseVisualStyleBackColor = true;
            // 
            // slashCheck
            // 
            this.slashCheck.AutoSize = true;
            this.slashCheck.Location = new System.Drawing.Point(138, 62);
            this.slashCheck.Name = "slashCheck";
            this.slashCheck.Size = new System.Drawing.Size(112, 17);
            this.slashCheck.TabIndex = 10;
            this.slashCheck.TabStop = true;
            this.slashCheck.Text = "Separar por slashs";
            this.slashCheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cadena";
            // 
            // JustificarCadena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.slashCheck);
            this.Controls.Add(this.guionCheck);
            this.Controls.Add(this.spaceCheck);
            this.Controls.Add(this.lineCheck);
            this.Controls.Add(this.lboxString);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.stringBox);
            this.Name = "JustificarCadena";
            this.Text = "Formato de cadenas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox stringBox;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.ListBox lboxString;
        private System.Windows.Forms.RadioButton lineCheck;
        private System.Windows.Forms.RadioButton spaceCheck;
        private System.Windows.Forms.RadioButton guionCheck;
        private System.Windows.Forms.RadioButton slashCheck;
        private System.Windows.Forms.Label label1;
    }
}

