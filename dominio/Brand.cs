using System;
using System.Collections.Generic;

namespace domain
{

    /*public List<Brand>Listar()
        {
            List<Brand> Listas = new List<Brand>();
            DataAccess data = new DataAccess();
            try
            {
                data.setQuery("");
                data.execute();

                while (data.sqlReader.Read())
                {
                    Brand aux = new Brand();
                    aux.Id = (int)data.sqlReader["Id"];
                    aux.Name = (string)data.sqlReader["Nombre"];
                    aux.Description = (string)data.sqlReader["Descrip"];


                    Listas.Add(aux);
                }
                return Listas;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.close();
            }
        }*/
    public class Brand
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Description;
        }

    }
}