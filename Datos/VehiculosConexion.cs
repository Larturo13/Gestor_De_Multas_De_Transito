using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;
using Gestor_De_Multas_De_Transito.Modelo;
using Newtonsoft.Json;

namespace Gestor_De_Multas_De_Transito.Datos
{
    class VehiculosConexion
    {
        //httprequest que se comunica con la api de datos por medio de un POST
        public string IngresarDatos(Vehiculos objUser, string url)
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
        //httprequest que se comunica con la api de datos por medio de un PUT
        public string ActualizarDatos(Vehiculos objUser, string url)
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
        //httprequest que se comunica con la api de datos por medio de un DELETE
        public string EliminarDatos(VehiculosEli objUser, string url)
        {
            string respuesta;
            var request = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                request.ContentType = "application/json";
                request.Method = "DELETE";

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
        //httprequest que se comunica con la api de datos por medio de un POST
        public string AsignarDatos(AsignarVehiculo objUser, string url)
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
        //httprequest que se comunica con la api de datos por medio de un PUT
        public string ActualizarAsignacion(AsignarVehiculo objUser, string url)
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

        public string EliminarAsignacion(AsignarVehiculo objUser, string url)
        {
            string respuesta;
            var request = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                request.ContentType = "application/json";
                request.Method = "DELETE";

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
        //httprequest que se comunica con la api de datos por medio de un GET y devuelve un objeto
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
        //httprequest que se comunica con la api de datos por medio de un GET y devuelve una lista de objetos
        public async Task<string> GetHttp(string url)
        {
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }
    }
}
