using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace DAL
{
    public class DALprestamo
    {
        SqlHelper _sqlHelper;
        DALdigitoverificador _dvdal;
        DALherramientas _herramientaD = new DALherramientas();
        Mappers.MPprestamo mapper= new Mappers.MPprestamo();


        public bool Alta(BEprestamo prestamo)
        {
            _sqlHelper= new SqlHelper();
            _dvdal= new DALdigitoverificador();
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@idHerramienta",prestamo.Herramienta.Id),
                new SqlParameter("@idCliente",prestamo.Cliente.IdCliente),
                new SqlParameter("@fechaInicio",prestamo.FechaInicio),
                new SqlParameter("@fechaDevolucion",prestamo.FechaDevolucion),
                new SqlParameter("@observaciones",prestamo.Observaciones)
            };

            int nuevoID = _sqlHelper.ExecuteQueryPRUEBA("prestamoInsert", parametros);
            int dvh = _dvdal.CalcularDVH(consultarPrestamoDT(nuevoID), 0);
            _dvdal.CargarDVH("Prestamo",nuevoID,dvh);
            int dvv = _dvdal.CalcularDVV("Prestamo");
            _dvdal.CargarDVV(7, dvv);

            parametros = new SqlParameter[]
            {
                new SqlParameter("@idHerramienta",prestamo.Herramienta.Id),
                new SqlParameter("@idEstado", 2),
                new SqlParameter("fecha",prestamo.FechaInicio),
            };

            nuevoID = _sqlHelper.ExecuteQueryPRUEBA("herramientaEstadoInsert", parametros);

            dvh= _dvdal.CalcularDVH(_herramientaD.ConsultarHerramientaEstadoDT(nuevoID), 0);
            _dvdal.CargarDVHp("Estado_Herramienta",nuevoID,dvh);
            dvv = _dvdal.CalcularDVVp("Estado_Herramienta");

            return _dvdal.CargarDVV(9, dvv);
        }


        public List<BEprestamo> Consultar()
        {
            _sqlHelper = new SqlHelper();
            SqlParameter[] parametros = new SqlParameter[]
            {};
            DataTable dt = _sqlHelper.ExecuteReader("prestamoSelect", parametros);
            List<BEprestamo> prestamos = new List<BEprestamo>();
            Mappers.MPprestamo mapper = new Mappers.MPprestamo();
            
             foreach(DataRow row in dt.Rows)
            {
                prestamos.Add(mapper.Map(row));
            }
             
            return prestamos;
        }

        public BEprestamo ConsultarPrestamo(int idPrestamo)
        {
            _sqlHelper = new SqlHelper();
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("idPrestamo",idPrestamo),
            };

            DataTable dt = _sqlHelper.ExecuteReader("prestamosConsultarPorID",parametros);

            BEprestamo prestamo = mapper.Map(dt.Rows[0]);
            return prestamo;
        }

        public DataTable consultarPrestamoDT(int idPrestamo)
        {
            _sqlHelper = new SqlHelper();
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("idPrestamo",idPrestamo),
            };

            DataTable dt = _sqlHelper.ExecuteReader("prestamoConsultar", parametros);
            return dt;

        }
    }
}
