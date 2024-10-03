using RestSharp;
using System.Xml.Serialization;

namespace WebApp.services
{
    public class SanitizeService
    {
        static readonly string SANITIZE_URL = "http://www.purgomalum.com/service/xml";

        public string SanitizeText(string rawValue)
        {
            var client = new RestClient(SANITIZE_URL);
            var request = new RestRequest();
            request.AddParameter("text", rawValue);
            var response = client.Execute(request);

            if (!string.IsNullOrWhiteSpace(response.Content))
            {
                // Code to deserialize content XML here
                var serializer = new XmlSerializer(typeof(PurgoMalum));
                using (StringReader sr = new StringReader(response.Content))
                {
                    PurgoMalum? filtered = (PurgoMalum?)serializer.Deserialize(sr);
                    return filtered.result;
                }
            }

            return string.Empty;
        }


    }
}
