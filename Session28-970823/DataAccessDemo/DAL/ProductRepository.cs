using DataAccessDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessDemo.DAL
{
    public class ProductRepository
    {
        public List<Product> GetProducts()
        {
            string connectionString = "server=.;database=AdventureWorks2016;uid=sa;pwd=developer;";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT ProductId, Name, Color, ListPrice FROM Production.Product");
            cmd.Connection = conn;
            cmd.Connection.Open();

            var reader = cmd.ExecuteReader(); //Cursor 
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                products.Add(new Product() {
                    ProductId = Convert.ToInt32(reader["ProductId"]),
                    Name = reader["Name"].ToString(),
                    Color = reader["Color"].ToString(),
                    ListPrice = Convert.ToDouble(reader["ListPrice"])
                });
            }

            conn.Close();

            return products;
        }
    }
}
