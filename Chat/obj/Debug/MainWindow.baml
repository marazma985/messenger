   M S B A M L   `   `   `  ����?  ;Chat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ChatChat  5   	       Chat.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Chat     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � -   5        $
��Grid��5	       � RowDefinitions 5
   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   .+�5   
   �� -   5        $��Start��5   "   $
��0,15q�6   $��0��6/   $��4��6<   $��1��6P   $��20(�6`   $��	dsfsdfsdf��6n    �� TextAlignment$ Center=�6   6�   �� 5   
   -   5        $��MessageInput��5       $
��0,15q�6   $��1��64   $��3��6A   $��1��6U   $��20(�6e   $��	Neverland��6s   �� 5   
   -   5        $��SendMessage��5   %   $��Отправить��6    �� 	IsDefault . $��1��6c   $��4��6p   $
��0,15q�6�   6�   � 5    
   $��2��6   $��1��6   $��4��6-   $��4��6>   .+�5!      �� .��5"      �� -   5        $��StackPanelMessage��5"       �� CanVerticallyScroll . 66   5#      5$      5&      5'      