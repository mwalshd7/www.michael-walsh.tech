using System.Collections.Generic;

namespace myApp2.Models
{
        
        public class EmailMessage
        {
        // Auto-implemented properties + instantiated )C#6+) ( <List>
            public List<EmailAddress> ToAddresses { get; set; } = new List<EmailAddress>();
            public List<EmailAddress> FromAddresses { get; set; } = new List<EmailAddress>();

        // Auto-implemented properties
            public string Subject { get; set; }
            public string Content { get; set; }
        }
    }
