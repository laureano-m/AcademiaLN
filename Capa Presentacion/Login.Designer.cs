namespace Capa_Presentacion
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.LoginBox = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnIngresar = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginBox
            // 
            this.LoginBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoginBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.LoginBox.Location = new System.Drawing.Point(176, 133);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(532, 455);
            this.LoginBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnIngresar);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.labelContraseña);
            this.panel1.Controls.Add(this.labelUsuario);
            this.panel1.Controls.Add(this.LoginBox);
            this.panel1.Location = new System.Drawing.Point(4, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 692);
            this.panel1.TabIndex = 2;
            // 
            // labelUsuario
            // 
            this.labelUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.labelUsuario.Font = new System.Drawing.Font("SAPGUI-Belize-Icons", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.labelUsuario.Location = new System.Drawing.Point(311, 235);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelUsuario.Size = new System.Drawing.Size(100, 20);
            this.labelUsuario.TabIndex = 2;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelContraseña
            // 
            this.labelContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.labelContraseña.Font = new System.Drawing.Font("SAPGUI-Belize-Icons", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.labelContraseña.Location = new System.Drawing.Point(307, 309);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelContraseña.Size = new System.Drawing.Size(100, 20);
            this.labelContraseña.TabIndex = 3;
            this.labelContraseña.Text = "Contraseña";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(153)))), ((int)(((byte)(190)))));
            this.textBox1.Location = new System.Drawing.Point(311, 270);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(153)))), ((int)(((byte)(190)))));
            this.textBox2.Location = new System.Drawing.Point(311, 346);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(270, 20);
            this.textBox2.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("SAPGUI-Belize-Icons", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.btnIngresar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnIngresar.IconColor = System.Drawing.Color.Black;
            this.btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIngresar.Location = new System.Drawing.Point(311, 403);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 35);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("SAPGUI-Belize-Icons", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSalir.IconColor = System.Drawing.Color.Black;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.Location = new System.Drawing.Point(506, 403);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 35);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(884, 711);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LoginBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.Label labelUsuario;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

