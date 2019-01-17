using System;
using System.Collections;

namespace MyWorld.Models
{
    public class Continent
    {
        private Guid _continentID;
        private string _name;

        public Continent(string name){
            _continentID = Guid.NewGuid();
            _name = name;
        }

        public Guid getContinentID(){
            return _continentID;
        }
        
        public string getName(){
            return _name;
        }
    }
}