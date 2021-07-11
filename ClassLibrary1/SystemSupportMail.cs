namespace CapaDatos
{
    public class SystemSupportMail : MasterMail
    {
        public SystemSupportMail()
        {
            senderMail = "jgc.isc@gmail.com";
            password = "65d3b5d221";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }
    }
}
