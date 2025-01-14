using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace OpenTK3_StandardTemplate_WinForms.helpers
{
    public class Object3D
    {
        public Vector3 Position { get; private set; }
        public Vector3 Rotation { get; private set; }
        public Vector3 Scale { get; private set; }
        public Color[] color { get; private set; }

        private int[] textures = new int[2];

        private Vector3[][] cube;

        private Vector2[] coordTexturi = new Vector2[]{ new Vector2(0.0f, 1.0f),
                                                        new Vector2(1.0f, 1.0f),
                                                        new Vector2(1.0f, 0.0f),
                                                        new Vector2(0.0f, 0.0f)
        };

        public Object3D(Vector3 position)
        {
            Position = position;
            Rotation = Vector3.Zero;
            Scale = new Vector3(0.75f,0.75f,0.75f);
            color = new Color[6];

            // setare locatie fisier in directorul corespunzator solutiei
            string filepath = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName + "\\" +
                ConfigurationManager.AppSettings["NumeFisier"];

            cube = ReadCubeCoord(filepath);

            for (int i = 0; i < 6; i++)
                color[i] = Randomizer.GetRandomColor();

            LoadTextures();
        }

        // Metoda pentru încărcarea texturii
        private void LoadTextures()
        {
            string filepath = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName + "\\" +
                ConfigurationManager.AppSettings["texture1"];

            GL.GenTextures(textures.Length, textures);
            LoadTexture(textures[0], filepath);

            filepath = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName + "\\" +
                ConfigurationManager.AppSettings["texture2"];
            LoadTexture(textures[1], filepath);
        }

        private void LoadTexture(int textureId, string filename)
        {
            Bitmap bmp = new Bitmap(filename);

            BitmapData data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
                                                    System.Drawing.Imaging.ImageLockMode.ReadOnly,
                                                    System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            GL.BindTexture(TextureTarget.Texture2D, textureId);
            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba,
                          bmp.Width, bmp.Height, 0, OpenTK.Graphics.OpenGL.PixelFormat.Bgra,
                          PixelType.UnsignedByte, data.Scan0);

            bmp.UnlockBits(data);

            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (float)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (float)TextureMagFilter.Linear);
        }

        public static Object3D ParseFromText(string line)
        {
            var parts = line.Split(',');
            return new Object3D(new Vector3(float.Parse(parts[0]), float.Parse(parts[1]), float.Parse(parts[2])));
        }

        public void Translate(float x, float y, float z)
        {
            Position += new Vector3(x, y, z);
        }

        public void Rotate(float x, float y, float z)
        {
            Rotation += new Vector3(x, y, z);
        }

        public void ScaleObject(float factor)
        {
            Scale *= factor;
        }

        public void Draw(bool texture, int number, int numberColor)
        {
            GL.PushMatrix();
            GL.Translate(Position);
            GL.Rotate(Rotation.X, 1, 0, 0);
            GL.Rotate(Rotation.Y, 0, 1, 0);
            GL.Rotate(Rotation.Z, 0, 0, 1);
            GL.Scale(Scale);

            if(texture == true)
            {
                GL.Enable(EnableCap.Texture2D);

                if(number == 1)
                    GL.BindTexture(TextureTarget.Texture2D, textures[0]);
                
                else
                    GL.BindTexture(TextureTarget.Texture2D, textures[1]);
            
                GL.Begin(PrimitiveType.Quads);

                if(numberColor == 0)
                    GL.Color3(Color.White);

                else if (numberColor == 1)
                    GL.Color3(Color.Red);

                else GL.Color3(Color.Blue);

                for (int i = 0; i < cube.Length; i++)
                {
                    for (int j = 0; j < cube[i].Length; j++)
                    {
                        GL.TexCoord2(coordTexturi[j]);
                        GL.Vertex3(cube[i][j]);
                    }
                }
            }
            else 
            {

                GL.Disable(EnableCap.Texture2D);
                GL.Begin(PrimitiveType.Quads);

                for (int i = 0; i < cube.Length; i++)
                {
                    GL.Color4(color[i]);

                    for (int j = 0; j < cube[i].Length; j++)
                    {
                        GL.Vertex3(cube[i][j]);
                    }
                }
            }

            GL.End();
            GL.PopMatrix();
        }

        private Vector3[][] ReadCubeCoord(string fileName)
        {
            Vector3[][] points = new Vector3[6][]; // 6 faces with 4 points each
            int indexFata = 0, indexVertex = 0;

            for (int i = 0; i < points.Length; i++)
                points[i] = new Vector3[4];

            try
            {
                using (StreamReader streamReader = new StreamReader(fileName))
                {
                    string line;
                    string[] coord;

                    // Citirea coordonatelor pentru fiecare fata
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        // Ignorare comentarii
                        if (line.StartsWith("#"))
                            continue;

                        // Extragere coordonate vertex dintr-o linie
                        coord = line.Split(',');


                        if (indexVertex == 4)
                        {
                            indexVertex = 0;
                            indexFata++;
                        }

                        // Creare vertex
                        points[indexFata][indexVertex++] = new Vector3(
                                float.Parse(coord[0]),
                                float.Parse(coord[1]),
                                float.Parse(coord[2]));
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception(eIO.Message);
            }

            return points;
        }

    }
}
