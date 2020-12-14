using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using InputKey;

namespace EditorGrafos
{
    public partial class Form1 : Form
    {
        List<Nodo> nodos = new List<Nodo>();
        //List<Nodo> nodos2 = new List<Nodo>();
        int bandera; //cual opcion elegi
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void moverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bandera = 2;
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bandera = 3;
        }

        private void dirigidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bandera = 4;
        }

        private void noDirigidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bandera = 5;
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bandera = 6;
        }
        Graphics dibujo;
        public void dibuja()
        {   
            List<Nodo> aux = new List<Nodo>(); //Crea la lista de nodos 
            aux = nodos; //para hacer pruebas
            //s declara area de dibujo
            if (dibujo != null)
            {
                dibujo.Clear(Color.Aqua); //color de mi pantalla grafo 1
            }
            
            //crea los Nodos en Pantalla 
            dibujo = this.pictureBox1.CreateGraphics(); //trabajar en el 1er picture box
            Font fonnt1 = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
            for (int i = 0; i < aux.Count(); i++)
            {
                float xletra = (float)aux[i].getX() + 15; //coord de identificador de nodo
                float yletra = (float)aux[i].getY() + 15;
                dibujo.FillEllipse(Brushes.Pink, aux[i].getX(), aux[i].getY(), 40, 40); //dibuja nodo
                dibujo.DrawString(aux[i].getnombre().ToString(), fonnt1, Brushes.Purple, xletra, yletra);//dibuja identif de nodo

            }
            for (int i = 0; i < aux.Count(); i++)
            {
                if (aux[i].aristas != null) //si hay aristas 
                {
                    for (int j = 0; j < aux[i].aristas.Count(); j++)
                    {
                        if (aux[i].aristas[j].getTipo() == 0)//aristas dirigidas
                        {


                            Pen pen = new Pen(Color.Black, 3);
                            pen.EndCap = LineCap.ArrowAnchor; //endCap es hacer la flecha
                            float xletra = Math.Abs(((float)nodos[aux[i].aristas[j].getOrigen()].getX() + (float)nodos[aux[i].aristas[j].getDestino()].getX())/2);//donde empieza a dibujarla
                            float yletra = Math.Abs(((float)nodos[aux[i].aristas[j].getOrigen()].getY() + (float)nodos[aux[i].aristas[j].getDestino()].getY())/2);
                            dibujo.DrawLine(pen, aux[aux[i].aristas[j].getOrigen()].getX() + 20, aux[aux[i].aristas[j].getOrigen()].getY() + 20, 
                                aux[aux[i].aristas[j].getDestino()].getX() + 20, aux[aux[i].aristas[j].getDestino()].getY() + 20);
                            dibujo.DrawString(aux[i].aristas[j].getPeso().ToString(), fonnt1, Brushes.Purple, xletra, yletra) ;
                           
                            
                        }
                        else if (aux[i].aristas[j].getTipo() == 1)//aristas no dirigidas
                        {
                            Pen pen = new Pen(Color.Black, 3);
                            float xletra = Math.Abs(((float)nodos[aux[i].aristas[j].getOrigen()].getX() + (float)nodos[aux[i].aristas[j].getDestino()].getX())/2);//donde empieza a dibujarla
                            float yletra = Math.Abs(((float)nodos[aux[i].aristas[j].getOrigen()].getY() + (float)nodos[aux[i].aristas[j].getDestino()].getY())/2);
                            dibujo.DrawLine(pen, aux[aux[i].aristas[j].getOrigen()].getX() + 20, aux[aux[i].aristas[j].getOrigen()].getY() + 20, 
                                aux[aux[i].aristas[j].getDestino()].getX() + 20, aux[aux[i].aristas[j].getDestino()].getY() + 20);
                            dibujo.DrawString(aux[i].aristas[j].getPeso().ToString(), fonnt1, Brushes.Purple, xletra, yletra);
                        }
                    }
                }
            }
        }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        int cordx = new int();//aun no la utilizo
        int cordy = new int();
        bool binicio = false; //seleccionar nodo de inicio
        bool bfinal = false;  //seleccionar nodo de final 
        int inicio = 10000; //no se le ha dado clic a nada
        public void acciones1() //picturebox1
        {
            int eliminar = 1000; //ningun noodo ha sido seleccionado para eliminar
            if (bandera == 1) //trabajar en el picture box 1
            {
                Nodo nod = new Nodo(); 
                nod.llenaNodo(cordx - 20, cordy - 20);
                nod.llenanombre(nodos.Count()); //identificador de nodo, nodos.Count es para darle secuencia 1234
                nodos.Add(nod); //ir agregando a la lista
                dibuja();//crea un nodo 
            }
            
            if (bandera == 2) //mover
            {
                dibuja();
            }
            if (bandera == 3) //eliminar
            {
                for (int i = 0; i < nodos.Count(); i++)
                {
                    if (cordx > nodos[i].getX() - 40 && cordx < nodos[i].getX() + 40 && cordy > nodos[i].getY() - 40 && cordy < nodos[i].getY() + 40) //checar el que toco
                    {
                        eliminar = i; //guarda el seleccionado
                    }
                }
                if (eliminar != 1000) //checa el nodo seleeccionado
                {
                    nodos.RemoveAt(eliminar); //elimina el seleccionado
                    dibuja();
                }
            }
            if (bandera == 4) //arista dirigida
            {
                for (int i = 0; i < nodos.Count(); i++)
                {
                    if (cordx > nodos[i].getX() - 40 && cordx < nodos[i].getX() + 40 && cordy > nodos[i].getY() - 40 && cordy < nodos[i].getY() + 40)
                    {
                        inicio = i; //el nodo que toque primero lo guardo
                        binicio = true; //ya se toco el punto de inicio

                    }
                }
                if (bfinal == true && binicio == true)//ya toque dos nodos
                {
                    dibuja();//dibujar arista
                    bfinal = false; 
                    binicio = false;
                }
            }
            if (bandera == 5) //arista no dirigida
            {
                for (int i = 0; i < nodos.Count(); i++)
                {
                    if (cordx > nodos[i].getX() - 40 && cordx < nodos[i].getX() + 40 && cordy > nodos[i].getY() - 40 && cordy < nodos[i].getY() + 40)
                    {
                        inicio = i;
                        binicio = true; //ya se toco el punto de inicio

                    }
                }
                if (bfinal == true && binicio == true)
                {
                    dibuja();
                    bfinal = false;
                    binicio = false;
                }
            }
        }
        

      
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            cordx = e.Location.X;
            cordy = e.Location.Y;
            int final = 1000;//punto final dar clic
            if (bandera == 4)//arista dirigida
            {
                if (binicio == true) //nodo inicial tocado
                {
                    Arista arista = new Arista(); //crear nueva arista
                    for (int i = 0; i < nodos.Count(); i++)
                    {
                        if (cordx > nodos[i].getX() - 40 && cordx < nodos[i].getX() + 40 && cordy > nodos[i].getY() - 40 && cordy < nodos[i].getY() + 40)
                        {
                            final = i; //punto final (i) guardado en final
                            bfinal = true; //ya se toco el punto final
                            arista.llenaArista(inicio, final, 0, 0); //le pongo sus datos
                            nodos[inicio].llenaarista(arista); //agrega una arista a la lista de aristas
                        }
                    }
                }
            }
            if (bandera == 5) //arista no dirigida
            {
                if (binicio == true)
                {
                    Arista arista = new Arista();
                    for (int i = 0; i < nodos.Count(); i++)
                    {
                        if (cordx > nodos[i].getX() - 40 && cordx < nodos[i].getX() + 40 && cordy > nodos[i].getY() - 40 && cordy < nodos[i].getY() + 40)
                        {
                            final = i;
                            bfinal = true; //ya se toco el punto final
                            //arista.llenaArista(inicio, final, 0, 0);
                            //nodos[inicio].llenaarista(arista); //puede ir, en la misma linea
                            arista.llenaArista(final, inicio, 0, 1);
                            nodos[final].llenaarista(arista); //puede regresar, en la misma linea
                        }
                    }
                }
            }
            if (bandera == 6)
            {
                bool uuu = false;
                for(int i = 0; i < nodos.Count; i++)
                {
                    for(int j = 0; j < nodos[i].aristas.Count; j++)
                    {
                        //y2-y1/x2-x1
                        int m = (nodos[nodos[i].aristas[j].getOrigen()].getX() - nodos[nodos[i].aristas[j].getDestino()].getX()) / (nodos[nodos[i].aristas[j].getOrigen()].getY() - nodos[nodos[i].aristas[j].getDestino()].getY());

                    }
                }
            }
            
            acciones1();
        }

        private void grafo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bandera = 1; //agregar nodo de grafo 1
        }

        
     
        //int inicio = 10000; //no se ha  tocado nada 
        
        private void grafoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bandera = 14;
        }

        //BORRAR GRAFO 1
        private void grafo1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nodos = new List<Nodo>();
            dibuja();
            pictureBox1.Image = null;
        }


        bool minicio = false;
        int xinicio = 0;
        int yinicio = 0;
        bool mfinal = false;
        int nodmover = 1000; //si es el que voy a mover
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (bandera == 2)
            {
                for (int i = 0; i < nodos.Count(); i++)
                {
                    if (cordx > nodos[i].getX() - 40 && cordx < nodos[i].getX() + 40)
                    {
                        xinicio = cordx;
                        yinicio = cordy;
                        minicio = true; //ya se toco el punto de inicio
                        nodmover = i;
                    }
                }
            }
            if (bandera == 7)
            {
                for (int i = 0; i < nodos.Count(); i++)
                {
                    if (e.Location.X > nodos[i].getX() - 40 && e.Location.X < nodos[i].getX() + 40 && e.Location.Y > nodos[i].getY() - 40 && e.Location.Y < nodos[i].getY() + 40)
                    {
                        xinicio = cordx;
                        yinicio = cordy;
                        minicio = true; //ya se toco el punto de inicio
                        nodmover = i;
                    }
                }
            }
        }


        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            int xdif = 0;
            int ydif = 0;
            Nodo nd = new Nodo(); //nuevo nodo para mover
            if (bandera == 2 && minicio == true) //mover todo y hay seleccion de nodo inicio 
            {
                xdif = e.Location.X - xinicio;
                ydif = e.Location.Y - yinicio;
                for (int i = 0; i < nodos.Count; i++)
                {
                    nodos[i].llenaNodo(nodos[i].getX() + xdif, nodos[i].getY() + ydif); //modificar la informacion del nodo
                }
                dibuja();
                minicio = false; 
            }

            if (bandera == 7 && minicio == true) //mover un nodo y seleccion de inicio
            {
                xdif = e.Location.X - nodos[nodmover].getX(); //nueva posicion x 
                ydif = e.Location.Y - nodos[nodmover].getY();//nueva posicion y
                nodos[nodmover].llenaNodo(nodos[nodmover].getX() + xdif, nodos[nodmover].getY() + ydif); //modifica la informacion del nodo
                /*for (int i = 0; i < nodos.Count; i++)
                {
                    nodos[i].llenaNodo(nodos[i].getX() + xdif, nodos[i].getY() + ydif);
                }*/
                dibuja();
               minicio = false;
            }
        }


        public void movimientotiemporeal()
        {
            List<Nodo> aux = new List<Nodo>();
            aux = auxmover;
            //s declara area de dibujo
            if (dibujo != null)
            {
                dibujo.Clear(Color.Aqua);
            }
            dibujo = this.pictureBox1.CreateGraphics();
            for (int i = 0; i < aux.Count(); i++)
            {
                dibujo.FillEllipse(Brushes.Pink, aux[i].getX(), aux[i].getY(), 40, 40);
            }
        }
        List<Nodo> auxmover;
       private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int xxdif = 0;
            int yydif = 0;
            List<Nodo> auxnodo = nodos;
            Nodo nd = new Nodo(); //nuevo nodo para mover
            if (bandera == 2 && minicio == true) //mover todo y hay seleccion de nodo inicio 
            {
                xxdif = e.Location.X - xinicio;
                yydif = e.Location.Y - yinicio;
                for (int i = 0; i < auxnodo.Count; i++)
                {
                    auxnodo[i].llenaNodo(auxnodo[i].getX() + xxdif, auxnodo[i].getY() + yydif); //modificar la informacion del nodo
                }
                dibuja();
            }

            if (bandera == 7 && minicio == true) //mover un nodo y seleccion de inicio
            {
                xxdif = e.Location.X - auxnodo[nodmover].getX(); //nueva posicion x 
                yydif = e.Location.Y - auxnodo[nodmover].getY();//nueva posicion y
                auxnodo[nodmover].llenaNodo(auxnodo[nodmover].getX() + xxdif, auxnodo[nodmover].getY() + yydif); //modifica la informacion del nodo
                dibuja();
            }
        }

        private void adyacenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void grafo1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            matriz_adyacencia md = new matriz_adyacencia(nodos);
            md.Show();//se abra el form de matriz adyacenciaa
        }

        private void moverNodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bandera = 7;
        }

        private void grafo1ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            matrizPeso mp = new matrizPeso(nodos);
            mp.Show(); //abrir form de matriz de peso
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string grafo1name = "";

    string grafo2name = "";
       

        private void grafo1ToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            bandera =8;
        }
        public int tipografo(List<Nodo> grafo)
        {
            int tipo = 1000;
            for(int j = 0; j < grafo.Count(); j++)
            {
                for(int k = 0; k < grafo[j].aristas.Count(); k++)
                {
                    if (grafo[j].aristas[k].getTipo()==0)
                    {
                        tipo = 0;
                        break;//puedo usarlo para romper el for 
                    }
                    else if(grafo[j].aristas[k].getTipo() == 1)
                    {
                        tipo = 1;
                        break;
                    }
                }
                if (tipo != 1000)
                {
                    break;
                }
            }
            return tipo;
        }
        private void grafo1ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (nodos.Count != 0)
            {
                if (tipografo(nodos) == 0)
                {
                    MessageBox.Show("Grafo Dirigido ", "Tipo grafo", MessageBoxButtons.OK);
                }
                else if (tipografo(nodos) == 1)
                {
                    MessageBox.Show("Grafo No Dirigido ", "Tipo grafo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Sin tipo ", "Tipo grafo", MessageBoxButtons.OK);
                }
            }
        }

        
        public int [,] llenamatriz()
        {
            int [,] matriz = new int[nodos.Count, nodos.Count];
            for (int i = 0; i < nodos.Count; i++)
            {
                for (int j = 0; j < nodos.Count; j++)
                {
                    matriz[i, j] = 0; //INICIALIZAMOS EN CERO
                }
            }

            for (int i = 0; i < nodos.Count; i++)
            {
                for (int j = 0; j < nodos[i].aristas.Count(); j++)
                {
                    if (nodos[i].aristas[j].getOrigen() == i)
                    {
                        matriz[i, nodos[i].aristas[j].getDestino()] = 1;
                    }
                    else
                    {
                        matriz[i, nodos[i].aristas[j].getOrigen()] = 1;
                    }
                }
            }
            return matriz;
        }
       
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void grafo1ToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            nodos = new List<Nodo>();
            dibuja();
        }
        public int cuentaaristas(List<Nodo> grafo)
        {
            int totalaristas = 0;
            for(int i = 0; i < grafo.Count(); i++)
            {
                totalaristas += grafo[i].aristas.Count();
            }
            return totalaristas;
        }
      
      

      
    }
}
