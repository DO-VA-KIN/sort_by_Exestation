   M S B A M L   `   `   `  ����M  ISystem, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089M3clr-namespace:System.ComponentModel;assembly=systemSystem.ComponentModel  5       WoW   WoW.MainWindow   5   	   :cm3clr-namespace:System.ComponentModel;assembly=system  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      -   5        $��278.8��5   <   $��434.933��6K     � 
ResizeMode$  CanMinimize=�6[    � Icon$ images/blackSky.jpg��6t   
������� � WindowStyle$ SingleBorderWindow=�6�    � 	Resources 5      ,   &System.ComponentModel.BackgroundWorker   BackgroundWorker1   WorkerReportsProgress!   WorkerSupportsCancellation��%=   &	          5   
   -   5         .  . 5      5      .��5      � $��
0,0,-0.2,0q�6   .+�5   
   �� -   5        $
��Left=�5      $��33��6+   $��
25,204,0,0q�67   $	��Top=�6K   $��48��6c   $��images/blackSky.jpg��6n    � ToolTip$ 	ClickHere��6�   $
��Fill=�6�    K� ZIndex$ 1��6�   �� 5   
   -   5         ��Name$ 
TextWayOut��5      $
��Left=�6&   $��21��6A   $��	98,10,0,0q�6M   	 �� TextWrapping$
	 Wrap=�6`   $	��Top=�6t   $	��302��6�   $��14(�6�   6�   �� 5   
   -   5        $ 	TextWayIn��5      $
��Left=�6%   $��21��6@   $��	98,36,0,0q�6L   $
	 Wrap=�6_   $	��Top=�6s   $	��302��6�   $��14(�6�   6�   �� 5   
   $!��Переместить из��6   $
��Left=�6)   $��0,8,0,0q�6D   $	��Top=�6U   �� 5   
   $��Переместить в��6   $
��Left=�6(   $��0,31,0,0q�6C   $	��Top=�6U   $��98��6m   �� 5   
   -   5        
 ��Name$
 ButtonWayOut��5      $	��...��6'   $
��Left=�65   $��
400,11,0,0q�6P   $	��Top=�6d   $��19��6|   6�   �� 5   
   -   5        $
 ButtonWayIn��5      $	��...��6&   $
��Left=�64   $��
400,37,0,0q�6O   $	��Top=�6c   $��19��6{   6�   �� 5   
   -   5        $
 ButtonStart��5      $��Пуск��6&   $
��Left=�65   $��174,204,0,0q�6P   $	��Top=�6e   $��85��6}   $��15(�6�   #��� ��6�   $��33��6�   6�   � 5   
   -	   5         �Name$ ProgressBar1��5      $
��Left=�6,   $��13��6G   $��292,224,0,0q�6S   $	��Top=�6h   $	��119��6�   �� 5   
   -
   5         ��Name$ checkBoxCopy��5   r   $4��.сортировать и копировать��6   $��19��66   $
��Left=�6B   $��114,130,0,0q�6]   $	��Top=�6�   $
��Auto��6�    d� 	IsChecked$ FalseY�6�   $��12(�6�    � ForceCursor .  z�5      �� 5       �� ScaleX$
 1.15Q�6!    �� ScaleY$
 1.15Q�6/   5      �� 5   
   -   5        $ checkBoxMove��5   s   $6��0сортировать и переместить��6   $��19��67   $
��Left=�6C   $��114,103,0,0q�6^   $	��Top=�6�   $
��Auto��6�   $
 TrueY�6�   $��12(�6�    .  z�5      �� 5      $
 1.15Q�6!   $
 1.15Q�6/   5!      �� 5"   
   -   5         ��Name$ labelProgress��5"      $��12465��6'   $��303,204,0,0q�67   $	��Top=�6L   $	��108��6d   $��21��6p   $��10(�6|   $
��Left=�6�   5#      5%      