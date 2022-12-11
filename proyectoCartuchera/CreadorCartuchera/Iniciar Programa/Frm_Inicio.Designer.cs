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
            this.gb_importar = new System.Windows.Forms.GroupBox();
            this.btn_importarXlm = new System.Windows.Forms.Button();
            this.btn_importarJson = new System.Windows.Forms.Button();
            this.dgv_cartucheraImportada = new System.Windows.Forms.DataGridView();
            this.btn_mostrarImoprtar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.gb_importar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cartucheraImportada)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(438, 134);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(212, 47);
            this.btn_0.TabIndex = 0;
            this.btn_0.Text = "btn_0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(201, 134);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(212, 47);
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
            // gb_importar
            // 
            this.gb_importar.Controls.Add(this.btn_importarXlm);
            this.gb_importar.Controls.Add(this.btn_importarJson);
            this.gb_importar.Location = new System.Drawing.Point(36, 280);
            this.gb_importar.Name = "gb_importar";
            this.gb_importar.Size = new System.Drawing.Size(250, 125);
            this.gb_importar.TabIndex = 4;
            this.gb_importar.TabStop = false;
            this.gb_importar.Text = "Importar cartuchera";
            // 
            // btn_importarXlm
            // 
            this.btn_importarXlm.Location = new System.Drawing.Point(19, 81);
            this.btn_importarXlm.Name = "btn_importarXlm";
            this.btn_importarXlm.Size = new System.Drawing.Size(214, 28);
            this.btn_importarXlm.TabIndex = 5;
            this.btn_importarXlm.Text = "Importar .xlm";
            this.btn_importarXlm.UseVisualStyleBackColor = true;
            // 
            // btn_importarJson
            // 
            this.btn_importarJson.Location = new System.Drawing.Point(19, 46);
            this.btn_importarJson.Name = "btn_importarJson";
            this.btn_importarJson.Size = new System.Drawing.Size(214, 29);
            this.btn_importarJson.TabIndex = 0;
            this.btn_importarJson.Text = "Importar .json";
            this.btn_importarJson.UseVisualStyleBackColor = true;
            this.btn_importarJson.Click += new System.EventHandler(this.btn_importarJson_Click);
            // 
            // dgv_cartucheraImportada
            // 
            this.dgv_cartucheraImportada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cartucheraImportada.Location = new System.Drawing.Point(317, 280);
            this.dgv_cartucheraImportada.Name = "dgv_cartucheraImportada";
            this.dgv_cartucheraImportada.RowHeadersWidth = 51;
            this.dgv_cartucheraImportada.RowTemplate.Height = 29;
            this.dgv_cartucheraImportada.Size = new System.Drawing.Size(447, 125);
            this.dgv_cartucheraImportada.TabIndex = 5;
            // 
            // btn_mostrarImoprtar
            // 
            this.btn_mostrarImoprtar.Location = new System.Drawing.Point(330, 223);
            this.btn_mostrarImoprtar.Name = "btn_mostrarImoprtar";
            this.btn_mostrarImoprtar.Size = new System.Drawing.Size(190, 29);
            this.btn_mostrarImoprtar.TabIndex = 6;
            this.btn_mostrarImoprtar.Text = "Importar cartuchera";
            this.btn_mostrarImoprtar.UseVisualStyleBackColor = true;
            this.btn_mostrarImoprtar.Click += new System.EventHandler(this.btn_mostrarImoprtar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(568, 411);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(94, 29);
            this.btn_modificar.TabIndex = 7;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(670, 410);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(94, 29);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // Frm_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_mostrarImoprtar);
            this.Controls.Add(this.dgv_cartucheraImportada);
            this.Controls.Add(this.gb_importar);
            this.Controls.Add(this.lbl_msjInicio);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_0);
            this.Name = "Frm_Inicio";
            this.Text = "Cartuchera";
            this.Load += new System.EventHandler(this.Frm_Inicio_Load_1);
            this.gb_importar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cartucheraImportada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_0;
        private Button btn_1;
        private Label lbl_titulo;
        private Label lbl_msjInicio;
        private GroupBox gb_importar;
        private Button btn_importarXlm;
        private Button btn_importarJson;
        private DataGridView dgv_cartucheraImportada;
        private Button btn_mostrarImoprtar;
        private Button btn_modificar;
        private Button btn_cancelar;
    }
}