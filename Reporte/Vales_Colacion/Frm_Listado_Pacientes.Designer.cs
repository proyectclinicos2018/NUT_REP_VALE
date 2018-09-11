namespace Vales_Colacion
{
    partial class Frm_Listado_Pacientes
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Listado_Pacientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.DateTimePicker();
            this.btn_servicio = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtservicios = new System.Windows.Forms.TextBox();
            this.btn_estado = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Btn_tipo_comida = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttipo_comida = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grilla_pedidos = new System.Windows.Forms.DataGridView();
            this.Ayuda = new AyudaSpreadNet.AyudaSprNet();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.Btn_imprimir = new System.Windows.Forms.Button();
            this.RV = new System.Windows.Forms.DataGridViewImageColumn();
            this.RI = new System.Windows.Forms.DataGridViewImageColumn();
            this.RGI = new System.Windows.Forms.DataGridViewImageColumn();
            this.VALE_IMPRESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_ESTADO_PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CORRELATIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_pedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // LblUsuario
            // 
            this.LblUsuario.BackColor = System.Drawing.Color.Silver;
            this.LblUsuario.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(12, 9);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(131, 25);
            this.LblUsuario.TabIndex = 190;
            this.LblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtfecha);
            this.groupBox1.Controls.Add(this.btn_servicio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtservicios);
            this.groupBox1.Controls.Add(this.btn_estado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtestado);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.Btn_limpiar);
            this.groupBox1.Controls.Add(this.Btn_tipo_comida);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txttipo_comida);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(15, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 106);
            this.groupBox1.TabIndex = 191;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(731, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 211;
            this.label5.Text = "Fecha";
            // 
            // txtfecha
            // 
            this.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfecha.Location = new System.Drawing.Point(777, 37);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(114, 20);
            this.txtfecha.TabIndex = 210;
            // 
            // btn_servicio
            // 
            this.btn_servicio.Image = ((System.Drawing.Image)(resources.GetObject("btn_servicio.Image")));
            this.btn_servicio.Location = new System.Drawing.Point(661, 65);
            this.btn_servicio.Name = "btn_servicio";
            this.btn_servicio.Size = new System.Drawing.Size(27, 23);
            this.btn_servicio.TabIndex = 209;
            this.btn_servicio.UseVisualStyleBackColor = true;
            this.btn_servicio.Click += new System.EventHandler(this.btn_servicio_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 208;
            this.label4.Text = "Servicios";
            // 
            // txtservicios
            // 
            this.txtservicios.BackColor = System.Drawing.Color.White;
            this.txtservicios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtservicios.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtservicios.Location = new System.Drawing.Point(412, 67);
            this.txtservicios.Name = "txtservicios";
            this.txtservicios.Size = new System.Drawing.Size(243, 20);
            this.txtservicios.TabIndex = 207;
            this.txtservicios.Enter += new System.EventHandler(this.CambiarColor_TextEnter);
            this.txtservicios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtservicios_KeyPress);
            this.txtservicios.Leave += new System.EventHandler(this.CambiarBlanco_TextLeave);
            // 
            // btn_estado
            // 
            this.btn_estado.Image = ((System.Drawing.Image)(resources.GetObject("btn_estado.Image")));
            this.btn_estado.Location = new System.Drawing.Point(266, 66);
            this.btn_estado.Name = "btn_estado";
            this.btn_estado.Size = new System.Drawing.Size(27, 23);
            this.btn_estado.TabIndex = 206;
            this.btn_estado.UseVisualStyleBackColor = true;
            this.btn_estado.Click += new System.EventHandler(this.btn_estado_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 205;
            this.label2.Text = "Estados";
            // 
            // txtestado
            // 
            this.txtestado.BackColor = System.Drawing.Color.White;
            this.txtestado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtestado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtestado.Location = new System.Drawing.Point(98, 68);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(162, 20);
            this.txtestado.TabIndex = 204;
            this.txtestado.Enter += new System.EventHandler(this.CambiarColor_TextEnter);
            this.txtestado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtestado_KeyPress);
            this.txtestado.Leave += new System.EventHandler(this.CambiarBlanco_TextLeave);
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.White;
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombre.Location = new System.Drawing.Point(412, 41);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(243, 20);
            this.txtnombre.TabIndex = 198;
            this.txtnombre.Enter += new System.EventHandler(this.CambiarColor_TextEnter);
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            this.txtnombre.Leave += new System.EventHandler(this.CambiarBlanco_TextLeave);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.Location = new System.Drawing.Point(734, 66);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(76, 31);
            this.btn_buscar.TabIndex = 203;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_limpiar.Image")));
            this.Btn_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_limpiar.Location = new System.Drawing.Point(816, 66);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(75, 30);
            this.Btn_limpiar.TabIndex = 202;
            this.Btn_limpiar.Text = "Limpiar";
            this.Btn_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_limpiar.UseVisualStyleBackColor = true;
            this.Btn_limpiar.Click += new System.EventHandler(this.Btn_limpiar_Click);
            // 
            // Btn_tipo_comida
            // 
            this.Btn_tipo_comida.Image = ((System.Drawing.Image)(resources.GetObject("Btn_tipo_comida.Image")));
            this.Btn_tipo_comida.Location = new System.Drawing.Point(266, 41);
            this.Btn_tipo_comida.Name = "Btn_tipo_comida";
            this.Btn_tipo_comida.Size = new System.Drawing.Size(27, 23);
            this.Btn_tipo_comida.TabIndex = 200;
            this.Btn_tipo_comida.UseVisualStyleBackColor = true;
            this.Btn_tipo_comida.Click += new System.EventHandler(this.Btn_tipo_comida_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 199;
            this.label3.Text = "Tipo Comida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 190;
            this.label1.Text = "Paciente";
            // 
            // txttipo_comida
            // 
            this.txttipo_comida.BackColor = System.Drawing.Color.White;
            this.txttipo_comida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttipo_comida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txttipo_comida.Location = new System.Drawing.Point(98, 44);
            this.txttipo_comida.Name = "txttipo_comida";
            this.txttipo_comida.Size = new System.Drawing.Size(162, 20);
            this.txttipo_comida.TabIndex = 189;
            this.txttipo_comida.Enter += new System.EventHandler(this.CambiarColor_TextEnter);
            this.txttipo_comida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttipo_comida_KeyPress);
            this.txttipo_comida.Leave += new System.EventHandler(this.CambiarBlanco_TextLeave);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Image = global::Vales_Colacion.Properties.Resources.HeaderLarge;
            this.label7.Location = new System.Drawing.Point(0, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(897, 25);
            this.label7.TabIndex = 79;
            this.label7.Text = "Configuración de Menú";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 2;
            // 
            // grilla_pedidos
            // 
            this.grilla_pedidos.AllowUserToAddRows = false;
            this.grilla_pedidos.AllowUserToDeleteRows = false;
            this.grilla_pedidos.AllowUserToResizeColumns = false;
            this.grilla_pedidos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grilla_pedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grilla_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_pedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RV,
            this.RI,
            this.RGI,
            this.VALE_IMPRESO,
            this.NOM_ESTADO_PEDIDO,
            this.NOM_PACIENTE,
            this.CORRELATIVO,
            this.FECHA_PEDIDO,
            this.COD_PEDIDO});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grilla_pedidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.grilla_pedidos.Location = new System.Drawing.Point(12, 195);
            this.grilla_pedidos.Name = "grilla_pedidos";
            this.grilla_pedidos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grilla_pedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grilla_pedidos.RowHeadersVisible = false;
            this.grilla_pedidos.Size = new System.Drawing.Size(909, 239);
            this.grilla_pedidos.TabIndex = 198;
            this.grilla_pedidos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_pedidos_CellContentDoubleClick);
            this.grilla_pedidos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.grilla_pedidos_CellPainting);
            // 
            // Ayuda
            // 
            this.Ayuda.AnchoColumnas = null;
            this.Ayuda.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Ayuda.Location = new System.Drawing.Point(201, -9);
            this.Ayuda.Multi_Seleccion = false;
            this.Ayuda.Name = "Ayuda";
            this.Ayuda.Nombre_BD_Datos = null;
            this.Ayuda.NombreColumnas = null;
            this.Ayuda.Package = null;
            this.Ayuda.Pass = null;
            this.Ayuda.Procedimiento = null;
            this.Ayuda.Size = new System.Drawing.Size(58, 66);
            this.Ayuda.TabIndex = 200;
            this.Ayuda.TipoBase = 0;
            this.Ayuda.TituloConsulta = null;
            this.Ayuda.User = null;
            this.Ayuda.UseWaitCursor = true;
            this.Ayuda.Visible = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "I";
            this.dataGridViewImageColumn1.Image = global::Vales_Colacion.Properties.Resources.reportes;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
            this.label13.Location = new System.Drawing.Point(14, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(907, 25);
            this.label13.TabIndex = 199;
            this.label13.Text = "Listado";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_imprimir
            // 
            this.Btn_imprimir.Image = global::Vales_Colacion.Properties.Resources.reportes;
            this.Btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_imprimir.Location = new System.Drawing.Point(326, 12);
            this.Btn_imprimir.Name = "Btn_imprimir";
            this.Btn_imprimir.Size = new System.Drawing.Size(111, 36);
            this.Btn_imprimir.TabIndex = 197;
            this.Btn_imprimir.Text = "Reporte Vale";
            this.Btn_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_imprimir.UseVisualStyleBackColor = true;
            this.Btn_imprimir.Click += new System.EventHandler(this.Btn_imprimir_Click);
            // 
            // RV
            // 
            this.RV.HeaderText = "RV";
            this.RV.Image = global::Vales_Colacion.Properties.Resources.reportes;
            this.RV.Name = "RV";
            this.RV.ReadOnly = true;
            this.RV.Width = 30;
            // 
            // RI
            // 
            this.RI.HeaderText = "RI";
            this.RI.Image = global::Vales_Colacion.Properties.Resources.reportes;
            this.RI.Name = "RI";
            this.RI.ReadOnly = true;
            this.RI.Width = 30;
            // 
            // RGI
            // 
            this.RGI.HeaderText = "RGI";
            this.RGI.Image = global::Vales_Colacion.Properties.Resources.reportes;
            this.RGI.Name = "RGI";
            this.RGI.ReadOnly = true;
            this.RGI.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RGI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.RGI.Width = 30;
            // 
            // VALE_IMPRESO
            // 
            this.VALE_IMPRESO.DataPropertyName = "VALE_IMPRESO";
            this.VALE_IMPRESO.HeaderText = "VALE";
            this.VALE_IMPRESO.Name = "VALE_IMPRESO";
            this.VALE_IMPRESO.ReadOnly = true;
            this.VALE_IMPRESO.Width = 25;
            // 
            // NOM_ESTADO_PEDIDO
            // 
            this.NOM_ESTADO_PEDIDO.DataPropertyName = "NOM_ESTADO_PEDIDO";
            this.NOM_ESTADO_PEDIDO.HeaderText = "ESTADO ";
            this.NOM_ESTADO_PEDIDO.Name = "NOM_ESTADO_PEDIDO";
            this.NOM_ESTADO_PEDIDO.ReadOnly = true;
            // 
            // NOM_PACIENTE
            // 
            this.NOM_PACIENTE.DataPropertyName = "NOM_PACIENTE";
            this.NOM_PACIENTE.HeaderText = "NOM PACIENTE";
            this.NOM_PACIENTE.Name = "NOM_PACIENTE";
            this.NOM_PACIENTE.ReadOnly = true;
            this.NOM_PACIENTE.Width = 300;
            // 
            // CORRELATIVO
            // 
            this.CORRELATIVO.DataPropertyName = "CORRELATIVO";
            this.CORRELATIVO.HeaderText = "CORRELATIVO";
            this.CORRELATIVO.Name = "CORRELATIVO";
            this.CORRELATIVO.ReadOnly = true;
            // 
            // FECHA_PEDIDO
            // 
            this.FECHA_PEDIDO.DataPropertyName = "FECHA_PEDIDO";
            this.FECHA_PEDIDO.HeaderText = "FECHA ";
            this.FECHA_PEDIDO.Name = "FECHA_PEDIDO";
            this.FECHA_PEDIDO.ReadOnly = true;
            // 
            // COD_PEDIDO
            // 
            this.COD_PEDIDO.DataPropertyName = "COD_PEDIDO";
            this.COD_PEDIDO.HeaderText = "COD_PEDIDO";
            this.COD_PEDIDO.Name = "COD_PEDIDO";
            this.COD_PEDIDO.ReadOnly = true;
            this.COD_PEDIDO.Visible = false;
            // 
            // Frm_Listado_Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 446);
            this.Controls.Add(this.Ayuda);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.grilla_pedidos);
            this.Controls.Add(this.Btn_imprimir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Listado_Pacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Pedido";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_pedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.Button Btn_tipo_comida;
        private System.Windows.Forms.Button Btn_imprimir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttipo_comida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView grilla_pedidos;
        private System.Windows.Forms.Button btn_buscar;
        private AyudaSpreadNet.AyudaSprNet Ayuda;
        private System.Windows.Forms.Button btn_servicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtservicios;
        private System.Windows.Forms.Button btn_estado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtfecha;
        private System.Windows.Forms.DataGridViewImageColumn RV;
        private System.Windows.Forms.DataGridViewImageColumn RI;
        private System.Windows.Forms.DataGridViewImageColumn RGI;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALE_IMPRESO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_ESTADO_PEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CORRELATIVO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_PEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_PEDIDO;
    }
}

