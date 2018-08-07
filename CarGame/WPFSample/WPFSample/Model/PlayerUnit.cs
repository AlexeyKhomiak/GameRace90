using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFSample.Infrastructure;

namespace WPFSample.Model
{
	class PlayerUnit:BaseGameObject
	{
		int hp;
		int score;
		public int HP
		{
			get { return hp; }
			set { hp = value;  Notify(); }
		}
		public int Score
		{
			get { return score; }
			set { score = value;  Notify(); }
		}
	}
}
