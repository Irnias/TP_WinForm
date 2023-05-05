﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace domain
{
    class DataAccess
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;

        public DataAccess()
        {
            connection = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true ");
            //connection = new SqlConnection("server=localhost; database=CATALOGO_P3_DB;User Id=sa; password=fakePassw0rd"); 
            command = new SqlCommand();
        }

        public void setQuery(string query)
        {
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = query;
        }
        public void execute()
        {
            command.Connection = connection;
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
 
        }

  
        public SqlDataReader sqlReader
        {
            get { return reader; }
        }
        public void executeAction()
        {
            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void close()
        {
            if (reader != null)
            reader.Close();
            connection.Close();
        }
    }
}
