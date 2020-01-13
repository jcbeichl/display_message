using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week._4.a
{
    class Program
    {
        //nested structure of employee 
        struct employeename
        {
            public string eName;
            public employeeaddress eaddress;
            public employeemonthsalary emonthly;
            public employeemonthlytaxwithholding emonthtaxwithhold;
            public employeeaftertaxmonthlysalary emonthaftertaxsalary;
            public employeeannualsalary eannual;
            public employeeannualtaxwithholding eannualtaxwithhold;
            public employeeaftertaxannualsalary eannualaftertaxsalary;
            public employeetype etaxtype;
        }

        //employeeaddress is a nested structure of employee
        struct employeeaddress
        {
            public string fulladd;
        }

        //employee monthly salary before taxes is a nested structure of employee
        struct employeemonthsalary
        {
            public int monthlypay;
        }

        //employee monthly taxes being withheld is a nested structure of employee
        struct employeemonthlytaxwithholding
        {
            public int monthlytaxwithholding;
        }

        //employee monthly salary after tax is a nested structure of employee
        struct employeeaftertaxmonthlysalary
        {
            public int aftertaxmonthlysalary;
        }

        //employee annual salary before taxes is a nested structure of employee
        struct employeeannualsalary
        {
            public int annualsalary;
        }

        //employee annual tax is a nested structure of employee
        struct employeeannualtaxwithholding
        {
            public int annualtaxwithholding;
        }

        //employee annual salary after tax is a nested structure of employee
        struct employeeaftertaxannualsalary
        {
            public int aftertaxannualsalary;
        }

        //employee type is a nested structure of employee
        struct employeetype
        {
            public int employeetaxtype;
        }

        static void Main(string[] args)
        {
            //variables
            int emonthpay = 0;
            double EmonthTax = 0.07;
            double EmonthtaxWithhold;
            int emonthwithholdtax = 0;
            int emonthaftertaxpay = 0;
            double NewEmonthPay;
            int eannualpay = 0;
            double EannualSalary;
            double EannualtaxWithhold;
            int eannualwithholdtax = 0;
            int eannualaftertaxpay = 0;
            double NewEannualPay;
            int etype = 0;
            int total = 3;
            
            
            employeename[] emp = new employeename[total];

            Console.Write("-------------------------------------------------------\n");
            
            for (int i = 0; i < total; i++)
            {

                Console.WriteLine("Please select the employee type from below: ");
                Console.WriteLine(" '1' W2");
                Console.WriteLine(" '2' 1099");
                etype = Convert.ToInt32(Console.ReadLine());
                emp[i].etaxtype.employeetaxtype = etype;

                Console.WriteLine();

                if (etype == 1)
                {
                    Console.Write("Name of the employee: ");
                    string nm = Console.ReadLine();
                    emp[i].eName = nm;

                    Console.Write("What is " + nm + "'s address: ");
                    string eadd = Console.ReadLine();
                    emp[i].eaddress.fulladd = eadd;

                    Console.Write("Enter " + nm + "'s salary: $");
                    emonthpay = Convert.ToInt32(Console.ReadLine());
                    emp[i].emonthly.monthlypay = emonthpay;

                    //monthly taxes for each employee
                    EmonthtaxWithhold = emonthpay * EmonthTax;

                    Console.Write("Monthly taxes withheld for " + nm + ": $" + EmonthtaxWithhold + "");
                    emonthwithholdtax = Convert.ToInt32(EmonthtaxWithhold);
                    emp[i].emonthtaxwithhold.monthlytaxwithholding = emonthwithholdtax;

                    Console.WriteLine();

                    //monthly pay for each employee after taxes
                    NewEmonthPay = emonthpay - EmonthtaxWithhold;

                    Console.Write("After taxes " + nm + "'s monthly salary: $" + NewEmonthPay + "");
                    emonthaftertaxpay = Convert.ToInt32(NewEmonthPay);
                    emp[i].emonthaftertaxsalary.aftertaxmonthlysalary = emonthaftertaxpay;

                    Console.WriteLine();

                    //annual pay for each employee
                    EannualSalary = emonthpay * 12;

                    Console.Write("" + nm + "'s annual salary is: $" + EannualSalary + "");
                    eannualpay = Convert.ToInt32(EannualSalary);
                    emp[i].eannual.annualsalary = eannualpay;

                    Console.WriteLine();

                    //annual taxes for each employee
                    EannualtaxWithhold = emonthwithholdtax * 12;

                    Console.Write("Annual taxes withheld for " + nm + " is: $" + EannualtaxWithhold + "");
                    eannualwithholdtax = Convert.ToInt32(EannualtaxWithhold);
                    emp[i].eannualtaxwithhold.annualtaxwithholding = eannualwithholdtax;

                    Console.WriteLine();

                    //annual gross pay for each employee after tax
                    NewEannualPay = eannualpay - EannualtaxWithhold;

                    Console.Write("After taxes " + nm + "'s annual salary is: $" + NewEannualPay + "");
                    eannualaftertaxpay = Convert.ToInt32(NewEannualPay);
                    emp[i].eannualaftertaxsalary.aftertaxannualsalary = eannualaftertaxpay;

                    Console.WriteLine();

                    Console.WriteLine("-------------------------------------------------------\n");

                 }

                else 
                {
                    Console.Write("Name of the employee: ");
                    string nm = Console.ReadLine();
                    emp[i].eName = nm;

                    Console.Write("What is " + nm + "'s address: ");
                    string eadd = Console.ReadLine();
                    emp[i].eaddress.fulladd = eadd;

                    Console.Write("Enter " + nm + "'s monthly salary: $");
                    emonthpay = Convert.ToInt32(Console.ReadLine());
                    emp[i].emonthly.monthlypay = emonthpay;

                    //annual pay for each employee
                    EannualSalary = emonthpay * 12;

                    Console.Write("" + nm + "'s annual salary is: $" + EannualSalary + "");
                    eannualpay = Convert.ToInt32(EannualSalary);
                    emp[i].eannual.annualsalary = eannualpay;

                    Console.WriteLine();

                    Console.WriteLine("-------------------------------------------------------\n");

                }

                

                

            }

        }
    }
}
