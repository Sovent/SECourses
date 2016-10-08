using MovieAdviser.Domain;
using Newtonsoft.Json;
using System;
using System.IO;

namespace MovieAdviser.Infrastructure
{
    public class JsonFileRepository<T> : IRepository<T>
    {
        private string _databaseFilePath;

        public JsonFileRepository(string databaseFilePath)
        {
            _databaseFilePath = databaseFilePath;
        }

        public T[] GetAllEntities()
        {
            var serializedUsers = File.ReadAllText(_databaseFilePath);
            var userProfiles = JsonConvert.DeserializeObject<T[]>(serializedUsers);
            return userProfiles;
        }

        public T GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveEntity(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
