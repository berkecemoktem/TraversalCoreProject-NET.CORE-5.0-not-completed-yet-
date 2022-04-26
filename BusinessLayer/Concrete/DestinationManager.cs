using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DestinationManager : IDestinationService
    {
        IDestinationDal _destinationDal;

        public DestinationManager(IDestinationDal _destinationDal)
        {
            this._destinationDal = _destinationDal;
        }

        public void Tadd(Destination t)
        {
            throw new NotImplementedException();
        }

        public void Tdelete(Destination t)
        {
            throw new NotImplementedException();
        }

        public Destination TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Destination> TGetList()
        {
            return _destinationDal.GetList();
        }

        public void Tupdate(Destination t)
        {
            throw new NotImplementedException();
        }
    }
}
