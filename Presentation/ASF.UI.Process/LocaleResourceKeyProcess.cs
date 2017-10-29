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
    public class LocaleResourceKeyProcess : ProcessComponent
    {

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<LocaleResourceKey> SelectList()
        {
            var response = HttpGet<AllResponseLocaleResourceKey>("rest/LocaleResourceKey/All", new Dictionary<string, object>(), MediaType.Json);
            return response.Result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public LocaleResourceKey Find(int id)
        {
            var path = "rest/LocaleResourceKey/Find/" + id;
            var response = HttpGet<FindResponseLocaleResourceKey>(path, new Dictionary<string, object>(), MediaType.Json);
            return response.Result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public void Insert(LocaleResourceKey locres)
        {
            var response = HttpPost<LocaleResourceKey>("rest/LocaleResourceKey/Add", locres, MediaType.Json);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public void Delete(int id)
        {
            var path = "rest/LocaleResourceKey/Remove/" + id;
            var response = HttpGet<FindResponseLocaleResourceKey>(path, new Dictionary<string, object>(), MediaType.Json);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public void Edit(LocaleResourceKey locres)
        {
            var response = HttpPost<LocaleResourceKey>("rest/LocaleResourceKey/Edit", locres, MediaType.Json);
        }

    }
}
