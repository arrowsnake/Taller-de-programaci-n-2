namespace EJ3._0
{
    /// <summary>
    /// Clase que controla en resultado de la ultima jugada en una partida
    /// </summary>
    internal class ResultadoJugada
    {
        private string iPalabraActual;
        private bool iExito;

        /// <summary>
        /// Property get y set de PalabraActual
        /// </summary>
        public string PalabraActual
        {
            get { return this.iPalabraActual; }
            set { this.iPalabraActual = value; }
        }

        public bool Exito
        {
            get { return this.iExito; }
            set { this.iExito = value; }
        }
    }
}