   M S B A M L   `   `   `  ����I  ETimeManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:TimeManagementTimeManagement  5   	       TimeManagement.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   .localclr-namespace:TimeManagement     5   	   -   5          � Title$  一个番茄��5   	   $��542.989��6   $��568.034��6'    � ShowActivated .   � 
ResizeMode$ NoResize=�6M   .��5      � $��0,0,0,0q�6   .+�5   
   � -   5        $��timeProgress��5      $
��Left=�6*   $��81��6E   $��	10,10,0,0q�6S    � Value$ 50Q�6f   $	��Top=�6q   $	��532��6�   ���	#7FEFF1E5��5	      �� 5
       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#4C6CF770��6#    � Offset$ 0Q�65   � 5      $ 	#B215FF00��6#   $ 1Q�65   5      5      �� 5   
   -   5        $��	txtRemain��5      $��25:00��6!   $��0��62   $��35(�6@   ���	#FF0A6CF9$��60��6e   $	��144��6q    J� RenderTransformOrigin$ 0.469,-0.555&�6}   $��207,21,211,434q�6�   ��6�   Z� 6�   �� 5   
   -   5        $��btnPomodoroFocus��5      $	��紧��6)   |�.  $
��Left=�6H   $��207,123,0,0q�6c   $	��Top=�6x   $��30(�6�   $��65��6�   $	��107��6�   $ 
1.921,0.58&�6�   ���	#7FEFF1E56�   �� 5   
   -   5        $��btnPomodoroRelax��5      |�.  $	��松��6[   $
��Left=�6g   $��
10,123,0,0q�6�   $	��Top=�6�   $��30(�6�   $��65��6�   $	��107��6�   $ 2.724,0.534&�6�   ���	#7FEFF1E56�   �� 5   
   $
��Left=�6   $	��267��60   $��
10,222,0,0q�6=   $	��Top=�6Q   $	��532��6i   .@�5      �� $��番茄日志��6   .��5      ]� ���	#FFE5E5E5.+�5      �� -   5        $��txtMindTracer��5   "   	 �� 
AcceptsTab	 . "
 �� VerticalScrollBarVisibility$

 Auto=�6I   5      5      5      5       � 	Resources 5         SaveLogs �� Text��%,   &	        �� 5    
   $ SaveLogs��6+   5!       J� InputBindings 5"      �� 5$   
    �� Gesture$ Ctrl+S��6    �� Command# [  6&    J� CommandBindings 5'      )  #System.Windows.Input.CommandBinding  5(   
   -   5           Command# [  5(      5*      5,      