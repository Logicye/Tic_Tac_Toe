using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameFramework.ColorSpace
{
    struct ColorPair
    {
        private readonly Color foreground;
        private readonly Color background;

        public ColorPair(Color foreground, Color background)
        {
            this.foreground = foreground;
            this.background = background;
        }

        public ColorPair(Color background, bool Readable)
        {
            this.background = background;
            if (Readable)
            {
                foreground = background.ReadableColor();
            }
            else
            {
                foreground = background.Inverse();
            }
        }

        public void UseColor()
        {
            Console.ForegroundColor = foreground.ReferenceColor;
            Console.BackgroundColor = background.ReferenceColor;
        }

        public Color Foreground()
        {
            return foreground;
        }
        public Color Background()
        {
            return background;
        }
    }
}
