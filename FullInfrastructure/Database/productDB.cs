using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class productDB
    {
        List<product> products;
        readonly string FILENAME="products.bin";
        public productDB(bool isNew)
        {
            //Creates a new department database
            if(isNew)
                products = new List<product>();
        }

        public bool load()
        {
            serializeHandler ser=new serializeHandler();
            return(ser.deserialize(FILENAME)!=null);
        }
        public void save()
        {
            serializeHandler ser = new serializeHandler();
            ser.serialize(FILENAME, products);
        }
    }
}
