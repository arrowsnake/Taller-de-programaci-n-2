namespace Ejercicio2
{
    /// <summary>
    /// aquí enumero los tipos de documentos que el cliente podrá elegir para registrarse
    /// </summary>
    public enum TipoDocumento { DNI, CUIT, CUIL, LE, LC };          

    /// <summary>
    /// esta clase se encarga de crear un cliente al que se le asignarán un nombre, tipo de documento y número del mismo (datos del cliente)
    /// </summary>
    public class Cliente
    {
        private int iNroDocumento;
        private string iNombre;
        private TipoDocumento iTipoDocumento;

        /// <summary>
        /// constructor de la clase "Cliente" con 3 parametros
        /// </summary>
        /// <param name="pTipoDocumento">
        /// de tipo enum, que será asignado a iTipoDocumento
        /// </param>
        /// <param name="pNroDocumento">
        /// de tipo int, que será asignado a iNroDocumento
        /// </param>
        /// <param name="pNombre">
        /// de tipo string, que será asignado a iNombre
        /// </param>
        public Cliente(TipoDocumento pTipoDocumento, int pNroDocumento, string pNombre)
        {
            this.iTipoDocumento = pTipoDocumento;
            this.iNroDocumento = pNroDocumento;
            this.iNombre = pNombre;
        }

        /// <summary>
        /// property de tipoDocumento (que será asignado dependiendo del tipo un número luego)
        /// </summary>
        public TipoDocumento tipoDocumento      
        {
            get { return this.iTipoDocumento; }
            set { this.iTipoDocumento = value; }
        }

        /// <summary>
        /// property de nombre (nombre del cliente agregado)
        /// </summary>
        public string nombre                    
        {
            get { return this.iNombre; }
            set { this.iNombre = value; }
        }

        /// <summary>
        /// property de nroDocumento (número que se le asigna al cliente agregado dependiendo el tipo de documento elegido) 
        /// </summary>
        public int nroDocumento                 
        {
            get { return this.iNroDocumento; }
            set { this.iNroDocumento = value; }
        }
    }
}