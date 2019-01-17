using System;
using System.Collections;

namespace MyWorld.Models
{
    public class Continent
    {
        private Guid _continentID;
        private string _name;

        public Continent(){
            _continentID = Guid.NewGuid();
        }

        public Guid getContinentID(){
            return _continentID;
        }
        
        public string getName(){
            return _name;
        }
    }
}