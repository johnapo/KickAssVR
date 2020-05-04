# **KickAssVR Self-Defense Educational VR Simulation**
## Central Michigan University Computer Science Department

KickAssVR is a simulation designed to teach users self-defense. With realistic training and a user-friendly guide, we aim to help users learn how to defend themselves. Although the chances of being in a scenario where you may need self-defense is low, self-defense is an important skill to have. Our goal is to enable users to learn self-defense even if they can’t attend classes. We plan to provide convenient access to self-defense training courses for our users with an added bonus of realistic gameplay without the need for hand controllers.

### Getting Started
**_Must have Oculus Rift, Rift S and Leap Motion Controller to play_**
1. Make sure your PC meets the minimum system requirements<br />
    - Intel Core i5-4950/AMD Ryzen 5 1500X CPU
    - Nvidia GTX 970/1060 or AMD Radeon R9 290/RX 480
    - 8GB of RAM
    - Four USB 3.0 ports (two for Oculus Sensors, one for Oculus VR headset, and one for Leap Motion Controller)
    - HDMI 1.3 port

2. Download and install the latest versions of Oculus VR & Leap Motion Windows VR software<br />
    - [Oculus VR Software](https://www.oculus.com/setup/#rift-s-setup)
    - [Leap Motion Windows VR Software](https://developer.leapmotion.com/vr-setup)

3. [Configure Oculus VR headset](https://www.pcmag.com/how-to/how-to-set-up-the-oculus-rift)<br />

4. [Configure Leap Motion Controller](https://developer.leapmotion.com/vr-setup/oculusrift)<br />

5. Download & Play!
  Download the build folder and double click the executable. Put the headset on and you are ready to learn self defense in KickAssVR!

### Acknowledgments
Author:
John Apo (johnapo)

Advisor:
Dr. Alex Redei (asmalex)

Contributors:
    - Nathan Berman (bermannathan)
    - Tristen Delmotte (tristdelm)
    - Ian Duval (ClassyDuval)
    - Jestin Griffes (jestin44)
    - Damon Rubley (ruble1dl)

Compatible with:
    - Unity 2019.2.9f1
    - Oculus Rift 1.43
    - Leap Motion 4.0.0
*No other versions have been tested and are therefore not supported*

#### Developer's Guide to Using GitHub, Git Large File Storage (LFS) with Unity
1. Download and install the following resources, and create an account on GitHub
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

COMING SOON
