   M S B A M L   `   `   `  ����D  @ExamBilet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ExamBilet	ExamBilet  5   	       ExamBilet.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ExamBilet     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � -   5         �Name$ 
layoutGrid��5	       � ColumnDefinitions 5
   
   �� 5      $
��200* �6   �� 5      $
��200* �6    � RowDefinitions 5   
   �� 5      $
��980* �6   �� 5      $
��150* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ table��5         
IsReadOnly .    AutoGenerateColumns . $��0��6O   $��0��6_   $��2��6l   ���#FFFFFF   
OrderFurnt#���   6�   �� 5   
   -   5        $��1��5      $��1��6   $��1��6.   $��17(�6Z   ���#FFFFFF.��6}   '%Невыполненые заказы6�   �� 5   
   -   5        $��1��5      $��0��6   $��1��6.   $��17(�6_   ���#FFFFFF.��6�   :8Сумма заявок по плановым датам6�   5      5      