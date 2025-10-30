namespace Module08_prac.Adapter;

public class LogisticAdapterA: IInternalDeliveryService
{
    private readonly ExternalDeliveryServiceA _externalDeliveryService;

    public LogisticAdapterA(ExternalDeliveryServiceA externalDeliveryService)
    {
        _externalDeliveryService = externalDeliveryService;
    }

    public void DeliveryOrder(string orderId)
    {
        int order = Convert.ToInt32(orderId);
        _externalDeliveryService.ShipItem(order);
    }

    public void GetDeliveryOrder(string orderId)
    {
        int  order = Convert.ToInt32(orderId);
        _externalDeliveryService.TrackShipment(order);
    }
}