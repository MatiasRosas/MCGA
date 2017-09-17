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
    public class FindResponse
    {
        [DataMember]
        public Category Result { get; set; }

        //[DataMember]
        //public Country ResultCountry { get; set; }
    }

    [DataContract]
    public class FindResponseCountry
    {
        [DataMember]
        public Country Result { get; set; }
    }

    [DataContract]
    public class FindResponseClient
    {
        [DataMember]
        public Client Result { get; set; }
    }

    [DataContract]
    public class FindResponseDealer
    {
        [DataMember]
        public Dealer Result { get; set; }
    }

    [DataContract]
    public class FindResponseCart
    {
        [DataMember]
        public Cart Result { get; set; }
    }

    [DataContract]
    public class FindResponseCartItem
    {
        [DataMember]
        public CartItem Result { get; set; }
    }

    [DataContract]
    public class FindResponseOrder
    {
        [DataMember]
        public Order Result { get; set; }
    }

    [DataContract]
    public class FindResponseOrderDetail
    {
        [DataMember]
        public OrderDetail Result { get; set; }
    }

    [DataContract]
    public class FindResponseOrderNumber
    {
        [DataMember]
        public OrderNumber Result { get; set; }
    }

    [DataContract]
    public class FindResponseProduct
    {
        [DataMember]
        public Product Result { get; set; }
    }
}

