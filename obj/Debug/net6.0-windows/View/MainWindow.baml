   M S B A M L   `   `   `  ����U  QDog_Training_App_Prototype, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Dog_Training_App_PrototypeDog_Training_App_Prototype  5   	   +    %Dog_Training_App_Prototype.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:Dog_Training_App_Prototype     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ShowGridLines$ False��6   $��800,450,0,195q�6!   .+�5
   
   �� -   5        $��
Daily Page��5
      $
��Left=�6&   $��20��6A   $��-748,-65,0,0q�6M   $	��Top=�6c   $��96��6{   6�   �� 5   
   -   5        $��
Statistics��5      $
��Left=�6&   $��20��6A   $��-552,-65,0,0q�6M   $	��Top=�6c   $��96��6{   6�   �� 5   
   -   5        $��
Add Skills��5      $
��Left=�6&   $��20��6A   $��-343,-65,0,0q�6M   $	��Top=�6c   $��96��6{   6�   �� 5   
   -   5        $��Training Path��5      $
��Left=�6)   $��20��6D   $��-148,-65,0,0q�6P   $	��Top=�6f   $��96��6~   6�   �� 5   
   -   5         ��Name$ 	listView1��5      $	��168��6?   $��-484,-424,32,0q�6L   $	��Top=�6d   $	��452��6|   ��6&   ��  �� View 5      �� 5      -   5        	gridView1��.P�5      ��  �� Width$	 100��6%   $
��User��61    �� DisplayMemberBinding 5      ��  �� Path$ Username��� 5      $	 100��6%   $
��Pass��61    5      �� $ Password��� 5      $ 80��6%   $	��Sit��60    5      �� $ sit.skillSelected��� 5      $ 80��6%   $��Lay Down��60    5      �� $ layDown.skillSelected��� 5      $ 80��6%   $
��Come��60    5      �� $ come.skillSelected�5      5      �� 5   
   -   5        $
��Left=�5      $��18��6-   $��-759,-424,0,0q�69    �� TextWrapping$
 Wrap=�6P   $��
Username: ��6d   $	��Top=�6v   $��73��6�   6�   �� 5    
   $
��Left=�6   $��18��6-   $��-759,-367,0,0q�69   $
 Wrap=�6P   $��
Password: ��6d   $	��Top=�6v   $��73��6�   �� 5"   
   -   5         ��Name$ username_input��5"      $
��Left=�6*   $��18��6E   $��-681,-424,0,0q�6Q   $
 Wrap=�6h   $
��User��6|   $	��Top=�6�   $	��132��6�   �� 5#   
   -	   5        $ password_input��5#      $
��Left=�6*   $��18��6E   $��-681,-367,0,0q�6Q   $	��Top=�6h   $	��132��6�   �� 5$   
   -
   5        $��Create User��5$      $
��Left=�6'   $��29��6B   $��-759,-318,0,0q�6N   $	��Top=�6e   $��87��6}   6�   �� 5%   
   -   5        $��Log In��5%      $
��Left=�6"   $��29��6=   $��-636,-318,0,0q�6I   $	��Top=�6`   $��87��6x   6�   5&      5'      