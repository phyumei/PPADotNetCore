// See https://aka.ms/new-console-template for more information
using PPADotNetCore.ConsoleApp;
using System.Data;
using System.Data.SqlClient;

//Console.WriteLine("Hello, World!");
//Console.ReadLine();

//foreach(DataRow dr in dt.Rows)
//{
//    Console.WriteLine(dr["BlogID"]);
//    Console.WriteLine(dr["BlogTitle"]);
//    Console.WriteLine(dr["BlogAuthor"]);
//    Console.WriteLine(dr["BlogContent"]);
//}

//Console.ReadKey();

AdoDotNetPPA adoDotNetPPA = new AdoDotNetPPA();
//adoDotNetPPA.Read();
//adoDotNetPPA.Create();
adoDotNetPPA.Edit();
//adoDotNetPPA.Update();
//adoDotNetPPA.Delete();


Console.ReadKey();