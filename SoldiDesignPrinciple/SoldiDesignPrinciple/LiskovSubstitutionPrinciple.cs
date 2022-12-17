using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SoldiDesignPrinciple
{

    //The Likov Substitution Principle state that "You should be able to use any derived class instead of parent class and have it behave in the same manner without modification".
    //It ensure that a derived class does not affect the behaviour of the parent class, in other words, that a derived class mus be subsitutable for its base class.

    //It state that we should put an effort to create such derived class objects which can replace objects of the base class without compromising application integrity.
    //What this means essentially, is that we should put an effort to create such derived class objects which can replace objects of the base class without modifying its behavior.
    //If we don’t, our application might end up being broken.



    public abstract class Employee
    {
        public abstract void Information();
        public abstract double Bonus(double salary);
    }


    // if we want to follow LSP then our child class should follow the same signature provided by parent class

    public class FullTimeEmployee : Employee
    {
        public override void Information()
        {
            Console.WriteLine("Information about Employee.");
        }

        public override double Bonus(double salary)
        {
            return (salary * 40) / 100;
        }
    }

   
    // if our child class doesnot follow the signature of parent class
    // or if we cannot subsitute our base class by using its child class then the coding partice doesnoit follow the Liskov Subsitution Principle.

    public class LiskovSubstitutionPrinciple
    {
    }
}
