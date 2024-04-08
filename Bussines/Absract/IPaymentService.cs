using Core.Utilities.Results;
using Entities.DTOs;

namespace Bussines.Absract
{
    public interface IPaymentService
    {
        IResult Add(PaymentDto paymentDto);
        IResult Update(PaymentDto paymentDto);
        IResult Delete(PaymentDto paymentDto);

        IDataResult<List<PaymentDto>> GetAll();
        IDataResult<PaymentDto> GetByPaymentId(int paymentId);



    }
}
