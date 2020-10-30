using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGitProj.ServiceLayer
{
    interface IAllReopository<T> where T:class 
    {

        IEnumerable<T> GetModel();  //All the in the form of the List
        T GetModelById(T modelId);  // Finde By Id
        void InsertModel(T model);  // Insertion
        void DeleteModel(int modelId); // Deletion
        void UpdateModel(T model);  // Updatation
        void Save();       //Save
    }
}
