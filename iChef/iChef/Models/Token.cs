using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace iChef.Models
{
    public class Token
    {
        [PrimaryKey]
        public int TokenId { get; set; }
        public string AccessToken { get; set; }
        public string ErrorDescription { get; set; }
        public DateTime ExpireDate { get; set; }
        public int ExpirationTime { get; set; }

    }
}
