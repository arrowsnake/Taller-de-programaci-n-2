using System;

namespace Ejercicio3
{
    internal class HighScores
    {
        private string[] iJugadores = new string[5];
        private double[] iTiempos = new double[5];

        public void Inicializar() // valores por default
        {
            string[] mJugadores = {"Paul", "John", "Kevin", "Bruno", "Charlie"};
            this.iJugadores = mJugadores;
            double[] mTiempos = { 30, 45, 60, 75, 90 };
            this.iTiempos = mTiempos;
        }

        public void Mostrar()
        {
            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine("Puesto: {0}   Jugador: {1}    Tiempo: {2} segundos", i+1, iJugadores[i], iTiempos[i]);
            }
        }

        public bool ObtenerHighScore(Partida pPartida)  //obtiene la duracion de la partida y el nombre del jugador
        {                                               //si esta duracion es menor a alguno de los highscores, tomara su lugar y desplazara a los demas, deshaciendonos del ultimo
            bool mHighScore = false;
            string mJugador = pPartida.Jugador;
            double mDuracion = pPartida.Duracion;
            for (int i = 0; i < 5; i++)
            {
                if (iTiempos[i] > mDuracion)
                {
                    string mJugadorAux = mJugador;
                    double mDuracionAux = mDuracion;
                    mJugador = iJugadores[i];
                    mDuracion = iTiempos[i];
                    iJugadores[i] = mJugadorAux;
                    iTiempos[i] = mDuracionAux;
                    mHighScore = true;
                }
            }
            return mHighScore;
        }
    }
}