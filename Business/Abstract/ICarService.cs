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
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int id);
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);

        IDataResult<List<CarDetailDto>> GetCarsDetails();
        IDataResult<List<CarDetailDto>> GetCarsDetailsByColorName(string colorName);
        IDataResult<List<CarDetailDto>> GetCarsDetailsByBrandName(string brandName);
        IDataResult<List<CarDetailDto>> GetCarsDetailsByBrandNameAndColorName(string brand, string color);
        IDataResult<CarDetailDto> GetCarDetailsById(int id);

    }
}
