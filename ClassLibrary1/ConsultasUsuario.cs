using CapaComun;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class ConsultasUsuario : Conexion
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "exec inicioSesion @user,@pass ";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Cache.IdUser = reader.GetInt32(0);
                            Cache.LoginName = reader.GetString(1);
                            Cache.Password = reader.GetString(2);
                            Cache.Nombre = reader.GetString(3);
                            Cache.ApellidoPatern = reader.GetString(4);
                            Cache.ApellidoMatern = reader.GetString(5);
                            Cache.Position = reader.GetString(6);
                            Cache.Email = reader.GetString(7);
                            Cache.Id = reader.GetString(8);
                            Cache.tipoUs=reader.GetString(9);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        public string recoverPassword(string userRequesting)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "exec recuperarContra @mail,@user";
                    command.Parameters.AddWithValue("@user", userRequesting);
                    command.Parameters.AddWithValue("@mail", userRequesting);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        
                        string userName = reader.GetString(1);
                        string userMail = reader.GetString(7);
                        string accountPassword = reader.GetString(2);
                        var mailservice = new SystemSupportMail();
                        mailservice.sendMail(
                          subject: "La Panaderia: Recuperación de contraseña",
                          body: "Hola, " + userName +
                          "Tu contraseña actual es: " + accountPassword +
                          "\nSin embargo, le recomendamos cambiar su contraseña inmediatamente una vez haya entrado al sistema.",
                          recipientMail: new List<string> { userMail }
                          );
                        return "Hola, " + userName + "\nHas solicitado la recuperación de su contraseña.\n" +
                          "Porfavor cheque la bandeja de entrada de su  correo electrónico: " + userMail ;
                    }
                    else
                        return "No se encontró una cuenta registrada con ese nombre de usuario o correo electronico";
                }
            }
        }


        public string RegistrarUsuario(string PUESTO,string NOMBRE, string APEPATERN,string APEMATERN,string SEXO,string CELULAR,string estado,string ciudad,int cp,
            string colonia, string calle, int numeroCasa, string email, string nombreUsuario, string nacimiento, int edad)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("REGISTRAR_USUARIOS"))
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PUESTO", PUESTO);
                    command.Parameters.AddWithValue("@NOMBRE", NOMBRE);
                    command.Parameters.AddWithValue("@APEPATERN", APEPATERN);
                    command.Parameters.AddWithValue("@APEMATERN", APEMATERN);
                    command.Parameters.AddWithValue("@SEXO", SEXO);
                    command.Parameters.AddWithValue("@CELULAR", CELULAR);
                    command.Parameters.AddWithValue("@estado", estado);
                    command.Parameters.AddWithValue("@ciudad", ciudad);
                    command.Parameters.AddWithValue("@cp", cp);
                    command.Parameters.AddWithValue("@colonia", colonia);
                    command.Parameters.AddWithValue("@calle", calle);
                    command.Parameters.AddWithValue("@numeroCasa", numeroCasa);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    command.Parameters.AddWithValue("@nacimiento", nacimiento);
                    command.Parameters.AddWithValue("@edad", edad);

                    int afectados = command.ExecuteNonQuery();
                    if (afectados > 0)
                    {


                        return "Nuevo usuario registrado con exito en el sistema.";
                          //"\nNombre de usuario y contraseña enviadas al correo: " + email;
                    }
                    else
                    {
                        return "Error al registrar un usuario" +
                            "\n Un usuario ya se encuentra registrado con el correo " + email;
                    }

                }
            }
        }

        public string EnviarDatosUsuario(string userRequesting)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "exec enviarDatosUsuarioNuevo @mail";
                    command.Parameters.AddWithValue("@mail", userRequesting);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        string nombre = reader.GetString(3);
                        string nombreUsuario = reader.GetString(1);
                        string userMail = reader.GetString(7);
                        string accountPassword = reader.GetString(2);
                        var mailservice = new SystemSupportMail();
                        mailservice.sendMail(
                          subject: "La Panaderia: Datos de tu cuenta",
                          body: "Hola, " + nombre +
                          "\nTu nombre de cuenta es: " + nombreUsuario +" y tu contraseña es: "+ accountPassword +
                          "\nLe recomendamos cambiar su contraseña una vez haya entrado al sistema.",
                          recipientMail: new List<string> { userMail }
                          ); 
                        return "Nombre de usuario y contraseña enviadas al correo: " + userMail;
                    }
                    else
                        return "El usuario no se registro";
                }
            }
        }


        public string EnviarDatosUsuarioEditado(string userRequesting, string id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "exec enviarDatosUsuarioEditado @mail,@id";
                    command.Parameters.AddWithValue("@mail", userRequesting);
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        string nombre = reader.GetString(3);
                        string nombreUsuario = reader.GetString(1);
                        string userMail = reader.GetString(7);
                        string accountPassword = reader.GetString(2);
                        var mailservice = new SystemSupportMail();
                        mailservice.sendMail(
                          subject: "La Panaderia: Datos de tu cuenta",
                          body: "Hola, " + nombre +
                          "\ntu nombre de cuenta es: " + nombreUsuario + " y tu contraseña es: " + accountPassword ,
                      
                          recipientMail: new List<string> { userMail }
                          );
                        return "Información del usuario editado con exito." +
                          "\nNombre de usuario y contraseña enviadas al correo: " + userMail;
                    }
                    else
                        return "Error al editar el usuario";
                }
            }
        }



        public DataTable verUsuarios()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("desplegarUsuarios", connection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }


        public DataTable verUsuariosEdit(string dato)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("verUsuariosEdit ", connection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@dato", SqlDbType.VarChar).Value = dato;
                da.SelectCommand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

       


        public string EditarUsuario(string id,string NOMBRE, string APEPATERN, string APEMATERN, string SEXO, string CELULAR, string estado, string ciudad, int cp,
            string colonia, string calle, int numeroCasa, string email, string nombreUsuario, string nacimiento, int edad)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("EDITAR_USUARIOS"))
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@NOMBRE", NOMBRE);
                    command.Parameters.AddWithValue("@APEPATERN", APEPATERN);
                    command.Parameters.AddWithValue("@APEMATERN", APEMATERN);
                    command.Parameters.AddWithValue("@SEXO", SEXO);
                    command.Parameters.AddWithValue("@CELULAR", CELULAR);
                    command.Parameters.AddWithValue("@estado", estado);
                    command.Parameters.AddWithValue("@ciudad", ciudad);
                    command.Parameters.AddWithValue("@cp", cp);
                    command.Parameters.AddWithValue("@colonia", colonia);
                    command.Parameters.AddWithValue("@calle", calle);
                    command.Parameters.AddWithValue("@numeroCasa", numeroCasa);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    command.Parameters.AddWithValue("@nacimiento", nacimiento);
                    command.Parameters.AddWithValue("@edad", edad);

                    command.ExecuteNonQuery();

                    int afectados = command.ExecuteNonQuery();
                    if (afectados > 0)
                    {
                        return "Información del usuario "+ NOMBRE+" "+APEPATERN+" "+APEMATERN +" editado con exito en el sistema." +
                          "\nNombre de usuario y contraseña enviadas al correo: " + email;
                    }
                    else
                    {
                        return "Error al editar un usuario" +
                            "\n Un usuario ya se encuentra registrado con el correo " + email;
                    }

                }
            }
        }




        public string EliminarUsuario(string id,string nombre,string apellidoPaterno)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("eliminarUsuario"))
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();

                    int afectados = command.ExecuteNonQuery();
                    if (afectados > 0)
                    {
                        return "El usuario " + nombre + " " + apellidoPaterno + " ha sido ha dado de baja del sistema correctamente.";
                    }
                    else
                    {
                        return "Error al dar de baja un usuario" +
                            "\n No puedes eliminar la cuenta maestra";
                            
                    }

                }
            }
        }

        public DataTable verUsuariosPorNombre(string dato)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("desplegarUsuariosFiltroNombre", connection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@dato", SqlDbType.VarChar).Value = dato;
                da.SelectCommand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable verUsuariosPorEmail(string dato)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("desplegarUsuariosFiltroEmail", connection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@dato", SqlDbType.VarChar).Value = dato;
                da.SelectCommand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable verUsuariosPorTelefono(string dato)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("desplegarUsuariosFiltroNumeroTelefono", connection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@dato", SqlDbType.VarChar).Value = dato;
                da.SelectCommand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public string EditarTipoUsuario(string id, string TIPO)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("cambiarTipoUsuario"))
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@tipo", TIPO);

                    command.ExecuteNonQuery();

                    int afectados = command.ExecuteNonQuery();
                    if (afectados > 0)
                    {
                        return "Tipo del usuario editado con exito." +
                            "\n Ahora el usuario seleccionado es   "+TIPO;

                    }
                    else
                    {
                        return "Error al editar el tipo de un usuario" +
                            "\n No se cambió el tipo del usuario seleccionado.";
                    }

                }
            }
        }


        public DataTable verContraseñaUsuario(string dato)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("mostrarContraseña", connection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@id", SqlDbType.VarChar).Value = dato;
                da.SelectCommand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public string EditarContraseña(string id, string contra)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("cambiarContraseña"))
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@contraseña", contra);

                    command.ExecuteNonQuery();

                    int afectados = command.ExecuteNonQuery();
                    if (afectados > 0)
                    {
                        return "Su contraseña ha sido cambiada con exito.";


                    }
                    else
                    {
                        return "Error al editar la contraseña" +
                            "\n No se cambió la contraseña.";
                    }

                }
            }
        }

        public string EnviarContraseñaEditada(string userRequesting, string id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "exec enviarDatosUsuarioEditado @mail,@id";
                    command.Parameters.AddWithValue("@mail", userRequesting);
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        string nombre = reader.GetString(3);
                        string nombreUsuario = reader.GetString(1);
                        string userMail = reader.GetString(7);
                        string accountPassword = reader.GetString(2);
                        var mailservice = new SystemSupportMail();
                        mailservice.sendMail(
                          subject: "La Panaderia: Contraseña modificada",
                          body: "Hola, " + nombre +
                          " tu nueva contraseña es: " + accountPassword +
                          "\n Si tu no modificaste tu contraseña, reestablece tu contraseña y reporta el caso con tu supervisor",

                          recipientMail: new List<string> { userMail }
                          );
                        return "Nueva contraseña enviada al correo: " + userMail;
                    }
                    else
                        return "Error al editar la contraseña";
                }
            }
        }



        public DataTable verEstado()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("desplegarEstado", connection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }


        public DataTable verCiudad(string estado)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("DesplegarCiudad", connection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@estado", SqlDbType.VarChar).Value = estado;
                da.SelectCommand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }


        public DataTable verPermisos()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("mostrarPermisos", connection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public string EditarPermisos(string permiso, int acceso,string tipo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("editarPermisos"))
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@tipo", tipo);
                    command.Parameters.AddWithValue("@permisoA", permiso);
                    command.Parameters.AddWithValue("@acceso", acceso);

                    command.ExecuteNonQuery();

                    int afectados = command.ExecuteNonQuery();

                        return "Permisos del rol "+tipo+" modificado con exito";



                }
            }
        }

        public DataTable verPermisosLogin(string tipo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("mostrarPermisosLogin", connection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@tipo", SqlDbType.VarChar).Value = tipo;
                da.SelectCommand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public string REEnviarDatosUsuario(string userRequesting)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "exec enviarDatosUsuarioNuevo @mail";
                    command.Parameters.AddWithValue("@mail", userRequesting);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        string nombre = reader.GetString(3);
                        string nombreUsuario = reader.GetString(1);
                        string userMail = reader.GetString(7);
                        string accountPassword = reader.GetString(2);
                        var mailservice = new SystemSupportMail();
                        mailservice.sendMail(
                          subject: "La Panaderia: Datos de tu cuenta",
                          body: "Hola, " + nombre +
                          "\nTu nombre de cuenta es: " + nombreUsuario + " y tu contraseña es: " + accountPassword ,
                          recipientMail: new List<string> { userMail }
                          );
                        return "Creedenciales Reenviadas con exito." +
                          "\nNombre de usuario y contraseña enviadas al correo: " + userMail;
                    }
                    else
                        return "";
                }
            }
        }


        public DataTable stockPanes()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("stockPan", connection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable PanRegistrado()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("PanRegistrado", connection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }


        public DataTable ventaTempo()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("temporalVentas", connection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable articulosTabla()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("tablaVender", connection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public string restarPan(string nombre)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("restarPan"))
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@nombre", nombre);


                    command.ExecuteNonQuery();

                    return "XD";



                }
            }
        }

        public string agregarPan(string nombre)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("agregarPan"))
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@nombre", nombre);


                    command.ExecuteNonQuery();

                    return "XD";



                }
            }
        }


        public string agregarArticulo(int idEmpleado,string nombreEmpleado, string concepto, double precioUni,int cantidad, string fecha,int idPan)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("agregarArticulo"))
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idEmple", idEmpleado);
                    command.Parameters.AddWithValue("@nombreEmpleado", nombreEmpleado);
                    command.Parameters.AddWithValue("@concepto", concepto);
                    command.Parameters.AddWithValue("@precioUni", precioUni);
                    command.Parameters.AddWithValue("@cantidad", cantidad);
                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.Parameters.AddWithValue("@idpan", idPan);


                    command.ExecuteNonQuery();

                    return "XD";



                }
            }
        }

        public string borrarArticulo(int id,int canti,string pan)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("quitarArticulo"))
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@cantidad", canti);
                    command.Parameters.AddWithValue("@nombrePan", pan);


                    command.ExecuteNonQuery();

                    return "XD";



                }
            }
        }


        public string venderPan()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("venderArticulo"))
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();

                    return "XD";
                }
            }
        }

        public string insertarRecibiCambi(double recibi, double cambi)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("RecibidoCambi"))
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@recibido", recibi);
                    command.Parameters.AddWithValue("@cambio", cambi);
                    command.ExecuteNonQuery();

                    return "XD";
                }
            }
        }


        public string limpiarREcibiCambi()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("limpiarrecibiCambi"))
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();

                    return "XD";
                }
            }
        }

        public string registrarPan(string nombrePan,double precio,string imagen)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("proceRegistrarPan"))
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@nombre_pan", nombrePan);
                    command.Parameters.AddWithValue("@precio_unitario", precio);
                    command.Parameters.AddWithValue("@imagen", imagen);



                    command.ExecuteNonQuery();

                    return "XD";



                }
            }
        }

        public string sumarStock(string nombre, int cantidad)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("agregarStockaPan"))
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@cantidad", cantidad);
                    command.ExecuteNonQuery();

                    return "XD";
                }
            }
        }

        public DataTable verVentas()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("verVentas", connection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

    }
}
