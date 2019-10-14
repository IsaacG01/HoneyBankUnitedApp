# Honeypot Project
Honeypot Project 

The primary focus of this project is to build an authentication sequence and method that will help distinguish an attacker from a user and redirect all attackers into a simulated honeypot database and prevent unauthorized access to the real database. 

For the purpose of demonstrating how this honeypot works I created an online banking system with a database first approach that only displays user account information. Within the escalation of steps, the methods will determine whether a user is an attacker or a client before directing the user the proper database. Authentication will be performed in the following sequence:

1.	A user will have three attempts to enter the correct username and password. 
2.	After a third failed attempt the user will be branded a hacker and redirected to the honeypot.
3.	If the user enters the correct username and password within the three fixed attempts, the user will be sent to a multi-authentication verification system, 
4.	If the user fails to verify, the instance will be timed out and the user will be branded a hacker and redirected to the honeypot.
5.	If the user is verified through the multi-authentication method, the user will then be authorized and directed to the real database.

A simulated network is usually referred to as a “honeypot.” The honeypot network serves as a decoy database containing false data. Within the honeypot simulated environment security developers can be as creative as they need to in order to, for example, collect and study attacker activity, or create a false repository of hashed passwords to deceive the attacker into believing they have a way into other decoy accounts. The possibilities are many. 

The environment within the honeypot is typically referred to as a “jailed” environment. The attackers are free to move within this jailed environment in order to give them the impression of access, however there is no accessibility to the true network from within this jailed environment, and attackers will either end up collecting the decoy data or moving on. Within this jailed environment all attacker activity will be logged for future auditing and analysis. This data can later serve as way to predict:
1.	Attacker phishing methods
2.	Attacker scamming (social engineering) methods 
3.	IPs used 
4.	Their attack vectors and methods of collecting data 
5.	Or help answer the following questions:	
a.	Are they targeting specific user accounts or all user accounts?
b.	What are they doing with the data (if trackable)?
c.	How do they behave after the have gained access?
Attacker activity data can later be used to build better defense strategies by enhancing general security measures.

## Wireframe:
![WireFramePage1](/images/wireframe1.PNG)
![WireFramePage1](/images/wireframe2.PNG)
![WireFramePage1](/images/wireframe3.PNG)
## Case Diagram:
![WireFramePage1](/images/casediagram.PNG)
## Flowchart
![WireFramePage1](/images/flowchart.PNG)
