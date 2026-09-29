using System;
using System.Data.Odbc;

namespace CapaModelo_Mantenimiento2k26
{
    public abstract class ClsConexion
    {
        protected readonly string _ConnectionString;

        public ClsConexion()
        {
            _ConnectionString = "Dsn=EmbutidosS.A";
        }

        protected OdbcConnection MantenimientoMetObtenerConexion()
        {
            return new OdbcConnection(_ConnectionString);
        }

        public void MantenimientoMetDesconexion(OdbcConnection ConexionOdbc)
        {
            try
            {
                ConexionOdbc.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No se desconecto");
            }
        }
    }
}
