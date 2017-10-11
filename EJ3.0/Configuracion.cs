namespace EJ3._0
{
    internal class Configuracion
    {
        /// <summary>
        /// Clase que controla la cantidad de Fallos para perder una Partida
        /// </summary>
        private int iFallos;

        /// <summary>
        /// Inicializador de Configuracion
        /// </summary>
        public Configuracion()
        {
            Fallos = 10;
        }

        /// <summary>
        /// Property get y set de Fallos
        /// </summary>
        public int Fallos
        {
            get { return this.iFallos; }
            set { this.iFallos = value; }
        }

        /// <summary>
        /// Funcion que resta un fallo de la cantidad actual
        /// </summary>
        public void RestarFallo()
        {
            Fallos--;
        }
    }
}