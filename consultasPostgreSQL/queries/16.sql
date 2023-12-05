SELECT 
       pd.codigo, 
       pd.e_rua, 
       pd.e_num, 
       pd.e_bairro, 
       pd.e_complemento, 
       pd.e_cidade, 
       pd.e_estado, 
       s.numero AS numero_sala, 
       COUNT(ifis.fiscal_cpf) AS quantidade_fiscais
FROM concurso_predio AS cp
JOIN predio AS pd ON cp.predio_cod = pd.codigo
JOIN sala AS s ON pd.codigo = s.predio_codigo
LEFT JOIN inscricao_f AS ifis ON cp.concurso_num = ifis.concurso_numero AND s.numero = ifis.sala_numero AND pd.codigo = ifis.sala_codigo_pred
WHERE cp.concurso_num = 8
GROUP BY pd.codigo, pd.e_rua, pd.e_num, pd.e_bairro, pd.e_complemento, pd.e_cidade, pd.e_estado, s.numero
ORDER BY pd.codigo, s.numero;