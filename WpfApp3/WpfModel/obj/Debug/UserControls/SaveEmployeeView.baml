   M S B A M L   `   `   `  ����C  ?WpfModel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:WpfModel.UserControlsWpfModel.UserControls  5      ,    &WpfModel.UserControls.SaveEmployeeView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:WpfModel.UserControls     5      ^ ZCaliburn.Micro.Platform, Version=3.2.0.0, Culture=neutral, PublicKeyToken=8e5891231f2ed21f(calhttp://www.caliburnproject.org  5      $��320.301��5      $	��450��60     Caliburn.Micro.Bind    Model  6<   �� .��5	      �  � RowDefinitions 5
   
   �� 5      $	��48* �6   �� 5      $	��50* �6   �� 5      $	��51* �6   �� 5      $	��45* �6   �� 5      $	��48* �6   �� 5      $	��78* �6    � ColumnDefinitions 5   
   �� 5      $
��106* �6   �� 5      $
��119* �6   .+�5   
   �� $
��Wrap=�6   $��EmpNo:��6(   �� 5   
   $��1��6   $
��Wrap=�6!   $��EmpName:��65   �� 5   
   $��2��6   $
��Wrap=�6!   $��Salary:��65   �� 5   
   $��3��6   $
��Wrap=�6!   $��	DeptName:��65   �� 5   
   $��4��6   $
��Wrap=�6!   $��Designation:��65   �� 5   
   $��1��6    �� TextWrapping$
 Wrap=�6"   ��66   �� *EmpInfo.EmpNo+ �� Mode$ TwoWay=��� 5   
   $��1��6   $��1��6"   $
 Wrap=�6/   ��6C   �� *EmpInfo.EmpName+$ TwoWay=��� 5   
   $��1��6   $��2��6"   $
 Wrap=�6/   ��6C   �� *EmpInfo.Salary+$ TwoWay=��� 5   
   $��1��6   $��3��6"   $
 Wrap=�6/   ��6C   �� *EmpInfo.DeptName+$ TwoWay=��� 5    
   $��1��6   $��4��6"   $
 Wrap=�6/   ��6C   �� *EmpInfo.Designation+$ TwoWay=��� 5!   
   $��Save Employee��6   $��20(�6)   $
��Bold"�5"      $��5��6#   $��2��5#        Caliburn.Micro.Message   Attach$ SaveEmployee()��6%   5%      5&      