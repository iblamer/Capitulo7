namespace PalabraPorLinea
{
    partial class PalabraPorLinea
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
            this.lboxString = new System.Windows.Forms.ListBox();
            this.btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stringBox
            // 
            this.stringBox.Location = new System.Drawing.Point(74, 55);
            this.stringBox.Name = "stringBox";
            this.stringBox.Size = new System.Drawing.Size(120, 20);
            this.stringBox.TabIndex = 0;
            // 
            // lboxString
            // 
            this.lboxString.FormattingEnabled = true;
            this.lboxString.Location = new System.Drawing.Point(74, 124);
            this.lboxString.Name = "lboxString";
            this.lboxString.Size = new System.Drawing.Size(120, 95);
            this.lboxString.TabIndex = 1;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(74, 81);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(120, 23);
            this.btn.TabIndex = 2;
            this.btn.Text = "Separar por lineas";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese una oracion";
            // 
            // PalabraPorLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lboxString);
            this.Controls.Add(this.stringBox);
            this.Name = "PalabraPorLinea";
            this.Text = "Separar palabras por linea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stringBox;
        private System.Windows.Forms.ListBox lboxString;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label1;
    }
}

