using MyWorld.Exceptions;
using System;
using System.Collections;

namespace MyWorld.Models
{
    public abstract class AbstractModel
    {

        public long Id { get; set; }
        public string Name  { get; set; }
        public string Description { get; set; }

        public String getInfo()
        {
            var toString =
                Description + "\n\n" +
                "ID :" + this.Id + "\n" +
                "NAME :" + this.Name + "\n";

            return toString;
        }
    }
}