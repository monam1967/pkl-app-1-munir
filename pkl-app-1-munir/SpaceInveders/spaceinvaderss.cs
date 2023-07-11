using pkl_app_1_munir.SpaceInveders.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pkl_app_1_munir.SpaceInveders
{
    public partial class spaceinvaderss : Form
    {
        private Bitmap _canvas = null;
        const int SPACE_BOARD_WIDTH = 80;
        const int SPACE_BOARD_HEIGHT = 40;
        const int SQUARE_SIZE = 10;
        const int JUMLAH_PELURU_ENEMY = 3;
        private List<EnemyModel> _listEnemy;
        private List<BentengModel> _listBenteng;
        private ActorModel _actor;
        private string _arahEnemy = "left";
        private string _arahActor = "";
        private PeluruModel _peluruActor;
        private List<PeluruModel> _listPeluruEnemy;
        private int _nyawaActor = 1;
        private int _score = 0;
        private bool _isGameOver = false;

        public spaceinvaderss()
        {
            InitializeComponent();
            _listEnemy = new List<EnemyModel>();
            _listBenteng = new List<BentengModel>();
            _actor = new ActorModel();
            _peluruActor = new PeluruModel();
            _listPeluruEnemy = new List<PeluruModel>();

            BuatEnemy();
            BuatBenteng();
            BuatActor();
            BuatPeluruActor();
            BuatPeluruEnemy();

            DrawAll();
        }

        private void DrawAll()
        {
            DBoard();
            DEnemy();
            DBenteng();
            DActor();
            DPeluru();
            DPeluruEnemy();

            if (_isGameOver)
            {
                DGameOver();
            }
            else
            {
                DScore();
            }

            Board.Invalidate();
        }

        private void DBoard()
        {
            _canvas = new Bitmap(Board.Width, Board.Height);
            using (var grafik = Graphics.FromImage(_canvas))
            {
                for (int x = 0; x < SPACE_BOARD_WIDTH; x++)
                    for (int y = 0; y < SPACE_BOARD_HEIGHT; y++)
                        grafik.DrawRectangle(new Pen(Color.DarkGreen), x * SQUARE_SIZE, y * SQUARE_SIZE, SQUARE_SIZE, SQUARE_SIZE);
            }
        }

        private void Board_Paint(object sender, PaintEventArgs e)
        {
            if (_canvas is null) return;
            e.Graphics.DrawImage(_canvas, 0, 0);
        }

        private void DEnemy()
        {
            using (var grafik = Graphics.FromImage(_canvas))
            {
                foreach (var enemy in _listEnemy.Where(x => x.IsAlive != 2).ToList())
                {
                    if (enemy.IsAlive == 0)
                        grafik.DrawImage(enemy.Gambar, enemy.PosX * SQUARE_SIZE, enemy.PosY * SQUARE_SIZE, enemy.Width * SQUARE_SIZE, enemy.Height * SQUARE_SIZE);
                    else
                    {
                        grafik.DrawImage(ExplosionPic.Image, enemy.PosX * SQUARE_SIZE, enemy.PosY * SQUARE_SIZE, enemy.Width * SQUARE_SIZE, enemy.Height * SQUARE_SIZE);
                        enemy.IsAlive = 2;
                    }

                }
            }
        }
        private void DActor()
        {
            using (var grafik = Graphics.FromImage(_canvas))
            {
                grafik.DrawImage(_actor.Gambar, _actor.PosX * SQUARE_SIZE, _actor.PosY * SQUARE_SIZE, _actor.Width * SQUARE_SIZE, _actor.Height * SQUARE_SIZE);
            }
        }
        private void DPeluru()
        {
            using (var grafik = Graphics.FromImage(_canvas))
            {
                grafik.DrawImage(_peluruActor.Gambar, _peluruActor.PosX * SQUARE_SIZE, _peluruActor.PosY * SQUARE_SIZE, _peluruActor.Width * SQUARE_SIZE, _peluruActor.Height * SQUARE_SIZE);
            }
        }

        private void DPeluruEnemy()
        {
            using (var grafik = Graphics.FromImage(_canvas))
            {
                foreach(var item in _listPeluruEnemy.Where(x => x.IsAktif))
                    grafik.DrawImage(item.Gambar, item.PosX * SQUARE_SIZE, item.PosY * SQUARE_SIZE, item.Width * SQUARE_SIZE, item.Height * SQUARE_SIZE);
            }
        }

        private void MoveEnemy()
        {
            var modifierX = 0;
            var modifierY = 0;
            switch (_arahEnemy)
            {
                case "up":
                    modifierX = 0;
                    modifierY = -1;
                    break;
                case "down":
                    modifierX = 0;
                    modifierY = 1;
                    break;
                case "left":
                    modifierX = -1;
                    modifierY = 0;
                    break;
                case "right":
                    modifierX = 1;
                    modifierY = 0;
                    break;
            }

            foreach (var enemy in _listEnemy)
            {
                enemy.PosX += modifierX;
                enemy.PosY += modifierY;
            }
        }

        private void DBenteng()
        {
            using (var grafik = Graphics.FromImage(_canvas))
            {
                foreach (var benteng in _listBenteng)
                {
                    Brush brush = null;
                    switch (benteng.DefencePower)
                    {
                        case 5:
                            brush = new SolidBrush(Color.Aquamarine);
                            break;
                        case 4:
                            brush = new SolidBrush(Color.Turquoise);
                            break;
                        case 3:
                            brush = new SolidBrush(Color.LightSeaGreen);
                            break;
                        case 2:
                            brush = new SolidBrush(Color.Teal);
                            break;
                        case 1:
                            brush = new SolidBrush(Color.FromArgb(0, 40, 40));
                            break;
                        default:
                            brush = new SolidBrush(Color.DarkSlateGray);
                            break;
                    };
                    grafik.FillRectangle(brush, benteng.PosX * SQUARE_SIZE, benteng.PosY * SQUARE_SIZE, benteng.Width * SQUARE_SIZE, benteng.Height * SQUARE_SIZE);

                }
            }
        }

        private void DGameOver()
        {
            if (_isGameOver)
            {
                using (var grafik = Graphics.FromImage(_canvas))
                {
                    var margin = 10;

                    Font gameOverFont = new Font("Arial", 34, FontStyle.Bold);
                    string gameOverText = "GAME OVER!";
                    SizeF gameOverSize = grafik.MeasureString(gameOverText, gameOverFont);
                    gameOverSize.Width += margin * 2;
                    gameOverSize.Height += margin * 2;

                    Font scoreFont = new Font("Arial", 18, FontStyle.Bold);
                    string scoreText = $"Score: {_score}";
                    SizeF scoreSize = grafik.MeasureString(scoreText, scoreFont);
                    scoreSize.Width += margin * 2;
                    scoreSize.Height += margin * 2;

                    var posXText = (Board.Width / 2) - (gameOverSize.Width / 2);
                    var posYText = 50;
                    var posXScore = (Board.Width / 2) - (scoreSize.Width / 2);
                    var posYScore = posYText + gameOverSize.Height + margin;

                    Rectangle rectGameOver = new Rectangle((int)posXText, (int)posYText, (int)gameOverSize.Width, (int)gameOverSize.Height);
                    var fillBrushGameOver = new SolidBrush(Color.AntiqueWhite);

                    Rectangle rectScore = new Rectangle((int)posXScore, (int)posYScore, (int)scoreSize.Width, (int)scoreSize.Height);
                    var fillBrushScore = new SolidBrush(Color.AntiqueWhite);

                    grafik.FillRectangle(fillBrushGameOver, rectGameOver);
                    grafik.FillRectangle(fillBrushScore, rectScore);
                    var line = new Pen(Color.DarkRed);
                    grafik.DrawRectangle(line, rectGameOver);
                    grafik.DrawRectangle(line, rectScore);

                    Brush brush = Brushes.DarkRed;
                    PointF positionGameOver = new PointF(posXText + margin, posYText + margin);
                    PointF positionScore = new PointF(posXScore + margin, posYScore + margin);
                    grafik.DrawString(gameOverText, gameOverFont, brush, positionGameOver);
                    grafik.DrawString(scoreText, scoreFont, brush, positionScore);
                }
            }
            Board.Invalidate();
        }

        private void DScore()
        {
            if (_isGameOver)
                return;

            using (var grafik = Graphics.FromImage(_canvas))
            {
                var margin = 5;

                Font font = new Font("Arial", 13, FontStyle.Bold);
                string text = $"Score: {_score}";
                SizeF size = grafik.MeasureString(text, font);
                size.Width += margin * 2;
                size.Height += margin * 2;

                var posXText = 10;
                var posYText = 10;

                Rectangle rect = new Rectangle((int)posXText, (int)posYText, (int)size.Width, (int)size.Height);
                var fillBrush = new SolidBrush(Color.Black);
                var line = new Pen(Color.White);

                grafik.FillRectangle(fillBrush, rect);
                grafik.DrawRectangle(line, rect);

                Brush brush = Brushes.White;
                PointF position = new PointF(posXText + margin, posYText + margin);
                grafik.DrawString(text, font, brush, position);
            }
            Board.Invalidate();
        }

        private void BuatEnemy()
        {
            const int WIDTH = 4;
            const int HEIGHT = 3;

            //  paling atas
            for (var i = 1; i <= 9; i++)
            {
                var newEnemy = new EnemyModel
                {
                    Id = i,
                    Gambar = Enemy3Pic.Image,
                    IsAlive = 0,
                    Width = WIDTH,
                    Height = HEIGHT,
                    PosX = (i * WIDTH * 2) - WIDTH,
                    PosY = 2
                };
                _listEnemy.Add(newEnemy);
            }

            //  tengah
            for (var i = 10; i <= 18; i++)
            {
                var newEnemy = new EnemyModel
                {
                    Id = i,
                    Gambar = Enemy2Pic.Image,
                    IsAlive = 0,
                    Width = WIDTH,
                    Height = HEIGHT,
                    PosX = ((i - 9) * WIDTH * 2) - WIDTH,
                    PosY = 7
                };
                _listEnemy.Add(newEnemy);
            }

            // baris ke-2
            for (var i = 19; i <= 27; i++)
            {
                var newEnemy = new EnemyModel
                {
                    Id = i,
                    Gambar = Enemy1Pic.Image,
                    IsAlive = 0,
                    Width = WIDTH,
                    Height = HEIGHT,
                    PosX = ((i - 18) * WIDTH * 2) - WIDTH,
                    PosY = 12
                };
                _listEnemy.Add(newEnemy);
            }

            // baris ke-1
            for (var i = 28; i <= 36; i++)
            {
                var newEnemy = new EnemyModel
                {
                    Id = i,
                    Gambar = Enemy1Pic.Image,
                    IsAlive = 0,
                    Width = WIDTH,
                    Height = HEIGHT,
                    PosX = ((i - 27) * WIDTH * 2) - WIDTH,
                    PosY = 17
                };
                _listEnemy.Add(newEnemy);
            }
        }

        private void BuatBenteng()
        {
            const int WIDTH = 6;
            const int HEIGHT = 1;

            for (var i = 1; i <= 8; i++)
            {
                var newBenteng = new BentengModel
                {
                    Id = i,
                    DefencePower = 1,
                    Height = HEIGHT,
                    Width = WIDTH,
                    PosX = (i * (WIDTH + 4)) - WIDTH,
                    PosY = 30
                };
                _listBenteng.Add(newBenteng);
            }

        }
        private void BuatActor()
        {
            _actor = new ActorModel
            {
                Gambar = ActorPic.Image,
                Width = 5,
                Height = 3,
                PosX = 0,
                PosY = 36,
            };
        }

        private void BuatPeluruActor()
        {
            _peluruActor.IsAktif = false;
            _peluruActor.Width = 1;
            _peluruActor.Height = 3;
            _peluruActor.Gambar = PeluruPic.Image;
        }

        private void BuatPeluruEnemy()
        {
            for(var i = 1; i <=JUMLAH_PELURU_ENEMY; i++)
            {
                _listPeluruEnemy.Add(new PeluruModel
                {
                    Gambar = PeluruEnemy.Image,
                    PosX = 0,
                    PosY = 0,
                    Height = 1,
                    Width = 1
                });
            }
        }

        private void EnemyTimer_Tick(object sender, EventArgs e)
        {
            var palingLeft = _listEnemy.Where(x => x.IsAlive == 0).Min(x => x.PosX);
            var palingRight = _listEnemy.Where(x => x.IsAlive == 0).Max(x => x.PosX + x.Width);

            if ((_arahEnemy == "left") && (palingLeft <= 0))
                _arahEnemy = "right";
            if ((_arahEnemy == "right") && (palingRight >= SPACE_BOARD_WIDTH))
                _arahEnemy = "left";
            MoveEnemy();
            DrawAll();
        }

        private void SpaceInvadersForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;
        }

        private void SpaceInvadersForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    _arahActor = "left";
                    break;
                case Keys.Right:
                    _arahActor = "right";
                    break;
                case Keys.Space:
                    TembakMusuh();
                    break;
            }
        }

        private void ActorTimer_Tick(object sender, EventArgs e)
        {
            if (_arahActor == "left")
                _actor.PosX--;
            if (_arahActor == "right")
                _actor.PosX++;

            if (_actor.PosX <= 0)
                _actor.PosX = 0;
            if (_actor.PosX > SPACE_BOARD_WIDTH - _actor.Width)
                _actor.PosX = SPACE_BOARD_WIDTH - _actor.Width;
            DrawAll();
        }

        private void SpaceInvadersForm_KeyUp(object sender, KeyEventArgs e)
        {
            _arahActor = string.Empty;
        }

        private void TembakMusuh()
        {
            if (_peluruActor.IsAktif)
                return;
            _peluruActor.PosX = _actor.PosX + (_actor.Width / 2);
            _peluruActor.PosY = _actor.PosY;
            _peluruActor.IsAktif = true;
        }

        private void PeluruActorTimer_Tick(object sender, EventArgs e)
        {
            if (!_peluruActor.IsAktif)
                return;
            _peluruActor.PosY--;

            //  peluru kena benteng?
            var bentengTertembak = BentengTertembak();
            if (bentengTertembak != null)
            {
                _peluruActor.IsAktif = false;
                _peluruActor.PosY = -10;
            }

            //  peluru kena enemy?
            var enemyTertembak = EnemyTertembak();
            if (enemyTertembak != null)
            {
                enemyTertembak.IsAlive = 1;
                _peluruActor.IsAktif = false;
                _peluruActor.PosY = -10;

                _score += 10;
            }

            if (_peluruActor.PosY <= 0)
            {
                _peluruActor.IsAktif = false;
                _peluruActor.PosY = -10;
            }
        }

        private EnemyModel EnemyTertembak()
        {
            foreach (var enemy in _listEnemy.Where(x => x.IsAlive == 0).OrderByDescending(x => x.Id).ToList())
            {
                // Pengandaian Tembak
                if (_peluruActor.PosY != enemy.PosY + 1 + enemy.Height)
                    continue;
                if (_peluruActor.PosX < enemy.PosX)
                    continue;
                if (_peluruActor.PosX > enemy.PosX + enemy.Width)
                    continue;
                return enemy;
            }
            return null;
        }

        private BentengModel BentengTertembak()
        {
            foreach (var benteng in _listBenteng)
            {
                if (benteng.DefencePower <= 0)
                    continue;
                if (_peluruActor.PosY > benteng.PosY + benteng.Height - 1)
                    continue;
                if (_peluruActor.PosX < benteng.PosX)
                    continue;
                if (_peluruActor.PosX > benteng.PosX + benteng.Width - 1)
                    continue;

                /*// Mengurangi kekuatan beteng
                benteng.DefencePower--;

                if (benteng.DefencePower <= 0)
                {
                    // Hapus beteng jika kekuatannya habis
                    _listBenteng.Remove(benteng);
                }*/

                return benteng;
            }
            return null;
        }

        private void PeluruEnemyTimer_Tick(object sender, EventArgs e)
        {
            foreach(var item in _listPeluruEnemy)
            {
                if (!item.IsAktif)
                    continue;
                item.PosY++;

                // Jika peluru enemy mengenai actor
                if (item.PosY >= _actor.PosY && item.PosY <= _actor.PosY + _actor.Height - 1 &&
                    item.PosX >= _actor.PosX && item.PosX <= _actor.PosX + _actor.Width - 1)
                {
                    
                    _nyawaActor--;
                    item.IsAktif = false;
                    item.PosY = -10;

                    /*// Menghentikan permainan jika nyawa habis
                    if (_nyawaActor <= 0 && !_isGameOver)
                    {
                        _isGameOver = true;
                        DGameOver();
                        GameOver();
                        return;
                    }*/
                    if (_nyawaActor <= 0)
                    {
                        DGameOver();
                        GameOver();
                        return;
                    }
                }

                if (item.PosY > SPACE_BOARD_HEIGHT)
                {
                    item.IsAktif = false;
                    item.PosY = -10;
                }

                /*var bentengTertembak = PeluruEnemyKenaBeteng(item);
                if (bentengTertembak != null)
                {
                    bentengTertembak.DefencePower--;
                    item.IsAktif = false;
                    item.PosY = -10;
                }*/
                var bentengTertembak = PeluruEnemyKenaBeteng(item);
                if (bentengTertembak != null)
                {
                    if (bentengTertembak.DefencePower <= 0)
                    {
                        item.IsAktif = false;
                        item.PosY = -10;
                    }
                    else
                    {
                        // Kurangi kekuatan pertahanan benteng
                        bentengTertembak.DefencePower--;
                    }
                }
            }
        }

        private void PeluruEnemyTembakTimer_Tick(object sender, EventArgs e)
        {
            var Nembak = RandomEnemyBawah();
            var peluru = _listPeluruEnemy.FirstOrDefault(x => !x.IsAktif);
            if (peluru is null)
                return;

            peluru.IsAktif = true;
            peluru.PosX = Nembak.PosX;
            peluru.PosY = Nembak.PosY;
        }

        private List<EnemyModel> ListEnemyBawah()
        {
            var listPosX= _listEnemy
                .Where(x => x.IsAlive == 0)
                .Select(x => x.PosX)
                .Distinct().ToList();
            var listEnemyBawah = new List<EnemyModel>();
            foreach(var item in listPosX)
            {
                var EBawah = _listEnemy
                    .Where(x => x.IsAlive == 0)
                    .Where(x => x.PosX == item)
                    .OrderByDescending(x => x.PosY)
                    .First();
                listEnemyBawah.Add(EBawah);
            }
            return listEnemyBawah;
        }

        private EnemyModel RandomEnemyBawah()
        {
            var listEnemy = ListEnemyBawah();
            var randomX = new Random();
            var Random = randomX.Next(1, listEnemy.Count);
            var result = listEnemy.Take(Random).Last();
            return result;
        }

        private void GameOver()
        {
            PeluruEnemyTimer.Stop();
            PeluruEnemyTembakTimer.Stop();
            ActorTimer.Stop();
            PeluruActorTimer.Stop();
            EnemyTimer.Stop();

            _isGameOver = true;
            DrawAll();
        }

        private BentengModel PeluruEnemyKenaBeteng(PeluruModel peluruEnemy)
        {
            foreach (var benteng in _listBenteng)
            {
                if (benteng.DefencePower <= 0)
                    continue;
                if (peluruEnemy.PosY < benteng.PosY)
                    continue;
                if (peluruEnemy.PosX < benteng.PosX)
                    continue;
                if (peluruEnemy.PosX > benteng.PosX + benteng.Width - 1)
                    continue;
                return benteng;
            }
            return null;
        }
    }
}
