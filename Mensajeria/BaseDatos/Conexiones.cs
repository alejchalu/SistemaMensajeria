using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections;

namespace BaseDatos
{
    public class Conexiones
    {
        //Conección a base de datos
        SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_Mensajeria"].ConnectionString);

        #region Metodos Clientes
        public DataTable ListarClientes()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Cli_P_ListarClientes", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

                Conexion.Close();
                return table;
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }
        public void InsertarClientes(string Identificacion, string Nombre, string Telefono,
              string Direccion, string Email, string Comentarios, DateTime Fecha_Registro, string Usuario_Registro, bool Activo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Cli_P_InsertarClientes", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                cmd.Parameters.AddWithValue("@Identificacion", Identificacion);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Telefono", Telefono);
                cmd.Parameters.AddWithValue("@Direccion", Direccion);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Comentarios", Comentarios);
                cmd.Parameters.AddWithValue("@Fecha_Registro", Fecha_Registro);
                cmd.Parameters.AddWithValue("@Usuario_Registro", Usuario_Registro);
                cmd.Parameters.AddWithValue("@Activo", Activo);

                cmd.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }

        public void ActualizarClientes(int ID, string Identificacion, string Nombre, string Telefono,
            string Direccion, string Email, string Comentarios, bool Activo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Cli_P_ActualizarClientes", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@Identificacion", Identificacion);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Telefono", Telefono);
                cmd.Parameters.AddWithValue("@Direccion", Direccion);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Comentarios", Comentarios);
                cmd.Parameters.AddWithValue("@Activo", Activo);

                cmd.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }

        public void EliminarClientes(int ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Cli_P_EliminarClientes", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                cmd.Parameters.AddWithValue("@ID", ID);

                cmd.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }
        #endregion

        #region Metodos Mensajeros
        public DataTable ListarMensajeros()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Men_P_ListarMensajeros", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

                Conexion.Close();
                return table;
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }
        public DataTable ListarMensajerosCombo()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Men_P_ListarMensajerosCombo", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

                Conexion.Close();
                return table;
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }
        public void InsertarMensajeros(string Identificacion, string Nombre, string Telefono,
            string Email, DateTime Fecha_Ingreso, DateTime Fecha_Registro, string Usuario_Registro, bool Activo)

        {
            try
            {
                SqlCommand cmd = new SqlCommand("Men_P_InsertarMensajeros", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                cmd.Parameters.AddWithValue("@Identificacion", Identificacion);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Telefono", Telefono);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Fecha_Ingreso", Fecha_Ingreso);
                cmd.Parameters.AddWithValue("@Fecha_Registro", Fecha_Registro);
                cmd.Parameters.AddWithValue("@Usuario_Registro", Usuario_Registro);
                cmd.Parameters.AddWithValue("@Activo", Activo);

                cmd.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }

        public void ActualizarMensajeros(int ID, string Identificacion, string Nombre, string Telefono,
            string Email, DateTime Fecha_Ingreso, bool Activo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Men_P_ActualizarMensajeros", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@Identificacion", Identificacion);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Telefono", Telefono);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Fecha_Ingreso", Fecha_Ingreso);
                cmd.Parameters.AddWithValue("@Activo", Activo);

                cmd.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }

        public void EliminarMensajeros(int ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Men_P_EliminarMensajeros", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                cmd.Parameters.AddWithValue("@ID", ID);

                cmd.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }
        #endregion

        #region Metodos Usuarios
        public DataTable ListarUsuarios()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Usu_P_ListarUsuarios", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

                Conexion.Close();
                return table;
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }
        public void InsertarUsuarios(string Usuario, string Contraseña, string Nombre,
            int ID_Perfil, DateTime Fecha_Registro, string Usuario_Registro, bool Activo)

        {
            try
            {
                SqlCommand cmd = new SqlCommand("Usu_P_InsertarUsuarios", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                cmd.Parameters.AddWithValue("@Usuario", Usuario);
                cmd.Parameters.AddWithValue("@Contraseña", Contraseña);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@ID_Perfil", ID_Perfil);
                cmd.Parameters.AddWithValue("@Fecha_Registro", Fecha_Registro);
                cmd.Parameters.AddWithValue("@Usuario_Registro", Usuario_Registro);
                cmd.Parameters.AddWithValue("@Activo", Activo);

                cmd.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }

        public void ActualizarUsuarios(int ID, string Usuario, string Contraseña, string Nombre,
            int ID_Perfil, bool Activo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Usu_P_ActualizarUsuarios", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@Usuario", Usuario);
                cmd.Parameters.AddWithValue("@Contraseña", Contraseña);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@ID_Perfil", ID_Perfil);
                cmd.Parameters.AddWithValue("@Activo", Activo);

                cmd.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }

        public void EliminarUsuarios(int ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Usu_P_EliminarUsuarios", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                cmd.Parameters.AddWithValue("@ID", ID);

                cmd.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }

        public string ValidaUsuarios(string Usuario, string Contraseña)
        {
            try
            {
                string[] Lista = new string[2];
                SqlDataReader LeerFilas;
                SqlCommand cmd = new SqlCommand("Usu_P_ValidaUsuarios", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                cmd.Parameters.AddWithValue("@Usuario", Usuario);
                cmd.Parameters.AddWithValue("@Contraseña", Contraseña);

                LeerFilas = cmd.ExecuteReader();

                if (LeerFilas.Read())
                {
                    Lista[0] = (LeerFilas.GetString(0));
                    Lista[1] = (Convert.ToString(LeerFilas.GetInt32(1)));
                    Conexion.Close();
                    LeerFilas.Close();
                    return Lista.GetValue(0).ToString() + "," + Lista.GetValue(1).ToString();
                }
                else
                {
                    Conexion.Close();
                    LeerFilas.Close();
                    return "";
                }
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }
        #endregion

        #region Metodos Boletas
        public void InsertarBoletas(string ID_Cliente, string ID_Mensajero, string Descripcion,
            int Cantidad_Objetos, string Numero_Factura, double Costo, DateTime Fecha_Retiro, DateTime Hora_Retiro,
            DateTime Fecha_Entrega, DateTime Hora_Entrega, DateTime Fecha_Registro, string Usuario_Registro)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Bol_P_InsertarBoletas", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                cmd.Parameters.AddWithValue("@ID_Cliente", ID_Cliente);
                cmd.Parameters.AddWithValue("@ID_Mensajero", ID_Mensajero);
                cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
                cmd.Parameters.AddWithValue("@Cantidad_Objetos", Cantidad_Objetos);
                cmd.Parameters.AddWithValue("@Numero_Factura", Numero_Factura);
                cmd.Parameters.AddWithValue("@Costo", Costo);
                cmd.Parameters.AddWithValue("@Fecha_Retiro", Fecha_Retiro);
                cmd.Parameters.AddWithValue("@Hora_Retiro", Hora_Retiro);
                cmd.Parameters.AddWithValue("@Fecha_Entrega", Fecha_Entrega);
                cmd.Parameters.AddWithValue("@Hora_Entrega", Hora_Entrega);
                cmd.Parameters.AddWithValue("@Fecha_Registro", Fecha_Registro);
                cmd.Parameters.AddWithValue("@Usuario_Registro", Usuario_Registro);

                cmd.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }

        public void ActualizarBoletas(int ID, string ID_Cliente, string ID_Mensajero, string Descripcion,
            int Cantidad_Objetos, string Numero_Factura, double Costo, DateTime Fecha_Retiro, DateTime Hora_Retiro,
            DateTime Fecha_Entrega, DateTime Hora_Entrega)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Bol_P_ActualizarBoletas", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@ID_Cliente", ID_Cliente);
                cmd.Parameters.AddWithValue("@ID_Mensajero", ID_Mensajero);
                cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
                cmd.Parameters.AddWithValue("@Cantidad_Objetos", Cantidad_Objetos);
                cmd.Parameters.AddWithValue("@Numero_Factura", Numero_Factura);
                cmd.Parameters.AddWithValue("@Costo", Costo);
                cmd.Parameters.AddWithValue("@Fecha_Retiro", Fecha_Retiro);
                cmd.Parameters.AddWithValue("@Hora_Retiro", Hora_Retiro);
                cmd.Parameters.AddWithValue("@Fecha_Entrega", Fecha_Entrega);
                cmd.Parameters.AddWithValue("@Hora_Entrega", Hora_Entrega);

                cmd.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }

        public void EliminarBoletas(int ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Bol_P_EliminarBoletas", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                cmd.Parameters.AddWithValue("@ID", ID);

                cmd.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }
        #endregion

        #region Metodos Ingresos_Gastos
        public DataTable ListarIngresosGastos()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Ing_P_ListarIngresos_Gastos", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

                Conexion.Close();
                return table;
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }
        public void InsertarIngresos_Gastos(DateTime Fecha_Transaccion, double Monto, string Descripcion,
            string Tipo, DateTime Fecha_Registro, string Usuario_Registro)

        {
            try
            {
                SqlCommand cmd = new SqlCommand("Ing_P_InsertarIngresos_Gastos", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                cmd.Parameters.AddWithValue("@Fecha_Transaccion", Fecha_Transaccion);
                cmd.Parameters.AddWithValue("@Monto", Monto);
                cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
                cmd.Parameters.AddWithValue("@Tipo", Tipo);
                cmd.Parameters.AddWithValue("@Fecha_Registro", Fecha_Registro);
                cmd.Parameters.AddWithValue("@Usuario_Registro", Usuario_Registro);

                cmd.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }

        public void ActualizarIngresos_Gastos(int ID, DateTime Fecha_Transaccion, double Monto, string Descripcion,
            string Tipo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Ing_P_ActualizarIngresos_Gastos", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@Fecha_Transaccion", Fecha_Transaccion);
                cmd.Parameters.AddWithValue("@Monto", Monto);
                cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
                cmd.Parameters.AddWithValue("@Tipo", Tipo);

                cmd.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }

        public void EliminarIngresos_Gastos(int ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Ing_P_EliminarIngresos_Gastos", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                cmd.Parameters.AddWithValue("@ID", ID);

                cmd.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }
        #endregion

        #region Metodos Perfil_Permisos
        public DataTable ListarPerfilesPermisos(int ID_Perfil)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Per_P_ListarPerfil_Permisos", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                cmd.Parameters.AddWithValue("@ID_Perfil", ID_Perfil);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

                Conexion.Close();
                return table;
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }
        public void InsertarPerfil_Permisos(int ID_Perfil,int ID,
            DateTime Fecha_Registro, string Usuario_Registro)

        {
            try
            {
                SqlCommand cmd = new SqlCommand("Per_P_InsertarPerfil_Permisos", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                cmd.Parameters.AddWithValue("@ID_Perfil", ID_Perfil);
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@Fecha_Registro", Fecha_Registro);
                cmd.Parameters.AddWithValue("@Usuario_Registro", Usuario_Registro);

                cmd.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }

        public void EliminarPerfil_Permisos(int ID_Perfil,int ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Per_P_EliminarPerfil_Permisos", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                cmd.Parameters.AddWithValue("@ID_Perfil", ID_Perfil);
                cmd.Parameters.AddWithValue("@ID", ID);

                cmd.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }
        #endregion

        #region Metodos Perfiles
        public DataTable ListarPerfilesCombo()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Per_P_ListarPerfilesCombo", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

                Conexion.Close();
                return table;
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }

        public DataTable ListarPerfiles()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Per_P_ListarPerfiles", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

                Conexion.Close();
                return table;
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }
        public void InsertarPerfiles(string Nombre,
            DateTime Fecha_Registro, string Usuario_Registro, bool Activo)

        {
            try
            {
                SqlCommand cmd = new SqlCommand("Per_P_InsertarPerfiles", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Fecha_Registro", Fecha_Registro);
                cmd.Parameters.AddWithValue("@Usuario_Registro", Usuario_Registro);
                cmd.Parameters.AddWithValue("@Activo", Activo);

                cmd.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }

        public void ActualizarPerfiles(int ID, string Nombre, bool Activo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Per_P_ActualizarPerfiles", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Activo", Activo);

                cmd.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }

        public void EliminarPerfiles(int ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Per_P_EliminarPerfiles", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                cmd.Parameters.AddWithValue("@ID", ID);

                cmd.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }
        #endregion

        #region Metodos Rutas
        public DataTable ListarRutasCombo()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Rut_P_ListarRutasCombo", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

                Conexion.Close();
                return table;
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }
        public DataTable ListarRutas()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Rut_P_ListarRutas", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

                Conexion.Close();
                return table;
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }
        public void InsertarRutas(string Nombre, int ID_Mensajero,
            DateTime Fecha_Registro, string Usuario_Registro, bool Activo)

        {
            try
            {
                SqlCommand cmd = new SqlCommand("Rut_P_InsertarRutas", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@ID_Mensajero", ID_Mensajero);
                cmd.Parameters.AddWithValue("@Fecha_Registro", Fecha_Registro);
                cmd.Parameters.AddWithValue("@Usuario_Registro", Usuario_Registro);
                cmd.Parameters.AddWithValue("@Activo", Activo);

                cmd.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }

        public void ActualizarRutas(int ID, string Nombre, int ID_Mensajero, bool Activo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Rut_P_ActualizarRutas", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@ID_Mensajero", ID_Mensajero);
                cmd.Parameters.AddWithValue("@Activo", Activo);

                cmd.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }

        public void EliminarRutas(int ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Rut_P_EliminarRutas", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                cmd.Parameters.AddWithValue("@ID", ID);

                cmd.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }
        #endregion

        #region Metodos Rutas_Clientes
        public DataTable ListarRutas_ClientesNoAsignados(string ID_Clientes)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Rut_P_ListarRutas_ClientesNoAsignados", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                cmd.Parameters.AddWithValue("@ID_Clientes", ID_Clientes);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

                Conexion.Close();
                return table;
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }
        public DataTable ListarRutas_ClientesAsignados(int ID_Rutas)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Rut_P_ListarRutas_ClientesAsignados", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                cmd.Parameters.AddWithValue("@ID_Rutas", ID_Rutas);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

                Conexion.Close();
                return table;
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }
        public void InsertarRutas_Clientes(int ID_Rutas, int ID_Cliente,
            DateTime Fecha_Registro, string Usuario_Registro)

        {
            try
            {
                SqlCommand cmd = new SqlCommand("Rut_P_InsertarRutas_Clientes", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                cmd.Parameters.AddWithValue("@ID_Rutas", ID_Rutas);
                cmd.Parameters.AddWithValue("@ID_Cliente", ID_Cliente);
                cmd.Parameters.AddWithValue("@Fecha_Registro", Fecha_Registro);
                cmd.Parameters.AddWithValue("@Usuario_Registro", Usuario_Registro);

                cmd.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }
        public void EliminarRutas_Clientes(int ID_Rutas,int ID_Cliente)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Rut_P_EliminarRutas_Clientes", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                cmd.Parameters.AddWithValue("@ID_Rutas", ID_Rutas);
                cmd.Parameters.AddWithValue("@ID_Cliente", ID_Cliente);

                cmd.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }
        #endregion

        #region Metodos Menu
        public DataTable ListarMenu()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Men_P_ListarMenu", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                Conexion.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

                Conexion.Close();
                return table;
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }
        #endregion
    }
}
