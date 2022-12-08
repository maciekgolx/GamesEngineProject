# Project Title

Name:

Student Number: C19389881

Class Group:DT228

# Description of the project
	This project you control a robot who is placed in a house, 
	you can explore the house and a platform right outside. 

	There is a fireplace with a particle system which simulates a real fire. 
	In the main room of the house there are 3 spinning hologram platforms present,
	each of which have a guitar which scales depending on the frequency of the music played. 
	The player when they move outside they can look for a star which reacts to their voice. 

	In the distance a lot of starships can be seen,
	with one of them going in a circular motion around various axis, 
	the rest of the starships use the seek and arrive theory of artificial intelligence,
	in order to move in accordance with the first starship.


	The starships, guitar, fireplace and sofa are all created in blender
# Instructions for use
	The user can move in Virtual Reality using their two controllers
	The right controllers button is responsible for turning,
	 where as the left controller is responsible for moving.
	the individual can walk on the various platforms to explore the world

# List of classes/assets in the project and whether made yourself or modified or if its from a source, please give the reference

| Class/asset 				| Source |
|---------------------------|-----------|
| ParticleAIController.cs 	| Self written |
| Randomrotate.cs			| Self written |
| CircularMovement.cs		| Self written |
| ScaleFromMicrophone.cs	| Self written |
| MicDetection.cs			| Self written |
| AudioLoudnesstester.cs	| Self written |
| Head.cs					| Self written |
| Hand.cs					| Modified from [reference]()  |
| IKFootSolver.cs 			| From [reference]() |

# How it works

# References

# What I am most proud of in the assignment

# Proposal submitted earlier can go here:
I aim of my project is to incorporate music and sci-fi into one, similar to the self playing guitar or piano idea shown in the brief but with a bit more groovyness, i aim to have the guitar produce music  from a hologramic point of view. I also aim for each key of the guitar to be reflected in the song. As well as the user being able to play a guitar of their own to produce music in the virtual reality environment which will be reflected by the background changing.

I plan to implement this idea by having a guitar hologram playing a song, and a seperate function of the user being able to play their guitar and it reflecting in the background in a virtual reality setting
## This is how to markdown text:

This is *emphasis*

This is a bulleted list

- Item
- Item

This is a numbered list

1. Item
1. Item

This is a [hyperlink](http://bryanduggan.org)

# Headings
## Headings
#### Headings
##### Headings

This is code:

```Java
public void render()
{
	ui.noFill();
	ui.stroke(255);
	ui.rect(x, y, width, height);
	ui.textAlign(PApplet.CENTER, PApplet.CENTER);
	ui.text(text, x + width * 0.5f, y + height * 0.5f);
}
```

So is this without specifying the language:

```
public void render()
{
	ui.noFill();
	ui.stroke(255);
	ui.rect(x, y, width, height);
	ui.textAlign(PApplet.CENTER, PApplet.CENTER);
	ui.text(text, x + width * 0.5f, y + height * 0.5f);
}
```

This is an image using a relative URL:

![An image](images/p8.png)

This is an image using an absolute URL:

![A different image](https://bryanduggandotorg.files.wordpress.com/2019/02/infinite-forms-00045.png?w=595&h=&zoom=2)

This is a youtube video:

[![YouTube](http://img.youtube.com/vi/J2kHSSFA4NU/0.jpg)](https://www.youtube.com/watch?v=J2kHSSFA4NU)

This is a table:

| Heading 1 | Heading 2 |
|-----------|-----------|
|Some stuff | Some more stuff in this column |
|Some stuff | Some more stuff in this column |
|Some stuff | Some more stuff in this column |
|Some stuff | Some more stuff in this column |

