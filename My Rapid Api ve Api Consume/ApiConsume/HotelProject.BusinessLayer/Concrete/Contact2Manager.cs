using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class Contact2Manager : IContact2Service
    {
        private readonly IContact2Dal _contact2Dal;

        public Contact2Manager(IContact2Dal contact2Dal)
        {
            _contact2Dal = contact2Dal;
        }

        public void TDelete(Contact2 t)
        {
            _contact2Dal.Delete(t);
        }

        public Contact2 TGetByID(int id)
        {
            return _contact2Dal.GetByID(id);
        }

        public List<Contact2> TGetList()
        {
            return _contact2Dal.GetList();
        }

        public void TInsert(Contact2 t)
        {
            _contact2Dal.Insert(t);
        }

        public void TUpdate(Contact2 t)
        {
            _contact2Dal.Update(t);
        }
    }
}
