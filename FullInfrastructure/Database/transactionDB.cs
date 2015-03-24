using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    class transactionDB
    {
        List<transaction> transactions;
        readonly string FILENAME="transactions.bin";
        public transactionDB(bool isNew)
        {
            //Creates a new department database
            if(isNew)
                transactions = new List<transaction>();
        }

        public bool load()
        {
            serializeHandler ser=new serializeHandler();
            return(ser.deserialize(FILENAME)!=null);
        }
        public void save()
        {
            serializeHandler ser = new serializeHandler();
            ser.serialize(FILENAME, transactions);
        }
    }
}
