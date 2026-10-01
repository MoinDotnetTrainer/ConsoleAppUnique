using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUnique.Solid
{
    public class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int Area()
        {
            return Width * Height;
        }
    }

    public class Square : Rectangle
    {
        public override int Width
        {
            set { base.Width = base.Height = value; }
        }

        public override int Height
        {
            set { base.Width = base.Height = value; }
        }
    }


    public interface IShape
    {
        int Area();
    }

    public class Rectangle1 : IShape
    {
        public int Width { get; }
        public int Height { get; }

        public Rectangle1(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Area()
        {
            return Width * Height;
        }
    }

    public class Square1 : IShape
    {
        public int Side { get; }

        public Square1(int side)
        {
            Side = side;
        }

        public int Area()
        {
            return Side * Side;
        }
    }


}
