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
    public partial class matriz_adyacencia : Form
    {
        List<Nodo> grafo = new List<Nodo>();//LISTA DE NODOS
        public matriz_adyacencia()
        {
            InitializeComponent();
        }
        public matriz_adyacencia(List<Nodo> gr)
        {
            InitializeComponent();
            grafo = gr;
        }

        private void matriz_adyacencia_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 0;
            dataGridView1.ColumnCount = grafo.Count;
            dataGridView1.RowCount = 1; //SIEMPRE HAY UNO
            dataGridView1.RowCount = grafo.Count;
            for(int i=0;i<grafo.Count;i++)
            {
                dataGridView1.Columns[i].Name = i.ToString();//PONGO EL NOMBRE DE LA COLUMNA
               
            }

            for (int i = 0; i < grafo.Count; i++)
            {
                for (int j = 0; j < grafo.Count; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = 0; //INICIALIZAMOS EN CERO
                }
            }

            for (int i = 0; i < grafo.Count; i++)
             {
                 for(int j = 0; j < grafo[i].aristas.Count(); j++)
                 {
                     dataGridView1.Rows[i].Cells[grafo[i].aristas[j].getDestino()].Value = 1; //RECORREMOS EL GRAFO Y AL QUE LE LLEGUE ALGO LE PONE UN 1 DE RELACION
                 }
             }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
