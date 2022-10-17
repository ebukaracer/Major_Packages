# Setup Guide:
This is a detailed guide explaining how to add a **reference** of any of the [listed packages](https://github.com/ebukaracer/Major_Packages/blob/main/README.md#available-packages) to your project. In this guide, I used the `Save Manager` package as example, this is applicable to all the packages as well.



- **Add Package Reference:**
	- *Note that If you are not using an **assembly definition asset** in your project, you can skip this step.*
	  <br>
 	  <img src="https://i.ibb.co/mJMhLDT/Img2.png">
	  </br>
	
	 - After you have imported this package, you need to add its reference in your project:
	
	- In your project's **Assembly Definition Asset** file, under **Assembly Definition References** click the **(+)** icon and add a `SaveManager` reference, then apply changes below.
	  <br>
 	  <img src="https://i.ibb.co/x2dW75C/Img1.png">
	  </br>


- **Configure Console Logs:**
	-  Log messages issued from this package may also not appear without explicitly enabling them.
	
	- Open up your **Project Settings** > **Player** > **Other Settings** > **Scripting Define Symbols**, click the **(+)** icon trice and add `ENABLE_LOG` | `ENABLE_LOG_WARNING` | `ENABLE_LOG_ERROR` for each entry:
	  <br>
 	  <img src="https://i.ibb.co/4Jsn75m/Img3.png">
	  </br>
	
	- Be sure to **Clear** the added entries above when you're set to build your project.


- **Calling APIs:**
	- Once the above steps are properly setup, you're ready to start calling this package's APIs.
	
	- Also, make sure to add the **using statement**: `using Racer.SaveManager;` to any underlying class calling any of this package's APIs. 
	
	-  *Though, the **Demo Scene** contained in this package will probably walk you through, if carefully reviewed.*
	
	-  *Once you're comfortable using this package, you can **delete** the **Demo Scene** or **omit** importing it into another project.*


- **Useful Resources:**
	- Check out unity's [playerpref](https://bit.ly/2GIeZtQ), since this package is kind of a build up of it.
	- Learn more about [asmdef](https://bit.ly/3exDWNz) files.
	- Learn more about [Scripting Define Symbols](https://bit.ly/3yGVWvS).
