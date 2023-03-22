using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcf_assignment3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class FlowerShop : IFlowerService
    {
        public string DeleteFlower(int value)
        {
            string Message;
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=FlowerShop;Integrated Security=True; TrustServerCertificate=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Flower where flowerId=@flowerId", con);
            cmd.Parameters.AddWithValue("@flowerId", value);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Message = "Flower "+value + " Deleted successfully";
            }
            else
            {
                Message = "Flower "+value + " not Deleted successfully";
            }
            con.Close();
            return Message;
        }

        public string InsertFlower(FlowerDetails flower)
        {
            string Message;
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=FlowerShop;Integrated Security=True; TrustServerCertificate=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Flower(name,colour,price,stock,species) values(@name,@colour,@price,@stock,@species)", con);
            cmd.Parameters.AddWithValue("@name", flower.Name);
            cmd.Parameters.AddWithValue("@colour", flower.Colour);
            cmd.Parameters.AddWithValue("@price", flower.Price);
            cmd.Parameters.AddWithValue("@stock", flower.Stock);
            cmd.Parameters.AddWithValue("@species", flower.Species);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Message = flower.Name + " Details inserted successfully";
            }
            else
            {
                Message = flower.Name + " Details not inserted successfully";
            }
            con.Close();
            return Message;
        }

        public string UpdateFlower(FlowerDetails flower, int value)
        {
            string Message;
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=FlowerShop;Integrated Security=True; TrustServerCertificate=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("update Flower SET name=@name,colour=@colour,price=@price,stock=@stock,species=@species where flowerId=@flowerId", con);
            cmd.Parameters.AddWithValue("@name", flower.Name);
            cmd.Parameters.AddWithValue("@colour", flower.Colour);
            cmd.Parameters.AddWithValue("@price", flower.Price);
            cmd.Parameters.AddWithValue("@stock", flower.Stock);
            cmd.Parameters.AddWithValue("@species", flower.Species);
            cmd.Parameters.AddWithValue("@flowerId", value);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Message = flower.Name + " Details updated successfully";
            }
            else
            {
                Message = flower.Name + " Details not updated successfully";
            }
            con.Close();
            return Message;
        }

        public FlowerDetails GetFlower(int value)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=FlowerShop;Integrated Security=True; TrustServerCertificate=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select flowerId,name,colour,price,stock,species from Flower where flowerId=@flowerId", con);
            cmd.Parameters.AddWithValue("@flowerId", value);
            FlowerDetails result= new FlowerDetails();
            SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int flowerId = reader.GetInt32(0);
                    if (flowerId==value)
                    {
                        string name = reader.GetString(1);
                        string colour= reader.GetString(2);
                        decimal price= reader.GetDecimal(3);
                        int stock= reader.GetInt32(4);
                        string species= reader.GetString(5);
                    result.FlowerId= flowerId;
                    result.Name = name;
                    result.Colour = colour;
                    result.Price = price;
                    result.Stock = stock;
                    result.Species = species;
                    }                   
                }
            return result;
        }
        public FlowerDetails[] GetFlowers()
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=FlowerShop;Integrated Security=True; TrustServerCertificate=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select flowerId,name,colour,price,stock,species from Flower", con);
            List<FlowerDetails>result = new List<FlowerDetails>();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                FlowerDetails flower=new FlowerDetails();
                int flowerId = reader.GetInt32(0);
                string name = reader.GetString(1);
                string colour = reader.GetString(2);
                decimal price = reader.GetDecimal(3);
                int stock = reader.GetInt32(4);
                string species = reader.GetString(5);
                flower.FlowerId = flowerId;
                flower.Name = name;
                flower.Colour = colour;
                flower.Price = price;
                flower.Stock = stock;
                flower.Species = species;
                result.Add(flower);
            }
            return result.ToArray();
        }
    }
}
