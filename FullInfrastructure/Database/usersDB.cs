using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class usersDB
    {
        List<user> users;
        readonly string FILENAME="users.bin";
        public usersDB(bool isNew)
        {
            //Creates a new department database
            if(isNew)
                users = new List<user>();
        }
        public bool load()
        {
            serializeHandler ser=new serializeHandler();
            return(ser.deserialize(FILENAME)!=null);
        }
        public void save()
        {
            serializeHandler ser = new serializeHandler();
            ser.serialize(FILENAME, users);
        }
    }
}
