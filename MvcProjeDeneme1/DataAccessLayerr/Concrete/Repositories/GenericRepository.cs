using DataAccessLayerr.Abstract;
using DataAccessLayerr.EntityFramework;

using EntityLaayer.Concrete;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerr.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        IMongoClient mongoClient = new MongoClient("mongodb://localhost:27017");
        Context c = new Context();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = c.Set<T>();
        }

        public List<Cars> DateTimeBolme(int carID,DateTime year,DateTime yearson)
        {

            // 11 15 2018 9,54
            var database = mongoClient.GetDatabase("mydemo");
            var collection = database.GetCollection<Cars>("cars");

            year = year.AddHours(3);
            yearson = yearson.AddHours(3);


            var sonuc1 = collection.Find<Cars>(a => a.id == carID.ToString()).SortByDescending(a => a.dateTime).Limit(1).ToList();
            DateTime datedeneme1 = sonuc1[0].dateTime.AddMonths(-2);
           // DateTime date = sonuc1[0].dateTime.AddMonths(year);
           var sonuclar1 = collection.Find<Cars>(a => a.dateTime <= yearson && a.dateTime >= year && a.id ==carID.ToString()).ToList();
            
            //DateTime request_date = new DateTime(2018, 11, 15, 9, 54, 0);
            //DateTime repost_date = request_date.AddMinutes(-30);

           // var sonuclar = collection.Find<Cars>(a => a.dateTime <= new Date(2018 - 10 - 02T14: 06:00.000 + 00:00 )&& a.dateTime >= repost_date && a.id == carID.ToString()).ToList();

            return sonuclar1;

            }

        public void Delete(T p)
        {
            var deletedEntity = c.Entry(p);
            deletedEntity.State = EntityState.Deleted;
            c.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public List<Cars> GetListCar()
        {

            var database = mongoClient.GetDatabase("mydemo");
            var collection = database.GetCollection<Cars>("cars");
            //for (int i = 0; i < list.Count; i++)
            //{
            //    collection.InsertOne(list[i]);
            //}

            //List <Cars> results = collection.Find<Cars>(a => true).ToList();
            List<Cars> results = collection.Find(x => (string)x.id == "2").ToList();

            return results;
        }



        public List<Cars> GetListCustomerCar1(int carID)
        {
            //var lines = File.ReadAllLines("dene.csv");
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

            // collection.Find(x=>x.dateTime.Split==DateTime.Now.)
            // CANGO İSMİNİN CAR İDLERİ 
            //List <Cars> results = collection.Find<Cars>(a => true).ToList();
            //List<Cars> results = collection.Find(x => (string)x.id == carID.ToString()).ToList();
            // List<Cars> results = collection.Find(x => (string)x.dateTime == carID.ToString()).ToList();

            var sonuc1 = collection.Find<Cars>(a => a.id == carID.ToString()).SortByDescending(a => a.dateTime).Limit(1).ToList();
            DateTime tson = sonuc1[0].dateTime.AddMinutes(-30);
            var results = collection.Find<Cars>(a => a.dateTime <= sonuc1[0].dateTime && a.dateTime >= tson && a.id == carID.ToString()).ToList();



            return results;
        }

        public List<Cars> GetListCustomerCar2(int carID)
        {
            //var lines = File.ReadAllLines("dene.csv");
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

            //List <Cars> results = collection.Find<Cars>(a => true).ToList();
            // List<Cars> results = collection.Find(x => (string)x.id == "2").ToList();
            //List<Cars> results = collection.Find(x => (string)x.id == carID.ToString()).ToList();
            var sonuc1 = collection.Find<Cars>(a => a.id == carID.ToString()).SortByDescending(a => a.dateTime).Limit(1).ToList();
            DateTime tson = sonuc1[0].dateTime.AddMinutes(-30);
            var results = collection.Find<Cars>(a => a.dateTime <= sonuc1[0].dateTime && a.dateTime >= tson && a.id ==carID.ToString()).ToList();

            return results;
        }

        public void Insert(T p)
        {
            var addedEntity = c.Entry(p);
            addedEntity.State = EntityState.Added;
            c.SaveChanges();
        }
        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            var updatedEntiy = c.Entry(p);
            updatedEntiy.State = EntityState.Modified;
            c.SaveChanges();
        }


        //public void CarsAddToMongoDB(T p)
        //{

        //    carsCollection.InsertOne(p);

        //}

        //public GenericRepository<T> locklama()
        //{
        //    lock (lockObject)
        //    {
        //        return _client ?? (_client = new GenericRepository<T>());
        //    }

    }


    //public void ConnecttoMongoDB()
    //{
    //    locklama();

    //}


}




