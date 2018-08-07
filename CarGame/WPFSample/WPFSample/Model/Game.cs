using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;

namespace WPFSample.Model
{
	class Game:BaseGameObject, IGame
    {

		public int WindowWidth { get; set; }
		public int WindowHeight { get; set; }
		Timer timer;
		public RoadUnit Road1 { get; set; }
		public RoadUnit Road2 { get; set; }
        public RoadUnit Road3 { get; set; }

        public RoadUnit TextStart { get; set; }
        public RoadUnit TextGameOver { get; set; }
           
        public RoadUnit Bot1 { get; set; }
        public RoadUnit Bot2 { get; set; }

        public RoadUnit Gasoline { get; set; }

        public PlayerUnit Player { get; set; }
                
		int dy =1;
        enum Pos { first=95, sec=160, third=228, forth=285 }
        static Pos RandomPosition<Pos>()
        {
            var v = Enum.GetValues(typeof(Pos));
            return (Pos)v.GetValue(new Random().Next(v.Length));
        }
        public Game()
		{
            
            WindowWidth = 410;
			WindowHeight = 350;
            
            Road1 = new RoadUnit
			{
				X = 0,
				Y = 0,
				Width = 400,
				Height = 325,
				LeftBorder = 100,
				RightBorder = 270,
				Sprite = @"\Sprites\road.png"
			};
			Road2 = new RoadUnit
			{
				X = 0,
				Y = -320,
				Width = 400,
				Height = 325,
				LeftBorder = 100,
				RightBorder = 270,
				Sprite = @"\Sprites\road.png"
			};
            Road3 = new RoadUnit
            {
                X = 0,
                Y = 0,
                Width = 400,
                Height = 325,
                LeftBorder = 100,
                RightBorder = 270,
                Sprite = "\\Sprites\\roads.png"
            };

            Player = new PlayerUnit
            {
                Score = 0,
				X = 221,
				Y = 230,
				Width = 40,
				Sprite = @"\Sprites\car.png"
			};


            Gasoline = new RoadUnit
            {                
                X = (int)RandomPosition<Pos>(),
                Y = -200,
                Width = 35,
                Height = 35,
                Sprite = "\\Sprites\\gas.png"
            };

            Bot1 = new RoadUnit
            {
                X = (int)RandomPosition<Pos>(),
                Y = -200,
                Width = 40,
                //Height = 35,
                Sprite = "\\Sprites\\bot1.png"
            };

            Bot2 = new RoadUnit
            {
                X = (int)RandomPosition<Pos>(),
                Y = -100,
                Width = 40,
                //Height = 35,
                Sprite = "\\Sprites\\bot2.png"
            };

            TextStart = new RoadUnit
            {
                X = 115,
                Y = 50,
                Width = 200,
                Height = 200,
                Sprite = "\\Sprites\\start.png"
            };

            

            //timer = new Timer(Update);
        }


        public void SetUnit()
        {
            Player.Score = 0;
            Player.X = 221;
            Player.Y = 230;

            Gasoline.X = (int)RandomPosition<Pos>();
            Gasoline.Y = -200;

            Bot1.X = (int)RandomPosition<Pos>();
            Bot1.Y = -200;
            
            Bot2.X = (int)RandomPosition<Pos>();
            Bot2.Y = -100;

        }

        public void StartGame()
		{
            SetUnit();

            timer = new Timer(Update);
            timer.Change(1000, 10);
        
		}
		public void StopGame()
		{
			timer.Dispose();

            
        }
        MessageBoxResult result;
        private void Update(object obj)
		{
            TextStart.Y += dy;

            Road1.Y += dy;
			Road2.Y += dy;
			if (Road1.Y >= 320)
				Road1.Y = -320;
			if (Road2.Y >= 320)
				Road2.Y = -320;

            Gasoline.Y += dy;
            if (Gasoline.Y>=320)
            {
                Gasoline.Y = -100;
                Gasoline.X = (int)RandomPosition<Pos>();
            }

            Bot1.Y += dy+1;
            if (Bot1.Y >= 320)
            {
                Bot1.Y = -50;
                Bot1.X = (int)RandomPosition<Pos>();
            }

            Bot2.Y += dy - 1;
            if (Bot2.Y >= 320)
            {
                Bot2.Y = -100;
                Bot2.X = (int)RandomPosition<Pos>();
            }
            if (((Player.X >= Bot1.X) && (Player.X <= Bot1.X + Bot1.Width)
               && (Player.Y <= Bot1.Y) && (Player.Y <= Bot1.Y + Bot1.Height))
               || ((Bot1.X >= Player.X) && (Bot1.X <= Player.X + Player.Width))
               && (Bot1.Y + Bot1.Height >= Player.Y) && (Bot1.Y + Bot1.Height >= Player.Y + Player.Height))
            {

                timer.Dispose();
                result = MessageBox.Show(
                    "GAME OVER!\n Начать сначала?", 
                    "GAME OVER", 
                    MessageBoxButton.OKCancel,
                    MessageBoxImage.Information
                    );
                switch (result)
                {
                    case MessageBoxResult.OK:
                        StartGame();
                        break;
                    case MessageBoxResult.Cancel:
                        break;
                }
            }

            if (((Player.X >= Bot2.X) && (Player.X <= Bot2.X + Bot2.Width)
   && (Player.Y <= Bot2.Y) && (Player.Y <= Bot2.Y + Bot2.Height))
   || ((Bot2.X >= Player.X) && (Bot2.X <= Player.X + Player.Width))
   && (Bot2.Y + Bot2.Height >= Player.Y) && (Bot2.Y + Bot2.Height >= Player.Y + Player.Height))
            {

                timer.Dispose();
                result = MessageBox.Show(
                    "GAME OVER!\n Начать сначала?",
                    "GAME OVER",
                    MessageBoxButton.OKCancel,
                    MessageBoxImage.Information
                    );
                switch (result)
                {
                    case MessageBoxResult.OK:
                        StartGame();
                        break;
                    case MessageBoxResult.Cancel:
                        break;
                }
            }


            if (((Player.X >= Gasoline.X) && (Player.X <= Gasoline.X + Gasoline.Width)                
                && (Player.Y<=Gasoline.Y) && (Player.Y<=Gasoline.Y+Gasoline.Height))
                ||((Gasoline.X >=Player.X) && (Gasoline.X <= Player.X + Player.Width)) 
                && (Gasoline.Y + Gasoline.Height>= Player.Y) && (Gasoline.Y + Gasoline.Height >= Player.Y + Player.Height))
            {
                Gasoline.Y = -100;
                Gasoline.X = (int)RandomPosition<Pos>();
                Player.Score += 1;
            }



            if (Player.Score==2)
            {
                dy = 2;
            }
            if (Player.Score == 5)
            {
                dy = 4;
            }
            if (Player.Score == 10)
            {
                dy = 6;
            }
            if (Player.Score <= 1)
            {
                dy = 1;
            }

        }


        public void UpMove()
        {
            //if (dy >= 8)
            //{
            //    dy = 8;
            //    return;
            //}
            //dy *= 2;
        }
        public void DownMove()
        {
            //if (dy <= 1)
            //{
            //    dy = 1;
            //    return;
            //}
            //dy /= 2;
        }
        public void RightMove()
		{
			if (Player.X >= Road1.RightBorder)
				return;
			Player.X += 63;
		}
		public void LeftMove()
		{
			if (Player.X <= Road1.LeftBorder)
				return;
			Player.X -= 63;
		}
        
    }
}
