using CashFlow.Communication.Enums;
using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;

namespace CashFlow.Application.UserCase.Expenses.Register
{
    public class RegisterExpensesUseCase
    {
        public ResponseRegisteredExpenseJson Execute(RequestRegisterExpensesJson request)
        {
            Validate(request);
            return new ResponseRegisteredExpenseJson();
        }

        private void Validate(RequestRegisterExpensesJson request)
        {
            if (string.IsNullOrWhiteSpace(request.Tilte))
            {
                throw new ArgumentException("The tilte is required.");
            }

            if (request.Amount <= 0)
            {
                throw new ArgumentException("The Amount must be greater than zero.");
            }

            if (DateTime.Compare(request.Date, DateTime.UtcNow) > 0)
            {
                throw new ArgumentException("Expenses cannot be for the future");
            }

            if (Enum.IsDefined(typeof(PaymentType), request.PaymentType))
            {
                throw new ArgumentException("Payment type is not valid.");
            }
        }
    }
}
