using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MCS_Week_003_final
{
    public partial class Form1 : Form
    {
        Color currentColor = Color.White;
        private int XTILES = 25; //Number of X tiles
        private int YTILES = 25; //Number of Y tiles
        private int TILESIZE = 10; //Size of the tiles (pixles)
        private PictureBox[,] mazeTiles;

        public Form1()
        {
            InitializeComponent();
            createNewMaze();
        }

        private void createNewMaze()
        {
            mazeTiles = new PictureBox[XTILES, YTILES];

            //Loop for getting all tiles
            for (int i = 0; i < XTILES; i++)
            {
                for (int j = 0; j < YTILES; j++)
                {
                    //initialize a new PictureBox array at cordinate XTILES, YTILES
                    mazeTiles[i, j] = new PictureBox();

                    //calculate size and location
                    int xPosition = (i * TILESIZE) + 13; //13 is padding from left
                    int yPosition = (j * TILESIZE) + 45; //45 is padding from top
                    mazeTiles[i, j].SetBounds(xPosition, yPosition, TILESIZE, TILESIZE);

                    //make top left and right bottom corner light blue. Used for start and finish
                    if ((i == 0 && j == 0) || (i == XTILES - 1 && j == YTILES - 1))
                        mazeTiles[i, j].BackColor = Color.LightBlue;
                    else
                    {
                        //make all other tiles white
                        mazeTiles[i, j].BackColor = Color.White;
                        //make it clickable
                        EventHandler clickEvent = new EventHandler(PictureBox_Click);
                        mazeTiles[i, j].Click += clickEvent; // += used incase other events are used
                    }

                    //Add to controls to form (display picture box)
                    this.Controls.Add(mazeTiles[i, j]);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            currentColor = Color.White;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            currentColor = Color.Black;
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = currentColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Create a previously searched array
            bool[,] alreadySearched = new bool[XTILES,YTILES];

            //Starts the recursive solver at tile (0,0). If false maze can not be solved.
            if(!solveMaze(0,0, alreadySearched))
                MessageBox.Show("Maze can not be solved.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Change all greay tiles to white
            for (int i = 0; i < XTILES; i++)
            {
                for (int j = 0; j < YTILES; j++)
                {
                    if (mazeTiles[i, j].BackColor == Color.Gray)
                        mazeTiles[i, j].BackColor = Color.White;
                }
            }

            //Reset start and finish to light blue
            mazeTiles[0, 0].BackColor = Color.LightBlue;
            mazeTiles[XTILES - 1, YTILES - 1].BackColor = Color.LightBlue;
        }

        private bool solveMaze(int xPos, int yPos, bool[,] alreadySearched)
        {
            bool correctPath = false;
            //should the computer check this tile
            bool shouldCheck = true;

            //Check for out of boundaries
            if (xPos >= XTILES || xPos < 0 || yPos >= YTILES || yPos < 0)
                shouldCheck = false;
            else
            {
                //Check if at finish, not (0,0 and colored light blue)
                if (mazeTiles[xPos, yPos].BackColor == Color.LightBlue && (xPos != 0 && yPos != 0))
                {
                    correctPath = true;
                    shouldCheck = false;
                }

                //Check for a wall
                if (mazeTiles[xPos, yPos].BackColor == Color.Black)
                    shouldCheck = false;

                //Check if previously searched
                if (alreadySearched[xPos, yPos])
                    shouldCheck = false;
            }

            //Search the Tile
            if (shouldCheck)
            {
                //mark tile as searched
                alreadySearched[xPos, yPos] = true;

                //Check right tile
                correctPath = correctPath || solveMaze(xPos + 1, yPos, alreadySearched);
                //Check down tile
                correctPath = correctPath || solveMaze(xPos, yPos + 1, alreadySearched);
                //check left tile
                correctPath = correctPath || solveMaze(xPos - 1, yPos, alreadySearched);
                //check up tile
                correctPath = correctPath || solveMaze(xPos, yPos - 1, alreadySearched);
            }

            //make correct path gray
            if (correctPath)
                mazeTiles[xPos, yPos].BackColor = Color.Gray;

            return correctPath;
        }
    }
}
