using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        //creando las listas alternas para luego utilizarlas de variable para la picture box
        private List<Producto> listaProductos;
        private List<Celular> listaCelular;
        private List<Televisor> listaTelevisor;
        private List <Media> listaMedia;
        private List <Audio> listaAudio;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            productoDatos productos = new productoDatos();
            listaProductos = productos.listaGeneral(); //variable a usar en el picture box
            dgvGeneral.DataSource = listaProductos;
            pctbGeneral.Load(listaProductos[0].imagen);
            
        }

         
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage selectedTab = tabControl.SelectedTab;
            
            //data grid view de Celulares
            CelularDatos celulares = new CelularDatos();
            listaCelular = celulares.ListaCelulares(); //variable a usar en el picture box
            dgvCelulares.DataSource = listaCelular;
            pctbCelulares.Load(listaCelular[0].imagen);

            //data grid view de Televisores
            televisoresDatos televisores = new televisoresDatos();
            listaTelevisor = televisores.listaTelevisores(); //variable a usar en el picture box
            dgvTelevisores.DataSource = listaTelevisor;
            pctbTelevisores.Load(listaTelevisor[0].imagen);

            //data grid view de Media
            mediaDatos media = new mediaDatos();
            listaMedia = media.listaMedia();  //variable a usar en el picture box  
            dgvMedia.DataSource = listaMedia; 
            pctbMedia.Load(listaMedia[0].imagen);
            
            //data grid view de Audio
            audioDatos audio = new audioDatos();
            listaAudio = audio.listaAudio();    
            dgvAudio.DataSource = listaAudio;
            pctbAudio.Load(listaAudio[0].imagen);

        }
        private void dgvGeneral_SelectionChanged(object sender, EventArgs e)
        {
            Producto producto1 = (Producto)dgvGeneral.CurrentRow.DataBoundItem;
            pctbGeneral.Load(producto1.imagen);
        }
        private void dgvCelulares_SelectionChanged(object sender, EventArgs e)
        {
            Celular celular1 = (Celular)dgvCelulares.CurrentRow.DataBoundItem;
            pctbCelulares.Load(celular1.imagen);
        }
        private void dgvTelevisores_SelectionChanged(object sender, EventArgs e)
        {
            Televisor televisor1 = (Televisor)dgvTelevisores.CurrentRow.DataBoundItem;
            pctbTelevisores.Load(televisor1 .imagen);
        }
        private void dgvMedia_SelectionChanged(object sender, EventArgs e)
        {
            Media media1 = (Media)dgvMedia.CurrentRow.DataBoundItem;    
            pctbMedia.Load(media1.imagen);
        }

        private void dgvAudio_SelectionChanged(object sender, EventArgs e)
        {
            Audio Audio1 = (Audio)dgvAudio.CurrentRow.DataBoundItem;
            pctbAudio.Load(Audio1.imagen);
        }

    }
}
