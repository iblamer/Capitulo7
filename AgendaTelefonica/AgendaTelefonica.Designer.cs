namespace AgendaTelefonica
{
    partial class AgendaTelefonica
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.telBox = new System.Windows.Forms.MaskedTextBox();
            this.agendaBox = new System.Windows.Forms.ListBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(12, 30);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 0;
            // 
            // telBox
            // 
            this.telBox.Location = new System.Drawing.Point(12, 63);
            this.telBox.Mask = "999-999-9999";
            this.telBox.Name = "telBox";
            this.telBox.Size = new System.Drawing.Size(100, 20);
            this.telBox.TabIndex = 1;
            // 
            // agendaBox
            // 
            this.agendaBox.FormattingEnabled = true;
            this.agendaBox.Location = new System.Drawing.Point(12, 89);
            this.agendaBox.Name = "agendaBox";
            this.agendaBox.Size = new System.Drawing.Size(250, 160);
            this.agendaBox.TabIndex = 2;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(137, 60);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(125, 23);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // AgendaTelefonica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.agendaBox);
            this.Controls.Add(this.telBox);
            this.Controls.Add(this.nameBox);
            this.Name = "AgendaTelefonica";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.MaskedTextBox telBox;
        private System.Windows.Forms.ListBox agendaBox;
        private System.Windows.Forms.Button addBtn;
    }
}

