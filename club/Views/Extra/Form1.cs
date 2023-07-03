using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace clubApp.Views
{
    public partial class Form1 : Form
    {
        private PictureBox player;
        private Timer enemyTimer;
        private Timer gameTimer;
        private bool isMovingLeft;
        private bool isMovingRight;
        public List<PictureBox> bullets = new List<PictureBox>();
        public List<PictureBox> enemies = new List<PictureBox>();
        private Label puntaje;
        private int numPuntaje=0;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            // Configurar el formulario
            this.BackColor = Color.Black;
            this.ClientSize = new Size(800, 600);

            //label del puntaje
            puntaje = new Label();
            puntaje.Location = new Point(this.ClientSize.Width - puntaje.Width,this.ClientSize.Height - puntaje.Height);
            puntaje.Text = "Puntaje : "+numPuntaje;
            puntaje.Visible = true;
            puntaje.ForeColor = Color.White;
            this.Controls.Add(puntaje);

            // Crear el jugador
            player = new PictureBox();
            player.Image = Properties.Resources.player;
            player.Name = "player";
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.Size = new Size(70,70);
            player.Location = new Point(this.ClientSize.Width / 2 - player.Width / 2, this.ClientSize.Height - player.Height - 10);
            this.Controls.Add(player);

            // Configurar el temporizador para mover a los enemigos
            enemyTimer = new Timer();
            enemyTimer.Interval = 1000;
            enemyTimer.Tick += EnemyTimer_Tick;
            enemyTimer.Start();

            // Configurar el temporizador principal del juego
            gameTimer = new Timer();
            gameTimer.Interval = 20;
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();
        }

        private void EnemyTimer_Tick(object sender, EventArgs e)
        {
            // Crear un enemigo nuevo y agregarlo al formulario
            PictureBox enemy = new PictureBox();
            enemy.Image = Properties.Resources.enemy;
            enemy.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy.Size = new Size(50, 50);
            enemy.Location = new Point(new Random().Next(0, this.ClientSize.Width - enemy.Width), 0);
            this.Controls.Add(enemy);
            this.enemies.Add(enemy);

            // Mover el enemigo hacia abajo
            Timer enemyMoveTimer = new Timer();
            enemyMoveTimer.Interval = 50;
            enemyMoveTimer.Tick += (s, ev) =>
            {
                enemy.Top += 10;
                if (!gameTimer.Enabled)
                {
                    enemyMoveTimer.Enabled = false;
                    enemyMoveTimer.Stop();
                }
                // Comprobar colisión con el jugador
                if (enemy.Bounds.IntersectsWith(player.Bounds))
                {
                    gameTimer.Stop();
                    enemyTimer.Stop();
                    enemy.Dispose();
                    player.Image = Properties.Resources.explode;
                    MessageBox.Show("¡Perdiste!");
                    this.Dispose();
                }

                // Comprobar si el enemigo llega al final
                if (enemy.Top >= this.ClientSize.Height)
                {
                }
            };
            enemyMoveTimer.Start();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            // Mover al jugador
            if (isMovingLeft)
            {
                player.Left -= 10;
            }
            else if (isMovingRight)
            {
                player.Left += 10;
            }

            // Comprobar límites del formulario
            if (player.Left < 0)
            {
                player.Left = 0;
            }
            else if (player.Right > this.ClientSize.Width)
            {
                player.Left = this.ClientSize.Width - player.Width;
            }
            foreach (PictureBox bullet in bullets)
            {
                bullet.Top -= 10;
                List<PictureBox> hit = new List<PictureBox>();
                // Comprobar colisión con los enemigos u otros elementos del juego
                foreach (PictureBox aux in this.enemies)
                {
                    if (bullet.Bounds.IntersectsWith(aux.Bounds))
                    {
                        aux.Dispose();
                        aux.Location = new Point();
                        numPuntaje += 1;
                        puntaje.Text = "Puntaje :" + numPuntaje;
                        aux.Image = Properties.Resources.explode;
                        hit.Add(aux);
                        bullet.Dispose();
                    }
                }
                foreach (PictureBox aux in hit)
                {
                    this.Controls.Remove(aux);
                    enemies.Remove(aux);   
                }
                // Comprobar si la bala sale de la pantalla
                if (bullet.Top + bullet.Height < 0)
                {
                    bullet.Dispose();
                }
            }

            // Limpiar las balas que se hayan salido de la pantalla
            bullets.RemoveAll(bullet => bullet.IsDisposed);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                isMovingLeft = true;
            }
            else if (e.KeyCode == Keys.Right)
            {
                isMovingRight = true;
            }
            if (e.KeyCode == Keys.Space)
            {
                // Crear una nueva bala
                PictureBox bullet = new PictureBox();
                bullet.Image = Properties.Resources.bullet;
                bullet.SizeMode = PictureBoxSizeMode.StretchImage;
                bullet.Size = new Size(10, 20);
                bullet.Location = new Point(player.Left + player.Width / 2 - bullet.Width / 2, player.Top - bullet.Height);
                this.Controls.Add(bullet);

                // Agregar la bala a la lista
                bullets.Add(bullet);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                isMovingLeft = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                isMovingRight = false;
            }
        }
    }
}
