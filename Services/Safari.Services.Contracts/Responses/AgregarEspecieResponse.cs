using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Safari.Entities;


namespace Safari.Services.Contracts
{
    [DataContract]
    public partial class AgregarEspecieResponse
    {
        [DataMember]
        public Especie Result { get; set; }
    }
}

