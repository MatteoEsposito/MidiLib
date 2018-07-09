# MidiLib

## Description
Just a proof-of-concept, a little, very featureless Midi Library to use in conjunction with Karaoke software which lacks the ability to search in folders ( like VanBasco )
This app aims to get a fully fuctional midi libary, it can be very usefull in a varieties of workflow and situations.

## Release Version History
V 1.0 09-07-2018

## Pre-requisite
- Have some midi file ( including kar files ) 
- .NetFramework 4/4.5

## How to Build
In order to build, it has to include the following libraries
- LiteDB: NOSQL database free implemetantion
- Custera: Really usefull for the portability of the app cause it embeds all dlls inside the main executable
- Wavers: dependecy of Custera not insatlled by default incertain isnatallation of VS
All libraries can be isnatlled by Nu-get

## How to use:
The usage is really straight forward, it opens in it's "search engine" trough the use of the escape key or the proper button
you can add paths to the Database wich recursively search all mid, midi and kar files and store their path inside itself.
After have imported all the path you can start searching. When you've found the file you were looking for with a click on it's name the app starts the system-default associated program. ( e.g. VanBasco )

## TODO:
I'm releasing the source code because I strongely believe in the free contribution to the common knowledge and software, in this form. So here it is a little list of ideas, feel free to implement it and issue here a merge o a pull request!
- Better managemnt and flexibility of the database handler
- Let user decide with which applciation start the file selected
- Support for dupicate deletion

## Credits:
All external libraries belongs to thei respective authors, the icon chosen was freely acquired here: 
Icons made by smashicons  from www.flaticon.com is licensed by CC 3.0 BY

 
