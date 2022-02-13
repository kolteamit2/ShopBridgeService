using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ShopBridgeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IShopBridgeService
    {
        ShopBridgeEntities shopBridge = new ShopBridgeEntities();

        public List<InventoryDetail> GetInventoryDetail()
        {
            return shopBridge.InventoryDetails.Where(x => x.IsDeleted == false).OrderByDescending(y => y.Id).ToList();
        }

        public InventoryDetail GetInventoryDetailByInventoryId(int inventoryId)
        {
            return shopBridge.InventoryDetails.FirstOrDefault(x => x.Id == inventoryId);
        }

        public bool SaveInventoryDetail(InventoryDetail request)
        {
            ShopBridgeEntities shopBridge = new ShopBridgeEntities();

            InventoryDetail entity = new InventoryDetail();
            entity.ItemName = request.ItemName;
            entity.ItemDescription = request.ItemDescription;
            entity.ItemPrice = request.ItemPrice;
            entity.IsDeleted = false;

            shopBridge.InventoryDetails.Add(entity);
            shopBridge.SaveChanges();

            return true;
        }

        public bool UpdateInventoryDetail(InventoryDetail request)
        {
            ShopBridgeEntities shopBridge = new ShopBridgeEntities();

            InventoryDetail entity = shopBridge.InventoryDetails.FirstOrDefault(x => x.Id == request.Id);
            if (entity != null)
            {
                entity.ItemName = request.ItemName;
                entity.ItemDescription = request.ItemDescription;
                entity.ItemPrice = request.ItemPrice;
                entity.IsDeleted = false;

                shopBridge.InventoryDetails.Attach(entity);
                shopBridge.Entry(entity).State = EntityState.Modified;
                shopBridge.SaveChanges();

                return true;
            }

            return false;
        }

        public bool DeleteInventoryDetail(int inventoryId)
        {
            ShopBridgeEntities shopBridge = new ShopBridgeEntities();

            InventoryDetail entity = shopBridge.InventoryDetails.FirstOrDefault(x => x.Id == inventoryId);
            if (entity != null)
            {   
                entity.IsDeleted = true;

                shopBridge.InventoryDetails.Attach(entity);
                shopBridge.Entry(entity).State = EntityState.Modified;
                shopBridge.SaveChanges();

                return true;
            }

            return false;
        }
    }
}
