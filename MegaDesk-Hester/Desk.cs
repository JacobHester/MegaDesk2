using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Hester
{
    

    class Desk
    {
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public decimal NumDrawers { get; set; }
        public string SurfaceMaterial { get; set; }
    }

    public enum DeskMaterial
    {
        Laminate,
        Oak,
        Veneer,
        Rosewood,
        Pine
    };
}
