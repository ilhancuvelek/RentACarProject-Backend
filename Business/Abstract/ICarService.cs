using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        public List<Car> GetAll();
        public void Add(Car car);
        public void Update(Car car);
        public void Delete(Car car);
        public List<Car> GetAllByBrandId(int Bid);
        public List<Car> GetAllByColorId(int Cid);

        public List<CarDetailDto> GetCarDetails();
    }
}
