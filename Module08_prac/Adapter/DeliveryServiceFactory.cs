namespace Module08_prac.Adapter;

public static class DeliveryServiceFactory
{
    public static IInternalDeliveryService CreateDeliveryService(string type)
    {
        switch (type)
        {
            case "A":
                return new LogisticAdapterA(new ExternalDeliveryServiceA());
            case "B":
                return new LogisticAdapterB(new ExternalDeliveryServiceB());
            default:
                throw new Exception("Unknown DeliveryService");
        }
    }
}