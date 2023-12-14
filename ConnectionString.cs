using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sql
{
    public class ConnectionString
    {
        public string cs {get; set;}

        public ConnectionString(){
            string server = "g84t6zfpijzwx08q.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
            string database = "qzk8ew4fgbscg75i";
            string port = "3306";
            string username = "o924cd1yskyhhy45";
            string password = "rcr7qy6kglysbr02";

            cs = $@"server = {server};user = {username};database={database};port={port};password={password};";

        }
    }
}