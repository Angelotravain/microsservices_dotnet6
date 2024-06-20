using GeekShopping.Email.Messages;

namespace GeekShopping.CartAPI.Repository
{
    public interface IEmailRepository
    {
        Task LogEmail(UpdatePaymentResultMessage message);

    }
}
