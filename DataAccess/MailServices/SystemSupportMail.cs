using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MailServices
{
    class SystemSupportMail:MasterMailServer
    {
        public SystemSupportMail()
        {
            senderMail = "noreply.preverisk@yahoo.com";
            password = "juntosimpulsamos";
            host = "smtp.mail.yahoo.com";
            port = 25;
            ssl = true;
            initializeSmtpClient();
        }
    }
}
