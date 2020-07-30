using System;
using OpenToolkit.Windowing.Desktop;

namespace CDawQ.Render
{
    public class ImageMaker
    {
        public void MakeWindow()
        {
            GameWindowSettings settings = new GameWindowSettings();
            NativeWindowSettings nativeSettings = new NativeWindowSettings();

            using (TriangleWindow window = new TriangleWindow(settings, nativeSettings))
            {
                window.Run();
            }

            using (SquareWindow window = new SquareWindow(settings, nativeSettings))
            {
                window.Run();
            }

            using (TextureWindow window = new TextureWindow(settings, nativeSettings))
            {
                window.Run();
            }

            using (CubeWindow window = new CubeWindow(settings, nativeSettings))
            {
                window.Run();
            }
        }
    }
}
