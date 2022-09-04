
namespace CapaPresentacion
{
    partial class Form_Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cerrar = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tgbtn_ver_contraseña = new RJCodeAdvance.RJControls.RJToggleButton();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txt_contraseña = new RJCodeAdvance.RJControls.RJTextBox();
            this.txt_usuario = new RJCodeAdvance.RJControls.RJTextBox();
            this.btn_ingresar = new RJCodeAdvance.RJControls.RJButton();
            this.rjCircularPictureBox1 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(108)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.btn_cerrar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 145);
            this.panel1.TabIndex = 0;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btn_cerrar.IconColor = System.Drawing.Color.White;
            this.btn_cerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cerrar.IconSize = 30;
            this.btn_cerrar.Location = new System.Drawing.Point(626, 3);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(30, 30);
            this.btn_cerrar.TabIndex = 5;
            this.btn_cerrar.TabStop = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(657, 448);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tgbtn_ver_contraseña);
            this.panel3.Controls.Add(this.iconPictureBox2);
            this.panel3.Controls.Add(this.iconPictureBox1);
            this.panel3.Controls.Add(this.txt_contraseña);
            this.panel3.Controls.Add(this.txt_usuario);
            this.panel3.Controls.Add(this.btn_ingresar);
            this.panel3.Controls.Add(this.rjCircularPictureBox1);
            this.panel3.Location = new System.Drawing.Point(87, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(483, 361);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(154, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ver Contraseña";
            // 
            // tgbtn_ver_contraseña
            // 
            this.tgbtn_ver_contraseña.Location = new System.Drawing.Point(116, 240);
            this.tgbtn_ver_contraseña.MinimumSize = new System.Drawing.Size(25, 15);
            this.tgbtn_ver_contraseña.Name = "tgbtn_ver_contraseña";
            this.tgbtn_ver_contraseña.OffBackColor = System.Drawing.Color.Gray;
            this.tgbtn_ver_contraseña.OffToggleColor = System.Drawing.Color.White;
            this.tgbtn_ver_contraseña.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(108)))), ((int)(((byte)(233)))));
            this.tgbtn_ver_contraseña.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tgbtn_ver_contraseña.Size = new System.Drawing.Size(32, 18);
            this.tgbtn_ver_contraseña.TabIndex = 5;
            this.tgbtn_ver_contraseña.UseVisualStyleBackColor = true;
            this.tgbtn_ver_contraseña.CheckedChanged += new System.EventHandler(this.tgbtn_ver_contraseña_CheckedChanged);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Gray;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Gray;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 25;
            this.iconPictureBox2.Location = new System.Drawing.Point(341, 198);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(25, 25);
            this.iconPictureBox2.TabIndex = 4;
            this.iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Gray;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Gray;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 25;
            this.iconPictureBox1.Location = new System.Drawing.Point(341, 152);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(25, 25);
            this.iconPictureBox1.TabIndex = 4;
            this.iconPictureBox1.TabStop = false;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.BackColor = System.Drawing.SystemColors.Window;
            this.txt_contraseña.BorderColor = System.Drawing.Color.Gray;
            this.txt_contraseña.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(108)))), ((int)(((byte)(233)))));
            this.txt_contraseña.BorderRadius = 0;
            this.txt_contraseña.BorderSize = 2;
            this.txt_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_contraseña.ForeColor = System.Drawing.Color.Gray;
            this.txt_contraseña.Location = new System.Drawing.Point(116, 194);
            this.txt_contraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txt_contraseña.Multiline = false;
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_contraseña.PasswordChar = true;
            this.txt_contraseña.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_contraseña.PlaceholderText = "";
            this.txt_contraseña.Size = new System.Drawing.Size(250, 32);
            this.txt_contraseña.TabIndex = 3;
            this.txt_contraseña.Texts = "Contraseña";
            this.txt_contraseña.UnderlinedStyle = true;
            this.txt_contraseña.Enter += new System.EventHandler(this.txt_contraseña_Enter);
            this.txt_contraseña.Leave += new System.EventHandler(this.txt_usuario_Leave);
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.SystemColors.Window;
            this.txt_usuario.BorderColor = System.Drawing.Color.Gray;
            this.txt_usuario.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(108)))), ((int)(((byte)(233)))));
            this.txt_usuario.BorderRadius = 0;
            this.txt_usuario.BorderSize = 2;
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_usuario.ForeColor = System.Drawing.Color.Gray;
            this.txt_usuario.Location = new System.Drawing.Point(116, 148);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_usuario.Multiline = false;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_usuario.PasswordChar = false;
            this.txt_usuario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_usuario.PlaceholderText = "";
            this.txt_usuario.Size = new System.Drawing.Size(250, 32);
            this.txt_usuario.TabIndex = 2;
            this.txt_usuario.Texts = "Usuario";
            this.txt_usuario.UnderlinedStyle = true;
            this.txt_usuario.Enter += new System.EventHandler(this.txt_usuario_Enter);
            this.txt_usuario.Leave += new System.EventHandler(this.txt_usuario_Leave);
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(108)))), ((int)(((byte)(233)))));
            this.btn_ingresar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(108)))), ((int)(((byte)(233)))));
            this.btn_ingresar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ingresar.BorderRadius = 0;
            this.btn_ingresar.BorderSize = 0;
            this.btn_ingresar.FlatAppearance.BorderSize = 0;
            this.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_ingresar.ForeColor = System.Drawing.Color.White;
            this.btn_ingresar.Location = new System.Drawing.Point(177, 313);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(132, 31);
            this.btn_ingresar.TabIndex = 1;
            this.btn_ingresar.Text = "INGRESAR";
            this.btn_ingresar.TextColor = System.Drawing.Color.White;
            this.btn_ingresar.UseVisualStyleBackColor = false;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(133)))), ((int)(((byte)(245)))));
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(133)))), ((int)(((byte)(245)))));
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.rjCircularPictureBox1.BorderSize = 0;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Image = global::CapaPresentacion.Properties.Resources.perfil;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(198, 27);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(89, 89);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 0;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(657, 448);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login CowApp";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private RJCodeAdvance.RJControls.RJTextBox txt_contraseña;
        private RJCodeAdvance.RJControls.RJTextBox txt_usuario;
        private RJCodeAdvance.RJControls.RJButton btn_ingresar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox btn_cerrar;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJToggleButton tgbtn_ver_contraseña;
    }
}

