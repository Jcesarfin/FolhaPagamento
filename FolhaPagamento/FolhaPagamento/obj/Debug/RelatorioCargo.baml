   M S B A M L   `   `   `  ����I  EFolhaPagamento, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:FolhaPagamentoFolhaPagamento  5   	   #    FolhaPagamento.RelatorioCargo   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:FolhaPagamento     5   	   -   5          �Name$  telaRelatCargos��5   	    � Title$ RELATÓRIOS CARGOS��5   	   ���	#FFF17272 � WindowStartupLocation$ CenterScreen=�6:   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��3* �6   �� 5      $��3* �6   .+�5   
   �� -   5         ��Name$ btnGerarRelatCargo��5      $��LISTAR��6-   $
��Left=�6>   $��	10,10,0,0q�6Y   $	��Top=�6l   $��67��6�   $��9(�6�   $��25��6�   �� 5   
   -   5        $ btbVoltarRelat��5      $��VOLTAR��6)   $
��Left=�6:   $��	145,8,0,0q�6U   $	��Top=�6h   $��66��6�   $��9(�6�   $��27��6�   �� 5   
   -   5         ��Name$ label��5      $
��Left=�6   $��	77,10,0,0q�6:   $��1��6M   $	��Top=�6Z   �� 5   
   -   5         ��Name$ lvCargos��5      $
��Left=�6%   $	��259��6@   $��	10,66,0,0q�6M   $	��Top=�6`   $	��305��6x    �� View 5      �� 5      .P�5      �� $��
NOME CARGO��6%    �� Width$	 150��69   	 �� DisplayMemberBinding	 6E   �� *	NomeCargo+�� 5      $��
VALOR HORA��6%   $	 150��69   	 6E   �� *	ValorHora+5      ��5      �� 5      .R�5      � .+�5      �� 
���   ���63   �� *	NomeCargo+�� 5      
���   ���63   �� *	ValorHora+5       5!      5%      5'      5(      