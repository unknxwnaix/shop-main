   M S B A M L   `   `   `  ����A  =client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:clientclient  5          client.CashPage   5      _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:client     5      .��5      �   � ColumnDefinitions  5   
   �� 5      $
��0.5* �6   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      $
��0.3* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ productGrid��5         CanUserDeleteRows .  $��3��6B      DataGridTheme#��[  6V      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *Name+6P     5      $ Штрих-код��6%   $ * 6T    68   �� *	Barcode+6T     5      $ Цена��6%   $
 0.7* 6m    63   �� *Retail_Price+ �� StringFormat$ 
{0:F2} ₽��6m     5      $ Вес��6%   $
 0.6* 6M    62   �� *Weight+6M     5      $ Количество��6%   $ * 6V    69   �� *
Quantity+6V   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Delete��6)   $ * 69   	   CellTemplate	 5      �� 5      .R�5      �� -   5        $��X��5   %   $��Right=�6F   5       5"      5$      �� 5%   
   -   5        
 ��Name$
 resultTb��5%      $��
Итог: ��6&   $
��Left=�64   $��Center=�6O   $��2��6j   $��2��6w   $��20(�6�   $��20q�6�   �� 5&   
   $��1��6   $��1��6"   .+�5'      �� -   5         ��Name$ 	barcodeTb��5'       �� 	MaxLength$ 11��6)   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$% Введите штрихкод��68   $��Center=�6j   $	��Top=�6�   $��20(�6�   $��15q�6�   6�   �� 5(      -   5         ��Name$ addBtn��5(      $��Добавить��6%   $��Center=�68   $��Bottom=�6U   $��0,5,0,0q�6p   6�   5)      �� 5*      $��1��6   $��2��6*   .+�5+      �� -   5         ��Name$ payMethodCb��5+       �� 
IsEditable .  $��Stretch=�6G   $	��Top=�6e   $��15q�6}   $��20(�6�   .@�5,      �� $��Наличные��6'   �� 5-      $��
Карта��6'   5.      �� 5/      -   5        $ payBtn��5/      $��Оплата��6-   $��Center=�6>   $��Bottom=�6[   $��0,5,0,0q�6v   6�   50      51      52      