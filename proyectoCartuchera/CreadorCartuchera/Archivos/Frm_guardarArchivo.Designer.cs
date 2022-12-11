namespace CreadorCartuchera
{
    partial class Frm_guardarArchivo
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
            this.btn_json = new System.Windows.Forms.Button();
            this.btn_xml = new System.Windows.Forms.Button();
            this.lbl_mensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_json
            // 
            this.btn_json.Location = new System.Drawing.Point(51, 151);
            this.btn_json.Name = "btn_json";
            this.btn_json.Size = new System.Drawing.Size(184, 89);
            this.btn_json.TabIndex = 0;
            this.btn_json.Text = ".json";
            this.btn_json.UseVisualStyleBackColor = true;
            this.btn_json.Click += new System.EventHandler(this.btn_json_Click);
            // 
            // btn_xml
            // 
            this.btn_xml.Location = new System.Drawing.Point(51, 268);
            this.btn_xml.Name = "btn_xml";
            this.btn_xml.Size = new System.Drawing.Size(184, 89);
            this.btn_xml.TabIndex = 1;
            this.btn_xml.Text = ".xml";
            this.btn_xml.UseVisualStyleBackColor = true;
            // 
            // lbl_mensaje
            // 
            this.lbl_mensaje.AutoSize = true;
            this.lbl_mensaje.Location = new System.Drawing.Point(51, 61);
            this.lbl_mensaje.Name = "lbl_mensaje";
            this.lbl_mensaje.Size = new System.Drawing.Size(191, 20);
            this.lbl_mensaje.TabIndex = 2;
            this.lbl_mensaje.Text = "En qué formato lo guarda? ";
            // 
            // Frm_guardarArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 426);
            this.Controls.Add(this.lbl_mensaje);
            this.Controls.Add(this.btn_xml);
            this.Controls.Add(this.btn_json);
            this.Name = "Frm_guardarArchivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guardar cartuchera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_json;
        private Button btn_xml;
        private Label lbl_mensaje;
    }
}