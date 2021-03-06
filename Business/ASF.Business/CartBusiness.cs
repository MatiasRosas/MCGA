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
    /// CartBusiness business component.
    /// </summary>
    public class CartBusiness
    {

        /// <summary>
        /// Add method. 
        /// </summary>
        /// <param name="cart"></param>
        /// <returns></returns>
        public Cart Add(Cart cart)
        {
            var cartDac = new CartDAC();
            return cartDac.Create(cart);
        }

        /// <summary>
        /// Delete method.
        /// </summary>
        /// <param name="id"></param>
        public void Remove(int id)
        {
            var cartDac = new CartDAC();
            cartDac.DeleteById(id);
        }

        /// <summary>
        /// FindAll method.
        /// </summary>
        /// <returns></returns>
        public List<Cart> All()
        {
            var cartDac = new CartDAC();
            var result = cartDac.Select();
            return result;
        }

        /// <summary>
        /// Find method.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Cart Find(int id)
        {
            var cartDac = new CartDAC();
            var result = cartDac.SelectById(id);
            return result;
        }

        /// <summary>
        /// Update method.
        /// </summary>
        /// <param name="cart"></param>
        public void Edit(Cart cart)
        {
            var cartDac = new CartDAC();
            cartDac.UpdateById(cart);
        }

    }
}
