# **KickAssVR Educational Self-Defense VR Simulation**
## Central Michigan University Computer Science Department

KickAssVR is a simulation designed to teach users self-defense. With realistic training and a user-friendly guide, we aim to help users learn how to defend themselves. Although the chances of being in a scenario where you may need self-defense is low, self-defense is an important skill to have. Our goal is to enable users to learn self-defense even if they can’t attend classes. We plan to provide convenient access to self-defense training courses for our users with an added bonus of realistic gameplay without the need for hand controllers.

### Getting Started
**_Must have Oculus Rift S, Quest, or Quest 2 to play_**

*If using Oculus Rift S:*
1. Make sure your PC meets the minimum system requirements<br />
    - OS: 64-bit Windows 10
    - CPU: Intel Core i3-6100 / AMD Ryzen 3 1200, FX4350
    - RAM: 8GB
    - GPU: NVIDIA GeForce GTX 1050Ti / Radeon RX 470
    - GPU RAM: 8GB
    - Ports: USB 3.0 (1), DisplayPort (1)

2. Download and install the latest versions of Oculus VR & Leap Motion Windows VR software<br />
    - [Oculus VR Software](https://www.oculus.com/setup/#rift-s-setup)

3. [Configure Oculus VR headset](https://www.pcmag.com/how-to/how-to-set-up-the-oculus-rift)<br />

4. Download & Play!
  Download the build folder and double click the executable. Put the headset on and you are ready to learn self defense in KickAssVR!
  
*If using standalone Oculus Quest or Quest 2:*
Support coming soon!

### Acknowledgments
Author:
John Apo (johnapo)

Advisor:
Dr. Alex Redei (asmalex)

* Contributors:
    * Nathan Berman (bermannathan)
    * Tristen Delmotte (tristdelm)
    * Ian Duval (ClassyDuval)
    * Jestin Griffes (jestin44)
    * Damon Rubley (ruble1dl)

* Compatible with:
    * Unity 2019.2.9f1
    * Oculus App v21.0.0.473.119<br />
*No other versions have been tested and are therefore not supported*

#### Developer's Guide to Using GitHub, Git Large File Storage (LFS) with Unity
1. Download and install the following resources, and create an account on GitHub<br />
    - [GitHub Website](https://github.com/)
    - [GitHub Desktop Client Download](https://desktop.github.com/)
    - [Git Version Control System Download](https://git-scm.com/)
    - [Git LFS Download](https://git-lfs.github.com/)

2. Create new repository on GitHub online<br />
  Name your repository. It does not matter whether your repo is public or private, and I would recommend initializing a README file to add      documentation in the future. However, make sure that you add a .gitignore for Unity for compatibility between Unity files and GitHub, then create repository.

3. Open GitHub Desktop Client<br />
  Clone the repository you just created by finding it in your GitHub repositories, selecting a local save destination, and clicking the clone button to confirm.
  
4. Install Git LFS to your repository<br />
  Using your file explorer, open your locally saved repo which should only contain your .gitignore and README.md files. In that folder, right click and select the option _Git Bash Here_. In the Git command line, type prompt, type **git lfs install** and hit enter.

5. Create a .gitattributes file<br />
  With the Git command line still pulled up, type **git lfs track "*.psd"** which starts tracking Photoshop files using Git LFS. We will change these settings later to track more common Unity files like .fbx and .meta. At this point, we did this to autogenerate the .gitattributes file.
  
6. Configure your Unity project<br />
  Whether you created a new project or have an existing project, make sure that its file directory is copied and pasted or created in the  local save of your GitHub repository. For this example, I dragged and dropped my existing Unity project into my local save which for me was C:\Users\MyUser\Documents\GitHub\RepoName. Additionally, open your Unity project and under Edit > Project Settings, make sure that _Force Text_ is enabled under Asset Serialization. This ensures that file names have proper naming conventions for easier saving to the GitHub repo. Exit Unity. Using your file explorer, find the .gitignore file in your repo and drag and drop it it in the first folder containing your Unity project so that GitHub can properly ignore your Unity files. In your file explorer, open your .gitattributes file and insert file types used in your project. I copied and pasted [this .gitattributes file](https://gist.github.com/Srfigie/77b5c15bc5eb61733a74d34d10b3ed87) which has common file types in Unity projects. You may have to add more file types to make your project more compatible with the file types you work with.

7. Commit the changes and push to GitHub<br />
  In the GitHub Desktop client, name your changes in the _Summary Required_ field. Something like "Initial Commit" would work fine. Press the _Commit to **master**_ button and wait until it processes your changes. This may take a while if you have a large Unity project. In future commits, it will not take as long as you will only be pushing new edits, not the entire project. When that has completed, click _Push origin_ to push your local changes to the GitHub cloud.
  
You are successfully uploaded your project to GitHub! **Congratulations!**

### References

**Audio**
- United States of Smash by My Hero Academia OST - (BGM)
- [Extreme Sports Mayhem by Eric Matyas](https://soundimage.org/sports/)
 
**Video**
- [Krav Maga First Steps by Krav Maga Academy](https://www.youtube.com/watch?v=K9e9OjOEFWo)
- [The Fundamentals of Krav Maga - Fighting Stance and Self Defense Tactics w/ AJ Draven by KMWKravMaga](https://www.youtube.com/watch?v=JfGPhSKMHE4)

**GameObjects / Assets**
- [Graphy - Ultimate FPS Counter - Stats Monitor & Debugger by Tayx](https://assetstore.unity.com/detail/tools/gui/graphy-ultimate-fps-counter-stats-monitor-debugger-105778)
- [FPS & Stats Monitor Simple To Advanced System Info by Burak Taban](https://assetstore.unity.com/detail/tools/gui/fps-stats-monitor-simple-to-advanced-system-info-69031)
- [FREE Bodybuilder Asset Pack by Ferocious Industries](https://assetstore.unity.com/packages/3d/props/free-bodybuilder-asset-pack-130940)
- [HQ Acoustic System by Next Level 3D](https://assetstore.unity.com/packages/3d/props/electronics/hq-acoustic-system-41886)
- [Low Poly Buildings Lite by A3D](https://assetstore.unity.com/packages/3d/environments/low-poly-buildings-lite-98836)
- [Low Poly Street Pack by DYNAMIC ART](https://assetstore.unity.com/packages/3d/environments/urban/low-poly-street-pack-67475)
- [Motion Library by Rokoko Electronics ApS](https://assetstore.unity.com/motion-library)
- [Leap Motion Unity Core Assets 4.4.0 by Ultraleap Ltd.](https://developer.leapmotion.com/unity/#5436356)
- [Oculus Integration 1.4.2 by Oculus](https://assetstore.unity.com/packages/tools/integration/oculus-integration-82022)
- [Neon Shapes by MAD Entertainment](https://assetstore.unity.com/packages/2d/textures-materials/neon-shapes-61454)
- [Sci-Fi Styled Modular Pack by karboosx](https://assetstore.unity.com/packages/3d/environments/sci-fi/sci-fi-styled-modular-pack-82913)
- [Spotlight and Structure by SpaceZeta](https://assetstore.unity.com/packages/3d/props/interior/spotlight-and-structure-141453)
- [Urban building - LemmoLab](https://assetstore.unity.com/packages/3d/props/exterior/urban-building-130318)
- [Urban Night Sky - Kendall Weaver](https://assetstore.unity.com/packages/2d/textures-materials/sky/urban-night-sky-134468)
