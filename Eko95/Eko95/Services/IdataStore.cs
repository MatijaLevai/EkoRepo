using Eko95.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Eko95.Services
{
    interface IdataStore
    {

        Task<bool> AddDeliveryAsync(DeliveryModel d );
        Task<bool> UpdateDeliveryAsync(DeliveryModel d);
        Task<bool> DeleteDeliveryAsync(string ID);
        Task<DeliveryModel> GetDeliveryAsync(string ID);
        Task<IEnumerable<DeliveryModel>> GetDeliveriesAsync(bool forceRefresh = false);
    }
}
