
namespace CapaPresentacion.Formularios
{
    partial class Form_MenuPrincipal
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
            this.panel_barraTitulo = new System.Windows.Forms.Panel();
            this.btn_minimizar = new FontAwesome.Sharp.IconPictureBox();
            this.btn_salir = new FontAwesome.Sharp.IconPictureBox();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_usuarios = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.panel_contenedorForms = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cerrarForm = new FontAwesome.Sharp.IconPictureBox();
            this.Titulo_FormAbierto = new FontAwesome.Sharp.IconButton();
            this.panel_barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            this.panel_menu.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel_contenedor.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrarForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_barraTitulo
            // 
            this.panel_barraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(0)))));
            this.panel_barraTitulo.Controls.Add(this.btn_minimizar);
            this.panel_barraTitulo.Controls.Add(this.btn_salir);
            this.panel_barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panel_barraTitulo.Name = "panel_barraTitulo";
            this.panel_barraTitulo.Size = new System.Drawing.Size(1250, 29);
            this.panel_barraTitulo.TabIndex = 0;
            this.panel_barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_barraTitulo_MouseDown);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(0)))));
            this.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_minimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btn_minimizar.IconColor = System.Drawing.SystemColors.ControlText;
            this.btn_minimizar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_minimizar.IconSize = 25;
            this.btn_minimizar.Location = new System.Drawing.Point(1190, 2);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(25, 25);
            this.btn_minimizar.TabIndex = 1;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            this.btn_minimizar.MouseLeave += new System.EventHandler(this.btn_salir_MouseLeave);
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(0)))));
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salir.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btn_salir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_salir.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btn_salir.IconColor = System.Drawing.SystemColors.ControlText;
            this.btn_salir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_salir.IconSize = 25;
            this.btn_salir.Location = new System.Drawing.Point(1218, 2);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(30, 25);
            this.btn_salir.TabIndex = 0;
            this.btn_salir.TabStop = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            this.btn_salir.MouseEnter += new System.EventHandler(this.btn_salir_MouseHover);
            this.btn_salir.MouseLeave += new System.EventHandler(this.btn_salir_MouseLeave);
            this.btn_salir.MouseHover += new System.EventHandler(this.btn_salir_MouseHover);
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(46)))));
            this.panel_menu.Controls.Add(this.flowLayoutPanel1);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 29);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(229, 691);
            this.panel_menu.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_usuarios);
            this.flowLayoutPanel1.Controls.Add(this.iconButton1);
            this.flowLayoutPanel1.Controls.Add(this.iconButton2);
            this.flowLayoutPanel1.Controls.Add(this.iconButton3);
            this.flowLayoutPanel1.Controls.Add(this.iconButton4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 120);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(229, 517);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btn_usuarios
            // 
            this.btn_usuarios.FlatAppearance.BorderSize = 0;
            this.btn_usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(170)))));
            this.btn_usuarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btn_usuarios.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(170)))));
            this.btn_usuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_usuarios.IconSize = 35;
            this.btn_usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_usuarios.Location = new System.Drawing.Point(0, 0);
            this.btn_usuarios.Margin = new System.Windows.Forms.Padding(0);
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.Padding = new System.Windows.Forms.Padding(10);
            this.btn_usuarios.Size = new System.Drawing.Size(238, 55);
            this.btn_usuarios.TabIndex = 1;
            this.btn_usuarios.Text = "  Usuarios";
            this.btn_usuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_usuarios.UseVisualStyleBackColor = true;
            this.btn_usuarios.Click += new System.EventHandler(this.btn_usuarios_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(170)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.AmazonPay;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(170)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 55);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10);
            this.iconButton1.Size = new System.Drawing.Size(238, 55);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "  Usuarios";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(170)))));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.AmazonPay;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(170)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 35;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 110);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10);
            this.iconButton2.Size = new System.Drawing.Size(238, 55);
            this.iconButton2.TabIndex = 3;
            this.iconButton2.Text = "  Usuarios";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(170)))));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.AmazonPay;
            this.iconButton3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(170)))));
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 35;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 165);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(10);
            this.iconButton3.Size = new System.Drawing.Size(238, 55);
            this.iconButton3.TabIndex = 4;
            this.iconButton3.Text = "  Usuarios";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(170)))));
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.AmazonPay;
            this.iconButton4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(170)))));
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 35;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(0, 220);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(10);
            this.iconButton4.Size = new System.Drawing.Size(238, 55);
            this.iconButton4.TabIndex = 5;
            this.iconButton4.Text = "  Usuarios";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.BackColor = System.Drawing.Color.White;
            this.panel_contenedor.Controls.Add(this.panel_contenedorForms);
            this.panel_contenedor.Controls.Add(this.panel1);
            this.panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor.Location = new System.Drawing.Point(229, 29);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(1021, 691);
            this.panel_contenedor.TabIndex = 2;
            // 
            // panel_contenedorForms
            // 
            this.panel_contenedorForms.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_contenedorForms.Location = new System.Drawing.Point(0, 63);
            this.panel_contenedorForms.Name = "panel_contenedorForms";
            this.panel_contenedorForms.Size = new System.Drawing.Size(1021, 628);
            this.panel_contenedorForms.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_cerrarForm);
            this.panel1.Controls.Add(this.Titulo_FormAbierto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 57);
            this.panel1.TabIndex = 7;
            // 
            // btn_cerrarForm
            // 
            this.btn_cerrarForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrarForm.BackColor = System.Drawing.Color.White;
            this.btn_cerrarForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrarForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(98)))), ((int)(((byte)(101)))));
            this.btn_cerrarForm.IconChar = FontAwesome.Sharp.IconChar.XmarkSquare;
            this.btn_cerrarForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(98)))), ((int)(((byte)(101)))));
            this.btn_cerrarForm.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_cerrarForm.IconSize = 30;
            this.btn_cerrarForm.Location = new System.Drawing.Point(980, 15);
            this.btn_cerrarForm.Name = "btn_cerrarForm";
            this.btn_cerrarForm.Size = new System.Drawing.Size(30, 30);
            this.btn_cerrarForm.TabIndex = 2;
            this.btn_cerrarForm.TabStop = false;
            this.btn_cerrarForm.Visible = false;
            this.btn_cerrarForm.Click += new System.EventHandler(this.btn_cerrarForm_Click);
            // 
            // Titulo_FormAbierto
            // 
            this.Titulo_FormAbierto.Enabled = false;
            this.Titulo_FormAbierto.FlatAppearance.BorderSize = 0;
            this.Titulo_FormAbierto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titulo_FormAbierto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_FormAbierto.ForeColor = System.Drawing.Color.Black;
            this.Titulo_FormAbierto.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.Titulo_FormAbierto.IconColor = System.Drawing.Color.Black;
            this.Titulo_FormAbierto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Titulo_FormAbierto.IconSize = 45;
            this.Titulo_FormAbierto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Titulo_FormAbierto.Location = new System.Drawing.Point(6, 3);
            this.Titulo_FormAbierto.Margin = new System.Windows.Forms.Padding(0);
            this.Titulo_FormAbierto.Name = "Titulo_FormAbierto";
            this.Titulo_FormAbierto.Size = new System.Drawing.Size(278, 51);
            this.Titulo_FormAbierto.TabIndex = 6;
            this.Titulo_FormAbierto.Text = "  Usuarios";
            this.Titulo_FormAbierto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Titulo_FormAbierto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Titulo_FormAbierto.UseVisualStyleBackColor = true;
            this.Titulo_FormAbierto.Visible = false;
            // 
            // Form_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1250, 720);
            this.Controls.Add(this.panel_contenedor);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel_barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal CowApp";
            this.panel_barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            this.panel_menu.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel_contenedor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrarForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_barraTitulo;
        private FontAwesome.Sharp.IconPictureBox btn_minimizar;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel_contenedor;
        private FontAwesome.Sharp.IconPictureBox btn_salir;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton btn_usuarios;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton Titulo_FormAbierto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_contenedorForms;
        private FontAwesome.Sharp.IconPictureBox btn_cerrarForm;
    }
}