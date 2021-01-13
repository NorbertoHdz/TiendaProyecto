namespace TiendaProyecto
{
    partial class Tienda
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbTablas = new System.Windows.Forms.ComboBox();
            this.txtDato1 = new System.Windows.Forms.TextBox();
            this.btnInsertarRegistro = new System.Windows.Forms.Button();
            this.txtDato2 = new System.Windows.Forms.TextBox();
            this.btninsertar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lbliddepartamento = new System.Windows.Forms.Label();
            this.txtDato4 = new System.Windows.Forms.TextBox();
            this.txtDato5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDato6 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDato11 = new System.Windows.Forms.TextBox();
            this.txtDato10 = new System.Windows.Forms.TextBox();
            this.txtDato9 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDato8 = new System.Windows.Forms.TextBox();
            this.txtDato7 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.btnmodi = new System.Windows.Forms.Button();
            this.cbconenctar = new System.Windows.Forms.ComboBox();
            this.txtDato12 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.cbbuscar = new System.Windows.Forms.ComboBox();
            this.txtDato3 = new System.Windows.Forms.TextBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1340, 374);
            this.dataGridView1.TabIndex = 1;
            // 
            // cbTablas
            // 
            this.cbTablas.FormattingEnabled = true;
            this.cbTablas.Items.AddRange(new object[] {
            "AccesorioHombre",
            "AccesoriosMujer",
            "AccesoriosNiñoNiña",
            "BlusasplayeraniñoRopaniño",
            "BlusasPlayeras",
            "Blusasplayerasniñoniña",
            "BlusasPlayerasRopa",
            "Bolsas",
            "Cajas",
            "CajasCajeros",
            "Cajero",
            "Cliente",
            "ClienteSeguros",
            "ClienteTienda",
            "Conductor",
            "Credito",
            "Debito",
            "Departamento",
            "DepartamentoHombre",
            "DepartamentoMujer",
            "DepartamentoNiñoNiña",
            "DeportivoNiñoNiña",
            "DeportivoNiñoRopaNiño",
            "Efectivo",
            "Empleados",
            "EmpleadosTienda",
            "Escolares",
            "EscolaresMochilas",
            "FormasPago",
            "FormaspagoVenta",
            "Gerente",
            "GerenteTienda",
            "JoyeriaHombre",
            "JoyeriahombreAccesoriohombre",
            "JoyeriaMujer",
            "JoyeriamujerAccesoriomujer",
            "JoyerianiñoAccesorioniño",
            "JoyeriaNiñoNiña",
            "Juguetes",
            "LentesHombre",
            "LenteshombreAccesoriohombre",
            "LentesMujer",
            "LentesmujerAccesorioMujer",
            "LentesniñoAccesorioniño",
            "LentesNiñoNiña",
            "Mochilas",
            "Pantalones_ShortsMujer",
            "PantalonesHombre",
            "PantalonesmujerRopa",
            "Pantalonesniñoniña",
            "PantalonesniñoRopaniño",
            "PantalonesRopahombre",
            "PlayerascamisaRopahombre",
            "PlayerasCamisas",
            "RelojHombre",
            "RelojhombreAccesoriohombre",
            "RelojMujer",
            "RelojmujerAccesorioMujer",
            "RelojniñoAccesorioniño",
            "RelojNiñoNiña",
            "RopaHombre",
            "RopaInterior",
            "RopainteriorRopahombre",
            "RopaMujer",
            "RopaNiñoNiña",
            "SeguroFamiliar",
            "Seguros",
            "SeguroVehiculo",
            "Tienda",
            "TiendaDepartamento",
            "UtilesEscolares",
            "UtilesescolaresEscolares",
            "Venta",
            "VentaCajas",
            "VentaCliente",
            "ZapatosHombre",
            "ZapatosMujer",
            "ZapatosNiñoniña"});
            this.cbTablas.Location = new System.Drawing.Point(198, 12);
            this.cbTablas.Name = "cbTablas";
            this.cbTablas.Size = new System.Drawing.Size(180, 21);
            this.cbTablas.TabIndex = 3;
            this.cbTablas.Text = "TABLAS";
            this.cbTablas.SelectedIndexChanged += new System.EventHandler(this.cbTablas_SelectedIndexChanged);
            // 
            // txtDato1
            // 
            this.txtDato1.Location = new System.Drawing.Point(12, 479);
            this.txtDato1.Name = "txtDato1";
            this.txtDato1.Size = new System.Drawing.Size(199, 20);
            this.txtDato1.TabIndex = 4;
            // 
            // btnInsertarRegistro
            // 
            this.btnInsertarRegistro.Location = new System.Drawing.Point(12, 558);
            this.btnInsertarRegistro.Name = "btnInsertarRegistro";
            this.btnInsertarRegistro.Size = new System.Drawing.Size(75, 23);
            this.btnInsertarRegistro.TabIndex = 5;
            this.btnInsertarRegistro.Text = "Insertar";
            this.btnInsertarRegistro.UseVisualStyleBackColor = true;
            this.btnInsertarRegistro.Click += new System.EventHandler(this.btnInsertarRegistro_Click);
            // 
            // txtDato2
            // 
            this.txtDato2.Location = new System.Drawing.Point(224, 479);
            this.txtDato2.Name = "txtDato2";
            this.txtDato2.Size = new System.Drawing.Size(163, 20);
            this.txtDato2.TabIndex = 6;
            // 
            // btninsertar
            // 
            this.btninsertar.Location = new System.Drawing.Point(12, 419);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(75, 23);
            this.btninsertar.TabIndex = 7;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(93, 419);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 8;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(174, 419);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 9;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(94, 463);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre";
            // 
            // lbliddepartamento
            // 
            this.lbliddepartamento.AutoSize = true;
            this.lbliddepartamento.Location = new System.Drawing.Point(263, 463);
            this.lbliddepartamento.Name = "lbliddepartamento";
            this.lbliddepartamento.Size = new System.Drawing.Size(82, 13);
            this.lbliddepartamento.TabIndex = 12;
            this.lbliddepartamento.Text = "idDepartamento";
            // 
            // txtDato4
            // 
            this.txtDato4.Location = new System.Drawing.Point(562, 479);
            this.txtDato4.Name = "txtDato4";
            this.txtDato4.Size = new System.Drawing.Size(163, 20);
            this.txtDato4.TabIndex = 14;
            // 
            // txtDato5
            // 
            this.txtDato5.Location = new System.Drawing.Point(765, 479);
            this.txtDato5.Name = "txtDato5";
            this.txtDato5.Size = new System.Drawing.Size(163, 20);
            this.txtDato5.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "idDepartamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(599, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "idDepartamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(807, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "idDepartamento";
            // 
            // txtDato6
            // 
            this.txtDato6.Location = new System.Drawing.Point(943, 479);
            this.txtDato6.Name = "txtDato6";
            this.txtDato6.Size = new System.Drawing.Size(163, 20);
            this.txtDato6.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(973, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "idDepartamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 518);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "idDepartamento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 518);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "idDepartamento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(464, 518);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "idDepartamento";
            // 
            // txtDato11
            // 
            this.txtDato11.Location = new System.Drawing.Point(765, 534);
            this.txtDato11.Name = "txtDato11";
            this.txtDato11.Size = new System.Drawing.Size(163, 20);
            this.txtDato11.TabIndex = 27;
            // 
            // txtDato10
            // 
            this.txtDato10.Location = new System.Drawing.Point(596, 534);
            this.txtDato10.Name = "txtDato10";
            this.txtDato10.Size = new System.Drawing.Size(163, 20);
            this.txtDato10.TabIndex = 26;
            // 
            // txtDato9
            // 
            this.txtDato9.Location = new System.Drawing.Point(427, 534);
            this.txtDato9.Name = "txtDato9";
            this.txtDato9.Size = new System.Drawing.Size(163, 20);
            this.txtDato9.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(647, 518);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "idDepartamento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(807, 518);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Nombre";
            // 
            // txtDato8
            // 
            this.txtDato8.Location = new System.Drawing.Point(224, 534);
            this.txtDato8.Name = "txtDato8";
            this.txtDato8.Size = new System.Drawing.Size(163, 20);
            this.txtDato8.TabIndex = 22;
            // 
            // txtDato7
            // 
            this.txtDato7.Location = new System.Drawing.Point(48, 534);
            this.txtDato7.Name = "txtDato7";
            this.txtDato7.Size = new System.Drawing.Size(163, 20);
            this.txtDato7.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(559, 479);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 31;
            this.dateTimePicker1.Value = new System.DateTime(2020, 12, 2, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(11, 534);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 32;
            this.dateTimePicker2.Value = new System.DateTime(2020, 12, 2, 0, 0, 0, 0);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(217, 534);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 33;
            this.dateTimePicker3.Value = new System.DateTime(2020, 12, 2, 0, 0, 0, 0);
            // 
            // btnmodi
            // 
            this.btnmodi.Location = new System.Drawing.Point(12, 558);
            this.btnmodi.Name = "btnmodi";
            this.btnmodi.Size = new System.Drawing.Size(75, 23);
            this.btnmodi.TabIndex = 34;
            this.btnmodi.Text = "Modificar";
            this.btnmodi.UseVisualStyleBackColor = true;
            this.btnmodi.Click += new System.EventHandler(this.btnmodi_Click);
            // 
            // cbconenctar
            // 
            this.cbconenctar.FormattingEnabled = true;
            this.cbconenctar.Items.AddRange(new object[] {
            "SQL",
            "MYSQL",
            "MARIADB",
            "ORACLE"});
            this.cbconenctar.Location = new System.Drawing.Point(12, 12);
            this.cbconenctar.Name = "cbconenctar";
            this.cbconenctar.Size = new System.Drawing.Size(180, 21);
            this.cbconenctar.TabIndex = 35;
            this.cbconenctar.Text = "MANEJADORES";
            this.cbconenctar.SelectedIndexChanged += new System.EventHandler(this.cbconenctar_SelectedIndexChanged);
            // 
            // txtDato12
            // 
            this.txtDato12.Location = new System.Drawing.Point(943, 534);
            this.txtDato12.Name = "txtDato12";
            this.txtDato12.Size = new System.Drawing.Size(163, 20);
            this.txtDato12.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(985, 518);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(255, 419);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 39;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // cbbuscar
            // 
            this.cbbuscar.FormattingEnabled = true;
            this.cbbuscar.Location = new System.Drawing.Point(336, 421);
            this.cbbuscar.Name = "cbbuscar";
            this.cbbuscar.Size = new System.Drawing.Size(180, 21);
            this.cbbuscar.TabIndex = 40;
            this.cbbuscar.SelectedIndexChanged += new System.EventHandler(this.cbbuscar_SelectedIndexChanged);
            // 
            // txtDato3
            // 
            this.txtDato3.Location = new System.Drawing.Point(393, 479);
            this.txtDato3.Name = "txtDato3";
            this.txtDato3.Size = new System.Drawing.Size(163, 20);
            this.txtDato3.TabIndex = 13;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(336, 448);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(180, 20);
            this.txtbuscar.TabIndex = 41;
            this.txtbuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbuscar_KeyUp);
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(248, 451);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(82, 13);
            this.lblbuscar.TabIndex = 42;
            this.lblbuscar.Text = "idDepartamento";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(522, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 43;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Tienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1363, 581);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.cbbuscar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDato12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbconenctar);
            this.Controls.Add(this.btnmodi);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDato11);
            this.Controls.Add(this.txtDato10);
            this.Controls.Add(this.txtDato9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDato8);
            this.Controls.Add(this.txtDato7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDato6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDato5);
            this.Controls.Add(this.txtDato4);
            this.Controls.Add(this.txtDato3);
            this.Controls.Add(this.lbliddepartamento);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.txtDato2);
            this.Controls.Add(this.btnInsertarRegistro);
            this.Controls.Add(this.txtDato1);
            this.Controls.Add(this.cbTablas);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Tienda";
            this.Text = "Tienda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbTablas;
        private System.Windows.Forms.TextBox txtDato1;
        private System.Windows.Forms.Button btnInsertarRegistro;
        private System.Windows.Forms.TextBox txtDato2;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lbliddepartamento;
        private System.Windows.Forms.TextBox txtDato4;
        private System.Windows.Forms.TextBox txtDato5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDato6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDato11;
        private System.Windows.Forms.TextBox txtDato10;
        private System.Windows.Forms.TextBox txtDato9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDato8;
        private System.Windows.Forms.TextBox txtDato7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button btnmodi;
        private System.Windows.Forms.ComboBox cbconenctar;
        private System.Windows.Forms.TextBox txtDato12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.ComboBox cbbuscar;
        private System.Windows.Forms.TextBox txtDato3;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.Button button2;
    }
}

