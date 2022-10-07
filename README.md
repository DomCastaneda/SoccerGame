## Notice
This game follows BatteryAcid's Unity Multiplayer Movement Synchronization w/ AWS tutorial:

https://www.youtube.com/watch?v=cMGLFkG1iDg&t=360s&ab_channel=BatteryAcid

The game also contains contents from BatteryAcid's GitHub repositories:

https://github.com/BatteryAcid/multiplayer-movement-sync-aws

https://github.com/BatteryAcid/multiplayer-movement-sync-unity

This game follows CloudScalr's blog post on Terraform and AWS:

https://cloudscalr.com/github-actions-terraform-oidc/

## Game Overview
Strikers is a 1v1 soccer minigame that showcases multiplayer synchronization functionality using AWS. The game allows players to compete in a practice soccer match against another and see each other's skills. The first player to score a goal using their unique soccer ball wins. Player's positions are logged onto the UI Canvas to confirm multiplayer synchronization.

## AWS Lambda, DynamoDB and APIGateway For Multiplayer Synchronization
The project uses an API Gateway to establish a websocket connection. 

There are three Lambda functions that handle match making, gameplay synchronization and disconnection. The first function, join-game, reacts when the clients connect. The second function, disconnect-game, reacts when the clients disconnect. The last function, game-messaging, reacts when the clients send messages to the server then he server sends the messages to all connected clients using the new API Gateway Management API.

A DynamoDb table is used for tracking player uuids and game status. Websockets allows the game to create a two-way communication line as a real-time application. This game could be considered a real-time application because the server has the ability to push to the clients without the client requesting data first. This is efficient for Strikers because the clients (players) request data from the server as needed.

## Troubleshooting Synchronization Lag
Currently player movement synchronization works as the game starts and I have been troubleshooting the fix as to why synced movement only works for a short time. It could be due to my game-messaging lambda function or my AWS free subscription but I am not yet sure the cause. Multiplayer gameplay matchmaking and player disconnects work.  

## Deploying with Terraform, AWS and GitActions
This project uses a GitHub action to deploy with Terraform in AWS. To make it more secure, I used GitHub OIDC (OpenID Connect) and only allowed these credentials to be run from GitHub Actions. After authentification using JWT, GitHub Actions will get access to AWS.

## Stress Testing
I attempted stress testing my backend code but unfortunately wasn't able to complete this portion of the game quest.