using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaveJuego
{
    internal class Ventana
    {
        public int Ancho { get; set; }
        public int Alto { get; set; } 

        public ConsoleColor Color { get; set; }

        public Point PuntoLimiteSuperior { get; set; }

        public Point PuntoLimiteInferior { get; set; }

        public Ventana(
            int ancho, 
            int alto, 
            ConsoleColor color,
            Point puntoSuperior,
            Point puntoInferior) 
        {
            Ancho = ancho;
            Alto = alto;
            Color = color;
            PuntoLimiteInferior = puntoInferior;
            PuntoLimiteSuperior = puntoSuperior;
            Init();
        }

        private void Init()
        {
            Console.SetWindowSize(Ancho, Alto);
            Console.Title = "Nave";
            Console.BackgroundColor = Color;
            Console.CursorVisible = false;
            Console.Clear();
        }

        public void DibujarMarco()
        {
            for (int i = PuntoLimiteSuperior.X; i <= PuntoLimiteInferior.X; i++)
            {
                Console.SetCursorPosition(i, PuntoLimiteSuperior.Y);
                Console.Write("═");
                Console.SetCursorPosition(i, PuntoLimiteInferior.Y);
                Console.Write("═");
            }
            for (int i = PuntoLimiteSuperior.Y; i <= PuntoLimiteInferior.Y; i++)
            {
                Console.SetCursorPosition(PuntoLimiteSuperior.X,i);
                Console.Write("║");
                Console.SetCursorPosition(PuntoLimiteInferior.X,i);
                Console.Write("║");
            }
            Console.SetCursorPosition(PuntoLimiteSuperior.X,PuntoLimiteSuperior.Y);
            Console.Write("╔");
            Console.SetCursorPosition(PuntoLimiteSuperior.X,PuntoLimiteInferior.Y);
            Console.Write("╚");
            Console.SetCursorPosition(PuntoLimiteInferior.X, PuntoLimiteSuperior.Y);
            Console.Write("╗");
            Console.SetCursorPosition(PuntoLimiteInferior.X, PuntoLimiteInferior.Y);
            Console.Write("╝");
        }
    }
}
