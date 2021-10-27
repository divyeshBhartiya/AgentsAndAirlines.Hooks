# AgentsAndAirline.Hooks
To Explore And Leverage The Power Of WebHooks With .NET5 !!!

WebHooks is a lightweight HTTP pattern providing a simple pub/sub model for wiring together Web APIs and SaaS services. When an event happens in a service, a notification is sent in the form of an HTTP POST request to registered subscribers. The POST request contains information about the event which makes it possible for the receiver to act accordingly.

## WebHooks
![image](https://user-images.githubusercontent.com/16538471/137380466-da9e65c9-7a99-4e6f-bad0-4170f92943e9.png)

## WebHooks Overview
WebHooks is a pattern which means that it varies how it is used from service to service but the basic idea is the same. You can think of WebHooks as a simple pub/sub model where a user can subscribe to events happening elsewhere. The event notifications are propagated as HTTP POST requests containing information about the event itself.

Typically the HTTP POST request contains a JSON object or HTML form data determined by the WebHook sender including information about the event causing the WebHook to trigger. To ensure that the WebHook is indeed from the intended sender, the POST request is secured in some way and then verified by the receiver.

The WebHook flow generally goes something like this:

The WebHook sender exposes events that a client can subscribe to. The events describe observable changes to the system, for example that a new data item has been inserted, that a process has completed, or something else. The WebHook receiver subscribes by registering a WebHook consisting of four things:

1.  A URI for where the event notification should be posted in the form of an HTTP POST request;

2.  A set of filters describing the particular events for which the WebHook should be fired;

3.  A secret key which is used to sign the HTTP POST request;

4.  Additional data which is to be included in the HTTP POST request. This can for example be additional HTTP header fields or properties included in the HTTP POST request body.

Once an event happens, the matching WebHook registrations are found and HTTP POST requests are submitted. Typically, the generation of the HTTP POST requests are retried several times if for some reason the recipient is not responding or the HTTP POST request results in an error response.


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
(Note: Instead of Docker setup I've used local setup of Microsoft SQL Server.)


## Courtesy:

Les Jackson

www.udemy.com

https://docs.microsoft.com/en-us/aspnet/webhooks/
