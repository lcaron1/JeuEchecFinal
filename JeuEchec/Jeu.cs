using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuEchec
{
    public partial class Form_Jeu : Form
    {
        public Form_Jeu()
        {
            InitializeComponent();
            flowLayoutPanel1.Click += new EventHandler(Pieces_Click);
            Plateau plateau = new Plateau();
            Dictionary<Case, Piece> dictionnaire = plateau.getMap();
            foreach (KeyValuePair<Case, Piece> Objet in dictionnaire)
            {
                Objet.Key.Image = Objet.Value;
                flowLayoutPanel1.Controls.Add(Objet.Key);
            }
        }
        private void Pieces_Click(object sender, EventArgs e)
        {
            Case casePiece = (Case)sender;
            //Piece piece = (Piece)sender;
            lb_position.Text = casePiece.NameCase;
            //picture_Piece.Image = ;//image pieces



        }
    }
}
