   M S B A M L   `   `   `  ����I  EFolhaPagamento, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:FolhaPagamentoFolhaPagamento  5   	   #    FolhaPagamento.RelatorioFolha   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:FolhaPagamento     5   	   -   5          �Name$  TelaRelatFolha��5   	    � Title$  RELATÓRIO FOLHA PAGAMENTO��5   	   ���	#FFF17272 � WindowStartupLocation$ CenterScreen=�6B   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��3* �6   .+�5   
   �� -   5         ��Name$ btnRelatFolhaListar��5      $��LISTAR��6.   $
��Left=�6?   $��	21,24,0,0q�6Z   $	��Top=�6m   $��75��6�   6�   �� 5   
   -   5        $ btnRelatFolhaVoltar��5      $��VOLTAR��6.   $
��Left=�6?   $��
156,24,0,0q�6Z   $	��Top=�6n   $��75��6�   6�   �� 5   
   -   5         ��Name$ lvFolha��5      $
��Left=�6$   $	��198��6?   $��10,60,-174,0q�6L   $	��Top=�6b   $	��924��6z   $��2��6�    �� View 5      �� 5      .P�5      �� $
��NOME��6%    �� Width$	 100��63    �� DisplayMemberBinding 6?   �� 	 �� Path$	 _Empregado.Nome��� 5      $	��CPF��6%   $ 80��62    6=   �� $	 _Empregado.CPF��� 5      $��	HR NORMAL��6%   $ 80��68    6C   �� *QtdeHoraNormal+�� 5      $��
VLR NORMAL��6%   $ 80��69    6D   �� *VlrHoraNormal+�� 5      $��HR EXTRA��6%   $ 80��67    6B   �� *QtdeHoraExtra+�� 5      $��	VLR EXTRA��6%   $ 80��68    6C   �� *VlrHoraExtra+�� 5      $��	VLR BRUTO��6%   $ 80��68    6C   �� *SalarioBruto+�� 5      $
��INSS��6%   $ 80��63    6>   �� *	VlrInss+�� 5      $��IR��6%   $ 80��61    6<   �� *VlrIR+�� 5      $��VLR LIQ��6%   $ 80��66    6A   �� *SalarioLiquido+�� 5      $
��MÊS��6%   $ 50��62    6=   �� *Mes+�� 5      $	��ANO��6%   $ 50��62    6=   �� *Ano+5       ��5'      �� 5(      .R�5)      � .+�5*      �� 
���   ���63   �� *Nome+�� 5+      
���   ���63   �� *CPF+�� 5,      
���   ���63   �� *QtdeHoraNormal+�� 5-      
���   ���63   �� *QtdeHoraExtra+�� 5.      
���   ���63   �� *VlrHoraNormal+�� 5/      
���   ���63   �� *VlrHoraExtra+�� 50      
���   ���63   �� *SalarioBruto+�� 51      
���   ���63   �� *	VlrInss+�� 52      
���   ���63   �� *VlrIR+�� 53      
���   ���63   �� *SalarioLiquido+�� 54      
���   ���63   �� *Mes+�� 55      
���   ���63   �� *Ano+57      58      5:      5<      5=      