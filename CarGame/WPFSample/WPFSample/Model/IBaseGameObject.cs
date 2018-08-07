using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSample.Model
{
	interface IBaseGameObject:INotifyPropertyChanged,ISprite,IGameObject
	{

	}
}
