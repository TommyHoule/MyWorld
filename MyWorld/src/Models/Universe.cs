using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;

using MyWorld.Exceptions;

namespace MyWorld.Models
{
    public class Universe : AbstractModel
    {
        public ArrayList Superclusters = new ArrayList();
        
        public ArrayList getSuperclusters()
        {
            return Superclusters;
        }

        public Supercluster getSupercluster(int id)
        {
            return (Supercluster)Superclusters[id];
        }
    }
}