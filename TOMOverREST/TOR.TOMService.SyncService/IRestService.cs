using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;


namespace TOR.OverRestService
{
    // NOTE: If you change the interface name "IService1" here, you must also update the reference to "IService1" in Web.config.
    [ServiceContract]
    public interface IRestService
    {

        [OperationContract(Name = "GetComponentByTcmUri")]
        [WebGet(UriTemplate = "/GetComponentByTcmUri/{tcmuri}/{xmlOrJson}")]
        string GetComponentByTcmUri(string tcmuri, string xmlOrJson);

        [OperationContract(Name = "GetSchemaByTcmUri")]
        [WebGet(UriTemplate = "/GetSchemaByTcmUri/{tcmuri}/{xmlOrJson}")]
        string GetSchemaByTcmUri(string tcmuri, string xmlOrJson);

        [OperationContract(Name = "GetAllCategoriesWithInPubByTcmUri")]
        [WebGet(UriTemplate = "/GetAllCategoriesWithInPubByTcmUri/{tcmuri}/{xmlOrJson}")]
        string GetAllCategoriesWithInPubByTcmUri(string tcmuri, string xmlOrJson);

        [OperationContract(Name = "GetKeywordByCategoryID")]
        [WebGet(UriTemplate = "/GetKeywordByCategoryID/{catID}/{xmlOrJson}")]
        string GetKeywordByCategoryID(string catID, string xmlOrJson);

        [OperationContract(Name = "GetPageTempletByPubID")]
        [WebGet(UriTemplate = "/GetPageTempletByPubID/{pubID}/{xmlOrJson}")]
        string GetPageTempletByPubID(string pubID, string xmlOrJson);

        [OperationContract(Name = "GetComponentTemplateByPubID")]
        [WebGet(UriTemplate = "/GetComponentTemplateByPubID/{pubID}/{xmlOrJson}")]
        string GetComponentTemplateByPubID(string pubID, string xmlOrJson);

        [OperationContract(Name = "GetTemplateBuildingBlockByPubID")]
        [WebGet(UriTemplate = "/GetTemplateBuildingBlockByPubID/{pubID}/{xmlOrJson}")]
        string GetTemplateBuildingBlockByPubID(string pubID, string xmlOrJson);

        [OperationContract(Name = "GetPageByPubID")]
        [WebGet(UriTemplate = "/GetPageByPubID/{pubID}/{xmlOrJson}")]
        string GetPageByPubID(string pubID, string xmlOrJson);

        [OperationContract(Name = "GetStructureGroupByPubID")]
        [WebGet(UriTemplate = "/GetStructureGroupByPubID/{pubID}/{xmlOrJson}")]
        string GetStructureGroupByPubID(string pubID, string xmlOrJson);

        [OperationContract(Name = "GetMultimediaComponentByPubID")]
        [WebGet(UriTemplate = "/GetMultimediaComponentByPubID/{pubID}/{xmlOrJson}")]
        string GetMultimediaComponentByPubID(string pubID, string xmlOrJson);

        [OperationContract(Name = "GetPublicationList")]
        [WebGet(UriTemplate = "/GetPublicationList/{xmlOrJson}")]
        string GetPublicationList(string xmlOrJson);

        [OperationContract(Name = "GetUserList")]
        [WebGet(UriTemplate = "/GetUserList/{xmlOrJson}")]
        string GetUserList(string xmlOrJson);

        [OperationContract(Name = "GetListOfAllFolder")]
        [WebGet(UriTemplate = "/GetListOfAllFolder/{pubID}")]
        string GetListOfAllFolder(string pubID);
         
    }


    
    
}
