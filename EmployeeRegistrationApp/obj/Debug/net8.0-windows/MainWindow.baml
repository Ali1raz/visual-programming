   M S B A M L   `   `   `  ����R  NEmployeeRegistrationApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:EmployeeRegistrationAppEmployeeRegistrationApp  5   	   (    "EmployeeRegistrationApp.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:EmployeeRegistrationApp     5   	     � Title$  Employee Registration��5   	   $	��450��6'   $	��800��64    � 	Resources 5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $ Styles.xaml?�6%   %    5      .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5    
   �� $
��Name��6   $��0��6   $��0��6,      
labelStyle#��[  6<   �� 5!   
   -   5         ��Name$ txtName��5!      $��0��6#   $��1��60     textBoxStyle#��[ 6@   �� 5#   
   $	��Age��6   $��1��6   $��0��6+   #��[  6;   �� 5$   
   -   5        $ txtAge��5$      $��1��6"   $��1��6/   #��[ 6?   �� 5&   
   $��Email��6   $��2��6    $��0��6-   #��[  6=   �� 5'   
   -   5        $ txtEmail��5'      $��2��6$   $��1��61   #��[ 6A   �� 5)   
   $��
Department��6   $��3��6%   $��0��62   #��[  6B   �� 5*   
   -   5         ��Name$ cbDepartment��5*      $��3��6)   $��1��66   #��[ 6F   $��30��6l   .@�5+      �� $��HR��6   �� 5,      $��IT��6   �� 5-      $��Finance��6   5.      �� 50   
   -   5         ��Name$ 	btnSubmit��50      $��4��6$   $��0��61   $��2��6A   $��Submit��6U     modernButtonStyle#��[ 51      6<   52      53      