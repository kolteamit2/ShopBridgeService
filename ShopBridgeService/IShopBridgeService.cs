using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ShopBridgeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IShopBridgeService
    {
        [OperationContract]
        List<InventoryDetail> GetInventoryDetail();

        [OperationContract]
        InventoryDetail GetInventoryDetailByInventoryId(int inventoryId);

        [OperationContract]
        bool SaveInventoryDetail(InventoryDetail request);

        [OperationContract]
        bool UpdateInventoryDetail(InventoryDetail request);

        [OperationContract]
        bool DeleteInventoryDetail(int inventoryId);
    }
}
