namespace Capitulo7
{
    partial class CalificacionesList
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
            this.addBtn = new System.Windows.Forms.Button();
            this.califBox = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.minBox = new System.Windows.Forms.TextBox();
            this.promBox = new System.Windows.Forms.TextBox();
            this.maxBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(12, 61);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // califBox
            // 
            this.califBox.Location = new System.Drawing.Point(12, 35);
            this.califBox.Name = "califBox";
            this.califBox.Size = new System.Drawing.Size(100, 20);
            this.califBox.TabIndex = 1;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 106);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(226, 173);
            this.listBox.TabIndex = 2;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // minBox
            // 
            this.minBox.Location = new System.Drawing.Point(244, 184);
            this.minBox.Name = "minBox";
            this.minBox.ReadOnly = true;
            this.minBox.Size = new System.Drawing.Size(100, 20);
            this.minBox.TabIndex = 3;
            // 
            // promBox
            // 
            this.promBox.Location = new System.Drawing.Point(244, 259);
            this.promBox.Name = "promBox";
            this.promBox.ReadOnly = true;
            this.promBox.Size = new System.Drawing.Size(100, 20);
            this.promBox.TabIndex = 4;
            // 
            // maxBox
            // 
            this.maxBox.Location = new System.Drawing.Point(244, 106);
            this.maxBox.Name = "maxBox";
            this.maxBox.ReadOnly = true;
            this.maxBox.Size = new System.Drawing.Size(100, 20);
            this.maxBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Calificacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Calificacion mas alta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Calificacion mas baja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Promedio";
            // 
            // CalificacionesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 326);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxBox);
            this.Controls.Add(this.promBox);
            this.Controls.Add(this.minBox);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.califBox);
            this.Controls.Add(this.addBtn);
            this.Name = "CalificacionesList";
            this.Text = "Calificaciones usando List<>";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox califBox;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox minBox;
        private System.Windows.Forms.TextBox promBox;
        private System.Windows.Forms.TextBox maxBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

