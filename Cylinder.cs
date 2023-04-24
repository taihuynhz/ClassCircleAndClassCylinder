using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCircleAndClassCylinder
{
   public class Cylinder : Circle
    {
        private double height = 5.0;
        public Cylinder()
        {

        }

        public Cylinder(double height)
        {
            this.height = height;
        }

        public Cylinder(double height, double radius, string color, bool filled): base(radius, color, filled)
        {
            this.height = height;
        }

        public double getHeight()
        {
            return height;
        }

        public void setHeight(double height)
        {
            this.height = height;
        }

        public double getVolume()
        {
            return height * radius * radius * Math.PI;
        }
        public override string ToString()
        {
            return "A Cylinder with height = "
                     + getHeight()
                     + " and volume = "
                     + getVolume()
                     + ", which is a subclass of "
                     + base.ToString();
        }
    }
}
