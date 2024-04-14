using AnniesPastryShop.Core.Models.Order;

namespace AnniesPastryShop.Core.Contracts
{
    public interface IOrderServices
    {
        Task<int> PlaceOrderAsync(OrderViewModel model, int cartId, decimal grandTotalPrice, int customerId);
        Task<IEnumerable<PaymentMethodViewModel>> GetAllPaymentMethodsAsync();
        Task<PaymentMethodViewModel?> GetPaymentMethodByIdAsync(int id);
    }
}
