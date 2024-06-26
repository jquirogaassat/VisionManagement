﻿using SpreadsheetLight;
using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Spreadsheet;
//using ClosedXML.Excel;


namespace VisionTFI
{
    public partial class Inicio : Form
    {
      
        public Inicio()
        {
            InitializeComponent();

            int i = 0;
            while (i< 3000)
            {
                i++;
            }

            i = 3000;

            while (i<6000)
            {
                i++;
            }

            i = 6000;

            while(i<10000)
            {
                i++;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {              
            MessageBox.Show(" Digitos arreglados!");
            Globa.menuPrincipal.Show();
            this.Hide();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            this.Focus();
            dgv_errores.DataSource = Globa.errores;
            dgv_errores.RowHeadersVisible = false;
            dgv_errores.AllowUserToAddRows = false;
            dgv_errores.AllowUserToDeleteRows = false;
            dgv_errores.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_errores.MultiSelect = false;
            dgv_errores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv_errores.Columns[0].HeaderText = "ID ERROR";
            dgv_errores.Columns[0].Visible = false;
            dgv_errores.Columns[1].HeaderText = "TABLA";
            dgv_errores.Columns[2].HeaderText = "TIPO DE ERROR";
            dgv_errores.Columns[3].HeaderText = "ID DEL ERROR";

            dgv_errores.Show();

           // ExportarToExcel(Globa.errores);
           // label2.Text = "Administrador";
        }

        //public void ExportarToExcel(List<BEerror> errores)
        //{
        //    using (var workbook = new XLWorkbook())
        //    {
        //        var worksheet = workbook.Worksheets.Add("Errores");
        //        int fila = 1;

        //        worksheet.Cell(fila, 1).Value = "idError";
        //        worksheet.Cell(fila, 2).Value = "tabla";
        //        worksheet.Cell(fila, 3).Value = "tipoError";
        //        worksheet.Cell(fila, 4).Value = "id";

        //        foreach (BEerror error in errores)
        //        {
        //            fila++;
        //            worksheet.Cell(fila, 1).Value = error.idError;
        //            worksheet.Cell(fila, 2).Value = error.tabla;
        //            worksheet.Cell(fila, 3).Value = error.tipoError;
        //            worksheet.Cell(fila, 4).Value = error.id;
        //        }

        //        workbook.SaveAs(@"C:\Users\Usuario\Desktop\ErroresBitacora.xlsx");
        //    }
        //}


        //public void exportarToExcel2(List<BEerror> errores)
        //{
        //    SLDocument sl = new SLDocument();

        //    sl.RenameWorksheet(SLDocument.DefaultFirstSheetName, "Algo");
        //    int fila = 1;

        //    sl.SetCellValue("A" + fila, "idError");
        //    sl.SetCellValue("B" + fila, "tabla");
        //    sl.SetCellValue("C" + fila, "tipoError");
        //    sl.SetCellValue("D" + fila, "id");

        //    foreach (BEerror error in errores)
        //    {
        //        fila++;
        //        sl.SetCellValue("A" + fila, error.idError);
        //        sl.SetCellValue("B" + fila, error.tabla);
        //        sl.SetCellValue("C" + fila, error.tipoError);
        //        sl.SetCellValue("D" + fila, error.id);
        //    }

        //    sl.SaveAs(@"C:\Users\Usuario\Desktop\ErroresBitacora.xlsx");
      
        //}

        private void btn_restore_Click(object sender, EventArgs e)
        {
            Globa.restore.Show();
            this.Hide();

        }
    }
}
