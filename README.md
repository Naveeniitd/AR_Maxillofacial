# AR Audio Visualizer
The AR Audio Visualizer is a project that allows you to visualize music in an augmented reality (AR) environment.

# Features
The AR Audio Visualizer project includes the following features:

1. A custom shader that uses edge detection and pulse animations to enhance the visual experience
2. A robust audio processing pipeline that computes the frequency spectrum of the sound
3. A mapping of the spectrum to a set of 3D objects in the AR scene

# Installation
To use the AR Audio Visualizer project, you'll need to follow these steps:

1. Clone the repository to your local machine
2. Open the project in Unity
3. Build the project for your desired platform (iOS or Android)
4. Deploy the app to your device or emulator

![Alt text](/images/Test1.png "Image Detection")


![Alt text](/images/Test2.png "Audio Visualization")

# Image Detection and Object Instantiation with EasyAR
This project uses image detection and object instantiation to create an augmented reality experience. We're using EasyAR, a cross-platform AR development kit, to make it easy to get started.

## Getting Started
To get started, you'll need to download and install the EasyAR SDK. Once you've done that, you can use the EasyAR Studio tool to create a new project and add the images you want to detect.

## Image Detection
EasyAR uses image recognition to detect the images you've added to your project. When the camera detects an image, it triggers an event that you can use to instantiate an object in the scene.

## Object Instantiation
We're using Unity to create the 3D objects we want to instantiate. When the image is detected, we use the EasyAR SDK to instantiate the object in the scene and position it relative to the image.

## Conclusion
By combining image detection and object instantiation with EasyAR, we're able to create a compelling augmented reality experience. We hope this project inspires you to explore the possibilities of AR development.




