using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lesson6
{
    internal abstract class Figure
    {
        private Color _colorFigure { get; set; }

        private bool _IsVisible = false;

        private int _x = 0, _y = 0;


        // coordination
        public Figure(int pX, int pY)
        {
            _x = pX;
            _y = pY;
        }


        // [Properties]
        public int X
        {
            get { return _x; }
            set
            {
                if (_x < 0)
                    _x = 0;
                else
                    _x = value;
            }
        }

        public int Y
        {
            get { return _y; }
            set
            {
                if (_y < 0)
                    _y = 0;
                else
                    _y = value;
            }
        }


        // Properties
        public bool IsVisible
        { 
            get => _IsVisible;
            set => _IsVisible = value;
        }
        public Color ColorFigure
        {
            get
            {
                return _colorFigure;
            }
            set
            {
                if (value != null)
                {
                    _colorFigure = value;
                }          
            }            
        }



        // move horizontal
        public void MoveHorizontal(int pX)
        {
            if (_x + pX < 0)
                return;

            _x += pX;
        }
        // move vertical 
        public void MoveVertical(int pY)
        {
            if (_y + pY < 0)
                return;

            _y += pY;
        }




        public void ChangeColor(Color color)
        {
            _colorFigure = color;
        }

        public void CheckVisibility()
        { 
            if(IsVisible)
                Console.WriteLine("Visible");
            else
                Console.WriteLine("Not Visible");
        }


                  
        public override string ToString()
        {
            return "Color =" + _colorFigure + " IsVisible =" + _IsVisible + " Cordination: X =" + _x + ", Y =" + _y;
        }
    }
}
