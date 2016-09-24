namespace OrdenAlfabetico
{
    partial class OrdenAlfabetico
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
            this.addBtn = new System.Windows.Forms.Button();
            this.sortBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stringBox
            // 
            this.stringBox.Location = new System.Drawing.Point(71, 27);
            this.stringBox.Name = "stringBox";
            this.stringBox.Size = new System.Drawing.Size(120, 20);
            this.stringBox.TabIndex = 0;
            // 
            // lboxString
            // 
            this.lboxString.FormattingEnabled = true;
            this.lboxString.Location = new System.Drawing.Point(71, 101);
            this.lboxString.Name = "lboxString";
            this.lboxString.Size = new System.Drawing.Size(120, 95);
            this.lboxString.TabIndex = 1;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(71, 62);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(120, 23);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Agregar";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(71, 202);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(120, 23);
            this.sortBtn.TabIndex = 3;
            this.sortBtn.Text = "Ordenar";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Palabra";
            // 
            // OrdenAlfabetico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.lboxString);
            this.Controls.Add(this.stringBox);
            this.Name = "OrdenAlfabetico";
            this.Text = "Orden alfabetico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stringBox;
        private System.Windows.Forms.ListBox lboxString;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Label label1;
    }
}

