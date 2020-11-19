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

namespace TestingConectionToServerPython.Model
{
    public class Conecction
    {
        public Conecction() {
            
        }
        public string GetReleases1(string url) {
            var client = new WebClient();
            client.Headers.Add("dd");
            var response = client.DownloadString(url);
            return response;
        }
        public string ConnectionTest(string uirWebAPI, string exceptionMessage) {
            exceptionMessage=string.Empty;
            string webResponse = string.Empty;
          //  try
           // {
                Uri uri = new Uri(uirWebAPI);
                WebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(uri);
            //httpWebRequest.ContentType = "application/json";
            //httpWebRequest.ContentType = "application/xml";
            httpWebRequest.Method = "POST";
                
                using (StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream())) 
                {
                    //Esto es lo que envia al servidor (?) Si creo que si
                   
                    //dynamic employee = new Object();
                    //employee.username = "theUserName";
                    //employee.password = "thePassword";
                    //streamWriter.Write("d");
                   
                }
                
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                {
                    webResponse = streamReader.ReadToEnd();
                }
           // }
          //  catch(Exception ex)
           // {
           //     exceptionMessage = $"An error occurred. {ex.Message}";
           ///     Console.WriteLine(ex.Message);
           //     Console.ReadKey();
           // }
            return webResponse;
        }

        public string ConnectionTest2(string uirWebAPI)
        {
            string webResponse = string.Empty;
            Uri uri = new Uri(uirWebAPI);
            WebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(uri);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";//AQUI SERIA POST A LA HORA DE MANDAR INFO
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            /*Se quitaria esto cuando este el post
            using (StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write("d");
            }
            */
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                webResponse = streamReader.ReadToEnd();
            }
            
            return webResponse;
        }

       
        public string SendPatientToServer(string uirWebAPI, Patient patient/*Este es el path que le va a mandar al metodo encoder para retornarle en base64 y despues poder enciarlo al servidor en nuestro caso seria la ruta al archivo csv*/) {
            string webResponse = string.Empty;

            Uri uri = new Uri(uirWebAPI);
            WebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(uri);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            using (StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream())) {
                var jarray = JArray.FromObject(patient.getAttributes());
                streamWriter.Write(jarray);
            }
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream())) {
                webResponse = streamReader.ReadToEnd();
            }
                return webResponse;
        }
        public Image ImageFromAnURI(string urlWebApi) {
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
            var client = new WebClient();
            var response = client.DownloadString(uirWebAPI);
            return response;
        }


        private string Base64CsvEncoder(string csvPathName) {
            string base64Csv = string.Empty;
            Byte[] bytes = File.ReadAllBytes(csvPathName);
            base64Csv = Convert.ToBase64String(bytes);
            return base64Csv;
        }
        //Ya no mandar CSV si no el paciente en formato Json
        //Imagen por ruta hacer metodo

    }
}
