namespace Template_CifraDecifra_Testo.Models.Services.Application
{
    public interface ISecurityServices
    {
         string CifraTesto(string sTesto, string bRes = null);
         string DecifraTesto(string sTesto, string bRes = null);
    }
}