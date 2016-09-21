namespace ServicioAlClienteQueue
{
    partial class ServicioCliente
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
            this.queueBox = new System.Windows.Forms.ListBox();
            this.clientBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.atenderBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // queueBox
            // 
            this.queueBox.FormattingEnabled = true;
            this.queueBox.Location = new System.Drawing.Point(12, 87);
            this.queueBox.Name = "queueBox";
            this.queueBox.Size = new System.Drawing.Size(248, 160);
            this.queueBox.TabIndex = 1;
            // 
            // clientBox
            // 
            this.clientBox.Location = new System.Drawing.Point(12, 32);
            this.clientBox.Name = "clientBox";
            this.clientBox.Size = new System.Drawing.Size(100, 20);
            this.clientBox.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(12, 58);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Anadir a fila";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // atenderBtn
            // 
            this.atenderBtn.Location = new System.Drawing.Point(185, 58);
            this.atenderBtn.Name = "atenderBtn";
            this.atenderBtn.Size = new System.Drawing.Size(75, 23);
            this.atenderBtn.TabIndex = 3;
            this.atenderBtn.Text = "Atender";
            this.atenderBtn.UseVisualStyleBackColor = true;
            this.atenderBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cliente";
            // 
            // ServicioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.atenderBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.queueBox);
            this.Controls.Add(this.clientBox);
            this.Name = "ServicioCliente";
            this.Text = "Fila de clientes simulacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox queueBox;
        private System.Windows.Forms.TextBox clientBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button atenderBtn;
        private System.Windows.Forms.Label label1;
    }
}

