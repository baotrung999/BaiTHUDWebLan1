using System;
using System.Data.Entity;
using System.Linq;

namespace BaiTH5.Models
{
    public class MailInfo
    {
        public string From { get; set; }
        public string Password { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}