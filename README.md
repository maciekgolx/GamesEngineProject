# Space Shenaniggans 

Name: Maciej Golubski

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


# How it works
### Model combined with camera
A model has been imported from the asset store of a robot.
this Model is then rigged to have both hand movements, leg movements and head movements.
##### Leg Movement 
To get the leg movement working,
I have followed a tutorial to get the legs to move in accordance to the rate of movement of the camera

# List of classes/assets in the project 

| Class/assets 				| Source |
|---------------------------|-----------|
| ParticleAIController.cs 	| Self written |
| Randomrotate.cs			| Self written |
| CircularMovement.cs		| Self written |
| ScaleFromMicrophone.cs	| Self written |
| MicDetection.cs			| Self written |
| AudioLoudnesstester.cs	| Self written |
| Head.cs					| Modified from [reference](https://www.youtube.com/watch?v=MYOjQICbd8I&list=PLwz27aQG0IIK88An7Gd16An9RrdCXKBAB&index=19) |
| Hand.cs					| Modified from [reference](https://www.youtube.com/watch?v=MYOjQICbd8I&list=PLwz27aQG0IIK88An7Gd16An9RrdCXKBAB&index=19)  |
| IKFootSolver.cs 			| From [reference](https://www.youtube.com/watch?v=1Xr3jB8ik1g&t=256s) |
| Robert Kyle				| Imported from asset store |
| sofa.fbx	                | self created in blender |
| fire						| Self written |
| skybox					| Self written |
| fireplace.fbx				| self created in blender |
| spaceship.fbx				| self created in blender |
| guitar.fbx				| self created in blender |
# References

# What I am most proud of in the assignment

# Proposal submitted earlier can go here:
	I aim of my project is to incorporate music and sci-fi into one, similar to the self playing guitar or piano idea shown in the brief but with a bit more groovyness, i aim to have the guitar produce music  from a hologramic point of view. I also aim for each key of the guitar to be reflected in the song. As well as the user being able to play a guitar of their own to produce music in the virtual reality environment which will be reflected by the background changing.

	I plan to implement this idea by having a guitar hologram playing a song, and a seperate function of the user being able to play their guitar and it reflecting in the background in a virtual reality setting
## This is how to markdown text:

# class "scale from microphone"
```c#
void Update()
    {
        float loudness = detector.GetLoudnessFromMicrophone() * loudnessSensibility;

        if ( loudness<threshold)
            loudness =0;
        transform.localScale= Vector3.Lerp(minScale,maxScale,loudness);
    }
```
Gets the loudnessFromMicrophone class from a different file and compares it then it scales it relative to the variables
# class "GetLoudnessFromMicrophone"
```c#
    public float GetLoudnessFromMicrophone()
    {
        return GetLoudnessFromAudioClip(Microphone.GetPosition(Microphone.devices[0]),microphoneClip);
    }
```
Gets loudness from a clip 
# class "GetLoudnessFromAudioClip"
```c#
    public float GetLoudnessFromAudioClip(int clipPosition, AudioClip clip)
    {
        int startPosition = clipPosition- sampleWindow;
        if(startPosition<0)
            return 0;

        float[] waveData = new float[sampleWindow];
        clip.GetData(waveData,startPosition);

        //compute loudness
        float totalLoudness = 0;
        for(int i = 0 ; i < sampleWindow; i++)
        {
            totalLoudness+= Mathf.Abs(waveData[i]);
        }
        return totalLoudness/ sampleWindow;
    }
```
Uses GetData to fetch data from the microphone which is in the form of a wave
# class "CircularMovement"
```c#
    void Update()
    {
        if (angle >= 360f)
            angle = 0f;
            posX =  centerRotation.position.x + Mathf.Cos (angle) * radiusRotation;
            posY =  centerRotation.position.y + Mathf.Sin (angle) * radiusRotation;
            posZ =  centerRotation.position.z + Mathf.Sin (angle) * radiusRotation;
            angle += Time.deltaTime * angularSpeed;
        

        transform.position = new Vector3(posX,posY,posZ);
    }
```
Makes the main spaceship rotate in a circular way
# class "ParticleAI"
```c#
    void Update()
    {
        otherParticleMesh.SetDestination(particleObj.position);
    }
```
Helps with Artificial intelligence of agents to follow the object
# class "Randomrotate"
```c#
    void Update()
    {
        rotateS = speed * Time.deltaTime;
        transform.Rotate(0, rotateS, 0);
    }
}
```
Rototate the hologram platforms
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

