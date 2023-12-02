# XmlUnitTest 

## Requisitos
### No projeto XmlUnitTest -> temos exemplos de 4 Xml’s:
- Xml Completo
- Xml Inválido
- Xml Sem CNPJ Emitente
- Xml Sem Número da NFS-e

### Executar:
##### ->  Criar método que teste se o Xml é válido
- Utilizar xml inválido e validar exceção;
  
##### -> Criar método que valide se o Xml Válido possui todas informações obrigatórias:
- Utilizar o Xml completo;
- Validar se os campos de Número, CNPJ emit e CNPJ dest foram preenchidos corretamente;
  
##### ->  Criar exceção na classe de leitura para os campos obrigatórios e criar testes para validar tais:
- Utilizar XmlWithoutEmit para validar campo de CNPJ;
- Utilizar XmlWithoutNumber para validar campo de número;
