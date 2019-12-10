using System.Drawing;
using System.Windows.Forms.Layout;

namespace JeuEchec
{
    partial class Form_Jeu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_position = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picture_Piece = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new JeuEchec.Layout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Piece)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 529);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(144, 82);
            this.listBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Au tour de :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pièce Selectionner";
            // 
            // lb_position
            // 
            this.lb_position.AutoSize = true;
            this.lb_position.Location = new System.Drawing.Point(371, 595);
            this.lb_position.Name = "lb_position";
            this.lb_position.Size = new System.Drawing.Size(44, 13);
            this.lb_position.TabIndex = 6;
            this.lb_position.Text = "Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 595);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Timer";
            // 
            // picture_Piece
            // 
            this.picture_Piece.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picture_Piece.Location = new System.Drawing.Point(472, 520);
            this.picture_Piece.Name = "picture_Piece";
            this.picture_Piece.Size = new System.Drawing.Size(100, 91);
            this.picture_Piece.TabIndex = 5;
            this.picture_Piece.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = global::JeuEchec.Properties.Resources.Plateau;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 12);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(56, 47, 48, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(507, 504);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // Form_Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 617);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_position);
            this.Controls.Add(this.picture_Piece);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.MaximizeBox = false;
            this.Name = "Form_Jeu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plateau";
            ((System.ComponentModel.ISupportInitialize)(this.picture_Piece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picture_Piece;
        private System.Windows.Forms.Label lb_position;
        private System.Windows.Forms.Label label3;
        private Layout flowLayoutPanel1;
    }
}

