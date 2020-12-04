using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokioHotelFanApp.DataLayer.Repository
{
    public interface IRepository
    {
        List<IRepository> GetAll();
        IRepository GetById(int id);
        void Create(IRepository entity);
        void Update(IRepository entity);
        void Delete(int id);
    }
}