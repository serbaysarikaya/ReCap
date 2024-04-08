using AutoMapper;
using Bussines.Absract;
using Core.Utilities.Results;
using DataAccess.Absract;
using Entities.Concrete;
using Entities.DTOs;

namespace Bussines.Concrete
{
    public class PaymentManager : IPaymentService
    {
        IPaymentDal _paymenDal;
        IMapper _mapper;

        public PaymentManager(IMapper mapper, IPaymentDal paymenDal)
        {
            _mapper = mapper;
            _paymenDal = paymenDal;
        }

        public IResult Add(PaymentDto paymentDto)
        {
            _paymenDal.Add(_mapper.Map<Payment>(paymentDto));
            return new SuccessResult("Payment Added");
        }
        public IResult Update(PaymentDto paymentDto)
        {
            _paymenDal.Update(_mapper.Map<Payment>(paymentDto));
            return new SuccessResult("Payment UPdated");
        }

        public IResult Delete(PaymentDto paymentDto)
        {
            _paymenDal.Delete(_mapper.Map<Payment>(paymentDto));
            return new SuccessResult("PAyment Deleted");
        }

        public IDataResult<List<PaymentDto>> GetAll()
        {
            return new SuccessDataResult<List<PaymentDto>>(_mapper.Map<List<PaymentDto>>(_paymenDal.GetAll()));

        }

        public IDataResult<PaymentDto> GetByPaymentId(int paymentId)
        {
            return new SuccessDataResult<PaymentDto>(_mapper.Map<PaymentDto>(_paymenDal.Get(p => p.Id == paymentId)), "Success message");
        }
    }
}
