using MyWorld.Exceptions;
using System;
using System.Collections;

namespace MyWorld.Models
{
    public class Supercluster : AbstractModel
    {
        public ArrayList GalaxyClusters = new ArrayList();

        public ArrayList getGalaxyClusters()
        {
            return GalaxyClusters;
        }

        public GalaxyCluster getGalaxyCluster(int id)
        {
            return (GalaxyCluster)GalaxyClusters[id];
        }
    }
}