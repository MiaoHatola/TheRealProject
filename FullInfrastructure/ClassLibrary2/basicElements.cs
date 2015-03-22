using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    class department
    {
        private int ID;
        private string name;
        public department(int id, string name)
        {
            this.name = name;
            this.ID = id;
        }
        public string getName()
        {
            return this.name;
        }
        public int getId()
        {
            return this.ID;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setId(int id)
        {
            this.ID = id;
        }
    }
    class employee
    {

    }
    class transaction
    {

    }
    class product
    {

    }
    class user
    {

    }
    class clubMember
    {

    }
    class person
    {

    }
}

