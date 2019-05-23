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

        public decimal QuoteTotal(DeskQuote deskQuote)
        {
            //Declare Variables for calculations
            decimal quoteTotal = 200;
            var surfaceMaterialCost = 0;
            var additionalMaterialCost = 0;
            var rushCost = 0;

            //Varialbles with values from deskQuote
            var surfaceMaterial = deskQuote.NewDesk.SurfaceMaterial.ToString();
            var rushValue = deskQuote.Rush.ToString();

            //Variable with calculations
            var surfaceArea = deskQuote.NewDesk.Depth * deskQuote.NewDesk.Width;
            var drawerCost = deskQuote.NewDesk.NumDrawers * 50;

            //Determine if additional material is needed
            if ((surfaceArea) > 1000)
            {
                additionalMaterialCost = (int) surfaceArea - 1000;
            }

            //Determine Surface Material Cost
            if (surfaceMaterial == "Oak") {
                surfaceMaterialCost = 200; }
            else if (surfaceMaterial == "Laminate") {
                surfaceMaterialCost = 100; }
            else if (surfaceMaterial == "Pine") {
                surfaceMaterialCost = 50; }
            else if (surfaceMaterial == "Rosewood") {
                surfaceMaterialCost = 300; }
            else { surfaceMaterialCost = 125; } //Veneer

            //Determine RushShipping Cost
            if ((rushValue == "Three_Day" && surfaceArea < 1000) || (rushValue == "Five_Day" && surfaceArea > 2000))
            {
                rushCost = 60;
            }
            else if ((rushValue == "Five_Day" && surfaceArea < 1000) || (rushValue == "Seven_Day" && surfaceArea > 2000))
            {
                rushCost = 40;
            }
            else if (rushValue == "Three_Day" && (2000 >= surfaceArea && surfaceArea > 1000))
            {
                rushCost = 70;
            }
            else if (rushValue == "Three_Day" && surfaceArea > 2000)
            {
                rushCost = 80;
            }
            else if (rushValue == "Five_Day" && (2000 >= surfaceArea && surfaceArea > 1000))
            {
                rushCost = 50;
            }
            else if (rushValue == "Seven_Day" && surfaceArea <= 1000)
            {
                rushCost = 30;
            }
            else
            {
                rushCost = 35; //seven day and 2000 >= surfaceArea > 1000
            }


            return quoteTotal + additionalMaterialCost + surfaceMaterialCost + rushCost + drawerCost;
        }
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
