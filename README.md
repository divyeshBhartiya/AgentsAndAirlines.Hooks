# AgentsAndAirline.Hooks
To Explore And Leverage The Power Of WebHooks With .NET5 !!!

## Big Picture
![image](https://user-images.githubusercontent.com/16538471/137380108-2686a73d-9117-439e-a9c9-151c42dba090.png)

![image](https://user-images.githubusercontent.com/16538471/137380245-bacb29c6-3745-4187-9d06-548769551375.png)


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


## Courtesy:

Les Jackson

www.udemy.com
