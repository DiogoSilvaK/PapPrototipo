using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PapPrototipo
{
    
    public partial class Main : Form
    {

        FormInicio fi = new FormInicio();
        FormInserir fir = new FormInserir();
        FormAtualizar fal = new FormAtualizar();

        public static Color PredC = Color.Red;
        public Main()
        {
            InitializeComponent();

        }
        
        bool logout = false;
        public void Form2_Load(object sender, EventArgs e){
            
            FormInserir fir = new FormInserir();
            FormInicio fi = new FormInicio();
            fi.TopLevel = false;

            panelf3.Controls.Add(fi);
            fi.Show();
            


            
        }




        private void VTS_Click(object sender, EventArgs e)
        {
            panelf3.Controls.Clear();
            ImprimirForm FVTS = new ImprimirForm();
            FVTS.TopLevel = false;
            panelf3.Controls.Add(FVTS);
            FVTS.Show();
        }
            
            
            private void InserirBut_Click(object sender, EventArgs e){
            panelf3.Controls.Clear();
           
            FormInserir fir = new FormInserir();
            fir.TopLevel = false;
            panelf3.Controls.Add(fir);
            fir.Show();
         
        }
        private void AtualizarBut_Click(object sender, EventArgs e){
           
            panelf3.Controls.Clear();
            FormAtualizar fal = new FormAtualizar();
            fal.TopLevel = false;
            panelf3.Controls.Add(fal);
            fal.Show();
         
        }
        private void ApagarBut_Click(object sender, EventArgs e){
            panelf3.Controls.Clear();
            FormApagar fapg = new FormApagar();
            fapg.TopLevel = false;
            panelf3.Controls.Add(fapg);
            fapg.Show();
        }
        private void PesquisarBut_Click(object sender, EventArgs e){
            panelf3.Controls.Clear();
            FormPesquisar fps= new FormPesquisar();
            fps.TopLevel = false;
            panelf3.Controls.Add(fps);
            fps.Show();
        }
        private void VTC_Click(object sender, EventArgs e){
            panelf3.Controls.Clear();
            VTForm FVTC= new VTForm();
            FVTC.TopLevel = false;
            panelf3.Controls.Add(FVTC);
            FVTC.Show();
        }





        private void InicioBut_Click(object sender, EventArgs e){
         
            panelf3.Controls.Clear();
            FormInicio fi = new FormInicio();
            fi.TopLevel = false;
            panelf3.Controls.Add(fi);
            fi.Show();
      
        }

        public void Sair_Click(object sender, EventArgs e)
        {
            
              logout = true;
              this.Close();
             Login f1 = new Login();
            f1.Show();
        }
        public void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (logout == false)
            {
                Application.Exit();
                logout = false;
            }
        }

        private void DefinBut_Click(object sender, EventArgs e)
        {
            DefinForms d1 = new DefinForms();
            d1.Show();
        }
    }
}
