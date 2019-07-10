using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;

using MyWorld.Exceptions;

namespace MyWorld.Models
{
    public class Universe
    {
        //Private members
        public long Id { get; set; }
        public string Name  { get; set; }
        public string Description { get; set; }
        public ArrayList Worlds = new ArrayList();
        
        public ArrayList getWorlds()
        {
            return Worlds;
        }

        public World getWorld(int id)
        {
            return (World)Worlds[id];
        }

        public String getInfo()
        {
            var toString =
                Description + "\n\n" +
                "ID :" + this.Id + "\n" +
                "NAME :" + this.Name + "\n" +
                "NUMBER_OF_WORLDS :" + this.Worlds.Count + "\n";

            return toString;
        }

        public void addWorld(World worldToAdd)
        {
            Boolean worldExists = false;

            foreach(World world in Worlds){
                if(world.getName() == worldToAdd.getName()){
                    worldExists = true;
                }
            }

            if(!worldExists){
                Worlds.Add(worldToAdd);
            }
            else{
                throw new AlreadyExistingWorldException();
            }
        }

        public void deleteWorld(World worldToRemove){
            throw new NotImplementedException();
        }
    }

    public class UniverseContext : DbContext
    {
        public UniverseContext(DbContextOptions<UniverseContext> options)
            : base(options)
        {
        }

        public DbSet<Universe> UniverseItems { get; set; }
    }
}