using Gestor_De_Multas_De_Transito.Modelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;

namespace Gestor_De_Multas_De_Transito.Datos
{
    class GenerarMulta
    {
        public string IngresarDatos(GenMulta objUser, string url)
        {
            string respuesta;
            var request = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                request.ContentType = "application/json";
                request.Method = "POST";

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(objUser);
                    streamWriter.Write(json);
                }

                var response = (HttpWebResponse)request.GetResponse();


                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    respuesta = result.ToString();
                }


            }
            catch (Exception ex)
            {
                respuesta = ex.Message;

            }
            return respuesta;
        }
        public string EliminarDatos(GenMultaPag objUser, string url)
        {
            string respuesta;
            var request = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                request.ContentType = "application/json";
                request.Method = "PUT";

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(objUser);
                    streamWriter.Write(json);
                }

                var response = (HttpWebResponse)request.GetResponse();


                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    respuesta = result.ToString();
                }


            }
            catch (Exception ex)
            {
                respuesta = ex.Message;

            }
            return respuesta;
        }
        public dynamic Get(string url)
        {

            HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create(url);
            myWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101 Firefox/23.0";
            //myWebRequest.CookieContainer = myCookie;
            myWebRequest.Credentials = CredentialCache.DefaultCredentials;
            myWebRequest.Proxy = null;
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
            Stream myStream = myHttpWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myStream);
            //Leemos los datos
            string Datos = HttpUtility.HtmlDecode(myStreamReader.ReadToEnd());

            dynamic data = JsonConvert.DeserializeObject(Datos);

            return data;
        }
        public async Task<string> GetHttp(string url)
        {
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }
    }
}
