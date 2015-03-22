using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class clubDB
    {
        List<clubMember> members;
        readonly string FILENAME="members.bin";
        public clubDB(bool isNew)
        {
            //Creates a new department database
            members = new List<clubMember>(); ;
        }

        public bool load()
        {
            serializeHandler ser=new serializeHandler();
            return(ser.deserialize(FILENAME)!=null);
        }
        public void save()
        {
            serializeHandler ser = new serializeHandler();
            ser.serialize(FILENAME, members);
        }
    }
}
