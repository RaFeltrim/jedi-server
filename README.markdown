# Jedi Server

## Descrição
O **Jedi Server** é uma aplicação web interativa baseada no universo de Star Wars. Este projeto permite explorar informações detalhadas de personagens, planetas e naves estelares através de uma interface atraente e intuitiva. Foi desenvolvido com foco na integração de dados e experiência do usuário.

Desenvolvido por Rafael Feltrim em colaboração com Daniela Yukari Udo, como parte de um estudo prático de desenvolvimento web moderno.

## Funcionalidades
- Listagem de personagens, naves e planetas do universo Star Wars.
- Integração com um banco de dados local no formato JSON (`starwars.json`).
- Interface estilizada com suporte a dispositivos móveis.
- Navegação dinâmica e interativa através de eventos JavaScript.

## Tecnologias Utilizadas
- **HTML5**: Estruturação da interface.
- **CSS3**: Estilização responsiva.
- **JavaScript**: Lógica de interação e manipulação de dados.
- **Node.js**: Gerenciamento de pacotes e dependências.
- **ESLint**: Padronização e validação de código.

## Estrutura do Projeto
```
jedi-server-main/
├── .vscode/               # Configurações do VSCode
├── codigo.js              # Lógica do projeto em JavaScript
├── estilos.css            # Arquivo de estilos CSS
├── index.html             # Página principal HTML
├── starwars.json          # Dados utilizados na aplicação
├── package.json           # Dependências do projeto
├── README.md              # Documentação do projeto
└── eslint.config.mjs      # Configurações do ESLint
```

## Instalação e Uso
### Pré-requisitos
Certifique-se de ter o [Node.js](https://nodejs.org/) instalado.

### Passos para instalação:
1. Clone este repositório:
   ```bash
   git clone https://github.com/RaFeltrim/Jedi-Server.git
   cd Jedi-Server
   ```

2. Instale as dependências do projeto:
   ```bash
   npm install
   ```

3. Inicie o servidor local:
   ```bash
   npm start
   ```

4. Acesse a aplicação no navegador em [http://localhost:3000](http://localhost:3000).

## Licença
Este projeto está licenciado sob os termos da [MIT License](LICENSE).

---
**Autores**: Rafael Feltrim e Daniela Yukari Udo  
**Contato**: [rafeltrim@gmail.com](mailto:rafeltrim@gmail.com), [danielaudo26@gmail.com](mailto:danielaudo26@gmail.com)
