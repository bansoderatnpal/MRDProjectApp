using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyGitProj.DAL;
using System.Data.Entity;
namespace MyGitProj.ServiceLayer
{
    public class IAllRepositoryImplimantaion<T> : IAllReopository<T> where T : class
    {
        //Connection String..
        private MrdDBEntities db;
        private IDbSet<T> dbEntity;

        public IAllRepositoryImplimantaion()
        {
            db = new MrdDBEntities();
            dbEntity = db.Set<T>();
        }

        public void DeleteModel(int modelId)
        {
            T model = dbEntity.Find(modelId);
            dbEntity.Remove(model);
        }

        public IEnumerable<T> GetModel()
        {
            return dbEntity.ToList();

        }

        public T GetModelById(T modelId)
        {
            return dbEntity.Find(modelId);
        }

        public void InsertModel(T model)
        {
            dbEntity.Add(model);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void UpdateModel(T model)
        {
            db.Entry(model).State = EntityState.Modified;
        }
    }
}