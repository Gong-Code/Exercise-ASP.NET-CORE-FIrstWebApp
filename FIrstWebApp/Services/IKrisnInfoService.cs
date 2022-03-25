namespace FIrstWebApp.Services
{
    public interface IKrisInfoService
    {
        List<KrisInfo> GetAllKrisInformation();
        List<KrisInfo> GetEmergencies();
        KrisInfo GetKrisInformation(string id);
    }
}
