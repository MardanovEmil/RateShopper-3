using System.Net.Http;
using System.Net;
using System.Threading.Tasks;

namespace Project.Storage
{
    internal class HtmlLoader
    {
        readonly HttpClient client;
        readonly string url;

        public HtmlLoader(IParserSettings settings)
        {
            client = new HttpClient();
            url = settings.Url[1];
        }
        public async Task<string> GetSourceByUrl (int id)
        {
            var response = await client.GetAsync(url);
            string source = null;

            if (response != null && response.StatusCode == HttpStatusCode.OK)
            {
                source = await response.Content.ReadAsStringAsync();
            }

            return source;

        }
    }
}
