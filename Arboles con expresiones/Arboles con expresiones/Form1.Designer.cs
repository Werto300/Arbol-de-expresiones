namespace Arboles_con_expresiones
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnPreOrd = new System.Windows.Forms.Button();
            this.btnPostOrd = new System.Windows.Forms.Button();
            this.txtPreOrder = new System.Windows.Forms.TextBox();
            this.txtPostOrder = new System.Windows.Forms.TextBox();
            this.txtAgregar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(13, 13);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnPreOrd
            // 
            this.btnPreOrd.Location = new System.Drawing.Point(12, 51);
            this.btnPreOrd.Name = "btnPreOrd";
            this.btnPreOrd.Size = new System.Drawing.Size(75, 23);
            this.btnPreOrd.TabIndex = 3;
            this.btnPreOrd.Text = "PreOrder";
            this.btnPreOrd.UseVisualStyleBackColor = true;
            this.btnPreOrd.Click += new System.EventHandler(this.btnPreOrd_Click);
            // 
            // btnPostOrd
            // 
            this.btnPostOrd.Location = new System.Drawing.Point(13, 90);
            this.btnPostOrd.Name = "btnPostOrd";
            this.btnPostOrd.Size = new System.Drawing.Size(75, 23);
            this.btnPostOrd.TabIndex = 4;
            this.btnPostOrd.Text = "PostOrder";
            this.btnPostOrd.UseVisualStyleBackColor = true;
            this.btnPostOrd.Click += new System.EventHandler(this.btnPostOrd_Click);
            // 
            // txtPreOrder
            // 
            this.txtPreOrder.Location = new System.Drawing.Point(114, 53);
            this.txtPreOrder.Name = "txtPreOrder";
            this.txtPreOrder.Size = new System.Drawing.Size(184, 20);
            this.txtPreOrder.TabIndex = 5;
            // 
            // txtPostOrder
            // 
            this.txtPostOrder.Location = new System.Drawing.Point(114, 92);
            this.txtPostOrder.Name = "txtPostOrder";
            this.txtPostOrder.Size = new System.Drawing.Size(184, 20);
            this.txtPostOrder.TabIndex = 6;
            // 
            // txtAgregar
            // 
            this.txtAgregar.Location = new System.Drawing.Point(114, 13);
            this.txtAgregar.Name = "txtAgregar";
            this.txtAgregar.Size = new System.Drawing.Size(184, 20);
            this.txtAgregar.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 128);
            this.Controls.Add(this.txtAgregar);
            this.Controls.Add(this.txtPostOrder);
            this.Controls.Add(this.txtPreOrder);
            this.Controls.Add(this.btnPostOrd);
            this.Controls.Add(this.btnPreOrd);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Arbol expresiones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnPreOrd;
        private System.Windows.Forms.Button btnPostOrd;
        private System.Windows.Forms.TextBox txtPreOrder;
        private System.Windows.Forms.TextBox txtPostOrder;
        private System.Windows.Forms.TextBox txtAgregar;
    }
}

