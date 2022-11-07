using BE;
using Infraestructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALbitacora : BE.ICRUd<BE.BEgestionbitacora>
    {

        DAL.SqlHelper sqlHelper = new SqlHelper();
        public bool Alta(BEgestionbitacora itemAlta)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("idPatente",itemAlta.idPatente),
                new SqlParameter("idUsuario",itemAlta.IdUsuario),
                new SqlParameter("fechaHora",itemAlta.FechaHora),
                new SqlParameter("nivelCriticidad",itemAlta.Criticidad),
                new SqlParameter("descripcion",itemAlta.Descripcion),
            };


            int idNuevo = sqlHelper.ExecuteQueryPRUEBA("bitacoraInserts", parameters);

            DAL.DALdigitoverificador dvDal = new DALdigitoverificador();

            int dvh = dvDal.CalcularDVH(ConsultarBitacoraDt(idNuevo), 0);
            dvDal.CargarDVH("BITACORA", idNuevo, dvh);
            int dvv = dvDal.CalcularDVV("BITACORA");
            return dvDal.CargarDVV(1, dvv);
        }


        public DataTable ConsultarBitacoraDt(int idBitacora)
        {
            SqlHelper sqlHelper= new SqlHelper();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("idBItacora",idBitacora),
            };

            DataTable data = sqlHelper.ExecuteReader("bitacoraConsultarPorId", parameters);
            return data;
        }


        public List<BE.BEgestionbitacora> Consulta (DateTime fechaDesde, DateTime fechaHasta, BE.BEusuario usuario, string orden, string criticidad)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("idUsuario",usuario.idUsuario),
                new SqlParameter("fechaDesde",fechaDesde),
                new SqlParameter("fechaHasta",fechaHasta),
                new SqlParameter("nivelCriticidad",criticidad),
                new SqlParameter("orden",orden),
            };

            DataTable data = sqlHelper.ExecuteReader("bitacoraConsultar", parameters);
            List<BE.BEgestionbitacora> bitacora = new List<BEgestionbitacora>();
            Mappers.MPbitacora mapp = new Mappers.MPbitacora();

            foreach(DataRow row in data.Rows)
            {
                bitacora.Add(mapp.Map(row));
            }
            return bitacora;
        }


        public List<BE.BEgestionbitacora>Consulta()
        {
            SqlParameter[] parameters = new SqlParameter[]
                {};

            DataTable data = sqlHelper.ExecuteReader("consultarBitacora", parameters);
            List<BE.BEgestionbitacora> bitacoras = new List<BEgestionbitacora>();
            Mappers.MPbitacora mapp = new Mappers.MPbitacora();
            foreach(DataRow row in data.Rows)
            {
                bitacoras.Add(mapp.Map(row));
            }
            return bitacoras;
        }

        public bool Baja(BEgestionbitacora itemBaja)
        {
            throw new NotImplementedException();
        }

        public IList<BEgestionbitacora> Listar()
        {
            throw new NotImplementedException();
        }

        public bool Modificar(BEgestionbitacora itemModifica)
        {
            throw new NotImplementedException();
        }
    }
}
