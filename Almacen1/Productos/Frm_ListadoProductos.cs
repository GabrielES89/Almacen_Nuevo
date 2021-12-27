﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen1.Productos
{
    public partial class Frm_ListadoProductos : Form
    {
        // Formas
        Productos.Frm_Productos_Editar FormaProductosEditar;
        Productos.Frm_Productos_Nuevo FormaProductosNuevo = new Frm_Productos_Nuevo();

        // Clases
        Class.Cls_Productos ObjProductos = new Class.Cls_Productos();


        // Datatable
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();

        public Frm_ListadoProductos()
        {
            InitializeComponent();
        }
        void Carga()
        {
            dt1.Clear();
            dt2.Clear();
            ObjProductos._consult_Productos(dt1);
            dt2 = dt1.Copy();
            dt2.Columns.Remove("id");
            DGV1.DataSource = dt2;
            this.Invoke(new Action(() => DGV1.Columns["Editar"].DisplayIndex = DGV1.Columns.Count - 1));
            this.Invoke(new Action(() => DGV1.Columns["Borrar"].DisplayIndex = DGV1.Columns.Count - 1));
            for (int i = 0; i < DGV1.Rows.Count; i++)
            {
                if (DGV1[9, i].Value.ToString() == "Disponible")
                {
                    DGV1[9, i].Style.ForeColor = Color.Green;
                }
                else
                {
                    DGV1[9, i].Style.ForeColor = Color.Red;
                }
            }
        }
        private void Frm_ListadoProductos_Load(object sender, EventArgs e)
        {
            Carga();
        }
        void Nuevo()
        {
            FormaProductosNuevo.DelegadoActualizar = Carga;
            FormaProductosNuevo.ShowDialog();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
        void EditarEmpleados(int Id)
        {
            FormaProductosEditar = new Productos.Frm_Productos_Editar(Id, dt1);
            FormaProductosEditar.DelegadoActualizar = Carga;
            FormaProductosEditar.ShowDialog();
        }

        void Borrar_Producto(int Fila)
        {
            if (MessageBox.Show("¿Desea borrar el producto " + dt2.Rows[Fila][0].ToString() + "?", "Borrar producto", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ObjProductos._delete(dt1.Rows[Fila][0].ToString());
            }
            Carga();
        }

        private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 0)
                {
                    EditarEmpleados(e.RowIndex);
                }
                if (e.ColumnIndex == 1)
                {
                    Borrar_Producto(e.RowIndex);
                }
            }
        }
    }
}
