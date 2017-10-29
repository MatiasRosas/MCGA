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
   public class LocaleStringResourceProcess : ProcessComponent
    {

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<LocaleStringResource> SelectList()
        {
            var response = HttpGet<AllResponseLocaleStringResource>("rest/LocaleStringResource/All", new Dictionary<string, object>(), MediaType.Json);
            return response.Result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public LocaleStringResource Find(int id)
        {
            var path = "rest/LocaleStringResource/Find/" + id;
            var response = HttpGet<FindResponseLocaleStringResource>(path, new Dictionary<string, object>(), MediaType.Json);
            return response.Result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public void Insert(LocaleStringResource locstr)
        {
            var response = HttpPost<LocaleStringResource>("rest/LocaleStringResource/Add", locstr, MediaType.Json);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public void Delete(int id)
        {
            var path = "rest/LocaleStringResource/Remove/" + id;
            var response = HttpGet<FindResponseLocaleStringResource>(path, new Dictionary<string, object>(), MediaType.Json);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public void Edit(LocaleStringResource locstr)
        {
            var response = HttpPost<LocaleStringResource>("rest/LocaleStringResource/Edit", locstr, MediaType.Json);
        }

    }
}
