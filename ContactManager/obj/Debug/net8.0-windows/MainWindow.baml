   M S B A M L   `   `   `  ����  ContactManager    ContactManager.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Menadżer Kontaktów��5   	   $	��450��6$   $	��800��61   .��5      �� 
�������$��10q�6$   .+�5   
   ��  �� Orientation$ Vertical=�6    �� Left$ 10��6,   
 �� Top$ 10��6=   .+�5      �� -   5         ��Name$ inputFirstName��5      $	��200��6.   $��5q�6:   �� 5      -   5        $ inputLastName��5      $	��200��6-   $��5q�69   �� 5	      -   5        $ 
inputPhone��5	      $	��200��6*   $��5q�66   �� 5
      -   5        $ 
inputEmail��5
      $	��200��6*   $��5q�66   �� 5      -   5         ��Name$ favoriteCheckBox��5      $��5q�61   $��Ulubiony��6<   5      �� 5   
   $ Vertical=�6   $	 220��6,   $ 10��6>   .+�5      �� -   5         ��Name$ filterComboBox��5      $	��200��6/   $��5q�6;   .@�5      �� $��	Wszystkie��6   �� 5      $��Ulubione��6   5      �� 5      -   5        $	��100��5      $��5q�6"   $��Dodaj��6-   6=   �� 5      -   5        $	��100��5      $��5q�6"   $��Edytuj��6-   6>   �� 5      -	   5        $	��100��5      $��5q�6"   $��Usuń��6-   6<   5      �� 5   
   -
   5         ��Name$ contactListBox��5   '   
���<��$	��400��6?   $	��200��6K   $ 10��6X   $	 150��6i   $��5q�6z    �� DisplayMemberPath$ FullName��6�   5      5      