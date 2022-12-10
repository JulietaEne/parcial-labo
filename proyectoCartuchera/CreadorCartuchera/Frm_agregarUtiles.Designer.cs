namespace CreadorCartuchera
{
    partial class Frm_agregarUtiles
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
            this.gb_utiles = new System.Windows.Forms.GroupBox();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.cmb_utiles = new System.Windows.Forms.ComboBox();
            this.gb_AgregarUtil = new System.Windows.Forms.GroupBox();
            this.btn_aceptarModificarUtil = new System.Windows.Forms.Button();
            this.lbl_msjError = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.cmb_propiety2 = new System.Windows.Forms.ComboBox();
            this.lbl_inputPropiety2 = new System.Windows.Forms.Label();
            this.lbl_inputPropiety = new System.Windows.Forms.Label();
            this.cmb_marca = new System.Windows.Forms.ComboBox();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.lbl_inputPrecio = new System.Windows.Forms.Label();
            this.txb_inputPropiety = new System.Windows.Forms.TextBox();
            this.txb_inputPrecio = new System.Windows.Forms.TextBox();
            this.dgv_utilesMiCartuchera = new System.Windows.Forms.DataGridView();
            this.lbl_indicacionDgv = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.lbl_detalleSeleccionado = new System.Windows.Forms.Label();
            this.btn_guardarCartuchera = new System.Windows.Forms.Button();
            this.gb_utiles.SuspendLayout();
            this.gb_AgregarUtil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_utilesMiCartuchera)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_utiles
            // 
            this.gb_utiles.Controls.Add(this.btn_seleccionar);
            this.gb_utiles.Controls.Add(this.cmb_utiles);
            this.gb_utiles.Location = new System.Drawing.Point(56, 80);
            this.gb_utiles.Name = "gb_utiles";
            this.gb_utiles.Size = new System.Drawing.Size(278, 171);
            this.gb_utiles.TabIndex = 4;
            this.gb_utiles.TabStop = false;
            this.gb_utiles.Text = "Seleccione un útil para agregar";
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Location = new System.Drawing.Point(90, 86);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(94, 29);
            this.btn_seleccionar.TabIndex = 1;
            this.btn_seleccionar.Text = "seleccionar";
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // cmb_utiles
            // 
            this.cmb_utiles.FormattingEnabled = true;
            this.cmb_utiles.Location = new System.Drawing.Point(18, 38);
            this.cmb_utiles.Name = "cmb_utiles";
            this.cmb_utiles.Size = new System.Drawing.Size(242, 28);
            this.cmb_utiles.TabIndex = 0;
            this.cmb_utiles.Text = "Seleccione un útil";
            this.cmb_utiles.SelectedIndexChanged += new System.EventHandler(this.cmb_utiles_SelectedIndexChanged);
            // 
            // gb_AgregarUtil
            // 
            this.gb_AgregarUtil.Controls.Add(this.btn_aceptarModificarUtil);
            this.gb_AgregarUtil.Controls.Add(this.lbl_msjError);
            this.gb_AgregarUtil.Controls.Add(this.btn_cancelar);
            this.gb_AgregarUtil.Controls.Add(this.btn_agregar);
            this.gb_AgregarUtil.Controls.Add(this.cmb_propiety2);
            this.gb_AgregarUtil.Controls.Add(this.lbl_inputPropiety2);
            this.gb_AgregarUtil.Controls.Add(this.lbl_inputPropiety);
            this.gb_AgregarUtil.Controls.Add(this.cmb_marca);
            this.gb_AgregarUtil.Controls.Add(this.lbl_marca);
            this.gb_AgregarUtil.Controls.Add(this.lbl_inputPrecio);
            this.gb_AgregarUtil.Controls.Add(this.txb_inputPropiety);
            this.gb_AgregarUtil.Controls.Add(this.txb_inputPrecio);
            this.gb_AgregarUtil.Location = new System.Drawing.Point(56, 296);
            this.gb_AgregarUtil.Name = "gb_AgregarUtil";
            this.gb_AgregarUtil.Size = new System.Drawing.Size(278, 297);
            this.gb_AgregarUtil.TabIndex = 5;
            this.gb_AgregarUtil.TabStop = false;
            this.gb_AgregarUtil.Text = "gb_AgregarUtil";
            // 
            // btn_aceptarModificarUtil
            // 
            this.btn_aceptarModificarUtil.Location = new System.Drawing.Point(21, 252);
            this.btn_aceptarModificarUtil.Name = "btn_aceptarModificarUtil";
            this.btn_aceptarModificarUtil.Size = new System.Drawing.Size(94, 29);
            this.btn_aceptarModificarUtil.TabIndex = 11;
            this.btn_aceptarModificarUtil.Text = "Aceptar";
            this.btn_aceptarModificarUtil.UseVisualStyleBackColor = true;
            this.btn_aceptarModificarUtil.Click += new System.EventHandler(this.btn_aceptarModificarUtil_Click);
            // 
            // lbl_msjError
            // 
            this.lbl_msjError.AutoSize = true;
            this.lbl_msjError.ForeColor = System.Drawing.Color.Red;
            this.lbl_msjError.Location = new System.Drawing.Point(28, 195);
            this.lbl_msjError.Name = "lbl_msjError";
            this.lbl_msjError.Size = new System.Drawing.Size(87, 20);
            this.lbl_msjError.TabIndex = 7;
            this.lbl_msjError.Text = "lbl_msjError";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(156, 252);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(94, 29);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(21, 252);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(94, 29);
            this.btn_agregar.TabIndex = 6;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // cmb_propiety2
            // 
            this.cmb_propiety2.FormattingEnabled = true;
            this.cmb_propiety2.Location = new System.Drawing.Point(99, 117);
            this.cmb_propiety2.Name = "cmb_propiety2";
            this.cmb_propiety2.Size = new System.Drawing.Size(151, 28);
            this.cmb_propiety2.TabIndex = 6;
            // 
            // lbl_inputPropiety2
            // 
            this.lbl_inputPropiety2.AutoSize = true;
            this.lbl_inputPropiety2.Location = new System.Drawing.Point(21, 117);
            this.lbl_inputPropiety2.Name = "lbl_inputPropiety2";
            this.lbl_inputPropiety2.Size = new System.Drawing.Size(129, 20);
            this.lbl_inputPropiety2.TabIndex = 6;
            this.lbl_inputPropiety2.Text = "lbl_inputPropiety2";
            // 
            // lbl_inputPropiety
            // 
            this.lbl_inputPropiety.AutoSize = true;
            this.lbl_inputPropiety.Location = new System.Drawing.Point(18, 154);
            this.lbl_inputPropiety.Name = "lbl_inputPropiety";
            this.lbl_inputPropiety.Size = new System.Drawing.Size(121, 20);
            this.lbl_inputPropiety.TabIndex = 5;
            this.lbl_inputPropiety.Text = "lbl_inputPropiety";
            // 
            // cmb_marca
            // 
            this.cmb_marca.FormattingEnabled = true;
            this.cmb_marca.Location = new System.Drawing.Point(99, 83);
            this.cmb_marca.Name = "cmb_marca";
            this.cmb_marca.Size = new System.Drawing.Size(151, 28);
            this.cmb_marca.TabIndex = 4;
            this.cmb_marca.Text = "Seleccione marca";
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Location = new System.Drawing.Point(18, 83);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(53, 20);
            this.lbl_marca.TabIndex = 3;
            this.lbl_marca.Text = "Marca:";
            // 
            // lbl_inputPrecio
            // 
            this.lbl_inputPrecio.AutoSize = true;
            this.lbl_inputPrecio.Location = new System.Drawing.Point(18, 50);
            this.lbl_inputPrecio.Name = "lbl_inputPrecio";
            this.lbl_inputPrecio.Size = new System.Drawing.Size(53, 20);
            this.lbl_inputPrecio.TabIndex = 2;
            this.lbl_inputPrecio.Text = "Precio:";
            // 
            // txb_inputPropiety
            // 
            this.txb_inputPropiety.Location = new System.Drawing.Point(99, 151);
            this.txb_inputPropiety.Name = "txb_inputPropiety";
            this.txb_inputPropiety.PlaceholderText = "txb_propiedad";
            this.txb_inputPropiety.Size = new System.Drawing.Size(151, 27);
            this.txb_inputPropiety.TabIndex = 1;
            this.txb_inputPropiety.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_inputPropiety_KeyPress);
            // 
            // txb_inputPrecio
            // 
            this.txb_inputPrecio.Location = new System.Drawing.Point(99, 47);
            this.txb_inputPrecio.Name = "txb_inputPrecio";
            this.txb_inputPrecio.PlaceholderText = "Ingrese precio";
            this.txb_inputPrecio.Size = new System.Drawing.Size(151, 27);
            this.txb_inputPrecio.TabIndex = 0;
            this.txb_inputPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_inputPrecio_KeyPress);
            // 
            // dgv_utilesMiCartuchera
            // 
            this.dgv_utilesMiCartuchera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_utilesMiCartuchera.Location = new System.Drawing.Point(408, 80);
            this.dgv_utilesMiCartuchera.Name = "dgv_utilesMiCartuchera";
            this.dgv_utilesMiCartuchera.RowHeadersWidth = 51;
            this.dgv_utilesMiCartuchera.RowTemplate.Height = 29;
            this.dgv_utilesMiCartuchera.Size = new System.Drawing.Size(432, 266);
            this.dgv_utilesMiCartuchera.TabIndex = 6;
            this.dgv_utilesMiCartuchera.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_utilesMiCartuchera_CellContentClick);
            // 
            // lbl_indicacionDgv
            // 
            this.lbl_indicacionDgv.AutoSize = true;
            this.lbl_indicacionDgv.Location = new System.Drawing.Point(408, 47);
            this.lbl_indicacionDgv.Name = "lbl_indicacionDgv";
            this.lbl_indicacionDgv.Size = new System.Drawing.Size(127, 20);
            this.lbl_indicacionDgv.TabIndex = 3;
            this.lbl_indicacionDgv.Text = "lbl_indicacionDgv";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(750, 404);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(94, 29);
            this.btn_eliminar.TabIndex = 7;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(650, 404);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(94, 29);
            this.btn_modificar.TabIndex = 8;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // lbl_detalleSeleccionado
            // 
            this.lbl_detalleSeleccionado.AutoSize = true;
            this.lbl_detalleSeleccionado.Location = new System.Drawing.Point(408, 369);
            this.lbl_detalleSeleccionado.Name = "lbl_detalleSeleccionado";
            this.lbl_detalleSeleccionado.Size = new System.Drawing.Size(167, 20);
            this.lbl_detalleSeleccionado.TabIndex = 10;
            this.lbl_detalleSeleccionado.Text = "lbl_detalleSeleccionado";
            // 
            // btn_guardarCartuchera
            // 
            this.btn_guardarCartuchera.Location = new System.Drawing.Point(650, 548);
            this.btn_guardarCartuchera.Name = "btn_guardarCartuchera";
            this.btn_guardarCartuchera.Size = new System.Drawing.Size(194, 45);
            this.btn_guardarCartuchera.TabIndex = 11;
            this.btn_guardarCartuchera.Text = "Guardar cartuchera";
            this.btn_guardarCartuchera.UseVisualStyleBackColor = true;
            this.btn_guardarCartuchera.Click += new System.EventHandler(this.btn_guardarCartuchera_Click);
            // 
            // Frm_agregarUtiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 621);
            this.Controls.Add(this.btn_guardarCartuchera);
            this.Controls.Add(this.lbl_detalleSeleccionado);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.dgv_utilesMiCartuchera);
            this.Controls.Add(this.gb_AgregarUtil);
            this.Controls.Add(this.gb_utiles);
            this.Controls.Add(this.lbl_indicacionDgv);
            this.Name = "Frm_agregarUtiles";
            this.Text = "Frm_agregarUtiles";
            this.Load += new System.EventHandler(this.Frm_agregarUtiles_Load);
            this.gb_utiles.ResumeLayout(false);
            this.gb_AgregarUtil.ResumeLayout(false);
            this.gb_AgregarUtil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_utilesMiCartuchera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RichTextBox rtb_Resultado;
        private GroupBox gb_utiles;
        private GroupBox gb_AgregarUtil;
        private Button btn_seleccionar;
        private ComboBox cmb_utiles;
        private TextBox txb_inputPropiety;
        private TextBox txb_inputPrecio;
        private Label lbl_inputPrecio;
        private Label lbl_inputPropiety;
        private ComboBox cmb_marca;
        private Label lbl_marca;
        private Button btn_agregar;
        private ComboBox cmb_propiety2;
        private Label lbl_inputPropiety2;
        private Button btn_cancelar;
        private DataGridView dgv_utilesMiCartuchera;
        private Label lbl_indicacionDgv;
        private Button btn_eliminar;
        private Button btn_modificar;
        private Label lbl_detalleSeleccionado;
        private Label lbl_msjError;
        private Button btn_aceptarModificarUtil;
        private Button btn_guardarCartuchera;
    }
}