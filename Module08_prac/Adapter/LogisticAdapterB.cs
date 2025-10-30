namespace Module08_prac.Adapter;

public class LogisticAdapterB: IInternalDeliveryService
{
    private readonly ExternalDeliveryServiceB _externalDeliveryService;

    public LogisticAdapterB(ExternalDeliveryServiceB externalDeliveryService)
    {
        _externalDeliveryService = externalDeliveryService;
    }

    public void DeliveryOrder(string orderId)
    {
        _externalDeliveryService.SendPackage(orderId);
    }

    public void GetDeliveryOrder(string orderId)
    {
        _externalDeliveryService.CheckPackageStatus(orderId);
    }
}