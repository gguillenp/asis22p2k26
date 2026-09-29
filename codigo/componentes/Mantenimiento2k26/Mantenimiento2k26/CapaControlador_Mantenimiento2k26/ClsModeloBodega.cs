using System.Data;
using CapaModelo_Mantenimiento2k26;

namespace CapaControlador_Mantenimiento2k26
{
    public class ClsModeloBodega
    {
        private readonly ClsRepositorioBodega _RepositorioBodega = new ClsRepositorioBodega();

        public DataTable MantenimientoMetObtenerBodegasReporte()
        {
            return _RepositorioBodega.MantenimientoMetObtenerBodegasReporte();
        }
    }
}
