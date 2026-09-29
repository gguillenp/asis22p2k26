namespace CapaVista_Mantenimiento2k26
{
    partial class MantenimientoBodega
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
            this.navegador1 = new CapaVista_Navegador.Navegador();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(12, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1438, 111);
            this.navegador1.TabIndex = 0;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1447, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reporte";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MantenimientoBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1611, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.navegador1);
            this.Name = "MantenimientoBodega";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MantenimientoBodega_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Navegador.Navegador navegador1;
        private System.Windows.Forms.Button button1;
    }
}