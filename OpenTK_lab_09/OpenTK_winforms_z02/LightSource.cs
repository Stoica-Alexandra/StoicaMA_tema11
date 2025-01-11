using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace OpenTK_winforms_z02
{
    public class LightSource
    {
        public bool IsEnabled { get; private set; }
        public float[] Ambient { get; set; }
        public float[] Diffuse { get; set; }
        public float[] Specular { get; set; }
        public float[] Position { get; set; }
        public LightName LightName { get; private set; }

        public LightSource(LightName lightName, float[] position)
        {
            LightName = lightName;
            Ambient = new float[] { 0.1f, 0.1f, 0.1f, 1.0f };
            //Diffuse = new float[] { 1.0f, 1.0f, 1.0f, 1.0f };
            //Specular = new float[] { 0.5f, 0.5f, 0.5f, 1.0f };
            Diffuse = new float[] { 5.0f, 1.0f, 1.0f, 1.0f };  // Culoare roșie foarte intensă
            Specular = new float[] { 3.0f, 0.0f, 0.0f, 1.0f };  // Reflexii mai puternice
            Position = position;
            IsEnabled = false;
        }

        public void Enable()
        {
            GL.Enable(EnableCap.Lighting);
            GL.Enable((EnableCap)LightName);
            IsEnabled = true;
        }

        public void Disable()
        {
            GL.Disable((EnableCap)LightName);
            IsEnabled = false;
        }

        public void Update()
        {
            GL.Light(LightName, LightParameter.Ambient, Ambient);
            GL.Light(LightName, LightParameter.Diffuse, Diffuse);
            GL.Light(LightName, LightParameter.Specular, Specular);
            GL.Light(LightName, LightParameter.Position, Position);
        }

        public void Move(float deltaX, float deltaY, float deltaZ)
        {
            Position[0] += deltaX;
            Position[1] += deltaY;
            Position[2] += deltaZ;
        }

        public void SetColor(float red, float green, float blue)
        {
            Ambient[0] = red * 0.1f;  // Valori slabe pentru ambient
            Ambient[1] = green * 0.1f;
            Ambient[2] = blue * 0.1f;

            Diffuse[0] = red;  // Valori directe pentru lumină difuză
            Diffuse[1] = green;
            Diffuse[2] = blue;

            Specular[0] = red * 0.5f;  // Reflexii mai puternice pentru specular
            Specular[1] = green * 0.5f;
            Specular[2] = blue * 0.5f;
        }

        public void SetIntenseColor(float red, float green, float blue, float intensity)
        {
            Ambient[0] = red * 0.1f * intensity;  // Valori ambientale
            Ambient[1] = green * 0.1f * intensity;
            Ambient[2] = blue * 0.1f * intensity;

            Diffuse[0] = red * intensity;  // Valori difuze
            Diffuse[1] = green * intensity;
            Diffuse[2] = blue * intensity;

            Specular[0] = red * 0.5f * intensity;  // Reflexii puternice
            Specular[1] = green * 0.5f * intensity;
            Specular[2] = blue * 0.5f * intensity;
        }

    }

}
