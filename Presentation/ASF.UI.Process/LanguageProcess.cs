using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using ASF.Entities;
using ASF.Services.Contracts;
using ASF.UI.Process;

namespace ASF.UI.Process
{
    public class LanguageProcess : ProcessComponent
    {

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Language> SelectList()
        {
            var response = HttpGet<AllResponseLanguage>("rest/Language/All", new Dictionary<string, object>(), MediaType.Json);
            return response.Result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Language Find(int id)
        {
            var path = "rest/Language/Find/" + id;
            var response = HttpGet<FindResponseLanguage>(path, new Dictionary<string, object>(), MediaType.Json);
            return response.Result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Language FindByLang(string id)
        {
            var path = "rest/Language/FindByLang/" + id;
            var response = HttpGet<FindResponseLanguage>(path, new Dictionary<string, object>(), MediaType.Json);
            return response.Result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public void Insert(Language lang)
        {
            var response = HttpPost<Language>("rest/Language/Add", lang, MediaType.Json);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public void Delete(int id)
        {
            var path = "rest/Language/Remove/" + id;
            var response = HttpGet<FindResponseLanguage>(path, new Dictionary<string, object>(), MediaType.Json);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public void Edit(Language lang)
        {
            var response = HttpPost<Language>("rest/Language/Edit", lang, MediaType.Json);
        }

    }
}
