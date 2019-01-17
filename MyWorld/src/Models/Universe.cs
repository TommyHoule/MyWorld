using MyWorld.Exceptions;
using System;
using System.Collections;

namespace MyWorld.Models
{
    public class Universe
    {
        //Private members
        private Guid _universeID;
        private string _name;
        private ArrayList _worlds;

        //Constructor
        public Universe(string name){
            _universeID = Guid.NewGuid();
            _name = name;
            _worlds = new ArrayList();
        }
        
        //Methods
        public Guid getUniverseID(){
            return _universeID;
        }
        public ArrayList getWorlds(){
            return _worlds;
        }
        public World getWorld(int id){

            return (World)_worlds[id];
        }

        public void addWorld(World worldToAdd){
            Boolean worldExists = false;
            foreach(World world in _worlds){
                if(world.getName() == worldToAdd.getName()){
                    worldExists = true;
                }
            }
            if(!worldExists){
                _worlds.Add(worldToAdd);
            }
            else{
                throw new AlreadyExistingWorldException();
            }
        }

        public void deleteWorld(World worldToRemove){
            throw new NotImplementedException();
        }
    }
}