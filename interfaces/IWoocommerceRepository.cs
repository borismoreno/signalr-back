using signal.Entities;

namespace signal.Repositories;

public interface IWoocommerceRepository
{
    Task CreateAsync(Webhook weebhook);
}