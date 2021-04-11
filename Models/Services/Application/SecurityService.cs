using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Template_CifraDecifra_Testo.Models.Services.Application
{
    public class SecurityService : ISecurityServices
    {
        string ISecurityServices.CifraTesto(string sTesto, string bRes)
        {
            string pTesto = string.Empty;

            pTesto = null;
            pTesto = CifraStringa(sTesto);
            bRes = pTesto;

            return bRes;
        }

        string ISecurityServices.DecifraTesto(string sTesto, string bRes)
        {
            string pTesto = string.Empty;

            pTesto = null;
            pTesto = DecifraStringa(sTesto);
            bRes = pTesto;

            return bRes;
        }

        private string CifraStringa(string sString)
        {
            var sRet = new StringBuilder();
            int i;
            int tVal;
            for (i = 0; i < sString.Length; i++)
            {
                tVal = Strings.Asc(sString[i]) + 1;
                sRet.Append(Strings.Format(tVal, "000"));
            }
            return sRet.ToString();
        }

        private string DecifraStringa(string sString)
        {
            var sRet = new StringBuilder();
            string pRet = "";
            int i;
            int tVal;
            for (i = 0; i <= (int)(sString.Length / 3d - 1d); i++)
            {
                tVal = Conversions.ToInteger(sString.Substring(i * 3, 3)) - 1;
                pRet = pRet + (char)tVal;
            }
            sRet.Append(Strings.Format(pRet));
            return sRet.ToString();
        }
    }
}