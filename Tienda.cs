using System;
using System.Data;
using System.Windows.Forms;

namespace TiendaProyecto
{
    public partial class Tienda : Form
    {
        string consulta = "";
        DataSet ds = new DataSet();

        public Tienda()
        {
            InitializeComponent();
            btnmodi.Visible = false;
            btnInsertarRegistro.Visible = false;
            OcultarDatos.Ocultartextbox(this);
            button1.Visible = false;
            cbbuscar.Visible = false;
            button2.Visible = false;

        }

        private void cbTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbconenctar.Text == "MANEJADORES")
            {
                cbTablas.ResetText();
                MessageBox.Show("SELECCIONA UN SERVIDOR");
                cbTablas.Text = "TABLAS";
                return;
            }
            else if (cbTablas.Text == "TABLAS")
            {
                MessageBox.Show("SELECCIONA UNA TABLA");
                return;
            }
            else
            {
                btnInsertarRegistro.Visible = false;
                btnmodi.Visible = false;
                button2.Visible = false;
                button1.Visible = false;
                lblbuscar.Visible = false;
                txtbuscar.Visible = false;
                cbbuscar.Visible = false;
                OcultarDatos.Ocultartextbox(this);
                consulta = "SELECT * FROM " + cbTablas.Text + " ORDER BY " + 1;
                if (cbTablas.Text == "TABLAS")
                {
                    return;
                }
                Datos.MostrarTabla(ds, cbTablas, consulta, "Tienda", dataGridView1);
            }
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            OcultarDatos.ocultartexto(this);

            if (dataGridView1.Columns.Count == 0)
            {
                MessageBox.Show("SELECCIONA UNA TABLA");
                return;
            }
            btnInsertarRegistro.Visible = true;
            btnmodi.Visible = false;
            button2.Visible = false;
            button1.Visible = true;
            lblbuscar.Visible = false;
            txtbuscar.Visible = false;
            cbbuscar.Visible = false;
            switch (cbTablas.Text)
            {
                case "AccesorioHombre":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    txtDato2.Text = "1";
                    txtDato1.Focus();
                    break;
                case "AccesoriosMujer":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    txtDato2.Text = "1";
                    txtDato1.Focus();
                    break;
                case "AccesoriosNiñoNiña":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    txtDato2.Text = "1";
                    txtDato1.Focus();
                    break;
                case "BlusasplayeraniñoRopaniño":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    txtDato2.Text = "2";
                    lblNombre.Text = "idblusas";
                    lbliddepartamento.Text = "idropa";
                    txtDato1.Focus();
                    break;
                case "BlusasPlayeras":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    txtDato1.Focus();
                    break;
                case "Blusasplayerasniñoniña":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    txtDato1.Focus();
                    break;
                case "BlusasPlayerasRopa":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    txtDato2.Text = "2";
                    lblNombre.Text = "idblusasplayeras";
                    lbliddepartamento.Text = "idropa";
                    txtDato1.Focus();
                    break;
                case "Bolsas":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    txtDato6.Visible = true;
                    txtDato6.Text = "3";
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    label4.Text = "id departamento mujer";
                    txtDato1.Focus();
                    break;
                case "Cajas":
                    txtDato1.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "Numero Cajas";
                    txtDato1.Focus();
                    break;
                case "CajasCajeros":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idcajas";
                    lbliddepartamento.Text = "idcajeros";
                    txtDato1.Focus();
                    break;
                case "Cajero":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "Apellido Paterno";
                    label1.Text = "Apellido Materno";
                    txtDato1.Focus();
                    break;
                case "Cliente":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "Apellido Paterno";
                    label1.Text = "Apellido Materno";
                    label2.Text = "Telefono";
                    txtDato1.Focus();
                    break;
                case "ClienteSeguros":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lblNombre.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Text = "idcliente";
                    lbliddepartamento.Text = "idseguro";
                    txtDato1.Focus();
                    break;
                case "ClienteTienda":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lblNombre.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Text = "idcliente";
                    lbliddepartamento.Text = "idtienda";
                    txtDato1.Focus();
                    break;
                case "Conductor":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    dateTimePicker1.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "Genero";
                    label1.Text = "Codigo Postal";
                    label2.Text = "Fecha Nacimiento";
                    txtDato1.Focus();
                    break;
                case "Credito":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    dateTimePicker1.Visible = true;
                    txtDato5.Visible = true;
                    txtDato6.Visible = true;
                    dateTimePicker2.Visible = true;
                    dateTimePicker3.Visible = true;
                    txtDato9.Visible = true;
                    txtDato10.Visible = true;
                    txtDato11.Text = "3";
                    txtDato11.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "Apellido paterno";
                    label1.Text = "Apellido materno";
                    label2.Text = "Fecha Nacimiento";
                    label3.Text = "Numero de tarjeta";
                    label4.Text = "meses";
                    label5.Text = "Fecha inicio";
                    label6.Text = "Fecha final";
                    label7.Text = "monto";
                    label8.Text = "factura";
                    label9.Text = "idformapago";
                    txtDato1.Focus();
                    break;

                case "Debito":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    dateTimePicker1.Visible = true;
                    txtDato3.Visible = true;
                    txtDato5.Visible = true;
                    txtDato5.Text = "1";
                    lblNombre.Visible = true;
                    lbliddepartamento.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    lblNombre.Text = "monto";
                    lbliddepartamento.Text = "Numero de tarjeta";
                    label1.Text = "Factura";
                    label2.Text = "Fecha Pago";
                    label3.Text = "idformapago";
                    txtDato1.Focus();
                    break;

                case "Departamento":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lblNombre.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "piso";
                    txtDato1.Focus();
                    break;
                case "DepartamentoHombre":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lblNombre.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "iddepartamentogeneral";
                    txtDato1.Focus();
                    break;
                case "DepartamentoMujer":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lblNombre.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "iddepartamentogeneral";
                    txtDato1.Focus();
                    break;
                case "DepartamentoNiñoNiña":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lblNombre.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "iddepartamentogeneral";
                    txtDato1.Focus();
                    break;
                case "DeportivoNiñoNiña":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    txtDato1.Focus();
                    break;

                case "DeportivoNiñoRopaNiño":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    txtDato2.Text = "3";
                    lblNombre.Text = "iddeportivo";
                    lbliddepartamento.Text = "idropa";
                    txtDato1.Focus();
                    break;
                case "Efectivo":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    dateTimePicker1.Visible = true;
                    txtDato5.Visible = true;
                    txtDato5.Text = "2";
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    lblNombre.Text = "monto";
                    lbliddepartamento.Text = "cambio";
                    label1.Text = "factura";
                    label2.Text = "fecha de pago";
                    label3.Text = "idformas pago";
                    txtDato1.Focus();
                    break;
                case "Empleados":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "Apellido Paterno";
                    label1.Text = "Apellido Materno";
                    label2.Text = "Direccion";
                    label3.Text = "Telefono";
                    txtDato1.Focus();

                    break;
                case "EmpleadosTienda":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idtienda";
                    lbliddepartamento.Text = "idempleado";
                    txtDato1.Focus();
                    break;
                case "Escolares":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "iddepartamento niño niña";
                    txtDato1.Focus();
                    break;
                case "EscolaresMochilas":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idescolares";
                    lbliddepartamento.Text = "idmochilas";
                    txtDato1.Focus();
                    break;
                case "FormasPago":
                    txtDato1.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "nombre";
                    txtDato1.Focus();
                    break;
                case "FormaspagoVenta":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idformas de pago";
                    lbliddepartamento.Text = "idventa";
                    txtDato1.Focus();
                    break;
                case "Gerente":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "Apellido Paterno";
                    label1.Text = "Apellido Materno";
                    label2.Text = "Direccion";
                    label3.Text = "Telefono";
                    txtDato1.Focus();
                    break;
                case "GerenteTienda":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idtienda";
                    lbliddepartamento.Text = "idgerente";
                    txtDato1.Focus();
                    break;
                case "JoyeriaHombre":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    txtDato1.Focus();
                    break;
                case "JoyeriahombreAccesoriohombre":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idjoyeria";
                    lbliddepartamento.Text = "idaccesorio";
                    txtDato1.Focus();
                    break;
                case "JoyeriaMujer":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    txtDato1.Focus();
                    break;
                case "JoyeriamujerAccesoriomujer":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idjoyeria";
                    lbliddepartamento.Text = "idaccesorio";
                    txtDato1.Focus();
                    break;
                case "JoyerianiñoAccesorioniño":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idjoyeria";
                    lbliddepartamento.Text = "idaccesorio";
                    txtDato1.Focus();
                    break;
                case "JoyeriaNiñoNiña":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    txtDato1.Focus();
                    break;
                case "Juguetes":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    txtDato6.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "precio";
                    label3.Text = "edad recomendada";
                    label4.Text = "iddepartamento niño niña";
                    txtDato1.Focus();
                    break;
                case "LentesHombre":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    txtDato1.Focus();
                    break;
                case "LenteshombreAccesoriohombre":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idlentes";
                    lbliddepartamento.Text = "idaccesorio";
                    txtDato1.Focus();
                    break;
                case "LentesMujer":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    txtDato1.Focus();
                    break;
                case "LentesmujerAccesorioMujer":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idlentes";
                    lbliddepartamento.Text = "idaccesorio";
                    txtDato1.Focus();
                    break;
                case "LentesniñoAccesorioniño":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idlentes";
                    lbliddepartamento.Text = "idaccesorio";
                    txtDato1.Focus();
                    break;
                case "LentesNiñoNiña":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    txtDato1.Focus();
                    break;
                case "Mochilas":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    txtDato1.Focus();
                    break;
                case "Pantalones_ShortsMujer":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    txtDato1.Focus();
                    break;
                case "PantalonesHombre":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    txtDato1.Focus();
                    break;
                case "PantalonesmujerRopa":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idpantalon";
                    lbliddepartamento.Text = "idropa";
                    txtDato1.Focus();
                    break;
                case "Pantalonesniñoniña":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    txtDato1.Focus();
                    break;
                case "PantalonesniñoRopaniño":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idpantalon";
                    lbliddepartamento.Text = "idropa";
                    txtDato1.Focus();
                    break;
                case "PantalonesRopahombre":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idpantalon";
                    lbliddepartamento.Text = "idropa";
                    txtDato1.Focus();
                    break;
                case "PlayerascamisaRopahombre":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idplayeras";
                    lbliddepartamento.Text = "idropa";
                    txtDato1.Focus();
                    break;
                case "PlayerasCamisas":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    txtDato1.Focus();
                    break;
                case "RelojHombre":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    txtDato1.Focus();
                    break;
                case "RelojhombreAccesoriohombre":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idreloj";
                    lbliddepartamento.Text = "idaccesorio";
                    txtDato1.Focus();
                    break;
                case "RelojMujer":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    txtDato1.Focus();
                    break;
                case "RelojmujerAccesorioMujer":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idreloj";
                    lbliddepartamento.Text = "idaccesorio";
                    txtDato1.Focus();
                    break;
                case "RelojniñoAccesorioniño":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idreloj";
                    lbliddepartamento.Text = "idaccesorio";
                    txtDato1.Focus();
                    break;
                case "RelojNiñoNiña":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    txtDato1.Focus();
                    break;
                case "RopaHombre":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "iddepartamento hombre";
                    txtDato1.Focus();
                    break;
                case "RopaInterior":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    txtDato1.Focus();
                    break;
                case "RopainteriorRopahombre":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idropa interior";
                    lbliddepartamento.Text = "idropa hombre";
                    txtDato1.Focus();
                    break;
                case "RopaMujer":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "iddepartamento mujer";
                    txtDato1.Focus();
                    break;
                case "RopaNiñoNiña":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "iddepartamento niño y niña";
                    txtDato1.Focus();
                    break;
                case "SeguroFamiliar":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    dateTimePicker1.Visible = true;
                    txtDato5.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "Apellido Paterno";
                    label1.Text = "Apellido Materno";
                    label2.Text = "Fecha Nacimiento";
                    label3.Text = "idseguros";
                    txtDato1.Focus();
                    break;
                case "Seguros":
                    txtDato1.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "nombre";
                    txtDato1.Focus();
                    break;
                case "SeguroVehiculo":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    dateTimePicker1.Visible = true;
                    txtDato5.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    lblNombre.Text = "marca";
                    lbliddepartamento.Text = "modelo";
                    label1.Text = "idconductor";
                    label2.Text = "Año";
                    label3.Text = "idseguros";
                    txtDato1.Focus();
                    break;
                case "Tienda":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "ubicacion";
                    label1.Text = "telefono";
                    txtDato1.Focus();
                    break;
                case "TiendaDepartamento":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idtienda";
                    lbliddepartamento.Text = "iddepartamento";
                    txtDato1.Focus();
                    break;
                case "UtilesEscolares":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    txtDato1.Focus();
                    break;
                case "UtilesescolaresEscolares":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idescolares";
                    lbliddepartamento.Text = "idutiles";
                    txtDato1.Focus();
                    break;
                case "Venta":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    dateTimePicker1.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label2.Visible = true;
                    lblNombre.Text = "monto";
                    lbliddepartamento.Text = "factura";
                    label2.Text = "fechaVenta";
                    txtDato1.Focus();
                    break;
                case "VentaCajas":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idventa";
                    lbliddepartamento.Text = "idcajas";
                    txtDato1.Focus();
                    break;
                case "VentaCliente":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idventa";
                    lbliddepartamento.Text = "idcliente";
                    txtDato1.Focus();
                    break;
                case "ZapatosHombre":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    txtDato6.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    label4.Text = "iddepartamento hombre";
                    break;
                case "ZapatosMujer":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    txtDato6.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    label4.Text = "iddepartamento mujer";
                    break;
                case "ZapatosNiñoniña":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    txtDato6.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    label4.Text = "iddepartamento niño niña";
                    break;
            }
        }

        private void btnInsertarRegistro_Click(object sender, EventArgs e)
        {
            string nacimiento = "";
            string inicio = "";
            string fin = "";

            if (cbconenctar.Text != "ORACLE")
            {
                DateTime fechanacimiento = dateTimePicker1.Value;
                nacimiento = fechanacimiento.ToString("yyyy-MM-dd");

                DateTime fechainicio = dateTimePicker2.Value;
                inicio = fechainicio.ToString("yyyy-MM-dd");

                DateTime fechafin = dateTimePicker3.Value;
                fin = fechafin.ToString("yyyy-MM-dd");
            }
            else
            {
                DateTime fechanacimiento = dateTimePicker1.Value;
                nacimiento = fechanacimiento.ToString("dd-MM-yyyy");

                DateTime fechainicio = dateTimePicker2.Value;
                inicio = fechainicio.ToString("dd-MM-yyyy");

                DateTime fechafin = dateTimePicker3.Value;
                fin = fechafin.ToString("dd-MM-yyyy");
            }


            switch (cbTablas.Text)
            {
                case "AccesorioHombre":
                    consulta = "INSERT INTO AccesorioHombre (nombre, iddepartamentohombre) VALUES('" + txtDato1.Text + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "AccesoriosMujer":
                    consulta = "INSERT INTO AccesoriosMujer (nombre, iddepartamentomujer) VALUES('" + txtDato1.Text + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "AccesoriosNiñoNiña":
                    consulta = "INSERT INTO AccesoriosNiñoNiña (nombre, iddepartamentoniñoiña) VALUES('" + txtDato1.Text + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "BlusasplayeraniñoRopaniño":
                    consulta = "INSERT INTO BlusasplayeraniñoRopaniño (idblusas, idropa) VALUES('" + int.Parse(txtDato1.Text) + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "BlusasPlayeras":
                    consulta = "INSERT INTO BlusasPlayeras (nombre, marca, color, talla, precio) VALUES('" + txtDato1.Text + "','" + txtDato2.Text + "','" + txtDato3.Text + "','" + txtDato4.Text + "','" + decimal.Parse(txtDato5.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "Blusasplayerasniñoniña":
                    consulta = "INSERT INTO Blusasplayerasniñoniña (nombre, marca, color, talla, precio) VALUES('" + txtDato1.Text + "','" + txtDato2.Text + "','" + txtDato3.Text + "','" + txtDato4.Text + "','" + decimal.Parse(txtDato5.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "BlusasPlayerasRopa":
                    consulta = "INSERT INTO BlusasPlayerasRopa (idblusasplayeras, idropa) VALUES('" + txtDato1.Text + "','" + txtDato2.Text + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "Bolsas":
                    consulta = "INSERT INTO Bolsas (nombre, marca, color, talla, precio,iddepartamentomujer) VALUES('" + txtDato1.Text + "','" + txtDato2.Text + "','" + txtDato3.Text + "','" + txtDato4.Text + "','" + decimal.Parse(txtDato5.Text) + "','" + txtDato6.Text + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "Cajas":
                    consulta = "INSERT INTO Cajas (numeroCajas) VALUES('" + int.Parse(txtDato1.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "CajasCajeros":
                    consulta = "INSERT INTO CajasCajeros (idcajas, idcajeros) VALUES('" + int.Parse(txtDato1.Text) + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "Cajero":
                    consulta = "INSERT INTO Cajero (nombre, apellidoPaterno, apellidoMaterno) VALUES ('" + txtDato1.Text + "','" + txtDato2.Text + "','" + txtDato3.Text + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "Cliente":
                    consulta = "INSERT INTO Cliente (nombre, apellidoPaterno, apellidoMaterno, telefono) VALUES ('" + txtDato1.Text + "','" + txtDato2.Text + "','" + txtDato3.Text + "','" + txtDato4.Text + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "ClienteSeguros":
                    consulta = "INSERT INTO ClienteSeguros (idcliente, idseguro) VALUES('" + int.Parse(txtDato1.Text) + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "ClienteTienda":
                    consulta = "INSERT INTO ClienteTienda (idcliente, idtienda) VALUES('" + int.Parse(txtDato1.Text) + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "Conductor":
                    consulta = "INSERT INTO Conductor (nombre, genero, codigopostal, fechaNacimiento) VALUES ('" + txtDato1.Text + "','" + txtDato2.Text + "','" + int.Parse(txtDato3.Text) + "','" + nacimiento + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "Credito":
                    consulta = "INSERT INTO Credito (nombre, apellidoPaterno, apellidoMaterno, fechaNacimiento, numeroTarjeta,meses, fechaInicio, fechaFinal, monto, factura, idformaspago) VALUES('" + txtDato1.Text + "','" + txtDato2.Text + "','" + txtDato3.Text + "','" + nacimiento + "','" + int.Parse(txtDato5.Text) + "','" + int.Parse(txtDato6.Text) + "','" + inicio + "','" + fin + "','" + decimal.Parse(txtDato9.Text) + "','" + txtDato10.Text + "','" + int.Parse(txtDato11.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "Debito":
                    consulta = "INSERT INTO Debito (monto, numeroTarjeta, fechapago, factura, idformaspago) VALUES('" + decimal.Parse(txtDato1.Text) + "','" + txtDato2.Text + "','" + nacimiento + "','" + int.Parse(txtDato3.Text) + "','" + txtDato5.Text + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "Departamento":
                    consulta = "INSERT INTO Departamento (nombre, piso) VALUES('" + txtDato1.Text + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "DepartamentoHombre":
                    consulta = "INSERT INTO DepartamentoHombre (nombre, iddepartamentogeneral) VALUES('" + txtDato1.Text + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "DepartamentoMujer":
                    consulta = "INSERT INTO DepartamentoMujer (nombre, iddepartamentogeneral) VALUES('" + txtDato1.Text + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "DepartamentoNiñoNiña":
                    consulta = "INSERT INTO DepartamentoNiñoNiña (nombre, iddepartamentogeneral) VALUES('" + txtDato1.Text + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "DeportivoNiñoNiña":
                    consulta = "INSERT INTO DeportivoNiñoNiña (nombre, marca, color, talla, precio) VALUES('" + txtDato1.Text + "','" + txtDato2.Text + "','" + txtDato3.Text + "','" + txtDato4.Text + "','" + decimal.Parse(txtDato5.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "DeportivoNiñoRopaNiño":
                    consulta = "INSERT INTO DeportivoNiñoRopaNiño (iddeportivo, idropa) VALUES('" + int.Parse(txtDato1.Text) + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "Efectivo":
                    consulta = "INSERT INTO Efectivo (monto, cambio, fechaPago, factura, idformaspago) VALUES('" + decimal.Parse(txtDato1.Text) + "','" + decimal.Parse(txtDato2.Text) + "','" + nacimiento + "','" + int.Parse(txtDato3.Text) + "','" + int.Parse(txtDato5.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "Empleados":
                    consulta = "INSERT INTO Empleados (nombre, apellidoPaterno, apellidoMaterno, direccion, telefono) VALUES('" + txtDato1.Text + "','" + txtDato2.Text + "','" + txtDato3.Text + "','" + txtDato4.Text + "','" + txtDato5.Text + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "EmpleadosTienda":
                    consulta = "INSERT INTO EmpleadosTienda (idtienda, idempleado) VALUES('" + int.Parse(txtDato1.Text) + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "Escolares":
                    consulta = "INSERT INTO Escolares (nombre, iddepartamentoniñoniña) VALUES('" + txtDato1.Text + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "EscolaresMochilas":
                    consulta = "INSERT INTO EscolaresMochilas (idescolares, idmochilas) VALUES('" + int.Parse(txtDato1.Text) + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "FormasPago":
                    consulta = "INSERT INTO FormasPago (nombre) VALUES('" + int.Parse(txtDato1.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "FormaspagoVenta":
                    consulta = "INSERT INTO FormaspagoVenta (idformaspago, idventa) VALUES('" + int.Parse(txtDato1.Text) + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "Gerente":
                    consulta = "INSERT INTO Gerente (nombre, apellidoPaterno, apellidoMaterno, direccion, telefono) VALUES('" + txtDato1.Text + "','" + txtDato2.Text + "','" + txtDato3.Text + "','" + txtDato4.Text + "','" + txtDato5.Text + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "GerenteTienda":
                    consulta = "INSERT INTO GerenteTienda (idtienda, idgerente) VALUES('" + int.Parse(txtDato1.Text) + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "JoyeriaHombre":
                    consulta = "INSERT INTO JoyeriaHombre (nombre, marca, color, talla, precio) VALUES('" + txtDato1.Text + "','" + txtDato2.Text + "','" + txtDato3.Text + "','" + txtDato4.Text + "','" + decimal.Parse(txtDato5.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "JoyeriahombreAccesoriohombre":
                    consulta = "INSERT INTO JoyeriahombreAccesoriohombre (idjoyeria, idaccesorio) VALUES('" + int.Parse(txtDato1.Text) + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "JoyeriaMujer":
                    consulta = "INSERT INTO JoyeriaMujer (nombre, marca, color, talla, precio) VALUES('" + txtDato1.Text + "','" + txtDato2.Text + "','" + txtDato3.Text + "','" + txtDato4.Text + "','" + decimal.Parse(txtDato5.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "JoyeriamujerAccesoriomujer":
                    consulta = "INSERT INTO JoyeriamujerAccesoriomujer (idjoyeria, idaccesorio) VALUES('" + int.Parse(txtDato1.Text) + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "JoyerianiñoAccesorioniño":
                    consulta = "INSERT INTO JoyeriamujerAccesoriomujer (idjoyeria, idaccesorio) VALUES('" + int.Parse(txtDato1.Text) + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "JoyeriaNiñoNiña":
                    consulta = "INSERT INTO JoyeriaNiñoNiña (nombre, marca, color, talla, precio) VALUES('" + txtDato1.Text + "','" + txtDato2.Text + "','" + txtDato3.Text + "','" + txtDato4.Text + "','" + decimal.Parse(txtDato5.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "Juguetes":
                    consulta = "INSERT INTO Juguetes (nombre, marca, color, edadRecomendada, precio,iddepartamentoNiñoNiña) VALUES('" + txtDato1.Text + "','" + txtDato2.Text + "','" + txtDato3.Text + "','" + int.Parse(txtDato4.Text) + "','" + decimal.Parse(txtDato5.Text) + "','" + int.Parse(txtDato6.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "LentesHombre":
                    consulta = "INSERT INTO LentesHombre (nombre, marca, color, talla, precio) VALUES('" + txtDato1.Text + "','" + txtDato2.Text + "','" + txtDato3.Text + "','" + txtDato4.Text + "','" + decimal.Parse(txtDato5.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "LenteshombreAccesoriohombre":
                    consulta = "INSERT INTO LenteshombreAccesoriohombre (idlentes, idaccesorio) VALUES('" + int.Parse(txtDato1.Text) + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "LentesMujer":
                    consulta = "INSERT INTO LentesMujer (nombre, marca, color, talla, precio) VALUES('" + txtDato1.Text + "','" + txtDato2.Text + "','" + txtDato3.Text + "','" + txtDato4.Text + "','" + decimal.Parse(txtDato5.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "LentesmujerAccesorioMujer":
                    consulta = "INSERT INTO LentesmujerAccesorioMujer (idlentes, idaccesorio) VALUES('" + int.Parse(txtDato1.Text) + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "LentesniñoAccesorioniño":
                    consulta = "INSERT INTO LentesniñoAccesorioniño (idlentes, idaccesorio) VALUES('" + int.Parse(txtDato1.Text) + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "LentesNiñoNiña":
                    consulta = "INSERT INTO LentesNiñoNiña (nombre, marca, color, talla, precio) VALUES('" + txtDato1.Text + "','" + txtDato2.Text + "','" + txtDato3.Text + "','" + txtDato4.Text + "','" + decimal.Parse(txtDato5.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "Mochilas":
                    consulta = "INSERT INTO Mochilas (nombre, marca, color, talla, precio) VALUES('" + txtDato1.Text + "','" + txtDato2.Text + "','" + txtDato3.Text + "','" + txtDato4.Text + "','" + decimal.Parse(txtDato5.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "Pantalones_ShortsMujer":
                    consulta = "INSERT INTO Pantalones_ShortsMujer (nombre, marca, color, talla, precio) VALUES('" + txtDato1.Text + "','" + txtDato2.Text + "','" + txtDato3.Text + "','" + txtDato4.Text + "','" + decimal.Parse(txtDato5.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "PantalonesHombre":
                    consulta = "INSERT INTO PantalonesHombre (nombre, marca, color, talla, precio) VALUES('" + txtDato1.Text + "','" + txtDato2.Text + "','" + txtDato3.Text + "','" + txtDato4.Text + "','" + decimal.Parse(txtDato5.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "PantalonesmujerRopa":
                    consulta = "INSERT INTO PantalonesmujerRopa (idpantalon, idropa) VALUES('" + int.Parse(txtDato1.Text) + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "Pantalonesniñoniña":
                    consulta = "INSERT INTO Pantalonesniñoniña (nombre, marca, color, talla, precio) VALUES('" + txtDato1.Text + "','" + txtDato2.Text + "','" + txtDato3.Text + "','" + txtDato4.Text + "','" + decimal.Parse(txtDato5.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "PantalonesniñoRopaniño":
                    consulta = "INSERT INTO PantalonesniñoRopaniño (idpantalones, idropa) VALUES('" + int.Parse(txtDato1.Text) + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "PantalonesRopahombre":
                    consulta = "INSERT INTO PantalonesRopahombre (idpantalones, idropa) VALUES('" + int.Parse(txtDato1.Text) + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "PlayerascamisaRopahombre":
                    consulta = "INSERT INTO PlayerascamisaRopahombre (idplayeras, idropa) VALUES('" + int.Parse(txtDato1.Text) + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "PlayerasCamisas":
                    consulta = "INSERT INTO PlayerasCamisas (nombre, marca, color, talla, precio) VALUES('" + txtDato1.Text + "','" + txtDato2.Text + "','" + txtDato3.Text + "','" + txtDato4.Text + "','" + decimal.Parse(txtDato5.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "RelojHombre":
                    consulta = "INSERT INTO RelojHombre (nombre, marca, color, talla, precio) VALUES('" + txtDato1.Text + "','" + txtDato2.Text + "','" + txtDato3.Text + "','" + txtDato4.Text + "','" + decimal.Parse(txtDato5.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "RelojhombreAccesoriohombre":
                    consulta = "INSERT INTO RelojhombreAccesoriohombre (idreloj, idaccesorio) VALUES('" + int.Parse(txtDato1.Text) + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "RelojMujer":
                    consulta = "INSERT INTO RelojMujer (nombre, marca, color, talla, precio) VALUES('" + txtDato1.Text + "','" + txtDato2.Text + "','" + txtDato3.Text + "','" + txtDato4.Text + "','" + decimal.Parse(txtDato5.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "RelojmujerAccesorioMujer":
                    consulta = "INSERT INTO RelojmujerAccesorioMujer (idreloj, idaccesorio) VALUES('" + int.Parse(txtDato1.Text) + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "RelojniñoAccesorioniño":
                    consulta = "INSERT INTO RelojniñoAccesorioniño (idreloj, idaccesorio) VALUES('" + int.Parse(txtDato1.Text) + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "RelojNiñoNiña":
                    consulta = "INSERT INTO RelojNiñoNiña (nombre, marca, color, talla, precio) VALUES('" + txtDato1.Text + "','" + txtDato2.Text + "','" + txtDato3.Text + "','" + txtDato4.Text + "','" + decimal.Parse(txtDato5.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "RopaHombre":
                    consulta = "INSERT INTO RopaHombre (nombre, iddepartamentohombre) VALUES('" + txtDato1.Text + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "RopaInterior":
                    consulta = "INSERT INTO RopaInterior (nombre, marca, color, talla, precio) VALUES('" + txtDato1.Text + "','" + txtDato2.Text + "','" + txtDato3.Text + "','" + txtDato4.Text + "','" + decimal.Parse(txtDato5.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "RopainteriorRopahombre":
                    consulta = "INSERT INTO RopaHombre (idropainterior, idropahombre) VALUES('" + int.Parse(txtDato1.Text) + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "RopaMujer":
                    consulta = "INSERT INTO RopaMujer (nombreDepartamento, iddepartamentomujer) VALUES('" + txtDato1.Text + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "RopaNiñoNiña":
                    consulta = "INSERT INTO RopaNiñoNiña (nombre, iddepartamentoniñoniña) VALUES('" + txtDato1.Text + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "SeguroFamiliar":
                    consulta = "INSERT INTO SeguroFamiliar (nombre, apellidoPaterno, apellidoMaterno, fechaNacimiento, idseguros) VALUES('" + txtDato1.Text + "','" + txtDato2.Text + "','" + txtDato3.Text + "','" + nacimiento + "','" + int.Parse(txtDato5.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "Seguros":
                    consulta = "INSERT INTO Seguros (nombre) VALUES('" + txtDato1.Text + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "SeguroVehiculo":
                    consulta = "INSERT INTO SeguroVehiculo (marca, modelo, año, idconductor, idseguros) VALUES('" + txtDato1.Text + "','" + txtDato2.Text + "','" + nacimiento + "','" + int.Parse(txtDato3.Text) + "','" + int.Parse(txtDato5.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "Tienda":
                    consulta = "INSERT INTO Tienda (nombre, ubicacion, telefono) VALUES('" + txtDato1.Text + "','" + txtDato2.Text + "','" + txtDato3.Text + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "TiendaDepartamento":
                    consulta = "INSERT INTO TiendaDepartamento (idtienda, iddepartamento) VALUES('" + int.Parse(txtDato1.Text) + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "UtilesEscolares":
                    consulta = "INSERT INTO UtilesEscolares (nombre, marca, color, talla, precio) VALUES('" + txtDato1.Text + "','" + txtDato2.Text + "','" + txtDato3.Text + "','" + txtDato4.Text + "','" + decimal.Parse(txtDato5.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "UtilesescolaresEscolares":
                    consulta = "INSERT INTO UtilesescolaresEscolares (idescolares, idutiles) VALUES('" + int.Parse(txtDato1.Text) + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "Venta":
                    consulta = "INSERT INTO Venta (monto, factura, fechaVenta) VALUES('" + decimal.Parse(txtDato1.Text) + "','" + int.Parse(txtDato2.Text) + "','" + nacimiento + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "VentaCajas":
                    consulta = "INSERT INTO VentaCajas (idventa, idcaja) VALUES('" + int.Parse(txtDato1.Text) + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "VentaCliente":
                    consulta = "INSERT INTO VentaCliente (idventa, idcliente) VALUES('" + int.Parse(txtDato1.Text) + "','" + int.Parse(txtDato2.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "ZapatosHombre":
                    consulta = "INSERT INTO ZapatosHombre (nombre, marca, color, talla, precio,iddepartamentohombre) VALUES('" + txtDato1.Text + "','" + txtDato2.Text + "','" + txtDato3.Text + "','" + txtDato4.Text + "','" + decimal.Parse(txtDato5.Text) + "','" + int.Parse(txtDato6.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "ZapatosMujer":
                    consulta = "INSERT INTO ZapatosMujer (nombre, marca, color, talla, precio,iddepartamentomujer) VALUES('" + txtDato1.Text + "','" + txtDato2.Text + "','" + txtDato3.Text + "','" + txtDato4.Text + "','" + decimal.Parse(txtDato5.Text) + "','" + int.Parse(txtDato6.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
                case "ZapatosNiñoniña":
                    consulta = "INSERT INTO ZapatosNiñoniña (nombre, marca, color, talla, precio,iddepartamentoniñoniña) VALUES('" + txtDato1.Text + "','" + txtDato2.Text + "','" + txtDato3.Text + "','" + txtDato4.Text + "','" + decimal.Parse(txtDato5.Text) + "','" + int.Parse(txtDato6.Text) + "');";
                    Datos.InsertarRegistro(consulta);
                    break;
            }
            actualizar();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count == 0)
            {
                MessageBox.Show("SELECCIONA UNA TABLA");
                return;
            }
            btnInsertarRegistro.Visible = false;
            btnmodi.Visible = true;
            button2.Visible = false;
            button1.Visible = true;
            lblbuscar.Visible = false;
            txtbuscar.Visible = false;
            cbbuscar.Visible = false;
            string a = dataGridView1.ColumnCount.ToString();
            DataGridViewRow row = dataGridView1.CurrentRow;
            string dato1 = "";
            string dato2 = "";
            string dato3 = "";
            string dato4 = "";
            string dato5 = "";
            string dato6 = "";
            string dato7 = "";
            string dato8 = "";
            string dato9 = "";
            string dato10 = "";
            string dato11 = "";
            string dato12 = "";

            if (a == "1")
            {
                dato1 = row.Cells[1].Value.ToString();
            }
            else if (a == "2")
            {
                dato1 = row.Cells[1].Value.ToString();

            }
            else if (a == "3")
            {
                dato1 = row.Cells[1].Value.ToString();
                dato2 = row.Cells[2].Value.ToString();


            }
            else if (a == "4")
            {
                dato1 = row.Cells[1].Value.ToString();
                dato2 = row.Cells[2].Value.ToString();
                dato3 = row.Cells[3].Value.ToString();

            }
            else if (a == "5")
            {
                dato1 = row.Cells[1].Value.ToString();
                dato2 = row.Cells[2].Value.ToString();
                dato3 = row.Cells[3].Value.ToString();
                dato4 = row.Cells[4].Value.ToString();

            }
            else if (a == "6")
            {
                dato1 = row.Cells[1].Value.ToString();
                dato2 = row.Cells[2].Value.ToString();
                dato3 = row.Cells[3].Value.ToString();
                dato4 = row.Cells[4].Value.ToString();
                dato5 = row.Cells[5].Value.ToString();

            }
            else if (a == "7")
            {
                dato1 = row.Cells[1].Value.ToString();
                dato2 = row.Cells[2].Value.ToString();
                dato3 = row.Cells[3].Value.ToString();
                dato4 = row.Cells[4].Value.ToString();
                dato5 = row.Cells[5].Value.ToString();
                dato6 = row.Cells[6].Value.ToString();
                //dato7 = row.Cells[7].Value.ToString();
            }
            else if (a == "8")
            {

                dato1 = row.Cells[1].Value.ToString();
                dato2 = row.Cells[2].Value.ToString();
                dato3 = row.Cells[3].Value.ToString();
                dato4 = row.Cells[4].Value.ToString();
                dato5 = row.Cells[5].Value.ToString();
                dato6 = row.Cells[6].Value.ToString();
                dato7 = row.Cells[7].Value.ToString();

            }
            else if (a == "9")
            {
                dato1 = row.Cells[1].Value.ToString();
                dato2 = row.Cells[2].Value.ToString();
                dato3 = row.Cells[3].Value.ToString();
                dato4 = row.Cells[4].Value.ToString();
                dato5 = row.Cells[5].Value.ToString();
                dato6 = row.Cells[6].Value.ToString();
                dato7 = row.Cells[7].Value.ToString();
                dato8 = row.Cells[8].Value.ToString();

            }
            else if (a == "10")
            {
                dato1 = row.Cells[1].Value.ToString();
                dato2 = row.Cells[2].Value.ToString();
                dato3 = row.Cells[3].Value.ToString();
                dato4 = row.Cells[4].Value.ToString();
                dato5 = row.Cells[5].Value.ToString();
                dato6 = row.Cells[6].Value.ToString();
                dato7 = row.Cells[7].Value.ToString();
                dato8 = row.Cells[8].Value.ToString();
                dato9 = row.Cells[9].Value.ToString();

            }
            else if (a == "13")
            {
                dato1 = row.Cells[1].Value.ToString();
                dato2 = row.Cells[2].Value.ToString();
                dato3 = row.Cells[3].Value.ToString();
                dato4 = row.Cells[4].Value.ToString();
                dato5 = row.Cells[5].Value.ToString();
                dato6 = row.Cells[6].Value.ToString();
                dato7 = row.Cells[7].Value.ToString();
                dato8 = row.Cells[8].Value.ToString();
                dato9 = row.Cells[9].Value.ToString();
                dato10 = row.Cells[10].Value.ToString();
                dato11 = row.Cells[11].Value.ToString();
                dato12 = row.Cells[12].Value.ToString();

            }

            switch (cbTablas.Text)
            {
                case "AccesorioHombre":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label1.Text = "estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "AccesoriosMujer":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label1.Text = "estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "AccesoriosNiñoNiña":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label1.Text = "estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "BlusasplayeraniñoRopaniño":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label1.Text = "estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "BlusasPlayeras":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    txtDato6.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    label4.Text = "estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato4.Text = dato4;
                    txtDato5.Text = dato5;
                    txtDato6.Text = dato6;
                    txtDato1.Focus();
                    break;
                case "Blusasplayerasniñoniña":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    txtDato6.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    label4.Text = "estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato4.Text = dato4;
                    txtDato5.Text = dato5;
                    txtDato6.Text = dato6;
                    txtDato1.Focus();
                    break;
                case "BlusasPlayerasRopa":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Estatus";
                    lblNombre.Text = "idblusasplayeras";
                    lbliddepartamento.Text = "idropa";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "Bolsas":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    txtDato6.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    label4.Text = "estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato4.Text = dato4;
                    txtDato5.Text = dato5;
                    txtDato6.Text = dato6;
                    txtDato1.Focus();
                    break;
                case "Cajas":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lblNombre.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Text = "Numero Cajas";
                    lbliddepartamento.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato1.Focus();
                    break;
                case "CajasCajeros":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Estatus";
                    lblNombre.Text = "idcajas";
                    lbliddepartamento.Text = "idcajeros";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "Cajero":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "Apellido Paterno";
                    label1.Text = "Apellido Materno";
                    label2.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato4.Text = dato4;
                    txtDato1.Focus();
                    break;
                case "Cliente":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "Apellido Paterno";
                    label1.Text = "Apellido Materno";
                    label2.Text = "Telefono";
                    label3.Text = "estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato4.Text = dato4;
                    txtDato5.Text = dato5;
                    txtDato1.Focus();
                    break;
                case "ClienteSeguros":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    lblNombre.Visible = true;
                    lbliddepartamento.Visible = true;
                    label1.Visible = true;
                    lblNombre.Text = "idcliente";
                    lbliddepartamento.Text = "idseguro";
                    label1.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "ClienteTienda":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lblNombre.Visible = true;
                    lbliddepartamento.Visible = true;
                    label1.Visible = true;
                    lblNombre.Text = "idcliente";
                    lbliddepartamento.Text = "idtienda";
                    label1.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "Conductor":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato5.Visible = true;
                    dateTimePicker1.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "Genero";
                    label1.Text = "Codigo Postal";
                    label2.Text = "Fecha Nacimiento";
                    label3.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    dateTimePicker1.Text = dato4.ToString();
                    txtDato5.Text = dato5;
                    txtDato1.Focus();
                    break;
                case "Credito":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    dateTimePicker1.Visible = true;
                    txtDato5.Visible = true;
                    txtDato6.Visible = true;
                    dateTimePicker2.Visible = true;
                    dateTimePicker3.Visible = true;
                    txtDato9.Visible = true;
                    txtDato10.Visible = true;
                    txtDato11.Text = "3";
                    txtDato11.Visible = true;
                    txtDato10.Visible = true;
                    txtDato12.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "Apellido paterno";
                    label1.Text = "Apellido materno";
                    label2.Text = "Fecha Nacimiento";
                    label3.Text = "Numero de tarjeta";
                    label4.Text = "meses";
                    label5.Text = "Fecha inicio";
                    label6.Text = "Fecha final";
                    label7.Text = "monto";
                    label8.Text = "factura";
                    label9.Text = "idformapago";
                    label10.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    dateTimePicker1.Text = dato4.ToString(); ;
                    txtDato5.Text = dato5;
                    txtDato6.Text = dato6;
                    dateTimePicker2.Text = dato7.ToString();
                    dateTimePicker3.Text = dato8.ToString();
                    txtDato9.Text = dato9;
                    txtDato10.Text = dato10;
                    txtDato11.Text = dato11;
                    txtDato12.Text = dato12;
                    txtDato1.Focus();
                    break;

                case "Debito":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    dateTimePicker1.Visible = true;
                    txtDato3.Visible = true;
                    txtDato5.Visible = true;
                    txtDato5.Text = "1";
                    txtDato6.Visible = true;
                    lblNombre.Visible = true;
                    lbliddepartamento.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    lblNombre.Text = "monto";
                    lbliddepartamento.Text = "Numero de tarjeta";
                    label1.Text = "Factura";
                    label2.Text = "Fecha Pago";
                    label3.Text = "idformapago";
                    label4.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato4;
                    dateTimePicker1.Text = dato3.ToString();
                    txtDato5.Text = dato5;
                    txtDato6.Text = dato6;
                    txtDato1.Focus();
                    break;

                case "Departamento":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    lblNombre.Visible = true;
                    lbliddepartamento.Visible = true;
                    label1.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "piso";
                    label1.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "DepartamentoHombre":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    lblNombre.Visible = true;
                    lbliddepartamento.Visible = true;
                    label1.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "iddepartamentogeneral";
                    label1.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "DepartamentoMujer":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lblNombre.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "iddepartamentogeneral";
                    txtDato3.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "DepartamentoNiñoNiña":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lblNombre.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "iddepartamentogeneral";
                    txtDato3.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "DeportivoNiñoNiña":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    txtDato6.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    label4.Text = "estatus";

                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato4.Text = dato4;
                    txtDato5.Text = dato5;
                    txtDato6.Text = dato6;
                    txtDato1.Focus();
                    break;

                case "DeportivoNiñoRopaNiño":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "iddeportivo";
                    lbliddepartamento.Text = "idropa";
                    txtDato3.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "Efectivo":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    dateTimePicker1.Visible = true;
                    txtDato5.Visible = true;
                    txtDato6.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    lblNombre.Text = "monto";
                    lbliddepartamento.Text = "cambio";
                    label1.Text = "factura";
                    label2.Text = "fecha de pago";
                    label3.Text = "idformas pago";
                    label4.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato4;
                    dateTimePicker1.Text = dato3.ToString();
                    txtDato5.Text = dato5;
                    txtDato6.Text = dato6;
                    txtDato1.Focus();
                    break;
                case "Empleados":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    txtDato6.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "Apellido Paterno";
                    label1.Text = "Apellido Materno";
                    label2.Text = "Direccion";
                    label3.Text = "Telefono";
                    label4.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato4.Text = dato4;
                    txtDato5.Text = dato5;
                    txtDato6.Text = dato6;
                    txtDato1.Focus();

                    break;
                case "EmpleadosTienda":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idtienda";
                    lbliddepartamento.Text = "idempleado";
                    txtDato3.Visible = true;
                    label1.Visible = true;
                    txtDato3.Visible = true;
                    label1.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "Escolares":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "iddepartamento niño niña";
                    txtDato3.Visible = true;
                    label1.Visible = true;
                    txtDato3.Visible = true;
                    label1.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "EscolaresMochilas":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idescolares";
                    lbliddepartamento.Text = "idmochilas";
                    txtDato3.Visible = true;
                    label1.Visible = true;
                    txtDato3.Visible = true;
                    label1.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "FormasPago":
                    txtDato1.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "nombre";
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lbliddepartamento.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato1.Focus();
                    break;
                case "FormaspagoVenta":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idformas de pago";
                    lbliddepartamento.Text = "idventa";
                    txtDato3.Visible = true;
                    label1.Visible = true;
                    txtDato3.Visible = true;
                    label1.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "Gerente":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "Apellido Paterno";
                    label1.Text = "Apellido Materno";
                    label2.Text = "Direccion";
                    label3.Text = "Telefono";
                    txtDato6.Visible = true;
                    label4.Visible = true;
                    label4.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato4.Text = dato4;
                    txtDato5.Text = dato5;
                    txtDato6.Text = dato6;
                    txtDato1.Focus();
                    break;
                case "GerenteTienda":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idtienda";
                    lbliddepartamento.Text = "idgerente";
                    txtDato3.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "JoyeriaHombre":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    txtDato6.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    label4.Text = "estatus";

                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato4.Text = dato4;
                    txtDato5.Text = dato5;
                    txtDato6.Text = dato6;
                    txtDato1.Focus();
                    txtDato1.Focus();
                    break;
                case "JoyeriahombreAccesoriohombre":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idjoyeria";
                    lbliddepartamento.Text = "idaccesorio";
                    txtDato3.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "JoyeriaMujer":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    txtDato6.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    label4.Text = "estatus";

                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato4.Text = dato4;
                    txtDato5.Text = dato5;
                    txtDato6.Text = dato6;
                    txtDato1.Focus();
                    break;
                case "JoyeriamujerAccesoriomujer":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idjoyeria";
                    lbliddepartamento.Text = "idaccesorio";
                    txtDato3.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "JoyerianiñoAccesorioniño":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idjoyeria";
                    lbliddepartamento.Text = "idaccesorio";
                    txtDato3.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "JoyeriaNiñoNiña":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    txtDato6.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    label4.Text = "estatus";

                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato4.Text = dato4;
                    txtDato5.Text = dato5;
                    txtDato6.Text = dato6;
                    txtDato1.Focus();
                    break;
                case "Juguetes":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    txtDato6.Visible = true;
                    txtDato7.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "precio";
                    label3.Text = "edad recomendada";
                    label4.Text = "iddepartamento niño niña";
                    label5.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato4.Text = dato4;
                    txtDato5.Text = dato5;
                    txtDato6.Text = dato6;
                    txtDato7.Text = dato7;

                    txtDato1.Focus();
                    break;
                case "LentesHombre":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    txtDato6.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    label4.Text = "estatus";

                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato4.Text = dato4;
                    txtDato5.Text = dato5;
                    txtDato6.Text = dato6;
                    txtDato1.Focus();
                    break;
                case "LenteshombreAccesoriohombre":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idlentes";
                    lbliddepartamento.Text = "idaccesorio";
                    txtDato3.Visible = true;
                    txtDato3.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "LentesMujer":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    txtDato6.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    label4.Text = "estatus";

                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato4.Text = dato4;
                    txtDato5.Text = dato5;
                    txtDato6.Text = dato6;
                    txtDato1.Focus();
                    break;
                case "LentesmujerAccesorioMujer":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idlentes";
                    lbliddepartamento.Text = "idaccesorio";
                    txtDato3.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "LentesniñoAccesorioniño":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idlentes";
                    lbliddepartamento.Text = "idaccesorio";
                    txtDato3.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "LentesNiñoNiña":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    txtDato6.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    label4.Text = "estatus";

                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato4.Text = dato4;
                    txtDato5.Text = dato5;
                    txtDato6.Text = dato6;
                    txtDato1.Focus();
                    break;
                case "Mochilas":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    txtDato6.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    label4.Text = "estatus";

                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato4.Text = dato4;
                    txtDato5.Text = dato5;
                    txtDato6.Text = dato6;
                    txtDato1.Focus();
                    break;
                case "Pantalones_ShortsMujer":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    txtDato6.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    label4.Text = "estatus";

                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato4.Text = dato4;
                    txtDato5.Text = dato5;
                    txtDato6.Text = dato6;
                    txtDato1.Focus();
                    break;
                case "PantalonesHombre":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    txtDato6.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    label4.Text = "estatus";

                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato4.Text = dato4;
                    txtDato5.Text = dato5;
                    txtDato6.Text = dato6;
                    txtDato1.Focus();
                    break;
                case "PantalonesmujerRopa":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idpantalon";
                    lbliddepartamento.Text = "idropa";
                    txtDato3.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "Pantalonesniñoniña":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    txtDato6.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    label4.Text = "estatus";

                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato4.Text = dato4;
                    txtDato5.Text = dato5;
                    txtDato6.Text = dato6;
                    txtDato1.Focus();
                    break;
                case "PantalonesniñoRopaniño":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idpantalon";
                    lbliddepartamento.Text = "idropa";
                    txtDato3.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "PantalonesRopahombre":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idpantalon";
                    lbliddepartamento.Text = "idropa";
                    txtDato3.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "PlayerascamisaRopahombre":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idplayeras";
                    lbliddepartamento.Text = "idropa";
                    txtDato3.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "PlayerasCamisas":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    txtDato6.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    label4.Text = "estatus";

                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato4.Text = dato4;
                    txtDato5.Text = dato5;
                    txtDato6.Text = dato6;
                    txtDato1.Focus();
                    break;
                case "RelojHombre":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    txtDato6.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    label4.Text = "estatus";

                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato4.Text = dato4;
                    txtDato5.Text = dato5;
                    txtDato6.Text = dato6;
                    txtDato1.Focus();
                    break;
                case "RelojhombreAccesoriohombre":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idreloj";
                    lbliddepartamento.Text = "idaccesorio";
                    txtDato3.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "RelojMujer":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    txtDato6.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    label4.Text = "estatus";

                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato4.Text = dato4;
                    txtDato5.Text = dato5;
                    txtDato6.Text = dato6;
                    txtDato1.Focus();
                    break;
                case "RelojmujerAccesorioMujer":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idreloj";
                    lbliddepartamento.Text = "idaccesorio";
                    txtDato3.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "RelojniñoAccesorioniño":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idreloj";
                    lbliddepartamento.Text = "idaccesorio";
                    txtDato3.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "RelojNiñoNiña":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    txtDato6.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    label4.Text = "estatus";

                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato4.Text = dato4;
                    txtDato5.Text = dato5;
                    txtDato6.Text = dato6;
                    txtDato1.Focus();
                    break;
                case "RopaHombre":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "iddepartamento hombre";
                    txtDato3.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "RopaInterior":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    txtDato6.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    label4.Text = "estatus";

                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato4.Text = dato4;
                    txtDato5.Text = dato5;
                    txtDato6.Text = dato6;
                    txtDato1.Focus();
                    break;
                case "RopainteriorRopahombre":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idropa interior";
                    lbliddepartamento.Text = "idropa hombre";
                    txtDato3.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "RopaMujer":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "iddepartamento mujer";
                    txtDato3.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "RopaNiñoNiña":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "iddepartamento niño y niña";
                    txtDato3.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "SeguroFamiliar":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    dateTimePicker1.Visible = true;
                    txtDato5.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "Apellido Paterno";
                    label1.Text = "Apellido Materno";
                    label2.Text = "Fecha Nacimiento";
                    label3.Text = "idseguros";
                    txtDato6.Visible = true;
                    label4.Visible = true;
                    label4.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    dateTimePicker1.Text = dato4.ToString();
                    txtDato5.Text = dato5;
                    txtDato6.Text = dato6;

                    txtDato1.Focus();
                    break;
                case "Seguros":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lblNombre.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato1.Focus();
                    break;
                case "SeguroVehiculo":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    dateTimePicker1.Visible = true;
                    txtDato5.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    lblNombre.Text = "marca";
                    lbliddepartamento.Text = "modelo";
                    label1.Text = "idconductor";
                    label2.Text = "Año";
                    label3.Text = "idseguros";
                    txtDato6.Visible = true;
                    label4.Visible = true;
                    label4.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato4;
                    dateTimePicker1.Text = dato3.ToString();
                    txtDato5.Text = dato5;
                    txtDato6.Text = dato6;
                    txtDato1.Focus();
                    break;
                case "Tienda":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "ubicacion";
                    label1.Text = "telefono";
                    txtDato4.Visible = true;
                    label2.Visible = true;
                    label2.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato4.Text = dato4;
                    txtDato1.Focus();
                    break;
                case "TiendaDepartamento":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idtienda";
                    lbliddepartamento.Text = "iddepartamento";
                    txtDato3.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "UtilesEscolares":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    txtDato6.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    label4.Text = "estatus";

                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato4.Text = dato4;
                    txtDato5.Text = dato5;
                    txtDato6.Text = dato6;
                    txtDato1.Focus();
                    break;
                case "UtilesescolaresEscolares":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idescolares";
                    lbliddepartamento.Text = "idutiles";
                    txtDato3.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "Venta":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    dateTimePicker1.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label2.Visible = true;
                    lblNombre.Text = "monto";
                    lbliddepartamento.Text = "factura";
                    label2.Text = "fechaVenta";
                    txtDato3.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato4;
                    txtDato3.Visible = true;
                    dateTimePicker1.Text = dato3.ToString();
                    txtDato1.Focus();
                    break;
                case "VentaCajas":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idventa";
                    lbliddepartamento.Text = "idcajas";
                    txtDato3.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "VentaCliente":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    lblNombre.Text = "idventa";
                    lbliddepartamento.Text = "idcliente";
                    txtDato3.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Estatus";
                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato1.Focus();
                    break;
                case "ZapatosHombre":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    txtDato6.Visible = true;
                    txtDato7.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    label4.Text = "iddepartamento hombre";
                    label5.Text = "estatus";

                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato4.Text = dato4;
                    txtDato5.Text = dato5;
                    txtDato6.Text = dato6;
                    txtDato7.Text = dato7;
                    txtDato1.Focus();
                    break;
                case "ZapatosMujer":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    txtDato6.Visible = true;
                    txtDato7.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    label4.Text = "iddepartamento mujer";
                    label5.Text = "estatus";

                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato4.Text = dato4;
                    txtDato5.Text = dato5;
                    txtDato6.Text = dato6;
                    txtDato7.Text = dato7;
                    txtDato1.Focus();
                    break;
                case "ZapatosNiñoniña":
                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    txtDato5.Visible = true;
                    txtDato6.Visible = true;
                    txtDato7.Visible = true;
                    lbliddepartamento.Visible = true;
                    lblNombre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    lblNombre.Text = "nombre";
                    lbliddepartamento.Text = "marca";
                    label1.Text = "color";
                    label2.Text = "talla";
                    label3.Text = "precio";
                    label4.Text = "iddepartamento niño niña";
                    label5.Text = "estatus";

                    txtDato1.Text = dato1;
                    txtDato2.Text = dato2;
                    txtDato3.Text = dato3;
                    txtDato4.Text = dato4;
                    txtDato5.Text = dato5;
                    txtDato6.Text = dato6;
                    txtDato7.Text = dato7;
                    txtDato1.Focus();
                    break;
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count == 0)
            {
                MessageBox.Show("SELECCIONA UNA TABLA");
                return;
            }

            DialogResult result = MessageBox.Show("¿SEGURO QUE QUIERE ELIMINAR EL REGISTRO?", "ELIMINAR", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {        
            btnmodi.Visible = false;
            btnInsertarRegistro.Visible = false;
            button1.Visible = false;
            btnInsertarRegistro.Visible = false;
            btnmodi.Visible = false;
            button2.Visible = false;
            cbbuscar.Visible = false;
            OcultarDatos.Ocultartextbox(this);
            int num = 0;
            string id = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[num].Value.ToString();
            string nombre = dataGridView1.Columns[0].HeaderText.ToString();

            string consulta = "DELETE FROM " + cbTablas.Text + " WHERE " + nombre + "=" + id;
            Datos.EjecutarConsulta(consulta, nombre, id, cbTablas);
            }
            else if (result == DialogResult.No)
            {
                return;
            }
            actualizar();
        }

        private void btnmodi_Click(object sender, EventArgs e)
        {
            DateTime fechanacimiento = dateTimePicker1.Value;
            string nacimiento = fechanacimiento.ToString("yyyy-MM-dd");

            DateTime fechainicio = dateTimePicker2.Value;
            string inicio = fechainicio.ToString("yyyy-MM-dd");

            DateTime fechafin = dateTimePicker3.Value;
            string fin = fechafin.ToString("yyyy-MM-dd");

            string c = dataGridView1.Columns.Count.ToString();

   
            string  id = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            string nombre = dataGridView1.Columns[0].HeaderText.ToString();

            OcultarDatos.estatus(this);
            switch (cbTablas.Text)
            {
                case "AccesorioHombre":
                    consulta = "UPDATE AccesorioHombre SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE AccesorioHombre SET iddepartamentohombre='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE AccesorioHombre SET estatus=" + txtDato3.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;

                case "AccesoriosMujer":
                    consulta = "UPDATE AccesoriosMujer SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE AccesoriosMujer SET iddepartamentomujer='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE AccesoriosMujer SET estatus=" + txtDato3.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;

                case "AccesoriosNiñoNiña":
                    consulta = "UPDATE AccesoriosNiñoNiña SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE AccesoriosNiñoNiña SET iddepartamentoniñoiña='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE AccesoriosNiñoNiña SET estatus=" + txtDato3.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;

                case "BlusasplayeraniñoRopaniño":
                    consulta = "UPDATE BlusasplayeraniñoRopaniño SET idblusas='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE BlusasplayeraniñoRopaniño SET idropa='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "BlusasPlayeras":
                    consulta = "UPDATE BlusasPlayeras SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE BlusasPlayeras SET marca='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE BlusasPlayeras SET color='" + txtDato3.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE BlusasPlayeras SET talla='" + txtDato4.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE BlusasPlayeras SET precio='" + decimal.Parse(txtDato5.Text) + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE BlusasPlayeras SET estatus=" + txtDato6.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "Blusasplayerasniñoniña":
                    consulta = "UPDATE Blusasplayerasniñoniña SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Blusasplayerasniñoniña SET marca='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Blusasplayerasniñoniña SET color='" + txtDato3.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Blusasplayerasniñoniña SET talla='" + txtDato4.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Blusasplayerasniñoniña SET precio='" + decimal.Parse(txtDato5.Text) + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Blusasplayerasniñoniña SET estatus=" + txtDato6.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "BlusasPlayerasRopa":
                    consulta = "UPDATE BlusasPlayerasRopa SET idblusasplayeras='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE BlusasPlayerasRopa SET idropa='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "Bolsas":
                    consulta = "UPDATE Bolsas SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Bolsas SET marca='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Bolsas SET color='" + txtDato3.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Bolsas SET talla='" + txtDato4.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Bolsas SET precio='" + decimal.Parse(txtDato5.Text) + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Bolsas SET iddepartamentomujer='" + int.Parse(txtDato6.Text) + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Bolsas SET estatus=" + txtDato7.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "Cajas":
                    consulta = "UPDATE Cajas SET numero='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Cajas SET estatus='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "CajasCajeros":
                    consulta = "UPDATE CajasCajeros SET idcajas='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE CajasCajeros SET idcajeros='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "Cajero":
                    consulta = "UPDATE Cajero SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Cajero SET apellidoPaterno='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Cajero SET apellidoMaterno='" + txtDato3.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Cajero SET estatus=" + txtDato4.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "Cliente":
                    consulta = "UPDATE Cliente SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Cliente SET apellidoPaterno='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Cliente SET apellidoMaterno='" + txtDato3.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Cliente SET telefono='" + txtDato4.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Cliente SET estatus=" + txtDato4.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "ClienteSeguros":
                    consulta = "UPDATE ClienteSeguros SET idcliente='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE ClienteSeguros SET idseguro='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "ClienteTienda":
                    consulta = "UPDATE ClienteTienda SET idcliente='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE ClienteTienda SET idtienda='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "Conductor":
                    consulta = "UPDATE Conductor SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Conductor SET genero='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Conductor SET codigopostal='" + txtDato3.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Conductor SET fechaNacimiento='" + nacimiento + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Conductor SET estatus=" + txtDato5.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "Credito":
                    consulta = "UPDATE Credito SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Credito SET apellidoPaterno='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Credito SET apellidoMaterno='" + txtDato3.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Credito SET fechaNacimiento='" + nacimiento + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Credito SET numeroTarjeta='" + txtDato5.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Credito SET meses='" + txtDato6.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Credito SET fechaInicio='" + inicio + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Credito SET fechaFinal='" + fin + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Credito SET monto='" + txtDato9.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Credito SET factura='" + txtDato10.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Credito SET idformaspago='" + txtDato11.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Credito SET estatus=" + txtDato12.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "Debito":
                    consulta = "UPDATE Debito SET monto='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Debito SET numeroTarjeta='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Debito SET fechaPago='" + nacimiento + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Debito SET factura='" + txtDato3.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Debito SET idformaspago='" + txtDato5.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Debito SET estatus=" + txtDato6.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "Departamento":
                    consulta = "UPDATE Departamento SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Departamento SET piso='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Departamento SET estatus=" + txtDato3.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "DepartamentoHombre":
                    consulta = "UPDATE DepartamentoHombre SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE DepartamentoHombre SET iddepartamentogeneral='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE DepartamentoHombre SET estatus=" + txtDato3.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    MessageBox.Show("SE REGISTRO CORRECTAMENTE, FAVOR DE ACTUALIZAR PARA VER LOS CAMBIOS");
                    break;
                case "DepartamentoMujer":
                    consulta = "UPDATE DepartamentoMujer SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE DepartamentoMujer SET iddepartamentogeneral='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE DepartamentoMujer SET estatus=" + txtDato3.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "DepartamentoNiñoNiña":
                    consulta = "UPDATE DepartamentoNiñoNiña SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE DepartamentoNiñoNiña SET iddepartamentogeneral='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE DepartamentoNiñoNiña SET estatus=" + txtDato3.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "DeportivoNiñoNiña":
                    consulta = "UPDATE DeportivoNiñoNiña SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE DeportivoNiñoNiña SET marca='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE DeportivoNiñoNiña SET color='" + txtDato3.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE DeportivoNiñoNiña SET talla='" + txtDato4.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE DeportivoNiñoNiña SET precio='" + decimal.Parse(txtDato5.Text) + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE DeportivoNiñoNiña SET estatus=" + txtDato6.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "DeportivoNiñoRopaNiño":
                    consulta = "UPDATE DeportivoNiñoRopaNiño SET iddeportivo='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE DeportivoNiñoRopaNiño SET idropa='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "Efectivo":
                    consulta = "UPDATE Efectivo SET monto='" + decimal.Parse(txtDato1.Text) + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Efectivo SET cambio='" + decimal.Parse(txtDato2.Text) + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Efectivo SET color='" + txtDato3.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Efectivo SET fechaPago='" + nacimiento + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Efectivo SET factura='" + txtDato5.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Efectivo SET idformaspago='" + txtDato6.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Efectivo SET estatus=" + txtDato7.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "Empleados":
                    consulta = "UPDATE Empleados SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Empleados SET apellidoPaterno='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Empleados SET apellidoMaterno='" + txtDato3.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Empleados SET direccion='" + txtDato4.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Empleados SET telefono='" + txtDato5.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Empleados SET estatus=" + txtDato6.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "EmpleadosTienda":
                    consulta = "UPDATE EmpleadosTienda SET idtienda='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE EmpleadosTienda SET idempleado='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "Escolares":
                    consulta = "UPDATE Escolares SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE EscolarT idmochilas='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "FormasPago":
                    consulta = "UPDATE FormasPago SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE FormasPago SET estatus=" + txtDato2.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "FormaspagoVenta":
                    consulta = "UPDATE FormaspagoVenta SET idformaspago='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE FormaspagoVenta SET idventa='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "Gerente":
                    consulta = "UPDATE Gerente SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Gerente SET apellidoPaterno='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Gerente SET apellidoMaterno='" + txtDato3.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Gerente SET direccion='" + txtDato4.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Gerente SET telefono='" + txtDato5.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Gerente SET estatus=" + txtDato6.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "GerenteTienda":
                    consulta = "UPDATE GerenteTienda SET idtienda='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE GerenteTienda SET idgerente='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "JoyeriaHombre":
                    consulta = "UPDATE JoyeriaHombre SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE JoyeriaHombre SET marca='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE JoyeriaHombre SET color='" + txtDato3.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE JoyeriaHombre SET talla='" + txtDato4.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE JoyeriaHombre SET precio='" + decimal.Parse(txtDato5.Text) + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE JoyeriaHombre SET estatus=" + txtDato6.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "JoyeriahombreAccesoriohombre":
                    consulta = "UPDATE JoyeriahombreAccesoriohombre SET idjoyeria='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE JoyeriahombreAccesoriohombre SET idaccesorio='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "JoyeriaMujer":
                    consulta = "UPDATE JoyeriaMujer SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE JoyeriaMujer SET marca='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE JoyeriaMujer SET color='" + txtDato3.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE JoyeriaMujer SET talla='" + txtDato4.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE JoyeriaMujer SET precio='" + decimal.Parse(txtDato5.Text) + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE JoyeriaMujer SET estatus=" + txtDato6.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "JoyeriamujerAccesoriomujer":
                    consulta = "UPDATE JoyeriamujerAccesoriomujer SET idjoyeria='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE JoyeriamujerAccesoriomujer SET idaccesorio='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "JoyerianiñoAccesorioniño":
                    consulta = "UPDATE JoyeriamujerAccesoriomujer SET idjoyeria='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE JoyeriamujerAccesoriomujer SET idaccesorio='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "JoyeriaNiñoNiña":
                    consulta = "UPDATE JoyeriaNiñoNiña SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE JoyeriaNiñoNiña SET marca='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE JoyeriaNiñoNiña SET color='" + txtDato3.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE JoyeriaNiñoNiña SET talla='" + txtDato4.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE JoyeriaNiñoNiña SET precio='" + decimal.Parse(txtDato5.Text) + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE JoyeriaNiñoNiña SET estatus=" + txtDato6.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "Juguetes":
                    consulta = "UPDATE Juguetes SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Juguetes SET marca='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Juguetes SET color='" + txtDato3.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Juguetes SET precio='" + decimal.Parse(txtDato4.Text) + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Juguetes SET edadRecomendada='" + txtDato5.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Juguetes SET iddepartamentoNiñoNiña='" + txtDato6.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Juguetes SET estatus=" + txtDato7.Text + " where " + nombre + "=" + id;
                    break;
                case "LentesHombre":
                    consulta = "UPDATE LentesHombre SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE LentesHombre SET marca='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE LentesHombre SET color='" + txtDato3.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE LentesHombre SET talla='" + txtDato4.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE LentesHombre SET precio='" + decimal.Parse(txtDato5.Text) + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE LentesHombre SET estatus=" + txtDato6.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "LenteshombreAccesoriohombre":
                    consulta = "UPDATE LenteshombreAccesoriohombre SET idlentes='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE LenteshombreAccesoriohombre SET idaccesorio='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "LentesMujer":
                    consulta = "UPDATE LentesMujer SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE LentesMujer SET marca='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE LentesMujer SET color='" + txtDato3.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE LentesMujer SET talla='" + txtDato4.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE LentesMujer SET precio='" + decimal.Parse(txtDato5.Text) + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE LentesMujer SET estatus=" + txtDato6.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "LentesmujerAccesorioMujer":
                    consulta = "UPDATE LentesmujerAccesorioMujer SET idlentes='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE LentesmujerAccesorioMujer SET idaccesorio='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "LentesniñoAccesorioniño":
                    consulta = "UPDATE LentesniñoAccesorioniño SET idlentes='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE LentesniñoAccesorioniño SET idaccesorio='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "LentesNiñoNiña":
                    consulta = "UPDATE LentesNiñoNiña SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE LentesNiñoNiña SET marca='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE LentesLentesNiñoNiñaMujer SET color='" + txtDato3.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE LentesNiñoNiña SET talla='" + txtDato4.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE LentesNiñoNiña SET precio='" + decimal.Parse(txtDato5.Text) + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE LentesNiñoNiña SET estatus=" + txtDato6.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "Mochilas":
                    consulta = "UPDATE Mochilas SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Mochilas SET marca='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Mochilas SET color='" + txtDato3.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Mochilas SET talla='" + txtDato4.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Mochilas SET precio='" + decimal.Parse(txtDato5.Text) + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Mochilas SET estatus=" + txtDato6.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "Pantalones_ShortsMujer":
                    consulta = "UPDATE Pantalones_ShortsMujer SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Pantalones_ShortsMujer SET marca='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Pantalones_ShortsMujer SET color='" + txtDato3.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Pantalones_ShortsMujer SET talla='" + txtDato4.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Pantalones_ShortsMujer SET precio='" + decimal.Parse(txtDato5.Text) + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Pantalones_ShortsMujer SET estatus=" + txtDato6.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "PantalonesHombre":
                    consulta = "UPDATE PantalonesHombre SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE PantalonesHombre SET marca='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE PantalonesHombre SET color='" + txtDato3.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE PantalonesHombre SET talla='" + txtDato4.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE PantalonesHombre SET precio='" + decimal.Parse(txtDato5.Text) + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE PantalonesHombre SET estatus=" + txtDato6.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "PantalonesmujerRopa":
                    consulta = "UPDATE PantalonesmujerRopa SET idpantalon='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE PantalonesmujerRopa SET idropa='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "Pantalonesniñoniña":
                    consulta = "UPDATE Pantalonesniñoniña SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Pantalonesniñoniña SET marca='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Pantalonesniñoniña SET color='" + txtDato3.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Pantalonesniñoniña SET talla='" + txtDato4.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Pantalonesniñoniña SET precio='" + decimal.Parse(txtDato5.Text) + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Pantalonesniñoniña SET estatus=" + txtDato6.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "PantalonesniñoRopaniño":
                    consulta = "UPDATE PantalonesniñoRopaniño SET idpantalones='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE PantalonesniñoRopaniño SET idropa='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "PantalonesRopahombre":
                    consulta = "UPDATE PantalonesRopahombre SET idpantalones='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE PantalonesRopahombre SET idropa='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "PlayerascamisaRopahombre":
                    consulta = "UPDATE PlayerascamisaRopahombre SET idplayeras='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE PlayerascamisaRopahombre SET idropa='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "PlayerasCamisas":
                    consulta = "UPDATE PlayerasCamisas SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE PlayerasCamisas SET marca='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE PlayerasCamisas SET color='" + txtDato3.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE PlayerasCamisas SET talla='" + txtDato4.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE PlayerasCamisas SET precio='" + decimal.Parse(txtDato5.Text) + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE PlayerasCamisas SET estatus=" + txtDato6.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "RelojHombre":
                    consulta = "UPDATE RelojHombre SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE RelojHombre SET marca='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE RelojHombre SET color='" + txtDato3.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE RelojHombre SET talla='" + txtDato4.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE RelojHombre SET precio='" + decimal.Parse(txtDato5.Text) + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE RelojHombre SET estatus=" + txtDato6.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "RelojhombreAccesoriohombre":
                    consulta = "UPDATE RelojhombreAccesoriohombre SET idreloj='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE RelojhombreAccesoriohombre SET idaccesorio='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "RelojMujer":
                    consulta = "UPDATE RelojMujer SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE RelojMujer SET marca='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE RelojMujer SET color='" + txtDato3.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE RelojMujer SET talla='" + txtDato4.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE RelojMujer SET precio='" + decimal.Parse(txtDato5.Text) + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE RelojMujer SET estatus=" + txtDato6.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "RelojmujerAccesorioMujer":
                    consulta = "UPDATE RelojmujerAccesorioMujer SET idreloj='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE RelojmujerAccesorioMujer SET idaccesorio='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "RelojniñoAccesorioniño":
                    consulta = "UPDATE RelojniñoAccesorioniño SET idreloj='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE RelojniñoAccesorioniño SET idaccesorio='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "RelojNiñoNiña":
                    consulta = "UPDATE RelojNiñoNiña SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE RelojNiñoNiña SET marca='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE RelojNiñoNiña SET color='" + txtDato3.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE RelojNiñoNiña SET talla='" + txtDato4.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE RelojNiñoNiña SET precio='" + decimal.Parse(txtDato5.Text) + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE RelojNiñoNiña SET estatus=" + txtDato6.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "RopaHombre":
                    consulta = "UPDATE RopaHombre SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE RopaHombre SET iddepartamentohombre='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE RopaHombre SET estatus=" + txtDato3.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "RopaInterior":
                    consulta = "UPDATE RopaInterior SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE RopaInterior SET marca='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE RopaInterior SET color='" + txtDato3.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE RopaInterior SET talla='" + txtDato4.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE RopaInterior SET precio='" + decimal.Parse(txtDato5.Text) + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE RopaInterior SET estatus=" + txtDato6.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "RopainteriorRopahombre":
                    consulta = "UPDATE RopainteriorRopahombre SET idropainterior='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE RopainteriorRopahombre SET idropahombre='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "RopaMujer":
                    consulta = "UPDATE RopaMujer SET nombreDepartamento='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE RopaMujer SET iddepartamentomujer='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE RopaMujer SET estatus=" + txtDato3.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "RopaNiñoNiña":
                    consulta = "UPDATE RopaNiñoNiña SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE RopaNiñoNiña SET iddepartamentoniñoniña='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE RopaNiñoNiña SET estatus=" + txtDato3.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "SeguroFamiliar":
                    consulta = "UPDATE SeguroFamiliar SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE SeguroFamiliar SET apellidoPaterno='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE SeguroFamiliar SET apellidoMaterno='" + txtDato3.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE SeguroFamiliar SET fechaNacimiento='" + nacimiento + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE SeguroFamiliar SET idseguros='" + txtDato5.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE SeguroFamiliar SET estatus=" + txtDato6.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "Seguros":
                    consulta = "UPDATE Seguros SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Seguros SET estatus=" + txtDato2.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "SeguroVehiculo":
                    consulta = "UPDATE SeguroVehiculo SET marca='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE SeguroVehiculo SET modelo='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE SeguroVehiculo SET año='" + nacimiento + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE SeguroVehiculo SET idconductor='" + txtDato3.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE SeguroVehiculo SET idseguros='" + txtDato5.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE SeguroVehiculo SET estatus=" + txtDato6.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "Tienda":
                    consulta = "UPDATE Tienda SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Tienda SET ubicacion='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Tienda SET telefono='" + txtDato3.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Tienda SET estatus=" + txtDato4.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "TiendaDepartamento":
                    consulta = "UPDATE TiendaDepartamento SET idtienda='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE TiendaDepartamento SET iddepartamento='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "UtilesEscolares":
                    consulta = "UPDATE UtilesEscolares SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE UtilesEscolares SET marca='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE UtilesEscolares SET color='" + txtDato3.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE UtilesEscolares SET talla='" + txtDato4.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE UtilesEscolares SET precio='" + decimal.Parse(txtDato5.Text) + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE UtilesEscolares SET estatus=" + txtDato6.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "UtilesescolaresEscolares":
                    consulta = "UPDATE UtilesescolaresEscolares SET idescolares='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE UtilesescolaresEscolares SET idutiles='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "Venta":
                    consulta = "UPDATE Venta SET monto='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Venta SET factura='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Venta SET fechaVenta='" + nacimiento + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE Venta SET estatus=" + txtDato3.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "VentaCajas":
                    consulta = "UPDATE VentaCajas SET idventa='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE VentaCajas SET idcaja='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "VentaCliente":
                    consulta = "UPDATE VentaCliente SET idventa='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE VentaCliente SET idcliente='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "ZapatosHombre":
                    consulta = "UPDATE ZapatosHombre SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE ZapatosHombre SET marca='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE ZapatosHombre SET color='" + txtDato3.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE ZapatosHombre SET talla='" + txtDato4.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE ZapatosHombre SET precio='" + decimal.Parse(txtDato5.Text) + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE ZapatosHombre SET iddepartamentohombre='" + int.Parse(txtDato6.Text) + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE ZapatosHombre SET estatus=" + txtDato7.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "ZapatosMujer":
                    consulta = "UPDATE ZapatosMujer SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE ZapatosMujer SET marca='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE ZapatosMujer SET color='" + txtDato3.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE ZapatosMujer SET talla='" + txtDato4.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE ZapatosMujer SET precio='" + decimal.Parse(txtDato5.Text) + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE ZapatosMujer SET iddepartamentomujer='" + int.Parse(txtDato6.Text) + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE ZapatosMujer SET estatus=" + txtDato7.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
                case "ZapatosNiñoniña":
                    consulta = "UPDATE ZapatosNiñoniña SET nombre='" + txtDato1.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE ZapatosNiñoniña SET marca='" + txtDato2.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE ZapatosNiñoniña SET color='" + txtDato3.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE ZapatosNiñoniña SET talla='" + txtDato4.Text + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE ZapatosNiñoniña SET precio='" + decimal.Parse(txtDato5.Text) + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE ZapatosNiñoniña SET iddepartamentoniñoniña='" + int.Parse(txtDato6.Text) + "' where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    consulta = "UPDATE ZapatosNiñoniña SET estatus=" + txtDato7.Text + " where " + nombre + "=" + id;
                    Datos.modificar(consulta);
                    break;
            }
            MessageBox.Show("SE MODIFICO CORRECTAMENTE");
            actualizar();
        }

        private void cbconenctar_SelectedIndexChanged(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿SEGURO QUE DESEA CAMBIAR DE MANEJADOR?", "MANEJADORES", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                btnmodi.Visible = false;
                btnInsertarRegistro.Visible = false;
                cbbuscar.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                OcultarDatos.Ocultartextbox(this);
                Datos.Manejadores(cbconenctar, cbTablas, dataGridView1);
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OcultarDatos.Ocultartextbox(this);
            button1.Visible = false;
            btnInsertarRegistro.Visible = false;
            btnmodi.Visible = false;
            button2.Visible = false;
        }

        private void actualizar()
        {
            if (dataGridView1.Columns.Count == 0)
            {
                MessageBox.Show("SELECCIONA UNA TABLA");
                return;
            }
            button1.Visible = false;
            btnmodi.Visible = false;
            btnInsertarRegistro.Visible = false;
            OcultarDatos.Ocultartextbox(this);
            if (cbconenctar.Text == "ORACLE")
            {
                consulta = "SELECT * FROM " + cbTablas.Text + " ORDER BY " + 1;
            }
            else
            {
                consulta = "SELECT * FROM " + cbTablas.Text;
            }
            Datos.MostrarTabla(ds, cbTablas, consulta, "Tienda", dataGridView1);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (cbTablas.Text=="TABLAS")
            {
                MessageBox.Show("SELECCIONA UNA TABLA");
                return;
            }
            OcultarDatos.Ocultartextbox(this);
            cbbuscar.Items.Clear();
            cbbuscar.Text = "";
            cbbuscar.Visible = true;
            btnmodi.Visible = false;
            btnInsertarRegistro.Visible = false;
            button1.Visible = false;
            button2.Visible = true;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                string nombre = dataGridView1.Columns[i].HeaderText.ToString();
                cbbuscar.Items.Add(nombre);
            }
        }

        private void txtbuscar_KeyUp(object sender, KeyEventArgs e)
        {
            string consulta = "SELECT * FROM " + cbTablas.Text + " WHERE " + cbbuscar.Text + " like('" + txtbuscar.Text + "%')";
            Datos.MostrarTabla(ds, cbTablas, consulta, "Tienda", dataGridView1);
        }

        private void cbbuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbuscar.Visible = true;
            lblbuscar.Visible = true;
            button2.Visible=true;
            lblbuscar.Text = cbbuscar.Text+":";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OcultarDatos.Ocultartextbox(this);
            button1.Visible = false;
            btnInsertarRegistro.Visible = false;
            btnmodi.Visible = false;
            button2.Visible = false;
            cbbuscar.Visible = false;
        }
    }
}