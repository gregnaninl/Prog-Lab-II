using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Threading;


namespace parcial_2016_II
{
    public partial class Form1 : Form
    {
        

        List<Persona> _corredores;
        List<Thread> _corredoresActivos;
        bool _hayGanador;
        
        public Form1()
        {
            InitializeComponent();
            this._corredores = new List<Persona>();
            this._corredoresActivos = new List<Thread>();
            this._corredores.Add(new Persona("Fernando", 9, Corredor.eCarril.Carril_1));
            this._corredores.Add(new Persona("Fernando", 15, Corredor.eCarril.Carril_2));
            this._hayGanador = false;
            
        }

        private void AnalizarCarrera(ProgressBar carril, int avance, Corredor corredor)
        {
            if (this._hayGanador == false)
            {
                carril.Increment(avance);
                if (carril.Value == carril.Maximum)
                {
                    HayGanador(corredor);
                }
            }
        }

        public void HayGanador(Corredor corredor)
        {
            if (this._hayGanador == true)
            {
                foreach (Thread aux in _corredoresActivos)
                {
                    aux.Abort();
                }

                using (System.IO.StreamWriter tx = new System.IO.StreamWriter("Ganadores.txt", true))
                {
                    tx.WriteLine(corredor.ToString());
                }

                MessageBox.Show(corredor.ToString());
            }                       
            
        
        }
        

        public delegate void CorrenCallback(int avance, Corredor corredor);
        

        private void PersonaCorriendo(int avance, Corredor corredor)
        {   

            if (pgbCarril1.InvokeRequired || pgbCarril2.InvokeRequired)
            {
                CorrenCallback d = new CorrenCallback(PersonaCorriendo);
                this.Invoke(d, new object[] { avance, corredor });
            }
            else
            {   if(corredor.CarrilElegido == Corredor.eCarril.Carril_1)
                {
                   
                  AnalizarCarrera(pgbCarril1, avance, corredor);
                   
                    
                }
                else
                 {
                    AnalizarCarrera(pgbCarril2, avance, corredor);                  
                  
                  }
            }

        }

        public void LimpiarCarriles()
        {
            pgbCarril1.Value = 0;
            pgbCarril2.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          // _corredoresActivos.Add( new Thread(PersonaCorriendo));
            
            foreach (Persona aux in _corredores)
            {
                aux.Corriendo += PersonaCorriendo;


            }
            foreach (Thread aux in _corredoresActivos)
            {   
                aux.Start();
            }
            
        }
    }
}
