# Music Garden

## Project Description

Music garden is a digital music service that gives you access to millions of songs and other content from creators all over the world. The user would be able to add and remove songs to a playlist and save and share the playlist via a token. Search songs by artist, Album, genre, or song name.


## Technologies Used

* ASP.NET MVC 
* SQL Server
* ADO.Net Entity Framework
* HTML
* CSS
* ASP.NET Web API
* Javascript
* Microsoft Azure


## Features

* Songs can be searched for using the Deezer API.
* Songs can be played and previewed by using the Deezer API.

To-do list:
* User’s can make an Account to have their own personal Playlists and Favorite Songs
* Bug fixing our remote web api application to properly save a playlist
* Create algorithms to calculate Top Songs Played for the Day/Week/Month/All Time


## Getting Started

(include git clone command)
Git clone https://github.com/Music-Garden/aspnet.git

Git clone https://github.com/Music-Garden/webapi.git


#Environments

* Microsoft Azure and Microsoft SQL Server

- Images of what it should look like


## Usage


If you wish to use it on the web rather than locally, then once the project is cloned, create the docker repositories necessary for both the webapi and aspnet repositories. Grab the docker user token for use in the github-action pipeline, and store in your github secrets.
Create two Azure WebApp services, and grab the related AZURE.CREDENTIALS by following this walkthrough: https://github.com/marketplace/actions/azure-login.
The connection to the WebAPI will need to be adjusted for whether you may be running the project locally, or online. This can be found in the aspnet project, in MusicGarden.Client/appsettings.json. Change the webapi url as needed.
https://i.imgur.com/Djl4VOQ.png

When the aspnet project is running, you should be greeted with this webpage upon going to the hosted url routed to home/index, shown in the link below.
https://i.imgur.com/XNAsFDh.png

Upon choosing to Search for a Song, you will be greeted with this screen:
https://i.imgur.com/WBQbhJT.png
When running the Web API in conjunction with this project, you will be able to input a search query and should receive results based on your query, similar to what is pictured
in this link below:
https://i.imgur.com/Pdm3IJQ.png

## Contributors

* Marcangy Cange
* Seth Larson
* Jacob Polivka

## Other Repos

* https://github.com/Music-Garden/webapi

## License

This project uses the following license: MIT.
