   M S B A M L   `   `   `  ����I  EFolhaPagamento, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:FolhaPagamentoFolhaPagamento  5   	   $    FolhaPagamento.ManutencaoFolha   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:FolhaPagamento     5   	   -   5          �Name$  telaManutFolha��5   	    � Title$" MANUTENÇÃO FOLHA PAGAMENTO��5   	   ���	#FFF17272 � WindowStartupLocation$ CenterScreen=�6C   .��5	      � .+�5
   
   �� -   5         ��Name$ lblManutFolhaCpf��5
      $��INFORME O CPF:��6*   $
��Left=�6C   $��	10,10,0,0q�6^   $	��Top=�6q   �� 5   
   -   5         ��Name$ txtManutFolhaCpf��5      $
��Left=�6,   $��23��6G   $��
114,13,0,0q�6S    �� TextWrapping$
 Wrap=�6g   $	��Top=�6{   $	��148��6�   �� 5   
   -   5         ��Name$ btnConsFolhaCpf��5      $��	PESQUISAR��6*   $
��Left=�6>   $��
374,10,0,0q�6Y   $	��Top=�6m   $��75��6�   6�   �� 5   
   -   5        $ lblManutFolhaNome��5      $��NOME:��6+   $
��Left=�6;   $��	10,41,0,0q�6V   $	��Top=�6i   �� 5   
   -   5        $ lblManutMesFolha��5      $��MÊS:��6*   $
��Left=�69   $��
10,315,0,0q�6T   $	��Top=�6h   �� 5   
   -   5        $ txtManutMesFolha��5      $
��Left=�6,   $��23��6G   $��210,320,0,0q�6S   $
 Wrap=�6h   $	��Top=�6|   $��67��6�   �� 5   
   -   5        $ txtManutNomeFolha��5      $
��Left=�6-   $��23��6H   $��
114,44,0,0q�6T   $
 Wrap=�6h   $	��Top=�6|   $	��335��6�   �� 5   
   -	   5        $ lblManutSalBrFolha��5      $��VALOR BRUTO:��6,   $
��Left=�6C   $��
10,196,0,0q�6^   $	��Top=�6r   �� 5   
   -
   5        $ lblManutInssFolha��5      $��VALOR INSS:��6+   $
��Left=�6A   $��
10,227,0,0q�6\   $	��Top=�6p   �� 5   
   -   5        $ txtManutSalBrFolha��5      $
��Left=�6.   $��23��6I   $��157,199,0,0q�6U   $
 Wrap=�6j   $	��Top=�6~   $	��120��6�   �� 5   
   -   5        $ txtManutInssFolha��5      $
��Left=�6-   $��23��6H   $��157,230,0,0q�6T   $
 Wrap=�6i   $	��Top=�6}   $	��120��6�   �� 5   
   -   5        $ lblManutIrFolha��5      $��	VALOR IR:��6)   $
��Left=�6=   $��
10,258,0,0q�6X   $	��Top=�6l   �� 5   
   -   5        $ txtManutIrFolha��5      $
��Left=�6+   $��23��6F   $��157,261,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $	��120��6�   �� 5   
   -   5        $ lblManutVlrLiqFolha��5      $��VALOR LIQUIDO:��6-   $
��Left=�6F   $��
10,289,0,0q�6a   $	��Top=�6u   �� 5   
   -   5        $ txtManutVlrLiqFolha��5      $
��Left=�6/   $��23��6J   $��157,292,0,0q�6V   $
 Wrap=�6k   $	��Top=�6   $	��120��6�   �� 5   
   -   5        $ btnVoltarMenuInicial��5      $��MENU INICIAL��6/   $
��Left=�6F   $��
10,377,0,0q�6a   $	��Top=�6u   $	��105��6�   6�   �� 5   
   -   5        $ btnVoltarMenuManut��5      $��MENU MANUTENÇÃO��6-   $
��Left=�6G   $��157,377,0,0q�6b   $	��Top=�6w   $	��126��6�   6�   �� 5   
   -   5        $ lblManutQtdeHrNormal��5      $��QUANTIDADE HORA NORMAL:��6.   $
��Left=�6P   $��	10,72,0,0q�6k   $	��Top=�6~   �� 5   
   -   5        $ lblManutQtdeHrExtra��5      $��QUANTIDADE HORA EXTRA:��6-   $
��Left=�6N   $��
10,103,0,0q�6i   $	��Top=�6}   �� 5   
   -   5        $ lblManutVlrHrNormal��5      $��VALOR HORA NORMAL:��6-   $
��Left=�6J   $��
10,134,0,0q�6e   $	��Top=�6y   �� 5   
   -   5        $ lblManutVlrHrExtra��5      $��VALOR HORA EXTRA:��6,   $
��Left=�6H   $��
10,165,0,0q�6c   $	��Top=�6w   �� 5   
   -   5        $ lblManutAnoFolha��5      $
��ANO:��6*   $
��Left=�69   $��
10,341,0,0q�6T   $	��Top=�6h   �� 5    
   -   5        $ txtManutAnoFolha��5       $
��Left=�6,   $��23��6G   $��210,348,0,0q�6S   $
 Wrap=�6h   $	��Top=�6|   $��67��6�   �� 5!   
   -   5        $ txtManutQtHrNormal��5!      $
��Left=�6.   $��23��6I   $��
200,75,0,0q�6U   $
 Wrap=�6i   $	��Top=�6}   $��77��6�   �� 5"   
   -   5        $ txtManutQtHrExtra��5"      $
��Left=�6-   $��23��6H   $��200,106,0,0q�6T   $
 Wrap=�6i   $	��Top=�6}   $��77��6�   �� 5#   
   -   5        $ txtManutVlrHrNormal��5#      $
��Left=�6/   $��23��6J   $��157,137,0,0q�6V   $
 Wrap=�6k   $	��Top=�6   $	��120��6�   �� 5$   
   -   5        $ txtManutVlrHrExtra��5$      $
��Left=�6.   $��23��6I   $��157,168,0,0q�6U   $
 Wrap=�6j   $	��Top=�6~   $	��120��6�   �� 5%   
   -   5        $ btnFolhaEditar��5%      $��EDITAR��6)   $
��Left=�6:   $��374,320,0,0q�6U   $	��Top=�6j   $��75��6�   6�   �� 5&   
   -   5        $ btnFolhaExcluir��5&      $��EXCLUIR��6*   $
��Left=�6<   $��374,351,0,0q�6W   $	��Top=�6l   $��75��6�   6�   5(      5)      