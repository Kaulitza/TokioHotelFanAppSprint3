using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokioHotelFanApp.DataLayer.Repository
{
    class AlbumRepository : IRepository
    {
        public List<IRepository> GetAll()
        {
            return new List<IRepository>()
            {

            };
        }
        public IRepository GetById(int id)
        {
            return new AlbumRepository()
            {

            };
        }
        public void Create(IRepository entity)
        {

        }
        public void Update(IRepository entity)
        {

        }
        public void Delete(int id)
        {

        }
    }
}
