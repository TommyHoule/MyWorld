using System;
public class AlreadyExistingWorldException : Exception
{
    public AlreadyExistingWorldException()
        : base("A world with the same name already exists in this universe !")
    {
    }
}