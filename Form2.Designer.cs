namespace PK02
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.PrzyciskStart = new System.Windows.Forms.Button();
            this.PrzyciskStop = new System.Windows.Forms.Button();
            this.CzasStopera = new System.Windows.Forms.Label();
            this.CzasStopera2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PrzyciskStart
            // 
            this.PrzyciskStart.Location = new System.Drawing.Point(355, 232);
            this.PrzyciskStart.Name = "PrzyciskStart";
            this.PrzyciskStart.Size = new System.Drawing.Size(75, 23);
            this.PrzyciskStart.TabIndex = 0;
            this.PrzyciskStart.Text = "START";
            this.PrzyciskStart.UseVisualStyleBackColor = true;
            this.PrzyciskStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // PrzyciskStop
            // 
            this.PrzyciskStop.Location = new System.Drawing.Point(355, 292);
            this.PrzyciskStop.Name = "PrzyciskStop";
            this.PrzyciskStop.Size = new System.Drawing.Size(75, 23);
            this.PrzyciskStop.TabIndex = 1;
            this.PrzyciskStop.Text = "STOP";
            this.PrzyciskStop.UseVisualStyleBackColor = true;
            this.PrzyciskStop.Click += new System.EventHandler(this.button2_Click);
            // 
            // CzasStopera
            // 
            this.CzasStopera.AutoSize = true;
            this.CzasStopera.Location = new System.Drawing.Point(375, 141);
            this.CzasStopera.Name = "CzasStopera";
            this.CzasStopera.Size = new System.Drawing.Size(36, 15);
            this.CzasStopera.TabIndex = 2;
            this.CzasStopera.Text = "CZAS";
            this.CzasStopera.Click += new System.EventHandler(this.CzasStopera_Click);
            // 
            // CzasStopera2
            // 
            this.CzasStopera2.Enabled = true;
            this.CzasStopera2.Interval = 1000;
            this.CzasStopera2.Tick += new System.EventHandler(this.CzasStopera_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CzasStopera);
            this.Controls.Add(this.PrzyciskStop);
            this.Controls.Add(this.PrzyciskStart);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button PrzyciskStart;
        private Button PrzyciskStop;
        private Label CzasStopera;
        private System.Windows.Forms.Timer CzasStopera2;
    }
}