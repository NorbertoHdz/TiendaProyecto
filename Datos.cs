using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.OracleClient;

namespace TiendaProyecto
{
    public class Datos
    {
        private static string servidor;
        private static string cadenaConexion;
        private static SqlConnection sqlconexion;
        private static MySqlConnection mysqlconexion;
        private static OracleConnection oracleconexion;

        public static void Manejadores(ComboBox cbconectores, ComboBox cbtablas, DataGridView dataGridView)
        {
            switch (cbconectores.Text)
            {
                case "SQL":
                    cadenaConexion = "Server = localhost\\SQLEXPRESS;Database = TiendaProyecto; Trusted_Connection = True;";
                    sqlconexion = new SqlConnection(cadenaConexion);
                    MessageBox.Show("SE HA CONECTADO CORRECTAMENTE CON SQL");
                    cbtablas.Text = "TABLAS";
                    dataGridView.Columns.Clear();
                    servidor = "SQL";
                    break;
                case "MYSQL":
                    cadenaConexion = "Server=localhost;Database=TiendaProyecto; Uid=root;pwd=A081218n;";
                    mysqlconexion = new MySqlConnection(cadenaConexion);
                    MessageBox.Show("SE HA CONECTADO CORRECTAMENTE CON MYSQL");
                    servidor = "MYSQL";
                    cbtablas.Text = "TABLAS";
                    dataGridView.Columns.Clear();
                    break;
                case "MARIADB":
                    cadenaConexion = "datasource=127.0.0.1;port=1234;username=root;password=A081218n.;database=TiendaProyecto;";
                    mysqlconexion = new MySqlConnection(cadenaConexion);
                    MessageBox.Show("SE HA CONECTADO CORRECTAMENTE CON MARIADB");
                    servidor = "MYSQL";
                    cbtablas.Text = "TABLAS";
                    dataGridView.Columns.Clear();
                    break;
                case "ORACLE":
                    cadenaConexion = "data source = orcl; password=A081218n.;user id= system; ";
                    oracleconexion = new OracleConnection(cadenaConexion);
                    MessageBox.Show("SE HA CONECTADO CORRECTAMENTE CON ORACLE");
                    servidor = "ORACLE";
                    cbtablas.Text = "TABLAS";
                    dataGridView.Columns.Clear();
                    break;
            }
        }

        public static int EjecutarConsulta(string consulta, string nombre, string id, ComboBox cbTablas)
        {
            int registrosAfectados = 0;
            if (servidor == "SQL")
            {
                try
                {
                    SqlCommand comando = new SqlCommand(consulta, sqlconexion);
                    sqlconexion.Open();
                    if (comando.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("SE ELIMINO CORRECTAMENTE");
                        registrosAfectados = comando.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("HUBO UN ERROR, FAVOR DE CHECAR BIEN LOS DATOS/n" + ex.Message);
                }
                sqlconexion.Close();
            }
            else if (servidor == "MYSQL")
            {
                try
                {
                    MySqlCommand comando = new MySqlCommand(consulta, mysqlconexion);
                    mysqlconexion.Open();
                    if (comando.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("SE ELIMINO CORRECTAMENTE");
                        registrosAfectados = comando.ExecuteNonQuery();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("HUBO UN ERROR, FAVOR DE CHECAR BIEN LOS DATOS/n" + ex.Message);
                }
                mysqlconexion.Close();
            }
            else if (servidor == "MARIADB")
            {
                try
                {
                    MySqlCommand comando = new MySqlCommand(consulta, mysqlconexion);
                    mysqlconexion.Open();
                    if (comando.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("SE ELIMINO CORRECTAMENTE");
                        registrosAfectados = comando.ExecuteNonQuery();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("HUBO UN ERROR, FAVOR DE CHECAR BIEN LOS DATOS/n" + ex.Message);
                }
                mysqlconexion.Close();
            }
            else if (servidor == "ORACLE")
            {
                try
                {
                    oracleconexion.Open();
                    string borrar = "DELETE FROM " + cbTablas.Text + " WHERE UPPER(" + nombre + ")=UPPER(" + id + ")";
                    OracleCommand comando = new OracleCommand(borrar, oracleconexion);
                    OracleDataAdapter dta = new OracleDataAdapter();
                    dta.DeleteCommand = comando;

                    if (dta.DeleteCommand.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("SE ELIMINO CORRECTAMENTE");
                        registrosAfectados = dta.DeleteCommand.ExecuteNonQuery();
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("HUBO UN ERROR, FAVOR DE CHECAR BIEN LOS DATOS/n" + ex.Message);
                }
                oracleconexion.Close();
            }
            return registrosAfectados;
        }

        public static void MostrarTabla(DataSet ds, ComboBox comboBox1, string consulta, string nombreTabla, DataGridView dataGridView1)
        {
            if (servidor == "SQL")
            {
                SqlDataAdapter da = new SqlDataAdapter(consulta, sqlconexion);
                ds = new DataSet();
                da.Fill(ds, nombreTabla);
                dataGridView1.DataSource = ds.Tables["Tienda"];
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if (servidor == "MYSQL")
            {
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, mysqlconexion);
                ds = new DataSet();
                da.Fill(ds, nombreTabla);
                dataGridView1.DataSource = ds.Tables["Tienda"];
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if (servidor == "MARIADB")
            {
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, mysqlconexion);
                ds = new DataSet();
                da.Fill(ds, nombreTabla);
                dataGridView1.DataSource = ds.Tables["Tienda"];
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if (servidor == "ORACLE")
            {
                oracleconexion.Open();
                OracleDataAdapter da = new OracleDataAdapter(consulta, oracleconexion);
                ds = new DataSet();
                da.Fill(ds, nombreTabla);
                dataGridView1.DataSource = ds.Tables["Tienda"];
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                foreach (DataGridViewColumn columna in dataGridView1.Columns)
                {
                    columna.HeaderText = columna.HeaderText.ToLower();
                }

                oracleconexion.Close();
            }
        }

        public static void InsertarRegistro(string consulta)
        {
            if (servidor == "SQL")
            {
                try
                {
                    SqlCommand comando = new SqlCommand(consulta, sqlconexion);
                    sqlconexion.Open();
                    if (comando.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("SE REGISTRO CORRECTAMENTE");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("HUBO UN ERROR, FAVOR DE CHECAR BIEN LOS DATOS/n" + ex.Message);
                }
                sqlconexion.Close();
            }
            else if (servidor == "MARIADB")
            {
                try
                {
                    MySqlCommand comando = new MySqlCommand(consulta, mysqlconexion);
                    mysqlconexion.Open();
                    if (comando.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("SE REGISTRO CORRECTAMENTE");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("HUBO UN ERROR, FAVOR DE CHECAR BIEN LOS DATOS/n" + ex.Message);
                }
                mysqlconexion.Close();
            }
            else if (servidor == "MYSQL")
            {
                try
                {
                    MySqlCommand comando = new MySqlCommand(consulta, mysqlconexion);
                    mysqlconexion.Open();
                    if (comando.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("SE REGISTRO CORRECTAMENTE");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("HUBO UN ERROR, FAVOR DE CHECAR BIEN LOS DATOS/n" + ex.Message);
                }
                mysqlconexion.Close();
            }
            else if (servidor == "ORACLE")
            {
                try
                {
                    oracleconexion.Open();
                    OracleCommand comando = new OracleCommand(consulta.Replace(";", ""), oracleconexion);
                    OracleDataAdapter dta = new OracleDataAdapter();
                    dta.InsertCommand = comando;

                    if (dta.InsertCommand.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("SE REGISTRO CORRECTAMENTE");
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("HUBO UN ERROR, FAVOR DE CHECAR BIEN LOS DATOS " + ex.Message);
                }
                oracleconexion.Close();
            }
        }

        public static void modificar(string consulta)
        {
            if (servidor == "SQL")
            {
                try
                {
                    SqlCommand comando = new SqlCommand(consulta, sqlconexion);
                    sqlconexion.Open();
                    if (comando.ExecuteNonQuery() != 0)
                    {

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("HUBO UN ERROR, FAVOR DE CHECAR BIEN LOS DATOS/n" + ex.Message);
                }
                sqlconexion.Close();
            }

            else if (servidor == "MYSQL")
            {
                try
                {
                    MySqlCommand comando = new MySqlCommand(consulta, mysqlconexion);
                    mysqlconexion.Open();
                    if (comando.ExecuteNonQuery() != 0)
                    {

                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("HUBO UN ERROR, FAVOR DE CHECAR BIEN LOS DATOS/n" + ex.Message);
                }
                mysqlconexion.Close();
            }

            else if (servidor == "MARIADB")
            {
                try
                {
                    MySqlCommand comando = new MySqlCommand(consulta, mysqlconexion);
                    mysqlconexion.Open();
                    if (comando.ExecuteNonQuery() != 0)
                    {

                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("HUBO UN ERROR, FAVOR DE CHECAR BIEN LOS DATOS/n" + ex.Message);
                }
                mysqlconexion.Close();
            }

            else if (servidor == "ORACLE")
            {
                try
                {
                    oracleconexion.Open();
                    OracleCommand comando = new OracleCommand(consulta.Replace(";", ""), oracleconexion);
                    OracleDataAdapter dta = new OracleDataAdapter();
                    dta.InsertCommand = comando;
                    if (comando.ExecuteNonQuery() != 0)
                    {

                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("HUBO UN ERROR, FAVOR DE CHECAR BIEN LOS DATOS/n" + ex.Message);
                }
                oracleconexion.Close();
            }
        }
    }
}