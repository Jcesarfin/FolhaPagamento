   M S B A M L   `   `   `  ����I  EFolhaPagamento, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:FolhaPagamentoFolhaPagamento  5   	   #    FolhaPagamento.RelatorioDepto   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:FolhaPagamento     5   	   -   5          �Name$  telaRelatDepto��5   	    � Title$ RELATÓRIO DEPARTAMENTOS��5   	   ���	#FFF17272 � WindowStartupLocation$ CenterScreen=�6@   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��3* �6   �� 5      $��3* �6   .+�5   
   �� -   5         ��Name$ label��5      $��Label��6   $
��Left=�6/   $��	40,25,0,0q�6J   $	��Top=�6]   $��13��6u   $��38��6�   �� 5   
   -   5         ��Name$ btnVoltarRelatGeral��5      $��VOLTAR��6.   $
��Left=�6?   $��69,7,0,0q�6Z   $	��Top=�6l   $��61��6�   $��9(�6�   $��16��6�   6�   �� 5   
   -   5        $ btbRelatGerar��5      $��LISTAR��6(   $
��Left=�69   $��10,7,0,0q�6T   $	��Top=�6f   $��54��6~   $��9(�6�   $��16��6�   6�   �� 5   
   -   5         ��Name$ lvDepto��5      $
��Left=�6$   $	��336��6?   $��	10,49,0,0q�6L   $	��Top=�6_   $	��307��6w    �� View 5      �� 5      .P�5      �� $��DEPARTAMENTO��6%    �� Width$	 150��6;   	 �� DisplayMemberBinding	 6G   �� *NomeDepartamento+�� 5      $��LOCAL��6%   $	 150��64   	 6@   �� *LocalDepartamento+5      ��5      �� 5      .R�5      � .+�5      �� 
���   ���63   �� *NomeDepartamento+�� 5       
���   ���63   �� *LocalDepartamento+5!      5"      5$      5%      5&      