using System;

namespace QwikPix.Entities.Accounts
{
    public class QwikUser
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string EmailAddress { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
