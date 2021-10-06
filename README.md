# AgentsAndAirline.Hooks
To Explore And Leverage The Power Of WebHooks With .NET5 !!!

The projects we build are:

## Airline Web

Webhook Registration REST API

Flight Details REST API - used to trigger webhook by publishing to RabbitMQ message bus

Simple HTML / JavaScript / Bootstrap Web Client to make webhook registration API calls

## Airline Send Agent

Stand alone "agent" used to send webhooks "en-mass"

Dependency Injection enabled

RabbitMQ Subscriber / Consumer with event based message delivery

Uses HttpClient and HttpClientFactory

## Travel Agent Web

Simple Webhook POST Endpoint

Uses SQL Server backend to retrieve webhook "secret" to authenticate webhooks

We also use Docker Compose to set up and run following solution fabric:

RabbitMQ Server

Microsoft SQL Server
