using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    
    class department
    {
        private int ID=1;
        private string name;
        public department(string name)
        {
            this.name = name;
            this.ID++;
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
    }
    class Employee : person
    {
        private int departmentID;
        private int salary;
        private int supervisorID;
        private string clear;

        public Employee(int TZ, string FN, string LN, gender G, int dID, int salary, int sID, string clear)
            : base(TZ, FN, LN, G)
        {
            this.departmentID = dID;
            this.salary = salary;
            this.supervisorID = sID;
            this.clear = clear;
        }
        public int getDepartmentID()
        {
            return this.departmentID;
        }
        public void setDepartmentID(int newID)
        {
            this.departmentID=newID;
        }//change employee department
        public int getSalary()
        {
            return this.salary;
        }
        public void setSalary(int newSalary)
        {
            this.salary = newSalary;
        }
        public int getSuperVisorID()
        {
            return this.supervisorID;
        }
        public void setSuperVisorId(int newSuperVisor)
        {
            this.supervisorID = newSuperVisor;
        }//change employee supervisor
    }//TODO talk about clearence
    enum paymentMethod {check,cash}
    class transaction
    {
        private int transactionID=1;
        private int dateTime;
        private bool isAReturn;
        private paymentMethod pM;

        public transaction(int dT,paymentMethod pM)
        {
            this.dateTime = dT;
            this.isAReturn = false;
            this.pM = pM;
            this.transactionID++;
        }
        public int getDateTime()
        {
            return this.dateTime;
        }
        public bool getIsAReturn()

        {
            return this.isAReturn;
        }
        public void setIsAreturn()
        {
            this.isAReturn = true;
        }
        public int getTransactionID()
        {
            return this.transactionID;
        }
    }
    enum Type { }
    class product
    {
        private int ProductID = 1;
        private string Name;
        private Type Type;
        private int location;
        private bool inStock;
        private int price;
        private int countStock = 0;
        
        public product(string _name, Type _type)
        {
            this.Name = _name;
            this.Type = _type;
            this.ProductID++;
        }
        public string getName()
        {
            return this.Name;
        }
        public Type getType()
        {
            return this.Type;
        }
    }
    class user
    {
        private string name;
        private int id = 0;

        public user(string name)
        {
            this.name = name;
            this.id++;
        }
        public string getUserName()
        {
            return this.name;
        }
        public int getID()
        {
            return this.id;
        }
    }
    class ClubMember : person
    {
        private int memberID;
        private List<int> historyTransactionID;
        private string dateOfBirth;

        public ClubMember(int TZ, string FN, string LN, gender G, int mID, string dOB)
            : base(TZ, FN, LN, G)
        {
            this.memberID = mID;
            this.historyTransactionID = null;
            this.dateOfBirth = dOB;
        }
        public int getMemberID()
        {
            return this.memberID;
        }
        public void addTransaction(int TID)
        {
            historyTransactionID.Add(TID);
        }//TODO check what more needed to now about the transaction
        public string getDateOfBirth()
        {
            return this.dateOfBirth;
        }   
    }
    enum gender { Male, Secretary }
    abstract class person
    {
        private int teudatZehute;
        private string firstName;
        private string lastName;
        private gender gender;
        public person(int TZ, string FN, string LN, gender G)
        {
            this.teudatZehute = TZ;
            this.firstName = FN;
            this.lastName = LN;
            this.gender = G;
        }
        public int getTeudatZehute()
        {
            return this.teudatZehute;
        }
        public string getFirstName()
        {
            return this.firstName;
        }
        public string getLastName()
        {
            return this.lastName;
        }
        public gender getGender()
        {
            return this.gender;
        }

    }
}



