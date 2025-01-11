﻿using System;
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

        }

        //
        private void InitializeTimer()
        {
            objectTimer = new Timer();
            objectTimer.Interval = 100; // 100ms ~ 10 FPS
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
            foreach (var obj in scene.Objects)
            {
                if(rbTexture0.Checked == true)
                    obj.Draw(texture, 1);  // Apelează funcția Draw pentru fiecare obiect
                else
                if (radioButton2.Checked == true)
                    obj.Draw(texture, 2);
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
                selectedObject.Rotate(5, 0, 0);
                LogAction($"Rotated object to {selectedObject.Rotation}");
                scene.Invalidate();
            }
        }

        //
        private void scaleButton_Click(object sender, EventArgs e)
        {
            if (selectedObject != null)
            {
                selectedObject.ScaleObject(1.1f);
                LogAction($"Scaled object to {selectedObject.Scale}");
                scene.Invalidate();
            }
        }

        //
        private void translateButton_Click(object sender, EventArgs e)
        {
            if (selectedObject != null)
            {
                selectedObject.Translate(0.0f , 1.0f , 0.0f);
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