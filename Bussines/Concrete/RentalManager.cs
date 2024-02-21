﻿using AutoMapper;
using Bussines.Absract;
using Bussines.Constants.Messages;
using Bussines.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Absract;
using Entities.Concrete;
using Entities.DTOs;

namespace Bussines.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        IMapper _mapper;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public RentalManager(IRentalDal rentalDal, IMapper mapper)
        {
            _rentalDal = rentalDal;
            _mapper = mapper;
        }

        [ValidationAspect(typeof(RentalDtoValidator))]
        public IResult Add(RentalDto rentalDto)
        {
            var isAvailable = _rentalDal.GetAll(p => p.CarId == rentalDto.CarId && p.ReturnDate == null).Any();
            if (isAvailable == true)
            {
                return new ErrorResult(RentalMessages.CarIsNotAvailable);

            }
            else
            {
                _rentalDal.Add(_mapper.Map<Rental>(rentalDto));
                return new SuccessResult(RentalMessages.RentalAdded);
            }

        }

        public IResult Delete(RentalDto rentalDto)
        {

            _rentalDal.Delete(_mapper.Map<Rental>(rentalDto));
            return new SuccessResult(RentalMessages.RentalDeleted);
        }

        public IDataResult<List<RentalDto>> GetAll()
        {
            return new SuccessDataResult<List<RentalDto>>(_mapper.Map<List<RentalDto>>(_rentalDal.GetAll()), RentalMessages.RentalsListed);
        }

        public IDataResult<RentalDto> GetById(int id)
        {
            return new SuccessDataResult<RentalDto>(_mapper.Map<RentalDto>(_rentalDal.Get(p => p.Id == id)), RentalMessages.RentalsListed);
        }

        [ValidationAspect(typeof(RentalDtoValidator))]
        public IResult Update(RentalDto rentalDto)
        {
            _rentalDal.Update(_mapper.Map<Rental>(rentalDto));
            return new SuccessResult(RentalMessages.RentalUpdated);


        }
    }
}
