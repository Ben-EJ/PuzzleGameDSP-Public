# Puzzle Game VR

# Abstract
VR as a platform is becoming increasingly more popular as time goes on, VR as we know it today, requires the user to place a headset upon their head to view the VR world and interact with said world through controllers held with each hand allowing the user to interact with in-game objects. Its most common use-case is in gaming, VR does however have applications in other fields such as education and medicine. The following report is a look into this rising technology and details the development of a VR game, and the research, testing and design associated with it. The purpose of this project it to experiment with VR technology in hopes to create a playable game with its own virtual world, puzzles, and method of interaction with this virtual world via controllers. The research involves looking at VR, its associated technologies, VR in popular culture and its application in fields other than gaming. Furthermore, the research will look into different game engines, and web frame works that could be used in the game’s development. The rest of the body of the report details the design of the game, creation of both functional and non-functional requirement and an in depth look into the process of creating fully playable VR game.

# Acknowledgements
Just want to give credit to friends, family my supervisor Dr. Benedict Gaster, my second marker Dr. Craig Duffy and to all others who helped me develop ideas for the project.

# Table of Contents
| Title | Page Number |
| ------------- | ------------- |
| Abstract	| 1 |
| Acknowledgements	| 1 |
| Table of Contents |	2 |
| Table of Figures	| 5 |
| Introduction	| 7 |
| Aims and Objectives	| 7 |
| Chapter outline	| 8 |
| Literature Review |	9 |
| Chapter Introduction |	9 |
| Introduction to VR |	9 |
| VR in past and present media |	9 |
| The Metaverse	| 9 |
| Early Virtual Reality Headsets and Head Mounted Displays	9|
| Sensorama	| 9 |
| Myron Krueger’s Videoplace	| 9 |
| Key elements of VR in 2003	| 10 |
| VR Possibilities outside of gaming |	10 |
| VR in Education	| 10 |
| VR in Medicine	| 11 |
| Game engines	| 11 |
| Tracking technology	| 12 |
| Xbox Kinect	| 12 |
| SLAM Overview	| 13 |
| Offline-SLAM for Map Acquisition a simple example of SLAM	| 13 |
| Oculus and SLAM	| 13 |
| Application Programming Interface	| 14 |
| REST API	| 14 |
| Web frameworks in python	| 14 |
| Django	| 14 |
| Flask	| 14 |
| WebSocket Scripting	| 15 |
| Examples of VR puzzle games	| 15 |
| Tetris® Effect: Connected	| 15 |
| I Expect You To Die 2 | 16 |
| Methodology	| 18 |
| Chapter Introduction	| 18 |
| Selected Methodology	| 18 |
| Requirements	| 19 |
| Chapter introduction	| 19 | 
| The Requirements	| 19 | 
| Functional Requirements:	| 19 |
| Requirements Analysis for functional requirements:	| 22 |
| Non-functional Requirements:	| 24 | 
| Requirements Analysis for non-functional requirements:	| 25 |
| Design	| 26 |
| Introduction to Chapter	| 26 |
| High Level Design	| 26 |
| Architecture diagram	| 26 |
| Use-Case Diagram Website (Django)	| 27 |
| Use-Case diagram puzzle game VR (Unity)	| 28 |
| Database design	| 28 |
| Website Design	| 29 |
| Low Level Design	| 31 |
| Class Diagram puzzle vr game (Unity) Part 1	| 31 |
| Class Diagram puzzle vr game (Unity) Part 2	| 32 |
| 8 Queens flowcharts:	| 33 |
| 2048 Game Flowcharts	| 38 |
| Reuse of Existing Code	| 38 |
| Implementation	| 39 |
| Chapter Introduction	| 39 |
| Sprint 1:	| 39 |
| Burn Down Chart:	| 39 |
| Explanation important code completed in sprint/Reflections:	| 40 |
| Functional Requirements Testing	| 43 |
| Sprint 2:	| 44 |
| Burn Down chart:	| 44 |
| Explanation important code completed in sprint/Reflections:	| 45 |
| Functional Requirements Testing	| 49 |
| Sprint 3:	| 51 |
| Burndown chart:	| 51 |
| Explanation important code completed in sprint:	| 52 |
| Functional Requirements Testing	| 52 |
| Sprint 4:	| 54 |
| Burn-Down chart:	| 54 |
| Explanation important code completed in sprint/Reflections:	| 55 |
| Functional Requirements Testing	| 55 |
| Non-functional requirements testing:	| 56 |
| Evaluation of testing	| 56 |
| Completed Implementation Images	| 57 |
| Project Evaluation	| 62 |
| Research	| 62 |
| Requirements	| 62 |
| Methodology	| 62 |
| Design	| 62 |
| Implementation and testing	| 62 |
| Further Work and Conclusions	| 63 |
| Conclusion	| 63 |
| Future work | 63 |
| References |	64 |

# Table of Figures
| Figure Number  | Title |
| ------------- | ------------- |
| Figure 1 | VR Game and Headset Image	14 |
| Figure 2 |  (Mishra, Shrawankar, 2016) ASSESSMENT OF ENGINES ON PERFORMANCE ASPECTS.	17 |
| Figure 3 |  (Zhang, 2012, pp.4-12) Depth Map	18
| Figure 4 |  Body tracking (Zhang, 2012, pp.4-12).	19 |
| Figure 5 |  The image provided is from the game Tetris® Effect: Connected (Monstars Inc. Resonair and Stage Games 2020).	21 |
| Figure 6 |  The image provided is from the game Tetris® Effect: Connected (Monstars Inc. Resonair and Stage Games 2020).	22 |
| Figure 7 |  The image provided is from the game I Expect You To Die 2 (Schell Games 2021).	22 |
| Figure 8 |  The image provided is from the game I Expect You To Die 2 (Schell Games 2021).	23 |
| Figure 9 |  Functional requirements.	28 |
| Figure 10 |  Non-functional requirements.	30 |
| Figure 11 |  Architecture Diagram.	32 |
| Figure 12 |  Website Use Case Diagram	33 |
| Figure 13 |  VR Game Use Case Diagram	34 |
| Figure 14 |  Database Design	34 |
| Figure 15 |  Home Page UI Design	35 |
| Figure 16 |  8 Queens Leader Board Page Design	35 |
| Figure 17 |  2048 Leader Board Page Design	36 |
| Figure 18 |  About Page Design	36 |
| Figure 19 |  VR Game Class Diagram Part 1	37 |
| Figure 20 |   VR Game Class Diagram Part 2	38 |
| Figure 21 |  PossibleMovesXAxis function flowchart	39 |
| Figure 22 |  Part of PossibleMovesXAxis function flowchart	39 |
| Figure 23 |  CalcDiagonalTopRight Function Flowchart	40 |
| Figure 24 |  CalcDiagonalTopRight Function Flowchart Loops	40 |
| Figure 25 |  CalcDiagonalTopRight Function Flowchart Loops, Add Chess coordinates.	41 |
| Figure 26 |  CalcDiagonalTopLeft Function Example	42 |
| Figure 27 |  Basic Game Logic For 8 Queens	43 |
| Figure 28 |  Cube merge and move algorithm 2048 Flowchart	44 |
| Figure 30 |  Burn Down Chart Sprint 1.	45 |
| Figure 31 |  Sprint 1 tasks	46 |
| Figure 32 |  Chess Coordinate List Part A.	46 |
| Figure 33 |  Chess Coordinate List Part B.	46 |
| Figure 34 |  PossibleMovesXAxis Code Snippet	46 |
| Figure 35 | CalcDiagonalTopLeft Code Snippet	47 |
| Figure 36 |  Chess Board Example	48 |
| Figure 37 |  All Possible Moves Output Example.	48 |
| Figure 38 |  InLineOfSightQueen Code Snippet	49 |
| Figure 39 |  CalculateScore Code Snippet	49 |
| Figure 40 |  Functional requirements testing sprint 1.	50 |
| Figure 41 |  Burndown chart sprint 2.	51 |
| Figure 42 |  Sprint 2 Tasks	51 |
| Figure 43 |  cubeMoveMerge Code Snippet.	52 |
| Figure 44 |  MoveMerge Code Snippet Part 2	53 |
| Figure 45 |  2048 updated row screenshot	54 |
| Figure 46 |  LeftButton Code Snippet.	55 |
| Figure 47 |  Functional Requirement Tests Sprint 2.	56 |
| Figure 48 |  Burn Down Chart Sprint 3.	57 |
| Figure 49 |  Sprint 3 Tasks	57 |
| Figure 50 |  REST API Code Snippet	58 |
| Figure 51 |  HTTPRequest Code Snippet	58 |
| Figure 52 |  Functional Requirements Tests Sprint 3.	59 |
| Figure 53 |  Burn Down Chart Sprint 4.	60 |
| Figure 54 |  Sprint 4 Tasks	60 |
| Figure 55 |  Keyboard Code Snippet.	61 |
| Figure 56 |  Functional Requirements Test Sprint 4.	62 |
| Figure 57 |  Non-Functional Requirement Tests	62 |
| Figure 58 |  Holding Chess Piece	63 |
| Figure 59 |  8 Queens Solved |
| Figure 60 |  8 Queens Solved with Text	64 |
| Figure 61 |  8 Queens Invalid Solution	64 |
| Figure 62 |  Grid Screenshot	65 |
| Figure 63 |  Grid Screenshot Lost State |
| Figure 64 |  Grid Lost Text	65 |
| Figure 65 |  Home page	66 |
| Figure 66 |  8 Queens Leader board	66 |
| Figure 67 |  2048 Leader Board	67 |
| Figure 68 |  About Page	67 |

# Introduction
In the past few years VR has become more and more popular, in both popular culture and in areas like the gaming industry. It has also seen use in both medical fields and in education. Some examples of VR appearing in popular culture include a very recent example, a movie called Ready Player One, originally adapted from a book written by Ernest Cline (Cline et al., 2011). There have also been other examples of VR like technology appearing in books such as in Virtual Light (Gibson et al., 1993) written by William Gibson. Both books will be further explained in the research section of the report. Certain concepts exist surrounding VR like the metaverse, this will also be explored further in the research section of the report. 
There are currently many headsets that exist in the real world outside of fiction such as the HTC Vive (HTC Vive) and Oculus Quest 2(Meta). These headsets have their own benefits and drawbacks, but the one that we will be concentrating on in this project is the Oculus quest 2. Developed by Meta, formally known as Facebook. This headset has become very popular, due to its price and plethora of features. 
Aims and Objectives
1.	Research VR, its concepts, applications, and associated technologies.
2.	Research game engines and web framework to help create the game.
3.	Identify appropriate requirements for the game.
4.	Identify an appropriate methodology to use when developing the game.
5.	Create a fully working VR Puzzle Game for the Quest 2:
•	Create the 8 Queens puzzle.
•	Create 2048 puzzle.
6.	Create a website to display score data in leader boards for both puzzles.
7.	Create a REST API to allow communication between the headset and webserver.
8.	Evaluate the project, including the report and the developed program.
This report documents the research, design and development of a VR game that involves puzzles. More specifically the 8 Queens Puzzle and the 2048 Puzzle. The 8 Queens puzzle involves placing a set of 8 queens on a chessboard in such a way that none of them can attack each other. 2048 is a game in which a user moves and merges cubes to make a 2048 cube. Merging involves adding two identical cubes together so a 2 cube and a 2 cube to make a cube with the cube of the two previous cubes, in this example a 4 cube will be created. The game is won by adding two 1024 cubes together to make 2048 and the game is lost by have no moves or merges to make.
 The game will be created using a game engine, in this case Unity, the language of choice is C#. 
Also, a website will be developed alongside the game to display scores submitted by players in a leader board for each of the puzzles. 
The main motivation to undertake this project is, VR as a platform has a lot of potential, in terms of its both future and current applications. As a technology it has come very far in such a short period of time, with the technology developing rapidly in such as short span of time. This project is a method in which we can explore this rising technology further.

# Chapter outline
(Chapter 1) Literature Review
The literature review contain research done at the beginning of the project, the research will include VR research on, its concepts, applications, and associated technologies. Research will also include a look at game engines and web framework that will be used to create the game.
(Chapter 2) Requirements
The requirements will contain two tables, the first being functional requirements, which involve functions of the system and the second being the non-functional requirements, which involve constraints on certain functionality.
(Chapter 3) Methodology
The methodology section will detail the development methodology that will be used during the development process in this case Agile Scrum, it will include and outline sprints and the tasks that will be likely undertaken during them.
(Chapter 4) Design
The design section will contain a list of design diagrams, including but not limited to, class diagrams, use-case diagrams, flowcharts, and UI design.
(Chapter 5) Implementation
This chapter will detail the implementation process, brief explanations of key code written during each sprint with screenshots of said code.
(Chapter 6) Project Evaluation
This is where the whole project is evaluated and reflected upon.
(Chapter 7) Further work and Conclusions
The section details further work to be undertaken in the future and final conclusions on the project.

![Figure 1VR Game and Headset Image](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure1.jpg)
##### Figure 1 VR Game and Headset Image

# Literature Review
## Chapter Introduction
This chapter of the report contains my research on VR technologies.
## Introduction to VR

There have been many representations of VR in the media, in the form of books and films. 
VR in past and present media
The first book, William Gibson’s Virtual Light, in summary, is about a pair of glasses which allow a person to view information by feeding it into that person’s optic nerve (Gibson et al., 1993). Ready player one is a dystopian future in which people use virtual reality to escape the tough reality of life. The VR world they go to is called the Oasis (Cline et al., 2011). 

## The Metaverse
The Metaverse can be described as a 3-dimensional virtual universe (Dionisio, III, Gilbert, 2013). This however differs from the concept of cyberspace that represents all shared online and virtual space across all dimensions (Dionisio, III, Gilbert, 2013). There are multiple different versions of the metaverse, the first example is an enlarged virtual world, and another is a large network of virtual worlds (Dionisio, III, Gilbert, 2013). The second example can be seen in ready player one. The virtual universe is split into multiple virtual worlds (Cline et al., 2011) that players can explore interact with, they are able to travel to other worlds inside the universe. 
All these examples show how virtual reality has been represented over the years. However, today the technology is far more primitive compared with the previously given fictional examples.
To illustrate how VR works in reality, one could look to early examples of VR headsets and VR like devices that have previously been developed in the past.
Early Virtual Reality Headsets and Head Mounted Displays
## Sensorama
An early example of a VR headset was the Sensorama( Craig, R. Sherman,  D. Will, 2009). This piece of literature describes early VR technology. “The Sensorama was the brainchild of cinematographer and inventor Morton Heilig”( Craig,Sherman,Will, 2009).  As described by the writer of this literature the system “was lacking a major component of the modern virtual reality system: response based on user’s actions”( Craig,Sherman,Will, 2009). Early headsets were very basic, this simply means that the system did not allow a user’s actions to have any impact on the virtual world unlike modern day headsets that allow a user to interact with the virtual world using controllers or in some cases the user’s hands. 
## Myron Krueger’s Videoplace
“Krueger’s artificial reality provided a second-person view of a virtual world in which participants could watch themselves within the world” ”( Craig,Sherman,Will, 2009). Craig, R. Sherman literature also talks about another early VR headset such as Myron Krueger’s Video Place. This headset gave the user a “second-person point of view” of themselves. No games could be played on this headset and the user did not have any devices or other sensors attached to their body ( Craig,Sherman,Will, 2009). Unlike some modern-day VR headsets that use full body tracking that require sensors to be placed all over the user’s body including head, legs and arms depending on what degree of tracking you want. In terms of features, from what is conveyed in the paper, these headsets are very limited in terms of functionality and are nothing like the headsets we have today.
## Key elements of VR in 2003
There are a few key elements of VR that have been identified in the past, this information will help with the creation of the puzzle game and help to mitigate any mistakes that could be made during design.
The paper written by Sherman details four key elements of virtual reality. 
A virtual world is the context of a medium (Sherman, Craig, 2003). In the case of this project this would refer to the game world. This will also tie into the writers next point regarding immersion. This is because a virtual world, if created correctly helps give a sense of immersion and improves the experience of the player.
It must have immersion, into a different reality or another point of view (Sherman, Craig, 2003). It must have both Physical and mental immersion, this can be split into two, mental immersion can often be referred to as having a mental presence within the world (Sherman, Craig, 2003) and physical immersion is when, a body enters into a medium (Sherman, Craig, 2003). Both points apply today, If the VR experience will be greatly affected if immersion is broken, so during development extra attention must be paid to this as one of the major causes of breaking immersion is frame drops whilst playing a VR game, therefore it is imperative that my code is optimised.
It must have sensory feedback, “VR allows participants to select their vantage point by positioning their body and to affect events in the virtual world” (Sherman, Craig 2003). This refers to moving your arm for example in the VR worlds and have it match up with the real world. This is a very good point and will be taken into consideration, the main method of movement, and interaction in with the Quest 2 is using the controllers. This does provide a degree of sensory feedback, referred to in this point by the writer.
The final key element according to the writer is, Interactivity. “For virtual reality to seem authentic, it should respond to user actions, namely, be interactive” (Sherman, Craig, 2003). In the case of current day VR this could be seen to be tied to the act of a user performing an action and getting a reaction. For example, a player pushes a box with their in-game hand and the box moves back in response. This also could be seen to further immersion which ties into the writers second point.
## VR Possibilities outside of gaming
### VR in Education
There are many applications for VR outside of gaming for entertainment. There also are applications for VR in the educational sector, for example in the research paper by (Holly, Pirker, Resch, Brettschuh, Gutl, 2021, pp.107-119), the paper shows how learning environments like Marroon (GameLabGraz), are environments designed to provide an interactive learning environment for students and allows students to perform experiments in a VR environment. The experiment that the researchers performed consisted of testing several factors for the game, Immersion, and engagement, learning value from both the teachers and learner’s respective perspectives (Holly, Pirker, Resch, Brettschuh, Gutl, 2021, pp.107-119). It would be useful to utilise some of these testing criteria namely immersion in this project as found in other papers during this literature review, immersion is a factor considered as one of the key elements of VR. In summary, the response was positive in all areas of study. Most students and teachers were happy with the level of immersion and engagement, and on average most students and teachers concluded that it had a high learning value (Holly, Pirker, Resch, Brettschuh, Gutl, 2021, pp.107-119). 

### VR in Medicine 
VR also has applications in medicine as out lined in this study by (Pourmand, Davis, Marchak, Whiteside, Sikka, 2018, pp.1-6). The study delves into how VR can be used to distract patients from many types of pain, including acute pain (Pourmand, Davis, Marchak, Whiteside, Sikka, 2018, pp.1-6). It concluded that VR has become an important option for helping with pain management and how the evidence in said study shows how VR can be effective at distracting patients from many types of pain including acute and chronic short-term (Pourmand, Davis, Marchak, Whiteside, Sikka, 2018, pp.1-6). The study references a paper that goes on to run some experiments on hospitalized patients, it was noted in the study that patients, had a significant drop in pain by around 24% in the VR group of patents compared to the 13% drop in pain in the control group (Tashjian, 2017, pp.e9). 
## Game engines
The Wikipedia definition of a game engine is as follows, "A game engine is a software framework primarily designed for the development of video games, and generally includes relevant libraries and support programs. The "engine" terminology is like the term "software engine" used in the software industry" (Wikipedia, 2021). 
For further clarification this is what is defined as a game engine in comparison between famous Game Engines and Eminent Games journal article. Game engines are sets of tools that allow a programmer to, perform game related tasks like interpretation and physics related tasks and for focusing on the niceties that make the game great(Mishra, Shrawankar, 2016, pp. 69). 

### ASSESSMENT OF ENGINES ON PERFORMANCE ASPECTS

| Game Engine  |  Platforms | Language Support | AI Engine  | Physics Engine | Forward Compatibility | Backward Compatibility |
| ------------- | ------------- | ------------- | ------------- | ------------- | ------------- | ------------- |
| CryEngine 3  |  Win, X360, PS3, Wii U | C++, Visual Script, Lua  |   Lua-driven AI | Soft body  |  No |  Yes |
|  Hero Engine | Win  |  Hero Script | Hero Script  |  AIseek | PhysX  |  Partial | Yes |
|  Source 2 Engine | Win, Mac, Xbox 360, Wii, Linux, Android  |  C++ |  AI Director  |  Ipion | No  |  Partial |
|  Unity 4 |  BlackBerry, Win Phone, Win, OS X, Android, iOS, Apple TV, PS3/4, PS Vita, Xbox 360, Xbox One, Wii U, Wii | C#, JavaScript, Boo |   RAIN  | PhysX  | Partial| Yes |
| Unreal 4 Engine  | Windows, OS X Linux, Xbox 360/ One, PS3/4, Wii U, Android, iOS, WinRT, PS Vita  | C++, C#, GLSL, CG, HLSL  |  Kynapse  | PhysX  | Partial  |  Yes  |
| Vision Engine 8  |  Windows, Xbox 360, PS3, Wii, Wii U, iOS, Android, Win Phone, PS Vita | C++  |  Kynapse  |  Bullet, ODE, PhysX | No  |  Partial |

Figure 2 (Mishra, Shrawankar, 2016) ASSESSMENT OF ENGINES ON PERFORMANCE ASPECTS

As can be seen from figure 2 CryEngine and Hero Engine don’t support nearly as many platforms as the other four. Furthermore, Hero engine does not support any of the more popular programming languages like C++ or C#. In addition to this Hero Engine, Unity and Unreal Engine only have partial forward compatibility. 
Unreal Engine has Blueprint Visual Scripting” (Chu, Zaman, 2021, pp.188). It was created to support the workflow of designers and artists by giving them access to tools normally only accessible to programmers (Chu, Zaman, 2021, pp.188). Blueprints is object oriented visual programming system which is used to create gameplay elements (Chu, Zaman, 2021). 
Unity has many functionalities, including animation, scenes, object generation, lens control and these features are controllable by a c# program (Tsai, Jhu,Chen, Kao, Chen, 2021, pp.1401 - 1417). Unity also has plugins that can give it features like blueprints, a recent example of plugins that allow Unity to obtain this functionality include, FlowCanvas, Playmaker, Bolt and Amplify shader editor (Chu, Zaman, 2021, pp.188). 

## Tracking technology
### Xbox Kinect 
Oculus uses state of the art tracking technology that developed from a massively successful technology known as the connect Kinect, was an early example of SLAM being used. Originally developed at Microsoft Research Cambridge, and then productized by the Xbox team at Microsoft. The Kinect is made up of 3 devices, the first being Depth sensor, the second being an RGB camera and lastly a 4-microphone array, these all give 3D full body tracking, facial recognition, and voice recognition (Zhang, 2012, pp.4-12).  The Kinect senses depth using its IR camara and IR projector which make up the depth sensor (Zhang, 2012, pp.4-12). This works by the IR projector projecting dots in an area, then if the dot in said image matches dots in the known dot pattern produced by the projector it is possible to rebuild it using 3D triangulation (Zhang, 2012, pp.4-12). 

![Figure 3 (Zhang, 2012, pp.4-12) Depth Map](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure3.jpg)
##### Figure 3 (Zhang, 2012, pp.4-12) Depth Map
Here is a depth map produced by the Kinect, the darker the grey the closer the object (Zhang, 2012, pp.4-12). This can then be used in conjunction with other techniques to track a person's body, Figure 3 gives the general outline of this.

![Figure 4 Body tracking (Zhang, 2012, pp.4-12)](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure4.jpg)
##### Figure 4 Body tracking (Zhang, 2012, pp.4-12)
From the depth image body part distribution is inferred, this is done per pixel as can be seen from the second part of Figure 4 above. (Shotton, Fitzgibbon, Cook, Sharp, Finocchio, Moore, Kipman, Blake, 2011). Local modes of this are then hypothesized to provide a good quality proposal for the joints in 3 dimensions, this all can also be done for multiple users(Shotton, Fitzgibbon, Cook, Sharp, Finocchio, Moore, Kipman, Blake, 2011).
## SLAM Overview 
SLAM stands for Simultaneous Localization and Mapping (MathWorks). There are many applications for SLAM including, using it with autonomous vehicles to produce maps of environments and pinpoint a vehicle in that map all at the same time (MathWorks). They can allow the vehicle to map environments and avoid obstacles and path find in that environment (MathWorks). 

There are many methods of SLAM, the first is Visual SLAM. This type of SLAM utilises images obtained from cameras and other sensors. There are two main types of this version of SLAM, Spare methods that match features of images at then utilise an algorithm like ORB-SLAM and dense methods that use algorithms like LSD-SLAM (MathWorks).
The second method of SLAM is LiDAR SLAM this version of SLAM usually uses some form of distance sensor, for example a laser sensor (MathWorks).
Both types of SLAM have advantages and disadvantages. LiDAR is not affected by light level and its angular view is quite large. Unfortunately, however, on a large-scale LiDAR is not as viable in certain situations as it can get very expensive (Huang, Zhao, Liu, 2019). Visual SLAM, however, does not do so well in low light conditions and in low texture environments (Huang, Zhao, Liu, 2019). Visual SLAM can usually be implemented at a much lower price as RGB-D cameras, used to implement it can be obtained quite cheaply (Taketomi, Uchiyama, Ikeda, 2017).

## Offline-SLAM for Map Acquisition a simple example of SLAM
There are many ways to use SLAM, a simple example of SLAM involving robots is as follows; the first phase is map learning phase. As a robot moves through an environment the sensor data is obtained, and labels are given such as place names. After this the SLAM algorithm creates a map from the data to robot collected. This data can then be used to plan paths and localization and so on (Frese, Wagner, Rofer, 2010, pp.191-198). 

## Oculus and SLAM 
SLAM tracking technology is a tracking method utilized by the Oculus Quest and Rift S (Hesch, Kozminski, Linde, 2019). On both these headsets there are three major types of sensors to work out the VR headset’s location, room aspects like where the floor is and track controllers with reference to a 3D map of the space around it that is generated continuously (Hesch, Kozminski, Linde, 2019). The three sensors include, IMUs that track the headsets orientation and position, cameras to generate a 3D map of the room, and infrared emitters mitigating the controller drift cause by having a lot of the IMU sensors (Hesch, Kozminski, Linde, 2019). 

## Application Programming Interface
APIs are powerful tools that can be used in this project, to break down what an API is, we must first learn what it stands for. It stands for Application Programming Interface(Uzayr, 2016), and is a way in which you can hide the component specification from the actual implementation or the user of said components (Souza, R.B, F, 2009). One reason for doing this is it separates the modules in to public and private modules. The public module being the API, and the private one being the implementation of said API. Any changes made to the private module do not impact the public module (Souza, R.B, F, 2009). Using APIs allows a company to give a developer functionality without said developer needing to know how it works (Souza, R.B, F, 2009).
## REST API
To give context, using REST is one way we could transmit data between a virtual reality head set and a webserver, in this case it would be the transmission of score data etc. To summarise, a REST API is a type of application programming interface that conforms to a set of constraints (Kotstein, Justus, 2021). Rest APIs have two aspects, the first is that they are a type of architectural style that can dictate how distributed hypermedia systems are built and used like the World Wide Web (Kotstein, Justus, 2021). Furthermore, this journal article goes into further detail for example the second aspect it gives is that REST is like a guide that formalises how web components like URLs and http for example should be used when creating new applications that utilise them.
## Web frameworks in python
### Django
Django is a collection of python modules designed for building web applications (Yudin et al., 2020). The Django framework can map URLS to methods, it can also render HTML webpages and it can handle cookies, session, and web security and has a REST framework (Yudin et al., 2020). Which handles all the essential of the REST API such as serialization and converting data to JSON (Yudin et al., 2020). This will be very useful for the project as this is a very reliable method of communicating between the headset and server and it comes with Django by default, so it is very likely to be tested thoroughly and a very reliable framework. Django can also support things like relational databases using object-relational mapping (Yudin et al., 2020). It has a build in database solution, known as SQLite (Yudin et al., 2020). SQL lite is a public domain software package that gives its user a relational database management system(Kreibichet et al., 2010) This is another important feature of Django that could be utilised in this project as user data will need to be stored, such as the user’s username and score. It also contains tools that allow easy authentication and authorization (Yudin et al., 2020). It is also widely used by the following websites, YouTube, Spotify, and many others (Yudin et al., 2020). It’s popularity with large technology companies is a good indicator of its quality and is another good reason to use it within the project.
### Flask
Flask is a small framework and is small enough to be called a micro framework (Grinberg et al., 2018). Flash was designed to be extendable, and you can pick and choose what you need to avoid bloat (Grinberg et al., 2018). Flash has a few dependencies, including the routing, debugging and web server gateway (Grinberg et al., 2018). However, it does not have support for accessing databases, validating web forms, or authenticating users (Grinberg et al., 2018). This is an issue for this project as we require a database to store score data from the game, also a way to authenticate users. After reviewing this book, due to flasks lack of features compared with Django, it is not a good idea to use this within the project, Django is by far the better choice due to its popularity and reliability and plethora of features and frameworks. 
## WebSocket Scripting
A WebSocket is a transfer control protocol for web applications. It provides connection in both ways meaning data can be sent to and from a server and client. However instead of connecting to an internet host and a port, it facilitates connections using URLS instead. To establish a connection between a server and client the protocol is changed from HTTP to WebSocket protocol. Once a connection is established messages can be sent back and forth between the client and the server (Lubbers, Albers, Salim,2011). This is one way in which information could be sent between the VR headset and a webserver that stores and displays score data in a database. However, the messages only need to be sent in one direction as, no messages are going to be sent to the client from the server. Therefore, using this method of data transfer not ideal for this project.

## Examples of VR puzzle games 
By looking at some high-quality games we can see what is expected from a high-quality VR game.
### Tetris® Effect: Connected
The first game we are going to look at is called Tetris® Effect: Connected. In summary, it is a game where the objective is to complete rows at the bottom of the screen. This is done by rotating different shapes to form these rows (Monstars Inc. Resonair and Stage Games, 2020).

![Figure 5 The image provided is from the game Tetris® Effect: Connected (Monstars Inc. Resonair and Stage Games 2020)](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure5.jpg)
##### Figure 5 The image provided is from the game Tetris® Effect: Connected (Monstars Inc. Resonair and Stage Games 2020)
As can be seen from the image above (Figure 5) there are multiple game play elements, a scoring system, levels and elements in the scene, that is the use of vibrant and interesting colours. Some of these elements would be useful to use in the VR puzzle game, this is because they create interesting and beautiful game play to immerse the user in the game.

![Figure 6 The image provided is from the game Tetris® Effect: Connected (Monstars Inc. Resonair and Stage Games 2020)](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure6.jpg)
##### Figure 6 The image provided is from the game Tetris® Effect: Connected (Monstars Inc. Resonair and Stage Games 2020)

### I Expect You To Die 2
The second game to analyse is called I Expect You to Die 2. In summary this game involves solving a selection of puzzles, the puzzles are split into missions for the player to complete where the player plays as an agent trying to defeat an enemy called Zoraxis (Schell Games 2021).

![Figure 7 The image provided is from the game I Expect You To Die 2 (Schell Games 2021)](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure7.jpg)
##### Figure 7 The image provided is from the game I Expect You To Die 2 (Schell Games 2021)

![Figure 8 The image provided is from the game I Expect You To Die 2 (Schell Games 2021)](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure8.jpg)
##### Figure 8 The image provided is from the game I Expect You To Die 2 (Schell Games 2021)

The gameplay above shows (Figure 7 and 8) an intricate and immersive world with high levels of detail, this level of detail, is important for immersion. As can be seen from both images (figure 7 and 8) the user is able to interact will objects using there in game hands, picking objects up, looking at them closely to solve the puzzle, read instructions and other such actions. All these small features create a sense of immersion in the world the author has created, as is the nature with VR, if the game is implemented correctly, it can make a player feel intertwined with the story and provide a real sense of emergency to solve problems that occur, like with the image above, the user is required to disarm a bomb. 
If all these elements are observed, it is possible to create an immersive and detailed world for a user to enjoy. These key elements will likely be very useful to incorporate into this project. The key elements to take away from these games, is allowing a user to interact with the world as much as possible.

# Methodology
## Chapter Introduction
This section of the report details the methodology that will be used to develop the product.
## Selected Methodology
To produce the VR game, the best methodology to use is an agile development process. Agile methods of software developments use an iterative and incremental approach to software development (Kumar, Bhatia, 2012). The type of agile method of development we have chosen is called, the scrum method. A scrum consists of sprints which are individual iterations that can last anywhere from two to four weeks each (Kumar, Bhatia, 2012). 

Planning for a sprint starts at the beginning of a sprint and the end of the sprint is used to determine what can be delivered in the next sprint (Hron, Obwegeser, 2021). A review of the sprint is then conducted at the end of the sprint to show the outcome of said sprint to the customer and to obtain feedback for the next sprint, feedback will then be used in the next sprint (Hron, Obwegeser, 2021).

Now knowing the information presented above, the game will be developed during two weeklong sprints for each stage of development.

Project setup Sprint 0: (9th Jan – 11th Jan)

This sprint will be two days long. In this sprint, basic project setup will be completed. Such as importing all libraries and packages that will be needed include Oculus integrations, creating a very basic prototype application to test all packages are working correctly and everything is setup and imported correctly.

Sprint 1: (16th Jan – 22nd Jan)

Basic game development of the puzzles will be done in this sprint. The two puzzles giving a week to produce each puzzle during the sprint I.E 8 queens puzzle and so forth. This will then be tested according to the requirements of the system. 

Sprint 2: (23rd Jan – 29th Jan)

Further game development will be done here, including the creation of the puzzle 2048.

Sprint 3: (4th Feb – 10th Feb)

Database setup will be performed in this sprint. The website will also be further developed. Testing to make sure data is stored correctly and is sent by the headset will also be done here.

Sprint 4:(11th Feb – 17th Feb)

User interface will be developed here according to the requirements specification. This will be tested along with the rest of the project to make sure everything is working correctly.

Sprint 5:(18th Feb – 25th Feb) (If needed)

This sprint will consist of making sure everything is working, correcting any bugs that may have occurred and gone unnoticed during the systems development. Final testing of the system will also be done here, making sure the system properly satisfies all requirements. 

# Requirements
## Chapter introduction
This section of the report will contain thirty-seven requirements in total. Thirty Functional and ten non-functional requirements. 

### The Requirements

The Requirements are identified with an ID and the type of requirement in said ID. For example:

-VR means a requirement related to the VR game itself.

•	-VR-8Q is a VR requirement relating to 8 Queens

•	-VR-2048 is a VR requirement relating to 2048

-WS means a requirement relating to the website.

•	-WS-8Q is a website requirement relating to 8 Queens

•	-WS-2048 is a website requirement relating to 2048

-VR/WS means it is a requirement that relates to both.

•	-VR/WS-8Q is a requirement relating to both VR, the website and 8 Queens

•	-VR/WS-2048 is a requirement relating to both VR, the website and 2048

### MoSCoW
Moscow stands for must have, should have, could have, won’t (Asghar, Bhatti, Tabassum, Shah, 2017, Page 303-313).

Must have – The system must have this, and this is the highest priority.

Should have – The system should have this, this is mid priority.

Could have – This system could have this, however it is not necessary.

Won’t have – This could be added in the future, but it won’t have this at this given time.

The requirement specification column gives more detail into the requirement and why it is necessary.

## Functional Requirements:

|Requirement No.|Requirement|Priority|
|:----|:----|:----|
|FR1-VR-8Q|User must be able to pick up the chess piece using the controllers.|Must|
|FR2-VR-8Q|Chess board must be able to detect the location of the queens.|Must|
|FR3-VR-8Q|Algorithm must be able to determine if an 8 queens’ solution is valid.|Must|
|FR4-VR-8Q|Timer that counts and starts when the user enters the puzzle level.|Must|
|FR5-VR-8Q|In the 8 Queens algorithm the score must be calculated using the time the user takes to solve the puzzle. | Must|
|FR6-VR-8Q| After 8 queens puzzle solved, the user is notified and taken back to menu in 5 seconds. | Must|
|FR7-VR-2048|2048 Algorithm must move cubes in each direction when the corresponding button is clicked.|Must|
|FR8-VR-2048| 2048 Algorithm must merge cubes when there are of the same value.|Must|
|FR9- VR-2048|Must check to see if the user has lost the game before every move the user makes.|Must|
|FR10-VR-2048|In the 2048 algorithm when two cubes are merged and added together to make 2048 notify the user they have won.|Must|
|FR11-VR-2048|In 2048 the algorithm, the user must gain 10 points with every cube merge they make.|Must|
|FR12- VR-2048|After the user has either lost or won, a button must appear to allow them to travel back to the main menu.|Must|
|FR13-VR-Menu|Button on the menu to take the user to the 8 queen’s puzzle.|Must|
|FR14-VR-Menu|Button on the menu to take the user to the 2048 puzzle.|Must|
|FR15-VR-Menu|In game keyboard to allow a user to enter their name.|Must|
|FR16-VR/WS-8Q|8 Queens - Website must receive score data and username after the puzzle is solved.|Must|
|FR17-VR/WS-2048|2048 – Website must receive score data and username if the user loses.|Must|
|FR18- VR/WS-2048|2048 – Website must receive and username score data if the user Wins.|Must|
|FR19-WS|The website must have a working navigation bar to take a user to the 4 pages.|Must|
|FR20-WS|On the 8 Queens leader board page score and usernames should be pulled from the database and displayed on the page.|Must|
|FR21-WS|On the 2048 leader board page score and usernames should be pulled from the database and displayed on the page.|Must|
|FR22-VR|Help could be provided if the user is struggling to solve a specific problem.|Should|
|FR23-WS|Allow a user to click a link to download the game.|Should|
|FR24-VR|Be able to move around and interact with the world using hand tracking.|Could|
|FR25-VR|Data could be stored locally on headset such as username and score data and pulled back into the game, when the game is opened.|Could|
|FR26-WS|A login system that allows a user to enter the website.|Could|
|FR27-WS|Users can edit and delete their high scores if necessary once they are logged in.|Won’t|
|FR28-VR/WS|The user won’t be able to view the leader board data within the headset/game.|Won’t|
|FR29-VR|Allow full body tracking, allowing the user to use all limbs when playing the game.|Won’t|
|FR30-VR|Multiplayer allowing multiple users to join a session and solve puzzles with each other.|Won’t|

##### Figure 9 Functional requirements.

### Requirements Analysis for functional requirements:
FR1-VR-8Q - Necessary for solving the puzzle as it allows the user to place the chess pieces on the chess board, furthermore during research, in the key elements of VR 
section it was discovered that interactivity was an important factor in VR experiences(Sherman, B.Craig, 2003). Therefore, this required to ensure this.

FR2-VR-8Q - Necessary, as need to know where the chess pieces are, as their positions will be used to determine if the solution given by the user is valid.

FR3-VR-8Q - Necessary for a user to see if they solved the puzzle or not.

FR4-VR-8Q - Necessary to determine a user’s score for 8 queens. 

FR5-VR-8Q - Necessary to allow the user to see how well they did compared to others on the leader board.

FR6-VR-8Q - Necessary to allow the user to be removed from the level after the puzzle is complete.

FR7-VR-2048 - When the user clicks a directional button with the controllers, the cubes will move in the direction indicated by said button.

FR8-VR-2048 - Necessary for the game to work. When two cubes are the same, i.e., 2 and 2, they are added together to produce a new cube, in this case, 4.

FR9- VR-2048 – Necessary as it ensures the moment the player loses, they are notified.

FR10-VR-2048 - Necessary to allow the user to win the game. When two 1024 cubes are merged, the player wins.

FR11-VR-2048 – Necessary as this is a method of keeping score, the more merges they make, the higher their final score will be.

FR12- VR-2048 - Necessary to allow a user to travel back to the main menu after they have completed the puzzle.

FR13-VR-Menu and FR14-VR-Menu - Necessary to travel to the 8 queen’s puzzle/ Necessary to travel to the 2048 puzzle. This will be in the form a virtual button that the user can manually press which further ties in with the paper (Sherman, B.Craig, 2003) as adding this method of moving between puzzles will provide more user interactivity with the VR world around them.

FR15-VR-Menu - Necessary to allow the user to input their name, so it can be used to display with their score on the website. This data will be sent to the webserver using the REST API created using Django libraries discovered during research.

FR16-VR/WS-8Q - This will use a REST API to transmit data between the headset and the webserver in a JSON format. Necessary to allow score data to be displayed on the 8 queens leader board.

FR17-VR/WS-2048 and FR18- VR/WS-2048 - This necessary as we will need to use a REST API to transmit data between the headset and the webserver in a JSON format this will be done using Django’s built-in REST library (Yudin et al., 2020) discovered during research.  After the player wins, there score data will need to be sent to the web server to be displayed in the 2048 leader board. The user still has a score value even if they lose that is why this requirement is necessary to allow score data to be displayed on the 2048 leader board.

FR19-WS - The Website will have a working navigation bar to take the user to the 4 pages, Home, 8 Queens leader board and about.

FR20-WS - On the 8 Queens leader board page score data and player usernames should be displayed in the leader board table, highest to lowest.

FR21-WS - On the 2048 leader board page score data and player usernames should be displayed in the leader board table, highest to lowest.

FR22-VR - The game will provide a hint if a user does not make a move within a given time frame

FR23-WS - When the user clicks a link, they are taken to a place where they can download the game to play.

FR24-VR - The user should be able to make a hand gesture and move around the world freely and interact with the world using their hands. This could further immersion. Immersion is one of the key elements of VR discussed further in this paper (Sherman, B.Craig, 2003).

FR25-VR - Store games save data on locally on the headset. Then pull data back into the game when game is loaded. This could be used to avoid a user having to re input their username each time they want to play. 

FR26-WS – Could be used to facilitate features such as the feature in requirement FR27-WS. It would provide sufficient security to allow this to be possible, as found in 
research (Yudin et al., 2020), Django comes with this functionality out of the box, so it could be used in this project at a later date.

FR27-WS - This is an extra feature that could be added at a later date. Allow users to manage their leader board data, I.E delete, change their name etc

FR28-VR/WS - This is an extra feature that could be added at a later date. The user can pull the leader board high score data from the website and view it within the game.

FR29-VR - This is an extra feature that could be added at a later date. Allow full body tracking for input could be used to further immersion, which was discovered to be an important factor during research section key elements in VR in 2003(Sherman, B.Craig, 2003).

FR30-VR - Allow multiplayer – This is an extra feature that could be added at a later date. It would allow users to solve puzzles in a cooperation with other users.

## Non-functional Requirements:

|Requirement No.|Description|Priority|
|:----|:----|:----|
|N-FR1|A user interface is necessary to allow users to select different puzzles.|Must|
|N-FR2|The game must be maintainable enough to allow for the addition of new puzzles.|Must|
|N-FR3|The game must be able to run at a reasonable frame rate on the quest 2, 60fps minimum.|Must|
|N-FR4|Good maintainability is necessary to allow updates to the system.|Must|
|N-FR5|The game should be able to check the validity of a solution without any long durations of frame rate drops.|Must|
|N-FR6|Multiple users are going to need to access the website at one time. The website should be robust enough for this to be allowed.|Must|
|N-FR7|There should be minimal delay when sending a message from the headset to the webserver.|Should|
|N-FR8|The game should also be available for headsets that require to be connected to a desktop machine.|Could|
|N-FR9|If a user of the website does not have the game, they do not have access the website|Could|
|N-FR10|The website must not be down for long periods of time.|Wont|

##### Figure 10 Non-functional requirements.

### Requirements Analysis for non-functional requirements:

N-FR1 - The game must have a way to select between different puzzles in the form of a UI.

N-FR2 – Must Allow for the addition of new puzzles, it must be flexible to allow for future work to take place.

N-FR3 - Must run on the Oculus Quest 2, Necessary as this is the target platform for this project.

N-FR4 - Must be simple to maintain both quest 2 app and website. Splitting programs into Classes and functions etc must be observed to prevent the code from being hard to maintain.

N-FR5 - Be able to check a puzzle solution within 1 second as any stuttering or frame rate drops caused by log calculations could be uncomfortable for the user.

N-FR6 - Multiple users must be able to use website at the same time.  This is a basic requirement that all websites and web apps must have.

N-FR7 - Be able to send data to the website from the headset and update it within 1 second.

N-FR8 - Cross compatibility with other headsets, the Oculus rift S for example.

N-FR9 - Users who do not own the game should not be able to access the website.

N-FR10 - The website would not be down for more than 5 minutes during a fault.

# Design
## Introduction to Chapter 
In this chapter we will go over the design of the system. This will include a selection of diagrams of the systems classes, use cases, architecture, database design and UI design.         
## High Level Design
### Architecture diagram

![Figure 11 Architecture Diagram.](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure11.jpg)
##### Figure 11 Architecture Diagram
The above diagram (Figure 11) shows the system architecture. It models how the Oculus quest 2 will send data to the server using a REST API and how that data will be viewed using the clients web browser.

### Use-Case Diagram Website (Django)
![Figure 12 Website Use Case Diagram.](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure12.jpg)
##### Figure 12 Website Use Case Diagram.
This is a use-case diagram for the website (Figure 12). This use case diagram describes a given users interactions with the website itself and how they view different webpages. Users in this case, includes people who play the game, and general users who do not necessarily own the game but wish to view leader boards for a given puzzle, and the about and home page. 

### Use-Case diagram puzzle game VR (Unity)
![Figure 13 VR Game Use Case Diagram](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure13.jpg)
##### Figure 13 VR Game Use Case Diagram
This is a use case diagram for the VR game (Figure 13). This use case diagram describes the player actor’s interaction with the VR game. The goal of this use case is to send score data to the website and return to the main menu, after the chosen puzzle have been completed. The data is sent to the webserver. 

### Database design
![Figure 14 Database Design](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure14.jpg)
##### Figure 14 Database Design
The above diagram (Figure 14) is the database design for the website. The database will have two tables, one containing score data for the 8 queens puzzle and the other for 2048. All records in both tables will contain a username and a score value.

### Website Design

#### Home Page
![Figure 15 Home Page UI Design](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure15.jpg)
##### Figure 15 Home Page UI Design
Above UI mock-up (Figure 15) shows the design of the home page.

### Eight Queens Leader board Design

![Figure 16 8 Queens Leader Board Page Design](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure16.jpg)
##### Figure 16 8 Queens Leader Board Page Design
Above UI mock-up (Figure 16) shows the design of the 8 queens leader board page. The page will contain a leader board, some text to describe the page and an image, the image will be a screen shot of the 8 queen’s puzzle.

### 2048 Leader board Page design

![Figure 17 2048 Leader Board Page Design](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure17.jpg)
##### Figure 17 2048 Leader Board Page Design
Above UI mock-up (Figure 17) shows the design of the 2048 leader board page. The design of this page will be like the design of the 8 queens leader board page (Figure 16). However, its leader board will contain 2048 score data, the image will be a screenshot of the 2048 puzzle in game.

### About Page Design

![Figure 18 About Page Design](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure18.jpg)
##### Figure 18 About Page Design
Above UI mock-u p (Figure 18) shows the design of the about page. The page will contain images of the puzzle and a guide on how to play each puzzle, and other general instructions pertaining to the game, like how to input a user’s username.

## Low Level Design 

### Class Diagram puzzle vr game (Unity) Part 1

![Figure 19 VR Game Class Diagram Part 1](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure19.jpg)
##### Figure 19 VR Game Class Diagram Part 1
This diagram (Figure 19) contains classes and the relations between them relating to the 8 queen’s puzzle. The class POST will be used to send data to the web server and the class KeyBoardMain class will be used by queensGame logic to obtain the username provided by the user in the main menu.

### Class Diagram puzzle vr game (Unity) Part 2

![Figure 20  VR Game Class Diagram Part 2](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure20.jpg)
##### Figure 20  VR Game Class Diagram Part 2

This part of the class diagram (Figure 20) contains classes that will be used by the 2048 puzzle and the relationships between them, as with the 8 queens puzzle the POST will be used to send score data to the web server and the KeyBoardMain class will be used to obtain the username inputted by the user in the main menu. Both classes are shared by both puzzles.

### 8 Queens flowcharts:

#### PossibleMovesXAxis function flowchart.

![Figure 21 PossibleMovesXAxis function flowchart](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure21.jpg)
##### Figure 21 PossibleMovesXAxis function flowchart
Figure 21 shows a flowchart that describes how the PossibleMovesXAxis function will work. This function gets all possible moves of a given queen on the x axis. There will also be another function (Figure 21) like this implemented, that will be almost identical to calculate possible moves on the Y axis, however it will deal with Y coordinates instead of X. It will also use different lists and for example, instead of chessBoardA it will use chessBoard1 list.

![Figure 22 Part of PossibleMovesXAxis function flowchart](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure22.jpg)
##### Figure 22 Part of PossibleMovesXAxis function flowchart
These lists in Figure 22 contain all chess coordinates in a row for a given axis for example:

chessBoardA = new List<string>() { "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8" }
 
chessBoard1 = new List<string>() { "A1", "B1", "C1", "D1", "E1", "F1", "G1", "H1" };

#### CalcDiagonalTopRight Function.
![Figure 23 CalcDiagonalTopRight Function Flowchart](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure23.jpg)
##### Figure 23 CalcDiagonalTopRight Function Flowchart
This flowchart (Figure 23) describes one of 4 very similar functions. It is used to calculate the diagonal top left possible moves from where the chess piece is placed. The other 3 functions are programmatically very similar. However, in the first two for loops (Figure 24):
 
![Figure 24 CalcDiagonalTopRight Function Flowchart Loops](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure24.jpg) 
##### Figure 24 CalcDiagonalTopRight Function Flowchart Loops
The functions will have a different combination of functions (for example, placeInXAxis() and placeInYAxis() functions) these could be any combination of these functions:
 
placeInXAxis() or placeInXAxisReverced()
 
placeInYAxis() or placeInYAxisReverced()  
 
And a corresponding list of chess coordinates within the loop so 
 
chessCoordsXAxis or chessCoordsXAxisReverced
 
chessCoordsYAxis or chessCoordsYAxisReverced
 
An example of the data the lists will contain:
 
chessCoordsXAxis = { "A", "B", "C", "D", "E", "F", "G", "H" };

chessCoordsYAxis = { "1", "2", "3", "4", "5", "6", "7", "8" };

chessCoordsXAxisReverced = { "H", "G", "F", "E", "D", "C", "B", "A" };
 
chessCoordsYAxisReverced = { "8", "7", "6", "5", "4", "3", "2", "1" };
 
Example in this function (Figure 25) CalcDiagonalTopRight():
 
![Figure 25 CalcDiagonalTopRight Function Flowchart Loops, Add Chess coordinates](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure25.jpg)
##### Figure 25 CalcDiagonalTopRight Function Flowchart Loops, Add Chess coordinates  
For example, this is what those loops would look like in the CalcDiagonalTopLeft function (Figure 26):
 
![Figure 26 CalcDiagonalTopLeft Function Example](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure26.jpg)
##### Figure 26 CalcDiagonalTopLeft Function Example
The rest of the function is identical to the others. Depending on the direction dictates what combination will be used.
 
#### General 8 queens’ algorithm
 
![Figure 27 Basic Game Logic For 8 Queens](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure27.jpg)
##### Figure 27 Basic Game Logic For 8 Queens 
This flowchart (Figure 27) shows basic game logic for 8 queens. I.E what will happen when the calculate if valid solution button is clicked.
 
### 2048 Game Flowcharts
 
![Figure 28 Cube merge and move algorithm 2048 Flowchart](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure28.jpg)
##### Figure 28 Cube merge and move algorithm 2048 Flowchart
The flowchart in Figure 28 shows how a given row on the 2048 grid will be updated to move and merge cubes. In essence, the algorithm works by first checking to see if merges can be made in each row and stores the new positions and cubes in an array, then it checks to see if a cube move can be made, thereby making sure all cubes are as far to the direction of the pressed button as possible. All these are operations are done on an array and are not updated on the 2048 grid initially until the calculations for a given row are complete. At the end of this algorithm an array containing the new state of the row. This is then used to update the row in game. 
 
### Reuse of Existing Code
 
One major library we will be using is called, Oculus integrations (Unity), it contains all code, and assets required to start developing for the Oculus Quest Two. This asset pack includes character prefabs, basic VR assets and other such VR related C# scripts. Another framework that will be used in development, is Django (Django), this will be used to create the website.

# Implementation
 
## Chapter Introduction
This section of the report details the development process of the Puzzle VR game and its website.
 
## Sprint 1:
 
### Burn Down Chart:
 
![Figure 30 Burn Down Chart Sprint 1](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure30.jpg)
##### Figure 30 Burn Down Chart Sprint 1
 
|Requirement To Be Implemented|Completed|
|:----|:----|
|FR1-VR-8Q|Done|
|FR2-VR-8Q|Done|
|FR3-VR-8Q|Done|
|FR3-VR-8Q|Done|
|FR4-VR-8Q|Done|
|FR5-VR-8Q|Done|
|FR6-VR-8Q|Done|

##### Figure 31 Sprint 1 tasks
 
### Explanation important code completed in sprint/Reflections:
 
To implement 8 queens, an algorithm is required to determine a few things, for example, the current position of a queen, its possible moves, thereby the queens it can attack. 
The first task is producing a set of arrays containing all positions on the chess board (Figure 32), one list for each of the rows and columns:

![Figure 32 Chess Coordinate List Part A](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure32.jpg)
#####  Figure 32 Chess Coordinate List Part A
 The final two important lists (Figure 33) contain the labels for each axis on the chess board and the same in reverse order:
 
 ![Figure 33 Chess Coordinate List Part B.](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure33.jpg)
 ##### Figure 33 Chess Coordinate List Part B.
After this has been implemented it is then possible to perform the required operations to determine which position a given chess piece is in and where it can move/attack.
 
To determine possible moves, each axis, is calculated separately, for example to calculate the possible moves for a given queen for the X axis this function is employed:

![Figure 34 PossibleMovesXAxis Code Snippet](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure34.jpg)
##### Figure 34 PossibleMovesXAxis Code Snippet  
This function (Figure 34) takes the current Coordinates for a given queen, splits them into a char array, and uses those coordinates to determine every place in can move on the given axis, so if the queen is sitting on an “A” square, it will add all places it can move on that column to the possible moves array, excluding the square that the queens is placed on. Programmatically, the method of calculating possible moves for the Y axis is identical, however it will use a different, array containing all the positions in a given row (Figure 32). 
 
The final set of steps in determining where the queen is placed, is determining possible moves diagonally, as the queen can move diagonally, this is done with a set of 4 functions, one of them is given bellow:

![Figure 35 CalcDiagonalTopLeft Code Snippet](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure35.jpg) 
##### Figure 35 CalcDiagonalTopLeft Code Snippet

This code works as follows. First, the possible positions on the X coordinates are found for the diagonal section and so is the Y.
Next, to prevent uneven arrays, which when the coordinates are merged, I.E “A” and “1” to produced “A1” this can happen, this for loop is employed to go through the array and remove any extra Y or X coordinates that have been added. Extra coordinates indicate the end of a diagonal section.
The beginning of each set of coordinates is then removed to prevent the actual position of the chess piece from being added to the final output list.
The individual coordinates are then merged to produce a list of a set of locations on the chessboard for that diagonal section.

The above code (Figure 35) shows how the possible moves are calculated for the top left diagonal section, the chess board is split into 4 different sections with the square that the queen is placed on as the centre for example (Figure 36):
 
![Figure 36 Chess Board Example](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure36.jpg)
##### Figure 36 Chess Board Example
 
Programmatically the function above for calculating the top left diagonal section is very similar to the other diagonal sections as show above, with a few key differences. Depending on the direction of the diagonal line section they may use a different initial coordinate list, for example “calcDiagonalBottomLeft()” uses “chessCoordsXAxisReversed” and “chessCoordsYAxisReversed” lists instead of “chessCoordsXAxis” and “chessCoordsYAxisReversed” like in “calcDiagonalBottomRight()”. And use a different combination of the place in axis functions, like with the two examples given above “calcDiagonalBottomLeft()” uses “placeInXAxisReversed(string location)” and “placeInYAxisReversed ()” and  “calcDiagonalBottomRight()” uses “placeInXAxis()” and “placeInYAxisReversed()”. Which “placeInAxis” function used depends on which direction “calculateDiagonal” function need to calculate coordinates for. 
 
Here is example (Figure 37) debug output for the above-mentioned functions with a queen on coordinate “F2”:

![Figure 37 All Possible Moves Output Example](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure37.jpg)
##### Figure 37 All Possible Moves Output Example
 
All these functions are called in the “getPossibleMoves(string currentLocation)” function, this function combines the results for the above functions to create a list with all possible moves for one queen. 
 
These steps are repeated for all queens until each queen has a list of all possible positions they can move. 
To check if a given queen can attack another this function is employed (Figure 38):
 
![Figure 38 InLineOfSightQueen Code Snippet](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure38.jpg)
##### Figure 38 InLineOfSightQueen Code Snippet

If the current queen’s coordinates match one of the coordinates in another queen’s possible moves, then they can attack each other, and the solution given by the user is invalid.
 
Score is calculating based on the time taken to solve the puzzle, and the score modifier:

![Figure 39 CalculateScore Code Snippet](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure39.jpg)
##### Figure 39 CalculateScore Code Snippet
 
Formula: PossibleScore – (timeTaken * scoreModifyer)

This function (Figure 39) ensures that the longer time a user takes to come to the solution, the less of a pre-set maximum score they will receive.
 
### Functional Requirements Testing 

 |Requirement|Expected result|State of system|Actual Result|Pass/Fail|
|:----|:----|:----|:----|:----|
|FR1-VR-8Q|User is able to pick up a chest piece.|player is in game, in the 8 queen’s scene.|Chess piece was able to be lifted using controller by pressing the grip button.|Pass|
|FR2-VR-8Q|Game detects chess piece when placed on a given chess piece on the board, sensor shows the chess queen in sensor check box ticked.|player is in game, in the 8 queen’s scene.|Sensor detected chess piece, queen in sensor check box ticked.|Pass|
|FR3-VR-8Q|Chess pieces are placed in incorrectly on the chess board, the game must register this as an incorrect solution.|player is in game, in the 8 queen’s scene. With puzzle completed.|Game flagged the players solution as invalid.|Pass|
|FR3-VR-8Q|Chess pieces are placed in correctly on the chess board, the game must register this as a valid solution.|player is in game, in the 8 queen’s scene. With puzzle completed.|Game flagged the players solution as valid.|Pass|
|FR4-VR-8Q|Timer must start the moment the player enters the puzzle.  It must start counting up.|Player clicked the 8 queens puzzle button in the main menu and is taken to the 8 queen’s puzzle level.|Timer stated counting correctly.|Pass|
|FR5-VR-8Q|Score is calculated based on the time it takes to solve the puzzle, puzzle is solved in 20 seconds, expected result is possibleScore - (timeInput * scoreModifyer). Therefore; 1000 – (20 * 10) = Score = 800 | Player is in game, in the 8 queen’s scene. With puzzle completed, clicked submit score button.|Score output as 800.|Pass|
|FR6-VR-8Q|After the 8 queens puzzle is solved, the user is taken back to the main menu in 5 seconds.|player is in game, in the 8 queen’s scene. With puzzle completed, clicked submit score button.|User was taken to the main menu after 5 seconds.|Pass|

##### Figure 40 Functional requirements testing sprint 1.

## Sprint 2:
### Burn Down chart:
![Figure 41 Burndown chart sprint 2.](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure41.jpg)
#####  Figure 41 Burndown chart sprint 2.
 
|Requirements To Implement|Completed|
|:----|:----|
|FR7-VR-2048|Done|
|FR8-VR-2048|Done|
|FR9- VR-2048|Done|
|FR10-VR-2048|Done|
|FR11-VR-2048|Done|
|FR12- VR-2048|Done|

##### Figure 42 Sprint 2 Tasks
 
### Explanation important code completed in sprint/Reflections:
There is one main function within the 2048 code that facilitates movement and cube merges:
This function has 2 applications. Its main function calculates a row of cube moves I.E if they can merge or move, and this can be used it 2 ways:

The first is facilitating cube movement and merging. When the flagAllowUpdateGrid flag is set to true, the cubes will move on the grid based on the functions calculated state of a row.
    
The second use case is to detect whether moves and merges are possible in each row and column. If there are moves and merges possible the function will return false, otherwise true to indicate no changes to the row can be made, when the flagAllowUpdateGrid flag is set to false this can be used to check whether the player has lost without making any physical moves on the grid.

![Figure 43 cubeMoveMerge Code Snippet](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure43.jpg)
##### Figure 43 cubeMoveMerge Code Snippet
 
This first section of the code (Figure 43) figures out what cubes can be merged in each row based on a few rules. The first is the cubes must have identical values and the second is that if a cube of a different value is in between two cubes of the same value a merge cannot occur. 
Instead of creating a function that moves and merges cubes as and when it finds a match, the method chosen calculated all possible movements and merges in one go and then update the whole row at once. This was done due to synchronization issues that occurred when changes to the grid were done as an when the algorithm determined there needed to be a merge or cube move, this is because when merging the old two cubes, must be deleted on the board, when this happened, the algorithm, still thinks the cube still exists and tries to delete it again causing an error as the cube position data would be outdated. This method of implementation is one way to avoid this error. The win condition is checked as the program is checking for merges, if the addition of two cubes equates to 2048 then the player has won, however before the player is notified of this the algorithm finishes running, and the board updated with the new cubes and locations to allow the user to see the winning cube on the board otherwise they would get the win message without the 2048 cube appearing on the board.

![Figure 44 MoveMerge Code Snippet Part 2](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure44.jpg)
##### Figure 44 MoveMerge Code Snippet Part 2
 
The second part of this function as displayed above (Figure 44) facilitates, the movement of cubes, the first part however if (flagMergesMade == false) determines where it is needed to use the output list created by merging. If no merges took place, then the original input list can be operated on to facilitate movement, this is done by removing all empty spaces from the list and appending them to the end of the list. This function is universal and can be used on every row and column, irrespective of the direction the user chooses to move I.E up, down, left, or right.
 
![Figure 45 2048 updated row screenshot](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure45.jpg)
##### Figure 45 2048 updated row screenshot
 
Here is an example output (Figure 45) of the function in Figures 43 and 44. The first section of the output bellow “original cube pos”, is the cube positions before the function processes the row and the output bellow “end result” is the positions of the cubes in the row after the function has been executed. As can be seen in the Figure 45 the original position of the cube 2 has been moved right to the end of the row in the “end result” section, indicating the algorithm is working as intended.
 
The code below (Figure 46) is the button script for the left button, when this button is pressed the cubes will be moved and merged to the left:
 
![Figure 46 LeftButton Code Snippet.](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure46.jpg) 
##### Figure 46 LeftButton Code Snippet.
 
The first set of function calls populates the corresponding lists with the UpToDate positions of the cubes in the whole grid.
If the button is pressed then possible moves and merges are calculated for all rows and columns, however only the cubeMoveMerge() that are operating on rows or columns that correspond with the button pressed are actually updated in game on the grid. 

This is done to allow for lose condition checking, no matter which direction use user selects to move, the reason this is checked in the code of each button is because, the other way of doing this is continuously checking the board to check to see if the player has lost. This does have a great impact on performance of the game, therefore, it should only be checked when any of the directional buttons are pressed, not continuously.
As can also be seen from the code above the Invoke(“AllowForButtonPress”, 2); function is used to allow for a delay in button presses. This is done to avoid the button being pressed multiple times unintentionally if the user leaves the controller inside the button for too long, allowing this to happen resulted in the game crashing during testing.
 
Score in this puzzle is calculated by adding ten to the score for each merge the user completes.
 
### Functional Requirements Testing 

|Requirement|Expected result|State of system|Actual Result|Pass/Fail|
|:----|:----|:----|:----|:----|
|FR7-VR-2048|When left button is clicked all cubes move to the left on the board.|2048 puzzle loaded; game is ready to play|All cubes moved in the correct direction.|pass|
|FR7-VR-2048|When right button is clicked all cubes move to the right on the board.|2048 puzzle loaded; game is ready to play|All cubes moved in the correct direction.|pass|
|FR7-VR-2048|When down button is clicked all cubes move down on the board.|2048 puzzle loaded; game is ready to play|All cubes moved in the correct direction.|pass|
|FR7-VR-2048|When up button is clicked all cubes move up on the board.|2048 puzzle loaded; game is ready to play|All cubes moved in the correct direction.|pass|
|FR8-VR-2048|Cubes must merge in the direction of the button the user clicked. Two “2” cubes are merged to produce 4. Button tested left.|2048 puzzle loaded; game is ready to play.|Cubes merged correctly to produce a 4 cube in their place.|pass|
|FR8-VR-2048|Cubes must merge in the direction of the button the user clicked. Two “2” cubes are merged to produce 4. Button tested right.|2048 puzzle loaded; game is ready to play.|Cubes merged correctly to produce a 4 cube in their place.|pass|
|FR8-VR-2048|Cubes must merge in the direction of the button the user clicked. Two “2” cubes are merged to produce 4. Button tested up.|2048 puzzle loaded; game is ready to play.|Cubes merged correctly to produce a 4 cube in their place.|pass|
|FR8-VR-2048|Cubes must merge in the direction of the button the user clicked. Two “2” cubes are merged to produce 4. Button tested down.|2048 puzzle loaded; game is ready to play.|Cubes merged correctly to produce a 4 cube in their place.|pass|
|FR9- VR-2048|Once no new movements of cubes or merges can be made the user gets a message saying they have lost.|2048 puzzle loaded; game is ready to play, no more merges or cube movements can be made|Game was declared a loss.|pass|
|FR10-VR-2048|After two 1024 cubes are merged the user is shown a win message.|2048 puzzle loaded; game is ready to play, two cubes are about to be added to make 2048|Two 1024 cubes are added to make 2048, user was notified of the victory|pass|
|FR11-VR-2048|3 cubes are merged to create a score of 30.|2048 puzzle loaded; game is ready to play, two cubes are about to be added.|Cubes are combined and score is now 30.|pass|
|FR12- VR-2048|After the game is won, button appears to take user back to the main menu|2048 game won|Button appeared to take user back to main menu.|pass|
|FR12- VR-2048|After the game is lost, button appears to take user back to the main menu|2048 game lost|Button appeared to take user back to main menu.|pass|

##### Figure 47 Functional Requirement Tests Sprint 2.
 
## Sprint 3:
### Burndown chart:

![Figure 48 Burn Down Chart Sprint 3](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure48.jpg)  
#####  Figure 48 Burn Down Chart Sprint 3
 
|Requirements To Implement|Completed|
|:----|:----|
|FR16-VR/WS-8Q|Done|
|FR17-VR/WS-2048|Done|
|FR18- VR/WS-2048|Done|
|FR19-WS|Done|
|FR20-WS|Done|
|FR21-WS|Done|

##### Figure 49 Sprint 3 Tasks
 
### Explanation important code completed in sprint:
![Figure 50 REST API Code Snippet](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure50.jpg)
##### Figure 50 REST API Code Snippet
 
Here are the two rest API classes for both puzzles, each class contains only handles post requests as the game does not require get requests as no data is required from the database by the game. The code accepts post requests and then takes the username from the JSON data and stores it in the database to be utilised by the website, to display user scores.
 
Some code is shared between the two puzzles most notably the POST class which allows score data to be sent to the webserver and stored in the database.
 
![Figure 51 HTTPRequest Code Snippet](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure51.jpg)
##### Figure 51 HTTPRequest Code Snippet
 
As can be seen from the code, the is facilitated using the System.Net class, allowing JSON data to be sent to the webserver in the form of a http Web Request.
Sent is both the username of the player and the score they obtained in the respective puzzle.

|Requirement |Expected result|State of system|Actual Result|Pass/Fail|
|:----|:----|:----|:----|:----|
|FR16-VR/WS-8Q|After 8 Queens puzzle is solved, score data and username are sent to the webserver and scored in the database. (The username in this test is hard coded). Test data: Username: “Test1” Score Data: “1000”|8 Queens puzzle is solved.|8 Queens score and username was sent to the database.|pass|
|FR17-VR/WS-2048|After 2048 puzzle is lost, score data and username are sent to the webserver and scored in the database. (The username in this test is hard coded). Test data: Username: “Test2” Score Data: “300”|2048 puzzle lost, no moves or merges to be made, user is notified of lost.|Score data and username received by headset.|pass|
|FR18- VR/WS-2048|After 2048 puzzle is won, score data and username are sent to the webserver and scored in the database. (The username in this test is hard coded) Test data:Username: “Test3”  Score Data: “400”|2048 puzzle won, two 1024 cubes added to win the game.|Score data and username received by headset.|pass|
|FR19-WS|Navigation bar home button takes user to the website home.|User is currently on the 8 Queens leader board page.|After clicking the home button user is taken to the home page.|pass|
|FR19-WS|Navigation bar 8 Queens leader board button takes user to the 8 queens leader board page.|User is currently on the home page.|After clicking the 8 Queens leader board button user is taken to the Queens ‘leader board page.|pass|
|FR19-WS|Navigation bar 2048 leader board button takes user to the 2048 leader board page.|User is currently on the home page.|After clicking the 2048 leader board button user is taken to the 2048 leader board page.|pass|
|FR20-WS|On the 8 Queens leader board page score and usernames should be pulled from the database and displayed on the page. Test data: Username “test” score “1000”|User is currently viewing the 8 queens leader board page.|User can view score data pulled from the database; test data is visible on webpage.|pass|
|FR21-WS|On the 2048 leader board page score and usernames should be pulled from the database and displayed on the page. Test data: Username “test2” score “300”|User is currently viewing the 2048 leader board page.|User can view score data pulled from the database; test data is visible on webpage.|pass|

##### Figure 52 Functional Requirements Tests Sprint 3.

## Sprint 4:
### Burn-Down chart:

![Figure 53 Burn Down Chart Sprint 4.](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure53.jpg)
##### Figure 53 Burn Down Chart Sprint 4.
 
|Requirement To Implement|Completed|
|:----|:----|
|FR13-VR-Menu|Done|
|FR14-VR-Menu|Done|
|FR15-VR-Menu|Done|

##### Figure 54 Sprint 4 Tasks
 
### Explanation important code completed in sprint/Reflections:
 
![Figure 55 Keyboard Code Snippet](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure55.jpg)
##### Figure 55 Keyboard Code Snippet
 
This code (Figure 55) is a small extract from the keyboards on trigger enter function. This script is attached to the controller. When the controller collides with a given key it’s corresponding letter or number is concatenated onto the typedText string variable, allowing user input to be collected and due to this being a public static variable, this variable can be accessed in other scenes allowing it to be used when score data needs to be sent to the webserver
Functional Requirements Testing 

### Functional Requirements Testing 
 
|Requirement|Expected result|State of system|Actual Result|Pass/Fail|
|:----|:----|:----|:----|:----|
|FR13-VR-Menu|When the 8 Queens’ button is clicked, the user is taken to the 8 Queens puzzle.|User is in main menu.|User is taken to the 8 Queen’s puzzle.|pass|
|FR14-VR-Menu|When the 2048 button is clicked, the user is taken to the 2048 puzzle.|User is in main menu.|User is taken to the 2048 puzzle.|pass|
|FR15-VR-Menu|The user can type the username “user1” and it appears on the in-game screen.|User is in main menu.|User data appeared after being typed out using the in-game keyboard.|pass|
|FR15-VR-Menu and FR14-VR|8 Queens - Username is retrieved from the main menu keyboard and sent with the score data to webserver.|User in 8 Queens with puzzle complete.|Username is retrieved from menu and sent along with score data to webserver.|pass|
|FR15-VR-Menu and FR14-VR|2048 - Username is retrieved from the main menu keyboard and sent with the score data to webserver after the user loses and presses the main menu button.|User in 2048 with puzzle Lost.|Username is retrieved from menu and sent along with score data to webserver|pass|
|FR15-VR-Menu and FR14-VR|2048 - Username is retrieved from the main menu keyboard and sent with the score data to webserver after the user wins and presses the main menu button.|User in 2048 with puzzle won.|Username is retrieved from menu and sent along with score data to webserver.|pass|

##### Figure 56 Functional Requirements Test Sprint 4.
 
## Non-functional requirements testing:

|Requirement|Expected result|State of system|Actual Result|Pass/Fail|
|:----|:----|:----|:----|:----|
|N-FR3|The game must be able to run at a reasonable frame rate on the quest 2, 60fps minimum.|Game loaded in puzzle.|Game achieves above 60 fps.|Pass|
|N-FR5|The game should be able to check the validity of a solution without any long durations (over 5 seconds) of frame drops.|Game loaded in puzzle 8 Queens.|Only a brief second of frame drops when the solution validity is being calculated.|Pass|
|N-FR5|2048 checking if lost. The game should be able to check the validity of a solution without any long durations (over 5 seconds) of frame drops.|Game loaded in puzzle 2048.|No frame drops present when testing, game runs smoothly, no delay when moving and merging cubes due to prior calculation of win loss state.|Pass|

##### Figure 57 Non-Functional Requirement Tests
 
## Evaluation of testing
After analysing all the test results, it is easy to conclude that testing the game went very well with all must requirements being implemented, tested, and are working as planned. 

In terms of strengths, the game has all important features identified in the requirements working, making it a fully playable game, which was one of the main aims and objectives of this project. However, the game is lacking in content such as puzzles to play and further features such as hand tracking support furthermore none of the should have or could have requirements were implemented due to limited time.
 
## Completed Implementation Images

![Figure 58 Holding Chess Piece](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure58.jpg)
##### Figure 58 Holding Chess Piece
 
In Figure 58 can be seen the player holding the chess piece. This is accomplished by holding the grip button on the controller, the user can then release the chess piece by releasing the grip button. The left hand is utilised for movement in both puzzles, this is done by using the joystick. This feature was implemented in sprint 1.
 
![Figure 59 8 Queens Solved](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure59.jpg)
##### Figure 59 8 Queens Solved
 
![Figure 60 8 Queens Solved with Text](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure60.jpg)
##### Figure 60 8 Queens Solved with Text
 
![Figure 61 8 Queens Invalid Solution](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure61.jpg)
##### Figure 61 8 Queens Invalid Solution
 
Figures 59 and 60, 61 were also implemented in sprint 1, they show chess pieces placed by the user on the chess board (Figure 59) and what happens when the player has lost (Figure 61) or won (Figure 60). If the player has lost the check solution button turns red and if they have won, victory text appears telling the user they have won and will be returned to the main menu.
 
![Figure 62 Grid Screenshot](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure62.jpg)
##### Figure 62 Grid Screenshot
 
![Figure 63 Grid Screenshot Lost State](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure63.jpg)
##### Figure 63 Grid Screenshot Lost State
 
![Figure 64 Grid Lost Text](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure64.jpg)
##### Figure 64 Grid Lost Text
 
Figures 62, 63 and 64 were implemented in sprint 2. Figure 62 shows the 2048 puzzle being played, Figures 63 and 64 show the lost state, when the grid is filled, and no more moves can be made.  The win state is similar however, two 1024 cubes must be matched, and the “You Lose” text will be “You Win”. The game is played by pressing the buttons on the control surface showing in all 3 figures, depending on the button the user clicks depend on which direction the cubes are moved and merged.
 
![Figure 65 Home page](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure65.jpg)
##### Figure 65 Home page
 
Figure 65 shows the home page for the website. At the bottom of the page is a small amount of text greeting the user.
 
![Figure 66 8 Queens Leader board](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure66.jpg)
##### Figure 66 8 Queens Leader board
 
Figure 66 shows the completed leader board page, with the leader board displayed on the bottom. Both leader board pages (Figure 66 and 67) have navbars at the top of the page however these screenshots show the leader boards at the bottom of the page therefore the navigation bar is not visible. The leader board shows player scores in descending order.
 
![Figure 67 2048 Leader Board](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure67.jpg)
##### Figure 67 2048 Leader Board 
 
Figure 67 shows the 2048 leader board with the user’s name and score displayed in descending order.
 
![Figure 68 About Page](https://github.com/hellhound858/PuzzleGameDSP/blob/main/Documents/Documentation/Report%20Figures/Figure68.jpg)
#####  Figure 68 About Page 
 
Figure 68 shows the about page which contains information about the puzzles and how to play them.
 
# Project Evaluation
This section will include a full project evaluation, the issues that were faced, the solutions to those issues and what improvements could be applied to make the product better will be discussed here.
 
## Research
During the research section, many topics were explored, how to implement it and the technologies used to implement it. However, the research was a little too narrow in some areas, particularly in terms of game engines, and web technologies, for example, likely due to personal bias, research was focused on unity, and web frameworks for the programming language python. This was not a wise strategy as it is likely that better solutions could have existed and would have been found if the search criteria were broadened. 
 
## Requirements
The methodology used however for prioritizing requirements “MoSCoW” proved to be very useful as it made planning sprints much easier, as identifying priority requirements before development, made important features that must have been implemented first clear. Furthermore, it resulted in a fully playable product as no time was wasted implementing less important features. Requirements section does have some flaws mainly, although all the “must have” requirements were implemented and tested, they “should have” requirements and “could have” requirements were not implemented due to time constraints.

## Methodology
As discussed in the methodology section the methodology selected was Agile Scrum. Even though they method is usually used in groups, it was found that during this project it worked quite well with individual projects as well. It was found that structuring development in this way helped to organised and implement work efficiently, setting time frames for sprints with set work to do within them, made the large amount of work that was needed to be done easier to handle and manage within those sprints.

## Design
 
In the case of this project, time management was of the utmost importance, making the design section extremely important as, not being prepared in this area when implementing could have resulted in time being wasted, due to poor planning. Due to this, this section could be considered a success as because of the diagrams, the implementation went smoothly and efficiently. Particularly the flow charts in this section proved very useful making some of the more complex algorithms in the project much quicker and easier to implement.
 
## Implementation and testing
 
During the development of the game, we obtained much feedback from the people that tested it. One of the major issues that users faced was if they were completely new to VR, it was very difficult for them to play the game, without instructions from someone with more experience. This is likely because with the headset on, you cannot look at the controls for reference. This issue could be rectified with an addition of a tutorial with general instructions about how to operate the headset, such as controls. Controls in VR games as was found during research and testing of different VR games, tend to be similar. For example, the grip button is used to grab objects in most VR games. Due to this fact, this product, because of its relatively simple concept could be used, and adapted as more of a learning aid, to allow users to get used to the basics of VR, because of its simple gameplay, it is not very intense. 
 
Another major point that was discovered when allowing users to test is that, as a developer, We did not consider the possibility of users playing the game unlike the developer would, for example, when we play we know exactly what we are doing, as the games developer we know that to play 8 queens, for example we know that we need to place all the queens on the chess board so they can’t attack each other, so we did not account for situations in which the user would go against this directive and walk up to a virtual wall and put their head through it seeing the incomplete world outside of the game area. Although at first this does not sound like an issue, it brought on a realisation that there are bugs and flaws in the game that we may not have been able to find because when we test, we are testing to see if a given feature works. Not if a feature can be used to break the game. This, it indicates that our approach to testing was flawed, as we only tested the game against the requirements of the project, and only used external testers after the large majority of implementation was finished. A better approach would have been to give the game to external testers after each sprint, so any unusual bugs that they found could be fixed in the next. This testing method would have likely resulted in a more polished game with fewer bugs. 
Further Work and Conclusions

## Conclusion
 
To conclude this report, it should be stated although a lot of things went very well, a few things did not. The main project aim, to create a VR game that has two puzzles with a web site to display scores was a success, all aims, and objectives declared at the start of the project have been achieved. This was all done using Unity and Django. Extending this would not be difficult in the future, as the game is set up in a way where adding new puzzles would be very easy. For example, using readymade unity prefabs and code that were created during the project for other puzzles. This report and the game implemented gave an in depth look into the rising technology VR and demonstrated one way in which it could be applied and used. During the reports research section other applications for VR were identified, VR as an emergent technology has a lot of potential applications because of this future work on this project would allow for further understanding of VR capabilities and limits.

## Future work
 
Although due to time constraints only the main requirements, the “MoSCoW” “Musts” were implemented, given more time, further additions could have been added. For example, if work on this project were to continue, more puzzles should be added to the game. More features like a login system for the website and the VR headset allowing players to update their existing scores rather than simply adding a new one to the leader board. Furthermore, creating a version of the game that will also execute on desktop-based VR headsets like the Oculus Rift S is another idea that could be considered. 
 
# References / Bibliography
 
Asghar, A.R.A, Bhatti, S.N.B, Tabassum, A.T, Shah, S.A.A.S (2017) The Impact of Analytical Assessment of Requirements Prioritization Models: An Empirical Study International Journal of Advanced Computer Science and Applications [online]. Volume 8. Page 303-313 [Accessed 28 December 2021].
 
Craig,A. Sherman,W. Will,J. (2009) Developing virtual reality applications : foundations of effective design [online]. Location: Elsevier Science & Technology. [Accessed 06 November 2021].
 
Cline, E.C. (2011) Ready player one. US: Crown Publishing Group[Accessed 25 December 2021].
 
Chu,E. Zaman,L. (2021) Exploring alternatives with Unreal Engine’s Blueprints Visual Scripting System. Entertainment Computing [Online]. Volume 36, Page 188[Accessed 13 November 2021]
 
Dionisio, III, Gilbert, J.D, W.I, R.G. (2013) 3D Virtual worlds and the metaverse: Current status and future possibilities. ACM computing surveys [online]. Volume 45, Issue 3. [Accessed 21 December 2021].
 
Django (No Date) Why Django. Available from: https://www.djangoproject.com/start/overview/ [Accessed 28 December 2021].
 
Frese, U. Wagner, R., Rofer, T. (2010) A SLAM overview from a user’s perspective. KI [online]. Volume 24, pages 191-198 [Accessed 28 December 2021].
 
Grinberg, M. (2018) Flask web development: developing web applications with Python[online]. Second edition. No place: O’Reilly. [Accessed 13 November 2021].
 
Gibson, W.G. (1993) Virtual Light. US, UK, Canada: Bantam Spectra, Viking Press, Seal Books[Accessed 25 December 2021].
 
Wikipedia (2021) Game Engines [online]. 24 December. Available from: https://en.wikipedia.org/wiki/Game_engine [Accessed 25 December 2021]. 
 
GameLabGraz (No Date) Maroon [Video game]. Graz University of Technology. Available from: https://maroon.tugraz.at/ [Accessed 27 December 2021]. 
 
HTC Vive(no Date) Vive Pro. Available from: https://www.vive.com/uk/product/vive-pro/ [Accessed 11 April 2022].
 
Huang, B., Zhao, J., Liu, J. (2019) A Survey of Simultaneous Localization and Mapping with an Envision in 6G Wireless Networks. CoRR [online]. Volume abs/1909.05214[Accessed 28 December 2021].
 
Hesch,J. Kozminski,A. Linde,O. (2019) Powered by AI: Oculus Insight. Available from: https://ai.facebook.com/blog/powered-by-ai-oculus-insight/[Accessed 21 December 2021].
Hron,M. ,  Obwegeser,N. (2021) Why and how is Scrum being adapted in practice: A systematic review, Journal of Systems and Software[online]. Volume 183[Accessed 31 December 2021].
 
Holly,M. Pirker,J. Resch,S. Brettschuh,S. Gutl,C. (2021) Designing VR Experiences--Expectations for Teaching and Learning in VR. Educational technology & society [online]. Volume 24, pp. 107 – 119 [Accessed 27 December 2021].
 
Kreibich, J.A. (2010) Using SQL Lite[online]. O’Reilly Media. [Accessed 30 December 2022].
 
Kumar, G., Bhatia,P.K.(2012) Impact of Agile Methodology on Software Development Process, International Journal of Computer Technology and Electronics Engineering [online]. Volume 2[Accessed 31 December 2021].
 
Kotstein,S. Justus,B. (2021) Which RESTful API Design Rules Are Important and How Do They Improve Software Quality?. A Delphi Study with Industry Experts[online]. [Accessed 21 December 2021].
 
Lubbers,P. Albers,B. Salim,F. (2011) Pro HTML5 Programming[online]. no place: Apress. [Accessed 25 December 2021].
Unity (No Date) Oculus integrations (37.0) [Unity asset Pack]. Available from: https://assetstore.unity.com/packages/tools/integration/oculus-integration-82022 [Accessed 03 March 2022].
Meta (no Date) Quest 2. Available from: https://www.oculus.com/quest-2/ [Accessed 11 April 2022].
 
Monstars Inc. Resonair and Stage Games (2020) Tetris® Effect: Connected [Video game]. Enhance. Available from: https://www.oculus.com/experiences/quest/3386618894743567/?locale=en_GB [Accessed 01 January 2022]. 
 
Mishra,P. Shrawankar,U. (2016) Comparison between Famous Game Engines and Eminent Games. International journal of interactive multimedia and artificial intelligence [online]. Volume 4, page 69. [Accessed 13 November 2021].
 
MathWorks. (No date) Powered by AI: Oculus Insight. Available from: https://uk.mathworks.com/discovery/slam.html#slam-with-matlab [Accessed 21 December 2021].
 
Pourmand,A. Davis,S. Marchak,A. Whiteside,T. Sikka,S. (2018) Virtual Reality as a Clinical Tool for Pain Management. Current pain and headache reports [online]. Volume 22, Pages 1-6 [Accessed 27 December 2021].
 
Souza,D. R.B,C. F,D. (2009) On the Roles of APIs in the Coordination of Collaborative Software Development. Computer supported cooperative work [online]. Volume 18, Page 445-475. [Accessed 21 December 2021].
 
Shotton, J, Fitzgibbon, A, Cook, M,  Sharp, T, Finocchio, M, Moore, R, Kipman, A , Blake, A. (2011) Real-time human pose recognition in parts from single depth images. Anon, CVPR 2011 , Colorado Springs, CO, USA, 2011, IEEE [Accessed 28 December 2021].
 
Sherman,W. Craig,A. (2003) Understanding Virtual Reality: Interface, Application, and Design [online]. Location: Morgan Kaufmann. [Accessed 06 November 2021].
 
Schell Games (2021) I Expect You to Die 2 [Video game]. Schell Games. Available from: https://www.oculus.com/experiences/quest/2970998659623177 [Accessed 01 January 2022]. 
 
Taketomi, T. Uchiyama, H. Ikeda, S. (2017) Visual SLAM algorithms: a survey from 2010 to 2016. IPSJ transactions on computer vision and applications [online]. Volume 9. [Accessed 28 December 2021].
 
Tashjian, V.C.T. (2017) Virtual Reality for Management of Pain in Hospitalized Patients: Results of a Controlled Trial [online]. Volume 4, page e9 [Accessed 27 December 2021].
 
Tsai,Y. Jhu,W. Chen,C. Kao,C. Chen,C. (2021) Unity game engine: interactive software design using digital glove for virtual reality baseball pitch training. Microsystem technologies: sensors, actuators, systems integration [online]. Volume 27, Pages 1401 - 1417. [Accessed 12 April 2022].
 
 Uzayr, S. (2016) Learning WordPress REST API [online]. Basingstoke: Palgrave Macmillan. [Accessed 05 December 2021].
 
Yudin, A.Y. (2020) Building Versatile Mobile Apps with Python and REST: RESTful Web Services with Django and React [online]. No place: Apress. [Accessed 13 November 2021].
 
Zhang,Z. (2012) Microsoft Kinect Sensor and Its Effect. IEEE Computer Society [online]. Volume 19, pages 4-12 [Accessed 28 December 2021].

