namespace BackpropagationNN
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.first_input = new System.Windows.Forms.TextBox();
            this.second_input = new System.Windows.Forms.TextBox();
            this.output_box = new System.Windows.Forms.TextBox();
            this.create_bpnn = new System.Windows.Forms.Button();
            this.train_nn = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Button();
            this.third_input = new System.Windows.Forms.TextBox();
            this.fourth_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // first_input
            // 
            this.first_input.Location = new System.Drawing.Point(31, 52);
            this.first_input.Name = "first_input";
            this.first_input.Size = new System.Drawing.Size(138, 20);
            this.first_input.TabIndex = 0;
            // 
            // second_input
            // 
            this.second_input.Location = new System.Drawing.Point(31, 89);
            this.second_input.Name = "second_input";
            this.second_input.Size = new System.Drawing.Size(138, 20);
            this.second_input.TabIndex = 1;
            // 
            // output_box
            // 
            this.output_box.Location = new System.Drawing.Point(377, 129);
            this.output_box.Name = "output_box";
            this.output_box.Size = new System.Drawing.Size(300, 20);
            this.output_box.TabIndex = 2;
            // 
            // create_bpnn
            // 
            this.create_bpnn.Location = new System.Drawing.Point(48, 222);
            this.create_bpnn.Name = "create_bpnn";
            this.create_bpnn.Size = new System.Drawing.Size(89, 23);
            this.create_bpnn.TabIndex = 3;
            this.create_bpnn.Text = "create BPNN";
            this.create_bpnn.UseVisualStyleBackColor = true;
            this.create_bpnn.Click += new System.EventHandler(this.create_bpnn_Click);
            // 
            // train_nn
            // 
            this.train_nn.Location = new System.Drawing.Point(177, 222);
            this.train_nn.Name = "train_nn";
            this.train_nn.Size = new System.Drawing.Size(144, 23);
            this.train_nn.TabIndex = 4;
            this.train_nn.Text = "Train Neural Network";
            this.train_nn.UseVisualStyleBackColor = true;
            this.train_nn.Click += new System.EventHandler(this.train_nn_Click);
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(451, 166);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(144, 23);
            this.test.TabIndex = 5;
            this.test.Text = "Test";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // third_input
            // 
            this.third_input.Location = new System.Drawing.Point(31, 129);
            this.third_input.Name = "third_input";
            this.third_input.Size = new System.Drawing.Size(138, 20);
            this.third_input.TabIndex = 6;
            // 
            // fourth_input
            // 
            this.fourth_input.Location = new System.Drawing.Point(31, 169);
            this.fourth_input.Name = "fourth_input";
            this.fourth_input.Size = new System.Drawing.Size(138, 20);
            this.fourth_input.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fourth_input);
            this.Controls.Add(this.third_input);
            this.Controls.Add(this.test);
            this.Controls.Add(this.train_nn);
            this.Controls.Add(this.create_bpnn);
            this.Controls.Add(this.output_box);
            this.Controls.Add(this.second_input);
            this.Controls.Add(this.first_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox first_input;
        private System.Windows.Forms.TextBox second_input;
        private System.Windows.Forms.TextBox output_box;
        private System.Windows.Forms.Button create_bpnn;
        private System.Windows.Forms.Button train_nn;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.TextBox third_input;
        private System.Windows.Forms.TextBox fourth_input;
    }
}

