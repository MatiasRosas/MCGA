//====================================================================================================
// Base code generated with LeatherGoods - ASF.Services.Contracts
// Architecture Solutions Foundation
//
// Generated by academic at LeatherGoods V 1.0 
//====================================================================================================

using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ASF.Entities;


namespace ASF.Services.Contracts
{
    
    [DataContract]
    public class AllResponse
    {
        [DataMember]
        public List<Category> Result { get; set; }

        //[DataMember]
        //public List<Country> ResultCountry { get; set; }
    }

    [DataContract]
    public class AllResponseCountry
    {
        [DataMember]
        public List<Country> Result { get; set; }
    }

    [DataContract]
    public class AllResponseClient
    {
        [DataMember]
        public List<Client> Result { get; set; }
    }

    [DataContract]
    public class AllResponseDealer
    {
        [DataMember]
        public List<Dealer> Result { get; set; }
    }

    [DataContract]
    public class AllResponseCart
    {
        [DataMember]
        public List<Cart> Result { get; set; }
    }

    [DataContract]
    public class AllResponseCartItem
    {
        [DataMember]
        public List<CartItem> Result { get; set; }
    }
}

