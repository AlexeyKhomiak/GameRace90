   M S B A M L   `   `   `  ����D  @WPFSample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WPFSample	WPFSample  5   	       WPFSample.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WPFSample     5   	   Hi:http://schemas.microsoft.com/expression/2010/interactivity     5   	     � Title$  
MainWindow��5	   	   ��6   ��  �� Path$ Game.WindowWidth� �� Mode$ TwoWay=���6R   �� $ Game.WindowHeight�$ TwoWay=� � DataContext 5
        WPFSample.ViewModel  5   
   6    J� InputBindings 5      �� 5   
   
 �� Key$
 Left��6    �� Command 6    �� *	CarLeft+6>   �� 5   
   $ Right��6    6!   �� *
CarRight+6@   �� 5   
   $ Up��6    6   �� *CarUp+6:   �� 5   
   $
 Down��6    6    �� *	CarDown+6>   �� 5   
   $	 Esc��6    6   �� *Stop+6:   �� 5   
   $ Enter��6    6!   �� *Start+6=   .��5      �� .+�5   
   �� $��UniformToFill=�6   ��5      �� *Game.Road3.Sprite+��5      �� *Game.Road3.Width+��5      �� *Game.Road3.Height+67   �� 5   
   $��UniformToFill=�5       �� Left 5      �� *Game.Road1.X+
 �� Top 5      �� *Game.Road1.Y+��5       �� *Game.Road1.Sprite+��5!      �� *Game.Road1.Width+��5"      �� *Game.Road1.Height+67   �� 5#   
   $��UniformToFill=�5%       5#      �� *Game.Road2.X+ 5$      �� *Game.Road2.Y+��5&      �� *Game.Road2.Sprite+��5'      �� *Game.Road2.Width+��5(      �� *Game.Road2.Height+67   �� 5)   
   $��UniformToFill=�6   ��5*      �� *Game.Player.Sprite+��5+      �� *Game.Player.Width+ 5,      �� *Game.Player.X+ 5-      �� *Game.Player.Y+67   �� 5.   
   $��UniformToFill=�6   ��5/      �� *Game.Gasoline.Sprite+��50      �� *Game.Gasoline.Width+ 51      �� *Game.Gasoline.X+ 52      �� *Game.Gasoline.Y+69   �� 54   
   $��UniformToFill=�6   ��55      �� *Game.Bot1.Sprite+��56      �� *Game.Bot1.Width+ 57      �� *Game.Bot1.X+ 58      �� *Game.Bot1.Y+65   �� 5:   
   $��UniformToFill=�6   ��5;      �� *Game.Bot2.Sprite+��5<      �� *Game.Bot2.Width+ 5=      �� *Game.Bot2.X+ 5>      �� *Game.Bot2.Y+65   �� 5A   
   ��5B      �� *Game.TextStart.Sprite+��5C      �� *Game.TextStart.Width+��5D      �� *Game.TextStart.Height+ 5E      �� *Game.TextStart.X+ 5F      �� *Game.TextStart.Y+6:   �� 5H   
   ��5I      �� *Game.TextGameOver.Sprite+��5J      �� *Game.TextGameOver.Width+��5K      �� *Game.TextGameOver.Height+ 5L      �� *Game.TextGameOver.X+ 5M      �� *Game.TextGameOver.Y+6=   �� 5P   
   $��Score: ��5Q      
�������$��24(�5S      $
��Bold"�5T      5W      �� 5X   
   $ 7��5Y      $ 87��5Z      
�������$��24(�5]      $
��Bold"�5^      ��5[      �� $ Game.Player.Score�	 �� UpdateSourceTrigger$	 PropertyChanged=�5a      5b      5c      