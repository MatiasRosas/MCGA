﻿//====================================================================================================
// Base code generated with LeatherGoods
// Architecture Solutions Foundation
//
// Generated by academic at LeatherGoods V 1.0 
//====================================================================================================

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;


namespace ASF.Entities
{
    /// <summary>
    /// Represents a state of an order.
    /// </summary>
    [Serializable]
    [DataContract]
    public class State
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        [DisplayName("Id")]
        [Browsable(false)]
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        [DisplayName("Description")]
        public string Description { get; set; }

    }
}
