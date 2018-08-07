using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFSample.Infrastructure;

namespace WPFSample.Model
{
	class BaseGameObject : NotifyPropertyChanged,IBaseGameObject
	{
		int x;
		int y;
		int width;
		int height;
		string sprite;
		public int Height
		{
			get { return height; }
			set { height = value; Notify(); }
		}
		public string Sprite
		{
			get { return sprite; }
			set { sprite = value; Notify(); }
		}

		public int Width
		{
			get { return width; }
			set { width = value; Notify(); }
		}

		public int X
		{
			get { return x; }
			set { x = value; Notify(); }
		}

		public int Y
		{
			get { return y; }
			set { y = value; Notify(); }
		}
	}
}
