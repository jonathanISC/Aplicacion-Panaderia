using CapaDatos;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocios
{
    public class Usuarios
    {
        ConsultasUsuario consulLogin = new ConsultasUsuario();
        public bool Login(string user, string pass)
        {
            return consulLogin.Login(user, pass);
        }

        public string recoverPassword(string userRequesting)
        {
            return consulLogin.recoverPassword(userRequesting);
        }

        public string registrarUsuario(string PUESTO, string NOMBRE, string APEPATERN, string APEMATERN, string SEXO, string CELULAR, string estado, string ciudad, int cp,
            string colonia, string calle, int numeroCasa, string email, string nombreUsuario, string nacimiento, int edad)
        {
            return consulLogin.RegistrarUsuario(PUESTO, NOMBRE, APEPATERN, APEMATERN, SEXO, CELULAR, estado, ciudad, cp, colonia, calle, numeroCasa, email, nombreUsuario, nacimiento, edad);
        }

        public string enviarDatos(string email)
        {
            return consulLogin.EnviarDatosUsuario(email);
        }

        public DataTable desplegarUsuarios()
        {
            return consulLogin.verUsuarios();
        }

        public DataTable desplegarUsuariosEdit(string dato)
        {
            return consulLogin.verUsuariosEdit(dato);
        }

        public string editarUsuario(string id, string NOMBRE, string APEPATERN, string APEMATERN, string SEXO, string CELULAR, string estado, string ciudad, int cp,
            string colonia, string calle, int numeroCasa, string email, string nombreUsuario, string nacimiento, int edad)
        {
            return consulLogin.EditarUsuario(id,NOMBRE, APEPATERN, APEMATERN, SEXO, CELULAR, estado, ciudad, cp, colonia, calle, numeroCasa, email, nombreUsuario, nacimiento, edad);
        }


        public string enviarDatosEditados(string email, string ide)
        {
            return consulLogin.EnviarDatosUsuarioEditado(email,ide);
        }

        public string eliminarUsuario(string ide,string nombre, string apellidoPaterno)
        {
            return consulLogin.EliminarUsuario (ide,nombre,apellidoPaterno);
        }


        public DataTable desplegarUsuariosNombre(string dato)
        {
            return consulLogin.verUsuariosPorNombre(dato);
        }

        public DataTable desplegarUsuariosEmail(string dato)
        {
            return consulLogin.verUsuariosPorEmail(dato);
        }

        public DataTable desplegarUsuariosTelefono(string dato)
        {
            return consulLogin.verUsuariosPorTelefono(dato);
        }

        public string editarElTipoDeUsuario(string ide,string tipo)
        {
            return consulLogin.EditarTipoUsuario(ide,tipo);
        }

        public DataTable verContraseña(string dato)
        {
            return consulLogin.verContraseñaUsuario(dato);
        }

        public string editarContraseña(string ide, string contra)
        {
            return consulLogin.EditarContraseña(ide, contra);
        }


        public string enviarContraNueva(string email, string ide)
        {
            return consulLogin.EnviarContraseñaEditada(email, ide);
        }

        public DataTable desplegarEstado()
        {
            return consulLogin.verEstado();
        }


        public DataTable desplegarCiudad(string dato)
        {
            return consulLogin.verCiudad(dato);
        }


        public DataTable desplegarPermisos()
        {
            return consulLogin.verPermisos();
        }

        public string editarPermisos(string permiso, int acceso, string tipo)
        {
            return consulLogin.EditarPermisos(permiso,acceso, tipo);
        }

        public DataTable mostrarPermisosLogin(string tipo)
        {
            return consulLogin.verPermisosLogin(tipo);
        }

        public string REenviarDatos(string email)
        {
            return consulLogin.REEnviarDatosUsuario(email);
        }

        public DataTable stockPan()
        {
            return consulLogin.stockPanes();
        }

        public DataTable PanRegistrado()
        {
            return consulLogin.PanRegistrado();
        }

        public DataTable ventaTempo()
        {
            return consulLogin.ventaTempo();
        }

        public DataTable articulosTabla()
        {
            return consulLogin.articulosTabla();
        }

        public string restarPan(string nombre)
        {
            return consulLogin.restarPan(nombre);
        }

        public string agregarPan(string nombre)
        {
            return consulLogin.agregarPan(nombre);
        }


        public string agregarArticulo(int idEmpleado, string nombreEmpleado, string concepto, double precioUni, int cantidad, string fecha, int idPan)
        {
            return consulLogin.agregarArticulo(idEmpleado, nombreEmpleado, concepto, precioUni, cantidad, fecha, idPan);
        }

        public string quitarArticulo(int id, int canti, string pan)
        {
            return consulLogin.borrarArticulo(id, canti, pan);
        }
        public string venderPan()
        {
            return consulLogin.venderPan();
        }

        public string insertarRecibidoCambio(double recibi, double cambi)
        {
            return consulLogin.insertarRecibiCambi(recibi, cambi);
        }

        public string limpiarRecibiCambi()
        {
            return consulLogin.limpiarREcibiCambi();
        }

        public string registrarPanN(string nombrePan, double precio, string imagen)
        {
            return consulLogin.registrarPan(nombrePan, precio, imagen);
        }

        public string sumarStocks(string nombre, int cantidad)
        {
            return consulLogin.sumarStock(nombre, cantidad);
        }

        public DataTable verVentash()
        {
            return consulLogin.verVentas();
        }
    }
}
