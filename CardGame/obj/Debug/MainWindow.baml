   M S B A M L   `   `   `  ����C  ?CardGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CardGameCardGame  5   	       CardGame.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:CardGame     5   	     � Title$  
MainWindow��5   	   $	��734��6   $
��1336��6)   $
��1000��5	   	   $
��1800��6    � 
ResizeMode$ NoResize=�5
   	    � 	Resources 5         ZoomPercentageConverter1  ZoomPercentageConverter��%:   &	        &	      	� 5   
   6"   	� 5   
   6"   5      .��5      � ��5   
   �� 5       �� ImageSource$ casino2.jpg��6   .+�5   
   � -   5         �Name$
 grid��5      $��Stretch=�6   $	��Top=�6;   $��204,162,174,0q�6S    J� RenderTransformOrigin$ 0.5,0.5&�6j   $
��Auto��6�   $	��541��6�   $��0��6�   ��6�   �� *ActualHeight+ �� Mode$ OneWay=� �� RelativeSource �� *FindAncestor+ �� AncestorType   CardGame.MainWindow"  ��5      �� 5      .+�5      �� -   5        	 ��Name$	 card_container_bottom��5      
 �� SelectionMode$
 Multiple=�65   $��479,406,414,5q�6N   $
��Auto��6e   $	��130��6r   $��Disabled=�6   $��Disabled=�6�   ��5      �� 5      ��5      �� 5      ��5       �� 5!      .R�5#      ��  �� Orientation$ 
Horizontal=�6&   5$      5&      �� 5(      -   5         ��Name$ redraw_button��5(      $��ReDraw��6,   $��662,352,650,156q�6=   $��33��6V   $ 0.5,0.5&�6~   $y�Hidden=�6�   �� 5)      -   5         ��Name$ Canvas��5)      $ 
1.78,-0.06&�6%   $��393,150,414,168q�6H   .+�5*      �� -   5         ��Name$ 
back_image��5*      $
��Left=�6,   $	��112��6G   $	��Top=�6T   $��78��6l    �� Left$	 289��6w   
 �� Top$ 69��6�   $��card back black.png��6�   $ 1.268,0.673&�6�   �� 5+      -   5        $ back_image_copy��5+      $
��Left=�61   $	��112��6L   $	��Top=�6Y   $��87��6q   $	 289��6|   $ 69��6�   $��card back black.png��6�   $ 1.268,0.673&�6�   5,      �� 5-      -   5        $ start_button��5-      $��Start��6+   $��662,352,650,156q�6;   $��33��6T   $ 0.5,0.5&�6{   �� 5.      -   5        $	 card_container_left��5.      $
 Multiple=�63   $��0,0,962,411q�6L   $
��Auto��6b   $	��130��6o   $��Disabled=�6|   $��Disabled=�6�   ��5/      �� 50      ��52      �� 53      ��55      �� 56      .R�58      �� $ 
Horizontal=�6&   59      5;      �� 5<      -	   5        $	 card_container_right��5<      $
 Multiple=�64   $��942,0,0,411q�6M   $
��Auto��6b   $	��130��6o   $��Disabled=�6|   $��Disabled=�6�   ��5=      �� 5>      ��5@      �� 5A      ��5C      �� 5D      .R�5F      �� $ 
Horizontal=�6&   5G      5I      �� 5J      -
   5        $	 card_container_top��5J      $
 Multiple=�62   $��440,-206,453,617q�6K   $
��Auto��6e   $	��130��6r   $��Disabled=�6   $��Disabled=�6�   ��5K      �� 5L      ��5N      �� 5O      ��5Q      �� 5R      .R�5T      �� $ 
Horizontal=�6&   5U      5W      5Z      �� 5[   
   $
��Left=�6   $	��115��6+   $	��Top=�68   $	��115��6P   $��
43,369,0,0q�6\   $��user_icon.jpg��6p   $ 0.557,1.148&�6�   �� 5\   
   $
��Left=�6   $	��115��6+   $	��Top=�68   $	��115��6P   $��
839,25,0,0q�6\   $��user_icon.jpg��6p   �� 5]   
   $
��Left=�6   $	��115��6+   $	��Top=�68   $	��115��6P   $��1654,369,0,0q�6\   $��user_icon.jpg��6r   �� 5^   
   $
��Left=�6   $	��115��6+   $	��Top=�68   $	��115��6P   $��
43,846,0,0q�6\   $��user_icon.jpg��6p   5a      5b      