using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class Circle
    {
        private string color;
        private double radius;

        public Circle()
        {
            radius = 1.5;
            color = "red";
        }
        public Circle(double r)
        {
            radius = r;
            color = "red";
        }
        public double getRadius()
        {
            return radius;
        }
        private double CalculateArea()
        {
            return 3.14 * radius * radius;
        }
        public string circleDetails()
        {
            string message = "Radius: " + this.radius + "\nColor: " + this.color + "\nArea :" + this.CalculateArea();
            return message;
        }

    }

  }

