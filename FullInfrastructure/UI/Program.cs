using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic.databaseHandler.initDatabase();
            //introSequence();
        }
        static void introSequence()
        {
            Console.WriteLine("**********************************************");
            Console.WriteLine("* Welcome to EasyN'Greasy Management System! *");
            Console.WriteLine("**********************************************");
            while (!sqlHandler.loginSequence()) ;
            mainMenu();
            bool exit = false;
            while (!exit)
                switch (char.Parse(Console.ReadLine()))
                {
                    case('0'):
                        mainMenu();
                        break;
                    case ('1'):
                        while(!sqlHandler.loginSequence());
                        mainMenu();
                        break;
                    case ('2'):
                        sqlHandler.printUsers();
                        break;
                    case ('3'):
                        sqlHandler.EmployeeRequest();
                        break;
                    case ('4'):
                        sqlHandler.regNewUser();
                        break;
                    case ('5'):
                        sqlHandler.regNewEmployee();
                        break;
                    case('6'):
                        sqlHandler.editEmployee();
                        break;
                    case ('7'):
                        sqlHandler.delUser();
                        break;
                    case ('8'):
                        sqlHandler.delEmployee();
                        break;
                    case('9'):
                        sqlHandler.editUser();
                        break;
                    case ('e'):
                        exit = true;
                        break;
                    default:
                        break;
                }

        }
        static void mainMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("0. Help = 0");
            Console.WriteLine("1. Switch user = 1");
            Console.WriteLine("2. Print users = 2");
            Console.WriteLine("3. Print Employees = 3");
            Console.WriteLine("4. Register = 4");
            Console.WriteLine("5. Register Employee = 5");
            Console.WriteLine("6. Edit Employee = 6");
            Console.WriteLine("7. Delete User = 7");
            Console.WriteLine("8. Delete Employee = 8");
            Console.WriteLine("9. Edit User = 9");
            Console.WriteLine("10. Exit = e");
        }
    }
}
