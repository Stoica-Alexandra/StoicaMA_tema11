using System.Collections.Generic;
using System.Drawing;

using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK3_StandardTemplate_WinForms.helpers;

namespace OpenTK3_StandardTemplate_WinForms.objects
{
    class Scene
    {
        private Color DEFAULT_BKG_COLOR = Color.LightGray;

        private GLControl viewport;

        //
        public List<Object3D> Objects { get; private set; }

        public Scene()
        {
            //
            Objects = new List<Object3D>();

            viewport = new GLControl(new OpenTK.Graphics.GraphicsMode(32, 24, 0, 8));
            viewport.TabIndex = 0;
            viewport.Name = "mainViewport";
            viewport.BackColor = DEFAULT_BKG_COLOR;
            viewport.Location = new Point(12, 12);
            viewport.Size = new Size(800, 600);
            viewport.VSync = false;
        }


        public Color GetBackgroundColor()
        {
            return viewport.BackColor;
        }

        public void SetBackgroundColor(Color color)
        {
            viewport.BackColor = color;
        }

        public GLControl GetViewport()
        {
            return viewport;
        }

        public void Reset()
        {
            GL.ClearColor(DEFAULT_BKG_COLOR);
            
            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Less);
            GL.Enable(EnableCap.Texture2D);
            GL.Enable(EnableCap.Multisample);
            GL.Hint(HintTarget.MultisampleFilterHintNv, HintMode.Nicest);
            GL.Hint(HintTarget.PolygonSmoothHint, HintMode.Nicest);
            GL.Hint(HintTarget.LineSmoothHint, HintMode.Nicest);
        }

        public void Invalidate()
        {
            viewport.Invalidate();
        }

        //
        public void AddObject(Object3D obj)
        {
            Objects.Add(obj);
        }

        public void ClearObjects()
        {
            Objects.Clear();
        }

        public Object3D SelectObject(int mouseX, int mouseY)
        {
            return Objects.Count > 0 ? Objects[0] : null; // Exemplu simplu
        }

    }

}

