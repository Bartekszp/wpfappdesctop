   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��300��6   $	��800��6)   .��5	      ��  �� Orientation$ 
Horizontal=�6   ���#5F9EA0.+�5
   
   �� $��Center=�6   $	��400��62   $��Center=�6>   .+�5      �� $ 
Horizontal=�6   $��0,0,0,20q�62   $	��200��6D   .+�5      �� $��Numer��6   $��0,0,20,0q�6(   $��Center=�6:   $��Center=�6W   �� 5      -   5         ��Name$ txtBoxNumer��5       �� TextWrapping$
 Wrap=�6/   $	��120��6C   
�������6b   5      �� 5      $��Center=�6   $��0,0,0,20q�66   $	��200��6H   $ 
Horizontal=�6T   .+�5      �� $
��Imie��6   $��0,0,20,0q�6'   $
��Left=�69   �� 5      -   5        $ 
txtBoxImie��5      $
 Wrap=�6.   $	��120��6B   $��Right=�6N   
�������6j   5      �� 5      $ 
Horizontal=�6   $��Center=�62   $��0,0,0,20q�6O   $	��200��6a   .+�5      �� $��Nazwisko��6   $��0,0,20,0q�6+   $
��Left=�6=   �� 5      -   5        $ txtBoxNazwisko��5      $
 Wrap=�62   $	��120��6F   $��Right=�6R   
�������6n   5      �� 5      $	��100��6   $��
Kolor oczu��6$   $��Center=�68   $	��300��6U   .��5      �� .+�5      	� -   5         	�Name$ 
RadButZiel��5   "   $��Zielone��66    d� 	IsChecked$
 TrueY�6H   	� 5      -   5        $ 
RadButNieb��5   "   $��
Niebieskie��66   $
 TrueY�6K   	� 5      -   5        $ 
RadButPiwn��5   "   $��Piwne��66   5      5      5      �� 5    
   $	��400��6   .+�5!      �� $ 
Horizontal=�6   $��Center=�62   $��0,20,0,0q�6O   .+�5"      �� -   5         ��Name$ imgPer��5"      $	��180��6(   $	��130��65   $��0,0,20,0q�6A   $��/000-zdjecie.jpg��6S   �� 5#      -   5        $ ImgPal��5#      $	��180��6(   $	��100��65   $��/000-odcisk.jpg��6A   $��20,0,0,0q�6Z   5$      �� 5%      -	   5         ��Name$ butOk��5%      $��ok��6$   $��Center=�61   $��0,30,0,0q�6L   
�������$	��200��6�   $��40��6�   5'      5(      5)      