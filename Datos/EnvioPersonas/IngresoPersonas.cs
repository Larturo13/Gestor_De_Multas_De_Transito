using Gestor_De_Multas_De_Transito.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Gestor_De_Multas_De_Transito.Grafico.Personas;
using Newtonsoft.Json;
using RestSharp;
using System.Web;
using System.Windows.Forms;


namespace Gestor_De_Multas_De_Transito.Datos.EnvioPersonas
{
    class IngresoPersonas
    {
        public string IngresarDatos(Personas objUser)
        {
            string respuesta;
            var request = (HttpWebRequest)WebRequest.Create("http://apimultas.azurewebsites.net/api/AccPer/");
            var request = (HttpWebRequest)WebRequest.Create("https://webapimultas.azurewebsites.net/api/InsertarPer");
=========
            var request = (HttpWebRequest)WebRequest.Create("https://webapimultas.azurewebsites.net/api/AccPer");
>>>>>>>>> Temporary merge branch 2
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

        public string ActualizarDatos(Personas objUser)
        {
            string respuesta;
            var request = (HttpWebRequest)WebRequest.Create("http://apimultas.azurewebsites.net/api/AccPer/");
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

}
            return respuesta;
        }
>>>>>>>>> Temporary merge branch 2
    }
}
