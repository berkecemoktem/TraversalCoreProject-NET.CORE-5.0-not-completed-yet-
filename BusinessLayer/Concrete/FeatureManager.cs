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
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal _featureDal)
        {
            this._featureDal = _featureDal;
        }

        public void Tadd(Feature t)
        {
            throw new NotImplementedException();
        }

        public void Tdelete(Feature t)
        {
            throw new NotImplementedException();
        }

        public Feature TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feature> TGetList()
        {
            return _featureDal.GetList();
        }

        public void Tupdate(Feature t)
        {
            throw new NotImplementedException();
        }
    }
}
