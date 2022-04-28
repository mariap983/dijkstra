namespace Deikstra
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
            this.Res = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BEnd = new System.Windows.Forms.Button();
            this.BDijkstra = new System.Windows.Forms.Button();
            this.BCreateGraph = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Res
            // 
            this.Res.BackColor = System.Drawing.Color.Ivory;
            this.Res.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Res.Location = new System.Drawing.Point(72, 64);
            this.Res.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Res.Name = "Res";
            this.Res.Size = new System.Drawing.Size(716, 313);
            this.Res.TabIndex = 1;
            this.Res.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(259, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Матрица на съседството";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BEnd
            // 
            this.BEnd.Location = new System.Drawing.Point(629, 385);
            this.BEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BEnd.Name = "BEnd";
            this.BEnd.Size = new System.Drawing.Size(159, 28);
            this.BEnd.TabIndex = 20;
            this.BEnd.Text = "Затвори";
            this.BEnd.UseVisualStyleBackColor = true;
            this.BEnd.Click += new System.EventHandler(this.BEnd_Click);
            // 
            // BDijkstra
            // 
            this.BDijkstra.Location = new System.Drawing.Point(352, 385);
            this.BDijkstra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BDijkstra.Name = "BDijkstra";
            this.BDijkstra.Size = new System.Drawing.Size(159, 28);
            this.BDijkstra.TabIndex = 19;
            this.BDijkstra.Text = "Дейкстра";
            this.BDijkstra.UseVisualStyleBackColor = true;
            this.BDijkstra.Click += new System.EventHandler(this.BDijkstra_Click);
            // 
            // BCreateGraph
            // 
            this.BCreateGraph.Location = new System.Drawing.Point(72, 385);
            this.BCreateGraph.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BCreateGraph.Name = "BCreateGraph";
            this.BCreateGraph.Size = new System.Drawing.Size(159, 28);
            this.BCreateGraph.TabIndex = 15;
            this.BCreateGraph.Text = "Въведи граф";
            this.BCreateGraph.UseVisualStyleBackColor = true;
            this.BCreateGraph.Click += new System.EventHandler(this.BCreateGraph_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dijkstra_s_Shortest_Path_Algorithm.Properties.Resources.background_blur_blurred_255379;
            this.ClientSize = new System.Drawing.Size(858, 426);
            this.Controls.Add(this.BEnd);
            this.Controls.Add(this.BDijkstra);
            this.Controls.Add(this.BCreateGraph);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Res);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Dijkstra\'s Shortest Path Algorithm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox Res;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BEnd;
        private System.Windows.Forms.Button BDijkstra;
        private System.Windows.Forms.Button BCreateGraph;
    }
}



