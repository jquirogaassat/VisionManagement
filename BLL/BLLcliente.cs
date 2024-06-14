using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLcliente : BE.ICRUd<BE.BEcliente>
    {
          
        DAL.DALcliente clienteDal = new DAL.DALcliente();
        BLL.BLLencriptacion encriptar = new BLL.BLLencriptacion();
        public bool Alta(BEcliente item)
        {            
            item.Telefono = encriptar.encriptarAES(item.Telefono);
            item.Direccion = encriptar.encriptarAES(item.Direccion);
            item.Localidad = encriptar.encriptarAES(item.Localidad);
            DAL.DALcliente clientedal = new DAL.DALcliente();
            return clientedal.Alta(item);
        }

        public bool Baja(BEcliente item)
        {
            //DAL.DALcliente dALcliente = new DAL.DALcliente();
            //return dALcliente.Baja(item);
            //throw new NotImplementedException();
            return clienteDal.Baja(item);
        }

        public IList<BEcliente> Listar(BEcliente item)
        {
            throw new NotImplementedException();
        }

        public List<BEcliente> Listar()
        {  
            List<BEcliente> lista = new List<BEcliente>();
            lista = clienteDal.Listar();
            int i = 0; 
            while(i< lista.Count)
            {
                lista[i] = Desencriptar(lista[i]);
                i++;
            }
            return lista;
            //throw new NotImplementedException();
        }

        public BE.BEcliente Desencriptar(BE.BEcliente clienteBE)
        {
            clienteBE.Telefono = encriptar.desencriptarAes(clienteBE.Telefono);
            clienteBE.Direccion = encriptar.desencriptarAes(clienteBE.Direccion);
            clienteBE.Localidad = encriptar.desencriptarAes(clienteBE.Localidad);
            return clienteBE;
        }

        

        public bool Modificar(BEcliente item)
        {
            item.Telefono = encriptar.encriptarAES(item.Telefono);
            item.Direccion = encriptar.encriptarAES(item.Direccion);
            item.Localidad = encriptar.encriptarAES(item.Localidad);
            return clienteDal.Modificar(item);
            //throw new NotImplementedException();
        }

        public IList<BEcliente> Lista()
        {
            throw new NotImplementedException();
        }

        public DataTable CargarInforme()
        {
            return clienteDal.CargarInforme();
        }
    }
}
