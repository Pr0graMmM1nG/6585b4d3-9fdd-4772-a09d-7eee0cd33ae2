using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DataBaseLibrary;
using DataBaseLibrary.Models;


namespace Library
{
    public class Service
    {
        private readonly DataBaseLibrary.Repository.SQLite.CRUD _cmdSql;
        private List<IName> _entityList;

        #region Constructors

        public Service()
        {
           _cmdSql = new DataBaseLibrary.Repository.SQLite.CRUD();
        }

        #endregion

        public void SetEntity(IName entity)
        {
            if (entity!=null)
            {
                _entityList.Add(entity);
            }
        
        }
        public void SavePriceList()
        {

           
        }

    }
}
