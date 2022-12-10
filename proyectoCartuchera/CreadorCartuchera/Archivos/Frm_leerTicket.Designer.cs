namespace CreadorCartuchera.Archivos
{
    partial class Frm_leerTicket
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
            this.rtxb_leerTicket = new System.Windows.Forms.RichTextBox();
            this.lbl_ruta = new System.Windows.Forms.Label();
            this.btn_atras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxb_leerTicket
            // 
            this.rtxb_leerTicket.Enabled = false;
            this.rtxb_leerTicket.Location = new System.Drawing.Point(28, 71);
            this.rtxb_leerTicket.Name = "rtxb_leerTicket";
            this.rtxb_leerTicket.Size = new System.Drawing.Size(695, 340);
            this.rtxb_leerTicket.TabIndex = 0;
            this.rtxb_leerTicket.Text = "";
            // 
            // lbl_ruta
            // 
            this.lbl_ruta.AutoSize = true;
            this.lbl_ruta.Location = new System.Drawing.Point(28, 29);
            this.lbl_ruta.Name = "lbl_ruta";
            this.lbl_ruta.Size = new System.Drawing.Size(58, 20);
            this.lbl_ruta.TabIndex = 1;
            this.lbl_ruta.Text = "lbl_ruta";
            // 
            // btn_atras
            // 
            this.btn_atras.Location = new System.Drawing.Point(361, 427);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(94, 29);
            this.btn_atras.TabIndex = 2;
            this.btn_atras.Text = "Atras";
            this.btn_atras.UseVisualStyleBackColor = false;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // Frm_leerTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.lbl_ruta);
            this.Controls.Add(this.rtxb_leerTicket);
            this.Name = "Frm_leerTicket";
            this.Text = "Lectura de ticket";
            this.Load += new System.EventHandler(this.Frm_leerTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox rtxb_leerTicket;
        private Label lbl_ruta;
        private Button btn_atras;
    }
}