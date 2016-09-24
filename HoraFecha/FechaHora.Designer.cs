namespace HoraFecha
{
    partial class FechaHora
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
            this.dateBox = new System.Windows.Forms.ListBox();
            this.btnDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateBox
            // 
            this.dateBox.FormattingEnabled = true;
            this.dateBox.Location = new System.Drawing.Point(59, 56);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(159, 30);
            this.dateBox.TabIndex = 0;
            // 
            // btnDate
            // 
            this.btnDate.Location = new System.Drawing.Point(98, 27);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(75, 23);
            this.btnDate.TabIndex = 1;
            this.btnDate.Text = "Mostrar";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // FechaHora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 115);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.dateBox);
            this.Name = "FechaHora";
            this.Text = "Fecha y Hora";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox dateBox;
        private System.Windows.Forms.Button btnDate;
    }
}

