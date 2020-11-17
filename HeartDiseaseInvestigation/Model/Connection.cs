using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using System.Drawing;
using Newtonsoft.Json.Linq;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace HeartDiseaseInvestigation.Model
{
    public class Connection
    {
        public Connection()
        {

        }
        public string SendPatientToServer(string uirWebAPI, Patient patient)
        {
            string webResponse = string.Empty;
            Uri uri = new Uri(uirWebAPI);
            WebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(uri);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            using (StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string stringJson = JsonConvert.SerializeObject(patient);
                streamWriter.Write(stringJson);
            }
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                webResponse = streamReader.ReadToEnd();
            }
            return webResponse;
        }
        public Image ImageFromAnURI(string urlWebApi)
        {
            string urlImage = GetImageURL(urlWebApi);
            Image image = null;
            Uri uri = new Uri(urlImage);
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(uri);
            WebResponse webResponse = webRequest.GetResponse();
            Stream stream = webResponse.GetResponseStream();
            image = Image.FromStream(stream);
            webResponse.Close();
            return image;
        }
        private string GetImageURL(string uirWebAPI)
        {
            string uriImage = string.Empty;
            Uri uri = new Uri(uirWebAPI);
            WebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(uri);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                var webResponse = streamReader.ReadToEnd();
                var completeString = new JavaScriptSerializer().Deserialize<Dictionary<string, string>>(webResponse);
                uriImage = completeString["url"];
            }
            return uriImage;
        }
        public string Train(string url)
        {
            var client = new WebClient();
            var response = client.DownloadString(url);
            return response;
        }









        //Ya no mandar CSV si no el paciente en formato Json
        //Imagen por ruta hacer metodo
    }
}
