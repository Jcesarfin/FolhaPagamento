   M S B A M L   `   `   `  ����I  EFolhaPagamento, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:FolhaPagamentoFolhaPagamento  5   	   (    "FolhaPagamento.RelatorioEmpregados   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:FolhaPagamento     5   	   -   5          �Name$  TelaRelatEmpregados��5   	    � Title$ RELATÓRIO EMPREGADOS��5   	   ���	#FFF17272 � WindowStartupLocation$ CenterScreen=�6=   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��3* �6    � RowDefinitions 5   
   �� 5      $	��20* �6   .+�5   
   �� -   5         ��Name$ btnRelatEmpVoltar��5      $��VOLTAR��6,   $
��Left=�6=   $��
188,25,0,0q�6X   $	��Top=�6l   $	��116��6�   $��20��6�   6�   �� 5   
   -   5        $ btnRelatEmpListar��5      $��LISTAR��6,   $
��Left=�6=   $��	30,25,0,0q�6X   $	��Top=�6k   $��75��6�   6�   �� 5   
   -   5         ��Name$ lvEmpregado��5      $
��Left=�6(   $	��250��6C   $��	10,66,0,0q�6P   $	��Top=�6c   $	��740��6{    J� RenderTransformOrigin$ 0.5,0.5&�6�    �� View 5      �� 5      .P�5      �� $
��NOME��6%   	 �� Width$		 100��63   
 �� DisplayMemberBinding
 6?   �� *Nome+�� 5      $��
IDENTIDADE��6%   $	 80��69   
 6D   �� *
Identidade+�� 5      $	��CPF��6%   $	 80��62   
 6=   �� *CPF+�� 5      $
��SEXO��6%   $	 80��63   
 6>   �� *Sexo+�� 5      $��	DATA NASC��6%   $	 80��68   
 6C   �� *DataNascimento+�� 5      $��DATA ADM��6%   $	 80��67   
 6B   �� *DataAdmissão+�� 5      $��DATA DEM��6%   $	 80��67   
 6B   �� *DataDemissão+�� 5      $��DEPTO��6%   $	 80��64   
 6?   �� *Departamento+�� 5       $��CARGO��6%   $	 80��64   
 6?   �� *Cargo+5!      ��5&      �� 5'      .R�5(      � .+�5)      �� 
���   ���63   �� *Nome+�� 5*      
���   ���63   �� *
Identidade+�� 5+      
���   ���63   �� *CPF+�� 5,      
���   ���63   �� *Sexo+�� 5-      
���   ���63   �� *DataNascimento+�� 5.      
���   ���63   �� *DataAdmissao+�� 5/      
���   ���63   �� *DataDemissao+�� 50      
���   ���63   �� *Departamento+�� 51      
���   ���63   �� *Cargo+53      54      56      5;      5<      