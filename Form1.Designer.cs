namespace maxx
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";

            // Other auto-generated code...

            // Button 1
            Button button1 = new Button();
            button1.Text = "Window Page 1";
            button1.Size = new Size(150, 50);
            button1.Location = new Point(50, 50);
            button1.Click += Button1_Click; // Wire up the event handler
            this.Controls.Add(button1); // Add button to the form

            // Button 2
            Button button2 = new Button();
            button2.Text = "Window Page 2";
            button2.Size = new Size(150, 50);
            button2.Location = new Point(50, 120);
            button2.Click += Button2_Click; // Wire up the event handler
            this.Controls.Add(button2); // Add button to the form

            // Button 3
            Button button3 = new Button();
            button3.Text = "Window Page 3";
            button3.Size = new Size(150, 50);
            button3.Location = new Point(50, 190);
            button3.Click += Button3_Click; // Wire up the event handler
            this.Controls.Add(button3); // Add button to the form

            // Button 4
            Button button4 = new Button();
            button4.Text = "Window Page 4";
            button4.Size = new Size(150, 50);
            button4.Location = new Point(50, 260);
            button4.Click += Button4_Click; // Wire up the event handler
            this.Controls.Add(button4); // Add button to the form
        }

        // Leave only one InitializeComponent method in one of the partial classes.
    }
}
