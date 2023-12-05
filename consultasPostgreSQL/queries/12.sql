SELECT 
       pd.codigo, 
       pd.e_rua, 
       pd.e_num, 
       pd.e_bairro, 
       pd.e_complemento, 
       pd.e_cidade, 
       pd.e_estado,
       s.numero AS numero_sala,
       s.capacidade AS capacidade,
       COUNT(ic.candidato_cpf) AS candidatos, 
       (CASE WHEN (s.capacidade - COUNT(ic.candidato_cpf)) > 0 THEN (s.capacidade - COUNT(ic.candidato_cpf)) ELSE 0 END) AS vagas_livres,
       (CASE WHEN (COUNT(ic.candidato_cpf) > s.capacidade)  THEN 'SIM' ELSE 'NAO' END) AS overbooking
FROM concurso_predio AS cp
JOIN predio AS pd ON cp.predio_cod = pd.codigo
JOIN sala AS s ON pd.codigo = s.predio_codigo
JOIN inscricao_c AS ic ON ic.concurso_numero = cp.concurso_num AND ic.sala_numero = s.numero AND  ic.sala_codigo_pred = pd.codigo
WHERE cp.concurso_num = 1
GROUP BY 
pd.codigo, 
       pd.e_rua, 
       pd.e_num, 
       pd.e_bairro, 
       pd.e_complemento, 
       pd.e_cidade, 
       pd.e_estado,
       s.numero,
       s.capacidade
ORDER BY pd.codigo, s.numero;