using calculate_distances.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate_distances.Services
{
    public class EmailService : IEmailService
    {
        private readonly string _emailSender;
        private readonly string[] _recipientEmails;
        private readonly string _googleApiKey;

        public EmailService(string emailSender, string[] recipientEmails, string googleApiKey)
        {
            _emailSender = emailSender;
            _recipientEmails = recipientEmails;
            _googleApiKey = googleApiKey;
        }

        public void SendNotification(string file)
        {
            // Send email notification with file URL, ensuring API key security
            // ...
        }
    }
}
