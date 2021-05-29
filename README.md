# SimplyChatwithRASA-tf
Let's Create the simple desktop chat application powered by RASA.

[Installition- Server Side Requirement]

1.Install the conda 
https://anaconda.org/anaconda/conda
https://conda.io/projects/conda/en/latest/user-guide/install/windows.html

2.Creating  and activate  environment
Ex: 
"conda create -n myenv python=3.x"
"conda activate ./myenv"

Follow the instructions below.
https://conda.io/projects/conda/en/latest/user-guide/tasks/manage-environments.html

3.Install the tesorflow using conda.
"conda install tensorflow"

4.Install the RASA via PIP.
"pip3 install -U pip",
"pip3 install rasa".

5.Start the RASA Server.
Follow the instructions below link.
https://rasa.com/docs/rasa/command-line-interface

Ex: "rasa run -m models --enable-api --cors "*" --debug".

Note: make sure RASA server is up and running.

[Client- side Envirnoment setup]

1.Connecting to A Channel
Rasa Open Source provides many built-in connectors to connect to common messaging and voice channels.

Follow below link for options.

https://rasa.com/docs/rasa/messaging-and-voice-channels

2.Lets choose REST Channels now.
When lauched RASA server it hooks into the  http://localhost:5005 by default.
We can connect and  get the resposnse from RASA server by sending the HTTP POST requests to "http://localhost:5005//webhooks/rasa/webhook".

3.To handle the POST requests and use the response lets build simple desktop GUI using C#.
Application will POST responses  with below format as specified in the RASA docs.

JSON format:
{
  "sender": "test_user",  
  "message": "Hi there!"
} // sender ID of the user sending the message

The response from Rasa Open Source will be a JSON body of bot responses.

Lets launch the Chat Application now.

![image](https://user-images.githubusercontent.com/76731781/120061394-ac0cdf80-c07a-11eb-9fa5-abb83db03d1c.png)
