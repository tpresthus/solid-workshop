using System.Collections.Generic;
using System.Threading.Tasks;

namespace Excercises.FatInterface
{
    internal interface IStockManagement
    {
        Task<int> LinkItemsToParcel(List<string> itemIdList, string creator);
        IEnumerable<string> GetSerialNumbersInParcel(int parcelId);
        void CreateStockItem(StockItem request);
        void DeleteStockItem(int itemsdetailid);
        void ChangeStockNonSimCard(Stock stc);
        void ChangeStockWithSimCard(Stock stc);
        IEnumerable<int> GetParcels();
        Task<decimal> CheckIfSnExistsInParcel(string itemId);
        IEnumerable<WarehouseStock> GetWarehousesTotalStock();
        IEnumerable<WarehouseItemsStock> GetWarehouseItemsStock(string aktorId);
        IEnumerable<WarehouseItemDetail> GetWarehouseItemDetail(string aktorId, string itemsId);
        void RemoveItemFromParcel(string serialNumber, int parcelId);
        IEnumerable<ScannedItemDetails> GetSimCardScannedItemDetails(string serialNumber, string clientId);
        int CheckIfSimcardAlreadyInStockCountDetail(int simcardId, int stockCountNo);
        void InsertSimCardToProductStockCountingDetail(int stockCountNo, int simcardId, string clientId, decimal itemsId, string aktorRefId);
        void AddToStockOverride(int simcardId, string toStockClientId, string inStockClientId, string itemNumber, string aktorRefId, decimal itemsId);
        IEnumerable<StockCountItem> GetStockCountItemsList(string clientId);
        IEnumerable<StockCountProcess> GetStockCountProcesses(string clientId, int take = 5);
        IEnumerable<ProductStockCounting> GetProductStockCounting(int stockCountNo);
        IEnumerable<StockCountItem> GetProductsCountedForProcess(int stockCountNo, string clientId);
        int CheckIfNonSimCardAlreadyInStockCountDetail(int itemsDetailId, int stockCountNo);
        void InsertNonSimCardToProductStockCountingDetail(int stockCountNo, int itemsDetailId, string clientId, decimal itemsId, string aktorRefId);
        void MoveNonSimCardItemToNewStock(decimal itemsId, string clientId, int itemsDetailId);
        void DoProductTypeDetailInsert(decimal itemsid, int itemsdetailid, string clientid, string aktorrefid);
        void UpdateStockItemsIdIntemsDetail(decimal itemsId, int itemsDetailId);
        void IncrementCurrentStock(decimal increment, string itemnumber, string clientid);

        Items GetItemsByItemNumberAndClientId(string itemNumber, string clientId);
        ItemsDetail GetItemsDetailBySerialNumber(string serialNumber);
        ProductTypeDetail GetProductTypeDetailBySimCardId(decimal simCardId);
        ProductTypeDetail GetProductTypeDetailByItemsDetailId(int itemsDetailId);
        SimCard GetSimCardBySerialNumber(string serialNumber);
        void InsertProductLostInStockProduct(int stockCountNo, int itemsId, int amount, string clientId);
        void UpdateCurrentStock(decimal currentstock, decimal itemsId);
        void InsertIntoProductTypeUpdateLog(string aktorRefId, decimal itemsId, int oldStock, int newStock, int added, string clientId, int? simcardId);
        IEnumerable<ProductTypeDetail> GetProductTypeDetailListByItemsId(decimal itemsId);
        void DeleteFromProductTypeDetail(decimal productTypeDetailId);
        void InsertNonSimCardProductLostInStockProductDetail(int stockCountNo, int itemsId, int itemsDetailId, string clientId);
        void SetProductStockCountingStatus(int countingStatus, int itemsId, int stockCountNo, string clientId);
        void InsertIntoProductLostInStock(int stockCountNo, string aktorRefId);
        void InsertSimCardProductLostInStockProductDetail(int stockCountNo, int itemsId, int simCardId, string clientId);
        int GetNewStockCountNo(string clientId);
        IEnumerable<ScannedItemDetails> GetNonSimCardScannedItemDetails(string serialNumber, string clientId);
        Task<int> DeleteFromItemsDetail(string serialNumber);
    }
}
