using System.Text;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Negocio;
using Dominioo;


namespace WindowsFormsApp2

{

    public partial class Form3 : Form
    {
        private List<Pokemon> listaPokemon;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
             
            cargar();

        }

        private void DGVPokemon_SelectionChanged(object sender, EventArgs e)
        {
           if(DGVPokemon.CurrentRow != null)
            {
            Pokemon seleccionado = (Pokemon)DGVPokemon.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
            Elemento elem = new Elemento();
            }

        }

        private void cargar()
        {

            PokemonNegocio negocio = new PokemonNegocio();
            try
            {

                listaPokemon = negocio.listar();
                DGVPokemon.DataSource = listaPokemon;
                ocultarColumnas();
                cargarImagen(listaPokemon[0].UrlImagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
           
        }
        private void ocultarColumnas ()
        {
            DGVPokemon.Columns["UrlImagen"].Visible = false;
            DGVPokemon.Columns["Id"].Visible = false;

        }
        private void cargarImagen(string imagen)
        {


            try
            {
                PBPokemon.Load(imagen);
            }
            catch (Exception)
            {

                PBPokemon.Load("https://wpdirecto.com/wp-content/uploads/2017/08/alt-de-una-imagen.png");
            }
        }

        private void BTAgregar_Click_1(object sender, EventArgs e)
        {
            AgregarPoke alta = new AgregarPoke();
            alta.ShowDialog();
            cargar();

        }

        private void DGVPokemon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTModificar_Click(object sender, EventArgs e)
        {
            Pokemon seleccionado;
            seleccionado = (Pokemon)DGVPokemon.CurrentRow.DataBoundItem;
            AgregarPoke modificar = new AgregarPoke(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            Pokemon seleccionado;

            try
            {
               DialogResult repuesta = MessageBox.Show("¿Seguro queres eliminar?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (repuesta == DialogResult.Yes)
                {
                 seleccionado = (Pokemon)DGVPokemon.CurrentRow.DataBoundItem;
                 negocio.Eliminar(seleccionado.Id);
                 cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
    }


        
       
        private void Btnbuscar_Click(object sender, EventArgs e)
        {
          

        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Pokemon> listaFiltrada;

            string filtro = TxtBuscar.Text;
            if (filtro.Length >= 3)
            {
                listaFiltrada = listaPokemon.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Tipo.Descripcion.ToUpper().Contains(filtro.ToUpper()));

            }
            else
            {
                listaFiltrada = listaPokemon;
            }
            DGVPokemon.DataSource = null;
            DGVPokemon.DataSource = listaFiltrada;
            ocultarColumnas();
        }
    }
}
