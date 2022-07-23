using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ImageManager : IImageService
    {
        IImageDal _imageDal;
        IFileHelper _fileHelper;

        public ImageManager(IImageDal imageDal, IFileHelper fileHelper)
        {
            _imageDal = imageDal;
            _fileHelper = fileHelper;
        }
        public IResult Add(IFormFile file, Image image)
        {
            IResult result = BusinessRules.Run(CheckIfImageLimit(image.CarId));
            if (result != null)
            {
                return result;
            }
            image.ImagePath = _fileHelper.Upload(file, PathConstant.ImagesPath);
            image.Date = DateTime.Now;
            _imageDal.Add(image);
            return new SuccessResult();
        }

        public IResult Delete(Image image)
        {
            _fileHelper.Delete(PathConstant.ImagesPath + image.ImagePath);
            _imageDal.Delete(image);
            return new SuccessResult();
        }

        public IDataResult<List<Image>> GetAll()
        {
            return new SuccessDataResult<List<Image>>(_imageDal.GetAll());
        }

        public IDataResult<List<Image>> GetByCarId(int carId)
        {
            var result = BusinessRules.Run(CheckCarImage(carId));
            if (result != null)
            {
                return new ErrorDataResult<List<Image>>(GetDefaultImage(carId).Data);
            }
            return new SuccessDataResult<List<Image>>(_imageDal.GetAll(c => c.CarId == carId));
        }

        public IDataResult<Image> GetByImageId(int imageId)
        {
            return new SuccessDataResult<Image>(_imageDal.Get(c => c.ImageId == imageId));
        }

        public IResult Update(IFormFile file, Image carImage)
        {
            carImage.ImagePath = _fileHelper.Update(file, PathConstant.ImagesPath + carImage.ImagePath, PathConstant.ImagesPath);
            _imageDal.Update(carImage);
            return new SuccessResult();
        }

        private IResult CheckIfImageLimit(int carId)
        {
            var result = _imageDal.GetAll(c => c.ImageId == carId).Count;

            if (result >= 5)
            {
                return new ErrorResult();
            }

            return new SuccessResult();
        }

        private IDataResult<List<Image>> GetDefaultImage(int carId)
        {
            List<Image> carImages = new List<Image>();
            carImages.Add(new Image { CarId = carId, Date = DateTime.Now, ImagePath = "default.jpg" });
            return new SuccessDataResult<List<Image>>(carImages);
        }

        private IResult CheckCarImage(int carId)
        {
            var result = _imageDal.GetAll(c => c.CarId == carId).Count;
            if (result > 0)
            {
                return new SuccessResult();
            }
            return new ErrorResult();
        }

    }
}
