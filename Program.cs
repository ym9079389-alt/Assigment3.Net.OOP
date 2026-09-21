namespace Assigment3.Net.OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            #region a
            //a)  What is Abstraction in Object - Oriented Programming ?
            // Abstraction concept of hiding complex implementation details and showing only the finl result of an object to the user.
            #endregion

            #region b
            //b)  Why is abstraction considered one of the four pillars of OOP ?
            //Enhances Maintainability & Security: Protects internal code from changes.
            //Enables Reusability: Provides reusable blueprints across the project.
            #endregion

            #endregion

            #region Q2

            #region a
            //a)  What is the difference between an Abstract Class and an Interface ?
            //Interface: cannot use constractor.
            //Abstract: can use constractor and implementation the proparety in abstract.
            #endregion

            #region b
            //b)  When would you choose an Interface instead of an Abstract Class ?
            // Interface: Multiple Inheritance, Decoupling & Testing.
            #endregion

            #region c
            //c)  Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?
            //No, 
            //Yes.
            #endregion

            #endregion

            #region Q3
            DeliveryCenter center = new DeliveryCenter("Cairo Center");

            Console.WriteLine("--- Enter Details for Standard Shipment ---");
            Console.Write("Tracking Code: "); string code1 = Console.ReadLine();
            Console.Write("Description: "); string desc1 = Console.ReadLine();
            Console.Write("Weight: "); decimal.TryParse(Console.ReadLine(), out decimal w1);
            Console.Write("Delivery Fee: "); decimal.TryParse(Console.ReadLine(), out decimal f1);
            Console.Write("City: "); string city1 = Console.ReadLine();
            Console.Write("Street: "); string street1 = Console.ReadLine();
            Console.Write("Building Number: "); int.TryParse(Console.ReadLine(), out int b1);

            DeliveryAddress addr1 = new DeliveryAddress(city1, street1, b1);
            StandardShipment standard = new StandardShipment(code1, desc1, w1, f1, addr1);
            center.AddShipment(standard);
            DeliveryReport report01 = new DeliveryReport();
            report01.PrintShipment(standard);

            Console.WriteLine("\n--- Enter Details for Express Shipment ---");
            Console.Write("Tracking Code: "); string code2 = Console.ReadLine();
            Console.Write("Description: "); string desc2 = Console.ReadLine();
            Console.Write("Weight: "); decimal.TryParse(Console.ReadLine(), out decimal w2);
            Console.Write("Delivery Fee: "); decimal.TryParse(Console.ReadLine(), out decimal f2);
            Console.Write("Extra Fee: "); decimal.TryParse(Console.ReadLine(), out decimal extraFee);
            Console.Write("City: "); string city2 = Console.ReadLine();
            Console.Write("Street: "); string street2 = Console.ReadLine();
            Console.Write("Building Number: "); int.TryParse(Console.ReadLine(), out int b2);

            DeliveryAddress addr2 = new DeliveryAddress(city2, street2, b2);
            ExpressShipment express = new ExpressShipment(code2, desc2, w2, f2, addr2, extraFee);
            center.AddShipment(express);
            DeliveryReport report02 = new DeliveryReport();
            report02.PrintShipment(express);

            Console.WriteLine("\n--- Enter Details for International Shipment ---");
            Console.Write("Tracking Code: "); string code3 = Console.ReadLine();
            Console.Write("Description: "); string desc3 = Console.ReadLine();
            Console.Write("Weight: "); decimal.TryParse(Console.ReadLine(), out decimal w3);
            Console.Write("Delivery Fee: "); decimal.TryParse(Console.ReadLine(), out decimal f3);
            Console.Write("Destination Country: "); string country = Console.ReadLine();
            Console.Write("Customs Fee: "); decimal.TryParse(Console.ReadLine(), out decimal customsFee);
            Console.Write("City: "); string city3 = Console.ReadLine();
            Console.Write("Street: "); string street3 = Console.ReadLine();
            Console.Write("Building Number: "); int.TryParse(Console.ReadLine(), out int b3);

            DeliveryAddress addr3 = new DeliveryAddress(city3, street3, b3);
            InternationalShipment intern = new InternationalShipment(code3, desc3, w3, f3, addr3, country, customsFee);
            center.AddShipment(intern);
            DeliveryReport report03 = new DeliveryReport();
            report03.PrintShipment(intern);


            ITrackable[] trackables = { standard, express, intern };
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(trackables[i].GetTrackingStatus());
            }

            IInsurable[] insurables = { standard, express, intern };
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(insurables[i].CalculateInsurance());
            }




            #endregion
        }
    }
}
