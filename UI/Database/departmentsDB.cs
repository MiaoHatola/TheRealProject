using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class departmentsDB
    {
        List<department> departments;
        readonly string FILENAME="departments.bin";
        public departmentsDB(bool isNew)
        {
            //Creates a new department database
            departments = new List<department>();
        }

        public bool load()
        {
            serializeHandler ser=new serializeHandler();
            return(ser.deserialize(FILENAME)!=null);
        }
        public void save()
        {
            serializeHandler ser = new serializeHandler();
            ser.serialize(FILENAME, departments);
        }
        

    }
}
