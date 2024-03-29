﻿using AutoMapper;
using Bussines.Absract;
using Bussines.BusinessAspects.Autofac;
using Bussines.Constants;
using Bussines.Constants.Messages;
using Bussines.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Results;
using DataAccess.Absract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;

namespace Bussines.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        IMapper _mapper;
        IFileHelper _fileHelper;

        public CarImageManager(ICarImageDal carImageDal, IMapper mapper, IFileHelper fileHelper = null)
        {
            _carImageDal = carImageDal;
            _mapper = mapper;
            _fileHelper = fileHelper;
        }
        [SecuredOperation("moderator,CarImage,admin")]
        [ValidationAspect(typeof(CarImageValidator))]
        [CacheRemoveAspect("ICarImageDal.Get")]
        public IResult Add(IFormFile file, CarImageDto carImageDto)
        {
            var result = BusinessRules.Run(checkCarImagesLimit(carImageDto.CarId));
            if (result != null)
            {
                return result;
            }

            carImageDto.ImagePath = _fileHelper.Upload(file, PathConstants.ImagesPath);
            _carImageDal.Add(_mapper.Map<CarImage>(carImageDto));
            return new SuccessResult(CarImageMessages.CarImageAdded);

        }

        [SecuredOperation("admin")]
        public IResult Delete(CarImageDto carImageDto)
        {
            _fileHelper.Delete(PathConstants.ImagesPath + carImageDto.ImagePath);
            _carImageDal.Delete(_mapper.Map<CarImage>(carImageDto));
            return new SuccessResult(CarImageMessages.CarImageDeleted);
        }
        [CacheAspect]
        public IDataResult<List<CarImageDto>> GetAll()
        {
            return new SuccessDataResult<List<CarImageDto>>(_mapper.Map<List<CarImageDto>>(_carImageDal.GetAll()), CarImageMessages.CarImagesListed);
        }
        [CacheAspect]
        public IDataResult<List<CarImageDto>> GetByCarId(int carId)
        {
            var result = BusinessRules.Run(checkCarImage(carId));

            if (result != null)
            {
                return new ErrorDataResult<List<CarImageDto>>(GetDefaultImage(carId).Data, result.Message);
            }

            return new SuccessDataResult<List<CarImageDto>>(_mapper.Map<List<CarImageDto>>(_carImageDal.GetAll(c => c.CarId == carId)), CarImageMessages.CarImagesListed);


        }

        public IDataResult<CarImageDto> GetByImageId(int imageId)
        {
            return new SuccessDataResult<CarImageDto>(_mapper.Map<CarImageDto>(_carImageDal.Get(c => c.Id == imageId)), CarImageMessages.CarImagesListed);
        }
        [SecuredOperation("CarImage,admin")]
        [ValidationAspect(typeof(CarImageValidator))]
        [CacheRemoveAspect("ICarImageDal.Get")]
        public IResult Update(IFormFile file, CarImageDto carImageDto)
        {
            carImageDto.ImagePath = _fileHelper.Update(file, PathConstants.ImagesPath + carImageDto.ImagePath, PathConstants.ImagesPath);
            _carImageDal.Update(_mapper.Map<CarImage>(carImageDto));
            return new SuccessResult();
        }


        private IDataResult<List<CarImageDto>> GetDefaultImage(int carId)
        {
            List<CarImageDto> carImageDtos = new List<CarImageDto>();
            carImageDtos.Add(new CarImageDto { CarId = carId, ImagePath = "Default.jpg", CreatedDate = DateTime.Now });

            return new SuccessDataResult<List<CarImageDto>>(carImageDtos);
        }

        private IResult checkCarImagesLimit(int carId)
        {
            int carImagesCount = _carImageDal.GetAll(c => c.CarId == carId).Count;
            if (carImagesCount >= 5)
            {
                return new ErrorResult(CarImageMessages.ExceedsMaxCarImagesMessage);
            }
            return new SuccessResult();

        }
        private IResult checkCarImage(int carId)
        {
            bool carImages = _carImageDal.GetAll(c => c.CarId == carId).Any();
            if (carImages)
            {
                return new SuccessResult();
            }
            return new ErrorResult(CarImageMessages.DefaultCarImageMessage);
        }
    }
}
