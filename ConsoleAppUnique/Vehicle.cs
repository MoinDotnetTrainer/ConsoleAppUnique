using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUnique
{
    public abstract class Vehicle
    {
        // break stops a vehicle
        // accel --> vehicle moves
        public abstract void Break();
        public abstract void Accelerate();

        public virtual void Speed() {  // object  , child support 
        }

        public void TestDrive() {   // obj
        }
        public static void Service()
        {   // obj
        }


        //with abstrct key ,  only a decleration , no impl , class shoule be abstr

    }

    public class KTM : Vehicle
    {
        public override void Break() { }
        public override void Accelerate() { }

    }

    public class Activa : Vehicle
    {
        public override void Break() { }
        public override void Accelerate() { }

    }


    public abstract class Accenture {
        public abstract void ProjectDetails();
    }

    public class IT : Accenture
    {
        public override void ProjectDetails() { }
    }

    public class HR : Accenture
    {
        public override void ProjectDetails() { }
    }
    public class Sales : Accenture
    {
        public override void ProjectDetails() { }
    }
}
