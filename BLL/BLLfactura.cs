﻿using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLfactura
    {
        DAL.DALfactura _facturadal= new DAL.DALfactura();

        //alta de factura
     
        public int AddPrueba(BEfactura facAlta)
        {
            return _facturadal.AddPrueba(facAlta);
        }

        //baja de factura
        public bool Delete(BEfactura facDel) 
        {
            return _facturadal.Delete(facDel);        
        }

        //traigo todas las facturas
        public IList<BEfactura> GetAll()
        {
            return _facturadal.GetAll();
        }
        // traigo la factura segun id de cliente
        public List<BEfactura> SellectAllByIdCliente(BEfactura factura)
        {
            return _facturadal.SellectAllByIdCliente(factura);
        }
        //traigo la factura segun id de factura
        public BEfactura GetById(BEfactura factura)
        {
            return _facturadal.GetAllById(factura);
        }

        public DataTable CargarReporte()
        {
            return _facturadal.CargarReporte();
        }
    }
}
