   M S B A M L   `   `   `  ����I  ETraumaSoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:TraumaSoftware.ViewTraumaSoftware.View  5   	   ,    &TraumaSoftware.View.VerificationWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:TraumaSoftware.View     5   	     � Title$  VerificationWindow��5   	   $	��470��6$   $	��750��61    � WindowStyle$
 None=�6=    � WindowStartupLocation$ CenterScreen=�6P    � 
ResizeMode$ NoResize=�6u    � AllowsTransparency . 
������ .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��270 �6   �� 5      $	��480 �6   .+�5   
   �� -   5        $��JumpArea��5      $��0��6!    �� CornerRadius$ 	15 0 0 15��61   ��5      �� 5       �� 
StartPoint$
 0, 0&�6&    �� EndPoint$
 1, 1&�68   .��5      � 	 � Color$	 #F9232F��6#   
 � Offset$
 0Q�63   � 5      $	 #880022��6#   $
 1Q�63   5      ._�5      � .+�5      �� .+�5      �  � Points �    -1��� ;X����5      �� 5      $
 0, 0&�62   $
 1, 1&�6D   .��5   "   � $	 #42AFC3��6/   $
 0Q�6?   � 5   "   $	 #1515��6/   $
 1Q�6=   5      5      � 5      ' �    �� �� ���� ��
����5       �� 5!      $
 0, 0&�62   $
 1, 1&�6D   .��5"   "   � $	 #1515��6/   $
 0Q�6=   � 5#   "   $	 #42AFC3��6/   $
 1Q�6?   5$      5&      5'      �� 5(      $��	0 150 0 0q�6   $��Center=�60   $	��Top=�6M   .+�5)      �� $��Get Started��6    $��	0 0 20 20q�63    	  Title#��[  6F   �� 5*      $��0 20 0 0q�6    $��17(�62    J� Opacity$	 .85Q�6@   #��[  6N   " Please, send your user indicator�� 5+   ;   " And enter your user password too5,      5-      5.      5/      �� 50   
   -   5        $��ContentArea��50      $��1��6$   ���#0C0002._�51      �  � RowDefinitions 52      �� 53      $��36 �6$   �� 54      $	��100 �6$   �� 55      $	��280 �6$   �� 56      $��54 �6$   .+�58      � -   5        $��TaskBar��58      $��0��6&   
������ .+�59      ��  �� Orientation$ 
Horizontal=�6!   $��Right=�6:   $��Center=�6V   .+�5:      �� -   5        $��CloseButton��5:       $��0 0 5 0q�63   $��20��6D   $��/View/Resources/close.png��6P    � Cursor$
 Hand��6s   ��5;      �� 5<   "    �� 
TargetType" ��6(   .�5=   &   ��  �� Property �@J�Opacity �� Value$	 .75Q�6@    �� Triggers 5>   &   P� 5?   *    P� Property �@J�IsMouseOver P� Value . . �5@   .   ��  �@J�Opacity$ 1Q�6H   5A   +   5C   #   5E      5F      5G      � 5H      -   5        $��EmblemSpace��5H      $��1��6*   
������ .+�5I      �� $ ��/View/Resources/emblem.png��6   $	��275��6@   $��Center=�6L   $��Center=�6i    J� Effect 5J      3  -System.Windows.Media.Effects.DropShadowEffect  5K         
BlurRadius$	 2.5Q�6/      Color$ #FF0042��6@      ShadowDepth$ 5Q�6P      Opacity$ .5Q�6`   5M      5N      �� 5O      $��2��6   $��0 0 0 10q�6*   $ Vertical=�6<   $��Center=�6S   $��Bottom=�6p   .+�5P      �� $��0 0 0 5q�6!   $ Vertical=�62   .+�5Q      �� $ Vertical=�6%   $��Center=�6<   .+�5R      �� $��	INDICATOR��6(     	BorderTag#��[ 69   �� 5S      -   5        $��IndicatorBorder��5S   %   $	��200��6<     	BorderBox#��[ 6H   ._�5T   "   � .+�5U   &   �� -   5        $��IndicatorWatermark��5U   0   $��	Assistant��6J   $	��200��6[     TextWatermark#��[ 6�   �� 5V   &   -   5        $��IndicatorBox��5V   .    �� 	MaxLength$ 20��6B     TextBox#��[ 6x   5W   #   5X      5Y      �� 5Z      $��0 10 0 0q�6%   $ Vertical=�67   $��Center=�6N   .+�5[      �� $��PASSWORD��6(   #��[ 68   �� 5\      -	   5        $��PasswordBorder��5\   %   $	��200��6;   #��[ 6G   ._�5]   "   � .+�5^   &   �� -
   5        $��PasswordWatermark��5^   0   $��User Password��6I   $	��200��6^   #��[ 6�   G� 5_   &   -   5        $��PasswordBox��5_   2    G� 	MaxLength$ 20��6E     PasswordBox#��[ 6�   5`   #   5a      5b      5c      �� 5d      -   5        $��TimeoutWatermark��5d       $�� ��68   $��Right=�6@   ���#FF0042$ 1Q�6q   #��[ 6}   �� 5e      -   5        $��EnterButton��5e      $��ENTER��60   $��0 30 0 0q�6@     EnterButton#��[ 6l    5f        5g      $ 25Q�6/   $ #FF0042��6?   $ 0Q�6O   $ .5Q�6_   5i      5j      5k      5l      5m      5n      