using CsvHelper;
using CsvHelper.Configuration.Attributes;
using DataAccessLayerr.Abstract;
using EntityLaayer.Concrete;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
namespace BuisnessLayerr.Concrete
{
    public class CsvReadManager
    {
        ICarsDal _carsDal;
        IMongoClient mongoClient = new MongoClient("mongodb://localhost:27017");
        public CsvReadManager(ICarsDal carsDal)
        {
            _carsDal = carsDal;
        }
        public CsvReadManager()
        {
            
        }
        public List<Cars> getCarList()
        {
            //var lines = File.ReadAllLines("allCars.csv");
            //var list = new List<Cars>();
            //int sayac = 0;
            //foreach (var line in lines)
            //{
            //    if (sayac < 5)
            //    {
            //        var values = line.Split(',');
            //        var cars = new Cars() { dateTime = values[0], lat = values[1], lng = values[2], id = values[3] };
            //        list.Add(cars);
            //        sayac++;
            //    }
            //    else
            //    {
            //        break;
            //    }


            //}

            var database = mongoClient.GetDatabase("mydemo");
            var collection = database.GetCollection<Cars>("cars");
            //for (int i = 0; i < list.Count; i++)
            //{
            //    collection.InsertOne(list[i]);
            //}

            var results = collection.Find<Cars>(a => true).ToList();

            return results;
            //List<Cars> records=null;
            //for (int i = 0; i < 5; i++)
            //{
            //    using (var streamReader = new StreamReader(@"C:\Users\Canberk\Downloads\archive\allCars.csv"))
            //    {
            //        using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
            //        {

            //      records = csvReader.GetRecords<Cars>().ToList();

            //        } 

            //    }

            //}
            //return records;

        }

    }
}
