using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Structurizr.Model
{

    /// <summary>
    /// A person who uses a software system.
    /// </summary>
    [DataContract]
    public class Person : Element, IEquatable<Person>
    {

        /// <summary>
        /// The location of this person.
        /// </summary>
        [DataMember(Name = "location", EmitDefaultValue = false)]
        public Location Location { get; set; }

        public override string CanonicalName
        {
            get
            {
                return CanonicalNameSeparator + FormatForCanonicalName(Name);
            }
        }

        public Person() : base()
        {
        }

        public bool Equals(Person person)
        {
            return this.Equals(person as Element);
        }

    }
}