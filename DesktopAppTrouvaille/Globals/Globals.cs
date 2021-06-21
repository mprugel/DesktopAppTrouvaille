

using DesktopAppTrouvaille.Enums;
using System.Collections.Generic;

namespace DesktopAppTrouvaille.Globals
{
    public class Globals
    {
        public static Dictionary<OrderState, string> OrderStateDic = new Dictionary<OrderState, string>();

        


        public static void InitGlobals()
        {
            // Set the names for the Sorting Order

            // Set the Names for the Order states:
            OrderStateDic.Add(OrderState.Bestellt, "Bestellt");
            OrderStateDic.Add(OrderState.Storniert, "Storniert");
            OrderStateDic.Add(OrderState.Unterwegs, "Unterwegs");
            OrderStateDic.Add(OrderState.Zugestellt, "Zugestellt");

            

        }
        //public static string[] OrderStateText = { "Ausgeliefert", "Bezahlt", "Storniert"};
        public enum PaymentMethod
        {
            Rechnung,
            Vorkasse,
            Paypal
        }

        public enum Shipmentmethod
        {
            dhl,
            dpd,
            ups,
            hermes
        }

        public enum OrderState
        {
            Bestellt ,
            Unterwegs ,
            Zugestellt ,
            Storniert 

        }

        public enum GermanStates
        {
            BadenWürttemberg,
            Bayer,
            Berlin,
            Brandenburg,
            Bremen,
            Hamburg,
            Hessen,
            Mecklenburg_Vorpommern,
            Niedersachen,
            Nordhein_Westfalen,
            RheinlandPfalz,
            Saarland,
            Sachsen,
            Sachsen_Anhalt,
            SchleswigHolstein,
            Thüringen
        }
    }
}

