﻿////Composition= Relationship between Two Classes that allows one to contain the other
////*Benefits
////1) Code Re-USe
////2) Flexibilty
////3) A means to Loose-Coupling Apps
   
////Composition Syntax
//public class Installer
//{
    ////Notice that this is Private Field for Composition
    //private Logger _logger;

    ////Here, the Contructor of the Installer Class returns a logger Object, which we use to Intialize the Private field above
    //public Installer(Logger logger)
    //{
    //    _logger = logger;
    //}
//}

using System;
namespace CP3.AssociationClasses
{
    ////Let's start by creating a Logger Class where we have the common functionality
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    /// <summary>
    /// Compositions.
    /// </summary>
    public Class


    public class Compositions
    {
       static void Main(string[] args)
        {
            
        }
    }
}
