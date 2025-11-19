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
            this.label1 = new System.Windows.Forms.Label();
            this.training_count_text = new System.Windows.Forms.Label();
            this.epoch_numeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epoch_numeric)).BeginInit();
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
            this.output_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_box.Location = new System.Drawing.Point(441, 109);
            this.output_box.Multiline = true;
            this.output_box.Name = "output_box";
            this.output_box.Size = new System.Drawing.Size(163, 40);
            this.output_box.TabIndex = 2;
            // 
            // create_bpnn
            // 
            this.create_bpnn.Location = new System.Drawing.Point(38, 248);
            this.create_bpnn.Name = "create_bpnn";
            this.create_bpnn.Size = new System.Drawing.Size(89, 23);
            this.create_bpnn.TabIndex = 3;
            this.create_bpnn.Text = "create BPNN";
            this.create_bpnn.UseVisualStyleBackColor = true;
            this.create_bpnn.Click += new System.EventHandler(this.create_bpnn_Click);
            // 
            // train_nn
            // 
            this.train_nn.Location = new System.Drawing.Point(167, 248);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Training Count:";
            // 
            // training_count_text
            // 
            this.training_count_text.AutoSize = true;
            this.training_count_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.training_count_text.Location = new System.Drawing.Point(317, 283);
            this.training_count_text.Name = "training_count_text";
            this.training_count_text.Size = new System.Drawing.Size(25, 25);
            this.training_count_text.TabIndex = 9;
            this.training_count_text.Text = "0";
            // 
            // epoch_numeric
            // 
            this.epoch_numeric.Location = new System.Drawing.Point(238, 332);
            this.epoch_numeric.Name = "epoch_numeric";
            this.epoch_numeric.Size = new System.Drawing.Size(104, 20);
            this.epoch_numeric.TabIndex = 10;
            this.epoch_numeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Epoch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Limit: 1000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.epoch_numeric);
            this.Controls.Add(this.training_count_text);
            this.Controls.Add(this.label1);
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
            ((System.ComponentModel.ISupportInitialize)(this.epoch_numeric)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label training_count_text;
        private System.Windows.Forms.NumericUpDown epoch_numeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

