using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Sys = Cosmos.System;

namespace Cosmostri
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            graf.starts();
        }

        protected override void Run()
        {
            while (true)
            {
                lines.Main();
                var input = Console.ReadLine();


            }


        }
    }
    class graf
    {
        public static Canvas canvas;
        public static Bitmap bitmap;


        public static void starts()
        {


            canvas = FullScreenCanvas.GetFullScreenCanvas(new Mode(640, 480, ColorDepth.ColorDepth32));
            Sys.MouseManager.ScreenHeight = (uint)(470);
            Sys.MouseManager.ScreenWidth = (uint)(630);






        }
        public static void displays()
        {

            canvas.Display();


        }
        public static void cls(Color c)
        {


            canvas.Clear(c);

        }

    }






    class tests



    {


        public static void mainLoop()
        {
            //


            graf.cls(Color.White);
            for (int i = 0; i < 639; i++)
            {
                Pen p = new Pen(Color.FromArgb(255, i / 3, i / 3, i / 3));
                graf.canvas.DrawLine(p, 640/2, 0, i, 479);


            }

            graf.displays();
        }



    }



    class lines
    {

        public static void Main()
        {
            tests.mainLoop();



        }



    }


}
