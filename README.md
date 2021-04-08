# MakeIT-How-to-build-your-own-datasets-with-Datasets-Builder
This repository is dedicated to a software I created and I decided to share with the community. It corresponds to the 3rd tutorial of my YouTube channel MakeIT.

The goal of this software is to use serial communication with an Arduino to fill a Datagridview (graphical component) and then you can export it to .csv file. You can build your own datasets using a large amount of sensors.

The operation behind all the code is quite simple. Datasets builder sends 1 the Arduino respond the headers, then in a while loop Datasets builder sends 2 and Arduino respond a formatted string with values separated by a separator sign. This loop ends when the user click on stop on Datasets builder.

Schema of the communication :
![operations](https://github.com/BaptisteZloch/MakeIT-How-to-build-your-own-datasets-with-Datasets-Builder/blob/main/Operations.png?raw=true)

The layout of the software is shown under this section. You can see it's quite simple to use just follow the steps in the video. First choose you splitting character, then choose the COM port and baud rate. After that you are able begin serial communication. Then you can begin the recording procedure and stop it as you wish. To finish you can export the dataset in csv or if you are not satisfied with it you can clear it and restart the recording procedure.

![Software_1](https://github.com/BaptisteZloch/MakeIT-How-to-build-your-own-datasets-with-Datasets-Builder/blob/main/Datasets_builder/Datasets_builder_1.png?raw=true)

Further more if you don't have any RTC module or NTP server you can timestamp your data by selecting the option. You can also change the separator of the serial communication. And of course you can also stop recording and resume it as you wish.

This repository also contains the Arduino code used in the tutorial to communicate with the Datasets Builder software.

