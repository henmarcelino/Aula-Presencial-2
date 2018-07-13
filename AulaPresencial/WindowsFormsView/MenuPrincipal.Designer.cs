namespace WindowsFormsView
{
    partial class MenuPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnListarAluno = new System.Windows.Forms.Button();
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnListarProfessor = new System.Windows.Forms.Button();
            this.btnCadastrarProfessor = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnListarMateria = new System.Windows.Forms.Button();
            this.btnCadastrarMateria = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnListarAluno);
            this.groupBox1.Controls.Add(this.btnCadastrarAluno);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aluno";
            // 
            // btnListarAluno
            // 
            this.btnListarAluno.Location = new System.Drawing.Point(7, 50);
            this.btnListarAluno.Name = "btnListarAluno";
            this.btnListarAluno.Size = new System.Drawing.Size(75, 23);
            this.btnListarAluno.TabIndex = 1;
            this.btnListarAluno.Text = "Listar";
            this.btnListarAluno.UseVisualStyleBackColor = true;
            this.btnListarAluno.Click += new System.EventHandler(this.btnListarAluno_Click);
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.Location = new System.Drawing.Point(7, 20);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarAluno.TabIndex = 0;
            this.btnCadastrarAluno.Text = "Cadastrar";
            this.btnCadastrarAluno.UseVisualStyleBackColor = true;
            this.btnCadastrarAluno.Click += new System.EventHandler(this.btnCadastrarAluno_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnListarProfessor);
            this.groupBox2.Controls.Add(this.btnCadastrarProfessor);
            this.groupBox2.Location = new System.Drawing.Point(127, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(108, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Professor";
            // 
            // btnListarProfessor
            // 
            this.btnListarProfessor.Location = new System.Drawing.Point(7, 50);
            this.btnListarProfessor.Name = "btnListarProfessor";
            this.btnListarProfessor.Size = new System.Drawing.Size(75, 23);
            this.btnListarProfessor.TabIndex = 1;
            this.btnListarProfessor.Text = "Listar";
            this.btnListarProfessor.UseVisualStyleBackColor = true;
            this.btnListarProfessor.Click += new System.EventHandler(this.btnListarProfessor_Click);
            // 
            // btnCadastrarProfessor
            // 
            this.btnCadastrarProfessor.Location = new System.Drawing.Point(7, 20);
            this.btnCadastrarProfessor.Name = "btnCadastrarProfessor";
            this.btnCadastrarProfessor.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarProfessor.TabIndex = 0;
            this.btnCadastrarProfessor.Text = "Cadastrar";
            this.btnCadastrarProfessor.UseVisualStyleBackColor = true;
            this.btnCadastrarProfessor.Click += new System.EventHandler(this.btnCadastrarProfessor_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnListarMateria);
            this.groupBox3.Controls.Add(this.btnCadastrarMateria);
            this.groupBox3.Location = new System.Drawing.Point(241, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(111, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Materia";
            // 
            // btnListarMateria
            // 
            this.btnListarMateria.Location = new System.Drawing.Point(7, 49);
            this.btnListarMateria.Name = "btnListarMateria";
            this.btnListarMateria.Size = new System.Drawing.Size(75, 23);
            this.btnListarMateria.TabIndex = 1;
            this.btnListarMateria.Text = "Listar";
            this.btnListarMateria.UseVisualStyleBackColor = true;
            this.btnListarMateria.Click += new System.EventHandler(this.btnListarMateria_Click);
            // 
            // btnCadastrarMateria
            // 
            this.btnCadastrarMateria.Location = new System.Drawing.Point(7, 19);
            this.btnCadastrarMateria.Name = "btnCadastrarMateria";
            this.btnCadastrarMateria.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarMateria.TabIndex = 0;
            this.btnCadastrarMateria.Text = "Cadastrar";
            this.btnCadastrarMateria.UseVisualStyleBackColor = true;
            this.btnCadastrarMateria.Click += new System.EventHandler(this.btnCadastrarMateria_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 132);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnListarAluno;
        private System.Windows.Forms.Button btnCadastrarAluno;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnListarProfessor;
        private System.Windows.Forms.Button btnCadastrarProfessor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnListarMateria;
        private System.Windows.Forms.Button btnCadastrarMateria;
    }
}