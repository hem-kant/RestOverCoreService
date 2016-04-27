using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Configuration;
using Newtonsoft.Json;
using System.Xml;
using TOR.TOMService.BAL.Utils;
using TOR.TOMService.BAL;


namespace TOR.OverRestService
{
    // NOTE: If you change the class name "Service1" here, you must also update the reference to "Service1" in Web.config and in the associated .svc file.
    public class RestService : IRestService
    {
        public string GetComponentByTcmUri(string tcmuri, string xmlOrJson)
        {
            string Output = string.Empty;
            string formattedData = string.Empty;
            try
            {
                if (ConfigurationManager.AppSettings["IsServiceEnabled"].ToString().ToLower() == "true")
                {
                    Logger.WriteLog(Logger.LogLevel.ERROR, "Calling GetComponentByTcmUri WCF RestService");
                    string data = NameSearchGeneration.getComponentByTcm(tcmuri, xmlOrJson);
                    Logger.WriteLog(Logger.LogLevel.ERROR, " Successfully executed GetComponentByTcmUri");
                    Output = data;

                }
                else
                {
                    Logger.WriteLog(Logger.LogLevel.ERROR, "Service is disabled ");
                    Output = "Error While get the Component data";
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(Logger.LogLevel.ERROR, ex.Message + "Error While Calling GetComponentByTcmUri");

            }
            return Output;
        }
        public string GetSchemaByTcmUri(string tcmuri, string xmlOrJson)
        {
            string Output = string.Empty;
            string formattedData = string.Empty;
            try
            {
                if (ConfigurationManager.AppSettings["IsServiceEnabled"].ToString().ToLower() == "true")
                {
                    Logger.WriteLog(Logger.LogLevel.ERROR, "Calling GetComponentByTcmUri WCF RestService");
                    string data = NameSearchGeneration.getSchemaByTcm(tcmuri, xmlOrJson);
                    Logger.WriteLog(Logger.LogLevel.ERROR, " Successfully executed GetComponentByTcmUri");
                    Output = data;

                }
                else
                {
                    Logger.WriteLog(Logger.LogLevel.ERROR, "Service is disabled ");
                    Output = "Error While get the Component data";
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(Logger.LogLevel.ERROR, ex.Message + "Error While Calling GetComponentByTcmUri");

            }
            return Output;
        }
        public string GetAllCategoriesWithInPubByTcmUri(string tcmuri, string xmljson)
        {
            string Output = string.Empty;
            string formattedData = string.Empty;
            try
            {
                if (ConfigurationManager.AppSettings["IsServiceEnabled"].ToString().ToLower() == "true")
                {
                    Logger.WriteLog(Logger.LogLevel.ERROR, "Calling GetComponentByTcmUri WCF RestService");
                    string data = NameSearchGeneration.GetAllCategoriesWithInPubByTcmUri(tcmuri, xmljson);
                    Logger.WriteLog(Logger.LogLevel.ERROR, " Successfully executed GetComponentByTcmUri");
                    Output = data;

                }
                else
                {
                    Logger.WriteLog(Logger.LogLevel.ERROR, "Service is disabled ");
                    Output = "Error While get the Component data";
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(Logger.LogLevel.ERROR, ex.Message + "Error While Calling GetComponentByTcmUri");

            }
            return Output;
        }
        public string GetKeywordByCategoryID(string categoryID, string xmljson)
        {
            string Output = string.Empty;
            string formattedData = string.Empty;
            try
            {
                if (ConfigurationManager.AppSettings["IsServiceEnabled"].ToString().ToLower() == "true")
                {
                    Logger.WriteLog(Logger.LogLevel.ERROR, "Calling GetComponentByTcmUri WCF RestService");
                    string data = NameSearchGeneration.GetKeywordByCategory(categoryID, xmljson);
                    Logger.WriteLog(Logger.LogLevel.ERROR, " Successfully executed GetComponentByTcmUri");
                    Output = data;

                }
                else
                {
                    Logger.WriteLog(Logger.LogLevel.ERROR, "Service is disabled ");
                    Output = "Error While get the Component data";
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(Logger.LogLevel.ERROR, ex.Message + "Error While Calling GetComponentByTcmUri");

            }
            return Output;
        }
        public string GetPageTempletByPubID(string PubID, string xmljson)
        {
            string Output = string.Empty;
            string formattedData = string.Empty;
            try
            {
                if (ConfigurationManager.AppSettings["IsServiceEnabled"].ToString().ToLower() == "true")
                {
                    Logger.WriteLog(Logger.LogLevel.ERROR, "Calling GetComponentByTcmUri WCF RestService");
                    string data = NameSearchGeneration.GetPageTempletByPubID(PubID, xmljson);
                    Logger.WriteLog(Logger.LogLevel.ERROR, " Successfully executed GetComponentByTcmUri");
                    Output = data;

                }
                else
                {
                    Logger.WriteLog(Logger.LogLevel.ERROR, "Service is disabled ");
                    Output = "Error While get the Component data";
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(Logger.LogLevel.ERROR, ex.Message + "Error While Calling GetComponentByTcmUri");

            }
            return Output;
        }

        public string GetComponentTemplateByPubID(string PubID, string xmljson)
        {
            string Output = string.Empty;
            string formattedData = string.Empty;
            try
            {
                if (ConfigurationManager.AppSettings["IsServiceEnabled"].ToString().ToLower() == "true")
                {
                    Logger.WriteLog(Logger.LogLevel.ERROR, "Calling GetComponentByTcmUri WCF RestService");
                    string data = NameSearchGeneration.GetComponentTemplateByPubID(PubID, xmljson);
                    Logger.WriteLog(Logger.LogLevel.ERROR, " Successfully executed GetComponentByTcmUri");
                    Output = data;

                }
                else
                {
                    Logger.WriteLog(Logger.LogLevel.ERROR, "Service is disabled ");
                    Output = "Error While get the Component data";
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(Logger.LogLevel.ERROR, ex.Message + "Error While Calling GetComponentByTcmUri");

            }
            return Output;
        }

        public string GetTemplateBuildingBlockByPubID(string PubID, string xmlOrJson)
        {
            string Output = string.Empty;
            string formattedData = string.Empty;
            try
            {
                if (ConfigurationManager.AppSettings["IsServiceEnabled"].ToString().ToLower() == "true")
                {
                    Logger.WriteLog(Logger.LogLevel.ERROR, "Calling GetComponentByTcmUri WCF RestService");
                    string data = NameSearchGeneration.GetTemplateBuildingBlockByPubID(PubID, xmlOrJson);
                    Logger.WriteLog(Logger.LogLevel.ERROR, " Successfully executed GetComponentByTcmUri");
                    Output = data;

                }
                else
                {
                    Logger.WriteLog(Logger.LogLevel.ERROR, "Service is disabled ");
                    Output = "Error While get the Component data";
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(Logger.LogLevel.ERROR, ex.Message + "Error While Calling GetComponentByTcmUri");

            }
            return Output;
        }

        public string GetPageByPubID(string PubID, string xmlOrJson)
        {
            string Output = string.Empty;
            string formattedData = string.Empty;
            try
            {
                if (ConfigurationManager.AppSettings["IsServiceEnabled"].ToString().ToLower() == "true")
                {
                    Logger.WriteLog(Logger.LogLevel.ERROR, "Calling GetComponentByTcmUri WCF RestService");
                    string data = NameSearchGeneration.GetPageByPubID(PubID, xmlOrJson);
                    Logger.WriteLog(Logger.LogLevel.ERROR, " Successfully executed GetComponentByTcmUri");
                    Output = data;

                }
                else
                {
                    Logger.WriteLog(Logger.LogLevel.ERROR, "Service is disabled ");
                    Output = "Error While get the Component data";
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(Logger.LogLevel.ERROR, ex.Message + "Error While Calling GetComponentByTcmUri");

            }
            return Output;
        }

        public string GetStructureGroupByPubID(string PubID, string xmlOrJson)
        {
            string Output = string.Empty;
            string formattedData = string.Empty;
            try
            {
                if (ConfigurationManager.AppSettings["IsServiceEnabled"].ToString().ToLower() == "true")
                {
                    Logger.WriteLog(Logger.LogLevel.ERROR, "Calling GetComponentByTcmUri WCF RestService");
                    string data = NameSearchGeneration.GetStructureGroupByPubID(PubID, xmlOrJson);
                    Logger.WriteLog(Logger.LogLevel.ERROR, " Successfully executed GetComponentByTcmUri");
                    Output = data;

                }
                else
                {
                    Logger.WriteLog(Logger.LogLevel.ERROR, "Service is disabled ");
                    Output = "Error While get the Component data";
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(Logger.LogLevel.ERROR, ex.Message + "Error While Calling GetComponentByTcmUri");

            }
            return Output;
        }

        public string GetMultimediaComponentByPubID(string PubID, string xmlOrJson)
        {
            string Output = string.Empty;
            string formattedData = string.Empty;
            try
            {
                if (ConfigurationManager.AppSettings["IsServiceEnabled"].ToString().ToLower() == "true")
                {
                    Logger.WriteLog(Logger.LogLevel.ERROR, "Calling GetMultimediaComponentByPubID WCF RestService");
                    string data = NameSearchGeneration.GetMultimediaComponentByPubID(PubID, xmlOrJson);
                    Logger.WriteLog(Logger.LogLevel.ERROR, " Successfully executed GetMultimediaComponentByPubID");
                    Output = data;
                }
                else
                {
                    Logger.WriteLog(Logger.LogLevel.ERROR, "Service is disabled ");
                    Output = "Error While get the GetMultimediaComponentByPubID data";
                }

            }
            catch (Exception ex)
            {
                Logger.WriteLog(Logger.LogLevel.ERROR, ex.Message + "Error While Calling GetMultimediaComponentByPubID");

            }
            return Output;
        }

        public string GetPublicationList(string xmlOrJson)
        {
            string Output = string.Empty;
            string formattedData = string.Empty;
            try
            {
                if (ConfigurationManager.AppSettings["IsServiceEnabled"].ToString().ToLower() == "true")
                {
                    Logger.WriteLog(Logger.LogLevel.ERROR, "Calling GetPublicationList WCF RestService");
                    string data = NameSearchGeneration.GetPublicationList(xmlOrJson);
                    Logger.WriteLog(Logger.LogLevel.ERROR, " Successfully executed GetPublicationList");
                    Output = data;
                }
                else
                {
                    Logger.WriteLog(Logger.LogLevel.ERROR, "Service is disabled ");
                    Output = "Error While get the GetPublicationList data";
                }

            }
            catch (Exception ex)
            {
                Logger.WriteLog(Logger.LogLevel.ERROR, ex.Message + "Error While Calling GetPublicationList");

            }
            return Output;
        }
        public string GetUserList(string xmlOrJson)
        {
            string Output = string.Empty;
            string formattedData = string.Empty;
            try
            {
                if (ConfigurationManager.AppSettings["IsServiceEnabled"].ToString().ToLower() == "true")
                {
                    Logger.WriteLog(Logger.LogLevel.ERROR, "Calling GetUserList WCF RestService");
                    string data = NameSearchGeneration.GetUserList(xmlOrJson);
                    Logger.WriteLog(Logger.LogLevel.ERROR, " Successfully executed GetUserList");
                    Output = data;
                }
                else
                {
                    Logger.WriteLog(Logger.LogLevel.ERROR, "Service is disabled ");
                    Output = "Error While get the GetUserList data";
                }

            }
            catch (Exception ex)
            {
                Logger.WriteLog(Logger.LogLevel.ERROR, ex.Message + "Error While Calling GetUserList");

            }
            return Output;
        }

        public string GetListOfAllFolder(string pubID)
        {
            string Output = string.Empty;
            string formattedData = string.Empty;
            try
            {
                if (ConfigurationManager.AppSettings["IsServiceEnabled"].ToString().ToLower() == "true")
                {
                    Logger.WriteLog(Logger.LogLevel.ERROR, "Calling GetUserList WCF RestService");
                    string data = NameSearchGeneration.GetListOfAllFolder(pubID);
                    Logger.WriteLog(Logger.LogLevel.ERROR, " Successfully executed GetUserList");
                    Output = data;
                }
                else
                {
                    Logger.WriteLog(Logger.LogLevel.ERROR, "Service is disabled ");
                    Output = "Error While get the GetUserList data";
                }

            }
            catch (Exception ex)
            {
                Logger.WriteLog(Logger.LogLevel.ERROR, ex.Message + "Error While Calling GetUserList");

            }
            return Output;
        }

    }
}
