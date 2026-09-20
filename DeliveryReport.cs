using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment3.Net.OOP
{
    internal class DeliveryReport
    {
        public void PrintShipment(ITrackable shipment)
        {
            Console.WriteLine(shipment.GetTrackingStatus()); 
        }
    }
}
