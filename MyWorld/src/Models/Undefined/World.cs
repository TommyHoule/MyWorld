using MyWorld.Exceptions;
using System;
using System.Collections;

namespace MyWorld.Models
{
    public class World
    {
        private Guid _worldID;
        private string _name;
        private ArrayList _continents;

        public World(string name){
            _worldID = Guid.NewGuid();
            _name = name;
            _continents = new ArrayList();
        }

        public Guid getWorldID(){
            return _worldID;
        }

        public string getName(){
            return _name;
        }

        public ArrayList getContinents(){
            return _continents;
        }
        public Continent getContinent(int id){
            return (Continent) _continents[id];
        }

        public void addContinent(Continent continentToAdd){
            Boolean continentExists = false;
            foreach(Continent continent in _continents){
                if(continent.getName() == continentToAdd.getName()){
                    continentExists = true;
                }
            }
            if(!continentExists){
                _continents.Add(continentToAdd);
            }
            else{
                throw new AlreadyExistingWorldException();
            }
        }

        public void deleteContinent(Continent continentToRemove){
            throw new NotImplementedException();
        }
    }
}