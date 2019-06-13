using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myApp2.Models
{
    public interface IEmailService
    {
        void Send(EmailMessage message);
    }
}
