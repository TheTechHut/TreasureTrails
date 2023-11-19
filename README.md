# Treasure Hunt
## An AR app for virtual treasure hunts
<br />

By AR Adventures Ltd. <br />
<br />
<b>Contents:</b>

- [What is the Treasure Hunt app?](#intro)
- [How does it work?](#how)
- [Requirements](#requirements)
- [Developer Setup](#setup)
- [Debug](#debug-notes)
- [Attributions](#attributions)
- [Contributors](#contributors)

<br />

<img src="ReadMeResources/treasurehunt-gif-1-sm.gif" width="30%"/>

<br />

------------
<br />
<a name="intro"></a>

## What is the Treasure Hunt app?

Treasure Hunt is an exciting augmented reality (AR) experience that transforms your surroundings into a virtual treasure hunting ground. Using AR technology and geospatial features, players can embark on thrilling adventures to discover hidden treasures in the real world. The app combines the joy of exploration with the thrill of uncovering hidden gems, making it a perfect activity for friends, families, or solo adventurers.

<br />
<br />
<p float="left" align="middle">
    <img src="ReadMeResources/treasurehunt-1.png" width="30%"/>
    <img src="ReadMeResources/treasurehunt-3.png" width="30%"/>
    <img src="ReadMeResources/treasurehunt-4.png" width="30%"/>
</p>
<br />

------------
<br />

<a name="how"></a>

## How does it work?

The Treasure Hunt Unity project can be built to create a mobile game/app.<br />The project utilizes Unity 2019.4.36f1 and incorporates geospatial features to anchor virtual treasures to specific GPS coordinates in the real world. Players can navigate their surroundings, following clues and hints provided by the app to discover and collect treasures.

The geospatial API tracks the player's latitude, longitude, and altitude on Earth, allowing the placement of virtual treasures at specific locations. The app also offers a multiplayer experience, enabling multiple players to embark on the same treasure hunt and share the excitement of discovery.

<br />

<p float="left" align="middle">
    <img src="ReadMeResources/treasurehunt-gif-2-sm.gif" width="30%" hspace="1%"/>
    <img src="ReadMeResources/treasurehunt-gif-3-sm.gif" width="30%" hspace="1%"/>
    <img src="ReadMeResources/treasurehunt-gif-4-sm.gif" width="30%" hspace="1%"/>
</p>

<br />

------------
<br />

<a name="requirements"></a>

## Requirements

To enjoy the full experience of the Treasure Hunt app, users will need the following:
- Internet and GPS access.
- The app works best when used outdoors.
- A compatible device: Android - Recommended devices include Google Pixel 2 or later for optimal performance.

<br />

------------
<br />

<a name="setup"></a>

## Developer Setup

The app is currently not available on mobile app stores, but developers can download the code and build it in Unity. The app has been tested on recent Android phones such as Pixel or Samsung Galaxy 7 and higher.

- [Unity App](#setup-unity)
- [AR Geospatial API Key](#setup-geo-ar)
- [Treasure Database (optional)](#setup-treasure-database)

<br />

<a name="setup-unity"></a>
### Unity App

1. Download Unity version [2019.4.36f1](https://unity3d.com/unity/qa/lts-releases?version=2019.4) for compatibility, preferably using Unity Hub.

2. Clone this repository to your machine (or fork it if you plan to expand on it).

3. Open the project in Unity 2019.4.36f1 and launch the 'TreasureHuntAR' scene.

4. Follow the steps below in the ['AR Geospatial API Key'](#setup-geo-ar) section.

5. Follow the steps below in the ['Treasure Database'](#setup-treasure-database) section.

6. Deploy the app to an [ARCore compatible device](https://developers.google.com/ar/discover/supported-devices).

<br />

<a name="setup-geo-ar"></a>

### AR Geospatial API Key

To enable geospatial features, an API Key with AR Geospatial API enabled is required.

Follow the steps [here](https://developers.google.com/ar/develop/geospatial/unity-arf/developer-guide) to obtain an API key.

Add the API Key to your Unity Project:
1. Open Unity Project Settings.

2. Under 'XR Plug-in Management,' click on 'ARCore Extensions.'

3. Paste the Android API Key into the 'Android API Key' text field.

4. Ensure that 'Geospatial' is turned on.

<br />



<a name="debug-notes"></a>

## Debug
<br />

Within the 'TreasureHuntAR' Unity scene, find the GameObject called "DEBUG SETTINGS." This allows toggling debug information about the Geospatial API and displaying additional information about each virtual treasure.

<br />
<p float="left" align="middle">
    <img src="ReadMeResources/treasurehunt-debug-sm.gif" width="26%" hspace="1%"/>
    <img src="ReadMeResources/debug-toggles.jpg" width="68%" hspace="1%"/>
</p>

<br />

------------
<br />

<a name="attributions"></a>

## Attributions
<br />

### Treasure Chest 3D Model

[Treasure Chest 3D model on Sketchfab]

------------
<br />

<a name="contributors"></a>

## Contributors
 - [Okemwag](https://github.com/Okemwag)
 - [STARKthegreat](https://github.com/STARKthegreat)

## License & Notes
[Apache 2.0 license.](https://www.apache.org/licenses/LICENSE-2.0)

This is not an official Google product, but an AR Experiment developed by .....
To power this session, Google will process visual data from your camera. [Learn more](https://developers.google.com/ar/cloud-anchors-privacy).

You can do this by implementing the recommended user notice flow available in our [Cloud Anchor sample apps](https://developers.google.com/ar/develop/downloads) and Geospatial API sample apps.

