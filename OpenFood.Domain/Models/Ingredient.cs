using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace OpenFood.Domain.Models
{

    [DataContract]
    public class Ingredient
    {

        [DataMember(Name = "text")]
        public string Text { get; set; }
    }
}
