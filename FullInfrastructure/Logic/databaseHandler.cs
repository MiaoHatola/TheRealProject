using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;

namespace Logic
{
    class databaseHandler
    {
        public void initDatabase()
        {
            employeeDB employees=new employeeDB(false);
            if(!employees.load())
            {
                employees = new employeeDB(true);
                employees.save();
            }
            usersDB users = new usersDB(false);
            if(!users.load())
            {
                users = new usersDB(true);
                users.save();
            }
            productDB products = new productDB(false);
            if(!products.load())
            {
                products = new productDB(true);
                products.save();
            }
            departmentsDB departments = new departmentsDB(false);
            if(!departments.load())
            {
                departments = new departmentsDB(true);
                departments.save();
            }
            clubDB members = new clubDB(false);
            if(!members.load())
            {
                members = new clubDB(true);
                members.save();
            }
        }
    }
}