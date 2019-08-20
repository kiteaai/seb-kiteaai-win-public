1. Checkout 2.2_merged branch.
2. Install visual studio (2019 version works)
3. Open Project in Visual Stusio
4. Build > Clean Solution
5. Build > Build Solution
6. Relative to Projects root folder go to this path: seb-win\SebWindowsConfig\bin\Debug
7. Copy the following files:
            i. DotNetZip.dll
			ii. Fleck.dll
			iii. IconLib.dll
			iv. Ionic.Zip.dll
			v. KiteConfigToolexe
			vi. KiteStudentPortal.exe
			vii. MetroFramework.dll
			viii. NAudio.dll
			ix. Newtonsoft.json.dll
			x. SEBWindowsServiceContracts.dll
	Go to de folder in the same path and copy this file: 
	        i. KiteStudentPortal.resources.dll
			
8. Go to seb-win\SebRegistryResetter\bin\Debug and copy these files:
            i. SEBRegistryResetter.exe
			ii. SEBWindowsServiceContracts.dll
			iii. SEBWindowsServiceWCF.exe
Note: Files under SEBWindowsBrowser only need to be copied if there are any changes made in that folder.		
9. Copy and paste all these files in the corresponding location for Installshield to pick up and create the msi. 
(Currently in Build server they are under C:\Kite-Seb-installer-files\Kite Student Portal and C:\Kite-Seb-installer-files\PLTW Kite Student Portal respectively)
Note: Included PLTWKiteSafeExamBrowser.ism and KiteSafeExamBrowser.ism files, which can be opened in installshield 2018 and you will have the setup to build in installshield.
10. The code checked in builds PLTW version by default. Check PLTWChanges.txt in the source folder to know how to build Kite version of the application.
11. To build exe: Go to Installation Designer > Redistributables and select Microsoft .Net Framework 4.5 Full.
12. To building MSI, uncheck the step 11 and it will use dotNetFx45_Full_setup.exe file which is included in the files used by installshield. Check MSI in Project Assistant > Build Installation tab.
13. All the setup required will be already set when you open the above (Step 9 note) ism files to build the msi and exe.
14. Check the version and Help url in Installation Designer > General tab every time you do a build. These sometime get reset.