using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsApp_Robot.Model
{
    class ModelContacts
    {
        public string contact;
        public string status;

        public ModelContacts(string contact, string status)
        {
            this.contact = contact ?? throw new ArgumentNullException(nameof(contact));
            this.status = status ?? throw new ArgumentNullException(nameof(status));
        }
    }
}
