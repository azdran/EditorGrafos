using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorGrafos
{
    public partial class matrizPeso : Form
    {

        List<Nodo> grafo = new List<Nodo>();

        public matrizPeso()
        {
            InitializeComponent();
        }

  
        public matrizPeso(List<Nodo> gr)
        {
            InitializeComponent();
            grafo = gr;
        }

        private void matrizPeso_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 0;
            dataGridView1.ColumnCount = grafo.Count;
            dataGridView1.RowCount = 1;
            dataGridView1.RowCount = grafo.Count;
            for (int i = 0; i < grafo.Count; i++)
            {
                dataGridView1.Columns[i].Name = i.ToString();
            }

            for (int i = 0; i < grafo.Count; i++)
            {
                for (int j = 0; j < grafo.Count; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = 0;
                }
            }

            for (int i = 0; i < grafo.Count; i++)
            {
                for (int j = 0; j < grafo[i].aristas.Count(); j++)
                {
                    dataGridView1.Rows[i].Cells[grafo[i].aristas[j].getDestino()].Value = grafo[i].aristas[j].getPeso();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
