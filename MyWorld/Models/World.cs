using System;
using System.Collections;

namespace MyWorld.Models
{
    public class World
    {
        private Guid _universeID { get; set; }
        private string _name;

        public string getName(){
            return _name;
        }
    }
}