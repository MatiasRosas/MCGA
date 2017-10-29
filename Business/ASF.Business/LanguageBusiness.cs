﻿//====================================================================================================
// Base code generated with LeatherGoods - ASF.Business
// Architecture Solutions Foundation
//
// Generated by academic at LeatherGoods V 1.0 
//====================================================================================================

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ASF.Entities;
using ASF.Data;

namespace ASF.Business
{
    /// <summary>
    /// LanguageBusiness business component.
    /// </summary>
    public class LanguageBusiness
    {

        /// <summary>
        /// Add method. 
        /// </summary>
        /// <param name="lang"></param>
        /// <returns></returns>
        public Language Add(Language lang)
        {
            var langDac = new LanguageDAC();
            return langDac.Create(lang);
        }

        /// <summary>
        /// Delete method.
        /// </summary>
        /// <param name="id"></param>
        public void Remove(int id)
        {
            var langDac = new LanguageDAC();
            langDac.DeleteById(id);
        }

        /// <summary>
        /// FindAll method.
        /// </summary>
        /// <returns></returns>
        public List<Language> All()
        {
            var langDac = new LanguageDAC();
            var result = langDac.Select();
            return result;
        }

        /// <summary>
        /// Find method.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Language Find(int id)
        {
            var langDac = new LanguageDAC();
            var result = langDac.SelectById(id);
            return result;
        }

        /// <summary>
        /// Find by language culture
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Language FindByLangCulture(string langcult)
        {
            var langDac = new LanguageDAC();
            var result = langDac.SelectByLanguageCulture(langcult);
            return result;
        }

        /// <summary>
        /// Update method.
        /// </summary>
        /// <param name="lang"></param>
        public void Edit(Language lang)
        {
            var langDac = new LanguageDAC();
            langDac.UpdateById(lang);
        }

    }
}
