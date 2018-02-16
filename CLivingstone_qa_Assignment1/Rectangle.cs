using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clivingstone_qa_assignment1
{
    public class Rectangle
    {
        private int length;
        private int width;


        public Rectangle()
        {
            length = 1;
            width = 1;

        }

        public Rectangle(int thisLength, int thisWidth)
        {
            width = thisWidth;
            length = thisLength;
        }

        public int GetLength()
        {
            return length;
        }

        public void SetLength(int newLength)
        {
            length = newLength;
        }

        public int GetWidth()
        {
            return width;
        }

        public void SetWidth(int newWidth)
        {
            width = newWidth;
        }

        public int GetPerimeter()
        {

            return (length * 2) + (width * 2);
        }

        public int GetArea()
        {

            return (length * width);
        }
    }

   
}
