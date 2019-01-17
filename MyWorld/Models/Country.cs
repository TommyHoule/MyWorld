using System;
using System.Collections;

namespace MyWorld.Models
{
    public class Country
    {
        
        private Guid _countryID;
        private string _name;
        public Country(string name){
            _countryID = Guid.NewGuid();
            _name = name;
        }
    }
}