namespace CSGOBeast.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Ticket
    {
        public int Id { get; set; }

        public string AuthorName { get; set; }

        public string EmailAddress { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }

        public virtual User User { get; set; }

        public string Answer { get; set; }

        public string UserId { get; set; }

        public bool Answered { get; set; }
    }
}
