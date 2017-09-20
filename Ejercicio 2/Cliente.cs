namespace Ejercicio2
{
    public enum TipoDocumento { DNI, CUIT, CUIL, LE, LC };          //aquí enumero los tipos de documentos que luego serán utilizados

    public class Cliente
    {
        private int iNroDocumento;
        private string iNombre;
        private TipoDocumento iTipoDocumento;

        public Cliente(TipoDocumento pTipoDocumento, int pNroDocumento, string pNombre) //constructor del cliente con 3 parametros
        {
            this.iTipoDocumento = pTipoDocumento;
            this.iNroDocumento = pNroDocumento;
            this.iNombre = pNombre;
        }

        public TipoDocumento tipoDocumento      //propiedad del tipo de documento
        {
            get { return this.iTipoDocumento; }
            set { this.iTipoDocumento = value; }
        }

        public string nombre                    //propiedad del nombre
        {
            get { return this.iNombre; }
            set { this.iNombre = value; }
        }

        public int nroDocumento                 //propiedad del número
        {
            get { return this.iNroDocumento; }
            set { this.iNroDocumento = value; }
        }
    }
}