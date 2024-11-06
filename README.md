# Calculadora com TDD em .NET usando xUnit

Projeto de uma calculadora simples que realiza operações matemáticas básicas e mantém um histórico das últimas operações realizadas. A implementação foi feita com desenvolvimento orientado a testes (TDD) usando xUnit.

## Tecnologias Usadas

- **C#**
- **.NET 5.0 ou superior**
- **xUnit** para testes unitários

## Como Usar

1. Clone o repositório:
```bash
   git clone https://github.com/Ale015/c_sharp-trilha-net-testes-unitarios.git
   cd c_sharp-trilha-net-testes-unitarios
```

2. Restaure os pacotes e execute o programa:
```bash
dotnet restore
dotnet run --project NewTalents
```

3. Para rodas os testes:
```bash
cd .\NewTalentsTests\
dotnet test
```

## Funcionalidades
- Operações Matemáticas: Soma, subtração, multiplicação e divisão (com verificação de divisão por zero).
- Histórico de Operações: Armazena e exibe as três operações mais recentes.
- Testes com xUnit: Valida todas as operações e o histórico.
