using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Hester
{
    public class DeskQuote
    {
        public Desk NewDesk { get; set; }
        public string Name { get; set; }
        public DateTime QuoteDate { get; set; }
        public Rush Rush { get; set; }
    }

    public enum Rush
    {
        Standard,
        Three_Day,
        Five_Day,
        Seven_Day,
    };

    //toString("c")
    //Json array of deskquote with desk inside
}
