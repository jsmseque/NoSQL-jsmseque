
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  MongoDB;


namespace MongoExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var elMongo = new MongoLogic.conexion();
            elMongo.CreateDatabase("localhost","newDatabaseName", "newCollectionName");
        }
    }
}