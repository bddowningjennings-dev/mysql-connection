using MySql.Data.MySqlClient;    
using System;    
using System.Collections.Generic;    
    
namespace mysql_connection.Models    
{    
    public class MusicStoreContext    
    {    
        public string ConnectionString { get; set; }    
    
        public MusicStoreContext(string connectionString)    
        {    
            this.ConnectionString = connectionString;    
        }    
    
        private MySqlConnection GetConnection()    
        {    
            return new MySqlConnection(ConnectionString);    
        }  
        public List<Album> GetAllAlbums()  
        {  
            List<Album> list = new List<Album>();  
          
            using (MySqlConnection conn = GetConnection())  
            {  
                conn.Open();  
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM webtools_ng.affected_mailboxes where query_id = '6068';", conn);  
          
                using (var reader = cmd.ExecuteReader())  
                {  
                  Console.WriteLine(reader);
                    // while (reader.Read())  
                    // {  
                    //     list.Add(new Album()  
                    //     {  
                    //         Id = Convert.ToInt32(reader["Id"]),  
                    //         Name = reader["Name"].ToString(),  
                    //         ArtistName = reader["ArtistName"].ToString(),  
                    //         Price = Convert.ToInt32(reader["Price"]),  
                    //         Genre = reader["genre"].ToString()  
                    //     });  
                    // }  
                }  
            }  
            return list;  
        }
    }
} 