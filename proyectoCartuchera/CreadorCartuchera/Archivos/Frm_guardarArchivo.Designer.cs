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
            this.rbtn_claseLapiz = new System.Windows.Forms.RadioButton();
            this.gb_dato = new System.Windows.Forms.GroupBox();
            this.rbtn_cartuchera = new System.Windows.Forms.RadioButton();
            this.gb_tipoArchivo = new System.Windows.Forms.GroupBox();
            this.txb_nombreArchivo = new System.Windows.Forms.TextBox();
            this.gb_dato.SuspendLayout();
            this.gb_tipoArchivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_json
            // 
            this.btn_json.Location = new System.Drawing.Point(39, 82);
            this.btn_json.Name = "btn_json";
            this.btn_json.Size = new System.Drawing.Size(184, 89);
            this.btn_json.TabIndex = 0;
            this.btn_json.Text = "Guardar en .json";
            this.btn_json.UseVisualStyleBackColor = true;
            this.btn_json.Click += new System.EventHandler(this.btn_json_Click);
            // 
            // btn_xml
            // 
            this.btn_xml.Location = new System.Drawing.Point(39, 177);
            this.btn_xml.Name = "btn_xml";
            this.btn_xml.Size = new System.Drawing.Size(184, 89);
            this.btn_xml.TabIndex = 1;
            this.btn_xml.Text = "Guardar en .xml";
            this.btn_xml.UseVisualStyleBackColor = true;
            // 
            // rbtn_claseLapiz
            // 
            this.rbtn_claseLapiz.AutoSize = true;
            this.rbtn_claseLapiz.Location = new System.Drawing.Point(39, 40);
            this.rbtn_claseLapiz.Name = "rbtn_claseLapiz";
            this.rbtn_claseLapiz.Size = new System.Drawing.Size(134, 24);
            this.rbtn_claseLapiz.TabIndex = 3;
            this.rbtn_claseLapiz.TabStop = true;
            this.rbtn_claseLapiz.Text = "Lista de Lápices";
            this.rbtn_claseLapiz.UseVisualStyleBackColor = true;
            // 
            // gb_dato
            // 
            this.gb_dato.Controls.Add(this.rbtn_cartuchera);
            this.gb_dato.Controls.Add(this.rbtn_claseLapiz);
            this.gb_dato.Location = new System.Drawing.Point(21, 12);
            this.gb_dato.Name = "gb_dato";
            this.gb_dato.Size = new System.Drawing.Size(250, 113);
            this.gb_dato.TabIndex = 4;
            this.gb_dato.TabStop = false;
            this.gb_dato.Text = "Indique datos a guardar";
            this.gb_dato.Enter += new System.EventHandler(this.gb_dato_Enter);
            // 
            // rbtn_cartuchera
            // 
            this.rbtn_cartuchera.AutoSize = true;
            this.rbtn_cartuchera.Location = new System.Drawing.Point(39, 70);
            this.rbtn_cartuchera.Name = "rbtn_cartuchera";
            this.rbtn_cartuchera.Size = new System.Drawing.Size(168, 24);
            this.rbtn_cartuchera.TabIndex = 4;
            this.rbtn_cartuchera.TabStop = true;
            this.rbtn_cartuchera.Text = "Cartuchera completa";
            this.rbtn_cartuchera.UseVisualStyleBackColor = true;
            // 
            // gb_tipoArchivo
            // 
            this.gb_tipoArchivo.Controls.Add(this.txb_nombreArchivo);
            this.gb_tipoArchivo.Controls.Add(this.btn_xml);
            this.gb_tipoArchivo.Controls.Add(this.btn_json);
            this.gb_tipoArchivo.Location = new System.Drawing.Point(21, 131);
            this.gb_tipoArchivo.Name = "gb_tipoArchivo";
            this.gb_tipoArchivo.Size = new System.Drawing.Size(250, 272);
            this.gb_tipoArchivo.TabIndex = 5;
            this.gb_tipoArchivo.TabStop = false;
            this.gb_tipoArchivo.Text = "Guardar archivo";
            // 
            // txb_nombreArchivo
            // 
            this.txb_nombreArchivo.Location = new System.Drawing.Point(29, 38);
            this.txb_nombreArchivo.Name = "txb_nombreArchivo";
            this.txb_nombreArchivo.PlaceholderText = "Nombre de archivo";
            this.txb_nombreArchivo.Size = new System.Drawing.Size(203, 27);
            this.txb_nombreArchivo.TabIndex = 2;
            // 
            // Frm_guardarArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 426);
            this.Controls.Add(this.gb_tipoArchivo);
            this.Controls.Add(this.gb_dato);
            this.Name = "Frm_guardarArchivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guardar cartuchera";
            this.Load += new System.EventHandler(this.Frm_guardarArchivo_Load);
            this.gb_dato.ResumeLayout(false);
            this.gb_dato.PerformLayout();
            this.gb_tipoArchivo.ResumeLayout(false);
            this.gb_tipoArchivo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_json;
        private Button btn_xml;
        private RadioButton rbtn_claseLapiz;
        private GroupBox gb_dato;
        private GroupBox gb_tipoArchivo;
        private RadioButton rbtn_cartuchera;
        private TextBox txb_nombreArchivo;
    }
}