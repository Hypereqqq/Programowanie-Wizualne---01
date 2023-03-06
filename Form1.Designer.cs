namespace PK02
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Przycisk = new System.Windows.Forms.Label();
            this.Zegarek = new System.Windows.Forms.Timer(this.components);
            this.PrzyciskStoper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Przycisk
            // 
            this.Przycisk.AutoSize = true;
            this.Przycisk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Przycisk.Location = new System.Drawing.Point(345, 114);
            this.Przycisk.Name = "Przycisk";
            this.Przycisk.Size = new System.Drawing.Size(62, 21);
            this.Przycisk.TabIndex = 0;
            this.Przycisk.Text = "KLIKNIJ";
            this.Przycisk.Click += new System.EventHandler(this.Przycisk_Click);
            // 
            // Zegarek
            // 
            this.Zegarek.Enabled = true;
            this.Zegarek.Interval = 1000;
            this.Zegarek.Tick += new System.EventHandler(this.Przycisk_Click);
            // 
            // PrzyciskStoper
            // 
            this.PrzyciskStoper.Location = new System.Drawing.Point(345, 359);
            this.PrzyciskStoper.Name = "PrzyciskStoper";
            this.PrzyciskStoper.Size = new System.Drawing.Size(91, 36);
            this.PrzyciskStoper.TabIndex = 1;
            this.PrzyciskStoper.Text = "STOPER";
            this.PrzyciskStoper.UseVisualStyleBackColor = true;
            this.PrzyciskStoper.Click += new System.EventHandler(this.PrzyciskStoper_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PrzyciskStoper);
            this.Controls.Add(this.Przycisk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Przycisk;
        private System.Windows.Forms.Timer Zegarek;
        private Button PrzyciskStoper;
    }
}