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
using System.Globalization;

namespace ASF.Entities
{
    /// <summary>
    /// Represents a row of entity data.
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class LocaleResourceKey : EntityBase
    {
        [DataMember]
        [DisplayName("Id")]
        [Browsable(false)]
        public int Id { get; set; }

        /// <summary>
        /// Clave que identifica a una traducciÃ³n.
        /// </summary>
        [DataMember]
        [DisplayName("Name")]
        public string Name { get; set; }

        /// <summary>
        /// Notas sobre la traducciÃ³n.
        /// </summary>
        [DataMember]
        [DisplayName("Notes")]
        public string Notes { get; set; }

        /// <summary>
        /// Fecha en la que se aÃ±adiÃ³
        /// </summary>
        [DataMember]
        [DisplayName("Date Added")]
        public DateTime DateAdded { get; set; }

    }
}
