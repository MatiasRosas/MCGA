﻿//====================================================================================================
// Base code generated with LeatherGoods - ASF.Services.Http
// Architecture Solutions Foundation
//
// Generated by academic at LeatherGoods V 1.0 
//====================================================================================================

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ASF.Business;
using ASF.Entities;
using ASF.Services.Contracts;

namespace ASF.Services.Http
{
    public class LocaleResourceKeyService : ApiController
    {

        [HttpPost]
        [Route("Add")]
        public LocaleResourceKey Add(LocaleResourceKey locres)
        {
            try
            {
                var blc = new LocaleResourceKeyBusiness();
                return blc.Add(locres);
            }
            catch (Exception ex)
            {
                var httpError = new HttpResponseMessage()
                {
                    StatusCode = (HttpStatusCode)422,
                    ReasonPhrase = ex.Message
                };

                throw new HttpResponseException(httpError);
            }
        }

        [HttpGet]
        [Route("All")]
        public AllResponseLocaleResourceKey All()
        {
            try
            {
                var response = new AllResponseLocaleResourceKey();
                var blc = new LocaleResourceKeyBusiness();
                response.Result = blc.All();
                return response;
            }
            catch (Exception ex)
            {
                var httpError = new HttpResponseMessage()
                {
                    StatusCode = (HttpStatusCode)422,
                    ReasonPhrase = ex.Message
                };

                throw new HttpResponseException(httpError);
            }
        }

        [HttpPost]
        [Route("Edit")]
        public void Edit(LocaleResourceKey locres)
        {
            try
            {
                var blc = new LocaleResourceKeyBusiness();
                blc.Edit(locres);
            }
            catch (Exception ex)
            {
                var httpError = new HttpResponseMessage()
                {
                    StatusCode = (HttpStatusCode)422,
                    ReasonPhrase = ex.Message
                };

                throw new HttpResponseException(httpError);
            }
        }

        [HttpGet]
        [Route("Find/{id}")]
        public FindResponseLocaleResourceKey Find(int id)
        {
            try
            {
                var response = new FindResponseLocaleResourceKey();
                var blc = new LocaleResourceKeyBusiness();
                response.Result = blc.Find(id);
                return response;
            }
            catch (Exception ex)
            {
                var httpError = new HttpResponseMessage()
                {
                    StatusCode = (HttpStatusCode)422,
                    ReasonPhrase = ex.Message
                };

                throw new HttpResponseException(httpError);
            }
        }

        [HttpGet]
        [Route("Remove/{id}")]
        public void Remove(int id)
        {
            try
            {
                var blc = new LocaleResourceKeyBusiness();
                blc.Remove(id);
            }
            catch (Exception ex)
            {
                var httpError = new HttpResponseMessage()
                {
                    StatusCode = (HttpStatusCode)422,
                    ReasonPhrase = ex.Message
                };

                throw new HttpResponseException(httpError);
            }
        }

    }
}
