using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using OpenTK.Graphics.OpenGL;

using OpenTK3_StandardTemplate_WinForms.helpers;
using OpenTK3_StandardTemplate_WinForms.objects;

namespace OpenTK3_StandardTemplate_WinForms
{
    public partial class MainForm : Form
    {
        private Axes mainAxis;
        private Rectangles re;
        private Camera cam;
        private Scene scene;

        private Point mousePosition;

        // 
        private Timer objectTimer;
        private Object3D selectedObject;
        private TextBox logTextBox;

        private bool trans = false;
        private bool texture = false;

        //Stări de control iluminare.
        private bool lightON;
        private bool lightON_0;

        //Dim valuesAmbientTemplate0() As Single = {255, 0, 0, 1.0}      //Valori alternative ambientale(lumină colorată)
        //# SET 1
        private float[] valuesAmbientTemplate0 = new float[] { 0.1f, 0.1f, 0.1f, 1.0f };
        private float[] valuesDiffuseTemplate0 = new float[] { 1.0f, 1.0f, 1.0f, 1.0f };
        private float[] valuesSpecularTemplate0 = new float[] { 0.1f, 0.1f, 0.1f, 1.0f };
        private float[] valuesPositionTemplate0 = new float[] { 0.0f, 0.0f, 5.0f, 1.0f };
        //# SET 2
        //private float[] valuesAmbientTemplate0 = new float[] { 0.2f, 0.2f, 0.2f, 1.0f };
        //private float[] valuesDiffuseTemplate0 = new float[] { 1.0f, 1.0f, 1.0f, 1.0f };
        //private float[] valuesSpecularTemplate0 = new float[] { 1.0f, 1.0f, 1.0f, 1.0f };
        //private float[] valuesPositionTemplate0 = new float[] { 1.0f, 1.0f, 1.0f, 0.0f };

        private float[] valuesAmbient0 = new float[4];
        private float[] valuesDiffuse0 = new float[4];
        private float[] valuesSpecular0 = new float[4];
        private float[] valuesPosition0 = new float[4];

        public MainForm()
        {   
            // general init
            InitializeComponent();

            // init VIEWPORT
            scene = new Scene();

            scene.GetViewport().Load += new EventHandler(this.mainViewport_Load);
            scene.GetViewport().Paint += new PaintEventHandler(this.mainViewport_Paint);
            scene.GetViewport().MouseMove += new MouseEventHandler(this.mainViewport_MouseMove);

            //
            scene.GetViewport().MouseClick += new MouseEventHandler(this.mainViewport_MouseClick);
            this.KeyPreview = true;
            scene.GetViewport().KeyDown += new KeyEventHandler(this.MainForm_KeyDown);

            this.Controls.Add(scene.GetViewport());

            //
            // Timer for object movement
            InitializeTimer();

            // Log text box
            InitializeLogTextBox();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // init RNG
            Randomizer.Init();

            // init CAMERA/EYE
            cam = new Camera(scene.GetViewport());

            // init AXES
            mainAxis = new Axes(showAxes.Checked);
            re = new Rectangles();

            // Iluminare
            setLight0Values();
            setIlluminationStatus(false);
            setSource0Status(false);

            setTrackLigh0Default();
            setColorAmbientLigh0Default();
            setColorDifuseLigh0Default();
            setColorSpecularLigh0Default();

        }

        //   CONTROL ILUMINARE
        //Setăm variabila de stare pentru iluminare.
        private void setIlluminationStatus(bool status)
        {
            if (status == false)
            {
                lightON = false;
                btnLights.Text = "Iluminare OFF";
            }
            else
            {
                lightON = true;
                btnLights.Text = "Iluminare ON";
            }
        }

        //Activăm/dezactivăm iluminarea.
        private void btnLights_Click(object sender, EventArgs e)
        {
            if (lightON == false)
            {
                setIlluminationStatus(true);
            }
            else
            {
                setIlluminationStatus(false);
            }
            scene.Invalidate();
        }

        //Setăm variabila de stare pentru sursa de lumină 0.
        private void setSource0Status(bool status)
        {
            if (status == false)
            {
                lightON_0 = false;
                btnLight0.Text = "Sursa 0 OFF";
            }
            else
            {
                lightON_0 = true;
                btnLight0.Text = "Sursa 0 ON";
            }
        }

        //Activăm/dezactivăm sursa 0 de iluminare (doar dacă iluminarea este activă).
        private void btnLight0_Click(object sender, EventArgs e)
        {
            if (lightON == true)
            {
                if (lightON_0 == false)
                {
                    setSource0Status(true);
                }
                else
                {
                    setSource0Status(false);
                }
                scene.Invalidate();
            }
        }

        //Schimbăm poziția sursei 0 de iluminare după axele XYZ.
        private void setTrackLigh0Default()
        {
            trackLight0PositionX.Value = (int)valuesPosition0[0];
            trackLight0PositionY.Value = (int)valuesPosition0[1];
            trackLight0PositionZ.Value = (int)valuesPosition0[2];
        }

        private void trackLight0PositionX_Scroll(object sender, EventArgs e)
        {
            valuesPosition0[0] = trackLight0PositionX.Value;
            scene.Invalidate();
        }

        private void trackLight0PositionY_Scroll(object sender, EventArgs e)
        {
            valuesPosition0[1] = trackLight0PositionY.Value;
            scene.Invalidate();
        }

        private void trackLight0PositionZ_Scroll(object sender, EventArgs e)
        {
            valuesPosition0[2] = trackLight0PositionZ.Value;
            scene.Invalidate();
        }

        //Schimbăm culoarea sursei de lumină 0 (ambiental) în domeniul RGB.
        private void setColorAmbientLigh0Default()
        {
            numericLight0Ambient_Red.Value = (decimal)valuesAmbient0[0];
            numericLight0Ambient_Green.Value = (decimal)valuesAmbient0[1];
            numericLight0Ambient_Blue.Value = (decimal)valuesAmbient0[2];
        }

        private void numericLight0Ambient_Red_ValueChanged(object sender, EventArgs e)
        {
            valuesAmbient0[0] = (float)numericLight0Ambient_Red.Value / 100;
            scene.Invalidate();
        }

        private void numericLight0Ambient_Green_ValueChanged(object sender, EventArgs e)
        {
            valuesAmbient0[1] = (float)numericLight0Ambient_Green.Value / 100;
            scene.Invalidate();
        }

        private void numericLight0Ambient_Blue_ValueChanged(object sender, EventArgs e)
        {
            valuesAmbient0[2] = (float)numericLight0Ambient_Blue.Value / 100;
            scene.Invalidate();
        }

        //Schimbăm culoarea sursei de lumină 0 (difuză) în domeniul RGB.
        private void setColorDifuseLigh0Default()
        {
            numericLight0Difuse_Red.Value = (decimal)valuesDiffuse0[0];
            numericLight0Difuse_Green.Value = (decimal)valuesDiffuse0[1];
            numericLight0Difuse_Blue.Value = (decimal)valuesDiffuse0[2];
        }

        private void numericLight0Difuse_Red_ValueChanged(object sender, EventArgs e)
        {
            valuesDiffuse0[0] = (float)numericLight0Difuse_Red.Value / 100;
            scene.Invalidate();
        }

        private void numericLight0Difuse_Green_ValueChanged(object sender, EventArgs e)
        {
            valuesDiffuse0[1] = (float)numericLight0Difuse_Green.Value / 100;
            scene.Invalidate();
        }

        private void numericLight0Difuse_Blue_ValueChanged(object sender, EventArgs e)
        {
            valuesDiffuse0[2] = (float)numericLight0Difuse_Blue.Value / 100;
            scene.Invalidate();
        }

        //Schimbăm culoarea sursei de lumină 0 (specular) în domeniul RGB.
        private void setColorSpecularLigh0Default()
        {
            numericLight0Specular_Red.Value = (decimal)valuesSpecular0[0];
            numericLight0Specular_Green.Value = (decimal)valuesSpecular0[1];
            numericLight0Specular_Blue.Value = (decimal)valuesSpecular0[2];
        }

        private void numericLight0Specular_Red_ValueChanged(object sender, EventArgs e)
        {
            valuesSpecular0[0] = (float)numericLight0Specular_Red.Value / 100;
            scene.Invalidate();
        }

        private void numericLight0Specular_Green_ValueChanged(object sender, EventArgs e)
        {
            valuesSpecular0[1] = (float)numericLight0Specular_Green.Value / 100;
            scene.Invalidate();
        }

        private void numericLight0Specular_Blue_ValueChanged(object sender, EventArgs e)
        {
            valuesSpecular0[2] = (float)numericLight0Specular_Blue.Value / 100;
            scene.Invalidate();
        }

        //Resetare stare sursă de lumină nr. 0.
        private void setLight0Values()
        {
            for (int i = 0; i < valuesAmbientTemplate0.Length; i++)
            {
                valuesAmbient0[i] = valuesAmbientTemplate0[i];
            }
            for (int i = 0; i < valuesDiffuseTemplate0.Length; i++)
            {
                valuesDiffuse0[i] = valuesDiffuseTemplate0[i];
            }
            for (int i = 0; i < valuesPositionTemplate0.Length; i++)
            {
                valuesPosition0[i] = valuesPositionTemplate0[i];
            }
        }

        private void btnLight0Reset_Click(object sender, EventArgs e)
        {
            setLight0Values();
            setTrackLigh0Default();
            setColorAmbientLigh0Default();
            setColorDifuseLigh0Default();
            setColorSpecularLigh0Default();
            scene.Invalidate();
        }



        //
        private void InitializeTimer()
        {
            objectTimer = new Timer();
            objectTimer.Interval = 60; 
            objectTimer.Tick += (s, e) =>
            {
                if (selectedObject != null && ckbTimerMove.Checked)
                {
                    selectedObject.Translate(0.25f , 0, 0); // Example movement
                    LogAction($"Object moved to {selectedObject.Position}");
                    scene.Invalidate();
                }
            };
            objectTimer.Start();
        }

        //
        private void InitializeLogTextBox()
        {
            logTextBox = new TextBox
            {
                Multiline = true,
                Dock = DockStyle.Bottom,
                Height = 100,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical, // Permite derularea verticală
                WordWrap = false
            };
            this.Controls.Add(logTextBox);
        }

        //
        private void LogAction(string message)
        {
            logTextBox.AppendText($"{DateTime.Now:HH:mm:ss} - {message}{Environment.NewLine}");
            logTextBox.SelectionStart = logTextBox.Text.Length; // Setează cursorul la sfârșit
            logTextBox.ScrollToCaret(); // Derulează automat la ultima linie
        }

        private void showAxes_CheckedChanged(object sender, EventArgs e)
        {
            mainAxis.SetVisibility(showAxes.Checked);

            scene.Invalidate();
        }

        private void changeBackground_Click(object sender, EventArgs e)
        {
            GL.ClearColor(Randomizer.GetRandomColor());

            scene.Invalidate();
        }

        private void resetScene_Click(object sender, EventArgs e)
        {
            showAxes.Checked = true;
            mainAxis.SetVisibility(showAxes.Checked);
            scene.Reset();
            cam.Reset();

            scene.Invalidate();
        }

        private void mainViewport_Load(object sender, EventArgs e)
        {
            scene.Reset();
        }

        private void mainViewport_MouseMove(object sender, MouseEventArgs e)
        {
            mousePosition = new Point(e.X, e.Y);
            scene.Invalidate();
        }

        //
        private void mainViewport_MouseClick(object sender, MouseEventArgs e)
        {
            selectedObject = scene.SelectObject(e.X, e.Y);

            if (selectedObject != null)
            {
                LogAction($"Object selected at position {selectedObject.Position.X}, {selectedObject.Position.Y}");
            }
            else
            {
                LogAction("No object selected.");
            }
        }

        private void mainViewport_Paint(object sender, PaintEventArgs e)
        {

            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Clear(ClearBufferMask.DepthBufferBit);

            //Pornim iluminarea (daca avem permisiunea să o facem).
            if (lightON == true)
            {
                //Permite utilizarea iluminării. Fara aceasta corecție iluminarea nu functioneaza.
                GL.Enable(EnableCap.Lighting);
            }
            else
            {
                //Dezactivează utilizarea iluminării.
                GL.Disable(EnableCap.Lighting);
            }

            //Se creeaza sursa de iluminare. In acest caz folosim o singura sursa.
            //Numarul de surse de lumini depinde de implementarea OpenGL, dar de obicei cel putin 8 surse sunt posibile simultan.
            GL.Light(LightName.Light0, LightParameter.Ambient, valuesAmbient0);
            GL.Light(LightName.Light0, LightParameter.Diffuse, valuesDiffuse0);
            GL.Light(LightName.Light0, LightParameter.Specular, valuesSpecular0);
            GL.Light(LightName.Light0, LightParameter.Position, valuesPosition0);

            if ((lightON == true) && (lightON_0 == true))
            {
                //Activam sursa 0 de lumina. Fara aceasta actiune nu avem iluminare.
                GL.Enable(EnableCap.Light0);
            }
            else
            {
                //Dezactivam sursa 0 de lumina.
                GL.Disable(EnableCap.Light0);
            }

            cam.SetView();

            if (enableRotation.Checked == true)
            {
                // Doar după axa Ox.
                GL.Rotate(Math.Max(mousePosition.X, mousePosition.Y), 1, 1, 1);
            }

            // GRAPHICS PAYLOAD
            mainAxis.Draw();

            if (enableObjectRotation.Checked == true)
            {
                // Rotatie a obiectului
                GL.PushMatrix();
                GL.Rotate(Math.Max(mousePosition.X, mousePosition.Y), 1, 1, 1);
                re.Draw();
                GL.PopMatrix();
            } else
            {
                re.Draw();
            }

            //
            int colorNumber = 0;
            if (rbColorBlue.Checked == true)
                colorNumber = 2;
            else
                if(rbColorWhite.Checked == true)
                colorNumber = 0;
            else if(rbColorRed.Checked == true)
                colorNumber = 1;

            foreach (var obj in scene.Objects)
            {
                if(rbTexture0.Checked == true)
                    obj.Draw(texture, 1, colorNumber);  // Apelează funcția Draw pentru fiecare obiect
                else
                if (radioButton2.Checked == true)
                    obj.Draw(texture, 2, colorNumber);
            }


            if (trans)
                Trans();

            scene.GetViewport().SwapBuffers();
        }

        //
        private void loadFileButton_Click(object sender, EventArgs e)
        {
            scene.ClearObjects();
            // Load objects from a file
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                int i = 0;
                openFileDialog.Filter = "Text Files (*.txt)|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] lines = File.ReadAllLines(openFileDialog.FileName);
                    foreach (var line in lines)
                    {
                        var obj = Object3D.ParseFromText(line);
                        scene.AddObject(obj);
                        lstbObjects.Items.Add(i++);
                        LogAction($"Loaded object from file: {line}");
                    }
                    scene.Invalidate();
                }
            }
        }

        //
        private void moveObject(Keys key)
        {
            if (selectedObject == null) return;
            float step = 1;
            switch (key)
            {
                case Keys.W: selectedObject.Translate(0, step, 0); break;
                case Keys.S: selectedObject.Translate(0, -step, 0); break;
                case Keys.A: selectedObject.Translate(-step, 0, 0); break;
                case Keys.D: selectedObject.Translate(step, 0, 0); break;
                case Keys.Q: selectedObject.Translate(0, 0, step); break;
                case Keys.E: selectedObject.Translate(0, 0, -step); break;
            }
            LogAction($"Moved object to {selectedObject.Position}");
            scene.Invalidate();
        }

        //
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            moveObject(e.KeyCode);
        }

        //
        private void rotateButton_Click(object sender, EventArgs e)
        {
            if (selectedObject != null)
            {
                selectedObject.Rotate((float)numericUpDown_Rotation.Value, 0, 0);
                LogAction($"Rotated object to {selectedObject.Rotation}");
                scene.Invalidate();
            }
        }

        //
        private void scaleButton_Click(object sender, EventArgs e)
        {
            if (selectedObject != null)
            {
                selectedObject.ScaleObject( 1.05f);
                LogAction($"Scaled object to {selectedObject.Scale}");
                scene.Invalidate();
            }
        }

        //
        private void translateButton_Click(object sender, EventArgs e)
        {
            if (selectedObject != null)
            {
                selectedObject.Translate(0.0f , (float) numericUpDown_Translation.Value , 0.0f);
                LogAction($"Translated object to {selectedObject.Position}");
                scene.Invalidate();
            }
        }

        [Obsolete]
        private void Trans()
        {
            GL.Begin(BeginMode.Quads);
            GL.Color3(Color.Red);
            GL.Vertex3(-10, 5, 10);
            GL.Vertex3(-10, 5, -10);
            GL.Vertex3(20, 5, -10);
            GL.Vertex3(20, 5, 10);
            GL.End();

            GL.BlendFunc((BlendingFactor)BlendingFactorSrc.SrcAlpha, (BlendingFactor)BlendingFactorDest.One);
            GL.Enable(EnableCap.Blend);
            GL.Begin(BeginMode.Quads);
            GL.Color4(25, 0, 25, 0.5);
            GL.Vertex3(-50, 25, 50);
            GL.Vertex3(-50, 25, -50);
            GL.Vertex3(100, 25, -50);
            GL.Vertex3(100, 25, 50);
            GL.End();
            GL.Disable(EnableCap.Blend);
        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            if (trans)
                trans = false;
            else trans = true;

            scene.Invalidate();
        }

        private void lstbObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedObject = scene.Objects[(int) lstbObjects.SelectedItem];
        }

        private void btnTexture_Click(object sender, EventArgs e)
        {
            texture = true;

            scene.Invalidate();
        }

        private void btnNoTexture_Click(object sender, EventArgs e)
        {
            texture = false;

            scene.Invalidate();

        }

    }
}
