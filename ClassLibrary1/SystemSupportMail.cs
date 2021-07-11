namespace CapaDatos
{
    public class SystemSupportMail : MasterMail
    {
        public SystemSupportMail()
        {
            senderMail = "Correo electronico del remitente";
            password = "Contraseña del correo electronico del remitente";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }
    }
}
