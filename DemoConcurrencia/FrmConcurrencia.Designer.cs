namespace DemoConcurrencia
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
            splitContainer1 = new SplitContainer();
            btnTarea = new Button();
            btnHilo = new Button();
            btnSecuencial = new Button();
            txtResultado = new TextBox();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnCancelar);
            splitContainer1.Panel1.Controls.Add(btnTarea);
            splitContainer1.Panel1.Controls.Add(btnHilo);
            splitContainer1.Panel1.Controls.Add(btnSecuencial);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtResultado);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // btnTarea
            // 
            btnTarea.Location = new Point(26, 228);
            btnTarea.Name = "btnTarea";
            btnTarea.Size = new Size(185, 68);
            btnTarea.TabIndex = 2;
            btnTarea.Text = "Iniciar Tarea";
            btnTarea.UseVisualStyleBackColor = true;
            btnTarea.Click += btnTarea_Click;
            // 
            // btnHilo
            // 
            btnHilo.Location = new Point(26, 125);
            btnHilo.Name = "btnHilo";
            btnHilo.Size = new Size(185, 67);
            btnHilo.TabIndex = 1;
            btnHilo.Text = "Iniciar Hilo";
            btnHilo.UseVisualStyleBackColor = true;
            btnHilo.Click += btnHilo_Click;
            // 
            // btnSecuencial
            // 
            btnSecuencial.Location = new Point(26, 36);
            btnSecuencial.Name = "btnSecuencial";
            btnSecuencial.Size = new Size(185, 62);
            btnSecuencial.TabIndex = 0;
            btnSecuencial.Text = "Iniciar Secuencia";
            btnSecuencial.UseVisualStyleBackColor = true;
            btnSecuencial.Click += btnSecuencial_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(3, 0);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(524, 447);
            txtResultado.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(26, 331);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(185, 53);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Demostracion Concurrente";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnSecuencial;
        private TextBox txtResultado;
        private Button btnTarea;
        private Button btnHilo;
        private Button btnCancelar;
    }
}
