using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using MongoDB.Driver;


namespace MongoLogic
{
    class conexion
    {
        public static void Main(string[] args) {
            CreateDatabase("newDatabaseName", "newCollectionName");
        }

        //conexion sin autentif
        public  void ConnectWithoutAuthentication() {
            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            Console.WriteLine("Connected"); }

        //crear base datos
        public  IMongoDatabase CreateDatabase(string databaseName, string collectionName) {
            MongoClient client = GetMongoClient(hostName);
            IMongoDatabase database = client.GetDatabase(databaseName);
            database.CreateCollection(collectionName); return database; }





    }




}
