# ConsumerProducerRabbitMQ
Teste básico RabbitMQ

## Como usar

- Necessário a última versão do Visual Studio 2019, a versão 3.1 do .NET Core SDK 
- Erlang versão 22.3 (requisito para rodar o RabbitMQ Server)
- RabbitMQ Server 3.8.3

## Tecnologias utilizadas:

- .NET Core 3.1
- RabbitMQ 3.8.3
- Erlang 22.3

## Como rodar

1. Instalar o Erlang (usuário administrador)
2. Instalar o RabbitMQ server
3. Produzir as mensagens rodando o projeto Producer Debug => Start Without Debugging ou [Ctrl]+[F5]
4. Visualizar as mensagens rodando o projeto Consumer Debug => Start Without Debugging ou [Ctrl]+[F5]

### Para visualizar as filas no dashboard do RabbitMQ

1. Abrir o RabbitMQ Command Prompt (sbin dir)
2. Executar o comando "rabbitmq-plugins enable rabbitmq_management"
3. Para iniciar o serviço executar o comando "rabbitmqctl start_app"
4. Para acessar o dashboard, acessar a url http://localhost:15672 com username "guest" e password "guest"
5. Para visualizar a fila, acessar http://localhost:15672/#/queues

