

using System.Collections.Generic;

namespace DesktopAppTrouvaille.Globals
{
    public class Globals
    {
        public static Dictionary<OrderState, string> OrderStateDic = new Dictionary<OrderState, string>();


        public static void InitGlobals()
        {
            OrderStateDic.Add(OrderState.payed, "Bezahlt");
            OrderStateDic.Add(OrderState.shipped, "Ausgeliefert");
            OrderStateDic.Add(OrderState.cancelled, "Storniert");
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
            shipped = 0,
            payed = 1,
            cancelled = 2,

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

