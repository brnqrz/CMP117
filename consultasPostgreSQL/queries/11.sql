SELECT 
       pd.codigo, 
       pd.e_rua, 
       pd.e_num, 
       pd.e_bairro, 
       pd.e_complemento, 
       pd.e_cidade, 
       pd.e_estado, 
       SUM(s.capacidade) AS capacidade
FROM concurso_predio AS cp
JOIN predio AS pd ON cp.predio_cod = pd.codigo
JOIN sala AS s ON pd.codigo = s.predio_codigo
WHERE cp.concurso_num = 1
GROUP BY pd.codigo, 
       pd.e_rua, 
       pd.e_num, 
       pd.e_bairro, 
       pd.e_complemento, 
       pd.e_cidade, 
       pd.e_estado
ORDER BY pd.codigo;