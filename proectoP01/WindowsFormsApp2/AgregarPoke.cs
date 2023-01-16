using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominioo;
using System.IO;
using System.Configuration;


namespace WindowsFormsApp2
{
    public partial class AgregarPoke : Form
    {
        private Pokemon pokemon = null;

        private OpenFileDialog archivo = null;  

        public AgregarPoke()
        {
            InitializeComponent();
        }
        public AgregarPoke(Pokemon pokemon)
        {

           InitializeComponent();

           this.pokemon = pokemon;
            Text = "Modificar Pokemon";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AgregarPoke_Load(object sender, EventArgs e)
        {
            ElementoNegocio elementonegocio = new ElementoNegocio();

            try
            {
                ComboTipo.DataSource = elementonegocio.listar();
                
                ComboTipo.ValueMember = "Id";
                ComboTipo.DisplayMember = "Descripcion";
                ComboDebilidad.DataSource = elementonegocio.listar();
                ComboDebilidad.ValueMember = "Id";
                ComboDebilidad.DisplayMember = "Descripcion";

                if(pokemon != null)
                {
                    TxtNumero.Text = pokemon.Numero.ToString();
                    TxtNombre.Text = pokemon.Nombre;
                    TxtDescrip.Text = pokemon.Descripcion;
                    TxtImagen.Text = pokemon.UrlImagen;
                    cargarImagen(pokemon.UrlImagen);
                    ComboTipo.SelectedValue = pokemon.Tipo.ToString();
                    ComboTipo.SelectedValue = pokemon.Debilidad.Id;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void GuardarImagen()
        {
            File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            PokemonNegocio Negocio = new PokemonNegocio();
            try
            {
                if (pokemon == null)
                    pokemon = new Pokemon();

                pokemon.Numero = int.Parse(TxtNumero.Text);
                pokemon.Nombre = TxtNombre.Text;
                pokemon.Descripcion = TxtDescrip.Text;
                pokemon.UrlImagen = TxtImagen.Text;
                pokemon.Tipo = (Elemento) ComboTipo.SelectedItem;
                pokemon.Debilidad = (Elemento) ComboDebilidad.SelectedItem;

                if (pokemon.Id != 0){

                    Negocio.modificar(pokemon);
                    MessageBox.Show("Modificado..." );

                }
                else
                {
                    Negocio.Agregar(pokemon);
                    MessageBox.Show("Agregado..");
                }
                //si apreta aceptar se guarda la imagen en la carpeta
                if (archivo != null && (TxtImagen.Text.ToUpper().Contains ("HTTP")))
                {
                    GuardarImagen();
                }
                
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void Nombre_Click(object sender, EventArgs e)
        {

        }

        private void Debilidad_Click(object sender, EventArgs e)
        {

        }

        private void TxtImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(TxtImagen.Text);
        }
        private void cargarImagen(string imagen) {

        try
        {
            PtbUrlImagen.Load(imagen);
        }
        catch (Exception)
        {

            PtbUrlImagen.Load("https://wpdirecto.com/wp-content/uploads/2017/08/alt-de-una-imagen.png");
        }
    }

        private void BtnAgegarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "jpg| *.jpg;|png|*.png";

            if (archivo.ShowDialog() == DialogResult.OK)
            {

                TxtImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);

                //guardar imagen
                //File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"]+archivo.SafeFileName);
            }

        }

        private void ComboDebilidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
