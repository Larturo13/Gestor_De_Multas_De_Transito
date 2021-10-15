using Gestor_De_Multas_De_Transito.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Gestor_De_Multas_De_Transito.Datos
{
    class IngresoPersonas
    {
        public string IngresarDatos(Personas objUser)
        {
            string respuesta;
            var request = (HttpWebRequest)WebRequest.Create("https://webapimultas.azurewebsites.net/api/InsertarPer");
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
    }
}
