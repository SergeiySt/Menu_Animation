   M S B A M L   `   `   `  ����I  EAnimation_menu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Animation_menu.PagesAnimation_menu.Pages  5      !    Animation_menu.Pages.UCMenu   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:Animation_menu.Pages     5      .��5	      �   � 	Resources  5
   
      LabelAnimation W� From	 W� To g� Duration �� 
TargetName �� TargetProperty  ImageAnimation��%{  &	        &	 �    �� 5      .��5      W� $	 100X�6"   $	 -30X�6-   $ 0:0:5D�66   $ label1��6G   $8 2(UIElement.RenderTransform).(TranslateTransform.Y)�6f   W� 5      $	 100X�6"   $	 -90X�6-   $ 0:0:8D�66   $ label2��6G   $8 2(UIElement.RenderTransform).(TranslateTransform.Y)�6f   W� 5      $ 0X�6"   $ 1X�6+   $ 0:0:5D�62   $ label1��6C   $ Opacity�6b   W� 5      $ 0X�6"   $ 1X�6+   $ 0:0:5D�62   $ label2��6C   $ Opacity�6b   5      �� 5      .��5      W� $ 0X�6"   $ 1X�6+   $ 0:0:3D�62   $ image��6C   $ Opacity�6a   5      5       � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ label1��5      $��1��6    $��Вітаємо Вас!��60   $
��Left=�6H    J� Opacity$ 0Q�6d   $��306,295,0,110q�6p   ���	#FF513DE0$
��Bold"�6�   $��26(�6�   z�5      T� 5      	 T� Y$		 100Q�6%   
 � Triggers
 5      :� 5       :� RoutedEvent$ Loaded��6   .[�5      �� #��[  6&   5       5"      �� 5#   
   -   5        $ label2��5#      $��1��6    $>��8У програмі анімаційних пригод!��60   $
��Left=�6Y   $ 0Q�6t   $��189,405,0,0q�6�   ���	#FF513DE0$
��Bold"�6�   $��26(�6�   z�5$      T� 5%      $		 100Q�6%   
 5'      :� 5(      $ Loaded��6   .[�5)      �� #��[  6&   5*      5,      �� 5-   
   -   5         ��Name$ image��5-      $��1��6   $
��Left=�6/   $��272,85,0,191q�6J   $	��201��6`   $��/Picture/smail.png��6l   $ 0Q�6�   
 5.      :� 5/      $ Loaded��6   .[�50      �� #��[ 6&   51      53      54      55      