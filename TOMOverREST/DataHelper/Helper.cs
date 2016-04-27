/*
 * This document set is the property of Sapient Corporation, and contains
 * confidential and trade secret information. It cannot be transferred from
 * the custody or control of Sapient except as authorized in writing by an
 * officer of Sapient. Neither this item nor the information it contains can
 * be used, transferred, reproduced, published, or disclosed, in whole or in
 * part, directly or indirectly, except as expressly authorized by an officer
 * of Sapient, pursuant to written agreement.
 * 
 * Copyright(c) Sapient Corp. 2009
 * 
 * File Name    : Helper
 * Author       : rkum32
 * Date Created : 5/12/2010 8:40:06 PM
 */


using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;
namespace Sapient.AMP.ContentEntryService.DataHelper
{
    public static class Helper
    {

        public static Image DownloadImage(string _URL, string targetPath)
        {
            Image _tmpImage = null;

            try
            {

                // Open a connection

                System.Net.HttpWebRequest _HttpWebRequest = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(_URL);

                _HttpWebRequest.AllowWriteStreamBuffering = true;

                // You can also specify additional header values like the user agent or the referer: (Optional)

                //_HttpWebRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1)";

                //_HttpWebRequest.Referer = "http://www.google.com/";

                // set timeout for 20 seconds (Optional)

                _HttpWebRequest.Timeout = 20000;

                // Request response:

                System.Net.WebResponse _WebResponse = _HttpWebRequest.GetResponse();

                // Open data stream:

                System.IO.Stream _WebStream = _WebResponse.GetResponseStream();

                // convert webstream to image

                _tmpImage = Image.FromStream(_WebStream);

                // Cleanup

                _WebResponse.Close();

                _WebResponse.Close();

                _tmpImage.Save(targetPath);

            }

            catch (Exception _Exception)
            {

                // Error

                Console.WriteLine("Exception caught in process: {0}", _Exception.ToString());

                return null;

            }



            return _tmpImage;

        }
        public static string GenerateRandomFileName(string path)
        {

            Random ran = new Random();
            int randomVal =1;
            while (File.Exists(String.Format(path, randomVal)))
            {
                randomVal = ran.Next(1, 9999);
            }
            return String.Format(path, randomVal);
            
        }

    }
}
