namespace G1_PPA1_E1
{
    partial class PantallaConsulta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.panelLlamada = new System.Windows.Forms.Panel();
            this.txtEncuesta = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.gridRespuestas = new System.Windows.Forms.DataGridView();
            this.DescPregunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.respuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDescEncuesta = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnBuscarLlamadas = new MaterialSkin.Controls.MaterialButton();
            this.lblFechaInicio = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechaFin = new MaterialSkin.Controls.MaterialLabel();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.btnGenerarCSV = new MaterialSkin.Controls.MaterialButton();
            this.btnImprimir = new MaterialSkin.Controls.MaterialButton();
            this.Fecha_Llamada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridLlamadas = new System.Windows.Forms.DataGridView();
            this.panelLlamada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRespuestas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLlamadas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Enabled = false;
            this.dtpFechaInicio.Location = new System.Drawing.Point(70, 104);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(220, 20);
            this.dtpFechaInicio.TabIndex = 0;
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaInicio_ValueChanged);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Enabled = false;
            this.dtpFechaFin.Location = new System.Drawing.Point(301, 104);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(220, 20);
            this.dtpFechaFin.TabIndex = 1;
            this.dtpFechaFin.ValueChanged += new System.EventHandler(this.dtpFechaFin_ValueChanged);
            // 
            // panelLlamada
            // 
            this.panelLlamada.Controls.Add(this.txtEncuesta);
            this.panelLlamada.Controls.Add(this.txtDuracion);
            this.panelLlamada.Controls.Add(this.txtEstado);
            this.panelLlamada.Controls.Add(this.txtCliente);
            this.panelLlamada.Controls.Add(this.gridRespuestas);
            this.panelLlamada.Controls.Add(this.lblDescEncuesta);
            this.panelLlamada.Controls.Add(this.lblDuracion);
            this.panelLlamada.Controls.Add(this.lblEstado);
            this.panelLlamada.Controls.Add(this.lblCliente);
            this.panelLlamada.Location = new System.Drawing.Point(32, 352);
            this.panelLlamada.Name = "panelLlamada";
            this.panelLlamada.Size = new System.Drawing.Size(630, 260);
            this.panelLlamada.TabIndex = 4;
            this.panelLlamada.Visible = false;
            // 
            // txtEncuesta
            // 
            this.txtEncuesta.Location = new System.Drawing.Point(113, 53);
            this.txtEncuesta.Name = "txtEncuesta";
            this.txtEncuesta.ReadOnly = true;
            this.txtEncuesta.Size = new System.Drawing.Size(227, 20);
            this.txtEncuesta.TabIndex = 8;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(437, 19);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.ReadOnly = true;
            this.txtDuracion.Size = new System.Drawing.Size(81, 20);
            this.txtDuracion.TabIndex = 7;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(240, 19);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 6;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(69, 19);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCliente.TabIndex = 5;
            // 
            // gridRespuestas
            // 
            this.gridRespuestas.AllowUserToDeleteRows = false;
            this.gridRespuestas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRespuestas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DescPregunta,
            this.respuesta});
            this.gridRespuestas.Location = new System.Drawing.Point(27, 93);
            this.gridRespuestas.Name = "gridRespuestas";
            this.gridRespuestas.Size = new System.Drawing.Size(579, 150);
            this.gridRespuestas.TabIndex = 4;
            // 
            // DescPregunta
            // 
            this.DescPregunta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescPregunta.HeaderText = "Descripción De La Pregunta";
            this.DescPregunta.Name = "DescPregunta";
            // 
            // respuesta
            // 
            this.respuesta.HeaderText = "Respuesta Seleccionada";
            this.respuesta.Name = "respuesta";
            this.respuesta.Width = 150;
            // 
            // lblDescEncuesta
            // 
            this.lblDescEncuesta.AutoSize = true;
            this.lblDescEncuesta.Location = new System.Drawing.Point(24, 56);
            this.lblDescEncuesta.Name = "lblDescEncuesta";
            this.lblDescEncuesta.Size = new System.Drawing.Size(83, 13);
            this.lblDescEncuesta.TabIndex = 3;
            this.lblDescEncuesta.Text = "Desc. Encuesta";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(381, 22);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(50, 13);
            this.lblDuracion.TabIndex = 2;
            this.lblDuracion.Text = "Duracion";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(194, 22);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 1;
            this.lblEstado.Text = "Estado";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(24, 22);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // btnBuscarLlamadas
            // 
            this.btnBuscarLlamadas.AutoSize = false;
            this.btnBuscarLlamadas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarLlamadas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscarLlamadas.Depth = 0;
            this.btnBuscarLlamadas.HighEmphasis = true;
            this.btnBuscarLlamadas.Icon = null;
            this.btnBuscarLlamadas.Location = new System.Drawing.Point(542, 80);
            this.btnBuscarLlamadas.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarLlamadas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarLlamadas.Name = "btnBuscarLlamadas";
            this.btnBuscarLlamadas.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscarLlamadas.Size = new System.Drawing.Size(96, 36);
            this.btnBuscarLlamadas.TabIndex = 9;
            this.btnBuscarLlamadas.Text = "Buscar";
            this.btnBuscarLlamadas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscarLlamadas.UseAccentColor = false;
            this.btnBuscarLlamadas.UseVisualStyleBackColor = true;
            this.btnBuscarLlamadas.Click += new System.EventHandler(this.btnBuscarLlamadas_Click);
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Depth = 0;
            this.lblFechaInicio.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFechaInicio.Location = new System.Drawing.Point(67, 80);
            this.lblFechaInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(144, 19);
            this.lblFechaInicio.TabIndex = 10;
            this.lblFechaInicio.Text = "Fecha Inicio Periodo";
            this.lblFechaInicio.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Depth = 0;
            this.lblFechaFin.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFechaFin.Location = new System.Drawing.Point(298, 80);
            this.lblFechaFin.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(128, 19);
            this.lblFechaFin.TabIndex = 11;
            this.lblFechaFin.Text = "Fecha Fin Periodo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(542, 124);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(96, 36);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = true;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGenerarCSV
            // 
            this.btnGenerarCSV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerarCSV.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGenerarCSV.Depth = 0;
            this.btnGenerarCSV.HighEmphasis = true;
            this.btnGenerarCSV.Icon = null;
            this.btnGenerarCSV.Location = new System.Drawing.Point(201, 635);
            this.btnGenerarCSV.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGenerarCSV.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerarCSV.Name = "btnGenerarCSV";
            this.btnGenerarCSV.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGenerarCSV.Size = new System.Drawing.Size(118, 36);
            this.btnGenerarCSV.TabIndex = 13;
            this.btnGenerarCSV.Text = "Generar CSV";
            this.btnGenerarCSV.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGenerarCSV.UseAccentColor = false;
            this.btnGenerarCSV.UseVisualStyleBackColor = true;
            this.btnGenerarCSV.Click += new System.EventHandler(this.btnGenerarCSV_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImprimir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnImprimir.Depth = 0;
            this.btnImprimir.HighEmphasis = true;
            this.btnImprimir.Icon = null;
            this.btnImprimir.Location = new System.Drawing.Point(377, 635);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnImprimir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnImprimir.Size = new System.Drawing.Size(87, 36);
            this.btnImprimir.TabIndex = 14;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnImprimir.UseAccentColor = false;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // Fecha_Llamada
            // 
            this.Fecha_Llamada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fecha_Llamada.HeaderText = "Fecha Llamada";
            this.Fecha_Llamada.Name = "Fecha_Llamada";
            this.Fecha_Llamada.ReadOnly = true;
            // 
            // gridLlamadas
            // 
            this.gridLlamadas.AllowUserToAddRows = false;
            this.gridLlamadas.AllowUserToDeleteRows = false;
            this.gridLlamadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLlamadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha_Llamada});
            this.gridLlamadas.Location = new System.Drawing.Point(59, 168);
            this.gridLlamadas.Name = "gridLlamadas";
            this.gridLlamadas.ReadOnly = true;
            this.gridLlamadas.Size = new System.Drawing.Size(579, 164);
            this.gridLlamadas.TabIndex = 2;
            this.gridLlamadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLlamadas_CellContentClick);
            this.gridLlamadas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLlamadas_CellContentClick);
            // 
            // PantallaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 700);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnGenerarCSV);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.btnBuscarLlamadas);
            this.Controls.Add(this.panelLlamada);
            this.Controls.Add(this.gridLlamadas);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Name = "PantallaConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Encuesta";
            this.Load += new System.EventHandler(this.PantallaConsulta_Load);
            this.panelLlamada.ResumeLayout(false);
            this.panelLlamada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRespuestas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLlamadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Panel panelLlamada;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.DataGridView gridRespuestas;
        private System.Windows.Forms.Label lblDescEncuesta;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.TextBox txtEncuesta;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescPregunta;
        private System.Windows.Forms.DataGridViewTextBoxColumn respuesta;
        private MaterialSkin.Controls.MaterialButton btnBuscarLlamadas;
        private MaterialSkin.Controls.MaterialLabel lblFechaInicio;
        private MaterialSkin.Controls.MaterialLabel lblFechaFin;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnGenerarCSV;
        private MaterialSkin.Controls.MaterialButton btnImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Llamada;
        private System.Windows.Forms.DataGridView gridLlamadas;
    }
}

