using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class employeeDB
    {
        private List<employee> employees;
        readonly string FILENAME="employees.bin";
        public employeeDB(bool isNew)
        {
            //Creates a new department database
            if(isNew)
                employees = new List<employee>();
        }

        public bool load()
        {
            serializeHandler ser=new serializeHandler();
            return(ser.deserialize(FILENAME)!=null);
        }
        public void save()
        {
            serializeHandler ser = new serializeHandler();
            ser.serialize(FILENAME, employees);
        }
    }
}
