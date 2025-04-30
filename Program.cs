using System;
using System.ComponentModel.Design;
using System.Formats.Asn1;
class ElectricityBill
{
    static void Main()
    {
        Console.Write("Enter customr ID: ");
        int customerID = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter cutomer Name: ");
        string customerName = Console.ReadLine();

        Console.Write("Enter units consumed: ");
        int units = Convert.ToInt32(Console.ReadLine());


        double chargePerUnit = 0;
        if (units <= 199)
        {
            chargePerUnit = 1.20;
        }
        else
        {
            if (units < 400)
            {
                chargePerUnit = 1.50;
            }
            else
            {
                if (units < 600) 
                {
                    chargePerUnit = 1.80;
                }
                else
                {
                    chargePerUnit = 2.00;

                }

                double totalAmount = units * chargePerUnit;

                // surcharge

                double surcharge = 0;
                if (totalAmount > 400)
                {
                    surcharge = totalAmount * .15;
                }
                double netAmount = totalAmount + surcharge;

                Console.WriteLine("Electricity Bill");
                Console.WriteLine("-----------------");
                Console.WriteLine($"Customer IDNO : {customerID}");
                Console.WriteLine($"Customer Name : {customerName}");
                Console.WriteLine($"Unit Consumed : {units}");
                Console.WriteLine($"Amount Charges @$ {chargePerUnit} per unit : {totalAmount:F2}");
                Console.WriteLine($"Surcharge Amount : {surcharge:F2}");
                Console.WriteLine($"Net Amount Paid By the Customer : {netAmount:F2}");
            }
        }
    }
}
