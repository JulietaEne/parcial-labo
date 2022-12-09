namespace CreadorCartuchera.Iniciar_Programa
{
    partial class Frm_personalizarCartuchera
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
            System.Windows.Forms.Label lbl_inputCapacidad;
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_inputPrecio = new System.Windows.Forms.Label();
            this.tbx_inputCapacidad = new System.Windows.Forms.TextBox();
            this.tbx_inputPrecio = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_mensaje = new System.Windows.Forms.Label();
            this.btn_noModificar = new System.Windows.Forms.Button();
            lbl_inputCapacidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_inputCapacidad
            // 
            lbl_inputCapacidad.AutoSize = true;
            lbl_inputCapacidad.Location = new System.Drawing.Point(67, 84);
            lbl_inputCapacidad.Name = "lbl_inputCapacidad";
            lbl_inputCapacidad.Size = new System.Drawing.Size(190, 20);
            lbl_inputCapacidad.TabIndex = 6;
            lbl_inputCapacidad.Text = "Capacidad de la cartuchera";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.Location = new System.Drawing.Point(102, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(119, 35);
            this.lbl_titulo.TabIndex = 4;
            this.lbl_titulo.Text = "lbl_titulo";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_inputPrecio
            // 
            this.lbl_inputPrecio.AutoSize = true;
            this.lbl_inputPrecio.Location = new System.Drawing.Point(105, 158);
            this.lbl_inputPrecio.Name = "lbl_inputPrecio";
            this.lbl_inputPrecio.Size = new System.Drawing.Size(116, 20);
            this.lbl_inputPrecio.TabIndex = 7;
            this.lbl_inputPrecio.Text = "Alerta de precio";
            // 
            // tbx_inputCapacidad
            // 
            this.tbx_inputCapacidad.Location = new System.Drawing.Point(102, 107);
            this.tbx_inputCapacidad.Name = "tbx_inputCapacidad";
            this.tbx_inputCapacidad.Size = new System.Drawing.Size(125, 27);
            this.tbx_inputCapacidad.TabIndex = 8;
            this.tbx_inputCapacidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_inputCapacidad_KeyPress);
            // 
            // tbx_inputPrecio
            // 
            this.tbx_inputPrecio.Location = new System.Drawing.Point(102, 181);
            this.tbx_inputPrecio.Name = "tbx_inputPrecio";
            this.tbx_inputPrecio.Size = new System.Drawing.Size(125, 27);
            this.tbx_inputPrecio.TabIndex = 9;
            this.tbx_inputPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_inputPrecio_KeyPress);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(78, 315);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(196, 29);
            this.btn_guardar.TabIndex = 10;
            this.btn_guardar.Text = "Guardar Cambios";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_mensaje
            // 
            this.lbl_mensaje.AutoSize = true;
            this.lbl_mensaje.Location = new System.Drawing.Point(67, 268);
            this.lbl_mensaje.Name = "lbl_mensaje";
            this.lbl_mensaje.Size = new System.Drawing.Size(87, 20);
            this.lbl_mensaje.TabIndex = 11;
            this.lbl_mensaje.Text = "lbl_mensaje";
            // 
            // btn_noModificar
            // 
            this.btn_noModificar.Location = new System.Drawing.Point(78, 350);
            this.btn_noModificar.Name = "btn_noModificar";
            this.btn_noModificar.Size = new System.Drawing.Size(196, 29);
            this.btn_noModificar.TabIndex = 12;
            this.btn_noModificar.Text = "Continuar sin modificar";
            this.btn_noModificar.UseVisualStyleBackColor = true;
            this.btn_noModificar.Click += new System.EventHandler(this.btn_noModificar_Click);
            // 
            // Frm_personalizarCartuchera
            // 
            this.ClientSize = new System.Drawing.Size(343, 445);
            this.Controls.Add(this.btn_noModificar);
            this.Controls.Add(this.lbl_mensaje);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.tbx_inputPrecio);
            this.Controls.Add(this.tbx_inputCapacidad);
            this.Controls.Add(this.lbl_inputPrecio);
            this.Controls.Add(lbl_inputCapacidad);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Frm_personalizarCartuchera";
            this.Text = "Personalizar Cartuchera";
            this.Load += new System.EventHandler(this.Frm_personalizarCartuchera_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Label lbl_titulo;
        private Label lbl_inputPrecio;
        private TextBox tbx_inputCapacidad;
        private TextBox tbx_inputPrecio;
        private Button btn_guardar;
        private Label lbl_mensaje;
        private Button btn_noModificar;
    }
}