﻿using System;

namespace Db40Spike.Domain
{
    public class Person : DomainBase
    {
        public Person(Name name)
        {
            this.name = name;
            id = Guid.NewGuid();
        }
       
        public void change_name_to(Name new_name)
        {
            name = new_name;
        }

        public Name name { get; private set; }

        public override string ToString()
        {
            return string.Format("{0}", name);
        }
    }
}