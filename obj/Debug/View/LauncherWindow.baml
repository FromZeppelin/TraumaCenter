   M S B A M L   `   `   `  ����I  ETraumaSoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:TraumaSoftware.ViewTraumaSoftware.View  5   	   C&clr-namespace:TraumaSoftware.ViewModelTraumaSoftware.ViewModel  5   	   (    "TraumaSoftware.View.LauncherWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:TraumaSoftware.View     5   	   5vm&clr-namespace:TraumaSoftware.ViewModel     5   	     � Title$  LauncherWindow��5	   	   $	��600��6    $
��1200��6-    � WindowStyle$
 None=�6:    � WindowStartupLocation$ CenterScreen=�6M    � 
ResizeMode$ NoResize=�6r    � DataContext 5
      ,  &TraumaSoftware.ViewModel.MainViewModel  5   
   .��5      � ���#0c0002 � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6   .+�5   
   � -   5        $
��Menu��5      $��0��6   $
��Left=�6+   
������  � RowDefinitions 5      �� 5      $	��120 �6    �� 5      $��* �6    �� 5      $��70 �6    ��5      �� 5       �� 
TargetType" �6   .�5      ��  �� Property � ��	 �� Value$		 200��6.   5      .+�5      �� $��0��6   
 �� Orientation$
 
Horizontal=�6&   $��20 0 0 0q�6?   $
��Left=�5      $��Bottom=�64   .+�5      �� $��50��6   $��50��6$   $��0 0 10 0q�6/   $%��/View/Resources/mini-emblem.png��5       �� 5!      $#��/View/Fonts/#Blender Pro Book)�6   $��24(�6G   ���#D3D3D3Trauma�� 6q   
Software6�   5"      �� 5#      $��1��6   $
 Vertical=�6&   $��Center=�6=   .+�5$      �� -   5        $��DiscoverTab��5$         
MenuButton#��[  6,   $��DISCOVER��5%       � 	Resources 5&        
ButtonIcon��%=   &	       ��5'      /view/resources/compass.png��6V   5(      5)      �� 5*      -   5        $��TreatersTab��5*      #��[  6,   $��TREATERS��5+      ��6,   �� *OpenTreaterView+ 5,      ��%>   &	       ��5-       /view/resources/employee.png��6W   5.      5/      �� 50      -   5        $��CustomersTab��50      #��[  6-   $��	CUSTOMERS��51      ��6-   �� *OpenCustomerView+ 52      ��%<   &	       ��53      /view/resources/folder.png��6U   54      55      �� 56      -   5        $��TimeTableTab��56      #��[  6-   $��	TIMETABLE��57      ��6-   �� *OpenTreatmentView+ 58      ��%>   &	       ��59       /view/resources/calendar.png��6W   5:      5;      �� 5<      -   5        $��SpecificationTab��5<      #��[  61   $��SPECIALTIES��5=      ��6/   �� *OpenSpecificationView+ 5>      ��%:   &	       ��5?      /view/resources/star.png��6S   5@      5A      �� 5B      -   5        $��DepartmentTab��5B      #��[  6.   $��DEPARTMENTS��5C      ��6/   �� *OpenDepartmentView+ 5D      ��%@   &	       ��5E      "/view/resources/department.png��6Y   5F      5G      �� 5H      -   5        $��BenefitsTab��5H      #��[  6,   $��BENEFITS��5I      ��6,   �� *OpenBenefitView+ 5J      ��%:   &	       ��5K      /view/resources/coin.png��6S   5L      5M      �� 5N      -	   5        $��
PaymentTab��5N      #��[  6+   $��PAYMENT��5O      ��6+   �� *OpenPaymentView+ 5P      ��%A   &	       ��5Q      #/view/resources/credit-card.png��6Z   5R      5S      5T      �� 5U      $��2��6   $
��Left=�6&   $��Center=�6A   .+�5V      �� -
   5        $��CollapseButton��5V      $��30��6.   $��30��6:   $��	20 0 0 10q�6E    � Cursor$
 Hand��6X   $"��/view/resources/collapse.png��5W      ��5X      �� 5Y      " ��6     �� Triggers 5Z      P� 5[   "    P� Property �@J�IsMouseOver P� Value . . �5\   &   ��  �@J�Opacity$		 .65Q�6@   5]   #   5_      5a      5b      5c      � 5d   
   -   5        $��ContentArea��5d      $��1��6"    5e      �� 5f      $��30 �6    �� 5g      $��* �6    .+�5i      � -   5        $��TopBar��5i      $��0��6!   
������ .+�5j      �� $
 
Horizontal=�6   $��Right=�66   $��Center=�6R   .+�5k      �� -   5        $��CloseButton��5k      $��25��6/   $��/View/Resources/close.png��6;   $
 Hand��6^   ��5l      �� 5m      " ��6$   .�5n   "   ��  �@J�Opacity$		 .75Q�6<    5o   "   P� 5p   &    �@J�IsMouseOver . . �5q   *   ��  �@J�Opacity$	 1Q�6D   5r   '   5t      5v      5w      5x       � 5y      -   5        $��	Container��5y      $��1��6E     � NavigationUIVisibility$ Hidden=�6R   ��6%   �� *CurrentView+6R   5z      5{      5|      