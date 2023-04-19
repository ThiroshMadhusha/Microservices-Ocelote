namespace Sliit.MTIT.Transport.Services
{
    public interface ITransportService
    {
        List<Models.Transport> GetTransports();

        Models.Transport? GetTransport(int id);

        Models.Transport? AddTransport(Models.Transport transport);

        Models.Transport? UpdateTransport(Models.Transport transport);

        bool? DeleteTransport(int id);
    }
}
