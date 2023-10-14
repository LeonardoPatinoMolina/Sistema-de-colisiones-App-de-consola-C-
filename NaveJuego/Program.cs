using NaveJuego;
using System.Drawing;

Ventana ventana;
Nave nave;
bool jugar = true;
void Init()
{
    //instanciamos la ventana
    ventana = new Ventana(ancho: 150,
                             alto: 40,// tamanio de pantalla
                             color: ConsoleColor.Black,
                             puntoSuperior: new Point(5, 5),
                             puntoInferior: new Point(130, 35));// tamanio de tablero
    nave = new Nave(posicion: new Point(30,15), 
                    ventana: ventana);

    ventana.DibujarMarco();
    nave.Dibujar();
}

void Game()
{
    while (jugar)
    {
        nave.Mover(1);
    }
}

Init();
Game(); 
