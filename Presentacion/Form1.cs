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
            //tab page de productos general
            productoDatos productos = new productoDatos();
            listaProductos = productos.listaGeneral(); //variable a usar en el picture box
            dgvGeneral.DataSource = listaProductos;
            cargarImagen(listaProductos[0].imagen);
            
        }

         
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage selectedTab = tabControl.SelectedTab;
            
            //tab page de Celulares
            CelularDatos celulares = new CelularDatos();
            listaCelular = celulares.ListaCelulares(); //variable a usar en el picture box
            dgvCelulares.DataSource = listaCelular;
            cargarImagen(listaCelular[0].imagen);

            //tab page de Televisores
            televisoresDatos televisores = new televisoresDatos();
            listaTelevisor = televisores.listaTelevisores(); //variable a usar en el picture box
            dgvTelevisores.DataSource = listaTelevisor;
            cargarImagen(listaTelevisor[0].imagen);

            //tab page de Media
            mediaDatos media = new mediaDatos();
            listaMedia = media.listaMedia();  //variable a usar en el picture box  
            dgvMedia.DataSource = listaMedia; 
            cargarImagen(listaMedia[0].imagen);
            
            //tab page de Audio
            audioDatos audio = new audioDatos();
            listaAudio = audio.listaAudio();    
            dgvAudio.DataSource = listaAudio;
            cargarImagen(listaAudio[0].imagen);

        }

        //todos estos metodos son para que se produzca el cambio de imagen a la hora de seleccionar una fila en el data grid view
        private void dgvGeneral_SelectionChanged(object sender, EventArgs e)
        {
            Producto producto1 = (Producto)dgvGeneral.CurrentRow.DataBoundItem;
            cargarImagen(producto1.imagen);
        }
        private void dgvCelulares_SelectionChanged(object sender, EventArgs e)
        {
            Celular celular1 = (Celular)dgvCelulares.CurrentRow.DataBoundItem;
            cargarImagen(celular1.imagen);
        }
        private void dgvTelevisores_SelectionChanged(object sender, EventArgs e)
        {
            Televisor televisor1 = (Televisor)dgvTelevisores.CurrentRow.DataBoundItem;
            cargarImagen(televisor1 .imagen);
        }
        private void dgvMedia_SelectionChanged(object sender, EventArgs e)
        {
            Media media1 = (Media)dgvMedia.CurrentRow.DataBoundItem;    
            cargarImagen(media1.imagen);
        }

        private void dgvAudio_SelectionChanged(object sender, EventArgs e)
        {
            Audio Audio1 = (Audio)dgvAudio.CurrentRow.DataBoundItem;
            cargarImagen(Audio1.imagen);
        }

        private void cargarImagen (string Imagen)
        {
            try
            {
                pctbGeneral.Load(Imagen);
                pctbCelulares.Load(Imagen);
                pctbTelevisores.Load(Imagen);
                pctbMedia.Load(Imagen);
                pctbAudio.Load(Imagen);

            }
            catch (Exception ex)
            {

               pctbGeneral.Load("https://media.istockphoto.com/id/1409329028/vector/no-picture-available-placeholder-thumbnail-icon-illustration-design.jpg?s=612x612&w=0&k=20&c=_zOuJu755g2eEUioiOUdz_mHKJQJn-tDgIAhQzyeKUQ=");
                pctbCelulares.Load("https://media.istockphoto.com/id/1409329028/vector/no-picture-available-placeholder-thumbnail-icon-illustration-design.jpg?s=612x612&w=0&k=20&c=_zOuJu755g2eEUioiOUdz_mHKJQJn-tDgIAhQzyeKUQ=");
                pctbTelevisores.Load("https://media.istockphoto.com/id/1409329028/vector/no-picture-available-placeholder-thumbnail-icon-illustration-design.jpg?s=612x612&w=0&k=20&c=_zOuJu755g2eEUioiOUdz_mHKJQJn-tDgIAhQzyeKUQ=");
                pctbMedia.Load("https://media.istockphoto.com/id/1409329028/vector/no-picture-available-placeholder-thumbnail-icon-illustration-design.jpg?s=612x612&w=0&k=20&c=_zOuJu755g2eEUioiOUdz_mHKJQJn-tDgIAhQzyeKUQ=");
                pctbAudio.Load("https://media.istockphoto.com/id/1409329028/vector/no-picture-available-placeholder-thumbnail-icon-illustration-design.jpg?s=612x612&w=0&k=20&c=_zOuJu755g2eEUioiOUdz_mHKJQJn-tDgIAhQzyeKUQ=");
            }
        }
    }
}
