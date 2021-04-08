# MakeIT-How-to-build-your-own-datasets-with-Datasets-Builder
This repository is dedicated to a software I created and I decided to share with the community. It corresponds to the 3rd tutorial of my YouTube channel MakeIT.

The goal of this software is to use serial communication with an Arduino to fill a Datagridview (graphical component) and then you can export it to .csv file. You can build your own datasets using a large amount of sensors.

Here is the design :
![Software_1](https://github.com/BaptisteZloch/MakeIT-How-to-build-your-own-datasets-with-Datasets-Builder/blob/main/Datasets_builder/Datasets_builder_1.png?raw=true)

Further more if you don't have any RTC module or NTP server you can timestamp your data by selecting the option. You can also change the separator of the serial communication. And of course you can also stop recording and resume it as you wish.

This repository also contains the Arduino code used in the tutorial to communicate with the Datasets Builder software.
