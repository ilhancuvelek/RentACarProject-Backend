using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        public IDataResult<List<Car>> GetAll();
        public IResult Add(Car car);
        public IResult Update(Car car);
        public IResult Delete(Car car);
        IDataResult<Car> GetById(int id);
        public IDataResult<List<Car>> GetAllByBrandId(int Bid);
        public IDataResult<List<Car>> GetAllByColorId(int Cid);

        public IDataResult<List<CarDetailDto>> GetCarDetails();
    }
}
