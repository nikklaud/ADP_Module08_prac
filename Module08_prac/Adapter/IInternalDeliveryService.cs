namespace Module08_prac.Adapter;

public interface IInternalDeliveryService
{
    void DeliveryOrder(string orderId);
    void GetDeliveryOrder(string orderId);
}