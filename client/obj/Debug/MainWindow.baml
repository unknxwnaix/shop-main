   M S B A M L   `   `   `  ����A  =client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:clientclient  5   	       client.MainWindow   5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5
   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:client     5   	   -   5           MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5	   	    � Title$ 
MainWindow��5   	   $	��450��6   $	��800��6)   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      $��5* �6   �� 5      .+�5   
   �� $��Чек��6   $��Center=�6   $��Center=�6<   $��28(�6W   $��2��6e   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ productGrid��5      $��Stretch=�6(   $��Stretch=�6F   ���#e3e3e3$��1��6w   $��2��6�      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6P   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 67   �� *Name+6P     5       $ Штрих-код��6%   $	 * 6T   
 68   �� *	Barcode+6T     5!      $ Цена��6%   $
	 0.6* 6m   
 63   �� *Retail_Price+ �� StringFormat$ 
{0:F2} ₽��6m     5"      $ Вес��6%   $
	 0.5* 6M   
 62   �� *Weight+6M     5#      $ Количество��6%   $
	 0.7* 6V   
 69   �� *
Quantity+6V   5%      �� 5&   
   -   5         ��Name$ resultTb��5&      $��
Итог: ��6&   $
��Left=�64   $��Center=�6O   $��2��6j   $��24(�6w   $��15q�6�   5'      5(      