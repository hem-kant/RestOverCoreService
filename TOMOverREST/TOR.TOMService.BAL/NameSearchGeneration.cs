using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  
using Tridion.ContentManager.CoreService.Client;
using System.Net;
using System.IO;
using System.Configuration;
using Newtonsoft.Json;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using TOR.TOMService.BAL.CoreServiceFramework;
using TOR.TOMService.BAL.Utils;
using System.Runtime.Serialization.Json;

namespace TOR.TOMService.BAL
{
    public class NameSearchGeneration
    {
        public static ICoreServiceFrameworkContext coreService = null;

        #region getComponentByTcmID
        public static string getComponentByTcm(string tcmuri,string xmljson)
        {
            try
            {
                coreService = CoreServiceFactory.GetCoreServiceContext(new Uri(ConfigurationManager.AppSettings["CoreServiceURL"].ToString()), new NetworkCredential(ConfigurationManager.AppSettings["UserName"].ToString(), ConfigurationManager.AppSettings["Password"].ToString(), ConfigurationManager.AppSettings["Domain"].ToString()));
                Logger.WriteLog(Logger.LogLevel.ERROR, "Entering in getComponentByTcm method");                 
                var component = coreService.Client.Read("tcm:-"+tcmuri, null) as ComponentData; 
                return xmljson.ToString().ToLower() == "json" ? JsonConvert.SerializeObject(component) : component.Content.ToString(); 
            }
       

            catch (Exception ex)
            {
                Logger.WriteLog(Logger.LogLevel.ERROR, ex.Message );
                return "Error";
            }

        }
        #endregion
        #region getSchemaFieldsByTcmID
        public static string getSchemaByTcm(string tcmuri, string xmljson)
        {
            try
            {
                string output = string.Empty;
                coreService = CoreServiceFactory.GetCoreServiceContext(new Uri(ConfigurationManager.AppSettings["CoreServiceURL"].ToString()), new NetworkCredential(ConfigurationManager.AppSettings["UserName"].ToString(), ConfigurationManager.AppSettings["Password"].ToString(), ConfigurationManager.AppSettings["Domain"].ToString()));
                Logger.WriteLog(Logger.LogLevel.ERROR, "Entering in getSchemaByTcm method");
                SchemaFieldsData schemaFieldsData = coreService.Client.ReadSchemaFields("tcm:"+tcmuri, false, null);
                if (xmljson.ToString().ToLower() =="json")
                {
                    output = JsonConvert.SerializeObject(schemaFieldsData);
                }
                else
                {
                    output = JsonConvert.SerializeObject(schemaFieldsData);
                    XmlDocument doc = new XmlDocument();

                    using (var reader = JsonReaderWriterFactory.CreateJsonReader(Encoding.UTF8.GetBytes(output), XmlDictionaryReaderQuotas.Max))
                    {
                        XElement xml = XElement.Load(reader);
                        doc.LoadXml(xml.ToString());
                    }
                    output = doc.InnerXml.ToString();
                }
                return output;// xmljson.ToString().ToLower() == "json" ? ConvertTojson.ConvertXmlToJson(schemasXml.ToString()) : schemasXml.ToString(); 
                
            }
        

            catch (Exception ex)
            {
                Logger.WriteLog(Logger.LogLevel.ERROR, ex.Message);
                return "Error";
            }

        }
        #endregion
        #region GetAllCategoriesWithInPubByPubID
        public static string GetAllCategoriesWithInPubByTcmUri(string tcmuri, string xmljson)
        {
            try
            {
                string output = string.Empty;
                coreService = CoreServiceFactory.GetCoreServiceContext(new Uri(ConfigurationManager.AppSettings["CoreServiceURL"].ToString()), new NetworkCredential(ConfigurationManager.AppSettings["UserName"].ToString(), ConfigurationManager.AppSettings["Password"].ToString(), ConfigurationManager.AppSettings["Domain"].ToString()));
                Logger.WriteLog(Logger.LogLevel.ERROR, "Entering in getSchemaByTcm method");
                var componentData = coreService.Client.GetList("tcm:" + tcmuri, new CategoriesFilterData()); //TridionComponent.GetAllCategoriesWithInPubByTcmUri(coreService, tcmuri);
                if (xmljson.ToString().ToLower() == "json")
                {
                    output = JsonConvert.SerializeObject(componentData);
                }
                else
                {
                    output = JsonConvert.SerializeObject(componentData);
                    XmlDocument doc = new XmlDocument();

                    using (var reader = JsonReaderWriterFactory.CreateJsonReader(Encoding.UTF8.GetBytes(output), XmlDictionaryReaderQuotas.Max))
                    {
                        XElement xml = XElement.Load(reader);
                        doc.LoadXml(xml.ToString());
                    }
                    output = doc.InnerXml.ToString();
                }
                return output;
            }


            catch (Exception ex)
            {
                Logger.WriteLog(Logger.LogLevel.ERROR, ex.Message);
                return "Error";
            }

        }
        #endregion
        #region GetKeywordByCategory
        public static string GetKeywordByCategory(string catID, string xmljson)
        {
            try
            {
                coreService = CoreServiceFactory.GetCoreServiceContext(new Uri(ConfigurationManager.AppSettings["CoreServiceURL"].ToString()), new NetworkCredential(ConfigurationManager.AppSettings["UserName"].ToString(), ConfigurationManager.AppSettings["Password"].ToString(), ConfigurationManager.AppSettings["Domain"].ToString()));
                Logger.WriteLog(Logger.LogLevel.ERROR, "Entering in getSchemaByTcm method");
                var filter = new OrganizationalItemItemsFilterData();
                var category = "tcm:" + catID;
                var keywords = coreService.Client.GetListXml(category, filter);

                return xmljson.ToString().ToLower() == "json" ? JsonConvert.SerializeObject(keywords) : keywords.ToString();
                 
            }


            catch (Exception ex)
            {
                Logger.WriteLog(Logger.LogLevel.ERROR, ex.Message);
                return "Error";
            }

        }
        #endregion
        #region GetPageTempletByPubID
        public static string GetPageTempletByPubID(string Pubid, string xmljson)
        {
            try
            {
                coreService = CoreServiceFactory.GetCoreServiceContext(new Uri(ConfigurationManager.AppSettings["CoreServiceURL"].ToString()), new NetworkCredential(ConfigurationManager.AppSettings["UserName"].ToString(), ConfigurationManager.AppSettings["Password"].ToString(), ConfigurationManager.AppSettings["Domain"].ToString()));

                Logger.WriteLog(Logger.LogLevel.ERROR, "Entering in GetPageTempletByPubID method");
                var filter = new RepositoryItemsFilterData();
                filter.ItemTypes = new[] { ItemType.PageTemplate, };
                filter.Recursive = true;
                var listXml = coreService.Client.GetListXml("tcm:"+Pubid, filter);
                //string output = JsonConvert.SerializeObject(listXml);
                return xmljson.ToLower() == "json" ? JsonConvert.SerializeObject(listXml) : listXml.ToString();
            }


            catch (Exception ex)
            {
                Logger.WriteLog(Logger.LogLevel.ERROR, ex.Message);
                return "Error";
            }

        }
        #endregion
        #region GetComponentTemplateByPubID
        public static string GetComponentTemplateByPubID(string Pubid, string xmljson)
        {
            try
            {
                coreService = CoreServiceFactory.GetCoreServiceContext(new Uri(ConfigurationManager.AppSettings["CoreServiceURL"].ToString()), new NetworkCredential(ConfigurationManager.AppSettings["UserName"].ToString(), ConfigurationManager.AppSettings["Password"].ToString(), ConfigurationManager.AppSettings["Domain"].ToString()));

                Logger.WriteLog(Logger.LogLevel.ERROR, "Entering in GetComponentTemplateByPubID method");
                var filter = new RepositoryItemsFilterData();
                filter.ItemTypes = new[] { ItemType.ComponentTemplate, };
                filter.Recursive = true;
                var listXml = coreService.Client.GetListXml("tcm:"+Pubid, filter);
                return xmljson.ToLower() == "json" ? JsonConvert.SerializeObject(listXml) : listXml.ToString();
            }


            catch (Exception ex)
            {
                Logger.WriteLog(Logger.LogLevel.ERROR, ex.Message);
                return "Error";
            }

        }
        #endregion
        #region GetTemplateBuildingBlockByPubID
        public static string GetTemplateBuildingBlockByPubID(string Pubid, string xmlOrJson)
        {
            try
            {
                coreService = CoreServiceFactory.GetCoreServiceContext(new Uri(ConfigurationManager.AppSettings["CoreServiceURL"].ToString()), new NetworkCredential(ConfigurationManager.AppSettings["UserName"].ToString(), ConfigurationManager.AppSettings["Password"].ToString(), ConfigurationManager.AppSettings["Domain"].ToString()));
                string output = string.Empty;
                Logger.WriteLog(Logger.LogLevel.ERROR, "Entering in GetPageByPubID method");
                var filter = new RepositoryItemsFilterData();
                filter.ItemTypes = new[] { ItemType.TemplateBuildingBlock, };
                filter.Recursive = true;
                var listXml = coreService.Client.GetListXml(Pubid, filter);
                if (xmlOrJson.ToString().ToLower() == "json")
                {
                    output = JsonConvert.SerializeObject(listXml);
                }
                else
                {
                    output = listXml.ToString();
                }

                return output;
            }


            catch (Exception ex)
            {
                Logger.WriteLog(Logger.LogLevel.ERROR, ex.Message);
                return "Error";
            }

        }
        #endregion
        #region GetPageByPubID
        public static string GetPageByPubID(string Pubid, string xmlOrJson)
        {
            try
            {
                coreService = CoreServiceFactory.GetCoreServiceContext(new Uri(ConfigurationManager.AppSettings["CoreServiceURL"].ToString()), new NetworkCredential(ConfigurationManager.AppSettings["UserName"].ToString(), ConfigurationManager.AppSettings["Password"].ToString(), ConfigurationManager.AppSettings["Domain"].ToString()));
                string output=string.Empty;
                Logger.WriteLog(Logger.LogLevel.ERROR, "Entering in GetPageByPubID method");
                var filter = new RepositoryItemsFilterData();
                filter.ItemTypes = new[] { ItemType.Page, };
                filter.Recursive = true;
                var listXml = coreService.Client.GetListXml("tcm:"+Pubid, filter);
                if (xmlOrJson.ToString().ToLower() =="json")
                {
                    output = JsonConvert.SerializeObject(listXml);
                }
                else
                {
                    output = listXml.ToString();
                }
                
                return output;
            }


            catch (Exception ex)
            {
                Logger.WriteLog(Logger.LogLevel.ERROR, ex.Message);
                return "Error";
            }

        }
        #endregion
        #region GetStructureGroupByPubID
        public static string GetStructureGroupByPubID(string Pubid, string xmlOrJson)
        {
            try
            {
                coreService = CoreServiceFactory.GetCoreServiceContext(new Uri(ConfigurationManager.AppSettings["CoreServiceURL"].ToString()), new NetworkCredential(ConfigurationManager.AppSettings["UserName"].ToString(), ConfigurationManager.AppSettings["Password"].ToString(), ConfigurationManager.AppSettings["Domain"].ToString()));
                string output = string.Empty;
                Logger.WriteLog(Logger.LogLevel.ERROR, "Entering in GetStructureGroupByPubID method");
                var filter = new RepositoryItemsFilterData();
                filter.ItemTypes = new[] { ItemType.StructureGroup, };
                filter.Recursive = true;
                var listXml = coreService.Client.GetListXml(Pubid, filter);
                if (xmlOrJson.ToString().ToLower() == "json")
                {
                    output = JsonConvert.SerializeObject(listXml);
                }
                else
                {
                    output = listXml.ToString();
                }

                return output;
            }


            catch (Exception ex)
            {
                Logger.WriteLog(Logger.LogLevel.ERROR, ex.Message);
                return "Error";
            }

        }
        #endregion
        #region GetMultimediaComponentByPubID
        public static string GetMultimediaComponentByPubID(string Pubid, string xmlOrJson)
        {
            try
            {
                coreService = CoreServiceFactory.GetCoreServiceContext(new Uri(ConfigurationManager.AppSettings["CoreServiceURL"].ToString()), new NetworkCredential(ConfigurationManager.AppSettings["UserName"].ToString(), ConfigurationManager.AppSettings["Password"].ToString(), ConfigurationManager.AppSettings["Domain"].ToString()));
                string output = string.Empty;
                Logger.WriteLog(Logger.LogLevel.ERROR, "Entering in GetStructureGroupByPubID method");
                var filter = new RepositoryItemsFilterData();
                filter.ItemTypes = new ItemType[] { ItemType.Component };
                filter.ComponentTypes = new ComponentType[] { ComponentType.Multimedia }; 

                filter.Recursive = true;
                var listXml = coreService.Client.GetListXml("tcm:"+Pubid, filter);
                if (xmlOrJson.ToString().ToLower() == "json")
                {
                    output = JsonConvert.SerializeObject(listXml);
                }
                else
                {
                    output = listXml.ToString();
                }

                return output;
            }


            catch (Exception ex)
            {
                Logger.WriteLog(Logger.LogLevel.ERROR, ex.Message);
                return "Error";
            }

        }
        #endregion
        #region GetPublicationList
        public static string GetPublicationList(string xmlOrJson)
        {
            try
            {
                coreService = CoreServiceFactory.GetCoreServiceContext(new Uri(ConfigurationManager.AppSettings["CoreServiceURL"].ToString()), new NetworkCredential(ConfigurationManager.AppSettings["UserName"].ToString(), ConfigurationManager.AppSettings["Password"].ToString(), ConfigurationManager.AppSettings["Domain"].ToString()));
                string output = string.Empty;
                Logger.WriteLog(Logger.LogLevel.ERROR, "Entering in GetPublicationList method");
                XmlDocument publicationList = new XmlDocument();
                PublicationsFilterData filter = new PublicationsFilterData();
                XElement publications = coreService.Client.GetSystemWideListXml(filter);
                publicationList.Load(publications.CreateReader());
                if (xmlOrJson.ToString().ToLower() == "json")
                {
                    output = JsonConvert.SerializeObject(publicationList);
                }
                else
                {
                    output = publicationList.InnerXml.ToString();
                }
                return output;
            }


            catch (Exception ex)
            {
                Logger.WriteLog(Logger.LogLevel.ERROR, ex.Message);
                return "Error";
            }

        }
        #endregion
        #region GetUserList
        public static string GetUserList(string xmlOrJson)
        {
            try
            {
                coreService = CoreServiceFactory.GetCoreServiceContext(new Uri(ConfigurationManager.AppSettings["CoreServiceURL"].ToString()), new NetworkCredential(ConfigurationManager.AppSettings["UserName"].ToString(), ConfigurationManager.AppSettings["Password"].ToString(), ConfigurationManager.AppSettings["Domain"].ToString()));
                string output = string.Empty;
                Logger.WriteLog(Logger.LogLevel.ERROR, "Entering in GetUserList method");
                var listXml = coreService.Client.GetSystemWideListXml(new UsersFilterData { BaseColumns = ListBaseColumns.IdAndTitle, IsPredefined = false });
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(listXml.ToString());
                output = xmlOrJson.ToString().ToLower() == "json" ? JsonConvert.SerializeObject(doc) : doc.ToString();
                return output;
               
            }
            catch (Exception ex)
            {
                Logger.WriteLog(Logger.LogLevel.ERROR, ex.Message);
                return "Error";
            }

        }
        #endregion


        #region GetListOfAllFolder
        public static string GetListOfAllFolder(string pubID)
        {
            try
            {
                coreService = CoreServiceFactory.GetCoreServiceContext(new Uri(ConfigurationManager.AppSettings["CoreServiceURL"].ToString()), new NetworkCredential(ConfigurationManager.AppSettings["UserName"].ToString(), ConfigurationManager.AppSettings["Password"].ToString(), ConfigurationManager.AppSettings["Domain"].ToString()));
                string output = string.Empty;
                Logger.WriteLog(Logger.LogLevel.ERROR, "Entering in GetUserList method");
                var rootFolderUri = "tcm:" + pubID;
                OrganizationalItemItemsFilterData filter = new OrganizationalItemItemsFilterData();

                var listXml = coreService.Client.GetListXml(rootFolderUri, filter);
                return output;

            }
            catch (Exception ex)
            {
                Logger.WriteLog(Logger.LogLevel.ERROR, ex.Message);
                return "Error";
            }

        }
        #endregion


    }
}
