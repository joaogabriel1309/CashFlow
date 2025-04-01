using CashFlow.Communication.Requests;
using FluentValidation;

namespace CashFlow.Application.UseCase.Expenses.Register
{
    public class RegisterExpensesValidator : AbstractValidator<RequestRegisterExpensesJson>
    {
        public RegisterExpensesValidator()
        {
            RuleFor(expense => expense.Tilte).NotEmpty().WithMessage("The tilte is required.");
            RuleFor(expense => expense.Amount).GreaterThan(0).WithMessage("The Amount must be greater than zero.");
            RuleFor(expense => expense.Date).LessThanOrEqualTo(DateTime.UtcNow).WithMessage("Expenses cannot be for the future");
            RuleFor(expense => expense.PaymentType).IsInEnum().WithMessage("Payment type is not valid.");
        }
    }
}
