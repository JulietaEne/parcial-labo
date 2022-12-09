namespace CreadorCartuchera.Iniciar_Programa
{
    partial class Frm_Inicio
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
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_msjInicio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(446, 198);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(212, 29);
            this.btn_0.TabIndex = 0;
            this.btn_0.Text = "btn_0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(169, 198);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(212, 29);
            this.btn_1.TabIndex = 1;
            this.btn_1.Text = "btn_1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click_1);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Location = new System.Drawing.Point(346, 30);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(67, 20);
            this.lbl_titulo.TabIndex = 2;
            this.lbl_titulo.Text = "lbl_titulo";
            // 
            // lbl_msjInicio
            // 
            this.lbl_msjInicio.AutoSize = true;
            this.lbl_msjInicio.Location = new System.Drawing.Point(36, 95);
            this.lbl_msjInicio.Name = "lbl_msjInicio";
            this.lbl_msjInicio.Size = new System.Drawing.Size(91, 20);
            this.lbl_msjInicio.TabIndex = 3;
            this.lbl_msjInicio.Text = "lbl_msjInicio";
            // 
            // Frm_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_msjInicio);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_0);
            this.Name = "Frm_Inicio";
            this.Text = "Cartuchera";
            this.Load += new System.EventHandler(this.Frm_Inicio_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_0;
        private Button btn_1;
        private Label lbl_titulo;
        private Label lbl_msjInicio;
    }
}