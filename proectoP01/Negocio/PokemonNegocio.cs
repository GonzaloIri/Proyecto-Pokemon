﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominioo;

namespace Negocio

{
    public class PokemonNegocio
    {
        public List<Pokemon> listar()

        {
            List<Pokemon> lista = new List<Pokemon>();

            SqlConnection conexion = new SqlConnection();

            SqlCommand comando = new SqlCommand();
            SqlDataReader lector; 


            try
            {
                conexion.ConnectionString = "server =.\\SQLEXPRESS;  database=POKEDEX_DB; integrated security=true";
                
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Numero, Nombre, P.Descripcion, UrlImagen , E.Descripcion Tipo, D.Descripcion Debilidad, P.IdTipo,P.IdDebilidad, P.Id from POKEMONS P, ELEMENTOS E, ELEMENTOS D where E.Id = P.IdTipo And D.Id = P.IdDebilidad and P.Activo = 1";

                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();


                while (lector.Read())

                {
                    Pokemon aux = new Pokemon();
                    aux.Id = (int)lector["Id"];
                    aux.Numero = lector.GetInt32(0);
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["descripcion"];
                  /// if (!(lector.IsDBNull(lector.GetOrdinal("UrlImagen")))
                 ///aux.UrlImagen = (string)lector["UrlImagen"];
                 ///Funcionan las dos formas...
                    if (!(lector["UrlImagen"] is DBNull))
                        aux.UrlImagen = (string)lector["UrlImagen"];
                    aux.Tipo = new Elemento();
                    aux.Tipo.Id = (int)lector["IdTipo"];
                    aux.Tipo.Descripcion = (string)lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Id = (int)lector["IdDebilidad"];
                    aux.Debilidad.Descripcion = (string)lector["Debilidad"];

                    lista.Add(aux);

                }

                conexion.Close();   
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    
            ///Me falta agregar esto... No colgar xd;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
    public void Agregar (Pokemon nuevo)
    {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Insert into POKEMONS (Numero, Nombre, Descripcion, Activo,IdTipo,IdDebilidad, UrlImagen)values(" + nuevo.Numero + ", ' " +nuevo.Nombre + " ', '"+nuevo.Descripcion+ " ', 1, @idTipo, @idDebilidad, @urlImagen)");
                datos.setearParametro("@idTipo", nuevo.Tipo.Id);
                datos.setearParametro("@idDebilidad", nuevo.Tipo.Id);
                datos.setearParametro ("@urlImagen", nuevo.UrlImagen);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            } 
            finally
            {
                datos.cerrarConexion( );
            }
            
    }
     

        public void modificar (Pokemon poke)
        {
            AccesoDatos datos = new AccesoDatos ();
            try
            {
                datos.setearConsulta("update POKEMONS set Numero = @numero,Nombre = @nombre,Descripcion = @descripcion, UrlImagen = @imagen, Idtipo = @idtipo, IdDebilidad = @IdDebilidad where Id = @id ");

                datos.setearParametro("@numero",poke.Numero);
                datos.setearParametro("@nombre",poke.Nombre);
                datos.setearParametro("@descripcion",poke.Descripcion);
                datos.setearParametro("@imagen", poke.UrlImagen );
                datos.setearParametro("@idtipo", poke.Tipo.Id);
                datos.setearParametro("@IdDebilidad", poke.Debilidad.Id);
                datos.setearParametro("@id", poke.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion ();
            }

        }


        public void Eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();

                datos.setearConsulta("delete from pokemons where  id = @id ");
                datos.setearParametro( "@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
        
}       

