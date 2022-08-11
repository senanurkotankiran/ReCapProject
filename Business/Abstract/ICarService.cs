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
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int id);
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);
        IDataResult<List<CarDetailDto>> GetCarDetails();

        IDataResult<List<CarFilterDto>> GetFilteredCars(int brandId, int colorId, int minDailyPrice, int maxDailyPrice);

        IDataResult<List<Car>> GetCarDetailsByBrandIdAndColorId(int brandId, int colorId);

        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);

        IResult AddTransactionalTest(Car car);

    }
}
