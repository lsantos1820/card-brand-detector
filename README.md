💳 Card Brand Detector (C#) — Regex + GitHub Copilot

Aplicação simples em C#/.NET capaz de identificar a bandeira de um cartão de crédito (Visa, MasterCard, Amex, etc.) a partir do número informado.
O projeto foi desenvolvido com foco em boas práticas, lógica de validação com expressões regulares (Regex) e exploração do GitHub Copilot como assistente de codificação para acelerar a produtividade.

🎯 Objetivo

Identificar bandeiras de cartão com base em BIN/IIN + comprimento do número.

Praticar Regex e organização de código em camadas simples (Models/Services).

Explorar o GitHub Copilot para:

gerar trechos de código com prompts,

refatorar e melhorar legibilidade,

acelerar o desenvolvimento.

🧠 Tecnologias e Conceitos

.NET / C#

Console App

Regex (System.Text.RegularExpressions)

Boas práticas de organização (separação por responsabilidade)

Git + GitHub

GitHub Copilot (IA Generativa e engenharia de prompt)

🗂️ Estrutura do Projeto
CardBrandDetector
├── CardBrandDetector.sln
└── cardBrandDetector
    ├── Program.cs
    └── Src
        ├── Models
        │   └── CardBrandResult.cs
        └── Services
            └── CardBrandDetectorService.cs
