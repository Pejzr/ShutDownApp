   M S B A M L   `   `   `  ����F  BShutDownApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ShutDownAppShutDownApp  5   	       ShutDownApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:ShutDownApp     5   	     � Title$  Vypnutí počítače��5   	   $	��424��6"   $	��600��6/   ��5	      �� 5
   
    �� Color$ 	#FF1999DC��6   .��5      � -   5         �Name$ gridContainer��5      $	��500��6"   $	��568��6.   $��	50,0,50,0q�6;    � RowDefinitions 5   
   �� 5      $	��81* �6   �� 5      $
��203* �6   .+�5   
   �� -   5        $��BtnHour��5      $��Vypnout za hodinu��6    $
��Left=�6<   $	��Top=�6W   $��88��6o   $	��178��6{   $��
322,25,0,0q�6�   �� 5   
   -   5        $��	Btn2Hours��5      $��Vypnout za 2 hodiny��6"   $
��Left=�6@   $	��Top=�6[   $��89��6s   $	��178��6   $��322,122,0,0q�6�   $��1��6�   �� 5   
   -   5        $��BtnHalfHour��5      $��Vypnout za půl hodiny��6$   $
��Left=�6D   $	��Top=�6_   $��90��6w   $	��178��6�   $��322,152,0,0q�6�   $��2��6�   �� 5   
   -   5        $��datelbl��5      $��18(�6$   $�� ��62    �� TextAlignment$ Center=�6:   $
��Wrap=�6Q   
�������$��39,128,283,237q�6x   $��1��6�   �� 5   
   -   5        $��BtnShutDown��5      $��Zastavit Vypnutí��6$   $
��Left=�6?   $��24��6Z   $��
39,187,0,0q�6f   $	��Top=�6z   $	��178��6�   ���	#FFD4FA2A$��1��6�   �� 5   
   -   5        $��dobaVypnuti��5   -   $
��Left=�6   $��
39,63,0,54q�6@   $��10q�6T   $��18(�6a   $��00:00��6o    �� TextWrapping$
 Wrap=�6|    �� TextAlignment$ Center=�6�   $	��178��6�   
�������6�   �� 5   
   -   5        $��spustOdpocet��5      $��Start��6%   $
��Left=�65   $��	84,12,0,0q�6P   $	��Top=�6c   $��28��6{   $��88��6�   $��1��6�   �� 5   
   $
��Left=�6   $��
90,113,0,0q�6/   $��(HH:MM)��6C   $
��Wrap=�6R   $	��Top=�6f   
���  ��$��18(�6�   $��SemiBold"�6�   $��Normal$�6�   $��Normal&�6�   �� 5   
   $
��Left=�6   $��	39,36,0,0q�6/   $��Zadejte čas vypnutí:��6B   $
��Wrap=�6^   $	��Top=�6r   $	��145��6�   $��22��6�   $��15(�6�   $
��Bold"�6�   5      5      