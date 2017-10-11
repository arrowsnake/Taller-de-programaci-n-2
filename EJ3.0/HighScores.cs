using System;

namespace EJ3._0
{
    /// <summary>
    /// Clase que se encarga de guardar y mostrar las 5 partidas de mejor tiempo
    /// </summary>
    internal class HighScores
    {
        private string[] iJugadores = new string[5];
        private double[] iTiempos = new double[5];

        /// <summary>
        /// Inicializador de los highscores al iniciar el programa
        /// </summary>
        public void Inicializar() // valores por default
        {
            string[] mJugadores = {"Paul", "John", "Kevin", "Bruno", "Charlie"};
            this.iJugadores = mJugadores;
            double[] mTiempos = { 30, 45, 60, 75, 90 };
            this.iTiempos = mTiempos;
        }

        /// <summary>
        /// Procedimiento que muestra cada Partida de los highscores con puesto, jugador y tiempo en segundos
        /// </summary>
        public void Mostrar()
        {
            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine("Puesto: {0}   Jugador: {1}    Tiempo: {2} segundos", i+1, iJugadores[i], iTiempos[i]);
            }
        }

        /// <summary>
        /// Procedimiento que obtiene la duracion de la partida y el nombre del jugador
        /// Si esta duracion es menor a alguno de los highscores, tomara su lugar y desplazara a los demas, deshaciendose del ultimo
        /// </summary>
        /// <param name="pPartida"></param>
        /// <returns></returns>
        public bool ObtenerHighScore(Partida pPartida)  
        {                                               
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