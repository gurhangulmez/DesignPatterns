using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDesignPattern
{
    class Customer : Person
    {
        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }

        public string City { get; set; }
    }
}
