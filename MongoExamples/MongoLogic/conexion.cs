using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;


namespace MongoLogic
{
    public class  conexion
    {
       
        //conexion sin autentif
        public  void ConnectWithoutAuthentication() {
            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
             }


        //nube
        public  void ConnectWithAuthentication() { string dbName = "ecommlight";
            string userName = "some_user";
            string password = "pwd";
            var credentials = MongoCredential.CreateCredential(dbName, userName, password);
            var clientSettings = new MongoClientSettings() {
                Credentials = new[] { credentials }, Server = new MongoServerAddress("localhost", 27017) };
            MongoClient client = new MongoClient(clientSettings);
            Console.WriteLine("Connected as {0}", userName);
        }


        //Referencing a database 
        public  MongoClient GetMongoClient(string hostName) {
            string connectionString = string.Format("mongodb://{0}:27017", hostName);
            return new MongoClient(connectionString); }


        //We use the GetDatabase() method to get a reference to a database directly from the MongoClient instance, as follows
        public IMongoDatabase GetDatabaseReference(string hostName, string dbName) {
            MongoClient client = GetMongoClient(hostName);
            IMongoDatabase database = client.GetDatabase(dbName); return database; }

        

        //crear base datos
        

                public   IMongoDatabase CreateDatabase(string hostName, string databaseName, string collectionName) {
                    MongoClient client = GetMongoClient(hostName);
                    IMongoDatabase database = client.GetDatabase(databaseName);
                    database.CreateCollection(collectionName); return database; }
            }




    }
