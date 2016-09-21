namespace SumaDeGastos
{
    partial class Form1
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
            this.gastosTBox = new System.Windows.Forms.TextBox();
            this.sumBox = new System.Windows.Forms.TextBox();
            this.gastosLBox = new System.Windows.Forms.ListBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gastosTBox
            // 
            this.gastosTBox.Location = new System.Drawing.Point(12, 34);
            this.gastosTBox.Name = "gastosTBox";
            this.gastosTBox.Size = new System.Drawing.Size(120, 20);
            this.gastosTBox.TabIndex = 0;
            // 
            // sumBox
            // 
            this.sumBox.Location = new System.Drawing.Point(172, 130);
            this.sumBox.Name = "sumBox";
            this.sumBox.Size = new System.Drawing.Size(100, 20);
            this.sumBox.TabIndex = 1;
            // 
            // gastosLBox
            // 
            this.gastosLBox.FormattingEnabled = true;
            this.gastosLBox.Location = new System.Drawing.Point(12, 89);
            this.gastosLBox.Name = "gastosLBox";
            this.gastosLBox.Size = new System.Drawing.Size(120, 147);
            this.gastosLBox.TabIndex = 2;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(12, 60);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(120, 23);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gasto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Suma";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.gastosLBox);
            this.Controls.Add(this.sumBox);
            this.Controls.Add(this.gastosTBox);
            this.Name = "Form1";
            this.Text = "Suma de gastos usando stacks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gastosTBox;
        private System.Windows.Forms.TextBox sumBox;
        private System.Windows.Forms.ListBox gastosLBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

