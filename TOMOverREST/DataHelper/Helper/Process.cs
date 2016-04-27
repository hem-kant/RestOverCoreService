using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOM.CoreServiceClient;
using Tridion.ContentManager.CoreService.Client;


namespace TOR.DataHelper.Helper
{
    public class Process
    {

        
         #region Process
        public static string GetSchemByTcmuri(string tcmuri, ICoreServiceFrameworkContext coreService)
        {

            var component = coreService.Client.Read(tcmuri, null);            
            var componentInOriginalContext = coreService.Client.Read(component.ToString(),null);
            return componentInOriginalContext.ToString();
        }
        #endregion
    }
}
