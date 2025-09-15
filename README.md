🚀 Tecnologias Utilizadas

C#

.NET 6/7 (dependendo da versão escolhida)

Entity Framework Core

SQL Server (ou outro banco configurado)

Swagger/OpenAPI (para documentação)

⚙️ Funcionalidades

✅ Cadastro de entidades personalizadas

✅ Consulta com filtros

✅ Atualização de registros

✅ Exclusão de registros

✅ Documentação interativa via Swagger

📂 Estrutura do Projeto
📦 SistemaPersonalizadoAPI
 ┣ 📂 Controllers     # Endpoints da API
 ┣ 📂 Models          # Modelos de dados
 ┣ 📂 Data            # Contexto do banco de dados
 ┣ 📂 Services        # Regras de negócio
 ┣ 📂 Migrations      # Controle de versões do banco
 ┗ Program.cs         # Configuração principal

▶️ Como Executar o Projeto
1. Clone o repositório
git clone https://github.com/seu-usuario/sistema-personalizado-api.git

2. Acesse a pasta do projeto
cd sistema-personalizado-api

3. Configure o banco de dados no arquivo appsettings.json

Exemplo de configuração:

"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=SistemaPersonalizado;Trusted_Connection=True;"
}

4. Execute as migrações
dotnet ef database update

5. Rode a aplicação
dotnet run


A API ficará disponível em:
👉 https://localhost:5001/swagger

📌 Exemplos de Endpoints
🔹 Criar um registro (POST)
POST /api/entidades


Body (JSON):

{
  "nome": "Exemplo",
  "descricao": "Registro de teste"
}

🔹 Listar registros (GET)
GET /api/entidades

🛠️ Contribuição

Faça um fork do projeto

Crie uma branch (git checkout -b feature/minha-feature)

Commit suas alterações (git commit -m 'Adiciona minha feature')

Envie para a branch (git push origin feature/minha-feature)

Abra um Pull Request

📄 Licença

Este projeto está sob a licença MIT.
