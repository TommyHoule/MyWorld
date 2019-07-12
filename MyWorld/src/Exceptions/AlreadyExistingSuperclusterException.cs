using System;
namespace MyWorld.Exceptions{
    public class AlreadyExistingSuperclusterException : Exception
    {
        public AlreadyExistingSuperclusterException()
            : base("A supercluster with the same name already exists in this universe !")
        {
        }
    }
}