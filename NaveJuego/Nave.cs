using NaveJuego.Singleton;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NaveJuego
{
    internal class Nave
    {
        public float Vida { get; set; }
        public Point Posicion { get; set; }
        public ConsoleColor Color { get; set; }
        public Ventana VentanaC { get; set; }
        public List<Point> Posiciones { get; set; }

        public Nave(Point posicion, Ventana ventana, ConsoleColor color = ConsoleColor.White)
        {
            Posicion = posicion;
            Color = color;
            VentanaC = ventana;
            Vida = 100;
            Posiciones = new List<Point>();
        }

        public void Dibujar()
        {
            Console.ForegroundColor = Color;
            int x = Posicion.X;
            int y = Posicion.Y;

            Console.SetCursorPosition(x + 3, y);
            Console.Write("A");
            Console.SetCursorPosition(x + 1, y + 1);
            Console.Write("<{X}>");
            Console.SetCursorPosition(x, y + 2);
            Console.Write("± W W ±");

            List<Point> pointsNave = new List<Point>{
                 new Point(x + 3, y)//A
                ,new Point(x + 1, y + 1)//<
                ,new Point(x + 2, y + 1)//{
                ,new Point(x + 3, y + 1)//X
                ,new Point(x + 4, y + 1)//}
                ,new Point(x + 5, y + 1)//>
                ,new Point(x, y + 2)//±
                ,new Point(x + 2, y + 2)//w
                ,new Point(x + 4, y + 2)//w
                ,new Point(x + 6, y + 2)//±
            };

            for (int i = 0; i < pointsNave.Count; i++)
            {
                SectorSG.SetSector(pointsNave[i], Posiciones.Count > 0 ? Posiciones[i] : new Point(1,1));
            }
            Posiciones = pointsNave;
        }//end Dibujar

        private void Borrar()
        {
            foreach (var item in Posiciones)
            {
                Console.SetCursorPosition(item.X,item.Y);
                Console.Write(" ");
            }
        }//end Borrar

        private void Teclado(ref Point distancia, int velocidad)
        {
            
            ConsoleKeyInfo tecla = Console.ReadKey(true);
            switch (tecla.Key)
            {
                case ConsoleKey.A:
                    distancia = new Point(-1,0); 
                    break;
                case ConsoleKey.D:
                    distancia = new Point(1, 0);
                    break;
                case ConsoleKey.W:
                    distancia = new Point(0, -1);
                    break;
                case ConsoleKey.S:
                    distancia = new Point(0,1);
                    break;
            }//end switch
            distancia.X *= velocidad;
            distancia.Y *= velocidad;
        }
        public void Mover(int velocidad)
        {
            if (Console.KeyAvailable)
            {
                Point distancia = new Point();
                Teclado(ref distancia, velocidad);
                Coliciones(distancia);
                Borrar();
                Dibujar();
            }
        }

        public void Coliciones(Point distancia)
        {
            Point PosicionAux = new Point(distancia.X + Posicion.X, distancia.Y + Posicion.Y);
            if (PosicionAux.X <= VentanaC.PuntoLimiteSuperior.X)
                PosicionAux.X  = VentanaC.PuntoLimiteSuperior.X + 1;
            if (PosicionAux.X + 6 >= VentanaC.PuntoLimiteInferior.X)
                PosicionAux.X = VentanaC.PuntoLimiteInferior.X - 7;
            if (PosicionAux.Y <= VentanaC.PuntoLimiteSuperior.Y)
                PosicionAux.Y = VentanaC.PuntoLimiteSuperior.Y + 1;
            if (PosicionAux.Y + 2 >= VentanaC.PuntoLimiteInferior.Y)
                PosicionAux.Y = VentanaC.PuntoLimiteInferior.Y - 3;

            Posicion = PosicionAux;
        }
    }
}
