using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Input;
using WPFSample.Model;

namespace WPFSample
{
	class ViewModel
	{
		public Game Game { get; set; }
		public ViewModel()
		{
			Game = new Game();
		}


		RelayCommand _carLeft;
		RelayCommand _carRight;
		RelayCommand _carUp;
		RelayCommand _carDown;
        RelayCommand _stop;
        RelayCommand _start;

        public ICommand Start
        {
            get
            {
                if (_start == null)
                    _start = new RelayCommand((x) =>
                    {
                        Game.StartGame();
                        
                    });
                return _start;
            }
        }

        public ICommand Stop
        {
            get
            {
                if (_stop == null)
                    _stop = new RelayCommand((x) =>
                    {
                        Game.StopGame();
                    });
                return _stop;
            }
        }
        public ICommand CarUp
		{
			get
			{
				if (_carUp == null)
					_carUp = new RelayCommand((x) =>
					{
						Game.UpMove();
					});
				return _carUp;
			}
		}
		public ICommand CarDown
		{
			get
			{
				if (_carDown == null)
					_carDown = new RelayCommand((x) =>
					{
						Game.DownMove();
					});
				return _carDown;
			}
		}
		public ICommand CarLeft
		{
			get
			{
				if (_carLeft == null)
					_carLeft = new RelayCommand((x) =>
					{
						Game.LeftMove();
					});
				return _carLeft;

			}
		}
		public ICommand CarRight
		{
			get
			{
				if (_carRight == null)
					_carRight = new RelayCommand((x) =>
					{
						Game.RightMove();
					});
				return _carRight;
			}
		}
	}
}
