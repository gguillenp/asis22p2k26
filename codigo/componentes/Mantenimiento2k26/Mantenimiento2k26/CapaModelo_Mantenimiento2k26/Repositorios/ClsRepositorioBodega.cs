using System.Data;
using System.Data.Odbc;

namespace CapaModelo_Mantenimiento2k26
{
    public class ClsRepositorioBodega : ClsConexion
    {
        private const string _SelectReporte =
            "SELECT codigo_bodega, nombre_bodega, estatus_bodega FROM tblBodegas ORDER BY nombre_bodega";

        public DataTable MantenimientoMetObtenerBodegasReporte()
        {
            DataTable Tabla = new DataTable("Bodegas");
            using (OdbcConnection Conexion = MantenimientoMetObtenerConexion())
            using (OdbcDataAdapter Adaptador = new OdbcDataAdapter(_SelectReporte, Conexion))
            {
                Adaptador.Fill(Tabla);
            }
            return Tabla;
        }
    }
}
