   M S B A M L   `   `   `  ����T  PNepovezan (Baze podatkov), Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Nepovezan__Baze_podatkov_Nepovezan__Baze_podatkov_  5   	   *    $Nepovezan__Baze_podatkov_.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Nepovezan__Baze_podatkov_     5   	   -   5          � Title$  
MainWindow��5   	   $	��600��6   $	��700��6)    � 	Resources 5	      *   $Nepovezan__Baze_podatkov_.adbDataset   
adbDataset  productViewSource �� Source �� Source��%X   &	        &	      7     5
   
   6   �� 5   
    69   �� *	Product+8   5      .��5      �  � DataContext# [ 6    � RowDefinitions 5   
   �� 5      �� 5      $��0* �6   .+�5   
   � -   5         �Name$ grid1��5      $
��Left=�6   $��	33,71,0,0q�69   $	��Top=�6L   $	��427��6d   $	��260��6q    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5       $
��Auto �6    �� 5!      $
��Auto �6    �� 5"      $
��Auto �6    �� 5#      $
��Auto �6    .+�5%      �� $��0��6   $��Product ID:��6$   $
��Left=�6:   $��3q�6U   $��0��6`   $��Center=�6m   �� 5&      -   5         ��Name$ productIDTextBox��5&      $��1��60   $
��Left=�6@   $	��NaN��6[   $��3q�6h   $��0��6s   $��Center=�6�   $	��120��6�   ��6�   �� *	ProductID+	 �� Mode$	 OneWay=�6�   �� 5'      $��0��6   $��Name:��6$   $
��Left=�64   $��3q�6O   $��1��6Z   $��Center=�6g   �� 5(      -   5        $ nameTextBox��5(      $��1��6+   $
��Left=�6;   $	��NaN��6V   $��3q�6c   $��1��6n   $��Center=�6�   $	��120��6�   ��6{   �� *Name+$	 TwoWay=�
 �� NotifyOnValidationError
 .  �� ValidatesOnExceptions . 6�   �� 5)      $��0��6   $��Product Number:��6$   $
��Left=�6>   $��3q�6Y   $��2��6d   $��Center=�6q   �� 5*      -   5        $ productNumberTextBox��5*      $��1��64   $
��Left=�6D   $	��NaN��6_   $��3q�6l   $��2��6w   $��Center=�6�   $	��120��6  ��6�   �� *ProductNumber+$	 TwoWay=�
 .  . 6  �� 5+      $��0��6   $��Color:��6$   $
��Left=�65   $��3q�6P   $��3��6[   $��Center=�6h   �� 5,      -   5        $ colorTextBox��5,      $��1��6,   $
��Left=�6<   $	��NaN��6W   $��3q�6d   $��3��6o   $��Center=�6�   $	��120��6�   ��6|   �� *Color+$	 TwoWay=�
 .  . 6�   �� 5-      $��0��6   $��Standard Cost:��6$   $
��Left=�6=   $��3q�6X   $��4��6c   $��Center=�6p   �� 5.      -   5        $ standardCostTextBox��5.      $��1��63   $
��Left=�6C   $	��NaN��6^   $��3q�6k   $��4��6v   $��Center=�6�   $	��120��6  ��6�   �� *StandardCost+$	 TwoWay=�
 .  . 6  �� 5/      $��0��6   $��List Price:��6$   $
��Left=�6:   $��3q�6U   $��5��6`   $��Center=�6m   �� 50      -   5        $ listPriceTextBox��50      $��1��60   $
��Left=�6@   $	��NaN��6[   $��3q�6h   $��5��6s   $��Center=�6�   $	��120��6�   ��6�   �� *	ListPrice+$	 TwoWay=�
 .  . 6�   �� 51      $��0��6   $��Size:��6$   $
��Left=�64   $��3q�6O   $��6��6Z   $��Center=�6g   �� 52      -	   5        $ sizeTextBox��52      $��1��6+   $
��Left=�6;   $	��NaN��6V   $��3q�6c   $��6��6n   $��Center=�6�   $	��120��6�   ��6{   �� *Size+$	 TwoWay=�
 .  . 6�   �� 53      $��0��6   $��Weight:��6$   $
��Left=�66   $��3q�6Q   $��7��6\   $��Center=�6i   �� 54      -
   5        $ weightTextBox��54      $��1��6-   $
��Left=�6=   $	��NaN��6X   $��3q�6e   $��7��6p   $��Center=�6�   $	��120��6�   ��6}   �� *Weight+$	 TwoWay=�
 .  . 6�   �� 55      $��0��6   $��Sell Start Date:��6$   $
��Left=�6?   $��3q�6Z   $��8��6e   $��Center=�6r   (  "System.Windows.Controls.DatePicker  56      -   5          Name$ sellStartDateDatePicker��56      $��1��6:   $
��Left=�6J   $��3q�6e   $��8��6p   $��Center=�6�      SelectedDate 6}   �� *SellStartDate+$	 TwoWay=�
 .  . 6�   �� 57      $��0��6   $��Sell End Date:��6$   $
��Left=�6=   $��3q�6X   $��9��6c   $��Center=�6p     58      -   5        $ sellEndDateDatePicker��58      $��1��68   $
��Left=�6H   $��3q�6c   $��9��6n   $��Center=�6�    6{   �� *SellEndDate+$	 TwoWay=�
 .  . 6�   �� 59      $��0��6   $��Discontinued Date:��6$   $
��Left=�6A   $��3q�6\   $��10��6g   $��Center=�6u     5:      -   5        $  discontinuedDateDatePicker��5:      $��1��6=   $
��Left=�6M   $��3q�6h   $��10��6s   $��Center=�6�    6�   �� *DiscontinuedDate+$	 TwoWay=�
 .  . 6�   �� 5;      $��0��6   $��Thumb Nail Photo:��6$   $
��Left=�6@   $��3q�6[   $��11��6f   $��Center=�6t   �� 5<      -   5         ��Name$ thumbNailPhotoImage��5<      $��1��61   $
��Left=�6A   $��3q�6\   $��11��6g   $��Center=�6�   ��6u   �� *ThumbNailPhoto+6�   5=      �� 5>   
    �� Orientation$ 
Horizontal=�6   $	��Top=�6.   $��58��6F   .+�5?      �� -   5        $��btnNazaj��5?       $��75��6   $��20, 20, 0,0q�60   $
��Left=�6E   $��<��6`   6�   �� 5@      -   5        $��	btnNaprej��5@       $��75��6   $��20, 20, 0, 0q�61   $
��Left=�6G   $��>��6b   6�   �� 5A      -   5        $��	btnShrani��5A       $��75��6   $��20, 20, 0, 0q�61   $
��Left=�6G   $��Shrani��6b   6�   5B      5C      5E      