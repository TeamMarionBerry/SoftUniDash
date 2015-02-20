﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SoftUniDash.CharacterClasses;

namespace SoftUniDash
{
    public partial class FormGameScreen : Form
    {
        Spell frozen = new Spell();

        private Mage player = new Mage("TODO", "Pesho", 100, 100, 200, 200, 25, 50, 50, 60);
        private Moving playerMoving;

        public FormGameScreen()
        {
            InitializeComponent();

            //Set game speed and start timer
            gameTimer.Interval = 24;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();

            playerNameLable.Text = player.Name;
            currentHealthLable.Text = player.CurrentHealth.ToString();
            playerMoving = Moving.None;

            StartGame();
        }

        private void StartGame()
        {

        }

        int velocity = 20;

        private void UpdateScreen(object sender, EventArgs e)
        {
            if (playerMoving == Moving.Left)
            {
                player.X -= velocity;
            }

            if (playerMoving == Moving.Right)
            {
                player.X += velocity;
            }

            if (playerMoving == Moving.Down)
            {
                player.Y += velocity;
            }

            if (playerMoving == Moving.Up)
            {
                player.Y -= velocity;
            }

            if (playerMoving == Moving.None)
            {
                velocity--;
            }

            if (velocity < 6)
            {
                velocity++;
            }

            mainCanvas.Invalidate();
        }

        private void mainCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            var playerColor = Brushes.Blue;

            canvas.FillRectangle(playerColor, player.X, player.Y, player.Height, player.Width);

            // Testing drowing
            //canvas.FillRectangle(playerColor, 60, 60, 50, 50);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormGameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.Left)
            {
                playerMoving = Moving.Left;
            }

            if (e.KeyCode == Keys.Right)
            {
                playerMoving = Moving.Right;
            }

            if (e.KeyCode == Keys.Up)
            {
                playerMoving = Moving.Up;
            }

            if (e.KeyCode == Keys.Down)
            {
                playerMoving = Moving.Down;
            }
        }

        private void FormGameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                playerMoving = Moving.None;
            }
        }

        protected override bool IsInputKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Right:
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                    return true;
                case Keys.Shift | Keys.Right:
                case Keys.Shift | Keys.Left:
                case Keys.Shift | Keys.Up:
                case Keys.Shift | Keys.Down:
                    return true;
            }
            return base.IsInputKey(keyData);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            switch (e.KeyCode)
            {
                case Keys.Left:
                case Keys.Right:
                case Keys.Up:
                case Keys.Down:
                    if (e.Shift)
                    {

                    }
                    else
                    {
                    }
                    break;
            }
        }
    }
}