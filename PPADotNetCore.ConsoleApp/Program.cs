﻿// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");
Console.ReadLine();

string connectionString = "Data Source = .; Initial Catalog= DotNetTrainingBatch5; User ID= sa; Password=sasa@123;";
Console.WriteLine("connectionString is" + connectionString);
SqlConnection connection = new SqlConnection(connectionString);

Console.WriteLine("Connection opening...");
connection.Open();
Console.WriteLine("Connection opened");

string query = @"SELECT [BlogId]
,[BlogTitle]
,[BlogAuthor]
,[BlogContent]
,[DeleteFlag] 
FROM [dbo].[Tbl_Blog] where DeleteFlag = 0";
SqlCommand cmd = new SqlCommand(query, connection);
//SqlDataAdapter adapter = new SqlDataAdapter(cmd);
//DataTable dt = new DataTable();
//adapter.Fill(dt);
SqlDataReader reader = cmd.ExecuteReader();
while (reader.Read())
{
    Console.WriteLine(reader["BlogID"]);
    Console.WriteLine(reader["BlogTitle"]);
    Console.WriteLine(reader["BlogAuthor"]);
    Console.WriteLine(reader["BlogContent"]);
}

Console.WriteLine("Connection closing...");
connection.Close();
Console.WriteLine("Connection closed");

//foreach(DataRow dr in dt.Rows)
//{
//    Console.WriteLine(dr["BlogID"]);
//    Console.WriteLine(dr["BlogTitle"]);
//    Console.WriteLine(dr["BlogAuthor"]);
//    Console.WriteLine(dr["BlogContent"]);
//}

Console.ReadKey();