# Automatic Irrigation System - API (AIS-API)

## Description AIS
Automatic Irrigation System is a automatic system that measure soil moisture with a sensor and decides if it need water or not.
The system then register this data to a open rest API (AIS-API) and a WEB based system gets this data and output it on a webpage (AIS-WEB).

The final goal with this project is that you can have a lots of fresh plants and flowers without have to spend time of to managing them.

## Description AIS-API
This is a functional REST Api that you can connect to from different programes. It manages the output from various moisture sensors (AIS-Sensor) placed in the soil of a plants or flowers.
It is easy to connect to this API and it manages PUT, POST and DELETE.

# BETA
This version is fully functional but i recommend to use it in privat network becuse there is no securite built in.  

## TODO
* Add security to the API that nobody that hasent been autorized can POST, DELETE or PUT values.
* Add multiply users

## Languages
This project is written in C#

## Features
* Easy to manages.
* GET, POST, PUT and DELETE.
* Documentation page to API (localhost:PORT/help)


## Tested software versions
* Mysql Workbench 6.3.8
* Microsoft Visual Studio Professional 2017
* Microsoft Visual Studio Community 2015

## Recommended software versions
* Mysql Workbench 6.3.8
* Microsoft Visual Studio Professional 2017

## Packages
* Microsoft.AspNet.WebApi.HelpPage

## Installation (WRITE THIS!!!!!)
1. Clone this repo and set folder Linkify to localhost or create a [Virtual directory](https://en.wikipedia.org/wiki/Virtual_directory)
  `git clone git@github.com:joakimremler/Linkify.git`.

2. Create a Database in Mysql called Linkify `CREATE DATABASE Linkify;`.

3. Import `linkify.sql` MySql backup file. Navigate to assets/mysql and insert this line:

    `mysql -u root -p Linkify < linkify.sql`

4. Edit your settings in core/init.php.

5. You're done, enjoy!

## Resources
Install Mysql Workbench:
[Mysql Workbench](https://dev.mysql.com/downloads/file/?id=467606)

Adding documentaion to API:
[Documentaion](https://www.youtube.com/watch?v=birftXcqDjo)

Great tutorial on C# REST API:
[REST API](https://www.youtube.com/watch?v=JeIE3jzAxHU)
