﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO.Ports;

namespace Hoofdform
{
    public class Trein
    {
        public SerialPort arduinoPoort;

        List<Coupe> coupes = new List<Coupe>();
        Locomotief locomotief;
        //static string ConnectionString = @"Server=mssql.fhict.local;Database=dbi392341;User Id = dbi392341; Password=Proftaak123;";
        
        public Trein(List<Coupe> coupes, Locomotief locomotief)
        {
            this.locomotief = locomotief;
            this.coupes = coupes;
        }

        public Trein()
        {

        }

        public void passagiersDoorgeven()
        {
            //hier de values doorgeven van het scherm
        }

        public void coupeDoorgeven()
        {
            //hier de eerste coupe uit de lijst doorgeven
        }




       /* public void CoupeOphalen()
        {
            string query = "SELECT * FROM dbo.Coupe WHERE id = @ID";
            using (SqlConnection connection = new SqlConnection(DatabaseCONN.ConnString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                connection.Open();
                cmd.Parameters.AddWithValue(@"ID", listCoupe.First());

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    speciaal = reader["speciaal"].ToString();
                    klasseR = reader["klasse_rechts"].ToString();
                    klasseL = reader["klasse_links"].ToString();
                    stoelenInCoupe = reader["aantal_stoelen"].ToString();
                }
            }
            if (speciaal == "True")
            {
                speciaal = "1";
            }
            else
            { 
                speciaal = "0";
            }
            compleet = String.Format("{0},{1},{2},{3}", speciaal, klasseR, klasseL, stoelenInCoupe);

            arduinoPoort.Open();
            arduinoPoort.WriteLine(compleet);
            arduinoPoort.Close();
        }*/
    }
}
