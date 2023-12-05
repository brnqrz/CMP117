SELECT 
       pd.codigo, 
       pd.e_rua, 
       pd.e_num, 
       pd.e_bairro, 
       pd.e_complemento, 
       pd.e_cidade, 
       pd.e_estado, 
       ifis.sala_numero, 
       ifis.fiscal_cpf, 
       p.nome
FROM inscricao_f AS ifis
JOIN pessoa AS p ON ifis.fiscal_cpf = p.cpf
JOIN sala AS s ON ifis.sala_numero = s.numero AND ifis.sala_codigo_pred = s.predio_codigo
JOIN predio AS pd ON s.predio_codigo = pd.codigo
WHERE ifis.concurso_numero = 4
ORDER BY pd.codigo, ifis.sala_numero, p.nome, ifis.fiscal_cpf;