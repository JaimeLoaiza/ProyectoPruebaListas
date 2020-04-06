using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Lista
{
    public partial class Form1 : Form
    {
        List<int> Milista = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            int n;
            n = int.Parse(txtvaloragregar.Text);
            Milista.Add(n);
            txtvaloragregar.Clear();
            txtvaloragregar.Focus();
            MessageBox.Show("EL VALOR FUE AGREGADO EXITOSAMENTE");
        }
        private void btninsertar_Click(object sender, EventArgs e)
        {
            int n, pos;
            n = int.Parse(txtvaloragregar.Text);
            pos = int.Parse(txtposicion.Text);
            Milista.Insert(pos, n);
            txtvaloragregar.Clear();
            txtvaloragregar.Focus();
            txtposicion.Clear();
            txtposicion.Focus();
            MessageBox.Show("EL VALOR FUE INSERTADO EXITOSAMENTE");
        }
        private void btneliminarde_Click(object sender, EventArgs e)
        {
            int pos;
            pos = int.Parse(txtposicion.Text);
            txtposicion.Clear();
            txtposicion.Focus();
            Milista.RemoveAt(pos);
        }
        private void btneliminar_Click(object sender, EventArgs e)
        {
            int n;
            n = int.Parse(txtvaloragregar.Text);
            Milista.Remove(n);
            txtvaloragregar.Clear();
            txtvaloragregar.Focus();
        }
        private void btnmostrar_Click(object sender, EventArgs e)
        {
            int i;
            LISTA.Items.Clear();
            for (i = 0; i <= Milista.Count-1; i++)
            {
                LISTA.Items.Add(Milista.ElementAt(i));
            }
        }
    }
}
