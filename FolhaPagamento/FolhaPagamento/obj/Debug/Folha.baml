   M S B A M L   `   `   `  ����I  EFolhaPagamento, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:FolhaPagamentoFolhaPagamento  5   	       FolhaPagamento.Folha   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:FolhaPagamento     5   	   -   5          �Name$  telaFolhaPgto��5   	    � Title$ FOLHA PAGAMENTO��5   	   ���	#FFF17272 � WindowStartupLocation$ CenterScreen=�68    � 	Resources 5	         	#FFF17272��%+   &	        ��5
   
   	#FFF06161��6-   5      .��5      � $��0,0,2,-7q�6   .+�5   
   �� -   5         ��Name$ lblApSalCpfEmpregado��5      $��INFORME O CPF:��6.   $
��Left=�6G   $��	10,10,0,0q�6b   $	��Top=�6u   �� 5   
   -   5         ��Name$ txtFolhaCpf��5      $
��Left=�6'   $��23��6B   $��	138,9,0,0q�6N    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��198��6�   �� 5   
   -   5         ��Name$ btnPesquisaCpf��5      $��	PESQUISAR��6)   $
��Left=�6=   $��
349,17,0,0q�6X   $	��Top=�6l   $��60��6�   $��8(�6�   6�   �� 5   
   -   5        $ lblNomeEmpSalario��5      $��NOME EMPREGADO:��6+   $
��Left=�6E   $��	10,36,0,0q�6`   $	��Top=�6s   �� 5   
   -   5        $ txtFolhaNome��5      $
��Left=�6(   $��23��6C   $��
138,37,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $	��271��6�   �� 5   
   -   5        $ lblQtdeHoraNormal��5      $��QUANTIDADE HORA NORMAL:��6+   $
��Left=�6M   $��	10,65,0,0q�6h   $	��Top=�6{   �� 5   
   -   5        $ lblQtdeHoraExtra��5      $��QUANTIDADE HORA EXTRA:��6*   $
��Left=�6K   $��	10,91,0,0q�6f   $	��Top=�6y   �� 5   
   -	   5        $ txtFolhaQtHrNormal��5      $
��Left=�6.   $��23��6I   $��
190,65,0,0q�6U   $
 Wrap=�6i   $	��Top=�6}   $��65��6�   �� 5   
   -
   5        $ txtFolhaQtHrExtra��5      $
��Left=�6-   $��23��6H   $��
190,91,0,0q�6T   $
 Wrap=�6h   $	��Top=�6|   $��65��6�   �� 5   
   -   5        $ lblVlrHrNormal��5      $��VALOR HORA NORMAL:��6(   $
��Left=�6E   $��
10,117,0,0q�6`   $	��Top=�6t   �� 5   
   -   5        $ lblVlrHrExtra��5      $��VALOR HORA EXTRA:��6'   $
��Left=�6C   $��
10,139,0,0q�6^   $	��Top=�6r   �� 5   
   -   5        $ txtFolhaVlrHrNormal��5      $
��Left=�6/   $��23��6J   $��190,117,0,0q�6V   $
 Wrap=�6k   $	��Top=�6   $	��120��6�   �� 5   
   -   5        $ txtFolhaVlrHrExtra��5      $
��Left=�6.   $��23��6I   $��190,142,0,0q�6U   $
 Wrap=�6j   $	��Top=�6~   $	��120��6�   �� 5   
   -   5        $ 
lblVlrInss��5      $��VALOR INSS:��6$   $
��Left=�6:   $��
10,189,0,0q�6U   $	��Top=�6i   �� 5   
   -   5        $ lblVlrImpRenda��5      $��	VALOR IR:��6(   $
��Left=�6<   $��
10,215,0,0q�6W   $	��Top=�6k   �� 5   
   -   5        $ txtFolhaVlrInss��5      $
��Left=�6+   $��23��6F   $��190,192,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $	��120��6�   �� 5   
   -   5        $ txtFolhaVlrIR��5      $
��Left=�6)   $��23��6D   $��190,218,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   �� 5   
   -   5        $ lblVlrBrutoSalario��5      $��VALOR BRUTO:��6,   $
��Left=�6C   $��
10,163,0,0q�6^   $	��Top=�6r    J� RenderTransformOrigin$ 0.5,0.5&�6�   �� 5   
   -   5        $ lblVlrLiqSalario��5      $��VALOR LIQUIDO:��6*   $
��Left=�6C   $��
10,240,0,0q�6^   $	��Top=�6r   �� 5    
   -   5        $ txtFolhaVlrSalBruto��5       $
��Left=�6/   $��23��6J   $��190,166,0,0q�6V   $
 Wrap=�6k   $	��Top=�6   $	��120��6�   �� 5!   
   -   5        $ txtFolhaVlrSalLiq��5!      $
��Left=�6-   $��23��6H   $��190,243,0,0q�6T   $
 Wrap=�6i   $	��Top=�6}   $	��120��6�   �� 5"   
   -   5        $ btnSalvarSalario��5"      $��SALVAR��6+   $
��Left=�6<   $��354,307,0,0q�6W   $	��Top=�6l   $��55��6�   $��8(�6�   6�   �� 5#   
   -   5        $ lblMesRefSalario��5#      $��MÊS:��6*   $
��Left=�69   $��
10,271,0,0q�6T   $	��Top=�6h   �� 5$   
   -   5        $ lblAnoRefSalario��5$      $
��ANO:��6*   $
��Left=�69   $��
10,302,0,0q�6T   $	��Top=�6h   �� 5%   
   -   5        $ txtFolhaMesRef��5%      $
��Left=�6*   $��23��6E   $��190,271,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��120��6�   �� 5&   
   -   5        $ txtFolhaAnoRef��5&      $
��Left=�6*   $��23��6E   $��190,299,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��120��6�   �� 5'   
   -   5        $ btnVoltarMenu��5'      $��MENU CADASTRO��6(   $
��Left=�6@   $��
10,333,0,0q�6[   $	��Top=�6o   $	��113��6�   6�   5)      5*      