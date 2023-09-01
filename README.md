## wordOccurrenceCounterAPI

# Introduction
Welcome to the word occurrence counter API. The idea of this application is to count the number of times a word occurs each time in a given text. </br>
You provide the text and the program counts each word and returns the result to you. NOTE... the result is limited by requirements to represent the 10 most occured words. </br>


# How do I get started?
Open a code editor of your choosing, but preferably visual studio 2022. Below are instructions to get going using the code editor just mentioned: </br>
* Fork this repositoy, it's completly free to use and modify.
* Open visual studio 2022 (does not matter if it is the enterprise version or else).
* Choose the alternative Clone a repository.
* Paste the Repository url of your newly forked repository.
* Choose your desired local path and hit select.
* Open a command promt in visual studio (ctrl + ö) - on a windows machine)
* Enter: `cd .\wordOccurranceCounterApi\` and hit enter to step in to the project folder (or cd w -> tab -> enter as a shortcut)
* enter: `dotnet run` to start the server (you should see: Now listening on: http://localhost:5181)

# Step two, using the program.
* While your server is running, open a command prompt window and enter the same path as the integrated cli in visual studio. (in windows: win + r -> cmd -> enter)
* Make sure you have curl installed, it ships as default on windows 10 and above. (you can test using: `curl -v`)
* enter: `curl http://localhost:5181/counter -X POST -d "{your string}" -H "Content-Type: plain/text"` NOTE!!! - change {your string} to your desired input (the string you wish to use in the program)
* If everything goes as expected you should see the result in the command prompt window.
* `{"dog":6,"cat":5,"cow":4,"horse":3,"pig":3, etc...}`

# What's a valid text input?
Specify any text inside the quotation marks (""). The only rules are that the input text can't be empty and that the words in the text needs to be seperated by a blankspace. Neglecting those rules will cause an exception.

# Any example text I can use?
Sure, enter this lorem ipsum example: </br> `curl http://localhost:5181/counter -X POST -d "Aenean arcu neque, porta ac erat nec, scelerisque placerat dui. Donec sit amet weekend dapibus turpis, happy mattis velit. Nulla facilisi. Nunc sit amet weekend nunc justo. Fusce posuere urna happy erat auctor sollicitudin. Praesent weekend efficitur convallis convallis. Fusce pulvinar maximus lacus eget consectetur weekend. Nunc happy accumsan nunc. Nullam interdum tortor at iaculis eleifend. Quisque tristique urna eget ante vulputate, non finibus ligula convallis. Class aptent taciti sociosqu ad litora torquent per conubia weekend nostra, per inceptos himenaeos. Sed faucibus ex happy et nulla lobortis tristique. Praesent quis tristique risus. Vivamus rhoncus lacus facilisis risus elementum luctus happy eget euismod magna. Nullam dapibus, mi happy semper viverra, eros metus placerat elit, eu commodo augue enim nec velit. Quisque nec facilisis nisi." -H "Content-Type: plain/text"`
