using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaveJuego.Singleton
{
    internal class SectorSG
    {
        private static SectorSG? Instance;

        private HashSet<string> EntitiesSector { get; }

        private SectorSG()
        {
            EntitiesSector = new HashSet<string>();
        }
        private static SectorSG GetSector()
        {
            if (Instance == null)
            {
                Instance = new SectorSG();
            }
            return  Instance;
        }//end GetSector

        public static bool SetSector(Point into, Point outop)
        {
            SectorSG.GetSector().EntitiesSector.Remove(outop.ToString());
            SectorSG.GetSector().EntitiesSector.Add(into.ToString());
            return true;
        }//end setSector

        public static bool SectorHas(Point p)
        {
            return SectorSG.GetSector().EntitiesSector.Contains(p.ToString());
        }
    }
}
