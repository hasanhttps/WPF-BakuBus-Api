   M S B A M L   `   `   `  ����d  `Microsoft.Maps.MapControl.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPFMicrosoft.Maps.MapControl.WPF  5   	   N JWPF Bind Map Lesson, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:WPF_Bind_Map_Lesson.ViewsWPF_Bind_Map_Lesson.Views 5   	   (   "WPF_Bind_Map_Lesson.Views.MainView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   bmapRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPF     5   	   9local'clr-namespace:WPF_Bind_Map_Lesson.Views     5   	   -   5          � Title$  Baku Bus��5
   	   $	��550��6   $
��1000��6'   $	��400��64   $	��750��6D   $	��800��6S   $
��1400��6c   .��5      � .+�5   
   '   !Microsoft.Maps.MapControl.WPF.Map  -   5        $	��Map��5      +   %Microsoft.Maps.MapControl.WPF.MapCore   Center<   6Microsoft.Maps.MapControl.WPF.Design.LocationConverter$ 40.389, 49.848 6      	ZoomLevel$
 12.8Q�65      CredentialsProviderT   NMicrosoft.Maps.MapControl.WPF.Design.ApplicationIdCredentialsProviderConverter$r lOW3MAkbZOrmKAQCg7Q5W~b7d6_7jSTuTPFLK3ExvIVQ~Ar5WbcR9NFJ6dlHZGPHBjIqalmx4WvDfazpHZ3i3utECNRza6Lf-efqpkWle5wi- 6F   �� 5   
   
������� J� Opacity$
 0.85Q�6$   $
��Left=�63   ._�5      �� $	��Top=�6   .+�5      ��    BakuBusImage#��[  6   $	��200��6?   $	��220��6L   �� 5      -   5         ��Name$ SearchFilterBus��5      $	��190��64   $��20��6@   $��5 0 5 0q�6L   �� 5      $��Search��6   
������ $��80��6f   $��20��6q   $��Center=�6}   
���  ��
�������$��5 5 5 5q�6�   ��6*   �� *SearchCommand+ � 	Resources 5       �� 
TargetType �� Property	 �� Value��%^   '��       �� 5      " ��6    .�5      ��  �@��CornerRadius$	 2��6=   5      5      5      �� 5      $��Netice��6   $��27(�6*   
�������$��15q�6J   �� 5      $��
Mesafe: km��6   $��12(�6.   
�������$
��15 0q�6N   �� 5      
 �� Orientation$
 
Horizontal=�6   .+�5      �� $��Avtobuslar: ��6    $��12(�64   
�������$��15 0 0 0q�6T   �� 5      $��12(�6:   
���������6    �� *
BusCount+6H   5      5      5      5       5!      