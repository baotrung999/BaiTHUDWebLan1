using System;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BaiTap4_60137367.Models
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