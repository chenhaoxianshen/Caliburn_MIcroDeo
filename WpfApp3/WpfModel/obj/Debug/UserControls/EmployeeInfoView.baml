   M S B A M L   `   `   `  ����C  ?WpfModel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:WpfModel.UserControlsWpfModel.UserControls  5      ,    &WpfModel.UserControls.EmployeeInfoView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:WpfModel.UserControls     5      ^ ZCaliburn.Micro.Platform, Version=3.2.0.0, Culture=neutral, PublicKeyToken=8e5891231f2ed21f(calhttp://www.caliburnproject.org  5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      $��446.866��5
      $��617.015��6     Caliburn.Micro.Bind    Model  5	      �� .��5      �  � RowDefinitions 5   
   �� 5      $	��51* �6   �� 5      $	��42* �6   �� 5      $
��283* �6   �� 5      $	��71* �6   .+�5   
   �� $
��Wrap=�6    �� TextAlignment$ Center=�5      $��List of All Employees��6,   $
��Bold"�6I   $��30(�6[   �� 5   
   -   5         ��Name$ btnloadallemployees��5      $��List All Employees��6.   $��3��5      $��30(�6   $
��Bold"�5      ��5      �� *ReadAllCommand+&   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgemp��5      $��2��6"      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5      $��	0,10,0,28q�6#    J� RenderTransformOrigin$ 0.5,0.5&�66      
IsReadOnly .   Caliburn.Micro.Message   Attach$A ;[Event SelectionChanged] = [Action SendEmployeeInfo($this)]��5   '   ��5   /   �� *	Employees+	 �� SelectedItem	 5      �� 
 �� Path$
 SelectedTab� �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�5      �� 5   
   $
��Left=�6   $��10,7,0,0q�6/   $��1��6A   $
��Wrap=�5      $��EmpName to Search:��6(   $	��Top=�6B   $	��231��5      �� 5    
   $
��Left=�6   $��30��6-   $��	262,7,0,0q�69   $��1��5!       �� TextWrapping$
 Wrap=�6   $	��Top=�5"      $	��310��6*   $5 /[Event TextChanged] = [Action SearchEmployee()]��66   ��5!   4   �� *	EmpName+$ PropertyChanged=�.��5"   |   5#      5$      5%      