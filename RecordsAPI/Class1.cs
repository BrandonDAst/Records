using System;
using System.Data.SqlClient;
using RecordsAPI.Models;

namespace RecordsAPI
{
    public class Record
    {
        public int Id { get; private set; }
        protected int UserId = 5; //Configurated via session
        public bool Enabled { get; private set; }
        static string _dataBase;

        protected virtual bool Update(Record newData){ return false; }
        protected static Record GerRecord(int Id)
        {
            Record r = new Record();
            using (SqlConnection connection = new SqlConnection(_dataBase))
            {
                
            }
            return r;
        }
    }

    public class Product : Record
    {
        public string Description { get; set; }
        public string Brand { get; set; }
        private void SetDefaults()
        {
        }
        public Product(string description, string brand, int userId)
        {
            SetDefaults();
            Description = description;
            Brand = brand;
        }
    }

    public class Test 
    {
        private void CreateRecord()
        {
            Product product = new Product("","",1);
        }
    }
}
